namespace Dolgozat
{
    public partial class Form1 : Form
    {
        float elsoSzam;
        float masodikSzam;
        float osszEredmeny;
        public Form1()
        {
            InitializeComponent();
            btnkoszonj.Click += Btnkoszonj_Click;
            lblPiros.Click += LblPiros_Click;
            lblZold.Click += LblZold_Click;
            lblKek.Click += LblKek_Click;
            btnOsszead.Click += BtnOsszead_Click;
            btnKivon.Click += BtnKivon_Click;
            btnSzoroz.Click += BtnSzoroz_Click;
            btnOsztas.Click += BtnOsztas_Click;
            //btnSzamolj.Click += BtnSzamolj_Click;
            btnAlaphelyzet.Click += BtnAlaphelyzet_Click;
            btnKilepes.Click += BtnKilepes_Click;


        }

        private bool KoszonesEllenorzo()
        {
            bool ures = false;
            if (txtKoszon.Text == "")
            {
                _ = MessageBox.Show(text: "Pótold ki a mezõt!");
                ures = true;
                lblUdvozles.Text = "###UDVOZLES###";
            }
            else
            {
                ures = false;
            }
            return ures;
        }

        private bool SzamolasEllenorzo()
        {
            bool elsoSiker = float.TryParse(txtElsoSzam.Text, out elsoSzam);
            bool masodikSiker = float.TryParse(txtMasodikSzam.Text, out masodikSzam);

            if (!elsoSiker || !masodikSiker)
            {
                _ = MessageBox.Show
                    (
                    caption: "HIBA",
                    text: "Helytelen felület használat!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK
                    );
            }

            return elsoSiker && masodikSiker;
        }


        private void BtnKilepes_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAlaphelyzet_Click(object? sender, EventArgs e)
        {
            Application.Restart();
        }

        //private void BtnSzamolj_Click(object? sender, EventArgs e)
        //{
        //    if (SzamolasEllenorzo() && )
        //    {

        //        txtEredmeny.Text = $"{elsoSzam / masodikSzam}";

        //    }


        //}




        private void BtnOsztas_Click(object? sender, EventArgs e)
        {

            btnOsztas.ForeColor = Color.Yellow;

        }

        private void BtnSzoroz_Click(object? sender, EventArgs e)
        {
            btnSzoroz.ForeColor = Color.Yellow;
        }

        private void BtnKivon_Click(object? sender, EventArgs e)
        {
            btnKivon.ForeColor = Color.Yellow;
        }

        private void BtnOsszead_Click(object? sender, EventArgs e)
        {
            btnOsszead.ForeColor = Color.Yellow;
        }

        private void lblEredmeny_TextChanged(object sender, EventArgs e)
        {
            lblEredmeny.Text = txtElsoSzam.Text + txtMasodikSzam.Text;
        }



        private void LblKek_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void LblZold_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void LblPiros_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Btnkoszonj_Click(object? sender, EventArgs e)
        {
            lblUdvozles.Text = $"Szia {txtKoszon.Text}!";

            if (KoszonesEllenorzo()) ;



        }


    }
}