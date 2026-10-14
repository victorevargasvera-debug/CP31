using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer.Resources;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000018 RID: 24
	internal class SqlTypesAssemblyLoader
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000E599 File Offset: 0x0000C799
		public static global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader DefaultInstance
		{
			get
			{
				return global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader._instance;
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		public SqlTypesAssemblyLoader(global::System.Collections.Generic.IEnumerable<string> assemblyNames = null)
		{
			if (assemblyNames != null)
			{
				this._preferredSqlTypesAssemblies = assemblyNames;
			}
			else
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>
				{
					global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.GenerateSqlServerTypesAssemblyName(11),
					global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.GenerateSqlServerTypesAssemblyName(10)
				};
				for (int i = 20; i > 11; i--)
				{
					list.Add(global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.GenerateSqlServerTypesAssemblyName(i));
				}
				this._preferredSqlTypesAssemblies = list.ToList<string>();
			}
			this._latestVersion = new global::System.Lazy<global::System.Data.Entity.SqlServer.SqlTypesAssembly>(new global::System.Func<global::System.Data.Entity.SqlServer.SqlTypesAssembly>(this.BindToLatest), true);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000E61D File Offset: 0x0000C81D
		private static string GenerateSqlServerTypesAssemblyName(int version)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Microsoft.SqlServer.Types, Version={0}.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91", new object[]
			{
				version
			});
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000E640 File Offset: 0x0000C840
		public SqlTypesAssemblyLoader(global::System.Data.Entity.SqlServer.SqlTypesAssembly assembly)
		{
			this._latestVersion = new global::System.Lazy<global::System.Data.Entity.SqlServer.SqlTypesAssembly>(() => assembly, true);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000E678 File Offset: 0x0000C878
		public virtual global::System.Data.Entity.SqlServer.SqlTypesAssembly TryGetSqlTypesAssembly()
		{
			return this._latestVersion.Value;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000E685 File Offset: 0x0000C885
		public virtual global::System.Data.Entity.SqlServer.SqlTypesAssembly GetSqlTypesAssembly()
		{
			global::System.Data.Entity.SqlServer.SqlTypesAssembly value = this._latestVersion.Value;
			if (value == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_SqlTypesAssemblyNotFound);
			}
			return value;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public virtual bool TryGetSqlTypesAssembly(global::System.Reflection.Assembly assembly, out global::System.Data.Entity.SqlServer.SqlTypesAssembly sqlAssembly)
		{
			if (this.IsKnownAssembly(assembly))
			{
				sqlAssembly = new global::System.Data.Entity.SqlServer.SqlTypesAssembly(assembly);
				return true;
			}
			sqlAssembly = null;
			return false;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000E6BC File Offset: 0x0000C8BC
		private global::System.Data.Entity.SqlServer.SqlTypesAssembly BindToLatest()
		{
			global::System.Reflection.Assembly assembly = null;
			global::System.Collections.Generic.IEnumerable<string> enumerable;
			if (global::System.Data.Entity.SqlServer.SqlProviderServices.SqlServerTypesAssemblyName == null)
			{
				enumerable = this._preferredSqlTypesAssemblies;
			}
			else
			{
				global::System.Collections.Generic.IEnumerable<string> enumerable2 = new string[]
				{
					global::System.Data.Entity.SqlServer.SqlProviderServices.SqlServerTypesAssemblyName
				};
				enumerable = enumerable2;
			}
			foreach (string assemblyName in enumerable)
			{
				global::System.Reflection.AssemblyName assemblyRef = new global::System.Reflection.AssemblyName(assemblyName);
				try
				{
					assembly = global::System.Reflection.Assembly.Load(assemblyRef);
					break;
				}
				catch (global::System.IO.FileNotFoundException)
				{
				}
				catch (global::System.IO.FileLoadException)
				{
				}
			}
			if (assembly != null)
			{
				return new global::System.Data.Entity.SqlServer.SqlTypesAssembly(assembly);
			}
			return null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000E75C File Offset: 0x0000C95C
		private bool IsKnownAssembly(global::System.Reflection.Assembly assembly)
		{
			foreach (string assemblyName in this._preferredSqlTypesAssemblies)
			{
				if (global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.AssemblyNamesMatch(assembly.FullName, new global::System.Reflection.AssemblyName(assemblyName)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		private static bool AssemblyNamesMatch(string infoRowProviderAssemblyName, global::System.Reflection.AssemblyName targetAssemblyName)
		{
			if (string.IsNullOrWhiteSpace(infoRowProviderAssemblyName))
			{
				return false;
			}
			global::System.Reflection.AssemblyName assemblyName;
			try
			{
				assemblyName = new global::System.Reflection.AssemblyName(infoRowProviderAssemblyName);
			}
			catch (global::System.Exception)
			{
				return false;
			}
			if (!string.Equals(targetAssemblyName.Name, assemblyName.Name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			if (targetAssemblyName.Version == null || assemblyName.Version == null)
			{
				return false;
			}
			if (targetAssemblyName.Version.Major != assemblyName.Version.Major || targetAssemblyName.Version.Minor != assemblyName.Version.Minor)
			{
				return false;
			}
			byte[] publicKeyToken = targetAssemblyName.GetPublicKeyToken();
			return publicKeyToken != null && publicKeyToken.SequenceEqual(assemblyName.GetPublicKeyToken());
		}

		// Token: 0x040000C3 RID: 195
		private const string AssemblyNameTemplate = "Microsoft.SqlServer.Types, Version={0}.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91";

		// Token: 0x040000C4 RID: 196
		private static readonly global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader _instance = new global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader(null);

		// Token: 0x040000C5 RID: 197
		private readonly global::System.Collections.Generic.IEnumerable<string> _preferredSqlTypesAssemblies;

		// Token: 0x040000C6 RID: 198
		private readonly global::System.Lazy<global::System.Data.Entity.SqlServer.SqlTypesAssembly> _latestVersion;
	}
}
