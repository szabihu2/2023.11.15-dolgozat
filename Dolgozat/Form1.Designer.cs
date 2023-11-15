namespace Dolgozat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKoszon = new TextBox();
            txtMasodikSzam = new TextBox();
            txtElsoSzam = new TextBox();
            btnkoszonj = new Button();
            btnOsszead = new Button();
            btnKivon = new Button();
            btnSzoroz = new Button();
            btnOsztas = new Button();
            label1 = new Label();
            btnSzamolj = new Button();
            btnAlaphelyzet = new Button();
            btnKilepes = new Button();
            lblUdvozles = new Label();
            lblPiros = new Label();
            lblZold = new Label();
            lblKek = new Label();
            label2 = new Label();
            lblEredmeny = new Label();
            SuspendLayout();
            // 
            // txtKoszon
            // 
            txtKoszon.Location = new Point(47, 24);
            txtKoszon.Name = "txtKoszon";
            txtKoszon.Size = new Size(108, 23);
            txtKoszon.TabIndex = 0;
            // 
            // txtMasodikSzam
            // 
            txtMasodikSzam.Location = new Point(198, 142);
            txtMasodikSzam.Name = "txtMasodikSzam";
            txtMasodikSzam.Size = new Size(38, 23);
            txtMasodikSzam.TabIndex = 2;
            // 
            // txtElsoSzam
            // 
            txtElsoSzam.Location = new Point(47, 144);
            txtElsoSzam.Name = "txtElsoSzam";
            txtElsoSzam.Size = new Size(37, 23);
            txtElsoSzam.TabIndex = 3;
            // 
            // btnkoszonj
            // 
            btnkoszonj.Location = new Point(161, 24);
            btnkoszonj.Name = "btnkoszonj";
            btnkoszonj.Size = new Size(84, 23);
            btnkoszonj.TabIndex = 4;
            btnkoszonj.Text = "Köszönj!";
            btnkoszonj.UseVisualStyleBackColor = true;
            // 
            // btnOsszead
            // 
            btnOsszead.Location = new Point(105, 125);
            btnOsszead.Name = "btnOsszead";
            btnOsszead.Size = new Size(33, 23);
            btnOsszead.TabIndex = 5;
            btnOsszead.Text = "+";
            btnOsszead.UseVisualStyleBackColor = true;
            // 
            // btnKivon
            // 
            btnKivon.Location = new Point(144, 125);
            btnKivon.Name = "btnKivon";
            btnKivon.Size = new Size(36, 23);
            btnKivon.TabIndex = 6;
            btnKivon.Text = "-";
            btnKivon.UseVisualStyleBackColor = true;
            // 
            // btnSzoroz
            // 
            btnSzoroz.Location = new Point(105, 160);
            btnSzoroz.Name = "btnSzoroz";
            btnSzoroz.Size = new Size(33, 23);
            btnSzoroz.TabIndex = 7;
            btnSzoroz.Text = "*";
            btnSzoroz.UseVisualStyleBackColor = true;
            // 
            // btnOsztas
            // 
            btnOsztas.Location = new Point(144, 161);
            btnOsztas.Name = "btnOsztas";
            btnOsztas.Size = new Size(36, 23);
            btnOsztas.TabIndex = 8;
            btnOsztas.Text = "/";
            btnOsztas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "név:";
            // 
            // btnSzamolj
            // 
            btnSzamolj.Location = new Point(25, 206);
            btnSzamolj.Name = "btnSzamolj";
            btnSzamolj.Size = new Size(457, 26);
            btnSzamolj.TabIndex = 10;
            btnSzamolj.Text = "Számolj!";
            btnSzamolj.UseVisualStyleBackColor = true;
            // 
            // btnAlaphelyzet
            // 
            btnAlaphelyzet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlaphelyzet.ForeColor = Color.FromArgb(128, 128, 255);
            btnAlaphelyzet.Location = new Point(237, 238);
            btnAlaphelyzet.Name = "btnAlaphelyzet";
            btnAlaphelyzet.Size = new Size(117, 39);
            btnAlaphelyzet.TabIndex = 11;
            btnAlaphelyzet.Text = "Alaphelyzet";
            btnAlaphelyzet.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            btnKilepes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKilepes.ForeColor = Color.FromArgb(192, 0, 0);
            btnKilepes.Location = new Point(365, 238);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(117, 39);
            btnKilepes.TabIndex = 12;
            btnKilepes.Text = "Kilépés";
            btnKilepes.UseVisualStyleBackColor = true;
            // 
            // lblUdvozles
            // 
            lblUdvozles.BackColor = Color.Khaki;
            lblUdvozles.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUdvozles.Location = new Point(25, 67);
            lblUdvozles.Name = "lblUdvozles";
            lblUdvozles.Padding = new Padding(5);
            lblUdvozles.Size = new Size(138, 29);
            lblUdvozles.TabIndex = 13;
            lblUdvozles.Text = "###UDVOZLES###";
            lblUdvozles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPiros
            // 
            lblPiros.BackColor = Color.Red;
            lblPiros.Location = new Point(328, 30);
            lblPiros.Name = "lblPiros";
            lblPiros.Padding = new Padding(0, 0, 10, 25);
            lblPiros.Size = new Size(43, 40);
            lblPiros.TabIndex = 14;
            lblPiros.Text = "piros";
            // 
            // lblZold
            // 
            lblZold.BackColor = Color.Green;
            lblZold.Location = new Point(377, 30);
            lblZold.Name = "lblZold";
            lblZold.Padding = new Padding(0, 0, 10, 25);
            lblZold.Size = new Size(39, 40);
            lblZold.TabIndex = 15;
            lblZold.Text = "zöld";
            // 
            // lblKek
            // 
            lblKek.BackColor = Color.Blue;
            lblKek.Location = new Point(422, 30);
            lblKek.Name = "lblKek";
            lblKek.Padding = new Padding(0, 0, 10, 25);
            lblKek.Size = new Size(40, 40);
            lblKek.TabIndex = 16;
            lblKek.Text = "kék";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(259, 142);
            label2.Name = "label2";
            label2.Padding = new Padding(2);
            label2.Size = new Size(25, 25);
            label2.TabIndex = 17;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEredmeny
            // 
            lblEredmeny.BackColor = Color.White;
            lblEredmeny.BorderStyle = BorderStyle.FixedSingle;
            lblEredmeny.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEredmeny.Location = new Point(290, 144);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(114, 23);
            lblEredmeny.TabIndex = 18;
            lblEredmeny.Text = "#eredmeny#";
            lblEredmeny.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 298);
            Controls.Add(lblEredmeny);
            Controls.Add(label2);
            Controls.Add(lblKek);
            Controls.Add(lblZold);
            Controls.Add(lblPiros);
            Controls.Add(lblUdvozles);
            Controls.Add(btnKilepes);
            Controls.Add(btnAlaphelyzet);
            Controls.Add(btnSzamolj);
            Controls.Add(label1);
            Controls.Add(btnOsztas);
            Controls.Add(btnSzoroz);
            Controls.Add(btnKivon);
            Controls.Add(btnOsszead);
            Controls.Add(btnkoszonj);
            Controls.Add(txtElsoSzam);
            Controls.Add(txtMasodikSzam);
            Controls.Add(txtKoszon);
            Name = "Form1";
            Text = "WFA dolgozat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKoszon;
        private TextBox txtMasodikSzam;
        private TextBox txtElsoSzam;
        private Button btnkoszonj;
        private Button btnOsszead;
        private Button btnKivon;
        private Button btnSzoroz;
        private Button btnOsztas;
        private Label label1;
        private Button btnSzamolj;
        private Button btnAlaphelyzet;
        private Button btnKilepes;
        private Label lblUdvozles;
        private Label lblPiros;
        private Label lblZold;
        private Label lblKek;
        private Label label2;
        private Label lblEredmeny;
    }
}