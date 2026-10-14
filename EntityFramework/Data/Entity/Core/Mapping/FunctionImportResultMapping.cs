using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200053C RID: 1340
	public sealed class FunctionImportResultMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x000DEA05 File Offset: 0x000DCC05
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> TypeMappings
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>(this._typeMappings);
			}
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x000DEA12 File Offset: 0x000DCC12
		public void AddTypeMapping(global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping typeMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>(typeMapping, "typeMapping");
			base.ThrowIfReadOnly();
			this._typeMappings.Add(typeMapping);
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x000DEA32 File Offset: 0x000DCC32
		public void RemoveTypeMapping(global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping typeMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>(typeMapping, "typeMapping");
			base.ThrowIfReadOnly();
			this._typeMappings.Remove(typeMapping);
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x000DEA53 File Offset: 0x000DCC53
		internal override void SetReadOnly()
		{
			this._typeMappings.TrimExcess();
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._typeMappings);
			base.SetReadOnly();
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06004202 RID: 16898 RVA: 0x000DEA71 File Offset: 0x000DCC71
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> SourceList
		{
			get
			{
				return this._typeMappings;
			}
		}

		// Token: 0x040016E1 RID: 5857
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> _typeMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>();
	}
}
