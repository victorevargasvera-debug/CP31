using System;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000626 RID: 1574
	internal sealed class Vertex : global::System.IEquatable<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>
	{
		// Token: 0x06004C27 RID: 19495 RVA: 0x0010B30D File Offset: 0x0010950D
		private Vertex()
		{
			this.Variable = int.MaxValue;
			this.Children = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[0];
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x0010B32C File Offset: 0x0010952C
		internal Vertex(int variable, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] children)
		{
			if (variable >= 2147483647)
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.BoolExprAssert, 0, "exceeded number of supported variables");
			}
			this.Variable = variable;
			this.Children = children;
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x0010B35C File Offset: 0x0010955C
		[global::System.Diagnostics.Conditional("DEBUG")]
		private static void AssertConstructorArgumentsValid(int variable, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] children)
		{
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex in children)
			{
			}
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x0010B37D File Offset: 0x0010957D
		internal bool IsOne()
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One == this;
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x0010B387 File Offset: 0x00109587
		internal bool IsZero()
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero == this;
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x0010B391 File Offset: 0x00109591
		internal bool IsSink()
		{
			return this.Variable == int.MaxValue;
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x0010B3A0 File Offset: 0x001095A0
		public bool Equals(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex other)
		{
			return this == other;
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x0010B3A6 File Offset: 0x001095A6
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x0010B3AF File Offset: 0x001095AF
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x0010B3B8 File Offset: 0x001095B8
		public override string ToString()
		{
			if (this.IsOne())
			{
				return "_1_";
			}
			if (this.IsZero())
			{
				return "_0_";
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "<{0}, {1}>", new object[]
			{
				this.Variable,
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(this.Children)
			});
		}

		// Token: 0x04001A91 RID: 6801
		internal static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex One = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex();

		// Token: 0x04001A92 RID: 6802
		internal static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex Zero = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex();

		// Token: 0x04001A93 RID: 6803
		internal readonly int Variable;

		// Token: 0x04001A94 RID: 6804
		internal readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] Children;
	}
}
