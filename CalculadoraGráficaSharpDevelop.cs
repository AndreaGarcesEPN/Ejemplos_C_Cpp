/*
 * Created by SharpDevelop.
 * User: USRGAM
 * Date: 12/06/2019
 * Time: 9:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
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
		void CalcularClick(object sender, EventArgs e)
		{
			double valor1 = 0, valor2 = 0, valor3 = 0;
			valor1 = Convert.ToDouble(txtValor1.Text);
			valor2 = Convert.ToDouble(txtValor2.Text);
			
			string operador = cmbOperador.Text;
			switch (operador) {
				case "+":
					valor3 = valor1 + valor2;
					break;
				case "-":
					valor3 = valor1 - valor2;
					break;
				case "*":
					valor3 = valor1 * valor2;
					break;
				case "/":
					valor3 = valor1 / valor2;
					break;
				default:
					valor3 = 0;
					break;
			}
			txtResultado.Text = valor3.ToString();
		}
	}
}
