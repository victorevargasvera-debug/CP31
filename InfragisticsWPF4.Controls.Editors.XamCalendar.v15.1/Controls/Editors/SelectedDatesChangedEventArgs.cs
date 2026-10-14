using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000032 RID: 50
	public class SelectedDatesChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000256 RID: 598 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		public SelectedDatesChangedEventArgs(global::System.Collections.Generic.IList<global::System.DateTime> removedDates, global::System.Collections.Generic.IList<global::System.DateTime> addedDates)
		{
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNull("removedDates", removedDates);
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNull("addedDates", addedDates);
			this._removedDates = new global::System.DateTime[removedDates.Count];
			removedDates.CopyTo(this._removedDates, 0);
			this._addedDates = new global::System.DateTime[addedDates.Count];
			addedDates.CopyTo(this._addedDates, 0);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000CB45 File Offset: 0x0000AD45
		public global::System.Collections.Generic.IList<global::System.DateTime> RemovedDates
		{
			get
			{
				return this._removedDates;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000CB4D File Offset: 0x0000AD4D
		public global::System.Collections.Generic.IList<global::System.DateTime> AddedDates
		{
			get
			{
				return this._addedDates;
			}
		}

		// Token: 0x0400016D RID: 365
		private global::System.DateTime[] _removedDates;

		// Token: 0x0400016E RID: 366
		private global::System.DateTime[] _addedDates;
	}
}
