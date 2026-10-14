using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000401 RID: 1025
	internal class PColor
	{
		// Token: 0x0600253E RID: 9534 RVA: 0x000702B7 File Offset: 0x0006E4B7
		public PColor(int red, int green, int blue)
		{
			this._red = (byte)red;
			this._green = (byte)green;
			this._blue = (byte)blue;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000702D7 File Offset: 0x0006E4D7
		public PColor(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._red = (byte)in1.ReadByte();
			this._green = (byte)in1.ReadByte();
			this._blue = (byte)in1.ReadByte();
			in1.ReadByte();
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x0007030D File Offset: 0x0006E50D
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this._red);
			out1.WriteByte((int)this._green);
			out1.WriteByte((int)this._blue);
			out1.WriteByte(0);
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x0007033C File Offset: 0x0006E53C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("  red           = ").Append((int)(this._red & byte.MaxValue)).Append('\n');
			stringBuilder.Append("  green         = ").Append((int)(this._green & byte.MaxValue)).Append('\n');
			stringBuilder.Append("  blue          = ").Append((int)(this._blue & byte.MaxValue)).Append('\n');
			return stringBuilder.ToString();
		}

		// Token: 0x04000FA7 RID: 4007
		public const short ENCODED_SIZE = 4;

		// Token: 0x04000FA8 RID: 4008
		public byte _red;

		// Token: 0x04000FA9 RID: 4009
		public byte _green;

		// Token: 0x04000FAA RID: 4010
		public byte _blue;
	}
}
