namespace graafinentehtava12
{
    partial class VastausLomakeForm
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
            KysymysLB = new Label();
            VastausGB = new GroupBox();
            VastausDRB = new RadioButton();
            VastausCRB = new RadioButton();
            VastausBRB = new RadioButton();
            VastausARB = new RadioButton();
            DummyRB = new RadioButton();
            VastausLB = new Label();
            VastausGB.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Location = new Point(28, 22);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(176, 21);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaus 1. kysymykseen";
            KysymysLB.UseWaitCursor = true;
            // 
            // VastausGB
            // 
            VastausGB.Controls.Add(VastausDRB);
            VastausGB.Controls.Add(VastausCRB);
            VastausGB.Controls.Add(VastausBRB);
            VastausGB.Controls.Add(VastausARB);
            VastausGB.Controls.Add(DummyRB);
            VastausGB.Location = new Point(240, 22);
            VastausGB.Name = "VastausGB";
            VastausGB.Size = new Size(198, 222);
            VastausGB.TabIndex = 1;
            VastausGB.TabStop = false;
            VastausGB.Text = "Vastaus:";
            VastausGB.UseWaitCursor = true;
            // 
            // VastausDRB
            // 
            VastausDRB.AutoSize = true;
            VastausDRB.Location = new Point(4, 129);
            VastausDRB.Name = "VastausDRB";
            VastausDRB.Size = new Size(39, 25);
            VastausDRB.TabIndex = 4;
            VastausDRB.TabStop = true;
            VastausDRB.Text = "D";
            VastausDRB.UseVisualStyleBackColor = true;
            VastausDRB.UseWaitCursor = true;
            // 
            // VastausCRB
            // 
            VastausCRB.AutoSize = true;
            VastausCRB.Location = new Point(4, 98);
            VastausCRB.Name = "VastausCRB";
            VastausCRB.Size = new Size(38, 25);
            VastausCRB.TabIndex = 3;
            VastausCRB.TabStop = true;
            VastausCRB.Text = "C";
            VastausCRB.UseVisualStyleBackColor = true;
            VastausCRB.UseWaitCursor = true;
            // 
            // VastausBRB
            // 
            VastausBRB.AutoSize = true;
            VastausBRB.Location = new Point(4, 67);
            VastausBRB.Name = "VastausBRB";
            VastausBRB.Size = new Size(37, 25);
            VastausBRB.TabIndex = 2;
            VastausBRB.TabStop = true;
            VastausBRB.Text = "B";
            VastausBRB.UseVisualStyleBackColor = true;
            VastausBRB.UseWaitCursor = true;
            // 
            // VastausARB
            // 
            VastausARB.AutoSize = true;
            VastausARB.Location = new Point(4, 36);
            VastausARB.Name = "VastausARB";
            VastausARB.Size = new Size(38, 25);
            VastausARB.TabIndex = 1;
            VastausARB.TabStop = true;
            VastausARB.Text = "A";
            VastausARB.UseVisualStyleBackColor = true;
            VastausARB.UseWaitCursor = true;
            // 
            // DummyRB
            // 
            DummyRB.AutoCheck = false;
            DummyRB.AutoSize = true;
            DummyRB.Location = new Point(6, 36);
            DummyRB.Name = "DummyRB";
            DummyRB.Size = new Size(36, 25);
            DummyRB.TabIndex = 0;
            DummyRB.TabStop = true;
            DummyRB.Text = "E";
            DummyRB.UseVisualStyleBackColor = true;
            DummyRB.UseWaitCursor = true;
            DummyRB.Visible = false;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(28, 223);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(63, 21);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.UseWaitCursor = true;
            VastausLB.Visible = false;
            // 
            // VastausLomakeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 288);
            Controls.Add(VastausLB);
            Controls.Add(VastausGB);
            Controls.Add(KysymysLB);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "VastausLomakeForm";
            RightToLeftLayout = true;
            Text = "Vastauslomake";
            UseWaitCursor = true;
            Load += VastausLomakeForm_Load;
            VastausGB.ResumeLayout(false);
            VastausGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private GroupBox VastausGB;
        private RadioButton DummyRB;
        private RadioButton VastausDRB;
        private RadioButton VastausCRB;
        private RadioButton VastausBRB;
        private RadioButton VastausARB;
        private Label VastausLB;
    }
}
