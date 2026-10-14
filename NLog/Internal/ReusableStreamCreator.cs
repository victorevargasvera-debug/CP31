using System;
using System.IO;

namespace NLog.Internal
{
	// Token: 0x0200011F RID: 287
	internal class ReusableStreamCreator : global::NLog.Internal.ReusableObjectCreator<global::System.IO.MemoryStream>, global::System.IDisposable
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x00021FDE File Offset: 0x000201DE
		public ReusableStreamCreator(int capacity) : base(new global::System.IO.MemoryStream(capacity), delegate(global::System.IO.MemoryStream m)
		{
			m.Position = 0L;
			m.SetLength(0L);
		})
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0002200B File Offset: 0x0002020B
		void global::System.IDisposable.Dispose()
		{
			this._reusableObject.Dispose();
		}
	}
}
