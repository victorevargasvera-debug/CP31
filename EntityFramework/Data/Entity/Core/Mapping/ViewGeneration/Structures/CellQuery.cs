using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x0200059D RID: 1437
	internal class CellQuery : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004599 RID: 17817 RVA: 0x000F491C File Offset: 0x000F2B1C
		internal CellQuery(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> slots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath rootMember, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct eliminateDuplicates) : this(slots.ToArray(), whereClause, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>(), eliminateDuplicates, rootMember)
		{
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x000F4933 File Offset: 0x000F2B33
		internal CellQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] projectedSlots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> boolExprs, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct elimDupl, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath rootMember)
		{
			this.m_boolExprs = boolExprs;
			this.m_projectedSlots = projectedSlots;
			this.m_whereClause = whereClause;
			this.m_originalWhereClause = whereClause;
			this.m_selectDistinct = elimDupl;
			this.m_extentMemberPath = rootMember;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x000F4968 File Offset: 0x000F2B68
		internal CellQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery source)
		{
			this.m_basicCellRelation = source.m_basicCellRelation;
			this.m_boolExprs = source.m_boolExprs;
			this.m_selectDistinct = source.m_selectDistinct;
			this.m_extentMemberPath = source.m_extentMemberPath;
			this.m_originalWhereClause = source.m_originalWhereClause;
			this.m_projectedSlots = source.m_projectedSlots;
			this.m_whereClause = source.m_whereClause;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x000F49CF File Offset: 0x000F2BCF
		private CellQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery existing, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] newSlots) : this(newSlots, existing.m_whereClause, existing.m_boolExprs, existing.m_selectDistinct, existing.m_extentMemberPath)
		{
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x000F49F0 File Offset: 0x000F2BF0
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct SelectDistinctFlag
		{
			get
			{
				return this.m_selectDistinct;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x000F49F8 File Offset: 0x000F2BF8
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Extent
		{
			get
			{
				return this.m_extentMemberPath.Extent;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x000F4A05 File Offset: 0x000F2C05
		internal int NumProjectedSlots
		{
			get
			{
				return this.m_projectedSlots.Length;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x000F4A0F File Offset: 0x000F2C0F
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] ProjectedSlots
		{
			get
			{
				return this.m_projectedSlots;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x000F4A17 File Offset: 0x000F2C17
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> BoolVars
		{
			get
			{
				return this.m_boolExprs;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x000F4A1F File Offset: 0x000F2C1F
		internal int NumBoolVars
		{
			get
			{
				return this.m_boolExprs.Count;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x000F4A2C File Offset: 0x000F2C2C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression WhereClause
		{
			get
			{
				return this.m_whereClause;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x000F4A34 File Offset: 0x000F2C34
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath SourceExtentMemberPath
		{
			get
			{
				return this.m_extentMemberPath;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x000F4A3C File Offset: 0x000F2C3C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicCellRelation BasicCellRelation
		{
			get
			{
				return this.m_basicCellRelation;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x000F4A44 File Offset: 0x000F2C44
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction> Conditions
		{
			get
			{
				return this.GetConjunctsFromOriginalWhereClause();
			}
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x000F4A4C File Offset: 0x000F2C4C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot ProjectedSlotAt(int slotNum)
		{
			return this.m_projectedSlots[slotNum];
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x000F4A58 File Offset: 0x000F2C58
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record CheckForDuplicateFields(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell sourceCell)
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot, int> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot, int>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer);
			for (int i = 0; i < this.m_projectedSlots.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot key = this.m_projectedSlots[i] as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
				keyToListMap.Add(key, i);
			}
			global::System.Text.StringBuilder stringBuilder = null;
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot in keyToListMap.Keys)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<int> readOnlyCollection = keyToListMap.ListForKey(memberProjectedSlot);
				if (readOnlyCollection.Count > 1 && !cQuery.AreSlotsEquivalentViaRefConstraints(readOnlyCollection))
				{
					flag = true;
					if (stringBuilder == null)
					{
						stringBuilder = new global::System.Text.StringBuilder(global::System.Data.Entity.Resources.Strings.ViewGen_Duplicate_CProperties(this.Extent.Name));
						stringBuilder.AppendLine();
					}
					global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
					for (int j = 0; j < readOnlyCollection.Count; j++)
					{
						int num = readOnlyCollection[j];
						if (j != 0)
						{
							stringBuilder2.Append(", ");
						}
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot2 = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)cQuery.m_projectedSlots[num];
						stringBuilder2.Append(memberProjectedSlot2.ToUserString());
					}
					stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ViewGen_Duplicate_CProperties_IsMapped(memberProjectedSlot.ToUserString(), stringBuilder2.ToString()));
				}
			}
			if (!flag)
			{
				return null;
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.DuplicateCPropertiesMapped, stringBuilder.ToString(), sourceCell, string.Empty);
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x000F4BB8 File Offset: 0x000F2DB8
		private bool AreSlotsEquivalentViaRefConstraints(global::System.Collections.ObjectModel.ReadOnlyCollection<int> cSideSlotIndexes)
		{
			if (!(this.Extent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet))
			{
				return false;
			}
			if (cSideSlotIndexes.Count > 2)
			{
				return false;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)this.m_projectedSlots[cSideSlotIndexes[0]];
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot2 = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)this.m_projectedSlots[cSideSlotIndexes[1]];
			return memberProjectedSlot.MemberPath.IsEquivalentViaRefConstraint(memberProjectedSlot2.MemberPath);
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x000F4C18 File Offset: 0x000F2E18
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record CheckForProjectedNotNullSlots(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell sourceCell, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> associationSets)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in this.Conditions)
			{
				if (memberRestriction.Domain.ContainsNotNull() && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot.GetSlotForMember(this.m_projectedSlots, memberRestriction.RestrictedMemberSlot.MemberPath) == null)
				{
					bool flag2 = true;
					if (this.Extent is global::System.Data.Entity.Core.Metadata.Edm.EntitySet)
					{
						bool flag3 = sourceCell.CQuery == this;
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget target = flag3 ? global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView;
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery = flag3 ? sourceCell.SQuery : sourceCell.CQuery;
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet rightExtent = cellQuery.Extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
						if (rightExtent != null)
						{
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> associationSets2 = (cellQuery.Extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet).AssociationSets;
							global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, bool> predicate;
							global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, bool> <>9__0;
							if ((predicate = <>9__0) == null)
							{
								global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, bool> <>9__1;
								predicate = (<>9__0 = delegate(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet association)
								{
									global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> associationSetEnds = association.AssociationSetEnds;
									global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, bool> predicate3;
									if ((predicate3 = <>9__1) == null)
									{
										predicate3 = (<>9__1 = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd end) => end.CorrespondingAssociationEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOppositeEnd(end).EntitySet.EdmEquals(rightExtent)));
									}
									return associationSetEnds.Any(predicate3);
								});
							}
							using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> enumerator2 = associationSets2.Where(predicate).GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									global::System.Data.Entity.Core.Metadata.Edm.AssociationSet association = enumerator2.Current;
									global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell, bool> predicate2;
									global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell, bool> <>9__2;
									if ((predicate2 = <>9__2) == null)
									{
										predicate2 = (<>9__2 = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell c) => c.GetRightQuery(target).Extent.EdmEquals(association)));
									}
									using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> enumerator3 = associationSets.Where(predicate2).GetEnumerator())
									{
										while (enumerator3.MoveNext())
										{
											if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot.GetSlotForMember(enumerator3.Current.GetLeftQuery(target).ProjectedSlots, memberRestriction.RestrictedMemberSlot.MemberPath) != null)
											{
												flag2 = false;
											}
										}
									}
								}
							}
						}
					}
					if (flag2)
					{
						stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ViewGen_NotNull_No_Projected_Slot(memberRestriction.RestrictedMemberSlot.MemberPath.PathToString(new bool?(false))));
						flag = true;
					}
				}
			}
			if (!flag)
			{
				return null;
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.NotNullNoProjectedSlot, stringBuilder.ToString(), sourceCell, string.Empty);
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x000F4E78 File Offset: 0x000F3078
		internal void FixMissingSlotAsDefaultConstant(int slotNumber, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot slot)
		{
			this.m_projectedSlots[slotNumber] = slot;
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x000F4E84 File Offset: 0x000F3084
		internal void CreateFieldAlignedCellQueries(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery otherQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery newMainQuery, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery newOtherQuery)
		{
			int count = projectedSlotMap.Count;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] array = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[count];
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] array2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[count];
			for (int i = 0; i < this.m_projectedSlots.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = this.m_projectedSlots[i] as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
				int num = projectedSlotMap.IndexOf(memberProjectedSlot.MemberPath);
				array[num] = this.m_projectedSlots[i];
				array2[num] = otherQuery.m_projectedSlots[i];
			}
			newMainQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(this, array);
			newOtherQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(otherQuery, array2);
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x000F4F00 File Offset: 0x000F3100
		internal global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetNonNullSlots()
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot in this.m_projectedSlots)
			{
				if (projectedSlot != null)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = projectedSlot as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
					set.Add(memberProjectedSlot.MemberPath);
				}
			}
			return set;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x000F4F4C File Offset: 0x000F314C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record VerifyKeysPresent(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell ownerCell, global::System.Func<object, object, string> formatEntitySetMessage, global::System.Func<object, object, object, string> formatAssociationSetMessage, global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode errorCode)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(1);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey>(1);
			if (this.Extent is global::System.Data.Entity.Core.Metadata.Edm.EntitySet)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(this.Extent);
				list.Add(memberPath);
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)this.Extent.ElementType;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey> keysForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetKeysForEntityType(memberPath, entityType);
				list2.Add(keysForEntityType[0]);
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.Extent;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember correspondingAssociationEndMember = associationSetEnd.CorrespondingAssociationEndMember;
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(associationSet, correspondingAssociationEndMember);
					list.Add(memberPath2);
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey> keysForEntityType2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetKeysForEntityType(memberPath2, global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(correspondingAssociationEndMember));
					list2.Add(keysForEntityType2[0]);
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath3 = list[i];
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot.GetKeySlots(this.GetMemberProjectedSlots(), memberPath3) == null)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey extentKey = list2[i];
					string message;
					if (this.Extent is global::System.Data.Entity.Core.Metadata.Edm.EntitySet)
					{
						string arg = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(extentKey.KeyFields, true);
						message = formatEntitySetMessage(arg, this.Extent.Name);
					}
					else
					{
						string name = memberPath3.RootEdmMember.Name;
						string arg2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(extentKey.KeyFields, false);
						message = formatAssociationSetMessage(arg2, name, this.Extent.Name);
					}
					return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(errorCode, message, ownerCell, string.Empty);
				}
			}
			return null;
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x000F50F0 File Offset: 0x000F32F0
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetProjectedMembers()
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot in this.GetMemberProjectedSlots())
			{
				yield return memberProjectedSlot.MemberPath;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x000F5100 File Offset: 0x000F3300
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> GetMemberProjectedSlots()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] array = this.m_projectedSlots;
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = array[i] as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
				if (memberProjectedSlot != null)
				{
					yield return memberProjectedSlot;
				}
			}
			array = null;
			yield break;
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x000F5110 File Offset: 0x000F3310
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> GetAllQuerySlots()
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot>(this.GetMemberProjectedSlots());
			hashSet.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(this.SourceExtentMemberPath));
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in this.Conditions)
			{
				hashSet.Add(memberRestriction.RestrictedMemberSlot);
			}
			return new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot>(hashSet);
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x000F5188 File Offset: 0x000F3388
		internal int GetProjectedPosition(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot)
		{
			for (int i = 0; i < this.m_projectedSlots.Length; i++)
			{
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(slot, this.m_projectedSlots[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x000F51C0 File Offset: 0x000F33C0
		internal global::System.Collections.Generic.List<int> GetProjectedPositions(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			for (int i = 0; i < this.m_projectedSlots.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = this.m_projectedSlots[i] as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
				if (memberProjectedSlot != null && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(member, memberProjectedSlot.MemberPath))
				{
					list.Add(i);
				}
			}
			return list;
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x000F5214 File Offset: 0x000F3414
		internal global::System.Collections.Generic.List<int> GetProjectedPositions(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> paths)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member in paths)
			{
				global::System.Collections.Generic.List<int> projectedPositions = this.GetProjectedPositions(member);
				if (projectedPositions.Count == 0)
				{
					return null;
				}
				list.Add(projectedPositions[0]);
			}
			return list;
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x000F5284 File Offset: 0x000F3484
		internal global::System.Collections.Generic.List<int> GetAssociationEndSlots(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			for (int i = 0; i < this.m_projectedSlots.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = this.m_projectedSlots[i] as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
				if (memberProjectedSlot != null && memberProjectedSlot.MemberPath.RootEdmMember.Equals(endMember))
				{
					list.Add(i);
				}
			}
			return list;
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x000F52D8 File Offset: 0x000F34D8
		internal global::System.Collections.Generic.List<int> GetProjectedPositions(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> paths, global::System.Collections.Generic.List<int> slotsToSearchFrom)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member in paths)
			{
				global::System.Collections.Generic.List<int> projectedPositions = this.GetProjectedPositions(member);
				if (projectedPositions.Count == 0)
				{
					return null;
				}
				int num = -1;
				if (projectedPositions.Count > 1)
				{
					for (int i = 0; i < projectedPositions.Count; i++)
					{
						if (slotsToSearchFrom.Contains(projectedPositions[i]))
						{
							num = projectedPositions[i];
						}
					}
					if (num == -1)
					{
						return null;
					}
				}
				else
				{
					num = projectedPositions[0];
				}
				list.Add(num);
			}
			return list;
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x000F5390 File Offset: 0x000F3590
		internal void UpdateWhereClause(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression in this.WhereClause.Atoms)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction = boolExpression.AsLiteral as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction;
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain = domainMap.GetDomain(memberRestriction.RestrictedMemberSlot.MemberPath);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction2 = memberRestriction.CreateCompleteMemberRestriction(domain);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction scalarRestriction = memberRestriction as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction;
				bool flag = scalarRestriction != null && !scalarRestriction.Domain.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null) && !scalarRestriction.Domain.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull) && !scalarRestriction.Domain.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined);
				if (flag)
				{
					domainMap.AddSentinel(memberRestriction2.RestrictedMemberSlot.MemberPath);
				}
				list.Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(memberRestriction2, domainMap));
				if (flag)
				{
					domainMap.RemoveSentinel(memberRestriction2.RestrictedMemberSlot.MemberPath);
				}
			}
			if (list.Count > 0)
			{
				this.m_whereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(list.ToArray());
			}
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x000F54A8 File Offset: 0x000F36A8
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression GetBoolVar(int varNum)
		{
			return this.m_boolExprs[varNum];
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x000F54B8 File Offset: 0x000F36B8
		internal void InitializeBoolExpressions(int numBoolVars, int cellNum)
		{
			this.m_boolExprs = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>(numBoolVars);
			for (int i = 0; i < numBoolVars; i++)
			{
				this.m_boolExprs.Add(null);
			}
			this.m_boolExprs[cellNum] = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x000F54FA File Offset: 0x000F36FA
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction> GetConjunctsFromWhereClause()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.GetConjunctsFromWhereClause(this.m_whereClause);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x000F5507 File Offset: 0x000F3707
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction> GetConjunctsFromOriginalWhereClause()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.GetConjunctsFromWhereClause(this.m_originalWhereClause);
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x000F5514 File Offset: 0x000F3714
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction> GetConjunctsFromWhereClause(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression in whereClause.Atoms)
			{
				if (!boolExpression.IsTrue)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction = boolExpression.AsLiteral as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction;
					yield return memberRestriction;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x000F5524 File Offset: 0x000F3724
		internal void GetIdentifiers(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] projectedSlots = this.m_projectedSlots;
			for (int i = 0; i < projectedSlots.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = projectedSlots[i] as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
				if (memberProjectedSlot != null)
				{
					memberProjectedSlot.MemberPath.GetIdentifiers(identifiers);
				}
			}
			this.m_extentMemberPath.GetIdentifiers(identifiers);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x000F556C File Offset: 0x000F376C
		internal void CreateBasicCellRelation(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation viewCellRelation)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot> allQuerySlots = this.GetAllQuerySlots();
			this.m_basicCellRelation = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicCellRelation(this, viewCellRelation, allQuerySlots);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x000F5590 File Offset: 0x000F3790
		internal override void ToCompactString(global::System.Text.StringBuilder stringBuilder)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> boolExprs = this.m_boolExprs;
			int num = 0;
			bool flag = true;
			using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>.Enumerator enumerator = boolExprs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current != null)
					{
						if (!flag)
						{
							stringBuilder.Append(",");
						}
						else
						{
							stringBuilder.Append("[");
						}
						global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(stringBuilder, "C{0}", new object[]
						{
							num
						});
						flag = false;
					}
					num++;
				}
			}
			if (flag)
			{
				this.ToFullString(stringBuilder);
				return;
			}
			stringBuilder.Append("]");
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x000F5638 File Offset: 0x000F3838
		internal override void ToFullString(global::System.Text.StringBuilder builder)
		{
			builder.Append("SELECT ");
			if (this.m_selectDistinct == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.Yes)
			{
				builder.Append("DISTINCT ");
			}
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(builder, this.m_projectedSlots, ", ", "_");
			if (this.m_boolExprs.Count > 0)
			{
				builder.Append(", Bool[");
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(builder, this.m_boolExprs, ", ", "_");
				builder.Append("]");
			}
			builder.Append(" FROM ");
			this.m_extentMemberPath.ToFullString(builder);
			if (!this.m_whereClause.IsTrue)
			{
				builder.Append(" WHERE ");
				this.m_whereClause.ToFullString(builder);
			}
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x000F56F4 File Offset: 0x000F38F4
		public override string ToString()
		{
			return this.ToFullString();
		}

		// Token: 0x040018F5 RID: 6389
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> m_boolExprs;

		// Token: 0x040018F6 RID: 6390
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] m_projectedSlots;

		// Token: 0x040018F7 RID: 6391
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression m_whereClause;

		// Token: 0x040018F8 RID: 6392
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression m_originalWhereClause;

		// Token: 0x040018F9 RID: 6393
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct m_selectDistinct;

		// Token: 0x040018FA RID: 6394
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath m_extentMemberPath;

		// Token: 0x040018FB RID: 6395
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicCellRelation m_basicCellRelation;

		// Token: 0x02000BB7 RID: 2999
		internal enum SelectDistinct
		{
			// Token: 0x04002E91 RID: 11921
			Yes,
			// Token: 0x04002E92 RID: 11922
			No
		}
	}
}
