using System;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200011A RID: 282
	internal class InitializerLockPair : global::System.Tuple<global::System.Action<global::System.Data.Entity.DbContext>, bool>
	{
		// Token: 0x06001377 RID: 4983 RVA: 0x00031C10 File Offset: 0x0002FE10
		public InitializerLockPair(global::System.Action<global::System.Data.Entity.DbContext> initializerDelegate, bool isLocked) : base(initializerDelegate, isLocked)
		{
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00031C1A File Offset: 0x0002FE1A
		public global::System.Action<global::System.Data.Entity.DbContext> InitializerDelegate
		{
			get
			{
				return base.Item1;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00031C22 File Offset: 0x0002FE22
		public bool IsLocked
		{
			get
			{
				return base.Item2;
			}
		}
	}
}
