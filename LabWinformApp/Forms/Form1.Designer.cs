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
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnGetProductById = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnPatchProduct = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnHead = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.txtTestId = new System.Windows.Forms.TextBox();
            this.btnGetTests = new System.Windows.Forms.Button();
            this.btnGetTestById = new System.Windows.Forms.Button();
            this.btnDeleteTest = new System.Windows.Forms.Button();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.btnUpdateTest = new System.Windows.Forms.Button();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.txtCreateTest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.tabPageProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(6, 35);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(150, 23);
            this.btnGetProducts.TabIndex = 0;
            this.btnGetProducts.Text = "GetProducts";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(6, 151);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 23;
            this.dgvProduct.Size = new System.Drawing.Size(306, 281);
            this.dgvProduct.TabIndex = 1;
            // 
            // btnGetProductById
            // 
            this.btnGetProductById.Location = new System.Drawing.Point(112, 6);
            this.btnGetProductById.Name = "btnGetProductById";
            this.btnGetProductById.Size = new System.Drawing.Size(150, 23);
            this.btnGetProductById.TabIndex = 2;
            this.btnGetProductById.Text = "GetProductById";
            this.btnGetProductById.UseVisualStyleBackColor = true;
            this.btnGetProductById.Click += new System.EventHandler(this.btnGetProductById_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(6, 6);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 21);
            this.txtProductId.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(6, 64);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 23);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "AddProduct";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(6, 93);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(150, 23);
            this.btnUpdateProduct.TabIndex = 5;
            this.btnUpdateProduct.Text = "UpdateProduct";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(6, 122);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(150, 23);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "DeleteProduct";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnPatchProduct
            // 
            this.btnPatchProduct.Location = new System.Drawing.Point(162, 64);
            this.btnPatchProduct.Name = "btnPatchProduct";
            this.btnPatchProduct.Size = new System.Drawing.Size(150, 23);
            this.btnPatchProduct.TabIndex = 7;
            this.btnPatchProduct.Text = "PatchProduct";
            this.btnPatchProduct.UseVisualStyleBackColor = true;
            this.btnPatchProduct.Click += new System.EventHandler(this.btnPatchProduct_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(162, 93);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(150, 23);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnHead
            // 
            this.btnHead.Location = new System.Drawing.Point(162, 122);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(150, 23);
            this.btnHead.TabIndex = 9;
            this.btnHead.Text = "Head";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPageTest);
            this.tab.Controls.Add(this.tabPageProduct);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(326, 470);
            this.tab.TabIndex = 10;
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.txtCreateTest);
            this.tabPageTest.Controls.Add(this.dgvTest);
            this.tabPageTest.Controls.Add(this.txtTestId);
            this.tabPageTest.Controls.Add(this.btnGetTests);
            this.tabPageTest.Controls.Add(this.btnGetTestById);
            this.tabPageTest.Controls.Add(this.btnDeleteTest);
            this.tabPageTest.Controls.Add(this.btnCreateTest);
            this.tabPageTest.Controls.Add(this.btnUpdateTest);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(318, 444);
            this.tabPageTest.TabIndex = 0;
            this.tabPageTest.Text = "Test";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // dgvTest
            // 
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(6, 151);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.RowTemplate.Height = 23;
            this.dgvTest.Size = new System.Drawing.Size(306, 281);
            this.dgvTest.TabIndex = 19;
            // 
            // txtTestId
            // 
            this.txtTestId.Location = new System.Drawing.Point(6, 6);
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.Size = new System.Drawing.Size(100, 21);
            this.txtTestId.TabIndex = 12;
            // 
            // btnGetTests
            // 
            this.btnGetTests.Location = new System.Drawing.Point(6, 35);
            this.btnGetTests.Name = "btnGetTests";
            this.btnGetTests.Size = new System.Drawing.Size(150, 23);
            this.btnGetTests.TabIndex = 10;
            this.btnGetTests.Text = "GetTests";
            this.btnGetTests.UseVisualStyleBackColor = true;
            this.btnGetTests.Click += new System.EventHandler(this.btnGetTests_Click);
            // 
            // btnGetTestById
            // 
            this.btnGetTestById.Location = new System.Drawing.Point(112, 6);
            this.btnGetTestById.Name = "btnGetTestById";
            this.btnGetTestById.Size = new System.Drawing.Size(150, 23);
            this.btnGetTestById.TabIndex = 11;
            this.btnGetTestById.Text = "GetTestById";
            this.btnGetTestById.UseVisualStyleBackColor = true;
            this.btnGetTestById.Click += new System.EventHandler(this.btnGetTestById_Click);
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.Location = new System.Drawing.Point(6, 122);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(150, 23);
            this.btnDeleteTest.TabIndex = 15;
            this.btnDeleteTest.Text = "DeleteTest";
            this.btnDeleteTest.UseVisualStyleBackColor = true;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_Click);
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(112, 64);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(150, 23);
            this.btnCreateTest.TabIndex = 13;
            this.btnCreateTest.Text = "CreateTest";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // btnUpdateTest
            // 
            this.btnUpdateTest.Location = new System.Drawing.Point(6, 93);
            this.btnUpdateTest.Name = "btnUpdateTest";
            this.btnUpdateTest.Size = new System.Drawing.Size(150, 23);
            this.btnUpdateTest.TabIndex = 14;
            this.btnUpdateTest.Text = "UpdateTest";
            this.btnUpdateTest.UseVisualStyleBackColor = true;
            this.btnUpdateTest.Click += new System.EventHandler(this.btnUpdateTest_Click);
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.txtProductId);
            this.tabPageProduct.Controls.Add(this.btnHead);
            this.tabPageProduct.Controls.Add(this.btnGetProducts);
            this.tabPageProduct.Controls.Add(this.btnOptions);
            this.tabPageProduct.Controls.Add(this.dgvProduct);
            this.tabPageProduct.Controls.Add(this.btnPatchProduct);
            this.tabPageProduct.Controls.Add(this.btnGetProductById);
            this.tabPageProduct.Controls.Add(this.btnDeleteProduct);
            this.tabPageProduct.Controls.Add(this.btnAddProduct);
            this.tabPageProduct.Controls.Add(this.btnUpdateProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(318, 444);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // txtCreateTest
            // 
            this.txtCreateTest.Location = new System.Drawing.Point(6, 66);
            this.txtCreateTest.Name = "txtCreateTest";
            this.txtCreateTest.Size = new System.Drawing.Size(100, 21);
            this.txtCreateTest.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPageTest.ResumeLayout(false);
            this.tabPageTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnGetProductById;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnPatchProduct;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TextBox txtTestId;
        private System.Windows.Forms.Button btnGetTests;
        private System.Windows.Forms.Button btnGetTestById;
        private System.Windows.Forms.Button btnDeleteTest;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Button btnUpdateTest;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.TextBox txtCreateTest;
    }
}

