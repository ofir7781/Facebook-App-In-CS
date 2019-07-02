using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FBApp.UI
{
    public partial class FormLogin : Form
    {
        private const string k_AppId = "2079856225613855";
        private AppSettings m_AppSettings;

        public User LoggedInUser { get; private set; } = new User();

        public FormLogin()
        {
            InitializeComponent();
            m_AppSettings = AppSettings.Instance;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInitialize();
        }

        private void loginAndInitialize()
        {
            LoginResult LoggedInUserResult = FacebookService.Login(
                k_AppId,
                "public_profile",
                "user_friends",
                "user_events",
                "user_likes",
                "user_photos",
                "user_posts",
                "manage_pages",
                "publish_pages",
                "email");
            if (!string.IsNullOrEmpty(LoggedInUserResult.AccessToken))
            {
                LoggedInUser = LoggedInUserResult.LoggedInUser;
                if (checkBoxRememberMe.Checked == true)
                {
                    m_AppSettings.RememberMe = checkBoxRememberMe.Checked;
                    m_AppSettings.LastAccessToken = LoggedInUserResult.AccessToken;
                    m_AppSettings.SaveToFile();
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                try
                {
                    MessageBox.Show(LoggedInUserResult.ErrorMessage);
                }
                catch (Exception)
                {
                    // this is in case LoggedInUserResult.ErrorMessage failed
                    MessageBox.Show("Error, unable to login");
                }
            }
        }
    }
}