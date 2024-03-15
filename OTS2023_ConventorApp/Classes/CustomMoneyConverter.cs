using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp.Classes
{
    internal class CustomMoneyConverter : IConvert
    {
        public string Convert(string start)
        {
            try
            {
                string[] label = start.Split(' ');
                string value = label[0];
                string currency1 = label[1];
                string currency2 = label[3];

                if (currency1 == "$")
                {
                    return Math.Round(Double.Parse(value) * 0.92, 3).ToString();
                }
                else if (currency1 == "€" && currency2 == "$")
                {
                    return Math.Round(Double.Parse(value) * 1.09, 3).ToString();
                }
                else if (currency1 == "€" && currency2 == "£")
                {
                    return Math.Round(Double.Parse(value) * 0.85, 3).ToString();
                }
                else if (currency2 == "€" && currency1 == "£")
                {
                    return Math.Round(Double.Parse(value) * 1.17, 3).ToString();
                }
                else
                {
                    MessageBox.Show("Pogresno uneta valuta za konverziju", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("Pogresno uneta vrednost za konverziju", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
