/*
 * Created by SharpDevelop.
 * User: USRGAM
 * Date: 26/06/2019
 * Time: 10:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

enum ColumnaLog {Tipo, Log};

namespace IntroducciónArchivos
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
		void BtnAnadirLogClick(object sender, EventArgs e)
		{
			string log = "Prueba de log";
			string tipo = "info";
			
			int posicionNuevoLog = dgvLogs.Rows.Add();
			
			
			
			dgvLogs.Rows[posicionNuevoLog].Cells[0].Value = tipo;
			dgvLogs.Rows[posicionNuevoLog].Cells[1].Value = log; 
			
			
			//Def cadena de texto
			//Llamar DataGriedView
			//Añadir fila
		}
		void DgvLogsCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			DataGridViewTextBoxCell celdaTipo = (DataGridViewTextBoxCell)dgvLogs.Rows[e.RowIndex].Cells[0];
			DataGridViewTextBoxCell celdaLog = (DataGridViewTextBoxCell)dgvLogs.Rows[e.RowIndex].Cells[1];
			
			if(celdaTipo.Value != null)
			{
			string tipo = celdaTipo.Value.ToString();
			string log = celdaLog.Value.ToString();
			
			MessageBoxIcon icono = MessageBoxIcon.Information;
			MessageBoxButtons botones = MessageBoxButtons.OK;
			
			MessageBox.Show(log, tipo, botones, icono);
			}
		}
		void BtnDirectorioClick(object sender, EventArgs e)
		{
			try
			{ 
				// OK
				string path = txbLeerDirectorio.Text;
				
				DirectoryInfo infoDirectorio = new DirectoryInfo(@path); //using System.IO;
				
				string fechaCreacion = infoDirectorio.CreationTime.ToString();
				string nombreCompleto = infoDirectorio.FullName.ToString();
				string directorioPadre = infoDirectorio.Parent.ToString();
				string directorioRaiz = infoDirectorio.Root.ToString();
				
				EscribirLog("info", fechaCreacion, dgvLogs);
				EscribirLog("info", nombreCompleto, dgvLogs);
				EscribirLog("info", directorioPadre, dgvLogs);
				EscribirLog("info", directorioRaiz, dgvLogs);
				
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
		}
		
		void EscribirLog(string tipo, string log, DataGridView dgv)
		{
			int posicionNuevoLog = dgv.Rows.Add();
			dgv.Rows[posicionNuevoLog].Cells[0].Value = tipo;
			dgv.Rows[posicionNuevoLog].Cells[1].Value = log; 
		}
		
	}
}
