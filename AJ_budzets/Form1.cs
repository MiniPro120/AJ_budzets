using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJ_budzets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alga = Convert.ToInt32(Math.Round(nr_alga.Value, 0));
            int papildus = Convert.ToInt32(Math.Round(nr_papildus.Value, 0));
            int ire = Convert.ToInt32(Math.Round(nr_ire.Value, 0));
            int partika = Convert.ToInt32(Math.Round(nr_partika.Value, 0));
            int komunalie = Convert.ToInt32(Math.Round(nr_komunalie.Value, 0));

            budzeta_aprekins(alga, papildus, ire, partika, komunalie);

        }

        private void budzeta_aprekins(int alga, int papildus, int ire, int partika, int komunalie)
        {

            int ienakumi = alga + papildus;

            int izdevumi = ire + partika + komunalie;

            int budzets = ienakumi - izdevumi;

            txt_budzets.Text = budzets.ToString();

        }
    }
}
