using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200042B RID: 1067
	public class LbsDropData
	{
		// Token: 0x0600273D RID: 10045 RVA: 0x00076246 File Offset: 0x00074446
		public LbsDropData()
		{
			this._str = "";
			this._unused = 0;
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00076260 File Offset: 0x00074460
		public LbsDropData(global::NPOI.Util.ILittleEndianInput in1)
		{
			this._wStyle = in1.ReadUShort();
			this._cLine = in1.ReadUShort();
			this._dxMin = in1.ReadUShort();
			this._str = global::NPOI.Util.StringUtil.ReadUnicodeString(in1);
			if (global::NPOI.Util.StringUtil.GetEncodedSize(this._str) % 2 != 0)
			{
				this._unused = (byte)in1.ReadByte();
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000762BF File Offset: 0x000744BF
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._wStyle);
			out1.WriteShort(this._cLine);
			out1.WriteShort(this._dxMin);
			global::NPOI.Util.StringUtil.WriteUnicodeString(out1, this._str);
			out1.WriteByte((int)this._unused);
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000762FD File Offset: 0x000744FD
		public int DataSize
		{
			get
			{
				return 6 + global::NPOI.Util.StringUtil.GetEncodedSize(this._str) + (int)this._unused;
			}
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00076314 File Offset: 0x00074514
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[LbsDropData]\n");
			stringBuilder.Append("  ._wStyle:  ").Append(this._wStyle).Append('\n');
			stringBuilder.Append("  ._cLine:  ").Append(this._cLine).Append('\n');
			stringBuilder.Append("  ._dxMin:  ").Append(this._dxMin).Append('\n');
			stringBuilder.Append("  ._str:  ").Append(this._str).Append('\n');
			stringBuilder.Append("  ._unused:  ").Append(this._unused).Append('\n');
			stringBuilder.Append("[/LbsDropData]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001091 RID: 4241
		public const int STYLE_COMBO_DROPDOWN = 0;

		// Token: 0x04001092 RID: 4242
		public const int STYLE_COMBO_EDIT_DROPDOWN = 1;

		// Token: 0x04001093 RID: 4243
		public const int STYLE_COMBO_SIMPLE_DROPDOWN = 2;

		// Token: 0x04001094 RID: 4244
		internal int _wStyle;

		// Token: 0x04001095 RID: 4245
		internal int _cLine;

		// Token: 0x04001096 RID: 4246
		private int _dxMin;

		// Token: 0x04001097 RID: 4247
		private string _str;

		// Token: 0x04001098 RID: 4248
		private byte _unused;
	}
}
