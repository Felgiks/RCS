namespace WindowsFormsApp1
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanelis = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelLOGO = new System.Windows.Forms.Label();
            this.ListBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.WMPMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Poga1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanelis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanelis
            // 
            this.TopPanelis.BackColor = System.Drawing.Color.DarkCyan;
            this.TopPanelis.Controls.Add(this.btnClose);
            this.TopPanelis.Controls.Add(this.labelLOGO);
            this.TopPanelis.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelis.ForeColor = System.Drawing.Color.Red;
            this.TopPanelis.Location = new System.Drawing.Point(0, 0);
            this.TopPanelis.Name = "TopPanelis";
            this.TopPanelis.Size = new System.Drawing.Size(741, 49);
            this.TopPanelis.TabIndex = 0;
            this.TopPanelis.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelis_MouseDown);
            this.TopPanelis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanelis_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(656, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Panic!";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelLOGO
            // 
            this.labelLOGO.AutoSize = true;
            this.labelLOGO.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLOGO.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelLOGO.Location = new System.Drawing.Point(21, 9);
            this.labelLOGO.Name = "labelLOGO";
            this.labelLOGO.Size = new System.Drawing.Size(226, 30);
            this.labelLOGO.TabIndex = 0;
            this.labelLOGO.Text = "Felgik\'s music player";
            this.labelLOGO.Click += new System.EventHandler(this.labelLOGO_Click);
            // 
            // ListBoxSongs
            // 
            this.ListBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxSongs.FormattingEnabled = true;
            this.ListBoxSongs.Location = new System.Drawing.Point(540, 64);
            this.ListBoxSongs.Name = "ListBoxSongs";
            this.ListBoxSongs.Size = new System.Drawing.Size(177, 221);
            this.ListBoxSongs.TabIndex = 0;
            this.ListBoxSongs.SelectedIndexChanged += new System.EventHandler(this.ListBoxSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelectSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSongs.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSelectSongs.Location = new System.Drawing.Point(540, 299);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(177, 79);
            this.btnSelectSongs.TabIndex = 1;
            this.btnSelectSongs.Text = "Select songs";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // WMPMusic
            // 
            this.WMPMusic.Enabled = true;
            this.WMPMusic.Location = new System.Drawing.Point(26, 299);
            this.WMPMusic.Name = "WMPMusic";
            this.WMPMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPMusic.OcxState")));
            this.WMPMusic.Size = new System.Drawing.Size(508, 79);
            this.WMPMusic.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(303, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developed by : Felgiks";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(27, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Poga1
            // 
            this.Poga1.Location = new System.Drawing.Point(27, 234);
            this.Poga1.Name = "Poga1";
            this.Poga1.Size = new System.Drawing.Size(122, 42);
            this.Poga1.TabIndex = 6;
            this.Poga1.Text = "Do you want to \r\n  play a game?";
            this.Poga1.UseVisualStyleBackColor = true;
            this.Poga1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(741, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Poga1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WMPMusic);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.ListBoxSongs);
            this.Controls.Add(this.TopPanelis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanelis.ResumeLayout(false);
            this.TopPanelis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanelis;
        private System.Windows.Forms.ListBox ListBoxSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer WMPMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLOGO;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Poga1;
        private System.Windows.Forms.Label label3;
    }
}

