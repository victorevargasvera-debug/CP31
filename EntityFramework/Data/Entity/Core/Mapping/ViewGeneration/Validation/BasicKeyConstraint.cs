using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x02000578 RID: 1400
	internal class BasicKeyConstraint : global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.KeyConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicCellRelation, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot>
	{
		// Token: 0x06004402 RID: 17410 RVA: 0x000ECA08 File Offset: 0x000EAC08
		internal BasicKeyConstraint(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicCellRelation relation, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> keySlots) : base(relation, keySlots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer)
		{
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x000ECA18 File Offset: 0x000EAC18
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint Propagate()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation viewCellRelation = base.CellRelation.ViewCellRelation;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot in base.KeySlots)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot viewCellSlot = viewCellRelation.LookupViewSlot(slot);
				if (viewCellSlot == null)
				{
					return null;
				}
				list.Add(viewCellSlot);
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint(viewCellRelation, list);
		}
	}
}
