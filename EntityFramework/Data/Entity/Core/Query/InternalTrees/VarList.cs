using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003FB RID: 1019
	[global::System.Diagnostics.DebuggerDisplay("{{{ToString()}}}")]
	internal class VarList : global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>
	{
		// Token: 0x06002F78 RID: 12152 RVA: 0x00094E87 File Offset: 0x00093087
		internal VarList()
		{
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00094E8F File Offset: 0x0009308F
		internal VarList(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> vars) : base(vars)
		{
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00094E98 File Offset: 0x00093098
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = string.Empty;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in this)
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}{1}", new object[]
				{
					text,
					var.Id
				});
				text = ",";
			}
			return stringBuilder.ToString();
		}
	}
}
