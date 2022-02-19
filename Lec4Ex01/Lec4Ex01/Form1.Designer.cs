namespace Lec4Ex01
{
    partial class Form1
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
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.dataView1 = new System.Data.DataView();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnDeleteSave = new System.Windows.Forms.Button();
            this.btnAcceptChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Relations.AddRange(new System.Data.DataRelation[] {
            new System.Data.DataRelation("rlt_Product_Orders", "Products", "Orders", new string[] {
                        "ProductID"}, new string[] {
                        "ProductID"}, false)});
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dataTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ProductID"}, true),
            new System.Data.UniqueConstraint("Unique_Product_QR", new string[] {
                        "ProductQR"}, false)});
            this.dataTable1.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.dataTable1.TableName = "Products";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "ProductID";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "ProductName";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ProductQR";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Price";
            this.dataColumn4.DataType = typeof(decimal);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Markup";
            this.dataColumn5.DataType = typeof(decimal);
            this.dataColumn5.Expression = "Price*0.3";
            this.dataColumn5.ReadOnly = true;
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTable2.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "OrderID"}, true),
            new System.Data.ForeignKeyConstraint("fk_Orders_Products", "Products", new string[] {
                        "ProductID"}, new string[] {
                        "ProductID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
            this.dataTable2.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn6};
            this.dataTable2.TableName = "Orders";
            // 
            // dataColumn6
            // 
            this.dataColumn6.AllowDBNull = false;
            this.dataColumn6.ColumnName = "OrderID";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "ProductID";
            this.dataColumn7.DataType = typeof(int);
            this.dataColumn7.DefaultValue = 9999;
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Qty";
            this.dataColumn8.DataType = typeof(decimal);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productQRDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.markupDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Products";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(58, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 127);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productQRDataGridViewTextBoxColumn
            // 
            this.productQRDataGridViewTextBoxColumn.DataPropertyName = "ProductQR";
            this.productQRDataGridViewTextBoxColumn.HeaderText = "ProductQR";
            this.productQRDataGridViewTextBoxColumn.Name = "productQRDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // markupDataGridViewTextBoxColumn
            // 
            this.markupDataGridViewTextBoxColumn.DataPropertyName = "Markup";
            this.markupDataGridViewTextBoxColumn.HeaderText = "Markup";
            this.markupDataGridViewTextBoxColumn.Name = "markupDataGridViewTextBoxColumn";
            this.markupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.dataSet1;
            this.listBox1.DisplayMember = "Products.ProductName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet1, "Products.ProductName", true));
            this.label1.Location = new System.Drawing.Point(171, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn1,
            this.qtyDataGridViewTextBoxColumn});
            this.dataGridView2.DataMember = "Orders";
            this.dataGridView2.DataSource = this.dataSet1;
            this.dataGridView2.Location = new System.Drawing.Point(284, 158);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(486, 195);
            this.dataGridView2.TabIndex = 3;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Location = new System.Drawing.Point(8, 465);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFirst.TabIndex = 4;
            this.btnMoveFirst.Text = "<<";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Location = new System.Drawing.Point(90, 465);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(75, 23);
            this.btnMovePrevious.TabIndex = 4;
            this.btnMovePrevious.Text = "<";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Location = new System.Drawing.Point(178, 465);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(75, 23);
            this.btnMoveNext.TabIndex = 4;
            this.btnMoveNext.Text = ">";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Location = new System.Drawing.Point(259, 465);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLast.TabIndex = 4;
            this.btnMoveLast.Text = ">>";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(124, 429);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 5;
            // 
            // btnDeleteSave
            // 
            this.btnDeleteSave.Location = new System.Drawing.Point(35, 304);
            this.btnDeleteSave.Name = "btnDeleteSave";
            this.btnDeleteSave.Size = new System.Drawing.Size(130, 49);
            this.btnDeleteSave.TabIndex = 6;
            this.btnDeleteSave.Text = "Delete row and save DiffGram";
            this.btnDeleteSave.UseVisualStyleBackColor = true;
            this.btnDeleteSave.Click += new System.EventHandler(this.btnDeleteSave_Click);
            // 
            // btnAcceptChanges
            // 
            this.btnAcceptChanges.Location = new System.Drawing.Point(35, 382);
            this.btnAcceptChanges.Name = "btnAcceptChanges";
            this.btnAcceptChanges.Size = new System.Drawing.Size(130, 23);
            this.btnAcceptChanges.TabIndex = 7;
            this.btnAcceptChanges.Text = "Accept Changes";
            this.btnAcceptChanges.UseVisualStyleBackColor = true;
            this.btnAcceptChanges.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 663);
            this.Controls.Add(this.btnAcceptChanges);
            this.Controls.Add(this.btnDeleteSave);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePrevious);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Data.DataView dataView1;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnDeleteSave;
        private System.Windows.Forms.Button btnAcceptChanges;
    }
}

