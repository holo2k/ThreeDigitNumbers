using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_ekzamen
{
    public partial class ThreeDigitNumbers : Form
    {
        public ThreeDigitNumbers()
        {
            InitializeComponent();
            tbNumber.MaxLength = 3;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text.Length == 3)
            {
                char[] number = tbNumber.Text.ToCharArray();
                char firstNum = number[0];
                char secondNum = number[1];
                char thirdNum = number[2];

                tbHundreds.Text = firstNum.ToString();
                tbTen.Text = secondNum.ToString();
                tbOne.Text = thirdNum.ToString();
            }
            else
            {
                MessageBox.Show("Введите 3-ех значное число", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }

        }

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }
    }
}
