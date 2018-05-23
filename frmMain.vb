Imports System.Windows.Forms
Module FormProject  
    Sub Main() 
        System.Console.WriteLine("The Main procedure is starting the application.")  

        Application.EnableVisualStyles()
        Dim T as New myForm

        Application.Run(T)

        System.Console.WriteLine("The application is terminating.")  
    End Sub  

    Public Class myForm
    Inherits Form

        Sub New()
            ' Setup Form Size
            Me.Width = 200
            Me.Height = 300

            ' Define Controls
            Dim gpbFirstName as new GroupBox
            With gpbFirstName
                .Left = 20
                .Top = 10

                .Width = 110
                .Height = 35

                .Text = "First Name: "
            End With

            Dim txtFirstName as New TextBox

            With txtFirstName
                .Left = 5
                .Top = 15

                .Width = 100
            End With
            Dim gpbLastName as new GroupBox

            With gpbLastName
                .Left = 20
                .Top = 60

                .Width = 110
                .Height = 35

                .Text = "Last Name: "
            End With

            Dim txtLastName as New TextBox

            With txtLastName
                .Left = 5
                .Top = 15

                .Width = 100
            End With

            ' Add child controls to group boxes
            gpbFirstName.Controls.Add(txtFirstName)

            gpbLastName.Controls.Add(txtLastName)

            Dim btnSubmit as new Button
            With btnSubmit
                .Text = "Submit"
            
                .Height = 40
                .Width = 100
                .Top = 100
                .Left = 50
            End With

            ' Add controls to form
            Me.Controls.Add(gpbFirstName)
            Me.Controls.Add(gpbLastName)

            Me.Controls.Add(btnSubmit)

            AddHandler btnSubmit.Click, AddressOf btnSubmit_Click
        End Sub

        Sub btnSubmit_Click(sender as Object, e as EventArgs)
            MessageBox.Show("Nope!")
        End Sub
    End Class
End Module 
