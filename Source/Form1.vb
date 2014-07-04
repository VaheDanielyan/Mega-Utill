' Microsoft Visual basic 2008 pro
' ******************************************************************
' Copyright © Vahe Danielyan 2014 <danielyan.vahe@gmail.com> 
'
' Everyone is permitted to copy and distribute verbatim or modified
' copies of this license document, and changing it is allowed as long
' as the name is changed.
'
'********************************************************************
Public Class Vahe_app
    Public Final As Integer
    Public S As String
    Public str As String
    Public Final2 As Integer
    '////////////////////////////'Input from textbox'////////////////////////////////////////////////////////////////////////////
    Private Sub Init(ByVal TextBox1 As System.Object)
        S = TextBox1.text
        If S = "" Then
            Final = 0
            Return
        End If
        Final = CType(S, Integer)
    End Sub
    '/////////////////////////////////'Input from textbox'//////////////////////////////////////////////////////////////////////
    Private Sub Init2(ByVal Second As System.Object)
        str = Second.text
        If str = "" Then
            Final2 = 0
            Return
        End If
        Final2 = CType(str, Integer)
    End Sub
    '////////////////////////////////////'Application is being loaded here'//////////////////////////////////////////////////////
    Private Sub Vahe_app_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub sqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sqrt.Click
        Init(TextBox1)
        LB.Items.Add(Math.Sqrt(Final))
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub pow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pow.Click
        Init(TextBox1)
        LB.Items.Add(Math.Pow(Final, 2))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log.Click
        Init(TextBox1)
        LB.Items.Add(Math.Log10(Final))
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub sin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sin.Click
        Init(TextBox1)
        LB.Items.Add(Math.Sin(Final))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LB.Items.Clear()
    End Sub
    '////////////////////////////////////////////////////////'Application closing part'/////////////////////////////////////////
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you sure you want to quit app", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Close()
        End If

    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Cos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cos.Click
        Init(TextBox1)
        LB.Items.Add(Math.Cos(Final))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Init(TextBox1)
        LB.Items.Add(Math.Tan(Final))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Ctan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctan.Click
        Init(TextBox1)
        LB.Items.Add(1 / (Math.Tan(Final)))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Asin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asin.Click
        Init(TextBox1)
        LB.Items.Add(Math.Asin(Final))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Acos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Acos.Click
        Init(TextBox1)
        LB.Items.Add(Math.Acos(Final))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Fact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fact.Click
        Init(TextBox1)

        If Final > 20 Then
            LB.Items.Add("NaN")
            Return
        End If

        Dim fact As Int64 = 1
        For i As Integer = 2 To Final
            fact = fact * i
        Next
        LB.Items.Add(fact)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        LB.Items.Add(Math.PI)
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Second.TextChanged
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Init2(Second)
        Init(TextBox1)
        LB.Items.Add(Math.Log(Final, Final2))
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Powx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Powx.Click
        Init(TextBox1)
        Init(Second)
        LB.Items.Add(Math.Pow(Final, Final2))
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub nsqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nsqrt.Click
        Init(TextBox1)
        Init2(Second)
        LB.Items.Add(Math.Pow(Final, (1 / Final2)))
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Msc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'My.Computer.Audio.Play(My.Resources.RapGod, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub An_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'My.Computer.Audio.Play(My.Resources.Animals, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Stop()
    End Sub

    Private Sub LP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Sum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sum.Click
        Init(TextBox1)
        LB.Items.Add(((Final) * (Final + 1)) / 2)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Init(TextBox1)
        Init2(Second)
        If Final = 0 Then
            LB.Items.Add("NaN")
            Return
        End If
        LB.Items.Add(Final Mod Final2)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Init(TextBox1)
        Init2(Second)
        LB.Items.Add(Final * Final2)
    End Sub

    Private Sub ABS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABS.Click
        Init(TextBox1)
        LB.Items.Add(Math.Abs(Final))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Init(TextBox1)
        Init2(Second)
        LB.Items.Add(Final * Final2 / 100)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        LB.Items.Add(Math.E)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LB.Items.Add(9.8)
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Init(TextBox1)
        Init2(Second)
        LB.Items.Add(Math.Atan(1 / Math.Tan(Final)))
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Init(TextBox1)
        Init(Second)
        LB.Items.Add(Math.Atan(Final))
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Init(TextBox1)
        Init2(Second)
        Dim c As Integer
        While Final2 <> 0
            Final = Final Mod Final2
            c = Final
            Final = Final2
            Final2 = c
        End While
        LB.Items.Add(Final)
    End Sub

    Private Sub Div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Div.Click
        Init(TextBox1)
        Init2(Second)
        LB.Items.Add(Final / Final2)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Init(TextBox1)
        Init2(Second)
        LB.Items.Add(Final + Final2)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Init(TextBox1)
        Init2(Second)
        LB.Items.Add(Final - Final2)
    End Sub
    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub LB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB.SelectedIndexChanged

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Init(TextBox1)
        Init2(Second)
        Dim k As Integer
        k = Final * Final2
        Dim c As Integer
        While Final2 <> 0
            Final = Final Mod Final2
            c = Final
            Final = Final2
            Final2 = c
        End While
        LB.Items.Add(k / Final)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Init(TextBox1)
        LB.Items.Add(Math.Exp(Final))
    End Sub
End Class
