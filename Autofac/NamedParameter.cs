using System;
using System.Reflection;
using Autofac.Core;
using Autofac.Util;

namespace Autofac
{
	// Token: 0x0200000E RID: 14
	public class NamedParameter : global::Autofac.Core.ConstantParameter
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002B1B File Offset: 0x00000D1B
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002B23 File Offset: 0x00000D23
		public string Name { get; private set; }

		// Token: 0x0600004F RID: 79 RVA: 0x00002B2C File Offset: 0x00000D2C
		public NamedParameter(string name, object value) : base(value, (global::System.Reflection.ParameterInfo pi) => pi.Name == name)
		{
			this.Name = global::Autofac.Util.Enforce.ArgumentNotNullOrEmpty(name, "name");
		}
	}
}
