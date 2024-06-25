<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653849/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2565)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/WpfApplication1/Customer.cs) (VB: [Customer.vb](./VB/WpfApplication1/Customer.vb))
* [Window1.xaml](./CS/WpfApplication1/Window1.xaml) (VB: [Window1.xaml](./VB/WpfApplication1/Window1.xaml))
* [Window1.xaml.cs](./CS/WpfApplication1/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/WpfApplication1/Window1.xaml.vb))
<!-- default file list end -->
# How to wrap text inside the GridColumn


<p>To enable wrapping in GridControl cells, use TextEditSettings as GridColumn's EditSettings and set the TextEditSettings.TextWrapping property to "Wrap".</p>


```xaml
<dxg:GridColumn.EditSettings>
    <dxe:TextEditSettings TextWrapping="Wrap"/>
</dxg:GridColumn.EditSettings>
```



<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-wrap-text-inside-columns&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-wrap-text-inside-columns&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
