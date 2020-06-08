using System;
using System.Windows.Forms;

namespace skor_analiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Görevlerin Totale Etki Yüzdeleri");
            this.chart1.Series["Mission1"].Points.AddY(10);
            this.chart1.Series["Mission2"].Points.AddY(20);
            this.chart1.Series["Mission3"].Points.AddY(30);
            this.chart1.Series["GroundMission"].Points.AddY(35);
        }
    }
}
