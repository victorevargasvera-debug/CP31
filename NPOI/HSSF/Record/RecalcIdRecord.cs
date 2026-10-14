using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200040C RID: 1036
	public class RecalcIdRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060025CB RID: 9675 RVA: 0x000713D5 File Offset: 0x0006F5D5
		public RecalcIdRecord()
		{
			this._reserved0 = 0;
			this._engineId = 0;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x000713EB File Offset: 0x0006F5EB
		public RecalcIdRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			in1.ReadUShort();
			this._reserved0 = in1.ReadUShort();
			this._engineId = in1.ReadInt();
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x00008875 File Offset: 0x00006A75
		public bool IsNeeded
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00071414 File Offset: 0x0006F614
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[RECALCID]\n");
			stringBuilder.Append("    .reserved = ").Append(global::NPOI.Util.HexDump.ShortToHex(this._reserved0)).Append("\n");
			stringBuilder.Append("    .engineId = ").Append(global::NPOI.Util.HexDump.IntToHex(this._engineId)).Append("\n");
			stringBuilder.Append("[/RECALCID]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x0007148F File Offset: 0x0006F68F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(449);
			out1.WriteShort(this._reserved0);
			out1.WriteInt(this._engineId);
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x000714BD File Offset: 0x0006F6BD
		// (set) Token: 0x060025D0 RID: 9680 RVA: 0x000714B4 File Offset: 0x0006F6B4
		public int EngineId
		{
			get
			{
				return this._engineId;
			}
			set
			{
				this._engineId = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x000714C5 File Offset: 0x0006F6C5
		public override short Sid
		{
			get
			{
				return 449;
			}
		}

		// Token: 0x04000FDD RID: 4061
		public const short sid = 449;

		// Token: 0x04000FDE RID: 4062
		private int _reserved0;

		// Token: 0x04000FDF RID: 4063
		private int _engineId;
	}
}
