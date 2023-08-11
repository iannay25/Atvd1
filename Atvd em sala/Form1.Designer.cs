namespace Atvd_em_sala
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
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.text_descricao = new System.Windows.Forms.TextBox();
            this.text_valor = new System.Windows.Forms.TextBox();
            this.text_precoaqui = new System.Windows.Forms.TextBox();
            this.text_lucro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cancelar = new System.Windows.Forms.Button();
            this.cadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_codigo
            // 
            this.text_codigo.Location = new System.Drawing.Point(267, 68);
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(202, 20);
            this.text_codigo.TabIndex = 0;
            // 
            // text_descricao
            // 
            this.text_descricao.Location = new System.Drawing.Point(277, 103);
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.Size = new System.Drawing.Size(182, 20);
            this.text_descricao.TabIndex = 1;
            // 
            // text_valor
            // 
            this.text_valor.Location = new System.Drawing.Point(320, 210);
            this.text_valor.Name = "text_valor";
            this.text_valor.Size = new System.Drawing.Size(149, 20);
            this.text_valor.TabIndex = 2;
            // 
            // text_precoaqui
            // 
            this.text_precoaqui.Location = new System.Drawing.Point(307, 142);
            this.text_precoaqui.Name = "text_precoaqui";
            this.text_precoaqui.Size = new System.Drawing.Size(149, 20);
            this.text_precoaqui.TabIndex = 3;
            // 
            // text_lucro
            // 
            this.text_lucro.Location = new System.Drawing.Point(355, 178);
            this.text_lucro.Name = "text_lucro";
            this.text_lucro.Size = new System.Drawing.Size(114, 20);
            this.text_lucro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESCRIÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "VALOR VENDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "CADASTRO DE PRODUTOS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "PORCENTAGEM DE LUCRO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "CÓDIGO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "PREÇO AQUISIÇÃO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(406, 262);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(78, 31);
            this.cancelar.TabIndex = 12;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // cadastro
            // 
            this.cadastro.Location = new System.Drawing.Point(237, 262);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(85, 31);
            this.cadastro.TabIndex = 13;
            this.cadastro.Text = "CADASTRAR";
            this.cadastro.UseVisualStyleBackColor = true;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 481);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_lucro);
            this.Controls.Add(this.text_precoaqui);
            this.Controls.Add(this.text_valor);
            this.Controls.Add(this.text_descricao);
            this.Controls.Add(this.text_codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.TextBox text_descricao;
        private System.Windows.Forms.TextBox text_valor;
        private System.Windows.Forms.TextBox text_precoaqui;
        private System.Windows.Forms.TextBox text_lucro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button cadastro;
    }
}

