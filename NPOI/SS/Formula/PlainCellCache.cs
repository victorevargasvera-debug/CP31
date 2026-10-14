using System;
using System.Collections;

namespace NPOI.SS.Formula
{
	// Token: 0x020000DA RID: 218
	public class PlainCellCache
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x000135F4 File Offset: 0x000117F4
		public PlainCellCache()
		{
			this._plainValueEntriesByLoc = new global::System.Collections.Hashtable();
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00013607 File Offset: 0x00011807
		public void Put(global::NPOI.SS.Formula.Loc key, global::NPOI.SS.Formula.PlainValueCellCacheEntry cce)
		{
			this._plainValueEntriesByLoc[key] = cce;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00013616 File Offset: 0x00011816
		public void Clear()
		{
			this._plainValueEntriesByLoc.Clear();
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00013623 File Offset: 0x00011823
		public global::NPOI.SS.Formula.PlainValueCellCacheEntry Get(global::NPOI.SS.Formula.Loc key)
		{
			return (global::NPOI.SS.Formula.PlainValueCellCacheEntry)this._plainValueEntriesByLoc[key];
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00013636 File Offset: 0x00011836
		public void Remove(global::NPOI.SS.Formula.Loc key)
		{
			this._plainValueEntriesByLoc.Remove(key);
		}

		// Token: 0x040003E3 RID: 995
		private global::System.Collections.Hashtable _plainValueEntriesByLoc;
	}
}
