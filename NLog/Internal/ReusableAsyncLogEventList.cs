using System;
using System.Collections.Generic;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x0200011B RID: 283
	internal class ReusableAsyncLogEventList : global::NLog.Internal.ReusableObjectCreator<global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo>>
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x00021F3A File Offset: 0x0002013A
		public ReusableAsyncLogEventList(int capacity) : base(new global::System.Collections.Generic.List<global::NLog.Common.AsyncLogEventInfo>(capacity), delegate(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> l)
		{
			l.Clear();
		})
		{
		}
	}
}
