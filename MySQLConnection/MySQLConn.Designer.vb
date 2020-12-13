<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MySQLConn
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button_connection = New System.Windows.Forms.Button()
        Me.button_insertion = New System.Windows.Forms.Button()
        Me.button_consulta_escalar = New System.Windows.Forms.Button()
        Me.button_consulta = New System.Windows.Forms.Button()
        Me.button_consulta_desconectado = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.textBox_anoNac = New System.Windows.Forms.TextBox()
        Me.textbox_mesNac = New System.Windows.Forms.TextBox()
        Me.textBox_diaNac = New System.Windows.Forms.TextBox()
        Me.textBox_apellidos = New System.Windows.Forms.TextBox()
        Me.textBox_nombre = New System.Windows.Forms.TextBox()
        Me.textBox_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBox_alumnos = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_connection
        '
        Me.button_connection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_connection.Location = New System.Drawing.Point(3, 3)
        Me.button_connection.Name = "button_connection"
        Me.button_connection.Size = New System.Drawing.Size(105, 87)
        Me.button_connection.TabIndex = 0
        Me.button_connection.Text = "Conectar"
        Me.button_connection.UseVisualStyleBackColor = True
        '
        'button_insertion
        '
        Me.button_insertion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_insertion.Location = New System.Drawing.Point(114, 3)
        Me.button_insertion.Name = "button_insertion"
        Me.button_insertion.Size = New System.Drawing.Size(105, 87)
        Me.button_insertion.TabIndex = 1
        Me.button_insertion.Text = "Insertar alumno"
        Me.button_insertion.UseVisualStyleBackColor = True
        '
        'button_consulta_escalar
        '
        Me.button_consulta_escalar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_consulta_escalar.Location = New System.Drawing.Point(225, 3)
        Me.button_consulta_escalar.Name = "button_consulta_escalar"
        Me.button_consulta_escalar.Size = New System.Drawing.Size(105, 87)
        Me.button_consulta_escalar.TabIndex = 2
        Me.button_consulta_escalar.Text = "Consulta escalar"
        Me.button_consulta_escalar.UseVisualStyleBackColor = True
        '
        'button_consulta
        '
        Me.button_consulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_consulta.Location = New System.Drawing.Point(336, 3)
        Me.button_consulta.Name = "button_consulta"
        Me.button_consulta.Size = New System.Drawing.Size(105, 87)
        Me.button_consulta.TabIndex = 3
        Me.button_consulta.Text = "Consulta"
        Me.button_consulta.UseVisualStyleBackColor = True
        '
        'button_consulta_desconectado
        '
        Me.button_consulta_desconectado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_consulta_desconectado.Location = New System.Drawing.Point(447, 3)
        Me.button_consulta_desconectado.Name = "button_consulta_desconectado"
        Me.button_consulta_desconectado.Size = New System.Drawing.Size(109, 87)
        Me.button_consulta_desconectado.TabIndex = 4
        Me.button_consulta_desconectado.Text = "Consulta desconectado"
        Me.button_consulta_desconectado.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.button_connection, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.button_consulta_desconectado, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.button_insertion, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.button_consulta, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.button_consulta_escalar, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(559, 93)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.textBox_anoNac)
        Me.Panel1.Controls.Add(Me.textbox_mesNac)
        Me.Panel1.Controls.Add(Me.textBox_diaNac)
        Me.Panel1.Controls.Add(Me.textBox_apellidos)
        Me.Panel1.Controls.Add(Me.textBox_nombre)
        Me.Panel1.Controls.Add(Me.textBox_id)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.listBox_alumnos)
        Me.Panel1.Location = New System.Drawing.Point(12, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 313)
        Me.Panel1.TabIndex = 6
        '
        'textBox_anoNac
        '
        Me.textBox_anoNac.Location = New System.Drawing.Point(151, 246)
        Me.textBox_anoNac.MaxLength = 4
        Me.textBox_anoNac.Name = "textBox_anoNac"
        Me.textBox_anoNac.Size = New System.Drawing.Size(50, 20)
        Me.textBox_anoNac.TabIndex = 11
        '
        'textbox_mesNac
        '
        Me.textbox_mesNac.Location = New System.Drawing.Point(119, 246)
        Me.textbox_mesNac.MaxLength = 2
        Me.textbox_mesNac.Name = "textbox_mesNac"
        Me.textbox_mesNac.Size = New System.Drawing.Size(26, 20)
        Me.textbox_mesNac.TabIndex = 10
        '
        'textBox_diaNac
        '
        Me.textBox_diaNac.Location = New System.Drawing.Point(87, 246)
        Me.textBox_diaNac.MaxLength = 2
        Me.textBox_diaNac.Name = "textBox_diaNac"
        Me.textBox_diaNac.Size = New System.Drawing.Size(26, 20)
        Me.textBox_diaNac.TabIndex = 9
        '
        'textBox_apellidos
        '
        Me.textBox_apellidos.Location = New System.Drawing.Point(92, 173)
        Me.textBox_apellidos.Name = "textBox_apellidos"
        Me.textBox_apellidos.Size = New System.Drawing.Size(100, 20)
        Me.textBox_apellidos.TabIndex = 8
        '
        'textBox_nombre
        '
        Me.textBox_nombre.Location = New System.Drawing.Point(89, 118)
        Me.textBox_nombre.Name = "textBox_nombre"
        Me.textBox_nombre.Size = New System.Drawing.Size(100, 20)
        Me.textBox_nombre.TabIndex = 7
        '
        'textBox_id
        '
        Me.textBox_id.Location = New System.Drawing.Point(89, 67)
        Me.textBox_id.Name = "textBox_id"
        Me.textBox_id.Size = New System.Drawing.Size(100, 20)
        Me.textBox_id.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Insertar nuevo alumno"
        '
        'listBox_alumnos
        '
        Me.listBox_alumnos.FormattingEnabled = True
        Me.listBox_alumnos.Items.AddRange(New Object() {"Lista alumnos"})
        Me.listBox_alumnos.Location = New System.Drawing.Point(281, 7)
        Me.listBox_alumnos.Name = "listBox_alumnos"
        Me.listBox_alumnos.Size = New System.Drawing.Size(275, 303)
        Me.listBox_alumnos.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "día"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(119, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "mes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(164, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "año"
        '
        'MySQLConn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "MySQLConn"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_connection As Button
    Friend WithEvents button_insertion As Button
    Friend WithEvents button_consulta_escalar As Button
    Friend WithEvents button_consulta As Button
    Friend WithEvents button_consulta_desconectado As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents listBox_alumnos As ListBox
    Friend WithEvents textBox_diaNac As TextBox
    Friend WithEvents textBox_apellidos As TextBox
    Friend WithEvents textBox_nombre As TextBox
    Friend WithEvents textBox_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textBox_anoNac As TextBox
    Friend WithEvents textbox_mesNac As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
