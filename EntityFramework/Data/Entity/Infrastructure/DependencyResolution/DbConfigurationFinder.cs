using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002AC RID: 684
	internal class DbConfigurationFinder
	{
		// Token: 0x060021A4 RID: 8612 RVA: 0x0005D6C2 File Offset: 0x0005B8C2
		public virtual global::System.Type TryFindConfigurationType(global::System.Type contextType, global::System.Collections.Generic.IEnumerable<global::System.Type> typesToSearch = null)
		{
			return this.TryFindConfigurationType(contextType.Assembly(), contextType, typesToSearch);
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0005D6D4 File Offset: 0x0005B8D4
		public virtual global::System.Type TryFindConfigurationType(global::System.Reflection.Assembly assemblyHint, global::System.Type contextTypeHint, global::System.Collections.Generic.IEnumerable<global::System.Type> typesToSearch = null)
		{
			if (contextTypeHint != null)
			{
				global::System.Type type = (from a in contextTypeHint.GetCustomAttributes(true)
				select a.ConfigurationType).FirstOrDefault<global::System.Type>();
				if (type != null)
				{
					if (!typeof(global::System.Data.Entity.DbConfiguration).IsAssignableFrom(type))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CreateInstance_BadDbConfigurationType(type.ToString(), typeof(global::System.Data.Entity.DbConfiguration).ToString()));
					}
					return type;
				}
			}
			global::System.Collections.Generic.List<global::System.Type> list = (from t in typesToSearch ?? assemblyHint.GetAccessibleTypes()
			where t.IsSubclassOf(typeof(global::System.Data.Entity.DbConfiguration)) && !t.IsAbstract() && !t.IsGenericType()
			select t).ToList<global::System.Type>();
			if (list.Count > 1)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MultipleConfigsInAssembly(list.First<global::System.Type>().Assembly(), typeof(global::System.Data.Entity.DbConfiguration).Name));
			}
			return list.FirstOrDefault<global::System.Type>();
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0005D7C4 File Offset: 0x0005B9C4
		public virtual global::System.Type TryFindContextType(global::System.Reflection.Assembly assemblyHint, global::System.Type contextTypeHint, global::System.Collections.Generic.IEnumerable<global::System.Type> typesToSearch = null)
		{
			if (contextTypeHint != null)
			{
				return contextTypeHint;
			}
			global::System.Collections.Generic.List<global::System.Type> list = (from t in typesToSearch ?? assemblyHint.GetAccessibleTypes()
			where t.IsSubclassOf(typeof(global::System.Data.Entity.DbContext)) && !t.IsAbstract() && !t.IsGenericType() && t.GetCustomAttributes(true).Any<global::System.Data.Entity.DbConfigurationTypeAttribute>()
			select t).ToList<global::System.Type>();
			if (list.Count != 1)
			{
				return null;
			}
			return list[0];
		}
	}
}
