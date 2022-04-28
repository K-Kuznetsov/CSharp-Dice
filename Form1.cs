using System;
using System.Windows.Forms;

namespace Täring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnJuku.Enabled = false;
            btnPeeter.Enabled = false;
            pilt1.LoadAsync(@"https://images.vexels.com/media/users/3/204679/isolated/lists/abc9403594fe735e6139fe3f131b0f05-cat-looking-up-silhouette-cat.png");
            pilt2.LoadAsync(@"https://images.vexels.com/media/users/3/160189/isolated/lists/a85f8b4d592da4ea0e5b7cb9302bb395-dog-ear-sketch.png");
        }
        public int Arv1;
        public int Arv2;
        public int Arv3;
        public int Arv4;
        public int Summa1;
        public int Summa2;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Arv1 = 0;
            Arv2 = 0;
            Arv3 = 0;
            Arv4 = 0;
            Summa1 = 0;
            Summa2 = 0;
            lblRandom1.Text = "";
            lblRandom2.Text = "";
            lblRandom3.Text = "";
            lblRandom4.Text = "";
            lblPunktid1.Text = "";
            lblPunktid2.Text = "";
            lblTulemus.Text = "";
            btnJuku.Enabled = true;
            btnPeeter.Enabled = false;
            btnStart.Enabled = false;
        }

        private void btnJuku_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Arv1 = rand.Next(1, 7);
            Arv2 = rand.Next(1, 7);
            lblRandom1.Text = Convert.ToString(Arv1);
            lblRandom2.Text = Convert.ToString(Arv2);

            Summa1 = Arv1 + Arv2;
            lblPunktid1.Text = Convert.ToString(Summa1);      

            btnJuku.Enabled = false;
            btnPeeter.Enabled = true;
        }

        private void btnPeeter_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Arv3 = rand.Next(1, 7);
            Arv4 = rand.Next(1, 7);
            lblRandom3.Text = Convert.ToString(Arv3);
            lblRandom4.Text = Convert.ToString(Arv4);

            Summa2 = Arv3 + Arv4;
            lblPunktid2.Text = Convert.ToString(Summa2);

            if (Summa1 > Summa2)
            {
                lblTulemus.Text = "Juku võitis!";
            }
            if (Summa1 < Summa2)
            {
                lblTulemus.Text = "Peeter võitis!";
            }
            if (Summa1 == Summa2)
            {
                lblTulemus.Text = "Viik!";
            }

            btnPeeter.Enabled = false;
            btnStart.Enabled = true;

        }

    }
}
