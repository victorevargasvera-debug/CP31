using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Core;
using Autofac.Util;

namespace Autofac
{
	// Token: 0x0200000F RID: 15
	public static class ParameterExtensions
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002B70 File Offset: 0x00000D70
		public static T Named<T>(this global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, string name)
		{
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			global::Autofac.Util.Enforce.ArgumentNotNullOrEmpty(name, "name");
			return global::Autofac.ParameterExtensions.ConstantValue<global::Autofac.NamedParameter, T>(parameters, (global::Autofac.NamedParameter c) => c.Name == name);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002BBC File Offset: 0x00000DBC
		public static T Positional<T>(this global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, int position)
		{
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			if (position < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("position");
			}
			return global::Autofac.ParameterExtensions.ConstantValue<global::Autofac.PositionalParameter, T>(parameters, (global::Autofac.PositionalParameter c) => c.Position == position);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002C0A File Offset: 0x00000E0A
		public static T TypedAs<T>(this global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			return global::Autofac.ParameterExtensions.ConstantValue<global::Autofac.TypedParameter, T>(parameters, (global::Autofac.TypedParameter c) => c.Type == typeof(T));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002C40 File Offset: 0x00000E40
		private static TValue ConstantValue<TParameter, TValue>(global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, global::System.Func<TParameter, bool> predicate) where TParameter : global::Autofac.Core.ConstantParameter
		{
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			if (predicate == null)
			{
				throw new global::System.ArgumentNullException("predicate");
			}
			return (from p in parameters.OfType<TParameter>().Where(predicate)
			select p.Value).Cast<TValue>().First<TValue>();
		}
	}
}
