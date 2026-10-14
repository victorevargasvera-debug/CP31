using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000398 RID: 920
	public class DConRefRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06001FA5 RID: 8101 RVA: 0x00061470 File Offset: 0x0005F670
		public DConRefRecord(byte[] data)
		{
			int num = 0;
			if (global::NPOI.Util.LittleEndian.GetShort(data, num) != 81)
			{
				throw new global::NPOI.Util.RecordFormatException("incompatible sid.");
			}
			num += 2;
			num += 2;
			this.firstRow = global::NPOI.Util.LittleEndian.GetUShort(data, num);
			num += 2;
			this.lastRow = global::NPOI.Util.LittleEndian.GetUShort(data, num);
			num += 2;
			this.firstCol = (int)global::NPOI.Util.LittleEndian.GetUByte(data, num);
			num++;
			this.lastCol = (int)global::NPOI.Util.LittleEndian.GetUByte(data, num);
			num++;
			this.charCount = global::NPOI.Util.LittleEndian.GetUShort(data, num);
			num += 2;
			if (this.charCount < 2)
			{
				throw new global::NPOI.Util.RecordFormatException("Character count must be >= 2");
			}
			this.charType = (int)global::NPOI.Util.LittleEndian.GetUByte(data, num);
			num++;
			int num2 = this.charCount * ((this.charType & 1) + 1);
			this.path = global::NPOI.Util.LittleEndian.GetByteArray(data, num, num2);
			num += num2;
			if (this.path[0] == 2)
			{
				this._unused = global::NPOI.Util.LittleEndian.GetByteArray(data, num, this.charType + 1);
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00061564 File Offset: 0x0005F764
		public DConRefRecord(global::NPOI.HSSF.Record.RecordInputStream inStream)
		{
			if (inStream.Sid != 81)
			{
				throw new global::NPOI.Util.RecordFormatException("Wrong sid: " + inStream.Sid.ToString());
			}
			this.firstRow = inStream.ReadUShort();
			this.lastRow = inStream.ReadUShort();
			this.firstCol = inStream.ReadUByte();
			this.lastCol = inStream.ReadUByte();
			this.charCount = inStream.ReadUShort();
			this.charType = (inStream.ReadUByte() & 1);
			int num = this.charCount * (this.charType + 1);
			this.path = new byte[num];
			inStream.ReadFully(this.path);
			if (this.path[0] == 2)
			{
				this._unused = inStream.ReadRemainder();
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00061628 File Offset: 0x0005F828
		protected override int DataSize
		{
			get
			{
				int num = 9 + this.path.Length;
				if (this.path[0] == 2)
				{
					num += this._unused.Length;
				}
				return num;
			}
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00061658 File Offset: 0x0005F858
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.firstRow);
			out1.WriteShort(this.lastRow);
			out1.WriteByte(this.firstCol);
			out1.WriteByte(this.lastCol);
			out1.WriteShort(this.charCount);
			out1.WriteByte(this.charType);
			out1.Write(this.path);
			if (this.path[0] == 2)
			{
				out1.Write(this._unused);
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x000616D0 File Offset: 0x0005F8D0
		public override short Sid
		{
			get
			{
				return 81;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x000616D4 File Offset: 0x0005F8D4
		public int FirstColumn
		{
			get
			{
				return this.firstCol;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x000616DC File Offset: 0x0005F8DC
		public int FirstRow
		{
			get
			{
				return this.firstRow;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x000616E4 File Offset: 0x0005F8E4
		public int LastColumn
		{
			get
			{
				return this.lastCol;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x000616EC File Offset: 0x0005F8EC
		public int LastRow
		{
			get
			{
				return this.lastRow;
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x000616F4 File Offset: 0x0005F8F4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DCONREF]\n");
			stringBuilder.Append("    .ref\n");
			stringBuilder.Append("        .firstrow   = ").Append(this.firstRow).Append("\n");
			stringBuilder.Append("        .lastrow    = ").Append(this.lastRow).Append("\n");
			stringBuilder.Append("        .firstcol   = ").Append(this.firstCol).Append("\n");
			stringBuilder.Append("        .lastcol    = ").Append(this.lastCol).Append("\n");
			stringBuilder.Append("    .cch            = ").Append(this.charCount).Append("\n");
			stringBuilder.Append("    .stFile\n");
			stringBuilder.Append("        .h          = ").Append(this.charType).Append("\n");
			stringBuilder.Append("        .rgb        = ").Append(this.ReadablePath).Append("\n");
			stringBuilder.Append("[/DCONREF]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00061822 File Offset: 0x0005FA22
		public byte[] GetPath()
		{
			return global::NPOI.Util.Arrays.CopyOf(this.path, this.path.Length);
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00061838 File Offset: 0x0005FA38
		public string ReadablePath
		{
			get
			{
				if (this.path != null)
				{
					int num = 1;
					while (this.path[num] < 32 && num < this.path.Length)
					{
						num++;
					}
					return global::System.Text.Encoding.UTF8.GetString(global::NPOI.Util.Arrays.CopyOfRange(this.path, num, this.path.Length)).Replace("\u0003", "/");
				}
				return null;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0006189B File Offset: 0x0005FA9B
		public bool IsExternalRef
		{
			get
			{
				return this.path[0] == 1;
			}
		}

		// Token: 0x04000C29 RID: 3113
		public const short sid = 81;

		// Token: 0x04000C2A RID: 3114
		private int firstRow;

		// Token: 0x04000C2B RID: 3115
		private int lastRow;

		// Token: 0x04000C2C RID: 3116
		private int firstCol;

		// Token: 0x04000C2D RID: 3117
		private int lastCol;

		// Token: 0x04000C2E RID: 3118
		private int charCount;

		// Token: 0x04000C2F RID: 3119
		private int charType;

		// Token: 0x04000C30 RID: 3120
		private byte[] path;

		// Token: 0x04000C31 RID: 3121
		private byte[] _unused;
	}
}
