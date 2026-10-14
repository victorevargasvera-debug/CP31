using System;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200064A RID: 1610
	internal class Disposer : global::System.IDisposable
	{
		// Token: 0x06004DF0 RID: 19952 RVA: 0x001177A4 File Offset: 0x001159A4
		internal Disposer(global::System.Action action)
		{
			this._action = action;
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x001177B3 File Offset: 0x001159B3
		public void Dispose()
		{
			this._action();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04001C2A RID: 7210
		private readonly global::System.Action _action;
	}
}
