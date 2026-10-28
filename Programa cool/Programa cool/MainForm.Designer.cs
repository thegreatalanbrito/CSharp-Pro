/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 27/10/2026
 * Hora: 10:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Programa_cool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.txtN1 = new System.Windows.Forms.TextBox();
			this.txtN2 = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(124, 177);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(102, 57);
			this.btnDividir.TabIndex = 0;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(12, 99);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(102, 57);
			this.btnSuma.TabIndex = 1;
			this.btnSuma.Text = "Sumar";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(12, 177);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(102, 57);
			this.btnMultiplicar.TabIndex = 2;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(120, 99);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(106, 57);
			this.btnRestar.TabIndex = 3;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// txtN1
			// 
			this.txtN1.Location = new System.Drawing.Point(12, 12);
			this.txtN1.Name = "txtN1";
			this.txtN1.Size = new System.Drawing.Size(54, 20);
			this.txtN1.TabIndex = 4;
			// 
			// txtN2
			// 
			this.txtN2.Location = new System.Drawing.Point(170, 12);
			this.txtN2.Name = "txtN2";
			this.txtN2.Size = new System.Drawing.Size(54, 20);
			this.txtN2.TabIndex = 5;
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(12, 59);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(212, 34);
			this.lblResultado.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 262);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtN2);
			this.Controls.Add(this.txtN1);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.btnDividir);
			this.Name = "MainForm";
			this.Text = "Programa cool";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtN2;
		private System.Windows.Forms.TextBox txtN1;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Button btnDividir;
	}
}
