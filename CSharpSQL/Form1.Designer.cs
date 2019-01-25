namespace CSharpSQL
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
            this.components = new System.ComponentModel.Container();
            this.studEvidencijaDataSet = new CSharpSQL.StudEvidencijaDataSet();
            this.tableAdapterManager = new CSharpSQL.StudEvidencijaDataSetTableAdapters.TableAdapterManager();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.studEvidencijaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studEvidencijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studEvidencijaDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // studEvidencijaDataSet
            // 
            this.studEvidencijaDataSet.DataSetName = "StudEvidencijaDataSet";
            this.studEvidencijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ispitTableAdapter = null;
            this.tableAdapterManager.mjestoTableAdapter = null;
            this.tableAdapterManager.nastavnikTableAdapter = null;
            this.tableAdapterManager.predmetTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSharpSQL.StudEvidencijaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // queryTextBox
            // 
            this.queryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryTextBox.Location = new System.Drawing.Point(16, 29);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(666, 20);
            this.queryTextBox.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(16, 55);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "Execute";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // studEvidencijaDataSetBindingSource
            // 
            this.studEvidencijaDataSetBindingSource.DataSource = this.studEvidencijaDataSet;
            this.studEvidencijaDataSetBindingSource.Position = 0;
            // 
            // errorTextBox
            // 
            this.errorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorTextBox.Location = new System.Drawing.Point(12, 612);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errorTextBox.Size = new System.Drawing.Size(825, 83);
            this.errorTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.queryTextBox);
            this.groupBox1.Controls.Add(this.button);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(796, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter SQL query:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(796, 451);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Errors:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.errorTextBox);
            this.Name = "Form1";
            this.Text = "Execute SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studEvidencijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studEvidencijaDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudEvidencijaDataSet studEvidencijaDataSet;
        private StudEvidencijaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.BindingSource studEvidencijaDataSetBindingSource;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

