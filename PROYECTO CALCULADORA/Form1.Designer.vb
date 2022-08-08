<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtvisor = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnraiz = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btncoma = New System.Windows.Forms.Button()
        Me.btnigual = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.btnresta = New System.Windows.Forms.Button()
        Me.btnmulti = New System.Windows.Forms.Button()
        Me.btndivi = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnborrarderecha = New System.Windows.Forms.Button()
        Me.btnporcentaje = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbloperacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtvisor
        '
        Me.txtvisor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtvisor.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtvisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvisor.Location = New System.Drawing.Point(10, 29)
        Me.txtvisor.Name = "txtvisor"
        Me.txtvisor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtvisor.Size = New System.Drawing.Size(228, 35)
        Me.txtvisor.TabIndex = 0
        Me.txtvisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtvisor.UseWaitCursor = True
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.MediumBlue
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn1.Location = New System.Drawing.Point(10, 167)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(54, 50)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.MediumBlue
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn4.Location = New System.Drawing.Point(10, 218)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(54, 50)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.MediumBlue
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn7.Location = New System.Drawing.Point(10, 269)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(54, 50)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.MediumBlue
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn0.Location = New System.Drawing.Point(10, 320)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(54, 50)
        Me.btn0.TabIndex = 10
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnraiz
        '
        Me.btnraiz.BackColor = System.Drawing.Color.DarkBlue
        Me.btnraiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnraiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnraiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnraiz.Image = CType(resources.GetObject("btnraiz.Image"), System.Drawing.Image)
        Me.btnraiz.Location = New System.Drawing.Point(10, 116)
        Me.btnraiz.Name = "btnraiz"
        Me.btnraiz.Size = New System.Drawing.Size(54, 50)
        Me.btnraiz.TabIndex = 20
        Me.btnraiz.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.MediumBlue
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn2.Location = New System.Drawing.Point(65, 167)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(54, 50)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.MediumBlue
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn3.Location = New System.Drawing.Point(120, 167)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(54, 50)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.MediumBlue
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn6.Location = New System.Drawing.Point(120, 218)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(54, 50)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.MediumBlue
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn8.Location = New System.Drawing.Point(65, 269)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(54, 50)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.MediumBlue
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn9.Location = New System.Drawing.Point(120, 269)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(54, 50)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btncoma
        '
        Me.btncoma.BackColor = System.Drawing.Color.MediumBlue
        Me.btncoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncoma.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncoma.Location = New System.Drawing.Point(65, 320)
        Me.btncoma.Name = "btncoma"
        Me.btncoma.Size = New System.Drawing.Size(54, 50)
        Me.btncoma.TabIndex = 11
        Me.btncoma.Text = ","
        Me.btncoma.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btncoma.UseVisualStyleBackColor = False
        '
        'btnigual
        '
        Me.btnigual.BackColor = System.Drawing.Color.DarkBlue
        Me.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnigual.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnigual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnigual.Location = New System.Drawing.Point(120, 320)
        Me.btnigual.Name = "btnigual"
        Me.btnigual.Size = New System.Drawing.Size(110, 50)
        Me.btnigual.TabIndex = 12
        Me.btnigual.Text = "="
        Me.btnigual.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.MediumBlue
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn5.Location = New System.Drawing.Point(65, 218)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(54, 50)
        Me.btn5.TabIndex = 13
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btnsuma
        '
        Me.btnsuma.BackColor = System.Drawing.Color.DarkBlue
        Me.btnsuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsuma.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsuma.Location = New System.Drawing.Point(175, 116)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(54, 50)
        Me.btnsuma.TabIndex = 14
        Me.btnsuma.Text = "+"
        Me.btnsuma.UseVisualStyleBackColor = False
        '
        'btnresta
        '
        Me.btnresta.BackColor = System.Drawing.Color.DarkBlue
        Me.btnresta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnresta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnresta.Location = New System.Drawing.Point(175, 167)
        Me.btnresta.Name = "btnresta"
        Me.btnresta.Size = New System.Drawing.Size(54, 50)
        Me.btnresta.TabIndex = 15
        Me.btnresta.Text = "-"
        Me.btnresta.UseVisualStyleBackColor = False
        '
        'btnmulti
        '
        Me.btnmulti.BackColor = System.Drawing.Color.DarkBlue
        Me.btnmulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmulti.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmulti.Location = New System.Drawing.Point(175, 218)
        Me.btnmulti.Name = "btnmulti"
        Me.btnmulti.Size = New System.Drawing.Size(54, 50)
        Me.btnmulti.TabIndex = 16
        Me.btnmulti.Text = "*"
        Me.btnmulti.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnmulti.UseVisualStyleBackColor = False
        '
        'btndivi
        '
        Me.btndivi.BackColor = System.Drawing.Color.DarkBlue
        Me.btndivi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndivi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndivi.Location = New System.Drawing.Point(175, 269)
        Me.btndivi.Name = "btndivi"
        Me.btndivi.Size = New System.Drawing.Size(54, 50)
        Me.btndivi.TabIndex = 17
        Me.btndivi.Text = "/"
        Me.btndivi.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.DarkBlue
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnclear.Location = New System.Drawing.Point(120, 116)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(54, 50)
        Me.btnclear.TabIndex = 18
        Me.btnclear.Text = "c"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnborrarderecha
        '
        Me.btnborrarderecha.BackColor = System.Drawing.Color.DarkBlue
        Me.btnborrarderecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnborrarderecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrarderecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnborrarderecha.Location = New System.Drawing.Point(175, 74)
        Me.btnborrarderecha.Name = "btnborrarderecha"
        Me.btnborrarderecha.Size = New System.Drawing.Size(54, 41)
        Me.btnborrarderecha.TabIndex = 19
        Me.btnborrarderecha.Text = "<--"
        Me.btnborrarderecha.UseVisualStyleBackColor = False
        '
        'btnporcentaje
        '
        Me.btnporcentaje.BackColor = System.Drawing.Color.DarkBlue
        Me.btnporcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnporcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnporcentaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnporcentaje.Location = New System.Drawing.Point(65, 116)
        Me.btnporcentaje.Name = "btnporcentaje"
        Me.btnporcentaje.Size = New System.Drawing.Size(54, 50)
        Me.btnporcentaje.TabIndex = 21
        Me.btnporcentaje.Text = "%"
        Me.btnporcentaje.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Diseño  Anto"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(120, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 41)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Fracción"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbloperacion
        '
        Me.lbloperacion.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lbloperacion.AllowDrop = True
        Me.lbloperacion.AutoEllipsis = True
        Me.lbloperacion.CausesValidation = False
        Me.lbloperacion.Enabled = False
        Me.lbloperacion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbloperacion.Location = New System.Drawing.Point(12, 70)
        Me.lbloperacion.Name = "lbloperacion"
        Me.lbloperacion.Size = New System.Drawing.Size(107, 43)
        Me.lbloperacion.TabIndex = 24
        Me.lbloperacion.UseMnemonic = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(244, 388)
        Me.Controls.Add(Me.lbloperacion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnporcentaje)
        Me.Controls.Add(Me.btnraiz)
        Me.Controls.Add(Me.btnborrarderecha)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btndivi)
        Me.Controls.Add(Me.btnmulti)
        Me.Controls.Add(Me.btnresta)
        Me.Controls.Add(Me.btnsuma)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btnigual)
        Me.Controls.Add(Me.btncoma)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtvisor)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Name = "Form1"
        Me.Text = "Calculadora Anto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents txtvisor As TextBox
    Friend WithEvents btnraiz As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btncoma As Button
    Friend WithEvents btnigual As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btnsuma As Button
    Friend WithEvents btnresta As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btndivi As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnborrarderecha As Button
    Friend WithEvents btnporcentaje As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbloperacion As Label
End Class
