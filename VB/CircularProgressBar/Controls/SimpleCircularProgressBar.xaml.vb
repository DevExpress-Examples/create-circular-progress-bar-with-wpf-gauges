Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media

Namespace CircularProgressBar.Controls

    ''' <summary>
    ''' Interaction logic for SimpleCircularProgressBar.xaml
    ''' </summary>
    Public Partial Class SimpleCircularProgressBar
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

        Public Shared ReadOnly MinValueProperty As DependencyProperty = DependencyProperty.Register("MinValue", GetType(Double), GetType(SimpleCircularProgressBar), New PropertyMetadata(0R))

        Public Property MaxValue As Double
            Get
                Return CDbl(GetValue(MaxValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(MaxValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly MaxValueProperty As DependencyProperty = DependencyProperty.Register("MaxValue", GetType(Double), GetType(SimpleCircularProgressBar), New PropertyMetadata(100R))

        Public Property Value As Double
            Get
                Return CDbl(GetValue(ValueProperty))
            End Get

            Set(ByVal value As Double)
                SetValue(ValueProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ValueProperty As DependencyProperty = DependencyProperty.Register("Value", GetType(Double), GetType(SimpleCircularProgressBar), New PropertyMetadata(0R))

        Public Property Thickness As Integer
            Get
                Return CInt(GetValue(ThicknessProperty))
            End Get

            Set(ByVal value As Integer)
                SetValue(ThicknessProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ThicknessProperty As DependencyProperty = DependencyProperty.Register("Thickness", GetType(Integer), GetType(SimpleCircularProgressBar), New PropertyMetadata(15))

        Public Property ProgressBrush As Brush
            Get
                Return CType(GetValue(ProgressBrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(ProgressBrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ProgressBrushProperty As DependencyProperty = DependencyProperty.Register("ProgressBrush", GetType(Brush), GetType(SimpleCircularProgressBar), New PropertyMetadata(Brushes.DeepSkyBlue))

        Public Property TextBrush As Brush
            Get
                Return CType(GetValue(TextBrushProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(TextBrushProperty, value)
            End Set
        End Property

        Public Shared ReadOnly TextBrushProperty As DependencyProperty = DependencyProperty.Register("TextBrush", GetType(Brush), GetType(SimpleCircularProgressBar), New PropertyMetadata(Brushes.DeepSkyBlue))

        Public Property ProgressThickness As Integer
            Get
                Return CInt(GetValue(ProgressThicknessProperty))
            End Get

            Set(ByVal value As Integer)
                SetValue(ProgressThicknessProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ProgressThicknessProperty As DependencyProperty = DependencyProperty.Register("ProgressThickness", GetType(Integer), GetType(SimpleCircularProgressBar), New PropertyMetadata(15))
    End Class
End Namespace
