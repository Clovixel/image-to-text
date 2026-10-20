namespace image_to_text
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxImage = new PictureBox();
            richTextBoxResult = new RichTextBox();
            statusStripMain = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStripMain = new MenuStrip();
            selectImageToolStripMenuItem = new ToolStripMenuItem();
            noteOptionToolStripMenuItem = new ToolStripMenuItem();
            addToANoteToolStripMenuItem = new ToolStripMenuItem();
            creatANoteToolStripMenuItem = new ToolStripMenuItem();
            copyToClipboardToolStripMenuItem = new ToolStripMenuItem();
            radioButton1 = new RadioButton();
            label1 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            statusStripMain.SuspendLayout();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(185, 67);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(470, 292);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            pictureBoxImage.Click += pictureBoxImage_Click;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Location = new Point(185, 395);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(470, 152);
            richTextBoxResult.TabIndex = 1;
            richTextBoxResult.Text = "";
            // 
            // statusStripMain
            // 
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStripMain.Location = new Point(0, 583);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1140, 22);
            statusStripMain.TabIndex = 2;
            statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // menuStripMain
            // 
            menuStripMain.BackColor = SystemColors.ActiveBorder;
            menuStripMain.Items.AddRange(new ToolStripItem[] { selectImageToolStripMenuItem, noteOptionToolStripMenuItem, copyToClipboardToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.RightToLeft = RightToLeft.Yes;
            menuStripMain.Size = new Size(1140, 24);
            menuStripMain.TabIndex = 3;
            menuStripMain.Text = "menuStripMain";
            // 
            // selectImageToolStripMenuItem
            // 
            selectImageToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            selectImageToolStripMenuItem.Checked = true;
            selectImageToolStripMenuItem.CheckState = CheckState.Checked;
            selectImageToolStripMenuItem.Name = "selectImageToolStripMenuItem";
            selectImageToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            selectImageToolStripMenuItem.Size = new Size(86, 20);
            selectImageToolStripMenuItem.Text = "Select Image";
            selectImageToolStripMenuItem.Click += selectImageToolStripMenuItem_Click_1;
            // 
            // noteOptionToolStripMenuItem
            // 
            noteOptionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToANoteToolStripMenuItem, creatANoteToolStripMenuItem });
            noteOptionToolStripMenuItem.Name = "noteOptionToolStripMenuItem";
            noteOptionToolStripMenuItem.Size = new Size(82, 20);
            noteOptionToolStripMenuItem.Text = "NoteOption";
            noteOptionToolStripMenuItem.Click += noteOptionToolStripMenuItem_Click;
            // 
            // addToANoteToolStripMenuItem
            // 
            addToANoteToolStripMenuItem.Name = "addToANoteToolStripMenuItem";
            addToANoteToolStripMenuItem.Size = new Size(144, 22);
            addToANoteToolStripMenuItem.Text = "add to a note";
            addToANoteToolStripMenuItem.Click += addToANoteToolStripMenuItem_Click;
            // 
            // creatANoteToolStripMenuItem
            // 
            creatANoteToolStripMenuItem.Name = "creatANoteToolStripMenuItem";
            creatANoteToolStripMenuItem.Size = new Size(144, 22);
            creatANoteToolStripMenuItem.Text = "creat a note";
            creatANoteToolStripMenuItem.Click += creatANoteToolStripMenuItem_Click;
            // 
            // copyToClipboardToolStripMenuItem
            // 
            copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            copyToClipboardToolStripMenuItem.Size = new Size(112, 20);
            copyToClipboardToolStripMenuItem.Text = "copy to clipboard";
            copyToClipboardToolStripMenuItem.Click += copyToClipboardToolStripMenuItem_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ButtonShadow;
            radioButton1.Location = new Point(735, 202);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "farsi";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(724, 110);
            label1.Name = "label1";
            label1.Size = new Size(356, 119);
            label1.TabIndex = 7;
            label1.Text = "slecet a language";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = SystemColors.ButtonShadow;
            radioButton4.Location = new Point(874, 202);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(45, 19);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "eng";
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = SystemColors.ButtonShadow;
            radioButton5.Location = new Point(986, 202);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(68, 19);
            radioButton5.TabIndex = 6;
            radioButton5.TabStop = true;
            radioButton5.Text = "fas+eng";
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 605);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton1);
            Controls.Add(menuStripMain);
            Controls.Add(statusStripMain);
            Controls.Add(richTextBoxResult);
            Controls.Add(pictureBoxImage);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Name = "Form1";
            Text = "Image to text";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImage;
        private RichTextBox richTextBoxResult;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem selectImageToolStripMenuItem;
        private RadioButton radioButton1;
        private Label label1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private ToolStripMenuItem noteOptionToolStripMenuItem;
        private ToolStripMenuItem addToANoteToolStripMenuItem;
        private ToolStripMenuItem creatANoteToolStripMenuItem;
        private ToolStripMenuItem copyToClipboardToolStripMenuItem;
    }
}
