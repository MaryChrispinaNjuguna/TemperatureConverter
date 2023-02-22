
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private Sub ButtonFtoC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFtoC.Click
        Dim objConv As New TempConv.TemperatureConversionComponent()
        Dim f As Double
        f = CDbl(TextBoxC.Text)
        TextBoxC.Text = objConv.fToC(f)
    End Sub
    Private Sub ButtonCtoF_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles ButtonCtoF.Click
        Dim objConv As New TempConv.TemperatureConversionComponent()
        Dim c As Double

        c = CDbl(TextBoxC.Text)
        TextBoxF.Text = objConv.cToF(c)
    End Sub
End Class