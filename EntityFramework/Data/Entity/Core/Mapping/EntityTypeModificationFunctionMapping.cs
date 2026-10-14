using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200052F RID: 1327
	public sealed class EntityTypeModificationFunctionMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x0600419E RID: 16798 RVA: 0x000DCD64 File Offset: 0x000DAF64
		public EntityTypeModificationFunctionMapping(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping deleteFunctionMapping, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping insertFunctionMapping, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping updateFunctionMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityType, "entityType");
			this._entityType = entityType;
			this._deleteFunctionMapping = deleteFunctionMapping;
			this._insertFunctionMapping = insertFunctionMapping;
			this._updateFunctionMapping = updateFunctionMapping;
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x0600419F RID: 16799 RVA: 0x000DCD95 File Offset: 0x000DAF95
		public global::System.Data.Entity.Core.Metadata.Edm.EntityType EntityType
		{
			get
			{
				return this._entityType;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060041A0 RID: 16800 RVA: 0x000DCD9D File Offset: 0x000DAF9D
		public global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping DeleteFunctionMapping
		{
			get
			{
				return this._deleteFunctionMapping;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x000DCDA5 File Offset: 0x000DAFA5
		public global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping InsertFunctionMapping
		{
			get
			{
				return this._insertFunctionMapping;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060041A2 RID: 16802 RVA: 0x000DCDAD File Offset: 0x000DAFAD
		public global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping UpdateFunctionMapping
		{
			get
			{
				return this._updateFunctionMapping;
			}
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x000DCDB8 File Offset: 0x000DAFB8
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "ET{{{0}}}:{4}DFunc={{{1}}},{4}IFunc={{{2}}},{4}UFunc={{{3}}}", new object[]
			{
				this.EntityType,
				this.DeleteFunctionMapping,
				this.InsertFunctionMapping,
				this.UpdateFunctionMapping,
				global::System.Environment.NewLine + "  "
			});
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x000DCE10 File Offset: 0x000DB010
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._deleteFunctionMapping);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._insertFunctionMapping);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._updateFunctionMapping);
			base.SetReadOnly();
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x000DCE3C File Offset: 0x000DB03C
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> PrimaryParameterBindings
		{
			get
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> enumerable = global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
				if (this.DeleteFunctionMapping != null)
				{
					enumerable = enumerable.Concat(this.DeleteFunctionMapping.ParameterBindings);
				}
				if (this.InsertFunctionMapping != null)
				{
					enumerable = enumerable.Concat(this.InsertFunctionMapping.ParameterBindings);
				}
				if (this.UpdateFunctionMapping != null)
				{
					enumerable = enumerable.Concat(from pb in this.UpdateFunctionMapping.ParameterBindings
					where pb.IsCurrent
					select pb);
				}
				return enumerable;
			}
		}

		// Token: 0x040016BC RID: 5820
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityType _entityType;

		// Token: 0x040016BD RID: 5821
		private readonly global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping _deleteFunctionMapping;

		// Token: 0x040016BE RID: 5822
		private readonly global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping _insertFunctionMapping;

		// Token: 0x040016BF RID: 5823
		private readonly global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping _updateFunctionMapping;
	}
}
