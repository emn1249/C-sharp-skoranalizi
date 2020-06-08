using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;


namespace skor_analiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ms1puan, ms2puan, ms3puan, gmpuan,finalskor,ms1yuzde,ms2yuzde,ms3yuzde,gmyuzde;

        private void Form1_Load(object sender, EventArgs e)
        {
            chart2.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {

           

            chart2.Series["Mission1"].Points.AddY(Convert.ToInt32(ms1yuzde));
            chart2.Series["Mission2"].Points.AddY(Convert.ToInt32(ms2yuzde));
            chart2.Series["Mission3"].Points.AddY(Convert.ToInt32(ms3yuzde));
            chart2.Series["GroundMission"].Points.AddY(Convert.ToInt32(gmyuzde));
            chart2.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                ms1puan = 1;
            }
            else
            {
                ms1puan = 0;
            }
            if (checkBox2.Checked == true)
            {
                ms2puan = 1 + (Convert.ToDouble(ms2min.Text) / Convert.ToDouble(ms2sure.Text));
            }
            else
            {
                ms2puan = 0;
            }
            if (checkBox3.Checked == true)
            {
                ms3puan = 2 + Convert.ToDouble(ms3skor.Text);
            }
            else
            {
                ms3puan = 0;
            }
            if (checkBox4.Checked == true)
            {
                gmpuan = (Convert.ToDouble(gmmin.Text) / (Convert.ToDouble(ms2gm.Text) + Convert.ToDouble(ms3gm.Text)));
            }
            else
            {
                gmpuan = 0;
            }
           

            finalskor = ms1puan + ms2puan + ms3puan + gmpuan;

            final.Text = finalskor.ToString();


            ms1yuzde = (1 / finalskor)*100 ;
            ms2yuzde = (ms2puan / finalskor)*100 ;
            ms3yuzde = (ms3puan / finalskor) * 100;
            gmyuzde = (gmpuan / finalskor) * 100;

            ms1y.Text = ms1yuzde.ToString();
            ms2y.Text = ms2yuzde.ToString();
            ms3y.Text = ms3yuzde.ToString();
            gmy.Text = gmyuzde.ToString();

            ms1p.Text = 1.ToString();
            ms2p.Text = ms2puan.ToString();
            ms3p.Text = ms3puan.ToString();
            gmp.Text = gmpuan.ToString();
            

        }
    }
}
