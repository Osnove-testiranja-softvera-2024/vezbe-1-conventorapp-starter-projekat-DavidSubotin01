using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    internal class MoneyConverter : IConvert
    {
        public string Convert(string start)
        {
            try
            {
                double result = Math.Round(Double.Parse(start) * 117.18, 3);
                return result.ToString();
            }
            catch
            {
                MessageBox.Show("Uneta je pogresna vrednost", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
