using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DD RID: 477
	internal class CellVisiblePositionComparer : global::Infragistics.Windows.Helpers.ClassComparer<global::Infragistics.Windows.DataPresenter.Cell>
	{
		// Token: 0x06001B7F RID: 7039 RVA: 0x0007583A File Offset: 0x00073A3A
		private CellVisiblePositionComparer()
		{
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00075844 File Offset: 0x00073A44
		protected override int CompareOverride(global::Infragistics.Windows.DataPresenter.Cell x, global::Infragistics.Windows.DataPresenter.Cell y)
		{
			int num = global::Infragistics.Windows.DataPresenter.RecordVisiblePositionComparer.Instance.Compare(x.Record, y.Record);
			if (num == 0)
			{
				num = global::Infragistics.Windows.DataPresenter.FieldNavigationIndexComparer.Instance.Compare(x.Field, y.Field);
			}
			return num;
		}

		// Token: 0x04000B5A RID: 2906
		internal static readonly global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Cell> Instance = new global::Infragistics.Windows.DataPresenter.CellVisiblePositionComparer();
	}
}
