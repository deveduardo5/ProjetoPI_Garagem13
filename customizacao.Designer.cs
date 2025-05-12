namespace garagem13
{
    partial class TelaCustomizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCustomizacao));
            buttonVoltarC = new Button();
            buttonCriarPedidoC = new Button();
            groupBoxCustomizacao = new GroupBox();
            textBoxTotal = new TextBox();
            label1 = new Label();
            comboBoxMotor = new ComboBox();
            comboBoxCor = new ComboBox();
            comboBoxQuadro = new ComboBox();
            comboBoxAro = new ComboBox();
            labelMotorizacao = new Label();
            labelCor = new Label();
            labelQuadro = new Label();
            labelAro = new Label();
            dataGridViewCustomizacao = new DataGridView();
            PEDIDOS = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBoxCustomizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomizacao).BeginInit();
            PEDIDOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonVoltarC
            // 
            buttonVoltarC.BackColor = SystemColors.ScrollBar;
            buttonVoltarC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltarC.Location = new Point(6, 348);
            buttonVoltarC.Margin = new Padding(3, 4, 3, 4);
            buttonVoltarC.Name = "buttonVoltarC";
            buttonVoltarC.Size = new Size(130, 30);
            buttonVoltarC.TabIndex = 3;
            buttonVoltarC.Text = "Voltar";
            buttonVoltarC.UseVisualStyleBackColor = false;
            buttonVoltarC.Click += buttonVoltarC_Click;
            // 
            // buttonCriarPedidoC
            // 
            buttonCriarPedidoC.BackColor = SystemColors.ScrollBar;
            buttonCriarPedidoC.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarPedidoC.Location = new Point(204, 348);
            buttonCriarPedidoC.Margin = new Padding(3, 4, 3, 4);
            buttonCriarPedidoC.Name = "buttonCriarPedidoC";
            buttonCriarPedidoC.Size = new Size(222, 30);
            buttonCriarPedidoC.TabIndex = 2;
            buttonCriarPedidoC.Text = "Criar Customização";
            buttonCriarPedidoC.UseVisualStyleBackColor = false;
            buttonCriarPedidoC.Click += buttonCriarPedidoC_Click;
            // 
            // groupBoxCustomizacao
            // 
            groupBoxCustomizacao.BackColor = SystemColors.ScrollBar;
            groupBoxCustomizacao.Controls.Add(textBoxTotal);
            groupBoxCustomizacao.Controls.Add(label1);
            groupBoxCustomizacao.Controls.Add(comboBoxMotor);
            groupBoxCustomizacao.Controls.Add(comboBoxCor);
            groupBoxCustomizacao.Controls.Add(comboBoxQuadro);
            groupBoxCustomizacao.Controls.Add(comboBoxAro);
            groupBoxCustomizacao.Controls.Add(labelMotorizacao);
            groupBoxCustomizacao.Controls.Add(labelCor);
            groupBoxCustomizacao.Controls.Add(labelQuadro);
            groupBoxCustomizacao.Controls.Add(labelAro);
            groupBoxCustomizacao.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxCustomizacao.Location = new Point(6, 16);
            groupBoxCustomizacao.Margin = new Padding(3, 4, 3, 4);
            groupBoxCustomizacao.Name = "groupBoxCustomizacao";
            groupBoxCustomizacao.Padding = new Padding(3, 4, 3, 4);
            groupBoxCustomizacao.Size = new Size(420, 324);
            groupBoxCustomizacao.TabIndex = 4;
            groupBoxCustomizacao.TabStop = false;
            groupBoxCustomizacao.Text = "Customização";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Enabled = false;
            textBoxTotal.Font = new Font("Segoe UI", 9F);
            textBoxTotal.Location = new Point(264, 286);
            textBoxTotal.Margin = new Padding(3, 4, 3, 4);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(134, 27);
            textBoxTotal.TabIndex = 8;
            textBoxTotal.Text = "R$ 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 292);
            label1.Name = "label1";
            label1.Size = new Size(108, 18);
            label1.TabIndex = 5;
            label1.Text = "Valor Total:";
            // 
            // comboBoxMotor
            // 
            comboBoxMotor.Font = new Font("Segoe UI", 9F);
            comboBoxMotor.FormattingEnabled = true;
            comboBoxMotor.Location = new Point(82, 186);
            comboBoxMotor.Margin = new Padding(3, 4, 3, 4);
            comboBoxMotor.Name = "comboBoxMotor";
            comboBoxMotor.Size = new Size(332, 28);
            comboBoxMotor.TabIndex = 7;
            comboBoxMotor.SelectedIndexChanged += comboBoxMotor_SelectedIndexChanged;
            // 
            // comboBoxCor
            // 
            comboBoxCor.Font = new Font("Segoe UI", 9F);
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(82, 142);
            comboBoxCor.Margin = new Padding(3, 4, 3, 4);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(332, 28);
            comboBoxCor.TabIndex = 6;
            comboBoxCor.SelectedIndexChanged += comboBoxCor_SelectedIndexChanged;
            // 
            // comboBoxQuadro
            // 
            comboBoxQuadro.Font = new Font("Segoe UI", 9F);
            comboBoxQuadro.FormattingEnabled = true;
            comboBoxQuadro.Location = new Point(82, 95);
            comboBoxQuadro.Margin = new Padding(3, 4, 3, 4);
            comboBoxQuadro.Name = "comboBoxQuadro";
            comboBoxQuadro.Size = new Size(332, 28);
            comboBoxQuadro.TabIndex = 5;
            comboBoxQuadro.SelectedIndexChanged += comboBoxQuadro_SelectedIndexChanged;
            // 
            // comboBoxAro
            // 
            comboBoxAro.Font = new Font("Segoe UI", 9F);
            comboBoxAro.FormattingEnabled = true;
            comboBoxAro.Location = new Point(82, 51);
            comboBoxAro.Margin = new Padding(3, 4, 3, 4);
            comboBoxAro.Name = "comboBoxAro";
            comboBoxAro.Size = new Size(332, 28);
            comboBoxAro.TabIndex = 4;
            comboBoxAro.SelectedIndexChanged += comboBoxAro_SelectedIndexChanged;
            // 
            // labelMotorizacao
            // 
            labelMotorizacao.AutoSize = true;
            labelMotorizacao.Location = new Point(17, 189);
            labelMotorizacao.Name = "labelMotorizacao";
            labelMotorizacao.Size = new Size(59, 18);
            labelMotorizacao.TabIndex = 3;
            labelMotorizacao.Text = "Motor";
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(39, 145);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(37, 18);
            labelCor.TabIndex = 2;
            labelCor.Text = "Cor";
            // 
            // labelQuadro
            // 
            labelQuadro.AutoSize = true;
            labelQuadro.Location = new Point(9, 98);
            labelQuadro.Name = "labelQuadro";
            labelQuadro.Size = new Size(67, 18);
            labelQuadro.TabIndex = 1;
            labelQuadro.Text = "Quadro";
            // 
            // labelAro
            // 
            labelAro.AutoSize = true;
            labelAro.Location = new Point(39, 54);
            labelAro.Name = "labelAro";
            labelAro.Size = new Size(37, 18);
            labelAro.TabIndex = 0;
            labelAro.Text = "Aro";
            // 
            // dataGridViewCustomizacao
            // 
            dataGridViewCustomizacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomizacao.Location = new Point(5, 27);
            dataGridViewCustomizacao.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCustomizacao.Name = "dataGridViewCustomizacao";
            dataGridViewCustomizacao.RowHeadersWidth = 62;
            dataGridViewCustomizacao.Size = new Size(500, 187);
            dataGridViewCustomizacao.TabIndex = 5;
            // 
            // PEDIDOS
            // 
            PEDIDOS.BackColor = Color.Transparent;
            PEDIDOS.BackgroundImage = (Image)resources.GetObject("PEDIDOS.BackgroundImage");
            PEDIDOS.Controls.Add(dataGridViewCustomizacao);
            PEDIDOS.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PEDIDOS.Location = new Point(431, 16);
            PEDIDOS.Margin = new Padding(2);
            PEDIDOS.Name = "PEDIDOS";
            PEDIDOS.Padding = new Padding(2);
            PEDIDOS.Size = new Size(510, 227);
            PEDIDOS.TabIndex = 6;
            PEDIDOS.TabStop = false;
            PEDIDOS.Text = "LISTA DE PEDIDOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-381, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(5000, 3334);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(596, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // TelaCustomizacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(946, 394);
            Controls.Add(pictureBox2);
            Controls.Add(PEDIDOS);
            Controls.Add(groupBoxCustomizacao);
            Controls.Add(buttonVoltarC);
            Controls.Add(buttonCriarPedidoC);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCustomizacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customizacao";
            Load += TelaCustomizacao_Load;
            groupBoxCustomizacao.ResumeLayout(false);
            groupBoxCustomizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomizacao).EndInit();
            PEDIDOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltarC;
        private Button buttonCriarPedidoC;
        private GroupBox groupBoxCustomizacao;
        private ComboBox comboBoxMotor;
        private ComboBox comboBoxCor;
        private ComboBox comboBoxQuadro;
        private ComboBox comboBoxAro;
        private Label labelMotorizacao;
        private Label labelCor;
        private Label labelQuadro;
        private Label labelAro;
        private Label label1;
        private TextBox textBoxTotal;
        private DataGridView dataGridViewCustomizacao;
        private GroupBox PEDIDOS;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}