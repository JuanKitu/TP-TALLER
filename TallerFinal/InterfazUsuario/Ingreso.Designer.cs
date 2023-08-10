namespace TallerFinal
{
    partial class Ingreso
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
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.labelIngresando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(13, 18);
            this.labelDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(77, 39);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(20, 73);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(573, 46);
            this.textBoxDNI.TabIndex = 1;
            // 
            // labelClave
            // 
            this.labelClave.AccessibleDescription = "Clave de homebanking";
            this.labelClave.AutoSize = true;
            this.labelClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClave.Location = new System.Drawing.Point(13, 149);
            this.labelClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(130, 39);
            this.labelClave.TabIndex = 2;
            this.labelClave.Text = "CLAVE";
            this.labelClave.Click += new System.EventHandler(this.labelClave_Click);
            this.labelClave.MouseEnter += new System.EventHandler(this.ClaveToolTip);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.Location = new System.Drawing.Point(20, 207);
            this.textBoxClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(573, 46);
            this.textBoxClave.TabIndex = 3;
            this.textBoxClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxClave_KeyDown);
            this.textBoxClave.MouseEnter += new System.EventHandler(this.ClaveToolTip);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.Location = new System.Drawing.Point(20, 303);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(573, 62);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "INGRESAR";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // labelIngresando
            // 
            this.labelIngresando.AutoSize = true;
            this.labelIngresando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresando.ForeColor = System.Drawing.Color.Green;
            this.labelIngresando.Location = new System.Drawing.Point(267, 397);
            this.labelIngresando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIngresando.Name = "labelIngresando";
            this.labelIngresando.Size = new System.Drawing.Size(103, 20);
            this.labelIngresando.TabIndex = 5;
            this.labelIngresando.Text = "Ingresando...";
            this.labelIngresando.Visible = false;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 448);
            this.Controls.Add(this.labelIngresando);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.labelDni);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ingreso";
            this.Text = "Identificación de Cliente";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label labelIngresando;
    }
}

