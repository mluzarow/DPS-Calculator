﻿using System;
using System.Windows.Forms;
using System.IO;

namespace DPS {
    public partial class Form1 : Form {
        #region Structs
        /// <summary>
        /// Stores DPS data as a struct / class of floats.
        /// </summary>
        private class DPS_Data {
            #region Public Fields
            /// <summary>
            /// The base damage of the target.
            /// </summary>
            public float damage;
            /// <summary>
            /// The attacks per second performed by the target.
            /// </summary>
            public float attackSpeed;
            /// <summary>
            /// The percentage chance the target has of getting a critical hit, per each hit.
            /// </summary>
            public float critChance;
            /// <summary>
            /// The critical damage of the target.
            /// </summary>
            public float critDamage;
            /// <summary>
            /// Calculated damage output with no critical hits.
            /// </summary>
            public float calcDamage;
            /// <summary>
            /// Calculated all critical damage output (theoretical maximum).
            /// </summary>
            public float calcCritDamage;
            /// <summary>
            /// Calculated estimate of damage target will do.
            /// </summary>
            public float calcEstimate;
            #endregion Public Fields
            
            #region Constructor
            /// <summary>
            /// Full variable constructor.  Will save all variables as well as calculate output via CalculateDamage() upon call.
            /// </summary>
            /// <param name="damage">
            /// The base damage of the target.
            /// </param>
            /// <param name="attackSpeed">
            /// The attacks per second performed by the target.
            /// </param>
            /// <param name="critChance">
            /// The percentage chance the target has of getting a critical hit, per each hit.
            /// </param>
            /// <param name="critDamage">
            /// The critical damage of the target.
            /// </param>
            public DPS_Data (float damage, float attackSpeed, float critChance, float critDamage) {
                this.damage = damage;
                this.attackSpeed = attackSpeed;
                this.critChance = critChance;
                this.critDamage = critDamage;

                CalculateDamage ();
            }
            /// <summary>
            /// Empty constructor.  Won't do anything; just here to be the default.
            /// </summary>
            public DPS_Data () {
                
            }
            #endregion Constructor

            #region Public Methods
            /// <summary>
            /// Uses internal class values in order to calculate the variables calcDamage, calcCritDamage, and calcEstimate.  Output is saved in the class.
            /// </summary>
            public void CalculateDamage () {
                this.calcDamage = this.damage * this.attackSpeed;
                this.calcCritDamage = this.damage * this.attackSpeed * this.critDamage;
                this.calcEstimate = (this.damage * this.attackSpeed * (1 - this.critChance)) + (this.damage * this.attackSpeed * this.critChance * this.critDamage);
            }
            #endregion Public Methods
        }
        #endregion Structs



        #region Private Variables
        /// <summary>
        /// Main instance of the DPS_Data class.
        /// </summary>
        private DPS_Data dpsData = new DPS_Data ();
        /// <summary>
        /// Constantly holding the path to the save data.
        /// </summary>
        private string DPS_PATH = Application.StartupPath + "\\Save Data\\";
        /// <summary>
        /// Constant hold the default dialog filters.
        /// </summary>
        private const string DPS_FILTER = "DPS Meter files (*.dps)|*.dps|All files (*.*)|*.*";
        #endregion Private Variables



        public Form1 () {
            InitializeComponent();
        }

        private void printDPS () {
            txt_dmg.Text = dpsData.damage.ToString ();
            txt_rate.Text = dpsData.attackSpeed.ToString ();
            txt_chance.Text = dpsData.critChance.ToString ();
            txt_critDmg.Text = dpsData.critDamage.ToString ();
            lbl_raw.Text = dpsData.calcDamage.ToString ();
            lbl_crit.Text = dpsData.calcCritDamage.ToString ();
            lbl_est.Text = dpsData.calcEstimate.ToString ();
        }



        #region Calculation
        private void btn_calc_Click (object sender, EventArgs e) {
            bool error = false;
            // Attempt int parse of textbox text to floats

            // If txt_dmg is not parseable
            if (!float.TryParse(txt_dmg.Text, out dpsData.damage)) {
                // Label the textbox as incorrect and return control
                txt_dmg.BackColor = System.Drawing.Color.Red;
                error = true;
            }
            if (!float.TryParse (txt_rate.Text, out dpsData.attackSpeed)) {
                txt_rate.BackColor = System.Drawing.Color.Red;
                error = true;
            }
            if (!float.TryParse(txt_chance.Text, out dpsData.critChance)) {
                txt_chance.BackColor = System.Drawing.Color.Red;
                error = true;
            }
            if (!float.TryParse(txt_critDmg.Text, out dpsData.critDamage)) {
                txt_critDmg.BackColor = System.Drawing.Color.Red;
                error = true;
            }

            if (!error) {
                //Calc
                dpsData.CalculateDamage ();
                printDPS ();
            }
        }

        private void txt_dmg_TextChanged (object sender, EventArgs e) {
            if (txt_dmg.BackColor == System.Drawing.Color.Red) {
                txt_dmg.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_rate_TextChanged (object sender, EventArgs e) {
            if (txt_rate.BackColor == System.Drawing.Color.Red) {
                txt_rate.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_chance_TextChanged (object sender, EventArgs e) {
            if (txt_chance.BackColor == System.Drawing.Color.Red) {
                txt_chance.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_critDmg_TextChanged (object sender, EventArgs e) {
            if (txt_critDmg.BackColor == System.Drawing.Color.Red) {
                txt_critDmg.BackColor = System.Drawing.Color.White;
            }
        }
        #endregion Calculation



        #region IO
        private void btn_save_Click (object sender, EventArgs e) {
            Stream f = null;
            StreamWriter fw = null;
            SaveFileDialog fs = new SaveFileDialog ();

            fs.InitialDirectory = DPS_PATH;
            fs.Filter = DPS_FILTER;
            fs.FilterIndex = 1;
            fs.RestoreDirectory = true;

            if (fs.ShowDialog () == DialogResult.OK) {
                try {
                    if ((f = fs.OpenFile()) != null) {
                        using (fw = new StreamWriter(f)) {
                            fw.WriteLine(dpsData.damage + "/" + dpsData.attackSpeed + "/" + dpsData.critChance + "/" + dpsData.critDamage + "/" + dpsData.calcDamage + "/" + dpsData.calcCritDamage + "/" + dpsData.calcEstimate);
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Could not save file.\n" + ex.Message);
                }
            }
        }

        private void btn_load_Click (object sender, EventArgs e) {
            Stream f = null;
            StreamReader fr = null;
            OpenFileDialog fd = new OpenFileDialog ();
            string line = "";

            fd.InitialDirectory = DPS_PATH;
            fd.Filter = DPS_FILTER;
            fd.FilterIndex = 1;
            fd.RestoreDirectory = true;

            if (fd.ShowDialog () == DialogResult.OK) {
                try {
                    if ((f = fd.OpenFile ()) != null) {
                        using (fr = new StreamReader (f)) {
                            line = fr.ReadLine ();

                            string[] lineSplit = line.Split('/');
                            dpsData.damage = Convert.ToSingle (lineSplit[0]);
                            dpsData.attackSpeed = Convert.ToSingle(lineSplit[1]);
                            dpsData.critChance = Convert.ToSingle(lineSplit[2]);
                            dpsData.critDamage = Convert.ToSingle(lineSplit[3]);
                            dpsData.calcDamage = Convert.ToSingle(lineSplit[4]);
                            dpsData.calcCritDamage = Convert.ToSingle(lineSplit[5]);
                            dpsData.calcEstimate = Convert.ToSingle(lineSplit[6]);

                            printDPS ();
                        }

                        f.Close ();
                        fr.Close ();
                    }
                } catch (Exception ex) {
                    MessageBox.Show ("Could not load save file.\n" + ex.Message);
                }
            }
        }
        #endregion IO

        private void button1_Click (object sender, EventArgs e) {
            fTeraMain tera = new fTeraMain ();
            tera.Show ();
        }
    }
}
