namespace Psi
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
            this.importApplicants = new System.Windows.Forms.Button();
            this.importTradeMarks = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.advancedDataGridView2 = new ADGV.AdvancedDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modifiedApplicants = new System.Windows.Forms.Label();
            this.modiefiedTradeMarks = new System.Windows.Forms.Label();
            this.euipo_db_OrigDataSet = new Psi.euipo_db_OrigDataSet();
            this.euipodbOrigDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicantsTableAdapter = new Psi.euipo_db_OrigDataSetTableAdapters.ApplicantsTableAdapter();
            this.trademarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trademarksTableAdapter = new Psi.euipo_db_OrigDataSetTableAdapters.TrademarksTableAdapter();
            this.trademarksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.euipo_db_OrigDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.euipodbOrigDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trademarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trademarksBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importApplicants
            // 
            this.importApplicants.Location = new System.Drawing.Point(12, 113);
            this.importApplicants.Name = "importApplicants";
            this.importApplicants.Size = new System.Drawing.Size(210, 49);
            this.importApplicants.TabIndex = 4;
            this.importApplicants.Text = "Import Applicants";
            this.importApplicants.UseVisualStyleBackColor = true;
            this.importApplicants.Click += new System.EventHandler(this.Button1_Click);
            // 
            // importTradeMarks
            // 
            this.importTradeMarks.Location = new System.Drawing.Point(323, 113);
            this.importTradeMarks.Name = "importTradeMarks";
            this.importTradeMarks.Size = new System.Drawing.Size(219, 49);
            this.importTradeMarks.TabIndex = 5;
            this.importTradeMarks.Text = "Import TradeMarks";
            this.importTradeMarks.UseVisualStyleBackColor = true;
            this.importTradeMarks.Click += new System.EventHandler(this.ImportTradeMarks_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(1473, 58);
            this.export.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(316, 159);
            this.export.TabIndex = 6;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.Export_Click);
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.AllowUserToAddRows = false;
            this.advancedDataGridView2.AllowUserToDeleteRows = false;
            this.advancedDataGridView2.AutoGenerateContextFilters = true;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.DateWithTime = false;
            this.advancedDataGridView2.Location = new System.Drawing.Point(135, 296);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            this.advancedDataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView2.RowHeadersWidth = 62;
            this.advancedDataGridView2.RowTemplate.Height = 28;
            this.advancedDataGridView2.Size = new System.Drawing.Size(1571, 553);
            this.advancedDataGridView2.TabIndex = 8;
            this.advancedDataGridView2.TimeFilter = false;
            this.advancedDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdvancedDataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "last modified:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(319, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "last modified:";
            // 
            // modifiedApplicants
            // 
            this.modifiedApplicants.AutoSize = true;
            this.modifiedApplicants.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modifiedApplicants.Location = new System.Drawing.Point(131, 77);
            this.modifiedApplicants.Name = "modifiedApplicants";
            this.modifiedApplicants.Size = new System.Drawing.Size(91, 20);
            this.modifiedApplicants.TabIndex = 12;
            this.modifiedApplicants.Text = "2019-10-01";
            this.modifiedApplicants.Click += new System.EventHandler(this.Label4_Click);
            // 
            // modiefiedTradeMarks
            // 
            this.modiefiedTradeMarks.AutoSize = true;
            this.modiefiedTradeMarks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modiefiedTradeMarks.Location = new System.Drawing.Point(451, 77);
            this.modiefiedTradeMarks.Name = "modiefiedTradeMarks";
            this.modiefiedTradeMarks.Size = new System.Drawing.Size(91, 20);
            this.modiefiedTradeMarks.TabIndex = 13;
            this.modiefiedTradeMarks.Text = "2019-10-01";
            // 
            // euipo_db_OrigDataSet
            // 
            this.euipo_db_OrigDataSet.DataSetName = "euipo_db_OrigDataSet";
            this.euipo_db_OrigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // euipodbOrigDataSetBindingSource
            // 
            this.euipodbOrigDataSetBindingSource.DataSource = this.euipo_db_OrigDataSet;
            this.euipodbOrigDataSetBindingSource.Position = 0;
            // 
            // applicantsBindingSource
            // 
            this.applicantsBindingSource.DataMember = "Applicants";
            this.applicantsBindingSource.DataSource = this.euipodbOrigDataSetBindingSource;
            // 
            // applicantsTableAdapter
            // 
            this.applicantsTableAdapter.ClearBeforeFill = true;
            // 
            // trademarksBindingSource
            // 
            this.trademarksBindingSource.DataMember = "Trademarks";
            this.trademarksBindingSource.DataSource = this.euipodbOrigDataSetBindingSource;
            // 
            // trademarksTableAdapter
            // 
            this.trademarksTableAdapter.ClearBeforeFill = true;
            // 
            // trademarksBindingSource1
            // 
            this.trademarksBindingSource1.DataMember = "Trademarks";
            this.trademarksBindingSource1.DataSource = this.euipodbOrigDataSetBindingSource;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(157, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 24);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All Countries";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(621, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(478, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(217, 24);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "All Countries excluded EU";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(320, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 24);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Only EU";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Countries:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 942);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modiefiedTradeMarks);
            this.Controls.Add(this.modifiedApplicants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.advancedDataGridView2);
            this.Controls.Add(this.export);
            this.Controls.Add(this.importTradeMarks);
            this.Controls.Add(this.importApplicants);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.euipo_db_OrigDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.euipodbOrigDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trademarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trademarksBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Button importApplicants;
        private System.Windows.Forms.Button importTradeMarks;
        private System.Windows.Forms.Button export;
        private ADGV.AdvancedDataGridView advancedDataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label modifiedApplicants;
        private System.Windows.Forms.Label modiefiedTradeMarks;
        private euipo_db_OrigDataSet euipo_db_OrigDataSet;
        private System.Windows.Forms.BindingSource euipodbOrigDataSetBindingSource;
        private System.Windows.Forms.BindingSource applicantsBindingSource;
        private euipo_db_OrigDataSetTableAdapters.ApplicantsTableAdapter applicantsTableAdapter;
        private System.Windows.Forms.BindingSource trademarksBindingSource;
        private euipo_db_OrigDataSetTableAdapters.TrademarksTableAdapter trademarksTableAdapter;
        private System.Windows.Forms.BindingSource trademarksBindingSource1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
    }
}

