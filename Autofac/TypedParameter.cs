using System;
using System.Reflection;
using Autofac.Core;

namespace Autofac
{
	// Token: 0x02000016 RID: 22
	public class TypedParameter : global::Autofac.Core.ConstantParameter
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004300 File Offset: 0x00002500
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00004308 File Offset: 0x00002508
		public global::System.Type Type { get; private set; }

		// Token: 0x060000E3 RID: 227 RVA: 0x00004314 File Offset: 0x00002514
		public TypedParameter(global::System.Type type, object value) : base(value, (global::System.Reflection.ParameterInfo pi) => pi.ParameterType == type)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			this.Type = type;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004366 File Offset: 0x00002566
		public static global::Autofac.TypedParameter From<T>(T value)
		{
			return new global::Autofac.TypedParameter(typeof(T), value);
		}
	}
}
