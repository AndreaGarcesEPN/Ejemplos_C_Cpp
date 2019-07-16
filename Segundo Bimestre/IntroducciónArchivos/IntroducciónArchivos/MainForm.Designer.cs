/*
 * Created by SharpDevelop.
 * User: USRGAM
 * Date: 26/06/2019
 * Time: 10:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IntroducciónArchivos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvLogs;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn log;
		private System.Windows.Forms.Button btnAnadirLog;
		private System.Windows.Forms.Button btnDirectorio;
		private System.Windows.Forms.TextBox txbLeerDirectorio;
		private System.Windows.Forms.TextBox txbListarDirectorio;
		private System.Windows.Forms.Button btnListarDirectorio;
		private System.Windows.Forms.TextBox txbCrearArchivo;
		private System.Windows.Forms.Button btnCrearArchivo;
		private System.Windows.Forms.TextBox txbCrearDirectorio;
		private System.Windows.Forms.Button btnCrearDirectorio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbNombre;
		private System.Windows.Forms.TextBox txbDestino;
		private System.Windows.Forms.Button btnCopiarDirectorio;
		private System.Windows.Forms.Button btnStreamW;
		private System.Windows.Forms.TextBox txbStreamW;
		private System.Windows.Forms.Button btnStreamR;
		private System.Windows.Forms.TextBox txbArreglo;
		private System.Windows.Forms.Button btnOrdenarArregloBS;
		private System.Windows.Forms.Button btnOrdenarArregloSs;
		
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
			this.dgvLogs = new System.Windows.Forms.DataGridView();
			this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.log = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAnadirLog = new System.Windows.Forms.Button();
			this.btnDirectorio = new System.Windows.Forms.Button();
			this.txbLeerDirectorio = new System.Windows.Forms.TextBox();
			this.txbListarDirectorio = new System.Windows.Forms.TextBox();
			this.btnListarDirectorio = new System.Windows.Forms.Button();
			this.txbCrearArchivo = new System.Windows.Forms.TextBox();
			this.btnCrearArchivo = new System.Windows.Forms.Button();
			this.txbCrearDirectorio = new System.Windows.Forms.TextBox();
			this.btnCrearDirectorio = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbNombre = new System.Windows.Forms.TextBox();
			this.txbDestino = new System.Windows.Forms.TextBox();
			this.btnCopiarDirectorio = new System.Windows.Forms.Button();
			this.btnStreamW = new System.Windows.Forms.Button();
			this.txbStreamW = new System.Windows.Forms.TextBox();
			this.btnStreamR = new System.Windows.Forms.Button();
			this.txbArreglo = new System.Windows.Forms.TextBox();
			this.btnOrdenarArregloBS = new System.Windows.Forms.Button();
			this.btnOrdenarArregloSs = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLogs
			// 
			this.dgvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLogs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.tipo,
			this.log});
			this.dgvLogs.GridColor = System.Drawing.SystemColors.AppWorkspace;
			this.dgvLogs.Location = new System.Drawing.Point(12, 67);
			this.dgvLogs.Name = "dgvLogs";
			this.dgvLogs.Size = new System.Drawing.Size(769, 157);
			this.dgvLogs.TabIndex = 0;
			this.dgvLogs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLogsCellDoubleClick);
			// 
			// tipo
			// 
			this.tipo.HeaderText = "Tipo Log";
			this.tipo.Name = "tipo";
			this.tipo.ReadOnly = true;
			// 
			// log
			// 
			this.log.HeaderText = "Descripción";
			this.log.Name = "log";
			this.log.ReadOnly = true;
			// 
			// btnAnadirLog
			// 
			this.btnAnadirLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAnadirLog.Location = new System.Drawing.Point(705, 38);
			this.btnAnadirLog.Name = "btnAnadirLog";
			this.btnAnadirLog.Size = new System.Drawing.Size(75, 23);
			this.btnAnadirLog.TabIndex = 1;
			this.btnAnadirLog.Text = "Añadir Log";
			this.btnAnadirLog.UseVisualStyleBackColor = true;
			this.btnAnadirLog.Click += new System.EventHandler(this.BtnAnadirLogClick);
			// 
			// btnDirectorio
			// 
			this.btnDirectorio.Location = new System.Drawing.Point(12, 38);
			this.btnDirectorio.Name = "btnDirectorio";
			this.btnDirectorio.Size = new System.Drawing.Size(100, 23);
			this.btnDirectorio.TabIndex = 2;
			this.btnDirectorio.Text = "Leer Directorio";
			this.btnDirectorio.UseVisualStyleBackColor = true;
			this.btnDirectorio.Click += new System.EventHandler(this.BtnDirectorioClick);
			// 
			// txbLeerDirectorio
			// 
			this.txbLeerDirectorio.Location = new System.Drawing.Point(12, 12);
			this.txbLeerDirectorio.Name = "txbLeerDirectorio";
			this.txbLeerDirectorio.Size = new System.Drawing.Size(100, 20);
			this.txbLeerDirectorio.TabIndex = 3;
			// 
			// txbListarDirectorio
			// 
			this.txbListarDirectorio.Location = new System.Drawing.Point(118, 12);
			this.txbListarDirectorio.Name = "txbListarDirectorio";
			this.txbListarDirectorio.Size = new System.Drawing.Size(100, 20);
			this.txbListarDirectorio.TabIndex = 4;
			// 
			// btnListarDirectorio
			// 
			this.btnListarDirectorio.Location = new System.Drawing.Point(118, 38);
			this.btnListarDirectorio.Name = "btnListarDirectorio";
			this.btnListarDirectorio.Size = new System.Drawing.Size(100, 23);
			this.btnListarDirectorio.TabIndex = 5;
			this.btnListarDirectorio.Text = "Listar Directorio";
			this.btnListarDirectorio.UseVisualStyleBackColor = true;
			this.btnListarDirectorio.Click += new System.EventHandler(this.BtnListarDirectorioClick);
			// 
			// txbCrearArchivo
			// 
			this.txbCrearArchivo.Location = new System.Drawing.Point(224, 12);
			this.txbCrearArchivo.Name = "txbCrearArchivo";
			this.txbCrearArchivo.Size = new System.Drawing.Size(100, 20);
			this.txbCrearArchivo.TabIndex = 6;
			// 
			// btnCrearArchivo
			// 
			this.btnCrearArchivo.Location = new System.Drawing.Point(224, 38);
			this.btnCrearArchivo.Name = "btnCrearArchivo";
			this.btnCrearArchivo.Size = new System.Drawing.Size(100, 23);
			this.btnCrearArchivo.TabIndex = 7;
			this.btnCrearArchivo.Text = "Crear Archivo";
			this.btnCrearArchivo.UseVisualStyleBackColor = true;
			this.btnCrearArchivo.Click += new System.EventHandler(this.BtnCrearArchivoClick);
			// 
			// txbCrearDirectorio
			// 
			this.txbCrearDirectorio.Location = new System.Drawing.Point(330, 12);
			this.txbCrearDirectorio.Name = "txbCrearDirectorio";
			this.txbCrearDirectorio.Size = new System.Drawing.Size(100, 20);
			this.txbCrearDirectorio.TabIndex = 8;
			// 
			// btnCrearDirectorio
			// 
			this.btnCrearDirectorio.Location = new System.Drawing.Point(330, 38);
			this.btnCrearDirectorio.Name = "btnCrearDirectorio";
			this.btnCrearDirectorio.Size = new System.Drawing.Size(100, 23);
			this.btnCrearDirectorio.TabIndex = 9;
			this.btnCrearDirectorio.Text = "Crear Directorio";
			this.btnCrearDirectorio.UseVisualStyleBackColor = true;
			this.btnCrearDirectorio.Click += new System.EventHandler(this.BtnCrearDirectorioClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(437, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(436, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Destino";
			// 
			// txbNombre
			// 
			this.txbNombre.Location = new System.Drawing.Point(491, 12);
			this.txbNombre.Name = "txbNombre";
			this.txbNombre.Size = new System.Drawing.Size(100, 20);
			this.txbNombre.TabIndex = 12;
			// 
			// txbDestino
			// 
			this.txbDestino.Location = new System.Drawing.Point(491, 39);
			this.txbDestino.Name = "txbDestino";
			this.txbDestino.Size = new System.Drawing.Size(100, 20);
			this.txbDestino.TabIndex = 13;
			// 
			// btnCopiarDirectorio
			// 
			this.btnCopiarDirectorio.Location = new System.Drawing.Point(597, 25);
			this.btnCopiarDirectorio.Name = "btnCopiarDirectorio";
			this.btnCopiarDirectorio.Size = new System.Drawing.Size(102, 23);
			this.btnCopiarDirectorio.TabIndex = 14;
			this.btnCopiarDirectorio.Text = "Copiar Directorio";
			this.btnCopiarDirectorio.UseVisualStyleBackColor = true;
			this.btnCopiarDirectorio.Click += new System.EventHandler(this.BtnCopiarDirectorioClick);
			// 
			// btnStreamW
			// 
			this.btnStreamW.Location = new System.Drawing.Point(13, 231);
			this.btnStreamW.Name = "btnStreamW";
			this.btnStreamW.Size = new System.Drawing.Size(99, 23);
			this.btnStreamW.TabIndex = 15;
			this.btnStreamW.Text = "Stream Writer";
			this.btnStreamW.UseVisualStyleBackColor = true;
			this.btnStreamW.Click += new System.EventHandler(this.BtnStreamWClick);
			// 
			// txbStreamW
			// 
			this.txbStreamW.Location = new System.Drawing.Point(118, 248);
			this.txbStreamW.Name = "txbStreamW";
			this.txbStreamW.Size = new System.Drawing.Size(100, 20);
			this.txbStreamW.TabIndex = 16;
			// 
			// btnStreamR
			// 
			this.btnStreamR.Location = new System.Drawing.Point(13, 261);
			this.btnStreamR.Name = "btnStreamR";
			this.btnStreamR.Size = new System.Drawing.Size(99, 23);
			this.btnStreamR.TabIndex = 17;
			this.btnStreamR.Text = "Stream Reader";
			this.btnStreamR.UseVisualStyleBackColor = true;
			this.btnStreamR.Click += new System.EventHandler(this.BtnStreamRClick);
			// 
			// txbArreglo
			// 
			this.txbArreglo.Location = new System.Drawing.Point(251, 233);
			this.txbArreglo.Name = "txbArreglo";
			this.txbArreglo.Size = new System.Drawing.Size(378, 20);
			this.txbArreglo.TabIndex = 18;
			// 
			// btnOrdenarArregloBS
			// 
			this.btnOrdenarArregloBS.Location = new System.Drawing.Point(251, 259);
			this.btnOrdenarArregloBS.Name = "btnOrdenarArregloBS";
			this.btnOrdenarArregloBS.Size = new System.Drawing.Size(114, 23);
			this.btnOrdenarArregloBS.TabIndex = 19;
			this.btnOrdenarArregloBS.Text = "Ordenar Arreglo Bs";
			this.btnOrdenarArregloBS.UseVisualStyleBackColor = true;
			this.btnOrdenarArregloBS.Click += new System.EventHandler(this.BtnOrdenarArregloBSClick);
			// 
			// btnOrdenarArregloSs
			// 
			this.btnOrdenarArregloSs.Location = new System.Drawing.Point(371, 259);
			this.btnOrdenarArregloSs.Name = "btnOrdenarArregloSs";
			this.btnOrdenarArregloSs.Size = new System.Drawing.Size(114, 23);
			this.btnOrdenarArregloSs.TabIndex = 20;
			this.btnOrdenarArregloSs.Text = "Ordenar Arreglo Ss";
			this.btnOrdenarArregloSs.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(793, 296);
			this.Controls.Add(this.btnOrdenarArregloSs);
			this.Controls.Add(this.btnOrdenarArregloBS);
			this.Controls.Add(this.txbArreglo);
			this.Controls.Add(this.btnStreamR);
			this.Controls.Add(this.txbStreamW);
			this.Controls.Add(this.btnStreamW);
			this.Controls.Add(this.btnCopiarDirectorio);
			this.Controls.Add(this.txbDestino);
			this.Controls.Add(this.txbNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCrearDirectorio);
			this.Controls.Add(this.txbCrearDirectorio);
			this.Controls.Add(this.btnCrearArchivo);
			this.Controls.Add(this.txbCrearArchivo);
			this.Controls.Add(this.btnListarDirectorio);
			this.Controls.Add(this.txbListarDirectorio);
			this.Controls.Add(this.txbLeerDirectorio);
			this.Controls.Add(this.btnDirectorio);
			this.Controls.Add(this.btnAnadirLog);
			this.Controls.Add(this.dgvLogs);
			this.Name = "MainForm";
			this.Text = "IntroducciónArchivos";
			((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
