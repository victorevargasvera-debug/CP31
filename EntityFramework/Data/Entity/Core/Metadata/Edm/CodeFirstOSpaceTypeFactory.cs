using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200050A RID: 1290
	internal class CodeFirstOSpaceTypeFactory : global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory
	{
		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x000D3828 File Offset: 0x000D1A28
		public override global::System.Collections.Generic.List<global::System.Action> ReferenceResolutions
		{
			get
			{
				return this._referenceResolutions;
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x000D3830 File Offset: 0x000D1A30
		public override void LogLoadMessage(string message, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType)
		{
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x000D3832 File Offset: 0x000D1A32
		public override void LogError(string errorMessage, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType)
		{
			throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.InvalidSchemaEncountered(errorMessage));
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x000D383F File Offset: 0x000D1A3F
		public override void TrackClosure(global::System.Type type)
		{
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x000D3841 File Offset: 0x000D1A41
		public override global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType> CspaceToOspace
		{
			get
			{
				return this._cspaceToOspace;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x000D3849 File Offset: 0x000D1A49
		public override global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> LoadedTypes
		{
			get
			{
				return this._loadedTypes;
			}
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x000D3851 File Offset: 0x000D1A51
		public override void AddToTypesInAssembly(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
		}

		// Token: 0x04001640 RID: 5696
		private readonly global::System.Collections.Generic.List<global::System.Action> _referenceResolutions = new global::System.Collections.Generic.List<global::System.Action>();

		// Token: 0x04001641 RID: 5697
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType> _cspaceToOspace = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType>();

		// Token: 0x04001642 RID: 5698
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> _loadedTypes = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
	}
}
