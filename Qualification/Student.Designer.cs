
namespace Qualification
{
    partial class Student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qualificationDataSet11 = new Qualification.QualificationDataSet11();
            this.студент1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студент1TableAdapter = new Qualification.QualificationDataSet11TableAdapters.Студент1TableAdapter();
            this.qualificationDataSet12 = new Qualification.QualificationDataSet12();
            this.студент1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.студент1TableAdapter1 = new Qualification.QualificationDataSet12TableAdapters.Студент1TableAdapter();
            this.qualificationDataSet13 = new Qualification.QualificationDataSet13();
            this.студент1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.студент1TableAdapter2 = new Qualification.QualificationDataSet13TableAdapters.Студент1TableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.академическаястипендияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Социальная_стипендия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дополнительная_стипендия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммавсехстипендийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_отлично = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_хорошо = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_удовлитворительно = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_задолженностей = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студент1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студент1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студент1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn1,
            this.Количество_отлично,
            this.Количество_хорошо,
            this.Количество_удовлитворительно,
            this.Количество_задолженностей});
            this.dataGridView1.DataSource = this.студент1BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(24, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.академическаястипендияDataGridViewTextBoxColumn,
            this.Социальная_стипендия,
            this.Дополнительная_стипендия,
            this.суммавсехстипендийDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.студент1BindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(24, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1077, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Успеваемость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стипендия";
            // 
            // qualificationDataSet11
            // 
            this.qualificationDataSet11.DataSetName = "QualificationDataSet11";
            this.qualificationDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студент1BindingSource
            // 
            this.студент1BindingSource.DataMember = "Студент1";
            this.студент1BindingSource.DataSource = this.qualificationDataSet11;
            // 
            // студент1TableAdapter
            // 
            this.студент1TableAdapter.ClearBeforeFill = true;
            // 
            // qualificationDataSet12
            // 
            this.qualificationDataSet12.DataSetName = "QualificationDataSet12";
            this.qualificationDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студент1BindingSource1
            // 
            this.студент1BindingSource1.DataMember = "Студент1";
            this.студент1BindingSource1.DataSource = this.qualificationDataSet12;
            // 
            // студент1TableAdapter1
            // 
            this.студент1TableAdapter1.ClearBeforeFill = true;
            // 
            // qualificationDataSet13
            // 
            this.qualificationDataSet13.DataSetName = "QualificationDataSet13";
            this.qualificationDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студент1BindingSource2
            // 
            this.студент1BindingSource2.DataMember = "Студент1";
            this.студент1BindingSource2.DataSource = this.qualificationDataSet13;
            // 
            // студент1TableAdapter2
            // 
            this.студент1TableAdapter2.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 150;
            // 
            // академическаястипендияDataGridViewTextBoxColumn
            // 
            this.академическаястипендияDataGridViewTextBoxColumn.DataPropertyName = "Академическая_стипендия";
            this.академическаястипендияDataGridViewTextBoxColumn.HeaderText = "Академическая_стипендия";
            this.академическаястипендияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.академическаястипендияDataGridViewTextBoxColumn.Name = "академическаястипендияDataGridViewTextBoxColumn";
            this.академическаястипендияDataGridViewTextBoxColumn.Width = 150;
            // 
            // Социальная_стипендия
            // 
            this.Социальная_стипендия.DataPropertyName = "Социальная_стипендия";
            this.Социальная_стипендия.HeaderText = "Социальная_стипендия";
            this.Социальная_стипендия.MinimumWidth = 8;
            this.Социальная_стипендия.Name = "Социальная_стипендия";
            this.Социальная_стипендия.Width = 150;
            // 
            // Дополнительная_стипендия
            // 
            this.Дополнительная_стипендия.DataPropertyName = "Дополнительная_стипендия";
            this.Дополнительная_стипендия.HeaderText = "Дополнительная_стипендия";
            this.Дополнительная_стипендия.MinimumWidth = 8;
            this.Дополнительная_стипендия.Name = "Дополнительная_стипендия";
            this.Дополнительная_стипендия.Width = 150;
            // 
            // суммавсехстипендийDataGridViewTextBoxColumn
            // 
            this.суммавсехстипендийDataGridViewTextBoxColumn.DataPropertyName = "Сумма_всех_стипендий";
            this.суммавсехстипендийDataGridViewTextBoxColumn.HeaderText = "Сумма_всех_стипендий";
            this.суммавсехстипендийDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.суммавсехстипендийDataGridViewTextBoxColumn.Name = "суммавсехстипендийDataGridViewTextBoxColumn";
            this.суммавсехстипендийDataGridViewTextBoxColumn.Width = 150;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Количество_отлично
            // 
            this.Количество_отлично.DataPropertyName = "Количество_отлично";
            this.Количество_отлично.HeaderText = "Количество_отлично";
            this.Количество_отлично.MinimumWidth = 8;
            this.Количество_отлично.Name = "Количество_отлично";
            this.Количество_отлично.Width = 150;
            // 
            // Количество_хорошо
            // 
            this.Количество_хорошо.DataPropertyName = "Количество_хорошо";
            this.Количество_хорошо.HeaderText = "Количество_хорошо";
            this.Количество_хорошо.MinimumWidth = 8;
            this.Количество_хорошо.Name = "Количество_хорошо";
            this.Количество_хорошо.Width = 150;
            // 
            // Количество_удовлитворительно
            // 
            this.Количество_удовлитворительно.DataPropertyName = "Количество_удовлитворительно";
            this.Количество_удовлитворительно.HeaderText = "Количество_удовлитворительно";
            this.Количество_удовлитворительно.MinimumWidth = 8;
            this.Количество_удовлитворительно.Name = "Количество_удовлитворительно";
            this.Количество_удовлитворительно.Width = 150;
            // 
            // Количество_задолженностей
            // 
            this.Количество_задолженностей.DataPropertyName = "Количество_задолженностей";
            this.Количество_задолженностей.HeaderText = "Количество_задолженностей";
            this.Количество_задолженностей.MinimumWidth = 8;
            this.Количество_задолженностей.Name = "Количество_задолженностей";
            this.Количество_задолженностей.Width = 150;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студент1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студент1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студент1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private QualificationDataSet11 qualificationDataSet11;
        private System.Windows.Forms.BindingSource студент1BindingSource;
        private QualificationDataSet11TableAdapters.Студент1TableAdapter студент1TableAdapter;
        private QualificationDataSet12 qualificationDataSet12;
        private System.Windows.Forms.BindingSource студент1BindingSource1;
        private QualificationDataSet12TableAdapters.Студент1TableAdapter студент1TableAdapter1;
        private QualificationDataSet13 qualificationDataSet13;
        private System.Windows.Forms.BindingSource студент1BindingSource2;
        private QualificationDataSet13TableAdapters.Студент1TableAdapter студент1TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_отлично;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_хорошо;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_удовлитворительно;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_задолженностей;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn академическаястипендияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Социальная_стипендия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дополнительная_стипендия;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммавсехстипендийDataGridViewTextBoxColumn;
    }
}