using System;
using System.Text;

namespace NLog.Internal
{
	// Token: 0x0200011D RID: 285
	internal class ReusableBuilderCreator : global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>
	{
		// Token: 0x06000D85 RID: 3461 RVA: 0x00021F94 File Offset: 0x00020194
		public ReusableBuilderCreator() : base(new global::System.Text.StringBuilder(), delegate(global::System.Text.StringBuilder sb)
		{
			sb.ClearBuilder();
		})
		{
		}
	}
}
