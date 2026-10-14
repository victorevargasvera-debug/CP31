using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E7 RID: 999
	public class HeaderFooterRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060023F2 RID: 9202 RVA: 0x0006C453 File Offset: 0x0006A653
		public HeaderFooterRecord(byte[] data)
		{
			this._rawData = data;
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x0006C462 File Offset: 0x0006A662
		public HeaderFooterRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._rawData = in1.ReadRemainder();
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x0006C476 File Offset: 0x0006A676
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this._rawData);
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0006C484 File Offset: 0x0006A684
		protected override int DataSize
		{
			get
			{
				return this._rawData.Length;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x0006C48E File Offset: 0x0006A68E
		public override short Sid
		{
			get
			{
				return 2204;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0006C498 File Offset: 0x0006A698
		public byte[] Guid
		{
			get
			{
				byte[] array = new byte[16];
				global::System.Array.Copy(this._rawData, 12, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x0006C4C0 File Offset: 0x0006A6C0
		public bool IsCurrentSheet
		{
			get
			{
				return global::NPOI.Util.Arrays.Equals(this.Guid, global::NPOI.HSSF.Record.HeaderFooterRecord.BLANK_GUID);
			}
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0006C4D4 File Offset: 0x0006A6D4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[").Append("HEADERFOOTER").Append("] (0x");
			stringBuilder.Append(global::NPOI.Util.StringUtil.ToHexString(2204).ToUpper() + ")\n");
			stringBuilder.Append("  rawData=").Append(global::NPOI.Util.HexDump.ToHex(this._rawData)).Append("\n");
			stringBuilder.Append("[/").Append("HEADERFOOTER").Append("]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00062BA1 File Offset: 0x00060DA1
		public override object Clone()
		{
			return base.CloneViaReserialise();
		}

		// Token: 0x04000F18 RID: 3864
		private static byte[] BLANK_GUID = new byte[16];

		// Token: 0x04000F19 RID: 3865
		public const short sid = 2204;

		// Token: 0x04000F1A RID: 3866
		private byte[] _rawData;
	}
}
