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
				//Leer Directorios
				
				string path = txbNombre.Text;
				DirectoryInfo directory = new DirectoryInfo(@path);
				string[] directorios = Directory.GetDirectories(@path);
				FileInfo[] archivos = directory.GetFiles();
				int numDirectorios = directorios.Length;
				
				if (Directory.Exists(@path)) 
				{
					foreach (string directorio in directorios) 
					{
						EscribirLog("Subdirectorio", "Directorio: " + directorio, dgvLogs);
					}
				}
				else
				{
					EscribirLog("error", "No se encontro el directorio", dgvLogs);
				}
				
				//Crear cada directorio
				
				string pathfinal = txbDestino.Text;
				Directory.CreateDirectory(@pathfinal);
				EscribirLog("info", "Directorio creado exitosamente", dgvLogs);
				
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
				EscribirLog("info", "Archivos copiados exitosamente", dgvLogs);
				
				//Recursividad
				
				/*foreach (string directorio in directorios) 
				{
					BtnCopiarDirectorioClick(object directorio, EventArgs e)
				}*/
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(), dgvLogs);
			}
			
		}
		void BtnOrdenarArregloBSClick(object sender, EventArgs e)
		{
			string arregloTexto = txbArreglo.Text;
			string[] elementosString = arregloTexto.Split(',');
			int longitudArreglo = elementosString.Length - 1;
			int[] elementos = new int[longitudArreglo + 1];
			int contador = 0;
			foreach (string elementoString in elementosString) 
			{
				elementos[contador] = Int32.Parse(elementoString);
				EscribirLog("info", elementos[contador].ToString(),dgvLogs);
				contador++;
			}
			for (int iPrimerelemento = 0; iPrimerelemento < longitudArreglo; iPrimerelemento++) // Primer for 
			{
				for (int iSegundoelemento = 0; iSegundoelemento < (longitudArreglo - iPrimerelemento); iSegundoelemento++) //Segundo for
				{
					int primerNumero = elementos[iSegundoelemento];
					int segundoNumero = elementos[iSegundoelemento + 1];
					if (segundoNumero < primerNumero) // Comparación
					{
						int valorTemporal = primerNumero;
						elementos[iSegundoelemento] = elementos[iSegundoelemento + 1];
						elementos[iSegundoelemento + 1] = valorTemporal;
					}
				} // Fin segundo for
			} // Fin primer for
			foreach (int elemento in elementos)
			{
				EscribirLog("orden", elemento.ToString(), dgvLogs);
			}
			string arregloOrdenado = string.Join("",elementos);
		}
		void BtnBusquedaClick(object sender, EventArgs e)
		{
			string arregloTexto = txbArreglo.Text;
			string[] elementosString = arregloTexto.Split(',');
			int longitudArreglo = elementosString.Length - 1;
			int[] elementos = new int[longitudArreglo + 1];
			int contador = 0;
			foreach (string elementoString in elementosString) 
			{
				elementos[contador] = Int32.Parse(elementoString);
				EscribirLog("info", elementos[contador].ToString(),dgvLogs);
				contador++;
			}
			for (int iPrimerelemento = 0; iPrimerelemento < longitudArreglo; iPrimerelemento++) // Primer for 
			{
				for (int iSegundoelemento = 0; iSegundoelemento < (longitudArreglo - iPrimerelemento); iSegundoelemento++) //Segundo for
				{
					int primerNumero = elementos[iSegundoelemento];
					int segundoNumero = elementos[iSegundoelemento + 1];
					if (segundoNumero < primerNumero) // Comparación
					{
						int valorTemporal = primerNumero;
						elementos[iSegundoelemento] = elementos[iSegundoelemento + 1];
						elementos[iSegundoelemento + 1] = valorTemporal;
					}
				} // Fin segundo for
			} // Fin primer for
			foreach (int elemento in elementos)
			{
				EscribirLog("orden", elemento.ToString(), dgvLogs);
			}
			//int[] arregloOrdenado = Array.ConvertAll(elementos, int.Parse);
			//string arregloOrdenado = string.Join("",elementos);
			//------------------------------------------------------------
			/*string elementoBuscado = txbBusqueda.Text;
			int mitad;
			int primerElemento = 0;
			int ultimoElemento = longitudArreglo;
			if(elementos[primerElemento] >= 1)
			{
				mitad = 1 + (ultimoElemento - 1) / 2;
			}
			if(elementos[mitad] == elementoBuscado)
			{
				return mitad;
			}*/
			string elementoBuscado = txbBusqueda.Text;
			Busqueda(elementos[elementosString.Length - 1], elementos[0], elementoBuscado, elementos);
		}
		int Busqueda(int ultimoElemento, int primerElemento, string elementoBuscado, int[] elementos)
		{
			primerElemento = 0;
			int mitad = 0;
			int elementoBuscadoEntero = int.Parse(elementoBuscado);
			/*int primerEntero = int.Parse(elementos[primerElemento]);
			int ultimoEntero = int.Parse(elementos[ultimoElemento]);
			 int mitadEntero = int.Parse(elementos[mitad]);*/
			if(elementos[ultimoElemento] >= 1)
			{
				mitad = 1 + (ultimoElemento) / 2;
							
				if(mitad == elementoBuscadoEntero)
				{
					return mitad;
				}
				if(mitad < elementoBuscadoEntero)
				{
					return Busqueda(ultimoElemento, mitad + 1, elementoBuscado, elementos);
				}
				if(mitad > elementoBuscadoEntero)
				{
					return Busqueda(mitad - 1, primerElemento, elementoBuscado, elementos);
				}
			}

			return -1;
		}
		
		
	}
}
