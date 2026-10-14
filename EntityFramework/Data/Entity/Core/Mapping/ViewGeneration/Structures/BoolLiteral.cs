using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x02000597 RID: 1431
	internal abstract class BoolLiteral : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004550 RID: 17744 RVA: 0x000F3CA4 File Offset: 0x000F1EA4
		internal static global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> MakeTermExpression(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(domain, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(range, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral.MakeTermExpression(literal, domain2, range2);
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x000F3CD4 File Offset: 0x000F1ED4
		internal static global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> MakeTermExpression(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range)
		{
			domain.MakeReadOnly();
			range.MakeReadOnly();
			global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> identifier = new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(literal, domain, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral.EqualityIdentifierComparer), range);
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Default, identifier);
		}

		// Token: 0x06004552 RID: 17746
		internal abstract global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> FixRange(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap);

		// Token: 0x06004553 RID: 17747
		internal abstract global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> GetDomainBoolExpression(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap);

		// Token: 0x06004554 RID: 17748
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral RemapBool(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap);

		// Token: 0x06004555 RID: 17749
		internal abstract void GetRequiredSlots(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, bool[] requiredSlots);

		// Token: 0x06004556 RID: 17750
		internal abstract global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull);

		// Token: 0x06004557 RID: 17751
		internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, bool skipIsNotNull);

		// Token: 0x06004558 RID: 17752
		internal abstract global::System.Text.StringBuilder AsUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull);

		// Token: 0x06004559 RID: 17753
		internal abstract global::System.Text.StringBuilder AsNegatedUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull);

		// Token: 0x0600455A RID: 17754 RVA: 0x000F3D0D File Offset: 0x000F1F0D
		protected virtual bool IsIdentifierEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral right)
		{
			return this.IsEqualTo(right);
		}

		// Token: 0x0600455B RID: 17755
		protected abstract bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral right);

		// Token: 0x0600455C RID: 17756 RVA: 0x000F3D16 File Offset: 0x000F1F16
		protected virtual int GetIdentifierHash()
		{
			return this.GetHashCode();
		}

		// Token: 0x040018E3 RID: 6371
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral> EqualityComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral.BoolLiteralComparer();

		// Token: 0x040018E4 RID: 6372
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral> EqualityIdentifierComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral.IdentifierComparer();

		// Token: 0x02000BB1 RID: 2993
		private sealed class BoolLiteralComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral>
		{
			// Token: 0x06006783 RID: 26499 RVA: 0x0016138D File Offset: 0x0015F58D
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral left, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral right)
			{
				return left == right || (left != null && right != null && left.IsEqualTo(right));
			}

			// Token: 0x06006784 RID: 26500 RVA: 0x001613A4 File Offset: 0x0015F5A4
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal)
			{
				return literal.GetHashCode();
			}
		}

		// Token: 0x02000BB2 RID: 2994
		private sealed class IdentifierComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral>
		{
			// Token: 0x06006786 RID: 26502 RVA: 0x001613B4 File Offset: 0x0015F5B4
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral left, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral right)
			{
				return left == right || (left != null && right != null && left.IsIdentifierEqualTo(right));
			}

			// Token: 0x06006787 RID: 26503 RVA: 0x001613CB File Offset: 0x0015F5CB
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal)
			{
				return literal.GetIdentifierHash();
			}
		}
	}
}
