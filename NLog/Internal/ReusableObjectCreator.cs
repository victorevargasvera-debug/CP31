using System;

namespace NLog.Internal
{
	// Token: 0x0200011E RID: 286
	internal class ReusableObjectCreator<T> where T : class
	{
		// Token: 0x06000D86 RID: 3462 RVA: 0x00021FC0 File Offset: 0x000201C0
		protected ReusableObjectCreator(T reusableObject, global::System.Action<T> clearObject)
		{
			this._reusableObject = reusableObject;
			this._clearObject = clearObject;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00021FD6 File Offset: 0x000201D6
		public global::NLog.Internal.ReusableObjectCreator<T>.LockOject Allocate()
		{
			return new global::NLog.Internal.ReusableObjectCreator<T>.LockOject(this);
		}

		// Token: 0x040003B2 RID: 946
		protected T _reusableObject;

		// Token: 0x040003B3 RID: 947
		private readonly global::System.Action<T> _clearObject;

		// Token: 0x040003B4 RID: 948
		public readonly global::NLog.Internal.ReusableObjectCreator<T>.LockOject None;

		// Token: 0x02000214 RID: 532
		public struct LockOject : global::System.IDisposable
		{
			// Token: 0x060012FB RID: 4859 RVA: 0x000312B5 File Offset: 0x0002F4B5
			public LockOject(global::NLog.Internal.ReusableObjectCreator<T> owner)
			{
				this.Result = owner._reusableObject;
				owner._reusableObject = default(T);
				this._owner = owner;
			}

			// Token: 0x060012FC RID: 4860 RVA: 0x000312D6 File Offset: 0x0002F4D6
			public void Dispose()
			{
				if (this.Result != null)
				{
					this._owner._clearObject(this.Result);
					this._owner._reusableObject = this.Result;
				}
			}

			// Token: 0x040005E3 RID: 1507
			public readonly T Result;

			// Token: 0x040005E4 RID: 1508
			private readonly global::NLog.Internal.ReusableObjectCreator<T> _owner;
		}
	}
}
