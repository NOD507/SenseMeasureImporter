namespace SenseMeasureImporter
{
    partial class SenseImporter
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreateMeasures = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.cmbSheets = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.useMeasureDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validationMessageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCheckUncheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFile.Location = new System.Drawing.Point(12, 298);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 37);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(109, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 88);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a csv or xls file with the following columns: title, description, tags, de" +
    "finition. The tags column is a semicolon \";\" separated list of tags.";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(404, 298);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(864, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select a sense app to add measures";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useMeasureDataGridViewCheckBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.tagsDataGridViewTextBoxColumn,
            this.definitionDataGridViewTextBoxColumn,
            this.validationMessageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aplicacionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(404, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 239);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // btnCreateMeasures
            // 
            this.btnCreateMeasures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateMeasures.Location = new System.Drawing.Point(404, 333);
            this.btnCreateMeasures.Name = "btnCreateMeasures";
            this.btnCreateMeasures.Size = new System.Drawing.Size(134, 37);
            this.btnCreateMeasures.TabIndex = 7;
            this.btnCreateMeasures.Text = "Create Measures";
            this.btnCreateMeasures.UseVisualStyleBackColor = true;
            this.btnCreateMeasures.Click += new System.EventHandler(this.createMeasures_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(594, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(26, 17);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "file";
            this.lblFile.Visible = false;
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(617, 324);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(48, 17);
            this.Status.TabIndex = 9;
            this.Status.Text = "Status";
            this.Status.Visible = false;
            // 
            // cmbSheets
            // 
            this.cmbSheets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSheets.FormattingEnabled = true;
            this.cmbSheets.Location = new System.Drawing.Point(12, 349);
            this.cmbSheets.Name = "cmbSheets";
            this.cmbSheets.Size = new System.Drawing.Size(91, 24);
            this.cmbSheets.TabIndex = 10;
            this.cmbSheets.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(1138, 333);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 37);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect to Sense";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Visible = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // useMeasureDataGridViewCheckBoxColumn
            // 
            this.useMeasureDataGridViewCheckBoxColumn.DataPropertyName = "useMeasure";
            this.useMeasureDataGridViewCheckBoxColumn.HeaderText = "useMeasure";
            this.useMeasureDataGridViewCheckBoxColumn.Name = "useMeasureDataGridViewCheckBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tagsDataGridViewTextBoxColumn
            // 
            this.tagsDataGridViewTextBoxColumn.DataPropertyName = "tags";
            this.tagsDataGridViewTextBoxColumn.HeaderText = "tags";
            this.tagsDataGridViewTextBoxColumn.Name = "tagsDataGridViewTextBoxColumn";
            // 
            // definitionDataGridViewTextBoxColumn
            // 
            this.definitionDataGridViewTextBoxColumn.DataPropertyName = "definition";
            this.definitionDataGridViewTextBoxColumn.HeaderText = "definition";
            this.definitionDataGridViewTextBoxColumn.Name = "definitionDataGridViewTextBoxColumn";
            // 
            // validationMessageDataGridViewTextBoxColumn
            // 
            this.validationMessageDataGridViewTextBoxColumn.DataPropertyName = "validationMessage";
            this.validationMessageDataGridViewTextBoxColumn.HeaderText = "validationMessage";
            this.validationMessageDataGridViewTextBoxColumn.Name = "validationMessageDataGridViewTextBoxColumn";
            // 
            // aplicacionBindingSource
            // 
            this.aplicacionBindingSource.DataSource = typeof(SenseMeasureImporter.measure);
            // 
            // btnCheckUncheck
            // 
            this.btnCheckUncheck.Location = new System.Drawing.Point(454, 24);
            this.btnCheckUncheck.Name = "btnCheckUncheck";
            this.btnCheckUncheck.Size = new System.Drawing.Size(117, 23);
            this.btnCheckUncheck.TabIndex = 12;
            this.btnCheckUncheck.Text = "Uncheck All";
            this.btnCheckUncheck.UseVisualStyleBackColor = true;
            this.btnCheckUncheck.Click += new System.EventHandler(this.btnCheckUncheck_Click);
            // 
            // SenseImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 382);
            this.Controls.Add(this.btnCheckUncheck);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbSheets);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnCreateMeasures);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SenseImporter";
            this.Text = "Sense Measure Importer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource aplicacionBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreateMeasures;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox cmbSheets;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useMeasureDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationMessageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCheckUncheck;
    }
}

