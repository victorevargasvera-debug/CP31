using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D0 RID: 1232
	internal abstract class MetadataArtifactAssemblyResolver
	{
		// Token: 0x06003D22 RID: 15650
		internal abstract bool TryResolveAssemblyReference(global::System.Reflection.AssemblyName referenceName, out global::System.Reflection.Assembly assembly);

		// Token: 0x06003D23 RID: 15651
		internal abstract global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetWildcardAssemblies();
	}
}
