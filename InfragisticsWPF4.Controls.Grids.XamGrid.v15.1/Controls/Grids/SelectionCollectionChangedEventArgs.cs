using System;
using System.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000197 RID: 407
	public class SelectionCollectionChangedEventArgs<T> : global::System.EventArgs where T : global::System.Collections.IEnumerable
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0002A09D File Offset: 0x0002829D
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x0002A0A5 File Offset: 0x000282A5
		public T PreviouslySelectedItems { get; protected internal set; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0002A0AE File Offset: 0x000282AE
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x0002A0B6 File Offset: 0x000282B6
		public T NewSelectedItems { get; protected internal set; }
	}
}
