using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PictureManagerLibrary;
using System.Text.RegularExpressions;

namespace PictureManagerProject
{
    public partial class ModifyPropety : Form
    {
        public ModifyPropety(string filePath)
        {
            InitializeComponent();
            ShowMyImage(filePath);
            ShowTags(filePath);
        }

        public void ShowMyImage(String fileToDisplay)
        {
            pictureBoxModifyProety.SizeMode = PictureBoxSizeMode.StretchImage;
            var MyImage = new Bitmap(fileToDisplay);
            /* pictureBox1.ClientSize = new Size(xSize, ySize);*/
            pictureBoxModifyProety.Image = (Image)MyImage;
            pictureBoxModifyProety.Tag = fileToDisplay;
            /*Console.WriteLine(pictureBox1.Name );
            Console.WriteLine(fileToDisplay);*/
        }
        public void ShowTags(String fileToDisplay)
        {
            textBox1.Text = String.Empty;
           
           Media mediaDB = MediaLibraryFunctions.GetMedia(fileToDisplay);
           Tags tagCategory = TableWaysLibraryFunctions.GetTableWaysIdTagsCategoryForDATE(mediaDB.Id_Media);
            DataDelete(tagCategory);
           textBox1.Text += "Numele pozei:  "; 
            textBox1.Text += mediaDB.Media_name;
            textBox1.AppendText(Environment.NewLine);
            foreach (var item in mediaDB.TableWays)
            {
                if (item.Tag.Is_Deleted != true)
                {
                    textBox1.Text += "->";
                    textBox1.Text += item.Tag.Value_tag;
                    textBox1.Text += " (";
                    textBox1.Text += item.TagType.Value_tagType;
                    textBox1.Text += " )";
                    textBox1.AppendText(Environment.NewLine);
                }
            }

        }
        private void buttonCancelInModifyPropety_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void buttonSaveInModifyPropety_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dateTimePicker1.Value);

            try 
           { 
            string newTagsString = this.textBoxNewTags.Text.ToString();
            Regex regex = new Regex(@"^((?<key>[A-Za-z]+)\s*-\s*(?<value>[A-Za-z]+)\s*[,;]\s*)+$", RegexOptions.Compiled);
            /*Regex regex = new Regex(@"(?<key>\w)", RegexOptions.Compiled);*/

                MatchCollection newTagList = regex.Matches(newTagsString);
                Console.WriteLine("count new tag list");
                Console.WriteLine(newTagList.Count);
                if (newTagList.Count == 0)
                {
                    ErrForm errForm = new ErrForm("Format Incorect Please use this format: tagName - tagCategory;");
                    errForm.ShowDialog();
                }
                Media mediaDB;
            foreach (Match match in newTagList)
            {
                GroupCollection groups = match.Groups;
                var countGroup = groups["key"].Captures.Count;
                //Console.WriteLine("countGroup");
                //Console.WriteLine(countGroup);

                for (int i = 0; i < countGroup; i++)
                {

                    string itemTag = groups["key"].Captures[i].ToString();
                    string itemTagType = groups["value"].Captures[i].ToString();
                    //Console.WriteLine("itemTag");
                    //Console.WriteLine(itemTag);
                    //Console.WriteLine("itemTagType");
                    //Console.WriteLine(itemTagType);

                    var tagDB = TagsLibraryFunctions.CreateTagAnReturnTag(itemTag);
                    mediaDB = MediaLibraryFunctions.GetMedia(pictureBoxModifyProety.Tag.ToString());

                    TagType tagTypeDB = new TagType();
                    if (TagTypesLibraryFunctions.GetTagTypes(itemTagType) != null)
                    {
                        tagTypeDB = TagTypesLibraryFunctions.GetTagTypes(itemTagType);
                        //Console.WriteLine("gasit");
                    }
                    else
                    {
                        tagTypeDB = TagTypesLibraryFunctions.CreateTagTypeAndReturnIt(itemTagType);
                        //Console.WriteLine("nou");
                    }

                    TableWaysLibraryFunctions.CreateTableWay(mediaDB, tagDB, tagTypeDB);

                    //Console.WriteLine(pictureBoxModifyProety.Tag.ToString());
                    ShowTags(mediaDB.Media_path);
                }

            }
                DataAssigment();
            }
            catch(Exception ex)
            {
                ErrForm errForm = new ErrForm(ex.ToString());
                errForm.ShowDialog();
            }
            
        }

        public void DataDelete(Tags tag)
        {
            
            TagsLibraryFunctions.DeleteTag(tag);

        }
        private void DataAssigment()
        {
            Tags dataTag = TagsLibraryFunctions.CreateDateTag(dateTimePicker1.Value.ToString());
            TagType dataTagType = TagTypesLibraryFunctions.CreateAndReturn("Data");
            Media dataMedia = MediaLibraryFunctions.GetMedia(pictureBoxModifyProety.Tag.ToString());
            TableWaysLibraryFunctions.CreateTableWay(dataMedia, dataTag, dataTagType);
        }

        private void buttonDeleteTag_Click(object sender, EventArgs e)
        {
            string forDeteleTags = this.textBoxNewTags.Text.ToString();

            Regex usedRegex = new Regex(@"^((?<key>[A-Za-z]+)\s*[;]\s*)+$",RegexOptions.Compiled);
            MatchCollection forDeleteTagList = usedRegex.Matches(forDeteleTags);

            Media mediaDB;
            //foreach (var item in forDeleteTagList)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            if (forDeleteTagList.Count == 0)
            {
                ErrForm errForm = new ErrForm("Format Incorect Please use this format: tagName;");
                errForm.ShowDialog();
            }

            try {
                foreach (Match match in forDeleteTagList)
                {
                    GroupCollection groups = match.Groups;
                    var countGroup = groups["key"].Captures.Count;

                    Console.WriteLine("countGroup");
                    Console.WriteLine(countGroup);

                    for (int i = 0; i < countGroup; i++)
                    {

                        string itemTagDelete = groups["key"].Captures[i].ToString();
                        //string itemTagType = groups["value"].Captures[i].ToString();
                        Console.WriteLine("itemTagDelete");
                        Console.WriteLine(itemTagDelete);

                        Tags tagDB = TagsLibraryFunctions.GetTag(itemTagDelete);
                        if (tagDB == null)
                        {
                            continue;
                        }

                        TagsLibraryFunctions.DeleteTag(tagDB);
                        //Console.WriteLine(TagsLibraryFunctions.DeleteTag(tagDB));

                        mediaDB = MediaLibraryFunctions.GetMedia(pictureBoxModifyProety.Tag.ToString());
                        TableWaysLibraryFunctions.DeleteTableWay(mediaDB);
                        ShowTags(mediaDB.Media_path);
                    }
                }

            }
            catch (Exception ex)
            {
                ErrForm errForm = new ErrForm(ex.ToString());
                errForm.ShowDialog();
            }

        }

        private void buttonEditInModify_Click(object sender, EventArgs e)
        {
            try { 
            if (pictureBoxModifyProety.Image == null)
            {
                return;
            }
            var path = pictureBoxModifyProety.Tag;
            var idMedia = MediaLibraryFunctions.GetMediaId((string)path);
            EditInformation editInformation = new EditInformation(idMedia);
            editInformation.ShowDialog();
            }
            catch(Exception ex)
            {
                ErrForm errForm = new ErrForm(ex.ToString());
                errForm.ShowDialog();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTimePicker dateTimePicker = (DateTimePicker)sender;
            

        }

        private void buttonDeletePicturesModify_Click(object sender, EventArgs e)
        {

            if (this.pictureBoxModifyProety.Image == null)
            {
                return;
            }
            var item = pictureBoxModifyProety.Tag.ToString();
            Console.WriteLine(item);
           
            if (!(MediaLibraryFunctions.DeleteMedia(item)))
            {
                ErrForm errForm = new ErrForm("Err occured at DELETE MEDIA");
                errForm.ShowDialog();
            }
            Form.ActiveForm.Close();
        }
    }
}
