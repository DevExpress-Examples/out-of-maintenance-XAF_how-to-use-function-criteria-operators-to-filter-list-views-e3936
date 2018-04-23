using DevExpress.ExpressApp.Model;
using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

using DevExpress.ExpressApp.SystemModule;

namespace UseFunctionCriteriaOperators.Module.BusinessObjects {
   [DefaultClassOptions]
   [ListViewFilter("AllRecords", "", true)]
   [ListViewFilter("Today", "[DueDate] = LocalDateTimeToday()")]
   [ListViewFilter("In three days", "[DueDate] >= ADDDAYS(LocalDateTimeToday(), -3) AND [DueDate] < LocalDateTimeToday()")]
   [ListViewFilter("In two weeks", "[DueDate] >= ADDDAYS(LocalDateTimeToday(), -14) AND [DueDate] < LocalDateTimeToday()")]
   [ListViewFilter("The last work week", "[DueDate] > LocalDateTimeLastWeek() AND [DueDate] <= ADDDAYS(LocalDateTimeLastWeek(), 5)")]
   [ListViewFilter("This work week", "[DueDate] > LocalDateTimeThisWeek() AND [DueDate] <= ADDDAYS(LocalDateTimeThisWeek(), 5)")]
   public class Task : BaseObject {
      public Task(Session session) : base(session) {}
      private DateTime dueDate;
      [ModelDefault("EditMask","d")]
      public DateTime DueDate {
         get { return dueDate; }
         set { SetPropertyValue("DueDate", ref dueDate, value); }
      }
   }

}
