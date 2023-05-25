namespace Lab_6_wforms
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
            this.addOrderButton = new System.Windows.Forms.Button();
            this.getProductsButton = new System.Windows.Forms.Button();
            this.buyProductButton = new System.Windows.Forms.Button();
            this.getPaydeskButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.buyClientProductTextBox = new System.Windows.Forms.TextBox();
            this.quantityClientTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyShopProductTextBox = new System.Windows.Forms.TextBox();
            this.quantityShopTextBox = new System.Windows.Forms.TextBox();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(14, 135);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(124, 34);
            this.addOrderButton.TabIndex = 2;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // getProductsButton
            // 
            this.getProductsButton.Location = new System.Drawing.Point(160, 135);
            this.getProductsButton.Name = "getProductsButton";
            this.getProductsButton.Size = new System.Drawing.Size(124, 34);
            this.getProductsButton.TabIndex = 3;
            this.getProductsButton.Text = "Get Products";
            this.getProductsButton.UseVisualStyleBackColor = true;
            this.getProductsButton.Click += new System.EventHandler(this.getProductsButton_Click);
            // 
            // buyProductButton
            // 
            this.buyProductButton.Location = new System.Drawing.Point(14, 387);
            this.buyProductButton.Name = "buyProductButton";
            this.buyProductButton.Size = new System.Drawing.Size(128, 34);
            this.buyProductButton.TabIndex = 4;
            this.buyProductButton.Text = "Buy Product";
            this.buyProductButton.UseVisualStyleBackColor = true;
            this.buyProductButton.Click += new System.EventHandler(this.buyProductButton_Click);
            // 
            // getPaydeskButton
            // 
            this.getPaydeskButton.Location = new System.Drawing.Point(172, 387);
            this.getPaydeskButton.Name = "getPaydeskButton";
            this.getPaydeskButton.Size = new System.Drawing.Size(112, 34);
            this.getPaydeskButton.TabIndex = 5;
            this.getPaydeskButton.Text = "Paydesk";
            this.getPaydeskButton.UseVisualStyleBackColor = true;
            this.getPaydeskButton.Click += new System.EventHandler(this.getPaydeskButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(124, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(150, 31);
            this.titleTextBox.TabIndex = 7;
            // 
            // buyClientProductTextBox
            // 
            this.buyClientProductTextBox.Location = new System.Drawing.Point(124, 49);
            this.buyClientProductTextBox.Name = "buyClientProductTextBox";
            this.buyClientProductTextBox.Size = new System.Drawing.Size(150, 31);
            this.buyClientProductTextBox.TabIndex = 8;
            // 
            // quantityClientTextBox
            // 
            this.quantityClientTextBox.Location = new System.Drawing.Point(124, 86);
            this.quantityClientTextBox.Name = "quantityClientTextBox";
            this.quantityClientTextBox.Size = new System.Drawing.Size(150, 31);
            this.quantityClientTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity";
            // 
            // buyShopProductTextBox
            // 
            this.buyShopProductTextBox.Location = new System.Drawing.Point(134, 297);
            this.buyShopProductTextBox.Name = "buyShopProductTextBox";
            this.buyShopProductTextBox.Size = new System.Drawing.Size(150, 31);
            this.buyShopProductTextBox.TabIndex = 15;
            // 
            // quantityShopTextBox
            // 
            this.quantityShopTextBox.Location = new System.Drawing.Point(134, 341);
            this.quantityShopTextBox.Name = "quantityShopTextBox";
            this.quantityShopTextBox.Size = new System.Drawing.Size(150, 31);
            this.quantityShopTextBox.TabIndex = 16;
            // 
            // MainTextBox
            // 
            this.MainTextBox.Location = new System.Drawing.Point(346, 12);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(419, 409);
            this.MainTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 439);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.quantityShopTextBox);
            this.Controls.Add(this.buyShopProductTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityClientTextBox);
            this.Controls.Add(this.buyClientProductTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.getPaydeskButton);
            this.Controls.Add(this.buyProductButton);
            this.Controls.Add(this.getProductsButton);
            this.Controls.Add(this.addOrderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addOrderButton;
        private Button getProductsButton;
        private Button buyProductButton;
        private Button getPaydeskButton;
        private TextBox titleTextBox;
        private TextBox buyClientProductTextBox;
        private TextBox quantityClientTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox buyShopProductTextBox;
        private TextBox quantityShopTextBox;
        private TextBox MainTextBox;
    }
}