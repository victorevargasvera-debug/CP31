using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006EE RID: 1774
	internal sealed class DbExpressionList : global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>
	{
		// Token: 0x060052B1 RID: 21169 RVA: 0x00127E0A File Offset: 0x0012600A
		internal DbExpressionList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> elements) : base(elements)
		{
		}
	}
}
