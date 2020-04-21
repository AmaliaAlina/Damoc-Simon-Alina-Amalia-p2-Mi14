namespace PictureManagerProject
{
    partial class ErrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrForm));
            this.panelInfoErr = new System.Windows.Forms.Panel();
            this.labelinfoErr = new System.Windows.Forms.Label();
            this.textBoxInfoErr = new System.Windows.Forms.TextBox();
            this.buttonCancelErrInfo = new System.Windows.Forms.Button();
            this.panelInfoErr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfoErr
            // 
            this.panelInfoErr.Controls.Add(this.textBoxInfoErr);
            this.panelInfoErr.Controls.Add(this.buttonCancelErrInfo);
            this.panelInfoErr.Controls.Add(this.labelinfoErr);
            this.panelInfoErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfoErr.Location = new System.Drawing.Point(0, 0);
            this.panelInfoErr.Name = "panelInfoErr";
            this.panelInfoErr.Padding = new System.Windows.Forms.Padding(150, 100, 155, 50);
            this.panelInfoErr.Size = new System.Drawing.Size(613, 411);
            this.panelInfoErr.TabIndex = 0;
            // 
            // labelinfoErr
            // 
            this.labelinfoErr.AutoSize = true;
            this.labelinfoErr.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelinfoErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfoErr.Location = new System.Drawing.Point(150, 100);
            this.labelinfoErr.Margin = new System.Windows.Forms.Padding(0);
            this.labelinfoErr.Name = "labelinfoErr";
            this.labelinfoErr.Size = new System.Drawing.Size(280, 39);
            this.labelinfoErr.TabIndex = 1;
            this.labelinfoErr.Text = "An error occurred";
            this.labelinfoErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInfoErr
            // 
            this.textBoxInfoErr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.textBoxInfoErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfoErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfoErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.textBoxInfoErr.Location = new System.Drawing.Point(150, 139);
            this.textBoxInfoErr.Multiline = true;
            this.textBoxInfoErr.Name = "textBoxInfoErr";
            this.textBoxInfoErr.ReadOnly = true;
            this.textBoxInfoErr.Size = new System.Drawing.Size(308, 180);
            this.textBoxInfoErr.TabIndex = 2;
            // 
            // buttonCancelErrInfo
            // 
            this.buttonCancelErrInfo.AutoSize = true;
            this.buttonCancelErrInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancelErrInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCancelErrInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.buttonCancelErrInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonCancelErrInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.buttonCancelErrInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelErrInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelErrInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.buttonCancelErrInfo.Location = new System.Drawing.Point(150, 319);
            this.buttonCancelErrInfo.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelErrInfo.Name = "buttonCancelErrInfo";
            this.buttonCancelErrInfo.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancelErrInfo.Size = new System.Drawing.Size(308, 42);
            this.buttonCancelErrInfo.TabIndex = 9;
            this.buttonCancelErrInfo.Text = "Close";
            this.buttonCancelErrInfo.UseVisualStyleBackColor = true;
            this.buttonCancelErrInfo.Click += new System.EventHandler(this.buttonCancelErrInfo_Click);
            // 
            // ErrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(613, 411);
            this.Controls.Add(this.panelInfoErr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrForm";
            this.Text = "ErrForm";
            this.panelInfoErr.ResumeLayout(false);
            this.panelInfoErr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfoErr;
        private System.Windows.Forms.Label labelinfoErr;
        private System.Windows.Forms.TextBox textBoxInfoErr;
        private System.Windows.Forms.Button buttonCancelErrInfo;
    }
}