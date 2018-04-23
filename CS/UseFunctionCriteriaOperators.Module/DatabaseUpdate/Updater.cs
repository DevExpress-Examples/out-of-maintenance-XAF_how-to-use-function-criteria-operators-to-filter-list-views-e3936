using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
//using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
using UseFunctionCriteriaOperators.Module.BusinessObjects;

namespace UseFunctionCriteriaOperators.Module.DatabaseUpdate {
   public class Updater : ModuleUpdater {
      public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) {
      }
      public override void UpdateDatabaseAfterUpdateSchema() {
         base.UpdateDatabaseAfterUpdateSchema();

         DateTime todayDate = DateTime.Today;
         for (int i = -14; i < 5; i++ ) {
            Task task = ObjectSpace.FindObject<Task>(CriteriaOperator.Parse("DueDate = ADDDAYS(LocalDateTimeToday(), "+i+")"));
            if (task == null) {
               task = ObjectSpace.CreateObject<Task>();
               task.DueDate = todayDate.AddDays(i);
               task.Save();
            }
         }
      }
   }
}
