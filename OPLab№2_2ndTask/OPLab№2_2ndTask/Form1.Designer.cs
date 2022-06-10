
namespace OPLab_2_2ndTask
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
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.tocombo2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.display_txt = new System.Windows.Forms.Label();
            this.CurrRate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromcombo1
            // 
            this.fromcombo1.AutoCompleteCustomSource.AddRange(new string[] {
            "USD",
            "UAH",
            "EUR",
            "PLN",
            "GBP",
            "CHF",
            "AED"});
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "PLN",
            "GBP",
            "CHF",
            "AED"});
            this.fromcombo1.Location = new System.Drawing.Point(182, 131);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(121, 23);
            this.fromcombo1.TabIndex = 0;
            this.fromcombo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tocombo2
            // 
            this.tocombo2.AutoCompleteCustomSource.AddRange(new string[] {
            "USD",
            "UAH",
            "EUR",
            "PLN",
            "GBP",
            "CHF",
            "AED"});
            this.tocombo2.FormattingEnabled = true;
            this.tocombo2.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "PLN",
            "GBP",
            "CHF",
            "AED"});
            this.tocombo2.Location = new System.Drawing.Point(182, 174);
            this.tocombo2.Name = "tocombo2";
            this.tocombo2.Size = new System.Drawing.Size(121, 23);
            this.tocombo2.TabIndex = 1;
            this.tocombo2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convert From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Convert To:";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(182, 83);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(121, 23);
            this.amount_txt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Amount:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(79, 249);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(112, 15);
            this.display_txt.TabIndex = 6;
            this.display_txt.Text = "Converted Amount:";
            // 
            // CurrRate
            // 
            this.CurrRate.AutoSize = true;
            this.CurrRate.Location = new System.Drawing.Point(431, 83);
            this.CurrRate.Name = "CurrRate";
            this.CurrRate.Size = new System.Drawing.Size(130, 15);
            this.CurrRate.TabIndex = 7;
            this.CurrRate.Text = "Current Exchange Rate:";
            this.CurrRate.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(843, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CurrRate);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tocombo2);
            this.Controls.Add(this.fromcombo1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromcombo1;
        private System.Windows.Forms.ComboBox tocombo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.Label CurrRate;
        private System.Windows.Forms.Button button1;
    }
}

