Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
'using DevExpress.Persistent.BaseImpl;
Imports DevExpress.ExpressApp.Security
Imports UseFunctionCriteriaOperators.Module.BusinessObjects

Namespace UseFunctionCriteriaOperators.Module.DatabaseUpdate
   Public Class Updater
       Inherits ModuleUpdater

      Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
          MyBase.New(objectSpace, currentDBVersion)
      End Sub
      Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
         MyBase.UpdateDatabaseAfterUpdateSchema()

         Dim todayDate As Date = Date.Today
         For i As Integer = -14 To 4
            Dim task As Task = ObjectSpace.FindObject(Of Task)(CriteriaOperator.Parse("DueDate = ADDDAYS(LocalDateTimeToday(), " & i & ")"))
            If task Is Nothing Then
               task = ObjectSpace.CreateObject(Of Task)()
               task.DueDate = todayDate.AddDays(i)
               task.Save()
            End If
         Next i
      End Sub
   End Class
End Namespace
