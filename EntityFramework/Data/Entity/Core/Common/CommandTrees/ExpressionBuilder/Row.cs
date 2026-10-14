using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
{
	// Token: 0x020006F9 RID: 1785
	public sealed class Row
	{
		// Token: 0x060053ED RID: 21485 RVA: 0x0012CDB1 File Offset: 0x0012AFB1
		public Row(global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> columnValue, params global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>[] columnValues)
		{
			this.arguments = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(global::System.Data.Entity.Core.Common.Utils.Helpers.Prepend<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(columnValues, columnValue));
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x0012CDCB File Offset: 0x0012AFCB
		public global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression ToExpression()
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(this.arguments);
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x0012CDD8 File Offset: 0x0012AFD8
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Row row)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Row>(row, "row");
			return row.ToExpression();
		}

		// Token: 0x04001E0E RID: 7694
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> arguments;
	}
}
