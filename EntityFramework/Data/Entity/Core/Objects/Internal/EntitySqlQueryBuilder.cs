using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200043E RID: 1086
	internal static class EntitySqlQueryBuilder
	{
		// Token: 0x06003518 RID: 13592 RVA: 0x000A9CB4 File Offset: 0x000A7EB4
		private static string GetCommandText(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query)
		{
			string result = null;
			if (!query.TryGetCommandText(out result))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ObjectQuery_QueryBuilder_NotSupportedLinqSource);
			}
			return result;
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x000A9CDC File Offset: 0x000A7EDC
		private static global::System.Data.Entity.Core.Objects.ObjectParameterCollection MergeParameters(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.ObjectParameterCollection sourceQueryParams, global::System.Data.Entity.Core.Objects.ObjectParameter[] builderMethodParams)
		{
			if (sourceQueryParams == null && builderMethodParams.Length == 0)
			{
				return null;
			}
			global::System.Data.Entity.Core.Objects.ObjectParameterCollection objectParameterCollection = global::System.Data.Entity.Core.Objects.ObjectParameterCollection.DeepCopy(sourceQueryParams);
			if (objectParameterCollection == null)
			{
				objectParameterCollection = new global::System.Data.Entity.Core.Objects.ObjectParameterCollection(context.Perspective);
			}
			foreach (global::System.Data.Entity.Core.Objects.ObjectParameter item in builderMethodParams)
			{
				objectParameterCollection.Add(item);
			}
			return objectParameterCollection;
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x000A9D24 File Offset: 0x000A7F24
		private static global::System.Data.Entity.Core.Objects.ObjectParameterCollection MergeParameters(global::System.Data.Entity.Core.Objects.ObjectParameterCollection query1Params, global::System.Data.Entity.Core.Objects.ObjectParameterCollection query2Params)
		{
			if (query1Params == null && query2Params == null)
			{
				return null;
			}
			global::System.Data.Entity.Core.Objects.ObjectParameterCollection objectParameterCollection;
			global::System.Data.Entity.Core.Objects.ObjectParameterCollection objectParameterCollection2;
			if (query1Params != null)
			{
				objectParameterCollection = global::System.Data.Entity.Core.Objects.ObjectParameterCollection.DeepCopy(query1Params);
				objectParameterCollection2 = query2Params;
			}
			else
			{
				objectParameterCollection = global::System.Data.Entity.Core.Objects.ObjectParameterCollection.DeepCopy(query2Params);
				objectParameterCollection2 = query1Params;
			}
			if (objectParameterCollection2 != null)
			{
				foreach (global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter in objectParameterCollection2)
				{
					objectParameterCollection.Add(objectParameter.ShallowCopy());
				}
			}
			return objectParameterCollection;
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000A9D94 File Offset: 0x000A7F94
		private static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState NewBuilderQuery(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState sourceQuery, global::System.Type elementType, global::System.Text.StringBuilder queryText, global::System.Data.Entity.Core.Objects.Span newSpan, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectParameter> enumerableParams)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.NewBuilderQuery(sourceQuery, elementType, queryText, false, newSpan, enumerableParams);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000A9DA4 File Offset: 0x000A7FA4
		private static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState NewBuilderQuery(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState sourceQuery, global::System.Type elementType, global::System.Text.StringBuilder queryText, bool allowsLimit, global::System.Data.Entity.Core.Objects.Span newSpan, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectParameter> enumerableParams)
		{
			global::System.Data.Entity.Core.Objects.ObjectParameterCollection objectParameterCollection = enumerableParams as global::System.Data.Entity.Core.Objects.ObjectParameterCollection;
			if (objectParameterCollection == null && enumerableParams != null)
			{
				objectParameterCollection = new global::System.Data.Entity.Core.Objects.ObjectParameterCollection(sourceQuery.ObjectContext.Perspective);
				foreach (global::System.Data.Entity.Core.Objects.ObjectParameter item in enumerableParams)
				{
					objectParameterCollection.Add(item);
				}
			}
			global::System.Data.Entity.Core.Objects.EntitySqlQueryState entitySqlQueryState = new global::System.Data.Entity.Core.Objects.EntitySqlQueryState(elementType, queryText.ToString(), allowsLimit, sourceQuery.ObjectContext, objectParameterCollection, newSpan);
			sourceQuery.ApplySettingsTo(entitySqlQueryState);
			return entitySqlQueryState;
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x000A9E2C File Offset: 0x000A802C
		private static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState BuildSetOp(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState leftQuery, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState rightQuery, global::System.Data.Entity.Core.Objects.Span newSpan, string setOp)
		{
			string commandText = global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GetCommandText(leftQuery);
			string commandText2 = global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GetCommandText(rightQuery);
			if (leftQuery.ObjectContext != rightQuery.ObjectContext)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectQuery_QueryBuilder_InvalidQueryArgument, "query");
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("(\r\n".Length + commandText.Length + setOp.Length + commandText2.Length + "\r\n)".Length);
			stringBuilder.Append("(\r\n");
			stringBuilder.Append(commandText);
			stringBuilder.Append(setOp);
			stringBuilder.Append(commandText2);
			stringBuilder.Append("\r\n)");
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.NewBuilderQuery(leftQuery, leftQuery.ElementType, stringBuilder, newSpan, global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.MergeParameters(leftQuery.Parameters, rightQuery.Parameters));
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x000A9EE4 File Offset: 0x000A80E4
		private static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState BuildSelectOrSelectValue(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string projection, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters, string projectOp, global::System.Type elementType)
		{
			string commandText = global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GetCommandText(query);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(projectOp.Length + projection.Length + "\r\nFROM (\r\n".Length + commandText.Length + "\r\n) AS ".Length + alias.Length);
			stringBuilder.Append(projectOp);
			stringBuilder.Append(projection);
			stringBuilder.Append("\r\nFROM (\r\n");
			stringBuilder.Append(commandText);
			stringBuilder.Append("\r\n) AS ");
			stringBuilder.Append(alias);
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.NewBuilderQuery(query, elementType, stringBuilder, null, global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.MergeParameters(query.ObjectContext, query.Parameters, parameters));
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x000A9F88 File Offset: 0x000A8188
		private static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState BuildOrderByOrWhere(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string predicateOrKeys, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters, string op, string skipCount, bool allowsLimit)
		{
			string commandText = global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GetCommandText(query);
			int num = "SELECT VALUE ".Length + alias.Length + "\r\nFROM (\r\n".Length + commandText.Length + "\r\n) AS ".Length + alias.Length + op.Length + predicateOrKeys.Length;
			if (skipCount != null)
			{
				num += "\r\nSKIP\r\n".Length + skipCount.Length;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(num);
			stringBuilder.Append("SELECT VALUE ");
			stringBuilder.Append(alias);
			stringBuilder.Append("\r\nFROM (\r\n");
			stringBuilder.Append(commandText);
			stringBuilder.Append("\r\n) AS ");
			stringBuilder.Append(alias);
			stringBuilder.Append(op);
			stringBuilder.Append(predicateOrKeys);
			if (skipCount != null)
			{
				stringBuilder.Append("\r\nSKIP\r\n");
				stringBuilder.Append(skipCount);
			}
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.NewBuilderQuery(query, query.ElementType, stringBuilder, allowsLimit, query.Span, global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.MergeParameters(query.ObjectContext, query.Parameters, parameters));
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x000AA090 File Offset: 0x000A8290
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Distinct(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query)
		{
			string commandText = global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GetCommandText(query);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("SET(\r\n".Length + commandText.Length + "\r\n)".Length);
			stringBuilder.Append("SET(\r\n");
			stringBuilder.Append(commandText);
			stringBuilder.Append("\r\n)");
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.NewBuilderQuery(query, query.ElementType, stringBuilder, query.Span, global::System.Data.Entity.Core.Objects.ObjectParameterCollection.DeepCopy(query.Parameters));
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x000AA104 File Offset: 0x000A8304
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Except(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState leftQuery, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState rightQuery)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildSetOp(leftQuery, rightQuery, leftQuery.Span, "\r\n) EXCEPT (\r\n");
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x000AA118 File Offset: 0x000A8318
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState GroupBy(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string keys, string projection, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			string commandText = global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GetCommandText(query);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("SELECT ".Length + projection.Length + "\r\nFROM (\r\n".Length + commandText.Length + "\r\n) AS ".Length + alias.Length + "\r\nGROUP BY\r\n".Length + keys.Length);
			stringBuilder.Append("SELECT ");
			stringBuilder.Append(projection);
			stringBuilder.Append("\r\nFROM (\r\n");
			stringBuilder.Append(commandText);
			stringBuilder.Append("\r\n) AS ");
			stringBuilder.Append(alias);
			stringBuilder.Append("\r\nGROUP BY\r\n");
			stringBuilder.Append(keys);
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.NewBuilderQuery(query, typeof(global::System.Data.Common.DbDataRecord), stringBuilder, null, global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.MergeParameters(query.ObjectContext, query.Parameters, parameters));
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x000AA1F0 File Offset: 0x000A83F0
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Intersect(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState leftQuery, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState rightQuery)
		{
			global::System.Data.Entity.Core.Objects.Span newSpan = global::System.Data.Entity.Core.Objects.Span.CopyUnion(leftQuery.Span, rightQuery.Span);
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildSetOp(leftQuery, rightQuery, newSpan, "\r\n) INTERSECT (\r\n");
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x000AA21C File Offset: 0x000A841C
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState OfType(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, global::System.Data.Entity.Core.Metadata.Edm.EdmType newType, global::System.Type clrOfType)
		{
			string commandText = global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GetCommandText(query);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("OFTYPE(\r\n(\r\n".Length + commandText.Length + "\r\n),\r\n[".Length + newType.NamespaceName.Length + ((!string.IsNullOrEmpty(newType.NamespaceName)) ? "].[".Length : 0) + newType.Name.Length + "]\r\n)".Length);
			stringBuilder.Append("OFTYPE(\r\n(\r\n");
			stringBuilder.Append(commandText);
			stringBuilder.Append("\r\n),\r\n[");
			if (!string.IsNullOrEmpty(newType.NamespaceName))
			{
				stringBuilder.Append(newType.NamespaceName);
				stringBuilder.Append("].[");
			}
			stringBuilder.Append(newType.Name);
			stringBuilder.Append("]\r\n)");
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.NewBuilderQuery(query, clrOfType, stringBuilder, query.Span, global::System.Data.Entity.Core.Objects.ObjectParameterCollection.DeepCopy(query.Parameters));
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x000AA308 File Offset: 0x000A8508
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState OrderBy(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string keys, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildOrderByOrWhere(query, alias, keys, parameters, "\r\nORDER BY\r\n", null, true);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x000AA31A File Offset: 0x000A851A
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Select(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string projection, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildSelectOrSelectValue(query, alias, projection, parameters, "SELECT ", typeof(global::System.Data.Common.DbDataRecord));
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x000AA334 File Offset: 0x000A8534
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState SelectValue(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string projection, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters, global::System.Type projectedType)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildSelectOrSelectValue(query, alias, projection, parameters, "SELECT VALUE ", projectedType);
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x000AA346 File Offset: 0x000A8546
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Skip(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string keys, string count, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildOrderByOrWhere(query, alias, keys, parameters, "\r\nORDER BY\r\n", count, true);
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x000AA35C File Offset: 0x000A855C
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Top(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string count, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			int num = count.Length;
			string commandText = global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GetCommandText(query);
			bool allowsLimitSubclause = ((global::System.Data.Entity.Core.Objects.EntitySqlQueryState)query).AllowsLimitSubclause;
			if (allowsLimitSubclause)
			{
				num += commandText.Length + "\r\nLIMIT\r\n".Length;
			}
			else
			{
				num += "SELECT VALUE TOP(\r\n".Length + "\r\n) ".Length + alias.Length + "\r\nFROM (\r\n".Length + commandText.Length + "\r\n) AS ".Length + alias.Length;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(num);
			if (allowsLimitSubclause)
			{
				stringBuilder.Append(commandText);
				stringBuilder.Append("\r\nLIMIT\r\n");
				stringBuilder.Append(count);
			}
			else
			{
				stringBuilder.Append("SELECT VALUE TOP(\r\n");
				stringBuilder.Append(count);
				stringBuilder.Append("\r\n) ");
				stringBuilder.Append(alias);
				stringBuilder.Append("\r\nFROM (\r\n");
				stringBuilder.Append(commandText);
				stringBuilder.Append("\r\n) AS ");
				stringBuilder.Append(alias);
			}
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.NewBuilderQuery(query, query.ElementType, stringBuilder, query.Span, global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.MergeParameters(query.ObjectContext, query.Parameters, parameters));
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x000AA47C File Offset: 0x000A867C
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Union(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState leftQuery, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState rightQuery)
		{
			global::System.Data.Entity.Core.Objects.Span newSpan = global::System.Data.Entity.Core.Objects.Span.CopyUnion(leftQuery.Span, rightQuery.Span);
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildSetOp(leftQuery, rightQuery, newSpan, "\r\n) UNION (\r\n");
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x000AA4A8 File Offset: 0x000A86A8
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState UnionAll(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState leftQuery, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState rightQuery)
		{
			global::System.Data.Entity.Core.Objects.Span newSpan = global::System.Data.Entity.Core.Objects.Span.CopyUnion(leftQuery.Span, rightQuery.Span);
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildSetOp(leftQuery, rightQuery, newSpan, "\r\n) UNION ALL (\r\n");
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x000AA4D4 File Offset: 0x000A86D4
		internal static global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Where(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState query, string alias, string predicate, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.BuildOrderByOrWhere(query, alias, predicate, parameters, "\r\nWHERE\r\n", null, false);
		}

		// Token: 0x04001122 RID: 4386
		private const string _setOpEpilog = "\r\n)";

		// Token: 0x04001123 RID: 4387
		private const string _setOpProlog = "(\r\n";

		// Token: 0x04001124 RID: 4388
		private const string _fromOp = "\r\nFROM (\r\n";

		// Token: 0x04001125 RID: 4389
		private const string _asOp = "\r\n) AS ";

		// Token: 0x04001126 RID: 4390
		private const string _distinctProlog = "SET(\r\n";

		// Token: 0x04001127 RID: 4391
		private const string _distinctEpilog = "\r\n)";

		// Token: 0x04001128 RID: 4392
		private const string _exceptOp = "\r\n) EXCEPT (\r\n";

		// Token: 0x04001129 RID: 4393
		private const string _groupByOp = "\r\nGROUP BY\r\n";

		// Token: 0x0400112A RID: 4394
		private const string _intersectOp = "\r\n) INTERSECT (\r\n";

		// Token: 0x0400112B RID: 4395
		private const string _ofTypeProlog = "OFTYPE(\r\n(\r\n";

		// Token: 0x0400112C RID: 4396
		private const string _ofTypeInfix = "\r\n),\r\n[";

		// Token: 0x0400112D RID: 4397
		private const string _ofTypeInfix2 = "].[";

		// Token: 0x0400112E RID: 4398
		private const string _ofTypeEpilog = "]\r\n)";

		// Token: 0x0400112F RID: 4399
		private const string _orderByOp = "\r\nORDER BY\r\n";

		// Token: 0x04001130 RID: 4400
		private const string _selectOp = "SELECT ";

		// Token: 0x04001131 RID: 4401
		private const string _selectValueOp = "SELECT VALUE ";

		// Token: 0x04001132 RID: 4402
		private const string _skipOp = "\r\nSKIP\r\n";

		// Token: 0x04001133 RID: 4403
		private const string _limitOp = "\r\nLIMIT\r\n";

		// Token: 0x04001134 RID: 4404
		private const string _topOp = "SELECT VALUE TOP(\r\n";

		// Token: 0x04001135 RID: 4405
		private const string _topInfix = "\r\n) ";

		// Token: 0x04001136 RID: 4406
		private const string _unionOp = "\r\n) UNION (\r\n";

		// Token: 0x04001137 RID: 4407
		private const string _unionAllOp = "\r\n) UNION ALL (\r\n";

		// Token: 0x04001138 RID: 4408
		private const string _whereOp = "\r\nWHERE\r\n";
	}
}
