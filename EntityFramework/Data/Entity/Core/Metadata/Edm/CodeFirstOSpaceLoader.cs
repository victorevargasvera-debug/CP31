using System;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000509 RID: 1289
	internal class CodeFirstOSpaceLoader
	{
		// Token: 0x06003FC4 RID: 16324 RVA: 0x000D36C0 File Offset: 0x000D18C0
		public CodeFirstOSpaceLoader(global::System.Data.Entity.Core.Metadata.Edm.CodeFirstOSpaceTypeFactory typeFactory = null)
		{
			this._typeFactory = (typeFactory ?? new global::System.Data.Entity.Core.Metadata.Edm.CodeFirstOSpaceTypeFactory());
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x000D36D8 File Offset: 0x000D18D8
		public void LoadTypes(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection objectItemCollection)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in from t in edmItemCollection.OfType<global::System.Data.Entity.Core.Metadata.Edm.EdmType>()
			where t.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType || t.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType || t.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType
			select t)
			{
				global::System.Type clrType = edmType.GetClrType();
				if (clrType != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = this._typeFactory.TryCreateType(clrType, edmType);
					if (edmType2 != null)
					{
						this._typeFactory.CspaceToOspace.Add(edmType, edmType2);
					}
				}
			}
			this._typeFactory.CreateRelationships(edmItemCollection);
			foreach (global::System.Action action in this._typeFactory.ReferenceResolutions)
			{
				action();
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType3 in this._typeFactory.LoadedTypes.Values)
			{
				edmType3.SetReadOnly();
			}
			objectItemCollection.AddLoadedTypes(this._typeFactory.LoadedTypes);
			objectItemCollection.OSpaceTypesLoaded = true;
		}

		// Token: 0x0400163F RID: 5695
		private readonly global::System.Data.Entity.Core.Metadata.Edm.CodeFirstOSpaceTypeFactory _typeFactory;
	}
}
