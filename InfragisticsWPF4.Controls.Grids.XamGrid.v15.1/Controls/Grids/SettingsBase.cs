using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200000A RID: 10
	public abstract class SettingsBase : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00007432 File Offset: 0x00005632
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000743A File Offset: 0x0000563A
		protected internal global::Infragistics.Controls.Grids.XamGrid Grid
		{
			get
			{
				return this._grid;
			}
			set
			{
				if (this._grid != value)
				{
					this._grid = value;
					this.OnGridSet();
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007452 File Offset: 0x00005652
		protected virtual void OnGridSet()
		{
		}

		// Token: 0x04000028 RID: 40
		private global::Infragistics.Controls.Grids.XamGrid _grid;
	}
}
