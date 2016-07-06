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
        //
        // pbGemDef00
        //
        private void pbGemDef00_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemDef00_DragDrop (object sender, DragEventArgs e) {
            pbGemDef00.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemDef01
        //
        private void pbGemDef01_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemDef01_DragDrop (object sender, DragEventArgs e) {
            pbGemDef01.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemDef02
        //
        private void pbGemDef02_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemDef02_DragDrop (object sender, DragEventArgs e) {
            pbGemDef02.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGemDef03
        //
        private void pbGemDef03_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGemDef03_DragDrop (object sender, DragEventArgs e) {
            pbGemDef03.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbEarring00
        //
        private void pbEarring00_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbEarring00_DragDrop (object sender, DragEventArgs e) {
            pbEarring00.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbEarring01
        //
        private void pbEarring01_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbEarring01_DragDrop (object sender, DragEventArgs e) {
            pbEarring01.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbRing00
        //
        private void pbRing00_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbRing00_DragDrop (object sender, DragEventArgs e) {
            pbRing00.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbRing01
        //
        private void pbRing01_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbRing01_DragDrop (object sender, DragEventArgs e) {
            pbRing01.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbWeapon
        //
        private void pbWeapon_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbWeapon_DragDrop (object sender, DragEventArgs e) {
            pbWeapon.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbArmor
        //
        private void pbArmor_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbArmor_DragDrop (object sender, DragEventArgs e) {
            pbArmor.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbGloves
        //
        private void pbGloves_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbGloves_DragDrop (object sender, DragEventArgs e) {
            pbGloves.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbBoots
        //
        private void pbBoots_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbBoots_DragDrop (object sender, DragEventArgs e) {
            pbBoots.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbNecklace
        //
        private void pbNecklace_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbNecklace_DragDrop (object sender, DragEventArgs e) {
            pbNecklace.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbBrooch
        //
        private void pbBrooch_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbBrooch_DragDrop (object sender, DragEventArgs e) {
            pbBrooch.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbInner
        //
        private void pbInner_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbInner_DragDrop (object sender, DragEventArgs e) {
            pbInner.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        //
        // pbBelt
        //
        private void pbBelt_DragEnter (object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pbBelt_DragDrop (object sender, DragEventArgs e) {
            pbBelt.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
        #endregion Drag and Drop Processing (Drop)



        private void pictureBox1_MouseDown (object sender, MouseEventArgs e) {
            pictureBox1.DoDragDrop (pictureBox1.Image, DragDropEffects.Copy | DragDropEffects.Move);
        }

    }
}
