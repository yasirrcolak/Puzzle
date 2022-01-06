using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Dersssssssss
{

    public abstract class Student
    {
        public int MyProperty { get; set; }


    }

    public class B : Student
    {

    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int hareketSayisi = 0;
        int labelIndex = 0;

        private void butonKaristir()
        {
            List<int> labelList = new List<int>();
            Random rnd = new Random(16);

            foreach (Button btn in this.panel1.Controls)
            {
                while (labelList.Contains(labelIndex))
                {
                    labelIndex = rnd.Next(16);
                }

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList.Add(labelIndex);

            }

            hareketSayisi = 0;
            label1.Text = "Hareket Sayisi: " + hareketSayisi;

        }

        private void yerDegistir(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "")
            {
                return;
            }

            Button whiteBtn = null;

            foreach (Button bt in this.panel1.Controls)
            {
                if (bt.Text == "")
                {
                    whiteBtn = bt;
                    break;
                }
            }

            if (btn.TabIndex == (whiteBtn.TabIndex - 1) ||
                btn.TabIndex == (whiteBtn.TabIndex - 4) ||
                btn.TabIndex == (whiteBtn.TabIndex + 1) ||
                btn.TabIndex == (whiteBtn.TabIndex + 4))
            {
                whiteBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                whiteBtn.Text = btn.Text;
                btn.Text = "";
                hareketSayisi++;
                label1.Text = "Hareket Sayisi: " + hareketSayisi;
            }

            kontrol();
        }

        private void kontrol()
        {
            int index = 1;

            foreach (Button bt in this.panel1.Controls)
            {
                if(bt.Text!="" && Convert.ToInt32(bt.Text) != index)
                {
                    return;
                }

                index++;
            }

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butonKaristir();
        }

        private void button17_Click(object sender, EventArgs e)
        {
                De();
        }

        public void De()
        {
            string[] dizi = { "siyah", "beyaz", "mavi", "mor" };
            var query = from x1 in dizi
                        where x1.Length == dizi.Max(x2 => x2.Length)
                        select x1;

            foreach (var element in query)
            {
                Console.WriteLine(element);
            }



        }

        void fun(double d)
        {
            Console.WriteLine();
        }


    }
}
