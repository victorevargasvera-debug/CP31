using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DE RID: 478
	internal class FieldNavigationIndexComparer : global::Infragistics.Windows.Helpers.ClassComparer<global::Infragistics.Windows.DataPresenter.Field>
	{
		// Token: 0x06001B82 RID: 7042 RVA: 0x0007588F File Offset: 0x00073A8F
		private FieldNavigationIndexComparer()
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00075898 File Offset: 0x00073A98
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

		// Token: 0x04000B5B RID: 2907
		internal static readonly global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field> Instance = new global::Infragistics.Windows.DataPresenter.FieldNavigationIndexComparer();
	}
}
