
;#Application UseFunctionCriteriaOperators.Win
#Application UseFunctionCriteriaOperators.Web


*Action Filter(Today)

*CheckTable Task
 RowCount = 1

*Action Filter(In three days)

*CheckTable Task
 RowCount = 3

*Action Filter(In two weeks)

*CheckTable Task
 RowCount = 14

*Action Filter(The last work week)

*CheckTable Task
 RowCount = 5

*Action Filter(This work week)

*CheckTable Task
 RowCount = 5

*Action Filter(AllRecords)

*CheckTable Task
 RowCount = 19