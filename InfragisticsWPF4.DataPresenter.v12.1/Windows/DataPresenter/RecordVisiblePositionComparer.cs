using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E0 RID: 480
	internal class RecordVisiblePositionComparer : global::Infragistics.Windows.Helpers.ClassComparer<global::Infragistics.Windows.DataPresenter.Record>
	{
		// Token: 0x06001B8A RID: 7050 RVA: 0x00075A28 File Offset: 0x00073C28
		private RecordVisiblePositionComparer()
		{
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00075A30 File Offset: 0x00073C30
		protected override int CompareOverride(global::Infragistics.Windows.DataPresenter.Record x, global::Infragistics.Windows.DataPresenter.Record y)
		{
			if (x.ParentCollection == y.ParentCollection)
			{
				return x.VisibleIndex.CompareTo(y.VisibleIndex);
			}
			return x.OverallSelectionPosition.CompareTo(y.OverallSelectionPosition);
		}

		// Token: 0x04000B5E RID: 2910
		internal static readonly global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record> Instance = new global::Infragistics.Windows.DataPresenter.RecordVisiblePositionComparer();
	}
}
