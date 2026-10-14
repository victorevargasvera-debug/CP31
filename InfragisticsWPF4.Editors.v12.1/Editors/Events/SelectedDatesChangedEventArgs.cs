using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x0200003F RID: 63
	public class SelectedDatesChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000429 RID: 1065 RVA: 0x00011B98 File Offset: 0x0000FD98
		public SelectedDatesChangedEventArgs(global::System.Collections.Generic.IList<global::System.DateTime> removedDates, global::System.Collections.Generic.IList<global::System.DateTime> addedDates)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("removedDates", removedDates);
			global::Infragistics.Windows.Editors.Utils.ValidateNull("addedDates", addedDates);
			this._removedDates = new global::System.DateTime[removedDates.Count];
			removedDates.CopyTo(this._removedDates, 0);
			this._addedDates = new global::System.DateTime[addedDates.Count];
			addedDates.CopyTo(this._addedDates, 0);
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00011BFD File Offset: 0x0000FDFD
		public global::System.Collections.Generic.IList<global::System.DateTime> RemovedDates
		{
			get
			{
				return this._removedDates;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00011C05 File Offset: 0x0000FE05
		public global::System.Collections.Generic.IList<global::System.DateTime> AddedDates
		{
			get
			{
				return this._addedDates;
			}
		}

		// Token: 0x0400017A RID: 378
		private global::System.DateTime[] _removedDates;

		// Token: 0x0400017B RID: 379
		private global::System.DateTime[] _addedDates;
	}
}
