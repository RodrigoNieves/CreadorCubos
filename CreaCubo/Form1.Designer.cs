namespace CreaCubo
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
            this.karelotitlanUsuarioProblema = new CreaCubo.KarelotitlanUsuarioProblema();
            this.usuarioProblemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioProblemaTableAdapter = new CreaCubo.KarelotitlanUsuarioProblemaTableAdapters.UsuarioProblemaTableAdapter();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonObtenInfo = new System.Windows.Forms.Button();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.checkedListBoxColumna = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxResumen = new System.Windows.Forms.CheckedListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewCubo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.karelotitlanUsuarioProblema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioProblemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCubo)).BeginInit();
            this.SuspendLayout();
            // 
            // karelotitlanUsuarioProblema
            // 
            this.karelotitlanUsuarioProblema.DataSetName = "KarelotitlanUsuarioProblema";
            this.karelotitlanUsuarioProblema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioProblemaBindingSource
            // 
            this.usuarioProblemaBindingSource.DataMember = "UsuarioProblema";
            this.usuarioProblemaBindingSource.DataSource = this.karelotitlanUsuarioProblema;
            // 
            // usuarioProblemaTableAdapter
            // 
            this.usuarioProblemaTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery.Location = new System.Drawing.Point(12, 29);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(931, 106);
            this.textBoxQuery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intsert el Query";
            // 
            // buttonObtenInfo
            // 
            this.buttonObtenInfo.Location = new System.Drawing.Point(16, 141);
            this.buttonObtenInfo.Name = "buttonObtenInfo";
            this.buttonObtenInfo.Size = new System.Drawing.Size(185, 23);
            this.buttonObtenInfo.TabIndex = 2;
            this.buttonObtenInfo.Text = "Ejecutar Query y Obtener Info";
            this.buttonObtenInfo.UseVisualStyleBackColor = true;
            this.buttonObtenInfo.Click += new System.EventHandler(this.buttonObtenInfo_Click);
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Location = new System.Drawing.Point(16, 170);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.Size = new System.Drawing.Size(927, 154);
            this.dataGridViewQuery.TabIndex = 3;
            this.dataGridViewQuery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkedListBoxColumna
            // 
            this.checkedListBoxColumna.CheckOnClick = true;
            this.checkedListBoxColumna.FormattingEnabled = true;
            this.checkedListBoxColumna.Location = new System.Drawing.Point(16, 343);
            this.checkedListBoxColumna.Name = "checkedListBoxColumna";
            this.checkedListBoxColumna.Size = new System.Drawing.Size(201, 154);
            this.checkedListBoxColumna.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columnas para Cubo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Columna de resumen";
            // 
            // checkedListBoxResumen
            // 
            this.checkedListBoxResumen.CheckOnClick = true;
            this.checkedListBoxResumen.FormattingEnabled = true;
            this.checkedListBoxResumen.Location = new System.Drawing.Point(226, 343);
            this.checkedListBoxResumen.Name = "checkedListBoxResumen";
            this.checkedListBoxResumen.Size = new System.Drawing.Size(187, 154);
            this.checkedListBoxResumen.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Contador",
            "Suma",
            "Minimo",
            "Maximo",
            "Promedio"});
            this.comboBox2.Location = new System.Drawing.Point(419, 343);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Resumen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar Cubo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCubo
            // 
            this.dataGridViewCubo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCubo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCubo.Location = new System.Drawing.Point(12, 503);
            this.dataGridViewCubo.Name = "dataGridViewCubo";
            this.dataGridViewCubo.Size = new System.Drawing.Size(931, 206);
            this.dataGridViewCubo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 721);
            this.Controls.Add(this.dataGridViewCubo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkedListBoxResumen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxColumna);
            this.Controls.Add(this.dataGridViewQuery);
            this.Controls.Add(this.buttonObtenInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.karelotitlanUsuarioProblema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioProblemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCubo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KarelotitlanUsuarioProblema karelotitlanUsuarioProblema;
        private System.Windows.Forms.BindingSource usuarioProblemaBindingSource;
        private KarelotitlanUsuarioProblemaTableAdapters.UsuarioProblemaTableAdapter usuarioProblemaTableAdapter;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonObtenInfo;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.CheckedListBox checkedListBoxColumna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxResumen;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewCubo;
    }
}

