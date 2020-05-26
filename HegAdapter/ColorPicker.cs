using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BxAdapter {
    public partial class ColorPicker : Form {
        BxAdapter MyBxAdapter;
        Color InitialColor;

        List<Color> Colors = new List<Color>();

        public ColorPicker(BxAdapter bxAdapter) {
        

            InitializeComponent();
            MyBxAdapter = bxAdapter;
            this.StartPosition= FormStartPosition.CenterParent;
            C.LockFormSizeAndSetTopmost(this);

            //special colors: black, white, transparent
            //custom colors
            //predefined colors
            //red orange yellow blue green indigo violet
            //blue green purple orange yellow red

            Colors.Add(Color.FromArgb(10, 59, 118)); //dark blue
            Colors.Add(Color.FromArgb(67, 149, 209)); //sky blue
            Colors.Add(Color.FromArgb(153, 217, 234)); //light blue
            Colors.Add(Color.FromArgb(0, 118, 163)); // blue-green
            Colors.Add(Color.FromArgb(122, 204, 200)); // medium turquoise
            Colors.Add(Color.FromArgb(202, 130, 156)); // medium green
            Colors.Add(Color.FromArgb(13, 104, 107)); // dark green blue

            Colors.Add(Color.FromArgb(0, 0, 0)); // black
            Colors.Add(Color.FromArgb(220, 220, 220)); // light gray
            Colors.Add(Color.FromArgb(120, 120, 120)); // dark gray
            
            Colors.Add(Color.FromArgb(255, 244, 104)); // bright yellow
            Colors.Add(Color.FromArgb(255, 247, 153)); // post it yellow
            
            Colors.Add(Color.FromArgb(216, 81, 113)); // deep pink
            Colors.Add(Color.FromArgb(184, 40, 50)); // rich red
            
            Colors.Add(Color.FromArgb(255, 194, 14)); // medium orange
            Colors.Add(Color.FromArgb(140, 98, 57)); // medium brown

            foreach (Color c in Colors) {
                Button b = new Button();
                b.BackColor = c;
                b.FlatStyle = FlatStyle.Flat;
                b.Width = 30;
                b.Height = b.Width;
                b.ForeColor = b.BackColor;
                b.Click += new EventHandler(btnSetBackgroundColor_Click);
                this.flowButton.Controls.Add(b);
            }

        }

        private void btnSelectCustomColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            colorDialog.ShowDialog();
        }

        private void ColorPicker_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                HideForm();
            }
        }

        private void HideForm() {
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            HideForm();        
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            SetBackgroundColor(InitialColor);
            HideForm();        
        }

        private Color GetVisibileForeColorForBackColor(Color backColor) {
            Color foreColor = new Color();
            if (backColor.R < 128 || backColor.G < 128 || backColor.B < 128) {
                foreColor = Color.White;
            } else {
                foreColor = Color.Black;
            }
            if (backColor == Color.Yellow) {
                foreColor = Color.Black;
            }
            return foreColor;
        }

        private void SetColorPreview(Color color) {
            lblDirections.BackColor = color;
            lblDirections.ForeColor = GetVisibileForeColorForBackColor(color);
        }

        private void SetBackgroundColor(Color newBackgroundColor) {
            SetColorPreview(newBackgroundColor);
            MyBxAdapter.SetBackgroundColor(newBackgroundColor);           
        }

        private void btnSetBackgroundColor_Click(object sender, EventArgs e) {
            Button button = sender as Button;
            SetBackgroundColor(button.BackColor);
        }

        private void ColorPicker_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                InitialColor = Globals.BackgroundColor;
                SetColorPreview(Globals.BackgroundColor);
            }
        }

    }
}
