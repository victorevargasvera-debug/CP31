using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000207 RID: 519
	internal class FieldNavigationIndexComparer : global::Infragistics.Windows.Helpers.ClassComparer<global::Infragistics.Windows.DataPresenter.Field>
	{
		// Token: 0x06001F99 RID: 8089 RVA: 0x000897F3 File Offset: 0x000879F3
		private FieldNavigationIndexComparer()
		{
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000897FC File Offset: 0x000879FC
		protected override int CompareOverride(global::Infragistics.Windows.DataPresenter.Field x, global::Infragistics.Windows.DataPresenter.Field y)
		{
			if (x.Owner == y.Owner)
			{
				return x.NavigationIndex.CompareTo(y.NavigationIndex);
			}
			if (x.Owner == null)
			{
				if (y.Owner == null)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (y.Owner == null)
				{
					return 1;
				}
				return x.Owner.Index.CompareTo(y.Owner.Index);
			}
		}

		// Token: 0x04000D4C RID: 3404
		internal static readonly global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field> Instance = new global::Infragistics.Windows.DataPresenter.FieldNavigationIndexComparer();
	}
}
