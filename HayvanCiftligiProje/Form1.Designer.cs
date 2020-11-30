namespace HayvanCiftligiProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keciAdet = new System.Windows.Forms.RichTextBox();
            this.ordekAdet = new System.Windows.Forms.RichTextBox();
            this.inekAdet = new System.Windows.Forms.RichTextBox();
            this.tavukAdet = new System.Windows.Forms.RichTextBox();
            this.keciText = new System.Windows.Forms.TextBox();
            this.ordekText = new System.Windows.Forms.TextBox();
            this.inekText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tavukText = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.GroupBox();
            this.sure = new System.Windows.Forms.Label();
            this.kasaTxt = new System.Windows.Forms.TextBox();
            this.sureTxt = new System.Windows.Forms.TextBox();
            this.keciSutSat = new System.Windows.Forms.Button();
            this.kasa = new System.Windows.Forms.RichTextBox();
            this.inekSutSat = new System.Windows.Forms.Button();
            this.ordekYumSat = new System.Windows.Forms.Button();
            this.tavukYumSat = new System.Windows.Forms.Button();
            this.rr = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ordekYemVer = new System.Windows.Forms.Button();
            this.tavukYemVer = new System.Windows.Forms.Button();
            this.ordekCan = new System.Windows.Forms.ProgressBar();
            this.tavukCan = new System.Windows.Forms.ProgressBar();
            this.ordekCanli = new System.Windows.Forms.TextBox();
            this.tavukCanli = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.keciYemVer = new System.Windows.Forms.Button();
            this.inekYemVer = new System.Windows.Forms.Button();
            this.keciCan = new System.Windows.Forms.ProgressBar();
            this.inekCan = new System.Windows.Forms.ProgressBar();
            this.keciCanli = new System.Windows.Forms.TextBox();
            this.inekCanli = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.t.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.keciAdet);
            this.groupBox1.Controls.Add(this.ordekAdet);
            this.groupBox1.Controls.Add(this.inekAdet);
            this.groupBox1.Controls.Add(this.tavukAdet);
            this.groupBox1.Controls.Add(this.keciText);
            this.groupBox1.Controls.Add(this.ordekText);
            this.groupBox1.Controls.Add(this.inekText);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tavukText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // keciAdet
            // 
            this.keciAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.keciAdet.Location = new System.Drawing.Point(192, 144);
            this.keciAdet.Name = "keciAdet";
            this.keciAdet.Size = new System.Drawing.Size(151, 46);
            this.keciAdet.TabIndex = 10;
            this.keciAdet.Text = "0 ADET";
            // 
            // ordekAdet
            // 
            this.ordekAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ordekAdet.Location = new System.Drawing.Point(30, 144);
            this.ordekAdet.Name = "ordekAdet";
            this.ordekAdet.Size = new System.Drawing.Size(156, 46);
            this.ordekAdet.TabIndex = 9;
            this.ordekAdet.Text = "0 ADET";
            // 
            // inekAdet
            // 
            this.inekAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inekAdet.Location = new System.Drawing.Point(192, 66);
            this.inekAdet.Name = "inekAdet";
            this.inekAdet.Size = new System.Drawing.Size(151, 46);
            this.inekAdet.TabIndex = 8;
            this.inekAdet.Text = "0 ADET";
            // 
            // tavukAdet
            // 
            this.tavukAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tavukAdet.Location = new System.Drawing.Point(30, 66);
            this.tavukAdet.Name = "tavukAdet";
            this.tavukAdet.Size = new System.Drawing.Size(156, 46);
            this.tavukAdet.TabIndex = 7;
            this.tavukAdet.Text = "0 ADET";
            // 
            // keciText
            // 
            this.keciText.BackColor = System.Drawing.Color.MistyRose;
            this.keciText.Location = new System.Drawing.Point(192, 118);
            this.keciText.Name = "keciText";
            this.keciText.Size = new System.Drawing.Size(151, 20);
            this.keciText.TabIndex = 5;
            this.keciText.Text = "               KEÇİ SÜTÜ";
            // 
            // ordekText
            // 
            this.ordekText.BackColor = System.Drawing.Color.MistyRose;
            this.ordekText.Location = new System.Drawing.Point(30, 118);
            this.ordekText.Name = "ordekText";
            this.ordekText.Size = new System.Drawing.Size(156, 20);
            this.ordekText.TabIndex = 6;
            this.ordekText.Text = "        ÖRDEK YUMRTASI";
            // 
            // inekText
            // 
            this.inekText.BackColor = System.Drawing.Color.MistyRose;
            this.inekText.Location = new System.Drawing.Point(192, 40);
            this.inekText.Name = "inekText";
            this.inekText.Size = new System.Drawing.Size(151, 20);
            this.inekText.TabIndex = 1;
            this.inekText.Text = "             İNEK SÜTÜ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.IndianRed;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(30, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "                         ÜRÜN DEPOSU";
            // 
            // tavukText
            // 
            this.tavukText.BackColor = System.Drawing.Color.MistyRose;
            this.tavukText.Location = new System.Drawing.Point(30, 40);
            this.tavukText.Name = "tavukText";
            this.tavukText.Size = new System.Drawing.Size(156, 20);
            this.tavukText.TabIndex = 2;
            this.tavukText.Text = "     TAVUK YUMURTASI";
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.LightSeaGreen;
            this.t.Controls.Add(this.sure);
            this.t.Controls.Add(this.kasaTxt);
            this.t.Controls.Add(this.sureTxt);
            this.t.Controls.Add(this.keciSutSat);
            this.t.Controls.Add(this.kasa);
            this.t.Controls.Add(this.inekSutSat);
            this.t.Controls.Add(this.ordekYumSat);
            this.t.Controls.Add(this.tavukYumSat);
            this.t.Controls.Add(this.rr);
            this.t.Location = new System.Drawing.Point(382, 12);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(364, 215);
            this.t.TabIndex = 12;
            this.t.TabStop = false;
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.Location = new System.Drawing.Point(245, 54);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(0, 31);
            this.sure.TabIndex = 13;
            // 
            // kasaTxt
            // 
            this.kasaTxt.BackColor = System.Drawing.Color.MistyRose;
            this.kasaTxt.Location = new System.Drawing.Point(234, 118);
            this.kasaTxt.Name = "kasaTxt";
            this.kasaTxt.Size = new System.Drawing.Size(115, 20);
            this.kasaTxt.TabIndex = 12;
            this.kasaTxt.Text = "          KASA";
            // 
            // sureTxt
            // 
            this.sureTxt.BackColor = System.Drawing.Color.MistyRose;
            this.sureTxt.Location = new System.Drawing.Point(234, 19);
            this.sureTxt.Name = "sureTxt";
            this.sureTxt.Size = new System.Drawing.Size(115, 20);
            this.sureTxt.TabIndex = 11;
            this.sureTxt.Text = "    GEÇEN SÜRE";
            // 
            // keciSutSat
            // 
            this.keciSutSat.Location = new System.Drawing.Point(21, 162);
            this.keciSutSat.Name = "keciSutSat";
            this.keciSutSat.Size = new System.Drawing.Size(177, 33);
            this.keciSutSat.TabIndex = 10;
            this.keciSutSat.Text = "KEÇİ SÜTÜ SAT";
            this.keciSutSat.UseVisualStyleBackColor = true;
            this.keciSutSat.Click += new System.EventHandler(this.keciSutSat_Click);
            // 
            // kasa
            // 
            this.kasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasa.Location = new System.Drawing.Point(234, 141);
            this.kasa.Name = "kasa";
            this.kasa.Size = new System.Drawing.Size(115, 54);
            this.kasa.TabIndex = 7;
            this.kasa.Text = "0 TL";
            // 
            // inekSutSat
            // 
            this.inekSutSat.Location = new System.Drawing.Point(21, 123);
            this.inekSutSat.Name = "inekSutSat";
            this.inekSutSat.Size = new System.Drawing.Size(177, 33);
            this.inekSutSat.TabIndex = 9;
            this.inekSutSat.Text = "İNEK SÜTÜ SAT";
            this.inekSutSat.UseVisualStyleBackColor = true;
            this.inekSutSat.Click += new System.EventHandler(this.inekSutSat_Click);
            // 
            // ordekYumSat
            // 
            this.ordekYumSat.Location = new System.Drawing.Point(21, 84);
            this.ordekYumSat.Name = "ordekYumSat";
            this.ordekYumSat.Size = new System.Drawing.Size(177, 33);
            this.ordekYumSat.TabIndex = 8;
            this.ordekYumSat.Text = "ÖRDEK YUMURTASI SAT";
            this.ordekYumSat.UseVisualStyleBackColor = true;
            this.ordekYumSat.Click += new System.EventHandler(this.ordekYumSat_Click);
            // 
            // tavukYumSat
            // 
            this.tavukYumSat.Location = new System.Drawing.Point(21, 45);
            this.tavukYumSat.Name = "tavukYumSat";
            this.tavukYumSat.Size = new System.Drawing.Size(177, 33);
            this.tavukYumSat.TabIndex = 7;
            this.tavukYumSat.Text = "TAVUK YUMURTASI SAT";
            this.tavukYumSat.UseVisualStyleBackColor = true;
            this.tavukYumSat.Click += new System.EventHandler(this.tavukYumSat_Click);
            // 
            // rr
            // 
            this.rr.BackColor = System.Drawing.Color.IndianRed;
            this.rr.Location = new System.Drawing.Point(21, 19);
            this.rr.Name = "rr";
            this.rr.Size = new System.Drawing.Size(177, 20);
            this.rr.TabIndex = 6;
            this.rr.Text = "            GIDA FABRİKASI";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.ordekYemVer);
            this.groupBox2.Controls.Add(this.tavukYemVer);
            this.groupBox2.Controls.Add(this.ordekCan);
            this.groupBox2.Controls.Add(this.tavukCan);
            this.groupBox2.Controls.Add(this.ordekCanli);
            this.groupBox2.Controls.Add(this.tavukCanli);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 217);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ordekYemVer
            // 
            this.ordekYemVer.Location = new System.Drawing.Point(121, 185);
            this.ordekYemVer.Name = "ordekYemVer";
            this.ordekYemVer.Size = new System.Drawing.Size(237, 23);
            this.ordekYemVer.TabIndex = 24;
            this.ordekYemVer.Text = "YEM VER";
            this.ordekYemVer.UseVisualStyleBackColor = true;
            this.ordekYemVer.Click += new System.EventHandler(this.ordekYemVer_Click);
            // 
            // tavukYemVer
            // 
            this.tavukYemVer.Location = new System.Drawing.Point(121, 87);
            this.tavukYemVer.Name = "tavukYemVer";
            this.tavukYemVer.Size = new System.Drawing.Size(237, 23);
            this.tavukYemVer.TabIndex = 23;
            this.tavukYemVer.Text = " YEM VER";
            this.tavukYemVer.UseVisualStyleBackColor = true;
            this.tavukYemVer.Click += new System.EventHandler(this.tavukYemVer_Click);
            // 
            // ordekCan
            // 
            this.ordekCan.Location = new System.Drawing.Point(121, 149);
            this.ordekCan.Name = "ordekCan";
            this.ordekCan.Size = new System.Drawing.Size(237, 23);
            this.ordekCan.TabIndex = 21;
            // 
            // tavukCan
            // 
            this.tavukCan.Location = new System.Drawing.Point(121, 58);
            this.tavukCan.Name = "tavukCan";
            this.tavukCan.Size = new System.Drawing.Size(237, 23);
            this.tavukCan.Step = 2;
            this.tavukCan.TabIndex = 20;
            // 
            // ordekCanli
            // 
            this.ordekCanli.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ordekCanli.Location = new System.Drawing.Point(121, 123);
            this.ordekCanli.Name = "ordekCanli";
            this.ordekCanli.Size = new System.Drawing.Size(237, 20);
            this.ordekCanli.TabIndex = 18;
            // 
            // tavukCanli
            // 
            this.tavukCanli.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tavukCanli.Location = new System.Drawing.Point(121, 32);
            this.tavukCanli.Name = "tavukCanli";
            this.tavukCanli.Size = new System.Drawing.Size(237, 20);
            this.tavukCanli.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.IndianRed;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(6, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(358, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "                          KÜMES";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.keciYemVer);
            this.groupBox3.Controls.Add(this.inekYemVer);
            this.groupBox3.Controls.Add(this.keciCan);
            this.groupBox3.Controls.Add(this.inekCan);
            this.groupBox3.Controls.Add(this.keciCanli);
            this.groupBox3.Controls.Add(this.inekCanli);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(382, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 217);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 123);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // keciYemVer
            // 
            this.keciYemVer.Location = new System.Drawing.Point(121, 178);
            this.keciYemVer.Name = "keciYemVer";
            this.keciYemVer.Size = new System.Drawing.Size(237, 23);
            this.keciYemVer.TabIndex = 25;
            this.keciYemVer.Text = "YEM VER";
            this.keciYemVer.UseVisualStyleBackColor = true;
            this.keciYemVer.Click += new System.EventHandler(this.keciYemVer_Click);
            // 
            // inekYemVer
            // 
            this.inekYemVer.Location = new System.Drawing.Point(121, 87);
            this.inekYemVer.Name = "inekYemVer";
            this.inekYemVer.Size = new System.Drawing.Size(237, 23);
            this.inekYemVer.TabIndex = 24;
            this.inekYemVer.Text = "YEM VER";
            this.inekYemVer.UseVisualStyleBackColor = true;
            this.inekYemVer.Click += new System.EventHandler(this.inekYemVer_Click);
            // 
            // keciCan
            // 
            this.keciCan.Location = new System.Drawing.Point(121, 149);
            this.keciCan.Name = "keciCan";
            this.keciCan.Size = new System.Drawing.Size(237, 23);
            this.keciCan.TabIndex = 22;
            // 
            // inekCan
            // 
            this.inekCan.Location = new System.Drawing.Point(121, 58);
            this.inekCan.Name = "inekCan";
            this.inekCan.Size = new System.Drawing.Size(237, 23);
            this.inekCan.TabIndex = 21;
            // 
            // keciCanli
            // 
            this.keciCanli.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.keciCanli.Location = new System.Drawing.Point(121, 123);
            this.keciCanli.Name = "keciCanli";
            this.keciCanli.Size = new System.Drawing.Size(237, 20);
            this.keciCanli.TabIndex = 19;
            // 
            // inekCanli
            // 
            this.inekCanli.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inekCanli.Location = new System.Drawing.Point(121, 32);
            this.inekCanli.Name = "inekCanli";
            this.inekCanli.Size = new System.Drawing.Size(237, 20);
            this.inekCanli.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.IndianRed;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(358, 26);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "                             AHIR";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.t);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.t.ResumeLayout(false);
            this.t.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox keciAdet;
        private System.Windows.Forms.RichTextBox ordekAdet;
        private System.Windows.Forms.RichTextBox inekAdet;
        private System.Windows.Forms.TextBox keciText;
        private System.Windows.Forms.TextBox ordekText;
        private System.Windows.Forms.TextBox inekText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tavukText;
        private System.Windows.Forms.GroupBox t;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.TextBox kasaTxt;
        private System.Windows.Forms.TextBox sureTxt;
        private System.Windows.Forms.Button keciSutSat;
        private System.Windows.Forms.RichTextBox kasa;
        private System.Windows.Forms.Button inekSutSat;
        private System.Windows.Forms.Button ordekYumSat;
        private System.Windows.Forms.Button tavukYumSat;
        private System.Windows.Forms.TextBox rr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ordekYemVer;
        private System.Windows.Forms.Button tavukYemVer;
        private System.Windows.Forms.ProgressBar ordekCan;
        private System.Windows.Forms.ProgressBar tavukCan;
        private System.Windows.Forms.TextBox ordekCanli;
        private System.Windows.Forms.TextBox tavukCanli;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button keciYemVer;
        private System.Windows.Forms.Button inekYemVer;
        private System.Windows.Forms.ProgressBar keciCan;
        private System.Windows.Forms.ProgressBar inekCan;
        private System.Windows.Forms.TextBox keciCanli;
        private System.Windows.Forms.TextBox inekCanli;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox tavukAdet;
    }
}

