using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS {
    public class GameItems {
        public Dictionary<string, bool> classes;

        public enum CrystalType {
            Rhomb = 0,
            Cabochon = 1,
            Hexage = 2,
            Pentant = 3,
            Concach = 4,
            Crux = 5,
            Niveot = 6
        }
        public enum Rarity {
            Common = 0,
            Uncommon = 1
        }
        public enum StaticRoll {
            critFactor = 1,


        }
        public class AccessoryCrystal {
            #region Public Fields
            string Name;
            string type;
            string rarity;
            int level;
            string imagePath;
            Dictionary <string, bool> classes = new Dictionary<string, bool> ();
            bool unique;

            public AccessoryCrystal () {
                // Set up dictionary (make it all false)
                foreach (KeyValuePair <string, bool> entry in classes) {
                    classes[entry.Key] = false;
                }
            }

            public void addClasses (string line) {
                line = line.Replace (" ", "");
                line = line.Split ('=')[1];
                string[] chars = line.Split (',');

                foreach (string c in chars) {
                    if (classes.ContainsKey (c)) {
                        classes[c] = true;
                    }
                }
            }
            #endregion Public Fields
        }
    }
}
