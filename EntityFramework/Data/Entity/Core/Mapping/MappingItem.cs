using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000549 RID: 1353
	public abstract class MappingItem
	{
		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600424F RID: 16975 RVA: 0x000E00C5 File Offset: 0x000DE2C5
		internal bool IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x000E00CD File Offset: 0x000DE2CD
		internal global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> Annotations
		{
			get
			{
				return this._annotations;
			}
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x000E00D5 File Offset: 0x000DE2D5
		internal virtual void SetReadOnly()
		{
			this._annotations.TrimExcess();
			this._readOnly = true;
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x000E00E9 File Offset: 0x000DE2E9
		internal void ThrowIfReadOnly()
		{
			if (this.IsReadOnly)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyItem);
			}
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x000E00FE File Offset: 0x000DE2FE
		internal static void SetReadOnly(global::System.Data.Entity.Core.Mapping.MappingItem item)
		{
			if (item != null)
			{
				item.SetReadOnly();
			}
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x000E010C File Offset: 0x000DE30C
		internal static void SetReadOnly(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingItem> items)
		{
			if (items == null)
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Mapping.MappingItem readOnly in items)
			{
				global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(readOnly);
			}
		}

		// Token: 0x0400176C RID: 5996
		private bool _readOnly;

		// Token: 0x0400176D RID: 5997
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> _annotations = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty>();
	}
}
