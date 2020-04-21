using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using PictureManagerLibrary;


namespace PictureManagerProject
{
    public partial class MediaManager : Form
    {
        public MediaManager()
        {

            InitializeComponent();
            this.listViewPicsInMediaView.ItemSelectionChanged += listViewPicsInMediaView_SelectedIndexChanged;

        }

        public void ShowMyImage(String fileToDisplay)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap MyImage = new Bitmap(fileToDisplay);
            pictureBox1.Image = (Image)MyImage;
            pictureBox1.Tag = fileToDisplay;
            /*Console.WriteLine(pictureBox1.Name );
            Console.WriteLine(fileToDisplay);*/
        }

        private void buttonSelectMediaInAdding_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "*|*.png;*.jpg";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                this.listViewPicsInAdding.View = View.LargeIcon;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageList imageList = new ImageList();
                    foreach (var item in openFileDialog.FileNames)
                    {
                        //Console.WriteLine(item);
                       if(MediaLibraryFunctions.CreateMedia(item))
                        {
                            ShowMyImage(item);
                            /*Console.WriteLine(pictureBox1.Name);*/
                            imageList.Images.Add(item, Image.FromFile(item));
                        }
                        else
                        {
                            ErrForm errForm = new ErrForm("Err occured at CREAT MEDIA");
                            errForm.ShowDialog();
                        }
                       

                    }
                    int count = 0;
                    if (this.listViewPicsInAdding.LargeImageList != null)
                    {
                        count = this.listViewPicsInAdding.LargeImageList.Images.Count;

                    }
                    else
                    {
                        this.listViewPicsInAdding.LargeImageList = new ImageList();
                    }

                    for (int i = 0; i < imageList.Images.Count; i++)
                    {
                        this.listViewPicsInAdding.LargeImageList.Images.Add(imageList.Images.Keys[i], imageList.Images[i]);

                    }
                    for (int i = 0; i < imageList.Images.Count; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.ImageIndex = i + count;
                        


                        this.listViewPicsInAdding.Items.Add(listViewItem);
                    }
                }
            }

            RefreshDB();
        }
        private void buttonDeleteMediaIInAdding_Click(object sender, EventArgs e)
        {


            if (this.pictureBox1.Image == null)
            {
                return;
            }
            var item = pictureBox1.Tag.ToString();
            Console.WriteLine(item);
            /*Console.WriteLine(pictureBox1.Name);*/
            /*var itemListed = this.listViewPicsInAdding.Items.Find(item, true).ToList()[0];
            this.listViewPicsInAdding.Items.Remove(itemListed);*/
            var indexPic = this.listViewPicsInAdding.LargeImageList.Images.IndexOfKey(item);
            /*Console.WriteLine(indexPic);
            Console.WriteLine("\n");*/
            foreach (ListViewItem itemPic in this.listViewPicsInAdding.Items)
            {
                if (itemPic.ImageIndex == indexPic)
                {
                    this.listViewPicsInAdding.Items.Remove(itemPic);

                    break;
                }
            }
            if (this.listViewPicsInAdding.Items.Count == 0)
            {
                this.pictureBox1.Image = null;
                //Console.WriteLine("this.listViewPicsInAdding.Items.Count == 0");
                //Console.WriteLine(this.listViewPicsInAdding.Items.Count == 0);
                //Console.WriteLine("\n");
            }
            else
            {
                //Console.WriteLine(this.listViewPicsInAdding.Items.Count);
                ListViewItem validare = this.listViewPicsInAdding.Items[0];
                //Console.WriteLine("validare.ImageIndex");
                //Console.WriteLine(validare.ImageIndex);
                /*Console.WriteLine("\n");*/
                this.pictureBox1.Image = this.listViewPicsInAdding.LargeImageList.Images[validare.ImageIndex];
                this.pictureBox1.Tag = this.listViewPicsInAdding.LargeImageList.Images.Keys[validare.ImageIndex];
                /*Console.WriteLine("this.listViewPicsInAdding.LargeImageList.Images.Keys[validare.ImageIndex]");
                Console.WriteLine(this.listViewPicsInAdding.LargeImageList.Images.Keys[validare.ImageIndex]);
                Console.WriteLine("\n");*/
            }
            if(!(MediaLibraryFunctions.DeleteMedia(item)))
            {
                ErrForm errForm = new ErrForm("Err occured at DELETE MEDIA");
                errForm.ShowDialog();
            }
        }

        private void buttonEdidInformationAdding_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }

            var path = pictureBox1.Tag;
            ModifyPropety modifyPropety = new ModifyPropety((String)path);
            modifyPropety.ShowDialog();
        }

        private void listViewPicsInMediaView_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Console.WriteLine("afiseaza");
            if (!(e.IsSelected))
            {
                return;
            }
            var listViewItemUsed = (ListViewItem)e.Item;
            var mediaUsed = (Media)listViewItemUsed.Tag;
            ModifyPropety modifyPropety = new ModifyPropety(mediaUsed.Media_path);
            modifyPropety.ShowDialog();
        }

        private void RefreshDB()
        {
            this.listViewPicsInMediaView.Items.Clear();
            var allMedia = PictureManagerLibrary.MediaLibraryFunctions.GetAllMedia();
            this.listViewPicsInMediaView.View = View.LargeIcon;
            ImageList imageList = new ImageList();
            foreach (var item in allMedia)
            {
                imageList.Images.Add(Path.GetFileName(item.Media_path), Image.FromFile(item.Media_path));
            }
            this.listViewPicsInMediaView.LargeImageList = imageList;
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.ImageIndex = i;
                listViewItem.Tag = allMedia[i];
                listViewItem.Text = allMedia[i].Media_name;

                this.listViewPicsInMediaView.Items.Add(listViewItem);
            }
        }

        private void MediaManager_Load(object sender, EventArgs e)
        {
            RefreshDB();
            tableTagsManagerT();
        }

        private void tableTagsManagerT()
        {
            tableTagsManager.AutoSize = true;
            tableTagsManager.RowCount = 1;
            tableTagsManager.ColumnCount = 4;
            tableTagsManager.RowStyles.Add(new RowStyle());

            tableTagsManager.ColumnStyles.Add(new ColumnStyle());
            tableTagsManager.ColumnStyles.Add(new ColumnStyle());
            tableTagsManager.ColumnStyles.Add(new ColumnStyle());
            tableTagsManager.ColumnStyles.Add(new ColumnStyle());

            Label tagValue = new Label();
            tagValue.Text = "Tag Value";
            tagValue.BackColor = Color.FromArgb(103, 146, 137);
            //tagValue.AutoSize = true;
            Label tagID = new Label();
            tagID.Text = "Tag Category Id";
            tagID.BackColor = Color.FromArgb(103, 146, 137);
            //tagID.AutoSize = true;
            Label tagCategory = new Label();
            tagCategory.Text = "Tag Category";
            tagCategory.BackColor = Color.FromArgb(103, 146, 137);
            //tagCategory.AutoSize = true;
            Label tagSerach = new Label();
            tagSerach.Text = "Search";
            tagSerach.BackColor = Color.FromArgb(103, 146, 137);
            //tagSerach.AutoSize = true;
            tableTagsManager.Controls.Add(tagID, 0, 0);
            tableTagsManager.Controls.Add(tagCategory, 1, 0);
            tableTagsManager.Controls.Add(tagValue, 2, 0);
            tableTagsManager.Controls.Add(tagSerach, 3, 0);

            List<Tags> newTag = TagsLibraryFunctions.GetTagAll();
            int count = 1;
            foreach (var item in newTag)
            {
                tableTagsManager.RowStyles.Add(new RowStyle());
                Label newLabelValue = new Label();
                Label newLabelId = new Label();
                Label newLabelCategory = new Label();
                var newLabelSearch = new Button();
                newLabelValue.Text = item.Value_tag;

                var init = TableWaysLibraryFunctions.GetTableWaysIdTagsCategory(item.Id_Tags);
                newLabelCategory.Text = TagTypesLibraryFunctions.GetTagTypes(init).Value_tagType;
                newLabelId.Text = TagTypesLibraryFunctions.GetTagTypes(init).Id_TagType.ToString();
                newLabelValue.BackColor = Color.FromArgb(244, 192, 149);
                newLabelCategory.BackColor = Color.FromArgb(244, 192, 149);
                newLabelId.BackColor = Color.FromArgb(244, 192, 149);

                tableTagsManager.Controls.Add(newLabelId, 0, count);
                tableTagsManager.Controls.Add(newLabelCategory, 1, count);
                tableTagsManager.Controls.Add(newLabelValue, 2, count);


                newLabelSearch.Text = "Vezi tot";
                newLabelSearch.BackColor = Color.FromArgb(244, 192, 149);
                newLabelSearch.Tag = TagTypesLibraryFunctions.GetTagTypes(init).Id_TagType;
                newLabelSearch.Click += NewLabelSearch_Click;
                tableTagsManager.Controls.Add(newLabelSearch, 3, count);

                count++;
                tableTagsManager.RowCount++;

            }

        }

        private void NewLabelSearch_Click(object sender, EventArgs e)
        {
            Button used = (Button)sender;
            int i = (int)used.Tag;
            SearchResult searchResult = new SearchResult(i);
            searchResult.ShowDialog();

        }


        private void GetDBAfterIdTagType(int idTagType)
        {
            this.listViewSearch.Items.Clear();
            List<int> idMedia = PictureManagerLibrary.TableWaysLibraryFunctions.GetTableWaysIdMediaAfterIdTagType(idTagType);
            List<Media> allMedia = new List<Media>();
            foreach (var countable in idMedia)
            {
                var element = PictureManagerLibrary.MediaLibraryFunctions.GetMedia(countable);
                allMedia.Add(element);
            }
            DBmedia(allMedia);
        }

        private void GetDBAfterIdTag(int idTag)
        {
            this.listViewSearch.Items.Clear();
            List<int> idMedia = PictureManagerLibrary.TableWaysLibraryFunctions.GetTableWaysIdMediaAfterIdTag(idTag);
            List<Media> allMedia = new List<Media>();
            foreach (var countable in idMedia)
            {
                var element = PictureManagerLibrary.MediaLibraryFunctions.GetMedia(countable);
                allMedia.Add(element);
                Console.WriteLine(allMedia.Count);
            }
            DBmedia(allMedia);
        }
        private void GetDBAfterMediaName(string mediaName)
        {
            this.listViewSearch.Items.Clear();
            List<Media> allMedia = PictureManagerLibrary.MediaLibraryFunctions.GetAllMedia(mediaName);
            Console.WriteLine(allMedia.Count);
            DBmedia(allMedia);
        }
        private void DBmedia(List<Media> allMedia)
        {
            this.listViewSearch.View = View.LargeIcon;
            ImageList imageList = new ImageList();
            foreach (var item in allMedia)
            {
                Console.WriteLine(item.Media_path);
                Bitmap MyImage = new Bitmap(item.Media_path);
                imageList.Images.Add(MyImage);
            }
            this.listViewSearch.LargeImageList = imageList;
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.ImageIndex = i;
                listViewItem.Tag = allMedia[i];
                //listViewItem.Text = allMedia[i].Media_name;
                this.listViewSearch.Items.Add(listViewItem);
            }
        }

        private void buttonSearchAfterTag_Click(object sender, EventArgs e)
        {
            var mediaGivenName = this.textBoxSearchAfterMediaLabel.Text;
            var tagGivenValue = this.textBoxSearchAfterTagLabel.Text;
            var tagTypeGivenValue = this.textBoxSearchAfterTagTypeLabel.Text;
            //Console.WriteLine(mediaGivenName);
            //Console.WriteLine(tagGivenValue);
            //Console.WriteLine(tagTypeGivenValue);

            if ((tagTypeGivenValue == null) && (tagTypeGivenValue == null) && (mediaGivenName == null))
            {
                Console.WriteLine("all is null");
            }
            else
            {
                if (tagTypeGivenValue != null)
                {
                    TagType k = TagTypesLibraryFunctions.GetTagTypes(tagTypeGivenValue);
                    if (k != null)
                    {
                        Console.WriteLine("k"); Console.WriteLine(k);
                        //this.textBoxSearchAfterTagTypeLabel.Text = null;
                        GetDBAfterIdTagType(k.Id_TagType);
                    }
                }
                if (tagGivenValue != null)
                {
                    Tags k = TagsLibraryFunctions.GetTag(tagGivenValue);
                    if (k != null)
                    {
                        Console.WriteLine("k"); Console.WriteLine(k.Value_tag);
                        //this.textBoxSearchAfterTagLabel.Text = null;
                        GetDBAfterIdTag(k.Id_Tags);
                    }

                }
                if(mediaGivenName != null)
                {
                    Console.WriteLine("k"); Console.WriteLine(mediaGivenName);
                    GetDBAfterMediaName(mediaGivenName);  
                }
            }
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("damocsimonalina@gmail,com");
            }
            catch(Exception ex)
            {
                ErrForm errForm = new ErrForm(ex.ToString());
                errForm.ShowDialog();
            }
        }

    }
}

    