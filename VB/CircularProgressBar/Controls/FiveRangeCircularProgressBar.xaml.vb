Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media

Namespace CircularProgressBar.Controls

    Public Partial Class FiveRangeCircularProgressBar
        Inherits UserControl

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Public Property MinValue As Double
            Get
                Return CDbl(GetValue(MinValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(MinValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly MinValueProperty As DependencyProperty = DependencyProperty.Register("MinValue", GetType(Double), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(0R))

        Public Property MaxValue As Double
            Get
                Return CDbl(GetValue(MaxValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(MaxValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly MaxValueProperty As DependencyProperty = DependencyProperty.Register("MaxValue", GetType(Double), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(100R))

        Public Property Thickness As Integer
            Get
                Return CInt(GetValue(ThicknessProperty))
            End Get

            Set(ByVal value As Integer)
                SetValue(ThicknessProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ThicknessProperty As DependencyProperty = DependencyProperty.Register("Thickness", GetType(Integer), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(15))

        Public Property ProgressThickness As Integer
            Get
                Return CInt(GetValue(ProgressThicknessProperty))
            End Get

            Set(ByVal value As Integer)
                SetValue(ProgressThicknessProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ProgressThicknessProperty As DependencyProperty = DependencyProperty.Register("ProgressThickness", GetType(Integer), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(15))

        Public Property TextBrush As Brush
            Get
                Return CType(GetValue(TextBrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(TextBrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly TextBrushProperty As DependencyProperty = DependencyProperty.Register("TextBrush", GetType(Brush), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(Brushes.Gray))

'#Region "Range Brushes"
        Public Property Range1Brush As Brush
            Get
                Return CType(GetValue(Range1BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Range1BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range1BrushProperty As DependencyProperty = DependencyProperty.Register("Range1Brush", GetType(Brush), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(New SolidColorBrush(CType(ColorConverter.ConvertFromString("#FFC106"), Color))))

        Public Property Range2Brush As Brush
            Get
                Return CType(GetValue(Range2BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Range2BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range2BrushProperty As DependencyProperty = DependencyProperty.Register("Range2Brush", GetType(Brush), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(New SolidColorBrush(CType(ColorConverter.ConvertFromString("#CCDC3B"), Color))))

        Public Property Range3Brush As Brush
            Get
                Return CType(GetValue(Range3BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Range3BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range3BrushProperty As DependencyProperty = DependencyProperty.Register("Range3Brush", GetType(Brush), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(New SolidColorBrush(CType(ColorConverter.ConvertFromString("#FF5E01"), Color))))

        Public Property Range4Brush As Brush
            Get
                Return CType(GetValue(Range4BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Range4BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range4BrushProperty As DependencyProperty = DependencyProperty.Register("Range4Brush", GetType(Brush), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(New SolidColorBrush(CType(ColorConverter.ConvertFromString("#29B6F6"), Color))))

        Public Property Range5Brush As Brush
            Get
                Return CType(GetValue(Range5BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Range5BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range5BrushProperty As DependencyProperty = DependencyProperty.Register("Range5Brush", GetType(Brush), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(New SolidColorBrush(CType(ColorConverter.ConvertFromString("#EF68B9"), Color))))

'#End Region  ' Range Brushes
'#Region "Range Values"
        Public Property Range1Value As Double
            Get
                Return CDbl(GetValue(Range1ValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(Range1ValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range1ValueProperty As DependencyProperty = DependencyProperty.Register("Range1Value", GetType(Double), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(0R))

        Public Property Range2Value As Double
            Get
                Return CDbl(GetValue(Range2ValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(Range2ValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range2ValueProperty As DependencyProperty = DependencyProperty.Register("Range2Value", GetType(Double), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(0R))

        Public Property Range3Value As Double
            Get
                Return CDbl(GetValue(Range3ValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(Range3ValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range3ValueProperty As DependencyProperty = DependencyProperty.Register("Range3Value", GetType(Double), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(0R))

        Public Property Range4Value As Double
            Get
                Return CDbl(GetValue(Range4ValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(Range4ValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range4ValueProperty As DependencyProperty = DependencyProperty.Register("Range4Value", GetType(Double), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(0R))

        Public Property Range5Value As Double
            Get
                Return CDbl(GetValue(Range5ValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(Range5ValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range5ValueProperty As DependencyProperty = DependencyProperty.Register("Range5Value", GetType(Double), GetType(FiveRangeCircularProgressBar), New PropertyMetadata(0R))

'#End Region  ' Range Values
'#Region "Range Labels"
        Public Property Range1Label As String
            Get
                Return CStr(GetValue(Range1LabelProperty))
            End Get

            Set(ByVal value As String)
                SetValue(Range1LabelProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range1LabelProperty As DependencyProperty = DependencyProperty.Register("Range1Label", GetType(String), GetType(FiveRangeCircularProgressBar), New PropertyMetadata("Range1"))

        Public Property Range2Label As String
            Get
                Return CStr(GetValue(Range2LabelProperty))
            End Get

            Set(ByVal value As String)
                SetValue(Range2LabelProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range2LabelProperty As DependencyProperty = DependencyProperty.Register("Range2Label", GetType(String), GetType(FiveRangeCircularProgressBar), New PropertyMetadata("Range2"))

        Public Property Range3Label As String
            Get
                Return CStr(GetValue(Range3LabelProperty))
            End Get

            Set(ByVal value As String)
                SetValue(Range3LabelProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range3LabelProperty As DependencyProperty = DependencyProperty.Register("Range3Label", GetType(String), GetType(FiveRangeCircularProgressBar), New PropertyMetadata("Range3"))

        Public Property Range4Label As String
            Get
                Return CStr(GetValue(Range4LabelProperty))
            End Get

            Set(ByVal value As String)
                SetValue(Range4LabelProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range4LabelProperty As DependencyProperty = DependencyProperty.Register("Range4Label", GetType(String), GetType(FiveRangeCircularProgressBar), New PropertyMetadata("Range4"))

        Public Property Range5Label As String
            Get
                Return CStr(GetValue(Range5LabelProperty))
            End Get

            Set(ByVal value As String)
                SetValue(Range5LabelProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Range5LabelProperty As DependencyProperty = DependencyProperty.Register("Range5Label", GetType(String), GetType(FiveRangeCircularProgressBar), New PropertyMetadata("Range5"))
'#End Region  ' Range Labels
    End Class
End Namespace
