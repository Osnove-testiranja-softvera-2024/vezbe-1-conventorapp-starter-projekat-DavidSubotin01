using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public class MassConvert : IConvert
    {
        public string Convert(string start)
        {
            try
            {
                double result = Math.Round(Double.Parse(start) * 0.453592, 3);
                return result.ToString();
            }
            catch
            {
                MessageBox.Show("Uneta je pograsna vrednost", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
