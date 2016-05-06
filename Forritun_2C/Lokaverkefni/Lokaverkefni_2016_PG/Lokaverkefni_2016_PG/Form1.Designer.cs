namespace Lokaverkefni_2016_PG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.vara = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.magnMinus = new System.Windows.Forms.Button();
            this.magnPlus = new System.Windows.Forms.Button();
            this.label_magnVoru = new System.Windows.Forms.Label();
            this.kvittun = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.byrjaDag = new System.Windows.Forms.Button();
            this.endaDag = new System.Windows.Forms.Button();
            this.klaraVidskipti = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_vidskiptavinurNumer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_virktNumer = new System.Windows.Forms.Label();
            this.byrjaVidskipti = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_snKarmellu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_snSukkuladi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_snGlassur = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_klKarmella = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_klSukkuladi = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_klGlassur = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_vinabraud = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label_vinabraudSerbakad = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label_braudHeilhveiti = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label_braudHeilhveitiSneid = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label_braudHvitt = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label_braudHvittSneid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(43, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veldu vöru";
            // 
            // vara
            // 
            this.vara.FormattingEnabled = true;
            this.vara.Items.AddRange(new object[] {
            "Snúður - Karmella",
            "Snúður - Súkkulaði",
            "Snúður - Glassúr",
            "Kleinuhringur - Karmella",
            "Kleinuhringur - Súkkulaði",
            "Kleinuhringur - Glassúr",
            "Vínarbrauð - Lengja",
            "Vínarbrauð - Sérbakað",
            "Brauð - Heilhveiti",
            "Brauð - Heilhveiti sneið",
            "Brauð - Hvítt",
            "Brauð - Hvítt sneið",
            "Kókómjólk -  250ml",
            "Kókómjólk - 1l",
            "Kaffi",
            "Kaffi Svart",
            "Bjór"});
            this.vara.Location = new System.Drawing.Point(48, 260);
            this.vara.Name = "vara";
            this.vara.Size = new System.Drawing.Size(238, 28);
            this.vara.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(394, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Magn";
            // 
            // magnMinus
            // 
            this.magnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.magnMinus.Location = new System.Drawing.Point(386, 254);
            this.magnMinus.Name = "magnMinus";
            this.magnMinus.Size = new System.Drawing.Size(35, 35);
            this.magnMinus.TabIndex = 4;
            this.magnMinus.Text = "-";
            this.magnMinus.UseVisualStyleBackColor = true;
            this.magnMinus.Click += new System.EventHandler(this.magnMinus_Click);
            // 
            // magnPlus
            // 
            this.magnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.magnPlus.Location = new System.Drawing.Point(465, 253);
            this.magnPlus.Name = "magnPlus";
            this.magnPlus.Size = new System.Drawing.Size(35, 35);
            this.magnPlus.TabIndex = 5;
            this.magnPlus.Text = "+";
            this.magnPlus.UseVisualStyleBackColor = true;
            this.magnPlus.Click += new System.EventHandler(this.magnPlus_Click);
            // 
            // label_magnVoru
            // 
            this.label_magnVoru.AutoSize = true;
            this.label_magnVoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_magnVoru.Location = new System.Drawing.Point(427, 259);
            this.label_magnVoru.Name = "label_magnVoru";
            this.label_magnVoru.Size = new System.Drawing.Size(23, 25);
            this.label_magnVoru.TabIndex = 6;
            this.label_magnVoru.Text = "0";
            // 
            // kvittun
            // 
            this.kvittun.Location = new System.Drawing.Point(48, 348);
            this.kvittun.Name = "kvittun";
            this.kvittun.Size = new System.Drawing.Size(628, 340);
            this.kvittun.TabIndex = 7;
            this.kvittun.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(43, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kvittun";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // byrjaDag
            // 
            this.byrjaDag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.byrjaDag.Location = new System.Drawing.Point(48, 66);
            this.byrjaDag.Name = "byrjaDag";
            this.byrjaDag.Size = new System.Drawing.Size(122, 100);
            this.byrjaDag.TabIndex = 9;
            this.byrjaDag.Text = "Byrja dag";
            this.byrjaDag.UseVisualStyleBackColor = true;
            this.byrjaDag.Click += new System.EventHandler(this.byrjaDag_Click);
            // 
            // endaDag
            // 
            this.endaDag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endaDag.Location = new System.Drawing.Point(176, 66);
            this.endaDag.Name = "endaDag";
            this.endaDag.Size = new System.Drawing.Size(100, 100);
            this.endaDag.TabIndex = 10;
            this.endaDag.Text = "Enda dag";
            this.endaDag.UseVisualStyleBackColor = true;
            this.endaDag.Click += new System.EventHandler(this.endaDag_Click);
            // 
            // klaraVidskipti
            // 
            this.klaraVidskipti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.klaraVidskipti.Location = new System.Drawing.Point(282, 66);
            this.klaraVidskipti.Name = "klaraVidskipti";
            this.klaraVidskipti.Size = new System.Drawing.Size(112, 100);
            this.klaraVidskipti.TabIndex = 11;
            this.klaraVidskipti.Text = "Klára viðskipti";
            this.klaraVidskipti.UseVisualStyleBackColor = true;
            this.klaraVidskipti.Click += new System.EventHandler(this.klaraVidskipti_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(587, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Þú ert númer";
            // 
            // label_vidskiptavinurNumer
            // 
            this.label_vidskiptavinurNumer.AutoSize = true;
            this.label_vidskiptavinurNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_vidskiptavinurNumer.Location = new System.Drawing.Point(587, 109);
            this.label_vidskiptavinurNumer.Name = "label_vidskiptavinurNumer";
            this.label_vidskiptavinurNumer.Size = new System.Drawing.Size(20, 22);
            this.label_vidskiptavinurNumer.TabIndex = 13;
            this.label_vidskiptavinurNumer.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(744, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Virkt númer";
            // 
            // label_virktNumer
            // 
            this.label_virktNumer.AutoSize = true;
            this.label_virktNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_virktNumer.Location = new System.Drawing.Point(745, 109);
            this.label_virktNumer.Name = "label_virktNumer";
            this.label_virktNumer.Size = new System.Drawing.Size(20, 22);
            this.label_virktNumer.TabIndex = 15;
            this.label_virktNumer.Text = "0";
            // 
            // byrjaVidskipti
            // 
            this.byrjaVidskipti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.byrjaVidskipti.Location = new System.Drawing.Point(400, 66);
            this.byrjaVidskipti.Name = "byrjaVidskipti";
            this.byrjaVidskipti.Size = new System.Drawing.Size(121, 100);
            this.byrjaVidskipti.TabIndex = 16;
            this.byrjaVidskipti.Text = "Byrja viðskipti";
            this.byrjaVidskipti.UseVisualStyleBackColor = true;
            this.byrjaVidskipti.Click += new System.EventHandler(this.byrjaVidskipti_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(745, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Magn í verslun";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(745, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Snúður með karmellu";
            // 
            // label_snKarmellu
            // 
            this.label_snKarmellu.AutoSize = true;
            this.label_snKarmellu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_snKarmellu.Location = new System.Drawing.Point(1024, 377);
            this.label_snKarmellu.Name = "label_snKarmellu";
            this.label_snKarmellu.Size = new System.Drawing.Size(23, 25);
            this.label_snKarmellu.TabIndex = 20;
            this.label_snKarmellu.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(745, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Snúður með súkkulaði";
            // 
            // label_snSukkuladi
            // 
            this.label_snSukkuladi.AutoSize = true;
            this.label_snSukkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_snSukkuladi.Location = new System.Drawing.Point(1024, 402);
            this.label_snSukkuladi.Name = "label_snSukkuladi";
            this.label_snSukkuladi.Size = new System.Drawing.Size(23, 25);
            this.label_snSukkuladi.TabIndex = 22;
            this.label_snSukkuladi.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(745, 422);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Snúður með glassúr";
            // 
            // label_snGlassur
            // 
            this.label_snGlassur.AutoSize = true;
            this.label_snGlassur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_snGlassur.Location = new System.Drawing.Point(1024, 426);
            this.label_snGlassur.Name = "label_snGlassur";
            this.label_snGlassur.Size = new System.Drawing.Size(23, 25);
            this.label_snGlassur.TabIndex = 24;
            this.label_snGlassur.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(745, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "Kleinuhringur með karmellu";
            // 
            // label_klKarmella
            // 
            this.label_klKarmella.AutoSize = true;
            this.label_klKarmella.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_klKarmella.Location = new System.Drawing.Point(1024, 451);
            this.label_klKarmella.Name = "label_klKarmella";
            this.label_klKarmella.Size = new System.Drawing.Size(23, 25);
            this.label_klKarmella.TabIndex = 26;
            this.label_klKarmella.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(744, 474);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(257, 25);
            this.label17.TabIndex = 27;
            this.label17.Text = "Kleinuhringur með súkkulaði";
            // 
            // label_klSukkuladi
            // 
            this.label_klSukkuladi.AutoSize = true;
            this.label_klSukkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_klSukkuladi.Location = new System.Drawing.Point(1023, 476);
            this.label_klSukkuladi.Name = "label_klSukkuladi";
            this.label_klSukkuladi.Size = new System.Drawing.Size(23, 25);
            this.label_klSukkuladi.TabIndex = 28;
            this.label_klSukkuladi.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(744, 500);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(238, 25);
            this.label19.TabIndex = 29;
            this.label19.Text = "Kleinuhringur með glassúr";
            // 
            // label_klGlassur
            // 
            this.label_klGlassur.AutoSize = true;
            this.label_klGlassur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_klGlassur.Location = new System.Drawing.Point(1023, 501);
            this.label_klGlassur.Name = "label_klGlassur";
            this.label_klGlassur.Size = new System.Drawing.Size(23, 25);
            this.label_klGlassur.TabIndex = 30;
            this.label_klGlassur.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(745, 526);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 25);
            this.label21.TabIndex = 31;
            this.label21.Text = "Vínarbrauð";
            // 
            // label_vinabraud
            // 
            this.label_vinabraud.AutoSize = true;
            this.label_vinabraud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_vinabraud.Location = new System.Drawing.Point(1023, 526);
            this.label_vinabraud.Name = "label_vinabraud";
            this.label_vinabraud.Size = new System.Drawing.Size(23, 25);
            this.label_vinabraud.TabIndex = 32;
            this.label_vinabraud.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.Location = new System.Drawing.Point(745, 551);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(194, 25);
            this.label23.TabIndex = 33;
            this.label23.Text = "Vínarbrauð sérbakað";
            // 
            // label_vinabraudSerbakad
            // 
            this.label_vinabraudSerbakad.AutoSize = true;
            this.label_vinabraudSerbakad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_vinabraudSerbakad.Location = new System.Drawing.Point(1023, 551);
            this.label_vinabraudSerbakad.Name = "label_vinabraudSerbakad";
            this.label_vinabraudSerbakad.Size = new System.Drawing.Size(23, 25);
            this.label_vinabraudSerbakad.TabIndex = 34;
            this.label_vinabraudSerbakad.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label25.Location = new System.Drawing.Point(745, 576);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(145, 25);
            this.label25.TabIndex = 35;
            this.label25.Text = "Heilhveiti brauð";
            // 
            // label_braudHeilhveiti
            // 
            this.label_braudHeilhveiti.AutoSize = true;
            this.label_braudHeilhveiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_braudHeilhveiti.Location = new System.Drawing.Point(1023, 576);
            this.label_braudHeilhveiti.Name = "label_braudHeilhveiti";
            this.label_braudHeilhveiti.Size = new System.Drawing.Size(23, 25);
            this.label_braudHeilhveiti.TabIndex = 36;
            this.label_braudHeilhveiti.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label27.Location = new System.Drawing.Point(745, 601);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(201, 25);
            this.label27.TabIndex = 37;
            this.label27.Text = "Heilhveiti brauð Sneið";
            // 
            // label_braudHeilhveitiSneid
            // 
            this.label_braudHeilhveitiSneid.AutoSize = true;
            this.label_braudHeilhveitiSneid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_braudHeilhveitiSneid.Location = new System.Drawing.Point(1023, 601);
            this.label_braudHeilhveitiSneid.Name = "label_braudHeilhveitiSneid";
            this.label_braudHeilhveitiSneid.Size = new System.Drawing.Size(23, 25);
            this.label_braudHeilhveitiSneid.TabIndex = 38;
            this.label_braudHeilhveitiSneid.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label29.Location = new System.Drawing.Point(745, 626);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(105, 25);
            this.label29.TabIndex = 39;
            this.label29.Text = "Hvítt brauð";
            // 
            // label_braudHvitt
            // 
            this.label_braudHvitt.AutoSize = true;
            this.label_braudHvitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_braudHvitt.Location = new System.Drawing.Point(1023, 626);
            this.label_braudHvitt.Name = "label_braudHvitt";
            this.label_braudHvitt.Size = new System.Drawing.Size(23, 25);
            this.label_braudHvitt.TabIndex = 40;
            this.label_braudHvitt.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label31.Location = new System.Drawing.Point(745, 651);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(161, 25);
            this.label31.TabIndex = 41;
            this.label31.Text = "Hvítt brauð Sneið";
            // 
            // label_braudHvittSneid
            // 
            this.label_braudHvittSneid.AutoSize = true;
            this.label_braudHvittSneid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_braudHvittSneid.Location = new System.Drawing.Point(1023, 651);
            this.label_braudHvittSneid.Name = "label_braudHvittSneid";
            this.label_braudHvittSneid.Size = new System.Drawing.Size(23, 25);
            this.label_braudHvittSneid.TabIndex = 42;
            this.label_braudHvittSneid.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 747);
            this.Controls.Add(this.label_braudHvittSneid);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label_braudHvitt);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label_braudHeilhveitiSneid);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label_braudHeilhveiti);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label_vinabraudSerbakad);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label_vinabraud);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label_klGlassur);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label_klSukkuladi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label_klKarmella);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label_snGlassur);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_snSukkuladi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_snKarmellu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.byrjaVidskipti);
            this.Controls.Add(this.label_virktNumer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_vidskiptavinurNumer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.klaraVidskipti);
            this.Controls.Add(this.endaDag);
            this.Controls.Add(this.byrjaDag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kvittun);
            this.Controls.Add(this.label_magnVoru);
            this.Controls.Add(this.magnPlus);
            this.Controls.Add(this.magnMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vara);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button magnMinus;
        private System.Windows.Forms.Button magnPlus;
        private System.Windows.Forms.Label label_magnVoru;
        private System.Windows.Forms.RichTextBox kvittun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button byrjaVidskipti;
        private System.Windows.Forms.Label label_virktNumer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_vidskiptavinurNumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button klaraVidskipti;
        private System.Windows.Forms.Button endaDag;
        private System.Windows.Forms.Button byrjaDag;
        private System.Windows.Forms.Label label_braudHvittSneid;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label_braudHvitt;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label_braudHeilhveitiSneid;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label_braudHeilhveiti;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label_vinabraudSerbakad;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_vinabraud;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_klGlassur;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_klSukkuladi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_klKarmella;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_snGlassur;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_snSukkuladi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_snKarmellu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}

