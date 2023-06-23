using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CircularProgressBar.Controls
{
    public partial class FiveRangeCircularProgressBar : UserControl
    {
        public FiveRangeCircularProgressBar()
        {
            InitializeComponent();
        }

        public double MinValue
        {
            get { return (double)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(double), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(0d));


        public double MaxValue
        {
            get { return (double)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(double), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(100d));


        public int Thickness
        {
            get { return (int)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register("Thickness", typeof(int), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(15));


        public int ProgressThickness
        {
            get { return (int)GetValue(ProgressThicknessProperty); }
            set { SetValue(ProgressThicknessProperty, value); }
        }

        public static readonly DependencyProperty ProgressThicknessProperty =
            DependencyProperty.Register("ProgressThickness", typeof(int), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(15));


        public Brush TextBrush
        {
            get { return (Brush)GetValue(TextBrushProperty); }
            set { SetValue(TextBrushProperty, value); }
        }

        public static readonly DependencyProperty TextBrushProperty =
            DependencyProperty.Register("TextBrush", typeof(Brush), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(Brushes.Gray));


        #region Range Brushes

        public Brush Range1Brush
        {
            get { return (Brush)GetValue(Range1BrushProperty); }
            set { SetValue(Range1BrushProperty, value); }
        }


        public static readonly DependencyProperty Range1BrushProperty =
            DependencyProperty.Register("Range1Brush", typeof(Brush), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC106"))));


        public Brush Range2Brush
        {
            get { return (Brush)GetValue(Range2BrushProperty); }
            set { SetValue(Range2BrushProperty, value); }
        }


        public static readonly DependencyProperty Range2BrushProperty =
            DependencyProperty.Register("Range2Brush", typeof(Brush), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CCDC3B"))));




        public Brush Range3Brush
        {
            get { return (Brush)GetValue(Range3BrushProperty); }
            set { SetValue(Range3BrushProperty, value); }
        }

        public static readonly DependencyProperty Range3BrushProperty =
            DependencyProperty.Register("Range3Brush", typeof(Brush), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5E01"))));




        public Brush Range4Brush
        {
            get { return (Brush)GetValue(Range4BrushProperty); }
            set { SetValue(Range4BrushProperty, value); }
        }

        public static readonly DependencyProperty Range4BrushProperty =
            DependencyProperty.Register("Range4Brush", typeof(Brush), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#29B6F6"))));



        public Brush Range5Brush
        {
            get { return (Brush)GetValue(Range5BrushProperty); }
            set { SetValue(Range5BrushProperty, value); }
        }

        public static readonly DependencyProperty Range5BrushProperty =
            DependencyProperty.Register("Range5Brush", typeof(Brush), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF68B9"))));

        #endregion Range Brushes

        #region Range Values



        public double Range1Value
        {
            get { return (double)GetValue(Range1ValueProperty); }
            set { SetValue(Range1ValueProperty, value); }
        }

        public static readonly DependencyProperty Range1ValueProperty =
            DependencyProperty.Register("Range1Value", typeof(double), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(0d));


        public double Range2Value
        {
            get { return (double)GetValue(Range2ValueProperty); }
            set { SetValue(Range2ValueProperty, value); }
        }

        public static readonly DependencyProperty Range2ValueProperty =
            DependencyProperty.Register("Range2Value", typeof(double), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(0d));




        public double Range3Value
        {
            get { return (double)GetValue(Range3ValueProperty); }
            set { SetValue(Range3ValueProperty, value); }
        }

        public static readonly DependencyProperty Range3ValueProperty =
            DependencyProperty.Register("Range3Value", typeof(double), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(0d));




        public double Range4Value
        {
            get { return (double)GetValue(Range4ValueProperty); }
            set { SetValue(Range4ValueProperty, value); }
        }

        public static readonly DependencyProperty Range4ValueProperty =
            DependencyProperty.Register("Range4Value", typeof(double), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(0d));




        public double Range5Value
        {
            get { return (double)GetValue(Range5ValueProperty); }
            set { SetValue(Range5ValueProperty, value); }
        }

        public static readonly DependencyProperty Range5ValueProperty =
            DependencyProperty.Register("Range5Value", typeof(double), typeof(FiveRangeCircularProgressBar), new PropertyMetadata(0d));



        #endregion Range Values

        #region Range Labels



        public string Range1Label
        {
            get { return (string)GetValue(Range1LabelProperty); }
            set { SetValue(Range1LabelProperty, value); }
        }

        public static readonly DependencyProperty Range1LabelProperty =
            DependencyProperty.Register("Range1Label", typeof(string), typeof(FiveRangeCircularProgressBar), new PropertyMetadata("Range1"));



        public string Range2Label
        {
            get { return (string)GetValue(Range2LabelProperty); }
            set { SetValue(Range2LabelProperty, value); }
        }

        public static readonly DependencyProperty Range2LabelProperty =
            DependencyProperty.Register("Range2Label", typeof(string), typeof(FiveRangeCircularProgressBar), new PropertyMetadata("Range2"));



        public string Range3Label
        {
            get { return (string)GetValue(Range3LabelProperty); }
            set { SetValue(Range3LabelProperty, value); }
        }

        public static readonly DependencyProperty Range3LabelProperty =
            DependencyProperty.Register("Range3Label", typeof(string), typeof(FiveRangeCircularProgressBar), new PropertyMetadata("Range3"));


        public string Range4Label
        {
            get { return (string)GetValue(Range4LabelProperty); }
            set { SetValue(Range4LabelProperty, value); }
        }

        public static readonly DependencyProperty Range4LabelProperty =
            DependencyProperty.Register("Range4Label", typeof(string), typeof(FiveRangeCircularProgressBar), new PropertyMetadata("Range4"));


        public string Range5Label
        {
            get { return (string)GetValue(Range5LabelProperty); }
            set { SetValue(Range5LabelProperty, value); }
        }

        public static readonly DependencyProperty Range5LabelProperty =
            DependencyProperty.Register("Range5Label", typeof(string), typeof(FiveRangeCircularProgressBar), new PropertyMetadata("Range5"));



        #endregion Range Labels
    }
}
