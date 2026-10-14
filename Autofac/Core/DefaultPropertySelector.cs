using System;
using System.Reflection;

namespace Autofac.Core
{
	// Token: 0x02000059 RID: 89
	public class DefaultPropertySelector : global::Autofac.Core.IPropertySelector
	{
		// Token: 0x0600022A RID: 554 RVA: 0x0000838C File Offset: 0x0000658C
		public DefaultPropertySelector(bool preserveSetValues)
		{
			this.PreserveSetValues = preserveSetValues;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000839B File Offset: 0x0000659B
		// (set) Token: 0x0600022C RID: 556 RVA: 0x000083A3 File Offset: 0x000065A3
		public bool PreserveSetValues { get; protected set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000083AC File Offset: 0x000065AC
		internal static global::Autofac.Core.IPropertySelector OverwriteSetValueInstance { get; } = new global::Autofac.Core.DefaultPropertySelector(false);

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600022E RID: 558 RVA: 0x000083B3 File Offset: 0x000065B3
		internal static global::Autofac.Core.IPropertySelector PreserveSetValueInstance { get; } = new global::Autofac.Core.DefaultPropertySelector(true);

		// Token: 0x0600022F RID: 559 RVA: 0x000083BC File Offset: 0x000065BC
		public virtual bool InjectProperty(global::System.Reflection.PropertyInfo propertyInfo, object instance)
		{
			if (propertyInfo.CanWrite)
			{
				global::System.Reflection.MethodInfo setMethod = propertyInfo.SetMethod;
				if (setMethod != null && setMethod.IsPublic)
				{
					if (this.PreserveSetValues && propertyInfo.CanRead)
					{
						try
						{
							return propertyInfo.GetValue(instance, null) == null;
						}
						catch
						{
							return false;
						}
						return true;
					}
					return true;
				}
			}
			return false;
		}
	}
}
