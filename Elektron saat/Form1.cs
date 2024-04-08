namespace Elektron_saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int saniye = 0, deqiqe=0, saat=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            saniye++;
            label5.Text = saniye.ToString();
            
            if (saniye == 60)
            {
                deqiqe++;
                label3.Text = deqiqe.ToString();
                this.BackColor = Color.YellowGreen;

                saniye = 0;
                if (deqiqe == 60)
                {
                    saat = saat + 1;
                    label1.Text = saat.ToString();
                    this.BackColor = Color.Brown;
                    deqiqe = 0;
                }

            }
            
        }
    }
}
