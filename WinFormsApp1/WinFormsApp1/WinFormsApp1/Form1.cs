namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label1.Image = label2.Image;
            label3.Image = label4.Image;
            label4.Image = label5.Image;
            label8.Image = label10.Image;
            label10.Image = label11.Image;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void jobb_Click(object sender, EventArgs e)
        {
            label1.Image = label2.Image;
            label3.Image = label4.Image;
            label5.Image = label8.Image;
            label10.Image = label11.Image;
            

        }
    }
}
