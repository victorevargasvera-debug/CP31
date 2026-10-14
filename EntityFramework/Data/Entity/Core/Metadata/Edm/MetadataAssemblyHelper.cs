using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.SchemaObjectModel;
using System.IO;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000510 RID: 1296
	internal static class MetadataAssemblyHelper
	{
		// Token: 0x06003FEA RID: 16362 RVA: 0x000D3B7C File Offset: 0x000D1D7C
		internal static global::System.Reflection.Assembly SafeLoadReferencedAssembly(global::System.Reflection.AssemblyName assemblyName)
		{
			global::System.Reflection.Assembly result = null;
			try
			{
				result = global::System.Reflection.Assembly.Load(assemblyName);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			catch (global::System.IO.FileLoadException)
			{
			}
			return result;
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x000D3BB8 File Offset: 0x000D1DB8
		private static bool ComputeShouldFilterAssembly(global::System.Reflection.Assembly assembly)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ShouldFilterAssembly(new global::System.Reflection.AssemblyName(assembly.FullName));
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x000D3BCA File Offset: 0x000D1DCA
		internal static bool ShouldFilterAssembly(global::System.Reflection.Assembly assembly)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper._filterAssemblyCacheByAssembly.Evaluate(assembly);
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x000D3BD7 File Offset: 0x000D1DD7
		private static bool ShouldFilterAssembly(global::System.Reflection.AssemblyName assemblyName)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ArePublicKeyTokensEqual(assemblyName.GetPublicKeyToken(), global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper._ecmaPublicKeyToken) || global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ArePublicKeyTokensEqual(assemblyName.GetPublicKeyToken(), global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper._msPublicKeyToken);
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x000D3C00 File Offset: 0x000D1E00
		private static bool ArePublicKeyTokensEqual(byte[] left, byte[] right)
		{
			if (left.Length != right.Length)
			{
				return false;
			}
			for (int i = 0; i < left.Length; i++)
			{
				if (left[i] != right[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x000D3C30 File Offset: 0x000D1E30
		internal static global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetNonSystemReferencedAssemblies(global::System.Reflection.Assembly assembly)
		{
			foreach (global::System.Reflection.AssemblyName assemblyName in assembly.GetReferencedAssemblies())
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ShouldFilterAssembly(assemblyName))
				{
					global::System.Reflection.Assembly assembly2 = global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.SafeLoadReferencedAssembly(assemblyName);
					if (assembly2 != null)
					{
						yield return assembly2;
					}
				}
			}
			global::System.Reflection.AssemblyName[] array = null;
			yield break;
		}

		// Token: 0x0400164D RID: 5709
		private const string EcmaPublicKey = "b77a5c561934e089";

		// Token: 0x0400164E RID: 5710
		private const string MicrosoftPublicKey = "b03f5f7f11d50a3a";

		// Token: 0x0400164F RID: 5711
		private static readonly byte[] _ecmaPublicKeyToken = global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.ConvertToByteArray("b77a5c561934e089");

		// Token: 0x04001650 RID: 5712
		private static readonly byte[] _msPublicKeyToken = global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.ConvertToByteArray("b03f5f7f11d50a3a");

		// Token: 0x04001651 RID: 5713
		private static readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Reflection.Assembly, bool> _filterAssemblyCacheByAssembly = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Reflection.Assembly, bool>(new global::System.Func<global::System.Reflection.Assembly, bool>(global::System.Data.Entity.Core.Metadata.Edm.MetadataAssemblyHelper.ComputeShouldFilterAssembly), global::System.Collections.Generic.EqualityComparer<global::System.Reflection.Assembly>.Default);
	}
}
