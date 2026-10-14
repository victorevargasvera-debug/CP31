using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000453 RID: 1107
	internal class ObjectSpanRewriter
	{
		// Token: 0x0600360F RID: 13839 RVA: 0x000ACF11 File Offset: 0x000AB111
		internal static bool EntityTypeEquals(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType1, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType2)
		{
			return entityType1 == entityType2;
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x000ACF18 File Offset: 0x000AB118
		internal static bool TryRewrite(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree, global::System.Data.Entity.Core.Objects.Span span, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression newQuery, out global::System.Data.Entity.Core.Objects.Internal.SpanIndex spanInfo)
		{
			newQuery = null;
			spanInfo = null;
			global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter objectSpanRewriter = null;
			bool flag = global::System.Data.Entity.Core.Objects.Span.RequiresRelationshipSpan(mergeOption);
			if (span != null && span.SpanList.Count > 0)
			{
				objectSpanRewriter = new global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter(tree, tree.Query, span, aliasGenerator);
			}
			else if (flag)
			{
				objectSpanRewriter = new global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter(tree, tree.Query, aliasGenerator);
			}
			if (objectSpanRewriter != null)
			{
				objectSpanRewriter.RelationshipSpan = flag;
				newQuery = objectSpanRewriter.RewriteQuery();
				if (newQuery != null)
				{
					spanInfo = objectSpanRewriter.SpanIndex;
				}
			}
			return spanInfo != null;
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x000ACF90 File Offset: 0x000AB190
		internal ObjectSpanRewriter(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree tree, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression toRewrite, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator)
		{
			this._toRewrite = toRewrite;
			this._tree = tree;
			this._aliasGenerator = aliasGenerator;
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x000ACFB8 File Offset: 0x000AB1B8
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace Metadata
		{
			get
			{
				return this._tree.MetadataWorkspace;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x000ACFC5 File Offset: 0x000AB1C5
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Query
		{
			get
			{
				return this._toRewrite;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x000ACFCD File Offset: 0x000AB1CD
		// (set) Token: 0x06003615 RID: 13845 RVA: 0x000ACFD5 File Offset: 0x000AB1D5
		internal bool RelationshipSpan
		{
			get
			{
				return this._relationshipSpan;
			}
			set
			{
				this._relationshipSpan = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06003616 RID: 13846 RVA: 0x000ACFDE File Offset: 0x000AB1DE
		internal global::System.Data.Entity.Core.Objects.Internal.SpanIndex SpanIndex
		{
			get
			{
				return this._spanIndex;
			}
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x000ACFE8 File Offset: 0x000AB1E8
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RewriteQuery()
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.Rewrite(this._toRewrite);
			if (this._toRewrite == dbExpression)
			{
				return null;
			}
			return dbExpression;
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x000AD010 File Offset: 0x000AB210
		internal global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo InitializeTrackingInfo(bool createAssociationEndTrackingInfo)
		{
			global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo result = default(global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo);
			result.ColumnDefinitions = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
			result.ColumnNames = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Span{0}_Column", new object[]
			{
				this._spanCount
			}));
			result.SpannedColumns = new global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>();
			if (createAssociationEndTrackingInfo)
			{
				result.FullSpannedEnds = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, bool>();
			}
			return result;
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x000AD07C File Offset: 0x000AB27C
		internal virtual global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo CreateEntitySpanTrackingInfo(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return default(global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo);
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x000AD094 File Offset: 0x000AB294
		protected global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Rewrite(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = expression.ExpressionKind;
			if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Element)
			{
				return this.RewriteElementExpression((global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression)expression);
			}
			if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit)
			{
				return this.RewriteLimitExpression((global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression)expression);
			}
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = expression.ResultType.EdmType.BuiltInTypeKind;
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
			{
				return this.RewriteCollection(expression);
			}
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				return this.RewriteEntity(expression, (global::System.Data.Entity.Core.Metadata.Edm.EntityType)expression.ResultType.EdmType);
			}
			if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
			{
				return expression;
			}
			return this.RewriteRow(expression, (global::System.Data.Entity.Core.Metadata.Edm.RowType)expression.ResultType.EdmType);
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x000AD128 File Offset: 0x000AB328
		private void AddSpannedRowType(global::System.Data.Entity.Core.Metadata.Edm.RowType spannedType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage originalType)
		{
			if (this._spanIndex == null)
			{
				this._spanIndex = new global::System.Data.Entity.Core.Objects.Internal.SpanIndex();
			}
			this._spanIndex.AddSpannedRowType(spannedType, originalType);
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x000AD14A File Offset: 0x000AB34A
		private void AddSpanMap(global::System.Data.Entity.Core.Metadata.Edm.RowType rowType, global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> columnMap)
		{
			if (this._spanIndex == null)
			{
				this._spanIndex = new global::System.Data.Entity.Core.Objects.Internal.SpanIndex();
			}
			this._spanIndex.AddSpanMap(rowType, columnMap);
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x000AD16C File Offset: 0x000AB36C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RewriteEntity(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance == expression.ExpressionKind)
			{
				return expression;
			}
			this._spanCount++;
			int spanCount = this._spanCount;
			global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo spanTrackingInfo = this.CreateEntitySpanTrackingInfo(expression, entityType);
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>> relationshipSpanEnds = this.GetRelationshipSpanEnds(entityType);
			if (relationshipSpanEnds != null)
			{
				if (spanTrackingInfo.ColumnDefinitions == null)
				{
					spanTrackingInfo = this.InitializeTrackingInfo(false);
				}
				int num = spanTrackingInfo.ColumnDefinitions.Count + 1;
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> keyValuePair in relationshipSpanEnds)
				{
					if (spanTrackingInfo.FullSpannedEnds == null || !spanTrackingInfo.FullSpannedEnds.ContainsKey(keyValuePair.Value))
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = null;
						if (!this.TryGetNavigationSource(keyValuePair.Value, out value))
						{
							value = expression.GetEntityRef().NavigateAllowingAllRelationshipsInSameTypeHierarchy(keyValuePair.Key, keyValuePair.Value);
						}
						spanTrackingInfo.ColumnDefinitions.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spanTrackingInfo.ColumnNames.Next(), value));
						spanTrackingInfo.SpannedColumns[num] = keyValuePair.Value;
						num++;
					}
				}
			}
			if (spanTrackingInfo.ColumnDefinitions == null)
			{
				this._spanCount--;
				return expression;
			}
			spanTrackingInfo.ColumnDefinitions.Insert(0, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Span{0}_SpanRoot", new object[]
			{
				spanCount
			}), expression));
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(spanTrackingInfo.ColumnDefinitions);
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)dbNewInstanceExpression.ResultType.EdmType;
			this.AddSpanMap(rowType, spanTrackingInfo.SpannedColumns);
			return dbNewInstanceExpression;
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x000AD308 File Offset: 0x000AB508
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RewriteElementExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.Rewrite(expression.Argument);
			if (expression.Argument != dbExpression)
			{
				expression = dbExpression.Element();
			}
			return expression;
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x000AD334 File Offset: 0x000AB534
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RewriteLimitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.Rewrite(expression.Argument);
			if (expression.Argument != dbExpression)
			{
				expression = dbExpression.Limit(expression.Limit);
			}
			return expression;
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x000AD368 File Offset: 0x000AB568
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RewriteRow(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Metadata.Edm.RowType rowType)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression dbLambdaExpression = expression as global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression;
			if (dbLambdaExpression != null)
			{
				dbNewInstanceExpression = (dbLambdaExpression.Lambda.Body as global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression);
			}
			else
			{
				dbNewInstanceExpression = (expression as global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression);
			}
			global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> dictionary = null;
			global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> dictionary2 = null;
			for (int i = 0; i < rowType.Properties.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = rowType.Properties[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
				if (dbNewInstanceExpression != null)
				{
					dbExpression = dbNewInstanceExpression.Arguments[i];
				}
				else
				{
					dbExpression = expression.Property(edmProperty.Name);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.Rewrite(dbExpression);
				if (dbExpression2 != dbExpression)
				{
					if (dictionary2 == null)
					{
						dictionary2 = new global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
					}
					dictionary2[i] = dbExpression2;
				}
				else
				{
					if (dictionary == null)
					{
						dictionary = new global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
					}
					dictionary[i] = dbExpression;
				}
			}
			if (dictionary2 == null)
			{
				return expression;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(rowType.Properties.Count);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(rowType.Properties.Count);
			for (int j = 0; j < rowType.Properties.Count; j++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = rowType.Properties[j];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = null;
				if (!dictionary2.TryGetValue(j, out dbExpression3))
				{
					dbExpression3 = dictionary[j];
				}
				list.Add(dbExpression3);
				list2.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(edmProperty2.Name, dbExpression3.ResultType));
			}
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType2 = new global::System.Data.Entity.Core.Metadata.Edm.RowType(list2, rowType.InitializerMetadata);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(rowType2);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4 = typeUsage.New(list);
			if (dbNewInstanceExpression == null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression5 = expression.IsNull();
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression6 = typeUsage.Null();
				dbExpression4 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					dbExpression5
				}), new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					dbExpression6
				}), dbExpression4);
			}
			this.AddSpannedRowType(rowType2, expression.ResultType);
			if (dbLambdaExpression != null && dbNewInstanceExpression != null)
			{
				dbExpression4 = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.Create(dbExpression4, dbLambdaExpression.Lambda.Variables).Invoke(dbLambdaExpression.Arguments);
			}
			return dbExpression4;
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x000AD54C File Offset: 0x000AB74C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RewriteCollection(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = null;
			if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project == expression.ExpressionKind)
			{
				dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)expression;
				dbExpression = dbProjectExpression.Input.Expression;
			}
			global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.NavigationInfo navigationInfo = null;
			if (this.RelationshipSpan)
			{
				dbExpression = global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.RelationshipNavigationVisitor.FindNavigationExpression(dbExpression, this._aliasGenerator, out navigationInfo);
			}
			if (navigationInfo != null)
			{
				this.EnterNavigationCollection(navigationInfo);
			}
			else
			{
				this.EnterCollection();
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = expression;
			if (dbProjectExpression != null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = this.Rewrite(dbProjectExpression.Projection);
				if (dbProjectExpression.Projection != dbExpression3)
				{
					dbExpression2 = dbExpression.BindAs(dbProjectExpression.Input.VariableName).Project(dbExpression3);
				}
			}
			else
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbExpression.BindAs(this._aliasGenerator.Next());
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression variable = dbExpressionBinding.Variable;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4 = this.Rewrite(variable);
				if (variable != dbExpression4)
				{
					dbExpression2 = dbExpressionBinding.Project(dbExpression4);
				}
			}
			this.ExitCollection();
			if (navigationInfo != null && navigationInfo.InUse)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(1);
				list.Add(navigationInfo.SourceVariable);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1);
				list2.Add(navigationInfo.Source);
				dbExpression2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(dbExpression2, list).Invoke(list2);
			}
			return dbExpression2;
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x000AD65F File Offset: 0x000AB85F
		private void EnterCollection()
		{
			this._navSources.Push(null);
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x000AD66D File Offset: 0x000AB86D
		private void EnterNavigationCollection(global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.NavigationInfo info)
		{
			this._navSources.Push(info);
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x000AD67B File Offset: 0x000AB87B
		private void ExitCollection()
		{
			this._navSources.Pop();
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x000AD68C File Offset: 0x000AB88C
		private bool TryGetNavigationSource(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember wasSourceNowTargetEnd, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source)
		{
			source = null;
			global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.NavigationInfo navigationInfo = null;
			if (this._navSources.Count > 0)
			{
				navigationInfo = this._navSources.Peek();
				if (navigationInfo != null && wasSourceNowTargetEnd != navigationInfo.SourceEnd)
				{
					navigationInfo = null;
				}
			}
			if (navigationInfo != null)
			{
				source = navigationInfo.SourceVariable;
				navigationInfo.InUse = true;
				return true;
			}
			return false;
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x000AD6DC File Offset: 0x000AB8DC
		private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>> GetRelationshipSpanEnds(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>> list = null;
			if (this._relationshipSpan)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in this._tree.MetadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace))
				{
					if (2 == associationType.AssociationEndMembers.Count)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = associationType.AssociationEndMembers[0];
						global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 = associationType.AssociationEndMembers[1];
						if (global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.IsValidRelationshipSpan(entityType, associationType, associationEndMember, associationEndMember2))
						{
							if (list == null)
							{
								list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>>();
							}
							list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(associationEndMember, associationEndMember2));
						}
						if (global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.IsValidRelationshipSpan(entityType, associationType, associationEndMember2, associationEndMember))
						{
							if (list == null)
							{
								list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>>();
							}
							list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(associationEndMember2, associationEndMember));
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x000AD7AC File Offset: 0x000AB9AC
		private static bool IsValidRelationshipSpan(global::System.Data.Entity.Core.Metadata.Edm.EntityType compareType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember toEnd)
		{
			if (!associationType.IsForeignKey && (global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One == toEnd.RelationshipMultiplicity || toEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)fromEnd.TypeUsage.EdmType).ElementType;
				return global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.EntityTypeEquals(compareType, entityType) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(compareType, entityType) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(entityType, compareType);
			}
			return false;
		}

		// Token: 0x04001177 RID: 4471
		private int _spanCount;

		// Token: 0x04001178 RID: 4472
		private global::System.Data.Entity.Core.Objects.Internal.SpanIndex _spanIndex;

		// Token: 0x04001179 RID: 4473
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _toRewrite;

		// Token: 0x0400117A RID: 4474
		private bool _relationshipSpan;

		// Token: 0x0400117B RID: 4475
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree _tree;

		// Token: 0x0400117C RID: 4476
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.NavigationInfo> _navSources = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.NavigationInfo>();

		// Token: 0x0400117D RID: 4477
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _aliasGenerator;

		// Token: 0x02000A56 RID: 2646
		internal struct SpanTrackingInfo
		{
			// Token: 0x04002A81 RID: 10881
			public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> ColumnDefinitions;

			// Token: 0x04002A82 RID: 10882
			public global::System.Data.Entity.Core.Common.Utils.AliasGenerator ColumnNames;

			// Token: 0x04002A83 RID: 10883
			public global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> SpannedColumns;

			// Token: 0x04002A84 RID: 10884
			public global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, bool> FullSpannedEnds;
		}

		// Token: 0x02000A57 RID: 2647
		private class NavigationInfo
		{
			// Token: 0x060061C1 RID: 25025 RVA: 0x0014FC42 File Offset: 0x0014DE42
			public NavigationInfo(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression originalNavigation, global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression rewrittenNavigation)
			{
				this._sourceEnd = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)originalNavigation.NavigateFrom;
				this._sourceRef = (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)rewrittenNavigation.NavigationSource;
				this._source = originalNavigation.NavigationSource;
			}

			// Token: 0x170010BF RID: 4287
			// (get) Token: 0x060061C2 RID: 25026 RVA: 0x0014FC78 File Offset: 0x0014DE78
			public global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember SourceEnd
			{
				get
				{
					return this._sourceEnd;
				}
			}

			// Token: 0x170010C0 RID: 4288
			// (get) Token: 0x060061C3 RID: 25027 RVA: 0x0014FC80 File Offset: 0x0014DE80
			public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Source
			{
				get
				{
					return this._source;
				}
			}

			// Token: 0x170010C1 RID: 4289
			// (get) Token: 0x060061C4 RID: 25028 RVA: 0x0014FC88 File Offset: 0x0014DE88
			public global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression SourceVariable
			{
				get
				{
					return this._sourceRef;
				}
			}

			// Token: 0x04002A85 RID: 10885
			private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression _sourceRef;

			// Token: 0x04002A86 RID: 10886
			private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember _sourceEnd;

			// Token: 0x04002A87 RID: 10887
			private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _source;

			// Token: 0x04002A88 RID: 10888
			public bool InUse;
		}

		// Token: 0x02000A58 RID: 2648
		private class RelationshipNavigationVisitor : global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor
		{
			// Token: 0x060061C5 RID: 25029 RVA: 0x0014FC90 File Offset: 0x0014DE90
			internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FindNavigationExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator, out global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.NavigationInfo navInfo)
			{
				navInfo = null;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)expression.ResultType.EdmType).TypeUsage;
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(typeUsage))
				{
					return expression;
				}
				global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.RelationshipNavigationVisitor relationshipNavigationVisitor = new global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.RelationshipNavigationVisitor(aliasGenerator);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = relationshipNavigationVisitor.Find(expression);
				if (expression != dbExpression)
				{
					navInfo = new global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.NavigationInfo(relationshipNavigationVisitor._original, relationshipNavigationVisitor._rewritten);
					return dbExpression;
				}
				return expression;
			}

			// Token: 0x060061C6 RID: 25030 RVA: 0x0014FCF1 File Offset: 0x0014DEF1
			private RelationshipNavigationVisitor(global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator)
			{
				this._aliasGenerator = aliasGenerator;
			}

			// Token: 0x060061C7 RID: 25031 RVA: 0x0014FD00 File Offset: 0x0014DF00
			private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Find(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
			{
				return this.VisitExpression(expression);
			}

			// Token: 0x060061C8 RID: 25032 RVA: 0x0014FD0C File Offset: 0x0014DF0C
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = expression.ExpressionKind;
				if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit)
				{
					if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Distinct && expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter && expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit)
					{
						return expression;
					}
				}
				else if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
				{
					if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfType && expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
					{
						return expression;
					}
				}
				else if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.RelationshipNavigation && expressionKind - global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip > 1)
				{
					return expression;
				}
				return base.VisitExpression(expression);
			}

			// Token: 0x060061C9 RID: 25033 RVA: 0x0014FD5C File Offset: 0x0014DF5C
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(expression, "expression");
				this._original = expression;
				string name = this._aliasGenerator.Next();
				global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression navigateFrom = new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression(expression.NavigationSource.ResultType, name);
				this._rewritten = navigateFrom.Navigate(expression.NavigateFrom, expression.NavigateTo);
				return this._rewritten;
			}

			// Token: 0x060061CA RID: 25034 RVA: 0x0014FDB8 File Offset: 0x0014DFB8
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(expression, "expression");
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.Find(expression.Input.Expression);
				if (dbExpression != expression.Input.Expression)
				{
					return dbExpression.BindAs(expression.Input.VariableName).Filter(expression.Predicate);
				}
				return expression;
			}

			// Token: 0x060061CB RID: 25035 RVA: 0x0014FE10 File Offset: 0x0014E010
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(expression, "expression");
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression.Projection;
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Deref == dbExpression.ExpressionKind)
				{
					dbExpression = ((global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression)dbExpression).Argument;
				}
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference == dbExpression.ExpressionKind && ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)dbExpression).VariableName.Equals(expression.Input.VariableName, global::System.StringComparison.Ordinal))
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.Find(expression.Input.Expression);
					if (dbExpression2 != expression.Input.Expression)
					{
						return dbExpression2.BindAs(expression.Input.VariableName).Project(expression.Projection);
					}
				}
				return expression;
			}

			// Token: 0x060061CC RID: 25036 RVA: 0x0014FEAC File Offset: 0x0014E0AC
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(expression, "expression");
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.Find(expression.Input.Expression);
				if (dbExpression != expression.Input.Expression)
				{
					return dbExpression.BindAs(expression.Input.VariableName).Sort(expression.SortOrder);
				}
				return expression;
			}

			// Token: 0x060061CD RID: 25037 RVA: 0x0014FF04 File Offset: 0x0014E104
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(expression, "expression");
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.Find(expression.Input.Expression);
				if (dbExpression != expression.Input.Expression)
				{
					return dbExpression.BindAs(expression.Input.VariableName).Skip(expression.SortOrder, expression.Count);
				}
				return expression;
			}

			// Token: 0x04002A89 RID: 10889
			private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _aliasGenerator;

			// Token: 0x04002A8A RID: 10890
			private global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression _original;

			// Token: 0x04002A8B RID: 10891
			private global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression _rewritten;
		}
	}
}
