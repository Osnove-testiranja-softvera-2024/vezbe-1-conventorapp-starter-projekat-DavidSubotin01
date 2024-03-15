using OTS2023_ConventorApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rbMass_CheckedChanged_1(object sender, EventArgs e)
        {
            gbTimeOutput.Visible = false;
            lblPocetni.Text = "Pounds:";
            lblRezultat.Text = "KG:";
            lblPocetni.Location = new Point(58, 138);
            lblRezultat.Location = new Point(75, 168);
        }

        private void rbLength_CheckedChanged(object sender, EventArgs e)
        {
            gbTimeOutput.Visible = false;
            lblPocetni.Text = "Feet:";
            lblRezultat.Text = "M:";
            lblPocetni.Location = new Point(66, 138);
            lblRezultat.Location = new Point(80, 168);
        }

        private void rbMoney_CheckedChanged(object sender, EventArgs e)
        {
            gbTimeOutput.Visible = false;
            lblPocetni.Text = "EUR:";
            lblRezultat.Text = "RSD:";
            lblPocetni.Location = new Point(70, 138);
            lblRezultat.Location = new Point(70, 168);
        }

        private void rbTime_CheckedChanged(object sender, EventArgs e)
        {
            gbTimeOutput.Visible = true;
            lblPocetni.Text = "Days:";
            lblPocetni.Location = new Point(66, 138);
        }

        private void rbHours_CheckedChanged(object sender, EventArgs e)
        {
            lblRezultat.Text = "Hours:";
            lblRezultat.Location = new Point(59, 168);
        }

        private void rbMinutes_CheckedChanged(object sender, EventArgs e)
        {
            lblRezultat.Text = "Minutes:";
            lblRezultat.Location = new Point(52, 168);
        }

        private void rbSeconds_CheckedChanged(object sender, EventArgs e)
        {
            lblRezultat.Text = "Seconds:";
            lblRezultat.Location = new Point(48, 168);
        }

        private void rbCustomMoney_CheckedChanged(object sender, EventArgs e)
        {
            lblPocetni.Text = "Custom expression:";
            lblRezultat.Text = "Result:";
            lblPocetni.Location = new Point(10, 138);
            lblRezultat.Location = new Point(52, 168);
        }

        private void btnKonvertuj_Click(object sender, EventArgs e)
        {
            MassConvert massConvert = new MassConvert();
            LenghtConvert lenghtConvert = new LenghtConvert();
            MoneyConverter moneyConverter = new MoneyConverter();
            TimeConverter timeConverter = new TimeConverter();
            CustomMoneyConverter customMoneyConverter = new CustomMoneyConverter();

            if (rbMass.Checked)
            {
                tbRezultat.Text = massConvert.Convert(tbPocetni.Text);
            }
            else if (rbLength.Checked)
            {
                tbRezultat.Text = lenghtConvert.Convert(tbPocetni.Text);
            }
            else if (rbMoney.Checked)
            {
                tbRezultat.Text = moneyConverter.Convert(tbPocetni.Text);
            }
            else if (rbTime.Checked)
            {
                if (rbHours.Checked)
                {
                    tbRezultat.Text = timeConverter.ConvertHours(tbPocetni.Text);
                }
                else if (rbMinutes.Checked)
                {
                    tbRezultat.Text = timeConverter.ConvertMinutes(tbPocetni.Text);
                }
                else if (rbSeconds.Checked)
                {
                    tbRezultat.Text = timeConverter.ConvertSeconds(tbPocetni.Text);
                }
            }
            else if (rbCustomMoney.Checked)
            {
                tbRezultat.Text = customMoneyConverter.Convert(tbPocetni.Text);
            }
            else
                MessageBox.Show("Nije selektovan ni jedan konvertor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
