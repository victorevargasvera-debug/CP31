using System;
using System.Data.Entity.Core.Common.Utils;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x02000579 RID: 1401
	internal abstract class CellRelation : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004404 RID: 17412 RVA: 0x000ECA9C File Offset: 0x000EAC9C
		protected CellRelation(int cellNumber)
		{
			this.m_cellNumber = cellNumber;
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x000ECAAB File Offset: 0x000EACAB
		internal int CellNumber
		{
			get
			{
				return this.m_cellNumber;
			}
		}

		// Token: 0x06004406 RID: 17414
		protected abstract int GetHash();

		// Token: 0x0400188C RID: 6284
		internal int m_cellNumber;
	}
}
