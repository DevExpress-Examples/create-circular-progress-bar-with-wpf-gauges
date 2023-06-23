<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/657562195/22.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1173963)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Create Circular Progress Bar with WPF Gauges

This example illustrates how to implement different Circular Progress Bars using DevExpress Gauges controls. The implementaiton contains three custom UserControls: 

1. `SimpleCircularProgressBar` - A simple Circular Progress Bar control.
2. `SegmentedCircularProgressBar` - A Circular Progress Bar control whose progress range element has four colored sections that reveal depending on the current control value.
3. `FiveRangeCircularProgressBar` - A Circular Progress Bar control that allows you to show a progress of five separate values. 

All these controls are implemented with the help of [CircularGaugeControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.CircularGaugeControl). The gray progress backgrounds and the colored progress range elements are defined via [ArcScaleRangeBars](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.ArcScaleRangeBar). 


----

## SimpleCircularProgressBar

![Image](/images/SimpleCircularProgressBar.png)

```xaml
 <controls:SimpleCircularProgressBar MinValue="{Binding ElementName=TrackBar1, Path=Minimum}"
        MaxValue="{Binding ElementName=TrackBar1, Path=Maximum}"
        Value="{Binding ElementName=TrackBar1, Path=Value}"
        Thickness="15" ProgressThickness="15" TextBrush="Black"
        ProgressBrush="{StaticResource OrangeGradient}"/>
```

## SegmentedCircularProgressBar

![Image](/images/SegmentedCircularProgressBar.png)

```xaml
<controls:SegmentedCircularProgressBar MinValue="{Binding ElementName=TrackBar2, Path=Minimum}"
        MaxValue="{Binding ElementName=TrackBar2, Path=Maximum}"
        Value="{Binding ElementName=TrackBar2, Path=Value}"
        Segment1Brush="#CCDC3B"
        Segment2Brush="#FF5E01"
        Segment3Brush="#29B6F6"
        Segment4Brush="#FFC106"
        Thickness="15"
        ProgressThickness="15" TextBrush="Black" FontWeight="Medium"/>
```


## FiveRangeCircularProgressBar

![Image](/images/FiveRangeCircularProgressBar.png)

```xaml
<controls:FiveRangeCircularProgressBar Grid.RowSpan="5"
        ProgressThickness="25" Thickness="25"
        Grid.Column="1"
        Range1Label="Temazepam"
        Range2Label="Guaifenesin"
        Range3Label="Salicylic Acid"
        Range4Label="Fluoride"
        TextBrush="#262626"
        Range5Label="Zinc Oxide"
        FontSize="15"
        FontFamily="Segoe UI"
        FontWeight="Regular"
        Range1Value="{Binding ElementName=Range1, Path=Value}"
        Range2Value="{Binding ElementName=Range2, Path=Value}"
        Range3Value="{Binding ElementName=Range3, Path=Value}"
        Range4Value="{Binding ElementName=Range4, Path=Value}"
        Range5Value="{Binding ElementName=Range5, Path=Value}"/>
```
