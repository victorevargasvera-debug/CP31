using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000497 RID: 1175
	internal class CustomAssemblyResolver : global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactAssemblyResolver
	{
		// Token: 0x06003A23 RID: 14883 RVA: 0x000BF9C3 File Offset: 0x000BDBC3
		internal CustomAssemblyResolver(global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly>> wildcardAssemblyEnumerator, global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly> referenceResolver)
		{
			this._wildcardAssemblyEnumerator = wildcardAssemblyEnumerator;
			this._referenceResolver = referenceResolver;
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x000BF9D9 File Offset: 0x000BDBD9
		internal override bool TryResolveAssemblyReference(global::System.Reflection.AssemblyName referenceName, out global::System.Reflection.Assembly assembly)
		{
			assembly = this._referenceResolver(referenceName);
			return assembly != null;
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x000BF9F1 File Offset: 0x000BDBF1
		internal override global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetWildcardAssemblies()
		{
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> enumerable = this._wildcardAssemblyEnumerator();
			if (enumerable == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.WildcardEnumeratorReturnedNull);
			}
			return enumerable;
		}

		// Token: 0x04001363 RID: 4963
		private readonly global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly> _referenceResolver;

		// Token: 0x04001364 RID: 4964
		private readonly global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly>> _wildcardAssemblyEnumerator;
	}
}
