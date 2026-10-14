using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000087 RID: 135
	internal static class AssemblyExtensions
	{
		// Token: 0x06000462 RID: 1122 RVA: 0x0000F564 File Offset: 0x0000D764
		public static string GetInformationalVersion(this global::System.Reflection.Assembly assembly)
		{
			return assembly.GetCustomAttributes<global::System.Reflection.AssemblyInformationalVersionAttribute>().Single<global::System.Reflection.AssemblyInformationalVersionAttribute>().InformationalVersion;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000F578 File Offset: 0x0000D778
		public static global::System.Collections.Generic.IEnumerable<global::System.Type> GetAccessibleTypes(this global::System.Reflection.Assembly assembly)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Type> result;
			try
			{
				result = from t in assembly.DefinedTypes
				select t.AsType();
			}
			catch (global::System.Reflection.ReflectionTypeLoadException ex)
			{
				result = from t in ex.Types
				where t != null
				select t;
			}
			return result;
		}
	}
}
