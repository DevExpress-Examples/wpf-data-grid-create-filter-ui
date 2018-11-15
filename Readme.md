<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication27/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication27/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication27/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/WpfApplication27/MainWindow.xaml))
* [ViewModel.cs](./CS/WpfApplication27/ViewModel.cs) (VB: [ViewModel.vb](./VB/WpfApplication27/ViewModel.vb))
<!-- default file list end -->
# How to create a simple filtering UI for GridControl with nested properties


<p>This example demonstrates how to create a simple filtering UI for GridControl. The main idea is to use the special FilteringBehavior which can be integrated to <a href="https://documentation.devexpress.com/WPF/11540/Controls-and-Libraries/Layout-Management/Tile-and-Layout/Layout-and-Data-Layout-Controls/Data-Layout-Control">DataLayoutControl</a>. First thing you need to do is to bind your <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.FilterCriteria.property">GridControl.FilterCriteria</a> property to the FilteringBehavior.FilterCriteria property to synchronize their current filter expressions. Then, you are required to set the object whose properties will be displayed and edited by your DataLayoutControl. To achieve this, set the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.LayoutControl.DataLayoutControl.CurrentItem.property">DataLayoutControl.CurrentItem</a> property to the FilteringBehavior's FilteringViewModel property. After that, create the required layout of items in your DataLayoutControl and bind them to corresponding properties of your view model. Note that you can use <a href="https://msdn.microsoft.com/en-us/en-es/library/system.componentmodel.dataannotations(v=vs.110).aspx">DataAnnotation</a> attributes for properties in your view model to specify which controls will be used in your DataLayoutControl.<br>Also, FilteringBehavior provides the capability to filter the nested object's properties. All you need is to bind the required DataLayoutItem to a corresponding nested property. You will see this in action in the current example.</p>
<p> </p>
<p><strong>Important</strong>: In this example, we used the grid's <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.FilterCriteria.property">FilterCriteria</a> property and disabled grid-level filtering. If you want to use <strong>FilteringBehavior</strong> without losing the possibility of filtering data in your grid (using the <a href="https://documentation.devexpress.com/WPF/6133/Controls-and-Libraries/Data-Grid/Filtering-and-Searching/Filter-Dropdown">Filter Dropdown</a>, <a href="https://documentation.devexpress.com/WPF/7788/Controls-and-Libraries/Data-Grid/Filtering-and-Searching/Filter-Editor">Filter Editor</a>, etc.), bind the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfGridDataControlBase_FixedFiltertopic">FixedFilter</a> property instead:</p>


```xaml
<dxg:GridControl x:Name="myGrid" Grid.Column="1" ItemsSource="{Binding Orders}" FixedFilter="{Binding Path=FilterCriteria, ElementName=filteringBehavior}">
```


<p><br><strong>See also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/T328691">How to generate a filter set based on DataLayoutControl</a><strong><br></strong></p>

<br/>


