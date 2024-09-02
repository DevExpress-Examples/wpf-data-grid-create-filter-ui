<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649342/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T535554)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Create a UI to Filter Grid Data

This example demonstrates how to create a filter UI for Data Grid.

![image](https://user-images.githubusercontent.com/65009440/190639827-d62ea1c9-ead4-41c5-97d3-316b43018ce5.png)

In this example, the [AccordionControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Accordion.AccordionControl) is bound to the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)'s `FilteringContext` property:

```xml
<dxa:AccordionControl SelectionMode="None" dxfui:FilterElement.Context="{Binding Path=FilteringContext, ElementName=grid}">
  ...
</dxa:AccordionControl>
```

Accordion items contain [Filter Elements](https://docs.devexpress.com/WPF/400314/controls-and-libraries/data-grid/filtering-and-searching/filter-elements) that allow you to filter grid data. Set the GridControl's [ShowAllTableValuesInFilterPopup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.ShowAllTableValuesInFilterPopup) property to `true` to display all values in the [RadioListFilterElement](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.FilteringUI.RadioListFilterElement) and [CheckedListFilterElement](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.FilteringUI.CheckedListFilterElement) even if they are filtered out.

## Files to Review

* [MainWindow.xaml](./CS/GridControlFilterUI/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GridControlFilterUI/MainWindow.xaml))
* [ViewModel.cs](./CS/GridControlFilterUI/ViewModel.cs) (VB: [ViewModel.vb](./VB/GridControlFilterUI/ViewModel.vb))

## Documentation

* [Filter Elements](https://docs.devexpress.com/WPF/400314/controls-and-libraries/data-grid/filtering-and-searching/filter-elements)
* [Filtering and Searching](https://docs.devexpress.com/WPF/7356/controls-and-libraries/data-grid/filtering-and-searching)

## More Examples

* [WPF Data Grid - How to Apply a Custom Filter Condition](https://github.com/DevExpress-Examples/wpf-data-grid-implement-custom-filtering)
* [WPF Data Grid - Customize Filter Items in a Column's Drop-Down Filter](https://github.com/DevExpress-Examples/how-to-customize-filter-items-within-a-columns-filter-dropdown-e1533)
* [Charts for WPF - Create Filter UI to Filter Series Data](https://github.com/DevExpress-Examples/wpf-charts-use-filterbehavior-to-filter-series-data)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-create-filter-ui&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-create-filter-ui&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
