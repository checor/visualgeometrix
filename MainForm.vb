' Visual Geometrix - Aplicación didáctica para Geometría Analítica
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

'No se recomienda usar TAB al usar el programa
Option Explicit On
Imports System.Drawing.Drawing2D
Imports System.Math
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	Public Sub printf(texto as String)
		Me.txtLog.AppendText(texto)
		me.txtLog.AppendText(vbCrLf)'Esto en "\n" en C
	End Sub
	Public Sub clrscr()
		me.txtLog.Text = ""
	End Sub
	Public Sub Cuadricula()
        'Codigo propiedad de Percy Reyes
        'dibujamos la coordenada Y
        Me.PictureBox1.CreateGraphics.DrawLine(New Pen(Color.Red, 3), _
        New PointF(Me.PictureBox1.Width / 2, 0), _
        New PointF(Me.PictureBox1.Width / 2, Me.PictureBox1.Height))
        'dibujamos la coordenada X
        Me.PictureBox1.CreateGraphics.DrawLine(New Pen(Color.Red, 3), _
        New PointF(0, Me.PictureBox1.Height / 2), _
        New PointF(Me.PictureBox1.Width, Me.PictureBox1.Height / 2))
        'dibujo de toda cuadricula
        Dim NroLines As Integer = 0
        'lineas horizontales de la cuadrícula de fondo
        For NroLines = 0 To Me.PictureBox1.Height Step 10
            Me.PictureBox1.CreateGraphics.DrawLine(New Pen(SystemColors.Highlight, 1), _
            New Point(0, NroLines), New Point(Me.PictureBox1.Width, NroLines))
        Next
        'lineas verticales de la cuadrícula de fondo
        For NroLines = 0 To Me.PictureBox1.Width Step 10
            Me.PictureBox1.CreateGraphics.DrawLine(New Pen(SystemColors.Highlight, 1), _
            New Point(NroLines, 0), New Point(NroLines, Me.PictureBox1.Height))
        Next
    End Sub
    Public function distancia(x1 As Single,y1 As Single, x2 As Single, y2 As Single) as Single
    	dim texto as String
    	texto="Obtener distancia de "& x1 &"," & y1 &") a (" & x2 &"," & y2 &")"
    	printf(texto)
    	distancia=Sqrt((y2-y1)^2 + (x2 - x1)^2)
    	texto="La distancia es:" & distancia
    	printf(texto)
    End function
	Public Sub graficaLinea(x1 As Single, y1 As Single, x2 as single, y2 as single)
		'Existe el problema con imprime curva a la hora de imprimir
		'dim texto as String
		Dim centro As Single = Me.pictureBox1.Height / 2
		Dim punto As Single = Me.pictureBox1.Height / 13
		'texto="Graficar una linea de (" & x1 & "," & y1 & ") a (" & x2 & "," & y2 & ")"
	'	printf(texto)
		Me.pictureBox1.CreateGraphics.DrawLine(New Pen(color.Blue,1), _
		New PointF(centro + ((x1/2)*punto),centro + ((y1/-2)*punto)), _
		New PointF(centro + ((x2/2)*punto),centro + ((y2/-2)*punto)) )
	End Sub
	Public Sub imprimecurva(cx As Single, cy As Single, Constante As Single)
		'No imprime circulos ni elipses! Tira error!
		'Falta mejorar en este campo el LOG
		'Ahora ya no aceptan exponentes ni margen de error
		Dim texto As String
		texto = "Graficar una linea con la ecuación " & cx & "x + " & cy & "y = " & Constante & " ..."
		printf(texto)
		texto = "En la ecuación X = (" & constante & " - " & cy & "y) /" & cx
		printf(texto)
		texto = "En la ecuación Y = (" & constante & " - " & cx & "x) /" & cy
		printf(texto)
		If cx = 0 or cy = 0 Then
			printf("No es posible graficar con los parametros dados.")
		elseIf cx < 0 or cx > 0 Then
			texto = "Sustituir X a -14 para graficar en el área del plano"
			printf(texto)
			Dim menosy As Single = (constante -(cx*-14)) / cy 'Y
			texto = "Punto 1 de la linea = (-14 , " & menosy & ")"
			printf(texto)
			Dim masy As Single = (constante -(cx*14)) / cy
			texto = "Punto 2 de la linea = (14 , " & masy & ")"
			printf(texto)
			graficaLinea(-14,menosy,14,masy)
			texto = "Se grafica la línea con los puntos mencionados"
			printf(texto)
		Else ' Se hace con y
			texto = "Sustituir Y a -14 para graficar en el área del plano"
			printf(texto)
			Dim menosx As Single = (constante -(cy*-14)) / cx 'X
			texto = "Punto 1 de la linea = (" & menosx & " , -14)"
			printf(texto)
			Dim masx As Single = (constante -(cy*14)) / cx
			texto = "Punto 2 de la linea = (" & masx & " , 14)"
			printf(texto)
			graficaLinea(menosx,-14,masx,14)
			texto = "Se grafica la línea con los puntos mencionados"
			printf(texto)
		End If
		printf("")'Dejando un enter
	End Sub
	Public Sub dibujacirculo(h As Single, k As Single, hr As Single, vr as single)
		'Quitado el LOG de dibujacirculo, pasado a funciones mas altas
		Dim centro As Single = Me.pictureBox1.Height / 2
		Dim punto As Single = Me.pictureBox1.Height / 13
		h=centro+(punto/-2 * (h)) : k = centro+(punto/-2 * (k))
		hr=punto * (hr) : vr=punto * (vr)
		Me.pictureBox1.creategraphics.drawellipse(New pen(color.Blue,1), _
		h-hr/2 ,k-vr/2 , hr, vr)
	End Sub
	Sub PictureBox1Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.pictureBox1.Refresh
		cuadricula()
	End Sub
	Sub ButCalculaplClick(ByVal sender As Object, ByVal e As EventArgs)
		cuadricula()
		graficalinea(val(Me.txtLinea1.Text),val(Me.txtLinea2.Text),val(Me.txtLinea3.Text), _
					val(Me.txtLinea4.Text))
	End Sub
	Sub ButEcuacircu1Click(ByVal sender As Object, ByVal e As EventArgs)
		'Ecuación larga del circulo
		dim texto as string
		Dim x As Single = val(txtXce1.Text)
		Dim y As Single = val(Me.txtYce1.Text)
		Dim cons As Single = val(Me.txtCoEc1.Text)
		texto = "Graficar un círculo con la ecuación X^2 + Y^2 + " & x & "x + " & y & "y = " & cons
		printf(texto)
		Dim h As Single = x/2 : dim k as Single = -y/2
		texto = "Coordenada x (h) del centro del círculo = " & x & "/2 = " & h
		printf(texto)
		texto = "Coordenada y (k) del centro del círculo = " & -y & "/2 = " & k
		printf(texto)
		texto = "Ecuación del radio: r^2 = (h/2)^2 + (k/2)^2 - constante"
		printf(texto)
		texto = "Sustituyendo: r^2 =( " & h & " /2)^2 + ( " & k & " /2)^2 + " & cons
		printf(texto)
		Dim radio As Single = sqrt((x/2)^2 + (y/2)^2 + cons)
		texto = "El radio es: " & radio
		printf(texto)
		texto = "Dibujar el círculo con los datos anteriores"
		printf(texto)
		printf("")
		dibujacirculo(h,k,radio,radio)
	End Sub
	Sub ButEcuacircu2Click(ByVal sender As Object, ByVal e As EventArgs)
		'Ecuacion tipo uno del circulo (la simplificada)
		dim texto as string
		Dim x As Single = val(txtXce2.Text)
		Dim y As Single = val(Me.txtYce2.Text)
		Dim cons As Single = val(Me.txtCoEc2.Text)
		texto = "Graficar circulo con la ecuación (x - " & x & ")^2 + (y - " & y & ")^2 = " & cons
		printf(texto)
		Dim h As Single = -x : dim k as Single = y
		texto = "Coordenadas del centro de la circunferencia ( " & h & " , " & k & " )"
		printf(texto)
		Dim radio As Single = sqrt(cons)
		texto = "Radio del círculo: " & radio
		printf(texto)
		texto = "Graficar el círculo con los datos anteriores"
		printf(texto)
		printf("")
		dibujacirculo(h,k,radio,radio)
	End Sub
	public sub parabolaverti(D as single,E as single,F as single)
		dim punto(0 to 1) as single : dim i as integer = 0 : dim P as single = D
		punto(0)=F/D: punto(1)=E/2 'Punto 0 = X : Punto 1 = Y
		dim x as single = 0:dim xmas as single =0
		for	i=-14 to 14
			x= ((4*i) - i*i - F) / D
			xmas = ( (4*(i+1)) - (i+1)*(i+1) - F) / D
			graficalinea(x,i,xmas,i+1)
		next i
	end sub
	public sub parabolavertireduced(a as single,p as single,b as single)
		dim D as single = a * 2
		dim E as single = -p
		dim F as single = -(p*b)
		parabolaverti(D,E,F)
	end sub
	public sub parabolahorizontal(D as single,E as single ,F as single)
		dim y as single = 0 : dim ymas as single = 0
		dim i  as integer = 0
		for i=-14 to 14
			y= (-(i*i)-(4*i)-F)/E
			ymas = (-((i+1)*(i+1))-(4*(i+1))-F)/E
			graficalinea(i,y,i+1,ymas)
		next i
	end sub
	public sub parabolahorizontalreduced(a as single,p as single,b as Single)
		dim D as single = a*2
		dim E as single = -p
		dim F as single =-(b*p)
		parabolahorizontal(D,E,F)
	End Sub
	public sub trescircu(x1 as single,y1 as single,x2 as single,y2 as single,x3 as single,y3 as single)
		'Ya estan lo de las 3 ecuaciones
		dim ecua1(0 to 3) as single
		ecua1(0)=x1^2 + y1^2: ecua1(1)=x1 : ecua1(2) = y1 : ecua1(3) = 1
		dim ecua2(0 to 3) as single
		ecua2(0)=x2^2 + y2^2: ecua2(1)=x2 : ecua2(2) = y2 : ecua2(3) = 1
		dim ecua3(0 to 3) as single
		ecua3(0)=x3^2 + y3^2: ecua3(1)=x3 : ecua3(2) = y3 : ecua3(3) = 1
		dim i as Integer = 0
		'dim ecua2neg(0 to 3) as single
		'for i=0 to 3
		'	ecua2neg(i)=ecua2(i)*-1 ' La segunda ecuacion la vuevo negativa
		'next i
		dim primerresu(0 to 3) as single
		for i=0 to 3
			primerresu(i)=ecua1(i) - ecua2(i) 'Eliminar F
		next i
		dim segundoresu(0 to 3) as single
		for i=0 to 3
			segundoresu(i)=ecua2(i) - ecua3(i) 'Debo de eliminar F
		next i
		dim respa as single = primerresu(1) 'Guardar coeficiente de D
		for i=0 to 3
			primerresu(i)=primerresu(i) * segundoresu(1) ' Me preparo para eliminar D
		next i
		for i=0 to 3
			segundoresu(i)=segundoresu(i) * respa 'Tambien la preparo
		next i
		dim ecuagood1(0 to 3) as single 'La esperada ecuacion sencilla
		for i=0 to 3
			ecuagood1(i)=primerresu(i)-segundoresu(i) 'Vuala, una ecuacion solo con E
		next i
		dim E as single = -(ecuagood1(0)) / ecuagood1(2)
		dim D as single = (-(primerresu(0))-primerresu(2)*E)/primerresu(1)
		dim F as single = -(ecua1(0)-ecua1(1)*D-ecua1(2)*E)/ecua1(3)
		Dim radio As Single = sqrt(F)
		dibujacirculo(E,D,radio,radio)
	end sub
	
	Sub ButGrPHRClick(ByVal sender As Object, ByVal e As EventArgs)
		on error goto err
		parabolavertireduced(val(txtPhrA.Text),val(txtPhrP.text),val(txtPhrB.Text))
		err:
		dim pen as Integer = 0
	End Sub
	
	Sub ButGrPHGClick(ByVal sender As Object, ByVal e As EventArgs)
		on error goto err
		parabolaverti(val(txtPhrD.Text),val(txtPhrE.Text),val(txtPhrF.Text))
		err:
		dim pen as Integer = 0
	End Sub
	
	Sub ButGrPVRClick(ByVal sender As Object, ByVal e As EventArgs)
		'Quitar las gillipoleces de on error
		on error goto err:
		parabolahorizontalreduced(val(txtPvrA.Text),val(txtPvrP.Text),val(txtPvrB.Text))
		err:
		dim p as Single = 0.000
	End Sub
	
	Sub ButGrPVGClick(ByVal sender As Object, ByVal e As EventArgs)
		On Error GoTo err:
		parabolahorizontal(val(txtPvrD.Text),val(txtPvrE.Text),val(txtPvrF.Text))
		err:
	End Sub
	Sub ButCalculaelClick(ByVal sender As Object, ByVal e As EventArgs)
		imprimecurva(val(me.txtXline.Text),val(me.txtYline.Text),val(me.txtConstLine.Text))
	End Sub
End Class
