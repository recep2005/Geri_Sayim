using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        int sure = 60;
        Boolean durum = false;

        public Form1()
        {
            InitializeComponent();
            bar.Maximum = sure_hesapla();
            bar.Value = sure_hesapla();  

        }


        int sure_hesapla()
        {
            if (rb_1.Checked == true) { sure = 60; }
            else if (rb_2.Checked == true) { sure = 180; }
            else if (rb_3.Checked == true) { sure = 300; }
            else if (rb_4.Checked == true) { sure = 600; }
            else if (rb_5.Checked == true) { sure = 900; }
            else if (rb_6.Checked == true) {

                sure = (int)ud_dakika.Value*60+(int)ud_saniye.Value;
            }
            return sure;
        
        
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_1_CheckedChanged(object sender, EventArgs e)
        {
            ud_dakika.Enabled = false;
            ud_saniye.Enabled = false;
            bar.Maximum = sure_hesapla();
            bar.Value = sure_hesapla();  

        }

        private void rb_2_CheckedChanged(object sender, EventArgs e)
        {
            ud_dakika.Enabled = false;
            ud_saniye.Enabled = false;
            bar.Maximum = sure_hesapla();
            bar.Value = sure_hesapla();  

        }

        private void rb_3_CheckedChanged(object sender, EventArgs e)
        {
            ud_dakika.Enabled = false;
            ud_saniye.Enabled = false;
            bar.Maximum = sure_hesapla();
            bar.Value = sure_hesapla();  
 
        }

        private void rb_4_CheckedChanged(object sender, EventArgs e)
        {
            ud_dakika.Enabled = false;
            ud_saniye.Enabled = false;
            bar.Maximum = sure_hesapla();
            bar.Value = sure_hesapla();  
  
        }

        private void rb_5_CheckedChanged(object sender, EventArgs e)
        {
            ud_dakika.Enabled = false;
            ud_saniye.Enabled = false;
            bar.Maximum = sure_hesapla();
            bar.Value = sure_hesapla();  
 
        }

        private void rb_6_CheckedChanged(object sender, EventArgs e)
        {
            ud_dakika.Enabled = true;
            ud_saniye.Enabled = true;
 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bar.Value == 0) {
              
                bt_basla.Text = "Başla";
                timer1.Stop();
                bar.Maximum = sure_hesapla();
                bar.Value = sure_hesapla();

                
            }
            else
            {
                bar.Value = bar.Value - 1;
            }
        }

        private void bt_basla_Click(object sender, EventArgs e)
        {


            if (durum == false)
            {

                timer1.Start();
                durum = true;
                bt_basla.Text = "Durdur";
            }
            else {
                timer1.Stop();
                durum = false;
                bt_basla.Text = "Devam et";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ud_dakika_ValueChanged(object sender, EventArgs e)
        {
            bar.Maximum = sure_hesapla();
            bar.Value = sure_hesapla(); 
        }

        private void ud_saniye_ValueChanged(object sender, EventArgs e)
        {
            bar.Maximum = sure_hesapla();
            bar.Value = sure_hesapla(); 
        }

        private void bt_sifirla_Click(object sender, EventArgs e)
        {

        }
    }
}