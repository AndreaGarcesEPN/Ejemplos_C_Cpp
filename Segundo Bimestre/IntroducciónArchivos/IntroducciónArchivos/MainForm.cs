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
using System.Text;

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
		void BtnStreamWClick(object sender, EventArgs e)
		{
			string path = txbStreamW.Text;
			Stream writingStream = new FileStream(@path, FileMode.Create);	
			try
			{
				if(writingStream.CanWrite)
				{
					byte[] miNombreEnBites = new byte[]
					{
						65, 110, 100, 114, 101, 97 
					};
					writingStream.Write(miNombreEnBites, 0, miNombreEnBites.Length);
					writingStream.WriteByte(33); // !
					EscribirLog("info", "Escribimos el archivo", dgvLogs);
				}
				else
				{
					EscribirLog("error", "No se puede escribir", dgvLogs);	
				}
				
				writingStream.Close();
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
		}
		void BtnStreamRClick(object sender, EventArgs e)
		{
			string path = txbStreamW.Text;
			try
			{
				using(Stream readingStream = new FileStream(@path, FileMode.Open))
				{
					byte[] arregloTemporal = new byte[3];
					UTF8Encoding codificacion = new UTF8Encoding(true);
					int posicion = readingStream.Read(arregloTemporal, 0, arregloTemporal.Length);
					string caracter = codificacion.GetString(arregloTemporal, 0, arregloTemporal.Length);
					EscribirLog("info", "Caracter: " + caracter, dgvLogs);
				}	
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
				
				/*string path = txbNombre.Text;
				string pathDestino = txbDestino.Text;
				char[] cadenaInicio = path.ToCharArray();
				char[] cadenaDestino = path.ToCharArray();
				
				//Leer Directorios
				
				Directory.Exists(@path);
				
				bool existeDirectorioInicio = Directory.Exists(@path);
				
				if(existeDirectorioInicio == true)
				{
					string[] directoriosInicio = Directory.GetDirectories(@path);
					
					foreach (string directorio in directoriosInicio) 
					{
						//EscribirLog("info", directorio, dgvLogs);
						for(int i = cadenaDestino.Length; i < (cadenaInicio.Length + 1); i++)
						{
							char cadenaPath = cadenaDestino[i];
						}
						//int inicioSubstring = path.Length;
						//int finSubstring = directorio.Length;
						//string nombreDirectorio = directorio.Substring(inicioSubestring, finSubstring);
						EscribirLog("info", cadenaPath, dgvLogs);
					}
						//Crear cada Directorio 
					Directory.CreateDirectory(@path);	
					EscribirLog("info", "Crear Directorio: Se creó el directorio " + path, dgvLogs);
			
					//Leer Archivos
					DirectoryInfo infoDirectorio = new DirectoryInfo(@path);
					FileInfo[] archivosDeDirectorio = Directory.GetFiles(@path);
						
					foreach (FileInfo archivo in archivosDeDirectorio) 
					{
						EscribirLog("info", "Archivo: " + archivo.CreationTime, dgvLogs);
						EscribirLog("info", "Archivo: " + archivo.FullName, dgvLogs);
						EscribirLog("info", "Archivo: " + archivo.Extension, dgvLogs);
						EscribirLog("info", "Archivo: " + archivo.IsReadOnly, dgvLogs);
					}
					
					//Copiar cada Archivo
					DirectoryInfo infoDirectorio = new DirectoryInfo(@path);
					FileInfo[] archivosDirectorio = Directory.GetFiles(@path);
						
					foreach (FileInfo archivo in archivosDirectorio) 
					{
						System.IO.File.Copy(path, pathDestino);
						//StreamWriter copia_archivo = File.Copy(path, pathDestino);
					}
				}
				else
				{
					EscribirLog("error", "No existe directorio.", dgvLogs);
				}*/
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
			
		}
		
	}
}
