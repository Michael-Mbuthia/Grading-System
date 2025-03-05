<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TxtName = New TextBox()
        TxtSub3 = New TextBox()
        TxtTotal = New TextBox()
        TxtAvg = New TextBox()
        TxtGrade = New TextBox()
        TxtSub2 = New TextBox()
        TxtSub1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 1
        Label2.Text = "Subject 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 25)
        Label3.TabIndex = 2
        Label3.Text = "Subject 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 25)
        Label4.TabIndex = 3
        Label4.Text = "Subject 3"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 25)
        Label5.TabIndex = 4
        Label5.Text = "Total marks"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(50, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 25)
        Label6.TabIndex = 5
        Label6.Text = "Average"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(50, 351)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 25)
        Label7.TabIndex = 6
        Label7.Text = "Grade"
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(453, 23)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(85, 31)
        TxtName.TabIndex = 7
        ' 
        ' TxtSub3
        ' 
        TxtSub3.Location = New Point(453, 207)
        TxtSub3.Name = "TxtSub3"
        TxtSub3.Size = New Size(85, 31)
        TxtSub3.TabIndex = 8
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Location = New Point(453, 256)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.Size = New Size(85, 31)
        TxtTotal.TabIndex = 9
        ' 
        ' TxtAvg
        ' 
        TxtAvg.Location = New Point(453, 299)
        TxtAvg.Name = "TxtAvg"
        TxtAvg.Size = New Size(85, 31)
        TxtAvg.TabIndex = 10
        ' 
        ' TxtGrade
        ' 
        TxtGrade.Location = New Point(453, 345)
        TxtGrade.Name = "TxtGrade"
        TxtGrade.Size = New Size(85, 31)
        TxtGrade.TabIndex = 11
        ' 
        ' TxtSub2
        ' 
        TxtSub2.Location = New Point(453, 149)
        TxtSub2.Name = "TxtSub2"
        TxtSub2.Size = New Size(85, 31)
        TxtSub2.TabIndex = 12
        ' 
        ' TxtSub1
        ' 
        TxtSub1.Location = New Point(453, 87)
        TxtSub1.Name = "TxtSub1"
        TxtSub1.Size = New Size(85, 31)
        TxtSub1.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(244, 418)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 35)
        Button1.TabIndex = 14
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(453, 418)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 31)
        Button2.TabIndex = 15
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(444, 455)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 30)
        Button3.TabIndex = 16
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(640, 215)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 25)
        Label8.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 503)
        Controls.Add(Label8)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TxtSub1)
        Controls.Add(TxtSub2)
        Controls.Add(TxtGrade)
        Controls.Add(TxtAvg)
        Controls.Add(TxtTotal)
        Controls.Add(TxtSub3)
        Controls.Add(TxtName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtSub3 As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtAvg As TextBox
    Friend WithEvents TxtGrade As TextBox
    Friend WithEvents TxtSub2 As TextBox
    Friend WithEvents TxtSub1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label

End Class
