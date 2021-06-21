using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8086_2._0
{
    public partial class Form1 : Form
    {
        int ryszard;
        long jurand;
        string x;

        static bool Hex(string test) 
        {
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }
        public void ClearAll() //zerowanie wartości
        {
            l_AX.Text = "0";
            l_BX.Text = "0";
            l_CX.Text = "0";
            l_DX.Text = "0";
            Fill8();
            Update8Bit();
        }
        public void Fill8() //dodawanie zer w rejestrach krótszych niż 8 znaków
        {
            while (l_AX.Text.Length + l_BX.Text.Length + (l_CX.Text.Length + l_DX.Text.Length) < 16)
            {
                if (l_AX.Text.Length < 4)
                {
                    l_AX.Text = "0" + l_AX.Text;
                }
                if (l_BX.Text.Length < 4)
                {
                    l_BX.Text = "0" + l_BX.Text;
                }
                if (l_CX.Text.Length < 4)
                {
                    l_CX.Text = "0" + l_CX.Text;
                }
                if (l_DX.Text.Length < 4)
                {
                    l_DX.Text = "0" + l_DX.Text;
                }
            }
        }
        public void Fill16() //dodawanie zer 
        {
            while (l_AH.Text.Length + l_BH.Text.Length + (l_CH.Text.Length + l_DH.Text.Length) + (l_AL.Text.Length + l_BL.Text.Length) + (l_CL.Text.Length + l_DL.Text.Length) < 16)
            {
                if (l_AH.Text.Length < 2)
                {
                    l_AH.Text = "0" + l_AH.Text;
                }
                if (l_AL.Text.Length < 2)
                {
                    l_AL.Text = "0" + l_AL.Text;
                }
                if (l_BH.Text.Length < 2)
                {
                    l_BH.Text = "0" + l_BH.Text;
                }
                if (l_BL.Text.Length < 2)
                {
                    l_BL.Text = "0" + l_BL.Text;
                }
                if (l_CH.Text.Length < 2)
                {
                    l_CH.Text = "0" + l_CH.Text;
                }
                if (l_CL.Text.Length < 2)
                {
                    l_CL.Text = "0" + l_CL.Text;
                }
                if (l_DH.Text.Length < 2)
                {
                    l_DH.Text = "0" + l_DH.Text;
                }
                if (l_DL.Text.Length < 2)
                {
                    l_DL.Text = "0" + l_DL.Text;
                }
            }
        }
        public void Update8Bit() //Ustawianie wartości dla rejestrów high i low
        {
            string AXT = l_AX.Text;
            l_AL.Text = AXT.Substring(2, 2);
            l_AH.Text = AXT.Substring(0, 2);

            string BXT = l_BX.Text;
            l_BL.Text = BXT.Substring(2, 2);
            l_BH.Text = BXT.Substring(0, 2);

            string CXT = l_CX.Text;
            l_CL.Text = CXT.Substring(2, 2);
            l_CH.Text = CXT.Substring(0, 2);

            string DXT = l_DX.Text;
            l_DL.Text = DXT.Substring(2, 2);
            l_DH.Text = DXT.Substring(0, 2);
            UpdateDec();
        }
        public void Update16Bit()
        {
            l_AX.Text = l_AH.Text + l_AL.Text;
            l_BX.Text = l_BH.Text + l_BL.Text;
            l_CX.Text = l_CH.Text + l_CL.Text;
            l_DX.Text = l_DH.Text + l_DL.Text;
            UpdateDec();
        }
        public void UpdateDec()
        {
            int AXD = int.Parse(l_AX.Text, System.Globalization.NumberStyles.HexNumber);
            int BXD = int.Parse(l_BX.Text, System.Globalization.NumberStyles.HexNumber);
            int CXD = int.Parse(l_CX.Text, System.Globalization.NumberStyles.HexNumber);
            int DXD = int.Parse(l_DX.Text, System.Globalization.NumberStyles.HexNumber);
            l_AXD.Text = AXD.ToString();
            l_BXD.Text = BXD.ToString();
            l_CXD.Text = CXD.ToString();
            l_DXD.Text = DXD.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void l_AL_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_set_Click(object sender, EventArgs e)
        {
            if (t_set.Text.Length < 3 && t_set.Text.Length > 0) //zapobieganie wpisywania pustych rejestrów a także przepełniania int
            {
                if (Hex(t_set.Text)) //sprawdzanie czy wpisany tekst jest w formacie szesnastkowym i konwersja na int
                {
                    ryszard = int.Parse(t_set.Text, System.Globalization.NumberStyles.HexNumber);
                    string grzegorz = t_set.Text;
                    if (ryszard < 256 && ryszard >= 0) //sprawdzanie czy wartosc nie jest zbyt duza, oraz przypisywanie wartosci do rejestrow
                    {
                        //przypisywanie rejestrom ustalonej wartości
                        if (c_set.SelectedIndex == 0)
                        {
                            l_AH.Text = grzegorz;
                        }
                        else if (c_set.SelectedIndex == 1)
                        {
                            l_AL.Text = grzegorz;
                        }
                        else if (c_set.SelectedIndex == 2)
                        {
                            l_BH.Text = grzegorz;

                        }
                        else if (c_set.SelectedIndex == 3)
                        {
                            l_BL.Text = grzegorz;

                        }
                        else if (c_set.SelectedIndex == 4)
                        {
                            l_CH.Text = grzegorz;

                        }
                        else if (c_set.SelectedIndex == 5)
                        {
                            l_CL.Text = grzegorz;

                        }
                        else if (c_set.SelectedIndex == 6)
                        {
                            l_DH.Text = grzegorz;

                        }
                        else if (c_set.SelectedIndex == 7)
                        {
                            l_DL.Text = grzegorz;

                        }
                        else if (c_set.SelectedIndex == -1)
                        {
                            MessageBox.Show("Proszę wybrać rejestr");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wpisana wartość jest nieprawidłowa");
                    }

                }
                else
                {
                    MessageBox.Show("Wpisana wartość nie jest w formacie szesnatskowym");
                }
            }
            else if (t_set.Text.Length >= 3)
            {
                MessageBox.Show("Wpisana wartość jest zbyt długa");
            }
            else if (t_set.Text.Length <= 0)
            {
                MessageBox.Show("Proszę wpisać wartość");
            }
            Fill8();
            Fill16();
            Update16Bit();

        }

        private void c_mov2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_mov_Click(object sender, EventArgs e) //mov 8 bit
        {
            if (c_mov1.SelectedIndex == 0)
            {
                if (c_mov2.SelectedIndex == 0)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov2.SelectedIndex == 1)
                {
                    x = l_AH.Text;
                    l_AL.Text = x;

                }
                if (c_mov2.SelectedIndex == 2)
                {
                    x = l_AH.Text;
                    l_BH.Text = x;

                }
                if (c_mov2.SelectedIndex == 3)
                {
                    x = l_AH.Text;
                    l_BL.Text = x;

                }
                if (c_mov2.SelectedIndex == 4)
                {
                    x = l_AH.Text;
                    l_CH.Text = x;

                }
                if (c_mov2.SelectedIndex == 5)
                {
                    x = l_AH.Text;
                    l_CL.Text = x;

                }
                if (c_mov2.SelectedIndex == 6)
                {
                    x = l_AH.Text;
                    l_DH.Text = x;

                }
                if (c_mov2.SelectedIndex == 7)
                {
                    x = l_AH.Text;
                    l_DL.Text = x;

                }


            }
            if (c_mov1.SelectedIndex == 1)
            {
                if (c_mov2.SelectedIndex == 0)
                {
                    x = l_AL.Text;
                    l_AH.Text = x;

                }
                if (c_mov2.SelectedIndex == 1)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov2.SelectedIndex == 2)
                {
                    x = l_AL.Text;
                    l_BH.Text = x;

                }
                if (c_mov2.SelectedIndex == 3)
                {
                    x = l_AL.Text;
                    l_BL.Text = x;

                }
                if (c_mov2.SelectedIndex == 4)
                {
                    x = l_AL.Text;
                    l_CH.Text = x;

                }
                if (c_mov2.SelectedIndex == 5)
                {
                    x = l_AL.Text;
                    l_CL.Text = x;

                }
                if (c_mov2.SelectedIndex == 6)
                {
                    x = l_AL.Text;
                    l_DH.Text = x;

                }
                if (c_mov2.SelectedIndex == 7)
                {
                    x = l_AL.Text;
                    l_DL.Text = x;

                }
            }
            if (c_mov1.SelectedIndex == 2)
            {
                if (c_mov2.SelectedIndex == 0)
                {
                    x = l_BH.Text;
                    l_AH.Text = x;

                }
                if (c_mov2.SelectedIndex == 1)
                {
                    x = l_BH.Text;
                    l_AL.Text = x;

                }
                if (c_mov2.SelectedIndex == 2)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov2.SelectedIndex == 3)
                {
                    x = l_BH.Text;
                    l_BL.Text = x;

                }
                if (c_mov2.SelectedIndex == 4)
                {
                    x = l_BH.Text;
                    l_CH.Text = x;

                }
                if (c_mov2.SelectedIndex == 5)
                {
                    x = l_BH.Text;
                    l_CL.Text = x;

                }
                if (c_mov2.SelectedIndex == 6)
                {
                    x = l_BH.Text;
                    l_DH.Text = x;

                }
                if (c_mov2.SelectedIndex == 7)
                {
                    x = l_BH.Text;
                    l_DL.Text = x;

                }
            }
            if (c_mov1.SelectedIndex == 3)
            {
                if (c_mov2.SelectedIndex == 0)
                {
                    x = l_BL.Text;
                    l_AH.Text = x;

                }
                if (c_mov2.SelectedIndex == 1)
                {
                    x = l_BL.Text;
                    l_AL.Text = x;

                }
                if (c_mov2.SelectedIndex == 2)
                {
                    x = l_BL.Text;
                    l_BH.Text = x;

                }
                if (c_mov2.SelectedIndex == 3)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov2.SelectedIndex == 4)
                {
                    x = l_BL.Text;
                    l_CH.Text = x;

                }
                if (c_mov2.SelectedIndex == 5)
                {
                    x = l_BL.Text;
                    l_CL.Text = x;

                }
                if (c_mov2.SelectedIndex == 6)
                {
                    x = l_BL.Text;
                    l_DH.Text = x;

                }
                if (c_mov2.SelectedIndex == 7)
                {
                    x = l_BL.Text;
                    l_DL.Text = x;

                }
            }
            if (c_mov1.SelectedIndex == 4)
            {
                if (c_mov2.SelectedIndex == 0)
                {
                    x = l_CH.Text;
                    l_AH.Text = x;

                }
                if (c_mov2.SelectedIndex == 1)
                {
                    x = l_CH.Text;
                    l_AL.Text = x;

                }
                if (c_mov2.SelectedIndex == 2)
                {
                    x = l_CH.Text;
                    l_BH.Text = x;

                }
                if (c_mov2.SelectedIndex == 3)
                {
                    x = l_CH.Text;
                    l_BL.Text = x;

                }
                if (c_mov2.SelectedIndex == 4)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov2.SelectedIndex == 5)
                {
                    x = l_CH.Text;
                    l_CL.Text = x;

                }
                if (c_mov2.SelectedIndex == 6)
                {
                    x = l_CH.Text;
                    l_DH.Text = x;

                }
                if (c_mov2.SelectedIndex == 7)
                {
                    x = l_CH.Text;
                    l_DL.Text = x;

                }
            }
            if (c_mov1.SelectedIndex == 5)
            {
                if (c_mov2.SelectedIndex == 0)
                {
                    x = l_CL.Text;
                    l_AH.Text = x;

                }
                if (c_mov2.SelectedIndex == 1)
                {
                    x = l_CL.Text;
                    l_AL.Text = x;

                }
                if (c_mov2.SelectedIndex == 2)
                {
                    x = l_CL.Text;
                    l_BH.Text = x;

                }
                if (c_mov2.SelectedIndex == 3)
                {
                    x = l_CL.Text;
                    l_BL.Text = x;

                }
                if (c_mov2.SelectedIndex == 4)
                {
                    x = l_CL.Text;
                    l_CH.Text = x;

                }
                if (c_mov2.SelectedIndex == 5)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov2.SelectedIndex == 6)
                {
                    x = l_CL.Text;
                    l_DH.Text = x;

                }
                if (c_mov2.SelectedIndex == 7)
                {
                    x = l_CL.Text;
                    l_DL.Text = x;

                }
            }
            if (c_mov1.SelectedIndex == 6)
            {
                if (c_mov2.SelectedIndex == 0)
                {
                    x = l_DH.Text;
                    l_AH.Text = x;

                }
                if (c_mov2.SelectedIndex == 1)
                {
                    x = l_DH.Text;
                    l_AL.Text = x;

                }
                if (c_mov2.SelectedIndex == 2)
                {
                    x = l_DH.Text;
                    l_BH.Text = x;

                }
                if (c_mov2.SelectedIndex == 3)
                {
                    x = l_DH.Text;
                    l_BL.Text = x;

                }
                if (c_mov2.SelectedIndex == 4)
                {
                    x = l_DH.Text;
                    l_CH.Text = x;

                }
                if (c_mov2.SelectedIndex == 5)
                {
                    x = l_DH.Text;
                    l_CL.Text = x;

                }
                if (c_mov2.SelectedIndex == 6)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov2.SelectedIndex == 7)
                {
                    x = l_DH.Text;
                    l_DL.Text = x;

                }
            }
            if (c_mov1.SelectedIndex == 7)
            {
                if (c_mov2.SelectedIndex == 0)
                {
                    x = l_DL.Text;
                    l_AH.Text = x;

                }
                if (c_mov2.SelectedIndex == 1)
                {
                    x = l_DL.Text;
                    l_AL.Text = x;

                }
                if (c_mov2.SelectedIndex == 2)
                {
                    x = l_DL.Text;
                    l_BH.Text = x;

                }
                if (c_mov2.SelectedIndex == 3)
                {
                    x = l_DL.Text;
                    l_BL.Text = x;

                }
                if (c_mov2.SelectedIndex == 4)
                {
                    x = l_DL.Text;
                    l_CH.Text = x;

                }
                if (c_mov2.SelectedIndex == 5)
                {
                    x = l_DL.Text;
                    l_CL.Text = x;

                }
                if (c_mov2.SelectedIndex == 6)
                {
                    x = l_DL.Text;
                    l_DH.Text = x;

                }
                if (c_mov2.SelectedIndex == 7)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
            }

            else if (c_mov2.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wybrać rejestr");
            }
            else if (c_mov1.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wybrać rejestr");
            }
            Update16Bit();
            
        }

        private void c_mov1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_mov2_Click(object sender, EventArgs e) //mov 16 bit
        {
            if (c_mov3.SelectedIndex == 0)
            {
                if (c_mov4.SelectedIndex == 0)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov2.SelectedIndex == 1)
                {
                    x = l_AX.Text;
                    l_BX.Text = x;

                }
                if (c_mov4.SelectedIndex == 2)
                {
                    x = l_AX.Text;
                    l_CX.Text = x;

                }
                if (c_mov4.SelectedIndex == 3)
                {
                    x = l_AX.Text;
                    l_DX.Text = x;

                }
            }
            if (c_mov3.SelectedIndex == 1)
            {
                if (c_mov4.SelectedIndex == 0)
                {
                    x = l_BX.Text;
                    l_AX.Text = x;

                }
                if (c_mov4.SelectedIndex == 1)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov4.SelectedIndex == 2)
                {
                    x = l_BX.Text;
                    l_CX.Text = x;

                }
                if (c_mov4.SelectedIndex == 3)
                {
                    x = l_BX.Text;
                    l_DX.Text = x;

                }
            }
            if (c_mov3.SelectedIndex == 2)
            {
                if (c_mov4.SelectedIndex == 0)
                {
                    x = l_CX.Text;
                    l_AX.Text = x;

                }
                if (c_mov4.SelectedIndex == 1)
                {
                    x = l_CX.Text;
                    l_BX.Text = x;

                }
                if (c_mov4.SelectedIndex == 2)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
                if (c_mov4.SelectedIndex == 3)
                {
                    x = l_CX.Text;
                    l_DX.Text = x;

                }
            }
            if (c_mov3.SelectedIndex == 3)
            {
                if (c_mov4.SelectedIndex == 0)
                {
                    x = l_DX.Text;
                    l_AX.Text = x;

                }
                if (c_mov4.SelectedIndex == 1)
                {
                    x = l_DX.Text;
                    l_BX.Text = x;

                }
                if (c_mov4.SelectedIndex == 2)
                {
                    x = l_DX.Text;
                    l_CX.Text = x;

                }
                if (c_mov4.SelectedIndex == 3)
                { MessageBox.Show("Wybierz poprawny rejestr"); }
            }
            else if (c_mov3.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wybrać rejestr");
            }
            else if (c_mov4.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wybrać rejestr");
            }
            Update8Bit();
        
    }

        private void b_set2_Click(object sender, EventArgs e)
        {
            if (t_set2.Text.Length < 10 && t_set2.Text.Length > 0) //zapobieganie wpisywania pustych rejestrów a także przepełniania int
            {
                if (Hex(t_set2.Text)) //sprawdzanie czy wpisany tekst jest w formacie szesnastkowym i konwersja na int
                {
                    jurand = long.Parse(t_set2.Text, System.Globalization.NumberStyles.HexNumber);

                    if (jurand < 65536 && jurand >= 0) //sprawdzanie czy wartosc nie jest zbyt duza, oraz przypisywanie wartosci do rejestrow
                    {
                        string zbigniew = t_set2.Text;
                        if (c_set2.SelectedIndex == 0)
                        {
                            l_AX.Text = zbigniew;
                        }
                        else if (c_set2.SelectedIndex == 1)
                        {
                            l_BX.Text = zbigniew;
                        }
                        else if (c_set2.SelectedIndex == 2)
                        {
                            l_CX.Text = zbigniew;

                        }
                        else if (c_set2.SelectedIndex == 3)
                        {
                            l_DX.Text = zbigniew;

                        }
                        else if (c_set2.SelectedIndex == -1)
                        {
                            MessageBox.Show("Proszę wybrać rejestr");
                        }
                        Fill8();
                        Update8Bit();

                    }
                    else
                    {
                        MessageBox.Show("Wpisana wartość jest nieprawidłowa");
                    }

                }
                else
                {
                    MessageBox.Show("Wpisana wartość nie jest w formacie szesnatskowym");
                }
            }
            else if (t_set2.Text.Length > 10)
            {
                MessageBox.Show("Wpisana wartość jest zbyt długa");
            }
            else if (t_set2.Text.Length <= 0)
            {
                MessageBox.Show("Proszę wpisać wartość");
            }

        
    }

        private void c_set2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
    





