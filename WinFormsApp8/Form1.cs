namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void HESAPLA_Click(object sender, EventArgs e)
        {
            int misirsayi, cekirdeksayi, kolasayi, fantasayi;

            misirsayi = Convert.ToInt32(textBox1.Text);
            cekirdeksayi = Convert.ToInt32(textBox2.Text);
            kolasayi = Convert.ToInt32(textBox3.Text);
            fantasayi = Convert.ToInt32(textBox4.Text);
            int toplam;
            toplam = misirsayi * 30 + cekirdeksayi * 10 + kolasayi * 15 + fantasayi * 12;
            label13.Text = "TOPLAM=" + toplam;
            kasa += toplam;
            label16.Text = kasa.ToString();
        }
    }
}