using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x02000581 RID: 1409
	internal class ViewCellRelation : global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.CellRelation
	{
		// Token: 0x06004446 RID: 17478 RVA: 0x000EF11A File Offset: 0x000ED31A
		internal ViewCellRelation(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> slots, int cellNumber) : base(cellNumber)
		{
			this.m_cell = cell;
			this.m_slots = slots;
			this.m_cell.CQuery.CreateBasicCellRelation(this);
			this.m_cell.SQuery.CreateBasicCellRelation(this);
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x000EF153 File Offset: 0x000ED353
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell Cell
		{
			get
			{
				return this.m_cell;
			}
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x000EF15C File Offset: 0x000ED35C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot LookupViewSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot viewCellSlot in this.m_slots)
			{
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(slot, viewCellSlot.CSlot) || global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(slot, viewCellSlot.SSlot))
				{
					return viewCellSlot;
				}
			}
			return null;
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x000EF1D8 File Offset: 0x000ED3D8
		protected override int GetHash()
		{
			return this.m_cell.GetHashCode();
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x000EF1E5 File Offset: 0x000ED3E5
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append("ViewRel[");
			this.m_cell.ToCompactString(builder);
			builder.Append(']');
		}

		// Token: 0x0400189A RID: 6298
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell m_cell;

		// Token: 0x0400189B RID: 6299
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> m_slots;
	}
}
