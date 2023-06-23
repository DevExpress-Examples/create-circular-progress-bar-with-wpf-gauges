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
            Dim val As Integer = Nothing, param As String = Nothing
            If CSharpImpl.__Assign(val, TryCast(value, Integer)) IsNot Nothing AndAlso CSharpImpl.__Assign(param, TryCast(parameter, String)) IsNot Nothing AndAlso Integer.TryParse(param, factor) Then
                Return -(val * (factor - 1)) - 7 * (factor - 1)
            End If

            Return 0
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
