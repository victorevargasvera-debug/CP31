using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D6 RID: 982
	public class RefSubRecord
	{
		// Token: 0x0600230A RID: 8970 RVA: 0x0006A2A4 File Offset: 0x000684A4
		public void AdjustIndex(int offset)
		{
			this._firstSheetIndex += offset;
			this._lastSheetIndex += offset;
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x0006A2C2 File Offset: 0x000684C2
		public RefSubRecord(int extBookIndex, int firstSheetIndex, int lastSheetIndex)
		{
			this._extBookIndex = extBookIndex;
			this._firstSheetIndex = firstSheetIndex;
			this._lastSheetIndex = lastSheetIndex;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0006A2DF File Offset: 0x000684DF
		public RefSubRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : this((int)in1.ReadShort(), (int)in1.ReadShort(), (int)in1.ReadShort())
		{
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x0006A2F9 File Offset: 0x000684F9
		public int ExtBookIndex
		{
			get
			{
				return this._extBookIndex;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x0006A301 File Offset: 0x00068501
		public int FirstSheetIndex
		{
			get
			{
				return this._firstSheetIndex;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x0006A309 File Offset: 0x00068509
		public int LastSheetIndex
		{
			get
			{
				return this._lastSheetIndex;
			}
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x0006A314 File Offset: 0x00068514
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("extBook=").Append(this._extBookIndex);
			stringBuilder.Append(" firstSheet=").Append(this._firstSheetIndex);
			stringBuilder.Append(" lastSheet=").Append(this._lastSheetIndex);
			return stringBuilder.ToString();
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x0006A370 File Offset: 0x00068570
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._extBookIndex);
			out1.WriteShort(this._firstSheetIndex);
			out1.WriteShort(this._lastSheetIndex);
		}

		// Token: 0x04000EC6 RID: 3782
		public const int ENCODED_SIZE = 6;

		// Token: 0x04000EC7 RID: 3783
		private int _extBookIndex;

		// Token: 0x04000EC8 RID: 3784
		private int _firstSheetIndex;

		// Token: 0x04000EC9 RID: 3785
		private int _lastSheetIndex;
	}
}
