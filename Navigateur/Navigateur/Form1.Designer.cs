namespace Navigateur
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
            this.Url_check = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NavigateurWeb = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Fav = new System.Windows.Forms.Button();
            this.Favoris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Url_check
            // 
            this.Url_check.Location = new System.Drawing.Point(198, 21);
            this.Url_check.Name = "Url_check";
            this.Url_check.Size = new System.Drawing.Size(656, 20);
            this.Url_check.TabIndex = 0;
            this.Url_check.TextChanged += new System.EventHandler(this.Url_check_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Go_Click);
            // 
            // NavigateurWeb
            // 
            this.NavigateurWeb.Location = new System.Drawing.Point(89, 128);
            this.NavigateurWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.NavigateurWeb.Name = "NavigateurWeb";
            this.NavigateurWeb.Size = new System.Drawing.Size(956, 439);
            this.NavigateurWeb.TabIndex = 2;
            this.NavigateurWeb.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.NavigateurWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Suivant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(1003, 32);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 5;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(733, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Fav
            // 
            this.Fav.Location = new System.Drawing.Point(590, 51);
            this.Fav.Name = "Fav";
            this.Fav.Size = new System.Drawing.Size(113, 20);
            this.Fav.TabIndex = 7;
            this.Fav.Text = "Add Fav";
            this.Fav.UseVisualStyleBackColor = true;
            this.Fav.Click += new System.EventHandler(this.Fav_Click);
            // 
            // Favoris
            // 
            this.Favoris.Location = new System.Drawing.Point(441, 51);
            this.Favoris.Name = "Favoris";
            this.Favoris.Size = new System.Drawing.Size(113, 20);
            this.Favoris.TabIndex = 8;
            this.Favoris.Text = "Favoris";
            this.Favoris.UseVisualStyleBackColor = true;
            this.Favoris.Click += new System.EventHandler(this.Favoris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 613);
            this.Controls.Add(this.Favoris);
            this.Controls.Add(this.Fav);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NavigateurWeb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Url_check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Url_check;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser NavigateurWeb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Fav;
        private System.Windows.Forms.Button Favoris;
    }
}

