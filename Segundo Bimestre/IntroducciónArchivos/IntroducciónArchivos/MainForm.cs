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
			
			EscribirLog(tipo, log, dgvLogs);
			
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
			
			if(tipo == "error")
			{
				icono = MessageBoxIcon.Error;
			}
			else
			{
				icono = MessageBoxIcon.Information;
			}
			
			
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
				
				EscribirLog("info", "Leyendo directorio: " + fechaCreacion, dgvLogs);
				EscribirLog("info", "Leyendo directorio: " + nombreCompleto, dgvLogs);
				EscribirLog("info", "Leyendo directorio: " + directorioPadre, dgvLogs);
				EscribirLog("info", "Leyendo directorio: " + directorioRaiz, dgvLogs);
				
				FileInfo[] archivosDeDirectorio = infoDirectorio.GetFiles();
				
				foreach (FileInfo archivo in archivosDeDirectorio) 
				{
					EscribirLog("info", "Archivo: " + archivo.CreationTime, dgvLogs);
					EscribirLog("info", "Archivo: " + archivo.FullName, dgvLogs);
					EscribirLog("info", "Archivo: " + archivo.Extension, dgvLogs);
					EscribirLog("info", "Archivo: " + archivo.LastAccessTime, dgvLogs);
					EscribirLog("info", "Archivo: " + archivo.IsReadOnly, dgvLogs);
				}
				
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
			
			if(tipo == "error")
			{
				dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.Red;	
			}
			else
			{
				dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.Aquamarine;
			}
		}
		void BtnListarDirectorioClick(object sender, EventArgs e)
		{
			try
			{
				string path = txbListarDirectorio.Text;
				string[] arregloDirectorios = Directory.GetDirectories(@path);
				int numeroDirectorios = arregloDirectorios.Length;
				EscribirLog("info", "Número de Directorios " + numeroDirectorios.ToString(), dgvLogs);
				
				foreach (string directorio in arregloDirectorios) 
				{
					EscribirLog("info", "Directorio: " + directorio, dgvLogs);
				}
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
		}
		
	}
}
