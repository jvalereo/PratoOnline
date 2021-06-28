namespace Prato_Online
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblIngredi = new System.Windows.Forms.Label();
            this.lblPratos = new System.Windows.Forms.Label();
            this.lstIngrediente = new System.Windows.Forms.ListBox();
            this.lstPratos = new System.Windows.Forms.ListBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnEspecial = new System.Windows.Forms.Button();
            this.gbrTipo = new System.Windows.Forms.GroupBox();
            this.chkViagem = new System.Windows.Forms.RadioButton();
            this.chkLocal = new System.Windows.Forms.RadioButton();
            this.gbrEmbalagem = new System.Windows.Forms.GroupBox();
            this.chkAluminio = new System.Windows.Forms.CheckBox();
            this.chkPlastico = new System.Windows.Forms.CheckBox();
            this.chkIsopor = new System.Windows.Forms.CheckBox();
            this.gbrBebidas = new System.Windows.Forms.GroupBox();
            this.chkRefrigerante = new System.Windows.Forms.CheckBox();
            this.chkAgua = new System.Windows.Forms.CheckBox();
            this.chkSuco = new System.Windows.Forms.CheckBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbrTipo.SuspendLayout();
            this.gbrEmbalagem.SuspendLayout();
            this.gbrBebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(180, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(325, 76);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Prato Online ";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(231, 125);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(192, 22);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Faça a Sua Escolha ";
       
            // 
            // lblIngredi
            // 
            this.lblIngredi.AutoSize = true;
            this.lblIngredi.BackColor = System.Drawing.Color.Transparent;
            this.lblIngredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredi.Location = new System.Drawing.Point(57, 192);
            this.lblIngredi.Name = "lblIngredi";
            this.lblIngredi.Size = new System.Drawing.Size(149, 25);
            this.lblIngredi.TabIndex = 3;
            this.lblIngredi.Text = "Ingredientes:";
            // 
            // lblPratos
            // 
            this.lblPratos.AutoSize = true;
            this.lblPratos.BackColor = System.Drawing.Color.Transparent;
            this.lblPratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPratos.Location = new System.Drawing.Point(422, 192);
            this.lblPratos.Name = "lblPratos";
            this.lblPratos.Size = new System.Drawing.Size(87, 25);
            this.lblPratos.TabIndex = 4;
            this.lblPratos.Text = "Pratos:";
            // 
            // lstIngrediente
            // 
            this.lstIngrediente.FormattingEnabled = true;
            this.lstIngrediente.Items.AddRange(new object[] {
            "Feijão",
            "Arroz ",
            "Marcarão",
            "Carne",
            "Frango",
            "Batata",
            "Salada"});
            this.lstIngrediente.Location = new System.Drawing.Point(58, 231);
            this.lstIngrediente.Name = "lstIngrediente";
            this.lstIngrediente.Size = new System.Drawing.Size(180, 212);
            this.lstIngrediente.TabIndex = 5;
            // 
            // lstPratos
            // 
            this.lstPratos.FormattingEnabled = true;
            this.lstPratos.Location = new System.Drawing.Point(427, 231);
            this.lstPratos.Name = "lstPratos";
            this.lstPratos.Size = new System.Drawing.Size(179, 212);
            this.lstPratos.TabIndex = 6;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Location = new System.Drawing.Point(269, 240);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(126, 35);
            this.BtnAdicionar.TabIndex = 7;
            this.BtnAdicionar.Text = "Adicionar >>";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(269, 297);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(126, 32);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "<< Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(269, 348);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(126, 34);
            this.BtnNovo.TabIndex = 9;
            this.BtnNovo.Text = "Novo Prato";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnEspecial
            // 
            this.BtnEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEspecial.Location = new System.Drawing.Point(269, 409);
            this.BtnEspecial.Name = "BtnEspecial";
            this.BtnEspecial.Size = new System.Drawing.Size(126, 32);
            this.BtnEspecial.TabIndex = 10;
            this.BtnEspecial.Text = "Especial";
            this.BtnEspecial.UseVisualStyleBackColor = true;
            this.BtnEspecial.Click += new System.EventHandler(this.BtnEspecial_Click);
            // 
            // gbrTipo
            // 
            this.gbrTipo.BackColor = System.Drawing.Color.Transparent;
            this.gbrTipo.Controls.Add(this.chkViagem);
            this.gbrTipo.Controls.Add(this.chkLocal);
            this.gbrTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrTipo.Location = new System.Drawing.Point(58, 462);
            this.gbrTipo.Name = "gbrTipo";
            this.gbrTipo.Size = new System.Drawing.Size(159, 100);
            this.gbrTipo.TabIndex = 11;
            this.gbrTipo.TabStop = false;
            this.gbrTipo.Text = "Tipo:";
            // 
            // chkViagem
            // 
            this.chkViagem.AutoSize = true;
            this.chkViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkViagem.Location = new System.Drawing.Point(7, 66);
            this.chkViagem.Name = "chkViagem";
            this.chkViagem.Size = new System.Drawing.Size(81, 24);
            this.chkViagem.TabIndex = 1;
            this.chkViagem.TabStop = true;
            this.chkViagem.Text = "Viagem";
            this.chkViagem.UseVisualStyleBackColor = true;
            this.chkViagem.CheckedChanged += new System.EventHandler(this.chkViagem_CheckedChanged);
            // 
            // chkLocal
            // 
            this.chkLocal.AutoSize = true;
            this.chkLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLocal.Location = new System.Drawing.Point(7, 35);
            this.chkLocal.Name = "chkLocal";
            this.chkLocal.Size = new System.Drawing.Size(65, 24);
            this.chkLocal.TabIndex = 0;
            this.chkLocal.TabStop = true;
            this.chkLocal.Text = "Local";
            this.chkLocal.UseVisualStyleBackColor = true;
            this.chkLocal.CheckedChanged += new System.EventHandler(this.chkLocal_CheckedChanged);
            // 
            // gbrEmbalagem
            // 
            this.gbrEmbalagem.BackColor = System.Drawing.Color.Transparent;
            this.gbrEmbalagem.Controls.Add(this.chkAluminio);
            this.gbrEmbalagem.Controls.Add(this.chkPlastico);
            this.gbrEmbalagem.Controls.Add(this.chkIsopor);
            this.gbrEmbalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrEmbalagem.Location = new System.Drawing.Point(249, 462);
            this.gbrEmbalagem.Name = "gbrEmbalagem";
            this.gbrEmbalagem.Size = new System.Drawing.Size(174, 100);
            this.gbrEmbalagem.TabIndex = 12;
            this.gbrEmbalagem.TabStop = false;
            this.gbrEmbalagem.Text = "Embalagens:";
            // 
            // chkAluminio
            // 
            this.chkAluminio.AutoSize = true;
            this.chkAluminio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAluminio.Location = new System.Drawing.Point(6, 70);
            this.chkAluminio.Name = "chkAluminio";
            this.chkAluminio.Size = new System.Drawing.Size(88, 24);
            this.chkAluminio.TabIndex = 2;
            this.chkAluminio.Text = "Alumínio";
            this.chkAluminio.UseVisualStyleBackColor = true;
            this.chkAluminio.CheckedChanged += new System.EventHandler(this.chkAluminio_CheckedChanged);
            // 
            // chkPlastico
            // 
            this.chkPlastico.AutoSize = true;
            this.chkPlastico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlastico.Location = new System.Drawing.Point(6, 25);
            this.chkPlastico.Name = "chkPlastico";
            this.chkPlastico.Size = new System.Drawing.Size(83, 24);
            this.chkPlastico.TabIndex = 0;
            this.chkPlastico.Text = "Plástico";
            this.chkPlastico.UseVisualStyleBackColor = true;
            this.chkPlastico.CheckedChanged += new System.EventHandler(this.chkPlastico_CheckedChanged);
            // 
            // chkIsopor
            // 
            this.chkIsopor.AutoSize = true;
            this.chkIsopor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsopor.Location = new System.Drawing.Point(6, 46);
            this.chkIsopor.Name = "chkIsopor";
            this.chkIsopor.Size = new System.Drawing.Size(77, 24);
            this.chkIsopor.TabIndex = 1;
            this.chkIsopor.Text = "Isopor ";
            this.chkIsopor.UseVisualStyleBackColor = true;
            this.chkIsopor.CheckedChanged += new System.EventHandler(this.chkIsopor_CheckedChanged);
            // 
            // gbrBebidas
            // 
            this.gbrBebidas.BackColor = System.Drawing.Color.Transparent;
            this.gbrBebidas.Controls.Add(this.chkRefrigerante);
            this.gbrBebidas.Controls.Add(this.chkAgua);
            this.gbrBebidas.Controls.Add(this.chkSuco);
            this.gbrBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrBebidas.Location = new System.Drawing.Point(455, 462);
            this.gbrBebidas.Name = "gbrBebidas";
            this.gbrBebidas.Size = new System.Drawing.Size(157, 100);
            this.gbrBebidas.TabIndex = 13;
            this.gbrBebidas.TabStop = false;
            this.gbrBebidas.Text = "Bebidas:";
            // 
            // chkRefrigerante
            // 
            this.chkRefrigerante.AutoSize = true;
            this.chkRefrigerante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRefrigerante.Location = new System.Drawing.Point(8, 70);
            this.chkRefrigerante.Name = "chkRefrigerante";
            this.chkRefrigerante.Size = new System.Drawing.Size(117, 24);
            this.chkRefrigerante.TabIndex = 2;
            this.chkRefrigerante.Text = "Refrigerante";
            this.chkRefrigerante.UseVisualStyleBackColor = true;
            // 
            // chkAgua
            // 
            this.chkAgua.AutoSize = true;
            this.chkAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgua.Location = new System.Drawing.Point(8, 46);
            this.chkAgua.Name = "chkAgua";
            this.chkAgua.Size = new System.Drawing.Size(66, 24);
            this.chkAgua.TabIndex = 1;
            this.chkAgua.Text = "Água";
            this.chkAgua.UseVisualStyleBackColor = true;
            // 
            // chkSuco
            // 
            this.chkSuco.AutoSize = true;
            this.chkSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuco.Location = new System.Drawing.Point(7, 25);
            this.chkSuco.Name = "chkSuco";
            this.chkSuco.Size = new System.Drawing.Size(65, 24);
            this.chkSuco.TabIndex = 0;
            this.chkSuco.Text = "Suco";
            this.chkSuco.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(269, 591);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(141, 26);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(146, 591);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 26);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar Tela";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(427, 591);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 26);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(667, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gbrBebidas);
            this.Controls.Add(this.gbrEmbalagem);
            this.Controls.Add(this.gbrTipo);
            this.Controls.Add(this.BtnEspecial);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.lstPratos);
            this.Controls.Add(this.lstIngrediente);
            this.Controls.Add(this.lblPratos);
            this.Controls.Add(this.lblIngredi);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prato Online";
            this.gbrTipo.ResumeLayout(false);
            this.gbrTipo.PerformLayout();
            this.gbrEmbalagem.ResumeLayout(false);
            this.gbrEmbalagem.PerformLayout();
            this.gbrBebidas.ResumeLayout(false);
            this.gbrBebidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblIngredi;
        private System.Windows.Forms.Label lblPratos;
        private System.Windows.Forms.ListBox lstIngrediente;
        private System.Windows.Forms.ListBox lstPratos;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnEspecial;
        private System.Windows.Forms.GroupBox gbrTipo;
        private System.Windows.Forms.GroupBox gbrEmbalagem;
        private System.Windows.Forms.GroupBox gbrBebidas;
        private System.Windows.Forms.RadioButton chkViagem;
        private System.Windows.Forms.RadioButton chkLocal;
        private System.Windows.Forms.CheckBox chkAluminio;
        private System.Windows.Forms.CheckBox chkPlastico;
        private System.Windows.Forms.CheckBox chkIsopor;
        private System.Windows.Forms.CheckBox chkRefrigerante;
        private System.Windows.Forms.CheckBox chkAgua;
        private System.Windows.Forms.CheckBox chkSuco;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

