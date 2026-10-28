/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 27/10/2026
 * Hora: 10:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Programa_cool
{
	partial class Formula
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblLol = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblX1 = new System.Windows.Forms.Label();
			this.lblX2 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(12, 84);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(248, 42);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblLol
			// 
			this.lblLol.Location = new System.Drawing.Point(13, 133);
			this.lblLol.Name = "lblLol";
			this.lblLol.Size = new System.Drawing.Size(48, 25);
			this.lblLol.TabIndex = 2;
			this.lblLol.Text = "X1:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Lado A:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(212, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Lado C:";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(13, 40);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(48, 20);
			this.txtA.TabIndex = 5;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(212, 40);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(48, 20);
			this.txtC.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(111, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Lado B:";
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(111, 40);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(48, 20);
			this.txtB.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(158, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "X2:";
			// 
			// lblX1
			// 
			this.lblX1.Location = new System.Drawing.Point(12, 158);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(103, 94);
			this.lblX1.TabIndex = 10;
			// 
			// lblX2
			// 
			this.lblX2.Location = new System.Drawing.Point(158, 158);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(102, 94);
			this.lblX2.TabIndex = 11;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(111, 190);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(48, 59);
			this.btnBack.TabIndex = 12;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// Formula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLol);
			this.Controls.Add(this.btnCalcular);
			this.Name = "Formula";
			this.Text = "Formula";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblLol;
		private System.Windows.Forms.Button btnCalcular;
	}
}
