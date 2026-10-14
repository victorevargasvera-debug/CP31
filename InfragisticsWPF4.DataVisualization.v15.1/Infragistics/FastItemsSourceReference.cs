using System;

namespace Infragistics
{
	// Token: 0x0200003F RID: 63
	public class FastItemsSourceReference
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x0000F00B File Offset: 0x0000D20B
		public FastItemsSourceReference(global::Infragistics.IFastItemsSource source)
		{
			this.FastItemsSource = source;
			this.References = 0;
		}

		// Token: 0x0400013D RID: 317
		public global::Infragistics.IFastItemsSource FastItemsSource;

		// Token: 0x0400013E RID: 318
		public int References;
	}
}
