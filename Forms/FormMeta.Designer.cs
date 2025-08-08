namespace DesafioArbrain.Forms
{
    partial class FormMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeta));
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_periodo = new System.Windows.Forms.ComboBox();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.comboBox_produto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_vendedor = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_tipoValor = new System.Windows.Forms.Label();
            this.numericUpDown_valor = new System.Windows.Forms.NumericUpDown();
            this.rjToggleButton_ativo = new RJCodeAdvance.RJControls.RJToggleButton();
            this.panel_campos = new System.Windows.Forms.Panel();
            this.button_excluir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_valor)).BeginInit();
            this.panel_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_salvar
            // 
            this.button_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(36)))));
            this.button_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.ForeColor = System.Drawing.Color.Black;
            this.button_salvar.Image = ((System.Drawing.Image)(resources.GetObject("button_salvar.Image")));
            this.button_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_salvar.Location = new System.Drawing.Point(392, 273);
            this.button_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(155, 36);
            this.button_salvar.TabIndex = 22;
            this.button_salvar.Text = "Salvar (F2)";
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voltar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.ForeColor = System.Drawing.Color.White;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_voltar.Location = new System.Drawing.Point(227, 273);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(5);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(155, 36);
            this.button_voltar.TabIndex = 21;
            this.button_voltar.Text = "Voltar (Esc)";
            this.button_voltar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.59596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.40404F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_periodo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_tipo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_produto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_vendedor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rjToggleButton_ativo, 1, 5);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 253);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 43);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ativo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_periodo
            // 
            this.comboBox_periodo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_periodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_periodo.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_periodo.FormattingEnabled = true;
            this.comboBox_periodo.Location = new System.Drawing.Point(117, 173);
            this.comboBox_periodo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.comboBox_periodo.Name = "comboBox_periodo";
            this.comboBox_periodo.Size = new System.Drawing.Size(110, 23);
            this.comboBox_periodo.TabIndex = 20;
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_tipo.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Location = new System.Drawing.Point(117, 53);
            this.comboBox_tipo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(47, 23);
            this.comboBox_tipo.TabIndex = 1;
            this.comboBox_tipo.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_tipo_SelectedIndexChanged);
            // 
            // comboBox_produto
            // 
            this.comboBox_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_produto.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_produto.FormattingEnabled = true;
            this.comboBox_produto.Location = new System.Drawing.Point(117, 93);
            this.comboBox_produto.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.comboBox_produto.Name = "comboBox_produto";
            this.comboBox_produto.Size = new System.Drawing.Size(398, 23);
            this.comboBox_produto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(36)))));
            this.label5.Location = new System.Drawing.Point(20, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor/Quant.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(36)))));
            this.label6.Location = new System.Drawing.Point(20, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Periodicidade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_vendedor
            // 
            this.comboBox_vendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_vendedor.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_vendedor.FormattingEnabled = true;
            this.comboBox_vendedor.Location = new System.Drawing.Point(117, 13);
            this.comboBox_vendedor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.comboBox_vendedor.Name = "comboBox_vendedor";
            this.comboBox_vendedor.Size = new System.Drawing.Size(398, 23);
            this.comboBox_vendedor.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.035176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.96482F));
            this.tableLayoutPanel2.Controls.Add(this.label_tipoValor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_valor, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(117, 131);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 27);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label_tipoValor
            // 
            this.label_tipoValor.BackColor = System.Drawing.Color.Transparent;
            this.label_tipoValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tipoValor.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipoValor.ForeColor = System.Drawing.Color.Black;
            this.label_tipoValor.Location = new System.Drawing.Point(0, 0);
            this.label_tipoValor.Margin = new System.Windows.Forms.Padding(0);
            this.label_tipoValor.Name = "label_tipoValor";
            this.label_tipoValor.Size = new System.Drawing.Size(28, 27);
            this.label_tipoValor.TabIndex = 3;
            this.label_tipoValor.Text = "R$";
            this.label_tipoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_valor
            // 
            this.numericUpDown_valor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown_valor.DecimalPlaces = 2;
            this.numericUpDown_valor.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_valor.Location = new System.Drawing.Point(31, 3);
            this.numericUpDown_valor.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown_valor.Name = "numericUpDown_valor";
            this.numericUpDown_valor.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_valor.TabIndex = 3;
            this.numericUpDown_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_valor.ThousandsSeparator = true;
            this.numericUpDown_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericUpDown_valor_KeyPress);
            // 
            // rjToggleButton_ativo
            // 
            this.rjToggleButton_ativo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjToggleButton_ativo.BackColor = System.Drawing.Color.White;
            this.rjToggleButton_ativo.Checked = true;
            this.rjToggleButton_ativo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton_ativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjToggleButton_ativo.Location = new System.Drawing.Point(122, 212);
            this.rjToggleButton_ativo.Margin = new System.Windows.Forms.Padding(5);
            this.rjToggleButton_ativo.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton_ativo.Name = "rjToggleButton_ativo";
            this.rjToggleButton_ativo.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.rjToggleButton_ativo.OffToggleColor = System.Drawing.Color.White;
            this.rjToggleButton_ativo.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(36)))));
            this.rjToggleButton_ativo.OnToggleColor = System.Drawing.Color.White;
            this.rjToggleButton_ativo.Size = new System.Drawing.Size(45, 29);
            this.rjToggleButton_ativo.TabIndex = 22;
            this.rjToggleButton_ativo.UseVisualStyleBackColor = false;
            // 
            // panel_campos
            // 
            this.panel_campos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_campos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel_campos.Controls.Add(this.tableLayoutPanel1);
            this.panel_campos.Location = new System.Drawing.Point(12, 12);
            this.panel_campos.Name = "panel_campos";
            this.panel_campos.Size = new System.Drawing.Size(535, 253);
            this.panel_campos.TabIndex = 6;
            // 
            // button_excluir
            // 
            this.button_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.button_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_excluir.FlatAppearance.BorderSize = 0;
            this.button_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excluir.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.White;
            this.button_excluir.Location = new System.Drawing.Point(12, 273);
            this.button_excluir.Margin = new System.Windows.Forms.Padding(5);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(155, 36);
            this.button_excluir.TabIndex = 7;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.Button_excluir_Click);
            // 
            // FormMeta
            // 
            this.AcceptButton = this.button_salvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button_voltar;
            this.ClientSize = new System.Drawing.Size(559, 323);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.panel_campos);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_salvar);
            this.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMeta";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Meta";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMeta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMeta_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_valor)).EndInit();
            this.panel_campos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_vendedor;
        private System.Windows.Forms.Panel panel_campos;
        private System.Windows.Forms.ComboBox comboBox_produto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_tipoValor;
        private System.Windows.Forms.ComboBox comboBox_periodo;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.NumericUpDown numericUpDown_valor;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJToggleButton rjToggleButton_ativo;
    }
}