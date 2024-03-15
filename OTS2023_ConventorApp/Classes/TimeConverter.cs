using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    internal class TimeConverter : ITime
    {
        public string ConvertHours(string start)
        {
            try
            {
                double result = Math.Round(Double.Parse(start) * 24, 3);
                return result.ToString();
            }
            catch
            {
                MessageBox.Show("Uneta je pogresna vrednost", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string ConvertMinutes(string start)
        {
            try
            {
                double result = Math.Round(Double.Parse(start) * 24 * 60, 3);
                return result.ToString();
            }
            catch
            {
                MessageBox.Show("Uneta je pogresna vrednost", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string ConvertSeconds(string start)
        {
            try
            {
                double result = Math.Round(Double.Parse(start) * 24 * 360, 3);
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
