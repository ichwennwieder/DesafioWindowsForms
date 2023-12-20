namespace DesafioWindowsForms
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
            lbNumero = new Label();
            txtNumero = new TextBox();
            btnNumero = new Button();
            lbData = new Label();
            calData = new MonthCalendar();
            btData = new Button();
            btTemperatura = new Button();
            txtTemperatura = new TextBox();
            lbTemperatura = new Label();
            btPositivo = new Button();
            label1 = new Label();
            btNegativo = new Button();
            SuspendLayout();
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(12, 9);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(121, 15);
            lbNumero.TabIndex = 0;
            lbNumero.Text = "INSIRA UM NÚMERO:";
            lbNumero.Click += label1_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 27);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnNumero
            // 
            btnNumero.Location = new Point(139, 27);
            btnNumero.Name = "btnNumero";
            btnNumero.Size = new Size(75, 23);
            btnNumero.TabIndex = 2;
            btnNumero.Text = "Verificar";
            btnNumero.UseVisualStyleBackColor = true;
            btnNumero.Click += btnNumero_Click;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(12, 77);
            lbData.Name = "lbData";
            lbData.Size = new Size(107, 15);
            lbData.TabIndex = 3;
            lbData.Text = "INSIRA UMA DATA:";
            // 
            // calData
            // 
            calData.Location = new Point(12, 101);
            calData.MaxSelectionCount = 1;
            calData.Name = "calData";
            calData.TabIndex = 4;
            // 
            // btData
            // 
            btData.Location = new Point(12, 275);
            btData.Name = "btData";
            btData.Size = new Size(75, 23);
            btData.TabIndex = 5;
            btData.Text = "Verificar";
            btData.UseVisualStyleBackColor = true;
            btData.Click += btData_Click;
            // 
            // btTemperatura
            // 
            btTemperatura.Location = new Point(480, 28);
            btTemperatura.Name = "btTemperatura";
            btTemperatura.Size = new Size(75, 23);
            btTemperatura.TabIndex = 8;
            btTemperatura.Text = "Verificar";
            btTemperatura.UseVisualStyleBackColor = true;
            btTemperatura.Click += btTemperatura_Click;
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(333, 28);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(141, 23);
            txtTemperatura.TabIndex = 7;
            // 
            // lbTemperatura
            // 
            lbTemperatura.AutoSize = true;
            lbTemperatura.Location = new Point(333, 9);
            lbTemperatura.Name = "lbTemperatura";
            lbTemperatura.Size = new Size(222, 15);
            lbTemperatura.TabIndex = 6;
            lbTemperatura.Text = "DIGITE UMA TEMPERATURA EM CELSIUS:";
            // 
            // btPositivo
            // 
            btPositivo.Location = new Point(333, 128);
            btPositivo.Name = "btPositivo";
            btPositivo.Size = new Size(75, 23);
            btPositivo.TabIndex = 11;
            btPositivo.Text = "Positivo";
            btPositivo.UseVisualStyleBackColor = true;
            btPositivo.Click += btPositivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 101);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 9;
            label1.Text = " [ -34, 77, -89, -25, -19, 14, -20, 46, -32, 91 ]";
            // 
            // btNegativo
            // 
            btNegativo.Location = new Point(414, 128);
            btNegativo.Name = "btNegativo";
            btNegativo.Size = new Size(75, 23);
            btNegativo.TabIndex = 12;
            btNegativo.Text = "Negativo";
            btNegativo.UseVisualStyleBackColor = true;
            btNegativo.Click += btNegativo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 314);
            Controls.Add(btNegativo);
            Controls.Add(btPositivo);
            Controls.Add(label1);
            Controls.Add(btTemperatura);
            Controls.Add(txtTemperatura);
            Controls.Add(lbTemperatura);
            Controls.Add(btData);
            Controls.Add(calData);
            Controls.Add(lbData);
            Controls.Add(btnNumero);
            Controls.Add(txtNumero);
            Controls.Add(lbNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumero;
        private TextBox txtNumero;
        private Button btnNumero;
        private Label lbData;
        private MonthCalendar calData;
        private Button btData;
        private Button btTemperatura;
        private TextBox txtTemperatura;
        private Label lbTemperatura;
        private Button btPositivo;
        private Label label1;
        private Button btNegativo;
    }
}
