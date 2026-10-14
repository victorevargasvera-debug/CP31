using System;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000071 RID: 113
	internal class CompletedAction : global::Infragistics.Windows.Helpers.ActionHistory.ActionBase
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x00018535 File Offset: 0x00016735
		private CompletedAction()
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001853D File Offset: 0x0001673D
		protected internal override bool CanPerform(object context)
		{
			return false;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00018540 File Offset: 0x00016740
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			return null;
		}

		// Token: 0x040001DE RID: 478
		internal static readonly global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Instance = new global::Infragistics.Windows.DataPresenter.CompletedAction();
	}
}
