using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureManagerProject
{
    public partial class ErrForm : Form
    {
        public ErrForm(string errInfo)
        {
            InitializeComponent();
            this.textBoxInfoErr.Text = errInfo;
        }

        private void buttonCancelErrInfo_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
