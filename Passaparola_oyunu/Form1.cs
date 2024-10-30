using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Passaparola_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        int soruno = 0;


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
            soruno++;
            this.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizdeki güney kısımdaki kıyı ismi?";
                button1.BackColor = Color.Blue;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü ilimiz?";
                button2.BackColor = Color.Blue;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Blue;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "20 plaka kodu olan ilimiz?";
                button4.BackColor = Color.Blue;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Büyük anlamında olan arapça/farsca kökenli sözcük?";
                button5.BackColor = Color.Blue;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Başkenti paris olan ülke?";
                button6.BackColor = Color.Blue;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyamızın ısı Kaynağı ?";
                button7.BackColor = Color.Blue;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Yaşam kelimesinin eş anlamlısı?";
                button8.BackColor = Color.Blue;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "sıcaklık ile karıştırılan sözcük ?";
                button9.BackColor = Color.Blue;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Napolyon hakkında söz söylediği türkiyedeki şehir?";
                button10.BackColor = Color.Blue;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "En sevilen kötü süper kahraman?";
                buttonn11.BackColor = Color.Blue;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Yazmaya yaran araç?";
                button12.BackColor = Color.Blue;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Çok güzel kokan bitki?";
                button13.BackColor = Color.Blue;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Şehzade mustafanın sancakbeyliği yaptığı şehir?";
                button14.BackColor = Color.Blue;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "... gazozu çok meşhurdur diyen biri nereden bahsediyordur?";
                button15.BackColor = Color.Blue;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "52 NERENİN PLAKASI?";
                button16.BackColor = Color.Blue;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Eyfel kulesi nerdedir?";
                button17.BackColor = Color.Blue;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "3 aylardan bir ay?";
                button18.BackColor = Color.Blue;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Doğu kelimesine karşılık gelen bir kelime?";
                button19.BackColor = Color.Blue;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Orta doğunun en güçlü ülkesi?";
                button20.BackColor = Color.Blue;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Yayın,haber ,televizyon gibi şeyler için önemli uzay aracı?";
                button21.BackColor = Color.Blue;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "bir gözü mavi bir gözü yeşil olan kedilerin bulunduğu şehir?";
                button22.BackColor = Color.Blue;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "çok popüler bir arama motoru?";
                button23.BackColor = Color.Blue;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "çok hayırlı bir su,kutsal su müslümanlar için?";
                button24.BackColor = Color.Blue;
            }

        }
        int dogru = 0,yanlis=0;
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox.Text == "denizli")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox.Text == "ekber")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox.Text == "fransa")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox.Text == "hayat")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox.Text == "ısı")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox.Text == "istanbul")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox.Text == "joker")
                        {
                            buttonn11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            buttonn11.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox.Text == "kalem")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox.Text == "manisa")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox.Text == "niğde")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox.Text == "ordu")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox.Text == "paris ") 
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox.Text == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox.Text == "serhat")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox.Text == "türkiye")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox.Text == "uydu")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox.Text == "yandex")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox.Text == "zemzem")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                }
            }


            }
        }
    }

