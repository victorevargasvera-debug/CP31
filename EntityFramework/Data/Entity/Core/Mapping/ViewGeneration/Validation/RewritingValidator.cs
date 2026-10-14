using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x02000576 RID: 1398
	internal class RewritingValidator
	{
		// Token: 0x060043EF RID: 17391 RVA: 0x000EBF2C File Offset: 0x000EA12C
		internal RewritingValidator(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode basicView)
		{
			this._viewgenContext = context;
			this._basicView = basicView;
			this._domainMap = this._viewgenContext.MemberMaps.UpdateDomainMap;
			this._keyAttributes = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.GetKeyMembers(this._viewgenContext.Extent, this._domainMap);
			this._errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x000EBF8C File Offset: 0x000EA18C
		internal void Validate()
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> memberValueTrees = this.CreateMemberValueTrees(false);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> memberValueTrees2 = this.CreateMemberValueTrees(true);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.WhereClauseVisitor whereClauseVisitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.WhereClauseVisitor(this._basicView, memberValueTrees);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.WhereClauseVisitor whereClauseVisitor2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.WhereClauseVisitor(this._basicView, memberValueTrees2);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in this._viewgenContext.AllWrappersForExtent)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell onlyInputCell = leftCellWrapper.OnlyInputCell;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode(this._viewgenContext, leftCellWrapper);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode2 = whereClauseVisitor2.GetCellTreeNode(onlyInputCell.SQuery.WhereClause);
				if (cellTreeNode2 != null)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode3;
					if (cellTreeNode2 != this._basicView)
					{
						cellTreeNode3 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this._viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[]
						{
							cellTreeNode2,
							this._basicView
						});
					}
					else
					{
						cellTreeNode3 = this._basicView;
					}
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression inExtentCondition = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(leftCellWrapper.CreateRoleBoolean(), this._viewgenContext.MemberMaps.QueryDomainMap);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression extraConstraint;
					if (!this.CheckEquivalence(cellTreeNode.RightFragmentQuery, cellTreeNode3.RightFragmentQuery, inExtentCondition, out extraConstraint))
					{
						object p = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
						{
							this._viewgenContext.Extent
						});
						cellTreeNode.RightFragmentQuery.Condition.ExpensiveSimplify();
						cellTreeNode3.RightFragmentQuery.Condition.ExpensiveSimplify();
						string message = global::System.Data.Entity.Resources.Strings.ViewGen_CQ_PartitionConstraint(p);
						this.ReportConstraintViolation(message, extraConstraint, global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.PartitionConstraintViolation, cellTreeNode.GetLeaves().Concat(cellTreeNode3.GetLeaves()));
					}
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode4 = whereClauseVisitor.GetCellTreeNode(onlyInputCell.SQuery.WhereClause);
					if (cellTreeNode4 != null)
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.DomainConstraintVisitor.CheckConstraints(cellTreeNode4, leftCellWrapper, this._viewgenContext, this._errorLog);
						if (this._errorLog.Count > 0)
						{
							continue;
						}
						this.CheckConstraintsOnProjectedConditionMembers(memberValueTrees, leftCellWrapper, cellTreeNode3, inExtentCondition);
						if (this._errorLog.Count > 0)
						{
							continue;
						}
					}
					this.CheckConstraintsOnNonNullableMembers(leftCellWrapper);
				}
			}
			if (this._errorLog.Count > 0)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(this._errorLog, this._viewgenContext.Config);
			}
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x000EC1A8 File Offset: 0x000EA3A8
		private bool CheckEquivalence(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery cQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery sQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression inExtentCondition, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression unsatisfiedConstraint)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = this._viewgenContext.RightFragmentQP.Difference(cQuery, sQuery);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery2 = this._viewgenContext.RightFragmentQP.Difference(sQuery, cQuery);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery3 = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				fragmentQuery.Condition,
				inExtentCondition
			}));
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery4 = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				fragmentQuery2.Condition,
				inExtentCondition
			}));
			unsatisfiedConstraint = null;
			bool flag = true;
			bool flag2 = true;
			if (this._viewgenContext.RightFragmentQP.IsSatisfiable(fragmentQuery3))
			{
				unsatisfiedConstraint = fragmentQuery3.Condition;
				flag = false;
			}
			if (this._viewgenContext.RightFragmentQP.IsSatisfiable(fragmentQuery4))
			{
				unsatisfiedConstraint = fragmentQuery4.Condition;
				flag2 = false;
			}
			if (flag && flag2)
			{
				return true;
			}
			unsatisfiedConstraint.ExpensiveSimplify();
			return false;
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x000EC274 File Offset: 0x000EA474
		private void ReportConstraintViolation(string message, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression extraConstraint, global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode errorCode, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> relevantWrappers)
		{
			if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.FindMappingErrors(this._viewgenContext, this._domainMap, this._errorLog))
			{
				return;
			}
			extraConstraint.ExpensiveSimplify();
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>(relevantWrappers);
			new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>(hashSet).Sort(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper.OriginalCellIdComparer);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine(message);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.EntityConfigurationToUserString(extraConstraint, stringBuilder);
			this._errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(errorCode, stringBuilder.ToString(), hashSet, ""));
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x000EC2EC File Offset: 0x000EA4EC
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> CreateMemberValueTrees(bool complementElse)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in this._domainMap.ConditionMembers(this._viewgenContext.Extent))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(this._domainMap.GetDomain(memberPath));
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this._viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union);
				for (int i = 0; i < list.Count; i++)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant = list[i];
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding key = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding(memberPath, constant);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateMemberConditionQuery(memberPath, constant, this._keyAttributes, this._domainMap);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile;
					if (this._viewgenContext.TryGetCachedRewriting(query, out tile))
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToCellTree(tile, this._viewgenContext);
						dictionary[key] = cellTreeNode;
						if (i < list.Count - 1)
						{
							opCellTreeNode.Add(cellTreeNode);
						}
					}
				}
				if (complementElse && list.Count > 1)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value = list[list.Count - 1];
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding key2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding(memberPath, value);
					dictionary[key2] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this._viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[]
					{
						this._basicView,
						opCellTreeNode
					});
				}
			}
			return dictionary;
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x000EC448 File Offset: 0x000EA648
		private void CheckConstraintsOnProjectedConditionMembers(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> memberValueTrees, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode sQueryTree, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression inExtentCondition)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in this._domainMap.ConditionMembers(this._viewgenContext.Extent))
			{
				int slotNum = this._viewgenContext.MemberMaps.ProjectedSlotMap.IndexOf(memberPath);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = wrapper.RightCellQuery.ProjectedSlotAt(slotNum) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
				if (memberProjectedSlot != null)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in this._domainMap.GetDomain(memberPath))
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode;
						if (memberValueTrees.TryGetValue(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding(memberPath, constant), out cellTreeNode))
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery cQuery = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.PropagateCellConstantsToWhereClause(wrapper, wrapper.RightCellQuery.WhereClause, constant, memberPath, this._viewgenContext.MemberMaps));
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode2 = (sQueryTree == this._basicView) ? cellTreeNode : new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this._viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[]
							{
								cellTreeNode,
								sQueryTree
							});
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression extraConstraint;
							if (!this.CheckEquivalence(cQuery, cellTreeNode2.RightFragmentQuery, inExtentCondition, out extraConstraint))
							{
								string message = global::System.Data.Entity.Resources.Strings.ViewGen_CQ_DomainConstraint(memberProjectedSlot.ToUserString());
								this.ReportConstraintViolation(message, extraConstraint, global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.DomainConstraintViolation, cellTreeNode2.GetLeaves().Concat(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper[]
								{
									wrapper
								}));
							}
						}
					}
				}
			}
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x000EC5E0 File Offset: 0x000EA7E0
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression PropagateCellConstantsToWhereClause(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression expression, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberMaps memberMaps)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot csideMappedSlotForSMember = wrapper.GetCSideMappedSlotForSMember(member);
			if (csideMappedSlotForSMember == null)
			{
				return expression;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negatedConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain = memberMaps.QueryDomainMap.GetDomain(csideMappedSlotForSMember.MemberPath);
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			if (negatedConstant != null)
			{
				set.Unite(domain);
				set.Difference(negatedConstant.Elements);
			}
			else
			{
				set.Add(constant);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction literal = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(csideMappedSlotForSMember.MemberPath, set, domain);
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				expression,
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(literal, memberMaps.QueryDomainMap)
			});
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x000EC670 File Offset: 0x000EA870
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery AddNullConditionOnCSideFragment(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberMaps memberMaps)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot csideMappedSlotForSMember = wrapper.GetCSideMappedSlotForSMember(member);
			if (csideMappedSlotForSMember == null || !csideMappedSlotForSMember.MemberPath.IsNullable)
			{
				return null;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = wrapper.RightCellQuery.WhereClause;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain = memberMaps.QueryDomainMap.GetDomain(csideMappedSlotForSMember.MemberPath);
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			set.Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction literal = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(csideMappedSlotForSMember.MemberPath, set, domain);
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				whereClause,
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(literal, memberMaps.QueryDomainMap)
			}));
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x000EC700 File Offset: 0x000EA900
		private void CheckConstraintsOnNonNullableMembers(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in this._domainMap.NonConditionMembers(this._viewgenContext.Extent))
			{
				bool flag = memberPath.EdmType is global::System.Data.Entity.Core.Metadata.Edm.SimpleType;
				if (!memberPath.IsNullable && flag)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.AddNullConditionOnCSideFragment(wrapper, memberPath, this._viewgenContext.MemberMaps);
					if (fragmentQuery != null && this._viewgenContext.RightFragmentQP.IsSatisfiable(fragmentQuery))
					{
						this._errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.NullableMappingForNonNullableColumn, global::System.Data.Entity.Resources.Strings.Viewgen_NullableMappingForNonNullableColumn(wrapper.LeftExtent.ToString(), memberPath.ToFullString()), wrapper.Cells, ""));
					}
				}
			}
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x000EC7D8 File Offset: 0x000EA9D8
		internal static void EntityConfigurationToUserString(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition, global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.EntityConfigurationToUserString(condition, builder, true);
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x000EC7E2 File Offset: 0x000EA9E2
		internal static void EntityConfigurationToUserString(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition, global::System.Text.StringBuilder builder, bool writeRoundTrippingMessage)
		{
			condition.AsUserString(builder, "PK", writeRoundTrippingMessage);
		}

		// Token: 0x04001884 RID: 6276
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext _viewgenContext;

		// Token: 0x04001885 RID: 6277
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap _domainMap;

		// Token: 0x04001886 RID: 6278
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode _basicView;

		// Token: 0x04001887 RID: 6279
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> _keyAttributes;

		// Token: 0x04001888 RID: 6280
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog _errorLog;

		// Token: 0x02000B85 RID: 2949
		private class WhereClauseVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>
		{
			// Token: 0x0600669C RID: 26268 RVA: 0x0015F23C File Offset: 0x0015D43C
			internal WhereClauseVisitor(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode topLevelTree, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> memberValueTrees)
			{
				this._topLevelTree = topLevelTree;
				this._memberValueTrees = memberValueTrees;
				this._viewgenContext = topLevelTree.ViewgenContext;
			}

			// Token: 0x0600669D RID: 26269 RVA: 0x0015F25E File Offset: 0x0015D45E
			internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode GetCellTreeNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause)
			{
				return whereClause.Tree.Accept<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(this);
			}

			// Token: 0x0600669E RID: 26270 RVA: 0x0015F26C File Offset: 0x0015D46C
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> enumerable = this.AcceptChildren(expression.Children);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this._viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in enumerable)
				{
					if (cellTreeNode == null)
					{
						return null;
					}
					if (cellTreeNode != this._topLevelTree)
					{
						opCellTreeNode.Add(cellTreeNode);
					}
				}
				if (opCellTreeNode.Children.Count != 0)
				{
					return opCellTreeNode;
				}
				return this._topLevelTree;
			}

			// Token: 0x0600669F RID: 26271 RVA: 0x0015F2F4 File Offset: 0x0015D4F4
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this._topLevelTree;
			}

			// Token: 0x060066A0 RID: 26272 RVA: 0x0015F2FC File Offset: 0x0015D4FC
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction)expression.Identifier.Variable.Identifier;
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range = expression.Identifier.Range;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this._viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = null;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value in range)
				{
					if (this.TryGetCellTreeNode(memberRestriction.RestrictedMemberSlot.MemberPath, value, out cellTreeNode))
					{
						opCellTreeNode.Add(cellTreeNode);
					}
				}
				int count = opCellTreeNode.Children.Count;
				if (count == 0)
				{
					return null;
				}
				if (count != 1)
				{
					return opCellTreeNode;
				}
				return cellTreeNode;
			}

			// Token: 0x060066A1 RID: 26273 RVA: 0x0015F3B0 File Offset: 0x0015D5B0
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060066A2 RID: 26274 RVA: 0x0015F3B7 File Offset: 0x0015D5B7
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060066A3 RID: 26275 RVA: 0x0015F3BE File Offset: 0x0015D5BE
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060066A4 RID: 26276 RVA: 0x0015F3C5 File Offset: 0x0015D5C5
			private bool TryGetCellTreeNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode singleNode)
			{
				return this._memberValueTrees.TryGetValue(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding(memberPath, value), out singleNode);
			}

			// Token: 0x060066A5 RID: 26277 RVA: 0x0015F3DA File Offset: 0x0015D5DA
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> AcceptChildren(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> children)
			{
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr in children)
				{
					yield return boolExpr.Accept<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(this);
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x04002E06 RID: 11782
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext _viewgenContext;

			// Token: 0x04002E07 RID: 11783
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode _topLevelTree;

			// Token: 0x04002E08 RID: 11784
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> _memberValueTrees;
		}

		// Token: 0x02000B86 RID: 2950
		internal class DomainConstraintVisitor : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.SimpleCellTreeVisitor<bool, bool>
		{
			// Token: 0x060066A6 RID: 26278 RVA: 0x0015F3F1 File Offset: 0x0015D5F1
			private DomainConstraintVisitor(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
			{
				this.m_wrapper = wrapper;
				this.m_viewgenContext = context;
				this.m_errorLog = errorLog;
			}

			// Token: 0x060066A7 RID: 26279 RVA: 0x0015F410 File Offset: 0x0015D610
			internal static void CheckConstraints(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode node, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.DomainConstraintVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.DomainConstraintVisitor(wrapper, context, errorLog);
				node.Accept<bool, bool>(visitor, true);
			}

			// Token: 0x060066A8 RID: 26280 RVA: 0x0015F430 File Offset: 0x0015D630
			internal override bool VisitLeaf(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode node, bool dummy)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightCellQuery = this.m_wrapper.RightCellQuery;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightCellQuery2 = node.LeftCellWrapper.RightCellQuery;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
				if (rightCellQuery != rightCellQuery2)
				{
					for (int i = 0; i < rightCellQuery.NumProjectedSlots; i++)
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = rightCellQuery.ProjectedSlotAt(i) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
						if (memberProjectedSlot != null)
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot2 = rightCellQuery2.ProjectedSlotAt(i) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
							if (memberProjectedSlot2 != null)
							{
								global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = this.m_viewgenContext.MemberMaps.ProjectedSlotMap[i];
								if (!memberPath.IsPartOfKey && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(memberProjectedSlot.MemberPath, memberProjectedSlot2.MemberPath))
								{
									list.Add(memberPath);
								}
							}
						}
					}
				}
				if (list.Count > 0)
				{
					string message = global::System.Data.Entity.Resources.Strings.ViewGen_NonKeyProjectedWithOverlappingPartitions(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(list, false));
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.NonKeyProjectedWithOverlappingPartitions, message, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper[]
					{
						this.m_wrapper,
						node.LeftCellWrapper
					}, string.Empty);
					this.m_errorLog.AddEntry(record);
				}
				return true;
			}

			// Token: 0x060066A9 RID: 26281 RVA: 0x0015F528 File Offset: 0x0015D728
			internal override bool VisitOpNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, bool dummy)
			{
				if (node.OpType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ)
				{
					node.Children[0].Accept<bool, bool>(this, dummy);
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in node.Children)
					{
						cellTreeNode.Accept<bool, bool>(this, dummy);
					}
				}
				return true;
			}

			// Token: 0x04002E09 RID: 11785
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper m_wrapper;

			// Token: 0x04002E0A RID: 11786
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext m_viewgenContext;

			// Token: 0x04002E0B RID: 11787
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog m_errorLog;
		}

		// Token: 0x02000B87 RID: 2951
		private struct MemberValueBinding : global::System.IEquatable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding>
		{
			// Token: 0x060066AA RID: 26282 RVA: 0x0015F59C File Offset: 0x0015D79C
			public MemberValueBinding(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value)
			{
				this.Member = member;
				this.Value = value;
			}

			// Token: 0x060066AB RID: 26283 RVA: 0x0015F5AC File Offset: 0x0015D7AC
			public override string ToString()
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}={1}", new object[]
				{
					this.Member,
					this.Value
				});
			}

			// Token: 0x060066AC RID: 26284 RVA: 0x0015F5D5 File Offset: 0x0015D7D5
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.MemberValueBinding other)
			{
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(this.Member, other.Member) && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer.Equals(this.Value, other.Value);
			}

			// Token: 0x04002E0C RID: 11788
			internal readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath Member;

			// Token: 0x04002E0D RID: 11789
			internal readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant Value;
		}
	}
}
