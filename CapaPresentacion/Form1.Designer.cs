namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbDocumento = new TextBox();
            tbPlazoSolicitado = new TextBox();
            tbIngresosTotales = new TextBox();
            tbEgresosTotales = new TextBox();
            tbMontoSolicitado = new TextBox();
            cbTipoDocumento = new ComboBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 41);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 106);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Nro de documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 172);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Plazo credito";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 231);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 4;
            label4.Text = "Ingresos totales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 290);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 5;
            label5.Text = "Egresos totales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 347);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 6;
            label6.Text = "Monto solicitado";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(210, 99);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(193, 27);
            tbDocumento.TabIndex = 7;
            // 
            // tbPlazoSolicitado
            // 
            tbPlazoSolicitado.Location = new Point(210, 165);
            tbPlazoSolicitado.Name = "tbPlazoSolicitado";
            tbPlazoSolicitado.Size = new Size(193, 27);
            tbPlazoSolicitado.TabIndex = 8;
            // 
            // tbIngresosTotales
            // 
            tbIngresosTotales.Location = new Point(210, 224);
            tbIngresosTotales.Name = "tbIngresosTotales";
            tbIngresosTotales.Size = new Size(193, 27);
            tbIngresosTotales.TabIndex = 9;
            // 
            // tbEgresosTotales
            // 
            tbEgresosTotales.Location = new Point(210, 287);
            tbEgresosTotales.Name = "tbEgresosTotales";
            tbEgresosTotales.Size = new Size(193, 27);
            tbEgresosTotales.TabIndex = 10;
            // 
            // tbMontoSolicitado
            // 
            tbMontoSolicitado.Location = new Point(210, 344);
            tbMontoSolicitado.Name = "tbMontoSolicitado";
            tbMontoSolicitado.Size = new Size(193, 27);
            tbMontoSolicitado.TabIndex = 11;
            // 
            // cbTipoDocumento
            // 
            cbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDocumento.FormattingEnabled = true;
            cbTipoDocumento.Items.AddRange(new object[] { "Cédula ciudadanía", "Tarjeta de identidad", "Tarjeta de extranjería" });
            cbTipoDocumento.Location = new Point(210, 38);
            cbTipoDocumento.Name = "cbTipoDocumento";
            cbTipoDocumento.Size = new Size(193, 28);
            cbTipoDocumento.TabIndex = 12;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(130, 414);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(188, 29);
            btnVerificar.TabIndex = 13;
            btnVerificar.Text = "Verificar viabilidad";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 490);
            Controls.Add(btnVerificar);
            Controls.Add(cbTipoDocumento);
            Controls.Add(tbMontoSolicitado);
            Controls.Add(tbEgresosTotales);
            Controls.Add(tbIngresosTotales);
            Controls.Add(tbPlazoSolicitado);
            Controls.Add(tbDocumento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Preaprobación Crédito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbDocumento;
        private TextBox tbPlazoSolicitado;
        private TextBox tbIngresosTotales;
        private TextBox tbEgresosTotales;
        private TextBox tbMontoSolicitado;
        private ComboBox cbTipoDocumento;
        private Button btnVerificar;
    }
}
