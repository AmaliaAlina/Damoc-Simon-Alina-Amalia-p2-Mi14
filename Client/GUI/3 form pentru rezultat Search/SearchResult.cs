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
using PictureManagerLibrary;

namespace PictureManagerProject
{
    public partial class SearchResult : Form
    {
        public SearchResult(int idTagType)
        {
            InitializeComponent();
            RefreshDB(idTagType);
        }
        private void RefreshDB(int idTagType)  
        {
            this.listViewSearch.Items.Clear();
            List<int> idMedia = PictureManagerLibrary.TableWaysLibraryFunctions.GetTableWaysIdMediaAfterIdTagType(idTagType);
            List<Media> allMedia = new List<Media>();
            foreach (var countable in idMedia)
            {
                var element = PictureManagerLibrary.MediaLibraryFunctions.GetMedia(countable);
                allMedia.Add(element);
            } 
            this.listViewSearch.View = View.LargeIcon;
            ImageList imageList = new ImageList();


                foreach (var item in allMedia)
                {
                //Console.WriteLine(item.Media_path);
                //imageList.Images.Add(Image.FromFile(item.Media_path));
                //imageList.Images.Add(item.Media_path, Image.FromFile(item.Media_path));
                imageList.Images.Add(Image.FromFile(item.Media_path));
            }
            this.listViewSearch.LargeImageList = imageList;
            for (int i = 0; i < imageList.Images.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.ImageIndex = i;
                    listViewItem.Tag = allMedia[i];

                    this.listViewSearch.Items.Add(listViewItem);
                }
            
           
        }

        private void buttonCancelErrInfo_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
