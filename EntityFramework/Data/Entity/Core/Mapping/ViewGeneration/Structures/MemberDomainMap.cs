using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A6 RID: 1446
	internal class MemberDomainMap : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004646 RID: 17990 RVA: 0x000F6DE2 File Offset: 0x000F4FE2
		private MemberDomainMap(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> domainMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> nonConditionDomainMap, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			this.m_conditionDomainMap = domainMap;
			this.m_nonConditionDomainMap = nonConditionDomainMap;
			this.m_edmItemCollection = edmItemCollection;
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x000F6E0C File Offset: 0x000F500C
		internal MemberDomainMap(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, bool isValidationEnabled, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> extentCells, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>> inheritanceGraph)
		{
			this.m_conditionDomainMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			this.m_edmItemCollection = edmItemCollection;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> dictionary = null;
			if (viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView)
			{
				dictionary = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.ComputeConstantDomainSetsForSlotsInUpdateViews(extentCells, this.m_edmItemCollection);
			}
			else
			{
				dictionary = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.ComputeConstantDomainSetsForSlotsInQueryViews(extentCells, this.m_edmItemCollection, isValidationEnabled);
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in extentCells)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in cell.GetLeftQuery(viewTarget).GetConjunctsFromWhereClause())
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = memberRestriction.RestrictedMemberSlot.MemberPath;
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set;
					if (!dictionary.TryGetValue(memberPath, out set))
					{
						set = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeriveDomainFromMemberPath(memberPath, edmItemCollection, isValidationEnabled);
					}
					if (!set.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null))
					{
						if (memberRestriction.Domain.Values.All((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant conditionConstant) => conditionConstant.Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull)))
						{
							continue;
						}
					}
					if (set.Count <= 0 || (!set.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null) && memberRestriction.Domain.Values.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null)))
					{
						string message = global::System.Data.Entity.Resources.Strings.ViewGen_InvalidCondition(memberPath.PathToString(new bool?(false)));
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.InvalidCondition, message, cell, string.Empty), config);
					}
					if (!memberPath.IsAlwaysDefined(inheritanceGraph))
					{
						set.Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined);
					}
					this.AddToDomainMap(memberPath, set);
				}
			}
			this.m_nonConditionDomainMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell2 in extentCells)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot in cell2.GetLeftQuery(viewTarget).GetAllQuerySlots())
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath2 = memberProjectedSlot.MemberPath;
					if (!this.m_conditionDomainMap.ContainsKey(memberPath2) && !this.m_nonConditionDomainMap.ContainsKey(memberPath2))
					{
						global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeriveDomainFromMemberPath(memberPath2, this.m_edmItemCollection, true);
						if (!memberPath2.IsAlwaysDefined(inheritanceGraph))
						{
							set2.Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined);
						}
						set2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.ExpandNegationsInDomain(set2, set2);
						this.m_nonConditionDomainMap.Add(memberPath2, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap.CellConstantSetInfo(set2));
					}
				}
			}
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x000F70E8 File Offset: 0x000F52E8
		internal bool IsProjectedConditionMember(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath)
		{
			return this.m_projectedConditionMembers.Contains(memberPath);
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x000F70F8 File Offset: 0x000F52F8
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap GetOpenDomain()
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> dictionary = this.m_conditionDomainMap.ToDictionary((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> p) => p.Key, (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> p) => new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(p.Value, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer));
			this.ExpandDomainsIfNeeded(dictionary);
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap(dictionary, this.m_nonConditionDomainMap, this.m_edmItemCollection);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x000F7168 File Offset: 0x000F5368
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap MakeCopy()
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap(this.m_conditionDomainMap.ToDictionary((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> p) => p.Key, (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> p) => new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(p.Value, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer)), this.m_nonConditionDomainMap, this.m_edmItemCollection);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x000F71CF File Offset: 0x000F53CF
		internal void ExpandDomainsToIncludeAllPossibleValues()
		{
			this.ExpandDomainsIfNeeded(this.m_conditionDomainMap);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x000F71E0 File Offset: 0x000F53E0
		private void ExpandDomainsIfNeeded(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> domainMapForMembers)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in domainMapForMembers.Keys)
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = domainMapForMembers[memberPath];
				if (memberPath.IsScalarType())
				{
					if (!set.Any((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant c) => c is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant))
					{
						if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.HasDiscreteDomain(memberPath.EdmType))
						{
							global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> other = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeriveDomainFromMemberPath(memberPath, this.m_edmItemCollection, true);
							set.Unite(other);
						}
						else
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant element = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant(set);
							set.Add(element);
						}
					}
				}
			}
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x000F7298 File Offset: 0x000F5498
		internal void ReduceEnumerableDomainToEnumeratedValues(global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap.ReduceEnumerableDomainToEnumeratedValues(this.m_conditionDomainMap, config, this.m_edmItemCollection);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap.ReduceEnumerableDomainToEnumeratedValues(this.m_nonConditionDomainMap, config, this.m_edmItemCollection);
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x000F72C0 File Offset: 0x000F54C0
		private static void ReduceEnumerableDomainToEnumeratedValues(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> domainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in domainMap.Keys)
			{
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.HasDiscreteDomain(memberPath.EdmType))
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> other = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeriveDomainFromMemberPath(memberPath, edmItemCollection, true);
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = domainMap[memberPath].Difference(other);
					set.Remove(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined);
					if (set.Count > 0)
					{
						if (config.IsNormalTracing)
						{
							global::System.Data.Entity.Core.Common.Utils.Helpers.FormatTraceLine("Changed domain of {0} from {1} - subtract {2}", new object[]
							{
								memberPath,
								domainMap[memberPath],
								set
							});
						}
						domainMap[memberPath].Subtract(set);
					}
				}
			}
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x000F737C File Offset: 0x000F557C
		internal static void PropagateUpdateDomainToQueryDomain(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap queryDomainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap updateDomainMap)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cquery = cell.CQuery;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery squery = cell.SQuery;
				for (int i = 0; i < cquery.NumProjectedSlots; i++)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = cquery.ProjectedSlotAt(i) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot2 = squery.ProjectedSlotAt(i) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
					if (memberProjectedSlot != null && memberProjectedSlot2 != null)
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = memberProjectedSlot.MemberPath;
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath2 = memberProjectedSlot2.MemberPath;
						global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainInternal = queryDomainMap.GetDomainInternal(memberPath);
						global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainInternal2 = updateDomainMap.GetDomainInternal(memberPath2);
						domainInternal.Unite(from constant in domainInternal2
						where !constant.IsNull() && !(constant is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant)
						select constant);
						if (updateDomainMap.IsConditionMember(memberPath2) && !queryDomainMap.IsConditionMember(memberPath))
						{
							queryDomainMap.m_projectedConditionMembers.Add(memberPath);
						}
					}
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap.ExpandNegationsInDomainMap(queryDomainMap.m_conditionDomainMap);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap.ExpandNegationsInDomainMap(queryDomainMap.m_nonConditionDomainMap);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x000F7490 File Offset: 0x000F5690
		private static void ExpandNegationsInDomainMap(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> domainMap)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath key in domainMap.Keys.ToArray<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>())
			{
				domainMap[key] = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.ExpandNegationsInDomain(domainMap[key]);
			}
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x000F74CE File Offset: 0x000F56CE
		internal bool IsConditionMember(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path)
		{
			return this.m_conditionDomainMap.ContainsKey(path);
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x000F74DC File Offset: 0x000F56DC
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> ConditionMembers(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in this.m_conditionDomainMap.Keys)
			{
				if (memberPath.Extent.Equals(extent))
				{
					yield return memberPath;
				}
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.KeyCollection.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.KeyCollection.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x000F74F3 File Offset: 0x000F56F3
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> NonConditionMembers(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in this.m_nonConditionDomainMap.Keys)
			{
				if (memberPath.Extent.Equals(extent))
				{
					yield return memberPath;
				}
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.KeyCollection.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.KeyCollection.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x000F750A File Offset: 0x000F570A
		internal void AddSentinel(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path)
		{
			this.GetDomainInternal(path).Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.AllOtherConstants);
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x000F751D File Offset: 0x000F571D
		internal void RemoveSentinel(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path)
		{
			this.GetDomainInternal(path).Remove(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.AllOtherConstants);
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x000F7530 File Offset: 0x000F5730
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> GetDomain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path)
		{
			return this.GetDomainInternal(path);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x000F753C File Offset: 0x000F573C
		private global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> GetDomainInternal(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> result;
			if (!this.m_conditionDomainMap.TryGetValue(path, out result))
			{
				result = this.m_nonConditionDomainMap[path];
			}
			return result;
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x000F7567 File Offset: 0x000F5767
		internal void UpdateConditionMemberDomain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainValues)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = this.m_conditionDomainMap[path];
			set.Clear();
			set.Unite(domainValues);
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x000F7584 File Offset: 0x000F5784
		private void AddToDomainMap(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainValues)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set;
			if (!this.m_conditionDomainMap.TryGetValue(member, out set))
			{
				set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			}
			set.Unite(domainValues);
			this.m_conditionDomainMap[member] = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.ExpandNegationsInDomain(set, set);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x000F75C8 File Offset: 0x000F57C8
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in this.m_conditionDomainMap.Keys)
			{
				builder.Append('(');
				memberPath.ToCompactString(builder);
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain = this.GetDomain(memberPath);
				builder.Append(": ");
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(builder, domain);
				builder.Append(") ");
			}
		}

		// Token: 0x0400191A RID: 6426
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> m_conditionDomainMap;

		// Token: 0x0400191B RID: 6427
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> m_nonConditionDomainMap;

		// Token: 0x0400191C RID: 6428
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_projectedConditionMembers = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();

		// Token: 0x0400191D RID: 6429
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection m_edmItemCollection;

		// Token: 0x02000BD6 RID: 3030
		private class CellConstantSetInfo : global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>
		{
			// Token: 0x06006849 RID: 26697 RVA: 0x001629E7 File Offset: 0x00160BE7
			internal CellConstantSetInfo(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> iconstants) : base(iconstants)
			{
			}
		}
	}
}
