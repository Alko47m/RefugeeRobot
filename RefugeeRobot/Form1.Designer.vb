<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.input = New System.Windows.Forms.TextBox()
        Me.output = New System.Windows.Forms.TextBox()
        Me.talk = New System.Windows.Forms.Button()
        Me.English = New System.Windows.Forms.RadioButton()
        Me.French = New System.Windows.Forms.RadioButton()
        Me.Spanish = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(65, 49)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(413, 26)
        Me.input.TabIndex = 0
        '
        'output
        '
        Me.output.Location = New System.Drawing.Point(12, 183)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(515, 26)
        Me.output.TabIndex = 1
        '
        'talk
        '
        Me.talk.Location = New System.Drawing.Point(216, 81)
        Me.talk.Name = "talk"
        Me.talk.Size = New System.Drawing.Size(105, 48)
        Me.talk.TabIndex = 2
        Me.talk.Text = "Go"
        Me.talk.UseVisualStyleBackColor = True
        '
        'English
        '
        Me.English.AutoSize = True
        Me.English.Location = New System.Drawing.Point(12, 273)
        Me.English.Name = "English"
        Me.English.Size = New System.Drawing.Size(86, 24)
        Me.English.TabIndex = 3
        Me.English.TabStop = True
        Me.English.Text = "English"
        Me.English.UseVisualStyleBackColor = True
        '
        'French
        '
        Me.French.AutoSize = True
        Me.French.Location = New System.Drawing.Point(216, 273)
        Me.French.Name = "French"
        Me.French.Size = New System.Drawing.Size(84, 24)
        Me.French.TabIndex = 4
        Me.French.TabStop = True
        Me.French.Text = "French"
        Me.French.UseVisualStyleBackColor = True
        '
        'Spanish
        '
        Me.Spanish.AutoSize = True
        Me.Spanish.Location = New System.Drawing.Point(394, 273)
        Me.Spanish.Name = "Spanish"
        Me.Spanish.Size = New System.Drawing.Size(92, 24)
        Me.Spanish.TabIndex = 5
        Me.Spanish.TabStop = True
        Me.Spanish.Text = "Spanish"
        Me.Spanish.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 545)
        Me.Controls.Add(Me.Spanish)
        Me.Controls.Add(Me.French)
        Me.Controls.Add(Me.English)
        Me.Controls.Add(Me.talk)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents input As TextBox
    Friend WithEvents output As TextBox
    Friend WithEvents talk As Button
    Friend WithEvents English As RadioButton
    Friend WithEvents French As RadioButton
    Friend WithEvents Spanish As RadioButton
End Class
