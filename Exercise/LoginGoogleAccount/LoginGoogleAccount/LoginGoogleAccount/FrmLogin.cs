using Newtonsoft.Json;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Oauth2.v2.Data;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace LoginGoogleAccount
{
    public partial class FrmLogin : Form
    {
        static string[] Scopes = { Oauth2Service.Scope.UserinfoEmail, Oauth2Service.Scope.UserinfoProfile };
        static string ApplicationName = "Neko";
        private static FrmLogin _defaultInstance;

        public static FrmLogin Default
        {
            get
            {
                if (_defaultInstance == null || _defaultInstance.IsDisposed)
                {
                    _defaultInstance = new FrmLogin();
                }
                return _defaultInstance;
            }
            set => _defaultInstance = value;
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this);
            guna2ShadowForm1.SetShadowForm(this);
            client = new FireSharp.FirebaseClient(ifc);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btn_LoginGoogle_Click(object sender, EventArgs e)
        {
            bool loginSuccess = await GoogleLogin();
            if (loginSuccess)
            {
                MessageBox.Show("Welcome!");
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.");
            }
        }

        private async Task<bool> GoogleLogin()
        {
            UserCredential credential;
            var clientSecrets = new ClientSecrets
            {
                ClientId = "38250210888-tcoufrdv7qpni08rll8710nqvqvupnv3.apps.googleusercontent.com",
                ClientSecret = "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"
            };

            // Đường dẫn tới thư mục AppData
            string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NekoGoogleLogin");

            try
            {
                // Tạo thư mục nếu không tồn tại
                Directory.CreateDirectory(credPath);

                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));

                // Xác định đường dẫn file token mặc định
                string tokenFilePath = Path.Combine(credPath, "Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");

                // Kiểm tra nếu token đã được lưu thành công
                if (File.Exists(tokenFilePath))
                {
                    MessageBox.Show($"Token saved successfully at: {tokenFilePath}");
                }
                else
                {
                    MessageBox.Show("Token save failed.");
                    return false;
                }

                // Đăng nhập thành công, lấy thông tin người dùng
                var service = new Oauth2Service(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                var userInfo = service.Userinfo.Get().Execute();
                UpdateUIAfterLogin(userInfo);

                // Kiểm tra xem người dùng đã tồn tại trong Firebase chưa
                FirebaseResponse response = await client.GetAsync("Users/" + userInfo.Id);
                NekoUser existingUser = response.ResultAs<NekoUser>();

                if (existingUser == null)
                {
                    // Người dùng chưa tồn tại, lưu thông tin vào Firebase
                    NekoUser user = new NekoUser()
                    {
                        Username = userInfo.Id,
                        Fullname = userInfo.Name,
                        Email = userInfo.Email,
                        Gender = userInfo.Gender, // Lưu ý: Giới tính có thể không được trả về bởi Google API
                        Position = "Google User"
                    };

                    SetResponse set = await client.SetAsync("Users/" + userInfo.Id, user);
                    if (set.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to save user info to database.");
                        return false;
                    }
                }
                else
                {
                    // Người dùng đã tồn tại
                    MessageBox.Show("User already exists in the database.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}");
                return false;
            }
        }

        private void UpdateUIAfterLogin(Userinfo userInfo)
        {
            // Ẩn nút đăng nhập sau khi đăng nhập thành công
            btn_LoginGoogle.Visible = false;

            // Hiển thị thông tin người dùng
            // Hiển thị hoặc kích hoạt các phần khác của ứng dụng
            // ...
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            LogoutGoogle();
        }

        private void LogoutGoogle()
        {
            string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NekoGoogleLogin");
            string tokenFilePath = Path.Combine(credPath, "Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");

            if (File.Exists(tokenFilePath))
            {
                try
                {
                    File.Delete(tokenFilePath); // Xóa file token chính xác
                    MessageBox.Show($"Token file deleted from: {tokenFilePath}");
                    MessageBox.Show("See you again!"); // Thông báo đăng xuất thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while logging out: {ex.Message}"); // Thông báo lỗi nếu xảy ra lỗi trong quá trình xóa
                }
            }
            else
            {
                MessageBox.Show("No login session found."); // Thông báo nếu file không tồn tại
            }
        }
    }

}
