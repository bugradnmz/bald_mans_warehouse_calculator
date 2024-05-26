namespace bald_mans_warehouse_calculator
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.menu_listbox = new System.Windows.Forms.ListBox();
            this.kereste_box = new System.Windows.Forms.GroupBox();
            this.keresteSonuc_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keresteCalc_btn = new System.Windows.Forms.Button();
            this.keresteZ_txt = new System.Windows.Forms.TextBox();
            this.keresteY_txt = new System.Windows.Forms.TextBox();
            this.keresteAdet_txt = new System.Windows.Forms.TextBox();
            this.keresteX_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nervurlu_box = new System.Windows.Forms.GroupBox();
            this.demirSonuc_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.demirAdet_txt = new System.Windows.Forms.TextBox();
            this.demirUzunluk_txt = new System.Windows.Forms.TextBox();
            this.Q36_btn = new System.Windows.Forms.RadioButton();
            this.Q32_btn = new System.Windows.Forms.RadioButton();
            this.Q30_btn = new System.Windows.Forms.RadioButton();
            this.Q28_btn = new System.Windows.Forms.RadioButton();
            this.Q26_btn = new System.Windows.Forms.RadioButton();
            this.Q24_btn = new System.Windows.Forms.RadioButton();
            this.Q22_btn = new System.Windows.Forms.RadioButton();
            this.Q20_btn = new System.Windows.Forms.RadioButton();
            this.Q18_btn = new System.Windows.Forms.RadioButton();
            this.Q16_btn = new System.Windows.Forms.RadioButton();
            this.Q14_btn = new System.Windows.Forms.RadioButton();
            this.Q12_btn = new System.Windows.Forms.RadioButton();
            this.Q10_btn = new System.Windows.Forms.RadioButton();
            this.Q8_btn = new System.Windows.Forms.RadioButton();
            this.welcome_box = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.demirCalc_btn = new System.Windows.Forms.Button();
            this.kereste_box.SuspendLayout();
            this.nervurlu_box.SuspendLayout();
            this.welcome_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_listbox
            // 
            this.menu_listbox.BackColor = System.Drawing.Color.LightCoral;
            this.menu_listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menu_listbox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menu_listbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_listbox.FormattingEnabled = true;
            this.menu_listbox.ItemHeight = 14;
            this.menu_listbox.Items.AddRange(new object[] {
            "KERESTE (M3)",
            "NERV. DEMİR (KG)"});
            this.menu_listbox.Location = new System.Drawing.Point(210, 8);
            this.menu_listbox.Name = "menu_listbox";
            this.menu_listbox.Size = new System.Drawing.Size(120, 182);
            this.menu_listbox.TabIndex = 0;
            this.menu_listbox.SelectedIndexChanged += new System.EventHandler(this.menu_listbox_SelectedIndexChanged);
            // 
            // kereste_box
            // 
            this.kereste_box.Controls.Add(this.keresteSonuc_lbl);
            this.kereste_box.Controls.Add(this.label4);
            this.kereste_box.Controls.Add(this.label3);
            this.kereste_box.Controls.Add(this.label2);
            this.kereste_box.Controls.Add(this.keresteCalc_btn);
            this.kereste_box.Controls.Add(this.keresteZ_txt);
            this.kereste_box.Controls.Add(this.keresteY_txt);
            this.kereste_box.Controls.Add(this.keresteAdet_txt);
            this.kereste_box.Controls.Add(this.keresteX_txt);
            this.kereste_box.Controls.Add(this.label1);
            this.kereste_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kereste_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kereste_box.Location = new System.Drawing.Point(336, 8);
            this.kereste_box.Name = "kereste_box";
            this.kereste_box.Size = new System.Drawing.Size(380, 182);
            this.kereste_box.TabIndex = 1;
            this.kereste_box.TabStop = false;
            this.kereste_box.Text = "KERESTE - M3";
            this.kereste_box.Visible = false;
            // 
            // keresteSonuc_lbl
            // 
            this.keresteSonuc_lbl.AutoSize = true;
            this.keresteSonuc_lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.keresteSonuc_lbl.Location = new System.Drawing.Point(280, 77);
            this.keresteSonuc_lbl.Name = "keresteSonuc_lbl";
            this.keresteSonuc_lbl.Size = new System.Drawing.Size(26, 14);
            this.keresteSonuc_lbl.TabIndex = 3;
            this.keresteSonuc_lbl.Text = "m3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(280, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sonuç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(147, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "En/Boy/Yükseklik";
            // 
            // keresteCalc_btn
            // 
            this.keresteCalc_btn.Location = new System.Drawing.Point(147, 112);
            this.keresteCalc_btn.Name = "keresteCalc_btn";
            this.keresteCalc_btn.Size = new System.Drawing.Size(75, 23);
            this.keresteCalc_btn.TabIndex = 4;
            this.keresteCalc_btn.Text = "Hesapla";
            this.keresteCalc_btn.UseVisualStyleBackColor = true;
            this.keresteCalc_btn.Click += new System.EventHandler(this.keresteCalc_btn_Click);
            // 
            // keresteZ_txt
            // 
            this.keresteZ_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keresteZ_txt.Location = new System.Drawing.Point(10, 130);
            this.keresteZ_txt.Name = "keresteZ_txt";
            this.keresteZ_txt.Size = new System.Drawing.Size(100, 22);
            this.keresteZ_txt.TabIndex = 2;
            this.keresteZ_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keresteZ_txt_KeyPress);
            // 
            // keresteY_txt
            // 
            this.keresteY_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keresteY_txt.Location = new System.Drawing.Point(10, 102);
            this.keresteY_txt.Name = "keresteY_txt";
            this.keresteY_txt.Size = new System.Drawing.Size(100, 22);
            this.keresteY_txt.TabIndex = 1;
            this.keresteY_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keresteY_txt_KeyPress);
            // 
            // keresteAdet_txt
            // 
            this.keresteAdet_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keresteAdet_txt.Location = new System.Drawing.Point(147, 74);
            this.keresteAdet_txt.Name = "keresteAdet_txt";
            this.keresteAdet_txt.Size = new System.Drawing.Size(100, 22);
            this.keresteAdet_txt.TabIndex = 3;
            this.keresteAdet_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keresteAdet_txt_KeyPress);
            // 
            // keresteX_txt
            // 
            this.keresteX_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keresteX_txt.Location = new System.Drawing.Point(10, 74);
            this.keresteX_txt.Name = "keresteX_txt";
            this.keresteX_txt.Size = new System.Drawing.Size(100, 22);
            this.keresteX_txt.TabIndex = 0;
            this.keresteX_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keresteX_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CM cinsinden en, boy, yükseklik yazınız ve adeti belirtiniz.";
            // 
            // nervurlu_box
            // 
            this.nervurlu_box.Controls.Add(this.demirCalc_btn);
            this.nervurlu_box.Controls.Add(this.demirSonuc_lbl);
            this.nervurlu_box.Controls.Add(this.label9);
            this.nervurlu_box.Controls.Add(this.label10);
            this.nervurlu_box.Controls.Add(this.label8);
            this.nervurlu_box.Controls.Add(this.label7);
            this.nervurlu_box.Controls.Add(this.demirAdet_txt);
            this.nervurlu_box.Controls.Add(this.demirUzunluk_txt);
            this.nervurlu_box.Controls.Add(this.Q36_btn);
            this.nervurlu_box.Controls.Add(this.Q32_btn);
            this.nervurlu_box.Controls.Add(this.Q30_btn);
            this.nervurlu_box.Controls.Add(this.Q28_btn);
            this.nervurlu_box.Controls.Add(this.Q26_btn);
            this.nervurlu_box.Controls.Add(this.Q24_btn);
            this.nervurlu_box.Controls.Add(this.Q22_btn);
            this.nervurlu_box.Controls.Add(this.Q20_btn);
            this.nervurlu_box.Controls.Add(this.Q18_btn);
            this.nervurlu_box.Controls.Add(this.Q16_btn);
            this.nervurlu_box.Controls.Add(this.Q14_btn);
            this.nervurlu_box.Controls.Add(this.Q12_btn);
            this.nervurlu_box.Controls.Add(this.Q10_btn);
            this.nervurlu_box.Controls.Add(this.Q8_btn);
            this.nervurlu_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nervurlu_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nervurlu_box.Location = new System.Drawing.Point(336, 8);
            this.nervurlu_box.Name = "nervurlu_box";
            this.nervurlu_box.Size = new System.Drawing.Size(380, 182);
            this.nervurlu_box.TabIndex = 2;
            this.nervurlu_box.TabStop = false;
            this.nervurlu_box.Text = "NERVÜRLÜ DEMİR";
            this.nervurlu_box.Visible = false;
            // 
            // demirSonuc_lbl
            // 
            this.demirSonuc_lbl.AutoSize = true;
            this.demirSonuc_lbl.Location = new System.Drawing.Point(291, 72);
            this.demirSonuc_lbl.Name = "demirSonuc_lbl";
            this.demirSonuc_lbl.Size = new System.Drawing.Size(22, 14);
            this.demirSonuc_lbl.TabIndex = 15;
            this.demirSonuc_lbl.Text = "kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label9.Location = new System.Drawing.Point(162, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adet (Boy)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label10.Location = new System.Drawing.Point(290, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sonuç";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(162, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Uzunluk (Metre)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(358, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Demir çapını seçip, uzunluk giriniz ve adet (boy) belirtiniz.";
            // 
            // demirAdet_txt
            // 
            this.demirAdet_txt.Location = new System.Drawing.Point(165, 118);
            this.demirAdet_txt.Name = "demirAdet_txt";
            this.demirAdet_txt.Size = new System.Drawing.Size(100, 22);
            this.demirAdet_txt.TabIndex = 1;
            this.demirAdet_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.demirAdet_txt_KeyPress);
            // 
            // demirUzunluk_txt
            // 
            this.demirUzunluk_txt.Location = new System.Drawing.Point(165, 68);
            this.demirUzunluk_txt.Name = "demirUzunluk_txt";
            this.demirUzunluk_txt.Size = new System.Drawing.Size(100, 22);
            this.demirUzunluk_txt.TabIndex = 0;
            this.demirUzunluk_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.demirUzunluk_txt_KeyPress);
            // 
            // Q36_btn
            // 
            this.Q36_btn.AutoSize = true;
            this.Q36_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q36_btn.Location = new System.Drawing.Point(78, 156);
            this.Q36_btn.Name = "Q36_btn";
            this.Q36_btn.Size = new System.Drawing.Size(70, 18);
            this.Q36_btn.TabIndex = 13;
            this.Q36_btn.Text = "Ø36 MM";
            this.Q36_btn.UseVisualStyleBackColor = true;
            // 
            // Q32_btn
            // 
            this.Q32_btn.AutoSize = true;
            this.Q32_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q32_btn.Location = new System.Drawing.Point(78, 137);
            this.Q32_btn.Name = "Q32_btn";
            this.Q32_btn.Size = new System.Drawing.Size(70, 18);
            this.Q32_btn.TabIndex = 12;
            this.Q32_btn.Text = "Ø32 MM";
            this.Q32_btn.UseVisualStyleBackColor = true;
            // 
            // Q30_btn
            // 
            this.Q30_btn.AutoSize = true;
            this.Q30_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q30_btn.Location = new System.Drawing.Point(79, 119);
            this.Q30_btn.Name = "Q30_btn";
            this.Q30_btn.Size = new System.Drawing.Size(70, 18);
            this.Q30_btn.TabIndex = 11;
            this.Q30_btn.Text = "Ø30 MM";
            this.Q30_btn.UseVisualStyleBackColor = true;
            // 
            // Q28_btn
            // 
            this.Q28_btn.AutoSize = true;
            this.Q28_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q28_btn.Location = new System.Drawing.Point(79, 100);
            this.Q28_btn.Name = "Q28_btn";
            this.Q28_btn.Size = new System.Drawing.Size(70, 18);
            this.Q28_btn.TabIndex = 10;
            this.Q28_btn.Text = "Ø28 MM";
            this.Q28_btn.UseVisualStyleBackColor = true;
            // 
            // Q26_btn
            // 
            this.Q26_btn.AutoSize = true;
            this.Q26_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q26_btn.Location = new System.Drawing.Point(78, 80);
            this.Q26_btn.Name = "Q26_btn";
            this.Q26_btn.Size = new System.Drawing.Size(70, 18);
            this.Q26_btn.TabIndex = 9;
            this.Q26_btn.Text = "Ø26 MM";
            this.Q26_btn.UseVisualStyleBackColor = true;
            // 
            // Q24_btn
            // 
            this.Q24_btn.AutoSize = true;
            this.Q24_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q24_btn.Location = new System.Drawing.Point(78, 59);
            this.Q24_btn.Name = "Q24_btn";
            this.Q24_btn.Size = new System.Drawing.Size(70, 18);
            this.Q24_btn.TabIndex = 8;
            this.Q24_btn.Text = "Ø24 MM";
            this.Q24_btn.UseVisualStyleBackColor = true;
            // 
            // Q22_btn
            // 
            this.Q22_btn.AutoSize = true;
            this.Q22_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q22_btn.Location = new System.Drawing.Point(78, 41);
            this.Q22_btn.Name = "Q22_btn";
            this.Q22_btn.Size = new System.Drawing.Size(70, 18);
            this.Q22_btn.TabIndex = 7;
            this.Q22_btn.Text = "Ø22 MM";
            this.Q22_btn.UseVisualStyleBackColor = true;
            // 
            // Q20_btn
            // 
            this.Q20_btn.AutoSize = true;
            this.Q20_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q20_btn.Location = new System.Drawing.Point(10, 156);
            this.Q20_btn.Name = "Q20_btn";
            this.Q20_btn.Size = new System.Drawing.Size(70, 18);
            this.Q20_btn.TabIndex = 6;
            this.Q20_btn.Text = "Ø20 MM";
            this.Q20_btn.UseVisualStyleBackColor = true;
            // 
            // Q18_btn
            // 
            this.Q18_btn.AutoSize = true;
            this.Q18_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q18_btn.Location = new System.Drawing.Point(10, 137);
            this.Q18_btn.Name = "Q18_btn";
            this.Q18_btn.Size = new System.Drawing.Size(70, 18);
            this.Q18_btn.TabIndex = 5;
            this.Q18_btn.Text = "Ø18 MM";
            this.Q18_btn.UseVisualStyleBackColor = true;
            // 
            // Q16_btn
            // 
            this.Q16_btn.AutoSize = true;
            this.Q16_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q16_btn.Location = new System.Drawing.Point(10, 119);
            this.Q16_btn.Name = "Q16_btn";
            this.Q16_btn.Size = new System.Drawing.Size(70, 18);
            this.Q16_btn.TabIndex = 4;
            this.Q16_btn.Text = "Ø16 MM";
            this.Q16_btn.UseVisualStyleBackColor = true;
            // 
            // Q14_btn
            // 
            this.Q14_btn.AutoSize = true;
            this.Q14_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q14_btn.Location = new System.Drawing.Point(10, 100);
            this.Q14_btn.Name = "Q14_btn";
            this.Q14_btn.Size = new System.Drawing.Size(70, 18);
            this.Q14_btn.TabIndex = 3;
            this.Q14_btn.Text = "Ø14 MM";
            this.Q14_btn.UseVisualStyleBackColor = true;
            // 
            // Q12_btn
            // 
            this.Q12_btn.AutoSize = true;
            this.Q12_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q12_btn.Location = new System.Drawing.Point(10, 80);
            this.Q12_btn.Name = "Q12_btn";
            this.Q12_btn.Size = new System.Drawing.Size(70, 18);
            this.Q12_btn.TabIndex = 2;
            this.Q12_btn.Text = "Ø12 MM";
            this.Q12_btn.UseVisualStyleBackColor = true;
            // 
            // Q10_btn
            // 
            this.Q10_btn.AutoSize = true;
            this.Q10_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q10_btn.Location = new System.Drawing.Point(10, 59);
            this.Q10_btn.Name = "Q10_btn";
            this.Q10_btn.Size = new System.Drawing.Size(70, 18);
            this.Q10_btn.TabIndex = 0;
            this.Q10_btn.Text = "Ø10 MM";
            this.Q10_btn.UseVisualStyleBackColor = true;
            // 
            // Q8_btn
            // 
            this.Q8_btn.AutoSize = true;
            this.Q8_btn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Q8_btn.Location = new System.Drawing.Point(10, 39);
            this.Q8_btn.Name = "Q8_btn";
            this.Q8_btn.Size = new System.Drawing.Size(63, 18);
            this.Q8_btn.TabIndex = 0;
            this.Q8_btn.Text = "Ø8 MM";
            this.Q8_btn.UseVisualStyleBackColor = true;
            // 
            // welcome_box
            // 
            this.welcome_box.Controls.Add(this.label6);
            this.welcome_box.Controls.Add(this.label5);
            this.welcome_box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcome_box.Location = new System.Drawing.Point(336, 8);
            this.welcome_box.Name = "welcome_box";
            this.welcome_box.Size = new System.Drawing.Size(380, 182);
            this.welcome_box.TabIndex = 5;
            this.welcome_box.TabStop = false;
            this.welcome_box.Text = "HOŞGELDİNİZ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 64);
            this.label6.TabIndex = 1;
            this.label6.Text = "Buğra DÖNMEZ\'in ÖZALTIN ambar çalışanlarına hediyesidir.\r\n\r\n2024";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 83);
            this.label5.TabIndex = 0;
            this.label5.Text = "Malzeme talep edilirken veya çıkış yapılırken formlara IFS üzerindeki birim yerin" +
    "e adet/boy vs. yazıldığında, bu program ile birimleri kolayca IFS üzerindeki bir" +
    "ime dönüştürebilirsiniz.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // demirCalc_btn
            // 
            this.demirCalc_btn.Location = new System.Drawing.Point(165, 147);
            this.demirCalc_btn.Name = "demirCalc_btn";
            this.demirCalc_btn.Size = new System.Drawing.Size(75, 23);
            this.demirCalc_btn.TabIndex = 2;
            this.demirCalc_btn.Text = "Hesapla";
            this.demirCalc_btn.UseVisualStyleBackColor = true;
            this.demirCalc_btn.Click += new System.EventHandler(this.demirCalc_btn_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(728, 202);
            this.Controls.Add(this.menu_listbox);
            this.Controls.Add(this.nervurlu_box);
            this.Controls.Add(this.welcome_box);
            this.Controls.Add(this.kereste_box);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bald Man\'s Warehouse Calculator v1.0.0";
            this.Click += new System.EventHandler(this.form_main_Click);
            this.kereste_box.ResumeLayout(false);
            this.kereste_box.PerformLayout();
            this.nervurlu_box.ResumeLayout(false);
            this.nervurlu_box.PerformLayout();
            this.welcome_box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox menu_listbox;
        private System.Windows.Forms.GroupBox kereste_box;
        private System.Windows.Forms.GroupBox nervurlu_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button keresteCalc_btn;
        private System.Windows.Forms.TextBox keresteZ_txt;
        private System.Windows.Forms.TextBox keresteY_txt;
        private System.Windows.Forms.TextBox keresteAdet_txt;
        private System.Windows.Forms.TextBox keresteX_txt;
        private System.Windows.Forms.Label keresteSonuc_lbl;
        private System.Windows.Forms.GroupBox welcome_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Q8_btn;
        private System.Windows.Forms.RadioButton Q36_btn;
        private System.Windows.Forms.RadioButton Q32_btn;
        private System.Windows.Forms.RadioButton Q30_btn;
        private System.Windows.Forms.RadioButton Q28_btn;
        private System.Windows.Forms.RadioButton Q26_btn;
        private System.Windows.Forms.RadioButton Q24_btn;
        private System.Windows.Forms.RadioButton Q22_btn;
        private System.Windows.Forms.RadioButton Q20_btn;
        private System.Windows.Forms.RadioButton Q18_btn;
        private System.Windows.Forms.RadioButton Q16_btn;
        private System.Windows.Forms.RadioButton Q14_btn;
        private System.Windows.Forms.RadioButton Q12_btn;
        private System.Windows.Forms.RadioButton Q10_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox demirUzunluk_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox demirAdet_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label demirSonuc_lbl;
        private System.Windows.Forms.Button demirCalc_btn;
    }
}

