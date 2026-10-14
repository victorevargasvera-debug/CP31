using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x02000583 RID: 1411
	internal class ViewKeyConstraint : global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.KeyConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot>
	{
		// Token: 0x06004456 RID: 17494 RVA: 0x000EF3D1 File Offset: 0x000ED5D1
		internal ViewKeyConstraint(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation relation, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> keySlots) : base(relation, keySlots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer)
		{
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x000EF3E0 File Offset: 0x000ED5E0
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell Cell
		{
			get
			{
				return base.CellRelation.Cell;
			}
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x000EF3F0 File Offset: 0x000ED5F0
		internal bool Implies(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint second)
		{
			if (base.CellRelation != second.CellRelation)
			{
				return false;
			}
			if (base.KeySlots.IsSubsetOf(second.KeySlots))
			{
				return true;
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot>(second.KeySlots);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot viewCellSlot in base.KeySlots)
			{
				bool flag = false;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot viewCellSlot2 in set)
				{
					if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(viewCellSlot.SSlot, viewCellSlot2.SSlot))
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = viewCellSlot.CSlot.MemberPath;
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath2 = viewCellSlot2.CSlot.MemberPath;
						if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(memberPath, memberPath2) || memberPath.IsEquivalentViaRefConstraint(memberPath2))
						{
							set.Remove(viewCellSlot2);
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x000EF514 File Offset: 0x000ED714
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record GetErrorRecord(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint rightKeyConstraint)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot>(rightKeyConstraint.KeySlots);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = list[0].SSlot.MemberPath.Extent;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent2 = list[0].CSlot.MemberPath.Extent;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(extent);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(extent2);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey primaryKeyForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetPrimaryKeyForEntityType(prefix, (global::System.Data.Entity.Core.Metadata.Edm.EntityType)extent.ElementType);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey extentKey;
			if (extent2 is global::System.Data.Entity.Core.Metadata.Edm.EntitySet)
			{
				extentKey = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetPrimaryKeyForEntityType(prefix2, (global::System.Data.Entity.Core.Metadata.Edm.EntityType)extent2.ElementType);
			}
			else
			{
				extentKey = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetKeyForRelationType(prefix2, (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)extent2.ElementType);
			}
			string message = global::System.Data.Entity.Resources.Strings.ViewGen_KeyConstraint_Violation(extent.Name, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot.SlotsToUserString(rightKeyConstraint.KeySlots, false), primaryKeyForEntityType.ToUserString(), extent2.Name, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot.SlotsToUserString(rightKeyConstraint.KeySlots, true), extentKey.ToUserString());
			string debugMessage = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("PROBLEM: Not implied {0}", new object[]
			{
				rightKeyConstraint
			});
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.KeyConstraintViolation, message, rightKeyConstraint.CellRelation.Cell, debugMessage);
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x000EF614 File Offset: 0x000ED814
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record GetErrorRecord(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> rightKeyConstraints)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint viewKeyConstraint = null;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint viewKeyConstraint2 in rightKeyConstraints)
			{
				string value = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot.SlotsToUserString(viewKeyConstraint2.KeySlots, true);
				if (!flag)
				{
					stringBuilder.Append("; ");
				}
				flag = false;
				stringBuilder.Append(value);
				viewKeyConstraint = viewKeyConstraint2;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot>(viewKeyConstraint.KeySlots);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = list[0].SSlot.MemberPath.Extent;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent2 = list[0].CSlot.MemberPath.Extent;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey primaryKeyForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetPrimaryKeyForEntityType(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(extent), (global::System.Data.Entity.Core.Metadata.Edm.EntityType)extent.ElementType);
			string message;
			if (extent2 is global::System.Data.Entity.Core.Metadata.Edm.EntitySet)
			{
				message = global::System.Data.Entity.Resources.Strings.ViewGen_KeyConstraint_Update_Violation_EntitySet(stringBuilder.ToString(), extent2.Name, primaryKeyForEntityType.ToUserString(), extent.Name);
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endThatShouldBeMappedToKey = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetEndThatShouldBeMappedToKey(((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)extent2).ElementType);
				if (endThatShouldBeMappedToKey != null)
				{
					message = global::System.Data.Entity.Resources.Strings.ViewGen_AssociationEndShouldBeMappedToKey(endThatShouldBeMappedToKey.Name, extent.Name);
				}
				else
				{
					message = global::System.Data.Entity.Resources.Strings.ViewGen_KeyConstraint_Update_Violation_AssociationSet(extent2.Name, primaryKeyForEntityType.ToUserString(), extent.Name);
				}
			}
			string debugMessage = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("PROBLEM: Not implied {0}", new object[]
			{
				viewKeyConstraint
			});
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.KeyConstraintUpdateViolation, message, viewKeyConstraint.CellRelation.Cell, debugMessage);
		}
	}
}
