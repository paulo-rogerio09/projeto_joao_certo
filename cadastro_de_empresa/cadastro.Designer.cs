namespace cadastro_de_empresa
{
    partial class cadastro
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
            this.cnpj_tx = new System.Windows.Forms.Label();
            this.razao_tx = new System.Windows.Forms.Label();
            this.fantasia_tx = new System.Windows.Forms.Label();
            this.cadastral_tx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inicio_tx = new System.Windows.Forms.Label();
            this.telefone_tx = new System.Windows.Forms.Label();
            this.capital_tx = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.porte_tx = new System.Windows.Forms.Label();
            this.natureza_tx = new System.Windows.Forms.Label();
            this.nome_tx = new System.Windows.Forms.Label();
            this.cpf_tx = new System.Windows.Forms.Label();
            this.tipo_tx = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.TextBox();
            this.razao = new System.Windows.Forms.TextBox();
            this.nome_fantasia = new System.Windows.Forms.TextBox();
            this.capital = new System.Windows.Forms.TextBox();
            this.cpf_proprietario = new System.Windows.Forms.TextBox();
            this.nome_proprietario = new System.Windows.Forms.TextBox();
            this.pequeno = new System.Windows.Forms.RadioButton();
            this.medio = new System.Windows.Forms.RadioButton();
            this.grande = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.situacao_cadastral = new System.Windows.Forms.ComboBox();
            this.simples = new System.Windows.Forms.RadioButton();
            this.lucro = new System.Windows.Forms.RadioButton();
            this.real = new System.Windows.Forms.RadioButton();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.matriz = new System.Windows.Forms.RadioButton();
            this.filial = new System.Windows.Forms.RadioButton();
            this.natureza = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.enderecos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cnpj_tx
            // 
            this.cnpj_tx.AutoSize = true;
            this.cnpj_tx.Location = new System.Drawing.Point(134, 53);
            this.cnpj_tx.Name = "cnpj_tx";
            this.cnpj_tx.Size = new System.Drawing.Size(27, 13);
            this.cnpj_tx.TabIndex = 0;
            this.cnpj_tx.Text = "cnpj";
            // 
            // razao_tx
            // 
            this.razao_tx.AutoSize = true;
            this.razao_tx.Location = new System.Drawing.Point(103, 78);
            this.razao_tx.Name = "razao_tx";
            this.razao_tx.Size = new System.Drawing.Size(63, 13);
            this.razao_tx.TabIndex = 1;
            this.razao_tx.Text = "razão social";
            this.razao_tx.Click += new System.EventHandler(this.razao_tx_Click);
            // 
            // fantasia_tx
            // 
            this.fantasia_tx.AutoSize = true;
            this.fantasia_tx.Location = new System.Drawing.Point(96, 105);
            this.fantasia_tx.Name = "fantasia_tx";
            this.fantasia_tx.Size = new System.Drawing.Size(73, 13);
            this.fantasia_tx.TabIndex = 2;
            this.fantasia_tx.Text = "nome fantasia";
            // 
            // cadastral_tx
            // 
            this.cadastral_tx.AutoSize = true;
            this.cadastral_tx.Location = new System.Drawing.Point(77, 132);
            this.cadastral_tx.Name = "cadastral_tx";
            this.cadastral_tx.Size = new System.Drawing.Size(93, 13);
            this.cadastral_tx.TabIndex = 3;
            this.cadastral_tx.Text = "situação cadastral";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "regime tributario";
            // 
            // inicio_tx
            // 
            this.inicio_tx.AutoSize = true;
            this.inicio_tx.Location = new System.Drawing.Point(98, 189);
            this.inicio_tx.Name = "inicio_tx";
            this.inicio_tx.Size = new System.Drawing.Size(68, 13);
            this.inicio_tx.TabIndex = 5;
            this.inicio_tx.Text = "data de incio";
            // 
            // telefone_tx
            // 
            this.telefone_tx.AutoSize = true;
            this.telefone_tx.Location = new System.Drawing.Point(121, 219);
            this.telefone_tx.Name = "telefone_tx";
            this.telefone_tx.Size = new System.Drawing.Size(45, 13);
            this.telefone_tx.TabIndex = 6;
            this.telefone_tx.Text = "telefone";
            // 
            // capital_tx
            // 
            this.capital_tx.AutoSize = true;
            this.capital_tx.Location = new System.Drawing.Point(98, 251);
            this.capital_tx.Name = "capital_tx";
            this.capital_tx.Size = new System.Drawing.Size(68, 13);
            this.capital_tx.TabIndex = 7;
            this.capital_tx.Text = "capital social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "endereço";
            // 
            // porte_tx
            // 
            this.porte_tx.AutoSize = true;
            this.porte_tx.Location = new System.Drawing.Point(79, 345);
            this.porte_tx.Name = "porte_tx";
            this.porte_tx.Size = new System.Drawing.Size(89, 13);
            this.porte_tx.TabIndex = 9;
            this.porte_tx.Text = "porte da empresa";
            // 
            // natureza_tx
            // 
            this.natureza_tx.AutoSize = true;
            this.natureza_tx.Location = new System.Drawing.Point(82, 371);
            this.natureza_tx.Name = "natureza_tx";
            this.natureza_tx.Size = new System.Drawing.Size(84, 13);
            this.natureza_tx.TabIndex = 10;
            this.natureza_tx.Text = "natureza juridica";
            // 
            // nome_tx
            // 
            this.nome_tx.AutoSize = true;
            this.nome_tx.Location = new System.Drawing.Point(64, 405);
            this.nome_tx.Name = "nome_tx";
            this.nome_tx.Size = new System.Drawing.Size(106, 13);
            this.nome_tx.TabIndex = 11;
            this.nome_tx.Text = "nome do proprietario ";
            // 
            // cpf_tx
            // 
            this.cpf_tx.AutoSize = true;
            this.cpf_tx.Location = new System.Drawing.Point(74, 431);
            this.cpf_tx.Name = "cpf_tx";
            this.cpf_tx.Size = new System.Drawing.Size(92, 13);
            this.cpf_tx.TabIndex = 12;
            this.cpf_tx.Text = "cpf do propietario ";
            // 
            // tipo_tx
            // 
            this.tipo_tx.AutoSize = true;
            this.tipo_tx.Location = new System.Drawing.Point(142, 320);
            this.tipo_tx.Name = "tipo_tx";
            this.tipo_tx.Size = new System.Drawing.Size(24, 13);
            this.tipo_tx.TabIndex = 14;
            this.tipo_tx.Text = "tipo";
            // 
            // cnpj
            // 
            this.cnpj.Location = new System.Drawing.Point(205, 52);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(133, 20);
            this.cnpj.TabIndex = 15;
            // 
            // razao
            // 
            this.razao.Location = new System.Drawing.Point(205, 78);
            this.razao.Name = "razao";
            this.razao.Size = new System.Drawing.Size(133, 20);
            this.razao.TabIndex = 16;
            // 
            // nome_fantasia
            // 
            this.nome_fantasia.Location = new System.Drawing.Point(205, 104);
            this.nome_fantasia.Name = "nome_fantasia";
            this.nome_fantasia.Size = new System.Drawing.Size(133, 20);
            this.nome_fantasia.TabIndex = 17;
            this.nome_fantasia.TextChanged += new System.EventHandler(this.nome_fantasia_TextChanged);
            // 
            // capital
            // 
            this.capital.Location = new System.Drawing.Point(205, 248);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(133, 20);
            this.capital.TabIndex = 18;
            // 
            // cpf_proprietario
            // 
            this.cpf_proprietario.Location = new System.Drawing.Point(205, 428);
            this.cpf_proprietario.Name = "cpf_proprietario";
            this.cpf_proprietario.Size = new System.Drawing.Size(139, 20);
            this.cpf_proprietario.TabIndex = 20;
            // 
            // nome_proprietario
            // 
            this.nome_proprietario.Location = new System.Drawing.Point(205, 402);
            this.nome_proprietario.Name = "nome_proprietario";
            this.nome_proprietario.Size = new System.Drawing.Size(139, 20);
            this.nome_proprietario.TabIndex = 21;
            // 
            // pequeno
            // 
            this.pequeno.AutoSize = true;
            this.pequeno.Location = new System.Drawing.Point(30, 3);
            this.pequeno.Name = "pequeno";
            this.pequeno.Size = new System.Drawing.Size(67, 17);
            this.pequeno.TabIndex = 22;
            this.pequeno.TabStop = true;
            this.pequeno.Text = "pequeno";
            this.pequeno.UseVisualStyleBackColor = true;
            // 
            // medio
            // 
            this.medio.AutoSize = true;
            this.medio.Location = new System.Drawing.Point(126, 3);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(53, 17);
            this.medio.TabIndex = 23;
            this.medio.TabStop = true;
            this.medio.Text = "medio";
            this.medio.UseVisualStyleBackColor = true;
            // 
            // grande
            // 
            this.grande.AutoSize = true;
            this.grande.Location = new System.Drawing.Point(185, 3);
            this.grande.Name = "grande";
            this.grande.Size = new System.Drawing.Size(58, 17);
            this.grande.TabIndex = 24;
            this.grande.TabStop = true;
            this.grande.Text = "grande";
            this.grande.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(205, 212);
            this.maskedTextBox1.Mask = "(00) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // situacao_cadastral
            // 
            this.situacao_cadastral.FormattingEnabled = true;
            this.situacao_cadastral.Items.AddRange(new object[] {
            "ativa ",
            "nula ",
            "suspensa ",
            "inapta",
            "baixada"});
            this.situacao_cadastral.Location = new System.Drawing.Point(205, 129);
            this.situacao_cadastral.Name = "situacao_cadastral";
            this.situacao_cadastral.Size = new System.Drawing.Size(133, 21);
            this.situacao_cadastral.TabIndex = 26;
            // 
            // simples
            // 
            this.simples.AutoSize = true;
            this.simples.Location = new System.Drawing.Point(6, 15);
            this.simples.Name = "simples";
            this.simples.Size = new System.Drawing.Size(108, 17);
            this.simples.TabIndex = 27;
            this.simples.TabStop = true;
            this.simples.Text = "simples naciopnal";
            this.simples.UseVisualStyleBackColor = true;
            // 
            // lucro
            // 
            this.lucro.AutoSize = true;
            this.lucro.Location = new System.Drawing.Point(120, 15);
            this.lucro.Name = "lucro";
            this.lucro.Size = new System.Drawing.Size(99, 17);
            this.lucro.TabIndex = 28;
            this.lucro.TabStop = true;
            this.lucro.Text = "lucro presumido";
            this.lucro.UseVisualStyleBackColor = true;
            // 
            // real
            // 
            this.real.AutoSize = true;
            this.real.Location = new System.Drawing.Point(247, 15);
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(42, 17);
            this.real.TabIndex = 29;
            this.real.TabStop = true;
            this.real.Text = "real";
            this.real.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(181, 184);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(200, 20);
            this.data.TabIndex = 31;
            // 
            // matriz
            // 
            this.matriz.AutoSize = true;
            this.matriz.Location = new System.Drawing.Point(6, 12);
            this.matriz.Name = "matriz";
            this.matriz.Size = new System.Drawing.Size(52, 17);
            this.matriz.TabIndex = 32;
            this.matriz.TabStop = true;
            this.matriz.Text = "matriz";
            this.matriz.UseVisualStyleBackColor = true;
            // 
            // filial
            // 
            this.filial.AutoSize = true;
            this.filial.Location = new System.Drawing.Point(80, 12);
            this.filial.Name = "filial";
            this.filial.Size = new System.Drawing.Size(42, 17);
            this.filial.TabIndex = 33;
            this.filial.TabStop = true;
            this.filial.Text = "filial";
            this.filial.UseVisualStyleBackColor = true;
            // 
            // natureza
            // 
            this.natureza.FormattingEnabled = true;
            this.natureza.Items.AddRange(new object[] {
            "empresario individual",
            "microempresario individual",
            "sociedade anonima"});
            this.natureza.Location = new System.Drawing.Point(205, 371);
            this.natureza.Name = "natureza";
            this.natureza.Size = new System.Drawing.Size(139, 21);
            this.natureza.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 63);
            this.button1.TabIndex = 35;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enderecos
            // 
            this.enderecos.FormattingEnabled = true;
            this.enderecos.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins",
            "Distrito Federal"});
            this.enderecos.Location = new System.Drawing.Point(205, 285);
            this.enderecos.Name = "enderecos";
            this.enderecos.Size = new System.Drawing.Size(133, 21);
            this.enderecos.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.real);
            this.groupBox1.Controls.Add(this.lucro);
            this.groupBox1.Controls.Add(this.simples);
            this.groupBox1.Location = new System.Drawing.Point(181, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 32);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.matriz);
            this.groupBox2.Controls.Add(this.filial);
            this.groupBox2.Location = new System.Drawing.Point(217, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 29);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grande);
            this.groupBox3.Controls.Add(this.medio);
            this.groupBox3.Controls.Add(this.pequeno);
            this.groupBox3.Location = new System.Drawing.Point(188, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 20);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.enderecos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.natureza);
            this.Controls.Add(this.data);
            this.Controls.Add(this.situacao_cadastral);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.nome_proprietario);
            this.Controls.Add(this.cpf_proprietario);
            this.Controls.Add(this.capital);
            this.Controls.Add(this.nome_fantasia);
            this.Controls.Add(this.razao);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.tipo_tx);
            this.Controls.Add(this.cpf_tx);
            this.Controls.Add(this.nome_tx);
            this.Controls.Add(this.natureza_tx);
            this.Controls.Add(this.porte_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capital_tx);
            this.Controls.Add(this.telefone_tx);
            this.Controls.Add(this.inicio_tx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cadastral_tx);
            this.Controls.Add(this.fantasia_tx);
            this.Controls.Add(this.razao_tx);
            this.Controls.Add(this.cnpj_tx);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cnpj_tx;
        private System.Windows.Forms.Label razao_tx;
        private System.Windows.Forms.Label fantasia_tx;
        private System.Windows.Forms.Label cadastral_tx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label inicio_tx;
        private System.Windows.Forms.Label telefone_tx;
        private System.Windows.Forms.Label capital_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label porte_tx;
        private System.Windows.Forms.Label natureza_tx;
        private System.Windows.Forms.Label nome_tx;
        private System.Windows.Forms.Label cpf_tx;
        private System.Windows.Forms.Label tipo_tx;
        private System.Windows.Forms.TextBox cnpj;
        private System.Windows.Forms.TextBox razao;
        private System.Windows.Forms.TextBox nome_fantasia;
        private System.Windows.Forms.TextBox capital;
        private System.Windows.Forms.TextBox cpf_proprietario;
        private System.Windows.Forms.TextBox nome_proprietario;
        private System.Windows.Forms.RadioButton pequeno;
        private System.Windows.Forms.RadioButton medio;
        private System.Windows.Forms.RadioButton grande;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox situacao_cadastral;
        private System.Windows.Forms.RadioButton simples;
        private System.Windows.Forms.RadioButton lucro;
        private System.Windows.Forms.RadioButton real;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.RadioButton matriz;
        private System.Windows.Forms.RadioButton filial;
        private System.Windows.Forms.ComboBox natureza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox enderecos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}