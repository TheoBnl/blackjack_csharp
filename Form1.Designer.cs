namespace BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text_joueur = new System.Windows.Forms.Label();
            this.carte_joueur = new System.Windows.Forms.TextBox();
            this.carte_casino = new System.Windows.Forms.TextBox();
            this.text_casino = new System.Windows.Forms.Label();
            this.init_game = new System.Windows.Forms.Button();
            this.argent_depart = new System.Windows.Forms.TextBox();
            this.afficher_argent = new System.Windows.Forms.Label();
            this.groupe_mise = new System.Windows.Forms.GroupBox();
            this.radio_max = new System.Windows.Forms.RadioButton();
            this.radio_100 = new System.Windows.Forms.RadioButton();
            this.radio_50 = new System.Windows.Forms.RadioButton();
            this.radio_20 = new System.Windows.Forms.RadioButton();
            this.radio_10 = new System.Windows.Forms.RadioButton();
            this.distribue = new System.Windows.Forms.Button();
            this.tirer_carte = new System.Windows.Forms.Button();
            this.reste = new System.Windows.Forms.Button();
            this.total_joueur = new System.Windows.Forms.Label();
            this.total_casino = new System.Windows.Forms.Label();
            this.groupe_mise.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_joueur
            // 
            this.text_joueur.AutoSize = true;
            this.text_joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_joueur.Location = new System.Drawing.Point(167, 289);
            this.text_joueur.Name = "text_joueur";
            this.text_joueur.Size = new System.Drawing.Size(109, 35);
            this.text_joueur.TabIndex = 0;
            this.text_joueur.Text = "Joueur";
            // 
            // carte_joueur
            // 
            this.carte_joueur.Location = new System.Drawing.Point(167, 327);
            this.carte_joueur.Multiline = true;
            this.carte_joueur.Name = "carte_joueur";
            this.carte_joueur.Size = new System.Drawing.Size(109, 145);
            this.carte_joueur.TabIndex = 1;
            this.carte_joueur.TextChanged += new System.EventHandler(this.carte_joueur_TextChanged);
            // 
            // carte_casino
            // 
            this.carte_casino.Location = new System.Drawing.Point(395, 327);
            this.carte_casino.Multiline = true;
            this.carte_casino.Name = "carte_casino";
            this.carte_casino.Size = new System.Drawing.Size(109, 145);
            this.carte_casino.TabIndex = 2;
            this.carte_casino.TextChanged += new System.EventHandler(this.carte_casino_TextChanged);
            // 
            // text_casino
            // 
            this.text_casino.AutoSize = true;
            this.text_casino.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_casino.Location = new System.Drawing.Point(395, 282);
            this.text_casino.Name = "text_casino";
            this.text_casino.Size = new System.Drawing.Size(110, 42);
            this.text_casino.TabIndex = 3;
            this.text_casino.Text = "Casino";
            // 
            // init_game
            // 
            this.init_game.Location = new System.Drawing.Point(62, 62);
            this.init_game.Name = "init_game";
            this.init_game.Size = new System.Drawing.Size(75, 23);
            this.init_game.TabIndex = 4;
            this.init_game.Text = "Init";
            this.init_game.UseVisualStyleBackColor = true;
            this.init_game.Click += new System.EventHandler(this.init_game_Click);
            // 
            // argent_depart
            // 
            this.argent_depart.Location = new System.Drawing.Point(158, 63);
            this.argent_depart.Name = "argent_depart";
            this.argent_depart.Size = new System.Drawing.Size(100, 23);
            this.argent_depart.TabIndex = 5;
            this.argent_depart.TextChanged += new System.EventHandler(this.argent_depart_TextChanged);
            // 
            // afficher_argent
            // 
            this.afficher_argent.AutoSize = true;
            this.afficher_argent.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.afficher_argent.Location = new System.Drawing.Point(624, 35);
            this.afficher_argent.Name = "afficher_argent";
            this.afficher_argent.Size = new System.Drawing.Size(67, 81);
            this.afficher_argent.TabIndex = 6;
            this.afficher_argent.Text = "0";
            // 
            // groupe_mise
            // 
            this.groupe_mise.Controls.Add(this.radio_max);
            this.groupe_mise.Controls.Add(this.radio_100);
            this.groupe_mise.Controls.Add(this.radio_50);
            this.groupe_mise.Controls.Add(this.radio_20);
            this.groupe_mise.Controls.Add(this.radio_10);
            this.groupe_mise.Location = new System.Drawing.Point(202, 152);
            this.groupe_mise.Name = "groupe_mise";
            this.groupe_mise.Size = new System.Drawing.Size(250, 61);
            this.groupe_mise.TabIndex = 7;
            this.groupe_mise.TabStop = false;
            this.groupe_mise.Text = "Mise";
            // 
            // radio_max
            // 
            this.radio_max.AutoSize = true;
            this.radio_max.Location = new System.Drawing.Point(184, 22);
            this.radio_max.Name = "radio_max";
            this.radio_max.Size = new System.Drawing.Size(60, 19);
            this.radio_max.TabIndex = 8;
            this.radio_max.TabStop = true;
            this.radio_max.Text = "ALL IN";
            this.radio_max.UseVisualStyleBackColor = true;
            // 
            // radio_100
            // 
            this.radio_100.AutoSize = true;
            this.radio_100.Location = new System.Drawing.Point(135, 22);
            this.radio_100.Name = "radio_100";
            this.radio_100.Size = new System.Drawing.Size(43, 19);
            this.radio_100.TabIndex = 8;
            this.radio_100.TabStop = true;
            this.radio_100.Text = "100";
            this.radio_100.UseVisualStyleBackColor = true;
            // 
            // radio_50
            // 
            this.radio_50.AutoSize = true;
            this.radio_50.Location = new System.Drawing.Point(92, 22);
            this.radio_50.Name = "radio_50";
            this.radio_50.Size = new System.Drawing.Size(37, 19);
            this.radio_50.TabIndex = 8;
            this.radio_50.TabStop = true;
            this.radio_50.Text = "50";
            this.radio_50.UseVisualStyleBackColor = true;
            // 
            // radio_20
            // 
            this.radio_20.AutoSize = true;
            this.radio_20.Location = new System.Drawing.Point(49, 22);
            this.radio_20.Name = "radio_20";
            this.radio_20.Size = new System.Drawing.Size(37, 19);
            this.radio_20.TabIndex = 8;
            this.radio_20.TabStop = true;
            this.radio_20.Text = "20";
            this.radio_20.UseVisualStyleBackColor = true;
            // 
            // radio_10
            // 
            this.radio_10.AutoSize = true;
            this.radio_10.Location = new System.Drawing.Point(6, 22);
            this.radio_10.Name = "radio_10";
            this.radio_10.Size = new System.Drawing.Size(37, 19);
            this.radio_10.TabIndex = 8;
            this.radio_10.TabStop = true;
            this.radio_10.Text = "10";
            this.radio_10.UseVisualStyleBackColor = true;
            // 
            // distribue
            // 
            this.distribue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distribue.Location = new System.Drawing.Point(174, 219);
            this.distribue.Name = "distribue";
            this.distribue.Size = new System.Drawing.Size(102, 34);
            this.distribue.TabIndex = 8;
            this.distribue.Text = "Distribuer";
            this.distribue.UseVisualStyleBackColor = true;
            this.distribue.Click += new System.EventHandler(this.distribue_Click);
            // 
            // tirer_carte
            // 
            this.tirer_carte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tirer_carte.Location = new System.Drawing.Point(282, 219);
            this.tirer_carte.Name = "tirer_carte";
            this.tirer_carte.Size = new System.Drawing.Size(88, 34);
            this.tirer_carte.TabIndex = 9;
            this.tirer_carte.Text = "Carte";
            this.tirer_carte.UseVisualStyleBackColor = true;
            this.tirer_carte.Click += new System.EventHandler(this.tirer_carte_Click);
            // 
            // reste
            // 
            this.reste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reste.Location = new System.Drawing.Point(379, 219);
            this.reste.Name = "reste";
            this.reste.Size = new System.Drawing.Size(88, 34);
            this.reste.TabIndex = 10;
            this.reste.Text = "Reste";
            this.reste.UseVisualStyleBackColor = true;
            this.reste.Click += new System.EventHandler(this.reste_Click);
            // 
            // total_joueur
            // 
            this.total_joueur.AutoSize = true;
            this.total_joueur.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_joueur.Location = new System.Drawing.Point(88, 430);
            this.total_joueur.Name = "total_joueur";
            this.total_joueur.Size = new System.Drawing.Size(35, 42);
            this.total_joueur.TabIndex = 11;
            this.total_joueur.Text = "0";
            // 
            // total_casino
            // 
            this.total_casino.AutoSize = true;
            this.total_casino.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_casino.Location = new System.Drawing.Point(524, 430);
            this.total_casino.Name = "total_casino";
            this.total_casino.Size = new System.Drawing.Size(35, 42);
            this.total_casino.TabIndex = 12;
            this.total_casino.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(841, 517);
            this.Controls.Add(this.total_casino);
            this.Controls.Add(this.total_joueur);
            this.Controls.Add(this.reste);
            this.Controls.Add(this.tirer_carte);
            this.Controls.Add(this.distribue);
            this.Controls.Add(this.groupe_mise);
            this.Controls.Add(this.afficher_argent);
            this.Controls.Add(this.argent_depart);
            this.Controls.Add(this.init_game);
            this.Controls.Add(this.text_casino);
            this.Controls.Add(this.carte_casino);
            this.Controls.Add(this.carte_joueur);
            this.Controls.Add(this.text_joueur);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupe_mise.ResumeLayout(false);
            this.groupe_mise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label text_joueur;
        private TextBox carte_joueur;
        private TextBox carte_casino;
        private Label text_casino;
        private Button init_game;
        private TextBox argent_depart;
        private Label afficher_argent;
        private GroupBox groupe_mise;
        private RadioButton radio_max;
        private RadioButton radio_100;
        private RadioButton radio_50;
        private RadioButton radio_20;
        private RadioButton radio_10;
        private Button distribue;
        private Button tirer_carte;
        private Button reste;
        private Label total_joueur;
        private Label total_casino;
    }
}