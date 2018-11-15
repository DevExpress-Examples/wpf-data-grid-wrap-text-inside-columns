<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/WpfApplication1/Customer.cs) (VB: [Customer.vb](./VB/WpfApplication1/Customer.vb))
* [Window1.xaml](./CS/WpfApplication1/Window1.xaml) (VB: [Window1.xaml](./VB/WpfApplication1/Window1.xaml))
* [Window1.xaml.cs](./CS/WpfApplication1/Window1.xaml.cs) (VB: [Window1.xaml](./VB/WpfApplication1/Window1.xaml))
<!-- default file list end -->
# How to wrap text inside the GridColumn


<p>To enable wrapping in GridControl cells, use TextEditSettings as GridColumn's EditSettings and set the TextEditSettings.TextWrapping property to "Wrap".</p>


```xaml
<dxg:GridColumn.EditSettings>
    <dxe:TextEditSettings TextWrapping="Wrap"/>
</dxg:GridColumn.EditSettings>
```



<br/>


