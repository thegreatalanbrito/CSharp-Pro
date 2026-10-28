/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 27/10/2026
 * Hora: 10:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programa_cool
{
	/// <summary>
	/// Description of Formula.
	/// </summary>
	public partial class Formula : Form
	{
		public Formula()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a=Convert.ToDouble(txtA.Text),b=Convert.ToDouble(txtB.Text),c=Convert.ToDouble(txtC.Text);
			double discriminante = Math.Pow(b,2)-4*a*c;
			if (discriminante < 0)
			{
				lblX1.Text="Imaginario";
				lblX2.Text="Imaginario";
			}
			else{
				double x1=(-b + Math.Sqrt(discriminante))/(2*a);
				double x2=(-b - Math.Sqrt(discriminante))/(2*a);
				lblX1.Text=x1.ToString();
				lblX2.Text=x2.ToString();
			}
		}
		
		void BtnBackClick(object sender, EventArgs e)
		{
			MainForm l = new MainForm();
			this.Close();
			l.Show();
		}
	}
}
