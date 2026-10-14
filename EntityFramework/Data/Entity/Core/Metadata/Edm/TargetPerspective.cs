using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004FF RID: 1279
	internal class TargetPerspective : global::System.Data.Entity.Core.Metadata.Edm.Perspective
	{
		// Token: 0x06003F47 RID: 16199 RVA: 0x000D1A64 File Offset: 0x000CFC64
		internal TargetPerspective(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace) : base(metadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
		{
			this._modelPerspective = new global::System.Data.Entity.Core.Metadata.Edm.ModelPerspective(metadataWorkspace);
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x000D1A7C File Offset: 0x000CFC7C
		internal override bool TryGetTypeByName(string fullName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage usage)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(fullName, "fullName");
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = null;
			if (base.MetadataWorkspace.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(fullName, ignoreCase, base.TargetDataspace, out edmType))
			{
				usage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType);
				usage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(usage);
				return true;
			}
			return this._modelPerspective.TryGetTypeByName(fullName, ignoreCase, out usage);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x000D1ACF File Offset: 0x000CFCCF
		internal override bool TryGetEntityContainer(string name, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer)
		{
			return base.TryGetEntityContainer(name, ignoreCase, out entityContainer) || this._modelPerspective.TryGetEntityContainer(name, ignoreCase, out entityContainer);
		}

		// Token: 0x04001595 RID: 5525
		internal const global::System.Data.Entity.Core.Metadata.Edm.DataSpace TargetPerspectiveDataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace;

		// Token: 0x04001596 RID: 5526
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ModelPerspective _modelPerspective;
	}
}
