Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media

Namespace CircularProgressBar.Controls

    Public Partial Class SegmentedCircularProgressBar
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

        Public Shared ReadOnly MinValueProperty As DependencyProperty = DependencyProperty.Register("MinValue", GetType(Double), GetType(SegmentedCircularProgressBar), New PropertyMetadata(0R))

        Public Property MaxValue As Double
            Get
                Return CDbl(GetValue(MaxValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(MaxValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly MaxValueProperty As DependencyProperty = DependencyProperty.Register("MaxValue", GetType(Double), GetType(SegmentedCircularProgressBar), New PropertyMetadata(100R))

        Public Property Value As Double
            Get
                Return CDbl(GetValue(ValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(ValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ValueProperty As DependencyProperty = DependencyProperty.Register("Value", GetType(Double), GetType(SegmentedCircularProgressBar), New PropertyMetadata(0R))

        Public Property Thickness As Integer
            Get
                Return CInt(GetValue(ThicknessProperty))
            End Get

            Set(ByVal value As Integer)
                SetValue(ThicknessProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ThicknessProperty As DependencyProperty = DependencyProperty.Register("Thickness", GetType(Integer), GetType(SegmentedCircularProgressBar), New PropertyMetadata(15))

        Public Property ProgressThickness As Integer
            Get
                Return CInt(GetValue(ProgressThicknessProperty))
            End Get

            Set(ByVal value As Integer)
                SetValue(ProgressThicknessProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ProgressThicknessProperty As DependencyProperty = DependencyProperty.Register("ProgressThickness", GetType(Integer), GetType(SegmentedCircularProgressBar), New PropertyMetadata(15))

        Public Property TextBrush As Brush
            Get
                Return CType(GetValue(TextBrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(TextBrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly TextBrushProperty As DependencyProperty = DependencyProperty.Register("TextBrush", GetType(Brush), GetType(SegmentedCircularProgressBar), New PropertyMetadata(Brushes.DeepSkyBlue))

        Public Property Segment1Brush As Brush
            Get
                Return CType(GetValue(Segment1BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Segment1BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Segment1BrushProperty As DependencyProperty = DependencyProperty.Register("Segment1Brush", GetType(Brush), GetType(SegmentedCircularProgressBar), New PropertyMetadata(Brushes.Coral))

        Public Property Segment2Brush As Brush
            Get
                Return CType(GetValue(Segment2BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Segment2BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Segment2BrushProperty As DependencyProperty = DependencyProperty.Register("Segment2Brush", GetType(Brush), GetType(SegmentedCircularProgressBar), New PropertyMetadata(Brushes.LightCoral))

        Public Property Segment3Brush As Brush
            Get
                Return CType(GetValue(Segment3BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Segment3BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Segment3BrushProperty As DependencyProperty = DependencyProperty.Register("Segment3Brush", GetType(Brush), GetType(SegmentedCircularProgressBar), New PropertyMetadata(Brushes.Gold))

        Public Property Segment4Brush As Brush
            Get
                Return CType(GetValue(Segment4BrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(Segment4BrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly Segment4BrushProperty As DependencyProperty = DependencyProperty.Register("Segment4Brush", GetType(Brush), GetType(SegmentedCircularProgressBar), New PropertyMetadata(Brushes.LightGreen))
    End Class
End Namespace
