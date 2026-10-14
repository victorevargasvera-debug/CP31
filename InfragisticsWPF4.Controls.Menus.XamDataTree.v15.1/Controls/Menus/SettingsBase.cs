using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200002B RID: 43
	public abstract class SettingsBase : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00008CFA File Offset: 0x00006EFA
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00008D02 File Offset: 0x00006F02
		protected internal global::Infragistics.Controls.Menus.XamDataTree Tree
		{
			get
			{
				return this._tree;
			}
			set
			{
				if (this._tree != value)
				{
					this._tree = value;
					this.OnTreeSet();
				}
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00008D1A File Offset: 0x00006F1A
		protected virtual void OnTreeSet()
		{
		}

		// Token: 0x04000090 RID: 144
		private global::Infragistics.Controls.Menus.XamDataTree _tree;
	}
}
