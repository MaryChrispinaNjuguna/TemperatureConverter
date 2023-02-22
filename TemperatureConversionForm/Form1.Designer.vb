<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.TextBoxF = New System.Windows.Forms.TextBox()
        Me.ButtonCtoF = New System.Windows.Forms.Button()
        Me.ButtonFtoC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(161, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Temperature Converter VB.NET Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(191, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Celsius"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(191, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fahrenheit"
        '
        'TextBoxC
        '
        Me.TextBoxC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxC.Location = New System.Drawing.Point(348, 138)
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(194, 26)
        Me.TextBoxC.TabIndex = 3
        '
        'TextBoxF
        '
        Me.TextBoxF.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxF.Location = New System.Drawing.Point(348, 180)
        Me.TextBoxF.Name = "TextBoxF"
        Me.TextBoxF.Size = New System.Drawing.Size(194, 26)
        Me.TextBoxF.TabIndex = 4
        '
        'ButtonCtoF
        '
        Me.ButtonCtoF.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCtoF.Location = New System.Drawing.Point(258, 273)
        Me.ButtonCtoF.Name = "ButtonCtoF"
        Me.ButtonCtoF.Size = New System.Drawing.Size(80, 32)
        Me.ButtonCtoF.TabIndex = 5
        Me.ButtonCtoF.Text = "C TO F"
        Me.ButtonCtoF.UseVisualStyleBackColor = True
        '
        'ButtonFtoC
        '
        Me.ButtonFtoC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonFtoC.Location = New System.Drawing.Point(429, 273)
        Me.ButtonFtoC.Name = "ButtonFtoC"
        Me.ButtonFtoC.Size = New System.Drawing.Size(75, 32)
        Me.ButtonFtoC.TabIndex = 6
        Me.ButtonFtoC.Text = "F TO C"
        Me.ButtonFtoC.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonFtoC)
        Me.Controls.Add(Me.ButtonCtoF)
        Me.Controls.Add(Me.TextBoxF)
        Me.Controls.Add(Me.TextBoxC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents TextBoxF As TextBox
    Friend WithEvents ButtonCtoF As Button
    Friend WithEvents ButtonFtoC As Button
End Class
