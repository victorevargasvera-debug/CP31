using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200044F RID: 1103
	internal class ObjectFullSpanRewriter : global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter
	{
		// Token: 0x060035E2 RID: 13794 RVA: 0x000AC458 File Offset: 0x000AA658
		internal ObjectFullSpanRewriter(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree tree, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression toRewrite, global::System.Data.Entity.Core.Objects.Span span, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(tree, toRewrite, aliasGenerator)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType declaringType = null;
			if (!global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.TryGetEntityType(base.Query.ResultType, out declaringType))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectQuery_Span_IncludeRequiresEntityOrEntityCollection);
			}
			global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo spanPathInfo = new global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo(declaringType);
			foreach (global::System.Data.Entity.Core.Objects.Span.SpanPath spanPath in span.SpanList)
			{
				this.AddSpanPath(spanPathInfo, spanPath.Navigations);
			}
			this._currentSpanPath.Push(spanPathInfo);
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x000AC4FC File Offset: 0x000AA6FC
		private void AddSpanPath(global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo parentInfo, global::System.Collections.Generic.List<string> navPropNames)
		{
			this.ConvertSpanPath(parentInfo, navPropNames, 0);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x000AC508 File Offset: 0x000AA708
		private void ConvertSpanPath(global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo parentInfo, global::System.Collections.Generic.List<string> navPropNames, int pos)
		{
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = null;
			if (!parentInfo.DeclaringType.NavigationProperties.TryGetValue(navPropNames[pos], true, out navigationProperty))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectQuery_Span_NoNavProp(parentInfo.DeclaringType.FullName, navPropNames[pos]));
			}
			if (parentInfo.Children == null)
			{
				parentInfo.Children = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo>();
			}
			global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo spanPathInfo = null;
			if (!parentInfo.Children.TryGetValue(navigationProperty, out spanPathInfo))
			{
				spanPathInfo = new global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo(global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.EntityTypeFromResultType(navigationProperty));
				parentInfo.Children[navigationProperty] = spanPathInfo;
			}
			if (pos < navPropNames.Count - 1)
			{
				this.ConvertSpanPath(spanPathInfo, navPropNames, pos + 1);
			}
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x000AC5A4 File Offset: 0x000AA7A4
		private static global::System.Data.Entity.Core.Metadata.Edm.EntityType EntityTypeFromResultType(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProp)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType result = null;
			global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.TryGetEntityType(navProp.TypeUsage, out result);
			return result;
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x000AC5C4 File Offset: 0x000AA7C4
		private static bool TryGetEntityType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, out global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType == resultType.EdmType.BuiltInTypeKind)
			{
				entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)resultType.EdmType;
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == resultType.EdmType.BuiltInTypeKind)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)resultType.EdmType).TypeUsage.EdmType;
				if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType == edmType.BuiltInTypeKind)
				{
					entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType;
					return true;
				}
			}
			entityType = null;
			return false;
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x000AC62B File Offset: 0x000AA82B
		private global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetNavigationPropertyTargetEnd(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty property)
		{
			return base.Metadata.GetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(property.RelationshipType.FullName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace).AssociationEndMembers[property.ToEndMember.Name];
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x000AC65C File Offset: 0x000AA85C
		internal override global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo CreateEntitySpanTrackingInfo(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo spanTrackingInfo = default(global::System.Data.Entity.Core.Objects.Internal.ObjectSpanRewriter.SpanTrackingInfo);
			global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo spanPathInfo = this._currentSpanPath.Peek();
			if (spanPathInfo.Children != null)
			{
				int num = 1;
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo> keyValuePair in spanPathInfo.Children)
				{
					if (spanTrackingInfo.ColumnDefinitions == null)
					{
						spanTrackingInfo = base.InitializeTrackingInfo(base.RelationshipSpan);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expression.Property(keyValuePair.Key);
					this._currentSpanPath.Push(keyValuePair.Value);
					dbExpression = base.Rewrite(dbExpression);
					this._currentSpanPath.Pop();
					spanTrackingInfo.ColumnDefinitions.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spanTrackingInfo.ColumnNames.Next(), dbExpression));
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember navigationPropertyTargetEnd = this.GetNavigationPropertyTargetEnd(keyValuePair.Key);
					spanTrackingInfo.SpannedColumns[num] = navigationPropertyTargetEnd;
					if (base.RelationshipSpan)
					{
						spanTrackingInfo.FullSpannedEnds[navigationPropertyTargetEnd] = true;
					}
					num++;
				}
			}
			return spanTrackingInfo;
		}

		// Token: 0x04001163 RID: 4451
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo> _currentSpanPath = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo>();

		// Token: 0x02000A54 RID: 2644
		private class SpanPathInfo
		{
			// Token: 0x060061BE RID: 25022 RVA: 0x0014F8CA File Offset: 0x0014DACA
			internal SpanPathInfo(global::System.Data.Entity.Core.Metadata.Edm.EntityType declaringType)
			{
				this.DeclaringType = declaringType;
			}

			// Token: 0x04002A73 RID: 10867
			internal readonly global::System.Data.Entity.Core.Metadata.Edm.EntityType DeclaringType;

			// Token: 0x04002A74 RID: 10868
			internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Data.Entity.Core.Objects.Internal.ObjectFullSpanRewriter.SpanPathInfo> Children;
		}
	}
}
