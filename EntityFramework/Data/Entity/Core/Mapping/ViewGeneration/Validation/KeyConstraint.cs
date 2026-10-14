using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x0200057F RID: 1407
	internal class KeyConstraint<TCellRelation, TSlot> : global::System.Data.Entity.Core.Common.Utils.InternalBase where TCellRelation : global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.CellRelation
	{
		// Token: 0x0600443D RID: 17469 RVA: 0x000EF01A File Offset: 0x000ED21A
		internal KeyConstraint(TCellRelation relation, global::System.Collections.Generic.IEnumerable<TSlot> keySlots, global::System.Collections.Generic.IEqualityComparer<TSlot> comparer)
		{
			this.m_relation = relation;
			this.m_keySlots = new global::System.Data.Entity.Core.Common.Utils.Set<TSlot>(keySlots, comparer).MakeReadOnly();
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x000EF03B File Offset: 0x000ED23B
		protected TCellRelation CellRelation
		{
			get
			{
				return this.m_relation;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x000EF043 File Offset: 0x000ED243
		protected global::System.Data.Entity.Core.Common.Utils.Set<TSlot> KeySlots
		{
			get
			{
				return this.m_keySlots;
			}
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x000EF04B File Offset: 0x000ED24B
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "Key (V{0}) - ", new object[]
			{
				this.m_relation.CellNumber
			});
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringSorted(builder, this.KeySlots, ", ");
		}

		// Token: 0x04001897 RID: 6295
		private readonly TCellRelation m_relation;

		// Token: 0x04001898 RID: 6296
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<TSlot> m_keySlots;
	}
}
