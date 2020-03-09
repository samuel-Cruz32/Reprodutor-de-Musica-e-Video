namespace MyMp3Player
{
    partial class frmMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusica));
            this.pnl_Nome = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReproduzir = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.pic_Bart = new System.Windows.Forms.PictureBox();
            this.pnl_Nome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Nome
            // 
            this.pnl_Nome.BackColor = System.Drawing.Color.Teal;
            this.pnl_Nome.Controls.Add(this.button1);
            this.pnl_Nome.Controls.Add(this.btnSair);
            this.pnl_Nome.Controls.Add(this.lbl_Nome);
            this.pnl_Nome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Nome.Location = new System.Drawing.Point(0, 0);
            this.pnl_Nome.Name = "pnl_Nome";
            this.pnl_Nome.Size = new System.Drawing.Size(1050, 40);
            this.pnl_Nome.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::MyMp3Player.Properties.Resources.minimize_118918;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(975, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 2;
            this.button1.Tag = "";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::MyMp3Player.Properties.Resources.ic_cancel_97589;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1014, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(33, 31);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Nome.Location = new System.Drawing.Point(3, 9);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(375, 25);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Reprodutor de Música e Video MP3 C#";
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.Color.Teal;
            this.btnRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetroceder.Enabled = false;
            this.btnRetroceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetroceder.FlatAppearance.BorderSize = 3;
            this.btnRetroceder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnRetroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.ForeColor = System.Drawing.Color.Black;
            this.btnRetroceder.Location = new System.Drawing.Point(27, 378);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(210, 44);
            this.btnRetroceder.TabIndex = 14;
            this.btnRetroceder.Text = "Começar / Recomeçar";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(298, 65);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(710, 339);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::MyMp3Player.Properties.Resources.player_stop_1081;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(782, 420);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 60);
            this.btnStop.TabIndex = 5;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::MyMp3Player.Properties.Resources.video_control_pause_icon_icons_com_48386;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(674, 420);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 60);
            this.btnPause.TabIndex = 6;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnReproduzir
            // 
            this.btnReproduzir.BackgroundImage = global::MyMp3Player.Properties.Resources.play_circle_icon_icons_com_69988;
            this.btnReproduzir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReproduzir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReproduzir.Enabled = false;
            this.btnReproduzir.FlatAppearance.BorderSize = 0;
            this.btnReproduzir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReproduzir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnReproduzir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnReproduzir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReproduzir.Location = new System.Drawing.Point(546, 420);
            this.btnReproduzir.Name = "btnReproduzir";
            this.btnReproduzir.Size = new System.Drawing.Size(80, 60);
            this.btnReproduzir.TabIndex = 7;
            this.btnReproduzir.UseVisualStyleBackColor = true;
            this.btnReproduzir.Click += new System.EventHandler(this.btnReproduzir_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.BackgroundImage = global::MyMp3Player.Properties.Resources.Rock_2_43086;
            this.btnPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasta.FlatAppearance.BorderSize = 0;
            this.btnPasta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPasta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnPasta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasta.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPasta.Location = new System.Drawing.Point(424, 420);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(80, 60);
            this.btnPasta.TabIndex = 9;
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // pic_Bart
            // 
            this.pic_Bart.BackgroundImage = global::MyMp3Player.Properties.Resources.Download_Music_PNG_Picture2;
            this.pic_Bart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Bart.Location = new System.Drawing.Point(12, 46);
            this.pic_Bart.Name = "pic_Bart";
            this.pic_Bart.Size = new System.Drawing.Size(241, 285);
            this.pic_Bart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Bart.TabIndex = 4;
            this.pic_Bart.TabStop = false;
            // 
            // frmMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1050, 496);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnReproduzir);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.pic_Bart);
            this.Controls.Add(this.pnl_Nome);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprodutor de Música";
            this.pnl_Nome.ResumeLayout(false);
            this.pnl_Nome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReproduzir;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.PictureBox pic_Bart;
        private System.Windows.Forms.Panel pnl_Nome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

