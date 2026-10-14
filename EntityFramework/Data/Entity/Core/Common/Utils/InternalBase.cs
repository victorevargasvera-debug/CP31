using System;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F7 RID: 1527
	internal abstract class InternalBase
	{
		// Token: 0x06004ABB RID: 19131
		internal abstract void ToCompactString(global::System.Text.StringBuilder builder);

		// Token: 0x06004ABC RID: 19132 RVA: 0x00107F98 File Offset: 0x00106198
		internal virtual void ToFullString(global::System.Text.StringBuilder builder)
		{
			this.ToCompactString(builder);
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x00107FA4 File Offset: 0x001061A4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.ToCompactString(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x00107FC4 File Offset: 0x001061C4
		internal virtual string ToFullString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.ToFullString(stringBuilder);
			return stringBuilder.ToString();
		}
	}
}
