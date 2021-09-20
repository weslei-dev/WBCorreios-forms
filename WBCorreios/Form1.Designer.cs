
namespace WBCorreios
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
            this.BtBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbComplemento2 = new System.Windows.Forms.TextBox();
            this.TbBairro = new System.Windows.Forms.TextBox();
            this.complemento = new System.Windows.Forms.TextBox();
            this.TbEndereco = new System.Windows.Forms.TextBox();
            this.TbEstado = new System.Windows.Forms.TextBox();
            this.TbCep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(247, 46);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(299, 39);
            this.BtBuscar.TabIndex = 0;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Complemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 8;
            // 
            // TbCidade
            // 
            this.TbCidade.Location = new System.Drawing.Point(12, 414);
            this.TbCidade.Multiline = true;
            this.TbCidade.Name = "TbCidade";
            this.TbCidade.Size = new System.Drawing.Size(454, 28);
            this.TbCidade.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Complemento 2";
            // 
            // TbComplemento2
            // 
            this.TbComplemento2.Location = new System.Drawing.Point(12, 271);
            this.TbComplemento2.Multiline = true;
            this.TbComplemento2.Name = "TbComplemento2";
            this.TbComplemento2.Size = new System.Drawing.Size(454, 28);
            this.TbComplemento2.TabIndex = 11;
            // 
            // TbBairro
            // 
            this.TbBairro.Location = new System.Drawing.Point(12, 345);
            this.TbBairro.Multiline = true;
            this.TbBairro.Name = "TbBairro";
            this.TbBairro.Size = new System.Drawing.Size(454, 28);
            this.TbBairro.TabIndex = 12;
            // 
            // complemento
            // 
            this.complemento.Location = new System.Drawing.Point(15, 198);
            this.complemento.Multiline = true;
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(454, 28);
            this.complemento.TabIndex = 13;
            // 
            // TbEndereco
            // 
            this.TbEndereco.Location = new System.Drawing.Point(12, 131);
            this.TbEndereco.Multiline = true;
            this.TbEndereco.Name = "TbEndereco";
            this.TbEndereco.Size = new System.Drawing.Size(454, 28);
            this.TbEndereco.TabIndex = 14;
            // 
            // TbEstado
            // 
            this.TbEstado.Location = new System.Drawing.Point(12, 496);
            this.TbEstado.Multiline = true;
            this.TbEstado.Name = "TbEstado";
            this.TbEstado.Size = new System.Drawing.Size(454, 28);
            this.TbEstado.TabIndex = 15;
            // 
            // TbCep
            // 
            this.TbCep.Location = new System.Drawing.Point(12, 49);
            this.TbCep.Multiline = true;
            this.TbCep.Name = "TbCep";
            this.TbCep.Size = new System.Drawing.Size(205, 28);
            this.TbCep.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 536);
            this.Controls.Add(this.TbCep);
            this.Controls.Add(this.TbEstado);
            this.Controls.Add(this.TbEndereco);
            this.Controls.Add(this.complemento);
            this.Controls.Add(this.TbBairro);
            this.Controls.Add(this.TbComplemento2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbComplemento2;
        private System.Windows.Forms.TextBox TbBairro;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.TextBox TbEndereco;
        private System.Windows.Forms.TextBox TbEstado;
        private System.Windows.Forms.TextBox TbCep;
    }
}

