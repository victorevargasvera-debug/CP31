using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020A RID: 522
	internal class TreeCellVisiblePositionComparer : global::Infragistics.Windows.Helpers.ClassComparer<global::Infragistics.Windows.DataPresenter.Cell>
	{
		// Token: 0x06001FA4 RID: 8100 RVA: 0x000899E4 File Offset: 0x00087BE4
		private TreeCellVisiblePositionComparer()
		{
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x000899EC File Offset: 0x00087BEC
		protected override int CompareOverride(global::Infragistics.Windows.DataPresenter.Cell x, global::Infragistics.Windows.DataPresenter.Cell y)
		{
			int num = x.Record.OverallSelectionPosition.CompareTo(y.Record.OverallSelectionPosition);
			if (num == 0)
			{
				global::Infragistics.Windows.DataPresenter.Field mappedFieldInTree = x.Field.GetMappedFieldInTree(x.DataPresenter.DefaultFieldLayout);
				global::Infragistics.Windows.DataPresenter.Field mappedFieldInTree2 = y.Field.GetMappedFieldInTree(x.DataPresenter.DefaultFieldLayout);
				num = global::Infragistics.Windows.DataPresenter.FieldNavigationIndexComparer.Instance.Compare(mappedFieldInTree, mappedFieldInTree2);
			}
			return num;
		}

		// Token: 0x04000D50 RID: 3408
		internal static readonly global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Cell> Instance = new global::Infragistics.Windows.DataPresenter.TreeCellVisiblePositionComparer();
	}
}
