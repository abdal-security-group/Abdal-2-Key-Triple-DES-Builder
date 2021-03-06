namespace Abdal_Security_Group_App
{
    partial class Abdal_2Key_Triple_DES_Builder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abdal_2Key_Triple_DES_Builder));
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.EncryptToggleSwitch = new Telerik.WinControls.UI.RadToggleSwitch();
            this.DecryptToggleSwitch = new Telerik.WinControls.UI.RadToggleSwitch();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.SecretPasswordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.EncDecButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hexRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.urlRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.base64RadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.quotedPrintableRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.StringTextEditor = new System.Windows.Forms.RichTextBox();
            this.ResultTextEditor = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptToggleSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptToggleSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecretPasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncDecButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hexRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base64RadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotedPrintableRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(27, 85);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Your String";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // EncryptToggleSwitch
            // 
            this.EncryptToggleSwitch.Location = new System.Drawing.Point(363, 149);
            this.EncryptToggleSwitch.Name = "EncryptToggleSwitch";
            this.EncryptToggleSwitch.OffText = "Encrypt OFF";
            this.EncryptToggleSwitch.OnText = "Encrypt ON";
            this.EncryptToggleSwitch.Size = new System.Drawing.Size(137, 20);
            this.EncryptToggleSwitch.TabIndex = 4;
            this.EncryptToggleSwitch.ThemeName = "VisualStudio2012Dark";
            this.EncryptToggleSwitch.ThumbTickness = 15;
            this.EncryptToggleSwitch.ValueChanged += new System.EventHandler(this.EncryptToggleSwitch_ValueChanged);
            // 
            // DecryptToggleSwitch
            // 
            this.DecryptToggleSwitch.Location = new System.Drawing.Point(509, 149);
            this.DecryptToggleSwitch.Name = "DecryptToggleSwitch";
            this.DecryptToggleSwitch.OffText = "Decrypt OFF";
            this.DecryptToggleSwitch.OnText = "Decrypt ON";
            this.DecryptToggleSwitch.Size = new System.Drawing.Size(137, 20);
            this.DecryptToggleSwitch.TabIndex = 3;
            this.DecryptToggleSwitch.ThemeName = "VisualStudio2012Dark";
            this.DecryptToggleSwitch.ThumbTickness = 15;
            this.DecryptToggleSwitch.Value = false;
            this.DecryptToggleSwitch.ValueChanged += new System.EventHandler(this.DecryptToggleSwitch_ValueChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(363, 85);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(114, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Your Secret Password";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // SecretPasswordTextBox
            // 
            this.SecretPasswordTextBox.Location = new System.Drawing.Point(363, 109);
            this.SecretPasswordTextBox.Name = "SecretPasswordTextBox";
            this.SecretPasswordTextBox.Size = new System.Drawing.Size(283, 24);
            this.SecretPasswordTextBox.TabIndex = 2;
            this.SecretPasswordTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(27, 222);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(37, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Result";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // EncDecButton
            // 
            this.EncDecButton.Location = new System.Drawing.Point(366, 178);
            this.EncDecButton.Name = "EncDecButton";
            this.EncDecButton.Size = new System.Drawing.Size(280, 24);
            this.EncDecButton.TabIndex = 5;
            this.EncDecButton.Text = "Encrypt \\ Decrypt";
            this.EncDecButton.ThemeName = "VisualStudio2012Dark";
            this.EncDecButton.Click += new System.EventHandler(this.EncDecButton_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(27, 487);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(205, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Programmer : Ebrahim Shafiei (EbraSha)";
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(238, 487);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(115, 18);
            this.radLabel5.TabIndex = 3;
            this.radLabel5.Text = "|   Www.Hackers.Zone";
            this.radLabel5.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(363, 487);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(135, 18);
            this.radLabel6.TabIndex = 4;
            this.radLabel6.Text = "|  Prof.Shafiei@Gmail.com";
            this.radLabel6.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(27, 512);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(183, 18);
            this.radLabel7.TabIndex = 6;
            this.radLabel7.Text = "Powered By Abdal Security Agency ";
            this.radLabel7.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.radLabel8.Location = new System.Drawing.Point(110, 15);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(477, 51);
            this.radLabel8.TabIndex = 7;
            this.radLabel8.Text = "Abdal 2-Key Triple DES Builder";
            this.radLabel8.ThemeName = "VisualStudio2012Dark";
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Location = new System.Drawing.Point(26, 468);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(619, 8);
            this.radProgressBar1.TabIndex = 9;
            this.radProgressBar1.ThemeName = "VisualStudio2012Dark";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Abdal_Security_Group_App.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(38, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hexRadioButton.Location = new System.Drawing.Point(366, 222);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(41, 18);
            this.hexRadioButton.TabIndex = 12;
            this.hexRadioButton.Text = "hex";
            this.hexRadioButton.ThemeName = "VisualStudio2012Dark";
            this.hexRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // urlRadioButton
            // 
            this.urlRadioButton.Location = new System.Drawing.Point(413, 222);
            this.urlRadioButton.Name = "urlRadioButton";
            this.urlRadioButton.Size = new System.Drawing.Size(36, 18);
            this.urlRadioButton.TabIndex = 13;
            this.urlRadioButton.TabStop = false;
            this.urlRadioButton.Text = "url";
            this.urlRadioButton.ThemeName = "VisualStudio2012Dark";
            // 
            // base64RadioButton
            // 
            this.base64RadioButton.Location = new System.Drawing.Point(455, 222);
            this.base64RadioButton.Name = "base64RadioButton";
            this.base64RadioButton.Size = new System.Drawing.Size(59, 18);
            this.base64RadioButton.TabIndex = 14;
            this.base64RadioButton.TabStop = false;
            this.base64RadioButton.Text = "base64";
            this.base64RadioButton.ThemeName = "VisualStudio2012Dark";
            // 
            // quotedPrintableRadioButton
            // 
            this.quotedPrintableRadioButton.Location = new System.Drawing.Point(520, 222);
            this.quotedPrintableRadioButton.Name = "quotedPrintableRadioButton";
            this.quotedPrintableRadioButton.Size = new System.Drawing.Size(109, 18);
            this.quotedPrintableRadioButton.TabIndex = 15;
            this.quotedPrintableRadioButton.TabStop = false;
            this.quotedPrintableRadioButton.Text = "quoted-printable";
            this.quotedPrintableRadioButton.ThemeName = "VisualStudio2012Dark";
            // 
            // StringTextEditor
            // 
            this.StringTextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.StringTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StringTextEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.StringTextEditor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.StringTextEditor.Location = new System.Drawing.Point(31, 109);
            this.StringTextEditor.Name = "StringTextEditor";
            this.StringTextEditor.Size = new System.Drawing.Size(322, 96);
            this.StringTextEditor.TabIndex = 16;
            this.StringTextEditor.Text = "";
            // 
            // ResultTextEditor
            // 
            this.ResultTextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ResultTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ResultTextEditor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ResultTextEditor.Location = new System.Drawing.Point(26, 246);
            this.ResultTextEditor.Name = "ResultTextEditor";
            this.ResultTextEditor.Size = new System.Drawing.Size(619, 216);
            this.ResultTextEditor.TabIndex = 17;
            this.ResultTextEditor.Text = "";
            // 
            // Abdal_2Key_Triple_DES_Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 569);
            this.Controls.Add(this.ResultTextEditor);
            this.Controls.Add(this.StringTextEditor);
            this.Controls.Add(this.quotedPrintableRadioButton);
            this.Controls.Add(this.base64RadioButton);
            this.Controls.Add(this.urlRadioButton);
            this.Controls.Add(this.hexRadioButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.EncDecButton);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.DecryptToggleSwitch);
            this.Controls.Add(this.SecretPasswordTextBox);
            this.Controls.Add(this.EncryptToggleSwitch);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Abdal_2Key_Triple_DES_Builder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Abdal 2-Key Triple DES Builder";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Abdal_2Key_Triple_DES_Builder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptToggleSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptToggleSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecretPasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncDecButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hexRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base64RadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotedPrintableRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadToggleSwitch EncryptToggleSwitch;
        private Telerik.WinControls.UI.RadToggleSwitch DecryptToggleSwitch;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox SecretPasswordTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton EncDecButton;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadRadioButton hexRadioButton;
        private Telerik.WinControls.UI.RadRadioButton urlRadioButton;
        private Telerik.WinControls.UI.RadRadioButton base64RadioButton;
        private Telerik.WinControls.UI.RadRadioButton quotedPrintableRadioButton;
        private System.Windows.Forms.RichTextBox StringTextEditor;
        private System.Windows.Forms.RichTextBox ResultTextEditor;
    }
}

