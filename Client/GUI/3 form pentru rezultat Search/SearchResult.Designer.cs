namespace PictureManagerProject
{
    partial class SearchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResult));
            this.listViewSearch = new System.Windows.Forms.ListView();
            this.labelTextSearch = new System.Windows.Forms.Label();
            this.buttonCancelErrInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSearch
            // 
            this.listViewSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.listViewSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.listViewSearch.HideSelection = false;
            this.listViewSearch.Location = new System.Drawing.Point(0, 0);
            this.listViewSearch.Name = "listViewSearch";
            this.listViewSearch.Size = new System.Drawing.Size(800, 397);
            this.listViewSearch.TabIndex = 0;
            this.listViewSearch.UseCompatibleStateImageBehavior = false;
            // 
            // labelTextSearch
            // 
            this.labelTextSearch.AutoSize = true;
            this.labelTextSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTextSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextSearch.Location = new System.Drawing.Point(0, 0);
            this.labelTextSearch.Name = "labelTextSearch";
            this.labelTextSearch.Size = new System.Drawing.Size(0, 29);
            this.labelTextSearch.TabIndex = 1;
            // 
            // buttonCancelErrInfo
            // 
            this.buttonCancelErrInfo.AutoSize = true;
            this.buttonCancelErrInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancelErrInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelErrInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.buttonCancelErrInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonCancelErrInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonCancelErrInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelErrInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelErrInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.buttonCancelErrInfo.Location = new System.Drawing.Point(726, 397);
            this.buttonCancelErrInfo.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelErrInfo.Name = "buttonCancelErrInfo";
            this.buttonCancelErrInfo.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancelErrInfo.Size = new System.Drawing.Size(74, 53);
            this.buttonCancelErrInfo.TabIndex = 10;
            this.buttonCancelErrInfo.Text = "Close";
            this.buttonCancelErrInfo.UseVisualStyleBackColor = true;
            this.buttonCancelErrInfo.Click += new System.EventHandler(this.buttonCancelErrInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancelErrInfo);
            this.panel1.Controls.Add(this.listViewSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 11;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTextSearch);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchResult";
            this.Text = "SearchResult";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSearch;
        private System.Windows.Forms.Label labelTextSearch;
        private System.Windows.Forms.Button buttonCancelErrInfo;
        private System.Windows.Forms.Panel panel1;
    }
}