using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000209 RID: 521
	internal class RecordVisiblePositionComparer : global::Infragistics.Windows.Helpers.ClassComparer<global::Infragistics.Windows.DataPresenter.Record>
	{
		// Token: 0x06001FA1 RID: 8097 RVA: 0x0008998C File Offset: 0x00087B8C
		private RecordVisiblePositionComparer()
		{
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x00089994 File Offset: 0x00087B94
		protected override int CompareOverride(global::Infragistics.Windows.DataPresenter.Record x, global::Infragistics.Windows.DataPresenter.Record y)
		{
			if (x.ParentCollection == y.ParentCollection)
			{
				return x.VisibleIndex.CompareTo(y.VisibleIndex);
			}
			return x.OverallSelectionPosition.CompareTo(y.OverallSelectionPosition);
		}

		// Token: 0x04000D4F RID: 3407
		internal static readonly global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record> Instance = new global::Infragistics.Windows.DataPresenter.RecordVisiblePositionComparer();
	}
}
