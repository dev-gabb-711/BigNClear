using System;
using System.Drawing;
using System.Windows.Forms;

namespace AccessiblePad
{
    public partial class Form1 : Form
    {
        // We define our UI elements here
        RichTextBox noteArea = new RichTextBox();
        Button contrastBtn = new Button();

        public Form1()
        {
            this.Size = new Size(600, 500);
            this.Text = "Accessible Notepad";

            // 1. Setup the Text Area
            noteArea.Dock = DockStyle.Top;
            noteArea.Height = 350;
            noteArea.Font = new Font("Segoe UI", 18);
            noteArea.AccessibleName = "Main text typing area";

            // 2. Setup the Contrast Button
            contrastBtn.Text = "Toggle High Contrast";
            contrastBtn.Dock = DockStyle.Bottom;
            contrastBtn.Height = 80;
            contrastBtn.BackColor = Color.LightGray;
            // This tells the button what to do when clicked
            contrastBtn.Click += (s, e) => ToggleContrast();

            // Add them to the window
            this.Controls.Add(noteArea);
            this.Controls.Add(contrastBtn);
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
    }
}