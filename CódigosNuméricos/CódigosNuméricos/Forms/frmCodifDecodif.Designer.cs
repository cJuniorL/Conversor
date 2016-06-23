namespace CódigosNuméricos.Forms
{
    partial class frmCodifDecodif
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
            this.rbtCodificar = new System.Windows.Forms.RadioButton();
            this.rbtDecod = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnConf = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtBCD = new System.Windows.Forms.RadioButton();
            this.rbtExcess = new System.Windows.Forms.RadioButton();
            this.rbtAyken = new System.Windows.Forms.RadioButton();
            this.rbtJohnson = new System.Windows.Forms.RadioButton();
            this.rbtGray = new System.Windows.Forms.RadioButton();
            this.rbtEntre = new System.Windows.Forms.RadioButton();
            this.rbtKappa = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtCodificar
            // 
            this.rbtCodificar.AutoSize = true;
            this.rbtCodificar.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCodificar.Location = new System.Drawing.Point(157, 25);
            this.rbtCodificar.Name = "rbtCodificar";
            this.rbtCodificar.Size = new System.Drawing.Size(143, 43);
            this.rbtCodificar.TabIndex = 4;
            this.rbtCodificar.TabStop = true;
            this.rbtCodificar.Text = "Codificar";
            this.rbtCodificar.UseVisualStyleBackColor = true;
            this.rbtCodificar.CheckedChanged += new System.EventHandler(this.rbtCodificar_CheckedChanged);
            // 
            // rbtDecod
            // 
            this.rbtDecod.AutoSize = true;
            this.rbtDecod.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDecod.Location = new System.Drawing.Point(316, 25);
            this.rbtDecod.Name = "rbtDecod";
            this.rbtDecod.Size = new System.Drawing.Size(167, 43);
            this.rbtDecod.TabIndex = 5;
            this.rbtDecod.TabStop = true;
            this.rbtDecod.Text = "Decodificar";
            this.rbtDecod.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(390, 165);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(205, 47);
            this.txtValor.TabIndex = 6;
            // 
            // btnConf
            // 
            this.btnConf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConf.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnConf.FlatAppearance.BorderSize = 2;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConf.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf.Location = new System.Drawing.Point(400, 223);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(177, 50);
            this.btnConf.TabIndex = 7;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = false;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(393, 297);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(206, 39);
            this.lblTexto.TabIndex = 8;
            this.lblTexto.Text = "Valor Codificado";
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(289, 349);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(407, 119);
            this.lblValor.TabIndex = 9;
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtCodificar);
            this.panel1.Controls.Add(this.rbtDecod);
            this.panel1.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(188, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 98);
            this.panel1.TabIndex = 10;
            // 
            // rbtBCD
            // 
            this.rbtBCD.AutoSize = true;
            this.rbtBCD.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBCD.Location = new System.Drawing.Point(19, 43);
            this.rbtBCD.Name = "rbtBCD";
            this.rbtBCD.Size = new System.Drawing.Size(173, 43);
            this.rbtBCD.TabIndex = 11;
            this.rbtBCD.TabStop = true;
            this.rbtBCD.Text = "BCD 8421";
            this.rbtBCD.UseVisualStyleBackColor = true;
            // 
            // rbtExcess
            // 
            this.rbtExcess.AutoSize = true;
            this.rbtExcess.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtExcess.Location = new System.Drawing.Point(19, 103);
            this.rbtExcess.Name = "rbtExcess";
            this.rbtExcess.Size = new System.Drawing.Size(154, 43);
            this.rbtExcess.TabIndex = 12;
            this.rbtExcess.TabStop = true;
            this.rbtExcess.Text = "Excesso 3";
            this.rbtExcess.UseVisualStyleBackColor = true;
            // 
            // rbtAyken
            // 
            this.rbtAyken.AutoSize = true;
            this.rbtAyken.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAyken.Location = new System.Drawing.Point(19, 163);
            this.rbtAyken.Name = "rbtAyken";
            this.rbtAyken.Size = new System.Drawing.Size(174, 43);
            this.rbtAyken.TabIndex = 13;
            this.rbtAyken.TabStop = true;
            this.rbtAyken.Text = "Ayken 2421";
            this.rbtAyken.UseVisualStyleBackColor = true;
            // 
            // rbtJohnson
            // 
            this.rbtJohnson.AutoSize = true;
            this.rbtJohnson.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtJohnson.Location = new System.Drawing.Point(19, 223);
            this.rbtJohnson.Name = "rbtJohnson";
            this.rbtJohnson.Size = new System.Drawing.Size(133, 43);
            this.rbtJohnson.TabIndex = 14;
            this.rbtJohnson.TabStop = true;
            this.rbtJohnson.Text = "Johnson";
            this.rbtJohnson.UseVisualStyleBackColor = true;
            // 
            // rbtGray
            // 
            this.rbtGray.AutoSize = true;
            this.rbtGray.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGray.Location = new System.Drawing.Point(19, 283);
            this.rbtGray.Name = "rbtGray";
            this.rbtGray.Size = new System.Drawing.Size(98, 43);
            this.rbtGray.TabIndex = 15;
            this.rbtGray.TabStop = true;
            this.rbtGray.Text = "Gray";
            this.rbtGray.UseVisualStyleBackColor = true;
            // 
            // rbtEntre
            // 
            this.rbtEntre.AutoSize = true;
            this.rbtEntre.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEntre.Location = new System.Drawing.Point(19, 343);
            this.rbtEntre.Name = "rbtEntre";
            this.rbtEntre.Size = new System.Drawing.Size(145, 43);
            this.rbtEntre.TabIndex = 16;
            this.rbtEntre.TabStop = true;
            this.rbtEntre.Text = "2 Entre 5";
            this.rbtEntre.UseVisualStyleBackColor = true;
            // 
            // rbtKappa
            // 
            this.rbtKappa.AutoSize = true;
            this.rbtKappa.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtKappa.Location = new System.Drawing.Point(19, 402);
            this.rbtKappa.Name = "rbtKappa";
            this.rbtKappa.Size = new System.Drawing.Size(115, 43);
            this.rbtKappa.TabIndex = 17;
            this.rbtKappa.TabStop = true;
            this.rbtKappa.Text = "Kappa";
            this.rbtKappa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbtJohnson);
            this.panel2.Controls.Add(this.rbtKappa);
            this.panel2.Controls.Add(this.rbtBCD);
            this.panel2.Controls.Add(this.rbtEntre);
            this.panel2.Controls.Add(this.rbtExcess);
            this.panel2.Controls.Add(this.rbtGray);
            this.panel2.Controls.Add(this.rbtAyken);
            this.panel2.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 558);
            this.panel2.TabIndex = 18;
            // 
            // frmCodifDecodif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(789, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.txtValor);
            this.MaximumSize = new System.Drawing.Size(807, 524);
            this.Name = "frmCodifDecodif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCodifDecodif";
            this.Load += new System.EventHandler(this.frmCodifDecodif_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtCodificar;
        private System.Windows.Forms.RadioButton rbtDecod;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtBCD;
        private System.Windows.Forms.RadioButton rbtExcess;
        private System.Windows.Forms.RadioButton rbtAyken;
        private System.Windows.Forms.RadioButton rbtJohnson;
        private System.Windows.Forms.RadioButton rbtGray;
        private System.Windows.Forms.RadioButton rbtEntre;
        private System.Windows.Forms.RadioButton rbtKappa;
        private System.Windows.Forms.Panel panel2;
    }
}