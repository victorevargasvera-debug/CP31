using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004DE RID: 1246
	[global::System.AttributeUsage(global::System.AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	internal sealed class MetadataPropertyAttribute : global::System.Attribute
	{
		// Token: 0x06003E09 RID: 15881 RVA: 0x000CD17F File Offset: 0x000CB37F
		internal MetadataPropertyAttribute(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind, bool isCollectionType) : this(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(builtInTypeKind), isCollectionType)
		{
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x000CD18E File Offset: 0x000CB38E
		internal MetadataPropertyAttribute(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind, bool isCollectionType) : this(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(primitiveTypeKind), isCollectionType)
		{
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x000CD1A2 File Offset: 0x000CB3A2
		internal MetadataPropertyAttribute(global::System.Type type, bool isCollection) : this(global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType.CreateReadonlyClrComplexType(type, type.NestingNamespace() ?? string.Empty, type.Name), isCollection)
		{
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x000CD1C6 File Offset: 0x000CB3C6
		private MetadataPropertyAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, bool isCollectionType)
		{
			this._type = type;
			this._isCollectionType = isCollectionType;
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06003E0D RID: 15885 RVA: 0x000CD1DC File Offset: 0x000CB3DC
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x000CD1E4 File Offset: 0x000CB3E4
		internal bool IsCollectionType
		{
			get
			{
				return this._isCollectionType;
			}
		}

		// Token: 0x0400151E RID: 5406
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType _type;

		// Token: 0x0400151F RID: 5407
		private readonly bool _isCollectionType;
	}
}
