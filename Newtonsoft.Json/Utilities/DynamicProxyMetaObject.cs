using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000050 RID: 80
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal sealed class DynamicProxyMetaObject<[global::System.Runtime.CompilerServices.Nullable(2)] T> : global::System.Dynamic.DynamicMetaObject
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00013EAA File Offset: 0x000120AA
		internal DynamicProxyMetaObject(global::System.Linq.Expressions.Expression expression, T value, global::Newtonsoft.Json.Utilities.DynamicProxy<T> proxy) : base(expression, global::System.Dynamic.BindingRestrictions.Empty, value)
		{
			this._proxy = proxy;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00013EC5 File Offset: 0x000120C5
		private bool IsOverridden(string method)
		{
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.IsMethodOverridden(this._proxy.GetType(), typeof(global::Newtonsoft.Json.Utilities.DynamicProxy<T>), method);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00013EE4 File Offset: 0x000120E4
		public override global::System.Dynamic.DynamicMetaObject BindGetMember(global::System.Dynamic.GetMemberBinder binder)
		{
			if (!this.IsOverridden("TryGetMember"))
			{
				return base.BindGetMember(binder);
			}
			return this.CallMethodWithResult("TryGetMember", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.NoArgs, ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackGetMember(this, e), null);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00013F44 File Offset: 0x00012144
		public override global::System.Dynamic.DynamicMetaObject BindSetMember(global::System.Dynamic.SetMemberBinder binder, global::System.Dynamic.DynamicMetaObject value)
		{
			if (!this.IsOverridden("TrySetMember"))
			{
				return base.BindSetMember(binder, value);
			}
			return this.CallMethodReturnLast("TrySetMember", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgs(new global::System.Dynamic.DynamicMetaObject[]
			{
				value
			}), ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackSetMember(this, value, e));
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00013FC0 File Offset: 0x000121C0
		public override global::System.Dynamic.DynamicMetaObject BindDeleteMember(global::System.Dynamic.DeleteMemberBinder binder)
		{
			if (!this.IsOverridden("TryDeleteMember"))
			{
				return base.BindDeleteMember(binder);
			}
			return this.CallMethodNoResult("TryDeleteMember", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.NoArgs, ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackDeleteMember(this, e));
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00014020 File Offset: 0x00012220
		public override global::System.Dynamic.DynamicMetaObject BindConvert(global::System.Dynamic.ConvertBinder binder)
		{
			if (!this.IsOverridden("TryConvert"))
			{
				return base.BindConvert(binder);
			}
			return this.CallMethodWithResult("TryConvert", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.NoArgs, ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackConvert(this, e), null);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00014080 File Offset: 0x00012280
		public override global::System.Dynamic.DynamicMetaObject BindInvokeMember(global::System.Dynamic.InvokeMemberBinder binder, global::System.Dynamic.DynamicMetaObject[] args)
		{
			if (!this.IsOverridden("TryInvokeMember"))
			{
				return base.BindInvokeMember(binder, args);
			}
			global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Fallback fallback = ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackInvokeMember(this, args, e);
			return this.BuildCallMethodWithResult("TryInvokeMember", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgArray(args), this.BuildCallMethodWithResult("TryGetMember", new global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetBinderAdapter(binder), global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.NoArgs, fallback(null), ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackInvoke(e, args, null)), null);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00014120 File Offset: 0x00012320
		public override global::System.Dynamic.DynamicMetaObject BindCreateInstance(global::System.Dynamic.CreateInstanceBinder binder, global::System.Dynamic.DynamicMetaObject[] args)
		{
			if (!this.IsOverridden("TryCreateInstance"))
			{
				return base.BindCreateInstance(binder, args);
			}
			return this.CallMethodWithResult("TryCreateInstance", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgArray(args), ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackCreateInstance(this, args, e), null);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00014194 File Offset: 0x00012394
		public override global::System.Dynamic.DynamicMetaObject BindInvoke(global::System.Dynamic.InvokeBinder binder, global::System.Dynamic.DynamicMetaObject[] args)
		{
			if (!this.IsOverridden("TryInvoke"))
			{
				return base.BindInvoke(binder, args);
			}
			return this.CallMethodWithResult("TryInvoke", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgArray(args), ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackInvoke(this, args, e), null);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00014208 File Offset: 0x00012408
		public override global::System.Dynamic.DynamicMetaObject BindBinaryOperation(global::System.Dynamic.BinaryOperationBinder binder, global::System.Dynamic.DynamicMetaObject arg)
		{
			if (!this.IsOverridden("TryBinaryOperation"))
			{
				return base.BindBinaryOperation(binder, arg);
			}
			return this.CallMethodWithResult("TryBinaryOperation", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgs(new global::System.Dynamic.DynamicMetaObject[]
			{
				arg
			}), ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackBinaryOperation(this, arg, e), null);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00014284 File Offset: 0x00012484
		public override global::System.Dynamic.DynamicMetaObject BindUnaryOperation(global::System.Dynamic.UnaryOperationBinder binder)
		{
			if (!this.IsOverridden("TryUnaryOperation"))
			{
				return base.BindUnaryOperation(binder);
			}
			return this.CallMethodWithResult("TryUnaryOperation", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.NoArgs, ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackUnaryOperation(this, e), null);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000142E4 File Offset: 0x000124E4
		public override global::System.Dynamic.DynamicMetaObject BindGetIndex(global::System.Dynamic.GetIndexBinder binder, global::System.Dynamic.DynamicMetaObject[] indexes)
		{
			if (!this.IsOverridden("TryGetIndex"))
			{
				return base.BindGetIndex(binder, indexes);
			}
			return this.CallMethodWithResult("TryGetIndex", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgArray(indexes), ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackGetIndex(this, indexes, e), null);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00014358 File Offset: 0x00012558
		public override global::System.Dynamic.DynamicMetaObject BindSetIndex(global::System.Dynamic.SetIndexBinder binder, global::System.Dynamic.DynamicMetaObject[] indexes, global::System.Dynamic.DynamicMetaObject value)
		{
			if (!this.IsOverridden("TrySetIndex"))
			{
				return base.BindSetIndex(binder, indexes, value);
			}
			return this.CallMethodReturnLast("TrySetIndex", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgArray(indexes, value), ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackSetIndex(this, indexes, value, e));
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000143DC File Offset: 0x000125DC
		public override global::System.Dynamic.DynamicMetaObject BindDeleteIndex(global::System.Dynamic.DeleteIndexBinder binder, global::System.Dynamic.DynamicMetaObject[] indexes)
		{
			if (!this.IsOverridden("TryDeleteIndex"))
			{
				return base.BindDeleteIndex(binder, indexes);
			}
			return this.CallMethodNoResult("TryDeleteIndex", binder, global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgArray(indexes), ([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject e) => binder.FallbackDeleteIndex(this, indexes, e));
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001444C File Offset: 0x0001264C
		private static global::System.Linq.Expressions.Expression[] NoArgs
		{
			get
			{
				return global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<global::System.Linq.Expressions.Expression>();
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00014453 File Offset: 0x00012653
		private static global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> GetArgs(params global::System.Dynamic.DynamicMetaObject[] args)
		{
			return args.Select(delegate(global::System.Dynamic.DynamicMetaObject arg)
			{
				global::System.Linq.Expressions.Expression expression = arg.Expression;
				if (!expression.Type.IsValueType())
				{
					return expression;
				}
				return global::System.Linq.Expressions.Expression.Convert(expression, typeof(object));
			});
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001447C File Offset: 0x0001267C
		private static global::System.Linq.Expressions.Expression[] GetArgArray(global::System.Dynamic.DynamicMetaObject[] args)
		{
			return new global::System.Linq.Expressions.NewArrayExpression[]
			{
				global::System.Linq.Expressions.Expression.NewArrayInit(typeof(object), global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgs(args))
			};
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000144AC File Offset: 0x000126AC
		private static global::System.Linq.Expressions.Expression[] GetArgArray(global::System.Dynamic.DynamicMetaObject[] args, global::System.Dynamic.DynamicMetaObject value)
		{
			global::System.Linq.Expressions.Expression expression = value.Expression;
			return new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.NewArrayInit(typeof(object), global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.GetArgs(args)),
				expression.Type.IsValueType() ? global::System.Linq.Expressions.Expression.Convert(expression, typeof(object)) : expression
			};
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00014504 File Offset: 0x00012704
		private static global::System.Linq.Expressions.ConstantExpression Constant(global::System.Dynamic.DynamicMetaObjectBinder binder)
		{
			global::System.Type type = binder.GetType();
			while (!type.IsVisible())
			{
				type = type.BaseType();
			}
			return global::System.Linq.Expressions.Expression.Constant(binder, type);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00014530 File Offset: 0x00012730
		private global::System.Dynamic.DynamicMetaObject CallMethodWithResult(string methodName, global::System.Dynamic.DynamicMetaObjectBinder binder, global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> args, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0
		})] global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Fallback fallback, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			0
		})] global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Fallback fallbackInvoke = null)
		{
			global::System.Dynamic.DynamicMetaObject fallbackResult = fallback(null);
			return this.BuildCallMethodWithResult(methodName, binder, args, fallbackResult, fallbackInvoke);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00014554 File Offset: 0x00012754
		private global::System.Dynamic.DynamicMetaObject BuildCallMethodWithResult(string methodName, global::System.Dynamic.DynamicMetaObjectBinder binder, global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> args, global::System.Dynamic.DynamicMetaObject fallbackResult, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			0
		})] global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Fallback fallbackInvoke)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), null);
			global::System.Collections.Generic.IList<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>();
			list.Add(global::System.Linq.Expressions.Expression.Convert(base.Expression, typeof(T)));
			list.Add(global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Constant(binder));
			list.AddRange(args);
			list.Add(parameterExpression);
			global::System.Dynamic.DynamicMetaObject dynamicMetaObject = new global::System.Dynamic.DynamicMetaObject(parameterExpression, global::System.Dynamic.BindingRestrictions.Empty);
			if (binder.ReturnType != typeof(object))
			{
				dynamicMetaObject = new global::System.Dynamic.DynamicMetaObject(global::System.Linq.Expressions.Expression.Convert(dynamicMetaObject.Expression, binder.ReturnType), dynamicMetaObject.Restrictions);
			}
			if (fallbackInvoke != null)
			{
				dynamicMetaObject = fallbackInvoke(dynamicMetaObject);
			}
			return new global::System.Dynamic.DynamicMetaObject(global::System.Linq.Expressions.Expression.Block(new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Condition(global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Constant(this._proxy), typeof(global::Newtonsoft.Json.Utilities.DynamicProxy<T>).GetMethod(methodName), list), dynamicMetaObject.Expression, fallbackResult.Expression, binder.ReturnType)
			}), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions).Merge(fallbackResult.Restrictions));
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00014670 File Offset: 0x00012870
		private global::System.Dynamic.DynamicMetaObject CallMethodReturnLast(string methodName, global::System.Dynamic.DynamicMetaObjectBinder binder, global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> args, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0
		})] global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Fallback fallback)
		{
			global::System.Dynamic.DynamicMetaObject dynamicMetaObject = fallback(null);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), null);
			global::System.Collections.Generic.IList<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>();
			list.Add(global::System.Linq.Expressions.Expression.Convert(base.Expression, typeof(T)));
			list.Add(global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Constant(binder));
			list.AddRange(args);
			list[list.Count - 1] = global::System.Linq.Expressions.Expression.Assign(parameterExpression, list[list.Count - 1]);
			return new global::System.Dynamic.DynamicMetaObject(global::System.Linq.Expressions.Expression.Block(new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Condition(global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Constant(this._proxy), typeof(global::Newtonsoft.Json.Utilities.DynamicProxy<T>).GetMethod(methodName), list), parameterExpression, dynamicMetaObject.Expression, typeof(object))
			}), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions));
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00014754 File Offset: 0x00012954
		private global::System.Dynamic.DynamicMetaObject CallMethodNoResult(string methodName, global::System.Dynamic.DynamicMetaObjectBinder binder, global::System.Linq.Expressions.Expression[] args, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0
		})] global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Fallback fallback)
		{
			global::System.Dynamic.DynamicMetaObject dynamicMetaObject = fallback(null);
			global::System.Collections.Generic.IList<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>();
			list.Add(global::System.Linq.Expressions.Expression.Convert(base.Expression, typeof(T)));
			list.Add(global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T>.Constant(binder));
			list.AddRange(args);
			return new global::System.Dynamic.DynamicMetaObject(global::System.Linq.Expressions.Expression.Condition(global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Constant(this._proxy), typeof(global::Newtonsoft.Json.Utilities.DynamicProxy<T>).GetMethod(methodName), list), global::System.Linq.Expressions.Expression.Empty(), dynamicMetaObject.Expression, typeof(void)), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions));
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000147EF File Offset: 0x000129EF
		private global::System.Dynamic.BindingRestrictions GetRestrictions()
		{
			if (base.Value != null || !base.HasValue)
			{
				return global::System.Dynamic.BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
			}
			return global::System.Dynamic.BindingRestrictions.GetInstanceRestriction(base.Expression, null);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001481F File Offset: 0x00012A1F
		public override global::System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames()
		{
			return this._proxy.GetDynamicMemberNames((T)((object)base.Value));
		}

		// Token: 0x040001BD RID: 445
		private readonly global::Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy;

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x06000E96 RID: 3734
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		private delegate global::System.Dynamic.DynamicMetaObject Fallback([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Dynamic.DynamicMetaObject errorSuggestion);

		// Token: 0x0200016A RID: 362
		[global::System.Runtime.CompilerServices.Nullable(0)]
		private sealed class GetBinderAdapter : global::System.Dynamic.GetMemberBinder
		{
			// Token: 0x06000E99 RID: 3737 RVA: 0x00041604 File Offset: 0x0003F804
			internal GetBinderAdapter(global::System.Dynamic.InvokeMemberBinder binder) : base(binder.Name, binder.IgnoreCase)
			{
			}

			// Token: 0x06000E9A RID: 3738 RVA: 0x00041618 File Offset: 0x0003F818
			public override global::System.Dynamic.DynamicMetaObject FallbackGetMember(global::System.Dynamic.DynamicMetaObject target, global::System.Dynamic.DynamicMetaObject errorSuggestion)
			{
				throw new global::System.NotSupportedException();
			}
		}
	}
}
