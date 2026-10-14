using System;
using System.Reflection;
using Autofac.Util;

namespace Autofac.Core
{
	// Token: 0x02000073 RID: 115
	public class NamedPropertyParameter : global::Autofac.Core.ConstantParameter
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00008A0A File Offset: 0x00006C0A
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00008A12 File Offset: 0x00006C12
		public string Name { get; private set; }

		// Token: 0x0600029F RID: 671 RVA: 0x00008A1C File Offset: 0x00006C1C
		public NamedPropertyParameter(string name, object value) : base(value, delegate(global::System.Reflection.ParameterInfo pi)
		{
			global::System.Reflection.PropertyInfo propertyInfo;
			return pi.TryGetDeclaringProperty(out propertyInfo) && propertyInfo.Name == name;
		})
		{
			this.Name = global::Autofac.Util.Enforce.ArgumentNotNullOrEmpty(name, "name");
		}
	}
}
