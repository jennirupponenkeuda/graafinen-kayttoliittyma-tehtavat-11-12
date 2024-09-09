namespace graafinentehtava11
{
    partial class NopanheittoF
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
            NopanHeittoLB = new Label();
            Noppa01PB = new PictureBox();
            Noppa02PB = new PictureBox();
            HeitaBT = new Button();
            ((System.ComponentModel.ISupportInitialize)Noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // NopanHeittoLB
            // 
            NopanHeittoLB.AutoSize = true;
            NopanHeittoLB.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NopanHeittoLB.Location = new Point(94, 32);
            NopanHeittoLB.Name = "NopanHeittoLB";
            NopanHeittoLB.Size = new Size(110, 21);
            NopanHeittoLB.TabIndex = 0;
            NopanHeittoLB.Text = "Nopan heitto";
            // 
            // Noppa01PB
            // 
            Noppa01PB.Image = Properties.Resources.dice01;
            Noppa01PB.Location = new Point(25, 79);
            Noppa01PB.Name = "Noppa01PB";
            Noppa01PB.Size = new Size(100, 100);
            Noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            Noppa01PB.TabIndex = 1;
            Noppa01PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            Noppa02PB.Image = Properties.Resources.dice01;
            Noppa02PB.Location = new Point(166, 79);
            Noppa02PB.Name = "Noppa02PB";
            Noppa02PB.Size = new Size(100, 100);
            Noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            Noppa02PB.TabIndex = 2;
            Noppa02PB.TabStop = false;
            // 
            // HeitaBT
            // 
            HeitaBT.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeitaBT.Location = new Point(94, 206);
            HeitaBT.Name = "HeitaBT";
            HeitaBT.Size = new Size(91, 33);
            HeitaBT.TabIndex = 3;
            HeitaBT.Text = "Heitä";
            HeitaBT.UseVisualStyleBackColor = true;
            HeitaBT.Click += HeitaBT_Click;
            // 
            // NopanheittoF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 269);
            Controls.Add(HeitaBT);
            Controls.Add(Noppa02PB);
            Controls.Add(Noppa01PB);
            Controls.Add(NopanHeittoLB);
            Name = "NopanheittoF";
            Text = "Nopan heitto";
            ((System.ComponentModel.ISupportInitialize)Noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)Noppa02PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NopanHeittoLB;
        private PictureBox Noppa01PB;
        private PictureBox Noppa02PB;
        private Button HeitaBT;
    }
}
