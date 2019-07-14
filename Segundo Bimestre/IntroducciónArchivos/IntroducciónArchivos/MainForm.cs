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
		void BtnCrearArchivoClick(object sender, EventArgs e)
		{
			//Se está fuera del código utilizado
			try
			{
				string path = txbCrearArchivo.Text;
				StreamWriter escritura = File.CreateText(@path);
				escritura.WriteLine("Hola archivo");
				escritura.WriteLine("Segunda linea");
				escritura.WriteLine("Tercera linea");
				
				escritura.Close();
				
				using(StreamWriter escritura2 = File.CreateText(@path))
				{
					escritura2.WriteLine("Hola archivo");
					escritura2.WriteLine("Segunda linea");
					escritura2.WriteLine("Tercera linea");
				}
				
				EscribirLog("info", "Escritura Archivo: Se escribió el archivo", dgvLogs);
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
		}
		void BtnCrearDirectorioClick(object sender, EventArgs e)
		{
			try
			{
				string path = txbCrearDirectorio.Text;
				Directory.CreateDirectory(@path);
				EscribirLog("info", "Crear Directorio: Se creó el directorio " + path, dgvLogs);
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
		}
		void BtnCopiarDirectorioClick(object sender, EventArgs e)
		{
			try
			{
				//Leer Directorios
				
				string path = txbNombre.Text;
				DirectoryInfo directory = new DirectoryInfo(@path);
				string[] directorios = Directory.GetDirectories(@path);
				FileInfo[] archivos = directory.GetFiles();
				int numDirectorios = directorios.Length;
				
				if(Directory.Exists(@path))
				{
					foreach (string directorio in directorios) 
					{
						EscribirLog("Subdirectorio", "Directorio: " + directorio, dgvLogs);
					}
				}
				else
				{
					EscribirLog("Error", "No se encontro el directorio", dgvLogs);
				}
				
				//Crear cada directorio
				
				string pathfinal = txbDestino.Text;
				Directory.CreateDirectory(@pathfinal);
				EscribirLog("Info", "Directorio creado exitosamente", dgvLogs);
				
				//Leer archivos
				
				foreach (FileInfo archivo in archivos) 
				{
					EscribirLog("Archivos", "Archivo: " + archivo, dgvLogs);
				}
				
				//Copiar cada archivo
				
				foreach (FileInfo archivo in archivos) 
				{
					string patharchivo = Path.Combine(@pathfinal, archivo.Name);
					archivo.CopyTo(patharchivo, false);
				}
				EscribirLog("Info", "Archivos copiados exitosamente", dgvLogs);
			}
			catch(Exception error)
			{
				EscribirLog("Error", error.ToString(), dgvLogs);
			}
			
		}
		
	}
}
