namespace frm_Calculator
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            btnEqual = new Button();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            lblDisplayTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.IndianRed;
            btnEqual.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(216, 163);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(122, 34);
            btnEqual.TabIndex = 0;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.BackColor = Color.White;
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(184, 20);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(188, 29);
            txtBoxInput1.TabIndex = 1;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.BackColor = Color.White;
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(184, 88);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(188, 29);
            txtBoxInput2.TabIndex = 2;
            // 
            // cbOperator
            // 
            cbOperator.BackColor = Color.White;
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(234, 55);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(74, 27);
            cbOperator.TabIndex = 3;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.BackColor = Color.SkyBlue;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F);
            lblDisplayTotal.Location = new Point(184, 133);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(17, 21);
            lblDisplayTotal.TabIndex = 4;
            lblDisplayTotal.Text = "?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 5;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 6;
            label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(113, 133);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 7;
            label3.Text = "Answer:";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(394, 225);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDisplayTotal);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(btnEqual);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEqual;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
