using System;
using System.Data.Entity.Utilities;
using System.Text;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F1 RID: 1265
	public class RefType : global::System.Data.Entity.Core.Metadata.Edm.EdmType
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x000D08C3 File Offset: 0x000CEAC3
		internal RefType()
		{
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x000D08CB File Offset: 0x000CEACB
		internal RefType(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType) : base(global::System.Data.Entity.Core.Metadata.Edm.RefType.GetIdentity(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityType, "entityType")), "Transient", entityType.DataSpace)
		{
			this._elementType = entityType;
			this.SetReadOnly();
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x000D08FB File Offset: 0x000CEAFB
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06003EF9 RID: 16121 RVA: 0x000D08FF File Offset: 0x000CEAFF
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityTypeBase, false)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase ElementType
		{
			get
			{
				return this._elementType;
			}
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x000D0908 File Offset: 0x000CEB08
		private static string GetIdentity(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(50);
			stringBuilder.Append("reference[");
			entityTypeBase.BuildIdentity(stringBuilder);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x000D0942 File Offset: 0x000CEB42
		public override int GetHashCode()
		{
			return this._elementType.GetHashCode() * 397 ^ typeof(global::System.Data.Entity.Core.Metadata.Edm.RefType).GetHashCode();
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x000D0968 File Offset: 0x000CEB68
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType = obj as global::System.Data.Entity.Core.Metadata.Edm.RefType;
			return refType != null && refType._elementType == this._elementType;
		}

		// Token: 0x0400157B RID: 5499
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase _elementType;
	}
}
