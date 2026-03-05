using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AccessiblePad
{
    public partial class Form1 : Form
    {
        // We define our UI elements here
        RichTextBox noteArea = new RichTextBox();
        Button contrastBtn = new Button();
        Button saveBtn = new Button();
        Button openBtn = new Button();

        public Form1()
        {
            this.Size = new Size(800, 600);
            this.Text = "Accessible Notepad";

            // Text Area
            noteArea.Dock = DockStyle.Top;
            noteArea.Height = 350;
            noteArea.Font = new Font("Segoe UI", 18);
            noteArea.AccessibleName = "Main text typing area";

            /* Open Button
            openBtn.Text = "Open File";
            openBtn.Dock = DockStyle.Top;
            openBtn.Height = 60;
            openBtn.Click += (s, e) => OpenFile();
            openBtn.AccessibleName = "Open a file from your computer";
            */

            // Save Button
            saveBtn.Text = "Save File";
            saveBtn.Dock = DockStyle.Top;
            saveBtn.Height = 60;
            saveBtn.Click += (s, e) => saveFile();
            saveBtn.AccessibleName = "Save current text to a file";

            // Contrast Button
            contrastBtn.Text = "Toggle High Contrast";
            contrastBtn.Dock = DockStyle.Bottom;
            contrastBtn.Height = 80;
            contrastBtn.BackColor = Color.LightGray;
            contrastBtn.Click += (s, e) => ToggleContrast();

            // Add them to the window
            this.Controls.Add(noteArea);
            this.Controls.Add(contrastBtn);
            this.Controls.Add(saveBtn);
            this.Controls.Add(openBtn);
        }

        void ToggleContrast()
        {
            if (noteArea.BackColor == Color.Black)
            {
                noteArea.BackColor = Color.White;
                noteArea.ForeColor = Color.Black;
            }
            else
            {
                noteArea.BackColor = Color.Black;
                noteArea.ForeColor = Color.Yellow;
            }
        }

        void saveFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, noteArea.Text);
                MessageBox.Show("File saved successfully");
            }
        }
    }
}