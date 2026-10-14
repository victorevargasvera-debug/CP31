using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000083 RID: 131
	public class CustomFilterDialogFilteringDataContext : global::Infragistics.FilteringDataContext
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x000153A7 File Offset: 0x000135A7
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x000153AF File Offset: 0x000135AF
		private global::Infragistics.Controls.Grids.Primitives.ProxyValueContainer Container { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x000153B8 File Offset: 0x000135B8
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x000153C0 File Offset: 0x000135C0
		private string PropertyName { get; set; }

		// Token: 0x06000492 RID: 1170 RVA: 0x000153CC File Offset: 0x000135CC
		public CustomFilterDialogFilteringDataContext(global::Infragistics.Controls.Grids.Primitives.FilterRowCell frc, global::Infragistics.Controls.Grids.Primitives.ProxyValueContainer proxyValueContainer, string propName) : base(frc)
		{
			this.PropertyName = propName;
			this.Container = proxyValueContainer;
			if (this.PropertyName == "ProxyValue1")
			{
				base.SetValueSilent(this.Container.ProxyValue1);
				return;
			}
			if (this.PropertyName == "ProxyValue2")
			{
				base.SetValueSilent(this.Container.ProxyValue2);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00015438 File Offset: 0x00013638
		protected override void OnValueChanged()
		{
			if (this.PropertyName == "ProxyValue1")
			{
				this.Container.ProxyValue1 = base.Value;
				return;
			}
			if (this.PropertyName == "ProxyValue2")
			{
				this.Container.ProxyValue2 = base.Value;
			}
		}
	}
}
