namespace Projeto3Camadas
{
    partial class Frm_CadastroProprietário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroProprietário));
            this.lbl_id_proprietario = new System.Windows.Forms.Label();
            this.txt_id_proprietario = new System.Windows.Forms.TextBox();
            this.lbl_cpf_cnpj = new System.Windows.Forms.Label();
            this.lbl_nome_razaosocial = new System.Windows.Forms.Label();
            this.txt_nome_razaosocial = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_nome_fazenda = new System.Windows.Forms.Label();
            this.txt_nome_fazenda = new System.Windows.Forms.TextBox();
            this.lbl_municipio = new System.Windows.Forms.Label();
            this.txt_municipio_fazenda = new System.Windows.Forms.TextBox();
            this.lbl_estado_municipio = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.Grid_Proprietários = new System.Windows.Forms.DataGridView();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_cadastrar_equipamento = new System.Windows.Forms.Button();
            this.txt_cpf_cnpj = new System.Windows.Forms.TextBox();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.cmb_uf_municipio_fazenda = new System.Windows.Forms.ComboBox();
            this.lbl_nome_tela = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_data_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_pesquisa_nome = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Proprietários)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_id_proprietario
            // 
            this.lbl_id_proprietario.AutoSize = true;
            this.lbl_id_proprietario.Location = new System.Drawing.Point(490, 22);
            this.lbl_id_proprietario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_proprietario.Name = "lbl_id_proprietario";
            this.lbl_id_proprietario.Size = new System.Drawing.Size(27, 15);
            this.lbl_id_proprietario.TabIndex = 1;
            this.lbl_id_proprietario.Text = "ID:";
            this.lbl_id_proprietario.Visible = false;
            // 
            // txt_id_proprietario
            // 
            this.txt_id_proprietario.BackColor = System.Drawing.Color.White;
            this.txt_id_proprietario.Location = new System.Drawing.Point(493, 40);
            this.txt_id_proprietario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id_proprietario.Name = "txt_id_proprietario";
            this.txt_id_proprietario.ReadOnly = true;
            this.txt_id_proprietario.Size = new System.Drawing.Size(132, 23);
            this.txt_id_proprietario.TabIndex = 2;
            this.txt_id_proprietario.Visible = false;
            // 
            // lbl_cpf_cnpj
            // 
            this.lbl_cpf_cnpj.AutoSize = true;
            this.lbl_cpf_cnpj.Location = new System.Drawing.Point(13, 67);
            this.lbl_cpf_cnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpf_cnpj.Name = "lbl_cpf_cnpj";
            this.lbl_cpf_cnpj.Size = new System.Drawing.Size(80, 15);
            this.lbl_cpf_cnpj.TabIndex = 3;
            this.lbl_cpf_cnpj.Text = "CPF/CNPJ:";
            // 
            // lbl_nome_razaosocial
            // 
            this.lbl_nome_razaosocial.AutoSize = true;
            this.lbl_nome_razaosocial.Location = new System.Drawing.Point(13, 117);
            this.lbl_nome_razaosocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_razaosocial.Name = "lbl_nome_razaosocial";
            this.lbl_nome_razaosocial.Size = new System.Drawing.Size(137, 15);
            this.lbl_nome_razaosocial.TabIndex = 5;
            this.lbl_nome_razaosocial.Text = "Nome/Razão Social:";
            // 
            // txt_nome_razaosocial
            // 
            this.txt_nome_razaosocial.BackColor = System.Drawing.Color.White;
            this.txt_nome_razaosocial.Location = new System.Drawing.Point(17, 136);
            this.txt_nome_razaosocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nome_razaosocial.MaxLength = 255;
            this.txt_nome_razaosocial.Name = "txt_nome_razaosocial";
            this.txt_nome_razaosocial.Size = new System.Drawing.Size(467, 23);
            this.txt_nome_razaosocial.TabIndex = 6;
            this.txt_nome_razaosocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_razaosocial_KeyPress);
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(13, 167);
            this.lbl_endereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(71, 15);
            this.lbl_endereco.TabIndex = 7;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.BackColor = System.Drawing.Color.White;
            this.txt_endereco.Location = new System.Drawing.Point(17, 187);
            this.txt_endereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_endereco.MaxLength = 255;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(467, 23);
            this.txt_endereco.TabIndex = 8;
            this.txt_endereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_endereco_KeyPress);
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(13, 218);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(63, 15);
            this.lbl_numero.TabIndex = 9;
            this.lbl_numero.Text = "Número:";
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.Color.White;
            this.txt_numero.Location = new System.Drawing.Point(17, 238);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_numero.MaxLength = 10;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(467, 23);
            this.txt_numero.TabIndex = 10;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(13, 269);
            this.lbl_bairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(53, 15);
            this.lbl_bairro.TabIndex = 11;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.BackColor = System.Drawing.Color.White;
            this.txt_bairro.Location = new System.Drawing.Point(17, 288);
            this.txt_bairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_bairro.MaxLength = 255;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(467, 23);
            this.txt_bairro.TabIndex = 12;
            this.txt_bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bairro_KeyPress);
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(13, 321);
            this.lbl_cep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(40, 15);
            this.lbl_cep.TabIndex = 13;
            this.lbl_cep.Text = "CEP:";
            // 
            // txt_cep
            // 
            this.txt_cep.BackColor = System.Drawing.Color.White;
            this.txt_cep.Location = new System.Drawing.Point(17, 339);
            this.txt_cep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cep.MaxLength = 9;
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(467, 23);
            this.txt_cep.TabIndex = 14;
            this.txt_cep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cep_KeyPress);
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(13, 376);
            this.lbl_cidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(58, 15);
            this.lbl_cidade.TabIndex = 15;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.BackColor = System.Drawing.Color.White;
            this.txt_cidade.Location = new System.Drawing.Point(17, 395);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cidade.MaxLength = 255;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(467, 23);
            this.txt_cidade.TabIndex = 16;
            this.txt_cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cidade_KeyPress);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(489, 66);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(56, 15);
            this.lbl_estado.TabIndex = 17;
            this.lbl_estado.Text = "Estado:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(489, 117);
            this.lbl_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(119, 15);
            this.lbl_telefone.TabIndex = 19;
            this.lbl_telefone.Text = "Telefone Celular:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.White;
            this.txt_telefone.Location = new System.Drawing.Point(493, 135);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_telefone.MaxLength = 13;
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(432, 23);
            this.txt_telefone.TabIndex = 20;
            this.txt_telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefone_KeyPress);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(489, 167);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(56, 15);
            this.lbl_email.TabIndex = 21;
            this.lbl_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email.Location = new System.Drawing.Point(493, 186);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_email.MaxLength = 255;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(432, 23);
            this.txt_email.TabIndex = 22;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            // 
            // lbl_nome_fazenda
            // 
            this.lbl_nome_fazenda.AutoSize = true;
            this.lbl_nome_fazenda.Location = new System.Drawing.Point(489, 218);
            this.lbl_nome_fazenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome_fazenda.Name = "lbl_nome_fazenda";
            this.lbl_nome_fazenda.Size = new System.Drawing.Size(150, 15);
            this.lbl_nome_fazenda.TabIndex = 23;
            this.lbl_nome_fazenda.Text = "Nome da Propriedade:";
            // 
            // txt_nome_fazenda
            // 
            this.txt_nome_fazenda.BackColor = System.Drawing.Color.White;
            this.txt_nome_fazenda.Location = new System.Drawing.Point(493, 237);
            this.txt_nome_fazenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nome_fazenda.MaxLength = 255;
            this.txt_nome_fazenda.Name = "txt_nome_fazenda";
            this.txt_nome_fazenda.Size = new System.Drawing.Size(432, 23);
            this.txt_nome_fazenda.TabIndex = 24;
            this.txt_nome_fazenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_fazenda_KeyPress);
            // 
            // lbl_municipio
            // 
            this.lbl_municipio.AutoSize = true;
            this.lbl_municipio.Location = new System.Drawing.Point(489, 269);
            this.lbl_municipio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_municipio.Name = "lbl_municipio";
            this.lbl_municipio.Size = new System.Drawing.Size(79, 15);
            this.lbl_municipio.TabIndex = 25;
            this.lbl_municipio.Text = "Município:";
            // 
            // txt_municipio_fazenda
            // 
            this.txt_municipio_fazenda.BackColor = System.Drawing.Color.White;
            this.txt_municipio_fazenda.Location = new System.Drawing.Point(493, 288);
            this.txt_municipio_fazenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_municipio_fazenda.MaxLength = 255;
            this.txt_municipio_fazenda.Name = "txt_municipio_fazenda";
            this.txt_municipio_fazenda.Size = new System.Drawing.Size(432, 23);
            this.txt_municipio_fazenda.TabIndex = 26;
            this.txt_municipio_fazenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_municipio_fazenda_KeyPress);
            // 
            // lbl_estado_municipio
            // 
            this.lbl_estado_municipio.AutoSize = true;
            this.lbl_estado_municipio.Location = new System.Drawing.Point(489, 320);
            this.lbl_estado_municipio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado_municipio.Name = "lbl_estado_municipio";
            this.lbl_estado_municipio.Size = new System.Drawing.Size(29, 15);
            this.lbl_estado_municipio.TabIndex = 27;
            this.lbl_estado_municipio.Text = "UF:";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.White;
            this.btn_Inserir.Location = new System.Drawing.Point(1143, 80);
            this.btn_Inserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(100, 25);
            this.btn_Inserir.TabIndex = 30;
            this.btn_Inserir.Text = "Gravar";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.White;
            this.btn_Novo.Location = new System.Drawing.Point(1035, 80);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(100, 25);
            this.btn_Novo.TabIndex = 29;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // Grid_Proprietários
            // 
            this.Grid_Proprietários.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Grid_Proprietários.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Proprietários.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid_Proprietários.Location = new System.Drawing.Point(17, 425);
            this.Grid_Proprietários.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Grid_Proprietários.Name = "Grid_Proprietários";
            this.Grid_Proprietários.ReadOnly = true;
            this.Grid_Proprietários.Size = new System.Drawing.Size(1336, 315);
            this.Grid_Proprietários.TabIndex = 36;
            this.Grid_Proprietários.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Proprietários_CellContentClick);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(1251, 80);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(102, 25);
            this.btn_Sair.TabIndex = 31;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_cadastrar_equipamento
            // 
            this.btn_cadastrar_equipamento.BackColor = System.Drawing.Color.White;
            this.btn_cadastrar_equipamento.Location = new System.Drawing.Point(1035, 133);
            this.btn_cadastrar_equipamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cadastrar_equipamento.Name = "btn_cadastrar_equipamento";
            this.btn_cadastrar_equipamento.Size = new System.Drawing.Size(318, 25);
            this.btn_cadastrar_equipamento.TabIndex = 32;
            this.btn_cadastrar_equipamento.Text = "Cadastrar Equipamento";
            this.btn_cadastrar_equipamento.UseVisualStyleBackColor = false;
            this.btn_cadastrar_equipamento.Click += new System.EventHandler(this.btn_cadastrar_equipamento_Click);
            // 
            // txt_cpf_cnpj
            // 
            this.txt_cpf_cnpj.BackColor = System.Drawing.Color.White;
            this.txt_cpf_cnpj.Location = new System.Drawing.Point(16, 83);
            this.txt_cpf_cnpj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cpf_cnpj.MaxLength = 14;
            this.txt_cpf_cnpj.Name = "txt_cpf_cnpj";
            this.txt_cpf_cnpj.Size = new System.Drawing.Size(468, 23);
            this.txt_cpf_cnpj.TabIndex = 4;
            this.txt_cpf_cnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf_cnpj_KeyPress);
            this.txt_cpf_cnpj.Leave += new System.EventHandler(this.txt_cpf_cnpj_Leave);
            this.txt_cpf_cnpj.Validated += new System.EventHandler(this.txt_cpf_cnpj_Validated);
            // 
            // cmb_estado
            // 
            this.cmb_estado.BackColor = System.Drawing.Color.White;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(493, 82);
            this.cmb_estado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(432, 23);
            this.cmb_estado.TabIndex = 18;
            // 
            // cmb_uf_municipio_fazenda
            // 
            this.cmb_uf_municipio_fazenda.BackColor = System.Drawing.Color.White;
            this.cmb_uf_municipio_fazenda.FormattingEnabled = true;
            this.cmb_uf_municipio_fazenda.Location = new System.Drawing.Point(493, 338);
            this.cmb_uf_municipio_fazenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_uf_municipio_fazenda.Name = "cmb_uf_municipio_fazenda";
            this.cmb_uf_municipio_fazenda.Size = new System.Drawing.Size(432, 23);
            this.cmb_uf_municipio_fazenda.TabIndex = 28;
            // 
            // lbl_nome_tela
            // 
            this.lbl_nome_tela.AutoSize = true;
            this.lbl_nome_tela.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_tela.Location = new System.Drawing.Point(122, 9);
            this.lbl_nome_tela.Name = "lbl_nome_tela";
            this.lbl_nome_tela.Size = new System.Drawing.Size(218, 23);
            this.lbl_nome_tela.TabIndex = 0;
            this.lbl_nome_tela.Text = "Cadastro Proprietário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 728);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 21);
            this.panel1.TabIndex = 37;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_data_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, -3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 24);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_data_hora
            // 
            this.lbl_data_hora.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_hora.Name = "lbl_data_hora";
            this.lbl_data_hora.Size = new System.Drawing.Size(178, 19);
            this.lbl_data_hora.Text = "toolStripStatusLabel1";
            // 
            // lbl_pesquisa_nome
            // 
            this.lbl_pesquisa_nome.AutoSize = true;
            this.lbl_pesquisa_nome.Location = new System.Drawing.Point(1032, 167);
            this.lbl_pesquisa_nome.Name = "lbl_pesquisa_nome";
            this.lbl_pesquisa_nome.Size = new System.Drawing.Size(217, 15);
            this.lbl_pesquisa_nome.TabIndex = 33;
            this.lbl_pesquisa_nome.Text = "Pesquisar Nome do Proprietário:";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.BackColor = System.Drawing.Color.White;
            this.txt_pesquisar.Location = new System.Drawing.Point(1035, 187);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(270, 23);
            this.txt_pesquisar.TabIndex = 34;
            this.txt_pesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisar_KeyPress);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_Pesquisar.Image = global::Projeto3Camadas.Properties.Resources.seo_social_web_network_internet_340_icon_icons1;
            this.btn_Pesquisar.Location = new System.Drawing.Point(1311, 167);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(42, 45);
            this.btn_Pesquisar.TabIndex = 35;
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // Frm_CadastroProprietário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.lbl_pesquisa_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nome_tela);
            this.Controls.Add(this.cmb_uf_municipio_fazenda);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.txt_cpf_cnpj);
            this.Controls.Add(this.btn_cadastrar_equipamento);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.Grid_Proprietários);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.lbl_estado_municipio);
            this.Controls.Add(this.txt_municipio_fazenda);
            this.Controls.Add(this.lbl_municipio);
            this.Controls.Add(this.txt_nome_fazenda);
            this.Controls.Add(this.lbl_nome_fazenda);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.txt_nome_razaosocial);
            this.Controls.Add(this.lbl_nome_razaosocial);
            this.Controls.Add(this.lbl_cpf_cnpj);
            this.Controls.Add(this.txt_id_proprietario);
            this.Controls.Add(this.lbl_id_proprietario);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_CadastroProprietário";
            this.Text = "SCGMT - Sistema de Controle e Gerenciamento das Manutenções em Tratores Agrícolas" +
    "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadastro_Proprietário_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Proprietários)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_proprietario;
        private System.Windows.Forms.TextBox txt_id_proprietario;
        private System.Windows.Forms.Label lbl_cpf_cnpj;
        private System.Windows.Forms.Label lbl_nome_razaosocial;
        private System.Windows.Forms.TextBox txt_nome_razaosocial;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_nome_fazenda;
        private System.Windows.Forms.TextBox txt_nome_fazenda;
        private System.Windows.Forms.Label lbl_municipio;
        private System.Windows.Forms.TextBox txt_municipio_fazenda;
        private System.Windows.Forms.Label lbl_estado_municipio;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.DataGridView Grid_Proprietários;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_cadastrar_equipamento;
        private System.Windows.Forms.TextBox txt_cpf_cnpj;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.ComboBox cmb_uf_municipio_fazenda;
        private System.Windows.Forms.Label lbl_nome_tela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_data_hora;
        private System.Windows.Forms.Label lbl_pesquisa_nome;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}