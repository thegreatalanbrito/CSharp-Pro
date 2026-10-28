/*
 * Creado por SharpDevelop.
 * Usuario: aland
 * Fecha: 27/10/2026
 * Hora: 10:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programa_cool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double num1=Convert.ToDouble(txtN1.Text),num2=Convert.ToDouble(txtN2.Text),resultado;
			resultado=num1+num2;
			lblResultado.Text="El resultado es: "+resultado.ToString();
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double num1=Convert.ToDouble(txtN1.Text),num2=Convert.ToDouble(txtN2.Text),resultado;
			resultado=num1-num2;
			lblResultado.Text="El resultado es: "+resultado.ToString();
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double num1=Convert.ToDouble(txtN1.Text),num2=Convert.ToDouble(txtN2.Text),resultado;
			resultado=num1*num2;
			lblResultado.Text="El resultado es: "+resultado.ToString();
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double num1=Convert.ToDouble(txtN1.Text),num2=Convert.ToDouble(txtN2.Text),resultado;
			resultado=num1/num2;
			lblResultado.Text="El resultado es: "+resultado.ToString();
		}
	}
}
