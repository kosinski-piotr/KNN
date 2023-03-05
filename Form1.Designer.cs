namespace Zad1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSciezkaPlikuRepozytorium = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWybierzPlik = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnAnaliza = new System.Windows.Forms.Button();
            this.cbMetodaWczytania = new System.Windows.Forms.ComboBox();
            this.nudMi = new System.Windows.Forms.NumericUpDown();
            this.nudMa = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbAtrybutyDoPominiecia = new System.Windows.Forms.CheckedListBox();
            this.Check_met1 = new System.Windows.Forms.CheckBox();
            this.Check_met2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MetricLogarytm = new System.Windows.Forms.CheckBox();
            this.MetricMinkowski = new System.Windows.Forms.CheckBox();
            this.MetricCzebyszew = new System.Windows.Forms.CheckBox();
            this.MetricEuklides = new System.Windows.Forms.CheckBox();
            this.MetricManhattan = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.warK = new System.Windows.Forms.TextBox();
            this.warP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dane = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKnn = new System.Windows.Forms.Button();
            this.btn1vsr = new System.Windows.Forms.Button();
            this.textDec = new System.Windows.Forms.TextBox();
            this.textPraw = new System.Windows.Forms.TextBox();
            this.dec = new System.Windows.Forms.Label();
            this.praw = new System.Windows.Forms.Label();
            this.txtNowe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSciezkaPlikuRepozytorium
            // 
            this.tbSciezkaPlikuRepozytorium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSciezkaPlikuRepozytorium.Location = new System.Drawing.Point(139, 50);
            this.tbSciezkaPlikuRepozytorium.Margin = new System.Windows.Forms.Padding(4);
            this.tbSciezkaPlikuRepozytorium.Name = "tbSciezkaPlikuRepozytorium";
            this.tbSciezkaPlikuRepozytorium.ReadOnly = true;
            this.tbSciezkaPlikuRepozytorium.Size = new System.Drawing.Size(535, 22);
            this.tbSciezkaPlikuRepozytorium.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plik repozytorium";
            // 
            // btnWybierzPlik
            // 
            this.btnWybierzPlik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWybierzPlik.Location = new System.Drawing.Point(682, 48);
            this.btnWybierzPlik.Margin = new System.Windows.Forms.Padding(4);
            this.btnWybierzPlik.Name = "btnWybierzPlik";
            this.btnWybierzPlik.Size = new System.Drawing.Size(48, 28);
            this.btnWybierzPlik.TabIndex = 2;
            this.btnWybierzPlik.Text = "...";
            this.btnWybierzPlik.UseVisualStyleBackColor = true;
            this.btnWybierzPlik.Click += new System.EventHandler(this.btnWybierzPlik_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnAnaliza
            // 
            this.btnAnaliza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnaliza.Enabled = false;
            this.btnAnaliza.Location = new System.Drawing.Point(619, 362);
            this.btnAnaliza.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaliza.Name = "btnAnaliza";
            this.btnAnaliza.Size = new System.Drawing.Size(121, 28);
            this.btnAnaliza.TabIndex = 3;
            this.btnAnaliza.Text = "Analizuj plik";
            this.btnAnaliza.UseVisualStyleBackColor = true;
            this.btnAnaliza.Click += new System.EventHandler(this.btnAnaliza_Click);
            // 
            // cbMetodaWczytania
            // 
            this.cbMetodaWczytania.FormattingEnabled = true;
            this.cbMetodaWczytania.Location = new System.Drawing.Point(139, 15);
            this.cbMetodaWczytania.Margin = new System.Windows.Forms.Padding(4);
            this.cbMetodaWczytania.Name = "cbMetodaWczytania";
            this.cbMetodaWczytania.Size = new System.Drawing.Size(520, 24);
            this.cbMetodaWczytania.TabIndex = 4;
            // 
            // nudMi
            // 
            this.nudMi.DecimalPlaces = 4;
            this.nudMi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudMi.Location = new System.Drawing.Point(94, 35);
            this.nudMi.Margin = new System.Windows.Forms.Padding(4);
            this.nudMi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMi.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudMi.Name = "nudMi";
            this.nudMi.Size = new System.Drawing.Size(160, 22);
            this.nudMi.TabIndex = 5;
            this.nudMi.ValueChanged += new System.EventHandler(this.nudMi_ValueChanged);
            // 
            // nudMa
            // 
            this.nudMa.DecimalPlaces = 4;
            this.nudMa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudMa.Location = new System.Drawing.Point(95, 71);
            this.nudMa.Margin = new System.Windows.Forms.Padding(4);
            this.nudMa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMa.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudMa.Name = "nudMa";
            this.nudMa.Size = new System.Drawing.Size(160, 22);
            this.nudMa.TabIndex = 6;
            this.nudMa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maksimum";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudMa);
            this.groupBox1.Location = new System.Drawing.Point(390, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(269, 106);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Normalizacja";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clbAtrybutyDoPominiecia
            // 
            this.clbAtrybutyDoPominiecia.FormattingEnabled = true;
            this.clbAtrybutyDoPominiecia.Location = new System.Drawing.Point(36, 85);
            this.clbAtrybutyDoPominiecia.Margin = new System.Windows.Forms.Padding(4);
            this.clbAtrybutyDoPominiecia.Name = "clbAtrybutyDoPominiecia";
            this.clbAtrybutyDoPominiecia.Size = new System.Drawing.Size(280, 106);
            this.clbAtrybutyDoPominiecia.TabIndex = 10;
            this.clbAtrybutyDoPominiecia.SelectedIndexChanged += new System.EventHandler(this.clbAtrybutyDoPominiecia_SelectedIndexChanged);
            // 
            // Check_met1
            // 
            this.Check_met1.AutoSize = true;
            this.Check_met1.Location = new System.Drawing.Point(16, 23);
            this.Check_met1.Name = "Check_met1";
            this.Check_met1.Size = new System.Drawing.Size(444, 21);
            this.Check_met1.TabIndex = 11;
            this.Check_met1.Text = "Metoda 1 - Najwięcej klas decyzyjnych w \'k\' najbliższych próbkach";
            this.Check_met1.UseVisualStyleBackColor = true;
            this.Check_met1.CheckedChanged += new System.EventHandler(this.Check_met1_CheckedChanged);
            // 
            // Check_met2
            // 
            this.Check_met2.AutoSize = true;
            this.Check_met2.Location = new System.Drawing.Point(16, 50);
            this.Check_met2.Name = "Check_met2";
            this.Check_met2.Size = new System.Drawing.Size(618, 21);
            this.Check_met2.TabIndex = 12;
            this.Check_met2.Text = "Metoda 2 - Najmniejsza suma odległości w \'k\' najbliższych próbkach z każdej klasy" +
    " decyzyjnej";
            this.Check_met2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MetricLogarytm);
            this.groupBox2.Controls.Add(this.MetricMinkowski);
            this.groupBox2.Controls.Add(this.MetricCzebyszew);
            this.groupBox2.Controls.Add(this.MetricEuklides);
            this.groupBox2.Controls.Add(this.MetricManhattan);
            this.groupBox2.Location = new System.Drawing.Point(36, 285);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(322, 103);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz Metrykę";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // MetricLogarytm
            // 
            this.MetricLogarytm.AutoSize = true;
            this.MetricLogarytm.Location = new System.Drawing.Point(8, 77);
            this.MetricLogarytm.Name = "MetricLogarytm";
            this.MetricLogarytm.Size = new System.Drawing.Size(176, 21);
            this.MetricLogarytm.TabIndex = 4;
            this.MetricLogarytm.Text = "Metryka Logarytmiczna";
            this.MetricLogarytm.UseVisualStyleBackColor = true;
            // 
            // MetricMinkowski
            // 
            this.MetricMinkowski.AutoSize = true;
            this.MetricMinkowski.Location = new System.Drawing.Point(169, 23);
            this.MetricMinkowski.Name = "MetricMinkowski";
            this.MetricMinkowski.Size = new System.Drawing.Size(147, 21);
            this.MetricMinkowski.TabIndex = 3;
            this.MetricMinkowski.Text = "Metryka Minkowski";
            this.MetricMinkowski.UseVisualStyleBackColor = true;
            // 
            // MetricCzebyszew
            // 
            this.MetricCzebyszew.AutoSize = true;
            this.MetricCzebyszew.Location = new System.Drawing.Point(169, 50);
            this.MetricCzebyszew.Name = "MetricCzebyszew";
            this.MetricCzebyszew.Size = new System.Drawing.Size(154, 21);
            this.MetricCzebyszew.TabIndex = 2;
            this.MetricCzebyszew.Text = "Metryka Czebyszew";
            this.MetricCzebyszew.UseVisualStyleBackColor = true;
            this.MetricCzebyszew.CheckedChanged += new System.EventHandler(this.MetricCzebyszew_CheckedChanged);
            // 
            // MetricEuklides
            // 
            this.MetricEuklides.AutoSize = true;
            this.MetricEuklides.Location = new System.Drawing.Point(8, 50);
            this.MetricEuklides.Name = "MetricEuklides";
            this.MetricEuklides.Size = new System.Drawing.Size(137, 21);
            this.MetricEuklides.TabIndex = 1;
            this.MetricEuklides.Text = "Metryka Euklides";
            this.MetricEuklides.UseVisualStyleBackColor = true;
            // 
            // MetricManhattan
            // 
            this.MetricManhattan.AutoSize = true;
            this.MetricManhattan.Location = new System.Drawing.Point(8, 23);
            this.MetricManhattan.Name = "MetricManhattan";
            this.MetricManhattan.Size = new System.Drawing.Size(151, 21);
            this.MetricManhattan.TabIndex = 0;
            this.MetricManhattan.Text = "Metryka Manhattan";
            this.MetricManhattan.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Check_met2);
            this.groupBox3.Controls.Add(this.Check_met1);
            this.groupBox3.Location = new System.Drawing.Point(36, 199);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(623, 78);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wybierz metodę";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // warK
            // 
            this.warK.Location = new System.Drawing.Point(441, 298);
            this.warK.Name = "warK";
            this.warK.Size = new System.Drawing.Size(99, 22);
            this.warK.TabIndex = 12;
            // 
            // warP
            // 
            this.warP.Location = new System.Drawing.Point(441, 326);
            this.warP.Name = "warP";
            this.warP.Size = new System.Drawing.Size(100, 22);
            this.warP.TabIndex = 13;
            this.warP.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Podaj K";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Podaj P";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label7.Location = new System.Drawing.Point(366, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "(Jeżeli wybrano metrykę Minkowskiego, w innym przypadku wpisz 0)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dane
            // 
            this.dane.Location = new System.Drawing.Point(558, 298);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(146, 22);
            this.dane.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Podaj atrybuty oddzielając spacją";
            // 
            // btnKnn
            // 
            this.btnKnn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKnn.Enabled = false;
            this.btnKnn.Location = new System.Drawing.Point(499, 362);
            this.btnKnn.Margin = new System.Windows.Forms.Padding(4);
            this.btnKnn.Name = "btnKnn";
            this.btnKnn.Size = new System.Drawing.Size(122, 28);
            this.btnKnn.TabIndex = 19;
            this.btnKnn.Text = "Wykonaj Knn";
            this.btnKnn.UseVisualStyleBackColor = true;
            this.btnKnn.Click += new System.EventHandler(this.btnKnn_Click);
            // 
            // btn1vsr
            // 
            this.btn1vsr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1vsr.Enabled = false;
            this.btn1vsr.Location = new System.Drawing.Point(381, 362);
            this.btn1vsr.Margin = new System.Windows.Forms.Padding(4);
            this.btn1vsr.Name = "btn1vsr";
            this.btn1vsr.Size = new System.Drawing.Size(122, 28);
            this.btn1vsr.TabIndex = 20;
            this.btn1vsr.Text = "1 vs reszta";
            this.btn1vsr.UseVisualStyleBackColor = true;
            this.btn1vsr.Click += new System.EventHandler(this.btn1vsr_Click);
            // 
            // textDec
            // 
            this.textDec.Location = new System.Drawing.Point(688, 122);
            this.textDec.Name = "textDec";
            this.textDec.Size = new System.Drawing.Size(52, 22);
            this.textDec.TabIndex = 21;
            // 
            // textPraw
            // 
            this.textPraw.Location = new System.Drawing.Point(688, 168);
            this.textPraw.Name = "textPraw";
            this.textPraw.Size = new System.Drawing.Size(52, 22);
            this.textPraw.TabIndex = 22;
            // 
            // dec
            // 
            this.dec.AutoSize = true;
            this.dec.Location = new System.Drawing.Point(664, 102);
            this.dec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(58, 17);
            this.dec.TabIndex = 23;
            this.dec.Text = "Decyzja";
            // 
            // praw
            // 
            this.praw.AutoSize = true;
            this.praw.Location = new System.Drawing.Point(664, 147);
            this.praw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.praw.Name = "praw";
            this.praw.Size = new System.Drawing.Size(51, 17);
            this.praw.TabIndex = 24;
            this.praw.Text = "Prawd.";
            // 
            // txtNowe
            // 
            this.txtNowe.Location = new System.Drawing.Point(688, 212);
            this.txtNowe.Name = "txtNowe";
            this.txtNowe.Size = new System.Drawing.Size(52, 22);
            this.txtNowe.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Pokrycie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 394);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNowe);
            this.Controls.Add(this.praw);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.textPraw);
            this.Controls.Add(this.textDec);
            this.Controls.Add(this.btn1vsr);
            this.Controls.Add(this.btnKnn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.warP);
            this.Controls.Add(this.warK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clbAtrybutyDoPominiecia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMetodaWczytania);
            this.Controls.Add(this.btnAnaliza);
            this.Controls.Add(this.btnWybierzPlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSciezkaPlikuRepozytorium);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(590, 329);
            this.Name = "Form1";
            this.Text = "Przygotwanie danych";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSciezkaPlikuRepozytorium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWybierzPlik;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnAnaliza;
        private System.Windows.Forms.ComboBox cbMetodaWczytania;
        private System.Windows.Forms.NumericUpDown nudMi;
        private System.Windows.Forms.NumericUpDown nudMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbAtrybutyDoPominiecia;
        private System.Windows.Forms.CheckBox Check_met1;
        private System.Windows.Forms.CheckBox Check_met2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox warK;
        private System.Windows.Forms.TextBox warP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox MetricLogarytm;
        private System.Windows.Forms.CheckBox MetricMinkowski;
        private System.Windows.Forms.CheckBox MetricCzebyszew;
        private System.Windows.Forms.CheckBox MetricEuklides;
        private System.Windows.Forms.CheckBox MetricManhattan;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox dane;
        private System.Windows.Forms.Button btnKnn;
        private System.Windows.Forms.Button btn1vsr;
        private System.Windows.Forms.Label dec;
        private System.Windows.Forms.Label praw;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textDec;
        public System.Windows.Forms.TextBox textPraw;
        public System.Windows.Forms.TextBox txtNowe;
    }
}

