using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000080 RID: 128
	internal class ProviderRowFinder
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x0000F164 File Offset: 0x0000D364
		public virtual global::System.Data.DataRow FindRow(global::System.Type hintType, global::System.Func<global::System.Data.DataRow, bool> selector, global::System.Collections.Generic.IEnumerable<global::System.Data.DataRow> dataRows)
		{
			global::System.Reflection.AssemblyName assemblyName = (hintType == null) ? null : new global::System.Reflection.AssemblyName(hintType.Assembly().FullName);
			foreach (global::System.Data.DataRow dataRow in dataRows)
			{
				string typeName = (string)dataRow[3];
				global::System.Reflection.AssemblyName rowProviderFactoryAssemblyName = null;
				global::System.Type.GetType(typeName, delegate(global::System.Reflection.AssemblyName a)
				{
					rowProviderFactoryAssemblyName = a;
					return null;
				}, (global::System.Reflection.Assembly _, string __, bool ___) => null);
				if (rowProviderFactoryAssemblyName != null && (hintType == null || string.Equals(assemblyName.Name, rowProviderFactoryAssemblyName.Name, global::System.StringComparison.OrdinalIgnoreCase)))
				{
					try
					{
						if (selector(dataRow))
						{
							return dataRow;
						}
					}
					catch (global::System.Exception)
					{
					}
				}
			}
			return null;
		}
	}
}
