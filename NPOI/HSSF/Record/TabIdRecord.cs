using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000431 RID: 1073
	public class TabIdRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002787 RID: 10119 RVA: 0x00076F8F File Offset: 0x0007518F
		public TabIdRecord()
		{
			this._tabids = global::NPOI.HSSF.Record.TabIdRecord.EMPTY_SHORT_ARRAY;
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00076FA4 File Offset: 0x000751A4
		public TabIdRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._tabids = new short[in1.Remaining / 2];
			for (int i = 0; i < this._tabids.Length; i++)
			{
				this._tabids[i] = in1.ReadShort();
			}
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00076FEB File Offset: 0x000751EB
		public void SetTabIdArray(short[] array)
		{
			this._tabids = (short[])array.Clone();
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00077000 File Offset: 0x00075200
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[TABID]\n");
			stringBuilder.Append("    .elements        = ").Append(this._tabids.Length).Append("\n");
			for (int i = 0; i < this._tabids.Length; i++)
			{
				stringBuilder.Append("    .element_" + i.ToString() + "       = ").Append(this._tabids[i]).Append("\n");
			}
			stringBuilder.Append("[/TABID]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0007709C File Offset: 0x0007529C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			short[] tabids = this._tabids;
			for (int i = 0; i < tabids.Length; i++)
			{
				out1.WriteShort((int)tabids[i]);
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x000770C7 File Offset: 0x000752C7
		protected override int DataSize
		{
			get
			{
				return this._tabids.Length * 2;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000770D3 File Offset: 0x000752D3
		public override short Sid
		{
			get
			{
				return 317;
			}
		}

		// Token: 0x040010BD RID: 4285
		public const short sid = 317;

		// Token: 0x040010BE RID: 4286
		private static short[] EMPTY_SHORT_ARRAY = new short[0];

		// Token: 0x040010BF RID: 4287
		public short[] _tabids;
	}
}
