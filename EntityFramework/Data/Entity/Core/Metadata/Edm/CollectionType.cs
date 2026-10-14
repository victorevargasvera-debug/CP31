using System;
using System.Data.Entity.Utilities;
using System.Text;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000491 RID: 1169
	public class CollectionType : global::System.Data.Entity.Core.Metadata.Edm.EdmType
	{
		// Token: 0x060039EF RID: 14831 RVA: 0x000BDEC6 File Offset: 0x000BC0C6
		internal CollectionType()
		{
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x000BDECE File Offset: 0x000BC0CE
		internal CollectionType(global::System.Data.Entity.Core.Metadata.Edm.EdmType elementType) : this(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(elementType))
		{
			this.DataSpace = elementType.DataSpace;
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x000BDEE8 File Offset: 0x000BC0E8
		internal CollectionType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType) : base(global::System.Data.Entity.Core.Metadata.Edm.CollectionType.GetIdentity(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(elementType, "elementType")), "Transient", elementType.EdmType.DataSpace)
		{
			this._typeUsage = elementType;
			this.SetReadOnly();
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060039F2 RID: 14834 RVA: 0x000BDF1D File Offset: 0x000BC11D
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x000BDF20 File Offset: 0x000BC120
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage, false)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				return this._typeUsage;
			}
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x000BDF28 File Offset: 0x000BC128
		private static string GetIdentity(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(50);
			stringBuilder.Append("collection[");
			typeUsage.BuildIdentity(stringBuilder);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x000BDF64 File Offset: 0x000BC164
		internal override bool EdmEquals(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			if (this == item)
			{
				return true;
			}
			if (item == null || global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType != item.BuiltInTypeKind)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType = (global::System.Data.Entity.Core.Metadata.Edm.CollectionType)item;
			return this.TypeUsage.EdmEquals(collectionType.TypeUsage);
		}

		// Token: 0x04001358 RID: 4952
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _typeUsage;
	}
}
