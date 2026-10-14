using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200051F RID: 1311
	public sealed class AssociationSetModificationFunctionMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x060040AD RID: 16557 RVA: 0x000D9474 File Offset: 0x000D7674
		public AssociationSetModificationFunctionMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping deleteFunctionMapping, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping insertFunctionMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(associationSet, "associationSet");
			this._associationSet = associationSet;
			this._deleteFunctionMapping = deleteFunctionMapping;
			this._insertFunctionMapping = insertFunctionMapping;
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060040AE RID: 16558 RVA: 0x000D949D File Offset: 0x000D769D
		public global::System.Data.Entity.Core.Metadata.Edm.AssociationSet AssociationSet
		{
			get
			{
				return this._associationSet;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060040AF RID: 16559 RVA: 0x000D94A5 File Offset: 0x000D76A5
		public global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping DeleteFunctionMapping
		{
			get
			{
				return this._deleteFunctionMapping;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x000D94AD File Offset: 0x000D76AD
		public global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping InsertFunctionMapping
		{
			get
			{
				return this._insertFunctionMapping;
			}
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x000D94B8 File Offset: 0x000D76B8
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "AS{{{0}}}:{3}DFunc={{{1}}},{3}IFunc={{{2}}}", new object[]
			{
				this.AssociationSet,
				this.DeleteFunctionMapping,
				this.InsertFunctionMapping,
				global::System.Environment.NewLine + "  "
			});
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x000D9507 File Offset: 0x000D7707
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._deleteFunctionMapping);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._insertFunctionMapping);
			base.SetReadOnly();
		}

		// Token: 0x0400167C RID: 5756
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet _associationSet;

		// Token: 0x0400167D RID: 5757
		private readonly global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping _deleteFunctionMapping;

		// Token: 0x0400167E RID: 5758
		private readonly global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping _insertFunctionMapping;
	}
}
