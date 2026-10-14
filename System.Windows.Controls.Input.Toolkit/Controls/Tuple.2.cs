using System;

namespace System.Windows.Controls
{
	// Token: 0x02000004 RID: 4
	internal class Tuple<T0, T1>
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020D9 File Offset: 0x000002D9
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020E1 File Offset: 0x000002E1
		public T0 First { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020EA File Offset: 0x000002EA
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020F2 File Offset: 0x000002F2
		public T1 Second { get; private set; }

		// Token: 0x06000012 RID: 18 RVA: 0x000020FB File Offset: 0x000002FB
		public Tuple(T0 first, T1 second)
		{
			this.First = first;
			this.Second = second;
		}
	}
}
