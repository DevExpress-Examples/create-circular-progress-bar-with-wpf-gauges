using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CircularProgressBar.Controls
{
    public partial class SegmentedCircularProgressBar : UserControl
    {
        public SegmentedCircularProgressBar()
        {
            InitializeComponent();
        }

        public double MinValue
        {
            get { return (double)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(double), typeof(SegmentedCircularProgressBar), new PropertyMetadata(0d));


        public double MaxValue
        {
            get { return (double)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(double), typeof(SegmentedCircularProgressBar), new PropertyMetadata(100d));


        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(SegmentedCircularProgressBar), new PropertyMetadata(0d));


        public int Thickness
        {
            get { return (int)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register("Thickness", typeof(int), typeof(SegmentedCircularProgressBar), new PropertyMetadata(15));


        public int ProgressThickness
        {
            get { return (int)GetValue(ProgressThicknessProperty); }
            set { SetValue(ProgressThicknessProperty, value); }
        }

        public static readonly DependencyProperty ProgressThicknessProperty =
            DependencyProperty.Register("ProgressThickness", typeof(int), typeof(SegmentedCircularProgressBar), new PropertyMetadata(15));


        public Brush TextBrush
        {
            get { return (Brush)GetValue(TextBrushProperty); }
            set { SetValue(TextBrushProperty, value); }
        }

        public static readonly DependencyProperty TextBrushProperty =
            DependencyProperty.Register("TextBrush", typeof(Brush), typeof(SegmentedCircularProgressBar), new PropertyMetadata(Brushes.DeepSkyBlue));



        public Brush Segment1Brush
        {
            get { return (Brush)GetValue(Segment1BrushProperty); }
            set { SetValue(Segment1BrushProperty, value); }
        }

        public static readonly DependencyProperty Segment1BrushProperty =
            DependencyProperty.Register("Segment1Brush", typeof(Brush), typeof(SegmentedCircularProgressBar), new PropertyMetadata(Brushes.Coral));




        public Brush Segment2Brush
        {
            get { return (Brush)GetValue(Segment2BrushProperty); }
            set { SetValue(Segment2BrushProperty, value); }
        }

        public static readonly DependencyProperty Segment2BrushProperty =
            DependencyProperty.Register("Segment2Brush", typeof(Brush), typeof(SegmentedCircularProgressBar), new PropertyMetadata(Brushes.LightCoral));



        public Brush Segment3Brush
        {
            get { return (Brush)GetValue(Segment3BrushProperty); }
            set { SetValue(Segment3BrushProperty, value); }
        }

        public static readonly DependencyProperty Segment3BrushProperty =
            DependencyProperty.Register("Segment3Brush", typeof(Brush), typeof(SegmentedCircularProgressBar), new PropertyMetadata(Brushes.Gold));



        public Brush Segment4Brush
        {
            get { return (Brush)GetValue(Segment4BrushProperty); }
            set { SetValue(Segment4BrushProperty, value); }
        }

        
        public static readonly DependencyProperty Segment4BrushProperty =
            DependencyProperty.Register("Segment4Brush", typeof(Brush), typeof(SegmentedCircularProgressBar), new PropertyMetadata(Brushes.LightGreen));


    }


}
