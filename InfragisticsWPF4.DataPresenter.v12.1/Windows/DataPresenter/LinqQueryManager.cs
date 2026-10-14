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
	// Token: 0x020001F1 RID: 497
	internal class LinqQueryManager
	{
		// Token: 0x06001BF9 RID: 7161 RVA: 0x00077136 File Offset: 0x00075336
		public LinqQueryManager(global::System.Collections.IEnumerable list, global::System.Type listItemType)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(list);
			global::Infragistics.CoreUtilities.ValidateNotNull(listItemType);
			this._list = list;
			this._listItemType = listItemType;
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00077163 File Offset: 0x00075363
		public global::System.Collections.IEnumerable List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x0007716B File Offset: 0x0007536B
		public global::System.Type ListItemType
		{
			get
			{
				return this._listItemType;
			}
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00077174 File Offset: 0x00075374
		public bool DoesItemMatch(object item, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition condition)
		{
			global::System.Collections.IEnumerable e = this.PerformQuery(new object[]
			{
				item
			}, condition);
			return global::Infragistics.CoreUtilities.HasItems(e);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0007719B File Offset: 0x0007539B
		public global::System.Collections.IEnumerable PerformQuery(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement linqStatement)
		{
			return this.PerformQuery(this._list, linqStatement);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000771AA File Offset: 0x000753AA
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition AndHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y)
		{
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.AndOrHelper(x, y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.And);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x000771B4 File Offset: 0x000753B4
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition AndHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition z)
		{
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.AndHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.AndHelper(x, y), z);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000771C4 File Offset: 0x000753C4
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

		// Token: 0x06001C01 RID: 7169 RVA: 0x00077224 File Offset: 0x00075424
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

		// Token: 0x06001C02 RID: 7170 RVA: 0x000772A4 File Offset: 0x000754A4
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

		// Token: 0x06001C03 RID: 7171 RVA: 0x000772D4 File Offset: 0x000754D4
		internal global::System.Type GetPropertyType(string propName)
		{
			global::System.Reflection.PropertyInfo property = this.GetProperty(propName);
			if (!(null != property))
			{
				return null;
			}
			return property.PropertyType;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000772FA File Offset: 0x000754FA
		internal bool HasProperty(string propName)
		{
			return null != this.GetProperty(propName);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00077309 File Offset: 0x00075509
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition OrHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y)
		{
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.AndOrHelper(x, y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.Or);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00077313 File Offset: 0x00075513
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition OrHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition z)
		{
			return global::Infragistics.Windows.DataPresenter.LinqQueryManager.OrHelper(global::Infragistics.Windows.DataPresenter.LinqQueryManager.OrHelper(z, y), z);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00077324 File Offset: 0x00075524
		internal global::System.Collections.IEnumerable PerformQuery(global::System.Collections.IEnumerable list, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement linqQuery)
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
			object obj = queryable.Provider.Execute(queriableExpression);
			if (obj != null && !(obj is global::System.Collections.IEnumerable))
			{
				obj = new object[]
				{
					obj
				};
			}
			return (global::System.Collections.IEnumerable)obj;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x000773C7 File Offset: 0x000755C7
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

		// Token: 0x06001C09 RID: 7177 RVA: 0x000773E0 File Offset: 0x000755E0
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

		// Token: 0x06001C0A RID: 7178 RVA: 0x00077434 File Offset: 0x00075634
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

		// Token: 0x06001C0B RID: 7179 RVA: 0x000774B4 File Offset: 0x000756B4
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

		// Token: 0x06001C0C RID: 7180 RVA: 0x00077544 File Offset: 0x00075744
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

		// Token: 0x06001C0D RID: 7181 RVA: 0x00077638 File Offset: 0x00075838
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

		// Token: 0x06001C0E RID: 7182 RVA: 0x000776BE File Offset: 0x000758BE
		private static T[] ToNonNullItems<T>(params T[] items) where T : class
		{
			return (from ii in items
			where null != ii
			select ii).ToArray<T>();
		}

		// Token: 0x04000B97 RID: 2967
		private global::System.Collections.Generic.Dictionary<global::System.Tuple<string, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>, int, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>>, global::System.Reflection.MethodInfo> _cachedMethods = new global::System.Collections.Generic.Dictionary<global::System.Tuple<string, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>, int, global::Infragistics.Windows.DataPresenter.ListKey<global::System.Type>>, global::System.Reflection.MethodInfo>();

		// Token: 0x04000B98 RID: 2968
		private global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo> _cachedProperties;

		// Token: 0x04000B99 RID: 2969
		private global::System.Collections.IEnumerable _list;

		// Token: 0x04000B9A RID: 2970
		private global::System.Type _listItemType;

		// Token: 0x020001F2 RID: 498
		public class CreateExpressionInfo
		{
			// Token: 0x06001C10 RID: 7184 RVA: 0x000776D7 File Offset: 0x000758D7
			public CreateExpressionInfo(global::Infragistics.Windows.DataPresenter.LinqQueryManager manager, global::System.Linq.Expressions.Expression queriableExpression, global::System.Linq.Expressions.ParameterExpression parameterExpression)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(manager);
				global::Infragistics.CoreUtilities.ValidateNotNull(queriableExpression);
				global::Infragistics.CoreUtilities.ValidateNotNull(parameterExpression);
				this._manager = manager;
				this._lastQueriableExpression = queriableExpression;
				this._parameterExpression = parameterExpression;
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06001C11 RID: 7185 RVA: 0x00077711 File Offset: 0x00075911
			internal global::System.Linq.Expressions.Expression QueriableExpression
			{
				get
				{
					return this._lastQueriableExpression;
				}
			}

			// Token: 0x06001C12 RID: 7186 RVA: 0x00077719 File Offset: 0x00075919
			internal void UpdateQueriableExpression(global::System.Linq.Expressions.Expression newQueriableExpression)
			{
				this._lastQueriableExpression = newQueriableExpression;
			}

			// Token: 0x06001C13 RID: 7187 RVA: 0x00077722 File Offset: 0x00075922
			internal void UpdateParameterExpression(global::System.Linq.Expressions.ParameterExpression newParameterExpression)
			{
				this._parameterExpression = newParameterExpression;
			}

			// Token: 0x06001C14 RID: 7188 RVA: 0x0007772C File Offset: 0x0007592C
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

			// Token: 0x04000B9B RID: 2971
			internal global::Infragistics.Windows.DataPresenter.LinqQueryManager _manager;

			// Token: 0x04000B9C RID: 2972
			internal global::System.Linq.Expressions.Expression _lastQueriableExpression;

			// Token: 0x04000B9D RID: 2973
			internal global::System.Linq.Expressions.ParameterExpression _parameterExpression;

			// Token: 0x04000B9E RID: 2974
			internal global::System.Collections.Generic.Dictionary<string, global::System.Linq.Expressions.MemberExpression> _cachedMembers = new global::System.Collections.Generic.Dictionary<string, global::System.Linq.Expressions.MemberExpression>();
		}

		// Token: 0x020001F3 RID: 499
		public interface ILinqExpression
		{
			// Token: 0x06001C15 RID: 7189
			global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info);
		}

		// Token: 0x020001F4 RID: 500
		public interface ILinqStatement : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
		}

		// Token: 0x020001F5 RID: 501
		public interface ILinqInstruction : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
		}

		// Token: 0x020001F6 RID: 502
		public interface ILinqCondition : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
		}

		// Token: 0x020001F7 RID: 503
		public enum LinqOperator
		{
			// Token: 0x04000BA0 RID: 2976
			Equal,
			// Token: 0x04000BA1 RID: 2977
			NotEqual,
			// Token: 0x04000BA2 RID: 2978
			LessThan,
			// Token: 0x04000BA3 RID: 2979
			LessThanOrEqual,
			// Token: 0x04000BA4 RID: 2980
			GreaterThan,
			// Token: 0x04000BA5 RID: 2981
			GreaterThanOrEqual,
			// Token: 0x04000BA6 RID: 2982
			AnyOf
		}

		// Token: 0x020001F8 RID: 504
		public enum LinqLogicalOperator
		{
			// Token: 0x04000BA8 RID: 2984
			And,
			// Token: 0x04000BA9 RID: 2985
			Or
		}

		// Token: 0x020001F9 RID: 505
		public class LinqCondition : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x06001C16 RID: 7190 RVA: 0x00077792 File Offset: 0x00075992
			public LinqCondition(string lhsFieldName, string rhsFieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator linqOperator) : this(lhsFieldName, linqOperator, rhsFieldName, true)
			{
			}

			// Token: 0x06001C17 RID: 7191 RVA: 0x0007779E File Offset: 0x0007599E
			public LinqCondition(string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator linqOperator, object operand) : this(fieldName, linqOperator, operand, false)
			{
			}

			// Token: 0x06001C18 RID: 7192 RVA: 0x000777AA File Offset: 0x000759AA
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

			// Token: 0x06001C19 RID: 7193 RVA: 0x000777E6 File Offset: 0x000759E6
			public LinqCondition(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression lhs, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator linqOperator, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression rhs)
			{
				this._linqOperator = linqOperator;
				this._lhs = lhs;
				this._rhs = rhs;
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00077803 File Offset: 0x00075A03
			public string FieldName
			{
				get
				{
					return this._fieldName;
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0007780B File Offset: 0x00075A0B
			public bool IsOperandFieldName
			{
				get
				{
					return this._isOperandFieldName;
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00077813 File Offset: 0x00075A13
			public global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator Operator
			{
				get
				{
					return this._linqOperator;
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0007781B File Offset: 0x00075A1B
			public object Operand
			{
				get
				{
					return this._operand;
				}
			}

			// Token: 0x06001C1E RID: 7198 RVA: 0x00077824 File Offset: 0x00075A24
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

			// Token: 0x04000BAA RID: 2986
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqOperator _linqOperator;

			// Token: 0x04000BAB RID: 2987
			private string _fieldName;

			// Token: 0x04000BAC RID: 2988
			private object _operand;

			// Token: 0x04000BAD RID: 2989
			private bool _isOperandFieldName;

			// Token: 0x04000BAE RID: 2990
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression _lhs;

			// Token: 0x04000BAF RID: 2991
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression _rhs;
		}

		// Token: 0x020001FA RID: 506
		public abstract class LinqInstructionBase : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqInstruction, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x06001C1F RID: 7199 RVA: 0x000779D8 File Offset: 0x00075BD8
			public LinqInstructionBase(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement)
			{
				this._innerStatement = innerStatement;
			}

			// Token: 0x06001C20 RID: 7200
			public abstract global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info);

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x06001C21 RID: 7201 RVA: 0x000779E7 File Offset: 0x00075BE7
			public global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement InnerStatement
			{
				get
				{
					return this._innerStatement;
				}
			}

			// Token: 0x06001C22 RID: 7202 RVA: 0x000779EF File Offset: 0x00075BEF
			protected void ProcessInnerStatement(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase.ProcessInnerStatementHelper(this._innerStatement, info);
			}

			// Token: 0x06001C23 RID: 7203 RVA: 0x00077A00 File Offset: 0x00075C00
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

			// Token: 0x04000BB0 RID: 2992
			protected global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement _innerStatement;
		}

		// Token: 0x020001FB RID: 507
		public class LinqInstructionOrderBy : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x06001C24 RID: 7204 RVA: 0x00077A2F File Offset: 0x00075C2F
			public LinqInstructionOrderBy(string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement, bool descending) : base(innerStatement)
			{
				this._fieldName = fieldName;
				this._descending = descending;
			}

			// Token: 0x06001C25 RID: 7205 RVA: 0x00077A48 File Offset: 0x00075C48
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

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00077B20 File Offset: 0x00075D20
			public bool Descending
			{
				get
				{
					return this._descending;
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00077B28 File Offset: 0x00075D28
			public string FieldName
			{
				get
				{
					return this._fieldName;
				}
			}

			// Token: 0x04000BB1 RID: 2993
			private string _fieldName;

			// Token: 0x04000BB2 RID: 2994
			private bool _descending;
		}

		// Token: 0x020001FC RID: 508
		public class LinqInstructionSelect : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x06001C28 RID: 7208 RVA: 0x00077B30 File Offset: 0x00075D30
			public LinqInstructionSelect(string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement) : base(innerStatement)
			{
				this._fieldName = fieldName;
			}

			// Token: 0x06001C29 RID: 7209 RVA: 0x00077B40 File Offset: 0x00075D40
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

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00077BDB File Offset: 0x00075DDB
			public string FieldName
			{
				get
				{
					return this._fieldName;
				}
			}

			// Token: 0x04000BB3 RID: 2995
			private string _fieldName;
		}

		// Token: 0x020001FD RID: 509
		public class LinqInstructionDistinct : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x06001C2B RID: 7211 RVA: 0x00077BE3 File Offset: 0x00075DE3
			public LinqInstructionDistinct(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement) : base(innerStatement)
			{
			}

			// Token: 0x06001C2C RID: 7212 RVA: 0x00077BEC File Offset: 0x00075DEC
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

		// Token: 0x020001FE RID: 510
		public class LinqInstructionFirstOrLast : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x06001C2D RID: 7213 RVA: 0x00077C3A File Offset: 0x00075E3A
			public LinqInstructionFirstOrLast(bool first, bool orDefault, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition condition, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement) : base(innerStatement)
			{
				this._first = first;
				this._orDefault = orDefault;
				this._condition = condition;
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00077C59 File Offset: 0x00075E59
			public global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition Condition
			{
				get
				{
					return this._condition;
				}
			}

			// Token: 0x06001C2F RID: 7215 RVA: 0x00077C64 File Offset: 0x00075E64
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

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00077D2D File Offset: 0x00075F2D
			public bool First
			{
				get
				{
					return this._first;
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00077D35 File Offset: 0x00075F35
			public bool OrDefault
			{
				get
				{
					return this._orDefault;
				}
			}

			// Token: 0x04000BB4 RID: 2996
			private bool _first;

			// Token: 0x04000BB5 RID: 2997
			private bool _orDefault;

			// Token: 0x04000BB6 RID: 2998
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition _condition;
		}

		// Token: 0x020001FF RID: 511
		public class LinqInstructionSummary : global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionBase
		{
			// Token: 0x06001C32 RID: 7218 RVA: 0x00077D3D File Offset: 0x00075F3D
			public LinqInstructionSummary(string summary, string fieldName, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement innerStatement) : base(innerStatement)
			{
				this._summary = summary;
				this._fieldName = fieldName;
			}

			// Token: 0x06001C33 RID: 7219 RVA: 0x00077D54 File Offset: 0x00075F54
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

			// Token: 0x04000BB7 RID: 2999
			private string _summary;

			// Token: 0x04000BB8 RID: 3000
			private string _fieldName;
		}

		// Token: 0x02000200 RID: 512
		public class LinqExpressionBinary : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x06001C34 RID: 7220 RVA: 0x00077EAE File Offset: 0x000760AE
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

			// Token: 0x06001C35 RID: 7221 RVA: 0x00077EEC File Offset: 0x000760EC
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

			// Token: 0x04000BB9 RID: 3001
			private string _lhs;

			// Token: 0x04000BBA RID: 3002
			private string _rhs;

			// Token: 0x04000BBB RID: 3003
			private string _binaryOperator;
		}

		// Token: 0x02000201 RID: 513
		public class LinqExpressionConstant : global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x06001C36 RID: 7222 RVA: 0x00077F4A File Offset: 0x0007614A
			public LinqExpressionConstant(object value)
			{
				this._value = value;
			}

			// Token: 0x06001C37 RID: 7223 RVA: 0x00077F59 File Offset: 0x00076159
			public global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.Windows.DataPresenter.LinqQueryManager.CreateExpressionInfo info)
			{
				return global::System.Linq.Expressions.Expression.Constant(this._value);
			}

			// Token: 0x04000BBC RID: 3004
			private object _value;
		}

		// Token: 0x02000202 RID: 514
		public class LinqConditionGroup : global::System.Collections.ObjectModel.Collection<global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition>, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqStatement, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqExpression
		{
			// Token: 0x06001C38 RID: 7224 RVA: 0x00077F66 File Offset: 0x00076166
			public LinqConditionGroup() : this(global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.And)
			{
			}

			// Token: 0x06001C39 RID: 7225 RVA: 0x00077F6F File Offset: 0x0007616F
			public LinqConditionGroup(global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator logicalOperator)
			{
				this._logicalOperator = logicalOperator;
			}

			// Token: 0x06001C3A RID: 7226 RVA: 0x00077F7E File Offset: 0x0007617E
			public LinqConditionGroup(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y) : this(x, y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator.And)
			{
			}

			// Token: 0x06001C3B RID: 7227 RVA: 0x00077F89 File Offset: 0x00076189
			public LinqConditionGroup(global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition x, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition y, global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator logicalOperator)
			{
				this._logicalOperator = logicalOperator;
				base.Add(x);
				base.Add(y);
			}

			// Token: 0x06001C3C RID: 7228 RVA: 0x00077FA6 File Offset: 0x000761A6
			protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition item)
			{
				if (item == null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.ScheduleUtilities.GetString("LE_CanNotAddANullItem"));
				}
				base.InsertItem(index, item);
			}

			// Token: 0x06001C3D RID: 7229 RVA: 0x00077FC3 File Offset: 0x000761C3
			protected override void SetItem(int index, global::Infragistics.Windows.DataPresenter.LinqQueryManager.ILinqCondition item)
			{
				if (item == null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.ScheduleUtilities.GetString("LE_CanNotAddANullItem"));
				}
				base.SetItem(index, item);
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00077FE0 File Offset: 0x000761E0
			// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00077FE8 File Offset: 0x000761E8
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

			// Token: 0x06001C40 RID: 7232 RVA: 0x00077FF4 File Offset: 0x000761F4
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

			// Token: 0x04000BBD RID: 3005
			private global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqLogicalOperator _logicalOperator;
		}
	}
}
