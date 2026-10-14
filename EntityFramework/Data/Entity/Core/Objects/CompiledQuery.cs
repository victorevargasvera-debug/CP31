using System;
using System.Collections;
using System.Data.Entity.Core.Objects.ELinq;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000402 RID: 1026
	public sealed class CompiledQuery
	{
		// Token: 0x06002FCA RID: 12234 RVA: 0x00095DF8 File Offset: 0x00093FF8
		private CompiledQuery(global::System.Linq.Expressions.LambdaExpression query)
		{
			global::System.Data.Entity.Core.Objects.ELinq.Funcletizer funcletizer = global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.CreateCompiledQueryLockdownFuncletizer();
			global::System.Func<bool> func;
			this._query = (global::System.Linq.Expressions.LambdaExpression)funcletizer.Funcletize(query, out func);
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00095E30 File Offset: 0x00094030
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x00095E43 File Offset: 0x00094043
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00095E56 File Offset: 0x00094056
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00095E69 File Offset: 0x00094069
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00095E7C File Offset: 0x0009407C
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00095E8F File Offset: 0x0009408F
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00095EA2 File Offset: 0x000940A2
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>);
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00095EB5 File Offset: 0x000940B5
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>);
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00095EC8 File Offset: 0x000940C8
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>);
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00095EDB File Offset: 0x000940DB
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>);
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00095EEE File Offset: 0x000940EE
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>);
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00095F01 File Offset: 0x00094101
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00095F14 File Offset: 0x00094114
		public static global::System.Func<TArg0, TArg1, TArg2, TArg3, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TArg3, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TArg3, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TArg3, TResult>);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00095F27 File Offset: 0x00094127
		public static global::System.Func<TArg0, TArg1, TArg2, TResult> Compile<TArg0, TArg1, TArg2, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TArg2, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TArg2, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TArg2, TResult>);
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00095F3A File Offset: 0x0009413A
		public static global::System.Func<TArg0, TArg1, TResult> Compile<TArg0, TArg1, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TArg1, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TArg1, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TArg1, TResult>);
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00095F4D File Offset: 0x0009414D
		public static global::System.Func<TArg0, TResult> Compile<TArg0, TResult>(global::System.Linq.Expressions.Expression<global::System.Func<TArg0, TResult>> query) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			return new global::System.Func<TArg0, TResult>(new global::System.Data.Entity.Core.Objects.CompiledQuery(query).Invoke<TArg0, TResult>);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00095F60 File Offset: 0x00094160
		private TResult Invoke<TArg0, TResult>(TArg0 arg0) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[0]);
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00095F93 File Offset: 0x00094193
		private TResult Invoke<TArg0, TArg1, TResult>(TArg0 arg0, TArg1 arg1) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1
			});
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x00095FD0 File Offset: 0x000941D0
		private TResult Invoke<TArg0, TArg1, TArg2, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2
			});
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x00096020 File Offset: 0x00094220
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3
			});
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x0009607C File Offset: 0x0009427C
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4
			});
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x000960E0 File Offset: 0x000942E0
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5
			});
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x00096150 File Offset: 0x00094350
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6
			});
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x000961C8 File Offset: 0x000943C8
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7
			});
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0009624C File Offset: 0x0009444C
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7,
				arg8
			});
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x000962D8 File Offset: 0x000944D8
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7,
				arg8,
				arg9
			});
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x00096370 File Offset: 0x00094570
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7,
				arg8,
				arg9,
				arg10
			});
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00096414 File Offset: 0x00094614
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7,
				arg8,
				arg9,
				arg10,
				arg11
			});
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x000964C4 File Offset: 0x000946C4
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7,
				arg8,
				arg9,
				arg10,
				arg11,
				arg12
			});
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x0009657C File Offset: 0x0009477C
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7,
				arg8,
				arg9,
				arg10,
				arg11,
				arg12,
				arg13
			});
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00096640 File Offset: 0x00094840
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7,
				arg8,
				arg9,
				arg10,
				arg11,
				arg12,
				arg13,
				arg14
			});
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00096710 File Offset: 0x00094910
		private TResult Invoke<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15) where TArg0 : global::System.Data.Entity.Core.Objects.ObjectContext
		{
			arg0.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResult), global::System.Reflection.Assembly.GetCallingAssembly());
			return this.ExecuteQuery<TResult>(arg0, new object[]
			{
				arg1,
				arg2,
				arg3,
				arg4,
				arg5,
				arg6,
				arg7,
				arg8,
				arg9,
				arg10,
				arg11,
				arg12,
				arg13,
				arg14,
				arg15
			});
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x000967EC File Offset: 0x000949EC
		private TResult ExecuteQuery<TResult>(global::System.Data.Entity.Core.Objects.ObjectContext context, params object[] parameterValues)
		{
			bool flag;
			global::System.Collections.IEnumerable enumerable = new global::System.Data.Entity.Core.Objects.ELinq.CompiledELinqQueryState(global::System.Data.Entity.Core.Objects.CompiledQuery.GetElementType(typeof(TResult), out flag), context, this._query, this._cacheToken, parameterValues, null).CreateQuery();
			if (flag)
			{
				return global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider.ExecuteSingle<TResult>(enumerable.Cast<TResult>(), this._query);
			}
			return (TResult)((object)enumerable);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00096840 File Offset: 0x00094A40
		private static global::System.Type GetElementType(global::System.Type resultType, out bool isSingleton)
		{
			global::System.Type elementType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(resultType);
			isSingleton = (elementType == resultType || !resultType.IsAssignableFrom(typeof(global::System.Data.Entity.Core.Objects.ObjectQuery<>).MakeGenericType(new global::System.Type[]
			{
				elementType
			})));
			if (isSingleton)
			{
				return resultType;
			}
			return elementType;
		}

		// Token: 0x0400101B RID: 4123
		private readonly global::System.Linq.Expressions.LambdaExpression _query;

		// Token: 0x0400101C RID: 4124
		private readonly global::System.Guid _cacheToken = global::System.Guid.NewGuid();
	}
}
