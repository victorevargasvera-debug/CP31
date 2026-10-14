using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x0200058A RID: 1418
	internal class QueryRewriter
	{
		// Token: 0x06004495 RID: 17557 RVA: 0x000F098C File Offset: 0x000EEB8C
		internal QueryRewriter(global::System.Data.Entity.Core.Metadata.Edm.EdmType generatedType, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode typesGenerationMode)
		{
			this._typesGenerationMode = typesGenerationMode;
			this._context = context;
			this._generatedType = generatedType;
			this._domainMap = context.MemberMaps.LeftDomainMap;
			this._config = context.Config;
			this._identifiers = context.CqlIdentifiers;
			this._qp = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>>(new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.DefaultTileProcessor<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>(context.LeftFragmentQP));
			this._extentPath = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(context.Extent);
			this._keyAttributes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.GetKeyMembers(context.Extent, this._domainMap));
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in this._context.AllWrappersForExtent)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = leftCellWrapper.FragmentQuery;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> item = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(fragmentQuery);
				this._fragmentQueries.Add(fragmentQuery);
				this._views.Add(item);
			}
			this.AdjustMemberDomainsForUpdateViews();
			this._domainQuery = this.GetDomainQuery(this.FragmentQueries, generatedType);
			this._usedViews = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>();
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x000F0AF0 File Offset: 0x000EECF0
		internal void GenerateViewComponents()
		{
			this.EnsureExtentIsFullyMapped(this._usedViews);
			this.GenerateCaseStatements(this._domainMap.ConditionMembers(this._extentPath.Extent), this._usedViews);
			this.AddTrivialCaseStatementsForConditionMembers();
			if (this._usedViews.Count == 0 || this._errorLog.Count > 0)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(this._errorLog, this._config);
			}
			this._topLevelWhereClause = this.GetTopLevelWhereClause(this._usedViews);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget = this._context.ViewTarget;
			this._usedCells = this.RemapFromVariables();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.BasicViewGenerator basicViewGenerator = new global::System.Data.Entity.Core.Mapping.ViewGeneration.BasicViewGenerator(this._context.MemberMaps.ProjectedSlotMap, this._usedCells, this._domainQuery, this._context, this._domainMap, this._errorLog, this._config);
			this._basicView = basicViewGenerator.CreateViewExpression();
			if (this._context.LeftFragmentQP.IsContainedIn(this._basicView.LeftFragmentQuery, this._domainQuery))
			{
				this._topLevelWhereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			}
			if (this._errorLog.Count > 0)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(this._errorLog, this._config);
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x000F0C1A File Offset: 0x000EEE1A
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext ViewgenContext
		{
			get
			{
				return this._context;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06004498 RID: 17560 RVA: 0x000F0C22 File Offset: 0x000EEE22
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement> CaseStatements
		{
			get
			{
				return this._caseStatements;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x000F0C2A File Offset: 0x000EEE2A
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression TopLevelWhereClause
		{
			get
			{
				return this._topLevelWhereClause;
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x000F0C32 File Offset: 0x000EEE32
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode BasicView
		{
			get
			{
				return this._basicView.MakeCopy();
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x000F0C3F File Offset: 0x000EEE3F
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> UsedCells
		{
			get
			{
				return this._usedCells;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x000F0C47 File Offset: 0x000EEE47
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> FragmentQueries
		{
			get
			{
				return this._fragmentQueries;
			}
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x000F0C50 File Offset: 0x000EEE50
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> GetDomain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath)
		{
			if (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(currentPath, this._extentPath))
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> types;
				if (this._typesGenerationMode == global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode.OfTypeOnlyViews)
				{
					types = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmType>
					{
						this._generatedType
					};
				}
				else
				{
					types = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(this._generatedType, this._context.EdmItemCollection, false);
				}
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetTypeConstants(types);
			}
			return this._domainMap.GetDomain(currentPath);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x000F0CC8 File Offset: 0x000EEEC8
		private void AdjustMemberDomainsForUpdateViews()
		{
			if (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView)
			{
				using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>.Enumerator enumerator = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(this._domainMap.ConditionMembers(this._extentPath.Extent)).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath = enumerator.Current;
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant = this._domainMap.GetDomain(currentPath).FirstOrDefault((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue) => global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.IsDefaultValue(domainValue, currentPath));
						if (constant != null)
						{
							this.RemoveUnusedValueFromStoreDomain(constant, currentPath);
						}
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant2 = this._domainMap.GetDomain(currentPath).FirstOrDefault((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue) => domainValue is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant);
						if (constant2 != null)
						{
							this.RemoveUnusedValueFromStoreDomain(constant2, currentPath);
						}
					}
				}
			}
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x000F0DC4 File Offset: 0x000EEFC4
		private void RemoveUnusedValueFromStoreDomain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = this.CreateMemberCondition(currentPath, domainValue);
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> outputUsedViews = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>();
			bool flag = false;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile;
			if (this.FindRewritingAndUsedViews(this._keyAttributes, whereClause, outputUsedViews, out tile))
			{
				flag = !global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToCellTree(tile, this._context).IsEmptyRightFragmentQuery;
			}
			if (!flag)
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(this._domainMap.GetDomain(currentPath), global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
				set.Remove(domainValue);
				this._domainMap.UpdateConditionMemberDomain(currentPath, set);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery in this._fragmentQueries)
				{
					fragmentQuery.Condition.FixDomainMap(this._domainMap);
				}
			}
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x000F0E8C File Offset: 0x000EF08C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery GetDomainQuery(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> fragmentQueries, global::System.Data.Entity.Core.Metadata.Edm.EdmType generatedType)
		{
			if (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause;
				if (generatedType == null)
				{
					whereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
				}
				else
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> types;
					if (this._typesGenerationMode == global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode.OfTypeOnlyViews)
					{
						types = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmType>
						{
							this._generatedType
						};
					}
					else
					{
						types = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(generatedType, this._context.EdmItemCollection, false);
					}
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetTypeConstants(types), this._domainMap.GetDomain(this._extentPath));
					whereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(this._extentPath), domain), this._domainMap);
				}
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(this._keyAttributes, whereClause);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateOr((from fragmentQuery in fragmentQueries
			select fragmentQuery.Condition).ToArray<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>());
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(this._keyAttributes, whereClause2);
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x000F0F6C File Offset: 0x000EF16C
		private bool AddRewritingToCaseStatement(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			bool flag = this._qp.IsContainedIn(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(this._domainQuery), rewriting);
			if (this._qp.IsDisjointFrom(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(this._domainQuery), rewriting))
			{
				return false;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot value;
			if (domainValue.HasNotNull())
			{
				value = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(currentPath);
			}
			else
			{
				value = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(domainValue);
			}
			if (!flag)
			{
				condition = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToBoolExpr(rewriting);
			}
			else
			{
				condition = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			}
			caseStatement.AddWhenThen(condition, value);
			return flag;
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x000F0FEC File Offset: 0x000EF1EC
		private void EnsureConfigurationIsFullyMapped(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression currentWhereClause, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> outputUsedViews, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in this.GetDomain(currentPath))
			{
				if (constant != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = this.CreateMemberCondition(currentPath, constant);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						currentWhereClause,
						boolExpression
					});
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile;
					if (!this.FindRewritingAndUsedViews(this._keyAttributes, boolExpression2, outputUsedViews, out tile))
					{
						if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.FindMappingErrors(this._context, this._domainMap, this._errorLog))
						{
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							string p = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
							{
								this._extentPath
							});
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition = tile.Query.Condition;
							condition.ExpensiveSimplify();
							if (condition.RepresentsAllTypeConditions)
							{
								string viewGen_Extent = global::System.Data.Entity.Resources.Strings.ViewGen_Extent;
								stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ViewGen_Cannot_Recover_Types(viewGen_Extent, p));
							}
							else
							{
								string viewGen_Entities = global::System.Data.Entity.Resources.Strings.ViewGen_Entities;
								stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ViewGen_Cannot_Disambiguate_MultiConstant(viewGen_Entities, p));
							}
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.EntityConfigurationToUserString(condition, stringBuilder);
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.AmbiguousMultiConstants, stringBuilder.ToString(), this._context.AllWrappersForExtent, string.Empty);
							errorLog.AddEntry(record);
						}
					}
					else
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant typeConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant;
						if (typeConstant != null)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = typeConstant.EdmType;
							global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetNonConditionalScalarMembers(edmType, currentPath, this._domainMap).Union(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetNonConditionalComplexMembers(edmType, currentPath, this._domainMap)).ToList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attributes;
							if (list.Count > 0 && !this.FindRewritingAndUsedViews(list, boolExpression2, outputUsedViews, out tile, out attributes))
							{
								list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(from a in list
								where !a.IsPartOfKey
								select a);
								this.AddUnrecoverableAttributesError(attributes, boolExpression, errorLog);
							}
							else
							{
								foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath2 in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetConditionalComplexMembers(edmType, currentPath, this._domainMap))
								{
									this.EnsureConfigurationIsFullyMapped(currentPath2, boolExpression2, outputUsedViews, errorLog);
								}
								foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath3 in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetConditionalScalarMembers(edmType, currentPath, this._domainMap))
								{
									this.EnsureConfigurationIsFullyMapped(currentPath3, boolExpression2, outputUsedViews, errorLog);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x000F1294 File Offset: 0x000EF494
		private static global::System.Collections.Generic.List<string> GetTypeBasedMemberPathList(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> nonConditionalScalarAttributes)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in nonConditionalScalarAttributes)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember leafEdmMember = memberPath.LeafEdmMember;
				global::System.Collections.Generic.List<string> list2 = list;
				string name = leafEdmMember.DeclaringType.Name;
				string str = ".";
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = leafEdmMember;
				list2.Add(name + str + ((edmMember != null) ? edmMember.ToString() : null));
			}
			return list;
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x000F130C File Offset: 0x000EF50C
		private void AddUnrecoverableAttributesError(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression domainAddedWhereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string p = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
			{
				this._extentPath
			});
			string viewGen_Extent = global::System.Data.Entity.Resources.Strings.ViewGen_Extent;
			string p2 = global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetTypeBasedMemberPathList(attributes));
			stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ViewGen_Cannot_Recover_Attributes(p2, viewGen_Extent, p));
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.EntityConfigurationToUserString(domainAddedWhereClause, stringBuilder);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.AttributesUnrecoverable, stringBuilder.ToString(), this._context.AllWrappersForExtent, string.Empty);
			errorLog.AddEntry(record);
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x000F138C File Offset: 0x000EF58C
		private void GenerateCaseStatements(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> members, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> outputUsedViews)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> source = from w in this._context.AllWrappersForExtent
			where this._usedViews.Contains(w.FragmentQuery)
			select w;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context = this._context;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[] children = (from wrapper in source
			select new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode(this._context, wrapper)).ToArray<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rightDomainQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(context, opType, children);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in members)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> list = this.GetDomain(memberPath).ToList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement(memberPath);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile = null;
				bool flag = list.Count != 2 || !list.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer) || !list.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in list)
				{
					if (constant == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined && this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
					{
						caseStatement.AddWhenThen(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.False, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined));
					}
					else
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = this.CreateMemberConditionQuery(memberPath, constant);
						global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile2;
						if (this.FindRewritingAndUsedViews(fragmentQuery.Attributes, fragmentQuery.Condition, outputUsedViews, out tile2))
						{
							if (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView)
							{
								tile = ((tile != null) ? this._qp.Union(tile, tile2) : tile2);
							}
							if (flag && this.AddRewritingToCaseStatement(tile2, caseStatement, memberPath, constant))
							{
								break;
							}
						}
						else if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.IsDefaultValue(constant, memberPath) && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.FindMappingErrors(this._context, this._domainMap, this._errorLog))
						{
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							string text = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
							{
								this._extentPath
							});
							string p = (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView) ? global::System.Data.Entity.Resources.Strings.ViewGen_Entities : global::System.Data.Entity.Resources.Strings.ViewGen_Tuples;
							if (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
							{
								stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.Viewgen_CannotGenerateQueryViewUnderNoValidation(text));
							}
							else
							{
								stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ViewGen_Cannot_Disambiguate_MultiConstant(p, text));
							}
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.EntityConfigurationToUserString(fragmentQuery.Condition, stringBuilder, this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView);
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.AmbiguousMultiConstants, stringBuilder.ToString(), this._context.AllWrappersForExtent, string.Empty);
							this._errorLog.AddEntry(record);
						}
					}
				}
				if (this._errorLog.Count == 0)
				{
					if (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView && flag)
					{
						this.AddElseDefaultToCaseStatement(memberPath, caseStatement, list, rightDomainQuery, tile);
					}
					if (caseStatement.Clauses.Count > 0)
					{
						this._caseStatements[memberPath] = caseStatement;
					}
				}
			}
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x000F168C File Offset: 0x000EF88C
		private void AddElseDefaultToCaseStatement(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rightDomainQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> unionCaseRewriting)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant;
			bool flag = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.TryGetDefaultValueForMemberPath(currentPath, out constant);
			if (!flag || !domain.Contains(constant))
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToCellTree(unionCaseRewriting, this._context);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = this._context.RightFragmentQP.Difference(rightDomainQuery.RightFragmentQuery, cellTreeNode.RightFragmentQuery);
				if (this._context.RightFragmentQP.IsSatisfiable(fragmentQuery))
				{
					if (flag)
					{
						caseStatement.AddWhenThen(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(constant));
						return;
					}
					fragmentQuery.Condition.ExpensiveSimplify();
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ViewGen_No_Default_Value_For_Configuration(currentPath.PathToString(new bool?(false))));
					this._errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.NoDefaultValue, stringBuilder.ToString(), this._context.AllWrappersForExtent, string.Empty));
				}
			}
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x000F175C File Offset: 0x000EF95C
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression GetTopLevelWhereClause(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> outputUsedViews)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile;
			if (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView && !this._domainQuery.Condition.IsTrue && this.FindRewritingAndUsedViews(this._keyAttributes, this._domainQuery.Condition, outputUsedViews, out tile))
			{
				boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToBoolExpr(tile);
				boolExpression.ExpensiveSimplify();
			}
			return boolExpression;
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x000F17B8 File Offset: 0x000EF9B8
		internal void EnsureExtentIsFullyMapped(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> outputUsedViews)
		{
			if (this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView && this._config.IsValidationEnabled)
			{
				this.EnsureConfigurationIsFullyMapped(this._extentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True, outputUsedViews, this._errorLog);
				if (this._errorLog.Count > 0)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(this._errorLog, this._config);
					return;
				}
			}
			else
			{
				if (this._config.IsValidationEnabled)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in this._context.MemberMaps.ProjectedSlotMap.Members)
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant;
						if (memberPath.IsScalarType() && !memberPath.IsPartOfKey && !this._domainMap.IsConditionMember(memberPath) && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.TryGetDefaultValueForMemberPath(memberPath, out constant))
						{
							global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(this._keyAttributes);
							hashSet.Add(memberPath);
							foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in this._context.AllWrappersForExtent)
							{
								global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = leftCellWrapper.FragmentQuery;
								global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery(fragmentQuery.Description, fragmentQuery.FromVariable, hashSet, fragmentQuery.Condition);
								global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toAvoid = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(this._keyAttributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(fragmentQuery.Condition)));
								global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile;
								global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> enumerable;
								if (!this.RewriteQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(query), toAvoid, out tile, out enumerable, false))
								{
									global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.GetDefaultValueForMemberPath(memberPath, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper[]
									{
										leftCellWrapper
									}, this._config);
								}
							}
						}
					}
				}
				using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>>.Enumerator enumerator3 = this._views.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toFill = enumerator3.Current;
						global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toAvoid2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(this._keyAttributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(toFill.Query.Condition)));
						global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile2;
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> enumerable2;
						if (!this.RewriteQuery(toFill, toAvoid2, out tile2, out enumerable2, true))
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper2 = this._context.AllWrappersForExtent.First((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper lcr) => lcr.FragmentQuery.Equals(toFill.Query));
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ImpossibleCondition, global::System.Data.Entity.Resources.Strings.Viewgen_QV_RewritingNotFound(leftCellWrapper2.RightExtent.ToString()), leftCellWrapper2.Cells, string.Empty);
							this._errorLog.AddEntry(record);
						}
						else
						{
							outputUsedViews.UnionWith(tile2.GetNamedQueries());
						}
					}
				}
			}
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x000F1A8C File Offset: 0x000EFC8C
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> RemapFromVariables()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>();
			int num = 0;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral.EqualityIdentifierComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in this._context.AllWrappersForExtent)
			{
				if (this._usedViews.Contains(leftCellWrapper.FragmentQuery))
				{
					list.Add(leftCellWrapper);
					int cellNumber = leftCellWrapper.OnlyInputCell.CellNumber;
					if (num != cellNumber)
					{
						dictionary[new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellIdBoolean(this._identifiers, cellNumber)] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellIdBoolean(this._identifiers, num);
					}
					num++;
				}
			}
			if (dictionary.Count > 0)
			{
				this._topLevelWhereClause = this._topLevelWhereClause.RemapLiterals(dictionary);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement> dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement>();
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement> keyValuePair in this._caseStatements)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement(keyValuePair.Key);
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen whenThen in keyValuePair.Value.Clauses)
					{
						caseStatement.AddWhenThen(whenThen.Condition.RemapLiterals(dictionary), whenThen.Value);
					}
					dictionary2[keyValuePair.Key] = caseStatement;
				}
				this._caseStatements = dictionary2;
			}
			return list;
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x000F1C30 File Offset: 0x000EFE30
		internal void AddTrivialCaseStatementsForConditionMembers()
		{
			for (int i = 0; i < this._context.MemberMaps.ProjectedSlotMap.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = this._context.MemberMaps.ProjectedSlotMap[i];
				if (!memberPath.IsScalarType() && !this._caseStatements.ContainsKey(memberPath))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant(memberPath.EdmType);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement(memberPath);
					caseStatement.AddWhenThen(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(value));
					this._caseStatements[memberPath] = caseStatement;
				}
			}
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x000F1CBC File Offset: 0x000EFEBC
		private bool FindRewritingAndUsedViews(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> outputUsedViews, out global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> enumerable;
			return this.FindRewritingAndUsedViews(attributes, whereClause, outputUsedViews, out rewriting, out enumerable);
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x000F1CD6 File Offset: 0x000EFED6
		private bool FindRewritingAndUsedViews(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> outputUsedViews, out global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting, out global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> notCoveredAttributes)
		{
			if (this.FindRewriting(attributes, whereClause, out rewriting, out notCoveredAttributes))
			{
				outputUsedViews.UnionWith(rewriting.GetNamedQueries());
				return true;
			}
			return false;
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x000F1CF8 File Offset: 0x000EFEF8
		private bool FindRewriting(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause, out global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting, out global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> notCoveredAttributes)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toFill = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(attributes, whereClause));
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toAvoid = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(this._keyAttributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(whereClause)));
			bool isRelaxed = this._context.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView;
			return this.RewriteQuery(toFill, toAvoid, out rewriting, out notCoveredAttributes, isRelaxed);
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x000F1D44 File Offset: 0x000EFF44
		private bool RewriteQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toFill, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toAvoid, out global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting, out global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> notCoveredAttributes, bool isRelaxed)
		{
			notCoveredAttributes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = toFill.Query;
			if (this._context.TryGetCachedRewriting(fragmentQuery, out rewriting))
			{
				return true;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>> relevantViews = this.GetRelevantViews(fragmentQuery);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query = fragmentQuery;
			if (!this.RewriteQueryCached(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(fragmentQuery.Condition)), toAvoid, relevantViews, out rewriting))
			{
				if (!isRelaxed)
				{
					return false;
				}
				fragmentQuery = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(fragmentQuery.Attributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAndNot(fragmentQuery.Condition, rewriting.Query.Condition));
				if (this._qp.IsEmpty(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(fragmentQuery)) || !this.RewriteQueryCached(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(fragmentQuery.Condition)), toAvoid, relevantViews, out rewriting))
				{
					return false;
				}
			}
			if (fragmentQuery.Attributes.Count == 0)
			{
				return true;
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath key in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.NonKeys(fragmentQuery.Attributes))
			{
				dictionary[key] = fragmentQuery;
			}
			if (dictionary.Count == 0 || this.CoverAttributes(ref rewriting, dictionary))
			{
				this.GetUsedViewsAndRemoveTrueSurrogate(ref rewriting);
				this._context.SetCachedRewriting(query, rewriting);
				return true;
			}
			if (isRelaxed)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath key2 in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.NonKeys(fragmentQuery.Attributes))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery2;
					if (dictionary.TryGetValue(key2, out fragmentQuery2))
					{
						dictionary[key2] = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAndNot(fragmentQuery.Condition, fragmentQuery2.Condition));
					}
					else
					{
						dictionary[key2] = fragmentQuery;
					}
				}
				if (this.CoverAttributes(ref rewriting, dictionary))
				{
					this.GetUsedViewsAndRemoveTrueSurrogate(ref rewriting);
					this._context.SetCachedRewriting(query, rewriting);
					return true;
				}
			}
			notCoveredAttributes = dictionary.Keys;
			return false;
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x000F1F24 File Offset: 0x000F0124
		private bool RewriteQueryCached(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toFill, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> toAvoid, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>> views, out global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting)
		{
			if (!this._context.TryGetCachedRewriting(toFill.Query, out rewriting))
			{
				bool flag = this._qp.RewriteQuery(toFill, toAvoid, views, out rewriting);
				if (flag)
				{
					this._context.SetCachedRewriting(toFill.Query, rewriting);
				}
				return flag;
			}
			return true;
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x000F1F64 File Offset: 0x000F0164
		private bool CoverAttributes(ref global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> attributeConditions)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery in new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>(rewriting.GetNamedQueries()))
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath projectedAttribute in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.NonKeys(fragmentQuery.Attributes))
				{
					this.CoverAttribute(projectedAttribute, fragmentQuery, attributeConditions);
				}
				if (attributeConditions.Count == 0)
				{
					return true;
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile = null;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery2 in this._fragmentQueries)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath projectedAttribute2 in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.NonKeys(fragmentQuery2.Attributes))
				{
					if (this.CoverAttribute(projectedAttribute2, fragmentQuery2, attributeConditions))
					{
						tile = ((tile == null) ? global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(fragmentQuery2) : this._qp.Union(tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(fragmentQuery2)));
					}
				}
				if (attributeConditions.Count == 0)
				{
					break;
				}
			}
			if (attributeConditions.Count == 0)
			{
				rewriting = this._qp.Join(rewriting, tile);
				return true;
			}
			return false;
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x000F20DC File Offset: 0x000F02DC
		private bool CoverAttribute(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath projectedAttribute, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery view, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> attributeConditions)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery;
			if (attributeConditions.TryGetValue(projectedAttribute, out fragmentQuery))
			{
				fragmentQuery = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAndNot(fragmentQuery.Condition, view.Condition));
				if (this._qp.IsEmpty(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(fragmentQuery)))
				{
					attributeConditions.Remove(projectedAttribute);
				}
				else
				{
					attributeConditions[projectedAttribute] = fragmentQuery;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x000F2134 File Offset: 0x000F0334
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>> GetRelevantViews(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> variables = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetVariables(query);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile2 = null;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile3 in this._views)
			{
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.GetVariables(tile3.Query).Overlaps(variables))
				{
					tile = ((tile == null) ? tile3 : this._qp.Union(tile, tile3));
					list.Add(tile3);
				}
				else if (this.IsTrue(tile3.Query) && tile2 == null)
				{
					tile2 = tile3;
				}
			}
			if (tile != null && this.IsTrue(tile.Query))
			{
				return list;
			}
			if (tile2 == null)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile4 = null;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query2 in this._fragmentQueries)
				{
					tile4 = ((tile4 == null) ? global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(query2) : this._qp.Union(tile4, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(query2)));
					if (this.IsTrue(tile4.Query))
					{
						tile2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter._trueViewSurrogate;
						break;
					}
				}
			}
			if (tile2 != null)
			{
				list.Add(tile2);
				return list;
			}
			return this._views;
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x000F2280 File Offset: 0x000F0480
		private global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> GetUsedViewsAndRemoveTrueSurrogate(ref global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> rewriting)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>(rewriting.GetNamedQueries());
			if (!hashSet.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter._trueViewSurrogate.Query))
			{
				return hashSet;
			}
			hashSet.Remove(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter._trueViewSurrogate.Query);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile = null;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery in hashSet.Concat(this._fragmentQueries))
			{
				tile = ((tile == null) ? global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(fragmentQuery) : this._qp.Union(tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(fragmentQuery)));
				hashSet.Add(fragmentQuery);
				if (this.IsTrue(tile.Query))
				{
					rewriting = rewriting.Replace(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter._trueViewSurrogate, tile);
					return hashSet;
				}
			}
			return hashSet;
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x000F234C File Offset: 0x000F054C
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression CreateMemberCondition(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.CreateMemberCondition(path, domainValue, this._domainMap);
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x000F235B File Offset: 0x000F055B
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery CreateMemberConditionQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateMemberConditionQuery(currentPath, domainValue, this._keyAttributes, this._domainMap);
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x000F2370 File Offset: 0x000F0570
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery CreateMemberConditionQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> keyAttributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.CreateMemberCondition(currentPath, domainValue, domainMap);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attrs = keyAttributes;
			if (domainValue is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant)
			{
				attrs = keyAttributes.Concat(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath[]
				{
					currentPath
				});
			}
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(attrs, whereClause);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x000F23A8 File Offset: 0x000F05A8
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileNamed<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> CreateTile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileNamed<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>(query);
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x000F23B0 File Offset: 0x000F05B0
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> GetTypeConstants(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> types)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType type in types)
			{
				yield return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant(type);
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmType> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x000F23C0 File Offset: 0x000F05C0
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetNonConditionalScalarMembers(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			return currentPath.GetMembers(edmType, new bool?(true), new bool?(false), null, domainMap);
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x000F23EC File Offset: 0x000F05EC
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetConditionalComplexMembers(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			return currentPath.GetMembers(edmType, new bool?(false), new bool?(true), null, domainMap);
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x000F2418 File Offset: 0x000F0618
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetNonConditionalComplexMembers(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			return currentPath.GetMembers(edmType, new bool?(false), new bool?(false), null, domainMap);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x000F2444 File Offset: 0x000F0644
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetConditionalScalarMembers(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			return currentPath.GetMembers(edmType, new bool?(true), new bool?(true), null, domainMap);
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x000F246E File Offset: 0x000F066E
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> NonKeys(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attributes)
		{
			return from attr in attributes
			where !attr.IsPartOfKey
			select attr;
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x000F2498 File Offset: 0x000F0698
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode TileToCellTree(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context)
		{
			if (tile.OpKind == global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Named)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery view = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileNamed<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>)tile).NamedQuery;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper cellWrapper = context.AllWrappersForExtent.First((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper w) => w.FragmentQuery == view);
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode(context, cellWrapper);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType;
			switch (tile.OpKind)
			{
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Union:
				opType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union;
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join:
				opType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ;
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.AntiSemiJoin:
				opType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ;
				break;
			default:
				return null;
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(context, opType, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[]
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToCellTree(tile.Arg1, context),
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToCellTree(tile.Arg2, context)
			});
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x000F253C File Offset: 0x000F073C
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression TileToBoolExpr(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> tile)
		{
			switch (tile.OpKind)
			{
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Union:
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateOr(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToBoolExpr(tile.Arg1),
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToBoolExpr(tile.Arg2)
				});
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join:
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToBoolExpr(tile.Arg1),
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToBoolExpr(tile.Arg2)
				});
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.AntiSemiJoin:
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToBoolExpr(tile.Arg1),
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.TileToBoolExpr(tile.Arg2))
				});
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Named:
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery namedQuery = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileNamed<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>)tile).NamedQuery;
				if (namedQuery.Condition.IsAlwaysTrue())
				{
					return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
				}
				return namedQuery.FromVariable;
			}
			default:
				return null;
			}
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x000F260F File Offset: 0x000F080F
		private static bool IsDefaultValue(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path)
		{
			return (domainValue.IsNull() && path.IsNullable) || (path.DefaultValue != null && (domainValue as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant).Value == path.DefaultValue);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x000F2640 File Offset: 0x000F0840
		private static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetVariables(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query)
		{
			return new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(from domainConstraint in query.Condition.VariableConstraints
			where domainConstraint.Variable.Identifier is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction && !domainConstraint.Variable.Domain.All((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant) => domainConstraint.Range.Contains(constant))
			select ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction)domainConstraint.Variable.Identifier).RestrictedMemberSlot.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x000F26AA File Offset: 0x000F08AA
		private bool IsTrue(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query)
		{
			return !this._context.LeftFragmentQP.IsSatisfiable(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(query.Condition)));
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x000F26D0 File Offset: 0x000F08D0
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void PrintStatistics(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>> qp)
		{
			int num;
			int num2;
			int num3;
			int num4;
			int num5;
			qp.GetStatistics(out num, out num2, out num3, out num4, out num5);
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x000F26ED File Offset: 0x000F08ED
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal void TraceVerbose(string msg, params object[] parameters)
		{
			if (this._config.IsVerboseTracing)
			{
				global::System.Data.Entity.Core.Common.Utils.Helpers.FormatTraceLine(msg, parameters);
			}
		}

		// Token: 0x040018AB RID: 6315
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath _extentPath;

		// Token: 0x040018AC RID: 6316
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap _domainMap;

		// Token: 0x040018AD RID: 6317
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator _config;

		// Token: 0x040018AE RID: 6318
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers _identifiers;

		// Token: 0x040018AF RID: 6319
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext _context;

		// Token: 0x040018B0 RID: 6320
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>> _qp;

		// Token: 0x040018B1 RID: 6321
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> _keyAttributes;

		// Token: 0x040018B2 RID: 6322
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> _fragmentQueries = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>();

		// Token: 0x040018B3 RID: 6323
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>> _views = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>>();

		// Token: 0x040018B4 RID: 6324
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery _domainQuery;

		// Token: 0x040018B5 RID: 6325
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType _generatedType;

		// Token: 0x040018B6 RID: 6326
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> _usedViews = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>();

		// Token: 0x040018B7 RID: 6327
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> _usedCells = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>();

		// Token: 0x040018B8 RID: 6328
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression _topLevelWhereClause;

		// Token: 0x040018B9 RID: 6329
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode _basicView;

		// Token: 0x040018BA RID: 6330
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement> _caseStatements = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement>();

		// Token: 0x040018BB RID: 6331
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog _errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();

		// Token: 0x040018BC RID: 6332
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode _typesGenerationMode;

		// Token: 0x040018BD RID: 6333
		private static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> _trueViewSurrogate = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter.CreateTile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True));
	}
}
