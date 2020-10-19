namespace Projeto_Barbearia
{
    partial class Cad_Prod_Serv
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
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbQuant = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.gridProd_Serv = new System.Windows.Forms.DataGridView();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbeariashopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barbearia_shopDataSet = new Projeto_Barbearia.Barbearia_shopDataSet();
            this.produtosTableAdapter = new Projeto_Barbearia.Barbearia_shopDataSetTableAdapters.ProdutosTableAdapter();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbChange = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProd_Serv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbeariashopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbearia_shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbDesc.Location = new System.Drawing.Point(7, 315);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(105, 25);
            this.lbDesc.TabIndex = 1;
            this.lbDesc.Text = "Descrição:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbValor.Location = new System.Drawing.Point(12, 370);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(64, 25);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Valor:";
            // 
            // lbQuant
            // 
            this.lbQuant.AutoSize = true;
            this.lbQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbQuant.Location = new System.Drawing.Point(264, 370);
            this.lbQuant.Name = "lbQuant";
            this.lbQuant.Size = new System.Drawing.Size(120, 25);
            this.lbQuant.TabIndex = 3;
            this.lbQuant.Text = "Quantidade:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(130, 320);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(621, 20);
            this.txtDesc.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Location = new System.Drawing.Point(12, 253);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(89, 29);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Location = new System.Drawing.Point(127, 253);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 29);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Location = new System.Drawing.Point(244, 253);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(89, 29);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Location = new System.Drawing.Point(361, 253);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 29);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(478, 253);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 29);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(404, 375);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(73, 20);
            this.txtQuant.TabIndex = 7;
            // 
            // gridProd_Serv
            // 
            this.gridProd_Serv.AllowUserToAddRows = false;
            this.gridProd_Serv.AllowUserToDeleteRows = false;
            this.gridProd_Serv.AllowUserToResizeColumns = false;
            this.gridProd_Serv.AllowUserToResizeRows = false;
            this.gridProd_Serv.AutoGenerateColumns = false;
            this.gridProd_Serv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProd_Serv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridProd_Serv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProd_Serv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.gridProd_Serv.DataSource = this.produtosBindingSource;
            this.gridProd_Serv.Location = new System.Drawing.Point(17, 12);
            this.gridProd_Serv.Name = "gridProd_Serv";
            this.gridProd_Serv.Size = new System.Drawing.Size(734, 226);
            this.gridProd_Serv.TabIndex = 14;
            this.gridProd_Serv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProd_Serv_CellClick);
            this.gridProd_Serv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProd_Serv_CellContentClick);
            this.gridProd_Serv.Click += new System.EventHandler(this.gridProd_Serv_Click);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "Id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Id_produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.barbeariashopDataSetBindingSource;
            // 
            // barbeariashopDataSetBindingSource
            // 
            this.barbeariashopDataSetBindingSource.DataSource = this.barbearia_shopDataSet;
            this.barbeariashopDataSetBindingSource.Position = 0;
            // 
            // barbearia_shopDataSet
            // 
            this.barbearia_shopDataSet.DataSetName = "Barbearia_shopDataSet";
            this.barbearia_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(102, 375);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(96, 20);
            this.txtValor.TabIndex = 15;
            // 
            // cbChange
            // 
            this.cbChange.AutoSize = true;
            this.cbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChange.Location = new System.Drawing.Point(530, 374);
            this.cbChange.Name = "cbChange";
            this.cbChange.Size = new System.Drawing.Size(74, 21);
            this.cbChange.TabIndex = 16;
            this.cbChange.Text = "Serviço";
            this.cbChange.UseVisualStyleBackColor = true;
            // 
            // Cad_Prod_Serv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.cbChange);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.gridProd_Serv);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lbQuant);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbDesc);
            this.Name = "Cad_Prod_Serv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos e Serviços";
            this.Load += new System.EventHandler(this.Cad_Prod_Serv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProd_Serv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbeariashopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barbearia_shopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbQuant;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.DataGridView gridProd_Serv;
        private System.Windows.Forms.BindingSource barbeariashopDataSetBindingSource;
        private Barbearia_shopDataSet barbearia_shopDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Barbearia_shopDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.CheckBox cbChange;
    }
}