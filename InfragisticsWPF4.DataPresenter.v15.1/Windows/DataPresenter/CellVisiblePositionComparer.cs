using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000206 RID: 518
	internal class CellVisiblePositionComparer : global::Infragistics.Windows.Helpers.ClassComparer<global::Infragistics.Windows.DataPresenter.Cell>
	{
		// Token: 0x06001F96 RID: 8086 RVA: 0x0008979E File Offset: 0x0008799E
		private CellVisiblePositionComparer()
		{
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000897A8 File Offset: 0x000879A8
		protected override int CompareOverride(global::Infragistics.Windows.DataPresenter.Cell x, global::Infragistics.Windows.DataPresenter.Cell y)
		{
			int num = global::Infragistics.Windows.DataPresenter.RecordVisiblePositionComparer.Instance.Compare(x.Record, y.Record);
			if (num == 0)
			{
				num = global::Infragistics.Windows.DataPresenter.FieldNavigationIndexComparer.Instance.Compare(x.Field, y.Field);
			}
			return num;
		}

		// Token: 0x04000D4B RID: 3403
		internal static readonly global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Cell> Instance = new global::Infragistics.Windows.DataPresenter.CellVisiblePositionComparer();
	}
}
