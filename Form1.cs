using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace bald_mans_warehouse_calculator
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
         }

        private void form_main_Click(object sender, EventArgs e)
        {
            welcome_box.Visible = true;
            kereste_box.Visible = false;
            nervurlu_box.Visible = false;
        }

        private void menu_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (menu_listbox.SelectedIndex)
            {
                case 0: //kereste
                    welcome_box.Visible = false;
                    kereste_box.Visible = true;
                    nervurlu_box.Visible = false;
                break;
                case 1: //nervürlü demir
                    welcome_box.Visible = false;
                    kereste_box.Visible = false;                    
                    nervurlu_box.Visible = true;
                    break;
            }
        }

        #region KERESTE

        private void keresteX_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only float Mr.Bald
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) //Backspace, rakam ve nokta
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)) //Max 1 virgül
            {
                e.Handled = true;
            }
        }        

        private void keresteY_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only float Mr.Bald
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) //Backspace, rakam ve nokta
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)) //Max 1 virgül
            {
                e.Handled = true;
            }
        }

        private void keresteZ_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only float Mr.Bald
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) //Backspace, rakam ve nokta
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)) //Max 1 virgül
            {
                e.Handled = true;
            }
        }

        private void keresteAdet_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only float Mr.Bald
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) //Backspace, rakam ve nokta
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)) //Max 1 virgül
            {
                e.Handled = true;
            }
        }

        private void keresteCalc_btn_Click(object sender, EventArgs e)
        {
            float x, y, z, a;

            if (keresteX_txt.Text != "")
                x = float.Parse(keresteX_txt.Text);
            else x = 0;

            if (keresteY_txt.Text != "")
                y = float.Parse(keresteY_txt.Text);
            else y = 0;

            if (keresteZ_txt.Text != "")
                z = float.Parse(keresteZ_txt.Text);
            else z = 0;

            if (keresteAdet_txt.Text != "")
                a = float.Parse(keresteAdet_txt.Text);
            else a = 0;
            
                keresteSonuc_lbl.Text = Math.Round(x*y*z/1000000*a,3) + " m3";
        }
        #endregion

        #region NERVÜRLÜ DEMİR

        private void demirUzunluk_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only float Mr.Bald
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) //Backspace, rakam ve nokta
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)) //Max 1 virgül
            {
                e.Handled = true;
            }
        }

        private void demirAdet_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept only float Mr.Bald
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) //Backspace, rakam ve nokta
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)) //Max 1 virgül
            {
                e.Handled = true;
            }
        }

        private void demirCalc_btn_Click(object sender, EventArgs e)
        {
            float kg, mt, adet;

            if (Q8_btn.Checked)
                kg = 0.395f;
            else if (Q10_btn.Checked)
                kg = 0.617f;
            else if (Q12_btn.Checked)
                kg = 0.888f;
            else if (Q14_btn.Checked)
                kg = 1.208f;
            else if (Q16_btn.Checked)
                kg = 1.578f;
            else if (Q18_btn.Checked)
                kg = 1.998f;
            else if (Q20_btn.Checked)
                kg = 2.466f;
            else if (Q22_btn.Checked)
                kg = 2.984f;
            else if (Q24_btn.Checked)
                kg = 3.551f;
            else if (Q26_btn.Checked)
                kg = 4.168f;
            else if (Q28_btn.Checked)
                kg = 4.834f;
            else if (Q30_btn.Checked)
                kg = 5.549f;
            else if (Q32_btn.Checked)
                kg = 6.313f;
            else if (Q36_btn.Checked)
                kg = 7.990f;
            else
                kg = 0;

            if (demirUzunluk_txt.Text != "")
                mt = float.Parse(demirUzunluk_txt.Text);
            else mt = 0;

            if (demirAdet_txt.Text != "")
                adet = float.Parse(demirAdet_txt.Text);
            else adet = 0;

            demirSonuc_lbl.Text = Math.Round(kg * mt * adet, 3) + " kg";
        }
        #endregion
    }
}
