using Tesseract;
using System.IO;
using Emgu.CV;

namespace image_to_text
{
    public partial class Form1 : Form
    {
        private string currentImagePath;
        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage.Image == null)
            {
                MessageBox.Show("Please select an image first.", "No Image",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            toolStripStatusLabel1.Text = "Extracting text...";
            this.Cursor = Cursors.WaitCursor;
            if (radioButton5.Checked == true)
            {
                if (!string.IsNullOrEmpty(currentImagePath))
                {
                    string extractedText = ExtractTextFromImage(currentImagePath, "fas+eng");
                    richTextBoxResult.Text = extractedText;
                }
                else
                {
                    MessageBox.Show("Image path not found. Please select the image again.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radioButton4.Checked == true)
            {
                if (!string.IsNullOrEmpty(currentImagePath))
                {
                    string extractedText = ExtractTextFromImageEn(currentImagePath, "eng");
                    richTextBoxResult.Text = extractedText;
                }
                else
                {
                    MessageBox.Show("Image path not found. Please select the image again.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radioButton1.Checked == true)
            {
                if (!string.IsNullOrEmpty(currentImagePath))
                {
                    string extractedText = ExtractTextFromImageFA(currentImagePath, "fas");
                    richTextBoxResult.Text = extractedText;
                }
                else
                {
                    MessageBox.Show("Image path not found. Please select the image again.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Cursor = Cursors.Default;
            toolStripStatusLabel1.Text = "Ready";
        }
        private void selectImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            {
                ofd.Title = "Select an Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tiff";
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofd.FileName;
                    currentImagePath = ofd.FileName;
                    pictureBoxImage.Image = Image.FromFile(imagePath);
                    toolStripStatusLabel1.Text = $"Image loaded: {System.IO.Path.GetFileName(imagePath)}" + "\n"+" click here for generate the photo";
                }
            }
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }
        private string ExtractTextFromImage(string imagePath, string language = "eng+fas")
        {
            try
            {

                string tessDataPath = Path.Combine(Application.StartupPath, "tessdata");


                if (!Directory.Exists(tessDataPath))
                {
                    return $"Error: tessdata folder not found at {tessDataPath}";
                }

                using (var engine = new TesseractEngine(tessDataPath, language, EngineMode.Default))
                {
                    engine.DefaultPageSegMode = PageSegMode.SingleBlock;
                    //string extractedText = ExtractTextFromImage(currentImagePath, "fas+eng");
                    // engine.DefaultPageSegMode = PageSegMode.SingleLine;
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            return page.GetText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        private string ExtractTextFromImageFA(string imagePath, string language = "fas")
        {
            try
            {

                string tessDataPath = Path.Combine(Application.StartupPath, "tessdata");


                if (!Directory.Exists(tessDataPath))
                {
                    return $"Error: tessdata folder not found at {tessDataPath}";
                }

                using (var engine = new TesseractEngine(tessDataPath, language, EngineMode.LstmOnly))
                {
                    engine.SetVariable("preserve_interword_spaces", "1");
                    engine.DefaultPageSegMode = PageSegMode.Auto;
                    engine.SetVariable("tessedit_char_whitelist", "\"ابپتثجچحخدذرزژسشصضطظعغفقکگلمنوهی۰۱۲۳۴۵۶۷۸۹،.؟! \"");

                    //string extractedText = ExtractTextFromImage(currentImagePath, "fas+eng");
                    // engine.DefaultPageSegMode = PageSegMode.SingleLine;
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {

                            return page.GetText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        private string ExtractTextFromImageEn(string imagePath, string language = "eng")
        {
            try
            {

                string tessDataPath = Path.Combine(Application.StartupPath, "tessdata");


                if (!Directory.Exists(tessDataPath))
                {
                    return $"Error: tessdata folder not found at {tessDataPath}";
                }

                using (var engine = new TesseractEngine(tessDataPath, language, EngineMode.Default))
                {
                    engine.DefaultPageSegMode = PageSegMode.SingleBlock;
                    //string extractedText = ExtractTextFromImage(currentImagePath, "fas+eng");
                    // engine.DefaultPageSegMode = PageSegMode.SingleLine;
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            return page.GetText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void noteOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToANoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxResult.Text))
            {
                MessageBox.Show("No text to save! Please extract text first.", "Empty Content",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Select a Note File";
            OFD.Filter = "Text Files|*.txt|All Files|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
            {

                string noteFilePath = OFD.FileName;
                try
                {
                    File.AppendAllText(noteFilePath, richTextBoxResult.Text + Environment.NewLine);
                    MessageBox.Show("Text added to the note successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void creatANoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxResult.Text))
            {
                MessageBox.Show("No text to save! Please extract text first.", "Empty Content",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // File.WriteAllText("note.txt", richTextBoxResult.Text);
            using SaveFileDialog OFD = new SaveFileDialog();
            OFD.Title = "Select a Note File";
            OFD.Filter = "Text Files|*.txt|All Files|*.*";
            //OFD.Filter = "text |*.txt| all files |*.*|";
            OFD.FilterIndex = 1;
            OFD.DefaultExt = "txt";
            OFD.FileName = $"gini_Result_{DateTime.Now:yyyyMMdd_HHmmss}";
            bool sucsess = false;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = OFD.FileName;
                try
                {


                    File.WriteAllText(selectedPath, richTextBoxResult.Text, System.Text.Encoding.UTF8);
                    sucsess = true;

                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show($"Access denied: {ex.Message}");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"File error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}");
                }
            }
            if (sucsess)
            {
                toolStripStatusLabel1.Text = "File created successfully." + OFD.FileName;
            }
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBoxResult.Text);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }

        }
    }
}
