using System;

namespace NPOI.SS.Formula
{
	// Token: 0x020000C0 RID: 192
	public class ExternalName
	{
		// Token: 0x06000676 RID: 1654 RVA: 0x0000F0A3 File Offset: 0x0000D2A3
		public ExternalName(string nameName, int nameNumber, int ix)
		{
			this._nameName = nameName;
			this._nameNumber = nameNumber;
			this._ix = ix;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		public string Name
		{
			get
			{
				return this._nameName;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
		public int Number
		{
			get
			{
				return this._nameNumber;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
		public int Ix
		{
			get
			{
				return this._ix;
			}
		}

		// Token: 0x040003A6 RID: 934
		private string _nameName;

		// Token: 0x040003A7 RID: 935
		private int _nameNumber;

		// Token: 0x040003A8 RID: 936
		private int _ix;
	}
}
