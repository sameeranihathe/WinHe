namespace WinHee
{
    partial class homeScreen
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
            this.productsButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.InvoicesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productsButton
            // 
            this.productsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.Location = new System.Drawing.Point(12, 145);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(107, 33);
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // customersButton
            // 
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.Location = new System.Drawing.Point(125, 145);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(118, 33);
            this.customersButton.TabIndex = 1;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // InvoicesButton
            // 
            this.InvoicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicesButton.Location = new System.Drawing.Point(249, 145);
            this.InvoicesButton.Name = "InvoicesButton";
            this.InvoicesButton.Size = new System.Drawing.Size(100, 33);
            this.InvoicesButton.TabIndex = 2;
            this.InvoicesButton.Text = "Invoices";
            this.InvoicesButton.UseVisualStyleBackColor = true;
            this.InvoicesButton.Click += new System.EventHandler(this.InvoicesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Winhe IT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "All right reserved by Winhe IT 2017";
            // 
            // homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InvoicesButton);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.productsButton);
            this.Name = "homeScreen";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button InvoicesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

