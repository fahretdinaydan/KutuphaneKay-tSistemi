namespace KutuphaneKayıtSistemi
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencikayitnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet = new KutuphaneKayıtSistemi.kutuphaneDataSet();
            this.dataSet4 = new KutuphaneKayıtSistemi.DataSet4();
            this.hastalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastalarTableAdapter = new KutuphaneKayıtSistemi.DataSet4TableAdapters.HastalarTableAdapter();
            this.dataSet3 = new KutuphaneKayıtSistemi.DataSet3();
            this.dataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciekleTableAdapter = new KutuphaneKayıtSistemi.kutuphaneDataSetTableAdapters.ogrenciekleTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciekleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 138);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(262, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrencileri Görüntüle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(568, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciadiDataGridViewTextBoxColumn,
            this.ogrencikayitnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciekleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(963, 374);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciadiDataGridViewTextBoxColumn
            // 
            this.ogrenciadiDataGridViewTextBoxColumn.DataPropertyName = "ogrenciadi";
            this.ogrenciadiDataGridViewTextBoxColumn.HeaderText = "ogrenciadi";
            this.ogrenciadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciadiDataGridViewTextBoxColumn.Name = "ogrenciadiDataGridViewTextBoxColumn";
            this.ogrenciadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrencikayitnoDataGridViewTextBoxColumn
            // 
            this.ogrencikayitnoDataGridViewTextBoxColumn.DataPropertyName = "ogrencikayitno";
            this.ogrencikayitnoDataGridViewTextBoxColumn.HeaderText = "ogrencikayitno";
            this.ogrencikayitnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrencikayitnoDataGridViewTextBoxColumn.Name = "ogrencikayitnoDataGridViewTextBoxColumn";
            this.ogrencikayitnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciekleBindingSource
            // 
            this.ogrenciekleBindingSource.DataMember = "ogrenciekle";
            this.ogrenciekleBindingSource.DataSource = this.kutuphaneDataSetBindingSource;
            // 
            // kutuphaneDataSetBindingSource
            // 
            this.kutuphaneDataSetBindingSource.DataSource = this.kutuphaneDataSet;
            this.kutuphaneDataSetBindingSource.Position = 0;
            // 
            // kutuphaneDataSet
            // 
            this.kutuphaneDataSet.DataSetName = "kutuphaneDataSet";
            this.kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastalarBindingSource
            // 
            this.hastalarBindingSource.DataMember = "Hastalar";
            this.hastalarBindingSource.DataSource = this.dataSet4;
            // 
            // hastalarTableAdapter
            // 
            this.hastalarTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet3BindingSource
            // 
            this.dataSet3BindingSource.DataSource = this.dataSet3;
            this.dataSet3BindingSource.Position = 0;
            // 
            // ogrenciekleTableAdapter
            // 
            this.ogrenciekleTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(963, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(987, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciekleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource hastalarBindingSource;
        private DataSet4TableAdapters.HastalarTableAdapter hastalarTableAdapter;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource dataSet3BindingSource;
        private System.Windows.Forms.BindingSource kutuphaneDataSetBindingSource;
        private kutuphaneDataSet kutuphaneDataSet;
        private System.Windows.Forms.BindingSource ogrenciekleBindingSource;
        private kutuphaneDataSetTableAdapters.ogrenciekleTableAdapter ogrenciekleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencikayitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}