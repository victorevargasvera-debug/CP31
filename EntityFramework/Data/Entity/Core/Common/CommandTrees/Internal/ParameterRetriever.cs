using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006F0 RID: 1776
	internal sealed class ParameterRetriever : global::System.Data.Entity.Core.Common.CommandTrees.BasicCommandTreeVisitor
	{
		// Token: 0x060052B9 RID: 21177 RVA: 0x001282BF File Offset: 0x001264BF
		private ParameterRetriever()
		{
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x001282D2 File Offset: 0x001264D2
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> GetParameters(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree tree)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.ParameterRetriever parameterRetriever = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.ParameterRetriever();
			parameterRetriever.VisitCommandTree(tree);
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(parameterRetriever.paramMappings.Values.ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>());
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x001282F4 File Offset: 0x001264F4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
			this.paramMappings[expression.ParameterName] = expression;
		}

		// Token: 0x04001DE7 RID: 7655
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> paramMappings = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>();
	}
}
