using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalculatorMachine;

namespace CalculatorWindowsFormsApp
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }


        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            var cal = new Calculator();

            lstHasil.Items.Clear();
            lstHasil.Items.Add("Hasil Penambahan " + a + " + " + b + " = " + cal.Penambahan(a, b));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} * {1} = {2}", a, b, cal.Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pangkat: {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Module: {0} % {1} = {2}", a, b, cal.Modulo(a, b)));

        }
    }
}
