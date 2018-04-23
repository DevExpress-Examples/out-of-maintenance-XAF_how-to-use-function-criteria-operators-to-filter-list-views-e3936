Imports DevExpress.ExpressApp.Model
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Imports DevExpress.ExpressApp.SystemModule

Namespace UseFunctionCriteriaOperators.Module.BusinessObjects
   <DefaultClassOptions, ListViewFilter("AllRecords", "", True), ListViewFilter("Today", "[DueDate] = LocalDateTimeToday()"), ListViewFilter("In three days", "[DueDate] >= ADDDAYS(LocalDateTimeToday(), -3) AND [DueDate] < LocalDateTimeToday()"), ListViewFilter("In two weeks", "[DueDate] >= ADDDAYS(LocalDateTimeToday(), -14) AND [DueDate] < LocalDateTimeToday()"), ListViewFilter("The last work week", "[DueDate] > LocalDateTimeLastWeek() AND [DueDate] <= ADDDAYS(LocalDateTimeLastWeek(), 5)"), ListViewFilter("This work week", "[DueDate] > LocalDateTimeThisWeek() AND [DueDate] <= ADDDAYS(LocalDateTimeThisWeek(), 5)")> _
   Public Class Task
       Inherits BaseObject

      Public Sub New(ByVal session As Session)
          MyBase.New(session)
      End Sub

      Private dueDate_Renamed As Date
      <ModelDefault("EditMask","d")> _
      Public Property DueDate() As Date
         Get
             Return dueDate_Renamed
         End Get
         Set(ByVal value As Date)
             SetPropertyValue("DueDate", dueDate_Renamed, value)
         End Set
      End Property
   End Class

End Namespace
