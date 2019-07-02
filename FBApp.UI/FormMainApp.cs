using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBApp.Features;

namespace FBApp.UI
{
    public partial class FormMainApp : Form
    {
        private FormLogin m_FormLogin;
        private User m_LoggedInUser;
        private AppSettings m_AppSettings = AppSettings.Instance;
        private FormMainAppFacade m_FormMainAppFacade;

        public FormMainApp()
        {
            InitializeComponent();
        }

        private void FormMainApp_Load(object sender, EventArgs e)
        {
            m_AppSettings.LoadFromFile();

            // if user clicked "Remember Me" check box, we connect him directly to the main application
            if (m_AppSettings.RememberMe == true)
            {
                try
                {
                    connectToRememberdUser();
                }
                catch (Exception)
                {
                    // if it was failed, we go to login screen regulary
                    loadLoginScreen();
                }
            }
            else
            {   // go to login screen because the check box was not selected
                loadLoginScreen();
            }
        }

        private void loadMainAppFeatures()
        {
            try
            {
                if (m_LoggedInUser != null)
                {
                    m_FormMainAppFacade = new FormMainAppFacade(m_LoggedInUser);
                    this.Text = string.Format("Logged in as {0}", m_LoggedInUser.Name);
                    pictureBoxUserProfile.LoadAsync(m_LoggedInUser.PictureLargeURL);
                    new Thread(fetchBasicUserInfoAndFillLabels).Start();
                    new Thread(fetchTimelinePosts).Start();
                    new Thread(fetchUserAlbums).Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Unable to load application features\n{0}", e.Message));

                // force cookies deletion, restore default settings and killing the app
                FacebookService.Logout(null);
                m_AppSettings.RestoreDefault();
                m_AppSettings.SaveToFile();
                Process.GetCurrentProcess().Kill();
            }
        }

        private void fetchBasicUserInfoAndFillLabels()
        {
            try
            {
                if (!string.IsNullOrEmpty(m_LoggedInUser.Name))
                {
                    labelFullName.Invoke(new Action(() => labelFullName.Text = m_LoggedInUser.Name));
                }

                if (!string.IsNullOrEmpty(m_LoggedInUser.Birthday))
                {
                    labelBirthday.Invoke(new Action(() => labelBirthday.Text = m_LoggedInUser.Birthday));
                }

                switch (m_LoggedInUser.Gender)
                {
                    case User.eGender.female:
                        labelGender.Invoke(new Action(() => labelGender.Text = "Female"));
                        break;
                    case User.eGender.male:
                        labelGender.Invoke(new Action(() => labelGender.Text = "Male"));
                        break;
                }

                if (!string.IsNullOrEmpty(m_LoggedInUser.Email))
                {
                    labelEmail.Invoke(new Action(() => labelEmail.Text = m_LoggedInUser.Email));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, could not retrieve basic user info");
            }
        }

        private void fetchUserAlbums()
        {
            if (m_LoggedInUser.Albums.Count == 0)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("The user has no available Albums to show")));
            }
            else
            {
                albumBindingSource.DataSource = m_LoggedInUser.Albums;
            }
        }

        private void fetchTimelinePosts()
        {
            List<Post> userPosts = m_FormMainAppFacade.GetAllUserPosts();
            foreach (Post post in userPosts)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format(
                    "{0} | {1} | {2} | Likes: {3} | Comments: {4} |",
                    post.UpdateTime.ToString(),
                    post.Type,
                    post.Message,
                    post.LikedBy.Count,
                    post.Comments.Count))));
            }
        } 

        private void loadLoginScreen()
        {
            if (m_FormLogin == null)
            {
                m_FormLogin = new FormLogin();
            }

            m_FormLogin.ShowDialog();
            if (m_FormLogin.DialogResult == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                clearAllData();
                m_LoggedInUser = m_FormLogin.LoggedInUser;
                this.Show();
                loadMainAppFeatures();
                this.Cursor = Cursors.Default;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void connectToRememberdUser()
        {
            m_LoggedInUser = FacebookService.Connect(m_AppSettings.LastAccessToken).LoggedInUser;
            this.Invoke(new Action(() => this.Show()));
            loadMainAppFeatures();
        }

        protected override CreateParams CreateParams
        {
            // this method fixes flickering bug with tabs
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.Logout(null);
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Error, unable to logout");
                Environment.Exit(0);
            }

            m_AppSettings.RestoreDefault();
            m_AppSettings.SaveToFile();
            loadLoginScreen();
        }

        private void clearAllData()
        {
            labelFullName.Text = "Name N/A";
            labelBirthday.Text = "Birthday N/A";
            labelGender.Text = "Gender N/A";
            labelEmail.Text = "Email N/A";
            pictureBoxUserProfile.Image = null;
            listBoxPosts.Items.Clear();
            textBoxStatusSearch.Clear();
            listBoxStatusSearch.Items.Clear();
            richTextBoxStatusAnalyzer.Clear();
            buttonThankTheUserWhoLikedYouTheMost.Enabled = false;
            tabControl.SelectedIndex = 0;
            m_FormMainAppFacade = null;
            m_LoggedInUser = null;
        }

        private void FormMainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_AppSettings.RememberMe == false && m_LoggedInUser != null)
            {
                // force cookies deletion incase RememberMe was false
                FacebookService.Logout(null);
            }
        }

        private void pictureBoxUserProfile_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBoxUserProfile_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBoxUserProfile_Click(object sender, EventArgs e)
        {
            enlargePictureInANewForm(this.m_LoggedInUser.PictureLargeURL);
        }

        private void enlargePictureInANewForm(string i_LargePictureURL)
        {
            // dynamically create the picturebox
            PictureBox largePicture = new PictureBox();
            largePicture.ImageLocation = i_LargePictureURL;
            largePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            largePicture.Dock = DockStyle.Fill;

            // dynamically Create the form
            Form profilePictureForm = new Form();
            profilePictureForm.MaximizeBox = false;
            profilePictureForm.MinimizeBox = false;
            profilePictureForm.Icon = this.Icon;
            profilePictureForm.Height = 600;
            profilePictureForm.Width = 600;
            profilePictureForm.StartPosition = FormStartPosition.CenterScreen;
            profilePictureForm.Text = string.Empty;
            profilePictureForm.Controls.Add(largePicture);
            profilePictureForm.ShowDialog();
        }

        private void buttonPostToTimeline_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTimelinePost.Text))
            {
                if (textBoxTimelinePost.Text != "What's on your mind?")
                {
                    try
                    {
                        m_FormMainAppFacade.PostStatus(textBoxTimelinePost.Text);
                        MessageBox.Show("Posted successfully to Timeline");
                        listBoxPosts.Items.Clear();
                        m_LoggedInUser.ReFetch();
                        fetchTimelinePosts();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error, unable to make a post");
                    }
                }
                else
                {
                    MessageBox.Show("Enter text to make a post");
                }
            }
            else
            {
                MessageBox.Show("Can't make empty post!");
            }

            textBoxTimelinePost.Text = "What's on your mind?";
        }

        private void textBoxTimelinePost_Enter(object sender, EventArgs e)
        {
            textBoxTimelinePost.Text = null;
        }

        private void textBoxTimelinePost_Leave(object sender, EventArgs e)
        {
            if (buttonPostToTimeline.Focused == false)
            {
                textBoxTimelinePost.Text = "What's on your mind?";
            }
        }

        private void textBoxTimelinePost_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.IBeam;
        }

        private void textBoxTimelinePost_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            reloadAllData();
        }

        private void reloadAllData()
        {
            User loggedInUserSaver = m_LoggedInUser;
            clearAllData();
            m_LoggedInUser = loggedInUserSaver;
            loadMainAppFeatures();
        }

        private void buttonStatusSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStatusSearch.Text) == true)
            {
                MessageBox.Show("Can't search empty string!");
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                List<Tuple<User, Status>> allRelevantStatuses = m_FormMainAppFacade.SearchInFriendsStatuses(textBoxStatusSearch.Text);
                fillRelevantStatuses(allRelevantStatuses);
                this.Cursor = Cursors.Default;
            }
        }

        private void fillRelevantStatuses(List<Tuple<User, Status>> i_RelevantStatuses)
        {
            listBoxStatusSearch.Items.Clear();
            if (i_RelevantStatuses.Count > 0)
            {
                foreach (Tuple<User, Status> userAndStatus in i_RelevantStatuses)
                {
                    listBoxStatusSearch.Items.Add(string.Format(
                        "{0} | {1} | {2} | Likes: {3} | Comments: {4} |",
                        userAndStatus.Item2.CreatedTime.ToString(),
                        userAndStatus.Item1.Name,
                        userAndStatus.Item2.Message,
                        userAndStatus.Item2.LikedBy.Count,
                        userAndStatus.Item2.Comments.Count));
                }
            }
            else
            {
                listBoxStatusSearch.Items.Add("Nothing matched your search terms.");
            }
        }

        private void buttonShowStatusStatistics_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                richTextBoxStatusAnalyzer.Text = m_FormMainAppFacade.GetStatusAnalysis();

                if (m_FormMainAppFacade.GetTheUserWhoFollowedTheMost().Id != m_LoggedInUser.Id)
                {
                    buttonThankTheUserWhoLikedYouTheMost.Enabled = true;
                }
            }
            catch (Exception)
            {
                richTextBoxStatusAnalyzer.Text += "User has no statuses...\n";
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void buttonThankTheUserWhoLikedYouTheMost_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.PostStatus(string.Format("Thank you! {0}", m_FormMainAppFacade.GetTheUserWhoFollowedTheMost().Name), null, null, m_FormMainAppFacade.GetTheUserWhoFollowedTheMost().Id);
                MessageBox.Show("The post was successfully sent");
                buttonThankTheUserWhoLikedYouTheMost.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, unable to make a post");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedIndex >= 0)
            {
                photoBindingSource.DataSource = m_LoggedInUser.Albums[listBoxAlbums.SelectedIndex].Photos;
            }
        }

        private void imageNormalPictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imageNormalPictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void imageNormalPictureBox_Click(object sender, EventArgs e)
        {
            enlargePictureInANewForm((listBoxPhotos.SelectedItem as Photo).PictureNormalURL);
        }
    }
}