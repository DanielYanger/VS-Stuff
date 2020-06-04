namespace NET_Testing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDevice = new System.Windows.Forms.Button();
            this.devicePath = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.importSection = new System.Windows.Forms.Label();
            this.sechduleLabel = new System.Windows.Forms.Label();
            this.eventCode = new System.Windows.Forms.TextBox();
            this.eventCodeLabel = new System.Windows.Forms.Label();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.apiKeyTextbox = new System.Windows.Forms.TextBox();
            this.scheduleGeneratorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pythonexeFile = new System.Windows.Forms.TextBox();
            this.PythonExe = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartApplicationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // restartApplicationToolStripMenuItem
            // 
            this.restartApplicationToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.restartApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.restartApplicationToolStripMenuItem.Name = "restartApplicationToolStripMenuItem";
            this.restartApplicationToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.restartApplicationToolStripMenuItem.Text = "Clear";
            this.restartApplicationToolStripMenuItem.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripHelp,
            this.aboutToolStripAbout});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // helpToolStripHelp
            // 
            this.helpToolStripHelp.BackColor = System.Drawing.Color.DimGray;
            this.helpToolStripHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.helpToolStripHelp.Name = "helpToolStripHelp";
            this.helpToolStripHelp.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripHelp.Text = "Help";
            this.helpToolStripHelp.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripAbout
            // 
            this.aboutToolStripAbout.BackColor = System.Drawing.Color.DimGray;
            this.aboutToolStripAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.aboutToolStripAbout.Name = "aboutToolStripAbout";
            this.aboutToolStripAbout.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripAbout.Text = "About";
            this.aboutToolStripAbout.Click += new System.EventHandler(this.aboutToolStripAbout_Click);
            // 
            // chooseDevice
            // 
            this.chooseDevice.ForeColor = System.Drawing.Color.Black;
            this.chooseDevice.Location = new System.Drawing.Point(45, 206);
            this.chooseDevice.Name = "chooseDevice";
            this.chooseDevice.Size = new System.Drawing.Size(109, 20);
            this.chooseDevice.TabIndex = 1;
            this.chooseDevice.Text = "Choose Device";
            this.chooseDevice.UseVisualStyleBackColor = true;
            this.chooseDevice.Click += new System.EventHandler(this.chooseDevice_Click);
            // 
            // devicePath
            // 
            this.devicePath.Location = new System.Drawing.Point(160, 206);
            this.devicePath.Name = "devicePath";
            this.devicePath.Size = new System.Drawing.Size(197, 20);
            this.devicePath.TabIndex = 3;
            this.devicePath.TextChanged += new System.EventHandler(this.devicePath_TextChanged);
            // 
            // importButton
            // 
            this.importButton.ForeColor = System.Drawing.Color.Black;
            this.importButton.Location = new System.Drawing.Point(130, 245);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(101, 23);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.title.Location = new System.Drawing.Point(12, 46);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(138, 25);
            this.title.TabIndex = 6;
            this.title.Text = "624 Scouting";
            // 
            // importSection
            // 
            this.importSection.AutoSize = true;
            this.importSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.importSection.Location = new System.Drawing.Point(24, 177);
            this.importSection.Name = "importSection";
            this.importSection.Size = new System.Drawing.Size(142, 20);
            this.importSection.TabIndex = 7;
            this.importSection.Text = "Import Match Data";
            // 
            // sechduleLabel
            // 
            this.sechduleLabel.AutoSize = true;
            this.sechduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sechduleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.sechduleLabel.Location = new System.Drawing.Point(13, 308);
            this.sechduleLabel.Name = "sechduleLabel";
            this.sechduleLabel.Size = new System.Drawing.Size(153, 20);
            this.sechduleLabel.TabIndex = 8;
            this.sechduleLabel.Text = "Schedule Generator";
            this.sechduleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventCode
            // 
            this.eventCode.Location = new System.Drawing.Point(150, 340);
            this.eventCode.Name = "eventCode";
            this.eventCode.Size = new System.Drawing.Size(197, 20);
            this.eventCode.TabIndex = 9;
            this.eventCode.TextChanged += new System.EventHandler(this.eventCode_TextChanged);
            // 
            // eventCodeLabel
            // 
            this.eventCodeLabel.AutoSize = true;
            this.eventCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.eventCodeLabel.Location = new System.Drawing.Point(44, 340);
            this.eventCodeLabel.Name = "eventCodeLabel";
            this.eventCodeLabel.Size = new System.Drawing.Size(89, 18);
            this.eventCodeLabel.TabIndex = 10;
            this.eventCodeLabel.Text = "Event Code:";
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.apiKeyLabel.Location = new System.Drawing.Point(70, 373);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(63, 18);
            this.apiKeyLabel.TabIndex = 12;
            this.apiKeyLabel.Text = "API Key:";
            this.apiKeyLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // apiKeyTextbox
            // 
            this.apiKeyTextbox.Location = new System.Drawing.Point(150, 374);
            this.apiKeyTextbox.Name = "apiKeyTextbox";
            this.apiKeyTextbox.Size = new System.Drawing.Size(197, 20);
            this.apiKeyTextbox.TabIndex = 11;
            this.apiKeyTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // scheduleGeneratorButton
            // 
            this.scheduleGeneratorButton.ForeColor = System.Drawing.Color.Black;
            this.scheduleGeneratorButton.Location = new System.Drawing.Point(120, 410);
            this.scheduleGeneratorButton.Name = "scheduleGeneratorButton";
            this.scheduleGeneratorButton.Size = new System.Drawing.Size(101, 23);
            this.scheduleGeneratorButton.TabIndex = 13;
            this.scheduleGeneratorButton.Text = "Generate";
            this.scheduleGeneratorButton.UseVisualStyleBackColor = true;
            this.scheduleGeneratorButton.Click += new System.EventHandler(this.scheduleGeneratorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Python Engine";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pythonexeFile
            // 
            this.pythonexeFile.Location = new System.Drawing.Point(162, 113);
            this.pythonexeFile.Name = "pythonexeFile";
            this.pythonexeFile.Size = new System.Drawing.Size(197, 20);
            this.pythonexeFile.TabIndex = 15;
            this.pythonexeFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PythonExe
            // 
            this.PythonExe.BackColor = System.Drawing.Color.Transparent;
            this.PythonExe.ForeColor = System.Drawing.Color.Black;
            this.PythonExe.Location = new System.Drawing.Point(47, 113);
            this.PythonExe.Name = "PythonExe";
            this.PythonExe.Size = new System.Drawing.Size(109, 20);
            this.PythonExe.TabIndex = 14;
            this.PythonExe.Text = "Choose Python";
            this.PythonExe.UseVisualStyleBackColor = false;
            this.PythonExe.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(392, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pythonexeFile);
            this.Controls.Add(this.PythonExe);
            this.Controls.Add(this.scheduleGeneratorButton);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.apiKeyTextbox);
            this.Controls.Add(this.eventCodeLabel);
            this.Controls.Add(this.eventCode);
            this.Controls.Add(this.sechduleLabel);
            this.Controls.Add(this.importSection);
            this.Controls.Add(this.title);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.devicePath);
            this.Controls.Add(this.chooseDevice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "624 Scouting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripAbout;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button chooseDevice;
        private System.Windows.Forms.TextBox devicePath;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label importSection;
        private System.Windows.Forms.Label sechduleLabel;
        private System.Windows.Forms.TextBox eventCode;
        private System.Windows.Forms.Label eventCodeLabel;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox apiKeyTextbox;
        private System.Windows.Forms.Button scheduleGeneratorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pythonexeFile;
        private System.Windows.Forms.Button PythonExe;
    }
}

