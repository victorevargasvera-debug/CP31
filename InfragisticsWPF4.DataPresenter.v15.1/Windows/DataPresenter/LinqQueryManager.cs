using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000225 RID: 549
	internal class LinqQueryManager
	{
		// Token: 0x06002077 RID: 8311 RVA: 0x0008D50A File Offset: 0x0008B70A
		public LinqQueryManager(global::System.Collections.IEnumerable list, global::System.Type listItemType)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(list);
			global::Infragistics.CoreUtilities.ValidateNotNull(listItemType);
			this._list = list;
			this._listItemType = listItemType;
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x0008D537 File Offset: 0x0008B737
		public global::System.Collections.IEnumerable List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0008D53F File Offset: 0x0008B73F
		public global::System.Type ListItemType
		{
			get
			{
				return this._listItemType;
			}
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x0008D548 File Offset: 0x0008B748
		public bool DoesItemMatch(object item, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition condition)
		{
			object obj = this.PerformQuery(new object[]
			{
				item
			}, condition);
			return obj is global::System.Collections.IEnumerable && global::Infragistics.CoreUtilities.HasItems((global::System.Collections.IEnumerable)obj);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x0008D57E File Offset: 0x0008B77E
		public object PerformQuery(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement linqStatement)
		{
			return this.PerformQuery(this._list, linqStatement);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0008D58D File Offset: 0x0008B78D
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition AndHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y)
		{
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.AndOrHelper(x, y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.And);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x0008D597 File Offset: 0x0008B797
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition AndHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition z)
		{
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.AndHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.AndHelper(x, y), z);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x0008D5A8 File Offset: 0x0008B7A8
		internal global::System.Collections.IEnumerable GetTypedEnumerable(global::System.Collections.IEnumerable list)
		{
			if (this._listItemType != global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetListElementType(list, false))
			{
				global::System.Type typeFromHandle = typeof(global::Infragistics.Collections.TypedEnumerable<>);
				global::System.Type type = typeFromHandle.MakeGenericType(new global::System.Type[]
				{
					this._listItemType
				});
				return (global::System.Collections.IEnumerable)global::System.Activator.CreateInstance(type, new object[]
				{
					list
				});
			}
			return list;
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x0008D608 File Offset: 0x0008B808
		internal static global::System.Type GetListElementType(global::System.Collections.IEnumerable list, bool useCollectionViewSource = true)
		{
			global::System.Type type = list.GetType();
			global::System.Type[] interfaces = type.GetInterfaces();
			if (interfaces != null)
			{
				foreach (global::System.Type type2 in interfaces)
				{
					if (type2.IsGenericType && typeof(global::System.Collections.Generic.IEnumerable<>) == type2.GetGenericTypeDefinition())
					{
						global::System.Type[] genericArguments = type2.GetGenericArguments();
						if (genericArguments != null && 1 == genericArguments.Length)
						{
							return genericArguments[0];
						}
					}
				}
				if (useCollectionViewSource)
				{
					global::System.Type listElementType_CollectionView = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetListElementType_CollectionView(list);
					if (null != listElementType_CollectionView)
					{
						return listElementType_CollectionView;
					}
				}
			}
			return null;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x0008D688 File Offset: 0x0008B888
		private static global::System.Type GetListElementType_CollectionView(global::System.Collections.IEnumerable list)
		{
			global::System.ComponentModel.ICollectionView collectionView = list as global::System.ComponentModel.ICollectionView;
			global::System.Collections.IEnumerable enumerable = (collectionView != null) ? collectionView.SourceCollection : null;
			if (enumerable == null)
			{
				return null;
			}
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetListElementType(enumerable, false);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x0008D6B8 File Offset: 0x0008B8B8
		internal global::System.Type GetPropertyType(string propName)
		{
			global::System.Reflection.PropertyInfo property = this.GetProperty(propName);
			if (!(null != property))
			{
				return null;
			}
			return property.PropertyType;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0008D6DE File Offset: 0x0008B8DE
		internal bool HasProperty(string propName)
		{
			return null != this.GetProperty(propName);
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x0008D6ED File Offset: 0x0008B8ED
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition OrHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y)
		{
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.AndOrHelper(x, y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.Or);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x0008D6F7 File Offset: 0x0008B8F7
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition OrHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition z)
		{
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.OrHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.OrHelper(z, y), z);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0008D708 File Offset: 0x0008B908
		internal object PerformQuery(global::System.Collections.IEnumerable list, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement linqQuery)
		{
			global::System.Collections.IEnumerable typedEnumerable = this.GetTypedEnumerable(list);
			global::System.Linq.IQueryable queryable = typedEnumerable.AsQueryable();
			global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo createExpressionInfo = new global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo(this, queryable.Expression, global::System.Linq.Expressions.Expression.Parameter(this._listItemType, "i"));
			global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase.ProcessInnerStatementHelper(linqQuery, createExpressionInfo);
			global::System.Linq.Expressions.Expression queriableExpression = createExpressionInfo.QueriableExpression;
			if (typeof(global::System.Linq.IQueryable).IsAssignableFrom(queriableExpression.Type))
			{
				return queryable.Provider.CreateQuery(queriableExpression);
			}
			return queryable.Provider.Execute(queriableExpression);
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x0008D77F File Offset: 0x0008B97F
		private static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition AndOrHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator logicalOperator)
		{
			if (x != null && y != null)
			{
				return new global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqConditionGroup(x, y, logicalOperator);
			}
			if (x != null)
			{
				return x;
			}
			return y;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0008D798 File Offset: 0x0008B998
		internal static global::System.Linq.Expressions.MemberExpression GetCachedMemberExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info, string fieldName)
		{
			global::System.Linq.Expressions.MemberExpression memberExpression;
			if (!info._cachedMembers.TryGetValue(fieldName, out memberExpression))
			{
				memberExpression = global::System.Linq.Expressions.Expression.Property(info._parameterExpression, fieldName);
				info._cachedMembers[fieldName] = memberExpression;
			}
			return memberExpression;
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x0008D7EC File Offset: 0x0008B9EC
		internal global::System.Reflection.PropertyInfo GetProperty(string propName)
		{
			global::System.Reflection.PropertyInfo propertyInfo;
			if (this._cachedProperties != null && this._cachedProperties.TryGetValue(propName, out propertyInfo))
			{
				return propertyInfo;
			}
			global::System.Reflection.PropertyInfo[] properties = this._listItemType.GetProperties();
			propertyInfo = properties.FirstOrDefault((global::System.Reflection.PropertyInfo ii) => ii.Name == propName);
			if (this._cachedProperties == null)
			{
				this._cachedProperties = new global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo>();
			}
			this._cachedProperties[propName] = propertyInfo;
			return propertyInfo;
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x0008D86C File Offset: 0x0008BA6C
		private static bool AreParametersCompatible(global::System.Reflection.MethodInfo method, global::System.Type[] parameterTypes)
		{
			int num = 0;
			foreach (global::System.Reflection.ParameterInfo parameterInfo in method.GetParameters())
			{
				if (!parameterInfo.ParameterType.IsAssignableFrom(parameterTypes[num++]))
				{
					return false;
				}
			}
			return num == parameterTypes.Length;
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x0008D8FC File Offset: 0x0008BAFC
		private static global::System.Reflection.MethodInfo GetMethodHelper(global::System.Reflection.MethodInfo[] methods, string name, global::System.Type[] genericTypeArguments, int parameterCount, params global::System.Type[] parameterTypes)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> enumerable = from ii in methods
			where ii.Name == name
			select ii;
			if (parameterCount >= 0)
			{
				enumerable = from ii in enumerable
				where ii.GetParameters().Length == parameterCount
				select ii;
			}
			if (genericTypeArguments != null)
			{
				enumerable = from ii in enumerable
				where ii.GetGenericArguments().Length == genericTypeArguments.Length
				select ii;
			}
			foreach (global::System.Reflection.MethodInfo methodInfo in enumerable)
			{
				try
				{
					global::System.Reflection.MethodInfo methodInfo2 = (genericTypeArguments == null) ? methodInfo : methodInfo.MakeGenericMethod(genericTypeArguments);
					if (null != methodInfo2 && (parameterTypes == null || global::Infragistics.Windows.DataPresenter.LinqQueryManager.AreParametersCompatible(methodInfo2, parameterTypes)))
					{
						return methodInfo2;
					}
				}
				catch
				{
				}
			}
			return null;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x0008D9F0 File Offset: 0x0008BBF0
		private global::System.Reflection.MethodInfo GetMethod(string name, global::System.Type[] genericTypeArguments, int parameterCount, global::System.Type[] parameterTypes = null)
		{
			global::System.Tuple<string, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>, int, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>> key = new global::System.Tuple<string, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>, int, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>>(name, new global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>(genericTypeArguments), parameterCount, new global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>(parameterTypes));
			global::System.Reflection.MethodInfo methodHelper;
			this._cachedMethods.TryGetValue(key, out methodHelper);
			if (null == methodHelper)
			{
				global::System.Reflection.MethodInfo[] methods = typeof(global::System.Linq.Queryable).GetMethods();
				methodHelper = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetMethodHelper(methods, name, genericTypeArguments, parameterCount, parameterTypes);
				if (null == methodHelper)
				{
					throw new global::System.ArgumentException("Unable to find a matching method.");
				}
				this._cachedMethods[key] = methodHelper;
			}
			return methodHelper;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x0008DA76 File Offset: 0x0008BC76
		private static T[] ToNonNullItems<T>(params T[] items) where T : class
		{
			return (from ii in items
			where null != ii
			select ii).ToArray<T>();
		}

		// Token: 0x04000DB3 RID: 3507
		private global::System.Collections.Generic.Dictionary<global::System.Tuple<string, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>, int, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>>, global::System.Reflection.MethodInfo> _cachedMethods = new global::System.Collections.Generic.Dictionary<global::System.Tuple<string, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>, int, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>>, global::System.Reflection.MethodInfo>();

		// Token: 0x04000DB4 RID: 3508
		private global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo> _cachedProperties;

		// Token: 0x04000DB5 RID: 3509
		private global::System.Collections.IEnumerable _list;

		// Token: 0x04000DB6 RID: 3510
		private global::System.Type _listItemType;

		// Token: 0x02000226 RID: 550
		public class CreateExpressionInfo
		{
			// Token: 0x0600208E RID: 8334 RVA: 0x0008DA8F File Offset: 0x0008BC8F
			public CreateExpressionInfo(global::Infragistics.Windows.DataPresenter.LinqQueryManager manager, global::System.Linq.Expressions.Expression queriableExpression, global::System.Linq.Expressions.ParameterExpression parameterExpression)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(manager);
				global::Infragistics.CoreUtilities.ValidateNotNull(queriableExpression);
				global::Infragistics.CoreUtilities.ValidateNotNull(parameterExpression);
				this._manager = manager;
				this._lastQueriableExpression = queriableExpression;
				this._parameterExpression = parameterExpression;
			}

			// Token: 0x1700093D RID: 2365
			// (get) Token: 0x0600208F RID: 8335 RVA: 0x0008DAC9 File Offset: 0x0008BCC9
			internal global::System.Linq.Expressions.Expression QueriableExpression
			{
				get
				{
					return this._lastQueriableExpression;
				}
			}

			// Token: 0x06002090 RID: 8336 RVA: 0x0008DAD1 File Offset: 0x0008BCD1
			internal void UpdateQueriableExpression(global::System.Linq.Expressions.Expression newQueriableExpression)
			{
				this._lastQueriableExpression = newQueriableExpression;
			}

			// Token: 0x06002091 RID: 8337 RVA: 0x0008DADA File Offset: 0x0008BCDA
			internal void UpdateParameterExpression(global::System.Linq.Expressions.ParameterExpression newParameterExpression)
			{
				this._parameterExpression = newParameterExpression;
			}

			// Token: 0x06002092 RID: 8338 RVA: 0x0008DAE4 File Offset: 0x0008BCE4
			internal void ApplyFilterConditions(global::System.Linq.Expressions.Expression lambdaBody)
			{
				global::System.Linq.Expressions.LambdaExpression arg = global::System.Linq.Expressions.Expression.Lambda(lambdaBody, new global::System.Linq.Expressions.ParameterExpression[]
				{
					this._parameterExpression
				});
				global::System.Reflection.MethodInfo method = this._manager.GetMethod("Where", global::Infragistics.Windows.DataPresenter.LinqQueryManager.ToNonNullItems<global::System.Type>(new global::System.Type[]
				{
					this._parameterExpression.Type
				}), 2, null);
				this._lastQueriableExpression = global::System.Linq.Expressions.Expression.Call(method, this._lastQueriableExpression, arg);
			}

			// Token: 0x04000DB7 RID: 3511
			internal global::Infragistics.Windows.DataPresenter.LinqQueryManager _manager;

			// Token: 0x04000DB8 RID: 3512
			internal global::System.Linq.Expressions.Expression _lastQueriableExpression;

			// Token: 0x04000DB9 RID: 3513
			internal global::System.Linq.Expressions.ParameterExpression _parameterExpression;

			// Token: 0x04000DBA RID: 3514
			internal global::System.Collections.Generic.Dictionary<string, global::System.Linq.Expressions.MemberExpression> _cachedMembers = new global::System.Collections.Generic.Dictionary<string, global::System.Linq.Expressions.MemberExpression>();
		}

		// Token: 0x02000227 RID: 551
		public interface ILinqExpression
		{
			// Token: 0x06002093 RID: 8339
			global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info);
		}

		// Token: 0x02000228 RID: 552
		public interface ILinqStatement : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
		}

		// Token: 0x02000229 RID: 553
		public interface ILinqInstruction : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
		}

		// Token: 0x0200022A RID: 554
		public interface ILinqCondition : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
		}

		// Token: 0x0200022B RID: 555
		public enum LinqOperator
		{
			// Token: 0x04000DBC RID: 3516
			Equal,
			// Token: 0x04000DBD RID: 3517
			NotEqual,
			// Token: 0x04000DBE RID: 3518
			LessThan,
			// Token: 0x04000DBF RID: 3519
			LessThanOrEqual,
			// Token: 0x04000DC0 RID: 3520
			GreaterThan,
			// Token: 0x04000DC1 RID: 3521
			GreaterThanOrEqual,
			// Token: 0x04000DC2 RID: 3522
			AnyOf
		}

		// Token: 0x0200022C RID: 556
		public enum LinqLogicalOperator
		{
			// Token: 0x04000DC4 RID: 3524
			And,
			// Token: 0x04000DC5 RID: 3525
			Or
		}

		// Token: 0x0200022D RID: 557
		public class LinqCondition : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x06002094 RID: 8340 RVA: 0x0008DB4A File Offset: 0x0008BD4A
			public LinqCondition(string lhsFieldName, string rhsFieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator linqOperator) : this(lhsFieldName, linqOperator, rhsFieldName, true)
			{
			}

			// Token: 0x06002095 RID: 8341 RVA: 0x0008DB56 File Offset: 0x0008BD56
			public LinqCondition(string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator linqOperator, object operand) : this(fieldName, linqOperator, operand, false)
			{
			}

			// Token: 0x06002096 RID: 8342 RVA: 0x0008DB62 File Offset: 0x0008BD62
			private LinqCondition(string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator linqOperator, object operand, bool isOperandFieldName)
			{
				if (isOperandFieldName && global::Infragistics.CoreUtilities.IsValueEmpty(operand))
				{
					throw new global::System.ArgumentOutOfRangeException("operand");
				}
				this._linqOperator = linqOperator;
				this._fieldName = fieldName;
				this._operand = operand;
				this._isOperandFieldName = isOperandFieldName;
			}

			// Token: 0x06002097 RID: 8343 RVA: 0x0008DB9E File Offset: 0x0008BD9E
			public LinqCondition(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression lhs, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator linqOperator, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression rhs)
			{
				this._linqOperator = linqOperator;
				this._lhs = lhs;
				this._rhs = rhs;
			}

			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x06002098 RID: 8344 RVA: 0x0008DBBB File Offset: 0x0008BDBB
			public string FieldName
			{
				get
				{
					return this._fieldName;
				}
			}

			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x06002099 RID: 8345 RVA: 0x0008DBC3 File Offset: 0x0008BDC3
			public bool IsOperandFieldName
			{
				get
				{
					return this._isOperandFieldName;
				}
			}

			// Token: 0x17000940 RID: 2368
			// (get) Token: 0x0600209A RID: 8346 RVA: 0x0008DBCB File Offset: 0x0008BDCB
			public global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator Operator
			{
				get
				{
					return this._linqOperator;
				}
			}

			// Token: 0x17000941 RID: 2369
			// (get) Token: 0x0600209B RID: 8347 RVA: 0x0008DBD3 File Offset: 0x0008BDD3
			public object Operand
			{
				get
				{
					return this._operand;
				}
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x0008DBDC File Offset: 0x0008BDDC
			public global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				global::System.Linq.Expressions.Expression expression = (this._lhs != null) ? this._lhs.CreateExpression(info) : global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetCachedMemberExpression(info, this._fieldName);
				global::System.Linq.Expressions.Expression expression2 = null;
				if (this._rhs != null)
				{
					expression2 = this._rhs.CreateExpression(info);
				}
				else if (this._isOperandFieldName)
				{
					expression2 = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetCachedMemberExpression(info, this._operand.ToString());
				}
				else
				{
					global::System.Type type = expression.Type;
					global::System.Type right = (this._operand != null) ? this._operand.GetType() : null;
					if (type != right && null != right && global::Infragistics.CoreUtilities.GetUnderlyingType(type) == right)
					{
						expression2 = global::System.Linq.Expressions.Expression.Constant(this._operand, type);
					}
					if (expression2 == null)
					{
						expression2 = global::System.Linq.Expressions.Expression.Constant(this._operand);
					}
				}
				switch (this._linqOperator)
				{
				case global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.Equal:
					return global::System.Linq.Expressions.Expression.Equal(expression, expression2);
				case global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.NotEqual:
					return global::System.Linq.Expressions.Expression.NotEqual(expression, expression2);
				case global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.LessThan:
					return global::System.Linq.Expressions.Expression.LessThan(expression, expression2);
				case global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.LessThanOrEqual:
					return global::System.Linq.Expressions.Expression.LessThanOrEqual(expression, expression2);
				case global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.GreaterThan:
					return global::System.Linq.Expressions.Expression.GreaterThan(expression, expression2);
				case global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.GreaterThanOrEqual:
					return global::System.Linq.Expressions.Expression.GreaterThanOrEqual(expression, expression2);
				case global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.AnyOf:
				{
					global::System.Collections.IEnumerable enumerable = this._operand as global::System.Collections.IEnumerable;
					if (enumerable != null)
					{
						global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqConditionGroup linqConditionGroup = new global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqConditionGroup(global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.Or);
						foreach (object operand in enumerable)
						{
							linqConditionGroup.Add(new global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqCondition(this._fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.Equal, operand));
						}
						return linqConditionGroup.CreateExpression(info);
					}
					return new global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqCondition(this._fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator.Equal, this._operand).CreateExpression(info);
				}
				default:
					return null;
				}
			}

			// Token: 0x04000DC6 RID: 3526
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator _linqOperator;

			// Token: 0x04000DC7 RID: 3527
			private string _fieldName;

			// Token: 0x04000DC8 RID: 3528
			private object _operand;

			// Token: 0x04000DC9 RID: 3529
			private bool _isOperandFieldName;

			// Token: 0x04000DCA RID: 3530
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression _lhs;

			// Token: 0x04000DCB RID: 3531
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression _rhs;
		}

		// Token: 0x0200022E RID: 558
		public abstract class LinqInstructionBase : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqInstruction, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x0600209D RID: 8349 RVA: 0x0008DD90 File Offset: 0x0008BF90
			public LinqInstructionBase(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement)
			{
				this._innerStatement = innerStatement;
			}

			// Token: 0x0600209E RID: 8350
			public abstract global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info);

			// Token: 0x17000942 RID: 2370
			// (get) Token: 0x0600209F RID: 8351 RVA: 0x0008DD9F File Offset: 0x0008BF9F
			public global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement InnerStatement
			{
				get
				{
					return this._innerStatement;
				}
			}

			// Token: 0x060020A0 RID: 8352 RVA: 0x0008DDA7 File Offset: 0x0008BFA7
			protected void ProcessInnerStatement(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase.ProcessInnerStatementHelper(this._innerStatement, info);
			}

			// Token: 0x060020A1 RID: 8353 RVA: 0x0008DDB8 File Offset: 0x0008BFB8
			internal static void ProcessInnerStatementHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				if (innerStatement != null)
				{
					global::System.Linq.Expressions.Expression expression = innerStatement.CreateExpression(info);
					if (innerStatement is global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition)
					{
						info.ApplyFilterConditions(expression);
						return;
					}
					info.UpdateQueriableExpression(expression);
				}
			}

			// Token: 0x04000DCC RID: 3532
			protected global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement _innerStatement;
		}

		// Token: 0x0200022F RID: 559
		public class LinqInstructionOrderBy : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x060020A2 RID: 8354 RVA: 0x0008DDE7 File Offset: 0x0008BFE7
			public LinqInstructionOrderBy(string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement, bool descending) : base(innerStatement)
			{
				this._fieldName = fieldName;
				this._descending = descending;
			}

			// Token: 0x060020A3 RID: 8355 RVA: 0x0008DE00 File Offset: 0x0008C000
			public override global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				base.ProcessInnerStatement(info);
				global::System.Linq.Expressions.Expression expression = null;
				if (!string.IsNullOrEmpty(this._fieldName))
				{
					expression = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetCachedMemberExpression(info, this._fieldName);
				}
				global::System.Linq.Expressions.Expression arg = (expression != null) ? global::System.Linq.Expressions.Expression.Lambda(expression, new global::System.Linq.Expressions.ParameterExpression[]
				{
					info._parameterExpression
				}) : global::System.Linq.Expressions.Expression.Lambda(info._parameterExpression, new global::System.Linq.Expressions.ParameterExpression[]
				{
					info._parameterExpression
				});
				global::System.Type type = (expression != null) ? expression.Type : info._parameterExpression.Type;
				global::System.Reflection.MethodInfo method = info._manager.GetMethod(this._descending ? "OrderByDescending" : "OrderBy", global::Infragistics.Windows.DataPresenter.LinqQueryManager.ToNonNullItems<global::System.Type>(new global::System.Type[]
				{
					info._parameterExpression.Type,
					type
				}), 2, null);
				return global::System.Linq.Expressions.Expression.Call(method, info.QueriableExpression, arg);
			}

			// Token: 0x17000943 RID: 2371
			// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0008DED8 File Offset: 0x0008C0D8
			public bool Descending
			{
				get
				{
					return this._descending;
				}
			}

			// Token: 0x17000944 RID: 2372
			// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0008DEE0 File Offset: 0x0008C0E0
			public string FieldName
			{
				get
				{
					return this._fieldName;
				}
			}

			// Token: 0x04000DCD RID: 3533
			private string _fieldName;

			// Token: 0x04000DCE RID: 3534
			private bool _descending;
		}

		// Token: 0x02000230 RID: 560
		public class LinqInstructionSelect : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x060020A6 RID: 8358 RVA: 0x0008DEE8 File Offset: 0x0008C0E8
			public LinqInstructionSelect(string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement) : base(innerStatement)
			{
				this._fieldName = fieldName;
			}

			// Token: 0x060020A7 RID: 8359 RVA: 0x0008DEF8 File Offset: 0x0008C0F8
			public override global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				base.ProcessInnerStatement(info);
				global::System.Linq.Expressions.Expression cachedMemberExpression = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetCachedMemberExpression(info, this._fieldName);
				global::System.Linq.Expressions.Expression arg = global::System.Linq.Expressions.Expression.Lambda(cachedMemberExpression, new global::System.Linq.Expressions.ParameterExpression[]
				{
					info._parameterExpression
				});
				global::System.Reflection.MethodInfo method = info._manager.GetMethod("Select", global::Infragistics.Windows.DataPresenter.LinqQueryManager.ToNonNullItems<global::System.Type>(new global::System.Type[]
				{
					info._parameterExpression.Type,
					cachedMemberExpression.Type
				}), 2, null);
				global::System.Linq.Expressions.MethodCallExpression result = global::System.Linq.Expressions.Expression.Call(method, info.QueriableExpression, arg);
				global::System.Linq.Expressions.ParameterExpression newParameterExpression = global::System.Linq.Expressions.Expression.Parameter(cachedMemberExpression.Type);
				info.UpdateParameterExpression(newParameterExpression);
				return result;
			}

			// Token: 0x17000945 RID: 2373
			// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0008DF93 File Offset: 0x0008C193
			public string FieldName
			{
				get
				{
					return this._fieldName;
				}
			}

			// Token: 0x04000DCF RID: 3535
			private string _fieldName;
		}

		// Token: 0x02000231 RID: 561
		public class LinqInstructionDistinct : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x060020A9 RID: 8361 RVA: 0x0008DF9B File Offset: 0x0008C19B
			public LinqInstructionDistinct(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement) : base(innerStatement)
			{
			}

			// Token: 0x060020AA RID: 8362 RVA: 0x0008DFA4 File Offset: 0x0008C1A4
			public override global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				base.ProcessInnerStatement(info);
				global::System.Reflection.MethodInfo method = info._manager.GetMethod("Distinct", global::Infragistics.Windows.DataPresenter.LinqQueryManager.ToNonNullItems<global::System.Type>(new global::System.Type[]
				{
					info._parameterExpression.Type
				}), 1, null);
				return global::System.Linq.Expressions.Expression.Call(method, info.QueriableExpression);
			}
		}

		// Token: 0x02000232 RID: 562
		public class LinqInstructionFirstOrLast : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x060020AB RID: 8363 RVA: 0x0008DFF2 File Offset: 0x0008C1F2
			public LinqInstructionFirstOrLast(bool first, bool orDefault, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition condition, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement) : base(innerStatement)
			{
				this._first = first;
				this._orDefault = orDefault;
				this._condition = condition;
			}

			// Token: 0x17000946 RID: 2374
			// (get) Token: 0x060020AC RID: 8364 RVA: 0x0008E011 File Offset: 0x0008C211
			public global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition Condition
			{
				get
				{
					return this._condition;
				}
			}

			// Token: 0x060020AD RID: 8365 RVA: 0x0008E01C File Offset: 0x0008C21C
			public override global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				base.ProcessInnerStatement(info);
				global::System.Linq.Expressions.Expression expression = null;
				if (this._condition != null)
				{
					global::System.Linq.Expressions.Expression body = this._condition.CreateExpression(info);
					expression = global::System.Linq.Expressions.Expression.Lambda(body, new global::System.Linq.Expressions.ParameterExpression[]
					{
						info._parameterExpression
					});
				}
				string name = this._first ? (this._orDefault ? "FirstOrDefault" : "First") : (this._orDefault ? "LastOrDefault" : "Last");
				global::System.Reflection.MethodInfo method = info._manager.GetMethod(name, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ToNonNullItems<global::System.Type>(new global::System.Type[]
				{
					info._parameterExpression.Type
				}), (expression != null) ? 2 : 1, null);
				if (expression == null)
				{
					return global::System.Linq.Expressions.Expression.Call(method, info.QueriableExpression);
				}
				return global::System.Linq.Expressions.Expression.Call(method, info.QueriableExpression, expression);
			}

			// Token: 0x17000947 RID: 2375
			// (get) Token: 0x060020AE RID: 8366 RVA: 0x0008E0E5 File Offset: 0x0008C2E5
			public bool First
			{
				get
				{
					return this._first;
				}
			}

			// Token: 0x17000948 RID: 2376
			// (get) Token: 0x060020AF RID: 8367 RVA: 0x0008E0ED File Offset: 0x0008C2ED
			public bool OrDefault
			{
				get
				{
					return this._orDefault;
				}
			}

			// Token: 0x04000DD0 RID: 3536
			private bool _first;

			// Token: 0x04000DD1 RID: 3537
			private bool _orDefault;

			// Token: 0x04000DD2 RID: 3538
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition _condition;
		}

		// Token: 0x02000233 RID: 563
		public class LinqInstructionSummary : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x060020B0 RID: 8368 RVA: 0x0008E0F5 File Offset: 0x0008C2F5
			public LinqInstructionSummary(string summary, string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement) : base(innerStatement)
			{
				this._summary = summary;
				this._fieldName = fieldName;
			}

			// Token: 0x060020B1 RID: 8369 RVA: 0x0008E10C File Offset: 0x0008C30C
			public override global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				base.ProcessInnerStatement(info);
				bool flag = "Min" == this._summary || "Max" == this._summary;
				bool flag2 = "Count" == this._summary;
				global::System.Linq.Expressions.Expression expression = null;
				if (!flag2 && !string.IsNullOrEmpty(this._fieldName))
				{
					expression = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetCachedMemberExpression(info, this._fieldName);
				}
				if ("Sum" == this._summary && typeof(int) == expression.Type)
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(decimal));
				}
				global::System.Linq.Expressions.Expression expression2 = (expression != null) ? global::System.Linq.Expressions.Expression.Lambda(expression, new global::System.Linq.Expressions.ParameterExpression[]
				{
					info._parameterExpression
				}) : null;
				global::System.Reflection.MethodInfo method = info._manager.GetMethod(this._summary, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ToNonNullItems<global::System.Type>(new global::System.Type[]
				{
					info._parameterExpression.Type,
					flag ? expression.Type : null
				}), (expression2 != null) ? 2 : 1, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ToNonNullItems<global::System.Type>(new global::System.Type[]
				{
					info.QueriableExpression.Type,
					(expression2 != null) ? expression2.GetType() : null
				}));
				if (expression2 == null)
				{
					return global::System.Linq.Expressions.Expression.Call(method, info.QueriableExpression);
				}
				return global::System.Linq.Expressions.Expression.Call(method, info.QueriableExpression, expression2);
			}

			// Token: 0x04000DD3 RID: 3539
			private string _summary;

			// Token: 0x04000DD4 RID: 3540
			private string _fieldName;
		}

		// Token: 0x02000234 RID: 564
		public class LinqExpressionBinary : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x060020B2 RID: 8370 RVA: 0x0008E266 File Offset: 0x0008C466
			public LinqExpressionBinary(string lhsField, string rhsField, string binaryOperator)
			{
				if ("+" != binaryOperator || "-" != binaryOperator)
				{
					throw new global::System.ArgumentOutOfRangeException();
				}
				this._lhs = lhsField;
				this._rhs = rhsField;
				this._binaryOperator = binaryOperator;
			}

			// Token: 0x060020B3 RID: 8371 RVA: 0x0008E2A4 File Offset: 0x0008C4A4
			public global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				global::System.Linq.Expressions.Expression cachedMemberExpression = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetCachedMemberExpression(info, this._lhs);
				global::System.Linq.Expressions.Expression cachedMemberExpression2 = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetCachedMemberExpression(info, this._rhs);
				string binaryOperator;
				if ((binaryOperator = this._binaryOperator) != null)
				{
					if (binaryOperator == "+")
					{
						return global::System.Linq.Expressions.Expression.Add(cachedMemberExpression, cachedMemberExpression2);
					}
					if (binaryOperator == "-")
					{
						return global::System.Linq.Expressions.Expression.Subtract(cachedMemberExpression, cachedMemberExpression2);
					}
				}
				return null;
			}

			// Token: 0x04000DD5 RID: 3541
			private string _lhs;

			// Token: 0x04000DD6 RID: 3542
			private string _rhs;

			// Token: 0x04000DD7 RID: 3543
			private string _binaryOperator;
		}

		// Token: 0x02000235 RID: 565
		public class LinqExpressionConstant : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x060020B4 RID: 8372 RVA: 0x0008E302 File Offset: 0x0008C502
			public LinqExpressionConstant(object value)
			{
				this._value = value;
			}

			// Token: 0x060020B5 RID: 8373 RVA: 0x0008E311 File Offset: 0x0008C511
			public global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				return global::System.Linq.Expressions.Expression.Constant(this._value);
			}

			// Token: 0x04000DD8 RID: 3544
			private object _value;
		}

		// Token: 0x02000236 RID: 566
		public class LinqConditionGroup : global::System.Collections.ObjectModel.Collection<global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition>, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x060020B6 RID: 8374 RVA: 0x0008E31E File Offset: 0x0008C51E
			public LinqConditionGroup() : this(global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.And)
			{
			}

			// Token: 0x060020B7 RID: 8375 RVA: 0x0008E327 File Offset: 0x0008C527
			public LinqConditionGroup(global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator logicalOperator)
			{
				this._logicalOperator = logicalOperator;
			}

			// Token: 0x060020B8 RID: 8376 RVA: 0x0008E336 File Offset: 0x0008C536
			public LinqConditionGroup(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y) : this(x, y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.And)
			{
			}

			// Token: 0x060020B9 RID: 8377 RVA: 0x0008E341 File Offset: 0x0008C541
			public LinqConditionGroup(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator logicalOperator)
			{
				this._logicalOperator = logicalOperator;
				base.Add(x);
				base.Add(y);
			}

			// Token: 0x060020BA RID: 8378 RVA: 0x0008E35E File Offset: 0x0008C55E
			protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition item)
			{
				if (item == null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.ScheduleUtilities.GetString("LE_CanNotAddANullItem"));
				}
				base.InsertItem(index, item);
			}

			// Token: 0x060020BB RID: 8379 RVA: 0x0008E37B File Offset: 0x0008C57B
			protected override void SetItem(int index, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition item)
			{
				if (item == null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.ScheduleUtilities.GetString("LE_CanNotAddANullItem"));
				}
				base.SetItem(index, item);
			}

			// Token: 0x17000949 RID: 2377
			// (get) Token: 0x060020BC RID: 8380 RVA: 0x0008E398 File Offset: 0x0008C598
			// (set) Token: 0x060020BD RID: 8381 RVA: 0x0008E3A0 File Offset: 0x0008C5A0
			public global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator LogicalOperator
			{
				get
				{
					return this._logicalOperator;
				}
				set
				{
					this._logicalOperator = value;
				}
			}

			// Token: 0x060020BE RID: 8382 RVA: 0x0008E3AC File Offset: 0x0008C5AC
			public global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				global::System.Linq.Expressions.Expression expression = null;
				int i = 0;
				int count = base.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition linqCondition = base[i];
					global::System.Linq.Expressions.Expression expression2 = linqCondition.CreateExpression(info);
					if (expression == null)
					{
						expression = expression2;
					}
					else
					{
						expression = ((global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.Or == this._logicalOperator) ? global::System.Linq.Expressions.Expression.OrElse(expression, expression2) : global::System.Linq.Expressions.Expression.AndAlso(expression, expression2));
					}
					i++;
				}
				return expression;
			}

			// Token: 0x04000DD9 RID: 3545
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator _logicalOperator;
		}
	}
}
