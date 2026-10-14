using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200055A RID: 1370
	public abstract class PropertyMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x06004303 RID: 17155 RVA: 0x000E5645 File Offset: 0x000E3845
		internal PropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			this._property = property;
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x000E5654 File Offset: 0x000E3854
		internal PropertyMapping()
		{
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x000E565C File Offset: 0x000E385C
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x000E5664 File Offset: 0x000E3864
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EdmProperty Property
		{
			get
			{
				return this._property;
			}
			internal set
			{
				this._property = value;
			}
		}

		// Token: 0x040017EF RID: 6127
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _property;
	}
}
