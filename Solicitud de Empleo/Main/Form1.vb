Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button1.Enabled = True
        ElseIf CheckBox1.Checked = False Then
            Button1.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Madrid" Then

            ComboBox2.Text = ""
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Parla")
            ComboBox2.Items.Add("Paseo de la Castellana")

        ElseIf ComboBox1.Text = "Barcelona" Then

            ComboBox2.Text = ""
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cornella")
            ComboBox2.Items.Add("Av.Diagonal")

        ElseIf ComboBox1.Text = "Valencia" Then

            ComboBox2.Text = ""
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Cheste")
            ComboBox2.Items.Add("C/Joaquin Sorolla")

        Else
            ComboBox2.Text = ""
            ComboBox2.Items.Clear()


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()
    End Sub

    Private Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        Button1.Enabled = False
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Add("Madrid")
        ComboBox1.Items.Add("Barcelona")
        ComboBox1.Items.Add("Valencia")
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Algun valor o valores no han sido insertados, compruebelo")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("No ha especificado el genero")
        ElseIf RadioButton3.Checked = False And RadioButton4.Checked = False Then
            MessageBox.Show("No ha especificado el salario")
        ElseIf ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MessageBox.Show("No ha especificado la localizacion")
        ElseIf CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False Then
            MessageBox.Show("No ha especificado la disponibilidad")

        Else
            Try
                Dim conexion As New SqlConnection("server=Nombre_Ordenador(O nombre configurado para SSMS)\SQLEXPRESS01; database=BaseEmpleados(Nombre de la base de datos en SSMS) ; integrated security = true")
                conexion.Open()
                Dim nom As String = TextBox1.Text
                Dim ape As String = TextBox2.Text
                Dim sexo As String
                If RadioButton1.Checked = True Then
                    sexo = "Masculino"
                ElseIf RadioButton2.Checked = True Then
                    sexo = "Femenino"
                Else
                    sexo = "No definido"
                End If
                Dim sede As String = ComboBox1.Text
                Dim localidad As String = ComboBox2.Text
                Dim dni As String = TextBox3.Text
                Dim disponibilidad As String = ""
                Dim salarioesperado As String
                If RadioButton3.Checked = True Then
                    salarioesperado = "<30.000"
                ElseIf RadioButton4.Checked = True Then
                    salarioesperado = ">30.000"
                Else
                    salarioesperado = "0.0"
                End If

                Dim numd As Integer = 0
                If CheckBox2.Checked = True Then
                    numd = numd + 1
                End If
                If CheckBox3.Checked = True Then
                    numd = numd + 1
                End If
                If CheckBox4.Checked = True Then
                    numd = numd + 1
                End If

                If numd = 0 Then
                    disponibilidad = "no insertada"
                ElseIf numd = 1 Then
                    disponibilidad = "Normal"
                ElseIf numd = 2 Then
                    disponibilidad = "Alta"
                ElseIf numd = 3 Then
                    disponibilidad = "Muy alta"
                End If

                Dim cadena As String = "insert into Empleados (nombre,apellidos,sexo,sede,localidad,dni,disponibilidad,salarioesperado) 
            values ('" & nom & "','" & ape & "','" & sexo & "','" & sede & "','" & localidad & "'," & dni & ",'" & disponibilidad & "','" & salarioesperado & "')"
                Dim comando As SqlCommand
                comando = New SqlCommand(cadena, conexion)
                comando.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception

                MessageBox.Show("Se ha producido un error:" + ex.Message)
            End Try

        End If

        Clear()
    End Sub

End Class
