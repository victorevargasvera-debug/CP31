using System;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006C RID: 108
	internal class CompletedAction : global::Infragistics.Windows.Helpers.ActionHistory.ActionBase
	{
		// Token: 0x060005B2 RID: 1458 RVA: 0x00016139 File Offset: 0x00014339
		private CompletedAction()
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00016141 File Offset: 0x00014341
		protected internal override bool CanPerform(object context)
		{
			return false;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00016144 File Offset: 0x00014344
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			return null;
		}

		// Token: 0x040001A5 RID: 421
		internal static readonly global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Instance = new global::Infragistics.Windows.DataPresenter.CompletedAction();
	}
}
