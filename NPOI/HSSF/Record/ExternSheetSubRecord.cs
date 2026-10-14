using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D8 RID: 984
	public class ExternSheetSubRecord : global::NPOI.HSSF.Record.Record
	{
		// Token: 0x06002324 RID: 8996 RVA: 0x0004D7E9 File Offset: 0x0004B9E9
		public ExternSheetSubRecord()
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0006A6BE File Offset: 0x000688BE
		public ExternSheetSubRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_index_to_supbook = in1.ReadShort();
			this.field_2_index_to_first_supbook_sheet = in1.ReadShort();
			this.field_3_index_to_last_supbook_sheet = in1.ReadShort();
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x0006A6EA File Offset: 0x000688EA
		public void SetIndexToSupBook(short index)
		{
			this.field_1_index_to_supbook = index;
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0006A6F3 File Offset: 0x000688F3
		public short GetIndexToSupBook()
		{
			return this.field_1_index_to_supbook;
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x0006A6FB File Offset: 0x000688FB
		public void SetIndexToFirstSupBook(short index)
		{
			this.field_2_index_to_first_supbook_sheet = index;
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x0006A704 File Offset: 0x00068904
		public short GetIndexToFirstSupBook()
		{
			return this.field_2_index_to_first_supbook_sheet;
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0006A70C File Offset: 0x0006890C
		public void SetIndexToLastSupBook(short index)
		{
			this.field_3_index_to_last_supbook_sheet = index;
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x0006A715 File Offset: 0x00068915
		public short GetIndexToLastSupBook()
		{
			return this.field_3_index_to_last_supbook_sheet;
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x0006A720 File Offset: 0x00068920
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("   supbookindex =").Append(this.GetIndexToSupBook()).Append('\n');
			stringBuilder.Append("   1stsbindex   =").Append(this.GetIndexToFirstSupBook()).Append('\n');
			stringBuilder.Append("   lastsbindex  =").Append(this.GetIndexToLastSupBook()).Append('\n');
			return stringBuilder.ToString();
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0006A791 File Offset: 0x00068991
		public override int Serialize(int offset, byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.GetIndexToSupBook());
			global::NPOI.Util.LittleEndian.PutShort(data, 2 + offset, this.GetIndexToFirstSupBook());
			global::NPOI.Util.LittleEndian.PutShort(data, 4 + offset, this.GetIndexToLastSupBook());
			return this.RecordSize;
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x00017F5F File Offset: 0x0001615F
		public override int RecordSize
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x0006A7C4 File Offset: 0x000689C4
		public override short Sid
		{
			get
			{
				return 4095;
			}
		}

		// Token: 0x04000ECC RID: 3788
		public const short sid = 4095;

		// Token: 0x04000ECD RID: 3789
		private short field_1_index_to_supbook;

		// Token: 0x04000ECE RID: 3790
		private short field_2_index_to_first_supbook_sheet;

		// Token: 0x04000ECF RID: 3791
		private short field_3_index_to_last_supbook_sheet;
	}
}
