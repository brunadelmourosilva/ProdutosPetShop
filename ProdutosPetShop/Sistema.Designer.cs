﻿namespace ProdutosPetShop
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtValorUni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeBusca = new System.Windows.Forms.TextBox();
            this.btnConfirmaRemocao = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConfirmaCadastro = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAlteraValorUni = new System.Windows.Forms.TextBox();
            this.txtAlteraValorCompra = new System.Windows.Forms.TextBox();
            this.txtAlteraQtd = new System.Windows.Forms.TextBox();
            this.txtAlteraMarca = new System.Windows.Forms.TextBox();
            this.txtAlteraDescricao = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            this.tabAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.btnCadastra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 568);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.panel4.Location = new System.Drawing.Point(1, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 50);
            this.panel4.TabIndex = 3;
            // 
            // btnBusca
            // 
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBusca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(12, 151);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(171, 54);
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "      Buscar";
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // btnCadastra
            // 
            this.btnCadastra.FlatAppearance.BorderSize = 0;
            this.btnCadastra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastra.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastra.ForeColor = System.Drawing.Color.White;
            this.btnCadastra.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastra.Image")));
            this.btnCadastra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.Location = new System.Drawing.Point(12, 77);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(171, 54);
            this.btnCadastra.TabIndex = 3;
            this.btnCadastra.Text = "      Cadastrar";
            this.btnCadastra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastra.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(650, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 37);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(241, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 120);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(183, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 430);
            this.tabControl1.TabIndex = 3;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.tabCadastrar.Controls.Add(this.btnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtValorUni);
            this.tabCadastrar.Controls.Add(this.txtValorCompra);
            this.tabCadastrar.Controls.Add(this.txtQtd);
            this.tabCadastrar.Controls.Add(this.txtMarca);
            this.tabCadastrar.Controls.Add(this.txtDescricao);
            this.tabCadastrar.Controls.Add(this.txtNome);
            this.tabCadastrar.Controls.Add(this.label7);
            this.tabCadastrar.Controls.Add(this.label6);
            this.tabCadastrar.Controls.Add(this.label5);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 28);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(670, 398);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.tabBuscar.Controls.Add(this.dgProdutos);
            this.tabBuscar.Controls.Add(this.btnAlterar);
            this.tabBuscar.Controls.Add(this.btnConfirmaRemocao);
            this.tabBuscar.Controls.Add(this.txtNomeBusca);
            this.tabBuscar.Controls.Add(this.label8);
            this.tabBuscar.Location = new System.Drawing.Point(4, 28);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(670, 398);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // tabAlterar
            // 
            this.tabAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Controls.Add(this.txtAlteraValorUni);
            this.tabAlterar.Controls.Add(this.txtAlteraValorCompra);
            this.tabAlterar.Controls.Add(this.txtAlteraQtd);
            this.tabAlterar.Controls.Add(this.txtAlteraMarca);
            this.tabAlterar.Controls.Add(this.txtAlteraDescricao);
            this.tabAlterar.Controls.Add(this.txtAlteraNome);
            this.tabAlterar.Controls.Add(this.label9);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Controls.Add(this.label11);
            this.tabAlterar.Controls.Add(this.label12);
            this.tabAlterar.Controls.Add(this.label13);
            this.tabAlterar.Controls.Add(this.label14);
            this.tabAlterar.Location = new System.Drawing.Point(4, 28);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlterar.Size = new System.Drawing.Size(670, 398);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor total da compra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Valor unitário:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(164, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(498, 27);
            this.txtNome.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(164, 70);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(498, 27);
            this.txtDescricao.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(164, 127);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(498, 27);
            this.txtMarca.TabIndex = 8;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(164, 171);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(162, 27);
            this.txtQtd.TabIndex = 9;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(164, 221);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(162, 27);
            this.txtValorCompra.TabIndex = 10;
            // 
            // txtValorUni
            // 
            this.txtValorUni.Location = new System.Drawing.Point(164, 273);
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(162, 27);
            this.txtValorUni.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome:";
            // 
            // txtNomeBusca
            // 
            this.txtNomeBusca.Location = new System.Drawing.Point(77, 13);
            this.txtNomeBusca.Name = "txtNomeBusca";
            this.txtNomeBusca.Size = new System.Drawing.Size(587, 27);
            this.txtNomeBusca.TabIndex = 1;
            // 
            // btnConfirmaRemocao
            // 
            this.btnConfirmaRemocao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaRemocao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConfirmaRemocao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmaRemocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaRemocao.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaRemocao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConfirmaRemocao.Location = new System.Drawing.Point(580, 65);
            this.btnConfirmaRemocao.Name = "btnConfirmaRemocao";
            this.btnConfirmaRemocao.Size = new System.Drawing.Size(84, 58);
            this.btnConfirmaRemocao.TabIndex = 2;
            this.btnConfirmaRemocao.Text = "Remover";
            this.btnConfirmaRemocao.UseVisualStyleBackColor = true;
            this.btnConfirmaRemocao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAlterar.Location = new System.Drawing.Point(580, 143);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 58);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmaCadastro
            // 
            this.btnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.btnConfirmaCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConfirmaCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaCadastro.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaCadastro.Image")));
            this.btnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaCadastro.Location = new System.Drawing.Point(258, 324);
            this.btnConfirmaCadastro.Name = "btnConfirmaCadastro";
            this.btnConfirmaCadastro.Size = new System.Drawing.Size(130, 40);
            this.btnConfirmaCadastro.TabIndex = 12;
            this.btnConfirmaCadastro.Text = " Salvar";
            this.btnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaCadastro.UseVisualStyleBackColor = true;
            // 
            // dgProdutos
            // 
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(11, 48);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(563, 344);
            this.dgProdutos.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Valor unitário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Valor total da compra:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Quantidade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Marca:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Descrição:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nome:";
            // 
            // txtAlteraValorUni
            // 
            this.txtAlteraValorUni.Location = new System.Drawing.Point(166, 285);
            this.txtAlteraValorUni.Name = "txtAlteraValorUni";
            this.txtAlteraValorUni.Size = new System.Drawing.Size(162, 27);
            this.txtAlteraValorUni.TabIndex = 17;
            // 
            // txtAlteraValorCompra
            // 
            this.txtAlteraValorCompra.Location = new System.Drawing.Point(166, 233);
            this.txtAlteraValorCompra.Name = "txtAlteraValorCompra";
            this.txtAlteraValorCompra.Size = new System.Drawing.Size(162, 27);
            this.txtAlteraValorCompra.TabIndex = 16;
            // 
            // txtAlteraQtd
            // 
            this.txtAlteraQtd.Location = new System.Drawing.Point(166, 183);
            this.txtAlteraQtd.Name = "txtAlteraQtd";
            this.txtAlteraQtd.Size = new System.Drawing.Size(162, 27);
            this.txtAlteraQtd.TabIndex = 15;
            // 
            // txtAlteraMarca
            // 
            this.txtAlteraMarca.Location = new System.Drawing.Point(166, 139);
            this.txtAlteraMarca.Name = "txtAlteraMarca";
            this.txtAlteraMarca.Size = new System.Drawing.Size(498, 27);
            this.txtAlteraMarca.TabIndex = 14;
            // 
            // txtAlteraDescricao
            // 
            this.txtAlteraDescricao.Location = new System.Drawing.Point(166, 82);
            this.txtAlteraDescricao.Name = "txtAlteraDescricao";
            this.txtAlteraDescricao.Size = new System.Drawing.Size(498, 27);
            this.txtAlteraDescricao.TabIndex = 13;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Location = new System.Drawing.Point(166, 32);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(498, 27);
            this.txtAlteraNome.TabIndex = 12;
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConfirmaAlteracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(258, 324);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(130, 40);
            this.btnConfirmaAlteracao.TabIndex = 18;
            this.btnConfirmaAlteracao.Text = "Alterar";
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "PetShop";
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 568);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.TabPage tabAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorUni;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnConfirmaRemocao;
        private System.Windows.Forms.TextBox txtNomeBusca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirmaCadastro;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.TextBox txtAlteraValorUni;
        private System.Windows.Forms.TextBox txtAlteraValorCompra;
        private System.Windows.Forms.TextBox txtAlteraQtd;
        private System.Windows.Forms.TextBox txtAlteraMarca;
        private System.Windows.Forms.TextBox txtAlteraDescricao;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
