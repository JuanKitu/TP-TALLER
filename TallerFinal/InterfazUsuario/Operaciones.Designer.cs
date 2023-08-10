namespace TallerFinal.InterfazUsuario
{
    partial class Operaciones
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonBlanqueo = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSinTarjetas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(13, 9);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(226, 25);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "BIENVENIDO, {Nombre}";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // buttonBlanqueo
            // 
            this.buttonBlanqueo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBlanqueo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlanqueo.Location = new System.Drawing.Point(18, 84);
            this.buttonBlanqueo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBlanqueo.Name = "buttonBlanqueo";
            this.buttonBlanqueo.Size = new System.Drawing.Size(450, 54);
            this.buttonBlanqueo.TabIndex = 1;
            this.buttonBlanqueo.Text = "BLANQUEO DE PIN";
            this.buttonBlanqueo.UseVisualStyleBackColor = false;
            this.buttonBlanqueo.Click += new System.EventHandler(this.buttonBlanqueo_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.Red;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(18, 332);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(450, 50);
            this.buttonCerrarSesion.TabIndex = 5;
            this.buttonCerrarSesion.Text = "CERRAR SESION";
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPERACIONES DISPONIBLES";
            // 
            // labelSinTarjetas
            // 
            this.labelSinTarjetas.AutoSize = true;
            this.labelSinTarjetas.ForeColor = System.Drawing.Color.Maroon;
            this.labelSinTarjetas.Location = new System.Drawing.Point(148, 281);
            this.labelSinTarjetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinTarjetas.Name = "labelSinTarjetas";
            this.labelSinTarjetas.Size = new System.Drawing.Size(226, 17);
            this.labelSinTarjetas.TabIndex = 4;
            this.labelSinTarjetas.Text = "Usted no tiene tarjetas disponibles";
            this.labelSinTarjetas.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "SALDO DE CUENTA CORRIENTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.balance_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(450, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "ULTIMOS MOVIMIENTOS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ultimosMov_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Desconectar);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 402);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSinTarjetas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonBlanqueo);
            this.Controls.Add(this.labelNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.Click += new System.EventHandler(this.ClickEnVentana);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonBlanqueo;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSinTarjetas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}