using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.PivotTable
{
	// Token: 0x02000448 RID: 1096
	public class PageItemRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002896 RID: 10390 RVA: 0x0007A3D0 File Offset: 0x000785D0
		public PageItemRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int remaining = in1.Remaining;
			if (remaining % 6 != 0)
			{
				throw new global::NPOI.Util.RecordFormatException("Bad data size " + remaining.ToString());
			}
			global::NPOI.HSSF.Record.PivotTable.PageItemRecord.FieldInfo[] array = new global::NPOI.HSSF.Record.PivotTable.PageItemRecord.FieldInfo[remaining / 6];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new global::NPOI.HSSF.Record.PivotTable.PageItemRecord.FieldInfo(in1);
			}
			this._fieldInfos = array;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0007A430 File Offset: 0x00078630
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			for (int i = 0; i < this._fieldInfos.Length; i++)
			{
				this._fieldInfos[i].Serialize(out1);
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x0007A45E File Offset: 0x0007865E
		protected override int DataSize
		{
			get
			{
				return this._fieldInfos.Length * 6;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x0007A46A File Offset: 0x0007866A
		public override short Sid
		{
			get
			{
				return 182;
			}
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0007A474 File Offset: 0x00078674
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SXPI]\n");
			for (int i = 0; i < this._fieldInfos.Length; i++)
			{
				stringBuilder.Append("    item[").Append(i).Append("]=");
				this._fieldInfos[i].AppendDebugInfo(stringBuilder);
				stringBuilder.Append('\n');
			}
			stringBuilder.Append("[/SXPI]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001159 RID: 4441
		public const short sid = 182;

		// Token: 0x0400115A RID: 4442
		private global::NPOI.HSSF.Record.PivotTable.PageItemRecord.FieldInfo[] _fieldInfos;

		// Token: 0x02000617 RID: 1559
		private class FieldInfo
		{
			// Token: 0x06003697 RID: 13975 RVA: 0x000A6C36 File Offset: 0x000A4E36
			public FieldInfo(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				this._isxvi = (int)in1.ReadShort();
				this._isxvd = (int)in1.ReadShort();
				this._idObj = (int)in1.ReadShort();
			}

			// Token: 0x06003698 RID: 13976 RVA: 0x000A6C62 File Offset: 0x000A4E62
			internal void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
			{
				out1.WriteShort(this._isxvi);
				out1.WriteShort(this._isxvd);
				out1.WriteShort(this._idObj);
			}

			// Token: 0x06003699 RID: 13977 RVA: 0x000A6C88 File Offset: 0x000A4E88
			public void AppendDebugInfo(global::System.Text.StringBuilder sb)
			{
				sb.Append('(');
				sb.Append("isxvi=").Append(global::NPOI.Util.HexDump.ShortToHex(this._isxvi));
				sb.Append(" isxvd=").Append(global::NPOI.Util.HexDump.ShortToHex(this._isxvd));
				sb.Append(" idObj=").Append(global::NPOI.Util.HexDump.ShortToHex(this._idObj));
				sb.Append(')');
			}

			// Token: 0x04001A87 RID: 6791
			public const int ENCODED_SIZE = 6;

			// Token: 0x04001A88 RID: 6792
			private int _isxvi;

			// Token: 0x04001A89 RID: 6793
			private int _isxvd;

			// Token: 0x04001A8A RID: 6794
			private int _idObj;
		}
	}
}
