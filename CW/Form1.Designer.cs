namespace CW
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
            lblTitle = new Label();
            txtInput = new TextBox();
            numShift = new NumericUpDown();
            btnEncode = new Button();
            lblOutput = new TextBox();
            LstDetails = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numShift).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(70, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(184, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Enter string and shift value";
            lblTitle.Click += label1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(70, 87);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 1;
            // 
            // numShift
            // 
            numShift.Location = new Point(228, 88);
            numShift.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numShift.Minimum = new decimal(new int[] { 25, 0, 0, int.MinValue });
            numShift.Name = "numShift";
            numShift.Size = new Size(150, 27);
            numShift.TabIndex = 2;
            numShift.ValueChanged += numShift_ValueChanged;
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(427, 90);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(94, 29);
            btnEncode.TabIndex = 3;
            btnEncode.Text = "Encode";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(70, 172);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(125, 27);
            lblOutput.TabIndex = 4;
            // 
            // LstDetails
            // 
            LstDetails.FormattingEnabled = true;
            LstDetails.Location = new Point(77, 257);
            LstDetails.Name = "LstDetails";
            LstDetails.Size = new Size(266, 104);
            LstDetails.TabIndex = 5;
            LstDetails.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstDetails);
            Controls.Add(lblOutput);
            Controls.Add(btnEncode);
            Controls.Add(numShift);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtInput;
        private NumericUpDown numShift;
        private Button btnEncode;
        private TextBox lblOutput;
        private ListBox LstDetails;
    }
}
