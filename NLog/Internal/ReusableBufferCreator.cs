using System;

namespace NLog.Internal
{
	// Token: 0x0200011C RID: 284
	internal class ReusableBufferCreator : global::NLog.Internal.ReusableObjectCreator<char[]>
	{
		// Token: 0x06000D84 RID: 3460 RVA: 0x00021F67 File Offset: 0x00020167
		public ReusableBufferCreator(int capacity) : base(new char[capacity], delegate(char[] b)
		{
		})
		{
		}
	}
}
