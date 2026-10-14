using System;
using System.Text;
using System.Text.RegularExpressions;

namespace NPOI.Util
{
	// Token: 0x0200025B RID: 603
	public class ClassID
	{
		// Token: 0x06000EFB RID: 3835 RVA: 0x0002C050 File Offset: 0x0002A250
		public ClassID(byte[] src, int offset)
		{
			this.Read(src, offset);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0002C064 File Offset: 0x0002A264
		public ClassID()
		{
			this.bytes = new byte[16];
			for (int i = 0; i < 16; i++)
			{
				this.bytes[i] = 0;
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0002C09C File Offset: 0x0002A29C
		public ClassID(string externalForm)
		{
			this.bytes = new byte[16];
			string text = global::System.Text.RegularExpressions.Regex.Replace(externalForm, "[{}-]", "");
			for (int i = 0; i < text.Length; i += 2)
			{
				this.bytes[i / 2] = (byte)global::System.Convert.ToInt64(text.Substring(i, 2), 16);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		public int Length
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0002C0FC File Offset: 0x0002A2FC
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x0002C104 File Offset: 0x0002A304
		public byte[] Bytes
		{
			get
			{
				return this.bytes;
			}
			set
			{
				for (int i = 0; i < this.bytes.Length; i++)
				{
					this.bytes[i] = value[i];
				}
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0002C130 File Offset: 0x0002A330
		public byte[] Read(byte[] src, int offset)
		{
			this.bytes = new byte[16];
			this.bytes[0] = src[3 + offset];
			this.bytes[1] = src[2 + offset];
			this.bytes[2] = src[1 + offset];
			this.bytes[3] = src[offset];
			this.bytes[4] = src[5 + offset];
			this.bytes[5] = src[4 + offset];
			this.bytes[6] = src[7 + offset];
			this.bytes[7] = src[6 + offset];
			for (int i = 8; i < 16; i++)
			{
				this.bytes[i] = src[i + offset];
			}
			return this.bytes;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0002C1D0 File Offset: 0x0002A3D0
		public void Write(byte[] dst, int offset)
		{
			if (dst.Length < 16)
			{
				throw new global::System.ArrayTypeMismatchException("Destination byte[] must have room for at least 16 bytes, but has a length of only " + dst.Length.ToString() + ".");
			}
			dst[offset] = this.bytes[3];
			dst[1 + offset] = this.bytes[2];
			dst[2 + offset] = this.bytes[1];
			dst[3 + offset] = this.bytes[0];
			dst[4 + offset] = this.bytes[5];
			dst[5 + offset] = this.bytes[4];
			dst[6 + offset] = this.bytes[7];
			dst[7 + offset] = this.bytes[6];
			for (int i = 8; i < 16; i++)
			{
				dst[i + offset] = this.bytes[i];
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0002C284 File Offset: 0x0002A484
		public override bool Equals(object o)
		{
			if (o == null || !(o is global::NPOI.Util.ClassID))
			{
				return false;
			}
			global::NPOI.Util.ClassID classID = (global::NPOI.Util.ClassID)o;
			if (this.bytes.Length != classID.bytes.Length)
			{
				return false;
			}
			for (int i = 0; i < this.bytes.Length; i++)
			{
				if (this.bytes[i] != classID.bytes[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0002C2E1 File Offset: 0x0002A4E1
		public override int GetHashCode()
		{
			return global::System.Text.Encoding.UTF8.GetString(this.bytes).GetHashCode();
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(38);
			stringBuilder.Append('{');
			for (int i = 0; i < 16; i++)
			{
				stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(this.bytes[i]));
				if (i == 3 || i == 5 || i == 7 || i == 9)
				{
					stringBuilder.Append('-');
				}
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x040006B8 RID: 1720
		public static global::NPOI.Util.ClassID OLE10_PACKAGE = new global::NPOI.Util.ClassID("{0003000C-0000-0000-C000-000000000046}");

		// Token: 0x040006B9 RID: 1721
		public static global::NPOI.Util.ClassID PPT_SHOW = new global::NPOI.Util.ClassID("{64818D10-4F9B-11CF-86EA-00AA00B929E8}");

		// Token: 0x040006BA RID: 1722
		public static global::NPOI.Util.ClassID XLS_WORKBOOK = new global::NPOI.Util.ClassID("{00020841-0000-0000-C000-000000000046}");

		// Token: 0x040006BB RID: 1723
		public static global::NPOI.Util.ClassID TXT_ONLY = new global::NPOI.Util.ClassID("{5e941d80-bf96-11cd-b579-08002b30bfeb}");

		// Token: 0x040006BC RID: 1724
		public static global::NPOI.Util.ClassID EXCEL97 = new global::NPOI.Util.ClassID("{00020820-0000-0000-C000-000000000046}");

		// Token: 0x040006BD RID: 1725
		public static global::NPOI.Util.ClassID EXCEL95 = new global::NPOI.Util.ClassID("{00020810-0000-0000-C000-000000000046}");

		// Token: 0x040006BE RID: 1726
		public static global::NPOI.Util.ClassID WORD97 = new global::NPOI.Util.ClassID("{00020906-0000-0000-C000-000000000046}");

		// Token: 0x040006BF RID: 1727
		public static global::NPOI.Util.ClassID WORD95 = new global::NPOI.Util.ClassID("{00020900-0000-0000-C000-000000000046}");

		// Token: 0x040006C0 RID: 1728
		public static global::NPOI.Util.ClassID POWERPOINT97 = new global::NPOI.Util.ClassID("{64818D10-4F9B-11CF-86EA-00AA00B929E8}");

		// Token: 0x040006C1 RID: 1729
		public static global::NPOI.Util.ClassID POWERPOINT95 = new global::NPOI.Util.ClassID("{EA7BAE70-FB3B-11CD-A903-00AA00510EA3}");

		// Token: 0x040006C2 RID: 1730
		public static global::NPOI.Util.ClassID EQUATION30 = new global::NPOI.Util.ClassID("{0002CE02-0000-0000-C000-000000000046}");

		// Token: 0x040006C3 RID: 1731
		protected byte[] bytes;

		// Token: 0x040006C4 RID: 1732
		public const int LENGTH = 16;
	}
}
