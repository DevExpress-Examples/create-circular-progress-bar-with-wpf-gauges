<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/657562195/22.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1173963)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Create Circular Progress Bar with WPF Gauges

This example demonstrates how to use [DevExpress WPF Gauge controls](https://www.devexpress.com/products/net/controls/wpf/gauges/) to implement different Circular Progress Bars. The implementaiton contains three custom `UserControls`: 

1. [SimpleCircularProgressBar](#simplecircularprogressbar) - A simple Circular Progress Bar control.
2. [SegmentedCircularProgressBar](#segmentedcircularprogressbar) - A Circular Progress Bar control that contains four colored sections. Each section is revealed based on the control value.
3. [FiveRangeCircularProgressBar](#fiverangecircularprogressbar) - A Circular Progress Bar control that allows you to show a progress of five separate values.

All these controls are implemented with the help of the [CircularGaugeControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.CircularGaugeControl). [ArcScaleRangeBars](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.ArcScaleRangeBar) define gray progress backgrounds and colored progress range elements. 


----

## SimpleCircularProgressBar

A simple Circular Progress Bar control.

![Image](/images/SimpleCircularProgressBar.png)

```xaml
 <controls:SimpleCircularProgressBar 
        MinValue="{Binding ElementName=TrackBar1, Path=Minimum}"
        MaxValue="{Binding ElementName=TrackBar1, Path=Maximum}"
        Value="{Binding ElementName=TrackBar1, Path=Value}"
        Thickness="15" ProgressThickness="15" TextBrush="Black"
        ProgressBrush="{StaticResource OrangeGradient}"/>
```

* [SimpleCircularProgressBar.xaml](./CS/CircularProgressBar/Controls/SimpleCircularProgressBar.xaml)
* [SimpleCircularProgressBar.xaml.cs](./CS/CircularProgressBar/Controls/SimpleCircularProgressBar.xaml.cs) (VB: [SimpleCircularProgressBar.xaml.vb](./VB/CircularProgressBar/Controls/SimpleCircularProgressBar.xaml.vb))


## SegmentedCircularProgressBar

A Circular Progress Bar control that contains four colored sections. Each section is revealed based on the control value.

![Image](/images/SegmentedCircularProgressBar.png)

```xaml
<controls:SegmentedCircularProgressBar 
        MinValue="{Binding ElementName=TrackBar2, Path=Minimum}"
        MaxValue="{Binding ElementName=TrackBar2, Path=Maximum}"
        Value="{Binding ElementName=TrackBar2, Path=Value}"
        Segment1Brush="#CCDC3B"
        Segment2Brush="#FF5E01"
        Segment3Brush="#29B6F6"
        Segment4Brush="#FFC106"
        Thickness="15" ProgressThickness="15" TextBrush="Black"/>
```

* [SegmentedCircularProgressBar.xaml](./CS/CircularProgressBar/Controls/SegmentedCircularProgressBar.xaml)
* [SegmentedCircularProgressBar.xaml.cs](./CS/CircularProgressBar/Controls/SegmentedCircularProgressBar.xaml.cs) (VB: [SegmentedCircularProgressBar.xaml.vb](./VB/CircularProgressBar/Controls/SegmentedCircularProgressBar.xaml.vb))


## FiveRangeCircularProgressBar

A Circular Progress Bar control that allows you to show a progress of five separate values.

![Image](/images/FiveRangeCircularProgressBar.png)

```xaml
<controls:FiveRangeCircularProgressBar 
        ProgressThickness="25" Thickness="25"
        Range1Label="Temazepam"
        Range2Label="Guaifenesin"
        Range3Label="Salicylic Acid"
        Range4Label="Fluoride"
        Range5Label="Zinc Oxide"
        TextBrush="#262626"
        FontSize="15"
        FontFamily="Segoe UI"
        FontWeight="Regular"
        Range1Value="{Binding ElementName=Range1, Path=Value}"
        Range2Value="{Binding ElementName=Range2, Path=Value}"
        Range3Value="{Binding ElementName=Range3, Path=Value}"
        Range4Value="{Binding ElementName=Range4, Path=Value}"
        Range5Value="{Binding ElementName=Range5, Path=Value}"/>
```

* [FiveRangeCircularProgressBar.xaml](./CS/CircularProgressBar/Controls/FiveRangeCircularProgressBar.xaml)
* [FiveRangeCircularProgressBar.xaml.cs](./CS/CircularProgressBar/Controls/FiveRangeCircularProgressBar.xaml.cs) (VB: [FiveRangeCircularProgressBar.xaml.vb](./VB/CircularProgressBar/Controls/FiveRangeCircularProgressBar.xaml.vb))

## Files to Review

* [MainWindow.xaml](./CS/CircularProgressBar/MainWindow.xaml)

## Documentation

* [CircularGaugeControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.CircularGaugeControl)
* [ArcScaleRangeBar](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.ArcScaleRangeBar)
* [Scales](https://docs.devexpress.com/WPF/10321/controls-and-libraries/gauge-controls/scales)

## More Examples

* [WPF Gauges - Create a Knob-like Gauge](https://github.com/DevExpress-Examples/wpf-gauges-create-a-knob-like-gauge)
