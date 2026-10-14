using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x02000042 RID: 66
	public class SelectedDatesChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x00012858 File Offset: 0x00010A58
		public SelectedDatesChangedEventArgs(global::System.Collections.Generic.IList<global::System.DateTime> removedDates, global::System.Collections.Generic.IList<global::System.DateTime> addedDates)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("removedDates", removedDates);
			global::Infragistics.Windows.Editors.Utils.ValidateNull("addedDates", addedDates);
			this._removedDates = new global::System.DateTime[removedDates.Count];
			removedDates.CopyTo(this._removedDates, 0);
			this._addedDates = new global::System.DateTime[addedDates.Count];
			addedDates.CopyTo(this._addedDates, 0);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000128BD File Offset: 0x00010ABD
		public global::System.Collections.Generic.IList<global::System.DateTime> RemovedDates
		{
			get
			{
				return this._removedDates;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x000128C5 File Offset: 0x00010AC5
		public global::System.Collections.Generic.IList<global::System.DateTime> AddedDates
		{
			get
			{
				return this._addedDates;
			}
		}

		// Token: 0x04000195 RID: 405
		private global::System.DateTime[] _removedDates;

		// Token: 0x04000196 RID: 406
		private global::System.DateTime[] _addedDates;
	}
}
