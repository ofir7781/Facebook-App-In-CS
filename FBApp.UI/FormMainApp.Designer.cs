using System.Windows.Forms;

namespace FBApp.UI
{
    public partial class FormMainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label AlnumCreatedTimeLabel;
            System.Windows.Forms.Label AlbumDescriptionLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label PhotoCreatedTimeLabel1;
            System.Windows.Forms.Label Descri;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainApp));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.tabPageStatusSearch = new System.Windows.Forms.TabPage();
            this.panelSearchInStatuses = new System.Windows.Forms.Panel();
            this.labelStatusSearch = new System.Windows.Forms.Label();
            this.buttonStatusSearch = new System.Windows.Forms.Button();
            this.listBoxStatusSearch = new System.Windows.Forms.ListBox();
            this.textBoxStatusSearch = new System.Windows.Forms.TextBox();
            this.tabPageTimelinePosts = new System.Windows.Forms.TabPage();
            this.textBoxTimelinePost = new System.Windows.Forms.TextBox();
            this.buttonPostToTimeline = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.labelChooseAlbum = new System.Windows.Forms.Label();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAlbumDetails = new System.Windows.Forms.Panel();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.countNumberOfPhotos = new System.Windows.Forms.Label();
            this.createdAlbumTimeCreated = new System.Windows.Forms.Label();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.createdTimeLabel2 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.tabPageStatusAnalyzer = new System.Windows.Forms.TabPage();
            this.panelStatusAnalyzer = new System.Windows.Forms.Panel();
            this.buttonThankTheUserWhoLikedYouTheMost = new System.Windows.Forms.Button();
            this.richTextBoxStatusAnalyzer = new System.Windows.Forms.RichTextBox();
            this.buttonShowStatusStatistics = new System.Windows.Forms.Button();
            this.buttonRefreshData = new System.Windows.Forms.Button();
            countLabel = new System.Windows.Forms.Label();
            AlnumCreatedTimeLabel = new System.Windows.Forms.Label();
            AlbumDescriptionLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            PhotoCreatedTimeLabel1 = new System.Windows.Forms.Label();
            Descri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.tabPageStatusSearch.SuspendLayout();
            this.panelSearchInStatuses.SuspendLayout();
            this.tabPageTimelinePosts.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.panelAlbumDetails.SuspendLayout();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.tabPageStatusAnalyzer.SuspendLayout();
            this.panelStatusAnalyzer.SuspendLayout();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(-1, 41);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(64, 21);
            countLabel.TabIndex = 0;
            countLabel.Text = "Photos:";
            // 
            // AlnumCreatedTimeLabel
            // 
            AlnumCreatedTimeLabel.AutoSize = true;
            AlnumCreatedTimeLabel.Location = new System.Drawing.Point(-1, 65);
            AlnumCreatedTimeLabel.Name = "AlnumCreatedTimeLabel";
            AlnumCreatedTimeLabel.Size = new System.Drawing.Size(107, 21);
            AlnumCreatedTimeLabel.TabIndex = 2;
            AlnumCreatedTimeLabel.Text = "Created Time:";
            // 
            // AlbumDescriptionLabel
            // 
            AlbumDescriptionLabel.AutoSize = true;
            AlbumDescriptionLabel.Location = new System.Drawing.Point(-1, 89);
            AlbumDescriptionLabel.Name = "AlbumDescriptionLabel";
            AlbumDescriptionLabel.Size = new System.Drawing.Size(93, 21);
            AlbumDescriptionLabel.TabIndex = 4;
            AlbumDescriptionLabel.Text = "Description:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(-1, 113);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(73, 21);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // PhotoCreatedTimeLabel1
            // 
            PhotoCreatedTimeLabel1.AutoSize = true;
            PhotoCreatedTimeLabel1.Location = new System.Drawing.Point(18, 274);
            PhotoCreatedTimeLabel1.Name = "PhotoCreatedTimeLabel1";
            PhotoCreatedTimeLabel1.Size = new System.Drawing.Size(107, 21);
            PhotoCreatedTimeLabel1.TabIndex = 0;
            PhotoCreatedTimeLabel1.Text = "Created Time:";
            // 
            // Descri
            // 
            Descri.AutoSize = true;
            Descri.Location = new System.Drawing.Point(18, 300);
            Descri.Name = "Descri";
            Descri.Size = new System.Drawing.Size(93, 21);
            Descri.TabIndex = 4;
            Descri.Text = "Description:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogout.Location = new System.Drawing.Point(864, 11);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(125, 37);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUserProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(135, 141);
            this.pictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserProfile.TabIndex = 2;
            this.pictureBoxUserProfile.TabStop = false;
            this.pictureBoxUserProfile.Click += new System.EventHandler(this.pictureBoxUserProfile_Click);
            this.pictureBoxUserProfile.MouseEnter += new System.EventHandler(this.pictureBoxUserProfile_MouseEnter);
            this.pictureBoxUserProfile.MouseLeave += new System.EventHandler(this.pictureBoxUserProfile_MouseLeave);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFullName.Location = new System.Drawing.Point(153, 24);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(115, 29);
            this.labelFullName.TabIndex = 5;
            this.labelFullName.Text = "Name N/A";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGender.Location = new System.Drawing.Point(153, 82);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(129, 29);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Gender N/A";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Location = new System.Drawing.Point(153, 111);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(111, 29);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email N/A";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthday.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBirthday.Location = new System.Drawing.Point(153, 53);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(140, 29);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthday N/A";
            // 
            // tabPageStatusSearch
            // 
            this.tabPageStatusSearch.BackColor = System.Drawing.Color.White;
            this.tabPageStatusSearch.Controls.Add(this.panelSearchInStatuses);
            this.tabPageStatusSearch.Location = new System.Drawing.Point(4, 30);
            this.tabPageStatusSearch.Name = "tabPageStatusSearch";
            this.tabPageStatusSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatusSearch.Size = new System.Drawing.Size(986, 466);
            this.tabPageStatusSearch.TabIndex = 5;
            this.tabPageStatusSearch.Text = "Status Search";
            // 
            // panelSearchInStatuses
            // 
            this.panelSearchInStatuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchInStatuses.Controls.Add(this.labelStatusSearch);
            this.panelSearchInStatuses.Controls.Add(this.buttonStatusSearch);
            this.panelSearchInStatuses.Controls.Add(this.listBoxStatusSearch);
            this.panelSearchInStatuses.Controls.Add(this.textBoxStatusSearch);
            this.panelSearchInStatuses.Location = new System.Drawing.Point(12, 19);
            this.panelSearchInStatuses.Name = "panelSearchInStatuses";
            this.panelSearchInStatuses.Size = new System.Drawing.Size(961, 403);
            this.panelSearchInStatuses.TabIndex = 0;
            // 
            // labelStatusSearch
            // 
            this.labelStatusSearch.AutoSize = true;
            this.labelStatusSearch.Location = new System.Drawing.Point(11, 33);
            this.labelStatusSearch.Name = "labelStatusSearch";
            this.labelStatusSearch.Size = new System.Drawing.Size(424, 21);
            this.labelStatusSearch.TabIndex = 3;
            this.labelStatusSearch.Text = "Enter the string you wish to search in your friends statuses:";
            // 
            // buttonStatusSearch
            // 
            this.buttonStatusSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonStatusSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStatusSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatusSearch.Location = new System.Drawing.Point(814, 66);
            this.buttonStatusSearch.Name = "buttonStatusSearch";
            this.buttonStatusSearch.Size = new System.Drawing.Size(125, 36);
            this.buttonStatusSearch.TabIndex = 2;
            this.buttonStatusSearch.Text = "Search";
            this.buttonStatusSearch.UseVisualStyleBackColor = false;
            this.buttonStatusSearch.Click += new System.EventHandler(this.buttonStatusSearch_Click);
            // 
            // listBoxStatusSearch
            // 
            this.listBoxStatusSearch.FormattingEnabled = true;
            this.listBoxStatusSearch.ItemHeight = 21;
            this.listBoxStatusSearch.Location = new System.Drawing.Point(15, 124);
            this.listBoxStatusSearch.Name = "listBoxStatusSearch";
            this.listBoxStatusSearch.Size = new System.Drawing.Size(931, 214);
            this.listBoxStatusSearch.TabIndex = 1;
            // 
            // textBoxStatusSearch
            // 
            this.textBoxStatusSearch.Location = new System.Drawing.Point(15, 74);
            this.textBoxStatusSearch.Name = "textBoxStatusSearch";
            this.textBoxStatusSearch.Size = new System.Drawing.Size(783, 28);
            this.textBoxStatusSearch.TabIndex = 0;
            // 
            // tabPageTimelinePosts
            // 
            this.tabPageTimelinePosts.AutoScroll = true;
            this.tabPageTimelinePosts.BackColor = System.Drawing.Color.White;
            this.tabPageTimelinePosts.Controls.Add(this.textBoxTimelinePost);
            this.tabPageTimelinePosts.Controls.Add(this.buttonPostToTimeline);
            this.tabPageTimelinePosts.Controls.Add(this.listBoxPosts);
            this.tabPageTimelinePosts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageTimelinePosts.Location = new System.Drawing.Point(4, 30);
            this.tabPageTimelinePosts.Name = "tabPageTimelinePosts";
            this.tabPageTimelinePosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimelinePosts.Size = new System.Drawing.Size(986, 466);
            this.tabPageTimelinePosts.TabIndex = 0;
            this.tabPageTimelinePosts.Text = "Timeline Posts";
            // 
            // textBoxTimelinePost
            // 
            this.textBoxTimelinePost.Location = new System.Drawing.Point(12, 19);
            this.textBoxTimelinePost.Multiline = true;
            this.textBoxTimelinePost.Name = "textBoxTimelinePost";
            this.textBoxTimelinePost.Size = new System.Drawing.Size(829, 87);
            this.textBoxTimelinePost.TabIndex = 0;
            this.textBoxTimelinePost.Text = "What\'s on your mind?";
            this.textBoxTimelinePost.Enter += new System.EventHandler(this.textBoxTimelinePost_Enter);
            this.textBoxTimelinePost.Leave += new System.EventHandler(this.textBoxTimelinePost_Leave);
            this.textBoxTimelinePost.MouseEnter += new System.EventHandler(this.textBoxTimelinePost_MouseEnter);
            this.textBoxTimelinePost.MouseLeave += new System.EventHandler(this.textBoxTimelinePost_MouseLeave);
            // 
            // buttonPostToTimeline
            // 
            this.buttonPostToTimeline.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonPostToTimeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPostToTimeline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPostToTimeline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPostToTimeline.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPostToTimeline.Location = new System.Drawing.Point(848, 46);
            this.buttonPostToTimeline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostToTimeline.Name = "buttonPostToTimeline";
            this.buttonPostToTimeline.Size = new System.Drawing.Size(125, 37);
            this.buttonPostToTimeline.TabIndex = 0;
            this.buttonPostToTimeline.Tag = string.Empty;
            this.buttonPostToTimeline.Text = "Post Status";
            this.buttonPostToTimeline.UseVisualStyleBackColor = false;
            this.buttonPostToTimeline.Click += new System.EventHandler(this.buttonPostToTimeline_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 21;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 124);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(961, 277);
            this.listBoxPosts.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTimelinePosts);
            this.tabControl.Controls.Add(this.tabPageAlbums);
            this.tabControl.Controls.Add(this.tabPageStatusSearch);
            this.tabControl.Controls.Add(this.tabPageStatusAnalyzer);
            this.tabControl.Location = new System.Drawing.Point(12, 169);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(994, 500);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Controls.Add(this.labelChooseAlbum);
            this.tabPageAlbums.Controls.Add(this.listBoxPhotos);
            this.tabPageAlbums.Controls.Add(this.listBoxAlbums);
            this.tabPageAlbums.Controls.Add(this.panelAlbumDetails);
            this.tabPageAlbums.Controls.Add(this.panelAlbums);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 30);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbums.Size = new System.Drawing.Size(986, 466);
            this.tabPageAlbums.TabIndex = 7;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // labelChooseAlbum
            // 
            this.labelChooseAlbum.AutoSize = true;
            this.labelChooseAlbum.BackColor = System.Drawing.Color.White;
            this.labelChooseAlbum.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseAlbum.Location = new System.Drawing.Point(15, 19);
            this.labelChooseAlbum.Name = "labelChooseAlbum";
            this.labelChooseAlbum.Size = new System.Drawing.Size(162, 29);
            this.labelChooseAlbum.TabIndex = 5;
            this.labelChooseAlbum.Text = "Choose Album:";
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPhotos.DataSource = this.photoBindingSource;
            this.listBoxPhotos.DisplayMember = "Name";
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.ItemHeight = 21;
            this.listBoxPhotos.Location = new System.Drawing.Point(341, 20);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(176, 401);
            this.listBoxPhotos.TabIndex = 4;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 21;
            this.listBoxAlbums.Location = new System.Drawing.Point(12, 54);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(320, 172);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // panelAlbumDetails
            // 
            this.panelAlbumDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlbumDetails.Controls.Add(this.locationLabel1);
            this.panelAlbumDetails.Controls.Add(locationLabel);
            this.panelAlbumDetails.Controls.Add(this.descriptionLabel1);
            this.panelAlbumDetails.Controls.Add(AlbumDescriptionLabel);
            this.panelAlbumDetails.Controls.Add(countLabel);
            this.panelAlbumDetails.Controls.Add(this.countNumberOfPhotos);
            this.panelAlbumDetails.Controls.Add(this.createdAlbumTimeCreated);
            this.panelAlbumDetails.Controls.Add(AlnumCreatedTimeLabel);
            this.panelAlbumDetails.Location = new System.Drawing.Point(12, 236);
            this.panelAlbumDetails.Name = "panelAlbumDetails";
            this.panelAlbumDetails.Size = new System.Drawing.Size(320, 185);
            this.panelAlbumDetails.TabIndex = 3;
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Location", true));
            this.locationLabel1.Location = new System.Drawing.Point(111, 113);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(208, 23);
            this.locationLabel1.TabIndex = 9;
            this.locationLabel1.Text = "Location";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(110, 88);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(209, 23);
            this.descriptionLabel1.TabIndex = 5;
            this.descriptionLabel1.Text = "Description";
            // 
            // countNumberOfPhotos
            // 
            this.countNumberOfPhotos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true));
            this.countNumberOfPhotos.Location = new System.Drawing.Point(110, 41);
            this.countNumberOfPhotos.Name = "countNumberOfPhotos";
            this.countNumberOfPhotos.Size = new System.Drawing.Size(209, 23);
            this.countNumberOfPhotos.TabIndex = 1;
            this.countNumberOfPhotos.Text = "Count";
            // 
            // createdAlbumTimeCreated
            // 
            this.createdAlbumTimeCreated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.createdAlbumTimeCreated.Location = new System.Drawing.Point(109, 65);
            this.createdAlbumTimeCreated.Name = "createdAlbumTimeCreated";
            this.createdAlbumTimeCreated.Size = new System.Drawing.Size(210, 23);
            this.createdAlbumTimeCreated.TabIndex = 3;
            this.createdAlbumTimeCreated.Text = "Created Time";
            // 
            // panelAlbums
            // 
            this.panelAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlbums.Controls.Add(PhotoCreatedTimeLabel1);
            this.panelAlbums.Controls.Add(this.createdTimeLabel2);
            this.panelAlbums.Controls.Add(this.imageNormalPictureBox);
            this.panelAlbums.Controls.Add(Descri);
            this.panelAlbums.Controls.Add(this.nameLabel1);
            this.panelAlbums.Location = new System.Drawing.Point(526, 20);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(447, 401);
            this.panelAlbums.TabIndex = 2;
            // 
            // createdTimeLabel2
            // 
            this.createdTimeLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "CreatedTime", true));
            this.createdTimeLabel2.Location = new System.Drawing.Point(137, 274);
            this.createdTimeLabel2.Name = "createdTimeLabel2";
            this.createdTimeLabel2.Size = new System.Drawing.Size(305, 23);
            this.createdTimeLabel2.TabIndex = 1;
            this.createdTimeLabel2.Text = "Photo Created Time";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(22, 12);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(401, 251);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            this.imageNormalPictureBox.Click += new System.EventHandler(this.imageNormalPictureBox_Click);
            this.imageNormalPictureBox.MouseEnter += new System.EventHandler(this.imageNormalPictureBox_MouseEnter);
            this.imageNormalPictureBox.MouseLeave += new System.EventHandler(this.imageNormalPictureBox_MouseLeave);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(137, 301);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(305, 23);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "Message";
            // 
            // tabPageStatusAnalyzer
            // 
            this.tabPageStatusAnalyzer.Controls.Add(this.panelStatusAnalyzer);
            this.tabPageStatusAnalyzer.Location = new System.Drawing.Point(4, 30);
            this.tabPageStatusAnalyzer.Name = "tabPageStatusAnalyzer";
            this.tabPageStatusAnalyzer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatusAnalyzer.Size = new System.Drawing.Size(986, 466);
            this.tabPageStatusAnalyzer.TabIndex = 6;
            this.tabPageStatusAnalyzer.Text = "Status Analyzer";
            this.tabPageStatusAnalyzer.UseVisualStyleBackColor = true;
            // 
            // panelStatusAnalyzer
            // 
            this.panelStatusAnalyzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatusAnalyzer.Controls.Add(this.buttonThankTheUserWhoLikedYouTheMost);
            this.panelStatusAnalyzer.Controls.Add(this.richTextBoxStatusAnalyzer);
            this.panelStatusAnalyzer.Controls.Add(this.buttonShowStatusStatistics);
            this.panelStatusAnalyzer.Location = new System.Drawing.Point(12, 19);
            this.panelStatusAnalyzer.Name = "panelStatusAnalyzer";
            this.panelStatusAnalyzer.Size = new System.Drawing.Size(961, 403);
            this.panelStatusAnalyzer.TabIndex = 0;
            // 
            // buttonThankTheUserWhoLikedYouTheMost
            // 
            this.buttonThankTheUserWhoLikedYouTheMost.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonThankTheUserWhoLikedYouTheMost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonThankTheUserWhoLikedYouTheMost.Enabled = false;
            this.buttonThankTheUserWhoLikedYouTheMost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThankTheUserWhoLikedYouTheMost.Location = new System.Drawing.Point(756, 211);
            this.buttonThankTheUserWhoLikedYouTheMost.Name = "buttonThankTheUserWhoLikedYouTheMost";
            this.buttonThankTheUserWhoLikedYouTheMost.Size = new System.Drawing.Size(190, 53);
            this.buttonThankTheUserWhoLikedYouTheMost.TabIndex = 2;
            this.buttonThankTheUserWhoLikedYouTheMost.Text = "Thank The User Who Liked You The Most";
            this.buttonThankTheUserWhoLikedYouTheMost.UseVisualStyleBackColor = false;
            this.buttonThankTheUserWhoLikedYouTheMost.Click += new System.EventHandler(this.buttonThankTheUserWhoLikedYouTheMost_Click);
            // 
            // richTextBoxStatusAnalyzer
            // 
            this.richTextBoxStatusAnalyzer.Location = new System.Drawing.Point(15, 16);
            this.richTextBoxStatusAnalyzer.Name = "richTextBoxStatusAnalyzer";
            this.richTextBoxStatusAnalyzer.Size = new System.Drawing.Size(725, 369);
            this.richTextBoxStatusAnalyzer.TabIndex = 1;
            this.richTextBoxStatusAnalyzer.Text = string.Empty;
            // 
            // buttonShowStatusStatistics
            // 
            this.buttonShowStatusStatistics.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonShowStatusStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonShowStatusStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowStatusStatistics.Location = new System.Drawing.Point(756, 118);
            this.buttonShowStatusStatistics.Name = "buttonShowStatusStatistics";
            this.buttonShowStatusStatistics.Size = new System.Drawing.Size(190, 53);
            this.buttonShowStatusStatistics.TabIndex = 0;
            this.buttonShowStatusStatistics.Text = "Show Status Statistics";
            this.buttonShowStatusStatistics.UseVisualStyleBackColor = false;
            this.buttonShowStatusStatistics.Click += new System.EventHandler(this.buttonShowStatusStatistics_Click);
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRefreshData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRefreshData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefreshData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRefreshData.Location = new System.Drawing.Point(733, 11);
            this.buttonRefreshData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(125, 37);
            this.buttonRefreshData.TabIndex = 1;
            this.buttonRefreshData.Text = "Refresh Data";
            this.buttonRefreshData.UseVisualStyleBackColor = false;
            this.buttonRefreshData.Click += new System.EventHandler(this.buttonRefreshData_Click);
            // 
            // FormMainApp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 729);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.buttonRefreshData);
            this.Controls.Add(this.buttonLogout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainApp";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainApp_FormClosing);
            this.Load += new System.EventHandler(this.FormMainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.tabPageStatusSearch.ResumeLayout(false);
            this.panelSearchInStatuses.ResumeLayout(false);
            this.panelSearchInStatuses.PerformLayout();
            this.tabPageTimelinePosts.ResumeLayout(false);
            this.tabPageTimelinePosts.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageAlbums.ResumeLayout(false);
            this.tabPageAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.panelAlbumDetails.ResumeLayout(false);
            this.panelAlbumDetails.PerformLayout();
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.tabPageStatusAnalyzer.ResumeLayout(false);
            this.panelStatusAnalyzer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBirthday;
        private TabPage tabPageStatusSearch;
        private TabPage tabPageTimelinePosts;
        private TextBox textBoxTimelinePost;
        private Button buttonPostToTimeline;
        private ListBox listBoxPosts;
        private TabControl tabControl;
        private Button buttonRefreshData;
        private Panel panelSearchInStatuses;
        private Label labelStatusSearch;
        private Button buttonStatusSearch;
        private ListBox listBoxStatusSearch;
        private TextBox textBoxStatusSearch;
        private TabPage tabPageStatusAnalyzer;
        private Panel panelStatusAnalyzer;
        private Button buttonShowStatusStatistics;
        private RichTextBox richTextBoxStatusAnalyzer;
        private Button buttonThankTheUserWhoLikedYouTheMost;
        private TabPage tabPageAlbums;
        private ListBox listBoxAlbums;
        private Panel panelAlbums;
        private Label countNumberOfPhotos;
        private BindingSource albumBindingSource;
        private Label createdAlbumTimeCreated;
        private Label descriptionLabel1;
        private Label locationLabel1;
        private Panel panelAlbumDetails;
        private ListBox listBoxPhotos;
        private Label createdTimeLabel2;
        private BindingSource photoBindingSource;
        private PictureBox imageNormalPictureBox;
        private Label nameLabel1;
        private Label labelChooseAlbum;
    }
}