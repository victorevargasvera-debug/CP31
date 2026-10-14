using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005B2 RID: 1458
	internal abstract class TrueFalseLiteral : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral
	{
		// Token: 0x06004709 RID: 18185 RVA: 0x000F9F70 File Offset: 0x000F8170
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> GetDomainBoolExpression(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> elements = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
			{
				new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(true)
			};
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
			{
				new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(true),
				new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(false)
			}, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer).MakeReadOnly();
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(elements, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer).MakeReadOnly();
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral.MakeTermExpression(this, domain, range);
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x000F9FE0 File Offset: 0x000F81E0
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> FixRange(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant scalarConstant = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant)range.First<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>();
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr = this.GetDomainBoolExpression(memberDomainMap);
			if (!(bool)scalarConstant.Value)
			{
				boolExpr = new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(boolExpr);
			}
			return boolExpr;
		}
	}
}
