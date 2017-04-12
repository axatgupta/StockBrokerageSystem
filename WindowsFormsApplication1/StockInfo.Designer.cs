namespace WindowsFormsApplication1
{
    partial class StockSell
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
            this.label1 = new System.Windows.Forms.Label();
            this.Current_Shares = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sell = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Shares";
            // 
            // Current_Shares
            // 
            this.Current_Shares.FormattingEnabled = true;
            this.Current_Shares.Location = new System.Drawing.Point(121, 25);
            this.Current_Shares.Name = "Current_Shares";
            this.Current_Shares.Size = new System.Drawing.Size(121, 21);
            this.Current_Shares.TabIndex = 1;
            this.Current_Shares.SelectedIndexChanged += new System.EventHandler(this.Current_Shares_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(121, 61);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(121, 20);
            this.Qty.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(121, 201);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(75, 23);
            this.Sell.TabIndex = 6;
            this.Sell.Text = "Sell";
            this.Sell.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(121, 153);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(121, 20);
            this.price.TabIndex = 8;
            // 
            // StockSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.price);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Current_Shares);
            this.Controls.Add(this.label1);
            this.Name = "StockSell";
            this.Text = "Stock Sell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Current_Shares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox price;
    }
}