using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000466 RID: 1126
	internal sealed class QueryParameterExpression : global::System.Linq.Expressions.Expression
	{
		// Token: 0x06003786 RID: 14214 RVA: 0x000B3C0E File Offset: 0x000B1E0E
		internal QueryParameterExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression parameterReference, global::System.Linq.Expressions.Expression funcletizedExpression, global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.ParameterExpression> compiledQueryParameters)
		{
			this._compiledQueryParameters = (compiledQueryParameters ?? global::System.Linq.Enumerable.Empty<global::System.Linq.Expressions.ParameterExpression>());
			this._parameterReference = parameterReference;
			this._type = funcletizedExpression.Type;
			this._funcletizedExpression = funcletizedExpression;
			this._cachedDelegate = null;
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x000B3C48 File Offset: 0x000B1E48
		internal object EvaluateParameter(object[] arguments)
		{
			if (this._cachedDelegate == null)
			{
				if (this._funcletizedExpression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant)
				{
					return ((global::System.Linq.Expressions.ConstantExpression)this._funcletizedExpression).Value;
				}
				global::System.Linq.Expressions.ConstantExpression constantExpression;
				if (global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression.TryEvaluatePath(this._funcletizedExpression, out constantExpression))
				{
					return constantExpression.Value;
				}
			}
			object result;
			try
			{
				if (this._cachedDelegate == null)
				{
					global::System.Type delegateType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetDelegateType(from p in this._compiledQueryParameters
					select p.Type, this._type);
					this._cachedDelegate = global::System.Linq.Expressions.Expression.Lambda(delegateType, this._funcletizedExpression, this._compiledQueryParameters).Compile();
				}
				result = this._cachedDelegate.DynamicInvoke(arguments);
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				throw ex.InnerException;
			}
			return result;
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x000B3D18 File Offset: 0x000B1F18
		internal global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression EscapeParameterForLike(global::System.Linq.Expressions.Expression<global::System.Func<string, global::System.Tuple<string, bool>>> method)
		{
			global::System.Linq.Expressions.Expression funcletizedExpression = global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Invoke(method, new global::System.Linq.Expressions.Expression[]
			{
				this._funcletizedExpression
			}), "Item1");
			return new global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression(this._parameterReference, funcletizedExpression, this._compiledQueryParameters);
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x000B3D57 File Offset: 0x000B1F57
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression ParameterReference
		{
			get
			{
				return this._parameterReference;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x000B3D5F File Offset: 0x000B1F5F
		public override global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x000B3D67 File Offset: 0x000B1F67
		public override global::System.Linq.Expressions.ExpressionType NodeType
		{
			get
			{
				return (global::System.Linq.Expressions.ExpressionType)(-1);
			}
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x000B3D6C File Offset: 0x000B1F6C
		private static bool TryEvaluatePath(global::System.Linq.Expressions.Expression expression, out global::System.Linq.Expressions.ConstantExpression constantExpression)
		{
			global::System.Linq.Expressions.MemberExpression memberExpression = expression as global::System.Linq.Expressions.MemberExpression;
			constantExpression = null;
			if (memberExpression != null)
			{
				global::System.Collections.Generic.Stack<global::System.Linq.Expressions.MemberExpression> stack = new global::System.Collections.Generic.Stack<global::System.Linq.Expressions.MemberExpression>();
				stack.Push(memberExpression);
				while ((memberExpression = (memberExpression.Expression as global::System.Linq.Expressions.MemberExpression)) != null)
				{
					stack.Push(memberExpression);
				}
				memberExpression = stack.Pop();
				if (memberExpression.Expression is global::System.Linq.Expressions.ConstantExpression)
				{
					object obj;
					if (!global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression.TryGetFieldOrPropertyValue(memberExpression, ((global::System.Linq.Expressions.ConstantExpression)memberExpression.Expression).Value, out obj))
					{
						return false;
					}
					if (stack.Count > 0)
					{
						using (global::System.Collections.Generic.Stack<global::System.Linq.Expressions.MemberExpression>.Enumerator enumerator = stack.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (!global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression.TryGetFieldOrPropertyValue(enumerator.Current, obj, out obj))
								{
									return false;
								}
							}
						}
					}
					constantExpression = global::System.Linq.Expressions.Expression.Constant(obj, expression.Type);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x000B3E44 File Offset: 0x000B2044
		private static bool TryGetFieldOrPropertyValue(global::System.Linq.Expressions.MemberExpression me, object instance, out object memberValue)
		{
			bool flag = false;
			memberValue = null;
			bool result;
			try
			{
				if (me.Member.MemberType == global::System.Reflection.MemberTypes.Field)
				{
					memberValue = ((global::System.Reflection.FieldInfo)me.Member).GetValue(instance);
					flag = true;
				}
				else if (me.Member.MemberType == global::System.Reflection.MemberTypes.Property)
				{
					memberValue = ((global::System.Reflection.PropertyInfo)me.Member).GetValue(instance, null);
					flag = true;
				}
				result = flag;
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				throw ex.InnerException;
			}
			return result;
		}

		// Token: 0x04001221 RID: 4641
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression _parameterReference;

		// Token: 0x04001222 RID: 4642
		private readonly global::System.Type _type;

		// Token: 0x04001223 RID: 4643
		private readonly global::System.Linq.Expressions.Expression _funcletizedExpression;

		// Token: 0x04001224 RID: 4644
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.ParameterExpression> _compiledQueryParameters;

		// Token: 0x04001225 RID: 4645
		private global::System.Delegate _cachedDelegate;
	}
}
