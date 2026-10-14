using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200055B RID: 1371
	public class ScalarPropertyMapping : global::System.Data.Entity.Core.Mapping.PropertyMapping
	{
		// Token: 0x06004307 RID: 17159 RVA: 0x000E5670 File Offset: 0x000E3870
		public ScalarPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column) : base(property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(property, "property");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(column, "column");
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(property.TypeUsage.EdmType) || !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(column.TypeUsage.EdmType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.StorageScalarPropertyMapping_OnlyScalarPropertiesAllowed);
			}
			this._column = column;
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x000E56D2 File Offset: 0x000E38D2
		// (set) Token: 0x06004309 RID: 17161 RVA: 0x000E56DA File Offset: 0x000E38DA
		public global::System.Data.Entity.Core.Metadata.Edm.EdmProperty Column
		{
			get
			{
				return this._column;
			}
			internal set
			{
				this._column = value;
			}
		}

		// Token: 0x040017F0 RID: 6128
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _column;
	}
}
