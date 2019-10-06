namespace Projekat_2
{
    partial class Kupovina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNoviArtikal = new System.Windows.Forms.Button();
            this.btnPrikazSvihRacuna = new System.Windows.Forms.Button();
            this.txtUkupnoZaNaplatu = new System.Windows.Forms.TextBox();
            this.btnUkloniArtikal = new System.Windows.Forms.Button();
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.Artikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(725, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite kategoriju";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(284, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dostupni artikli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(309, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Racun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(971, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kolicina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(722, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ukupno za naplatu";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(725, 67);
            this.cbKategorija.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(207, 24);
            this.cbKategorija.TabIndex = 5;
            this.cbKategorija.SelectedIndexChanged += new System.EventHandler(this.cbKategorija_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 185);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikal,
            this.Kolicina,
            this.Cena});
            this.dataGridView2.Location = new System.Drawing.Point(40, 305);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(606, 185);
            this.dataGridView2.TabIndex = 7;
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(971, 67);
            this.nudKolicina.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(140, 22);
            this.nudKolicina.TabIndex = 8;
            this.nudKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(725, 115);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(386, 137);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNoviArtikal
            // 
            this.btnNoviArtikal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviArtikal.Location = new System.Drawing.Point(40, 537);
            this.btnNoviArtikal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNoviArtikal.Name = "btnNoviArtikal";
            this.btnNoviArtikal.Size = new System.Drawing.Size(606, 99);
            this.btnNoviArtikal.TabIndex = 10;
            this.btnNoviArtikal.Text = "Dodaj novi artikal";
            this.btnNoviArtikal.UseVisualStyleBackColor = true;
            this.btnNoviArtikal.Click += new System.EventHandler(this.btnNoviArtikal_Click);
            // 
            // btnPrikazSvihRacuna
            // 
            this.btnPrikazSvihRacuna.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazSvihRacuna.Location = new System.Drawing.Point(725, 537);
            this.btnPrikazSvihRacuna.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrikazSvihRacuna.Name = "btnPrikazSvihRacuna";
            this.btnPrikazSvihRacuna.Size = new System.Drawing.Size(386, 99);
            this.btnPrikazSvihRacuna.TabIndex = 11;
            this.btnPrikazSvihRacuna.Text = "Prikaz svih racuna";
            this.btnPrikazSvihRacuna.UseVisualStyleBackColor = true;
            this.btnPrikazSvihRacuna.Click += new System.EventHandler(this.btnPrikazSvihRacuna_Click);
            // 
            // txtUkupnoZaNaplatu
            // 
            this.txtUkupnoZaNaplatu.Location = new System.Drawing.Point(845, 341);
            this.txtUkupnoZaNaplatu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUkupnoZaNaplatu.Name = "txtUkupnoZaNaplatu";
            this.txtUkupnoZaNaplatu.Size = new System.Drawing.Size(266, 22);
            this.txtUkupnoZaNaplatu.TabIndex = 12;
            // 
            // btnUkloniArtikal
            // 
            this.btnUkloniArtikal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniArtikal.Location = new System.Drawing.Point(845, 415);
            this.btnUkloniArtikal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUkloniArtikal.Name = "btnUkloniArtikal";
            this.btnUkloniArtikal.Size = new System.Drawing.Size(135, 46);
            this.btnUkloniArtikal.TabIndex = 14;
            this.btnUkloniArtikal.Text = "Ukloni artikal";
            this.btnUkloniArtikal.UseVisualStyleBackColor = true;
            this.btnUkloniArtikal.Click += new System.EventHandler(this.btnUkloniArtikal_Click);
            // 
            // btnRacun
            // 
            this.btnRacun.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacun.Location = new System.Drawing.Point(990, 415);
            this.btnRacun.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(121, 46);
            this.btnRacun.TabIndex = 15;
            this.btnRacun.Text = "Izdaj racun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorniraj.Location = new System.Drawing.Point(725, 415);
            this.btnStorniraj.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(113, 46);
            this.btnStorniraj.TabIndex = 16;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click_1);
            // 
            // Artikal
            // 
            this.Artikal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Artikal.DividerWidth = 1;
            this.Artikal.HeaderText = "Artikal";
            this.Artikal.MinimumWidth = 263;
            this.Artikal.Name = "Artikal";
            this.Artikal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Artikal.Width = 263;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.MinimumWidth = 150;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 150;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.MinimumWidth = 150;
            this.Cena.Name = "Cena";
            this.Cena.Width = 150;
            // 
            // Kupovina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 695);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.btnUkloniArtikal);
            this.Controls.Add(this.txtUkupnoZaNaplatu);
            this.Controls.Add(this.btnPrikazSvihRacuna);
            this.Controls.Add(this.btnNoviArtikal);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Kupovina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupovina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kupovina_FormClosing);
            this.Load += new System.EventHandler(this.Kupovina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNoviArtikal;
        private System.Windows.Forms.Button btnPrikazSvihRacuna;
        private System.Windows.Forms.TextBox txtUkupnoZaNaplatu;
        private System.Windows.Forms.Button btnUkloniArtikal;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
    }
}