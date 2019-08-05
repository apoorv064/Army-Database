namespace WindowsFormsApplication1
{
    partial class Weapon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.weaponnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weapontypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firerateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ammunitionDatabaseDataSet2 = new Army_Database_2._0.ammunitionDatabaseDataSet2();
            this.armsTableAdapter = new Army_Database_2._0.ammunitionDatabaseDataSet2TableAdapters.ArmsTableAdapter();
            this.save_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammunitionDatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weaponnameDataGridViewTextBoxColumn,
            this.weapontypeDataGridViewTextBoxColumn,
            this.batchIDDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.magsizeDataGridViewTextBoxColumn,
            this.ammocDataGridViewTextBoxColumn,
            this.firerateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.armsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // weaponnameDataGridViewTextBoxColumn
            // 
            this.weaponnameDataGridViewTextBoxColumn.DataPropertyName = "Weapon_name";
            this.weaponnameDataGridViewTextBoxColumn.HeaderText = "Weapon_name";
            this.weaponnameDataGridViewTextBoxColumn.Name = "weaponnameDataGridViewTextBoxColumn";
            // 
            // weapontypeDataGridViewTextBoxColumn
            // 
            this.weapontypeDataGridViewTextBoxColumn.DataPropertyName = "Weapon_type";
            this.weapontypeDataGridViewTextBoxColumn.HeaderText = "Weapon_type";
            this.weapontypeDataGridViewTextBoxColumn.Name = "weapontypeDataGridViewTextBoxColumn";
            // 
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "Batch_ID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "Batch_ID";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            // 
            // magsizeDataGridViewTextBoxColumn
            // 
            this.magsizeDataGridViewTextBoxColumn.DataPropertyName = "Mag_size";
            this.magsizeDataGridViewTextBoxColumn.HeaderText = "Mag_size";
            this.magsizeDataGridViewTextBoxColumn.Name = "magsizeDataGridViewTextBoxColumn";
            // 
            // ammocDataGridViewTextBoxColumn
            // 
            this.ammocDataGridViewTextBoxColumn.DataPropertyName = "Ammo_c";
            this.ammocDataGridViewTextBoxColumn.HeaderText = "Ammo_c";
            this.ammocDataGridViewTextBoxColumn.Name = "ammocDataGridViewTextBoxColumn";
            // 
            // firerateDataGridViewTextBoxColumn
            // 
            this.firerateDataGridViewTextBoxColumn.DataPropertyName = "Fire_rate";
            this.firerateDataGridViewTextBoxColumn.HeaderText = "Fire_rate";
            this.firerateDataGridViewTextBoxColumn.Name = "firerateDataGridViewTextBoxColumn";
            // 
            // armsBindingSource
            // 
            this.armsBindingSource.DataMember = "Arms";
            this.armsBindingSource.DataSource = this.ammunitionDatabaseDataSet2;
            // 
            // ammunitionDatabaseDataSet2
            // 
            this.ammunitionDatabaseDataSet2.DataSetName = "ammunitionDatabaseDataSet2";
            this.ammunitionDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // armsTableAdapter
            // 
            this.armsTableAdapter.ClearBeforeFill = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(106, 415);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(306, 415);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(12, 415);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(75, 23);
            this.new_btn.TabIndex = 3;
            this.new_btn.Text = "New";
            this.new_btn.UseVisualStyleBackColor = true;
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(211, 415);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 4;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Weapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Weapon";
            this.Text = "Weapon";
            this.Load += new System.EventHandler(this.Weapon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammunitionDatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Army_Database_2._0.ammunitionDatabaseDataSet2 ammunitionDatabaseDataSet2;
        private System.Windows.Forms.BindingSource armsBindingSource;
        private Army_Database_2._0.ammunitionDatabaseDataSet2TableAdapters.ArmsTableAdapter armsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn weaponnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weapontypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firerateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button button1;
    }
}