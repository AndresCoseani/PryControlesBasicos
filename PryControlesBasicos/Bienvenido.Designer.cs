namespace PryControlesBasicos
{
    partial class Bienvenido
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(180, 173);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(446, 76);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(345, 315);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(103, 39);
            this.cmdSiguiente.TabIndex = 1;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "Bienvenido";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button cmdSiguiente;
    }
}