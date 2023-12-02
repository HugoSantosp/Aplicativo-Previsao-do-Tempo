namespace Aplicativo_Previsão_do_Tempo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_enviar = new System.Windows.Forms.Button();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_moonphase = new System.Windows.Forms.PictureBox();
            this.pb_contionalslug = new System.Windows.Forms.PictureBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.pb_temp = new System.Windows.Forms.PictureBox();
            this.lb_temp = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_windspeed = new System.Windows.Forms.Label();
            this.lb_rain = new System.Windows.Forms.Label();
            this.lb_timezone = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_sunrise = new System.Windows.Forms.Label();
            this.lb_sunset = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lb_clock = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bt_ipgeo = new System.Windows.Forms.Button();
            this.lb_ip1 = new System.Windows.Forms.Label();
            this.lb_type1 = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_region1 = new System.Windows.Forms.Label();
            this.lb_region = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_moonphase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_contionalslug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(312, 43);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(99, 32);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Consultar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(21, 49);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(149, 26);
            this.tb_cidade.TabIndex = 2;
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cb_estado.Location = new System.Drawing.Point(205, 47);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(63, 28);
            this.cb_estado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite Sua Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado";
            // 
            // pb_moonphase
            // 
            this.pb_moonphase.Location = new System.Drawing.Point(40, 213);
            this.pb_moonphase.Name = "pb_moonphase";
            this.pb_moonphase.Size = new System.Drawing.Size(100, 96);
            this.pb_moonphase.TabIndex = 7;
            this.pb_moonphase.TabStop = false;
            // 
            // pb_contionalslug
            // 
            this.pb_contionalslug.Location = new System.Drawing.Point(40, 327);
            this.pb_contionalslug.Name = "pb_contionalslug";
            this.pb_contionalslug.Size = new System.Drawing.Size(100, 96);
            this.pb_contionalslug.TabIndex = 9;
            this.pb_contionalslug.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(154, 248);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(60, 31);
            this.lb_data.TabIndex = 10;
            this.lb_data.Text = "N/A";
            // 
            // pb_temp
            // 
            this.pb_temp.Image = ((System.Drawing.Image)(resources.GetObject("pb_temp.Image")));
            this.pb_temp.Location = new System.Drawing.Point(40, 439);
            this.pb_temp.Name = "pb_temp";
            this.pb_temp.Size = new System.Drawing.Size(100, 96);
            this.pb_temp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_temp.TabIndex = 11;
            this.pb_temp.TabStop = false;
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_temp.Location = new System.Drawing.Point(166, 459);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(60, 31);
            this.lb_temp.TabIndex = 13;
            this.lb_temp.Text = "N/A";
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(338, 363);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(136, 31);
            this.lb_description.TabIndex = 15;
            this.lb_description.Text = "Descrição";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 548);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lb_windspeed
            // 
            this.lb_windspeed.AutoSize = true;
            this.lb_windspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_windspeed.Location = new System.Drawing.Point(166, 573);
            this.lb_windspeed.Name = "lb_windspeed";
            this.lb_windspeed.Size = new System.Drawing.Size(60, 31);
            this.lb_windspeed.TabIndex = 17;
            this.lb_windspeed.Text = "N/A";
            // 
            // lb_rain
            // 
            this.lb_rain.AutoSize = true;
            this.lb_rain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rain.Location = new System.Drawing.Point(166, 363);
            this.lb_rain.Name = "lb_rain";
            this.lb_rain.Size = new System.Drawing.Size(60, 31);
            this.lb_rain.TabIndex = 18;
            this.lb_rain.Text = "N/A";
            // 
            // lb_timezone
            // 
            this.lb_timezone.AutoSize = true;
            this.lb_timezone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timezone.Location = new System.Drawing.Point(154, 120);
            this.lb_timezone.Name = "lb_timezone";
            this.lb_timezone.Size = new System.Drawing.Size(60, 31);
            this.lb_timezone.TabIndex = 19;
            this.lb_timezone.Text = "N/A";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(340, 426);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(340, 548);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // lb_sunrise
            // 
            this.lb_sunrise.AutoSize = true;
            this.lb_sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sunrise.Location = new System.Drawing.Point(460, 573);
            this.lb_sunrise.Name = "lb_sunrise";
            this.lb_sunrise.Size = new System.Drawing.Size(60, 31);
            this.lb_sunrise.TabIndex = 23;
            this.lb_sunrise.Text = "N/A";
            // 
            // lb_sunset
            // 
            this.lb_sunset.AutoSize = true;
            this.lb_sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sunset.Location = new System.Drawing.Point(460, 459);
            this.lb_sunset.Name = "lb_sunset";
            this.lb_sunset.Size = new System.Drawing.Size(60, 31);
            this.lb_sunset.TabIndex = 22;
            this.lb_sunset.Text = "N/A";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(340, 213);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // lb_clock
            // 
            this.lb_clock.AutoSize = true;
            this.lb_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clock.Location = new System.Drawing.Point(460, 248);
            this.lb_clock.Name = "lb_clock";
            this.lb_clock.Size = new System.Drawing.Size(60, 31);
            this.lb_clock.TabIndex = 25;
            this.lb_clock.Text = "N/A";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(40, 95);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 96);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // bt_ipgeo
            // 
            this.bt_ipgeo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_ipgeo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ipgeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ipgeo.Location = new System.Drawing.Point(434, 43);
            this.bt_ipgeo.Name = "bt_ipgeo";
            this.bt_ipgeo.Size = new System.Drawing.Size(133, 32);
            this.bt_ipgeo.TabIndex = 27;
            this.bt_ipgeo.Text = "Localização";
            this.bt_ipgeo.UseVisualStyleBackColor = false;
            this.bt_ipgeo.Click += new System.EventHandler(this.bt_ipgeo_Click);
            // 
            // lb_ip1
            // 
            this.lb_ip1.AutoSize = true;
            this.lb_ip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ip1.Location = new System.Drawing.Point(340, 95);
            this.lb_ip1.Name = "lb_ip1";
            this.lb_ip1.Size = new System.Drawing.Size(41, 25);
            this.lb_ip1.TabIndex = 28;
            this.lb_ip1.Text = "IP: ";
            this.lb_ip1.Visible = false;
            // 
            // lb_type1
            // 
            this.lb_type1.AutoSize = true;
            this.lb_type1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type1.Location = new System.Drawing.Point(340, 130);
            this.lb_type1.Name = "lb_type1";
            this.lb_type1.Size = new System.Drawing.Size(68, 25);
            this.lb_type1.TabIndex = 29;
            this.lb_type1.Text = "Type: ";
            this.lb_type1.Visible = false;
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ip.Location = new System.Drawing.Point(461, 95);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(46, 25);
            this.lb_ip.TabIndex = 30;
            this.lb_ip.Text = "N/A";
            this.lb_ip.Visible = false;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.Location = new System.Drawing.Point(461, 130);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(46, 25);
            this.lb_type.TabIndex = 31;
            this.lb_type.Text = "N/A";
            this.lb_type.Visible = false;
            this.lb_type.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_region1
            // 
            this.lb_region1.AutoSize = true;
            this.lb_region1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_region1.Location = new System.Drawing.Point(340, 166);
            this.lb_region1.Name = "lb_region1";
            this.lb_region1.Size = new System.Drawing.Size(84, 25);
            this.lb_region1.TabIndex = 32;
            this.lb_region1.Text = "Estado: ";
            this.lb_region1.Visible = false;
            // 
            // lb_region
            // 
            this.lb_region.AutoSize = true;
            this.lb_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_region.Location = new System.Drawing.Point(461, 166);
            this.lb_region.Name = "lb_region";
            this.lb_region.Size = new System.Drawing.Size(46, 25);
            this.lb_region.TabIndex = 33;
            this.lb_region.Text = "N/A";
            this.lb_region.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(604, 673);
            this.Controls.Add(this.lb_region);
            this.Controls.Add(this.lb_region1);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_ip);
            this.Controls.Add(this.lb_type1);
            this.Controls.Add(this.lb_ip1);
            this.Controls.Add(this.bt_ipgeo);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lb_clock);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lb_sunrise);
            this.Controls.Add(this.lb_sunset);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_timezone);
            this.Controls.Add(this.lb_rain);
            this.Controls.Add(this.lb_windspeed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.lb_temp);
            this.Controls.Add(this.pb_temp);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.pb_contionalslug);
            this.Controls.Add(this.pb_moonphase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.btn_enviar);
            this.Name = "Form1";
            this.Text = "Previsão do Tempo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_moonphase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_contionalslug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_moonphase;
        private System.Windows.Forms.PictureBox pb_contionalslug;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.PictureBox pb_temp;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_windspeed;
        private System.Windows.Forms.Label lb_rain;
        private System.Windows.Forms.Label lb_timezone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_sunrise;
        private System.Windows.Forms.Label lb_sunset;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_clock;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button bt_ipgeo;
        private System.Windows.Forms.Label lb_ip1;
        private System.Windows.Forms.Label lb_type1;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_region1;
        private System.Windows.Forms.Label lb_region;
    }
}

