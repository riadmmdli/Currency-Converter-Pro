namespace Currency_Converter_Pro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fromLabel = new MetroFramework.Controls.MetroLabel();
            this.toLabel = new MetroFramework.Controls.MetroLabel();
            this.fromCombo = new MetroFramework.Controls.MetroComboBox();
            this.toCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.amountTxt = new MetroFramework.Controls.MetroTextBox();
            this.resultLbl = new MetroFramework.Controls.MetroLabel();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.changeBtn = new MetroFramework.Controls.MetroButton();
            this.dateLabel = new MetroFramework.Controls.MetroLabel();
            this.timeLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            resources.ApplyResources(this.fromLabel, "fromLabel");
            this.fromLabel.BackColor = System.Drawing.Color.Teal;
            this.fromLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.fromLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.fromLabel.Name = "fromLabel";
            // 
            // toLabel
            // 
            resources.ApplyResources(this.toLabel, "toLabel");
            this.toLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.toLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.toLabel.Name = "toLabel";
            this.toLabel.Click += new System.EventHandler(this.toLabel_Click);
            // 
            // fromCombo
            // 
            this.fromCombo.BackColor = System.Drawing.SystemColors.Control;
            this.fromCombo.ForeColor = System.Drawing.Color.Red;
            this.fromCombo.FormattingEnabled = true;
            resources.ApplyResources(this.fromCombo, "fromCombo");
            this.fromCombo.Name = "fromCombo";
            this.fromCombo.Style = MetroFramework.MetroColorStyle.Red;
            this.fromCombo.UseCustomBackColor = true;
            this.fromCombo.UseCustomForeColor = true;
            this.fromCombo.UseSelectable = true;
            this.fromCombo.UseStyleColors = true;
            // 
            // toCombo
            // 
            this.toCombo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toCombo.ForeColor = System.Drawing.Color.Red;
            this.toCombo.FormattingEnabled = true;
            resources.ApplyResources(this.toCombo, "toCombo");
            this.toCombo.Name = "toCombo";
            this.toCombo.Style = MetroFramework.MetroColorStyle.Red;
            this.toCombo.UseCustomBackColor = true;
            this.toCombo.UseCustomForeColor = true;
            this.toCombo.UseSelectable = true;
            this.toCombo.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.metroLabel1.Name = "metroLabel1";
            // 
            // amountTxt
            // 
            this.amountTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.amountTxt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.amountTxt.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.amountTxt.CustomButton.Name = "";
            this.amountTxt.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.amountTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountTxt.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.amountTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountTxt.CustomButton.UseSelectable = true;
            this.amountTxt.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.amountTxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.amountTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.amountTxt.Lines = new string[0];
            resources.ApplyResources(this.amountTxt, "amountTxt");
            this.amountTxt.MaxLength = 32767;
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.PasswordChar = '\0';
            this.amountTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountTxt.SelectedText = "";
            this.amountTxt.SelectionLength = 0;
            this.amountTxt.SelectionStart = 0;
            this.amountTxt.ShortcutsEnabled = true;
            this.amountTxt.UseCustomBackColor = true;
            this.amountTxt.UseCustomForeColor = true;
            this.amountTxt.UseSelectable = true;
            this.amountTxt.UseStyleColors = true;
            this.amountTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.amountTxt.Click += new System.EventHandler(this.amountTxt_Click);
            // 
            // resultLbl
            // 
            resources.ApplyResources(this.resultLbl, "resultLbl");
            this.resultLbl.BackColor = System.Drawing.Color.White;
            this.resultLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.resultLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.resultLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Style = MetroFramework.MetroColorStyle.Black;
            this.resultLbl.UseCustomBackColor = true;
            this.resultLbl.UseCustomForeColor = true;
            this.resultLbl.UseStyleColors = true;
            this.resultLbl.Click += new System.EventHandler(this.resultLbl_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseCustomBackColor = true;
            this.clearButton.UseCustomForeColor = true;
            this.clearButton.UseSelectable = true;
            this.clearButton.UseStyleColors = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.changeBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.changeBtn.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.changeBtn, "changeBtn");
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.UseCustomBackColor = true;
            this.changeBtn.UseCustomForeColor = true;
            this.changeBtn.UseSelectable = true;
            this.changeBtn.UseStyleColors = true;
            // 
            // dateLabel
            // 
            this.dateLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.UseCustomBackColor = true;
            this.dateLabel.UseCustomForeColor = true;
            this.dateLabel.UseStyleColors = true;
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.UseCustomBackColor = true;
            this.timeLabel.UseCustomForeColor = true;
            this.timeLabel.UseStyleColors = true;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.toCombo);
            this.Controls.Add(this.fromCombo);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel fromLabel;
        private MetroFramework.Controls.MetroLabel toLabel;
        private MetroFramework.Controls.MetroComboBox fromCombo;
        private MetroFramework.Controls.MetroComboBox toCombo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox amountTxt;
        private MetroFramework.Controls.MetroLabel resultLbl;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton changeBtn;
        private MetroFramework.Controls.MetroLabel dateLabel;
        private MetroFramework.Controls.MetroLabel timeLabel;
    }
}

