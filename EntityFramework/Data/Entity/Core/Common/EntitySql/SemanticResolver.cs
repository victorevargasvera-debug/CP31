using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.EntitySql.AST;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200066B RID: 1643
	internal sealed class SemanticResolver
	{
		// Token: 0x06004EB5 RID: 20149 RVA: 0x0011DADA File Offset: 0x0011BCDA
		internal static global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver Create(global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> parameters, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables)
		{
			return new global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver(parserOptions, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.ProcessParameters(parameters, parserOptions), global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.ProcessVariables(variables, parserOptions), new global::System.Data.Entity.Core.Common.EntitySql.TypeResolver(perspective, parserOptions));
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x0011DAF7 File Offset: 0x0011BCF7
		internal global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver CloneForInlineFunctionConversion()
		{
			return new global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver(this._parserOptions, this._parameters, this._variables, this._typeResolver);
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x0011DB18 File Offset: 0x0011BD18
		private SemanticResolver(global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> parameters, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables, global::System.Data.Entity.Core.Common.EntitySql.TypeResolver typeResolver)
		{
			this._parserOptions = parserOptions;
			this._parameters = parameters;
			this._variables = variables;
			this._typeResolver = typeResolver;
			this._scopeManager = new global::System.Data.Entity.Core.Common.EntitySql.ScopeManager(this.NameComparer);
			this.EnterScopeRegion();
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression in this._variables.Values)
			{
				this.CurrentScope.Add(dbVariableReferenceExpression.VariableName, new global::System.Data.Entity.Core.Common.EntitySql.FreeVariableScopeEntry(dbVariableReferenceExpression));
			}
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x0011DBC8 File Offset: 0x0011BDC8
		private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> ProcessParameters(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> paramDefs, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(parserOptions.NameComparer);
			if (paramDefs != null)
			{
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression dbParameterReferenceExpression in paramDefs)
				{
					if (dictionary.ContainsKey(dbParameterReferenceExpression.ParameterName))
					{
						throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.MultipleDefinitionsOfParameter(dbParameterReferenceExpression.ParameterName));
					}
					dictionary.Add(dbParameterReferenceExpression.ParameterName, dbParameterReferenceExpression);
				}
			}
			return dictionary;
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x0011DC48 File Offset: 0x0011BE48
		private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> ProcessVariables(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> varDefs, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(parserOptions.NameComparer);
			if (varDefs != null)
			{
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression in varDefs)
				{
					if (dictionary.ContainsKey(dbVariableReferenceExpression.VariableName))
					{
						throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.MultipleDefinitionsOfVariable(dbVariableReferenceExpression.VariableName));
					}
					dictionary.Add(dbVariableReferenceExpression.VariableName, dbVariableReferenceExpression);
				}
			}
			return dictionary;
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x0011DCC8 File Offset: 0x0011BEC8
		internal global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x0011DCD0 File Offset: 0x0011BED0
		internal global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> Variables
		{
			get
			{
				return this._variables;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06004EBC RID: 20156 RVA: 0x0011DCD8 File Offset: 0x0011BED8
		internal global::System.Data.Entity.Core.Common.EntitySql.TypeResolver TypeResolver
		{
			get
			{
				return this._typeResolver;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06004EBD RID: 20157 RVA: 0x0011DCE0 File Offset: 0x0011BEE0
		internal global::System.Data.Entity.Core.Common.EntitySql.ParserOptions ParserOptions
		{
			get
			{
				return this._parserOptions;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06004EBE RID: 20158 RVA: 0x0011DCE8 File Offset: 0x0011BEE8
		internal global::System.StringComparer NameComparer
		{
			get
			{
				return this._parserOptions.NameComparer;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06004EBF RID: 20159 RVA: 0x0011DCF5 File Offset: 0x0011BEF5
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion> ScopeRegions
		{
			get
			{
				return this._scopeRegions;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06004EC0 RID: 20160 RVA: 0x0011DCFD File Offset: 0x0011BEFD
		internal global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion CurrentScopeRegion
		{
			get
			{
				return this._scopeRegions[this._scopeRegions.Count - 1];
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06004EC1 RID: 20161 RVA: 0x0011DD17 File Offset: 0x0011BF17
		internal global::System.Data.Entity.Core.Common.EntitySql.Scope CurrentScope
		{
			get
			{
				return this._scopeManager.CurrentScope;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06004EC2 RID: 20162 RVA: 0x0011DD24 File Offset: 0x0011BF24
		internal int CurrentScopeIndex
		{
			get
			{
				return this._scopeManager.CurrentScopeIndex;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06004EC3 RID: 20163 RVA: 0x0011DD31 File Offset: 0x0011BF31
		internal global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo CurrentGroupAggregateInfo
		{
			get
			{
				return this._currentGroupAggregateInfo;
			}
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x0011DD3C File Offset: 0x0011BF3C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetExpressionFromScopeEntry(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry, int scopeIndex, string varName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = scopeEntry.GetExpression(varName, errCtx);
			if (this._currentGroupAggregateInfo != null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion definingScopeRegion = this.GetDefiningScopeRegion(scopeIndex);
				if (definingScopeRegion.ScopeRegionIndex <= this._currentGroupAggregateInfo.DefiningScopeRegion.ScopeRegionIndex)
				{
					this._currentGroupAggregateInfo.UpdateScopeIndex(scopeIndex, this);
					global::System.Data.Entity.Core.Common.EntitySql.IGroupExpressionExtendedInfo groupExpressionExtendedInfo = scopeEntry as global::System.Data.Entity.Core.Common.EntitySql.IGroupExpressionExtendedInfo;
					if (groupExpressionExtendedInfo != null)
					{
						global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo groupAggregateInfo = this._currentGroupAggregateInfo;
						while (groupAggregateInfo != null && groupAggregateInfo.DefiningScopeRegion.ScopeRegionIndex >= definingScopeRegion.ScopeRegionIndex && groupAggregateInfo.DefiningScopeRegion.ScopeRegionIndex != definingScopeRegion.ScopeRegionIndex)
						{
							groupAggregateInfo = groupAggregateInfo.ContainingAggregate;
						}
						if (groupAggregateInfo == null || groupAggregateInfo.DefiningScopeRegion.ScopeRegionIndex < definingScopeRegion.ScopeRegionIndex)
						{
							groupAggregateInfo = this._currentGroupAggregateInfo;
						}
						switch (groupAggregateInfo.AggregateKind)
						{
						case global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Function:
							if (groupExpressionExtendedInfo.GroupVarBasedExpression != null)
							{
								result = groupExpressionExtendedInfo.GroupVarBasedExpression;
							}
							break;
						case global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Partition:
							if (groupExpressionExtendedInfo.GroupAggBasedExpression != null)
							{
								result = groupExpressionExtendedInfo.GroupAggBasedExpression;
							}
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x0011DE31 File Offset: 0x0011C031
		internal global::System.IDisposable EnterIgnoreEntityContainerNameResolution()
		{
			this._ignoreEntityContainerNameResolution = true;
			return new global::System.Data.Entity.Core.Common.EntitySql.Disposer(delegate()
			{
				this._ignoreEntityContainerNameResolution = false;
			});
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x0011DE4C File Offset: 0x0011C04C
		internal global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ResolveSimpleName(string name, bool leftHandSideOfMemberAccess, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry;
			int num;
			if (this.TryScopeLookup(name, out scopeEntry, out num))
			{
				if (scopeEntry.EntryKind == global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind.SourceVar && ((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry)scopeEntry).IsJoinClauseLeftExpr)
				{
					string invalidJoinLeftCorrelation = global::System.Data.Entity.Resources.Strings.InvalidJoinLeftCorrelation;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidJoinLeftCorrelation, null);
				}
				this.SetScopeRegionCorrelationFlag(num);
				return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(this.GetExpressionFromScopeEntry(scopeEntry, num, name, errCtx));
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityContainer defaultContainer = this.TypeResolver.Perspective.GetDefaultContainer();
				global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution result;
				if (defaultContainer != null && this.TryResolveEntityContainerMemberAccess(defaultContainer, name, out result))
				{
					return result;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer;
				if (!this._ignoreEntityContainerNameResolution && this.TypeResolver.Perspective.TryGetEntityContainer(name, this._parserOptions.NameComparisonCaseInsensitive, out entityContainer))
				{
					return new global::System.Data.Entity.Core.Common.EntitySql.EntityContainerExpression(entityContainer);
				}
				return this.TypeResolver.ResolveUnqualifiedName(name, leftHandSideOfMemberAccess, errCtx);
			}
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x0011DF04 File Offset: 0x0011C104
		internal global::System.Data.Entity.Core.Common.EntitySql.MetadataMember ResolveSimpleFunctionName(string name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			global::System.Data.Entity.Core.Common.EntitySql.MetadataMember metadataMember = this.TypeResolver.ResolveUnqualifiedName(name, false, errCtx);
			if (metadataMember.MetadataMemberClass == global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Namespace)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityContainer defaultContainer = this.TypeResolver.Perspective.GetDefaultContainer();
				global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution expressionResolution;
				if (defaultContainer != null && this.TryResolveEntityContainerMemberAccess(defaultContainer, name, out expressionResolution) && expressionResolution.ExpressionClass == global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.MetadataMember)
				{
					metadataMember = (global::System.Data.Entity.Core.Common.EntitySql.MetadataMember)expressionResolution;
				}
			}
			return metadataMember;
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x0011DF5C File Offset: 0x0011C15C
		private bool TryScopeLookup(string key, out global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry, out int scopeIndex)
		{
			scopeEntry = null;
			scopeIndex = -1;
			for (int i = this.CurrentScopeIndex; i >= 0; i--)
			{
				if (this._scopeManager.GetScopeByIndex(i).TryLookup(key, out scopeEntry))
				{
					scopeIndex = i;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x0011DF9B File Offset: 0x0011C19B
		internal global::System.Data.Entity.Core.Common.EntitySql.MetadataMember ResolveMetadataMemberName(string[] name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			return this.TypeResolver.ResolveMetadataMemberName(name, errCtx);
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x0011DFAC File Offset: 0x0011C1AC
		internal global::System.Data.Entity.Core.Common.EntitySql.ValueExpression ResolvePropertyAccess(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression valueExpr, string name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value;
			if (this.TryResolveAsPropertyAccess(valueExpr, name, out value))
			{
				return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(value);
			}
			if (this.TryResolveAsRefPropertyAccess(valueExpr, name, errCtx, out value))
			{
				return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(value);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(valueExpr.ResultType))
			{
				string errorMessage = global::System.Data.Entity.Resources.Strings.NotAMemberOfCollection(name, valueExpr.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			string errorMessage2 = global::System.Data.Entity.Resources.Strings.NotAMemberOfType(name, valueExpr.ResultType.EdmType.FullName);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage2, null);
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x0011E02C File Offset: 0x0011C22C
		private bool TryResolveAsPropertyAccess(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression valueExpr, string name, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression propertyExpr)
		{
			propertyExpr = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember member;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStructuralType(valueExpr.ResultType.EdmType) && this.TypeResolver.Perspective.TryGetMember((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)valueExpr.ResultType.EdmType, name, this._parserOptions.NameComparisonCaseInsensitive, out member))
			{
				propertyExpr = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePropertyExpressionFromMember(valueExpr, member);
				return true;
			}
			return false;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x0011E08C File Offset: 0x0011C28C
		private bool TryResolveAsRefPropertyAccess(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression valueExpr, string name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression propertyExpr)
		{
			propertyExpr = null;
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(valueExpr.ResultType))
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = valueExpr.Deref();
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = dbExpression.ResultType;
			if (this.TryResolveAsPropertyAccess(dbExpression, name, out propertyExpr))
			{
				return true;
			}
			string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidDeRefProperty(name, resultType.EdmType.FullName, valueExpr.ResultType.EdmType.FullName);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x0011E0F4 File Offset: 0x0011C2F4
		internal global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ResolveEntityContainerMemberAccess(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, string name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution result;
			if (this.TryResolveEntityContainerMemberAccess(entityContainer, name, out result))
			{
				return result;
			}
			string errorMessage = global::System.Data.Entity.Resources.Strings.MemberDoesNotBelongToEntityContainer(name, entityContainer.Name);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x0011E124 File Offset: 0x0011C324
		private bool TryResolveEntityContainerMemberAccess(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, string name, out global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution resolution)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase targetSet;
			if (this.TypeResolver.Perspective.TryGetExtent(entityContainer, name, this._parserOptions.NameComparisonCaseInsensitive, out targetSet))
			{
				resolution = new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(targetSet.Scan());
				return true;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction;
			if (this.TypeResolver.Perspective.TryGetFunctionImport(entityContainer, name, this._parserOptions.NameComparisonCaseInsensitive, out edmFunction))
			{
				resolution = new global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup(edmFunction.FullName, new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction[]
				{
					edmFunction
				});
				return true;
			}
			resolution = null;
			return false;
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x0011E19F File Offset: 0x0011C39F
		internal global::System.Data.Entity.Core.Common.EntitySql.MetadataMember ResolveMetadataMemberAccess(global::System.Data.Entity.Core.Common.EntitySql.MetadataMember metadataMember, string name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			return this.TypeResolver.ResolveMetadataMemberAccess(metadataMember, name, errCtx);
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x0011E1B0 File Offset: 0x0011C3B0
		internal bool TryResolveInternalAggregateName(string name, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression)
		{
			global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry;
			int scopeRegionCorrelationFlag;
			if (this.TryScopeLookup(name, out scopeEntry, out scopeRegionCorrelationFlag))
			{
				this.SetScopeRegionCorrelationFlag(scopeRegionCorrelationFlag);
				dbExpression = scopeEntry.GetExpression(name, errCtx);
				return true;
			}
			dbExpression = null;
			return false;
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x0011E1E4 File Offset: 0x0011C3E4
		internal bool TryResolveDotExprAsGroupKeyAlternativeName(global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dotExpr, out global::System.Data.Entity.Core.Common.EntitySql.ValueExpression groupKeyResolution)
		{
			groupKeyResolution = null;
			string[] array;
			global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry;
			int num;
			if (this.IsInAnyGroupScope() && dotExpr.IsMultipartIdentifier(out array) && this.TryScopeLookup(global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(array), out scopeEntry, out num))
			{
				global::System.Data.Entity.Core.Common.EntitySql.IGetAlternativeName getAlternativeName = scopeEntry as global::System.Data.Entity.Core.Common.EntitySql.IGetAlternativeName;
				if (getAlternativeName != null && getAlternativeName.AlternativeName != null && array.SequenceEqual(getAlternativeName.AlternativeName, this.NameComparer))
				{
					this.SetScopeRegionCorrelationFlag(num);
					groupKeyResolution = new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(this.GetExpressionFromScopeEntry(scopeEntry, num, global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(array), dotExpr.ErrCtx));
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x0011E264 File Offset: 0x0011C464
		internal string GenerateInternalName(string hint)
		{
			string str = "_##";
			uint namegenCounter = this._namegenCounter;
			this._namegenCounter = namegenCounter + 1U;
			return str + hint + namegenCounter.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06004ED3 RID: 20179 RVA: 0x0011E298 File Offset: 0x0011C498
		private string CreateNewAlias(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression dbScanExpression = expr as global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression;
			if (dbScanExpression != null)
			{
				return dbScanExpression.Target.Name;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = expr as global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression;
			if (dbPropertyExpression != null)
			{
				return dbPropertyExpression.Property.Name;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression = expr as global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression;
			if (dbVariableReferenceExpression != null)
			{
				return dbVariableReferenceExpression.VariableName;
			}
			return this.GenerateInternalName(string.Empty);
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x0011E2F0 File Offset: 0x0011C4F0
		internal string InferAliasName(global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr aliasedExpr, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression convertedExpression)
		{
			if (aliasedExpr.Alias != null)
			{
				return aliasedExpr.Alias.Name;
			}
			global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = aliasedExpr.Expr as global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier;
			if (identifier != null)
			{
				return identifier.Name;
			}
			global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dotExpr = aliasedExpr.Expr as global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr;
			string[] array;
			if (dotExpr != null && dotExpr.IsMultipartIdentifier(out array))
			{
				return array[array.Length - 1];
			}
			return this.CreateNewAlias(convertedExpression);
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x0011E350 File Offset: 0x0011C550
		internal global::System.IDisposable EnterScopeRegion()
		{
			this._scopeManager.EnterScope();
			global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion item = new global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion(this._scopeManager, this.CurrentScopeIndex, this._scopeRegions.Count);
			this._scopeRegions.Add(item);
			return new global::System.Data.Entity.Core.Common.EntitySql.Disposer(delegate()
			{
				this.CurrentScopeRegion.GroupAggregateInfos.Each(delegate(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo groupAggregateInfo)
				{
					groupAggregateInfo.DetachFromAstNode();
				});
				this.CurrentScopeRegion.RollbackAllScopes();
				this._scopeRegions.Remove(this.CurrentScopeRegion);
			});
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x0011E3A2 File Offset: 0x0011C5A2
		internal void RollbackToScope(int scopeIndex)
		{
			this._scopeManager.RollbackToScope(scopeIndex);
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x0011E3B0 File Offset: 0x0011C5B0
		internal void EnterScope()
		{
			this._scopeManager.EnterScope();
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x0011E3BD File Offset: 0x0011C5BD
		internal void LeaveScope()
		{
			this._scopeManager.LeaveScope();
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x0011E3CC File Offset: 0x0011C5CC
		internal bool IsInAnyGroupScope()
		{
			for (int i = 0; i < this._scopeRegions.Count; i++)
			{
				if (this._scopeRegions[i].IsAggregating)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x0011E408 File Offset: 0x0011C608
		internal global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion GetDefiningScopeRegion(int scopeIndex)
		{
			for (int i = this._scopeRegions.Count - 1; i >= 0; i--)
			{
				if (this._scopeRegions[i].ContainsScope(scopeIndex))
				{
					return this._scopeRegions[i];
				}
			}
			return null;
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x0011E44F File Offset: 0x0011C64F
		private void SetScopeRegionCorrelationFlag(int scopeIndex)
		{
			this.GetDefiningScopeRegion(scopeIndex).WasResolutionCorrelated = true;
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x0011E45E File Offset: 0x0011C65E
		internal global::System.IDisposable EnterFunctionAggregate(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, out global::System.Data.Entity.Core.Common.EntitySql.FunctionAggregateInfo aggregateInfo)
		{
			aggregateInfo = new global::System.Data.Entity.Core.Common.EntitySql.FunctionAggregateInfo(methodExpr, errCtx, this._currentGroupAggregateInfo, this.CurrentScopeRegion);
			return this.EnterGroupAggregate(aggregateInfo);
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x0011E47D File Offset: 0x0011C67D
		internal global::System.IDisposable EnterGroupPartition(global::System.Data.Entity.Core.Common.EntitySql.AST.GroupPartitionExpr groupPartitionExpr, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, out global::System.Data.Entity.Core.Common.EntitySql.GroupPartitionInfo aggregateInfo)
		{
			aggregateInfo = new global::System.Data.Entity.Core.Common.EntitySql.GroupPartitionInfo(groupPartitionExpr, errCtx, this._currentGroupAggregateInfo, this.CurrentScopeRegion);
			return this.EnterGroupAggregate(aggregateInfo);
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x0011E49C File Offset: 0x0011C69C
		internal global::System.IDisposable EnterGroupKeyDefinition(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind aggregateKind, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, out global::System.Data.Entity.Core.Common.EntitySql.GroupKeyAggregateInfo aggregateInfo)
		{
			aggregateInfo = new global::System.Data.Entity.Core.Common.EntitySql.GroupKeyAggregateInfo(aggregateKind, errCtx, this._currentGroupAggregateInfo, this.CurrentScopeRegion);
			return this.EnterGroupAggregate(aggregateInfo);
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x0011E4BC File Offset: 0x0011C6BC
		private global::System.IDisposable EnterGroupAggregate(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo aggregateInfo)
		{
			this._currentGroupAggregateInfo = aggregateInfo;
			return new global::System.Data.Entity.Core.Common.EntitySql.Disposer(delegate()
			{
				this._currentGroupAggregateInfo = aggregateInfo.ContainingAggregate;
				aggregateInfo.ValidateAndComputeEvaluatingScopeRegion(this);
			});
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x0011E4FA File Offset: 0x0011C6FA
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction ResolveFunctionOverloads(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionsMetadata, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes, bool isGroupAggregateFunction, out bool isAmbiguous)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.ResolveFunctionOverloads(functionsMetadata, argTypes, new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareFlattenArgumentType), new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareFlattenParameterType), new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool>(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareIsPromotableTo), new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool>(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareIsStructurallyEqual), isGroupAggregateFunction, out isAmbiguous);
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x0011E538 File Offset: 0x0011C738
		internal static TFunctionMetadata ResolveFunctionOverloads<TFunctionMetadata, TFunctionParameterMetadata>(global::System.Collections.Generic.IList<TFunctionMetadata> functionsMetadata, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes, global::System.Func<TFunctionMetadata, global::System.Collections.Generic.IList<TFunctionParameterMetadata>> getSignatureParams, global::System.Func<TFunctionParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> getParameterTypeUsage, global::System.Func<TFunctionParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode> getParameterMode, bool isGroupAggregateFunction, out bool isAmbiguous) where TFunctionMetadata : class
		{
			return global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.ResolveFunctionOverloads<TFunctionMetadata, TFunctionParameterMetadata>(functionsMetadata, argTypes, getSignatureParams, getParameterTypeUsage, getParameterMode, new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareFlattenArgumentType), new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareFlattenParameterType), new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool>(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareIsPromotableTo), new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool>(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareIsStructurallyEqual), isGroupAggregateFunction, out isAmbiguous);
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x0011E584 File Offset: 0x0011C784
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> UntypedNullAwareFlattenArgumentType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argType)
		{
			if (argType == null)
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[1];
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.FlattenType(argType);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x0011E5A4 File Offset: 0x0011C7A4
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> UntypedNullAwareFlattenParameterType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage paramType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argType)
		{
			if (argType == null)
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
				{
					paramType
				};
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.FlattenType(paramType);
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x0011E5C7 File Offset: 0x0011C7C7
		private static bool UntypedNullAwareIsPromotableTo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			if (fromType == null)
			{
				return !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(toType.EdmType);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(fromType, toType);
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x0011E5E2 File Offset: 0x0011C7E2
		private static bool UntypedNullAwareIsStructurallyEqual(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			if (fromType == null)
			{
				return global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.UntypedNullAwareIsPromotableTo(fromType, toType);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(fromType, toType);
		}

		// Token: 0x04001C77 RID: 7287
		private readonly global::System.Data.Entity.Core.Common.EntitySql.ParserOptions _parserOptions;

		// Token: 0x04001C78 RID: 7288
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> _parameters;

		// Token: 0x04001C79 RID: 7289
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> _variables;

		// Token: 0x04001C7A RID: 7290
		private readonly global::System.Data.Entity.Core.Common.EntitySql.TypeResolver _typeResolver;

		// Token: 0x04001C7B RID: 7291
		private readonly global::System.Data.Entity.Core.Common.EntitySql.ScopeManager _scopeManager;

		// Token: 0x04001C7C RID: 7292
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion> _scopeRegions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion>();

		// Token: 0x04001C7D RID: 7293
		private bool _ignoreEntityContainerNameResolution;

		// Token: 0x04001C7E RID: 7294
		private global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo _currentGroupAggregateInfo;

		// Token: 0x04001C7F RID: 7295
		private uint _namegenCounter;
	}
}
