namespace INF_UE5_Pythagoras
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
            label1 = new Label();
            txtA = new TextBox();
            label2 = new Label();
            txtB = new TextBox();
            btCalc = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 68);
            label1.Name = "label1";
            label1.Size = new Size(45, 32);
            label1.TabIndex = 0;
            label1.Text = "A=";
            // 
            // txtA
            // 
            txtA.Location = new Point(190, 68);
            txtA.Name = "txtA";
            txtA.Size = new Size(200, 39);
            txtA.TabIndex = 1;
            txtA.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 115);
            label2.Name = "label2";
            label2.Size = new Size(44, 32);
            label2.TabIndex = 2;
            label2.Text = "B=";
            // 
            // txtB
            // 
            txtB.Location = new Point(190, 115);
            txtB.Name = "txtB";
            txtB.Size = new Size(200, 39);
            txtB.TabIndex = 3;
            txtB.Text = "4";
            // 
            // btCalc
            // 
            btCalc.Location = new Point(513, 68);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(150, 46);
            btCalc.TabIndex = 4;
            btCalc.Text = "Calc";
            btCalc.UseVisualStyleBackColor = true;
            btCalc.Click += btCalc_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(571, 118);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(25, 32);
            lblResult.TabIndex = 5;
            lblResult.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 727);
            Controls.Add(lblResult);
            Controls.Add(btCalc);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(txtA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private Label label2;
        private TextBox txtB;
        private Button btCalc;
        private Label lblResult;
    }
}
