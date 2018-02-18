using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // declare var for class (class=WindowsFormApp1
        int j;

        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Calcbasics_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_kmEur.Visible = false;
        }

        private void Btn_AddFahrt_Click(object sender, EventArgs e)
        {
            

            // declare var needed for calc
            int liStart = Convert.ToInt32(Fillin_start.Text);
            int liEnd = Convert.ToInt32(Fillin_end.Text);
            int i = 0;

            //Calculation
            
            i = liEnd - liStart;
            if (i > j) { tBox_km.Text = Convert.ToString(i); }
            else tBox_km.Text = Convert.ToString(j);

            j = j + i;
            MessageBox.Show("Fahrt über " + i + "Kilometer erfolgreich hinzugebucht." + Environment.NewLine + "Sie sind derzeit auf " + j + "Kilometer gesamt");
            Fillin_start.Text = "";
            Fillin_end.Text = "";
        }


        private double BaseValue()
        {
            if (rBtn_PKW.Checked) { return 0.42; }
            else if (rBtn_Beifahrer.Checked) { return 0.05; }
            else if (rBtn_Moped.Checked) { return 0.24; }
            else if (rBtn_Rad.Checked) { return 0.38; }
            return 0.42;
        }

        private void Btn_CalcEur_Click(object sender, EventArgs e)
        {
            // check radio-btn and assign value:

            double ldBaseValue_calc;

            // calculation
            ldBaseValue_calc = BaseValue();
            double liEur = 0;
            liEur = j * ldBaseValue_calc;

            // Display return of calc
            lbl_kmEur.Text = "Das berechnete Fahrtgeld für " + j + " km beträgt " + liEur + "€";
            if (lbl_kmEur.Text != "")
            {
                lbl_kmEur.Visible = true;
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Release: 10.12´.2017" + Environment.NewLine + "Developer: Markus Lorber" + Environment.NewLine + Environment.NewLine + "Unter Berechnungsgrundlage bitte eintragen wofür die das Fahrtgeld berechnen möchten." + Environment.NewLine + "Als Standart wird hier auf Grund der Häufigkeit PKW gewählt." + Environment.NewLine + "Um erneut von 0 anzufangen zu zählen auf 'Reset' drücken.");
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            j = 0;
            lbl_kmEur.Visible = false;
        }
    }
}
