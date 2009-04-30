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
		Me.textBox13 = New System.Windows.Forms.TextBox
		Me.textBox12 = New System.Windows.Forms.TextBox
		Me.textBox11 = New System.Windows.Forms.TextBox
		Me.textBox10 = New System.Windows.Forms.TextBox
		Me.textBox9 = New System.Windows.Forms.TextBox
		Me.textBox8 = New System.Windows.Forms.TextBox
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
		Me.label27 = New System.Windows.Forms.Label
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
		Me.tabElipse = New System.Windows.Forms.TabPage
		Me.tabProcedimiento = New System.Windows.Forms.TabPage
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
		Me.tabLinea.SuspendLayout
		Me.tabLineas.SuspendLayout
		Me.tabCirculo.SuspendLayout
		Me.tabParabola.SuspendLayout
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
		Me.tabLinea.Location = New System.Drawing.Point(0, 74)
		Me.tabLinea.Name = "tabLinea"
		Me.tabLinea.SelectedIndex = 0
		Me.tabLinea.Size = New System.Drawing.Size(298, 304)
		Me.tabLinea.TabIndex = 0
		'
		'tabLineas
		'
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
		Me.tabLineas.Location = New System.Drawing.Point(4, 22)
		Me.tabLineas.Name = "tabLineas"
		Me.tabLineas.Padding = New System.Windows.Forms.Padding(3)
		Me.tabLineas.Size = New System.Drawing.Size(290, 278)
		Me.tabLineas.TabIndex = 0
		Me.tabLineas.Text = "Lineas"
		Me.tabLineas.UseVisualStyleBackColor = true
		'
		'lblPeri
		'
		Me.lblPeri.Location = New System.Drawing.Point(15, 132)
		Me.lblPeri.Name = "lblPeri"
		Me.lblPeri.Size = New System.Drawing.Size(244, 25)
		Me.lblPeri.TabIndex = 18
		Me.lblPeri.Text = "Perimetro de la linea (aprox):"
		'
		'butCalculapl
		'
		Me.butCalculapl.Location = New System.Drawing.Point(171, 92)
		Me.butCalculapl.Name = "butCalculapl"
		Me.butCalculapl.Size = New System.Drawing.Size(64, 19)
		Me.butCalculapl.TabIndex = 15
		Me.butCalculapl.Text = "Graficar"
		Me.butCalculapl.UseVisualStyleBackColor = true
		AddHandler Me.butCalculapl.Click, AddressOf Me.ButCalculaplClick
		'
		'txtLinea4
		'
		Me.txtLinea4.Location = New System.Drawing.Point(115, 92)
		Me.txtLinea4.Name = "txtLinea4"
		Me.txtLinea4.Size = New System.Drawing.Size(25, 20)
		Me.txtLinea4.TabIndex = 13
		'
		'txtLinea3
		'
		Me.txtLinea3.Location = New System.Drawing.Point(84, 92)
		Me.txtLinea3.Name = "txtLinea3"
		Me.txtLinea3.Size = New System.Drawing.Size(25, 20)
		Me.txtLinea3.TabIndex = 12
		'
		'txtLinea2
		'
		Me.txtLinea2.Location = New System.Drawing.Point(51, 92)
		Me.txtLinea2.Name = "txtLinea2"
		Me.txtLinea2.Size = New System.Drawing.Size(24, 20)
		Me.txtLinea2.TabIndex = 11
		'
		'txtLinea1
		'
		Me.txtLinea1.Location = New System.Drawing.Point(21, 92)
		Me.txtLinea1.Name = "txtLinea1"
		Me.txtLinea1.Size = New System.Drawing.Size(24, 20)
		Me.txtLinea1.TabIndex = 10
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(10, 70)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(153, 14)
		Me.label3.TabIndex = 8
		Me.label3.Text = "O inserte 2 puntos de la recta:"
		'
		'butCalculael
		'
		Me.butCalculael.Location = New System.Drawing.Point(185, 39)
		Me.butCalculael.Name = "butCalculael"
		Me.butCalculael.Size = New System.Drawing.Size(61, 21)
		Me.butCalculael.TabIndex = 7
		Me.butCalculael.Text = "Graficar"
		Me.butCalculael.UseVisualStyleBackColor = true
		AddHandler Me.butCalculael.Click, AddressOf Me.ButCalculaelClick
		'
		'txtConstLine
		'
		Me.txtConstLine.Location = New System.Drawing.Point(117, 40)
		Me.txtConstLine.Name = "txtConstLine"
		Me.txtConstLine.Size = New System.Drawing.Size(62, 20)
		Me.txtConstLine.TabIndex = 6
		'
		'txtYline
		'
		Me.txtYline.Location = New System.Drawing.Point(67, 40)
		Me.txtYline.Name = "txtYline"
		Me.txtYline.Size = New System.Drawing.Size(19, 20)
		Me.txtYline.TabIndex = 4
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(33, 43)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(131, 18)
		Me.label2.TabIndex = 2
		Me.label2.Text = "X  +        Y ="
		'
		'txtXline
		'
		Me.txtXline.Location = New System.Drawing.Point(8, 40)
		Me.txtXline.Name = "txtXline"
		Me.txtXline.Size = New System.Drawing.Size(23, 20)
		Me.txtXline.TabIndex = 1
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(3, 12)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(161, 15)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Inserte la ecuacion de la recta:"
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(8, 87)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(164, 32)
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
		Me.tabCirculo.Controls.Add(Me.textBox13)
		Me.tabCirculo.Controls.Add(Me.textBox12)
		Me.tabCirculo.Controls.Add(Me.textBox11)
		Me.tabCirculo.Controls.Add(Me.textBox10)
		Me.tabCirculo.Controls.Add(Me.textBox9)
		Me.tabCirculo.Controls.Add(Me.textBox8)
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
		Me.tabCirculo.Location = New System.Drawing.Point(4, 22)
		Me.tabCirculo.Name = "tabCirculo"
		Me.tabCirculo.Padding = New System.Windows.Forms.Padding(3)
		Me.tabCirculo.Size = New System.Drawing.Size(290, 278)
		Me.tabCirculo.TabIndex = 1
		Me.tabCirculo.Text = "Circulo"
		Me.tabCirculo.UseVisualStyleBackColor = true
		'
		'label14
		'
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label14.Location = New System.Drawing.Point(155, 66)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(16, 14)
		Me.label14.TabIndex = 28
		Me.label14.Text = "2"
		'
		'label13
		'
		Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label13.Location = New System.Drawing.Point(74, 66)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(16, 14)
		Me.label13.TabIndex = 27
		Me.label13.Text = "2"
		'
		'label11
		'
		Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.Location = New System.Drawing.Point(63, 29)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(16, 14)
		Me.label11.TabIndex = 25
		Me.label11.Text = "2"
		'
		'label10
		'
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.Location = New System.Drawing.Point(32, 30)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(16, 14)
		Me.label10.TabIndex = 24
		Me.label10.Text = "2"
		'
		'butcircu3p
		'
		Me.butcircu3p.Location = New System.Drawing.Point(223, 121)
		Me.butcircu3p.Name = "butcircu3p"
		Me.butcircu3p.Size = New System.Drawing.Size(58, 22)
		Me.butcircu3p.TabIndex = 23
		Me.butcircu3p.Text = "Obtener"
		Me.butcircu3p.UseVisualStyleBackColor = true
		'
		'textBox13
		'
		Me.textBox13.Location = New System.Drawing.Point(56, 119)
		Me.textBox13.Name = "textBox13"
		Me.textBox13.Size = New System.Drawing.Size(18, 20)
		Me.textBox13.TabIndex = 21
		'
		'textBox12
		'
		Me.textBox12.Location = New System.Drawing.Point(94, 119)
		Me.textBox12.Name = "textBox12"
		Me.textBox12.Size = New System.Drawing.Size(18, 20)
		Me.textBox12.TabIndex = 20
		'
		'textBox11
		'
		Me.textBox11.Location = New System.Drawing.Point(187, 121)
		Me.textBox11.Name = "textBox11"
		Me.textBox11.Size = New System.Drawing.Size(18, 20)
		Me.textBox11.TabIndex = 19
		'
		'textBox10
		'
		Me.textBox10.Location = New System.Drawing.Point(159, 120)
		Me.textBox10.Name = "textBox10"
		Me.textBox10.Size = New System.Drawing.Size(18, 20)
		Me.textBox10.TabIndex = 18
		'
		'textBox9
		'
		Me.textBox9.Location = New System.Drawing.Point(125, 119)
		Me.textBox9.Name = "textBox9"
		Me.textBox9.Size = New System.Drawing.Size(18, 20)
		Me.textBox9.TabIndex = 17
		'
		'textBox8
		'
		Me.textBox8.Location = New System.Drawing.Point(31, 119)
		Me.textBox8.Name = "textBox8"
		Me.textBox8.Size = New System.Drawing.Size(18, 20)
		Me.textBox8.TabIndex = 16
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(22, 100)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(250, 19)
		Me.label8.TabIndex = 15
		Me.label8.Text = "Inserte 3 coordenadas que toque la circunferencia:"
		'
		'butEcuacircu2
		'
		Me.butEcuacircu2.Location = New System.Drawing.Point(213, 74)
		Me.butEcuacircu2.Name = "butEcuacircu2"
		Me.butEcuacircu2.Size = New System.Drawing.Size(70, 19)
		Me.butEcuacircu2.TabIndex = 14
		Me.butEcuacircu2.Text = "Graficar"
		Me.butEcuacircu2.UseVisualStyleBackColor = true
		AddHandler Me.butEcuacircu2.Click, AddressOf Me.ButEcuacircu2Click
		'
		'txtCoEc2
		'
		Me.txtCoEc2.Location = New System.Drawing.Point(179, 75)
		Me.txtCoEc2.Name = "txtCoEc2"
		Me.txtCoEc2.Size = New System.Drawing.Size(24, 20)
		Me.txtCoEc2.TabIndex = 12
		'
		'txtYce2
		'
		Me.txtYce2.Location = New System.Drawing.Point(125, 75)
		Me.txtYce2.Name = "txtYce2"
		Me.txtYce2.Size = New System.Drawing.Size(24, 20)
		Me.txtYce2.TabIndex = 11
		'
		'txtXce2
		'
		Me.txtXce2.Location = New System.Drawing.Point(42, 74)
		Me.txtXce2.Name = "txtXce2"
		Me.txtXce2.Size = New System.Drawing.Size(22, 20)
		Me.txtXce2.TabIndex = 10
		'
		'butEcuacircu1
		'
		Me.butEcuacircu1.Location = New System.Drawing.Point(199, 11)
		Me.butEcuacircu1.Name = "butEcuacircu1"
		Me.butEcuacircu1.Size = New System.Drawing.Size(73, 21)
		Me.butEcuacircu1.TabIndex = 9
		Me.butEcuacircu1.Text = "Graficar"
		Me.butEcuacircu1.UseVisualStyleBackColor = true
		AddHandler Me.butEcuacircu1.Click, AddressOf Me.ButEcuacircu1Click
		'
		'txtCoEc1
		'
		Me.txtCoEc1.Location = New System.Drawing.Point(187, 38)
		Me.txtCoEc1.Name = "txtCoEc1"
		Me.txtCoEc1.Size = New System.Drawing.Size(27, 20)
		Me.txtCoEc1.TabIndex = 6
		'
		'txtYce1
		'
		Me.txtYce1.Location = New System.Drawing.Point(136, 38)
		Me.txtYce1.Name = "txtYce1"
		Me.txtYce1.Size = New System.Drawing.Size(23, 20)
		Me.txtYce1.TabIndex = 5
		'
		'txtXce1
		'
		Me.txtXce1.Location = New System.Drawing.Point(84, 38)
		Me.txtXce1.Name = "txtXce1"
		Me.txtXce1.Size = New System.Drawing.Size(24, 20)
		Me.txtXce1.TabIndex = 4
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(19, 39)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(253, 21)
		Me.label6.TabIndex = 1
		Me.label6.Text = "X  +  Y  +       X +        Y ="
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(22, 11)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(165, 19)
		Me.label5.TabIndex = 0
		Me.label5.Text = "Inserte la ecuación del ciruculo:"
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(8, 74)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(179, 26)
		Me.label7.TabIndex = 13
		Me.label7.Text = "(X -         )  + (Y -        )  ="
		'
		'label9
		'
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.Location = New System.Drawing.Point(18, 120)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(238, 25)
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
		Me.tabParabola.Controls.Add(Me.label27)
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
		Me.tabParabola.Location = New System.Drawing.Point(4, 22)
		Me.tabParabola.Name = "tabParabola"
		Me.tabParabola.Size = New System.Drawing.Size(290, 278)
		Me.tabParabola.TabIndex = 2
		Me.tabParabola.Text = "Parabola"
		Me.tabParabola.UseVisualStyleBackColor = true
		'
		'label29
		'
		Me.label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label29.Location = New System.Drawing.Point(33, 151)
		Me.label29.Name = "label29"
		Me.label29.Size = New System.Drawing.Size(16, 14)
		Me.label29.TabIndex = 47
		Me.label29.Text = "2"
		'
		'butGrPVG
		'
		Me.butGrPVG.Location = New System.Drawing.Point(201, 157)
		Me.butGrPVG.Name = "butGrPVG"
		Me.butGrPVG.Size = New System.Drawing.Size(73, 21)
		Me.butGrPVG.TabIndex = 46
		Me.butGrPVG.Text = "Graficar"
		Me.butGrPVG.UseVisualStyleBackColor = true
		AddHandler Me.butGrPVG.Click, AddressOf Me.ButGrPVGClick
		'
		'butGrPVR
		'
		Me.butGrPVR.Location = New System.Drawing.Point(201, 130)
		Me.butGrPVR.Name = "butGrPVR"
		Me.butGrPVR.Size = New System.Drawing.Size(73, 21)
		Me.butGrPVR.TabIndex = 45
		Me.butGrPVR.Text = "Graficar"
		Me.butGrPVR.UseVisualStyleBackColor = true
		AddHandler Me.butGrPVR.Click, AddressOf Me.ButGrPVRClick
		'
		'butGrPHG
		'
		Me.butGrPHG.Location = New System.Drawing.Point(201, 72)
		Me.butGrPHG.Name = "butGrPHG"
		Me.butGrPHG.Size = New System.Drawing.Size(73, 21)
		Me.butGrPHG.TabIndex = 44
		Me.butGrPHG.Text = "Graficar"
		Me.butGrPHG.UseVisualStyleBackColor = true
		AddHandler Me.butGrPHG.Click, AddressOf Me.ButGrPHGClick
		'
		'butGrPHR
		'
		Me.butGrPHR.Location = New System.Drawing.Point(201, 36)
		Me.butGrPHR.Name = "butGrPHR"
		Me.butGrPHR.Size = New System.Drawing.Size(73, 21)
		Me.butGrPHR.TabIndex = 43
		Me.butGrPHR.Text = "Graficar"
		Me.butGrPHR.UseVisualStyleBackColor = true
		AddHandler Me.butGrPHR.Click, AddressOf Me.ButGrPHRClick
		'
		'txtPvrA
		'
		Me.txtPvrA.Location = New System.Drawing.Point(51, 131)
		Me.txtPvrA.Name = "txtPvrA"
		Me.txtPvrA.Size = New System.Drawing.Size(22, 20)
		Me.txtPvrA.TabIndex = 42
		'
		'txtPvrF
		'
		Me.txtPvrF.Location = New System.Drawing.Point(142, 161)
		Me.txtPvrF.Name = "txtPvrF"
		Me.txtPvrF.Size = New System.Drawing.Size(22, 20)
		Me.txtPvrF.TabIndex = 41
		'
		'txtPvrE
		'
		Me.txtPvrE.Location = New System.Drawing.Point(96, 160)
		Me.txtPvrE.Name = "txtPvrE"
		Me.txtPvrE.Size = New System.Drawing.Size(22, 20)
		Me.txtPvrE.TabIndex = 40
		'
		'txtPvrD
		'
		Me.txtPvrD.Location = New System.Drawing.Point(49, 160)
		Me.txtPvrD.Name = "txtPvrD"
		Me.txtPvrD.Size = New System.Drawing.Size(22, 20)
		Me.txtPvrD.TabIndex = 39
		'
		'txtPvrB
		'
		Me.txtPvrB.Location = New System.Drawing.Point(157, 131)
		Me.txtPvrB.Name = "txtPvrB"
		Me.txtPvrB.Size = New System.Drawing.Size(22, 20)
		Me.txtPvrB.TabIndex = 38
		'
		'txtPvrP
		'
		Me.txtPvrP.Location = New System.Drawing.Point(105, 131)
		Me.txtPvrP.Name = "txtPvrP"
		Me.txtPvrP.Size = New System.Drawing.Size(22, 20)
		Me.txtPvrP.TabIndex = 37
		'
		'label28
		'
		Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label28.Location = New System.Drawing.Point(79, 123)
		Me.label28.Name = "label28"
		Me.label28.Size = New System.Drawing.Size(16, 14)
		Me.label28.TabIndex = 36
		Me.label28.Text = "2"
		'
		'label27
		'
		Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label27.Location = New System.Drawing.Point(21, 161)
		Me.label27.Name = "label27"
		Me.label27.Size = New System.Drawing.Size(218, 22)
		Me.label27.TabIndex = 35
		Me.label27.Text = "y  +      y +       x +       = 0"
		'
		'label26
		'
		Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label26.Location = New System.Drawing.Point(21, 132)
		Me.label26.Name = "label26"
		Me.label26.Size = New System.Drawing.Size(218, 22)
		Me.label26.TabIndex = 34
		Me.label26.Text = "(x +       )  =        (y +       )"
		'
		'txtPhrF
		'
		Me.txtPhrF.Location = New System.Drawing.Point(142, 70)
		Me.txtPhrF.Name = "txtPhrF"
		Me.txtPhrF.Size = New System.Drawing.Size(22, 20)
		Me.txtPhrF.TabIndex = 33
		'
		'txtPhrD
		'
		Me.txtPhrD.Location = New System.Drawing.Point(49, 70)
		Me.txtPhrD.Name = "txtPhrD"
		Me.txtPhrD.Size = New System.Drawing.Size(22, 20)
		Me.txtPhrD.TabIndex = 32
		'
		'txtPhrE
		'
		Me.txtPhrE.Location = New System.Drawing.Point(97, 70)
		Me.txtPhrE.Name = "txtPhrE"
		Me.txtPhrE.Size = New System.Drawing.Size(22, 20)
		Me.txtPhrE.TabIndex = 31
		'
		'label25
		'
		Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label25.Location = New System.Drawing.Point(21, 71)
		Me.label25.Name = "label25"
		Me.label25.Size = New System.Drawing.Size(218, 22)
		Me.label25.TabIndex = 30
		Me.label25.Text = "x  +       x +       y +      = 0"
		'
		'txtPhrP
		'
		Me.txtPhrP.Location = New System.Drawing.Point(99, 35)
		Me.txtPhrP.Name = "txtPhrP"
		Me.txtPhrP.Size = New System.Drawing.Size(22, 20)
		Me.txtPhrP.TabIndex = 29
		'
		'txtPhrB
		'
		Me.txtPhrB.Location = New System.Drawing.Point(153, 35)
		Me.txtPhrB.Name = "txtPhrB"
		Me.txtPhrB.Size = New System.Drawing.Size(22, 20)
		Me.txtPhrB.TabIndex = 28
		'
		'txtPhrA
		'
		Me.txtPhrA.Location = New System.Drawing.Point(46, 34)
		Me.txtPhrA.Name = "txtPhrA"
		Me.txtPhrA.Size = New System.Drawing.Size(22, 20)
		Me.txtPhrA.TabIndex = 27
		'
		'label24
		'
		Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label24.Location = New System.Drawing.Point(31, 59)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(16, 14)
		Me.label24.TabIndex = 26
		Me.label24.Text = "2"
		'
		'label23
		'
		Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label23.Location = New System.Drawing.Point(79, 23)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(16, 14)
		Me.label23.TabIndex = 25
		Me.label23.Text = "2"
		'
		'label22
		'
		Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label22.Location = New System.Drawing.Point(18, 35)
		Me.label22.Name = "label22"
		Me.label22.Size = New System.Drawing.Size(218, 22)
		Me.label22.TabIndex = 2
		Me.label22.Text = "(y +       )  =        (x +       )"
		'
		'label21
		'
		Me.label21.Location = New System.Drawing.Point(14, 110)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(223, 17)
		Me.label21.TabIndex = 1
		Me.label21.Text = "Inserte la ecuacion de la parabola vertical"
		'
		'label20
		'
		Me.label20.Location = New System.Drawing.Point(14, 11)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(223, 17)
		Me.label20.TabIndex = 0
		Me.label20.Text = "Inserte la ecuación de la parabola horizontal:"
		'
		'tabElipse
		'
		Me.tabElipse.Location = New System.Drawing.Point(4, 22)
		Me.tabElipse.Name = "tabElipse"
		Me.tabElipse.Size = New System.Drawing.Size(290, 278)
		Me.tabElipse.TabIndex = 4
		Me.tabElipse.Text = "Elipse"
		Me.tabElipse.UseVisualStyleBackColor = true
		'
		'tabProcedimiento
		'
		Me.tabProcedimiento.Controls.Add(Me.label12)
		Me.tabProcedimiento.Controls.Add(Me.txtLog)
		Me.tabProcedimiento.Location = New System.Drawing.Point(4, 22)
		Me.tabProcedimiento.Name = "tabProcedimiento"
		Me.tabProcedimiento.Padding = New System.Windows.Forms.Padding(3)
		Me.tabProcedimiento.Size = New System.Drawing.Size(290, 278)
		Me.tabProcedimiento.TabIndex = 3
		Me.tabProcedimiento.Text = "Procedimiento"
		Me.tabProcedimiento.UseVisualStyleBackColor = true
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(8, 9)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(178, 18)
		Me.label12.TabIndex = 1
		Me.label12.Text = "Procedimiento de la última acción:"
		'
		'txtLog
		'
		Me.txtLog.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtLog.Location = New System.Drawing.Point(8, 30)
		Me.txtLog.Multiline = true
		Me.txtLog.Name = "txtLog"
		Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtLog.Size = New System.Drawing.Size(276, 214)
		Me.txtLog.TabIndex = 0
		'
		'pictureBox1
		'
		Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
		Me.pictureBox1.Location = New System.Drawing.Point(304, 105)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(260, 260)
		Me.pictureBox1.TabIndex = 1
		Me.pictureBox1.TabStop = false
		AddHandler Me.pictureBox1.Click, AddressOf Me.PictureBox1Click
		'
		'lblTitle
		'
		Me.lblTitle.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitle.Location = New System.Drawing.Point(19, 30)
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
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(576, 377)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.tabLinea)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.Text = "Visual Geometrix"
		Me.tabLinea.ResumeLayout(false)
		Me.tabLineas.ResumeLayout(false)
		Me.tabLineas.PerformLayout
		Me.tabCirculo.ResumeLayout(false)
		Me.tabCirculo.PerformLayout
		Me.tabParabola.ResumeLayout(false)
		Me.tabParabola.PerformLayout
		Me.tabProcedimiento.ResumeLayout(false)
		Me.tabProcedimiento.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
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
	Private textBox8 As System.Windows.Forms.TextBox
	Private textBox9 As System.Windows.Forms.TextBox
	Private textBox10 As System.Windows.Forms.TextBox
	Private textBox11 As System.Windows.Forms.TextBox
	Private textBox12 As System.Windows.Forms.TextBox
	Private textBox13 As System.Windows.Forms.TextBox
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
