<!-- default file list -->
*Files to look at*:

* **[Task.cs](./CS/UseFunctionCriteriaOperators.Module/BusinessObjects/Task.cs) (VB: [Task.vb](./VB/UseFunctionCriteriaOperators.Module/BusinessObjects/Task.vb))**
<!-- default file list end -->
# How to Use Function Criteria Operators to Filter List Views


<p>The eXpressApp Framework provides various approaches to filtering List Views: on the data source level, via the Application Model and on the UI level. In each of these approaches, you may need to set static variables as filter criteria values. For example, the filter "Task.DueDate must be set to the current date" needs the CurrentDate variable that will be calculated every time it is required. For this purpose, use Function Criteria Operators. They represent functions you can use in criteria. These can be functions that simply return a value, such as the current date or the current user. They can also represent functions that take arguments, such as the concatenation function.  This example demonstrates how to use Function Criteria Operators when setting filter criteria for the Task List View. To see a full list of built-in Function Criteria Operators and learn how to implement custom ones, refer to the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3307"><u>Function Criteria Operators</u></a> topic.</p><p>Since the way to use Function Criteria Operators is typical for any filtering approach both in code and the Model Editor, the ListViewFilterAttribute is chosen for demonstration.<br />
See code in the Task.cs (Task.vb) file. For details, refer to the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2809"><u>How to: Use </u><u>Function Criteria Operators</u><u> to Filter List Views</u></a> topic in XAF documentation.</p><br />


<br/>


