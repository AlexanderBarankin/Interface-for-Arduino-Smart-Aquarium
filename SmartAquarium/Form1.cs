namespace SmartAquarium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"https://www.tinkercad.com/things/bhpYC8SFs1l-smart-aquarium/editel", UseShellExecute = true }); ;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "ER-chart";
            pictureBox1.Image = System.Drawing.Image.FromFile(@"Arduino\ER.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Smart Aquarium Circuit";
            pictureBox1.Image = System.Drawing.Image.FromFile(@"Arduino\Circuit.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Components List";
            pictureBox1.Image = System.Drawing.Image.FromFile(@"Arduino\Components.png");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Open report";
            pictureBox1.Image = null;
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"Arduino\БСТ2001 Баранкин - Отчёт по учебной (технологической) практике.docx", UseShellExecute = true }); ;

        }
    }
}