namespace PROYECTOPVA
{
    partial class FRMPadreMantenimientos
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(558, 368);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUsuarios.Location = new System.Drawing.Point(558, 176);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(213, 37);
            this.btnUsuarios.TabIndex = 22;
            this.btnUsuarios.Text = "Guardar";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPass.Location = new System.Drawing.Point(558, 242);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(213, 37);
            this.btnPass.TabIndex = 21;
            this.btnPass.Text = "Eliminar";
            this.btnPass.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.Location = new System.Drawing.Point(558, 111);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(213, 37);
            this.btnMenu.TabIndex = 20;
            this.btnMenu.Text = "Consultar";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSesion.Location = new System.Drawing.Point(558, 305);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(213, 37);
            this.btnSesion.TabIndex = 19;
            this.btnSesion.Text = "Nuevo";
            this.btnSesion.UseVisualStyleBackColor = false;
            // 
            // FRMPadreMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSesion);
            this.Name = "FRMPadreMantenimientos";
            this.Text = "FRMMantenimientos";
            this.Load += new System.EventHandler(this.FRMMantenimientos_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnSesion, 0);
            this.Controls.SetChildIndex(this.btnMenu, 0);
            this.Controls.SetChildIndex(this.btnPass, 0);
            this.Controls.SetChildIndex(this.btnUsuarios, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSesion;
    }
}