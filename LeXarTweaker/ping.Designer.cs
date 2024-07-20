namespace LeXarTweaker
{
    partial class ping
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pictureBoxPingStatus = new PictureBox();
            label1 = new Label();
            ea_ping = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label2 = new Label();
            label3 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            buttonrefresh = new Guna.UI2.WinForms.Guna2Button();
            pingTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPingStatus).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.gen5_horizontal_white_1_;
            pictureBox1.Location = new Point(13, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.IndianRed;
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(pictureBoxPingStatus);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(ea_ping);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(14, 89);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(237, 66);
            guna2Panel1.TabIndex = 1;
            // 
            // pictureBoxPingStatus
            // 
            pictureBoxPingStatus.Image = Properties.Resources.red_image;
            pictureBoxPingStatus.Location = new Point(196, 14);
            pictureBoxPingStatus.Name = "pictureBoxPingStatus";
            pictureBoxPingStatus.Size = new Size(29, 35);
            pictureBoxPingStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPingStatus.TabIndex = 3;
            pictureBoxPingStatus.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 13);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "EA - MDLBEAST";
            // 
            // ea_ping
            // 
            ea_ping.BackColor = Color.Transparent;
            ea_ping.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ea_ping.ForeColor = Color.White;
            ea_ping.Location = new Point(84, 38);
            ea_ping.Name = "ea_ping";
            ea_ping.Size = new Size(101, 17);
            ea_ping.TabIndex = 2;
            ea_ping.Text = "guna2HtmlLabel1";
            ea_ping.Click += ea_ping_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(68, 3);
            label2.Name = "label2";
            label2.Size = new Size(19, 28);
            label2.TabIndex = 15;
            label2.Text = "|";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(68, 28);
            label3.Name = "label3";
            label3.Size = new Size(19, 28);
            label3.TabIndex = 16;
            label3.Text = "|";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // buttonrefresh
            // 
            buttonrefresh.BorderRadius = 9;
            buttonrefresh.CustomizableEdges = customizableEdges3;
            buttonrefresh.DisabledState.BorderColor = Color.DarkGray;
            buttonrefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonrefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonrefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonrefresh.FillColor = Color.IndianRed;
            buttonrefresh.Font = new Font("Segoe UI", 9F);
            buttonrefresh.ForeColor = Color.White;
            buttonrefresh.Location = new Point(14, 495);
            buttonrefresh.Name = "buttonrefresh";
            buttonrefresh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buttonrefresh.Size = new Size(76, 26);
            buttonrefresh.TabIndex = 2;
            buttonrefresh.Text = "Refresh";
            buttonrefresh.Click += buttonrefresh_Click;
            // 
            // ping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 33, 48);
            ClientSize = new Size(956, 550);
            Controls.Add(buttonrefresh);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ping";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ping";
            Load += ping_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPingStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel ea_ping;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button buttonrefresh;
        private System.Windows.Forms.Timer pingTimer;
        private PictureBox pictureBoxPingStatus;
    }
}