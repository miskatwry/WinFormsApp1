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
        Button1 = New Button()
        Label1 = New Label()
        alas = New TextBox()
        luas = New TextBox()
        Label2 = New Label()
        tinggi = New TextBox()
        Label3 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(310, 331)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 0
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 32)
        Label1.TabIndex = 1
        Label1.Text = "Alas"
        ' 
        ' alas
        ' 
        alas.Location = New Point(310, 93)
        alas.Name = "alas"
        alas.Size = New Size(306, 39)
        alas.TabIndex = 2
        ' 
        ' luas
        ' 
        luas.Location = New Point(310, 231)
        luas.Name = "luas"
        luas.Size = New Size(306, 39)
        luas.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 32)
        Label2.TabIndex = 3
        Label2.Text = "Luas"
        ' 
        ' tinggi
        ' 
        tinggi.Location = New Point(310, 161)
        tinggi.Name = "tinggi"
        tinggi.Size = New Size(306, 39)
        tinggi.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 32)
        Label3.TabIndex = 5
        Label3.Text = "Tinggi"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(503, 331)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 46)
        Button2.TabIndex = 7
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(tinggi)
        Controls.Add(Label3)
        Controls.Add(luas)
        Controls.Add(Label2)
        Controls.Add(alas)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents alas As TextBox
    Friend WithEvents luas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tinggi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
