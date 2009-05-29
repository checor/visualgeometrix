' Visual Geometrix - Aplicación didáctica
' Copyright (C) 2009  Checor
' 
' This program is free software; you can redistribute it and/or
' modify it under the terms of the GNU General Public License
' as published by the Free Software Foundation; either version 2
' of the License, or (at your option) any later version.
' 
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with this program; if not, write to the Free Software
' Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.tabLinea = New System.Windows.Forms.TabControl
		Me.tabLineas = New System.Windows.Forms.TabPage
		Me.lblPeri = New System.Windows.Forms.Label
		Me.butCalculapl = New System.Windows.Forms.Button
		Me.txtLinea4 = New System.Windows.Forms.TextBox
		Me.txtLinea3 = New System.Windows.Forms.TextBox
		Me.txtLinea2 = New System.Windows.Forms.TextBox
		Me.txtLinea1 = New System.Windows.Forms.TextBox
		Me.label3 = New System.Windows.Forms.Label
		Me.butCalculael = New System.Windows.Forms.Button
		Me.txtConstLine = New System.Windows.Forms.TextBox
		Me.txtYline = New System.Windows.Forms.TextBox
		Me.label2 = New System.Windows.Forms.Label
		Me.txtXline = New System.Windows.Forms.TextBox
		Me.label1 = New System.Windows.Forms.Label
		Me.label4 = New System.Windows.Forms.Label
		Me.tabCirculo = New System.Windows.Forms.TabPage
		Me.label14 = New System.Windows.Forms.Label
		Me.label13 = New System.Windows.Forms.Label
		Me.label11 = New System.Windows.Forms.Label
		Me.label10 = New System.Windows.Forms.Label
		Me.butcircu3p = New System.Windows.Forms.Button
		Me.txty1cir = New System.Windows.Forms.TextBox
		Me.txtx2cir = New System.Windows.Forms.TextBox
		Me.txty3cir = New System.Windows.Forms.TextBox
		Me.txtx3cir = New System.Windows.Forms.TextBox
		Me.txty2cir = New System.Windows.Forms.TextBox
		Me.txtx1cir = New System.Windows.Forms.TextBox
		Me.label8 = New System.Windows.Forms.Label
		Me.butEcuacircu2 = New System.Windows.Forms.Button
		Me.txtCoEc2 = New System.Windows.Forms.TextBox
		Me.txtYce2 = New System.Windows.Forms.TextBox
		Me.txtXce2 = New System.Windows.Forms.TextBox
		Me.butEcuacircu1 = New System.Windows.Forms.Button
		Me.txtCoEc1 = New System.Windows.Forms.TextBox
		Me.txtYce1 = New System.Windows.Forms.TextBox
		Me.txtXce1 = New System.Windows.Forms.TextBox
		Me.label6 = New System.Windows.Forms.Label
		Me.label5 = New System.Windows.Forms.Label
		Me.label7 = New System.Windows.Forms.Label
		Me.label9 = New System.Windows.Forms.Label
		Me.tabParabola = New System.Windows.Forms.TabPage
		Me.label29 = New System.Windows.Forms.Label
		Me.butGrPVG = New System.Windows.Forms.Button
		Me.butGrPVR = New System.Windows.Forms.Button
		Me.butGrPHG = New System.Windows.Forms.Button
		Me.butGrPHR = New System.Windows.Forms.Button
		Me.txtPvrA = New System.Windows.Forms.TextBox
		Me.txtPvrF = New System.Windows.Forms.TextBox
		Me.txtPvrE = New System.Windows.Forms.TextBox
		Me.txtPvrD = New System.Windows.Forms.TextBox
		Me.txtPvrB = New System.Windows.Forms.TextBox
		Me.txtPvrP = New System.Windows.Forms.TextBox
		Me.label28 = New System.Windows.Forms.Label
		Me.label26 = New System.Windows.Forms.Label
		Me.txtPhrF = New System.Windows.Forms.TextBox
		Me.txtPhrD = New System.Windows.Forms.TextBox
		Me.txtPhrE = New System.Windows.Forms.TextBox
		Me.label25 = New System.Windows.Forms.Label
		Me.txtPhrP = New System.Windows.Forms.TextBox
		Me.txtPhrB = New System.Windows.Forms.TextBox
		Me.txtPhrA = New System.Windows.Forms.TextBox
		Me.label24 = New System.Windows.Forms.Label
		Me.label23 = New System.Windows.Forms.Label
		Me.label22 = New System.Windows.Forms.Label
		Me.label21 = New System.Windows.Forms.Label
		Me.label20 = New System.Windows.Forms.Label
		Me.label27 = New System.Windows.Forms.Label
		Me.tabElipse = New System.Windows.Forms.TabPage
		Me.butElipse = New System.Windows.Forms.Button
		Me.txtEliX = New System.Windows.Forms.TextBox
		Me.txtEliY = New System.Windows.Forms.TextBox
		Me.txtEliY2 = New System.Windows.Forms.TextBox
		Me.txtEliX2 = New System.Windows.Forms.TextBox
		Me.label15 = New System.Windows.Forms.Label
		Me.label16 = New System.Windows.Forms.Label
		Me.label17 = New System.Windows.Forms.Label
		Me.tabProcedimiento = New System.Windows.Forms.TabPage
		Me.butLimp = New System.Windows.Forms.Button
		Me.label12 = New System.Windows.Forms.Label
		Me.txtLog = New System.Windows.Forms.TextBox
		Me.pictureBox1 = New System.Windows.Forms.PictureBox
		Me.lblTitle = New System.Windows.Forms.Label
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip
		Me.archivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.preferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ayudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.temasDeAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.acercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.lblpe = New System.Windows.Forms.Label
		Me.tabLinea.SuspendLayout
		Me.tabLineas.SuspendLayout
		Me.tabCirculo.SuspendLayout
		Me.tabParabola.SuspendLayout
		Me.tabElipse.SuspendLayout
		Me.tabProcedimiento.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.menuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'tabLinea
		'
		Me.tabLinea.Controls.Add(Me.tabLineas)
		Me.tabLinea.Controls.Add(Me.tabCirculo)
		Me.tabLinea.Controls.Add(Me.tabParabola)
		Me.tabLinea.Controls.Add(Me.tabElipse)
		Me.tabLinea.Controls.Add(Me.tabProcedimiento)
		Me.tabLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tabLinea.Location = New System.Drawing.Point(3, 79)
		Me.tabLinea.Name = "tabLinea"
		Me.tabLinea.SelectedIndex = 0
		Me.tabLinea.Size = New System.Drawing.Size(418, 339)
		Me.tabLinea.TabIndex = 0
		'
		'tabLineas
		'
		Me.tabLineas.Controls.Add(Me.lblpe)
		Me.tabLineas.Controls.Add(Me.lblPeri)
		Me.tabLineas.Controls.Add(Me.butCalculapl)
		Me.tabLineas.Controls.Add(Me.txtLinea4)
		Me.tabLineas.Controls.Add(Me.txtLinea3)
		Me.tabLineas.Controls.Add(Me.txtLinea2)
		Me.tabLineas.Controls.Add(Me.txtLinea1)
		Me.tabLineas.Controls.Add(Me.label3)
		Me.tabLineas.Controls.Add(Me.butCalculael)
		Me.tabLineas.Controls.Add(Me.txtConstLine)
		Me.tabLineas.Controls.Add(Me.txtYline)
		Me.tabLineas.Controls.Add(Me.label2)
		Me.tabLineas.Controls.Add(Me.txtXline)
		Me.tabLineas.Controls.Add(Me.label1)
		Me.tabLineas.Controls.Add(Me.label4)
		Me.tabLineas.Location = New System.Drawing.Point(4, 29)
		Me.tabLineas.Name = "tabLineas"
		Me.tabLineas.Padding = New System.Windows.Forms.Padding(3)
		Me.tabLineas.Size = New System.Drawing.Size(410, 306)
		Me.tabLineas.TabIndex = 0
		Me.tabLineas.Text = "Lineas"
		Me.tabLineas.UseVisualStyleBackColor = true
		'
		'lblPeri
		'
		Me.lblPeri.Location = New System.Drawing.Point(13, 242)
		Me.lblPeri.Name = "lblPeri"
		Me.lblPeri.Size = New System.Drawing.Size(244, 34)
		Me.lblPeri.TabIndex = 18
		Me.lblPeri.Text = "Perimetro de la linea (aprox):"
		'
		'butCalculapl
		'
		Me.butCalculapl.Location = New System.Drawing.Point(171, 144)
		Me.butCalculapl.Name = "butCalculapl"
		Me.butCalculapl.Size = New System.Drawing.Size(104, 32)
		Me.butCalculapl.TabIndex = 15
		Me.butCalculapl.Text = "Graficar"
		Me.butCalculapl.UseVisualStyleBackColor = true
		AddHandler Me.butCalculapl.Click, AddressOf Me.ButCalculaplClick
		'
		'txtLinea4
		'
		Me.txtLinea4.Location = New System.Drawing.Point(115, 148)
		Me.txtLinea4.Name = "txtLinea4"
		Me.txtLinea4.Size = New System.Drawing.Size(25, 26)
		Me.txtLinea4.TabIndex = 13
		'
		'txtLinea3
		'
		Me.txtLinea3.Location = New System.Drawing.Point(85, 148)
		Me.txtLinea3.Name = "txtLinea3"
		Me.txtLinea3.Size = New System.Drawing.Size(25, 26)
		Me.txtLinea3.TabIndex = 12
		'
		'txtLinea2
		'
		Me.txtLinea2.Location = New System.Drawing.Point(51, 148)
		Me.txtLinea2.Name = "txtLinea2"
		Me.txtLinea2.Size = New System.Drawing.Size(24, 26)
		Me.txtLinea2.TabIndex = 11
		'
		'txtLinea1
		'
		Me.txtLinea1.Location = New System.Drawing.Point(21, 147)
		Me.txtLinea1.Name = "txtLinea1"
		Me.txtLinea1.Size = New System.Drawing.Size(24, 26)
		Me.txtLinea1.TabIndex = 10
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(15, 114)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(274, 23)
		Me.label3.TabIndex = 8
		Me.label3.Text = "O inserte 2 puntos de la recta:"
		'
		'butCalculael
		'
		Me.butCalculael.Location = New System.Drawing.Point(185, 54)
		Me.butCalculael.Name = "butCalculael"
		Me.butCalculael.Size = New System.Drawing.Size(90, 27)
		Me.butCalculael.TabIndex = 7
		Me.butCalculael.Text = "Graficar"
		Me.butCalculael.UseVisualStyleBackColor = true
		AddHandler Me.butCalculael.Click, AddressOf Me.ButCalculaelClick
		'
		'txtConstLine
		'
		Me.txtConstLine.Location = New System.Drawing.Point(117, 55)
		Me.txtConstLine.Name = "txtConstLine"
		Me.txtConstLine.Size = New System.Drawing.Size(62, 26)
		Me.txtConstLine.TabIndex = 6
		'
		'txtYline
		'
		Me.txtYline.Location = New System.Drawing.Point(67, 55)
		Me.txtYline.Name = "txtYline"
		Me.txtYline.Size = New System.Drawing.Size(19, 26)
		Me.txtYline.TabIndex = 4
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(33, 58)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(131, 18)
		Me.label2.TabIndex = 2
		Me.label2.Text = "X  +        Y ="
		'
		'txtXline
		'
		Me.txtXline.Location = New System.Drawing.Point(8, 55)
		Me.txtXline.Name = "txtXline"
		Me.txtXline.Size = New System.Drawing.Size(23, 26)
		Me.txtXline.TabIndex = 1
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(11, 22)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(278, 24)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Inserte la ecuacion de la recta:"
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(8, 146)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(164, 47)
		Me.label4.TabIndex = 14
		Me.label4.Text = "(            ,            )"
		'
		'tabCirculo
		'
		Me.tabCirculo.Controls.Add(Me.label14)
		Me.tabCirculo.Controls.Add(Me.label13)
		Me.tabCirculo.Controls.Add(Me.label11)
		Me.tabCirculo.Controls.Add(Me.label10)
		Me.tabCirculo.Controls.Add(Me.butcircu3p)
		Me.tabCirculo.Controls.Add(Me.txty1cir)
		Me.tabCirculo.Controls.Add(Me.txtx2cir)
		Me.tabCirculo.Controls.Add(Me.txty3cir)
		Me.tabCirculo.Controls.Add(Me.txtx3cir)
		Me.tabCirculo.Controls.Add(Me.txty2cir)
		Me.tabCirculo.Controls.Add(Me.txtx1cir)
		Me.tabCirculo.Controls.Add(Me.label8)
		Me.tabCirculo.Controls.Add(Me.butEcuacircu2)
		Me.tabCirculo.Controls.Add(Me.txtCoEc2)
		Me.tabCirculo.Controls.Add(Me.txtYce2)
		Me.tabCirculo.Controls.Add(Me.txtXce2)
		Me.tabCirculo.Controls.Add(Me.butEcuacircu1)
		Me.tabCirculo.Controls.Add(Me.txtCoEc1)
		Me.tabCirculo.Controls.Add(Me.txtYce1)
		Me.tabCirculo.Controls.Add(Me.txtXce1)
		Me.tabCirculo.Controls.Add(Me.label6)
		Me.tabCirculo.Controls.Add(Me.label5)
		Me.tabCirculo.Controls.Add(Me.label7)
		Me.tabCirculo.Controls.Add(Me.label9)
		Me.tabCirculo.Location = New System.Drawing.Point(4, 29)
		Me.tabCirculo.Name = "tabCirculo"
		Me.tabCirculo.Padding = New System.Windows.Forms.Padding(3)
		Me.tabCirculo.Size = New System.Drawing.Size(410, 306)
		Me.tabCirculo.TabIndex = 1
		Me.tabCirculo.Text = "Circulo"
		Me.tabCirculo.UseVisualStyleBackColor = true
		AddHandler Me.tabCirculo.Click, AddressOf Me.TabCirculoClick
		'
		'label14
		'
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label14.Location = New System.Drawing.Point(155, 92)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(16, 14)
		Me.label14.TabIndex = 28
		Me.label14.Text = "2"
		'
		'label13
		'
		Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label13.Location = New System.Drawing.Point(74, 91)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(16, 14)
		Me.label13.TabIndex = 27
		Me.label13.Text = "2"
		'
		'label11
		'
		Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.Location = New System.Drawing.Point(63, 44)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(16, 14)
		Me.label11.TabIndex = 25
		Me.label11.Text = "2"
		'
		'label10
		'
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.Location = New System.Drawing.Point(30, 45)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(16, 14)
		Me.label10.TabIndex = 24
		Me.label10.Text = "2"
		'
		'butcircu3p
		'
		Me.butcircu3p.Location = New System.Drawing.Point(230, 199)
		Me.butcircu3p.Name = "butcircu3p"
		Me.butcircu3p.Size = New System.Drawing.Size(93, 24)
		Me.butcircu3p.TabIndex = 23
		Me.butcircu3p.Text = "Obtener"
		Me.butcircu3p.UseVisualStyleBackColor = true
		AddHandler Me.butcircu3p.Click, AddressOf Me.Butcircu3pClick
		'
		'txty1cir
		'
		Me.txty1cir.Location = New System.Drawing.Point(46, 196)
		Me.txty1cir.Name = "txty1cir"
		Me.txty1cir.Size = New System.Drawing.Size(18, 26)
		Me.txty1cir.TabIndex = 21
		'
		'txtx2cir
		'
		Me.txtx2cir.Location = New System.Drawing.Point(84, 196)
		Me.txtx2cir.Name = "txtx2cir"
		Me.txtx2cir.Size = New System.Drawing.Size(18, 26)
		Me.txtx2cir.TabIndex = 20
		'
		'txty3cir
		'
		Me.txty3cir.Location = New System.Drawing.Point(176, 196)
		Me.txty3cir.Name = "txty3cir"
		Me.txty3cir.Size = New System.Drawing.Size(18, 26)
		Me.txty3cir.TabIndex = 19
		'
		'txtx3cir
		'
		Me.txtx3cir.Location = New System.Drawing.Point(150, 196)
		Me.txtx3cir.Name = "txtx3cir"
		Me.txtx3cir.Size = New System.Drawing.Size(18, 26)
		Me.txtx3cir.TabIndex = 18
		'
		'txty2cir
		'
		Me.txty2cir.Location = New System.Drawing.Point(114, 196)
		Me.txty2cir.Name = "txty2cir"
		Me.txty2cir.Size = New System.Drawing.Size(18, 26)
		Me.txty2cir.TabIndex = 17
		'
		'txtx1cir
		'
		Me.txtx1cir.Location = New System.Drawing.Point(19, 195)
		Me.txtx1cir.Name = "txtx1cir"
		Me.txtx1cir.Size = New System.Drawing.Size(18, 26)
		Me.txtx1cir.TabIndex = 16
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(12, 152)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(298, 43)
		Me.label8.TabIndex = 15
		Me.label8.Text = "Inserte 3 coordenadas que toque la circunferencia:"
		'
		'butEcuacircu2
		'
		Me.butEcuacircu2.Location = New System.Drawing.Point(225, 102)
		Me.butEcuacircu2.Name = "butEcuacircu2"
		Me.butEcuacircu2.Size = New System.Drawing.Size(98, 26)
		Me.butEcuacircu2.TabIndex = 14
		Me.butEcuacircu2.Text = "Graficar"
		Me.butEcuacircu2.UseVisualStyleBackColor = true
		AddHandler Me.butEcuacircu2.Click, AddressOf Me.ButEcuacircu2Click
		'
		'txtCoEc2
		'
		Me.txtCoEc2.Location = New System.Drawing.Point(178, 103)
		Me.txtCoEc2.Name = "txtCoEc2"
		Me.txtCoEc2.Size = New System.Drawing.Size(24, 26)
		Me.txtCoEc2.TabIndex = 12
		'
		'txtYce2
		'
		Me.txtYce2.Location = New System.Drawing.Point(127, 104)
		Me.txtYce2.Name = "txtYce2"
		Me.txtYce2.Size = New System.Drawing.Size(24, 26)
		Me.txtYce2.TabIndex = 11
		'
		'txtXce2
		'
		Me.txtXce2.Location = New System.Drawing.Point(43, 105)
		Me.txtXce2.Name = "txtXce2"
		Me.txtXce2.Size = New System.Drawing.Size(27, 26)
		Me.txtXce2.TabIndex = 10
		'
		'butEcuacircu1
		'
		Me.butEcuacircu1.Location = New System.Drawing.Point(225, 49)
		Me.butEcuacircu1.Name = "butEcuacircu1"
		Me.butEcuacircu1.Size = New System.Drawing.Size(98, 27)
		Me.butEcuacircu1.TabIndex = 9
		Me.butEcuacircu1.Text = "Graficar"
		Me.butEcuacircu1.UseVisualStyleBackColor = true
		AddHandler Me.butEcuacircu1.Click, AddressOf Me.ButEcuacircu1Click
		'
		'txtCoEc1
		'
		Me.txtCoEc1.Location = New System.Drawing.Point(185, 53)
		Me.txtCoEc1.Name = "txtCoEc1"
		Me.txtCoEc1.Size = New System.Drawing.Size(27, 26)
		Me.txtCoEc1.TabIndex = 6
		'
		'txtYce1
		'
		Me.txtYce1.Location = New System.Drawing.Point(130, 52)
		Me.txtYce1.Name = "txtYce1"
		Me.txtYce1.Size = New System.Drawing.Size(23, 26)
		Me.txtYce1.TabIndex = 5
		'
		'txtXce1
		'
		Me.txtXce1.Location = New System.Drawing.Point(79, 52)
		Me.txtXce1.Name = "txtXce1"
		Me.txtXce1.Size = New System.Drawing.Size(24, 26)
		Me.txtXce1.TabIndex = 4
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(15, 58)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(253, 21)
		Me.label6.TabIndex = 1
		Me.label6.Text = "X  +  Y  +       X +        Y ="
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(10, 23)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(302, 19)
		Me.label5.TabIndex = 0
		Me.label5.Text = "Inserte la ecuación del ciruculo:"
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(10, 108)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(199, 28)
		Me.label7.TabIndex = 13
		Me.label7.Text = "(X -         )  + (Y -        )  ="
		'
		'label9
		'
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.Location = New System.Drawing.Point(7, 199)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(238, 24)
		Me.label9.TabIndex = 22
		Me.label9.Text = "(      ,      ) (      ,      ) (      ,      )"
		'
		'tabParabola
		'
		Me.tabParabola.Controls.Add(Me.label29)
		Me.tabParabola.Controls.Add(Me.butGrPVG)
		Me.tabParabola.Controls.Add(Me.butGrPVR)
		Me.tabParabola.Controls.Add(Me.butGrPHG)
		Me.tabParabola.Controls.Add(Me.butGrPHR)
		Me.tabParabola.Controls.Add(Me.txtPvrA)
		Me.tabParabola.Controls.Add(Me.txtPvrF)
		Me.tabParabola.Controls.Add(Me.txtPvrE)
		Me.tabParabola.Controls.Add(Me.txtPvrD)
		Me.tabParabola.Controls.Add(Me.txtPvrB)
		Me.tabParabola.Controls.Add(Me.txtPvrP)
		Me.tabParabola.Controls.Add(Me.label28)
		Me.tabParabola.Controls.Add(Me.label26)
		Me.tabParabola.Controls.Add(Me.txtPhrF)
		Me.tabParabola.Controls.Add(Me.txtPhrD)
		Me.tabParabola.Controls.Add(Me.txtPhrE)
		Me.tabParabola.Controls.Add(Me.label25)
		Me.tabParabola.Controls.Add(Me.txtPhrP)
		Me.tabParabola.Controls.Add(Me.txtPhrB)
		Me.tabParabola.Controls.Add(Me.txtPhrA)
		Me.tabParabola.Controls.Add(Me.label24)
		Me.tabParabola.Controls.Add(Me.label23)
		Me.tabParabola.Controls.Add(Me.label22)
		Me.tabParabola.Controls.Add(Me.label21)
		Me.tabParabola.Controls.Add(Me.label20)
		Me.tabParabola.Controls.Add(Me.label27)
		Me.tabParabola.Location = New System.Drawing.Point(4, 29)
		Me.tabParabola.Name = "tabParabola"
		Me.tabParabola.Size = New System.Drawing.Size(410, 306)
		Me.tabParabola.TabIndex = 2
		Me.tabParabola.Text = "Parabola"
		Me.tabParabola.UseVisualStyleBackColor = true
		'
		'label29
		'
		Me.label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label29.Location = New System.Drawing.Point(31, 195)
		Me.label29.Name = "label29"
		Me.label29.Size = New System.Drawing.Size(16, 14)
		Me.label29.TabIndex = 47
		Me.label29.Text = "2"
		'
		'butGrPVG
		'
		Me.butGrPVG.Location = New System.Drawing.Point(215, 207)
		Me.butGrPVG.Name = "butGrPVG"
		Me.butGrPVG.Size = New System.Drawing.Size(101, 25)
		Me.butGrPVG.TabIndex = 46
		Me.butGrPVG.Text = "Graficar"
		Me.butGrPVG.UseVisualStyleBackColor = true
		AddHandler Me.butGrPVG.Click, AddressOf Me.ButGrPVGClick
		'
		'butGrPVR
		'
		Me.butGrPVR.Location = New System.Drawing.Point(215, 157)
		Me.butGrPVR.Name = "butGrPVR"
		Me.butGrPVR.Size = New System.Drawing.Size(101, 27)
		Me.butGrPVR.TabIndex = 45
		Me.butGrPVR.Text = "Graficar"
		Me.butGrPVR.UseVisualStyleBackColor = true
		AddHandler Me.butGrPVR.Click, AddressOf Me.ButGrPVRClick
		'
		'butGrPHG
		'
		Me.butGrPHG.Location = New System.Drawing.Point(217, 78)
		Me.butGrPHG.Name = "butGrPHG"
		Me.butGrPHG.Size = New System.Drawing.Size(101, 24)
		Me.butGrPHG.TabIndex = 44
		Me.butGrPHG.Text = "Graficar"
		Me.butGrPHG.UseVisualStyleBackColor = true
		AddHandler Me.butGrPHG.Click, AddressOf Me.ButGrPHGClick
		'
		'butGrPHR
		'
		Me.butGrPHR.Location = New System.Drawing.Point(217, 44)
		Me.butGrPHR.Name = "butGrPHR"
		Me.butGrPHR.Size = New System.Drawing.Size(101, 27)
		Me.butGrPHR.TabIndex = 43
		Me.butGrPHR.Text = "Graficar"
		Me.butGrPHR.UseVisualStyleBackColor = true
		AddHandler Me.butGrPHR.Click, AddressOf Me.ButGrPHRClick
		'
		'txtPvrA
		'
		Me.txtPvrA.Location = New System.Drawing.Point(51, 157)
		Me.txtPvrA.Name = "txtPvrA"
		Me.txtPvrA.Size = New System.Drawing.Size(22, 26)
		Me.txtPvrA.TabIndex = 42
		'
		'txtPvrF
		'
		Me.txtPvrF.Location = New System.Drawing.Point(142, 203)
		Me.txtPvrF.Name = "txtPvrF"
		Me.txtPvrF.Size = New System.Drawing.Size(22, 26)
		Me.txtPvrF.TabIndex = 41
		'
		'txtPvrE
		'
		Me.txtPvrE.Location = New System.Drawing.Point(96, 203)
		Me.txtPvrE.Name = "txtPvrE"
		Me.txtPvrE.Size = New System.Drawing.Size(22, 26)
		Me.txtPvrE.TabIndex = 40
		'
		'txtPvrD
		'
		Me.txtPvrD.Location = New System.Drawing.Point(49, 203)
		Me.txtPvrD.Name = "txtPvrD"
		Me.txtPvrD.Size = New System.Drawing.Size(22, 26)
		Me.txtPvrD.TabIndex = 39
		'
		'txtPvrB
		'
		Me.txtPvrB.Location = New System.Drawing.Point(156, 156)
		Me.txtPvrB.Name = "txtPvrB"
		Me.txtPvrB.Size = New System.Drawing.Size(22, 26)
		Me.txtPvrB.TabIndex = 38
		'
		'txtPvrP
		'
		Me.txtPvrP.Location = New System.Drawing.Point(103, 155)
		Me.txtPvrP.Name = "txtPvrP"
		Me.txtPvrP.Size = New System.Drawing.Size(22, 26)
		Me.txtPvrP.TabIndex = 37
		'
		'label28
		'
		Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label28.Location = New System.Drawing.Point(79, 143)
		Me.label28.Name = "label28"
		Me.label28.Size = New System.Drawing.Size(16, 14)
		Me.label28.TabIndex = 36
		Me.label28.Text = "2"
		'
		'label26
		'
		Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label26.Location = New System.Drawing.Point(21, 160)
		Me.label26.Name = "label26"
		Me.label26.Size = New System.Drawing.Size(218, 26)
		Me.label26.TabIndex = 34
		Me.label26.Text = "(x +       )  =        (y +       )"
		'
		'txtPhrF
		'
		Me.txtPhrF.Location = New System.Drawing.Point(142, 74)
		Me.txtPhrF.Name = "txtPhrF"
		Me.txtPhrF.Size = New System.Drawing.Size(22, 26)
		Me.txtPhrF.TabIndex = 33
		'
		'txtPhrD
		'
		Me.txtPhrD.Location = New System.Drawing.Point(49, 74)
		Me.txtPhrD.Name = "txtPhrD"
		Me.txtPhrD.Size = New System.Drawing.Size(22, 26)
		Me.txtPhrD.TabIndex = 32
		'
		'txtPhrE
		'
		Me.txtPhrE.Location = New System.Drawing.Point(96, 74)
		Me.txtPhrE.Name = "txtPhrE"
		Me.txtPhrE.Size = New System.Drawing.Size(22, 26)
		Me.txtPhrE.TabIndex = 31
		'
		'label25
		'
		Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label25.Location = New System.Drawing.Point(22, 209)
		Me.label25.Name = "label25"
		Me.label25.Size = New System.Drawing.Size(218, 32)
		Me.label25.TabIndex = 30
		Me.label25.Text = "x  +       x +       y +      = 0"
		'
		'txtPhrP
		'
		Me.txtPhrP.Location = New System.Drawing.Point(101, 43)
		Me.txtPhrP.Name = "txtPhrP"
		Me.txtPhrP.Size = New System.Drawing.Size(22, 26)
		Me.txtPhrP.TabIndex = 29
		'
		'txtPhrB
		'
		Me.txtPhrB.Location = New System.Drawing.Point(153, 43)
		Me.txtPhrB.Name = "txtPhrB"
		Me.txtPhrB.Size = New System.Drawing.Size(22, 26)
		Me.txtPhrB.TabIndex = 28
		'
		'txtPhrA
		'
		Me.txtPhrA.Location = New System.Drawing.Point(49, 43)
		Me.txtPhrA.Name = "txtPhrA"
		Me.txtPhrA.Size = New System.Drawing.Size(22, 26)
		Me.txtPhrA.TabIndex = 27
		'
		'label24
		'
		Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label24.Location = New System.Drawing.Point(31, 72)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(16, 14)
		Me.label24.TabIndex = 26
		Me.label24.Text = "2"
		'
		'label23
		'
		Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label23.Location = New System.Drawing.Point(75, 28)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(16, 14)
		Me.label23.TabIndex = 25
		Me.label23.Text = "2"
		'
		'label22
		'
		Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label22.Location = New System.Drawing.Point(18, 47)
		Me.label22.Name = "label22"
		Me.label22.Size = New System.Drawing.Size(218, 22)
		Me.label22.TabIndex = 2
		Me.label22.Text = "(y +       )  =        (x +       )"
		'
		'label21
		'
		Me.label21.Location = New System.Drawing.Point(14, 117)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(288, 21)
		Me.label21.TabIndex = 1
		Me.label21.Text = "Inserte la ecuacion de la parabola vertical"
		'
		'label20
		'
		Me.label20.Location = New System.Drawing.Point(17, 13)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(302, 19)
		Me.label20.TabIndex = 0
		Me.label20.Text = "Inserte la ecuación de la parabola horizontal:"
		'
		'label27
		'
		Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label27.Location = New System.Drawing.Point(22, 79)
		Me.label27.Name = "label27"
		Me.label27.Size = New System.Drawing.Size(218, 24)
		Me.label27.TabIndex = 35
		Me.label27.Text = "y  +      y +       x +       = 0"
		'
		'tabElipse
		'
		Me.tabElipse.Controls.Add(Me.butElipse)
		Me.tabElipse.Controls.Add(Me.txtEliX)
		Me.tabElipse.Controls.Add(Me.txtEliY)
		Me.tabElipse.Controls.Add(Me.txtEliY2)
		Me.tabElipse.Controls.Add(Me.txtEliX2)
		Me.tabElipse.Controls.Add(Me.label15)
		Me.tabElipse.Controls.Add(Me.label16)
		Me.tabElipse.Controls.Add(Me.label17)
		Me.tabElipse.Location = New System.Drawing.Point(4, 29)
		Me.tabElipse.Name = "tabElipse"
		Me.tabElipse.Size = New System.Drawing.Size(330, 302)
		Me.tabElipse.TabIndex = 4
		Me.tabElipse.Text = "Elipse"
		Me.tabElipse.UseVisualStyleBackColor = true
		'
		'butElipse
		'
		Me.butElipse.Location = New System.Drawing.Point(213, 100)
		Me.butElipse.Name = "butElipse"
		Me.butElipse.Size = New System.Drawing.Size(108, 26)
		Me.butElipse.TabIndex = 8
		Me.butElipse.Text = "Graficar"
		Me.butElipse.UseVisualStyleBackColor = true
		AddHandler Me.butElipse.Click, AddressOf Me.ButElipseClick
		'
		'txtEliX
		'
		Me.txtEliX.Location = New System.Drawing.Point(64, 54)
		Me.txtEliX.Name = "txtEliX"
		Me.txtEliX.Size = New System.Drawing.Size(23, 26)
		Me.txtEliX.TabIndex = 5
		'
		'txtEliY
		'
		Me.txtEliY.Location = New System.Drawing.Point(144, 54)
		Me.txtEliY.Name = "txtEliY"
		Me.txtEliY.Size = New System.Drawing.Size(23, 26)
		Me.txtEliY.TabIndex = 4
		'
		'txtEliY2
		'
		Me.txtEliY2.Location = New System.Drawing.Point(115, 98)
		Me.txtEliY2.Name = "txtEliY2"
		Me.txtEliY2.Size = New System.Drawing.Size(52, 26)
		Me.txtEliY2.TabIndex = 2
		'
		'txtEliX2
		'
		Me.txtEliX2.Location = New System.Drawing.Point(34, 98)
		Me.txtEliX2.Name = "txtEliX2"
		Me.txtEliX2.Size = New System.Drawing.Size(52, 26)
		Me.txtEliX2.TabIndex = 1
		'
		'label15
		'
		Me.label15.Location = New System.Drawing.Point(12, 21)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(304, 18)
		Me.label15.TabIndex = 0
		Me.label15.Text = "Inserte la ecuación de la elipse:"
		'
		'label16
		'
		Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label16.Location = New System.Drawing.Point(32, 60)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(235, 23)
		Me.label16.TabIndex = 6
		Me.label16.Text = "( X -        ) + ( Y -       ) = 1"
		'
		'label17
		'
		Me.label17.Location = New System.Drawing.Point(32, 65)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(152, 22)
		Me.label17.TabIndex = 9
		Me.label17.Text = "______   ______"
		'
		'tabProcedimiento
		'
		Me.tabProcedimiento.Controls.Add(Me.butLimp)
		Me.tabProcedimiento.Controls.Add(Me.label12)
		Me.tabProcedimiento.Controls.Add(Me.txtLog)
		Me.tabProcedimiento.Location = New System.Drawing.Point(4, 29)
		Me.tabProcedimiento.Name = "tabProcedimiento"
		Me.tabProcedimiento.Padding = New System.Windows.Forms.Padding(3)
		Me.tabProcedimiento.Size = New System.Drawing.Size(410, 306)
		Me.tabProcedimiento.TabIndex = 3
		Me.tabProcedimiento.Text = "Procedimiento"
		Me.tabProcedimiento.UseVisualStyleBackColor = true
		'
		'butLimp
		'
		Me.butLimp.Location = New System.Drawing.Point(251, 276)
		Me.butLimp.Name = "butLimp"
		Me.butLimp.Size = New System.Drawing.Size(82, 31)
		Me.butLimp.TabIndex = 2
		Me.butLimp.Text = "Limpiar"
		Me.butLimp.UseVisualStyleBackColor = true
		AddHandler Me.butLimp.Click, AddressOf Me.ButLimpClick
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(8, 9)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(293, 18)
		Me.label12.TabIndex = 1
		Me.label12.Text = "Procedimiento de la última acción:"
		'
		'txtLog
		'
		Me.txtLog.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtLog.Location = New System.Drawing.Point(8, 34)
		Me.txtLog.Multiline = true
		Me.txtLog.Name = "txtLog"
		Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtLog.Size = New System.Drawing.Size(325, 236)
		Me.txtLog.TabIndex = 0
		'
		'pictureBox1
		'
		Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
		Me.pictureBox1.Location = New System.Drawing.Point(424, 108)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(260, 260)
		Me.pictureBox1.TabIndex = 1
		Me.pictureBox1.TabStop = false
		AddHandler Me.pictureBox1.Click, AddressOf Me.PictureBox1Click
		'
		'lblTitle
		'
		Me.lblTitle.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitle.Location = New System.Drawing.Point(16, 27)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(304, 34)
		Me.lblTitle.TabIndex = 2
		Me.lblTitle.Text = "Visual Geometrix"
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivoToolStripMenuItem, Me.ayudaToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(576, 24)
		Me.menuStrip1.TabIndex = 3
		Me.menuStrip1.Text = "menuStrip1"
		Me.menuStrip1.Visible = false
		'
		'archivoToolStripMenuItem
		'
		Me.archivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.preferenciasToolStripMenuItem, Me.salirToolStripMenuItem})
		Me.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem"
		Me.archivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
		Me.archivoToolStripMenuItem.Text = "&Archivo"
		'
		'preferenciasToolStripMenuItem
		'
		Me.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem"
		Me.preferenciasToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.preferenciasToolStripMenuItem.Text = "&Preferencias..."
		'
		'salirToolStripMenuItem
		'
		Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
		Me.salirToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.salirToolStripMenuItem.Text = "&Salir"
		'
		'ayudaToolStripMenuItem
		'
		Me.ayudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.temasDeAyudaToolStripMenuItem, Me.acercaDeToolStripMenuItem})
		Me.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem"
		Me.ayudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
		Me.ayudaToolStripMenuItem.Text = "Ayuda"
		'
		'temasDeAyudaToolStripMenuItem
		'
		Me.temasDeAyudaToolStripMenuItem.Name = "temasDeAyudaToolStripMenuItem"
		Me.temasDeAyudaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
		Me.temasDeAyudaToolStripMenuItem.Text = "Temas de ayuda"
		'
		'acercaDeToolStripMenuItem
		'
		Me.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem"
		Me.acercaDeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
		Me.acercaDeToolStripMenuItem.Text = "Acerca de..."
		'
		'lblpe
		'
		Me.lblpe.Location = New System.Drawing.Point(263, 242)
		Me.lblpe.Name = "lblpe"
		Me.lblpe.Size = New System.Drawing.Size(141, 22)
		Me.lblpe.TabIndex = 19
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(692, 516)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.tabLinea)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Visual Geometrix"
		Me.tabLinea.ResumeLayout(false)
		Me.tabLineas.ResumeLayout(false)
		Me.tabLineas.PerformLayout
		Me.tabCirculo.ResumeLayout(false)
		Me.tabCirculo.PerformLayout
		Me.tabParabola.ResumeLayout(false)
		Me.tabParabola.PerformLayout
		Me.tabElipse.ResumeLayout(false)
		Me.tabElipse.PerformLayout
		Me.tabProcedimiento.ResumeLayout(false)
		Me.tabProcedimiento.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lblpe As System.Windows.Forms.Label
	Private butLimp As System.Windows.Forms.Button
	Private label17 As System.Windows.Forms.Label
	Private label16 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private txtEliX2 As System.Windows.Forms.TextBox
	Private txtEliY2 As System.Windows.Forms.TextBox
	Private txtEliY As System.Windows.Forms.TextBox
	Private txtEliX As System.Windows.Forms.TextBox
	Private butElipse As System.Windows.Forms.Button
	Private txty1cir As System.Windows.Forms.TextBox
	Private txtx2cir As System.Windows.Forms.TextBox
	Private txty3cir As System.Windows.Forms.TextBox
	Private txtx3cir As System.Windows.Forms.TextBox
	Private txty2cir As System.Windows.Forms.TextBox
	Private txtx1cir As System.Windows.Forms.TextBox
	Private txtLog As System.Windows.Forms.TextBox
	Private label12 As System.Windows.Forms.Label
	Private tabProcedimiento As System.Windows.Forms.TabPage
	Private tabElipse As System.Windows.Forms.TabPage
	Private txtPvrF As System.Windows.Forms.TextBox
	Private label29 As System.Windows.Forms.Label
	Private butGrPVG As System.Windows.Forms.Button
	Private butGrPVR As System.Windows.Forms.Button
	Private butGrPHG As System.Windows.Forms.Button
	Private butGrPHR As System.Windows.Forms.Button
	Private label20 As System.Windows.Forms.Label
	Private label21 As System.Windows.Forms.Label
	Private label22 As System.Windows.Forms.Label
	Private label23 As System.Windows.Forms.Label
	Private label24 As System.Windows.Forms.Label
	Private txtPhrA As System.Windows.Forms.TextBox
	Private txtPhrB As System.Windows.Forms.TextBox
	Private txtPhrP As System.Windows.Forms.TextBox
	Private label25 As System.Windows.Forms.Label
	Private txtPhrE As System.Windows.Forms.TextBox
	Private txtPhrD As System.Windows.Forms.TextBox
	Private txtPhrF As System.Windows.Forms.TextBox
	Private label26 As System.Windows.Forms.Label
	Private label27 As System.Windows.Forms.Label
	Private label28 As System.Windows.Forms.Label
	Private txtPvrP As System.Windows.Forms.TextBox
	Private txtPvrB As System.Windows.Forms.TextBox
	Private txtPvrD As System.Windows.Forms.TextBox
	Private txtPvrE As System.Windows.Forms.TextBox
	Private txtPvrA As System.Windows.Forms.TextBox
	Private txtXce2 As System.Windows.Forms.TextBox
	Private txtCoEc2 As System.Windows.Forms.TextBox
	Private txtYce2 As System.Windows.Forms.TextBox
	Private label13 As System.Windows.Forms.Label
	Private label14 As System.Windows.Forms.Label
	Private txtXce1 As System.Windows.Forms.TextBox
	Private txtYce1 As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private butcircu3p As System.Windows.Forms.Button
	Private butEcuacircu2 As System.Windows.Forms.Button
	Private butEcuacircu1 As System.Windows.Forms.Button
	Private txtCoEc1 As System.Windows.Forms.TextBox
	Private acercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private temasDeAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private ayudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private salirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private preferenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private archivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private label9 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private lblPeri As System.Windows.Forms.Label
	Private txtLinea4 As System.Windows.Forms.TextBox
	Private txtLinea3 As System.Windows.Forms.TextBox
	Private txtLinea2 As System.Windows.Forms.TextBox
	Private txtLinea1 As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private butCalculapl As System.Windows.Forms.Button
	Private butCalculael As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private txtXline As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private txtYline As System.Windows.Forms.TextBox
	Private txtConstLine As System.Windows.Forms.TextBox
	Private lblTitle As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private tabParabola As System.Windows.Forms.TabPage
	Private tabCirculo As System.Windows.Forms.TabPage
	Private tabLineas As System.Windows.Forms.TabPage
	Private tabLinea As System.Windows.Forms.TabControl
	

	

End Class
