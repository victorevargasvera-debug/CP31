using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000083 RID: 131
	internal class TypeFinder
	{
		// Token: 0x0600045A RID: 1114 RVA: 0x0000F29D File Offset: 0x0000D49D
		public TypeFinder(global::System.Reflection.Assembly assembly)
		{
			this._assembly = assembly;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000F2AC File Offset: 0x0000D4AC
		public global::System.Type FindType(global::System.Type baseType, string typeName, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Type>, global::System.Collections.Generic.IEnumerable<global::System.Type>> filter, global::System.Func<string, global::System.Exception> noType = null, global::System.Func<string, global::System.Collections.Generic.IEnumerable<global::System.Type>, global::System.Exception> multipleTypes = null, global::System.Func<string, string, global::System.Exception> noTypeWithName = null, global::System.Func<string, string, global::System.Exception> multipleTypesWithName = null)
		{
			bool flag = !string.IsNullOrWhiteSpace(typeName);
			global::System.Type type = null;
			if (flag)
			{
				type = this._assembly.GetType(typeName);
			}
			if (type == null)
			{
				string name = this._assembly.GetName().Name;
				global::System.Collections.Generic.IEnumerable<global::System.Type> enumerable = from t in this._assembly.GetAccessibleTypes()
				where baseType.IsAssignableFrom(t)
				select t;
				if (flag)
				{
					enumerable = (from t in enumerable
					where string.Equals(t.Name, typeName, global::System.StringComparison.OrdinalIgnoreCase)
					select t).ToList<global::System.Type>();
					if (enumerable.Count<global::System.Type>() > 1)
					{
						enumerable = (from t in enumerable
						where string.Equals(t.Name, typeName, global::System.StringComparison.Ordinal)
						select t).ToList<global::System.Type>();
					}
					if (!enumerable.Any<global::System.Type>())
					{
						if (noTypeWithName != null)
						{
							throw noTypeWithName(typeName, name);
						}
						return null;
					}
					else if (enumerable.Count<global::System.Type>() > 1)
					{
						if (multipleTypesWithName != null)
						{
							throw multipleTypesWithName(typeName, name);
						}
						return null;
					}
				}
				else
				{
					enumerable = filter(enumerable);
					if (!enumerable.Any<global::System.Type>())
					{
						if (noType != null)
						{
							throw noType(name);
						}
						return null;
					}
					else if (enumerable.Count<global::System.Type>() > 1)
					{
						if (multipleTypes != null)
						{
							throw multipleTypes(name, enumerable);
						}
						return null;
					}
				}
				type = enumerable.Single<global::System.Type>();
			}
			return type;
		}

		// Token: 0x04000113 RID: 275
		private readonly global::System.Reflection.Assembly _assembly;
	}
}
