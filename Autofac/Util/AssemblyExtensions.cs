using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Autofac.Util
{
	// Token: 0x02000019 RID: 25
	public static class AssemblyExtensions
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00004550 File Offset: 0x00002750
		public static global::System.Collections.Generic.IEnumerable<global::System.Type> GetLoadableTypes(this global::System.Reflection.Assembly assembly)
		{
			if (assembly == null)
			{
				throw new global::System.ArgumentNullException("assembly");
			}
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
