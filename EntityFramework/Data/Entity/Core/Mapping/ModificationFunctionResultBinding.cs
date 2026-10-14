using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000551 RID: 1361
	public sealed class ModificationFunctionResultBinding : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x060042E4 RID: 17124 RVA: 0x000E5382 File Offset: 0x000E3582
		public ModificationFunctionResultBinding(string columnName, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(columnName, "columnName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(property, "property");
			this._columnName = columnName;
			this._property = property;
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x000E53B0 File Offset: 0x000E35B0
		// (set) Token: 0x060042E6 RID: 17126 RVA: 0x000E53B8 File Offset: 0x000E35B8
		public string ColumnName
		{
			get
			{
				return this._columnName;
			}
			internal set
			{
				this._columnName = value;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x000E53C1 File Offset: 0x000E35C1
		public global::System.Data.Entity.Core.Metadata.Edm.EdmProperty Property
		{
			get
			{
				return this._property;
			}
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x000E53C9 File Offset: 0x000E35C9
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}->{1}", new object[]
			{
				this.ColumnName,
				this.Property
			});
		}

		// Token: 0x0400178C RID: 6028
		private string _columnName;

		// Token: 0x0400178D RID: 6029
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _property;
	}
}
