using System;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Util
{
	// Token: 0x02000340 RID: 832
	public class GUID
	{
		// Token: 0x060018C4 RID: 6340 RVA: 0x0004BE07 File Offset: 0x0004A007
		public GUID(global::NPOI.Util.ILittleEndianInput in1) : this(in1.ReadInt(), in1.ReadUShort(), in1.ReadUShort(), in1.ReadLong())
		{
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0004BE27 File Offset: 0x0004A027
		public GUID(int d1, int d2, int d3, long d4)
		{
			this._d1 = d1;
			this._d2 = d2;
			this._d3 = d3;
			this._d4 = d4;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0004BE4C File Offset: 0x0004A04C
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this._d1);
			out1.WriteShort(this._d2);
			out1.WriteShort(this._d3);
			out1.WriteLong(this._d4);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0004BE80 File Offset: 0x0004A080
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.HSSF.Util.GUID))
			{
				return false;
			}
			global::NPOI.HSSF.Util.GUID guid = (global::NPOI.HSSF.Util.GUID)obj;
			return this._d1 == guid._d1 && this._d2 == guid._d2 && this._d3 == guid._d3 && this._d4 == guid._d4;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0004BED8 File Offset: 0x0004A0D8
		public override int GetHashCode()
		{
			return this._d1 ^ this._d2 ^ this._d3 ^ this._d4.GetHashCode();
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0004BEFA File Offset: 0x0004A0FA
		public int D1
		{
			get
			{
				return this._d1;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x0004BF02 File Offset: 0x0004A102
		public int D2
		{
			get
			{
				return this._d2;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x0004BF0A File Offset: 0x0004A10A
		public int D3
		{
			get
			{
				return this._d3;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x0004BF14 File Offset: 0x0004A114
		public long D4
		{
			get
			{
				byte[] array;
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(8))
				{
					global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(memoryStream);
					binaryWriter.Write(this._d4);
					array = memoryStream.ToArray();
					binaryWriter.Close();
				}
				global::System.Array.Reverse(array);
				return new global::NPOI.Util.LittleEndianByteArrayInputStream(array).ReadLong();
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0004BF74 File Offset: 0x0004A174
		public string FormatAsString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(36);
			int length = "0x".Length;
			stringBuilder.Append(global::NPOI.Util.HexDump.IntToHex(this._d1), length, 8);
			stringBuilder.Append("-");
			stringBuilder.Append(global::NPOI.Util.HexDump.ShortToHex(this._d2), length, 4);
			stringBuilder.Append("-");
			stringBuilder.Append(global::NPOI.Util.HexDump.ShortToHex(this._d3), length, 4);
			stringBuilder.Append("-");
			char[] value = global::NPOI.Util.HexDump.LongToHex(this.D4);
			stringBuilder.Append(value, length, 4);
			stringBuilder.Append("-");
			stringBuilder.Append(value, length + 4, 12);
			return stringBuilder.ToString();
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0004C028 File Offset: 0x0004A228
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.FormatAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0004C078 File Offset: 0x0004A278
		public static global::NPOI.HSSF.Util.GUID Parse(string rep)
		{
			char[] array = rep.ToCharArray();
			if (array.Length != 36)
			{
				throw new global::NPOI.Util.RecordFormatException("supplied text is the wrong length for a GUID");
			}
			int d = (global::NPOI.HSSF.Util.GUID.ParseShort(array, 0) << 16) + global::NPOI.HSSF.Util.GUID.ParseShort(array, 4);
			int d2 = global::NPOI.HSSF.Util.GUID.ParseShort(array, 9);
			int d3 = global::NPOI.HSSF.Util.GUID.ParseShort(array, 14);
			for (int i = 23; i > 19; i--)
			{
				array[i] = array[i - 1];
			}
			long d4 = global::NPOI.HSSF.Util.GUID.ParseLELong(array, 20);
			return new global::NPOI.HSSF.Util.GUID(d, d2, d3, d4);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0004C0F4 File Offset: 0x0004A2F4
		private static long ParseLELong(char[] cc, int startIndex)
		{
			long num = 0L;
			for (int i = startIndex + 14; i >= startIndex; i -= 2)
			{
				num <<= 4;
				num += (long)global::NPOI.HSSF.Util.GUID.ParseHexChar(cc[i]);
				num <<= 4;
				num += (long)global::NPOI.HSSF.Util.GUID.ParseHexChar(cc[i + 1]);
			}
			return num;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0004C138 File Offset: 0x0004A338
		private static int ParseShort(char[] cc, int startIndex)
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				num <<= 4;
				num += global::NPOI.HSSF.Util.GUID.ParseHexChar(cc[startIndex + i]);
			}
			return num;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0004C168 File Offset: 0x0004A368
		private static int ParseHexChar(char c)
		{
			if (c >= '0' && c <= '9')
			{
				return (int)(c - '0');
			}
			if (c >= 'A' && c <= 'F')
			{
				return (int)(c - 'A' + '\n');
			}
			if (c >= 'a' && c <= 'f')
			{
				return (int)(c - 'a' + '\n');
			}
			throw new global::NPOI.Util.RecordFormatException("Bad hex char '" + c.ToString() + "'");
		}

		// Token: 0x040009EC RID: 2540
		private const int TEXT_FORMAT_LENGTH = 36;

		// Token: 0x040009ED RID: 2541
		public const int ENCODED_SIZE = 16;

		// Token: 0x040009EE RID: 2542
		private int _d1;

		// Token: 0x040009EF RID: 2543
		private int _d2;

		// Token: 0x040009F0 RID: 2544
		private int _d3;

		// Token: 0x040009F1 RID: 2545
		private long _d4;
	}
}
