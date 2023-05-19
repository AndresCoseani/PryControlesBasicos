namespace PryControlesBasicos
{
    partial class Secundario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.lblTextofinal = new System.Windows.Forms.Label();
            this.cboagregado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPicante.Location = new System.Drawing.Point(96, 220);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(74, 21);
            this.chkPicante.TabIndex = 0;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            this.chkPicante.CheckedChanged += new System.EventHandler(this.chkPicante_CheckedChanged);
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayonesa.Location = new System.Drawing.Point(96, 247);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(92, 21);
            this.chkMayonesa.TabIndex = 1;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            this.chkMayonesa.CheckedChanged += new System.EventHandler(this.chkMayonesa_CheckedChanged);
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKetchup.Location = new System.Drawing.Point(97, 274);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(79, 21);
            this.chkKetchup.TabIndex = 2;
            this.chkKetchup.Text = "Ketchup";
            this.chkKetchup.UseVisualStyleBackColor = true;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Location = new System.Drawing.Point(96, 301);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 3;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(213, 384);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 17);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultados";
            // 
            // txtIngresar
            // 
            this.txtIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresar.Location = new System.Drawing.Point(116, 34);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(476, 23);
            this.txtIngresar.TabIndex = 5;
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRojo.Location = new System.Drawing.Point(183, 86);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(55, 21);
            this.optRojo.TabIndex = 6;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAzul.Location = new System.Drawing.Point(278, 86);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(53, 21);
            this.optAzul.TabIndex = 7;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAsignar.Location = new System.Drawing.Point(372, 82);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(67, 29);
            this.cmdAsignar.TabIndex = 8;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // lblTextofinal
            // 
            this.lblTextofinal.AutoSize = true;
            this.lblTextofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextofinal.Location = new System.Drawing.Point(243, 141);
            this.lblTextofinal.Name = "lblTextofinal";
            this.lblTextofinal.Size = new System.Drawing.Size(235, 20);
            this.lblTextofinal.TabIndex = 9;
            this.lblTextofinal.Text = "El texto escrito figurarà aqui";
            // 
            // cboagregado
            // 
            this.cboagregado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboagregado.FormattingEnabled = true;
            this.cboagregado.Location = new System.Drawing.Point(96, 330);
            this.cboagregado.Name = "cboagregado";
            this.cboagregado.Size = new System.Drawing.Size(92, 21);
            this.cboagregado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.cboagregado);
            this.Controls.Add(this.lblTextofinal);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.txtIngresar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.chkKetchup);
            this.Controls.Add(this.chkMayonesa);
            this.Controls.Add(this.chkPicante);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.Label lblTextofinal;
        private System.Windows.Forms.ComboBox cboagregado;
    }
}

