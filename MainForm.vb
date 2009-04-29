'Geometrico Analitico
'Version Pre-Alpha 0.0 Unstable
'Checor
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
    	distancia=Sqrt((y2-y1)^2 + (x2 - x1)^2)
    End function
	Public Sub graficaLinea(x1 As Single, y1 As Single, x2 as single, y2 as single)
		'Funciona ok
		Dim centro As Single = Me.pictureBox1.Height / 2
		Dim punto As Single = Me.pictureBox1.Height / 13
		Me.pictureBox1.CreateGraphics.DrawLine(New Pen(color.Blue,1), _
		New PointF(centro + ((x1/2)*punto),centro + ((y1/-2)*punto)), _
		New PointF(centro + ((x2/2)*punto),centro + ((y2/-2)*punto)) )
	End Sub
	Public Sub imprimecurva(cx As Single, ex As Single, cy As Single, ey As Single, Constante As Single, margen as Single)
		'No imprime circulos ni elipses! Tira error!
		Dim a(0 To 1) As Single
		if ey = 2  or ex+ey=2 then
			a(0) = ((constante - cy * -14 ^ ey) / cx) ^ ( 1 / ex)
			a(1) = ((constante-cy* (-14 + margen) ^ ey)/cx) ^ (1/ex) 
			graficalinea(a(0),-14,a(1),-14+margen)
			Dim i As Single =-14 + (margen * 2)
			While i < 14 
				a(0) = a(1)
				a(1) = ((constante-cy*i ^ ey)/cx) ^ (1/ex)
				graficalinea(a(0),i-margen,a(1),i)
				i = i + margen
			End While
		Else 'Ye
			a(0) = ((constante - cx * -14 ^ ex) / cy) ^ ( 1 / ey)
			a(1) = ((constante-cx* (-14 + margen) ^ ex)/cy) ^ (1/ey) 
			graficalinea(a(0),-14,a(1),-14+margen)
			Dim i As Single =-14 + (margen * 2)
			While i < 14 
				a(0) = a(1)
				a(1) = ((constante-cx*i ^ ex)/cy) ^ (1/ey)
				graficalinea(i-margen,a(0),i,a(1))
				i = i + margen
			End While
		End if
	End Sub
	Public Sub dibujacirculo(h As Single, k As Single, hr As Single, vr as single)
		'OK
		Dim centro As Single = Me.pictureBox1.Height / 2
		Dim punto As Single = Me.pictureBox1.Height / 13
		h=centro+(punto/-2 * (h)) : k = centro+(punto/-2 * (k))
		hr=punto * (hr) : vr=punto * (vr)
		Me.pictureBox1.creategraphics.drawellipse(New pen(color.Blue,1), _
		h-hr/2 ,k-vr/2 , hr, vr)
	End Sub
	public function interline (cx As Single, cy As Single, cons As Single,cx2 As Single ,cy2 As Single,cons2 As Single) as String
		'ini
		dim ori as Single=cx:dim ori2 as Single=cy: dim ori3 as Single=cons
		cx=cx*cx2:cy=cy*cx2:cons=cons*cx2
		cx2=cx2*ori:cy2=cy2*ori:cons2=cons2*ori
		cy=cy-cy2:cons=cons-cons2
		Dim y As Single = cons/cy:Dim x As Single= (ori2*y-ori3)/ori
		dim nep as String = "(" & x & "," & y & ")"
		interline = nep
	End function
	Public Function FindLineCircleIntersections(ByVal cx As _
    	Single, ByVal cy As Single, ByVal radius As Single, _
	    ByVal x1 As Single, ByVal y1 As Single, ByVal x2 As _
    	Single, ByVal y2 As Single) As string 'Codigo de dominio publico
	    Dim dx As Single: dim ix1 as Single: dim iy1 as Single
	    Dim dy As Single: dim ix2 as Single: dim iy2 as Single
	    Dim A As Single
	    Dim B As Single
	    Dim C As Single
	    Dim det As Single
	    Dim t As Single

	    dx = x2 - x1
	    dy = y2 - y1

	    A = dx * dx + dy * dy
	    B = 2 * (dx * (x1 - cx) + dy * (y1 - cy))
	    C = (x1 - cx) * (x1 - cx) + (y1 - cy) * (y1 - cy) - _
	        radius * radius

 	   det = B * B - 4 * A * C
	    If (A <= 0.0000001) Or (det < 0) Then
	        ' No real solutions.
	        FindLineCircleIntersections = ""
	    ElseIf det = 0 Then
	        ' One solution.
	        t = -B / (2 * A)
	        ix1 = x1 + t * dx
	        iy1 = y1 + t * dy
	        dim nep as string = "(" & ix1 & "," & iy1 & ")"
			FindLineCircleIntersections = nep
		Else
	        ' Two solutions.
	        t = (-B + Sqrt(det)) / (2 * A)
	        ix1 = x1 + t * dx
	        iy1 = y1 + t * dy
	        t = (-B - Sqrt(det)) / (2 * A)
	        ix2 = x1 + t * dx
	        iy2 = y1 + t * dy
	        Dim nepe As String
	        nepe ="(" & ix1 & "," & iy1 & ") (" & ix2 & "," & iy2 & ")"
			FindLineCircleIntersections = nepe
	    End If
	End Function
	Public Function interlinecircle(x As Single, y As Single, cons As Single, x2 As Single,y2 as Single, cons2 as Single) As String
		Dim equis1 As Single = (cons - y*100)/x
		Dim ye1 As Single =(cons - x*100)/y
		Dim equis2 As Single = (cons - y*-100)/x
		Dim ye2 As Single =(cons - x*-100)/y
		Dim radio As Single = sqrt(cons2)
		Dim resultado As String = FindLineCircleIntersections(-x2,-y2,radio,equis1,ye1,equis2,ye2)
		interlinecircle = resultado
	End Function
	Sub ButCalculaelClick(ByVal sender As Object, ByVal e As EventArgs)
		cuadricula()
		imprimecurva(val(Me.txtXline.Text),val(Me.nudLineX.Value), _
					val(Me.txtYline.Text), val(Me.nudLineY.Value), _
					val(me.txtConstLine.Text), .1)
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
	Sub NudLineXValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		If Me.nudLineY.Value = 2 And Me.nudLineX.Value = 2 Then
			me.nudLineY.Value = 1
		End If
	End Sub
	Sub NudLineYValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		If Me.nudLineY.Value = 2 And Me.nudLineX.Value = 2 Then
			me.nudLineX.Value = 1
		End If
	End Sub
	Sub ButEcuacircu1Click(ByVal sender As Object, ByVal e As EventArgs)
		'Se necesita convertir la ecuacion a tipo 2 para graficar
		Dim x As Single = val(txtXce1.Text)
		Dim y As Single = val(Me.txtYce1.Text)
		Dim cons As Single = val(Me.txtCoEc1.Text)
		Dim h As Single = x/2 : dim k as Single = -y/2
		Dim radio As Single = sqrt((x/2)^2+(y/2)^2 + cons)
		dibujacirculo(h,k,radio,radio)
	End Sub
	Sub ButEcuacircu2Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim x As Single = val(txtXce2.Text)
		Dim y As Single = val(Me.txtYce2.Text)
		Dim cons As Single = val(Me.txtCoEc2.Text)
		Dim h As Single = -x : dim k as Single = y
		Dim radio As Single = sqrt(cons)
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
End Class
