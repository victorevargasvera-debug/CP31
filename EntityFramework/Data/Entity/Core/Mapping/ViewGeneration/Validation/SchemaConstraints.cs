using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x02000580 RID: 1408
	internal class SchemaConstraints<TKeyConstraint> : global::System.Data.Entity.Core.Common.Utils.InternalBase where TKeyConstraint : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004441 RID: 17473 RVA: 0x000EF088 File Offset: 0x000ED288
		internal SchemaConstraints()
		{
			this.m_keyConstraints = new global::System.Collections.Generic.List<TKeyConstraint>();
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x000EF09B File Offset: 0x000ED29B
		internal global::System.Collections.Generic.IEnumerable<TKeyConstraint> KeyConstraints
		{
			get
			{
				return this.m_keyConstraints;
			}
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x000EF0A3 File Offset: 0x000ED2A3
		internal void Add(TKeyConstraint constraint)
		{
			this.m_keyConstraints.Add(constraint);
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x000EF0B4 File Offset: 0x000ED2B4
		private static void ConstraintsToBuilder<Constraint>(global::System.Collections.Generic.IEnumerable<Constraint> constraints, global::System.Text.StringBuilder builder) where Constraint : global::System.Data.Entity.Core.Common.Utils.InternalBase
		{
			foreach (Constraint constraint in constraints)
			{
				constraint.ToCompactString(builder);
				builder.Append(global::System.Environment.NewLine);
			}
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x000EF10C File Offset: 0x000ED30C
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<TKeyConstraint>.ConstraintsToBuilder<TKeyConstraint>(this.m_keyConstraints, builder);
		}

		// Token: 0x04001899 RID: 6297
		private readonly global::System.Collections.Generic.List<TKeyConstraint> m_keyConstraints;
	}
}
