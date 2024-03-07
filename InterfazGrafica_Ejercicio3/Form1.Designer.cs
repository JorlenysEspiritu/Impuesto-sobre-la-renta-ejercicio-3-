namespace InterfazGrafica_Ejercicio8
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMensaje = new TextBox();
            txtIsr = new TextBox();
            txtSfs = new TextBox();
            txtAfp = new TextBox();
            txtSueldo = new TextBox();
            btnEvaluar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Wide Latin", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(682, 29);
            label1.TabIndex = 0;
            label1.Text = "IMPUESTO SOBRE LA RENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 210);
            label2.Name = "label2";
            label2.Size = new Size(50, 30);
            label2.TabIndex = 1;
            label2.Text = "AFP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 136);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 2;
            label3.Text = "Sueldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(131, 272);
            label4.Name = "label4";
            label4.Size = new Size(48, 30);
            label4.TabIndex = 3;
            label4.Text = "SFS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(119, 404);
            label5.Name = "label5";
            label5.Size = new Size(94, 30);
            label5.TabIndex = 4;
            label5.Text = "Mensaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(129, 328);
            label6.Name = "label6";
            label6.Size = new Size(44, 30);
            label6.TabIndex = 5;
            label6.Text = "ISR";
            // 
            // txtMensaje
            // 
            txtMensaje.Enabled = false;
            txtMensaje.Location = new Point(213, 401);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(150, 31);
            txtMensaje.TabIndex = 6;
            // 
            // txtIsr
            // 
            txtIsr.Enabled = false;
            txtIsr.Location = new Point(213, 328);
            txtIsr.Name = "txtIsr";
            txtIsr.Size = new Size(150, 31);
            txtIsr.TabIndex = 7;
            // 
            // txtSfs
            // 
            txtSfs.Enabled = false;
            txtSfs.Location = new Point(213, 269);
            txtSfs.Name = "txtSfs";
            txtSfs.Size = new Size(150, 31);
            txtSfs.TabIndex = 8;
            // 
            // txtAfp
            // 
            txtAfp.Enabled = false;
            txtAfp.Location = new Point(213, 204);
            txtAfp.Name = "txtAfp";
            txtAfp.Size = new Size(150, 31);
            txtAfp.TabIndex = 9;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(213, 136);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(150, 31);
            txtSueldo.TabIndex = 10;
            // 
            // btnEvaluar
            // 
            btnEvaluar.BackColor = Color.FromArgb(0, 192, 0);
            btnEvaluar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvaluar.ForeColor = Color.White;
            btnEvaluar.Location = new Point(524, 158);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(147, 47);
            btnEvaluar.TabIndex = 11;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = false;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 192, 0);
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(524, 234);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(147, 48);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(524, 305);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(147, 48);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEvaluar);
            Controls.Add(txtSueldo);
            Controls.Add(txtAfp);
            Controls.Add(txtSfs);
            Controls.Add(txtIsr);
            Controls.Add(txtMensaje);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private TextBox txtMensaje;
        private TextBox txtIsr;
        private TextBox txtSfs;
        private TextBox txtAfp;
        private TextBox txtSueldo;
        private Button btnEvaluar;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}