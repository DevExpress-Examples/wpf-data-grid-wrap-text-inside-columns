<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653849/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2565)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Wrap Text Inside Columns

This example demonstrates how to wrap text inside column cells and headers:

![image](https://user-images.githubusercontent.com/65009440/221171447-1036face-9051-49e5-b523-7fc1d796647e.png)

To wrap text in [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) cells, assign the [TextEditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.TextEditSettings) object to the column's [EditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.EditSettings) property and set the [TextWrapping](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.TextEditSettings.TextWrapping) property to `Wrap`:

```xaml
<dxg:GridColumn.EditSettings>
    <dxe:TextEditSettings TextWrapping="Wrap"/>
</dxg:GridColumn.EditSettings>
```

To wrap the column header's text, specify the [ColumnHeaderTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderTemplate) property and set the [TextBlock.TextWrapping](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.textblock.textwrapping) property to `Wrap`:

```xaml
<dxg:TableView.ColumnHeaderTemplate>
    <DataTemplate>
        <TextBlock Text="{Binding}" TextWrapping="Wrap"/>
    </DataTemplate>
</dxg:TableView.ColumnHeaderTemplate>
```

## Files to Review

* [Window1.xaml](./CS/WpfApplication1/Window1.xaml) (VB: [Window1.xaml](./VB/WpfApplication1/Window1.xaml))
* [Window1.xaml.cs](./CS/WpfApplication1/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/WpfApplication1/Window1.xaml.vb))

## Documentation

* [TextEditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.TextEditSettings)
* [Assign Editors to Cells](https://docs.devexpress.com/WPF/401011/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/assign-an-editor-to-a-cell)
* [ColumnHeaderTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ColumnHeaderTemplate)
* [Column Header Customization](https://docs.devexpress.com/WPF/6295/controls-and-libraries/data-grid/appearance-customization/column-header-customization)

## More Examples

* [WPF Data Grid - Customize Column Headers Based on Their Location](https://github.com/DevExpress-Examples/wpf-data-grid-customize-column-headers-based-on-location)
* [Data Grid for WPF - Display Hyperlinks in Cells](https://github.com/DevExpress-Examples/wpf-data-grid-display-hyperlinks)
* [Build Binding Paths in WPF Data Grid Cells](https://github.com/DevExpress-Examples/how-to-build-binding-paths-in-gridcontrol-cells)
* [WPF Data Grid - Add Image and Button Columns](https://github.com/DevExpress-Examples/wpf-data-grid-add-image-and-button-columns)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-wrap-text-inside-columns&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-wrap-text-inside-columns&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
