using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C9 RID: 1225
	public abstract class GlobalItem : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003CA8 RID: 15528 RVA: 0x000C83DF File Offset: 0x000C65DF
		internal GlobalItem()
		{
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x000C83E7 File Offset: 0x000C65E7
		internal GlobalItem(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags flags) : base(flags)
		{
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06003CAA RID: 15530 RVA: 0x000C83F0 File Offset: 0x000C65F0
		// (set) Token: 0x06003CAB RID: 15531 RVA: 0x000C83F8 File Offset: 0x000C65F8
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(typeof(global::System.Data.Entity.Core.Metadata.Edm.DataSpace), false)]
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.DataSpace DataSpace
		{
			get
			{
				return base.GetDataSpace();
			}
			set
			{
				base.SetDataSpace(value);
			}
		}
	}
}
