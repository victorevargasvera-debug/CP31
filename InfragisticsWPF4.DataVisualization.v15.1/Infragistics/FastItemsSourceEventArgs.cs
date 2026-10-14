using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x02000042 RID: 66
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class FastItemsSourceEventArgs : global::System.EventArgs
	{
		// Token: 0x060003AB RID: 939 RVA: 0x0000F021 File Offset: 0x0000D221
		public FastItemsSourceEventArgs(global::Infragistics.FastItemsSourceEventAction action, int position, int count)
		{
			this.Action = action;
			this.Position = position;
			this.Count = count;
			this.PropertyName = null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000F045 File Offset: 0x0000D245
		public FastItemsSourceEventArgs(int position, string propertyName)
		{
			this.Action = global::Infragistics.FastItemsSourceEventAction.Change;
			this.Position = position;
			this.Count = 1;
			this.PropertyName = propertyName;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000F069 File Offset: 0x0000D269
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000F071 File Offset: 0x0000D271
		public global::Infragistics.FastItemsSourceEventAction Action { get; private set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000F07A File Offset: 0x0000D27A
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0000F082 File Offset: 0x0000D282
		public int Position { get; private set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000F08B File Offset: 0x0000D28B
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x0000F093 File Offset: 0x0000D293
		public int Count { get; private set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000F09C File Offset: 0x0000D29C
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		public string PropertyName { get; private set; }
	}
}
