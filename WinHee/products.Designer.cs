namespace WinHee
{
    partial class products
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_edit_product = new System.Windows.Forms.Button();
            this.btn_delete_product = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(321, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product.Location = new System.Drawing.Point(401, 478);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(139, 37);
            this.btn_add_product.TabIndex = 3;
            this.btn_add_product.Text = "Add Product";
            this.btn_add_product.UseVisualStyleBackColor = true;
            // 
            // btn_edit_product
            // 
            this.btn_edit_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_product.Location = new System.Drawing.Point(575, 478);
            this.btn_edit_product.Name = "btn_edit_product";
            this.btn_edit_product.Size = new System.Drawing.Size(132, 37);
            this.btn_edit_product.TabIndex = 4;
            this.btn_edit_product.Text = "Edit Product";
            this.btn_edit_product.UseVisualStyleBackColor = true;
            // 
            // btn_delete_product
            // 
            this.btn_delete_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_product.Location = new System.Drawing.Point(740, 478);
            this.btn_delete_product.Name = "btn_delete_product";
            this.btn_delete_product.Size = new System.Drawing.Size(140, 37);
            this.btn_delete_product.TabIndex = 5;
            this.btn_delete_product.Text = "Delete Product";
            this.btn_delete_product.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 527);
            this.Controls.Add(this.btn_delete_product);
            this.Controls.Add(this.btn_edit_product);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Button btn_edit_product;
        private System.Windows.Forms.Button btn_delete_product;
    }
}