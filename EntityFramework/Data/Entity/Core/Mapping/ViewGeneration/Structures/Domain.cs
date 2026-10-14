using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A2 RID: 1442
	internal class Domain : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060045F5 RID: 17909 RVA: 0x000F5A13 File Offset: 0x000F3C13
		internal Domain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleDiscreteValues) : this(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
		{
			value
		}, possibleDiscreteValues)
		{
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x000F5A26 File Offset: 0x000F3C26
		internal Domain(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> values, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleDiscreteValues)
		{
			this.m_possibleValues = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeterminePossibleValues(values, possibleDiscreteValues);
			this.m_domain = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.ExpandNegationsInDomain(values, this.m_possibleValues);
			this.AssertInvariant();
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x000F5A53 File Offset: 0x000F3C53
		internal Domain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain)
		{
			this.m_domain = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(domain.m_domain, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			this.m_possibleValues = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(domain.m_possibleValues, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			this.AssertInvariant();
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x000F5A8D File Offset: 0x000F3C8D
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> AllPossibleValues
		{
			get
			{
				return this.AllPossibleValuesInternal;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x000F5A98 File Offset: 0x000F3C98
		private global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> AllPossibleValuesInternal
		{
			get
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negatedConstant = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant(this.m_possibleValues);
				return this.m_possibleValues.Union(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
				{
					negatedConstant
				});
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x000F5AC6 File Offset: 0x000F3CC6
		internal int Count
		{
			get
			{
				return this.m_domain.Count;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060045FB RID: 17915 RVA: 0x000F5AD3 File Offset: 0x000F3CD3
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> Values
		{
			get
			{
				return this.m_domain;
			}
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x000F5ADC File Offset: 0x000F3CDC
		internal static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> DeriveDomainFromMemberPath(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, bool leaveDomainUnbounded)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeriveDomainFromType(memberPath.EdmType, edmItemCollection, leaveDomainUnbounded);
			if (memberPath.IsNullable)
			{
				set.Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null);
			}
			return set;
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x000F5B0C File Offset: 0x000F3D0C
		private static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> DeriveDomainFromType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, bool leaveDomainUnbounded)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(type))
			{
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.HasDiscreteDomain(type))
				{
					set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.CreateList(true, false), global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
				}
				else
				{
					set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
					if (leaveDomainUnbounded)
					{
						set.Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull);
					}
				}
			}
			else
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(type))
				{
					type = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)type).ElementType;
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType type2 in global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(type, edmItemCollection, false))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant item = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant(type2);
					list.Add(item);
				}
				set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(list, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			}
			return set;
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x000F5BD4 File Offset: 0x000F3DD4
		internal static bool TryGetDefaultValueForMemberPath(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant defaultConstant)
		{
			object defaultValue = memberPath.DefaultValue;
			defaultConstant = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null;
			if (defaultValue != null)
			{
				defaultConstant = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(defaultValue);
				return true;
			}
			return memberPath.IsNullable || memberPath.IsComputed;
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x000F5C10 File Offset: 0x000F3E10
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant GetDefaultValueForMemberPath(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> wrappersForErrorReporting, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant result = null;
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.TryGetDefaultValueForMemberPath(memberPath, out result))
			{
				string message = global::System.Data.Entity.Resources.Strings.ViewGen_No_Default_Value(memberPath.Extent.Name, memberPath.PathToString(new bool?(false)));
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.NoDefaultValue, message, wrappersForErrorReporting, string.Empty), config);
			}
			return result;
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x000F5C60 File Offset: 0x000F3E60
		internal int GetHash()
		{
			int num = 0;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant obj in this.m_domain)
			{
				num ^= global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer.GetHashCode(obj);
			}
			return num;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x000F5CC0 File Offset: 0x000F3EC0
		internal bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain second)
		{
			return this.m_domain.SetEquals(second.m_domain);
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x000F5CD4 File Offset: 0x000F3ED4
		internal bool ContainsNotNull()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negatedConstant = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.GetNegatedConstant(this.m_domain);
			return negatedConstant != null && negatedConstant.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x000F5CFD File Offset: 0x000F3EFD
		internal bool Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant)
		{
			return this.m_domain.Contains(constant);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x000F5D0C File Offset: 0x000F3F0C
		internal static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> ExpandNegationsInDomain(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> otherPossibleValues)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeterminePossibleValues(domain, otherPossibleValues);
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in domain)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negatedConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant;
				if (negatedConstant != null)
				{
					set2.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant(set));
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> elements = set.Difference(negatedConstant.Elements);
					set2.AddRange(elements);
				}
				else
				{
					set2.Add(constant);
				}
			}
			return set2;
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x000F5D9C File Offset: 0x000F3F9C
		internal static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> ExpandNegationsInDomain(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.ExpandNegationsInDomain(domain, domain);
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x000F5DA8 File Offset: 0x000F3FA8
		private static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> DeterminePossibleValues(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in domain)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negatedConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant;
				if (negatedConstant != null)
				{
					using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> enumerator2 = negatedConstant.Elements.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant element = enumerator2.Current;
							set.Add(element);
						}
						continue;
					}
				}
				set.Add(constant);
			}
			return set;
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x000F5E4C File Offset: 0x000F404C
		internal static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> ComputeConstantDomainSetsForSlotsInQueryViews(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, bool isValidationEnabled)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in cell.CQuery.GetConjunctsFromWhereClause())
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot restrictedMemberSlot = memberRestriction.RestrictedMemberSlot;
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeriveDomainFromMemberPath(restrictedMemberSlot.MemberPath, edmItemCollection, isValidationEnabled);
					set.AddRange(from c in memberRestriction.Domain.Values
					where !c.Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null) && !c.Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull)
					select c);
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set2;
					if (!dictionary.TryGetValue(restrictedMemberSlot.MemberPath, out set2))
					{
						dictionary[restrictedMemberSlot.MemberPath] = set;
					}
					else
					{
						set2.AddRange(set);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x000F5F58 File Offset: 0x000F4158
		private static bool GetRestrictedOrUnrestrictedDomain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, out global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.TryGetDomainRestrictedByWhereClause(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeriveDomainFromMemberPath(slot.MemberPath, edmItemCollection, true), slot, cellQuery, out domain);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x000F5F70 File Offset: 0x000F4170
		internal static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> ComputeConstantDomainSetsForSlotsInUpdateViews(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cquery = cell.CQuery;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery squery = cell.SQuery;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot in from oneOfConst in squery.GetConjunctsFromWhereClause()
				select oneOfConst.RestrictedMemberSlot)
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set;
					if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.GetRestrictedOrUnrestrictedDomain(memberProjectedSlot, squery, edmItemCollection, out set))
					{
						int projectedPosition = squery.GetProjectedPosition(memberProjectedSlot);
						if (projectedPosition >= 0 && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.GetRestrictedOrUnrestrictedDomain(cquery.ProjectedSlotAt(projectedPosition) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot, cquery, edmItemCollection, out set))
						{
							continue;
						}
					}
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = memberProjectedSlot.MemberPath;
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant element;
					if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.TryGetDefaultValueForMemberPath(memberPath, out element))
					{
						set.Add(element);
					}
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set2;
					if (!dictionary.TryGetValue(memberPath, out set2))
					{
						dictionary[memberPath] = set;
					}
					else
					{
						set2.AddRange(set);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x000F60A4 File Offset: 0x000F42A4
		private static bool TryGetDomainRestrictedByWhereClause(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery, out global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> result)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> enumerable = from restriction in cellQuery.GetConjunctsFromWhereClause()
			where global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(restriction.RestrictedMemberSlot.MemberPath, slot.MemberPath)
			select new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(restriction.Domain.Values, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			if (!enumerable.Any<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>())
			{
				result = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(domain);
				return false;
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleDiscreteValues = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeterminePossibleValues(enumerable.SelectMany((global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> m) => from c in m
			select c), domain);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(domain, possibleDiscreteValues);
			foreach (global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> values in enumerable)
			{
				domain2 = domain2.Intersect(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(values, possibleDiscreteValues));
			}
			result = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(domain2.Values, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			return !domain.SequenceEqual(result);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x000F61A8 File Offset: 0x000F43A8
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain Intersect(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain second)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(this);
			domain.m_domain.Intersect(second.m_domain);
			return domain;
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x000F61C4 File Offset: 0x000F43C4
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant GetNegatedConstant(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> constants)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant result = null;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in constants)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negatedConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant;
				if (negatedConstant != null)
				{
					result = negatedConstant;
				}
			}
			return result;
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x000F6214 File Offset: 0x000F4414
		private static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> DeterminePossibleValues(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain1, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain2)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.DeterminePossibleValues(new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(domain1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer).Union(domain2));
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x000F622C File Offset: 0x000F442C
		[global::System.Diagnostics.Conditional("DEBUG")]
		private static void CheckTwoDomainInvariants(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain2)
		{
			domain1.AssertInvariant();
			domain2.AssertInvariant();
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x000F623A File Offset: 0x000F443A
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> CreateList(object value1, object value2)
		{
			yield return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(value1);
			yield return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(value2);
			yield break;
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x000F6251 File Offset: 0x000F4451
		internal void AssertInvariant()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.GetNegatedConstant(this.m_domain);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.GetNegatedConstant(this.m_possibleValues);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x000F626C File Offset: 0x000F446C
		internal string ToUserString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in this.m_domain)
			{
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(constant.ToUserString());
				flag = false;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x000F62E4 File Offset: 0x000F44E4
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append(this.ToUserString());
		}

		// Token: 0x0400190A RID: 6410
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> m_domain;

		// Token: 0x0400190B RID: 6411
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> m_possibleValues;
	}
}
