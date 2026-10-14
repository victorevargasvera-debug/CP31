using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x0200057D RID: 1405
	internal class ErrorPatternMatcher
	{
		// Token: 0x06004410 RID: 17424 RVA: 0x000ECBC4 File Offset: 0x000EADC4
		private ErrorPatternMatcher(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
		{
			this.m_viewgenContext = context;
			this.m_domainMap = domainMap;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.GetKeyMembers(context.Extent, domainMap);
			this.m_errorLog = errorLog;
			this.m_originalErrorCount = this.m_errorLog.Count;
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x000ECC00 File Offset: 0x000EAE00
		public static bool FindMappingErrors(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
		{
			if (context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView && !context.Config.IsValidationEnabled)
			{
				return false;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher errorPatternMatcher = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher(context, domainMap, errorLog);
			errorPatternMatcher.MatchMissingMappingErrors();
			errorPatternMatcher.MatchConditionErrors();
			errorPatternMatcher.MatchSplitErrors();
			if (errorPatternMatcher.m_errorLog.Count == errorPatternMatcher.m_originalErrorCount)
			{
				errorPatternMatcher.MatchPartitionErrors();
			}
			if (errorPatternMatcher.m_errorLog.Count > errorPatternMatcher.m_originalErrorCount)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(errorPatternMatcher.m_errorLog, errorPatternMatcher.m_viewgenContext.Config);
			}
			return false;
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x000ECC84 File Offset: 0x000EAE84
		private void MatchMissingMappingErrors()
		{
			if (this.m_viewgenContext.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(this.m_viewgenContext.Extent.ElementType, this.m_viewgenContext.EdmItemCollection, false));
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in this.m_viewgenContext.AllWrappersForExtent)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in leftCellWrapper.Cells)
					{
						foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in cell.CQuery.Conditions)
						{
							foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in memberRestriction.Domain.Values)
							{
								global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant typeConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant;
								if (typeConstant != null)
								{
									set.Remove(typeConstant.EdmType);
								}
							}
						}
					}
				}
				if (set.Count > 0)
				{
					this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternMissingMappingError, global::System.Data.Entity.Resources.Strings.ViewGen_Missing_Type_Mapping(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.BuildCommaSeparatedErrorString<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(set)), this.m_viewgenContext.AllWrappersForExtent, ""));
				}
			}
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x000ECE10 File Offset: 0x000EB010
		private static bool HasNotNullCondition(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in cellQuery.GetConjunctsFromWhereClause())
			{
				if (memberRestriction.RestrictedMemberSlot.MemberPath.Equals(member))
				{
					if (memberRestriction.Domain.Values.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull))
					{
						return true;
					}
					using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant> enumerator2 = (from cellConstant in memberRestriction.Domain.Values
					select cellConstant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant into negated
					where negated != null
					select negated).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.Elements.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null))
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x000ECF2C File Offset: 0x000EB12C
		private static bool IsMemberPartOfNotNullCondition(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> wrappers, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath leftMember, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget)
		{
			global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, bool> <>9__0;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in wrappers)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery leftQuery = leftCellWrapper.OnlyInputCell.GetLeftQuery(viewTarget);
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.HasNotNullCondition(leftQuery, leftMember))
				{
					return true;
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightQuery = leftCellWrapper.OnlyInputCell.GetRightQuery(viewTarget);
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> projectedMembers = leftQuery.GetProjectedMembers();
				global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path) => !path.Equals(leftMember)));
				}
				int num = projectedMembers.TakeWhile(predicate).Count<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
				if (num < leftQuery.GetProjectedMembers().Count<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>())
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)rightQuery.ProjectedSlotAt(num)).MemberPath;
					if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.HasNotNullCondition(rightQuery, memberPath))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x000ED01C File Offset: 0x000EB21C
		private void MatchConditionErrors()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> allWrappersForExtent = this.m_viewgenContext.AllWrappersForExtent;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ConditionComparer());
			global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ConditionComparer());
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in allWrappersForExtent)
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>();
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in leftCellWrapper.OnlyInputCell.GetLeftQuery(this.m_viewgenContext.ViewTarget).GetConjunctsFromWhereClause())
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = memberRestriction.RestrictedMemberSlot.MemberPath;
					if (this.m_domainMap.IsConditionMember(memberPath))
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction scalarRestriction = memberRestriction as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction;
						if (scalarRestriction != null && !set.Contains(memberPath) && !leftCellWrapper.OnlyInputCell.CQuery.WhereClause.Equals(leftCellWrapper.OnlyInputCell.SQuery.WhereClause) && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.IsMemberPartOfNotNullCondition(allWrappersForExtent, memberPath, this.m_viewgenContext.ViewTarget))
						{
							this.CheckThatConditionMemberIsNotMapped(memberPath, allWrappersForExtent, set);
						}
						if (this.m_viewgenContext.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView && scalarRestriction != null && memberPath.IsNullable && global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.IsMemberPartOfNotNullCondition(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper[]
						{
							leftCellWrapper
						}, memberPath, this.m_viewgenContext.ViewTarget))
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath rightMemberPath = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.GetRightMemberPath(memberPath, leftCellWrapper);
							if (rightMemberPath != null && rightMemberPath.IsNullable && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.IsMemberPartOfNotNullCondition(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper[]
							{
								leftCellWrapper
							}, rightMemberPath, this.m_viewgenContext.ViewTarget))
							{
								this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternConditionError, global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_NotNullConditionMappedToNullableMember(memberPath, rightMemberPath), leftCellWrapper.OnlyInputCell, ""));
							}
						}
						foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant element in memberRestriction.Domain.Values)
						{
							global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set3;
							if (!dictionary2.TryGetValue(memberPath, out set3))
							{
								set3 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
								dictionary2.Add(memberPath, set3);
							}
							set3.Add(element);
						}
					}
				}
				if (dictionary2.Count > 0)
				{
					if (set2.Contains(dictionary2))
					{
						if (!this.RightSideEqual(dictionary[dictionary2], leftCellWrapper))
						{
							this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternConditionError, global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_DuplicateConditionValue(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.BuildCommaSeparatedErrorString<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(dictionary2.Keys)), global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ToIEnum(dictionary[dictionary2].OnlyInputCell, leftCellWrapper.OnlyInputCell), ""));
						}
					}
					else
					{
						set2.Add(dictionary2);
						dictionary.Add(dictionary2, leftCellWrapper);
					}
				}
			}
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x000ED324 File Offset: 0x000EB524
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath GetRightMemberPath(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath conditionMember, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper)
		{
			global::System.Collections.Generic.List<int> projectedPositions = leftCellWrapper.OnlyInputCell.GetRightQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView).GetProjectedPositions(conditionMember);
			if (projectedPositions.Count != 1)
			{
				return null;
			}
			int slotNum = projectedPositions.First<int>();
			return ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)leftCellWrapper.OnlyInputCell.GetLeftQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView).ProjectedSlotAt(slotNum)).MemberPath;
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x000ED374 File Offset: 0x000EB574
		private void MatchSplitErrors()
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> enumerable = from r in this.m_viewgenContext.AllWrappersForExtent
			where !(r.LeftExtent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet) && !(r.RightCellQuery.Extent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)
			select r;
			if (this.m_viewgenContext.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView && enumerable.Any<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>())
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper = enumerable.First<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>();
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = leftCellWrapper.RightCellQuery.Extent;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper2 in enumerable)
				{
					if (!leftCellWrapper2.RightCellQuery.Extent.EdmEquals(extent) && !this.RightSideEqual(leftCellWrapper2, leftCellWrapper))
					{
						this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternSplittingError, global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_TableMappedToMultipleES(leftCellWrapper2.LeftExtent.ToString(), leftCellWrapper2.RightCellQuery.Extent.ToString(), extent.ToString()), leftCellWrapper2.Cells.First<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>(), ""));
					}
				}
			}
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x000ED484 File Offset: 0x000EB684
		private void MatchPartitionErrors()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> allWrappersForExtent = this.m_viewgenContext.AllWrappersForExtent;
			int num = 0;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in allWrappersForExtent)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper2 in allWrappersForExtent.Skip(++num))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = this.CreateRightFragmentQuery(leftCellWrapper);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery2 = this.CreateRightFragmentQuery(leftCellWrapper2);
					bool flag = this.CompareS(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsDisjointFrom, this.m_viewgenContext, leftCellWrapper, leftCellWrapper2, fragmentQuery, fragmentQuery2);
					bool flag2 = this.CompareC(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsDisjointFrom, this.m_viewgenContext, leftCellWrapper, leftCellWrapper2, fragmentQuery, fragmentQuery2);
					bool flag3;
					bool flag4;
					bool flag5;
					if (flag)
					{
						if (flag2)
						{
							continue;
						}
						flag3 = this.CompareC(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsContainedIn, this.m_viewgenContext, leftCellWrapper, leftCellWrapper2, fragmentQuery, fragmentQuery2);
						flag4 = this.CompareC(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsContainedIn, this.m_viewgenContext, leftCellWrapper2, leftCellWrapper, fragmentQuery2, fragmentQuery);
						flag5 = (flag3 && flag4);
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						if (flag5)
						{
							stringBuilder.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Disj_Eq);
						}
						else if (flag3 || flag4)
						{
							if (this.CSideHasDifferentEntitySets(leftCellWrapper, leftCellWrapper2))
							{
								stringBuilder.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Disj_Subs_Ref);
							}
							else
							{
								stringBuilder.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Disj_Subs);
							}
						}
						else
						{
							stringBuilder.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Disj_Unk);
						}
						this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternInvalidPartitionError, stringBuilder.ToString(), global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ToIEnum(leftCellWrapper.OnlyInputCell, leftCellWrapper2.OnlyInputCell), ""));
						if (this.FoundTooManyErrors())
						{
							return;
						}
					}
					else
					{
						flag3 = this.CompareC(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsContainedIn, this.m_viewgenContext, leftCellWrapper, leftCellWrapper2, fragmentQuery, fragmentQuery2);
						flag4 = this.CompareC(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsContainedIn, this.m_viewgenContext, leftCellWrapper2, leftCellWrapper, fragmentQuery2, fragmentQuery);
					}
					bool flag6 = this.CompareS(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsContainedIn, this.m_viewgenContext, leftCellWrapper, leftCellWrapper2, fragmentQuery, fragmentQuery2);
					bool flag7 = this.CompareS(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsContainedIn, this.m_viewgenContext, leftCellWrapper2, leftCellWrapper, fragmentQuery2, fragmentQuery);
					flag5 = (flag3 && flag4);
					if (flag6 && flag7)
					{
						if (!flag5)
						{
							global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
							if (flag2)
							{
								stringBuilder2.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Eq_Disj);
							}
							else if (flag3 || flag4)
							{
								if (this.CSideHasDifferentEntitySets(leftCellWrapper, leftCellWrapper2))
								{
									stringBuilder2.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Eq_Subs_Ref);
								}
								else
								{
									if (leftCellWrapper.LeftExtent.Equals(leftCellWrapper2.LeftExtent))
									{
										bool flag8;
										global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmType> list;
										global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.GetTypesAndConditionForWrapper(leftCellWrapper, out flag8, out list);
										bool flag9;
										global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmType> list2;
										global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.GetTypesAndConditionForWrapper(leftCellWrapper2, out flag9, out list2);
										if (!flag8 && !flag9 && (list.Except(list2).Count<global::System.Data.Entity.Core.Metadata.Edm.EdmType>() != 0 || list2.Except(list).Count<global::System.Data.Entity.Core.Metadata.Edm.EdmType>() != 0) && (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.CheckForStoreConditions(leftCellWrapper) || !global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.CheckForStoreConditions(leftCellWrapper2)))
										{
											global::System.Collections.Generic.IEnumerable<string> list3 = (from it in list
											select it.FullName).Union(from it in list2
											select it.FullName);
											this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternConditionError, global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_MultipleTypesMappedToSameTable_WithoutCondition(global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(list3), leftCellWrapper.LeftExtent), global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ToIEnum(leftCellWrapper.OnlyInputCell, leftCellWrapper2.OnlyInputCell), ""));
											return;
										}
									}
									stringBuilder2.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Eq_Subs);
								}
							}
							else if (!this.IsQueryView() && (leftCellWrapper.OnlyInputCell.CQuery.Extent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet || leftCellWrapper2.OnlyInputCell.CQuery.Extent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet))
							{
								stringBuilder2.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Eq_Unk_Association);
							}
							else
							{
								stringBuilder2.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Eq_Unk);
							}
							this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternInvalidPartitionError, stringBuilder2.ToString(), global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ToIEnum(leftCellWrapper.OnlyInputCell, leftCellWrapper2.OnlyInputCell), ""));
							if (this.FoundTooManyErrors())
							{
								return;
							}
						}
					}
					else if ((flag6 || flag7) && (!flag6 || !flag3 || flag4) && (!flag7 || !flag4 || flag3))
					{
						global::System.Text.StringBuilder stringBuilder3 = new global::System.Text.StringBuilder();
						if (flag2)
						{
							stringBuilder3.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Sub_Disj);
						}
						else if (flag5)
						{
							if (this.CSideHasDifferentEntitySets(leftCellWrapper, leftCellWrapper2))
							{
								stringBuilder3.Append(" " + global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Sub_Eq_Ref);
							}
							else
							{
								stringBuilder3.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Sub_Eq);
							}
						}
						else
						{
							stringBuilder3.Append(global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_Partition_Sub_Unk);
						}
						this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternInvalidPartitionError, stringBuilder3.ToString(), global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ToIEnum(leftCellWrapper.OnlyInputCell, leftCellWrapper2.OnlyInputCell), ""));
						if (this.FoundTooManyErrors())
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x000ED974 File Offset: 0x000EBB74
		private static void GetTypesAndConditionForWrapper(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper, out bool hasCondition, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmType> edmTypes)
		{
			hasCondition = false;
			edmTypes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in wrapper.Cells)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in cell.CQuery.Conditions)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in memberRestriction.Domain.Values)
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant typeConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant;
						if (typeConstant != null)
						{
							edmTypes.Add(typeConstant.EdmType);
						}
						else
						{
							hasCondition = true;
						}
					}
				}
			}
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x000EDA54 File Offset: 0x000EBC54
		private static bool CheckForStoreConditions(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper)
		{
			return wrapper.Cells.SelectMany((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell c) => c.SQuery.Conditions).Any<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction>();
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x000EDA88 File Offset: 0x000EBC88
		private void CheckThatConditionMemberIsNotMapped(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath conditionMember, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> mappingFragments, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> mappedConditionMembers)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in mappingFragments)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in leftCellWrapper.Cells)
				{
					if (cell.GetLeftQuery(this.m_viewgenContext.ViewTarget).GetProjectedMembers().Contains(conditionMember))
					{
						mappedConditionMembers.Add(conditionMember);
						this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ErrorPatternConditionError, global::System.Data.Entity.Resources.Strings.Viewgen_ErrorPattern_ConditionMemberIsMapped(conditionMember.ToString()), cell, ""));
					}
				}
			}
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x000EDB50 File Offset: 0x000EBD50
		private bool FoundTooManyErrors()
		{
			return this.m_errorLog.Count > this.m_originalErrorCount + 5;
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x000EDB68 File Offset: 0x000EBD68
		private static string BuildCommaSeparatedErrorString<T>(global::System.Collections.Generic.IEnumerable<T> members)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			T t = members.First<T>();
			foreach (T t2 in members)
			{
				if (!t2.Equals(t))
				{
					stringBuilder.Append(", ");
				}
				global::System.Text.StringBuilder stringBuilder2 = stringBuilder;
				string str = "'";
				T t3 = t2;
				stringBuilder2.Append(str + ((t3 != null) ? t3.ToString() : null) + "'");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x000EDC10 File Offset: 0x000EBE10
		private bool CSideHasDifferentEntitySets(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper a, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper b)
		{
			if (this.IsQueryView())
			{
				return a.LeftExtent == b.LeftExtent;
			}
			return a.RightCellQuery == b.RightCellQuery;
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x000EDC37 File Offset: 0x000EBE37
		private bool CompareC(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP op, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftWrapper1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftWrapper2, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery rightQuery1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery rightQuery2)
		{
			return this.Compare(true, op, context, leftWrapper1, leftWrapper2, rightQuery1, rightQuery2);
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x000EDC49 File Offset: 0x000EBE49
		private bool CompareS(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP op, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftWrapper1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftWrapper2, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery rightQuery1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery rightQuery2)
		{
			return this.Compare(false, op, context, leftWrapper1, leftWrapper2, rightQuery1, rightQuery2);
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x000EDC5C File Offset: 0x000EBE5C
		private bool Compare(bool lookingForC, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP op, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftWrapper1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftWrapper2, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery rightQuery1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery rightQuery2)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.LCWComparer lcwcomparer;
			if ((lookingForC && this.IsQueryView()) || (!lookingForC && !this.IsQueryView()))
			{
				if (op == global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsContainedIn)
				{
					lcwcomparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.LCWComparer(context.LeftFragmentQP.IsContainedIn);
				}
				else
				{
					if (op != global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsDisjointFrom)
					{
						return false;
					}
					lcwcomparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.LCWComparer(context.LeftFragmentQP.IsDisjointFrom);
				}
				return lcwcomparer(leftWrapper1.FragmentQuery, leftWrapper2.FragmentQuery);
			}
			if (op == global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsContainedIn)
			{
				lcwcomparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.LCWComparer(context.RightFragmentQP.IsContainedIn);
			}
			else
			{
				if (op != global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.ComparisonOP.IsDisjointFrom)
				{
					return false;
				}
				lcwcomparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.LCWComparer(context.RightFragmentQP.IsDisjointFrom);
			}
			return lcwcomparer(rightQuery1, rightQuery2);
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x000EDD00 File Offset: 0x000EBF00
		private bool RightSideEqual(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper2)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q = this.CreateRightFragmentQuery(wrapper1);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q2 = this.CreateRightFragmentQuery(wrapper2);
			return this.m_viewgenContext.RightFragmentQP.IsEquivalentTo(q, q2);
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x000EDD2F File Offset: 0x000EBF2F
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery CreateRightFragmentQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(wrapper.OnlyInputCell.CellLabel.ToString(), wrapper.CreateRoleBoolean(), wrapper.OnlyInputCell.GetRightQuery(this.m_viewgenContext.ViewTarget));
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x000EDD62 File Offset: 0x000EBF62
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> ToIEnum(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell one, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell two)
		{
			return new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>
			{
				one,
				two
			};
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x000EDD77 File Offset: 0x000EBF77
		private bool IsQueryView()
		{
			return this.m_viewgenContext.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView;
		}

		// Token: 0x0400188D RID: 6285
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext m_viewgenContext;

		// Token: 0x0400188E RID: 6286
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_domainMap;

		// Token: 0x0400188F RID: 6287
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog m_errorLog;

		// Token: 0x04001890 RID: 6288
		private readonly int m_originalErrorCount;

		// Token: 0x04001891 RID: 6289
		private const int NUM_PARTITION_ERR_TO_FIND = 5;

		// Token: 0x02000B88 RID: 2952
		private enum ComparisonOP
		{
			// Token: 0x04002E0F RID: 11791
			IsContainedIn,
			// Token: 0x04002E10 RID: 11792
			IsDisjointFrom
		}
	}
}
