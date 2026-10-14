using System;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004E0 RID: 1248
	internal sealed class MetadataPropertyValue
	{
		// Token: 0x06003E13 RID: 15891 RVA: 0x000CD237 File Offset: 0x000CB437
		internal MetadataPropertyValue(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			this._propertyInfo = propertyInfo;
			this._item = item;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x000CD24D File Offset: 0x000CB44D
		internal object GetValue()
		{
			return this._propertyInfo.GetValue(this._item, new object[0]);
		}

		// Token: 0x04001521 RID: 5409
		private readonly global::System.Reflection.PropertyInfo _propertyInfo;

		// Token: 0x04001522 RID: 5410
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataItem _item;
	}
}
