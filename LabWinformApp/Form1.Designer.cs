namespace LabWinformApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetProductsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GetProductByIdButton = new System.Windows.Forms.Button();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.PatchProductButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.HeadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetProductsButton
            // 
            this.GetProductsButton.Location = new System.Drawing.Point(12, 41);
            this.GetProductsButton.Name = "GetProductsButton";
            this.GetProductsButton.Size = new System.Drawing.Size(150, 23);
            this.GetProductsButton.TabIndex = 0;
            this.GetProductsButton.Text = "GetProductsButton";
            this.GetProductsButton.UseVisualStyleBackColor = true;
            this.GetProductsButton.Click += new System.EventHandler(this.GetProductsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(306, 281);
            this.dataGridView1.TabIndex = 1;
            // 
            // GetProductByIdButton
            // 
            this.GetProductByIdButton.Location = new System.Drawing.Point(118, 12);
            this.GetProductByIdButton.Name = "GetProductByIdButton";
            this.GetProductByIdButton.Size = new System.Drawing.Size(150, 23);
            this.GetProductByIdButton.TabIndex = 2;
            this.GetProductByIdButton.Text = "GetProductByIdButton";
            this.GetProductByIdButton.UseVisualStyleBackColor = true;
            this.GetProductByIdButton.Click += new System.EventHandler(this.GetProductByIdButton_Click);
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(12, 12);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.productIdTextBox.TabIndex = 3;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(12, 70);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(150, 23);
            this.AddProductButton.TabIndex = 4;
            this.AddProductButton.Text = "AddProductButton";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Location = new System.Drawing.Point(12, 99);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(150, 23);
            this.UpdateProductButton.TabIndex = 5;
            this.UpdateProductButton.Text = "UpdateProductButton";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(12, 128);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(150, 23);
            this.DeleteProductButton.TabIndex = 6;
            this.DeleteProductButton.Text = "DeleteProductButton";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // PatchProductButton
            // 
            this.PatchProductButton.Location = new System.Drawing.Point(168, 70);
            this.PatchProductButton.Name = "PatchProductButton";
            this.PatchProductButton.Size = new System.Drawing.Size(150, 23);
            this.PatchProductButton.TabIndex = 7;
            this.PatchProductButton.Text = "PatchProductButton";
            this.PatchProductButton.UseVisualStyleBackColor = true;
            this.PatchProductButton.Click += new System.EventHandler(this.PatchProductButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Location = new System.Drawing.Point(168, 99);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(150, 23);
            this.OptionsButton.TabIndex = 8;
            this.OptionsButton.Text = "OptionsButton";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // HeadButton
            // 
            this.HeadButton.Location = new System.Drawing.Point(168, 128);
            this.HeadButton.Name = "HeadButton";
            this.HeadButton.Size = new System.Drawing.Size(150, 23);
            this.HeadButton.TabIndex = 9;
            this.HeadButton.Text = "HeadButton";
            this.HeadButton.UseVisualStyleBackColor = true;
            this.HeadButton.Click += new System.EventHandler(this.HeadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.HeadButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.PatchProductButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.GetProductByIdButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetProductsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetProductsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetProductByIdButton;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button PatchProductButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button HeadButton;
    }
}

