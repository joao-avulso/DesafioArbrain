namespace DesafioArbrain.Forms
{
    partial class CadastroMetas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMetas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_filtro = new System.Windows.Forms.TextBox();
            this.label_filtro = new System.Windows.Forms.Label();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label_countReg = new System.Windows.Forms.Label();
            this.button_limparFiltro = new System.Windows.Forms.Button();
            this.button_duplicar = new System.Windows.Forms.Button();
            this.button_desfazer = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_desfazer = new System.Windows.Forms.Label();
            this.chkInativos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_filtro
            // 
            this.textBox_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filtro.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_filtro.ForeColor = System.Drawing.Color.Gray;
            this.textBox_filtro.Location = new System.Drawing.Point(49, 10);
            this.textBox_filtro.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_filtro.Name = "textBox_filtro";
            this.textBox_filtro.Size = new System.Drawing.Size(231, 22);
            this.textBox_filtro.TabIndex = 5;
            this.textBox_filtro.Text = "Tipo, Vendedor, Produto, Periodo.";
            this.textBox_filtro.TextChanged += new System.EventHandler(this.TextBox_filtro_TextChanged);
            this.textBox_filtro.Enter += new System.EventHandler(this.TextBox_filtro_Enter);
            this.textBox_filtro.Leave += new System.EventHandler(this.TextBox_filtro_Leave);
            // 
            // label_filtro
            // 
            this.label_filtro.AutoSize = true;
            this.label_filtro.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filtro.ForeColor = System.Drawing.Color.White;
            this.label_filtro.Location = new System.Drawing.Point(3, 13);
            this.label_filtro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_filtro.Name = "label_filtro";
            this.label_filtro.Size = new System.Drawing.Size(44, 15);
            this.label_filtro.TabIndex = 2;
            this.label_filtro.Text = "Filtro";
            // 
            // button_adicionar
            // 
            this.button_adicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.button_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_adicionar.FlatAppearance.BorderSize = 2;
            this.button_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adicionar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicionar.ForeColor = System.Drawing.Color.White;
            this.button_adicionar.Image = ((System.Drawing.Image)(resources.GetObject("button_adicionar.Image")));
            this.button_adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_adicionar.Location = new System.Drawing.Point(1024, 10);
            this.button_adicionar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(155, 36);
            this.button_adicionar.TabIndex = 0;
            this.button_adicionar.Text = "Novo (F2)";
            this.button_adicionar.UseVisualStyleBackColor = false;
            this.button_adicionar.Click += new System.EventHandler(this.Button_adicionar_Click);
            // 
            // button_editar
            // 
            this.button_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_editar.BackColor = System.Drawing.Color.Transparent;
            this.button_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editar.Enabled = false;
            this.button_editar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_editar.FlatAppearance.BorderSize = 2;
            this.button_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.ForeColor = System.Drawing.Color.White;
            this.button_editar.Image = ((System.Drawing.Image)(resources.GetObject("button_editar.Image")));
            this.button_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_editar.Location = new System.Drawing.Point(859, 10);
            this.button_editar.Margin = new System.Windows.Forms.Padding(5);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(155, 36);
            this.button_editar.TabIndex = 1;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.Click += new System.EventHandler(this.Button_editar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(5, 85);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1174, 546);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView_RowsRemoved);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // label_countReg
            // 
            this.label_countReg.AutoSize = true;
            this.label_countReg.BackColor = System.Drawing.Color.Transparent;
            this.label_countReg.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_countReg.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label_countReg.Location = new System.Drawing.Point(3, 67);
            this.label_countReg.Name = "label_countReg";
            this.label_countReg.Size = new System.Drawing.Size(120, 15);
            this.label_countReg.TabIndex = 6;
            this.label_countReg.Text = "0 de 0 registros.";
            // 
            // button_limparFiltro
            // 
            this.button_limparFiltro.BackColor = System.Drawing.Color.Transparent;
            this.button_limparFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_limparFiltro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_limparFiltro.FlatAppearance.BorderSize = 2;
            this.button_limparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_limparFiltro.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limparFiltro.ForeColor = System.Drawing.Color.White;
            this.button_limparFiltro.Location = new System.Drawing.Point(289, 10);
            this.button_limparFiltro.Margin = new System.Windows.Forms.Padding(5);
            this.button_limparFiltro.Name = "button_limparFiltro";
            this.button_limparFiltro.Size = new System.Drawing.Size(155, 22);
            this.button_limparFiltro.TabIndex = 4;
            this.button_limparFiltro.Text = "Limpar Filtro";
            this.button_limparFiltro.UseCompatibleTextRendering = true;
            this.button_limparFiltro.UseVisualStyleBackColor = false;
            this.button_limparFiltro.Click += new System.EventHandler(this.Button_limpar_filtro_Click);
            // 
            // button_duplicar
            // 
            this.button_duplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_duplicar.BackColor = System.Drawing.Color.Transparent;
            this.button_duplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_duplicar.Enabled = false;
            this.button_duplicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_duplicar.FlatAppearance.BorderSize = 2;
            this.button_duplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_duplicar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_duplicar.ForeColor = System.Drawing.Color.White;
            this.button_duplicar.Image = ((System.Drawing.Image)(resources.GetObject("button_duplicar.Image")));
            this.button_duplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_duplicar.Location = new System.Drawing.Point(694, 10);
            this.button_duplicar.Margin = new System.Windows.Forms.Padding(5);
            this.button_duplicar.Name = "button_duplicar";
            this.button_duplicar.Size = new System.Drawing.Size(155, 36);
            this.button_duplicar.TabIndex = 2;
            this.button_duplicar.Text = "Duplicar";
            this.button_duplicar.UseVisualStyleBackColor = false;
            this.button_duplicar.Click += new System.EventHandler(this.Button_duplicar_Click);
            // 
            // button_desfazer
            // 
            this.button_desfazer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_desfazer.BackColor = System.Drawing.Color.Transparent;
            this.button_desfazer.Enabled = false;
            this.button_desfazer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_desfazer.FlatAppearance.BorderSize = 0;
            this.button_desfazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_desfazer.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_desfazer.ForeColor = System.Drawing.Color.White;
            this.button_desfazer.Image = ((System.Drawing.Image)(resources.GetObject("button_desfazer.Image")));
            this.button_desfazer.Location = new System.Drawing.Point(651, 10);
            this.button_desfazer.Margin = new System.Windows.Forms.Padding(0);
            this.button_desfazer.Name = "button_desfazer";
            this.button_desfazer.Size = new System.Drawing.Size(38, 36);
            this.button_desfazer.TabIndex = 3;
            this.button_desfazer.UseVisualStyleBackColor = false;
            this.button_desfazer.Click += new System.EventHandler(this.Button_desfazer_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_voltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_voltar.FlatAppearance.BorderSize = 2;
            this.button_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voltar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.ForeColor = System.Drawing.Color.White;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_voltar.Location = new System.Drawing.Point(1024, 636);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(5);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(155, 36);
            this.button_voltar.TabIndex = 6;
            this.button_voltar.Text = "Voltar (Esc)";
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.Button_voltar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(1021, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filtrar Inativos";
            // 
            // label_desfazer
            // 
            this.label_desfazer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_desfazer.BackColor = System.Drawing.Color.Transparent;
            this.label_desfazer.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_desfazer.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desfazer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.label_desfazer.Location = new System.Drawing.Point(485, 19);
            this.label_desfazer.Margin = new System.Windows.Forms.Padding(2);
            this.label_desfazer.Name = "label_desfazer";
            this.label_desfazer.Size = new System.Drawing.Size(164, 18);
            this.label_desfazer.TabIndex = 25;
            this.label_desfazer.Text = "Desfazer: Adicionar Meta";
            this.label_desfazer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_desfazer.Visible = false;
            // 
            // chkInativos
            // 
            this.chkInativos.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInativos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkInativos.Checked = true;
            this.chkInativos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInativos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkInativos.FlatAppearance.BorderSize = 0;
            this.chkInativos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkInativos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkInativos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkInativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInativos.ForeColor = System.Drawing.Color.Transparent;
            this.chkInativos.Image = global::DesafioArbrain.Properties.Resources.Switch_True;
            this.chkInativos.Location = new System.Drawing.Point(1133, 46);
            this.chkInativos.Name = "chkInativos";
            this.chkInativos.Size = new System.Drawing.Size(46, 37);
            this.chkInativos.TabIndex = 26;
            this.chkInativos.UseVisualStyleBackColor = false;
            this.chkInativos.CheckedChanged += new System.EventHandler(this.chkInativos_CheckedChanged);
            this.chkInativos.Click += new System.EventHandler(this.chkInativos_Click);
            // 
            // CadastroMetas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.CancelButton = this.button_voltar;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.chkInativos);
            this.Controls.Add(this.label_desfazer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_desfazer);
            this.Controls.Add(this.button_duplicar);
            this.Controls.Add(this.button_limparFiltro);
            this.Controls.Add(this.label_countReg);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.label_filtro);
            this.Controls.Add(this.textBox_filtro);
            this.Controls.Add(this.dataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "CadastroMetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Metas";
            this.Load += new System.EventHandler(this.CadastroMetas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastroMetas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_filtro;
        private System.Windows.Forms.Label label_filtro;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_countReg;
        private System.Windows.Forms.Button button_limparFiltro;
        private System.Windows.Forms.Button button_duplicar;
        private System.Windows.Forms.Button button_desfazer;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_desfazer;
        private System.Windows.Forms.CheckBox chkInativos;
    }
}

