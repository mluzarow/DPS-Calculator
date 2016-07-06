using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DPS {
    public partial class fTeraMain : Form {
        public fTeraMain () {
            InitializeComponent();
        }



        #region Drag and Drop Processing (Drop)
        //
        // pbGemAcc00
        //
        private void pbGemAcc00_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemAcc00_DragDrop (object sender, DragEventArgs e) {
            pbGemAcc00.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemAcc01
        //
        private void pbGemAcc01_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemAcc01_DragDrop (object sender, DragEventArgs e) {
            pbGemAcc01.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemAcc02
        private void pbGemAcc02_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemAcc02_DragDrop (object sender, DragEventArgs e) {
            pbGemAcc02.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemAcc03
        //
        private void pbGemAcc03_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemAcc03_DragDrop (object sender, DragEventArgs e) {
            pbGemAcc03.Image =  (Image) e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemAtt00
        //
        private void pbGemAtt00_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemAtt00_DragDrop (object sender, DragEventArgs e) {
            pbGemAtt00.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemAtt01
        //
        private void pbGemAtt01_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemAtt01_DragDrop (object sender, DragEventArgs e) {
            pbGemAtt01.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemAtt02
        //
        private void pbGemAtt02_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemAtt02_DragDrop (object sender, DragEventArgs e) {
            pbGemAtt02.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemAtt03
        //
        private void pbGemAtt03_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemAtt03_DragDrop (object sender, DragEventArgs e) {
            pbGemAtt03.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        #endregion Drag and Drop Processing (Drop)



        private void pictureBox1_MouseDown (object sender, MouseEventArgs e) {
            pictureBox1.DoDragDrop (pictureBox1.Image, DragDropEffects.Copy | DragDropEffects.Move);
        }

    }
}
