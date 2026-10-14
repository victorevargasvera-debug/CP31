using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000460 RID: 1120
	internal sealed class ExpressionConverter
	{
		// Token: 0x060036FD RID: 14077 RVA: 0x000B0E84 File Offset: 0x000AF084
		internal ExpressionConverter(global::System.Data.Entity.Core.Objects.ELinq.Funcletizer funcletizer, global::System.Linq.Expressions.Expression expression)
		{
			this._funcletizer = funcletizer;
			expression = funcletizer.Funcletize(expression, out this._recompileRequired);
			global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer linqExpressionNormalizer = new global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer();
			this._expression = linqExpressionNormalizer.Visit(expression);
			this._perspective = funcletizer.RootContext.Perspective;
			this._bindingContext = new global::System.Data.Entity.Core.Objects.ELinq.BindingContext();
			this._ignoreInclude = 0;
			this._orderByLifter = new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter(this._aliasGenerator);
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x000B0F08 File Offset: 0x000AF108
		private static global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ExpressionType, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator> InitializeTranslators()
		{
			global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ExpressionType, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ExpressionType, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator>();
			foreach (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator translator in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.GetTranslators())
			{
				foreach (global::System.Linq.Expressions.ExpressionType key in translator.NodeTypes)
				{
					dictionary.Add(key, translator);
				}
			}
			return dictionary;
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x000B0F94 File Offset: 0x000AF194
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator> GetTranslators()
		{
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.AndAlsoTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrElseTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.LessThanTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.LessThanOrEqualsTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.GreaterThanTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.GreaterThanOrEqualsTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.NotEqualsTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ConvertTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ConstantTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.NotTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ParameterTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberInitTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.NewTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.AddTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ConditionalTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DivideTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ModuloTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.SubtractTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MultiplyTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.PowerTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.NegateTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.UnaryPlusTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CoalesceTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.AsTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.IsTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.QuoteTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.AndTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ExclusiveOrTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ExtensionTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.NewArrayInitTranslator();
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ListInitTranslator();
			global::System.Linq.Expressions.ExpressionType[] array = new global::System.Linq.Expressions.ExpressionType[7];
			global::System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, fieldof(global::<PrivateImplementationDetails>.583A8AD6D763783A087385D9DB46FCB398D3D1E27858033C8755705BA6D8F2BC).FieldHandle);
			yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.NotSupportedTranslator(array);
			yield break;
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x000B0F9D File Offset: 0x000AF19D
		private global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection EdmItemCollection
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection)this._funcletizer.RootContext.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, true);
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x000B0FBB File Offset: 0x000AF1BB
		internal global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
		{
			get
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)this._funcletizer.RootContext.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)).ProviderManifest;
			}
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x000B0FDD File Offset: 0x000AF1DD
		internal global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>> GetParameters()
		{
			if (this._parameters != null)
			{
				return this._parameters;
			}
			return null;
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x000B0FEF File Offset: 0x000AF1EF
		internal global::System.Data.Entity.Core.Objects.MergeOption? PropagatedMergeOption
		{
			get
			{
				return this._mergeOption;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x000B0FF7 File Offset: 0x000AF1F7
		internal global::System.Data.Entity.Core.Objects.Span PropagatedSpan
		{
			get
			{
				return this._span;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x000B0FFF File Offset: 0x000AF1FF
		internal global::System.Func<bool> RecompileRequired
		{
			get
			{
				return this._recompileRequired;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x000B1007 File Offset: 0x000AF207
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x000B100F File Offset: 0x000AF20F
		internal int IgnoreInclude
		{
			get
			{
				return this._ignoreInclude;
			}
			set
			{
				this._ignoreInclude = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x000B1018 File Offset: 0x000AF218
		internal global::System.Data.Entity.Core.Common.Utils.AliasGenerator AliasGenerator
		{
			get
			{
				return this._aliasGenerator;
			}
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x000B1020 File Offset: 0x000AF220
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Convert()
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.TranslateExpression(this._expression);
			if (!this.TryGetSpan(dbExpression, out this._span))
			{
				this._span = null;
			}
			return dbExpression;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x000B1051 File Offset: 0x000AF251
		internal static bool CanFuncletizePropertyInfo(global::System.Reflection.PropertyInfo propertyInfo)
		{
			return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.CanFuncletizePropertyInfo(propertyInfo);
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x000B1059 File Offset: 0x000AF259
		internal bool CanIncludeSpanInfo()
		{
			return this._ignoreInclude == 0;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x000B1064 File Offset: 0x000AF264
		private void NotifyMergeOption(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			if (this._mergeOption == null)
			{
				this._mergeOption = new global::System.Data.Entity.Core.Objects.MergeOption?(mergeOption);
			}
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x000B1080 File Offset: 0x000AF280
		internal void ValidateInitializerMetadata(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata metadata)
		{
			global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata other;
			if (this._initializers != null && this._initializers.TryGetValue(metadata.ClrType, out other))
			{
				if (!metadata.Equals(other))
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedHeterogeneousInitializers(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(metadata.ClrType)));
				}
			}
			else
			{
				if (this._initializers == null)
				{
					this._initializers = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata>();
				}
				this._initializers.Add(metadata.ClrType, metadata);
			}
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x000B10F0 File Offset: 0x000AF2F0
		private void AddParameter(global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression queryParameter)
		{
			if (this._parameters == null)
			{
				this._parameters = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>>();
			}
			if (!(from p in this._parameters
			select p.Item2).Contains(queryParameter))
			{
				global::System.Data.Entity.Core.Objects.ObjectParameter item = new global::System.Data.Entity.Core.Objects.ObjectParameter(queryParameter.ParameterReference.ParameterName, queryParameter.Type);
				this._parameters.Add(new global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>(item, queryParameter));
			}
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x000B116B File Offset: 0x000AF36B
		private bool IsQueryRoot(global::System.Linq.Expressions.Expression Expression)
		{
			return this._expression == Expression;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x000B1178 File Offset: 0x000AF378
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AddSpanMapping(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Objects.Span span)
		{
			if (span != null && this.CanIncludeSpanInfo())
			{
				if (this._spanMappings == null)
				{
					this._spanMappings = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Objects.Span>();
				}
				global::System.Data.Entity.Core.Objects.Span span2 = null;
				if (this._spanMappings.TryGetValue(expression, out span2))
				{
					foreach (global::System.Data.Entity.Core.Objects.Span.SpanPath spanPath in span.SpanList)
					{
						span2.AddSpanPath(spanPath);
					}
					this._spanMappings[expression] = span2;
				}
				else
				{
					this._spanMappings[expression] = span;
				}
			}
			return expression;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x000B1218 File Offset: 0x000AF418
		private bool TryGetSpan(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, out global::System.Data.Entity.Core.Objects.Span span)
		{
			if (this._spanMappings != null)
			{
				return this._spanMappings.TryGetValue(expression, out span);
			}
			span = null;
			return false;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x000B1234 File Offset: 0x000AF434
		private void ApplySpanMapping(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression from, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression to)
		{
			global::System.Data.Entity.Core.Objects.Span span;
			if (this.TryGetSpan(from, out span))
			{
				this.AddSpanMapping(to, span);
			}
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x000B1258 File Offset: 0x000AF458
		private void UnifySpanMappings(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression to)
		{
			global::System.Data.Entity.Core.Objects.Span span = null;
			global::System.Data.Entity.Core.Objects.Span span2 = null;
			bool flag = this.TryGetSpan(left, out span);
			bool flag2 = this.TryGetSpan(right, out span2);
			if (!flag && !flag2)
			{
				return;
			}
			this.AddSpanMapping(to, global::System.Data.Entity.Core.Objects.Span.CopyUnion(span, span2));
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x000B1294 File Offset: 0x000AF494
		private global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression Distinct(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression dbDistinctExpression = argument.Distinct();
			this.ApplySpanMapping(argument, dbDistinctExpression);
			return dbDistinctExpression;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x000B12B4 File Offset: 0x000AF4B4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression Except(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression dbExceptExpression = left.Except(right);
			this.ApplySpanMapping(left, dbExceptExpression);
			return dbExceptExpression;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x000B12D4 File Offset: 0x000AF4D4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this._orderByLifter.Filter(input, predicate);
			this.ApplySpanMapping(input.Expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x000B1300 File Offset: 0x000AF500
		private global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression Intersect(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression dbIntersectExpression = left.Intersect(right);
			this.UnifySpanMappings(left, right, dbIntersectExpression);
			return dbIntersectExpression;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x000B1320 File Offset: 0x000AF520
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression limit)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this._orderByLifter.Limit(argument, limit);
			this.ApplySpanMapping(argument, dbExpression);
			return dbExpression;
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x000B1344 File Offset: 0x000AF544
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression OfType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ofType)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this._orderByLifter.OfType(argument, ofType);
			this.ApplySpanMapping(argument, dbExpression);
			return dbExpression;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x000B1368 File Offset: 0x000AF568
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this._orderByLifter.Project(input, projection);
			if (projection.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference && ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)projection).VariableName.Equals(input.VariableName, global::System.StringComparison.Ordinal))
			{
				this.ApplySpanMapping(input.Expression, dbExpression);
			}
			return dbExpression;
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x000B13B4 File Offset: 0x000AF5B4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression Sort(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> keys)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression dbSortExpression = input.Sort(keys);
			this.ApplySpanMapping(input.Expression, dbSortExpression);
			return dbSortExpression;
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x000B13D8 File Offset: 0x000AF5D8
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression skipCount)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this._orderByLifter.Skip(input, skipCount);
			this.ApplySpanMapping(input.Expression, dbExpression);
			return dbExpression;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x000B1404 File Offset: 0x000AF604
		private global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression UnionAll(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression dbUnionAllExpression = left.UnionAll(right);
			this.UnifySpanMappings(left, right, dbUnionAllExpression);
			return dbUnionAllExpression;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x000B1424 File Offset: 0x000AF624
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetCastTargetType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Type toClrType, global::System.Type fromClrType, bool preserveCastForDateTime)
		{
			if (fromClrType != null && fromClrType.IsGenericType() && toClrType.IsGenericType() && (fromClrType.GetGenericTypeDefinition() == typeof(global::System.Data.Entity.Core.Objects.ObjectQuery<>) || fromClrType.GetGenericTypeDefinition() == typeof(global::System.Linq.IQueryable<>) || fromClrType.GetGenericTypeDefinition() == typeof(global::System.Linq.IOrderedQueryable<>)) && (toClrType.GetGenericTypeDefinition() == typeof(global::System.Data.Entity.Core.Objects.ObjectQuery<>) || toClrType.GetGenericTypeDefinition() == typeof(global::System.Linq.IQueryable<>) || toClrType.GetGenericTypeDefinition() == typeof(global::System.Linq.IOrderedQueryable<>)) && fromClrType.GetGenericArguments()[0] == toClrType.GetGenericArguments()[0])
			{
				return null;
			}
			if (fromClrType != null && global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(fromClrType).IsEnum && toClrType == typeof(global::System.Enum))
			{
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (this.TryGetValueLayerType(toClrType, out typeUsage) && global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CanOmitCast(fromType, typeUsage, preserveCastForDateTime))
			{
				return null;
			}
			typeUsage = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ValidateAndAdjustCastTypes(typeUsage, fromType, toClrType, fromClrType);
			return typeUsage;
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x000B1544 File Offset: 0x000AF744
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateAndAdjustCastTypes(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Type toClrType, global::System.Type fromClrType)
		{
			if (toType == null || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(toType) || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(fromType))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedCast(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(fromClrType), global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(toClrType)));
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.Helper.AsPrimitive(fromType.EdmType).PrimitiveTypeKind;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.AsPrimitive(toType.EdmType).PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal)
			{
				if (primitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte && primitiveTypeKind - global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte > 3)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedCastToDecimal);
				}
				toType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)toType.EdmType, 19, 0);
			}
			return toType;
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x000B15CC File Offset: 0x000AF7CC
		private static bool CanOmitCast(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType, bool preserveCastForDateTime)
		{
			bool flag = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(fromType);
			if (flag && preserveCastForDateTime && ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)fromType.EdmType).PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime)
			{
				return false;
			}
			if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypeUsageEquals(fromType, toType))
			{
				return true;
			}
			if (flag)
			{
				return fromType.EdmType.EdmEquals(toType.EdmType);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(fromType, toType);
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x000B1624 File Offset: 0x000AF824
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetIsOrAsTargetType(global::System.Linq.Expressions.ExpressionType operationType, global::System.Type toClrType, global::System.Type fromClrType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (!this.TryGetValueLayerType(toClrType, out typeUsage) || (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(typeUsage)))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedIsOrAs(operationType, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(fromClrType), global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(toClrType)));
			}
			return typeUsage;
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x000B166C File Offset: 0x000AF86C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateInlineQueryOfT(global::System.Data.Entity.Core.Objects.ObjectQuery inlineQuery)
		{
			if (this._funcletizer.RootContext != inlineQuery.QueryState.ObjectContext)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedDifferentContexts);
			}
			if (this._inlineEntitySqlQueries == null)
			{
				this._inlineEntitySqlQueries = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.ObjectQuery>();
			}
			bool flag = this._inlineEntitySqlQueries.Add(inlineQuery);
			global::System.Data.Entity.Core.Objects.EntitySqlQueryState entitySqlQueryState = (global::System.Data.Entity.Core.Objects.EntitySqlQueryState)inlineQuery.QueryState;
			global::System.Data.Entity.Core.Objects.ObjectParameterCollection parameters = inlineQuery.QueryState.Parameters;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
			if (!this._funcletizer.IsCompiledQuery || parameters == null || parameters.Count == 0)
			{
				if (flag && parameters != null)
				{
					if (this._parameters == null)
					{
						this._parameters = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>>();
					}
					foreach (global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter in inlineQuery.QueryState.Parameters)
					{
						this._parameters.Add(new global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>(objectParameter.ShallowCopy(), null));
					}
				}
				dbExpression = entitySqlQueryState.Parse();
			}
			else
			{
				dbExpression = entitySqlQueryState.Parse();
				dbExpression = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ParameterReferenceRemover.RemoveParameterReferences(dbExpression, parameters);
			}
			return dbExpression;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x000B177C File Offset: 0x000AF97C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateCastExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Type toClrType, global::System.Type fromClrType)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.NormalizeSetSource(source);
			if (source != dbExpression && this.GetCastTargetType(dbExpression.ResultType, toClrType, fromClrType, true) == null)
			{
				return source;
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage castTargetType = this.GetCastTargetType(source.ResultType, toClrType, fromClrType, true);
			if (castTargetType == null)
			{
				return source;
			}
			return source.CastTo(castTargetType);
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x000B17C4 File Offset: 0x000AF9C4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateLambda(global::System.Linq.Expressions.LambdaExpression lambda, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
			input = this.NormalizeSetSource(input);
			binding = input.BindAs(this._aliasGenerator.Next());
			return this.TranslateLambda(lambda, binding.Variable);
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x000B17F0 File Offset: 0x000AF9F0
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateLambda(global::System.Linq.Expressions.LambdaExpression lambda, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, string bindingName, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
			input = this.NormalizeSetSource(input);
			binding = input.BindAs(bindingName);
			return this.TranslateLambda(lambda, binding.Variable);
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x000B1814 File Offset: 0x000AFA14
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateLambda(global::System.Linq.Expressions.LambdaExpression lambda, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, out global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding)
		{
			input = this.NormalizeSetSource(input);
			string text = this._aliasGenerator.Next();
			binding = input.GroupBindAs(text, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Group{0}", new object[]
			{
				text
			}));
			return this.TranslateLambda(lambda, binding.Variable);
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x000B1868 File Offset: 0x000AFA68
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateLambda(global::System.Linq.Expressions.LambdaExpression lambda, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input)
		{
			global::System.Data.Entity.Core.Objects.ELinq.Binding binding = new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambda.Parameters[0], input);
			this._bindingContext.PushBindingScope(binding);
			this._ignoreInclude++;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = this.TranslateExpression(lambda.Body);
			this._ignoreInclude--;
			this._bindingContext.PopBindingScope();
			return result;
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x000B18C8 File Offset: 0x000AFAC8
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression NormalizeSetSource(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input)
		{
			global::System.Data.Entity.Core.Objects.Span span;
			if (input.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project && !this.TryGetSpan(input, out span))
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)input;
				if (dbProjectExpression.Projection == dbProjectExpression.Input.Variable)
				{
					input = dbProjectExpression.Input.Expression;
				}
			}
			global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
			if (global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.TryGetInitializerMetadata(input.ResultType, out initializerMetadata))
			{
				if (initializerMetadata.Kind == global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.Grouping)
				{
					input = input.Property("Group");
				}
				else if (initializerMetadata.Kind == global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.EntityCollection)
				{
					input = input.Property("Elements");
				}
			}
			return input;
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x000B1950 File Offset: 0x000AFB50
		private global::System.Linq.Expressions.LambdaExpression GetLambdaExpression(global::System.Linq.Expressions.MethodCallExpression callExpression, int argumentOrdinal)
		{
			global::System.Linq.Expressions.Expression argument = callExpression.Arguments[argumentOrdinal];
			return (global::System.Linq.Expressions.LambdaExpression)this.GetLambdaExpression(argument);
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x000B1978 File Offset: 0x000AFB78
		private global::System.Linq.Expressions.Expression GetLambdaExpression(global::System.Linq.Expressions.Expression argument)
		{
			if (global::System.Linq.Expressions.ExpressionType.Lambda == argument.NodeType)
			{
				return argument;
			}
			if (global::System.Linq.Expressions.ExpressionType.Quote == argument.NodeType)
			{
				return this.GetLambdaExpression(((global::System.Linq.Expressions.UnaryExpression)argument).Operand);
			}
			if (global::System.Linq.Expressions.ExpressionType.Call == argument.NodeType)
			{
				if (typeof(global::System.Linq.Expressions.Expression).IsAssignableFrom(argument.Type))
				{
					global::System.Func<global::System.Linq.Expressions.Expression> func = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Linq.Expressions.Expression>>(argument, new global::System.Linq.Expressions.ParameterExpression[0]).Compile();
					return this.GetLambdaExpression(func());
				}
			}
			else if (global::System.Linq.Expressions.ExpressionType.Invoke == argument.NodeType && typeof(global::System.Linq.Expressions.Expression).IsAssignableFrom(argument.Type))
			{
				global::System.Func<global::System.Linq.Expressions.Expression> func2 = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Linq.Expressions.Expression>>(argument, new global::System.Linq.Expressions.ParameterExpression[0]).Compile();
				return this.GetLambdaExpression(func2());
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1025));
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x000B1A40 File Offset: 0x000AFC40
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateSet(global::System.Linq.Expressions.Expression linq)
		{
			return this.NormalizeSetSource(this.TranslateExpression(linq));
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x000B1A50 File Offset: 0x000AFC50
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateExpression(global::System.Linq.Expressions.Expression linq)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
			if (!this._bindingContext.TryGetBoundExpression(linq, out result))
			{
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator translator;
				if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter._translators.TryGetValue(linq.NodeType, out translator))
				{
					throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UnknownLinqNodeType, -1, linq.NodeType.ToString());
				}
				result = translator.Translate(this, linq);
			}
			return result;
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x000B1AB0 File Offset: 0x000AFCB0
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AlignTypes(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqt, global::System.Type toClrType)
		{
			global::System.Type fromClrType = null;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage castTargetType = this.GetCastTargetType(cqt.ResultType, toClrType, fromClrType, false);
			if (castTargetType != null)
			{
				return cqt.CastTo(castTargetType);
			}
			return cqt;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x000B1ADC File Offset: 0x000AFCDC
		private void CheckInitializerType(global::System.Type type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (this._funcletizer.RootContext.Perspective.TryGetType(type, out typeUsage))
			{
				global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = typeUsage.EdmType.BuiltInTypeKind;
				if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType == builtInTypeKind || global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType == builtInTypeKind)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedNominalType(typeUsage.EdmType.FullName));
				}
			}
			if (global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.IsSequenceType(type))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedEnumerableType(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(type)));
			}
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x000B1B48 File Offset: 0x000AFD48
		private static bool TypeUsageEquals(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage left, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage right)
		{
			if (left.EdmType.EdmEquals(right.EdmType))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == left.EdmType.BuiltInTypeKind && global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == right.EdmType.BuiltInTypeKind)
			{
				return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypeUsageEquals(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)left.EdmType).TypeUsage, ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)right.EdmType).TypeUsage);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType == left.EdmType.BuiltInTypeKind && global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType == right.EdmType.BuiltInTypeKind && ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)left.EdmType).ClrEquivalentType.Equals(((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)right.EdmType).ClrEquivalentType);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x000B1BF4 File Offset: 0x000AFDF4
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetValueLayerType(global::System.Type linqType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
			if (!this.TryGetValueLayerType(linqType, out result))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedType(linqType));
			}
			return result;
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x000B1C1C File Offset: 0x000AFE1C
		private bool TryGetValueLayerType(global::System.Type linqType, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Type type2 = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(linqType);
			if (type2.IsEnum() && this.EdmItemCollection.EdmVersion < 3.0)
			{
				type2 = type2.GetEnumUnderlyingType();
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			if (global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.TryGetPrimitiveTypeKind(type2, out primitiveTypeKind))
			{
				type = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(primitiveTypeKind);
				return true;
			}
			global::System.Type elementType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(type2);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType2;
			if (elementType != type2 && this.TryGetValueLayerType(elementType, out elementType2))
			{
				type = global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(elementType2);
				return true;
			}
			this._perspective.MetadataWorkspace.ImplicitLoadAssemblyForType(linqType, null);
			if (!this._perspective.TryGetTypeByName(type2.FullNameWithNesting(), false, out type) && type2.IsEnum() && global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.TryGetPrimitiveTypeKind(type2.GetEnumUnderlyingType(), out primitiveTypeKind))
			{
				type = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(primitiveTypeKind);
			}
			return type != null;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x000B1CE4 File Offset: 0x000AFEE4
		private static void VerifyTypeSupportedForComparison(global::System.Type clrType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType, global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> memberPath, bool isNullComparison)
		{
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.EdmType.BuiltInTypeKind;
			if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				if (builtInTypeKind - global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType > 1 && builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
				{
					goto IL_5F;
				}
			}
			else if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
			{
				if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
				{
					goto IL_5F;
				}
				global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
				if (!global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.TryGetInitializerMetadata(edmType, out initializerMetadata) || initializerMetadata.Kind == global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.ProjectionInitializer || initializerMetadata.Kind == global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.ProjectionNew)
				{
					if (!isNullComparison)
					{
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.VerifyRowTypeSupportedForComparison(clrType, (global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType.EdmType, memberPath, isNullComparison);
					}
					return;
				}
				goto IL_5F;
			}
			return;
			IL_5F:
			if (memberPath == null)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedComparison(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(clrType)));
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in memberPath)
			{
				stringBuilder.Append(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedRowMemberComparison(edmMember.Name));
			}
			stringBuilder.Append(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedRowTypeComparison(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(clrType)));
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedRowComparison(stringBuilder.ToString()));
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x000B1DDC File Offset: 0x000AFFDC
		private static void VerifyRowTypeSupportedForComparison(global::System.Type clrType, global::System.Data.Entity.Core.Metadata.Edm.RowType rowType, global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> memberPath, bool isNullComparison)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in rowType.Properties)
			{
				if (memberPath == null)
				{
					memberPath = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
				}
				memberPath.Push(edmMember);
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.VerifyTypeSupportedForComparison(clrType, edmMember.TypeUsage, memberPath, isNullComparison);
				memberPath.Pop();
			}
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x000B1E50 File Offset: 0x000B0050
		internal static string DescribeClrType(global::System.Type clrType)
		{
			if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.IsCSharpGeneratedClass(clrType.Name, "DisplayClass") || global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.IsVBGeneratedClass(clrType.Name, "Closure"))
			{
				return global::System.Data.Entity.Resources.Strings.ELinq_ClosureType;
			}
			if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.IsCSharpGeneratedClass(clrType.Name, "AnonymousType") || global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.IsVBGeneratedClass(clrType.Name, "AnonymousType"))
			{
				return global::System.Data.Entity.Resources.Strings.ELinq_AnonymousType;
			}
			return clrType.FullName;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x000B1EB7 File Offset: 0x000B00B7
		private static bool IsCSharpGeneratedClass(string typeName, string pattern)
		{
			return typeName.Contains("<>") && typeName.Contains("__") && typeName.Contains(pattern);
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x000B1EDC File Offset: 0x000B00DC
		private static bool IsVBGeneratedClass(string typeName, string pattern)
		{
			return typeName.Contains("_") && typeName.Contains("$") && typeName.Contains(pattern);
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x000B1F01 File Offset: 0x000B0101
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateIsNullExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Type operandClrType)
		{
			global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.VerifyTypeSupportedForComparison(operandClrType, operand.ResultType, null, true);
			return operand.IsNull();
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x000B1F18 File Offset: 0x000B0118
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateEqualsExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern, global::System.Type leftClrType, global::System.Type rightClrType)
		{
			global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.VerifyTypeSupportedForComparison(leftClrType, left.ResultType, null, false);
			global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.VerifyTypeSupportedForComparison(rightClrType, right.ResultType, null, false);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = left.ResultType;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType2 = right.ResultType;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (resultType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType && resultType2.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(resultType, resultType2, out typeUsage))
			{
				global::System.Data.Entity.Core.Metadata.Edm.RefType refType = left.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType;
				global::System.Data.Entity.Core.Metadata.Edm.RefType refType2 = right.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType;
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedRefComparison(refType.ElementType.FullName, refType2.ElementType.FullName));
			}
			return this.RecursivelyRewriteEqualsExpression(left, right, pattern);
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x000B1FC4 File Offset: 0x000B01C4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RecursivelyRewriteEqualsExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = left.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType2 = right.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
			if (rowType != null || rowType2 != null)
			{
				if (rowType != null && rowType2 != null)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyMetadata in rowType.Properties)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression left2 = left.Property(propertyMetadata);
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression right2 = right.Property(propertyMetadata);
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.RecursivelyRewriteEqualsExpression(left2, right2, pattern);
						if (dbExpression == null)
						{
							dbExpression = dbExpression2;
						}
						else
						{
							dbExpression = dbExpression.And(dbExpression2);
						}
					}
					return dbExpression;
				}
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False;
			}
			else
			{
				if (!this._funcletizer.RootContext.ContextOptions.UseCSharpNullComparisonBehavior)
				{
					return this.ImplementEquality(left, right, pattern);
				}
				return this.ImplementEquality(left, right, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.Store);
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x000B20A8 File Offset: 0x000B02A8
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ImplementEquality(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = left.ExpressionKind;
			if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind2 = right.ExpressionKind;
					if (expressionKind2 == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return this.ImplementEqualityConstantAndUnknown((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)right, left, pattern);
					}
					if (expressionKind2 != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null)
					{
						return this.ImplementEqualityUnknownArguments(left, right, pattern);
					}
					return left.IsNull();
				}
				else
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind2 = right.ExpressionKind;
					if (expressionKind2 == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False;
					}
					if (expressionKind2 != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null)
					{
						return right.IsNull();
					}
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True;
				}
			}
			else
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind2 = right.ExpressionKind;
				if (expressionKind2 == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
				{
					return left.Equal(right);
				}
				if (expressionKind2 != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null)
				{
					return this.ImplementEqualityConstantAndUnknown((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)left, right, pattern);
				}
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False;
			}
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x000B214C File Offset: 0x000B034C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ImplementEqualityConstantAndUnknown(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression constant, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression unknown, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern)
		{
			if (pattern <= global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityNonComposable)
			{
				return constant.Equal(unknown);
			}
			if (pattern != global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityComposable)
			{
				return null;
			}
			if (!this._funcletizer.RootContext.ContextOptions.UseCSharpNullComparisonBehavior)
			{
				return constant.Equal(unknown);
			}
			return constant.Equal(unknown).And(unknown.IsNull().Not());
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x000B21A4 File Offset: 0x000B03A4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ImplementEqualityUnknownArguments(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern)
		{
			switch (pattern)
			{
			case global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.Store:
				return left.Equal(right);
			case global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityNonComposable:
				return left.Equal(right).Or(left.IsNull().And(right.IsNull()));
			case global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityComposable:
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression left2 = left.Equal(right);
				global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression right2 = left.IsNull().And(right.IsNull());
				if (!this._funcletizer.RootContext.ContextOptions.UseCSharpNullComparisonBehavior)
				{
					return left2.Or(right2);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression argument = left.IsNull().Or(right.IsNull());
				return left2.And(argument.Not()).Or(right2);
			}
			default:
				return null;
			}
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x000B2250 File Offset: 0x000B0450
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateLike(global::System.Linq.Expressions.MethodCallExpression call)
		{
			char c;
			bool flag = this.ProviderManifest.SupportsEscapingLikeArgument(out c);
			global::System.Linq.Expressions.Expression linq = call.Arguments[0];
			global::System.Linq.Expressions.Expression linq2 = call.Arguments[1];
			global::System.Linq.Expressions.Expression expression = (call.Arguments.Count > 2) ? call.Arguments[2] : null;
			if (!flag && expression != null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDoesNotSupportEscapingLikeArgument);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pattern = this.TranslateExpression(linq2);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression escape = (expression != null) ? this.TranslateExpression(expression) : null;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument = this.TranslateExpression(linq);
			if (expression == null)
			{
				return argument.Like(pattern);
			}
			return argument.Like(pattern, escape);
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x000B22EC File Offset: 0x000B04EC
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateFunctionIntoLike(global::System.Linq.Expressions.MethodCallExpression call, bool insertPercentAtStart, bool insertPercentAtEnd, global::System.Func<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter, global::System.Linq.Expressions.MethodCallExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> defaultTranslator)
		{
			char c;
			bool flag = this.ProviderManifest.SupportsEscapingLikeArgument(out c);
			bool flag2 = false;
			bool flag3 = true;
			global::System.Linq.Expressions.Expression expression = call.Arguments[0];
			global::System.Linq.Expressions.Expression @object = call.Object;
			global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression queryParameterExpression = expression as global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression;
			if (flag && queryParameterExpression != null)
			{
				flag2 = true;
				global::System.Reflection.MethodInfo method = typeof(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter).GetMethod("PreparePattern", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic);
				global::System.Linq.Expressions.ParameterExpression parameterExpression;
				global::System.Linq.Expressions.Expression<global::System.Func<string, global::System.Tuple<string, bool>>> method2 = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string, global::System.Tuple<string, bool>>>(global::System.Linq.Expressions.Expression.Call(method, parameterExpression, global::System.Linq.Expressions.Expression.Constant(insertPercentAtStart), global::System.Linq.Expressions.Expression.Constant(insertPercentAtEnd), global::System.Linq.Expressions.Expression.Constant(this.ProviderManifest)), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression
				});
				expression = queryParameterExpression.EscapeParameterForLike(method2);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.TranslateExpression(expression);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.TranslateExpression(@object);
			if (flag && dbExpression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				flag2 = true;
				global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)dbExpression;
				global::System.Tuple<string, bool> tuple = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.PreparePattern((string)dbConstantExpression.Value, insertPercentAtStart, insertPercentAtEnd, this.ProviderManifest);
				string item = tuple.Item1;
				flag3 = tuple.Item2;
				dbExpression = dbConstantExpression.ResultType.Constant(item);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
			if (flag2)
			{
				if (flag3)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression escape = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String).Constant(new string(new char[]
					{
						c
					}));
					result = dbExpression2.Like(dbExpression, escape);
				}
				else
				{
					result = dbExpression2.Like(dbExpression);
				}
			}
			else
			{
				result = defaultTranslator(this, call, dbExpression, dbExpression2);
			}
			return result;
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x000B2458 File Offset: 0x000B0658
		private static global::System.Tuple<string, bool> PreparePattern(string patternValue, bool insertPercentAtStart, bool insertPercentAtEnd, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (patternValue == null)
			{
				return new global::System.Tuple<string, bool>(null, false);
			}
			string text = providerManifest.EscapeLikeArgument(patternValue);
			if (text == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderEscapeLikeArgumentReturnedNull);
			}
			bool item = patternValue != text;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (insertPercentAtStart)
			{
				stringBuilder.Append("%");
			}
			stringBuilder.Append(text);
			if (insertPercentAtEnd)
			{
				stringBuilder.Append("%");
			}
			return new global::System.Tuple<string, bool>(stringBuilder.ToString(), item);
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x000B24C8 File Offset: 0x000B06C8
		private global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression TranslateIntoCanonicalFunction(string functionName, global::System.Linq.Expressions.Expression Expression, params global::System.Linq.Expressions.Expression[] linqArguments)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] array = new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[linqArguments.Length];
			for (int i = 0; i < linqArguments.Length; i++)
			{
				array[i] = this.TranslateExpression(linqArguments[i]);
			}
			return this.CreateCanonicalFunction(functionName, Expression, array);
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x000B2504 File Offset: 0x000B0704
		private global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CreateCanonicalFunction(string functionName, global::System.Linq.Expressions.Expression Expression, params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] translatedArguments)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(translatedArguments.Length);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in translatedArguments)
			{
				list.Add(dbExpression.ResultType);
			}
			return this.FindCanonicalFunction(functionName, list, false, Expression).Invoke(translatedArguments);
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x000B254A File Offset: 0x000B074A
		private global::System.Data.Entity.Core.Metadata.Edm.EdmFunction FindCanonicalFunction(string functionName, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argumentTypes, bool isGroupAggregateFunction, global::System.Linq.Expressions.Expression Expression)
		{
			return this.FindFunction("Edm", functionName, argumentTypes, isGroupAggregateFunction, Expression);
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x000B255C File Offset: 0x000B075C
		private global::System.Data.Entity.Core.Metadata.Edm.EdmFunction FindFunction(string namespaceName, string functionName, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argumentTypes, bool isGroupAggregateFunction, global::System.Linq.Expressions.Expression Expression)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionsMetadata;
			if (!this._perspective.TryGetFunctionByName(namespaceName, functionName, false, out functionsMetadata))
			{
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ThrowUnresolvableFunction(Expression);
			}
			bool flag;
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.ResolveFunctionOverloads(functionsMetadata, argumentTypes, isGroupAggregateFunction, out flag);
			if (flag || edmFunction == null)
			{
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ThrowUnresolvableFunctionOverload(Expression, flag);
			}
			return edmFunction;
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x000B25A0 File Offset: 0x000B07A0
		private static void ThrowUnresolvableFunction(global::System.Linq.Expressions.Expression Expression)
		{
			if (Expression.NodeType == global::System.Linq.Expressions.ExpressionType.Call)
			{
				global::System.Reflection.MethodInfo method = ((global::System.Linq.Expressions.MethodCallExpression)Expression).Method;
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnresolvableFunctionForMethod(method, method.DeclaringType));
			}
			if (Expression.NodeType == global::System.Linq.Expressions.ExpressionType.MemberAccess)
			{
				string text;
				global::System.Type type;
				global::System.Reflection.MemberInfo memberInfo = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.PropertyOrField(((global::System.Linq.Expressions.MemberExpression)Expression).Member, out text, out type);
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnresolvableFunctionForMember(memberInfo, memberInfo.DeclaringType));
			}
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnresolvableFunctionForExpression(Expression.NodeType));
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x000B261C File Offset: 0x000B081C
		private static void ThrowUnresolvableFunctionOverload(global::System.Linq.Expressions.Expression Expression, bool isAmbiguous)
		{
			if (Expression.NodeType == global::System.Linq.Expressions.ExpressionType.Call)
			{
				global::System.Reflection.MethodInfo method = ((global::System.Linq.Expressions.MethodCallExpression)Expression).Method;
				if (isAmbiguous)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnresolvableFunctionForMethodAmbiguousMatch(method, method.DeclaringType));
				}
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnresolvableFunctionForMethodNotFound(method, method.DeclaringType));
			}
			else
			{
				if (Expression.NodeType == global::System.Linq.Expressions.ExpressionType.MemberAccess)
				{
					string text;
					global::System.Type type;
					global::System.Reflection.MemberInfo memberInfo = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.PropertyOrField(((global::System.Linq.Expressions.MemberExpression)Expression).Member, out text, out type);
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnresolvableStoreFunctionForMember(memberInfo, memberInfo.DeclaringType));
				}
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnresolvableStoreFunctionForExpression(Expression.NodeType));
			}
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x000B26AC File Offset: 0x000B08AC
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression CreateNewRowExpression(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> columns, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(columns.Count);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(columns.Count);
			for (int i = 0; i < columns.Count; i++)
			{
				global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValuePair = columns[i];
				list.Add(keyValuePair.Value);
				list2.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(keyValuePair.Key, keyValuePair.Value.ResultType));
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.RowType(list2, initializerMetadata)).New(list);
		}

		// Token: 0x040011DA RID: 4570
		private readonly global::System.Data.Entity.Core.Objects.ELinq.Funcletizer _funcletizer;

		// Token: 0x040011DB RID: 4571
		private readonly global::System.Data.Entity.Core.Metadata.Edm.Perspective _perspective;

		// Token: 0x040011DC RID: 4572
		private readonly global::System.Linq.Expressions.Expression _expression;

		// Token: 0x040011DD RID: 4573
		private readonly global::System.Data.Entity.Core.Objects.ELinq.BindingContext _bindingContext;

		// Token: 0x040011DE RID: 4574
		private global::System.Func<bool> _recompileRequired;

		// Token: 0x040011DF RID: 4575
		private global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>> _parameters;

		// Token: 0x040011E0 RID: 4576
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Objects.Span> _spanMappings;

		// Token: 0x040011E1 RID: 4577
		private global::System.Data.Entity.Core.Objects.MergeOption? _mergeOption;

		// Token: 0x040011E2 RID: 4578
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata> _initializers;

		// Token: 0x040011E3 RID: 4579
		private global::System.Data.Entity.Core.Objects.Span _span;

		// Token: 0x040011E4 RID: 4580
		private global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.ObjectQuery> _inlineEntitySqlQueries;

		// Token: 0x040011E5 RID: 4581
		private int _ignoreInclude;

		// Token: 0x040011E6 RID: 4582
		private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _aliasGenerator = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("LQ", 0);

		// Token: 0x040011E7 RID: 4583
		private readonly global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter _orderByLifter;

		// Token: 0x040011E8 RID: 4584
		private const string s_visualBasicAssemblyFullName = "Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		// Token: 0x040011E9 RID: 4585
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ExpressionType, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator> _translators = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.InitializeTranslators();

		// Token: 0x040011EA RID: 4586
		internal const string KeyColumnName = "Key";

		// Token: 0x040011EB RID: 4587
		internal const string GroupColumnName = "Group";

		// Token: 0x040011EC RID: 4588
		internal const string EntityCollectionOwnerColumnName = "Owner";

		// Token: 0x040011ED RID: 4589
		internal const string EntityCollectionElementsColumnName = "Elements";

		// Token: 0x040011EE RID: 4590
		internal const string EdmNamespaceName = "Edm";

		// Token: 0x040011EF RID: 4591
		private const string Concat = "Concat";

		// Token: 0x040011F0 RID: 4592
		private const string IndexOf = "IndexOf";

		// Token: 0x040011F1 RID: 4593
		private const string Length = "Length";

		// Token: 0x040011F2 RID: 4594
		private const string Right = "Right";

		// Token: 0x040011F3 RID: 4595
		private const string Substring = "Substring";

		// Token: 0x040011F4 RID: 4596
		private const string ToUpper = "ToUpper";

		// Token: 0x040011F5 RID: 4597
		private const string ToLower = "ToLower";

		// Token: 0x040011F6 RID: 4598
		private const string Trim = "Trim";

		// Token: 0x040011F7 RID: 4599
		private const string LTrim = "LTrim";

		// Token: 0x040011F8 RID: 4600
		private const string RTrim = "RTrim";

		// Token: 0x040011F9 RID: 4601
		private const string Reverse = "Reverse";

		// Token: 0x040011FA RID: 4602
		private const string BitwiseAnd = "BitwiseAnd";

		// Token: 0x040011FB RID: 4603
		private const string BitwiseOr = "BitwiseOr";

		// Token: 0x040011FC RID: 4604
		private const string BitwiseNot = "BitwiseNot";

		// Token: 0x040011FD RID: 4605
		private const string BitwiseXor = "BitwiseXor";

		// Token: 0x040011FE RID: 4606
		private const string CurrentUtcDateTime = "CurrentUtcDateTime";

		// Token: 0x040011FF RID: 4607
		private const string CurrentDateTimeOffset = "CurrentDateTimeOffset";

		// Token: 0x04001200 RID: 4608
		private const string CurrentDateTime = "CurrentDateTime";

		// Token: 0x04001201 RID: 4609
		private const string Year = "Year";

		// Token: 0x04001202 RID: 4610
		private const string Month = "Month";

		// Token: 0x04001203 RID: 4611
		private const string Day = "Day";

		// Token: 0x04001204 RID: 4612
		private const string Hour = "Hour";

		// Token: 0x04001205 RID: 4613
		private const string Minute = "Minute";

		// Token: 0x04001206 RID: 4614
		private const string Second = "Second";

		// Token: 0x04001207 RID: 4615
		private const string Millisecond = "Millisecond";

		// Token: 0x04001208 RID: 4616
		private const string Like = "Like";

		// Token: 0x04001209 RID: 4617
		private const string AsUnicode = "AsUnicode";

		// Token: 0x0400120A RID: 4618
		private const string AsNonUnicode = "AsNonUnicode";

		// Token: 0x02000A72 RID: 2674
		private class ParameterReferenceRemover : global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor
		{
			// Token: 0x06006207 RID: 25095 RVA: 0x0015315D File Offset: 0x0015135D
			internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RemoveParameterReferences(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Objects.ObjectParameterCollection availableParameters)
			{
				return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.ParameterReferenceRemover(availableParameters).VisitExpression(expression);
			}

			// Token: 0x06006208 RID: 25096 RVA: 0x0015316B File Offset: 0x0015136B
			private ParameterReferenceRemover(global::System.Data.Entity.Core.Objects.ObjectParameterCollection availableParams)
			{
				this.objectParameters = availableParams;
			}

			// Token: 0x06006209 RID: 25097 RVA: 0x0015317C File Offset: 0x0015137C
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
				if (!this.objectParameters.Contains(expression.ParameterName))
				{
					return expression;
				}
				global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter = this.objectParameters[expression.ParameterName];
				if (objectParameter.Value == null)
				{
					return expression.ResultType.Null();
				}
				return expression.ResultType.Constant(objectParameter.Value);
			}

			// Token: 0x04002B27 RID: 11047
			private readonly global::System.Data.Entity.Core.Objects.ObjectParameterCollection objectParameters;
		}

		// Token: 0x02000A73 RID: 2675
		private enum EqualsPattern
		{
			// Token: 0x04002B29 RID: 11049
			Store,
			// Token: 0x04002B2A RID: 11050
			PositiveNullEqualityNonComposable,
			// Token: 0x04002B2B RID: 11051
			PositiveNullEqualityComposable
		}

		// Token: 0x02000A74 RID: 2676
		internal sealed class MethodCallTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.MethodCallExpression>
		{
			// Token: 0x0600620A RID: 25098 RVA: 0x001531E1 File Offset: 0x001513E1
			internal MethodCallTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Call
			})
			{
			}

			// Token: 0x0600620B RID: 25099 RVA: 0x001531F4 File Offset: 0x001513F4
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression linq)
			{
				global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod;
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator sequenceMethodTranslator;
				if (global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.TryIdentifySequenceMethod(linq.Method, out sequenceMethod) && global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._sequenceTranslators.TryGetValue(sequenceMethod, out sequenceMethodTranslator))
				{
					return sequenceMethodTranslator.Translate(parent, linq, sequenceMethod);
				}
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator callTranslator;
				if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TryGetCallTranslator(linq.Method, out callTranslator))
				{
					return callTranslator.Translate(parent, linq);
				}
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator objectQueryCallTranslator;
				if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator.IsCandidateMethod(linq.Method) && global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._objectQueryTranslators.TryGetValue(linq.Method.Name, out objectQueryCallTranslator))
				{
					return objectQueryCallTranslator.Translate(parent, linq);
				}
				global::System.Data.Entity.DbFunctionAttribute dbFunctionAttribute = linq.Method.GetCustomAttributes(false).FirstOrDefault<global::System.Data.Entity.DbFunctionAttribute>();
				if (dbFunctionAttribute != null)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._functionCallTranslator.TranslateFunctionCall(parent, linq, dbFunctionAttribute);
				}
				string name = linq.Method.Name;
				global::System.Type[] array;
				if (name != null && name == "Contains" && linq.Method.GetParameters().Count<global::System.Reflection.ParameterInfo>() == 1 && linq.Method.ReturnType.Equals(typeof(bool)) && linq.Method.IsImplementationOfGenericInterfaceMethod(typeof(global::System.Collections.Generic.ICollection<>), out array))
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator.TranslateContains(parent, linq.Object, linq.Arguments[0]);
				}
				return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._defaultTranslator.Translate(parent, linq);
			}

			// Token: 0x0600620C RID: 25100 RVA: 0x00153320 File Offset: 0x00151520
			private static global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator> InitializeMethodTranslators()
			{
				global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator>();
				foreach (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator callTranslator in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GetCallTranslators())
				{
					foreach (global::System.Reflection.MethodInfo key in callTranslator.Methods)
					{
						dictionary.Add(key, callTranslator);
					}
				}
				return dictionary;
			}

			// Token: 0x0600620D RID: 25101 RVA: 0x001533AC File Offset: 0x001515AC
			private static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator> InitializeSequenceMethodTranslators()
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator>();
				foreach (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator sequenceMethodTranslator in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GetSequenceMethodTranslators())
				{
					foreach (global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod key in sequenceMethodTranslator.Methods)
					{
						dictionary.Add(key, sequenceMethodTranslator);
					}
				}
				return dictionary;
			}

			// Token: 0x0600620E RID: 25102 RVA: 0x00153438 File Offset: 0x00151638
			private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator> InitializeObjectQueryTranslators()
			{
				global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator>(global::System.StringComparer.Ordinal);
				foreach (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator objectQueryCallTranslator in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GetObjectQueryCallTranslators())
				{
					dictionary[objectQueryCallTranslator.MethodName] = objectQueryCallTranslator;
				}
				return dictionary;
			}

			// Token: 0x0600620F RID: 25103 RVA: 0x00153498 File Offset: 0x00151698
			private static bool TryGetCallTranslator(global::System.Reflection.MethodInfo methodInfo, out global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator callTranslator)
			{
				if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._methodTranslators.TryGetValue(methodInfo, out callTranslator))
				{
					return true;
				}
				if ("Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" == methodInfo.DeclaringType.Assembly().FullName)
				{
					object vbInitializerLock = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._vbInitializerLock;
					lock (vbInitializerLock)
					{
						if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.s_vbMethodsInitialized)
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.InitializeVBMethods(methodInfo.DeclaringType.Assembly());
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.s_vbMethodsInitialized = true;
						}
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._methodTranslators.TryGetValue(methodInfo, out callTranslator);
					}
				}
				callTranslator = null;
				return false;
			}

			// Token: 0x06006210 RID: 25104 RVA: 0x00153530 File Offset: 0x00151730
			private static void InitializeVBMethods(global::System.Reflection.Assembly vbAssembly)
			{
				foreach (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator callTranslator in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GetVisualBasicCallTranslators(vbAssembly))
				{
					foreach (global::System.Reflection.MethodInfo key in callTranslator.Methods)
					{
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._methodTranslators.Add(key, callTranslator);
					}
				}
			}

			// Token: 0x06006211 RID: 25105 RVA: 0x001535B8 File Offset: 0x001517B8
			private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator> GetVisualBasicCallTranslators(global::System.Reflection.Assembly vbAssembly)
			{
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionDefaultTranslator(vbAssembly);
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionRenameTranslator(vbAssembly);
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBDatePartTranslator(vbAssembly);
				yield break;
			}

			// Token: 0x06006212 RID: 25106 RVA: 0x001535C8 File Offset: 0x001517C8
			private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator> GetCallTranslators()
			{
				return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator[]
				{
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CanonicalFunctionDefaultTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AsUnicodeFunctionTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AsNonUnicodeFunctionTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.MathTruncateTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.MathPowerTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GuidNewGuidTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.LikeFunctionTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.StringContainsTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.StartsWithTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.EndsWithTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.IndexOfTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SubstringTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.RemoveTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.InsertTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.IsNullOrEmptyTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.StringConcatTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimStartTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimEndTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HasFlagTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ToStringTranslator()
				};
			}

			// Token: 0x06006213 RID: 25107 RVA: 0x001536A2 File Offset: 0x001518A2
			private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator> GetSequenceMethodTranslators()
			{
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ConcatTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.UnionTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.IntersectTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ExceptTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.DistinctTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.WhereTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SelectTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OrderByTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OrderByDescendingTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ThenByTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ThenByDescendingTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SelectManyTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AnyTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AnyPredicateTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AllTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.JoinTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GroupByTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.MaxTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.MinTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AverageTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SumTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CountTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.LongCountTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CastMethodTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GroupJoinTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OfTypeTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.PassthroughTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.DefaultIfEmptyTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstPredicateTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstOrDefaultTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstOrDefaultPredicateTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TakeTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SkipTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SingleTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SinglePredicateTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SingleOrDefaultTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SingleOrDefaultPredicateTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator();
				yield break;
			}

			// Token: 0x06006214 RID: 25108 RVA: 0x001536AB File Offset: 0x001518AB
			private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator> GetObjectQueryCallTranslators()
			{
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderDistinctTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderExceptTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderFirstTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderToListTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryIncludeTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderIntersectTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderOfTypeTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderUnionTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryMergeAsTranslator();
				yield return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryIncludeSpanTranslator();
				yield break;
			}

			// Token: 0x06006215 RID: 25109 RVA: 0x001536B4 File Offset: 0x001518B4
			private static bool IsTrivialRename(global::System.Linq.Expressions.LambdaExpression selectorLambda, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter converter, out string leftName, out string rightName, out global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata)
			{
				leftName = null;
				rightName = null;
				initializerMetadata = null;
				if (selectorLambda.Parameters.Count != 2 || selectorLambda.Body.NodeType != global::System.Linq.Expressions.ExpressionType.New)
				{
					return false;
				}
				global::System.Linq.Expressions.NewExpression newExpression = (global::System.Linq.Expressions.NewExpression)selectorLambda.Body;
				if (newExpression.Arguments.Count != 2)
				{
					return false;
				}
				if (newExpression.Arguments[0] != selectorLambda.Parameters[0] || newExpression.Arguments[1] != selectorLambda.Parameters[1])
				{
					return false;
				}
				leftName = newExpression.Members[0].Name;
				rightName = newExpression.Members[1].Name;
				initializerMetadata = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.CreateProjectionInitializer(converter.EdmItemCollection, newExpression);
				converter.ValidateInitializerMetadata(initializerMetadata);
				return true;
			}

			// Token: 0x04002B2C RID: 11052
			private const string s_stringsTypeFullName = "Microsoft.VisualBasic.Strings";

			// Token: 0x04002B2D RID: 11053
			private static readonly global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator _defaultTranslator = new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.DefaultTranslator();

			// Token: 0x04002B2E RID: 11054
			private static readonly global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FunctionCallTranslator _functionCallTranslator = new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FunctionCallTranslator();

			// Token: 0x04002B2F RID: 11055
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator> _methodTranslators = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.InitializeMethodTranslators();

			// Token: 0x04002B30 RID: 11056
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator> _sequenceTranslators = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.InitializeSequenceMethodTranslators();

			// Token: 0x04002B31 RID: 11057
			private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator> _objectQueryTranslators = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.InitializeObjectQueryTranslators();

			// Token: 0x04002B32 RID: 11058
			private static bool s_vbMethodsInitialized;

			// Token: 0x04002B33 RID: 11059
			private static readonly object _vbInitializerLock = new object();

			// Token: 0x02000CE7 RID: 3303
			internal sealed class HierarchyIdMethodCallTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D1F RID: 27935 RVA: 0x00172DC8 File Offset: 0x00170FC8
				internal HierarchyIdMethodCallTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetSupportedMethods())
				{
				}

				// Token: 0x06006D20 RID: 27936 RVA: 0x00172DD5 File Offset: 0x00170FD5
				private static global::System.Reflection.MethodInfo GetStaticMethod<TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TResult>> lambda)
				{
					return ((global::System.Linq.Expressions.MethodCallExpression)lambda.Body).Method;
				}

				// Token: 0x06006D21 RID: 27937 RVA: 0x00172DE7 File Offset: 0x00170FE7
				private static global::System.Reflection.MethodInfo GetInstanceMethod<T, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<T, TResult>> lambda)
				{
					return ((global::System.Linq.Expressions.MethodCallExpression)lambda.Body).Method;
				}

				// Token: 0x06006D22 RID: 27938 RVA: 0x00172DF9 File Offset: 0x00170FF9
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetSupportedMethods()
				{
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Hierarchy.HierarchyId>(() => global::System.Data.Entity.Hierarchy.HierarchyId.GetRoot());
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Hierarchy.HierarchyId>(() => global::System.Data.Entity.Hierarchy.HierarchyId.Parse(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, global::System.Data.Entity.Hierarchy.HierarchyId>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.GetAncestor(0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, global::System.Data.Entity.Hierarchy.HierarchyId>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.GetDescendant(null, null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, short>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.GetLevel());
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, bool>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.IsDescendantOf(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, global::System.Data.Entity.Hierarchy.HierarchyId>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.GetReparentedValue(null, null));
					yield break;
				}

				// Token: 0x06006D23 RID: 27939 RVA: 0x00172E04 File Offset: 0x00171004
				private static global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, string> GetRenamedMethodFunctions()
				{
					return new global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, string>
					{
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Hierarchy.HierarchyId>(() => global::System.Data.Entity.Hierarchy.HierarchyId.GetRoot()),
							"HierarchyIdGetRoot"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Hierarchy.HierarchyId>(() => global::System.Data.Entity.Hierarchy.HierarchyId.Parse(null)),
							"HierarchyIdParse"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, global::System.Data.Entity.Hierarchy.HierarchyId>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.GetAncestor(0)),
							"GetAncestor"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, global::System.Data.Entity.Hierarchy.HierarchyId>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.GetDescendant(null, null)),
							"GetDescendant"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, short>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.GetLevel()),
							"GetLevel"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, bool>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.IsDescendantOf(null)),
							"IsDescendantOf"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Hierarchy.HierarchyId, global::System.Data.Entity.Hierarchy.HierarchyId>((global::System.Data.Entity.Hierarchy.HierarchyId h) => h.GetReparentedValue(null, null)),
							"GetReparentedValue"
						}
					};
				}

				// Token: 0x06006D24 RID: 27940 RVA: 0x0017309C File Offset: 0x0017129C
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Reflection.MethodInfo method = call.Method;
					string name;
					if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator._methodFunctionRenames.TryGetValue(method, out name))
					{
						name = method.Name;
					}
					global::System.Linq.Expressions.Expression[] linqArguments;
					if (method.IsStatic)
					{
						linqArguments = call.Arguments.ToArray<global::System.Linq.Expressions.Expression>();
					}
					else
					{
						linqArguments = new global::System.Linq.Expressions.Expression[]
						{
							call.Object
						}.Concat(call.Arguments).ToArray<global::System.Linq.Expressions.Expression>();
					}
					return parent.TranslateIntoCanonicalFunction(name, call, linqArguments);
				}

				// Token: 0x04003280 RID: 12928
				private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, string> _methodFunctionRenames = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HierarchyIdMethodCallTranslator.GetRenamedMethodFunctions();
			}

			// Token: 0x02000CE8 RID: 3304
			internal abstract class CallTranslator
			{
				// Token: 0x06006D26 RID: 27942 RVA: 0x00173111 File Offset: 0x00171311
				protected CallTranslator(params global::System.Reflection.MethodInfo[] methods)
				{
					this._methods = methods;
				}

				// Token: 0x06006D27 RID: 27943 RVA: 0x00173120 File Offset: 0x00171320
				protected CallTranslator(global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> methods)
				{
					this._methods = methods;
				}

				// Token: 0x170011A0 RID: 4512
				// (get) Token: 0x06006D28 RID: 27944 RVA: 0x0017312F File Offset: 0x0017132F
				internal global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> Methods
				{
					get
					{
						return this._methods;
					}
				}

				// Token: 0x06006D29 RID: 27945
				internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call);

				// Token: 0x06006D2A RID: 27946 RVA: 0x00173137 File Offset: 0x00171337
				public override string ToString()
				{
					return base.GetType().Name;
				}

				// Token: 0x04003281 RID: 12929
				private readonly global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> _methods;
			}

			// Token: 0x02000CE9 RID: 3305
			private abstract class ObjectQueryCallTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D2B RID: 27947 RVA: 0x00173144 File Offset: 0x00171344
				internal static bool IsCandidateMethod(global::System.Reflection.MethodInfo method)
				{
					global::System.Type declaringType = method.DeclaringType;
					return (method.IsPublic || (method.IsAssembly && (method.Name == "MergeAs" || method.Name == "IncludeSpan"))) && null != declaringType && declaringType.IsGenericType() && typeof(global::System.Data.Entity.Core.Objects.ObjectQuery<>) == declaringType.GetGenericTypeDefinition();
				}

				// Token: 0x06006D2C RID: 27948 RVA: 0x001731B4 File Offset: 0x001713B4
				internal static global::System.Linq.Expressions.Expression RemoveConvertToObjectQuery(global::System.Linq.Expressions.Expression queryExpression)
				{
					if (queryExpression.NodeType == global::System.Linq.Expressions.ExpressionType.Convert)
					{
						global::System.Linq.Expressions.UnaryExpression unaryExpression = (global::System.Linq.Expressions.UnaryExpression)queryExpression;
						global::System.Type type = unaryExpression.Operand.Type;
						if (type.IsGenericType() && (typeof(global::System.Linq.IQueryable<>) == type.GetGenericTypeDefinition() || typeof(global::System.Linq.IOrderedQueryable<>) == type.GetGenericTypeDefinition()))
						{
							queryExpression = unaryExpression.Operand;
						}
					}
					return queryExpression;
				}

				// Token: 0x06006D2D RID: 27949 RVA: 0x0017321D File Offset: 0x0017141D
				protected ObjectQueryCallTranslator(string methodName) : base(new global::System.Reflection.MethodInfo[0])
				{
					this._methodName = methodName;
				}

				// Token: 0x170011A1 RID: 4513
				// (get) Token: 0x06006D2E RID: 27950 RVA: 0x00173232 File Offset: 0x00171432
				internal string MethodName
				{
					get
					{
						return this._methodName;
					}
				}

				// Token: 0x04003282 RID: 12930
				private readonly string _methodName;
			}

			// Token: 0x02000CEA RID: 3306
			private abstract class ObjectQueryBuilderCallTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator
			{
				// Token: 0x06006D2F RID: 27951 RVA: 0x0017323A File Offset: 0x0017143A
				protected ObjectQueryBuilderCallTranslator(string methodName, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceEquivalent) : base(methodName)
				{
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator._sequenceTranslators.TryGetValue(sequenceEquivalent, out this._translator);
				}

				// Token: 0x06006D30 RID: 27952 RVA: 0x00173255 File Offset: 0x00171455
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return this._translator.Translate(parent, call);
				}

				// Token: 0x04003283 RID: 12931
				private readonly global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator _translator;
			}

			// Token: 0x02000CEB RID: 3307
			private sealed class ObjectQueryBuilderUnionTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderCallTranslator
			{
				// Token: 0x06006D31 RID: 27953 RVA: 0x00173264 File Offset: 0x00171464
				internal ObjectQueryBuilderUnionTranslator() : base("Union", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Union)
				{
				}
			}

			// Token: 0x02000CEC RID: 3308
			private sealed class ObjectQueryBuilderIntersectTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderCallTranslator
			{
				// Token: 0x06006D32 RID: 27954 RVA: 0x00173273 File Offset: 0x00171473
				internal ObjectQueryBuilderIntersectTranslator() : base("Intersect", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Intersect)
				{
				}
			}

			// Token: 0x02000CED RID: 3309
			private sealed class ObjectQueryBuilderExceptTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderCallTranslator
			{
				// Token: 0x06006D33 RID: 27955 RVA: 0x00173282 File Offset: 0x00171482
				internal ObjectQueryBuilderExceptTranslator() : base("Except", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Except)
				{
				}
			}

			// Token: 0x02000CEE RID: 3310
			private sealed class ObjectQueryBuilderDistinctTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderCallTranslator
			{
				// Token: 0x06006D34 RID: 27956 RVA: 0x00173291 File Offset: 0x00171491
				internal ObjectQueryBuilderDistinctTranslator() : base("Distinct", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Distinct)
				{
				}
			}

			// Token: 0x02000CEF RID: 3311
			private sealed class ObjectQueryBuilderOfTypeTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderCallTranslator
			{
				// Token: 0x06006D35 RID: 27957 RVA: 0x001732A0 File Offset: 0x001714A0
				internal ObjectQueryBuilderOfTypeTranslator() : base("OfType", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OfType)
				{
				}
			}

			// Token: 0x02000CF0 RID: 3312
			private sealed class ObjectQueryBuilderFirstTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderCallTranslator
			{
				// Token: 0x06006D36 RID: 27958 RVA: 0x001732AE File Offset: 0x001714AE
				internal ObjectQueryBuilderFirstTranslator() : base("First", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.First)
				{
				}
			}

			// Token: 0x02000CF1 RID: 3313
			private sealed class ObjectQueryBuilderToListTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryBuilderCallTranslator
			{
				// Token: 0x06006D37 RID: 27959 RVA: 0x001732BD File Offset: 0x001714BD
				internal ObjectQueryBuilderToListTranslator() : base("ToList", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ToList)
				{
				}
			}

			// Token: 0x02000CF2 RID: 3314
			private sealed class ObjectQueryIncludeTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator
			{
				// Token: 0x06006D38 RID: 27960 RVA: 0x001732CF File Offset: 0x001714CF
				internal ObjectQueryIncludeTranslator() : base("Include")
				{
				}

				// Token: 0x06006D39 RID: 27961 RVA: 0x001732DC File Offset: 0x001714DC
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression = parent.TranslateExpression(call.Object);
					global::System.Data.Entity.Core.Objects.Span span;
					if (!parent.TryGetSpan(expression, out span))
					{
						span = null;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(call.Arguments[0]);
					if (dbExpression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						string pathToInclude = (string)((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)dbExpression).Value;
						if (parent.CanIncludeSpanInfo())
						{
							span = global::System.Data.Entity.Core.Objects.Span.IncludeIn(span, pathToInclude);
						}
						return parent.AddSpanMapping(expression, span);
					}
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedInclude);
				}
			}

			// Token: 0x02000CF3 RID: 3315
			private sealed class ObjectQueryMergeAsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator
			{
				// Token: 0x06006D3A RID: 27962 RVA: 0x00173357 File Offset: 0x00171557
				internal ObjectQueryMergeAsTranslator() : base("MergeAs")
				{
				}

				// Token: 0x06006D3B RID: 27963 RVA: 0x00173364 File Offset: 0x00171564
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (call.Arguments[0].NodeType != global::System.Linq.Expressions.ExpressionType.Constant)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedMergeAs);
					}
					global::System.Data.Entity.Core.Objects.MergeOption mergeOption = (global::System.Data.Entity.Core.Objects.MergeOption)((global::System.Linq.Expressions.ConstantExpression)call.Arguments[0]).Value;
					global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
					parent.NotifyMergeOption(mergeOption);
					global::System.Linq.Expressions.Expression linq = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator.RemoveConvertToObjectQuery(call.Object);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression = parent.TranslateExpression(linq);
					global::System.Data.Entity.Core.Objects.Span span;
					if (!parent.TryGetSpan(expression, out span))
					{
						span = null;
					}
					return parent.AddSpanMapping(expression, span);
				}
			}

			// Token: 0x02000CF4 RID: 3316
			private sealed class ObjectQueryIncludeSpanTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator
			{
				// Token: 0x06006D3C RID: 27964 RVA: 0x001733E3 File Offset: 0x001715E3
				internal ObjectQueryIncludeSpanTranslator() : base("IncludeSpan")
				{
				}

				// Token: 0x06006D3D RID: 27965 RVA: 0x001733F0 File Offset: 0x001715F0
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Objects.Span span = (global::System.Data.Entity.Core.Objects.Span)((global::System.Linq.Expressions.ConstantExpression)call.Arguments[0]).Value;
					global::System.Linq.Expressions.Expression linq = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ObjectQueryCallTranslator.RemoveConvertToObjectQuery(call.Object);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression = parent.TranslateExpression(linq);
					if (!parent.CanIncludeSpanInfo())
					{
						span = null;
					}
					return parent.AddSpanMapping(expression, span);
				}
			}

			// Token: 0x02000CF5 RID: 3317
			internal sealed class DefaultTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D3E RID: 27966 RVA: 0x00173440 File Offset: 0x00171640
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Reflection.MethodInfo method = call.Method;
					if (method.DeclaringType.Assembly().FullName == "Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" && method.Name == "Mid")
					{
						if (new global::System.Type[]
						{
							typeof(string),
							typeof(int)
						}.SequenceEqual(from p in method.GetParameters()
						select p.ParameterType))
						{
							throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedMethodSuggestedAlternative(method, "System.String Mid(System.String, Int32, Int32)"));
						}
					}
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedMethod(method));
				}

				// Token: 0x06006D3F RID: 27967 RVA: 0x001734EF File Offset: 0x001716EF
				public DefaultTranslator() : base(new global::System.Reflection.MethodInfo[0])
				{
				}
			}

			// Token: 0x02000CF6 RID: 3318
			private sealed class FunctionCallTranslator
			{
				// Token: 0x06006D40 RID: 27968 RVA: 0x00173500 File Offset: 0x00171700
				internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateFunctionCall(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.DbFunctionAttribute functionAttribute)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = (from a in call.Arguments
					select this.UnwrapNoOpConverts(a) into b
					select this.NormalizeAllSetSources(parent, parent.TranslateExpression(b))).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argumentTypes = (from a in list
					select a.ResultType).ToList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
					global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = parent.FindFunction(functionAttribute.NamespaceName, functionAttribute.FunctionName, argumentTypes, false, call);
					if (!edmFunction.IsComposableAttribute)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.CannotCallNoncomposableFunction(edmFunction.FullName));
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = edmFunction.Invoke(list);
					return this.ValidateReturnType(dbExpression, dbExpression.ResultType, parent, call, call.Type, false);
				}

				// Token: 0x06006D41 RID: 27969 RVA: 0x001735D4 File Offset: 0x001717D4
				private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression NormalizeAllSetSources(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argumentExpr)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
					global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = argumentExpr.ResultType.EdmType.BuiltInTypeKind;
					if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
					{
						if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
							global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = argumentExpr.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
							bool flag = false;
							foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyMetadata in rowType.Properties)
							{
								global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = argumentExpr.Property(propertyMetadata);
								dbExpression = this.NormalizeAllSetSources(parent, dbPropertyExpression);
								if (dbExpression != dbPropertyExpression)
								{
									flag = true;
									list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbPropertyExpression.Property.Name, dbExpression));
								}
								else
								{
									list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbPropertyExpression.Property.Name, dbPropertyExpression));
								}
							}
							if (flag)
							{
								dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list);
							}
							else
							{
								dbExpression = argumentExpr;
							}
						}
					}
					else
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = argumentExpr.BindAs(parent.AliasGenerator.Next());
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.NormalizeAllSetSources(parent, dbExpressionBinding.Variable);
						if (dbExpression2 != dbExpressionBinding.Variable)
						{
							dbExpression = dbExpressionBinding.Project(dbExpression2);
						}
					}
					if (dbExpression != null && dbExpression != argumentExpr)
					{
						return parent.NormalizeSetSource(dbExpression);
					}
					return parent.NormalizeSetSource(argumentExpr);
				}

				// Token: 0x06006D42 RID: 27970 RVA: 0x0017370C File Offset: 0x0017190C
				private global::System.Linq.Expressions.Expression UnwrapNoOpConverts(global::System.Linq.Expressions.Expression expression)
				{
					if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Convert)
					{
						global::System.Linq.Expressions.UnaryExpression unaryExpression = (global::System.Linq.Expressions.UnaryExpression)expression;
						global::System.Linq.Expressions.Expression expression2 = this.UnwrapNoOpConverts(unaryExpression.Operand);
						if (expression.Type.IsAssignableFrom(expression2.Type))
						{
							return expression2;
						}
					}
					return expression;
				}

				// Token: 0x06006D43 RID: 27971 RVA: 0x00173750 File Offset: 0x00171950
				private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ValidateReturnType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage actualReturnType, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Type clrReturnType, bool isElementOfCollection)
				{
					global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = actualReturnType.EdmType.BuiltInTypeKind;
					if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
					{
						if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
						{
							if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
							{
								if (isElementOfCollection && parent.GetCastTargetType(actualReturnType, clrReturnType, null, false) != null)
								{
									throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionAttributedFunctionWithWrongReturnType(call.Method, call.Method.DeclaringType));
								}
								global::System.Data.Entity.Core.Metadata.Edm.TypeUsage valueLayerType = parent.GetValueLayerType(clrReturnType);
								if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(actualReturnType, valueLayerType))
								{
									throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionAttributedFunctionWithWrongReturnType(call.Method, call.Method.DeclaringType));
								}
								if (!isElementOfCollection)
								{
									result = parent.AlignTypes(result, clrReturnType);
								}
							}
							else if (clrReturnType != typeof(global::System.Data.Common.DbDataRecord))
							{
								throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionAttributedFunctionWithWrongReturnType(call.Method, call.Method.DeclaringType));
							}
						}
						else if (clrReturnType != typeof(global::System.Data.Entity.Core.EntityKey))
						{
							throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionAttributedFunctionWithWrongReturnType(call.Method, call.Method.DeclaringType));
						}
					}
					else
					{
						if (!clrReturnType.IsGenericType())
						{
							throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionAttributedFunctionWithWrongReturnType(call.Method, call.Method.DeclaringType));
						}
						global::System.Type genericTypeDefinition = clrReturnType.GetGenericTypeDefinition();
						if (genericTypeDefinition != typeof(global::System.Collections.Generic.IEnumerable<>) && genericTypeDefinition != typeof(global::System.Linq.IQueryable<>))
						{
							throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionAttributedFunctionWithWrongReturnType(call.Method, call.Method.DeclaringType));
						}
						global::System.Type clrReturnType2 = clrReturnType.GetGenericArguments()[0];
						result = this.ValidateReturnType(result, global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(actualReturnType), parent, call, clrReturnType2, true);
					}
					return result;
				}
			}

			// Token: 0x02000CF7 RID: 3319
			internal sealed class CanonicalFunctionDefaultTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D45 RID: 27973 RVA: 0x001738F5 File Offset: 0x00171AF5
				internal CanonicalFunctionDefaultTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CanonicalFunctionDefaultTranslator.GetMethods())
				{
				}

				// Token: 0x06006D46 RID: 27974 RVA: 0x00173904 File Offset: 0x00171B04
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>
					{
						typeof(global::System.Math).GetDeclaredMethod("Ceiling", new global::System.Type[]
						{
							typeof(decimal)
						}),
						typeof(global::System.Math).GetDeclaredMethod("Ceiling", new global::System.Type[]
						{
							typeof(double)
						}),
						typeof(global::System.Math).GetDeclaredMethod("Floor", new global::System.Type[]
						{
							typeof(decimal)
						}),
						typeof(global::System.Math).GetDeclaredMethod("Floor", new global::System.Type[]
						{
							typeof(double)
						}),
						typeof(global::System.Math).GetDeclaredMethod("Round", new global::System.Type[]
						{
							typeof(decimal)
						}),
						typeof(global::System.Math).GetDeclaredMethod("Round", new global::System.Type[]
						{
							typeof(double)
						}),
						typeof(global::System.Math).GetDeclaredMethod("Round", new global::System.Type[]
						{
							typeof(decimal),
							typeof(int)
						}),
						typeof(global::System.Math).GetDeclaredMethod("Round", new global::System.Type[]
						{
							typeof(double),
							typeof(int)
						}),
						typeof(decimal).GetDeclaredMethod("Floor", new global::System.Type[]
						{
							typeof(decimal)
						}),
						typeof(decimal).GetDeclaredMethod("Ceiling", new global::System.Type[]
						{
							typeof(decimal)
						}),
						typeof(decimal).GetDeclaredMethod("Round", new global::System.Type[]
						{
							typeof(decimal)
						}),
						typeof(decimal).GetDeclaredMethod("Round", new global::System.Type[]
						{
							typeof(decimal),
							typeof(int)
						}),
						typeof(string).GetDeclaredMethod("Replace", new global::System.Type[]
						{
							typeof(string),
							typeof(string)
						}),
						typeof(string).GetDeclaredMethod("ToLower", new global::System.Type[0]),
						typeof(string).GetDeclaredMethod("ToUpper", new global::System.Type[0]),
						typeof(string).GetDeclaredMethod("Trim", new global::System.Type[0])
					};
					list.AddRange(from a in new global::System.Type[]
					{
						typeof(decimal),
						typeof(double),
						typeof(float),
						typeof(int),
						typeof(long),
						typeof(sbyte),
						typeof(short)
					}
					select typeof(global::System.Math).GetDeclaredMethod("Abs", new global::System.Type[]
					{
						a
					}));
					return list;
				}

				// Token: 0x06006D47 RID: 27975 RVA: 0x00173C84 File Offset: 0x00171E84
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Linq.Expressions.Expression[] linqArguments;
					if (!call.Method.IsStatic)
					{
						global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>(call.Arguments.Count + 1);
						list.Add(call.Object);
						list.AddRange(call.Arguments);
						linqArguments = list.ToArray();
					}
					else
					{
						linqArguments = call.Arguments.ToArray<global::System.Linq.Expressions.Expression>();
					}
					return parent.TranslateIntoCanonicalFunction(call.Method.Name, call, linqArguments);
				}
			}

			// Token: 0x02000CF8 RID: 3320
			internal sealed class LikeFunctionTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D48 RID: 27976 RVA: 0x00173CEF File Offset: 0x00171EEF
				internal LikeFunctionTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.LikeFunctionTranslator.GetMethods())
				{
				}

				// Token: 0x06006D49 RID: 27977 RVA: 0x00173CFC File Offset: 0x00171EFC
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(global::System.Data.Entity.DbFunctions).GetDeclaredMethod("Like", new global::System.Type[]
					{
						typeof(string),
						typeof(string)
					});
					yield return typeof(global::System.Data.Entity.DbFunctions).GetDeclaredMethod("Like", new global::System.Type[]
					{
						typeof(string),
						typeof(string),
						typeof(string)
					});
					yield return typeof(global::System.Data.Entity.Core.Objects.EntityFunctions).GetDeclaredMethod("Like", new global::System.Type[]
					{
						typeof(string),
						typeof(string)
					});
					yield return typeof(global::System.Data.Entity.Core.Objects.EntityFunctions).GetDeclaredMethod("Like", new global::System.Type[]
					{
						typeof(string),
						typeof(string),
						typeof(string)
					});
					yield break;
				}

				// Token: 0x06006D4A RID: 27978 RVA: 0x00173D05 File Offset: 0x00171F05
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.TranslateLike(call);
				}
			}

			// Token: 0x02000CF9 RID: 3321
			internal abstract class AsUnicodeNonUnicodeBaseFunctionTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D4B RID: 27979 RVA: 0x00173D0E File Offset: 0x00171F0E
				protected AsUnicodeNonUnicodeBaseFunctionTranslator(global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> methods, bool isUnicode) : base(methods)
				{
					this._isUnicode = isUnicode;
				}

				// Token: 0x06006D4C RID: 27980 RVA: 0x00173D20 File Offset: 0x00171F20
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(call.Arguments[0]);
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = dbExpression.ResultType.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
					{
						Unicode = new bool?(this._isUnicode)
					});
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = dbExpression.ExpressionKind;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
					if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null)
						{
							if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
							{
								throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedAsUnicodeAndAsNonUnicode(call.Method));
							}
							result = typeUsage.Parameter(((global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression)dbExpression).ParameterName);
						}
						else
						{
							result = typeUsage.Null();
						}
					}
					else
					{
						result = typeUsage.Constant(((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)dbExpression).Value);
					}
					return result;
				}

				// Token: 0x04003284 RID: 12932
				private readonly bool _isUnicode;
			}

			// Token: 0x02000CFA RID: 3322
			internal sealed class AsUnicodeFunctionTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AsUnicodeNonUnicodeBaseFunctionTranslator
			{
				// Token: 0x06006D4D RID: 27981 RVA: 0x00173DC1 File Offset: 0x00171FC1
				internal AsUnicodeFunctionTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AsUnicodeFunctionTranslator.GetMethods(), true)
				{
				}

				// Token: 0x06006D4E RID: 27982 RVA: 0x00173DCF File Offset: 0x00171FCF
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(global::System.Data.Entity.DbFunctions).GetDeclaredMethod("AsUnicode", new global::System.Type[]
					{
						typeof(string)
					});
					yield return typeof(global::System.Data.Entity.Core.Objects.EntityFunctions).GetDeclaredMethod("AsUnicode", new global::System.Type[]
					{
						typeof(string)
					});
					yield break;
				}
			}

			// Token: 0x02000CFB RID: 3323
			internal sealed class AsNonUnicodeFunctionTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AsUnicodeNonUnicodeBaseFunctionTranslator
			{
				// Token: 0x06006D4F RID: 27983 RVA: 0x00173DD8 File Offset: 0x00171FD8
				internal AsNonUnicodeFunctionTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AsNonUnicodeFunctionTranslator.GetMethods(), false)
				{
				}

				// Token: 0x06006D50 RID: 27984 RVA: 0x00173DE6 File Offset: 0x00171FE6
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(global::System.Data.Entity.DbFunctions).GetDeclaredMethod("AsNonUnicode", new global::System.Type[]
					{
						typeof(string)
					});
					yield return typeof(global::System.Data.Entity.Core.Objects.EntityFunctions).GetDeclaredMethod("AsNonUnicode", new global::System.Type[]
					{
						typeof(string)
					});
					yield break;
				}
			}

			// Token: 0x02000CFC RID: 3324
			internal sealed class HasFlagTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D51 RID: 27985 RVA: 0x00173DEF File Offset: 0x00171FEF
				internal HasFlagTranslator() : base(new global::System.Reflection.MethodInfo[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HasFlagTranslator._hasFlagMethod
				})
				{
				}

				// Token: 0x06006D52 RID: 27986 RVA: 0x00173E08 File Offset: 0x00172008
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateHasFlag(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression sourceExpression, global::System.Linq.Expressions.Expression valueExpression)
				{
					if (valueExpression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant && ((global::System.Linq.Expressions.ConstantExpression)valueExpression).Value == null)
					{
						throw new global::System.ArgumentNullException("flag");
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(valueExpression);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = parent.TranslateExpression(sourceExpression);
					if (dbExpression2.ResultType.EdmType != dbExpression.ResultType.EdmType)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_HasFlagArgumentAndSourceTypeMismatch(dbExpression.ResultType.EdmType.Name, dbExpression2.ResultType.EdmType.Name));
					}
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType = global::System.Data.Entity.Core.Common.TypeHelpers.CreateEnumUnderlyingTypeUsage(dbExpression2.ResultType);
					global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression dbCastExpression = dbExpression.CastTo(toType);
					return dbExpression2.CastTo(toType).BitwiseAnd(dbCastExpression).Equal(dbCastExpression);
				}

				// Token: 0x06006D53 RID: 27987 RVA: 0x00173EB1 File Offset: 0x001720B1
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.HasFlagTranslator.TranslateHasFlag(parent, call.Object, call.Arguments[0]);
				}

				// Token: 0x04003285 RID: 12933
				private static readonly global::System.Reflection.MethodInfo _hasFlagMethod = typeof(global::System.Enum).GetDeclaredMethod("HasFlag", new global::System.Type[]
				{
					typeof(global::System.Enum)
				});
			}

			// Token: 0x02000CFD RID: 3325
			internal sealed class MathTruncateTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D55 RID: 27989 RVA: 0x00173EFC File Offset: 0x001720FC
				internal MathTruncateTranslator() : base(new global::System.Reflection.MethodInfo[]
				{
					typeof(global::System.Math).GetDeclaredMethod("Truncate", new global::System.Type[]
					{
						typeof(decimal)
					}),
					typeof(global::System.Math).GetDeclaredMethod("Truncate", new global::System.Type[]
					{
						typeof(double)
					})
				})
				{
				}

				// Token: 0x06006D56 RID: 27990 RVA: 0x00173F6C File Offset: 0x0017216C
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = parent.TranslateExpression(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression digits = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(0);
					return value.Truncate(digits);
				}
			}

			// Token: 0x02000CFE RID: 3326
			internal sealed class MathPowerTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D57 RID: 27991 RVA: 0x00173FA0 File Offset: 0x001721A0
				internal MathPowerTranslator() : base(new global::System.Reflection.MethodInfo[]
				{
					typeof(global::System.Math).GetDeclaredMethod("Pow", new global::System.Type[]
					{
						typeof(double),
						typeof(double)
					})
				})
				{
				}

				// Token: 0x06006D58 RID: 27992 RVA: 0x00173FF0 File Offset: 0x001721F0
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression baseArgument = parent.TranslateExpression(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exponent = parent.TranslateExpression(call.Arguments[1]);
					return baseArgument.Power(exponent);
				}
			}

			// Token: 0x02000CFF RID: 3327
			internal sealed class GuidNewGuidTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D59 RID: 27993 RVA: 0x00174028 File Offset: 0x00172228
				internal GuidNewGuidTranslator() : base(new global::System.Reflection.MethodInfo[]
				{
					typeof(global::System.Guid).GetDeclaredMethod("NewGuid", new global::System.Type[0])
				})
				{
				}

				// Token: 0x06006D5A RID: 27994 RVA: 0x00174053 File Offset: 0x00172253
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.NewGuid();
				}
			}

			// Token: 0x02000D00 RID: 3328
			internal sealed class StringContainsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D5B RID: 27995 RVA: 0x0017405A File Offset: 0x0017225A
				internal StringContainsTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.StringContainsTranslator.GetMethods())
				{
				}

				// Token: 0x06006D5C RID: 27996 RVA: 0x00174067 File Offset: 0x00172267
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("Contains", new global::System.Type[]
					{
						typeof(string)
					});
					yield break;
				}

				// Token: 0x06006D5D RID: 27997 RVA: 0x00174070 File Offset: 0x00172270
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.TranslateFunctionIntoLike(call, true, true, new global::System.Func<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter, global::System.Linq.Expressions.MethodCallExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.StringContainsTranslator.CreateDefaultTranslation));
				}

				// Token: 0x06006D5E RID: 27998 RVA: 0x00174087 File Offset: 0x00172287
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateDefaultTranslation(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression patternExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression inputExpression)
				{
					return parent.CreateCanonicalFunction("IndexOf", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						patternExpression,
						inputExpression
					}).GreaterThan(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(0));
				}
			}

			// Token: 0x02000D01 RID: 3329
			internal sealed class IndexOfTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D5F RID: 27999 RVA: 0x001740B3 File Offset: 0x001722B3
				internal IndexOfTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.IndexOfTranslator.GetMethods())
				{
				}

				// Token: 0x06006D60 RID: 28000 RVA: 0x001740C0 File Offset: 0x001722C0
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("IndexOf", new global::System.Type[]
					{
						typeof(string)
					});
					yield break;
				}

				// Token: 0x06006D61 RID: 28001 RVA: 0x001740C9 File Offset: 0x001722C9
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.TranslateIntoCanonicalFunction("IndexOf", call, new global::System.Linq.Expressions.Expression[]
					{
						call.Arguments[0],
						call.Object
					}).Minus(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1));
				}
			}

			// Token: 0x02000D02 RID: 3330
			internal sealed class StartsWithTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D62 RID: 28002 RVA: 0x00174105 File Offset: 0x00172305
				internal StartsWithTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.StartsWithTranslator.GetMethods())
				{
				}

				// Token: 0x06006D63 RID: 28003 RVA: 0x00174112 File Offset: 0x00172312
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("StartsWith", new global::System.Type[]
					{
						typeof(string)
					});
					yield break;
				}

				// Token: 0x06006D64 RID: 28004 RVA: 0x0017411B File Offset: 0x0017231B
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.TranslateFunctionIntoLike(call, false, true, new global::System.Func<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter, global::System.Linq.Expressions.MethodCallExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.StartsWithTranslator.CreateDefaultTranslation));
				}

				// Token: 0x06006D65 RID: 28005 RVA: 0x00174132 File Offset: 0x00172332
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateDefaultTranslation(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression patternExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression inputExpression)
				{
					return parent.CreateCanonicalFunction("IndexOf", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						patternExpression,
						inputExpression
					}).Equal(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1));
				}
			}

			// Token: 0x02000D03 RID: 3331
			internal sealed class EndsWithTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D66 RID: 28006 RVA: 0x0017415E File Offset: 0x0017235E
				internal EndsWithTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.EndsWithTranslator.GetMethods())
				{
				}

				// Token: 0x06006D67 RID: 28007 RVA: 0x0017416B File Offset: 0x0017236B
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("EndsWith", new global::System.Type[]
					{
						typeof(string)
					});
					yield break;
				}

				// Token: 0x06006D68 RID: 28008 RVA: 0x00174174 File Offset: 0x00172374
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.TranslateFunctionIntoLike(call, true, false, new global::System.Func<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter, global::System.Linq.Expressions.MethodCallExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.EndsWithTranslator.CreateDefaultTranslation));
				}

				// Token: 0x06006D69 RID: 28009 RVA: 0x0017418C File Offset: 0x0017238C
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateDefaultTranslation(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression patternExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression inputExpression)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression dbFunctionExpression = parent.CreateCanonicalFunction("Reverse", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						patternExpression
					});
					global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression dbFunctionExpression2 = parent.CreateCanonicalFunction("Reverse", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						inputExpression
					});
					return parent.CreateCanonicalFunction("IndexOf", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbFunctionExpression,
						dbFunctionExpression2
					}).Equal(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1));
				}
			}

			// Token: 0x02000D04 RID: 3332
			internal sealed class SubstringTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D6A RID: 28010 RVA: 0x001741F1 File Offset: 0x001723F1
				internal SubstringTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SubstringTranslator.GetMethods())
				{
				}

				// Token: 0x06006D6B RID: 28011 RVA: 0x001741FE File Offset: 0x001723FE
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("Substring", new global::System.Type[]
					{
						typeof(int)
					});
					yield return typeof(string).GetDeclaredMethod("Substring", new global::System.Type[]
					{
						typeof(int),
						typeof(int)
					});
					yield break;
				}

				// Token: 0x06006D6C RID: 28012 RVA: 0x00174208 File Offset: 0x00172408
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = parent.TranslateExpression(call.Object);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = dbExpression.Plus(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4;
					if (call.Arguments.Count == 1)
					{
						dbExpression4 = parent.CreateCanonicalFunction("Length", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							dbExpression2
						}).Minus(dbExpression);
					}
					else
					{
						dbExpression4 = parent.TranslateExpression(call.Arguments[1]);
					}
					return parent.CreateCanonicalFunction("Substring", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbExpression2,
						dbExpression3,
						dbExpression4
					});
				}
			}

			// Token: 0x02000D05 RID: 3333
			internal sealed class RemoveTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D6D RID: 28013 RVA: 0x001742A5 File Offset: 0x001724A5
				internal RemoveTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.RemoveTranslator.GetMethods())
				{
				}

				// Token: 0x06006D6E RID: 28014 RVA: 0x001742B2 File Offset: 0x001724B2
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("Remove", new global::System.Type[]
					{
						typeof(int)
					});
					yield return typeof(string).GetDeclaredMethod("Remove", new global::System.Type[]
					{
						typeof(int),
						typeof(int)
					});
					yield break;
				}

				// Token: 0x06006D6F RID: 28015 RVA: 0x001742BC File Offset: 0x001724BC
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(call.Object);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = parent.TranslateExpression(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = parent.CreateCanonicalFunction("Substring", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbExpression,
						global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1),
						dbExpression2
					});
					if (call.Arguments.Count == 2)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4 = parent.TranslateExpression(call.Arguments[1]);
						if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.RemoveTranslator.IsNonNegativeIntegerConstant(dbExpression4))
						{
							throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedStringRemoveCase(call.Method, call.Method.GetParameters()[1].Name));
						}
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression5 = dbExpression2.Plus(dbExpression4).Plus(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1));
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression6 = parent.CreateCanonicalFunction("Length", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							dbExpression
						}).Minus(dbExpression2.Plus(dbExpression4));
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression7 = parent.CreateCanonicalFunction("Substring", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							dbExpression,
							dbExpression5,
							dbExpression6
						});
						dbExpression3 = parent.CreateCanonicalFunction("Concat", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							dbExpression3,
							dbExpression7
						});
					}
					return dbExpression3;
				}

				// Token: 0x06006D70 RID: 28016 RVA: 0x001743DD File Offset: 0x001725DD
				private static bool IsNonNegativeIntegerConstant(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
				{
					return argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(argument.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32) && (int)((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)argument).Value >= 0;
				}
			}

			// Token: 0x02000D06 RID: 3334
			internal sealed class InsertTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D71 RID: 28017 RVA: 0x0017440F File Offset: 0x0017260F
				internal InsertTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.InsertTranslator.GetMethods())
				{
				}

				// Token: 0x06006D72 RID: 28018 RVA: 0x0017441C File Offset: 0x0017261C
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("Insert", new global::System.Type[]
					{
						typeof(int),
						typeof(string)
					});
					yield break;
				}

				// Token: 0x06006D73 RID: 28019 RVA: 0x00174428 File Offset: 0x00172628
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(call.Object);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = parent.TranslateExpression(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = parent.CreateCanonicalFunction("Substring", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbExpression,
						global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1),
						dbExpression2
					});
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4 = parent.CreateCanonicalFunction("Substring", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbExpression,
						dbExpression2.Plus(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1)),
						parent.CreateCanonicalFunction("Length", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							dbExpression
						}).Minus(dbExpression2)
					});
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression5 = parent.TranslateExpression(call.Arguments[1]);
					return parent.CreateCanonicalFunction("Concat", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						parent.CreateCanonicalFunction("Concat", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							dbExpression3,
							dbExpression5
						}),
						dbExpression4
					});
				}
			}

			// Token: 0x02000D07 RID: 3335
			internal sealed class IsNullOrEmptyTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D74 RID: 28020 RVA: 0x00174510 File Offset: 0x00172710
				internal IsNullOrEmptyTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.IsNullOrEmptyTranslator.GetMethods())
				{
				}

				// Token: 0x06006D75 RID: 28021 RVA: 0x0017451D File Offset: 0x0017271D
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("IsNullOrEmpty", new global::System.Type[]
					{
						typeof(string)
					});
					yield break;
				}

				// Token: 0x06006D76 RID: 28022 RVA: 0x00174528 File Offset: 0x00172728
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = dbExpression.IsNull();
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = parent.CreateCanonicalFunction("Length", call, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbExpression
					}).Equal(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(0));
					return left.Or(right);
				}
			}

			// Token: 0x02000D08 RID: 3336
			internal sealed class StringConcatTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D77 RID: 28023 RVA: 0x0017457D File Offset: 0x0017277D
				internal StringConcatTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.StringConcatTranslator.GetMethods())
				{
				}

				// Token: 0x06006D78 RID: 28024 RVA: 0x0017458A File Offset: 0x0017278A
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("Concat", new global::System.Type[]
					{
						typeof(string),
						typeof(string)
					});
					yield return typeof(string).GetDeclaredMethod("Concat", new global::System.Type[]
					{
						typeof(string),
						typeof(string),
						typeof(string)
					});
					yield return typeof(string).GetDeclaredMethod("Concat", new global::System.Type[]
					{
						typeof(string),
						typeof(string),
						typeof(string),
						typeof(string)
					});
					yield return typeof(string).GetDeclaredMethod("Concat", new global::System.Type[]
					{
						typeof(object),
						typeof(object)
					});
					yield return typeof(string).GetDeclaredMethod("Concat", new global::System.Type[]
					{
						typeof(object),
						typeof(object),
						typeof(object)
					});
					yield return typeof(string).GetDeclaredMethod("Concat", new global::System.Type[]
					{
						typeof(object),
						typeof(object),
						typeof(object),
						typeof(object)
					});
					yield return typeof(string).GetDeclaredMethod("Concat", new global::System.Type[]
					{
						typeof(object[])
					});
					yield return typeof(string).GetDeclaredMethod("Concat", new global::System.Type[]
					{
						typeof(string[])
					});
					yield break;
				}

				// Token: 0x06006D79 RID: 28025 RVA: 0x00174594 File Offset: 0x00172794
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Linq.Expressions.Expression[] linqArgs;
					if (call.Arguments.Count == 1 && (call.Arguments.First<global::System.Linq.Expressions.Expression>().Type == typeof(object[]) || call.Arguments.First<global::System.Linq.Expressions.Expression>().Type == typeof(string[])))
					{
						if (call.Arguments[0] is global::System.Linq.Expressions.NewArrayExpression)
						{
							linqArgs = ((global::System.Linq.Expressions.NewArrayExpression)call.Arguments[0]).Expressions.ToArray<global::System.Linq.Expressions.Expression>();
						}
						else
						{
							global::System.Linq.Expressions.ConstantExpression constantExpression = (global::System.Linq.Expressions.ConstantExpression)call.Arguments[0];
							if (constantExpression.Value == null)
							{
								throw new global::System.ArgumentNullException((constantExpression.Type == typeof(object[])) ? "args" : "values");
							}
							global::System.Linq.Expressions.Expression[] array = (from v in (object[])constantExpression.Value
							select global::System.Linq.Expressions.Expression.Constant(v)).ToArray<global::System.Linq.Expressions.ConstantExpression>();
							linqArgs = array;
						}
					}
					else
					{
						linqArgs = call.Arguments.ToArray<global::System.Linq.Expressions.Expression>();
					}
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.ConcatArgs(parent, call, linqArgs);
				}
			}

			// Token: 0x02000D09 RID: 3337
			internal sealed class ToStringTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D7A RID: 28026 RVA: 0x001746BB File Offset: 0x001728BB
				internal ToStringTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ToStringTranslator._methods)
				{
				}

				// Token: 0x06006D7B RID: 28027 RVA: 0x001746C8 File Offset: 0x001728C8
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.ConvertToString(parent, call.Object);
				}

				// Token: 0x04003286 RID: 12934
				private static readonly global::System.Reflection.MethodInfo[] _methods = new global::System.Reflection.MethodInfo[]
				{
					typeof(string).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(byte).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(sbyte).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(short).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(int).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(long).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(double).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(float).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(global::System.Guid).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(global::System.DateTime).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(global::System.DateTimeOffset).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(global::System.TimeSpan).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(decimal).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(bool).GetDeclaredMethod("ToString", new global::System.Type[0]),
					typeof(object).GetDeclaredMethod("ToString", new global::System.Type[0])
				};
			}

			// Token: 0x02000D0A RID: 3338
			internal abstract class TrimBaseTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D7D RID: 28029 RVA: 0x001748AA File Offset: 0x00172AAA
				protected TrimBaseTranslator(global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> methods, string canonicalFunctionName) : base(methods)
				{
					this._canonicalFunctionName = canonicalFunctionName;
				}

				// Token: 0x06006D7E RID: 28030 RVA: 0x001748BC File Offset: 0x00172ABC
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (call.Arguments.Count != 0 && !global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimBaseTranslator.IsEmptyArray(call.Arguments[0]))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedTrimStartTrimEndCase(call.Method));
					}
					return parent.TranslateIntoCanonicalFunction(this._canonicalFunctionName, call, new global::System.Linq.Expressions.Expression[]
					{
						call.Object
					});
				}

				// Token: 0x06006D7F RID: 28031 RVA: 0x00174918 File Offset: 0x00172B18
				internal static bool IsEmptyArray(global::System.Linq.Expressions.Expression expression)
				{
					global::System.Linq.Expressions.NewArrayExpression newArrayExpression = expression as global::System.Linq.Expressions.NewArrayExpression;
					if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.NewArrayInit)
					{
						if (newArrayExpression.Expressions.Count == 0)
						{
							return true;
						}
					}
					else if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.NewArrayBounds && newArrayExpression.Expressions.Count == 1 && newArrayExpression.Expressions[0].NodeType == global::System.Linq.Expressions.ExpressionType.Constant)
					{
						return object.Equals(((global::System.Linq.Expressions.ConstantExpression)newArrayExpression.Expressions[0]).Value, 0);
					}
					return false;
				}

				// Token: 0x04003287 RID: 12935
				private readonly string _canonicalFunctionName;
			}

			// Token: 0x02000D0B RID: 3339
			internal sealed class TrimTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimBaseTranslator
			{
				// Token: 0x06006D80 RID: 28032 RVA: 0x00174995 File Offset: 0x00172B95
				internal TrimTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimTranslator.GetMethods(), "Trim")
				{
				}

				// Token: 0x06006D81 RID: 28033 RVA: 0x001749A7 File Offset: 0x00172BA7
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("Trim", new global::System.Type[]
					{
						typeof(char[])
					});
					yield break;
				}
			}

			// Token: 0x02000D0C RID: 3340
			internal sealed class TrimStartTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimBaseTranslator
			{
				// Token: 0x06006D82 RID: 28034 RVA: 0x001749B0 File Offset: 0x00172BB0
				internal TrimStartTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimStartTranslator.GetMethods(), "LTrim")
				{
				}

				// Token: 0x06006D83 RID: 28035 RVA: 0x001749C2 File Offset: 0x00172BC2
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("TrimStart", new global::System.Type[]
					{
						typeof(char[])
					});
					yield break;
				}
			}

			// Token: 0x02000D0D RID: 3341
			internal sealed class TrimEndTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimBaseTranslator
			{
				// Token: 0x06006D84 RID: 28036 RVA: 0x001749CB File Offset: 0x00172BCB
				internal TrimEndTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.TrimEndTranslator.GetMethods(), "RTrim")
				{
				}

				// Token: 0x06006D85 RID: 28037 RVA: 0x001749DD File Offset: 0x00172BDD
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods()
				{
					yield return typeof(string).GetDeclaredMethod("TrimEnd", new global::System.Type[]
					{
						typeof(char[])
					});
					yield break;
				}
			}

			// Token: 0x02000D0E RID: 3342
			internal sealed class VBCanonicalFunctionDefaultTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D86 RID: 28038 RVA: 0x001749E6 File Offset: 0x00172BE6
				internal VBCanonicalFunctionDefaultTranslator(global::System.Reflection.Assembly vbAssembly) : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionDefaultTranslator.GetMethods(vbAssembly))
				{
				}

				// Token: 0x06006D87 RID: 28039 RVA: 0x001749F4 File Offset: 0x00172BF4
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods(global::System.Reflection.Assembly vbAssembly)
				{
					global::System.Type stringsType = vbAssembly.GetType("Microsoft.VisualBasic.Strings");
					yield return stringsType.GetDeclaredMethod("Trim", new global::System.Type[]
					{
						typeof(string)
					});
					yield return stringsType.GetDeclaredMethod("LTrim", new global::System.Type[]
					{
						typeof(string)
					});
					yield return stringsType.GetDeclaredMethod("RTrim", new global::System.Type[]
					{
						typeof(string)
					});
					yield return stringsType.GetDeclaredMethod("Left", new global::System.Type[]
					{
						typeof(string),
						typeof(int)
					});
					yield return stringsType.GetDeclaredMethod("Right", new global::System.Type[]
					{
						typeof(string),
						typeof(int)
					});
					global::System.Type dateTimeType = vbAssembly.GetType("Microsoft.VisualBasic.DateAndTime");
					yield return dateTimeType.GetDeclaredMethod("Year", new global::System.Type[]
					{
						typeof(global::System.DateTime)
					});
					yield return dateTimeType.GetDeclaredMethod("Month", new global::System.Type[]
					{
						typeof(global::System.DateTime)
					});
					yield return dateTimeType.GetDeclaredMethod("Day", new global::System.Type[]
					{
						typeof(global::System.DateTime)
					});
					yield return dateTimeType.GetDeclaredMethod("Hour", new global::System.Type[]
					{
						typeof(global::System.DateTime)
					});
					yield return dateTimeType.GetDeclaredMethod("Minute", new global::System.Type[]
					{
						typeof(global::System.DateTime)
					});
					yield return dateTimeType.GetDeclaredMethod("Second", new global::System.Type[]
					{
						typeof(global::System.DateTime)
					});
					yield break;
				}

				// Token: 0x06006D88 RID: 28040 RVA: 0x00174A04 File Offset: 0x00172C04
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.TranslateIntoCanonicalFunction(call.Method.Name, call, call.Arguments.ToArray<global::System.Linq.Expressions.Expression>());
				}

				// Token: 0x04003288 RID: 12936
				private const string s_stringsTypeFullName = "Microsoft.VisualBasic.Strings";

				// Token: 0x04003289 RID: 12937
				private const string s_dateAndTimeTypeFullName = "Microsoft.VisualBasic.DateAndTime";
			}

			// Token: 0x02000D0F RID: 3343
			internal sealed class VBCanonicalFunctionRenameTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D89 RID: 28041 RVA: 0x00174A23 File Offset: 0x00172C23
				internal VBCanonicalFunctionRenameTranslator(global::System.Reflection.Assembly vbAssembly) : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionRenameTranslator.GetMethods(vbAssembly).ToArray<global::System.Reflection.MethodInfo>())
				{
				}

				// Token: 0x06006D8A RID: 28042 RVA: 0x00174A36 File Offset: 0x00172C36
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods(global::System.Reflection.Assembly vbAssembly)
				{
					global::System.Type stringsType = vbAssembly.GetType("Microsoft.VisualBasic.Strings");
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionRenameTranslator.GetMethodInfo(stringsType, "Len", "Length", new global::System.Type[]
					{
						typeof(string)
					});
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionRenameTranslator.GetMethodInfo(stringsType, "Mid", "Substring", new global::System.Type[]
					{
						typeof(string),
						typeof(int),
						typeof(int)
					});
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionRenameTranslator.GetMethodInfo(stringsType, "UCase", "ToUpper", new global::System.Type[]
					{
						typeof(string)
					});
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionRenameTranslator.GetMethodInfo(stringsType, "LCase", "ToLower", new global::System.Type[]
					{
						typeof(string)
					});
					yield break;
				}

				// Token: 0x06006D8B RID: 28043 RVA: 0x00174A48 File Offset: 0x00172C48
				private static global::System.Reflection.MethodInfo GetMethodInfo(global::System.Type declaringType, string methodName, string canonicalFunctionName, global::System.Type[] argumentTypes)
				{
					global::System.Reflection.MethodInfo declaredMethod = declaringType.GetDeclaredMethod(methodName, argumentTypes);
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionRenameTranslator.s_methodNameMap.Add(declaredMethod, canonicalFunctionName);
					return declaredMethod;
				}

				// Token: 0x06006D8C RID: 28044 RVA: 0x00174A6B File Offset: 0x00172C6B
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.TranslateIntoCanonicalFunction(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBCanonicalFunctionRenameTranslator.s_methodNameMap[call.Method], call, call.Arguments.ToArray<global::System.Linq.Expressions.Expression>());
				}

				// Token: 0x0400328A RID: 12938
				private const string s_stringsTypeFullName = "Microsoft.VisualBasic.Strings";

				// Token: 0x0400328B RID: 12939
				private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, string> s_methodNameMap = new global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, string>(4);
			}

			// Token: 0x02000D10 RID: 3344
			internal sealed class VBDatePartTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006D8E RID: 28046 RVA: 0x00174A9C File Offset: 0x00172C9C
				internal VBDatePartTranslator(global::System.Reflection.Assembly vbAssembly) : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBDatePartTranslator.GetMethods(vbAssembly))
				{
				}

				// Token: 0x06006D8F RID: 28047 RVA: 0x00174AAA File Offset: 0x00172CAA
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetMethods(global::System.Reflection.Assembly vbAssembly)
				{
					global::System.Type type = vbAssembly.GetType("Microsoft.VisualBasic.DateAndTime");
					global::System.Type type2 = vbAssembly.GetType("Microsoft.VisualBasic.DateInterval");
					global::System.Type type3 = vbAssembly.GetType("Microsoft.VisualBasic.FirstDayOfWeek");
					global::System.Type type4 = vbAssembly.GetType("Microsoft.VisualBasic.FirstWeekOfYear");
					yield return type.GetDeclaredMethod("DatePart", new global::System.Type[]
					{
						type2,
						typeof(global::System.DateTime),
						type3,
						type4
					});
					yield break;
				}

				// Token: 0x06006D90 RID: 28048 RVA: 0x00174ABC File Offset: 0x00172CBC
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Linq.Expressions.ConstantExpression constantExpression = call.Arguments[0] as global::System.Linq.Expressions.ConstantExpression;
					if (constantExpression == null)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedVBDatePartNonConstantInterval(call.Method, call.Method.GetParameters()[0].Name));
					}
					string text = constantExpression.Value.ToString();
					if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.VBDatePartTranslator._supportedIntervals.Contains(text))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedVBDatePartInvalidInterval(call.Method, call.Method.GetParameters()[0].Name, text));
					}
					return parent.TranslateIntoCanonicalFunction(text, call, new global::System.Linq.Expressions.Expression[]
					{
						call.Arguments[1]
					});
				}

				// Token: 0x0400328C RID: 12940
				private const string s_dateAndTimeTypeFullName = "Microsoft.VisualBasic.DateAndTime";

				// Token: 0x0400328D RID: 12941
				private const string s_DateIntervalFullName = "Microsoft.VisualBasic.DateInterval";

				// Token: 0x0400328E RID: 12942
				private const string s_FirstDayOfWeekFullName = "Microsoft.VisualBasic.FirstDayOfWeek";

				// Token: 0x0400328F RID: 12943
				private const string s_FirstWeekOfYearFullName = "Microsoft.VisualBasic.FirstWeekOfYear";

				// Token: 0x04003290 RID: 12944
				private static readonly global::System.Collections.Generic.HashSet<string> _supportedIntervals = new global::System.Collections.Generic.HashSet<string>
				{
					"Year",
					"Month",
					"Day",
					"Hour",
					"Minute",
					"Second"
				};
			}

			// Token: 0x02000D11 RID: 3345
			private abstract class SequenceMethodTranslator
			{
				// Token: 0x06006D92 RID: 28050 RVA: 0x00174BBB File Offset: 0x00172DBB
				protected SequenceMethodTranslator(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods)
				{
					this._methods = methods;
				}

				// Token: 0x170011A2 RID: 4514
				// (get) Token: 0x06006D93 RID: 28051 RVA: 0x00174BCA File Offset: 0x00172DCA
				internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod> Methods
				{
					get
					{
						return this._methods;
					}
				}

				// Token: 0x06006D94 RID: 28052 RVA: 0x00174BD2 File Offset: 0x00172DD2
				internal virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod)
				{
					return this.Translate(parent, call);
				}

				// Token: 0x06006D95 RID: 28053
				internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call);

				// Token: 0x06006D96 RID: 28054 RVA: 0x00174BDC File Offset: 0x00172DDC
				public override string ToString()
				{
					return base.GetType().Name;
				}

				// Token: 0x04003291 RID: 12945
				private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod> _methods;
			}

			// Token: 0x02000D12 RID: 3346
			private abstract class PagingTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.UnarySequenceMethodTranslator
			{
				// Token: 0x06006D97 RID: 28055 RVA: 0x00174BE9 File Offset: 0x00172DE9
				protected PagingTranslator(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
				}

				// Token: 0x06006D98 RID: 28056 RVA: 0x00174BF4 File Offset: 0x00172DF4
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Linq.Expressions.Expression linq = call.Arguments[1];
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count = parent.TranslateExpression(linq);
					return this.TranslatePagingOperator(parent, operand, count);
				}

				// Token: 0x06006D99 RID: 28057
				protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslatePagingOperator(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count);
			}

			// Token: 0x02000D13 RID: 3347
			private sealed class TakeTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.PagingTranslator
			{
				// Token: 0x06006D9A RID: 28058 RVA: 0x00174C1F File Offset: 0x00172E1F
				internal TakeTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Take
				})
				{
				}

				// Token: 0x06006D9B RID: 28059 RVA: 0x00174C34 File Offset: 0x00172E34
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslatePagingOperator(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = count as global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression;
					if (dbConstantExpression != null && dbConstantExpression.Value.Equals(0))
					{
						return parent.Filter(operand.BindAs(parent.AliasGenerator.Next()), global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False);
					}
					return parent.Limit(operand, count);
				}
			}

			// Token: 0x02000D14 RID: 3348
			private sealed class SkipTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.PagingTranslator
			{
				// Token: 0x06006D9C RID: 28060 RVA: 0x00174C83 File Offset: 0x00172E83
				internal SkipTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Skip
				})
				{
				}

				// Token: 0x06006D9D RID: 28061 RVA: 0x00174C96 File Offset: 0x00172E96
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslatePagingOperator(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count)
				{
					return parent.Skip(operand.BindAs(parent.AliasGenerator.Next()), count);
				}
			}

			// Token: 0x02000D15 RID: 3349
			private sealed class JoinTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006D9E RID: 28062 RVA: 0x00174CB0 File Offset: 0x00172EB0
				internal JoinTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Join
				})
				{
				}

				// Token: 0x06006D9F RID: 28063 RVA: 0x00174CC4 File Offset: 0x00172EC4
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input = parent.TranslateSet(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input2 = parent.TranslateSet(call.Arguments[1]);
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = parent.GetLambdaExpression(call, 2);
					global::System.Linq.Expressions.LambdaExpression lambdaExpression2 = parent.GetLambdaExpression(call, 3);
					global::System.Linq.Expressions.LambdaExpression lambdaExpression3 = parent.GetLambdaExpression(call, 4);
					string bindingName;
					string bindingName2;
					global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
					bool flag = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.IsTrivialRename(lambdaExpression3, parent, out bindingName, out bindingName2, out initializerMetadata);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = flag ? parent.TranslateLambda(lambdaExpression, input, bindingName, out dbExpressionBinding) : parent.TranslateLambda(lambdaExpression, input, out dbExpressionBinding);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = flag ? parent.TranslateLambda(lambdaExpression2, input2, bindingName2, out dbExpressionBinding2) : parent.TranslateLambda(lambdaExpression2, input2, out dbExpressionBinding2);
					if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(dbExpression.ResultType) || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(dbExpression2.ResultType))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedKeySelector(call.Method.Name));
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = parent.CreateEqualsExpression(dbExpression, dbExpression2, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityNonComposable, lambdaExpression.Body.Type, lambdaExpression2.Body.Type);
					if (flag)
					{
						global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowType(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>
						{
							new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(dbExpressionBinding.VariableName, dbExpressionBinding.VariableType),
							new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(dbExpressionBinding2.VariableName, dbExpressionBinding2.VariableType)
						}, initializerMetadata));
						return new global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionType(elementType)), dbExpressionBinding, dbExpressionBinding2, dbExpression3);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding3 = dbExpressionBinding.InnerJoin(dbExpressionBinding2, dbExpression3).BindAs(parent.AliasGenerator.Next());
					global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression cqtExpression = dbExpressionBinding3.Variable.Property(dbExpressionBinding.VariableName);
					global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression cqtExpression2 = dbExpressionBinding3.Variable.Property(dbExpressionBinding2.VariableName);
					parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambdaExpression3.Parameters[0], cqtExpression));
					parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambdaExpression3.Parameters[1], cqtExpression2));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = parent.TranslateExpression(lambdaExpression3.Body);
					parent._bindingContext.PopBindingScope();
					parent._bindingContext.PopBindingScope();
					return dbExpressionBinding3.Project(projection);
				}
			}

			// Token: 0x02000D16 RID: 3350
			private abstract class BinarySequenceMethodTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006DA0 RID: 28064 RVA: 0x00174EBE File Offset: 0x001730BE
				protected BinarySequenceMethodTranslator(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
				}

				// Token: 0x06006DA1 RID: 28065 RVA: 0x00174EC7 File Offset: 0x001730C7
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateLeft(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression expr)
				{
					return parent.TranslateSet(expr);
				}

				// Token: 0x06006DA2 RID: 28066 RVA: 0x00174ED0 File Offset: 0x001730D0
				protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateRight(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression expr)
				{
					return parent.TranslateSet(expr);
				}

				// Token: 0x06006DA3 RID: 28067 RVA: 0x00174EDC File Offset: 0x001730DC
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (call.Object != null)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.BinarySequenceMethodTranslator.TranslateLeft(parent, call.Object);
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = this.TranslateRight(parent, call.Arguments[0]);
						return this.TranslateBinary(parent, left, right);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left2 = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.BinarySequenceMethodTranslator.TranslateLeft(parent, call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right2 = this.TranslateRight(parent, call.Arguments[1]);
					return this.TranslateBinary(parent, left2, right2);
				}

				// Token: 0x06006DA4 RID: 28068
				protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right);
			}

			// Token: 0x02000D17 RID: 3351
			private class ConcatTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.BinarySequenceMethodTranslator
			{
				// Token: 0x06006DA5 RID: 28069 RVA: 0x00174F4C File Offset: 0x0017314C
				internal ConcatTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Concat
				})
				{
				}

				// Token: 0x06006DA6 RID: 28070 RVA: 0x00174F5F File Offset: 0x0017315F
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
				{
					return parent.UnionAll(left, right);
				}
			}

			// Token: 0x02000D18 RID: 3352
			private sealed class UnionTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.BinarySequenceMethodTranslator
			{
				// Token: 0x06006DA7 RID: 28071 RVA: 0x00174F69 File Offset: 0x00173169
				internal UnionTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Union
				})
				{
				}

				// Token: 0x06006DA8 RID: 28072 RVA: 0x00174F7C File Offset: 0x0017317C
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
				{
					return parent.Distinct(parent.UnionAll(left, right));
				}
			}

			// Token: 0x02000D19 RID: 3353
			private sealed class IntersectTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.BinarySequenceMethodTranslator
			{
				// Token: 0x06006DA9 RID: 28073 RVA: 0x00174F8C File Offset: 0x0017318C
				internal IntersectTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Intersect
				})
				{
				}

				// Token: 0x06006DAA RID: 28074 RVA: 0x00174F9F File Offset: 0x0017319F
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
				{
					return parent.Intersect(left, right);
				}
			}

			// Token: 0x02000D1A RID: 3354
			private sealed class ExceptTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.BinarySequenceMethodTranslator
			{
				// Token: 0x06006DAB RID: 28075 RVA: 0x00174FA9 File Offset: 0x001731A9
				internal ExceptTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Except
				})
				{
				}

				// Token: 0x06006DAC RID: 28076 RVA: 0x00174FBC File Offset: 0x001731BC
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
				{
					return parent.Except(left, right);
				}

				// Token: 0x06006DAD RID: 28077 RVA: 0x00174FC8 File Offset: 0x001731C8
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateRight(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression expr)
				{
					int ignoreInclude = parent.IgnoreInclude;
					parent.IgnoreInclude = ignoreInclude + 1;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = base.TranslateRight(parent, expr);
					ignoreInclude = parent.IgnoreInclude;
					parent.IgnoreInclude = ignoreInclude - 1;
					return result;
				}
			}

			// Token: 0x02000D1B RID: 3355
			private abstract class AggregateTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006DAE RID: 28078 RVA: 0x00174FFD File Offset: 0x001731FD
				protected AggregateTranslator(string functionName, bool takesPredicate, params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
					this._takesPredicate = takesPredicate;
					this._functionName = functionName;
				}

				// Token: 0x06006DAF RID: 28079 RVA: 0x00175014 File Offset: 0x00173214
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					bool flag = 1 == call.Arguments.Count;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateSet(call.Arguments[0]);
					if (!flag)
					{
						global::System.Linq.Expressions.LambdaExpression lambdaExpression = parent.GetLambdaExpression(call, 1);
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input;
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = parent.TranslateLambda(lambdaExpression, dbExpression, out input);
						if (this._takesPredicate)
						{
							dbExpression = parent.Filter(input, dbExpression2);
						}
						else
						{
							dbExpression = input.Project(dbExpression2);
						}
					}
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage returnType = this.GetReturnType(parent, call);
					global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function = this.FindFunction(parent, call, returnType);
					dbExpression = this.WrapCollectionOperand(parent, dbExpression, returnType);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqt = function.Invoke(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
					{
						dbExpression
					});
					return parent.AlignTypes(cqt, call.Type);
				}

				// Token: 0x06006DB0 RID: 28080 RVA: 0x001750BA File Offset: 0x001732BA
				protected virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetReturnType(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.GetValueLayerType(call.Type);
				}

				// Token: 0x06006DB1 RID: 28081 RVA: 0x001750C8 File Offset: 0x001732C8
				protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression WrapCollectionOperand(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage returnType)
				{
					if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypeUsageEquals(returnType, ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)operand.ResultType.EdmType).TypeUsage))
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = operand.BindAs(parent.AliasGenerator.Next());
						operand = dbExpressionBinding.Project(dbExpressionBinding.Variable.CastTo(returnType));
					}
					return operand;
				}

				// Token: 0x06006DB2 RID: 28082 RVA: 0x00175117 File Offset: 0x00173317
				protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression WrapNonCollectionOperand(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage returnType)
				{
					if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypeUsageEquals(returnType, operand.ResultType))
					{
						operand = operand.CastTo(returnType);
					}
					return operand;
				}

				// Token: 0x06006DB3 RID: 28083 RVA: 0x00175134 File Offset: 0x00173334
				protected virtual global::System.Data.Entity.Core.Metadata.Edm.EdmFunction FindFunction(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argumentType)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(1);
					list.Add(argumentType);
					return parent.FindCanonicalFunction(this._functionName, list, true, call);
				}

				// Token: 0x04003292 RID: 12946
				private readonly string _functionName;

				// Token: 0x04003293 RID: 12947
				private readonly bool _takesPredicate;
			}

			// Token: 0x02000D1C RID: 3356
			private sealed class MaxTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AggregateTranslator
			{
				// Token: 0x06006DB4 RID: 28084 RVA: 0x0017515E File Offset: 0x0017335E
				internal MaxTranslator() : base("Max", false, new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Max,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxInt,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxIntSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxDecimal,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxDecimalSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxDouble,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxDoubleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxLong,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxLongSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxSingle,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxSingleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableDecimal,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableDecimalSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableDouble,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableDoubleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableInt,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableIntSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableLong,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableLongSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableSingle,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableSingleSelector
				})
				{
				}

				// Token: 0x06006DB5 RID: 28085 RVA: 0x00175180 File Offset: 0x00173380
				protected override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetReturnType(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage returnType = base.GetReturnType(parent, call);
					if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(returnType))
					{
						return returnType;
					}
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(returnType.EdmType), returnType.Facets);
				}
			}

			// Token: 0x02000D1D RID: 3357
			private sealed class MinTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AggregateTranslator
			{
				// Token: 0x06006DB6 RID: 28086 RVA: 0x001751B6 File Offset: 0x001733B6
				internal MinTranslator() : base("Min", false, new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Min,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinDecimal,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinDecimalSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinDouble,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinDoubleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinInt,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinIntSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinLong,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinLongSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableDecimal,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinSingle,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinSingleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableDecimalSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableDouble,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableDoubleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableInt,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableIntSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableLong,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableLongSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableSingle,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableSingleSelector
				})
				{
				}

				// Token: 0x06006DB7 RID: 28087 RVA: 0x001751D8 File Offset: 0x001733D8
				protected override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetReturnType(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage returnType = base.GetReturnType(parent, call);
					if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(returnType))
					{
						return returnType;
					}
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(returnType.EdmType), returnType.Facets);
				}
			}

			// Token: 0x02000D1E RID: 3358
			private sealed class AverageTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AggregateTranslator
			{
				// Token: 0x06006DB8 RID: 28088 RVA: 0x0017520E File Offset: 0x0017340E
				internal AverageTranslator() : base("Avg", false, new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDecimal,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDecimalSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDouble,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDoubleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageInt,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageIntSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageLong,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageLongSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageSingle,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageSingleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDecimal,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDecimalSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDouble,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDoubleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableInt,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableIntSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableLong,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableLongSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableSingle,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableSingleSelector
				})
				{
				}
			}

			// Token: 0x02000D1F RID: 3359
			private sealed class SumTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AggregateTranslator
			{
				// Token: 0x06006DB9 RID: 28089 RVA: 0x0017522E File Offset: 0x0017342E
				internal SumTranslator() : base("Sum", false, new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDecimal,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDecimalSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDouble,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDoubleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumInt,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumIntSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumLong,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumLongSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumSingle,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumSingleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDecimal,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDecimalSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDouble,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDoubleSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableInt,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableIntSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableLong,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableLongSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableSingle,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableSingleSelector
				})
				{
				}
			}

			// Token: 0x02000D20 RID: 3360
			private abstract class CountTranslatorBase : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.AggregateTranslator
			{
				// Token: 0x06006DBA RID: 28090 RVA: 0x0017524E File Offset: 0x0017344E
				protected CountTranslatorBase(string functionName, params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(functionName, true, methods)
				{
				}

				// Token: 0x06006DBB RID: 28091 RVA: 0x00175259 File Offset: 0x00173459
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression WrapCollectionOperand(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage returnType)
				{
					return operand.BindAs(parent.AliasGenerator.Next()).Project(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1));
				}

				// Token: 0x06006DBC RID: 28092 RVA: 0x0017527C File Offset: 0x0017347C
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression WrapNonCollectionOperand(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage returnType)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1);
					if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypeUsageEquals(dbExpression.ResultType, returnType))
					{
						dbExpression = dbExpression.CastTo(returnType);
					}
					return dbExpression;
				}

				// Token: 0x06006DBD RID: 28093 RVA: 0x001752AC File Offset: 0x001734AC
				protected override global::System.Data.Entity.Core.Metadata.Edm.EdmFunction FindFunction(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argumentType)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argumentType2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32));
					return base.FindFunction(parent, call, argumentType2);
				}
			}

			// Token: 0x02000D21 RID: 3361
			private sealed class CountTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CountTranslatorBase
			{
				// Token: 0x06006DBE RID: 28094 RVA: 0x001752D4 File Offset: 0x001734D4
				internal CountTranslator() : base("Count", new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Count,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.CountPredicate
				})
				{
				}
			}

			// Token: 0x02000D22 RID: 3362
			private sealed class LongCountTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CountTranslatorBase
			{
				// Token: 0x06006DBF RID: 28095 RVA: 0x001752F1 File Offset: 0x001734F1
				internal LongCountTranslator() : base("BigCount", new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LongCount,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LongCountPredicate
				})
				{
				}
			}

			// Token: 0x02000D23 RID: 3363
			private abstract class UnarySequenceMethodTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006DC0 RID: 28096 RVA: 0x0017530E File Offset: 0x0017350E
				protected UnarySequenceMethodTranslator(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
				}

				// Token: 0x06006DC1 RID: 28097 RVA: 0x00175318 File Offset: 0x00173518
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (call.Object != null)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand = parent.TranslateSet(call.Object);
						return this.TranslateUnary(parent, operand, call);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand2 = parent.TranslateSet(call.Arguments[0]);
					return this.TranslateUnary(parent, operand2, call);
				}

				// Token: 0x06006DC2 RID: 28098
				protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call);
			}

			// Token: 0x02000D24 RID: 3364
			private sealed class PassthroughTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.UnarySequenceMethodTranslator
			{
				// Token: 0x06006DC3 RID: 28099 RVA: 0x00175360 File Offset: 0x00173560
				internal PassthroughTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AsQueryableGeneric,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AsQueryable,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AsEnumerable,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ToList
				})
				{
				}

				// Token: 0x06006DC4 RID: 28100 RVA: 0x00175379 File Offset: 0x00173579
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(operand.ResultType))
					{
						return operand;
					}
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedPassthrough(call.Method.Name, operand.ResultType.EdmType.Name));
				}
			}

			// Token: 0x02000D25 RID: 3365
			private sealed class OfTypeTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.UnarySequenceMethodTranslator
			{
				// Token: 0x06006DC5 RID: 28101 RVA: 0x001753AF File Offset: 0x001735AF
				internal OfTypeTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OfType
				})
				{
				}

				// Token: 0x06006DC6 RID: 28102 RVA: 0x001753C4 File Offset: 0x001735C4
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Type type = call.Method.GetGenericArguments()[0];
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
					if (!parent.TryGetValueLayerType(type, out typeUsage) || (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(typeUsage)))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_InvalidOfTypeResult(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(type)));
					}
					return parent.OfType(operand, typeUsage);
				}
			}

			// Token: 0x02000D26 RID: 3366
			private sealed class DistinctTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.UnarySequenceMethodTranslator
			{
				// Token: 0x06006DC7 RID: 28103 RVA: 0x00175413 File Offset: 0x00173613
				internal DistinctTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Distinct
				})
				{
				}

				// Token: 0x06006DC8 RID: 28104 RVA: 0x00175426 File Offset: 0x00173626
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return parent.Distinct(operand);
				}
			}

			// Token: 0x02000D27 RID: 3367
			private sealed class AnyTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.UnarySequenceMethodTranslator
			{
				// Token: 0x06006DC9 RID: 28105 RVA: 0x0017542F File Offset: 0x0017362F
				internal AnyTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Any
				})
				{
				}

				// Token: 0x06006DCA RID: 28106 RVA: 0x00175442 File Offset: 0x00173642
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return operand.IsEmpty().Not();
				}
			}

			// Token: 0x02000D28 RID: 3368
			private abstract class OneLambdaTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006DCB RID: 28107 RVA: 0x0017544F File Offset: 0x0017364F
				internal OneLambdaTranslator(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
				}

				// Token: 0x06006DCC RID: 28108 RVA: 0x00175458 File Offset: 0x00173658
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2;
					return this.Translate(parent, call, out dbExpression, out dbExpressionBinding, out dbExpression2);
				}

				// Token: 0x06006DCD RID: 28109 RVA: 0x00175474 File Offset: 0x00173674
				protected global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda)
				{
					source = parent.TranslateExpression(call.Arguments[0]);
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = parent.GetLambdaExpression(call, 1);
					lambda = parent.TranslateLambda(lambdaExpression, source, out sourceBinding);
					return this.TranslateOneLambda(parent, sourceBinding, lambda);
				}

				// Token: 0x06006DCE RID: 28110
				protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateOneLambda(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda);
			}

			// Token: 0x02000D29 RID: 3369
			private sealed class AnyPredicateTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator
			{
				// Token: 0x06006DCF RID: 28111 RVA: 0x001754B9 File Offset: 0x001736B9
				internal AnyPredicateTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AnyPredicate
				})
				{
				}

				// Token: 0x06006DD0 RID: 28112 RVA: 0x001754CC File Offset: 0x001736CC
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateOneLambda(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda)
				{
					return sourceBinding.Any(lambda);
				}
			}

			// Token: 0x02000D2A RID: 3370
			private sealed class AllTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator
			{
				// Token: 0x06006DD1 RID: 28113 RVA: 0x001754D5 File Offset: 0x001736D5
				internal AllTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.All
				})
				{
				}

				// Token: 0x06006DD2 RID: 28114 RVA: 0x001754E8 File Offset: 0x001736E8
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateOneLambda(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda)
				{
					return sourceBinding.All(lambda);
				}
			}

			// Token: 0x02000D2B RID: 3371
			private sealed class WhereTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator
			{
				// Token: 0x06006DD3 RID: 28115 RVA: 0x001754F1 File Offset: 0x001736F1
				internal WhereTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[1])
				{
				}

				// Token: 0x06006DD4 RID: 28116 RVA: 0x001754FF File Offset: 0x001736FF
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateOneLambda(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda)
				{
					return parent.Filter(sourceBinding, lambda);
				}
			}

			// Token: 0x02000D2C RID: 3372
			private sealed class SelectTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator
			{
				// Token: 0x06006DD5 RID: 28117 RVA: 0x00175509 File Offset: 0x00173709
				internal SelectTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Select
				})
				{
				}

				// Token: 0x06006DD6 RID: 28118 RVA: 0x0017551C File Offset: 0x0017371C
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2;
					return base.Translate(parent, call, out dbExpression, out dbExpressionBinding, out dbExpression2);
				}

				// Token: 0x06006DD7 RID: 28119 RVA: 0x00175537 File Offset: 0x00173737
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateOneLambda(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda)
				{
					return parent.Project(sourceBinding, lambda);
				}
			}

			// Token: 0x02000D2D RID: 3373
			private sealed class DefaultIfEmptyTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006DD8 RID: 28120 RVA: 0x00175541 File Offset: 0x00173741
				internal DefaultIfEmptyTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.DefaultIfEmpty,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.DefaultIfEmptyValue
				})
				{
				}

				// Token: 0x06006DD9 RID: 28121 RVA: 0x0017555C File Offset: 0x0017375C
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateSet(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = (call.Arguments.Count == 2) ? parent.TranslateExpression(call.Arguments[1]) : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.DefaultIfEmptyTranslator.GetDefaultValue(parent, call.Type);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding left = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewCollection(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						new byte?((byte)1)
					}).BindAs(parent.AliasGenerator.Next());
					bool flag = dbExpression2 != null && dbExpression2.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null;
					if (flag)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbExpression.BindAs(parent.AliasGenerator.Next());
						dbExpression = dbExpressionBinding.Project(new global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Row(new byte?((byte)1).As("sentinel"), new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>[]
						{
							dbExpressionBinding.Variable.As("value")
						}));
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = dbExpression.BindAs(parent.AliasGenerator.Next());
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding3 = left.LeftOuterJoin(dbExpressionBinding2, new bool?(true)).BindAs(parent.AliasGenerator.Next());
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = dbExpressionBinding3.Variable.Property(dbExpressionBinding2.VariableName);
					if (flag)
					{
						dbExpression3 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression[]
						{
							dbExpression3.Property("sentinel").IsNull()
						}, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							dbExpression2
						}, dbExpression3.Property("value"));
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4 = dbExpressionBinding3.Project(dbExpression3);
					parent.ApplySpanMapping(dbExpression, dbExpression4);
					return dbExpression4;
				}

				// Token: 0x06006DDA RID: 28122 RVA: 0x001756E4 File Offset: 0x001738E4
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetDefaultValue(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Type resultType)
				{
					global::System.Type elementType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(resultType);
					object defaultValue = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetDefaultValue(elementType);
					if (defaultValue != null)
					{
						return parent.TranslateExpression(global::System.Linq.Expressions.Expression.Constant(defaultValue, elementType));
					}
					return null;
				}
			}

			// Token: 0x02000D2E RID: 3374
			private sealed class ContainsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006DDB RID: 28123 RVA: 0x00175711 File Offset: 0x00173911
				internal ContainsTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Contains
				})
				{
				}

				// Token: 0x06006DDC RID: 28124 RVA: 0x00175724 File Offset: 0x00173924
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator.TranslateContains(parent, call.Arguments[0], call.Arguments[1]);
				}

				// Token: 0x06006DDD RID: 28125 RVA: 0x00175744 File Offset: 0x00173944
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateContainsHelper(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> rightList, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern, global::System.Type leftType, global::System.Type rightType)
				{
					return global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(from argument in rightList
					select parent.CreateEqualsExpression(left, argument, pattern, leftType, rightType)), (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression prev, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression next) => prev.Or(next));
				}

				// Token: 0x06006DDE RID: 28126 RVA: 0x001757B8 File Offset: 0x001739B8
				internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateContains(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression sourceExpression, global::System.Linq.Expressions.Expression valueExpression)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.NormalizeSetSource(parent.TranslateExpression(sourceExpression));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = parent.TranslateExpression(valueExpression);
					global::System.Type elementType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(sourceExpression.Type);
					if (dbExpression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbExpression.BindAs(parent.AliasGenerator.Next());
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.Store;
						if (parent._funcletizer.RootContext.ContextOptions.UseCSharpNullComparisonBehavior)
						{
							pattern = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityComposable;
						}
						return dbExpressionBinding.Filter(parent.CreateEqualsExpression(dbExpressionBinding.Variable, dbExpression2, pattern, elementType, valueExpression.Type)).Exists();
					}
					global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments = ((global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbExpression).Arguments;
					if (arguments.Count <= 0)
					{
						return new bool?(false);
					}
					bool useCSharpNullComparisonBehavior = parent._funcletizer.RootContext.ContextOptions.UseCSharpNullComparisonBehavior;
					bool flag = parent.ProviderManifest.SupportsInExpression();
					if (!useCSharpNullComparisonBehavior && !flag)
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator.TranslateContainsHelper(parent, dbExpression2, arguments, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.Store, elementType, valueExpression.Type);
					}
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
					foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 in arguments)
					{
						((dbExpression3.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant) ? list : list2).Add(dbExpression3);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4 = null;
					if (list.Count > 0)
					{
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern2 = useCSharpNullComparisonBehavior ? global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityNonComposable : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.Store;
						dbExpression4 = (flag ? global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateInExpression(dbExpression2, list) : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator.TranslateContainsHelper(parent, dbExpression2, list, pattern2, elementType, valueExpression.Type));
						if (useCSharpNullComparisonBehavior)
						{
							dbExpression4 = dbExpression4.And(dbExpression2.IsNull().Not());
						}
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression5 = null;
					if (list2.Count > 0)
					{
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern3 = useCSharpNullComparisonBehavior ? global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityComposable : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.Store;
						dbExpression5 = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ContainsTranslator.TranslateContainsHelper(parent, dbExpression2, list2, pattern3, elementType, valueExpression.Type);
					}
					if (dbExpression4 == null)
					{
						return dbExpression5;
					}
					if (dbExpression5 == null)
					{
						return dbExpression4;
					}
					return dbExpression4.Or(dbExpression5);
				}
			}

			// Token: 0x02000D2F RID: 3375
			private abstract class FirstTranslatorBase : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.UnarySequenceMethodTranslator
			{
				// Token: 0x06006DDF RID: 28127 RVA: 0x0017599C File Offset: 0x00173B9C
				protected FirstTranslatorBase(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
				}

				// Token: 0x06006DE0 RID: 28128 RVA: 0x001759A5 File Offset: 0x00173BA5
				protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression LimitResult(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
				{
					return parent.Limit(expression, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1));
				}

				// Token: 0x06006DE1 RID: 28129 RVA: 0x001759BC File Offset: 0x00173BBC
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.LimitResult(parent, operand);
					if (!parent.IsQueryRoot(call))
					{
						dbExpression = dbExpression.Element();
						dbExpression = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstTranslatorBase.AddDefaultCase(dbExpression, call.Type);
					}
					global::System.Data.Entity.Core.Objects.Span span = null;
					if (parent.TryGetSpan(operand, out span))
					{
						parent.AddSpanMapping(dbExpression, span);
					}
					return dbExpression;
				}

				// Token: 0x06006DE2 RID: 28130 RVA: 0x00175A08 File Offset: 0x00173C08
				internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AddDefaultCase(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression element, global::System.Type elementType)
				{
					object defaultValue = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetDefaultValue(elementType);
					if (defaultValue == null)
					{
						return element;
					}
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
					{
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CreateIsNullExpression(element, elementType)
					}, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
					{
						element.ResultType.Constant(defaultValue)
					}, element);
				}
			}

			// Token: 0x02000D30 RID: 3376
			private sealed class FirstTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstTranslatorBase
			{
				// Token: 0x06006DE3 RID: 28131 RVA: 0x00175A54 File Offset: 0x00173C54
				internal FirstTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.First
				})
				{
				}

				// Token: 0x06006DE4 RID: 28132 RVA: 0x00175A67 File Offset: 0x00173C67
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (!parent.IsQueryRoot(call))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedNestedFirst);
					}
					return base.TranslateUnary(parent, operand, call);
				}
			}

			// Token: 0x02000D31 RID: 3377
			private sealed class FirstOrDefaultTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstTranslatorBase
			{
				// Token: 0x06006DE5 RID: 28133 RVA: 0x00175A86 File Offset: 0x00173C86
				internal FirstOrDefaultTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefault
				})
				{
				}
			}

			// Token: 0x02000D32 RID: 3378
			private abstract class SingleTranslatorBase : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstTranslatorBase
			{
				// Token: 0x06006DE6 RID: 28134 RVA: 0x00175A99 File Offset: 0x00173C99
				protected SingleTranslatorBase(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
				}

				// Token: 0x06006DE7 RID: 28135 RVA: 0x00175AA2 File Offset: 0x00173CA2
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (!parent.IsQueryRoot(call))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedNestedSingle);
					}
					return base.TranslateUnary(parent, operand, call);
				}

				// Token: 0x06006DE8 RID: 28136 RVA: 0x00175AC1 File Offset: 0x00173CC1
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression LimitResult(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
				{
					return parent.Limit(expression, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(2));
				}
			}

			// Token: 0x02000D33 RID: 3379
			private sealed class SingleTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SingleTranslatorBase
			{
				// Token: 0x06006DE9 RID: 28137 RVA: 0x00175AD5 File Offset: 0x00173CD5
				internal SingleTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Single
				})
				{
				}
			}

			// Token: 0x02000D34 RID: 3380
			private sealed class SingleOrDefaultTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SingleTranslatorBase
			{
				// Token: 0x06006DEA RID: 28138 RVA: 0x00175AE8 File Offset: 0x00173CE8
				internal SingleOrDefaultTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefault
				})
				{
				}
			}

			// Token: 0x02000D35 RID: 3381
			private abstract class FirstPredicateTranslatorBase : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator
			{
				// Token: 0x06006DEB RID: 28139 RVA: 0x00175AFB File Offset: 0x00173CFB
				protected FirstPredicateTranslatorBase(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
				}

				// Token: 0x06006DEC RID: 28140 RVA: 0x00175B04 File Offset: 0x00173D04
				protected virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RestrictResult(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
				{
					return parent.Limit(expression, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(1));
				}

				// Token: 0x06006DED RID: 28141 RVA: 0x00175B18 File Offset: 0x00173D18
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = base.Translate(parent, call);
					if (parent.IsQueryRoot(call))
					{
						return this.RestrictResult(parent, dbExpression);
					}
					dbExpression = this.RestrictResult(parent, dbExpression);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = dbExpression.Element();
					dbExpression2 = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstTranslatorBase.AddDefaultCase(dbExpression2, call.Type);
					global::System.Data.Entity.Core.Objects.Span span = null;
					if (parent.TryGetSpan(dbExpression, out span))
					{
						parent.AddSpanMapping(dbExpression2, span);
					}
					return dbExpression2;
				}

				// Token: 0x06006DEE RID: 28142 RVA: 0x00175B74 File Offset: 0x00173D74
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateOneLambda(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda)
				{
					return parent.Filter(sourceBinding, lambda);
				}
			}

			// Token: 0x02000D36 RID: 3382
			private sealed class FirstPredicateTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstPredicateTranslatorBase
			{
				// Token: 0x06006DEF RID: 28143 RVA: 0x00175B7E File Offset: 0x00173D7E
				internal FirstPredicateTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstPredicate
				})
				{
				}

				// Token: 0x06006DF0 RID: 28144 RVA: 0x00175B91 File Offset: 0x00173D91
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (!parent.IsQueryRoot(call))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedNestedFirst);
					}
					return base.Translate(parent, call);
				}
			}

			// Token: 0x02000D37 RID: 3383
			private sealed class FirstOrDefaultPredicateTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstPredicateTranslatorBase
			{
				// Token: 0x06006DF1 RID: 28145 RVA: 0x00175BAF File Offset: 0x00173DAF
				internal FirstOrDefaultPredicateTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefaultPredicate
				})
				{
				}
			}

			// Token: 0x02000D38 RID: 3384
			private abstract class SinglePredicateTranslatorBase : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.FirstPredicateTranslatorBase
			{
				// Token: 0x06006DF2 RID: 28146 RVA: 0x00175BC2 File Offset: 0x00173DC2
				protected SinglePredicateTranslatorBase(params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
				}

				// Token: 0x06006DF3 RID: 28147 RVA: 0x00175BCB File Offset: 0x00173DCB
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					if (!parent.IsQueryRoot(call))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedNestedSingle);
					}
					return base.Translate(parent, call);
				}

				// Token: 0x06006DF4 RID: 28148 RVA: 0x00175BE9 File Offset: 0x00173DE9
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression RestrictResult(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
				{
					return parent.Limit(expression, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(2));
				}
			}

			// Token: 0x02000D39 RID: 3385
			private sealed class SinglePredicateTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SinglePredicateTranslatorBase
			{
				// Token: 0x06006DF5 RID: 28149 RVA: 0x00175BFD File Offset: 0x00173DFD
				internal SinglePredicateTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SinglePredicate
				})
				{
				}
			}

			// Token: 0x02000D3A RID: 3386
			private sealed class SingleOrDefaultPredicateTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SinglePredicateTranslatorBase
			{
				// Token: 0x06006DF6 RID: 28150 RVA: 0x00175C10 File Offset: 0x00173E10
				internal SingleOrDefaultPredicateTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefaultPredicate
				})
				{
				}
			}

			// Token: 0x02000D3B RID: 3387
			private sealed class SelectManyTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator
			{
				// Token: 0x06006DF7 RID: 28151 RVA: 0x00175C23 File Offset: 0x00173E23
				internal SelectManyTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectMany,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectManyResultSelector
				})
				{
				}

				// Token: 0x06006DF8 RID: 28152 RVA: 0x00175C3C File Offset: 0x00173E3C
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = (call.Arguments.Count == 3) ? parent.GetLambdaExpression(call, 2) : null;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = base.Translate(parent, call);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding;
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty;
					if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SelectManyTranslator.IsLeftOuterJoin(dbExpression, out dbExpressionBinding, out edmProperty))
					{
						string varName;
						string varName2;
						global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
						if (lambdaExpression != null && global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.IsTrivialRename(lambdaExpression, parent, out varName, out varName2, out initializerMetadata))
						{
							global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = dbExpressionBinding.Expression.BindAs(varName);
							global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding3 = dbExpressionBinding2.Variable.Property(edmProperty.Name).BindAs(varName2);
							global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowType(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>
							{
								new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(dbExpressionBinding2.VariableName, dbExpressionBinding2.VariableType),
								new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(dbExpressionBinding3.VariableName, dbExpressionBinding3.VariableType)
							}, initializerMetadata));
							return new global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionType(elementType)), dbExpressionBinding2, dbExpressionBinding3);
						}
						dbExpression = dbExpressionBinding.OuterApply(dbExpressionBinding.Variable.Property(edmProperty).BindAs(parent.AliasGenerator.Next()));
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding4 = dbExpression.BindAs(parent.AliasGenerator.Next());
					global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)dbExpressionBinding4.Variable.ResultType.EdmType;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = dbExpressionBinding4.Variable.Property(rowType.Properties[1]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection;
					if (lambdaExpression != null)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqtExpression = dbExpressionBinding4.Variable.Property(rowType.Properties[0]);
						parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambdaExpression.Parameters[0], cqtExpression));
						parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambdaExpression.Parameters[1], dbExpression2));
						projection = parent.TranslateSet(lambdaExpression.Body);
						parent._bindingContext.PopBindingScope();
						parent._bindingContext.PopBindingScope();
					}
					else
					{
						projection = dbExpression2;
					}
					return dbExpressionBinding4.Project(projection);
				}

				// Token: 0x06006DF9 RID: 28153 RVA: 0x00175E10 File Offset: 0x00174010
				private static bool IsLeftOuterJoin(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqtExpression, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding crossApplyInput, out global::System.Data.Entity.Core.Metadata.Edm.EdmProperty lojRightInput)
				{
					crossApplyInput = null;
					lojRightInput = null;
					if (cqtExpression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply)
					{
						return false;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression dbApplyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression)cqtExpression;
					if (dbApplyExpression.Input.VariableType.EdmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
					{
						return false;
					}
					global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)dbApplyExpression.Input.VariableType.EdmType;
					if (dbApplyExpression.Apply.Expression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
					{
						return false;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)dbApplyExpression.Apply.Expression;
					if (dbProjectExpression.Input.Expression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin)
					{
						return false;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression dbJoinExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression)dbProjectExpression.Input.Expression;
					if (dbProjectExpression.Projection.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
					{
						return false;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbProjectExpression.Projection;
					if (dbPropertyExpression.Instance != dbProjectExpression.Input.Variable || dbPropertyExpression.Property.Name != dbJoinExpression.Right.VariableName || dbJoinExpression.JoinCondition.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return false;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)dbJoinExpression.JoinCondition;
					if (!(dbConstantExpression.Value is bool) || !(bool)dbConstantExpression.Value)
					{
						return false;
					}
					if (dbJoinExpression.Left.Expression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)
					{
						return false;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbJoinExpression.Left.Expression;
					if (dbNewInstanceExpression.Arguments.Count != 1 || dbNewInstanceExpression.Arguments[0].ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return false;
					}
					if (dbJoinExpression.Right.Expression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
					{
						return false;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression lojRight = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbJoinExpression.Right.Expression;
					if (lojRight.Instance != dbApplyExpression.Input.Variable)
					{
						return false;
					}
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = rowType.Properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Name == lojRight.Property.Name);
					if (edmProperty == null)
					{
						return false;
					}
					crossApplyInput = dbApplyExpression.Input;
					lojRightInput = edmProperty;
					return true;
				}

				// Token: 0x06006DFA RID: 28154 RVA: 0x00176010 File Offset: 0x00174210
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateOneLambda(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda)
				{
					lambda = parent.NormalizeSetSource(lambda);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply = lambda.BindAs(parent.AliasGenerator.Next());
					return sourceBinding.CrossApply(apply);
				}
			}

			// Token: 0x02000D3C RID: 3388
			private sealed class CastMethodTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006DFB RID: 28155 RVA: 0x0017603F File Offset: 0x0017423F
				internal CastMethodTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Cast
				})
				{
				}

				// Token: 0x06006DFC RID: 28156 RVA: 0x00176054 File Offset: 0x00174254
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input = parent.TranslateSet(call.Arguments[0]);
					global::System.Type elementType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(call.Type);
					global::System.Type elementType2 = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(call.Arguments[0].Type);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = input.BindAs(parent.AliasGenerator.Next());
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = parent.CreateCastExpression(dbExpressionBinding.Variable, elementType, elementType2);
					return parent.Project(dbExpressionBinding, projection);
				}
			}

			// Token: 0x02000D3D RID: 3389
			private sealed class GroupByTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006DFD RID: 28157 RVA: 0x001760BE File Offset: 0x001742BE
				internal GroupByTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupBy,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorResultSelector,
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByResultSelector
				})
				{
				}

				// Token: 0x06006DFE RID: 28158 RVA: 0x001760D8 File Offset: 0x001742D8
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input = parent.TranslateSet(call.Arguments[0]);
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = parent.GetLambdaExpression(call, 1);
					global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding dbGroupExpressionBinding;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateLambda(lambdaExpression, input, out dbGroupExpressionBinding);
					if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(dbExpression.ResultType))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedKeySelector(call.Method.Name));
					}
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>>();
					list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>("Key", dbExpression));
					list2.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>("Group", dbGroupExpressionBinding.GroupAggregate));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbGroupExpressionBinding.GroupBy(list, list2).BindAs(parent.AliasGenerator.Next());
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = dbExpressionBinding.Variable.Property("Group");
					if (sequenceMethod == global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelector || sequenceMethod == global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorResultSelector)
					{
						global::System.Linq.Expressions.LambdaExpression lambdaExpression2 = parent.GetLambdaExpression(call, 2);
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input2;
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = parent.TranslateLambda(lambdaExpression2, dbExpression2, out input2);
						dbExpression2 = input2.Project(projection);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] array = new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbExpressionBinding.Variable.Property("Key"),
						dbExpression2
					};
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(2);
					list3.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Key", array[0].ResultType));
					list3.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Group", array[1].ResultType));
					global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.CreateGroupingInitializer(parent.EdmItemCollection, global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(call.Type));
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage instanceType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.RowType(list3, initializerMetadata));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = dbExpressionBinding.Project(instanceType.New(array));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = dbExpression3;
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GroupByTranslator.ProcessResultSelector(parent, call, sequenceMethod, dbExpression3, result);
				}

				// Token: 0x06006DFF RID: 28159 RVA: 0x00176270 File Offset: 0x00174470
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ProcessResultSelector(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression topLevelProject, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result)
				{
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = null;
					if (sequenceMethod == global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByResultSelector)
					{
						lambdaExpression = parent.GetLambdaExpression(call, 2);
					}
					else if (sequenceMethod == global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorResultSelector)
					{
						lambdaExpression = parent.GetLambdaExpression(call, 3);
					}
					if (lambdaExpression != null)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = topLevelProject.BindAs(parent.AliasGenerator.Next());
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression cqtExpression = dbExpressionBinding.Variable.Property("Key");
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression cqtExpression2 = dbExpressionBinding.Variable.Property("Group");
						parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambdaExpression.Parameters[0], cqtExpression));
						parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambdaExpression.Parameters[1], cqtExpression2));
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = parent.TranslateExpression(lambdaExpression.Body);
						result = dbExpressionBinding.Project(projection);
						parent._bindingContext.PopBindingScope();
						parent._bindingContext.PopBindingScope();
					}
					return result;
				}

				// Token: 0x06006E00 RID: 28160 RVA: 0x0017633D File Offset: 0x0017453D
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					return null;
				}
			}

			// Token: 0x02000D3E RID: 3390
			private sealed class GroupJoinTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006E01 RID: 28161 RVA: 0x00176340 File Offset: 0x00174540
				internal GroupJoinTranslator() : base(new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupJoin
				})
				{
				}

				// Token: 0x06006E02 RID: 28162 RVA: 0x00176354 File Offset: 0x00174554
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input = parent.TranslateSet(call.Arguments[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input2 = parent.TranslateSet(call.Arguments[1]);
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = parent.GetLambdaExpression(call, 2);
					global::System.Linq.Expressions.LambdaExpression lambdaExpression2 = parent.GetLambdaExpression(call, 3);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateLambda(lambdaExpression, input, out dbExpressionBinding);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input3;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = parent.TranslateLambda(lambdaExpression2, input2, out input3);
					if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(dbExpression.ResultType) || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(dbExpression2.ResultType))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedKeySelector(call.Method.Name));
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = parent.Filter(input3, parent.CreateEqualsExpression(dbExpression, dbExpression2, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityNonComposable, lambdaExpression.Body.Type, lambdaExpression2.Body.Type));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(2)
					{
						new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>("o", dbExpressionBinding.Variable),
						new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>("i", value)
					});
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = dbExpressionBinding.Project(projection).BindAs(parent.AliasGenerator.Next());
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqtExpression = dbExpressionBinding2.Variable.Property("o");
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqtExpression2 = dbExpressionBinding2.Variable.Property("i");
					global::System.Linq.Expressions.LambdaExpression lambdaExpression3 = parent.GetLambdaExpression(call, 4);
					parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambdaExpression3.Parameters[0], cqtExpression));
					parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(lambdaExpression3.Parameters[1], cqtExpression2));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection2 = parent.TranslateExpression(lambdaExpression3.Body);
					parent._bindingContext.PopBindingScope();
					parent._bindingContext.PopBindingScope();
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.GroupJoinTranslator.CollapseTrivialRenamingProjection(dbExpressionBinding2.Project(projection2));
				}

				// Token: 0x06006E03 RID: 28163 RVA: 0x00176500 File Offset: 0x00174700
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CollapseTrivialRenamingProjection(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqtExpression)
				{
					if (cqtExpression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
					{
						return cqtExpression;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)cqtExpression;
					if (dbProjectExpression.Projection.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance || dbProjectExpression.Projection.ResultType.EdmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
					{
						return cqtExpression;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbProjectExpression.Projection;
					global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)dbNewInstanceExpression.ResultType.EdmType;
					global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, string>> list = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, string>>();
					for (int i = 0; i < dbNewInstanceExpression.Arguments.Count; i++)
					{
						if (dbNewInstanceExpression.Arguments[i].ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
						{
							return cqtExpression;
						}
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbNewInstanceExpression.Arguments[i];
						if (dbPropertyExpression.Instance != dbProjectExpression.Input.Variable)
						{
							return cqtExpression;
						}
						list.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, string>((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)dbPropertyExpression.Property, rowType.Properties[i].Name));
					}
					if (dbProjectExpression.Input.Expression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
					{
						return cqtExpression;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)dbProjectExpression.Input.Expression;
					if (dbProjectExpression2.Projection.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance || dbProjectExpression2.Projection.ResultType.EdmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
					{
						return cqtExpression;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbProjectExpression2.Projection;
					global::System.Data.Entity.Core.Metadata.Edm.RowType rowType2 = (global::System.Data.Entity.Core.Metadata.Edm.RowType)dbNewInstanceExpression2.ResultType.EdmType;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
					foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, string> tuple in list)
					{
						int index = rowType2.Properties.IndexOf(tuple.Item1);
						list2.Add(dbNewInstanceExpression2.Arguments[index]);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression projection = dbNewInstanceExpression.ResultType.New(list2);
					return dbProjectExpression2.Input.Project(projection);
				}
			}

			// Token: 0x02000D3F RID: 3391
			private abstract class OrderByTranslatorBase : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OneLambdaTranslator
			{
				// Token: 0x06006E04 RID: 28164 RVA: 0x001766F4 File Offset: 0x001748F4
				protected OrderByTranslatorBase(bool ascending, params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
					this._ascending = ascending;
				}

				// Token: 0x06006E05 RID: 28165 RVA: 0x00176704 File Offset: 0x00174904
				protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateOneLambda(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sourceBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambda)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(1);
					global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause item = this._ascending ? lambda.ToSortClause() : lambda.ToSortClauseDescending();
					list.Add(item);
					return parent.Sort(sourceBinding, list);
				}

				// Token: 0x04003294 RID: 12948
				private readonly bool _ascending;
			}

			// Token: 0x02000D40 RID: 3392
			private sealed class OrderByTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OrderByTranslatorBase
			{
				// Token: 0x06006E06 RID: 28166 RVA: 0x0017673E File Offset: 0x0017493E
				internal OrderByTranslator() : base(true, new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderBy
				})
				{
				}
			}

			// Token: 0x02000D41 RID: 3393
			private sealed class OrderByDescendingTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.OrderByTranslatorBase
			{
				// Token: 0x06006E07 RID: 28167 RVA: 0x00176752 File Offset: 0x00174952
				internal OrderByDescendingTranslator() : base(false, new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderByDescending
				})
				{
				}
			}

			// Token: 0x02000D42 RID: 3394
			private abstract class ThenByTranslatorBase : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SequenceMethodTranslator
			{
				// Token: 0x06006E08 RID: 28168 RVA: 0x00176766 File Offset: 0x00174966
				protected ThenByTranslatorBase(bool ascending, params global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[] methods) : base(methods)
				{
					this._ascending = ascending;
				}

				// Token: 0x06006E09 RID: 28169 RVA: 0x00176778 File Offset: 0x00174978
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateSet(call.Arguments[0]);
					if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort != dbExpression.ExpressionKind)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ELinq_ThenByDoesNotFollowOrderBy);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression dbSortExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression)dbExpression;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input = dbSortExpression.Input;
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = parent.GetLambdaExpression(call, 1);
					global::System.Linq.Expressions.ParameterExpression linqExpression = lambdaExpression.Parameters[0];
					parent._bindingContext.PushBindingScope(new global::System.Data.Entity.Core.Objects.ELinq.Binding(linqExpression, input.Variable));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key = parent.TranslateExpression(lambdaExpression.Body);
					parent._bindingContext.PopBindingScope();
					return parent.Sort(input, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(dbSortExpression.SortOrder)
					{
						new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause(key, this._ascending, null)
					});
				}

				// Token: 0x04003295 RID: 12949
				private readonly bool _ascending;
			}

			// Token: 0x02000D43 RID: 3395
			private sealed class ThenByTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ThenByTranslatorBase
			{
				// Token: 0x06006E0A RID: 28170 RVA: 0x0017682A File Offset: 0x00174A2A
				internal ThenByTranslator() : base(true, new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenBy
				})
				{
				}
			}

			// Token: 0x02000D44 RID: 3396
			private sealed class ThenByDescendingTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.ThenByTranslatorBase
			{
				// Token: 0x06006E0B RID: 28171 RVA: 0x0017683E File Offset: 0x00174A3E
				internal ThenByDescendingTranslator() : base(false, new global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenByDescending
				})
				{
				}
			}

			// Token: 0x02000D45 RID: 3397
			private sealed class SpatialMethodCallTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.CallTranslator
			{
				// Token: 0x06006E0C RID: 28172 RVA: 0x00176852 File Offset: 0x00174A52
				internal SpatialMethodCallTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetSupportedMethods())
				{
				}

				// Token: 0x06006E0D RID: 28173 RVA: 0x0017685F File Offset: 0x00174A5F
				private static global::System.Reflection.MethodInfo GetStaticMethod<TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TResult>> lambda)
				{
					return ((global::System.Linq.Expressions.MethodCallExpression)lambda.Body).Method;
				}

				// Token: 0x06006E0E RID: 28174 RVA: 0x00176871 File Offset: 0x00174A71
				private static global::System.Reflection.MethodInfo GetInstanceMethod<T, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<T, TResult>> lambda)
				{
					return ((global::System.Linq.Expressions.MethodCallExpression)lambda.Body).Method;
				}

				// Token: 0x06006E0F RID: 28175 RVA: 0x00176883 File Offset: 0x00174A83
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetSupportedMethods()
				{
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromText(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.PointFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.LineFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.PolygonFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiPointFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiLineFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiPolygonFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.GeographyCollectionFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromBinary(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.PointFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.LineFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.PolygonFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiPointFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiLineFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiPolygonFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.GeographyCollectionFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromGml(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromGml(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, byte[]>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.AsBinary());
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, string>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.AsGml());
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, string>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.AsText());
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, bool>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.SpatialEquals(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, bool>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Disjoint(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, bool>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Intersects(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Buffer((double?)0.0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Distance(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Intersection(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Union(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Difference(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.SymmetricDifference(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.ElementAt(0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.PointAt(0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromText(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.PointFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.LineFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.PolygonFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiPointFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiLineFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiPolygonFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.GeometryCollectionFromText(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromBinary(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.PointFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.LineFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.PolygonFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiPointFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiLineFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiPolygonFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.GeometryCollectionFromBinary(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromGml(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromGml(null, 0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, byte[]>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.AsBinary());
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, string>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.AsGml());
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, string>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.AsText());
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.SpatialEquals(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Disjoint(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Intersects(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Touches(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Crosses(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Within(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Contains(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Overlaps(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Relate(null, null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Buffer((double?)0.0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Distance(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Intersection(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Union(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Difference(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.SymmetricDifference(null));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.ElementAt(0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.PointAt(0));
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.InteriorRingAt(0));
					yield break;
				}

				// Token: 0x06006E10 RID: 28176 RVA: 0x0017688C File Offset: 0x00174A8C
				private static global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, string> GetRenamedMethodFunctions()
				{
					return new global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, string>
					{
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromText(null)),
							"GeographyFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromText(null, 0)),
							"GeographyFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.PointFromText(null, 0)),
							"GeographyPointFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.LineFromText(null, 0)),
							"GeographyLineFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.PolygonFromText(null, 0)),
							"GeographyPolygonFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiPointFromText(null, 0)),
							"GeographyMultiPointFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiLineFromText(null, 0)),
							"GeographyMultiLineFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiPolygonFromText(null, 0)),
							"GeographyMultiPolygonFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.GeographyCollectionFromText(null, 0)),
							"GeographyCollectionFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromBinary(null, 0)),
							"GeographyFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromBinary(null)),
							"GeographyFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.PointFromBinary(null, 0)),
							"GeographyPointFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.LineFromBinary(null, 0)),
							"GeographyLineFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.PolygonFromBinary(null, 0)),
							"GeographyPolygonFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiPointFromBinary(null, 0)),
							"GeographyMultiPointFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiLineFromBinary(null, 0)),
							"GeographyMultiLineFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.MultiPolygonFromBinary(null, 0)),
							"GeographyMultiPolygonFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.GeographyCollectionFromBinary(null, 0)),
							"GeographyCollectionFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromGml(null)),
							"GeographyFromGml"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeography>(() => global::System.Data.Entity.Spatial.DbGeography.FromGml(null, 0)),
							"GeographyFromGml"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, byte[]>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.AsBinary()),
							"AsBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, string>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.AsGml()),
							"AsGml"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, string>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.AsText()),
							"AsText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, bool>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.SpatialEquals(null)),
							"SpatialEquals"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, bool>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Disjoint(null)),
							"SpatialDisjoint"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, bool>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Intersects(null)),
							"SpatialIntersects"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Buffer((double?)0.0)),
							"SpatialBuffer"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Distance(null)),
							"Distance"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Intersection(null)),
							"SpatialIntersection"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Union(null)),
							"SpatialUnion"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Difference(null)),
							"SpatialDifference"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.SymmetricDifference(null)),
							"SpatialSymmetricDifference"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.ElementAt(0)),
							"SpatialElementAt"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.PointAt(0)),
							"PointAt"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromText(null)),
							"GeometryFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromText(null, 0)),
							"GeometryFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.PointFromText(null, 0)),
							"GeometryPointFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.LineFromText(null, 0)),
							"GeometryLineFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.PolygonFromText(null, 0)),
							"GeometryPolygonFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiPointFromText(null, 0)),
							"GeometryMultiPointFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiLineFromText(null, 0)),
							"GeometryMultiLineFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiPolygonFromText(null, 0)),
							"GeometryMultiPolygonFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.GeometryCollectionFromText(null, 0)),
							"GeometryCollectionFromText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromBinary(null)),
							"GeometryFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromBinary(null, 0)),
							"GeometryFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.PointFromBinary(null, 0)),
							"GeometryPointFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.LineFromBinary(null, 0)),
							"GeometryLineFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.PolygonFromBinary(null, 0)),
							"GeometryPolygonFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiPointFromBinary(null, 0)),
							"GeometryMultiPointFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiLineFromBinary(null, 0)),
							"GeometryMultiLineFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.MultiPolygonFromBinary(null, 0)),
							"GeometryMultiPolygonFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.GeometryCollectionFromBinary(null, 0)),
							"GeometryCollectionFromBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromGml(null)),
							"GeometryFromGml"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetStaticMethod<global::System.Data.Entity.Spatial.DbGeometry>(() => global::System.Data.Entity.Spatial.DbGeometry.FromGml(null, 0)),
							"GeometryFromGml"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, byte[]>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.AsBinary()),
							"AsBinary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, string>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.AsGml()),
							"AsGml"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, string>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.AsText()),
							"AsText"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.SpatialEquals(null)),
							"SpatialEquals"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Disjoint(null)),
							"SpatialDisjoint"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Intersects(null)),
							"SpatialIntersects"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Touches(null)),
							"SpatialTouches"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Crosses(null)),
							"SpatialCrosses"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Within(null)),
							"SpatialWithin"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Contains(null)),
							"SpatialContains"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Overlaps(null)),
							"SpatialOverlaps"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Relate(null, null)),
							"SpatialRelate"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Buffer((double?)0.0)),
							"SpatialBuffer"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Distance(null)),
							"Distance"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Intersection(null)),
							"SpatialIntersection"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Union(null)),
							"SpatialUnion"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Difference(null)),
							"SpatialDifference"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.SymmetricDifference(null)),
							"SpatialSymmetricDifference"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.ElementAt(0)),
							"SpatialElementAt"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.PointAt(0)),
							"PointAt"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetInstanceMethod<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.InteriorRingAt(0)),
							"InteriorRingAt"
						}
					};
				}

				// Token: 0x06006E11 RID: 28177 RVA: 0x00178490 File Offset: 0x00176690
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MethodCallExpression call)
				{
					global::System.Reflection.MethodInfo method = call.Method;
					string functionName;
					if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator._methodFunctionRenames.TryGetValue(method, out functionName))
					{
						functionName = "ST" + method.Name;
					}
					global::System.Linq.Expressions.Expression[] linqArguments;
					if (method.IsStatic)
					{
						linqArguments = call.Arguments.ToArray<global::System.Linq.Expressions.Expression>();
					}
					else
					{
						linqArguments = new global::System.Linq.Expressions.Expression[]
						{
							call.Object
						}.Concat(call.Arguments).ToArray<global::System.Linq.Expressions.Expression>();
					}
					return parent.TranslateIntoCanonicalFunction(functionName, call, linqArguments);
				}

				// Token: 0x04003296 RID: 12950
				private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, string> _methodFunctionRenames = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MethodCallTranslator.SpatialMethodCallTranslator.GetRenamedMethodFunctions();
			}
		}

		// Token: 0x02000A75 RID: 2677
		private sealed class OrderByLifter
		{
			// Token: 0x06006217 RID: 25111 RVA: 0x001537B9 File Offset: 0x001519B9
			internal OrderByLifter(global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator)
			{
				this._aliasGenerator = aliasGenerator;
			}

			// Token: 0x06006218 RID: 25112 RVA: 0x001537C8 File Offset: 0x001519C8
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection)
			{
				return this.GetLifter(input.Expression).Project(input.Project(projection));
			}

			// Token: 0x06006219 RID: 25113 RVA: 0x001537E2 File Offset: 0x001519E2
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate)
			{
				return this.GetLifter(input.Expression).Filter(input.Filter(predicate));
			}

			// Token: 0x0600621A RID: 25114 RVA: 0x001537FC File Offset: 0x001519FC
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression OfType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
			{
				return this.GetLifter(argument).OfType(type);
			}

			// Token: 0x0600621B RID: 25115 RVA: 0x0015380B File Offset: 0x00151A0B
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression skipCount)
			{
				return this.GetLifter(input.Expression).Skip(skipCount);
			}

			// Token: 0x0600621C RID: 25116 RVA: 0x0015381F File Offset: 0x00151A1F
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression limit)
			{
				return this.GetLifter(argument).Limit(limit);
			}

			// Token: 0x0600621D RID: 25117 RVA: 0x0015382E File Offset: 0x00151A2E
			private global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase GetLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression root)
			{
				return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.GetLifter(root, this._aliasGenerator);
			}

			// Token: 0x04002B34 RID: 11060
			private readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _aliasGenerator;

			// Token: 0x02000D49 RID: 3401
			private abstract class OrderByLifterBase
			{
				// Token: 0x06006E2B RID: 28203 RVA: 0x00178D6F File Offset: 0x00176F6F
				protected OrderByLifterBase(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression root, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator)
				{
					this._root = root;
					this._aliasGenerator = aliasGenerator;
				}

				// Token: 0x06006E2C RID: 28204 RVA: 0x00178D88 File Offset: 0x00176F88
				internal static global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase GetLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator)
				{
					if (source.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort)
					{
						return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.SortLifter((global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression)source, aliasGenerator);
					}
					if (source.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)source;
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression = dbProjectExpression.Input.Expression;
						if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort)
						{
							return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.ProjectSortLifter(dbProjectExpression, (global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression)expression, aliasGenerator);
						}
						if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip)
						{
							return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.ProjectSkipLifter(dbProjectExpression, (global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression)expression, aliasGenerator);
						}
						if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit)
						{
							global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression dbLimitExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression)expression;
							global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument = dbLimitExpression.Argument;
							if (argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort)
							{
								return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.ProjectLimitSortLifter(dbProjectExpression, dbLimitExpression, (global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression)argument, aliasGenerator);
							}
							if (argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip)
							{
								return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.ProjectLimitSkipLifter(dbProjectExpression, dbLimitExpression, (global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression)argument, aliasGenerator);
							}
						}
					}
					if (source.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip)
					{
						return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.SkipLifter((global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression)source, aliasGenerator);
					}
					if (source.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression dbLimitExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression)source;
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument2 = dbLimitExpression2.Argument;
						if (argument2.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort)
						{
							return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.LimitSortLifter(dbLimitExpression2, (global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression)argument2, aliasGenerator);
						}
						if (argument2.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip)
						{
							return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.LimitSkipLifter(dbLimitExpression2, (global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression)argument2, aliasGenerator);
						}
						if (argument2.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
						{
							global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)argument2;
							global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression2 = dbProjectExpression2.Input.Expression;
							if (expression2.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort)
							{
								return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.ProjectLimitSortLifter(dbProjectExpression2, dbLimitExpression2, (global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression)expression2, aliasGenerator);
							}
							if (expression2.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip)
							{
								return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.ProjectLimitSkipLifter(dbProjectExpression2, dbLimitExpression2, (global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression)expression2, aliasGenerator);
							}
						}
					}
					return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.PassthroughOrderByLifter(source, aliasGenerator);
				}

				// Token: 0x06006E2D RID: 28205
				internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project);

				// Token: 0x06006E2E RID: 28206
				internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter);

				// Token: 0x06006E2F RID: 28207 RVA: 0x00178F14 File Offset: 0x00177114
				internal virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression OfType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = this._root.BindAs(this._aliasGenerator.Next());
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.Filter(dbExpressionBinding.Filter(dbExpressionBinding.Variable.IsOf(type)));
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase lifter = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.GetLifter(dbExpression, this._aliasGenerator);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = dbExpression.BindAs(this._aliasGenerator.Next());
					return lifter.Project(dbExpressionBinding2.Project(dbExpressionBinding2.Variable.TreatAs(type)));
				}

				// Token: 0x06006E30 RID: 28208
				internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k);

				// Token: 0x06006E31 RID: 28209
				internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k);

				// Token: 0x06006E32 RID: 28210 RVA: 0x00178F88 File Offset: 0x00177188
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression ComposeProject(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression first, global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression second)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(second.Projection, new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[]
					{
						second.Input.Variable
					});
					global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project = first.Input.Project(lambda.Invoke(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						first.Projection
					}));
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(input, project);
				}

				// Token: 0x06006E33 RID: 28211 RVA: 0x00178FE0 File Offset: 0x001771E0
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression ComposeFilter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression first, global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression second)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(second.Predicate, new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[]
					{
						second.Input.Variable
					});
					global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter = first.Input.Filter(lambda.Invoke(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						first.Projection
					}));
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindFilter(input, filter);
				}

				// Token: 0x06006E34 RID: 28212 RVA: 0x00179038 File Offset: 0x00177238
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression AddToSkip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression skip, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression plusK)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.CombineIntegers(skip.Count, plusK, (int l, int r) => l + r);
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSkip(input, skip, k);
				}

				// Token: 0x06006E35 RID: 28213 RVA: 0x0017907C File Offset: 0x0017727C
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression SubtractFromLimit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression limit, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression minusK)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.CombineIntegers(limit.Limit, minusK, delegate(int l, int r)
					{
						if (r <= l)
						{
							return l - r;
						}
						return 0;
					});
					return input.Limit(count);
				}

				// Token: 0x06006E36 RID: 28214 RVA: 0x001790BC File Offset: 0x001772BC
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression MinimumLimit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression limit, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.CombineIntegers(limit.Limit, k, new global::System.Func<int, int, int>(global::System.Math.Min));
					return input.Limit(count);
				}

				// Token: 0x06006E37 RID: 28215 RVA: 0x001790EC File Offset: 0x001772EC
				private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CombineIntegers(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Func<int, int, int> combineConstants)
				{
					if (left.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && right.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						object value = ((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)left).Value;
						object value2 = ((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)right).Value;
						if (value is int && value2 is int)
						{
							return left.ResultType.Constant(combineConstants((int)value, (int)value2));
						}
					}
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1025));
				}

				// Token: 0x06006E38 RID: 28216 RVA: 0x0017916A File Offset: 0x0017736A
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression RebindProject(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return input.BindAs(project.Input.VariableName).Project(project.Projection);
				}

				// Token: 0x06006E39 RID: 28217 RVA: 0x00179188 File Offset: 0x00177388
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression RebindFilter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return input.BindAs(filter.Input.VariableName).Filter(filter.Predicate);
				}

				// Token: 0x06006E3A RID: 28218 RVA: 0x001791A6 File Offset: 0x001773A6
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression RebindSort(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression sort)
				{
					return input.BindAs(sort.Input.VariableName).Sort(sort.SortOrder);
				}

				// Token: 0x06006E3B RID: 28219 RVA: 0x001791C4 File Offset: 0x001773C4
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression ApplySkipOrderToSort(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression sortSpec)
				{
					return input.BindAs(sortSpec.Input.VariableName).Sort(sortSpec.SortOrder);
				}

				// Token: 0x06006E3C RID: 28220 RVA: 0x001791E2 File Offset: 0x001773E2
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression ApplySortOrderToSkip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression sort, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return input.BindAs(sort.Input.VariableName).Skip(sort.SortOrder, k);
				}

				// Token: 0x06006E3D RID: 28221 RVA: 0x00179201 File Offset: 0x00177401
				protected static global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression RebindSkip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression skip, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return input.BindAs(skip.Input.VariableName).Skip(skip.SortOrder, k);
				}

				// Token: 0x040032A2 RID: 12962
				protected readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _root;

				// Token: 0x040032A3 RID: 12963
				protected readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _aliasGenerator;
			}

			// Token: 0x02000D4A RID: 3402
			private class LimitSkipLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E3E RID: 28222 RVA: 0x00179220 File Offset: 0x00177420
				internal LimitSkipLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression limit, global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression skip, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(limit, aliasGenerator)
				{
					this._limit = limit;
					this._skip = skip;
				}

				// Token: 0x06006E3F RID: 28223 RVA: 0x00179238 File Offset: 0x00177438
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySkipOrderToSort(filter, this._skip);
				}

				// Token: 0x06006E40 RID: 28224 RVA: 0x00179246 File Offset: 0x00177446
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return project;
				}

				// Token: 0x06006E41 RID: 28225 RVA: 0x0017924C File Offset: 0x0017744C
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					if (this._limit.Limit.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && k.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.MinimumLimit(this._skip, this._limit, k);
					}
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySkipOrderToSort(this._limit, this._skip).Limit(k);
				}

				// Token: 0x06006E42 RID: 28226 RVA: 0x0017929F File Offset: 0x0017749F
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSkip(this._limit, this._skip, k);
				}

				// Token: 0x040032A4 RID: 12964
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression _limit;

				// Token: 0x040032A5 RID: 12965
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression _skip;
			}

			// Token: 0x02000D4B RID: 3403
			private class LimitSortLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E43 RID: 28227 RVA: 0x001792B3 File Offset: 0x001774B3
				internal LimitSortLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression limit, global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression sort, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(limit, aliasGenerator)
				{
					this._limit = limit;
					this._sort = sort;
				}

				// Token: 0x06006E44 RID: 28228 RVA: 0x001792CB File Offset: 0x001774CB
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSort(filter, this._sort);
				}

				// Token: 0x06006E45 RID: 28229 RVA: 0x001792D9 File Offset: 0x001774D9
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return project;
				}

				// Token: 0x06006E46 RID: 28230 RVA: 0x001792DC File Offset: 0x001774DC
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					if (this._limit.Limit.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && k.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.MinimumLimit(this._sort, this._limit, k);
					}
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSort(this._limit, this._sort).Limit(k);
				}

				// Token: 0x06006E47 RID: 28231 RVA: 0x0017932F File Offset: 0x0017752F
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySortOrderToSkip(this._limit, this._sort, k);
				}

				// Token: 0x040032A6 RID: 12966
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression _limit;

				// Token: 0x040032A7 RID: 12967
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression _sort;
			}

			// Token: 0x02000D4C RID: 3404
			private class ProjectLimitSkipLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E48 RID: 28232 RVA: 0x00179343 File Offset: 0x00177543
				internal ProjectLimitSkipLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project, global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression limit, global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression skip, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(project, aliasGenerator)
				{
					this._project = project;
					this._limit = limit;
					this._skip = skip;
					this._source = skip.Input.Expression;
				}

				// Token: 0x06006E49 RID: 28233 RVA: 0x00179374 File Offset: 0x00177574
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySkipOrderToSort(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ComposeFilter(this._skip.Limit(this._limit.Limit), this._project, filter), this._skip), this._project);
				}

				// Token: 0x06006E4A RID: 28234 RVA: 0x001793AE File Offset: 0x001775AE
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ComposeProject(this._skip.Limit(this._limit.Limit), this._project, project);
				}

				// Token: 0x06006E4B RID: 28235 RVA: 0x001793D4 File Offset: 0x001775D4
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					if (this._limit.Limit.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && k.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.MinimumLimit(this._skip, this._limit, k), this._project);
					}
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySkipOrderToSort(this._skip.Limit(this._limit.Limit), this._skip).Limit(k), this._project);
				}

				// Token: 0x06006E4C RID: 28236 RVA: 0x00179450 File Offset: 0x00177650
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					if (this._skip.Count.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && this._limit.Limit.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && k.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.SubtractFromLimit(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.AddToSkip(this._source, this._skip, k), this._limit, k), this._project);
					}
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSkip(this._skip.Limit(this._limit.Limit), this._skip, k), this._project);
				}

				// Token: 0x040032A8 RID: 12968
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression _project;

				// Token: 0x040032A9 RID: 12969
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression _limit;

				// Token: 0x040032AA RID: 12970
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression _skip;

				// Token: 0x040032AB RID: 12971
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _source;
			}

			// Token: 0x02000D4D RID: 3405
			private class ProjectLimitSortLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E4D RID: 28237 RVA: 0x001794E3 File Offset: 0x001776E3
				internal ProjectLimitSortLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project, global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression limit, global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression sort, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(project, aliasGenerator)
				{
					this._project = project;
					this._limit = limit;
					this._sort = sort;
				}

				// Token: 0x06006E4E RID: 28238 RVA: 0x00179503 File Offset: 0x00177703
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSort(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ComposeFilter(this._sort.Limit(this._limit.Limit), this._project, filter), this._sort), this._project);
				}

				// Token: 0x06006E4F RID: 28239 RVA: 0x0017953D File Offset: 0x0017773D
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ComposeProject(this._sort.Limit(this._limit.Limit), this._project, project);
				}

				// Token: 0x06006E50 RID: 28240 RVA: 0x00179564 File Offset: 0x00177764
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					if (this._limit.Limit.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && k.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.MinimumLimit(this._sort, this._limit, k), this._project);
					}
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSort(this._sort.Limit(this._limit.Limit), this._sort).Limit(k), this._project);
				}

				// Token: 0x06006E51 RID: 28241 RVA: 0x001795DD File Offset: 0x001777DD
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySortOrderToSkip(this._sort.Limit(this._limit.Limit), this._sort, k), this._project);
				}

				// Token: 0x040032AC RID: 12972
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression _project;

				// Token: 0x040032AD RID: 12973
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression _limit;

				// Token: 0x040032AE RID: 12974
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression _sort;
			}

			// Token: 0x02000D4E RID: 3406
			private class ProjectSkipLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E52 RID: 28242 RVA: 0x0017960C File Offset: 0x0017780C
				internal ProjectSkipLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project, global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression skip, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(project, aliasGenerator)
				{
					this._project = project;
					this._skip = skip;
					this._source = this._skip.Input.Expression;
				}

				// Token: 0x06006E53 RID: 28243 RVA: 0x0017963A File Offset: 0x0017783A
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySkipOrderToSort(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ComposeFilter(this._skip, this._project, filter), this._skip), this._project);
				}

				// Token: 0x06006E54 RID: 28244 RVA: 0x00179664 File Offset: 0x00177864
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return this._root.Limit(k);
				}

				// Token: 0x06006E55 RID: 28245 RVA: 0x00179672 File Offset: 0x00177872
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ComposeProject(this._skip, this._project, project);
				}

				// Token: 0x06006E56 RID: 28246 RVA: 0x00179688 File Offset: 0x00177888
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					if (this._skip.Count.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && k.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.AddToSkip(this._source, this._skip, k), this._project);
					}
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSkip(this._skip, this._skip, k), this._project);
				}

				// Token: 0x040032AF RID: 12975
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression _project;

				// Token: 0x040032B0 RID: 12976
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression _skip;

				// Token: 0x040032B1 RID: 12977
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _source;
			}

			// Token: 0x02000D4F RID: 3407
			private class SkipLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E57 RID: 28247 RVA: 0x001796EC File Offset: 0x001778EC
				internal SkipLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression skip, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(skip, aliasGenerator)
				{
					this._skip = skip;
					this._source = skip.Input.Expression;
				}

				// Token: 0x06006E58 RID: 28248 RVA: 0x0017970E File Offset: 0x0017790E
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySkipOrderToSort(filter, this._skip);
				}

				// Token: 0x06006E59 RID: 28249 RVA: 0x0017971C File Offset: 0x0017791C
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return project;
				}

				// Token: 0x06006E5A RID: 28250 RVA: 0x0017971F File Offset: 0x0017791F
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return this._root.Limit(k);
				}

				// Token: 0x06006E5B RID: 28251 RVA: 0x00179730 File Offset: 0x00177930
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					if (this._skip.Count.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && k.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.AddToSkip(this._source, this._skip, k);
					}
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSkip(this._skip, this._skip, k);
				}

				// Token: 0x040032B2 RID: 12978
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression _skip;

				// Token: 0x040032B3 RID: 12979
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _source;
			}

			// Token: 0x02000D50 RID: 3408
			private class ProjectSortLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E5C RID: 28252 RVA: 0x0017977E File Offset: 0x0017797E
				internal ProjectSortLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project, global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression sort, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(project, aliasGenerator)
				{
					this._project = project;
					this._sort = sort;
					this._source = sort.Input.Expression;
				}

				// Token: 0x06006E5D RID: 28253 RVA: 0x001797A7 File Offset: 0x001779A7
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ComposeProject(this._sort, this._project, project);
				}

				// Token: 0x06006E5E RID: 28254 RVA: 0x001797BB File Offset: 0x001779BB
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSort(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ComposeFilter(this._source, this._project, filter), this._sort), this._project);
				}

				// Token: 0x06006E5F RID: 28255 RVA: 0x001797E5 File Offset: 0x001779E5
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return this._root.Limit(k);
				}

				// Token: 0x06006E60 RID: 28256 RVA: 0x001797F3 File Offset: 0x001779F3
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindProject(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySortOrderToSkip(this._source, this._sort, k), this._project);
				}

				// Token: 0x040032B4 RID: 12980
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression _project;

				// Token: 0x040032B5 RID: 12981
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression _sort;

				// Token: 0x040032B6 RID: 12982
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _source;
			}

			// Token: 0x02000D51 RID: 3409
			private class SortLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E61 RID: 28257 RVA: 0x00179812 File Offset: 0x00177A12
				internal SortLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression sort, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(sort, aliasGenerator)
				{
					this._sort = sort;
					this._source = sort.Input.Expression;
				}

				// Token: 0x06006E62 RID: 28258 RVA: 0x00179834 File Offset: 0x00177A34
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return project;
				}

				// Token: 0x06006E63 RID: 28259 RVA: 0x00179837 File Offset: 0x00177A37
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindSort(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.RebindFilter(this._source, filter), this._sort);
				}

				// Token: 0x06006E64 RID: 28260 RVA: 0x00179850 File Offset: 0x00177A50
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return this._root.Limit(k);
				}

				// Token: 0x06006E65 RID: 28261 RVA: 0x0017985E File Offset: 0x00177A5E
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase.ApplySortOrderToSkip(this._source, this._sort, k);
				}

				// Token: 0x040032B7 RID: 12983
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression _sort;

				// Token: 0x040032B8 RID: 12984
				private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _source;
			}

			// Token: 0x02000D52 RID: 3410
			private class PassthroughOrderByLifter : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.OrderByLifter.OrderByLifterBase
			{
				// Token: 0x06006E66 RID: 28262 RVA: 0x00179872 File Offset: 0x00177A72
				internal PassthroughOrderByLifter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Data.Entity.Core.Common.Utils.AliasGenerator aliasGenerator) : base(source, aliasGenerator)
				{
				}

				// Token: 0x06006E67 RID: 28263 RVA: 0x0017987C File Offset: 0x00177A7C
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression project)
				{
					return project;
				}

				// Token: 0x06006E68 RID: 28264 RVA: 0x0017987F File Offset: 0x00177A7F
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter)
				{
					return filter;
				}

				// Token: 0x06006E69 RID: 28265 RVA: 0x00179882 File Offset: 0x00177A82
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression OfType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
				{
					return this._root.OfType(type);
				}

				// Token: 0x06006E6A RID: 28266 RVA: 0x00179890 File Offset: 0x00177A90
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					return this._root.Limit(k);
				}

				// Token: 0x06006E6B RID: 28267 RVA: 0x0017989E File Offset: 0x00177A9E
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Skip(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression k)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_SkipWithoutOrder);
				}
			}
		}

		// Token: 0x02000A76 RID: 2678
		internal sealed class MemberAccessTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.MemberExpression>
		{
			// Token: 0x0600621E RID: 25118 RVA: 0x0015383C File Offset: 0x00151A3C
			internal MemberAccessTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.MemberAccess
			})
			{
			}

			// Token: 0x0600621F RID: 25119 RVA: 0x00153850 File Offset: 0x00151A50
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression linq)
			{
				string text;
				global::System.Type type;
				global::System.Reflection.MemberInfo memberInfo = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.PropertyOrField(linq.Member, out text, out type);
				if (linq.Expression != null)
				{
					if (global::System.Linq.Expressions.ExpressionType.Constant == linq.Expression.NodeType && ((global::System.Linq.Expressions.ConstantExpression)linq.Expression).Type.GetCustomAttributes(typeof(global::System.Runtime.CompilerServices.CompilerGeneratedAttribute), false).FirstOrDefault<object>() != null)
					{
						global::System.Delegate @delegate = global::System.Linq.Expressions.Expression.Lambda(linq, new global::System.Linq.Expressions.ParameterExpression[0]).Compile();
						return parent.TranslateExpression(global::System.Linq.Expressions.Expression.Constant(@delegate.DynamicInvoke(new object[0])));
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(linq.Expression);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
					if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.TryResolveAsProperty(parent, memberInfo, dbExpression.ResultType, dbExpression, out result))
					{
						return result;
					}
				}
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator propertyTranslator;
				if (memberInfo.MemberType == global::System.Reflection.MemberTypes.Property && global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.TryGetTranslator((global::System.Reflection.PropertyInfo)memberInfo, out propertyTranslator))
				{
					return propertyTranslator.Translate(parent, linq);
				}
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnrecognizedMember(linq.Member.Name));
			}

			// Token: 0x06006220 RID: 25120 RVA: 0x00153938 File Offset: 0x00151B38
			static MemberAccessTranslator()
			{
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator._propertyTranslators = new global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator>();
				foreach (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator propertyTranslator in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.GetPropertyTranslators())
				{
					foreach (global::System.Reflection.PropertyInfo key in propertyTranslator.Properties)
					{
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator._propertyTranslators.Add(key, propertyTranslator);
					}
				}
			}

			// Token: 0x06006221 RID: 25121 RVA: 0x001539D4 File Offset: 0x00151BD4
			private static bool TryGetTranslator(global::System.Reflection.PropertyInfo propertyInfo, out global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator propertyTranslator)
			{
				global::System.Reflection.PropertyInfo propertyInfo2 = propertyInfo;
				if (propertyInfo.DeclaringType.IsGenericType())
				{
					try
					{
						propertyInfo = propertyInfo.DeclaringType.GetGenericTypeDefinition().GetDeclaredProperty(propertyInfo.Name);
					}
					catch (global::System.Reflection.AmbiguousMatchException)
					{
						propertyTranslator = null;
						return false;
					}
					if (propertyInfo == null)
					{
						propertyTranslator = null;
						return false;
					}
				}
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator propertyTranslator2;
				if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator._propertyTranslators.TryGetValue(propertyInfo, out propertyTranslator2))
				{
					propertyTranslator = propertyTranslator2;
					return true;
				}
				if ("Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" == propertyInfo.DeclaringType.Assembly().FullName)
				{
					object vbInitializerLock = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator._vbInitializerLock;
					lock (vbInitializerLock)
					{
						if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator._vbPropertiesInitialized)
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.InitializeVBProperties(propertyInfo.DeclaringType.Assembly());
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator._vbPropertiesInitialized = true;
						}
						if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator._propertyTranslators.TryGetValue(propertyInfo, out propertyTranslator2))
						{
							propertyTranslator = propertyTranslator2;
							return true;
						}
						propertyTranslator = null;
						return false;
					}
				}
				if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.GenericICollectionTranslator.TryGetPropertyTranslator(propertyInfo2, out propertyTranslator))
				{
					return true;
				}
				propertyTranslator = null;
				return false;
			}

			// Token: 0x06006222 RID: 25122 RVA: 0x00153AD8 File Offset: 0x00151CD8
			private static bool TryResolveAsProperty(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Reflection.MemberInfo clrMember, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage definingType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression propertyExpression)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = definingType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
				string name = clrMember.Name;
				if (rowType == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = definingType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType;
					if (structuralType != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = null;
						if (parent._perspective.TryGetMember(structuralType, name, false, out edmMember) && edmMember != null)
						{
							if (edmMember.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty)
							{
								global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProp = (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)edmMember;
								propertyExpression = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.TranslateNavigationProperty(parent, clrMember, instance, navProp);
								return true;
							}
							propertyExpression = instance.Property(name);
							return true;
						}
					}
					if (name == "Key" && global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property == instance.ExpressionKind)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)instance;
						global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
						if (dbPropertyExpression.Property.Name == "Group" && global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.TryGetInitializerMetadata(dbPropertyExpression.Instance.ResultType, out initializerMetadata) && initializerMetadata.Kind == global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.Grouping)
						{
							propertyExpression = dbPropertyExpression.Instance.Property("Key");
							return true;
						}
					}
					propertyExpression = null;
					return false;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2;
				if (rowType.Members.TryGetValue(name, false, out edmMember2))
				{
					propertyExpression = instance.Property(name);
					return true;
				}
				propertyExpression = null;
				return false;
			}

			// Token: 0x06006223 RID: 25123 RVA: 0x00153BE8 File Offset: 0x00151DE8
			private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateNavigationProperty(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Reflection.MemberInfo clrMember, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProp)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = instance.Property(navProp);
				if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == dbExpression.ResultType.EdmType.BuiltInTypeKind)
				{
					global::System.Type propertyType = ((global::System.Reflection.PropertyInfo)clrMember).PropertyType;
					if (propertyType.IsGenericType() && propertyType.GetGenericTypeDefinition() == typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<>))
					{
						dbExpression = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CreateNewRowExpression(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(2)
						{
							new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>("Owner", instance),
							new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>("Elements", dbExpression)
						}, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.CreateEntityCollectionInitializer(parent.EdmItemCollection, propertyType, navProp));
					}
				}
				return dbExpression;
			}

			// Token: 0x06006224 RID: 25124 RVA: 0x00153C78 File Offset: 0x00151E78
			private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateCount(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Type sequenceElementType, global::System.Linq.Expressions.Expression sequence)
			{
				global::System.Reflection.MethodInfo methodInfo;
				global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.TryLookupMethod(global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Count, out methodInfo);
				methodInfo = methodInfo.MakeGenericMethod(new global::System.Type[]
				{
					sequenceElementType
				});
				global::System.Linq.Expressions.Expression linq = global::System.Linq.Expressions.Expression.Call(methodInfo, sequence);
				return parent.TranslateExpression(linq);
			}

			// Token: 0x06006225 RID: 25125 RVA: 0x00153CB0 File Offset: 0x00151EB0
			private static void InitializeVBProperties(global::System.Reflection.Assembly vbAssembly)
			{
				foreach (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator propertyTranslator in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.GetVisualBasicPropertyTranslators(vbAssembly))
				{
					foreach (global::System.Reflection.PropertyInfo key in propertyTranslator.Properties)
					{
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator._propertyTranslators.Add(key, propertyTranslator);
					}
				}
			}

			// Token: 0x06006226 RID: 25126 RVA: 0x00153D38 File Offset: 0x00151F38
			private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator> GetVisualBasicPropertyTranslators(global::System.Reflection.Assembly vbAssembly)
			{
				return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator[]
				{
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.VBDateAndTimeNowTranslator(vbAssembly)
				};
			}

			// Token: 0x06006227 RID: 25127 RVA: 0x00153D49 File Offset: 0x00151F49
			private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator> GetPropertyTranslators()
			{
				return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator[]
				{
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.DefaultCanonicalFunctionPropertyTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.EntityCollectionCountTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.NullableHasValueTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.NullableValueTranslator(),
					new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator()
				};
			}

			// Token: 0x06006228 RID: 25128 RVA: 0x00153D84 File Offset: 0x00151F84
			internal static bool CanFuncletizePropertyInfo(global::System.Reflection.PropertyInfo propertyInfo)
			{
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator propertyTranslator;
				return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.GenericICollectionTranslator.TryGetPropertyTranslator(propertyInfo, out propertyTranslator) || !global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.TryGetTranslator(propertyInfo, out propertyTranslator);
			}

			// Token: 0x04002B35 RID: 11061
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator> _propertyTranslators;

			// Token: 0x04002B36 RID: 11062
			private static bool _vbPropertiesInitialized;

			// Token: 0x04002B37 RID: 11063
			private static readonly object _vbInitializerLock = new object();

			// Token: 0x02000D53 RID: 3411
			private sealed class SpatialPropertyTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator
			{
				// Token: 0x06006E6C RID: 28268 RVA: 0x001798AA File Offset: 0x00177AAA
				internal SpatialPropertyTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetSupportedProperties())
				{
				}

				// Token: 0x06006E6D RID: 28269 RVA: 0x001798C2 File Offset: 0x00177AC2
				private static global::System.Reflection.PropertyInfo GetProperty<T, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<T, TResult>> lambda)
				{
					return (global::System.Reflection.PropertyInfo)((global::System.Linq.Expressions.MemberExpression)lambda.Body).Member;
				}

				// Token: 0x06006E6E RID: 28270 RVA: 0x001798D9 File Offset: 0x00177AD9
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetSupportedProperties()
				{
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, int>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.CoordinateSystemId);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, string>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.SpatialTypeName);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, int>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Dimension);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, bool>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.IsEmpty);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, int?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.ElementCount);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Latitude);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Longitude);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Elevation);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Measure);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Length);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.StartPoint);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.EndPoint);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, bool?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.IsClosed);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, int?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.PointCount);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Area);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.CoordinateSystemId);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, string>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.SpatialTypeName);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Dimension);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Envelope);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsEmpty);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsSimple);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Boundary);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsValid);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.ConvexHull);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.ElementCount);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.XCoordinate);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.YCoordinate);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Elevation);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Measure);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Length);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.StartPoint);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.EndPoint);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsClosed);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsRing);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.PointCount);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Area);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Centroid);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.PointOnSurface);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.ExteriorRing);
					yield return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.InteriorRingCount);
					yield break;
				}

				// Token: 0x06006E6F RID: 28271 RVA: 0x001798E4 File Offset: 0x00177AE4
				private static global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, string> GetRenamedPropertyFunctions()
				{
					return new global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, string>
					{
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, int>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.CoordinateSystemId),
							"CoordinateSystemId"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, string>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.SpatialTypeName),
							"SpatialTypeName"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, int>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Dimension),
							"SpatialDimension"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, bool>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.IsEmpty),
							"IsEmptySpatial"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, int?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.ElementCount),
							"SpatialElementCount"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Latitude),
							"Latitude"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Longitude),
							"Longitude"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Elevation),
							"Elevation"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Measure),
							"Measure"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Length),
							"SpatialLength"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.StartPoint),
							"StartPoint"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, global::System.Data.Entity.Spatial.DbGeography>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.EndPoint),
							"EndPoint"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, bool?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.IsClosed),
							"IsClosedSpatial"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, int?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.PointCount),
							"PointCount"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeography, double?>((global::System.Data.Entity.Spatial.DbGeography geo) => geo.Area),
							"Area"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.CoordinateSystemId),
							"CoordinateSystemId"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, string>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.SpatialTypeName),
							"SpatialTypeName"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Dimension),
							"SpatialDimension"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Envelope),
							"SpatialEnvelope"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsEmpty),
							"IsEmptySpatial"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsSimple),
							"IsSimpleGeometry"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Boundary),
							"SpatialBoundary"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsValid),
							"IsValidGeometry"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.ConvexHull),
							"SpatialConvexHull"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.ElementCount),
							"SpatialElementCount"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.XCoordinate),
							"XCoordinate"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.YCoordinate),
							"YCoordinate"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Elevation),
							"Elevation"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Measure),
							"Measure"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Length),
							"SpatialLength"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.StartPoint),
							"StartPoint"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.EndPoint),
							"EndPoint"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsClosed),
							"IsClosedSpatial"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, bool?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.IsRing),
							"IsRing"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.PointCount),
							"PointCount"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, double?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Area),
							"Area"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.Centroid),
							"Centroid"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.PointOnSurface),
							"PointOnSurface"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, global::System.Data.Entity.Spatial.DbGeometry>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.ExteriorRing),
							"ExteriorRing"
						},
						{
							global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetProperty<global::System.Data.Entity.Spatial.DbGeometry, int?>((global::System.Data.Entity.Spatial.DbGeometry geo) => geo.InteriorRingCount),
							"InteriorRingCount"
						}
					};
				}

				// Token: 0x06006E70 RID: 28272 RVA: 0x0017A460 File Offset: 0x00178660
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call)
				{
					global::System.Reflection.PropertyInfo propertyInfo = (global::System.Reflection.PropertyInfo)call.Member;
					string functionName;
					if (!this.propertyFunctionRenames.TryGetValue(propertyInfo, out functionName))
					{
						functionName = "ST" + propertyInfo.Name;
					}
					return parent.TranslateIntoCanonicalFunction(functionName, call, new global::System.Linq.Expressions.Expression[]
					{
						call.Expression
					});
				}

				// Token: 0x040032B9 RID: 12985
				private readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, string> propertyFunctionRenames = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.SpatialPropertyTranslator.GetRenamedPropertyFunctions();
			}

			// Token: 0x02000D54 RID: 3412
			private sealed class GenericICollectionTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator
			{
				// Token: 0x06006E71 RID: 28273 RVA: 0x0017A4B1 File Offset: 0x001786B1
				private GenericICollectionTranslator(global::System.Type elementType) : base(global::System.Linq.Enumerable.Empty<global::System.Reflection.PropertyInfo>())
				{
					this._elementType = elementType;
				}

				// Token: 0x06006E72 RID: 28274 RVA: 0x0017A4C5 File Offset: 0x001786C5
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.TranslateCount(parent, this._elementType, call.Expression);
				}

				// Token: 0x06006E73 RID: 28275 RVA: 0x0017A4DC File Offset: 0x001786DC
				internal static bool TryGetPropertyTranslator(global::System.Reflection.PropertyInfo propertyInfo, out global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator propertyTranslator)
				{
					if (propertyInfo.Name == "Count" && propertyInfo.PropertyType.Equals(typeof(int)))
					{
						foreach (global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Type> keyValuePair in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.GenericICollectionTranslator.GetImplementedICollections(propertyInfo.DeclaringType))
						{
							global::System.Type key = keyValuePair.Key;
							global::System.Type value = keyValuePair.Value;
							if (propertyInfo.IsImplementationOf(key))
							{
								propertyTranslator = new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.GenericICollectionTranslator(value);
								return true;
							}
						}
					}
					propertyTranslator = null;
					return false;
				}

				// Token: 0x06006E74 RID: 28276 RVA: 0x0017A580 File Offset: 0x00178780
				private static bool IsICollection(global::System.Type candidateType, out global::System.Type elementType)
				{
					if (candidateType.IsGenericType() && candidateType.GetGenericTypeDefinition().Equals(typeof(global::System.Collections.Generic.ICollection<>)))
					{
						elementType = candidateType.GetGenericArguments()[0];
						return true;
					}
					elementType = null;
					return false;
				}

				// Token: 0x06006E75 RID: 28277 RVA: 0x0017A5B1 File Offset: 0x001787B1
				private static global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Type>> GetImplementedICollections(global::System.Type type)
				{
					global::System.Type value;
					if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.GenericICollectionTranslator.IsICollection(type, out value))
					{
						yield return new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Type>(type, value);
					}
					else
					{
						foreach (global::System.Type type2 in type.GetInterfaces())
						{
							if (global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.GenericICollectionTranslator.IsICollection(type2, out value))
							{
								yield return new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Type>(type2, value);
							}
						}
						global::System.Type[] array = null;
					}
					yield break;
				}

				// Token: 0x040032BA RID: 12986
				private readonly global::System.Type _elementType;
			}

			// Token: 0x02000D55 RID: 3413
			internal abstract class PropertyTranslator
			{
				// Token: 0x06006E76 RID: 28278 RVA: 0x0017A5C1 File Offset: 0x001787C1
				protected PropertyTranslator(params global::System.Reflection.PropertyInfo[] properties)
				{
					this._properties = properties;
				}

				// Token: 0x06006E77 RID: 28279 RVA: 0x0017A5D0 File Offset: 0x001787D0
				protected PropertyTranslator(global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> properties)
				{
					this._properties = properties;
				}

				// Token: 0x170011A9 RID: 4521
				// (get) Token: 0x06006E78 RID: 28280 RVA: 0x0017A5DF File Offset: 0x001787DF
				internal global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> Properties
				{
					get
					{
						return this._properties;
					}
				}

				// Token: 0x06006E79 RID: 28281
				internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call);

				// Token: 0x06006E7A RID: 28282 RVA: 0x0017A5E7 File Offset: 0x001787E7
				public override string ToString()
				{
					return base.GetType().Name;
				}

				// Token: 0x040032BB RID: 12987
				private readonly global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> _properties;
			}

			// Token: 0x02000D56 RID: 3414
			internal sealed class DefaultCanonicalFunctionPropertyTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator
			{
				// Token: 0x06006E7B RID: 28283 RVA: 0x0017A5F4 File Offset: 0x001787F4
				internal DefaultCanonicalFunctionPropertyTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.DefaultCanonicalFunctionPropertyTranslator.GetProperties())
				{
				}

				// Token: 0x06006E7C RID: 28284 RVA: 0x0017A604 File Offset: 0x00178804
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetProperties()
				{
					return new global::System.Reflection.PropertyInfo[]
					{
						typeof(string).GetDeclaredProperty("Length"),
						typeof(global::System.DateTime).GetDeclaredProperty("Year"),
						typeof(global::System.DateTime).GetDeclaredProperty("Month"),
						typeof(global::System.DateTime).GetDeclaredProperty("Day"),
						typeof(global::System.DateTime).GetDeclaredProperty("Hour"),
						typeof(global::System.DateTime).GetDeclaredProperty("Minute"),
						typeof(global::System.DateTime).GetDeclaredProperty("Second"),
						typeof(global::System.DateTime).GetDeclaredProperty("Millisecond"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("Year"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("Month"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("Day"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("Hour"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("Minute"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("Second"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("Millisecond"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("LocalDateTime"),
						typeof(global::System.DateTimeOffset).GetDeclaredProperty("UtcDateTime")
					};
				}

				// Token: 0x06006E7D RID: 28285 RVA: 0x0017A7A7 File Offset: 0x001789A7
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call)
				{
					return parent.TranslateIntoCanonicalFunction(call.Member.Name, call, new global::System.Linq.Expressions.Expression[]
					{
						call.Expression
					});
				}
			}

			// Token: 0x02000D57 RID: 3415
			internal sealed class RenameCanonicalFunctionPropertyTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator
			{
				// Token: 0x06006E7E RID: 28286 RVA: 0x0017A7CA File Offset: 0x001789CA
				internal RenameCanonicalFunctionPropertyTranslator() : base(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator.GetProperties())
				{
				}

				// Token: 0x06006E7F RID: 28287 RVA: 0x0017A7D8 File Offset: 0x001789D8
				private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetProperties()
				{
					return new global::System.Reflection.PropertyInfo[]
					{
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator.GetProperty(typeof(global::System.DateTime), "Now", "CurrentDateTime"),
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator.GetProperty(typeof(global::System.DateTime), "UtcNow", "CurrentUtcDateTime"),
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator.GetProperty(typeof(global::System.DateTimeOffset), "Now", "CurrentDateTimeOffset"),
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator.GetProperty(typeof(global::System.TimeSpan), "Hours", "Hour"),
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator.GetProperty(typeof(global::System.TimeSpan), "Minutes", "Minute"),
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator.GetProperty(typeof(global::System.TimeSpan), "Seconds", "Second"),
						global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator.GetProperty(typeof(global::System.TimeSpan), "Milliseconds", "Millisecond")
					};
				}

				// Token: 0x06006E80 RID: 28288 RVA: 0x0017A8B0 File Offset: 0x00178AB0
				private static global::System.Reflection.PropertyInfo GetProperty(global::System.Type declaringType, string propertyName, string canonicalFunctionName)
				{
					global::System.Reflection.PropertyInfo declaredProperty = declaringType.GetDeclaredProperty(propertyName);
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator._propertyRenameMap[declaredProperty] = canonicalFunctionName;
					return declaredProperty;
				}

				// Token: 0x06006E81 RID: 28289 RVA: 0x0017A8D4 File Offset: 0x00178AD4
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call)
				{
					global::System.Reflection.PropertyInfo key = (global::System.Reflection.PropertyInfo)call.Member;
					string functionName = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.RenameCanonicalFunctionPropertyTranslator._propertyRenameMap[key];
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
					if (call.Expression == null)
					{
						result = parent.TranslateIntoCanonicalFunction(functionName, call, new global::System.Linq.Expressions.Expression[0]);
					}
					else
					{
						result = parent.TranslateIntoCanonicalFunction(functionName, call, new global::System.Linq.Expressions.Expression[]
						{
							call.Expression
						});
					}
					return result;
				}

				// Token: 0x040032BC RID: 12988
				private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, string> _propertyRenameMap = new global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, string>(2);
			}

			// Token: 0x02000D58 RID: 3416
			internal sealed class VBDateAndTimeNowTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator
			{
				// Token: 0x06006E83 RID: 28291 RVA: 0x0017A938 File Offset: 0x00178B38
				internal VBDateAndTimeNowTranslator(global::System.Reflection.Assembly vbAssembly) : base(new global::System.Reflection.PropertyInfo[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.VBDateAndTimeNowTranslator.GetProperty(vbAssembly)
				})
				{
				}

				// Token: 0x06006E84 RID: 28292 RVA: 0x0017A94F File Offset: 0x00178B4F
				private static global::System.Reflection.PropertyInfo GetProperty(global::System.Reflection.Assembly vbAssembly)
				{
					return vbAssembly.GetType("Microsoft.VisualBasic.DateAndTime").GetDeclaredProperty("Now");
				}

				// Token: 0x06006E85 RID: 28293 RVA: 0x0017A966 File Offset: 0x00178B66
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call)
				{
					return parent.TranslateIntoCanonicalFunction("CurrentDateTime", call, new global::System.Linq.Expressions.Expression[0]);
				}

				// Token: 0x040032BD RID: 12989
				private const string s_dateAndTimeTypeFullName = "Microsoft.VisualBasic.DateAndTime";
			}

			// Token: 0x02000D59 RID: 3417
			internal sealed class EntityCollectionCountTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator
			{
				// Token: 0x06006E86 RID: 28294 RVA: 0x0017A97A File Offset: 0x00178B7A
				internal EntityCollectionCountTranslator() : base(new global::System.Reflection.PropertyInfo[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.EntityCollectionCountTranslator.GetProperty()
				})
				{
				}

				// Token: 0x06006E87 RID: 28295 RVA: 0x0017A990 File Offset: 0x00178B90
				private static global::System.Reflection.PropertyInfo GetProperty()
				{
					return typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<>).GetDeclaredProperty("Count");
				}

				// Token: 0x06006E88 RID: 28296 RVA: 0x0017A9A6 File Offset: 0x00178BA6
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.TranslateCount(parent, call.Member.DeclaringType.GetGenericArguments()[0], call.Expression);
				}
			}

			// Token: 0x02000D5A RID: 3418
			internal sealed class NullableHasValueTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator
			{
				// Token: 0x06006E89 RID: 28297 RVA: 0x0017A9C6 File Offset: 0x00178BC6
				internal NullableHasValueTranslator() : base(new global::System.Reflection.PropertyInfo[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.NullableHasValueTranslator.GetProperty()
				})
				{
				}

				// Token: 0x06006E8A RID: 28298 RVA: 0x0017A9DC File Offset: 0x00178BDC
				private static global::System.Reflection.PropertyInfo GetProperty()
				{
					return typeof(global::System.Nullable<>).GetDeclaredProperty("HasValue");
				}

				// Token: 0x06006E8B RID: 28299 RVA: 0x0017A9F2 File Offset: 0x00178BF2
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CreateIsNullExpression(parent.TranslateExpression(call.Expression), call.Expression.Type).Not();
				}
			}

			// Token: 0x02000D5B RID: 3419
			internal sealed class NullableValueTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.PropertyTranslator
			{
				// Token: 0x06006E8C RID: 28300 RVA: 0x0017AA15 File Offset: 0x00178C15
				internal NullableValueTranslator() : base(new global::System.Reflection.PropertyInfo[]
				{
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.MemberAccessTranslator.NullableValueTranslator.GetProperty()
				})
				{
				}

				// Token: 0x06006E8D RID: 28301 RVA: 0x0017AA2B File Offset: 0x00178C2B
				private static global::System.Reflection.PropertyInfo GetProperty()
				{
					return typeof(global::System.Nullable<>).GetDeclaredProperty("Value");
				}

				// Token: 0x06006E8E RID: 28302 RVA: 0x0017AA41 File Offset: 0x00178C41
				internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberExpression call)
				{
					return parent.TranslateExpression(call.Expression);
				}
			}
		}

		// Token: 0x02000A77 RID: 2679
		internal static class StringTranslatorUtil
		{
			// Token: 0x06006229 RID: 25129 RVA: 0x00153DA8 File Offset: 0x00151FA8
			internal static global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> GetConcatArgs(global::System.Linq.Expressions.Expression linq)
			{
				if (linq.IsStringAddExpression())
				{
					foreach (global::System.Linq.Expressions.Expression expression in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.GetConcatArgs((global::System.Linq.Expressions.BinaryExpression)linq))
					{
						yield return expression;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Linq.Expressions.Expression> enumerator = null;
				}
				else
				{
					yield return linq;
				}
				yield break;
				yield break;
			}

			// Token: 0x0600622A RID: 25130 RVA: 0x00153DB8 File Offset: 0x00151FB8
			internal static global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> GetConcatArgs(global::System.Linq.Expressions.BinaryExpression linq)
			{
				foreach (global::System.Linq.Expressions.Expression expression in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.GetConcatArgs(linq.Left))
				{
					yield return expression;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Linq.Expressions.Expression> enumerator = null;
				foreach (global::System.Linq.Expressions.Expression expression2 in global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.GetConcatArgs(linq.Right))
				{
					yield return expression2;
				}
				enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x0600622B RID: 25131 RVA: 0x00153DC8 File Offset: 0x00151FC8
			internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConcatArgs(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.ConcatArgs(parent, linq, global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.GetConcatArgs(linq).ToArray<global::System.Linq.Expressions.Expression>());
			}

			// Token: 0x0600622C RID: 25132 RVA: 0x00153DDC File Offset: 0x00151FDC
			internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConcatArgs(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression linq, global::System.Linq.Expressions.Expression[] linqArgs)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] array = (from arg in linqArgs
				where !arg.IsNullConstant()
				select global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.ConvertToString(parent, arg)).ToArray<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
				if (array.Length == 0)
				{
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(string.Empty);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = array.First<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 in array.Skip(1))
				{
					dbExpression = parent.CreateCanonicalFunction("Concat", linq, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbExpression,
						dbExpression2
					});
				}
				return dbExpression;
			}

			// Token: 0x0600622D RID: 25133 RVA: 0x00153EA8 File Offset: 0x001520A8
			internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression StripNull(global::System.Linq.Expressions.Expression sourceExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression inputExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression outputExpression, bool useDatabaseNullSemantics)
			{
				if (sourceExpression.IsNullConstant())
				{
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(string.Empty);
				}
				if (sourceExpression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant)
				{
					return outputExpression;
				}
				if (useDatabaseNullSemantics)
				{
					return outputExpression;
				}
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression[]
				{
					inputExpression.IsNull()
				}, new global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression[]
				{
					global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(string.Empty)
				}, outputExpression);
			}

			// Token: 0x0600622E RID: 25134 RVA: 0x00153F04 File Offset: 0x00152104
			internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConvertToString(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression linqExpression)
			{
				if (linqExpression.Type == typeof(object))
				{
					global::System.Linq.Expressions.ConstantExpression constantExpression = linqExpression as global::System.Linq.Expressions.ConstantExpression;
					linqExpression = ((constantExpression != null) ? global::System.Linq.Expressions.Expression.Constant(constantExpression.Value) : linqExpression.RemoveConvert());
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression = parent.TranslateExpression(linqExpression);
				global::System.Type nonNullableType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(linqExpression.Type);
				bool useDatabaseNullSemantics = !parent._funcletizer.RootContext.ContextOptions.UseCSharpNullComparisonBehavior;
				if (nonNullableType.IsEnum)
				{
					if (global::System.Attribute.IsDefined(nonNullableType, typeof(global::System.FlagsAttribute)))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Elinq_ToStringNotSupportedForEnumsWithFlags);
					}
					if (linqExpression.IsNullConstant())
					{
						return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(string.Empty);
					}
					if (linqExpression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant)
					{
						object value = ((global::System.Linq.Expressions.ConstantExpression)linqExpression).Value;
						return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(global::System.Enum.GetName(nonNullableType, value) ?? value.ToString());
					}
					global::System.Type integralType = nonNullableType.GetEnumUnderlyingType();
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = parent.GetValueLayerType(integralType);
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> whenExpressions = (from object v in nonNullableType.GetEnumValues()
					select global::System.Convert.ChangeType(v, integralType, global::System.Globalization.CultureInfo.InvariantCulture) into v
					select global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(v) into c
					select expression.CastTo(type).Equal(c)).Concat(new global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression[]
					{
						expression.CastTo(type).IsNull()
					});
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression> thenExpressions = (from s in nonNullableType.GetEnumNames()
					select global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(s)).Concat(new global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression[]
					{
						global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(string.Empty)
					});
					global::System.Linq.Expressions.UnaryExpression linq = global::System.Linq.Expressions.Expression.Convert(linqExpression, integralType);
					global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression elseExpression = parent.TranslateExpression(linq).CastTo(parent.GetValueLayerType(typeof(string)));
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(whenExpressions, thenExpressions, elseExpression);
				}
				else
				{
					if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(expression.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.StripNull(linqExpression, expression, expression, useDatabaseNullSemantics);
					}
					if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(expression.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid))
					{
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.StripNull(linqExpression, expression, expression.CastTo(parent.GetValueLayerType(typeof(string))).ToLower(), useDatabaseNullSemantics);
					}
					if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(expression.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean))
					{
						if (linqExpression.IsNullConstant())
						{
							return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(string.Empty);
						}
						if (linqExpression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant)
						{
							return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(((global::System.Linq.Expressions.ConstantExpression)linqExpression).Value.ToString());
						}
						global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression dbComparisonExpression = expression.Equal(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True);
						global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression dbComparisonExpression2 = expression.Equal(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False);
						global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(true.ToString());
						global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(false.ToString());
						return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression[]
						{
							dbComparisonExpression,
							dbComparisonExpression2
						}, new global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression[]
						{
							dbConstantExpression,
							dbConstantExpression2
						}, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(string.Empty));
					}
					else
					{
						if (!global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.SupportsCastToString(expression.ResultType))
						{
							throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Elinq_ToStringNotSupportedForType(expression.ResultType.EdmType.Name));
						}
						return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.StripNull(linqExpression, expression, expression.CastTo(parent.GetValueLayerType(typeof(string))), useDatabaseNullSemantics);
					}
				}
			}

			// Token: 0x0600622F RID: 25135 RVA: 0x00154280 File Offset: 0x00152480
			internal static bool SupportsCastToString(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(typeUsage, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNumericType(typeUsage) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsBooleanType(typeUsage) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(typeUsage, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(typeUsage, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(typeUsage, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(typeUsage, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid);
			}
		}

		// Token: 0x02000A78 RID: 2680
		internal abstract class Translator
		{
			// Token: 0x06006230 RID: 25136 RVA: 0x001542CD File Offset: 0x001524CD
			protected Translator(params global::System.Linq.Expressions.ExpressionType[] nodeTypes)
			{
				this._nodeTypes = nodeTypes;
			}

			// Token: 0x170010C2 RID: 4290
			// (get) Token: 0x06006231 RID: 25137 RVA: 0x001542DC File Offset: 0x001524DC
			internal global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.ExpressionType> NodeTypes
			{
				get
				{
					return this._nodeTypes;
				}
			}

			// Token: 0x06006232 RID: 25138
			internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression linq);

			// Token: 0x06006233 RID: 25139 RVA: 0x001542E4 File Offset: 0x001524E4
			public override string ToString()
			{
				return base.GetType().Name;
			}

			// Token: 0x04002B38 RID: 11064
			private readonly global::System.Linq.Expressions.ExpressionType[] _nodeTypes;
		}

		// Token: 0x02000A79 RID: 2681
		internal abstract class TypedTranslator<T_Linq> : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator where T_Linq : global::System.Linq.Expressions.Expression
		{
			// Token: 0x06006234 RID: 25140 RVA: 0x001542F1 File Offset: 0x001524F1
			protected TypedTranslator(params global::System.Linq.Expressions.ExpressionType[] nodeTypes) : base(nodeTypes)
			{
			}

			// Token: 0x06006235 RID: 25141 RVA: 0x001542FA File Offset: 0x001524FA
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression linq)
			{
				return this.TypedTranslate(parent, (T_Linq)((object)linq));
			}

			// Token: 0x06006236 RID: 25142
			protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, T_Linq linq);
		}

		// Token: 0x02000A7A RID: 2682
		private sealed class ConstantTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.ConstantExpression>
		{
			// Token: 0x06006237 RID: 25143 RVA: 0x00154309 File Offset: 0x00152509
			internal ConstantTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Constant
			})
			{
			}

			// Token: 0x06006238 RID: 25144 RVA: 0x0015431C File Offset: 0x0015251C
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.ConstantExpression linq)
			{
				if (linq == parent._funcletizer.RootContextExpression)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedUseOfContextParameter(parent._funcletizer.RootContextParameter.Name));
				}
				global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = (linq.Value as global::System.Linq.IQueryable).TryGetObjectQuery();
				if (objectQuery != null)
				{
					return parent.TranslateInlineQueryOfT(objectQuery);
				}
				global::System.Collections.IEnumerable enumerable = linq.Value as global::System.Collections.IEnumerable;
				if (enumerable != null)
				{
					global::System.Type elementType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(linq.Type);
					if (elementType != null && elementType != linq.Type)
					{
						global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>();
						foreach (object value in enumerable)
						{
							list.Add(global::System.Linq.Expressions.Expression.Constant(value, elementType));
						}
						parent._recompileRequired = (() => true);
						return parent.TranslateExpression(global::System.Linq.Expressions.Expression.NewArrayInit(elementType, list));
					}
				}
				bool flag = linq.Value == null;
				bool flag2 = false;
				global::System.Type type = linq.Type;
				if (type == typeof(global::System.Enum))
				{
					type = linq.Value.GetType();
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
				if (parent.TryGetValueLayerType(type, out typeUsage) && (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(typeUsage.EdmType) || (flag && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(typeUsage.EdmType))))
				{
					flag2 = true;
				}
				if (!flag2)
				{
					if (flag)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedNullConstant(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(linq.Type)));
					}
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedConstant(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(linq.Type)));
				}
				else
				{
					if (flag)
					{
						return typeUsage.Null();
					}
					object value2 = linq.Value;
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(typeUsage.EdmType))
					{
						global::System.Type nonNullableType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(type);
						if (nonNullableType.IsEnum())
						{
							value2 = global::System.Convert.ChangeType(linq.Value, nonNullableType.GetEnumUnderlyingType(), global::System.Globalization.CultureInfo.InvariantCulture);
						}
					}
					return typeUsage.Constant(value2);
				}
			}
		}

		// Token: 0x02000A7B RID: 2683
		private sealed class ParameterTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.ParameterExpression>
		{
			// Token: 0x06006239 RID: 25145 RVA: 0x00154520 File Offset: 0x00152720
			internal ParameterTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Parameter
			})
			{
			}

			// Token: 0x0600623A RID: 25146 RVA: 0x00154533 File Offset: 0x00152733
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.ParameterExpression linq)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ELinq_UnboundParameterExpression(linq.Name));
			}
		}

		// Token: 0x02000A7C RID: 2684
		private sealed class NewTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.NewExpression>
		{
			// Token: 0x0600623B RID: 25147 RVA: 0x00154545 File Offset: 0x00152745
			internal NewTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.New
			})
			{
			}

			// Token: 0x0600623C RID: 25148 RVA: 0x00154584 File Offset: 0x00152784
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.NewExpression linq)
			{
				int num = (linq.Members == null) ? 0 : linq.Members.Count;
				if (linq.Arguments.Count == 1 && this._castableTypes.Any((global::System.Tuple<global::System.Type, global::System.Type> cast) => cast.Item1 == linq.Constructor.DeclaringType && cast.Item2 == linq.Arguments[0].Type))
				{
					return parent.CreateCastExpression(parent.TranslateExpression(linq.Arguments[0]), linq.Constructor.DeclaringType, linq.Arguments[0].Type);
				}
				if (null == linq.Constructor || linq.Arguments.Count != num)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedConstructor);
				}
				parent.CheckInitializerType(linq.Type);
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(num + 1);
				global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
				for (int i = 0; i < num; i++)
				{
					string text;
					global::System.Type type;
					global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.PropertyOrField(linq.Members[i], out text, out type);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = parent.TranslateExpression(linq.Arguments[i]);
					hashSet.Add(text);
					list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(text, value));
				}
				global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
				if (num == 0)
				{
					list.Add(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True.As("Key"));
					initializerMetadata = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.CreateEmptyProjectionInitializer(parent.EdmItemCollection, linq);
				}
				else
				{
					initializerMetadata = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.CreateProjectionInitializer(parent.EdmItemCollection, linq);
				}
				parent.ValidateInitializerMetadata(initializerMetadata);
				return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CreateNewRowExpression(list, initializerMetadata);
			}

			// Token: 0x04002B39 RID: 11065
			private global::System.Collections.Generic.List<global::System.Tuple<global::System.Type, global::System.Type>> _castableTypes = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Type, global::System.Type>>
			{
				new global::System.Tuple<global::System.Type, global::System.Type>(typeof(global::System.Guid), typeof(string))
			};
		}

		// Token: 0x02000A7D RID: 2685
		private sealed class NewArrayInitTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.NewArrayExpression>
		{
			// Token: 0x0600623D RID: 25149 RVA: 0x00154733 File Offset: 0x00152933
			internal NewArrayInitTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.NewArrayInit
			})
			{
			}

			// Token: 0x0600623E RID: 25150 RVA: 0x00154748 File Offset: 0x00152948
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.NewArrayExpression linq)
			{
				if (linq.Expressions.Count > 0)
				{
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewCollection(from e in linq.Expressions
					select parent.TranslateExpression(e));
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionType;
				if (typeof(byte[]) == linq.Type)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType;
					if (parent.TryGetValueLayerType(typeof(byte), out elementType))
					{
						collectionType = global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(elementType);
						return collectionType.NewEmptyCollection();
					}
				}
				else if (parent.TryGetValueLayerType(linq.Type, out collectionType))
				{
					return collectionType.NewEmptyCollection();
				}
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedType(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(linq.Type)));
			}
		}

		// Token: 0x02000A7E RID: 2686
		private sealed class ListInitTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.ListInitExpression>
		{
			// Token: 0x0600623F RID: 25151 RVA: 0x001547FC File Offset: 0x001529FC
			internal ListInitTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.ListInit
			})
			{
			}

			// Token: 0x06006240 RID: 25152 RVA: 0x00154810 File Offset: 0x00152A10
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.ListInitExpression linq)
			{
				if (linq.NewExpression.Constructor != null && linq.NewExpression.Constructor.GetParameters().Length != 0)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedConstructor);
				}
				if (linq.Initializers.Any((global::System.Linq.Expressions.ElementInit i) => i.Arguments.Count != 1))
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedInitializers);
				}
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewCollection(from i in linq.Initializers
				select parent.TranslateExpression(i.Arguments[0]));
			}
		}

		// Token: 0x02000A7F RID: 2687
		private sealed class MemberInitTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.MemberInitExpression>
		{
			// Token: 0x06006241 RID: 25153 RVA: 0x001548AE File Offset: 0x00152AAE
			internal MemberInitTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.MemberInit
			})
			{
			}

			// Token: 0x06006242 RID: 25154 RVA: 0x001548C4 File Offset: 0x00152AC4
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.MemberInitExpression linq)
			{
				if (null == linq.NewExpression.Constructor || linq.NewExpression.Constructor.GetParameters().Length != 0)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedConstructor);
				}
				parent.CheckInitializerType(linq.Type);
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(linq.Bindings.Count + 1);
				global::System.Reflection.MemberInfo[] array = new global::System.Reflection.MemberInfo[linq.Bindings.Count];
				global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
				for (int i = 0; i < linq.Bindings.Count; i++)
				{
					global::System.Linq.Expressions.MemberAssignment memberAssignment = linq.Bindings[i] as global::System.Linq.Expressions.MemberAssignment;
					if (memberAssignment == null)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedBinding);
					}
					string text;
					global::System.Type type;
					global::System.Reflection.MemberInfo memberInfo = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.PropertyOrField(memberAssignment.Member, out text, out type);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = parent.TranslateExpression(memberAssignment.Expression);
					hashSet.Add(text);
					array[i] = memberInfo;
					list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(text, value));
				}
				global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
				if (list.Count == 0)
				{
					list.Add(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(true).As("Key"));
					initializerMetadata = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.CreateEmptyProjectionInitializer(parent.EdmItemCollection, linq.NewExpression);
				}
				else
				{
					initializerMetadata = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.CreateProjectionInitializer(parent.EdmItemCollection, linq);
				}
				parent.ValidateInitializerMetadata(initializerMetadata);
				return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CreateNewRowExpression(list, initializerMetadata);
			}
		}

		// Token: 0x02000A80 RID: 2688
		private sealed class ConditionalTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.ConditionalExpression>
		{
			// Token: 0x06006243 RID: 25155 RVA: 0x00154A0B File Offset: 0x00152C0B
			internal ConditionalTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Conditional
			})
			{
			}

			// Token: 0x06006244 RID: 25156 RVA: 0x00154A20 File Offset: 0x00152C20
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.ConditionalExpression linq)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression item = parent.TranslateExpression(linq.Test);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2;
				if (!linq.IfTrue.IsNullConstant())
				{
					dbExpression = parent.TranslateExpression(linq.IfTrue);
					dbExpression2 = ((!linq.IfFalse.IsNullConstant()) ? parent.TranslateExpression(linq.IfFalse) : dbExpression.ResultType.Null());
				}
				else
				{
					if (linq.IfFalse.IsNullConstant())
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedNullConstant(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.DescribeClrType(linq.Type)));
					}
					dbExpression2 = parent.TranslateExpression(linq.IfFalse);
					dbExpression = dbExpression2.ResultType.Null();
				}
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>
				{
					item
				}, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>
				{
					dbExpression
				}, dbExpression2);
			}
		}

		// Token: 0x02000A81 RID: 2689
		private sealed class NotSupportedTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator
		{
			// Token: 0x06006245 RID: 25157 RVA: 0x00154AD9 File Offset: 0x00152CD9
			internal NotSupportedTranslator(params global::System.Linq.Expressions.ExpressionType[] nodeTypes) : base(nodeTypes)
			{
			}

			// Token: 0x06006246 RID: 25158 RVA: 0x00154AE2 File Offset: 0x00152CE2
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression linq)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedExpressionType(linq.NodeType));
			}
		}

		// Token: 0x02000A82 RID: 2690
		private sealed class ExtensionTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.Translator
		{
			// Token: 0x06006247 RID: 25159 RVA: 0x00154AF9 File Offset: 0x00152CF9
			internal ExtensionTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				(global::System.Linq.Expressions.ExpressionType)(-1)
			})
			{
			}

			// Token: 0x06006248 RID: 25160 RVA: 0x00154B0C File Offset: 0x00152D0C
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Translate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression linq)
			{
				global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression queryParameterExpression = linq as global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression;
				if (queryParameterExpression == null)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedExpressionType(linq.NodeType));
				}
				parent.AddParameter(queryParameterExpression);
				return queryParameterExpression.ParameterReference;
			}
		}

		// Token: 0x02000A83 RID: 2691
		private abstract class BinaryTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.BinaryExpression>
		{
			// Token: 0x06006249 RID: 25161 RVA: 0x00154B46 File Offset: 0x00152D46
			protected BinaryTranslator(params global::System.Linq.Expressions.ExpressionType[] nodeTypes) : base(nodeTypes)
			{
			}

			// Token: 0x0600624A RID: 25162 RVA: 0x00154B4F File Offset: 0x00152D4F
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return this.TranslateBinary(parent, parent.TranslateExpression(linq.Left), parent.TranslateExpression(linq.Right), linq);
			}

			// Token: 0x0600624B RID: 25163
			protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq);
		}

		// Token: 0x02000A84 RID: 2692
		private sealed class CoalesceTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x0600624C RID: 25164 RVA: 0x00154B71 File Offset: 0x00152D71
			internal CoalesceTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Coalesce
			})
			{
			}

			// Token: 0x0600624D RID: 25165 RVA: 0x00154B84 File Offset: 0x00152D84
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression item = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CreateIsNullExpression(left, linq.Left.Type);
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
				{
					item
				}, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
				{
					right
				}, left);
			}
		}

		// Token: 0x02000A85 RID: 2693
		private sealed class AndAlsoTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x0600624E RID: 25166 RVA: 0x00154BC6 File Offset: 0x00152DC6
			internal AndAlsoTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.AndAlso
			})
			{
			}

			// Token: 0x0600624F RID: 25167 RVA: 0x00154BD8 File Offset: 0x00152DD8
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.And(right);
			}
		}

		// Token: 0x02000A86 RID: 2694
		private sealed class OrElseTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006250 RID: 25168 RVA: 0x00154BE1 File Offset: 0x00152DE1
			internal OrElseTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.OrElse
			})
			{
			}

			// Token: 0x06006251 RID: 25169 RVA: 0x00154BF4 File Offset: 0x00152DF4
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.Or(right);
			}
		}

		// Token: 0x02000A87 RID: 2695
		private sealed class LessThanTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006252 RID: 25170 RVA: 0x00154BFD File Offset: 0x00152DFD
			internal LessThanTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.LessThan
			})
			{
			}

			// Token: 0x06006253 RID: 25171 RVA: 0x00154C10 File Offset: 0x00152E10
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.LessThan(right);
			}
		}

		// Token: 0x02000A88 RID: 2696
		private sealed class LessThanOrEqualsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006254 RID: 25172 RVA: 0x00154C19 File Offset: 0x00152E19
			internal LessThanOrEqualsTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.LessThanOrEqual
			})
			{
			}

			// Token: 0x06006255 RID: 25173 RVA: 0x00154C2C File Offset: 0x00152E2C
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.LessThanOrEqual(right);
			}
		}

		// Token: 0x02000A89 RID: 2697
		private sealed class GreaterThanTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006256 RID: 25174 RVA: 0x00154C35 File Offset: 0x00152E35
			internal GreaterThanTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.GreaterThan
			})
			{
			}

			// Token: 0x06006257 RID: 25175 RVA: 0x00154C48 File Offset: 0x00152E48
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.GreaterThan(right);
			}
		}

		// Token: 0x02000A8A RID: 2698
		private sealed class GreaterThanOrEqualsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006258 RID: 25176 RVA: 0x00154C51 File Offset: 0x00152E51
			internal GreaterThanOrEqualsTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.GreaterThanOrEqual
			})
			{
			}

			// Token: 0x06006259 RID: 25177 RVA: 0x00154C64 File Offset: 0x00152E64
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.GreaterThanOrEqual(right);
			}
		}

		// Token: 0x02000A8B RID: 2699
		private sealed class EqualsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.BinaryExpression>
		{
			// Token: 0x0600625A RID: 25178 RVA: 0x00154C6D File Offset: 0x00152E6D
			internal EqualsTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Equal
			})
			{
			}

			// Token: 0x0600625B RID: 25179 RVA: 0x00154C80 File Offset: 0x00152E80
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq)
			{
				global::System.Linq.Expressions.Expression left = linq.Left;
				global::System.Linq.Expressions.Expression right = linq.Right;
				bool flag = left.IsNullConstant();
				bool flag2 = right.IsNullConstant();
				if (flag && flag2)
				{
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True;
				}
				if (flag)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsTranslator.CreateIsNullExpression(parent, right);
				}
				if (flag2)
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsTranslator.CreateIsNullExpression(parent, left);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left2 = parent.TranslateExpression(left);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right2 = parent.TranslateExpression(right);
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern pattern = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.Store;
				if (parent._funcletizer.RootContext.ContextOptions.UseCSharpNullComparisonBehavior)
				{
					pattern = global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.EqualsPattern.PositiveNullEqualityComposable;
				}
				return parent.CreateEqualsExpression(left2, right2, pattern, left.Type, right.Type);
			}

			// Token: 0x0600625C RID: 25180 RVA: 0x00154D11 File Offset: 0x00152F11
			private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateIsNullExpression(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.Expression input)
			{
				input = input.RemoveConvert();
				return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CreateIsNullExpression(parent.TranslateExpression(input), input.Type);
			}
		}

		// Token: 0x02000A8C RID: 2700
		private sealed class NotEqualsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.BinaryExpression>
		{
			// Token: 0x0600625D RID: 25181 RVA: 0x00154D2D File Offset: 0x00152F2D
			internal NotEqualsTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.NotEqual
			})
			{
			}

			// Token: 0x0600625E RID: 25182 RVA: 0x00154D40 File Offset: 0x00152F40
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq)
			{
				global::System.Linq.Expressions.Expression linq2 = global::System.Linq.Expressions.Expression.Not(global::System.Linq.Expressions.Expression.Equal(linq.Left, linq.Right));
				return parent.TranslateExpression(linq2);
			}
		}

		// Token: 0x02000A8D RID: 2701
		private sealed class IsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.TypeBinaryExpression>
		{
			// Token: 0x0600625F RID: 25183 RVA: 0x00154D6B File Offset: 0x00152F6B
			internal IsTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.TypeIs
			})
			{
			}

			// Token: 0x06006260 RID: 25184 RVA: 0x00154D80 File Offset: 0x00152F80
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.TypeBinaryExpression linq)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument = parent.TranslateExpression(linq.Expression);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage isOrAsTargetType = parent.GetIsOrAsTargetType(global::System.Linq.Expressions.ExpressionType.TypeIs, linq.TypeOperand, linq.Expression.Type);
				return argument.IsOf(isOrAsTargetType);
			}
		}

		// Token: 0x02000A8E RID: 2702
		private sealed class AddTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006261 RID: 25185 RVA: 0x00154DB9 File Offset: 0x00152FB9
			internal AddTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Add,
				global::System.Linq.Expressions.ExpressionType.AddChecked
			})
			{
			}

			// Token: 0x06006262 RID: 25186 RVA: 0x00154DCB File Offset: 0x00152FCB
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq)
			{
				if (linq.IsStringAddExpression())
				{
					return global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.StringTranslatorUtil.ConcatArgs(parent, linq);
				}
				return this.TranslateBinary(parent, parent.TranslateExpression(linq.Left), parent.TranslateExpression(linq.Right), linq);
			}

			// Token: 0x06006263 RID: 25187 RVA: 0x00154DFD File Offset: 0x00152FFD
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.Plus(right);
			}
		}

		// Token: 0x02000A8F RID: 2703
		private sealed class DivideTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006264 RID: 25188 RVA: 0x00154E06 File Offset: 0x00153006
			internal DivideTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Divide
			})
			{
			}

			// Token: 0x06006265 RID: 25189 RVA: 0x00154E19 File Offset: 0x00153019
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.Divide(right);
			}
		}

		// Token: 0x02000A90 RID: 2704
		private sealed class ModuloTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006266 RID: 25190 RVA: 0x00154E22 File Offset: 0x00153022
			internal ModuloTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Modulo
			})
			{
			}

			// Token: 0x06006267 RID: 25191 RVA: 0x00154E35 File Offset: 0x00153035
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.Modulo(right);
			}
		}

		// Token: 0x02000A91 RID: 2705
		private sealed class MultiplyTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x06006268 RID: 25192 RVA: 0x00154E3E File Offset: 0x0015303E
			internal MultiplyTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Multiply,
				global::System.Linq.Expressions.ExpressionType.MultiplyChecked
			})
			{
			}

			// Token: 0x06006269 RID: 25193 RVA: 0x00154E56 File Offset: 0x00153056
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.Multiply(right);
			}
		}

		// Token: 0x02000A92 RID: 2706
		private sealed class PowerTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x0600626A RID: 25194 RVA: 0x00154E5F File Offset: 0x0015305F
			internal PowerTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Power
			})
			{
			}

			// Token: 0x0600626B RID: 25195 RVA: 0x00154E72 File Offset: 0x00153072
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.Power(right);
			}
		}

		// Token: 0x02000A93 RID: 2707
		private sealed class SubtractTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BinaryTranslator
		{
			// Token: 0x0600626C RID: 25196 RVA: 0x00154E7B File Offset: 0x0015307B
			internal SubtractTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Subtract,
				global::System.Linq.Expressions.ExpressionType.SubtractChecked
			})
			{
			}

			// Token: 0x0600626D RID: 25197 RVA: 0x00154E93 File Offset: 0x00153093
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateBinary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Linq.Expressions.BinaryExpression linq)
			{
				return left.Minus(right);
			}
		}

		// Token: 0x02000A94 RID: 2708
		private sealed class NegateTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.UnaryTranslator
		{
			// Token: 0x0600626E RID: 25198 RVA: 0x00154E9C File Offset: 0x0015309C
			internal NegateTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Negate,
				global::System.Linq.Expressions.ExpressionType.NegateChecked
			})
			{
			}

			// Token: 0x0600626F RID: 25199 RVA: 0x00154EB4 File Offset: 0x001530B4
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.UnaryExpression unary, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand)
			{
				return operand.UnaryMinus();
			}
		}

		// Token: 0x02000A95 RID: 2709
		private sealed class UnaryPlusTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.UnaryTranslator
		{
			// Token: 0x06006270 RID: 25200 RVA: 0x00154EBC File Offset: 0x001530BC
			internal UnaryPlusTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.UnaryPlus
			})
			{
			}

			// Token: 0x06006271 RID: 25201 RVA: 0x00154ECF File Offset: 0x001530CF
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.UnaryExpression unary, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand)
			{
				return operand;
			}
		}

		// Token: 0x02000A96 RID: 2710
		private abstract class BitwiseBinaryTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.BinaryExpression>
		{
			// Token: 0x06006272 RID: 25202 RVA: 0x00154ED2 File Offset: 0x001530D2
			protected BitwiseBinaryTranslator(global::System.Linq.Expressions.ExpressionType nodeType, string canonicalFunctionName) : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				nodeType
			})
			{
				this._canonicalFunctionName = canonicalFunctionName;
			}

			// Token: 0x06006273 RID: 25203 RVA: 0x00154EEC File Offset: 0x001530EC
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(linq.Left);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = parent.TranslateExpression(linq.Right);
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsBooleanType(dbExpression.ResultType))
				{
					return this.TranslateIntoLogicExpression(parent, linq, dbExpression, dbExpression2);
				}
				return parent.CreateCanonicalFunction(this._canonicalFunctionName, linq, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					dbExpression,
					dbExpression2
				});
			}

			// Token: 0x06006274 RID: 25204
			protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateIntoLogicExpression(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right);

			// Token: 0x04002B3A RID: 11066
			private readonly string _canonicalFunctionName;
		}

		// Token: 0x02000A97 RID: 2711
		private sealed class AndTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BitwiseBinaryTranslator
		{
			// Token: 0x06006275 RID: 25205 RVA: 0x00154F46 File Offset: 0x00153146
			internal AndTranslator() : base(global::System.Linq.Expressions.ExpressionType.And, "BitwiseAnd")
			{
			}

			// Token: 0x06006276 RID: 25206 RVA: 0x00154F54 File Offset: 0x00153154
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateIntoLogicExpression(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
			{
				return left.And(right);
			}
		}

		// Token: 0x02000A98 RID: 2712
		private sealed class OrTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BitwiseBinaryTranslator
		{
			// Token: 0x06006277 RID: 25207 RVA: 0x00154F5E File Offset: 0x0015315E
			internal OrTranslator() : base(global::System.Linq.Expressions.ExpressionType.Or, "BitwiseOr")
			{
			}

			// Token: 0x06006278 RID: 25208 RVA: 0x00154F6D File Offset: 0x0015316D
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateIntoLogicExpression(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
			{
				return left.Or(right);
			}
		}

		// Token: 0x02000A99 RID: 2713
		private sealed class ExclusiveOrTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.BitwiseBinaryTranslator
		{
			// Token: 0x06006279 RID: 25209 RVA: 0x00154F77 File Offset: 0x00153177
			internal ExclusiveOrTranslator() : base(global::System.Linq.Expressions.ExpressionType.ExclusiveOr, "BitwiseXor")
			{
			}

			// Token: 0x0600627A RID: 25210 RVA: 0x00154F88 File Offset: 0x00153188
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateIntoLogicExpression(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.BinaryExpression linq, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left2 = left.And(right.Not());
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right2 = left.Not().And(right);
				return left2.Or(right2);
			}
		}

		// Token: 0x02000A9A RID: 2714
		private sealed class NotTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.UnaryExpression>
		{
			// Token: 0x0600627B RID: 25211 RVA: 0x00154FB6 File Offset: 0x001531B6
			internal NotTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Not
			})
			{
			}

			// Token: 0x0600627C RID: 25212 RVA: 0x00154FCC File Offset: 0x001531CC
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.UnaryExpression linq)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = parent.TranslateExpression(linq.Operand);
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsBooleanType(dbExpression.ResultType))
				{
					return dbExpression.Not();
				}
				return parent.CreateCanonicalFunction("BitwiseNot", linq, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					dbExpression
				});
			}
		}

		// Token: 0x02000A9B RID: 2715
		private abstract class UnaryTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.TypedTranslator<global::System.Linq.Expressions.UnaryExpression>
		{
			// Token: 0x0600627D RID: 25213 RVA: 0x00155010 File Offset: 0x00153210
			protected UnaryTranslator(params global::System.Linq.Expressions.ExpressionType[] nodeTypes) : base(nodeTypes)
			{
			}

			// Token: 0x0600627E RID: 25214 RVA: 0x00155019 File Offset: 0x00153219
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TypedTranslate(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.UnaryExpression linq)
			{
				return this.TranslateUnary(parent, linq, parent.TranslateExpression(linq.Operand));
			}

			// Token: 0x0600627F RID: 25215
			protected abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.UnaryExpression unary, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand);
		}

		// Token: 0x02000A9C RID: 2716
		private sealed class QuoteTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.UnaryTranslator
		{
			// Token: 0x06006280 RID: 25216 RVA: 0x0015502F File Offset: 0x0015322F
			internal QuoteTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Quote
			})
			{
			}

			// Token: 0x06006281 RID: 25217 RVA: 0x00155042 File Offset: 0x00153242
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.UnaryExpression unary, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand)
			{
				return operand;
			}
		}

		// Token: 0x02000A9D RID: 2717
		private sealed class ConvertTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.UnaryTranslator
		{
			// Token: 0x06006282 RID: 25218 RVA: 0x00155045 File Offset: 0x00153245
			internal ConvertTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.Convert,
				global::System.Linq.Expressions.ExpressionType.ConvertChecked
			})
			{
			}

			// Token: 0x06006283 RID: 25219 RVA: 0x00155060 File Offset: 0x00153260
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.UnaryExpression unary, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand)
			{
				global::System.Type type = unary.Type;
				global::System.Type type2 = unary.Operand.Type;
				return parent.CreateCastExpression(operand, type, type2);
			}
		}

		// Token: 0x02000A9E RID: 2718
		private sealed class AsTranslator : global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.UnaryTranslator
		{
			// Token: 0x06006284 RID: 25220 RVA: 0x00155089 File Offset: 0x00153289
			internal AsTranslator() : base(new global::System.Linq.Expressions.ExpressionType[]
			{
				global::System.Linq.Expressions.ExpressionType.TypeAs
			})
			{
			}

			// Token: 0x06006285 RID: 25221 RVA: 0x0015509C File Offset: 0x0015329C
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TranslateUnary(global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter parent, global::System.Linq.Expressions.UnaryExpression unary, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression operand)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage isOrAsTargetType = parent.GetIsOrAsTargetType(global::System.Linq.Expressions.ExpressionType.TypeAs, unary.Type, unary.Operand.Type);
				return operand.TreatAs(isOrAsTargetType);
			}
		}
	}
}
