namespace PictureManagerProject
{
    partial class MediaManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaManager));
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.panelListViewPicureAfterSearch = new System.Windows.Forms.Panel();
            this.listViewSearch = new System.Windows.Forms.ListView();
            this.panelSearchOption = new System.Windows.Forms.Panel();
            this.panelSearchButtons = new System.Windows.Forms.Panel();
            this.buttonSearchAfterTag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearchOptions = new System.Windows.Forms.Panel();
            this.textBoxSearchAfterMediaLabel = new System.Windows.Forms.TextBox();
            this.SearchAfterMediaLabel = new System.Windows.Forms.Label();
            this.textBoxSearchAfterTagTypeLabel = new System.Windows.Forms.TextBox();
            this.SearchAfterTagTypeLabel = new System.Windows.Forms.Label();
            this.textBoxSearchAfterTagLabel = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.textInfo = new System.Windows.Forms.Label();
            this.SearchAfterTagLabel = new System.Windows.Forms.Label();
            this.tabPageTagsManager = new System.Windows.Forms.TabPage();
            this.tableTagsManager = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageMediaView = new System.Windows.Forms.TabPage();
            this.listViewPicsInMediaView = new System.Windows.Forms.ListView();
            this.tabPageAddMedia = new System.Windows.Forms.TabPage();
            this.panelPictureInAdding = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelButtonsInAdding = new System.Windows.Forms.Panel();
            this.flowLayoutPanelButtondInAdding = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSelectMediaInAdding = new System.Windows.Forms.Button();
            this.buttonDeleteMediaIInAdding = new System.Windows.Forms.Button();
            this.buttonEdidInformationAdding = new System.Windows.Forms.Button();
            this.panelDisplayInAdding = new System.Windows.Forms.Panel();
            this.listViewPicsInAdding = new System.Windows.Forms.ListView();
            this.dBPicturesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPicturesDataSet = new PictureManagerProject.DBPicturesDataSet();
            this.tabControlMenu.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.panelListViewPicureAfterSearch.SuspendLayout();
            this.panelSearchOption.SuspendLayout();
            this.panelSearchButtons.SuspendLayout();
            this.panelSearchOptions.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.tabPageTagsManager.SuspendLayout();
            this.tabPageMediaView.SuspendLayout();
            this.tabPageAddMedia.SuspendLayout();
            this.panelPictureInAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelButtonsInAdding.SuspendLayout();
            this.flowLayoutPanelButtondInAdding.SuspendLayout();
            this.panelDisplayInAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBPicturesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPicturesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlMenu.Controls.Add(this.tabPageSearch);
            this.tabControlMenu.Controls.Add(this.tabPageTagsManager);
            this.tabControlMenu.Controls.Add(this.tabPageMediaView);
            this.tabControlMenu.Controls.Add(this.tabPageAddMedia);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.Margin = new System.Windows.Forms.Padding(10);
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.Padding = new System.Drawing.Point(10, 10);
            this.tabControlMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlMenu.RightToLeftLayout = true;
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1082, 753);
            this.tabControlMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.tabPageSearch.Controls.Add(this.panelListViewPicureAfterSearch);
            this.tabPageSearch.Controls.Add(this.panelSearchOption);
            this.tabPageSearch.Controls.Add(this.panelTitle);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 42);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1074, 707);
            this.tabPageSearch.TabIndex = 4;
            this.tabPageSearch.Text = "SEARCH";
            // 
            // panelListViewPicureAfterSearch
            // 
            this.panelListViewPicureAfterSearch.Controls.Add(this.listViewSearch);
            this.panelListViewPicureAfterSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListViewPicureAfterSearch.Location = new System.Drawing.Point(3, 289);
            this.panelListViewPicureAfterSearch.Name = "panelListViewPicureAfterSearch";
            this.panelListViewPicureAfterSearch.Size = new System.Drawing.Size(1068, 415);
            this.panelListViewPicureAfterSearch.TabIndex = 3;
            // 
            // listViewSearch
            // 
            this.listViewSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.listViewSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSearch.HideSelection = false;
            this.listViewSearch.Location = new System.Drawing.Point(0, 0);
            this.listViewSearch.Name = "listViewSearch";
            this.listViewSearch.Size = new System.Drawing.Size(1068, 415);
            this.listViewSearch.TabIndex = 0;
            this.listViewSearch.UseCompatibleStateImageBehavior = false;
            // 
            // panelSearchOption
            // 
            this.panelSearchOption.Controls.Add(this.panelSearchButtons);
            this.panelSearchOption.Controls.Add(this.panelSearchOptions);
            this.panelSearchOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchOption.Location = new System.Drawing.Point(3, 72);
            this.panelSearchOption.Name = "panelSearchOption";
            this.panelSearchOption.Size = new System.Drawing.Size(1068, 217);
            this.panelSearchOption.TabIndex = 2;
            // 
            // panelSearchButtons
            // 
            this.panelSearchButtons.Controls.Add(this.buttonSearchAfterTag);
            this.panelSearchButtons.Controls.Add(this.label1);
            this.panelSearchButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchButtons.Location = new System.Drawing.Point(666, 0);
            this.panelSearchButtons.Margin = new System.Windows.Forms.Padding(10);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Padding = new System.Windows.Forms.Padding(75);
            this.panelSearchButtons.Size = new System.Drawing.Size(402, 217);
            this.panelSearchButtons.TabIndex = 1;
            // 
            // buttonSearchAfterTag
            // 
            this.buttonSearchAfterTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.buttonSearchAfterTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearchAfterTag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.buttonSearchAfterTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonSearchAfterTag.Location = new System.Drawing.Point(75, 75);
            this.buttonSearchAfterTag.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchAfterTag.Name = "buttonSearchAfterTag";
            this.buttonSearchAfterTag.Size = new System.Drawing.Size(252, 67);
            this.buttonSearchAfterTag.TabIndex = 3;
            this.buttonSearchAfterTag.Text = "Search";
            this.buttonSearchAfterTag.UseVisualStyleBackColor = false;
            this.buttonSearchAfterTag.Click += new System.EventHandler(this.buttonSearchAfterTag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "          ";
            // 
            // panelSearchOptions
            // 
            this.panelSearchOptions.Controls.Add(this.textBoxSearchAfterMediaLabel);
            this.panelSearchOptions.Controls.Add(this.SearchAfterMediaLabel);
            this.panelSearchOptions.Controls.Add(this.textBoxSearchAfterTagTypeLabel);
            this.panelSearchOptions.Controls.Add(this.SearchAfterTagTypeLabel);
            this.panelSearchOptions.Controls.Add(this.textBoxSearchAfterTagLabel);
            this.panelSearchOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearchOptions.Location = new System.Drawing.Point(0, 0);
            this.panelSearchOptions.Name = "panelSearchOptions";
            this.panelSearchOptions.Padding = new System.Windows.Forms.Padding(10);
            this.panelSearchOptions.Size = new System.Drawing.Size(666, 217);
            this.panelSearchOptions.TabIndex = 0;
            // 
            // textBoxSearchAfterMediaLabel
            // 
            this.textBoxSearchAfterMediaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.textBoxSearchAfterMediaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchAfterMediaLabel.Location = new System.Drawing.Point(10, 112);
            this.textBoxSearchAfterMediaLabel.Multiline = true;
            this.textBoxSearchAfterMediaLabel.Name = "textBoxSearchAfterMediaLabel";
            this.textBoxSearchAfterMediaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSearchAfterMediaLabel.Size = new System.Drawing.Size(646, 31);
            this.textBoxSearchAfterMediaLabel.TabIndex = 5;
            // 
            // SearchAfterMediaLabel
            // 
            this.SearchAfterMediaLabel.AutoSize = true;
            this.SearchAfterMediaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchAfterMediaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAfterMediaLabel.Location = new System.Drawing.Point(10, 92);
            this.SearchAfterMediaLabel.Name = "SearchAfterMediaLabel";
            this.SearchAfterMediaLabel.Size = new System.Drawing.Size(202, 20);
            this.SearchAfterMediaLabel.TabIndex = 4;
            this.SearchAfterMediaLabel.Text = "Search After Media Name";
            // 
            // textBoxSearchAfterTagTypeLabel
            // 
            this.textBoxSearchAfterTagTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.textBoxSearchAfterTagTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchAfterTagTypeLabel.Location = new System.Drawing.Point(10, 61);
            this.textBoxSearchAfterTagTypeLabel.Multiline = true;
            this.textBoxSearchAfterTagTypeLabel.Name = "textBoxSearchAfterTagTypeLabel";
            this.textBoxSearchAfterTagTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSearchAfterTagTypeLabel.Size = new System.Drawing.Size(646, 31);
            this.textBoxSearchAfterTagTypeLabel.TabIndex = 3;
            // 
            // SearchAfterTagTypeLabel
            // 
            this.SearchAfterTagTypeLabel.AutoSize = true;
            this.SearchAfterTagTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchAfterTagTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAfterTagTypeLabel.Location = new System.Drawing.Point(10, 41);
            this.SearchAfterTagTypeLabel.Name = "SearchAfterTagTypeLabel";
            this.SearchAfterTagTypeLabel.Size = new System.Drawing.Size(208, 20);
            this.SearchAfterTagTypeLabel.TabIndex = 2;
            this.SearchAfterTagTypeLabel.Text = "Search After Tag Category";
            // 
            // textBoxSearchAfterTagLabel
            // 
            this.textBoxSearchAfterTagLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.textBoxSearchAfterTagLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchAfterTagLabel.Location = new System.Drawing.Point(10, 10);
            this.textBoxSearchAfterTagLabel.Multiline = true;
            this.textBoxSearchAfterTagLabel.Name = "textBoxSearchAfterTagLabel";
            this.textBoxSearchAfterTagLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSearchAfterTagLabel.Size = new System.Drawing.Size(646, 31);
            this.textBoxSearchAfterTagLabel.TabIndex = 1;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.textInfo);
            this.panelTitle.Controls.Add(this.SearchAfterTagLabel);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(3, 3);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1068, 69);
            this.panelTitle.TabIndex = 1;
            // 
            // textInfo
            // 
            this.textInfo.AutoSize = true;
            this.textInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInfo.Location = new System.Drawing.Point(0, 0);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(227, 29);
            this.textInfo.TabIndex = 0;
            this.textInfo.Text = "Search media after";
            this.textInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchAfterTagLabel
            // 
            this.SearchAfterTagLabel.AutoSize = true;
            this.SearchAfterTagLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchAfterTagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAfterTagLabel.Location = new System.Drawing.Point(0, 49);
            this.SearchAfterTagLabel.Name = "SearchAfterTagLabel";
            this.SearchAfterTagLabel.Size = new System.Drawing.Size(136, 20);
            this.SearchAfterTagLabel.TabIndex = 0;
            this.SearchAfterTagLabel.Text = "Search After Tag";
            // 
            // tabPageTagsManager
            // 
            this.tabPageTagsManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.tabPageTagsManager.Controls.Add(this.tableTagsManager);
            this.tabPageTagsManager.Location = new System.Drawing.Point(4, 42);
            this.tabPageTagsManager.Name = "tabPageTagsManager";
            this.tabPageTagsManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTagsManager.Size = new System.Drawing.Size(1074, 707);
            this.tabPageTagsManager.TabIndex = 2;
            this.tabPageTagsManager.Text = "TAGS MANAGER";
            // 
            // tableTagsManager
            // 
            this.tableTagsManager.ColumnCount = 1;
            this.tableTagsManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTagsManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTagsManager.Location = new System.Drawing.Point(3, 3);
            this.tableTagsManager.Name = "tableTagsManager";
            this.tableTagsManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableTagsManager.RowCount = 1;
            this.tableTagsManager.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableTagsManager.Size = new System.Drawing.Size(1068, 701);
            this.tableTagsManager.TabIndex = 0;
            // 
            // tabPageMediaView
            // 
            this.tabPageMediaView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.tabPageMediaView.Controls.Add(this.listViewPicsInMediaView);
            this.tabPageMediaView.Location = new System.Drawing.Point(4, 42);
            this.tabPageMediaView.Name = "tabPageMediaView";
            this.tabPageMediaView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMediaView.Size = new System.Drawing.Size(1074, 707);
            this.tabPageMediaView.TabIndex = 1;
            this.tabPageMediaView.Text = "MEDIA VIEW";
            // 
            // listViewPicsInMediaView
            // 
            this.listViewPicsInMediaView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.listViewPicsInMediaView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPicsInMediaView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.listViewPicsInMediaView.HideSelection = false;
            this.listViewPicsInMediaView.Location = new System.Drawing.Point(3, 3);
            this.listViewPicsInMediaView.Name = "listViewPicsInMediaView";
            this.listViewPicsInMediaView.Size = new System.Drawing.Size(1068, 701);
            this.listViewPicsInMediaView.TabIndex = 0;
            this.listViewPicsInMediaView.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageAddMedia
            // 
            this.tabPageAddMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.tabPageAddMedia.Controls.Add(this.panelPictureInAdding);
            this.tabPageAddMedia.Controls.Add(this.panelButtonsInAdding);
            this.tabPageAddMedia.Controls.Add(this.panelDisplayInAdding);
            this.tabPageAddMedia.Location = new System.Drawing.Point(4, 42);
            this.tabPageAddMedia.Name = "tabPageAddMedia";
            this.tabPageAddMedia.Size = new System.Drawing.Size(1074, 707);
            this.tabPageAddMedia.TabIndex = 0;
            this.tabPageAddMedia.Text = "ADD MEDIA";
            // 
            // panelPictureInAdding
            // 
            this.panelPictureInAdding.Controls.Add(this.pictureBox1);
            this.panelPictureInAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPictureInAdding.Location = new System.Drawing.Point(0, 0);
            this.panelPictureInAdding.Name = "panelPictureInAdding";
            this.panelPictureInAdding.Padding = new System.Windows.Forms.Padding(25);
            this.panelPictureInAdding.Size = new System.Drawing.Size(647, 301);
            this.panelPictureInAdding.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 251);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelButtonsInAdding
            // 
            this.panelButtonsInAdding.Controls.Add(this.flowLayoutPanelButtondInAdding);
            this.panelButtonsInAdding.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonsInAdding.Location = new System.Drawing.Point(647, 0);
            this.panelButtonsInAdding.Name = "panelButtonsInAdding";
            this.panelButtonsInAdding.Padding = new System.Windows.Forms.Padding(25);
            this.panelButtonsInAdding.Size = new System.Drawing.Size(427, 301);
            this.panelButtonsInAdding.TabIndex = 5;
            // 
            // flowLayoutPanelButtondInAdding
            // 
            this.flowLayoutPanelButtondInAdding.Controls.Add(this.buttonSelectMediaInAdding);
            this.flowLayoutPanelButtondInAdding.Controls.Add(this.buttonDeleteMediaIInAdding);
            this.flowLayoutPanelButtondInAdding.Controls.Add(this.buttonEdidInformationAdding);
            this.flowLayoutPanelButtondInAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtondInAdding.Location = new System.Drawing.Point(25, 25);
            this.flowLayoutPanelButtondInAdding.Name = "flowLayoutPanelButtondInAdding";
            this.flowLayoutPanelButtondInAdding.Size = new System.Drawing.Size(377, 251);
            this.flowLayoutPanelButtondInAdding.TabIndex = 0;
            // 
            // buttonSelectMediaInAdding
            // 
            this.buttonSelectMediaInAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonSelectMediaInAdding.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonSelectMediaInAdding.FlatAppearance.BorderSize = 0;
            this.buttonSelectMediaInAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectMediaInAdding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.buttonSelectMediaInAdding.Location = new System.Drawing.Point(32, 5);
            this.buttonSelectMediaInAdding.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSelectMediaInAdding.Name = "buttonSelectMediaInAdding";
            this.buttonSelectMediaInAdding.Size = new System.Drawing.Size(340, 40);
            this.buttonSelectMediaInAdding.TabIndex = 2;
            this.buttonSelectMediaInAdding.Text = "SELECT MEDIA";
            this.buttonSelectMediaInAdding.UseVisualStyleBackColor = false;
            this.buttonSelectMediaInAdding.Click += new System.EventHandler(this.buttonSelectMediaInAdding_Click);
            // 
            // buttonDeleteMediaIInAdding
            // 
            this.buttonDeleteMediaIInAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonDeleteMediaIInAdding.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonDeleteMediaIInAdding.FlatAppearance.BorderSize = 0;
            this.buttonDeleteMediaIInAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMediaIInAdding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.buttonDeleteMediaIInAdding.Location = new System.Drawing.Point(32, 55);
            this.buttonDeleteMediaIInAdding.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteMediaIInAdding.Name = "buttonDeleteMediaIInAdding";
            this.buttonDeleteMediaIInAdding.Size = new System.Drawing.Size(340, 40);
            this.buttonDeleteMediaIInAdding.TabIndex = 1;
            this.buttonDeleteMediaIInAdding.Text = "DELETE";
            this.buttonDeleteMediaIInAdding.UseVisualStyleBackColor = false;
            this.buttonDeleteMediaIInAdding.Click += new System.EventHandler(this.buttonDeleteMediaIInAdding_Click);
            // 
            // buttonEdidInformationAdding
            // 
            this.buttonEdidInformationAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonEdidInformationAdding.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonEdidInformationAdding.FlatAppearance.BorderSize = 0;
            this.buttonEdidInformationAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdidInformationAdding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.buttonEdidInformationAdding.Location = new System.Drawing.Point(32, 105);
            this.buttonEdidInformationAdding.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEdidInformationAdding.Name = "buttonEdidInformationAdding";
            this.buttonEdidInformationAdding.Size = new System.Drawing.Size(340, 40);
            this.buttonEdidInformationAdding.TabIndex = 4;
            this.buttonEdidInformationAdding.Text = "EDIT INFORMATION";
            this.buttonEdidInformationAdding.UseVisualStyleBackColor = false;
            this.buttonEdidInformationAdding.Click += new System.EventHandler(this.buttonEdidInformationAdding_Click);
            // 
            // panelDisplayInAdding
            // 
            this.panelDisplayInAdding.Controls.Add(this.listViewPicsInAdding);
            this.panelDisplayInAdding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDisplayInAdding.Location = new System.Drawing.Point(0, 301);
            this.panelDisplayInAdding.Name = "panelDisplayInAdding";
            this.panelDisplayInAdding.Size = new System.Drawing.Size(1074, 406);
            this.panelDisplayInAdding.TabIndex = 6;
            // 
            // listViewPicsInAdding
            // 
            this.listViewPicsInAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.listViewPicsInAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPicsInAdding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.listViewPicsInAdding.HideSelection = false;
            this.listViewPicsInAdding.Location = new System.Drawing.Point(0, 0);
            this.listViewPicsInAdding.Name = "listViewPicsInAdding";
            this.listViewPicsInAdding.Size = new System.Drawing.Size(1074, 406);
            this.listViewPicsInAdding.TabIndex = 0;
            this.listViewPicsInAdding.UseCompatibleStateImageBehavior = false;
            // 
            // dBPicturesDataSetBindingSource
            // 
            this.dBPicturesDataSetBindingSource.DataSource = this.dBPicturesDataSet;
            this.dBPicturesDataSetBindingSource.Position = 0;
            // 
            // dBPicturesDataSet
            // 
            this.dBPicturesDataSet.DataSetName = "DBPicturesDataSet";
            this.dBPicturesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MediaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.tabControlMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaManager";
            this.Text = "MediaManager";
            this.Load += new System.EventHandler(this.MediaManager_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.panelListViewPicureAfterSearch.ResumeLayout(false);
            this.panelSearchOption.ResumeLayout(false);
            this.panelSearchButtons.ResumeLayout(false);
            this.panelSearchButtons.PerformLayout();
            this.panelSearchOptions.ResumeLayout(false);
            this.panelSearchOptions.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tabPageTagsManager.ResumeLayout(false);
            this.tabPageMediaView.ResumeLayout(false);
            this.tabPageAddMedia.ResumeLayout(false);
            this.panelPictureInAdding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelButtonsInAdding.ResumeLayout(false);
            this.flowLayoutPanelButtondInAdding.ResumeLayout(false);
            this.panelDisplayInAdding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBPicturesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPicturesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageAddMedia;
        private System.Windows.Forms.TabPage tabPageMediaView;
        private System.Windows.Forms.TabPage tabPageTagsManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDeleteMediaIInAdding;
        private System.Windows.Forms.Button buttonSelectMediaInAdding;
        private System.Windows.Forms.Panel panelButtonsInAdding;
        private System.Windows.Forms.Panel panelPictureInAdding;
        private System.Windows.Forms.Panel panelDisplayInAdding;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtondInAdding;
        private System.Windows.Forms.ListView listViewPicsInAdding;
        private System.Windows.Forms.Button buttonEdidInformationAdding;
        private System.Windows.Forms.ListView listViewPicsInMediaView;
        private System.Windows.Forms.BindingSource dBPicturesDataSetBindingSource;
        private DBPicturesDataSet dBPicturesDataSet;
        private System.Windows.Forms.TableLayoutPanel tableTagsManager;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Label textInfo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelListViewPicureAfterSearch;
        private System.Windows.Forms.Panel panelSearchOption;
        private System.Windows.Forms.Panel panelSearchButtons;
        private System.Windows.Forms.Panel panelSearchOptions;
        private System.Windows.Forms.Label SearchAfterTagLabel;
        private System.Windows.Forms.TextBox textBoxSearchAfterTagLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchAfterTag;
        private System.Windows.Forms.Label SearchAfterTagTypeLabel;
        private System.Windows.Forms.TextBox textBoxSearchAfterTagTypeLabel;
        private System.Windows.Forms.TextBox textBoxSearchAfterMediaLabel;
        private System.Windows.Forms.Label SearchAfterMediaLabel;
        private System.Windows.Forms.ListView listViewSearch;
    }
}