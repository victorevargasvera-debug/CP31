using System;
using System.Runtime.CompilerServices;

namespace CefSharp.Internals
{
	// Token: 0x020000D1 RID: 209
	public class FreezableBase
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x00009FCB File Offset: 0x000081CB
		public void Freeze()
		{
			this.frozen = true;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00009FD4 File Offset: 0x000081D4
		protected void ThrowIfFrozen([global::System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
		{
			if (this.frozen)
			{
				throw new global::System.Exception(base.GetType().Name + "." + memberName + " can no longer be modified, settings must be changed before the underlying browser has been created.");
			}
		}

		// Token: 0x0400037E RID: 894
		private bool frozen;
	}
}
