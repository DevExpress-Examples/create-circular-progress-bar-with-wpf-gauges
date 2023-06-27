Imports System
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace CircularProgressBar.Converters

    Public Class ThicknessToOffsetConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim factor As Integer = 1
            If parameter Is Nothing AndAlso value Is Nothing Then Return 0
            Dim param = CStr(parameter)
            Dim val = CInt(value)
            If Not Integer.TryParse(param, factor) Then Return 0
            Return -(val + 7) * (factor - 1)
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
