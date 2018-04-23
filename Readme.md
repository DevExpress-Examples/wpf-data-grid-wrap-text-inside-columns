# How to wrap text inside the GridColumn


<p>To enable wrapping in GridControl cells, use TextEditSettings as GridColumn's EditSettings and set the TextEditSettings.TextWrapping property to "Wrap".</p>


```xaml
<dxg:GridColumn.EditSettings>
    <dxe:TextEditSettings TextWrapping="Wrap"/>
</dxg:GridColumn.EditSettings>
```



<br/>


