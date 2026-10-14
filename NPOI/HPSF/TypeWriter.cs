using System;
using System.IO;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x0200051F RID: 1311
	public class TypeWriter
	{
		// Token: 0x0600315F RID: 12639 RVA: 0x00094B02 File Offset: 0x00092D02
		public static int WriteToStream(global::System.IO.Stream out1, short n)
		{
			global::NPOI.Util.LittleEndian.PutShort(out1, n);
			return 2;
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00094B0C File Offset: 0x00092D0C
		public static int WriteToStream(global::System.IO.Stream out1, int n)
		{
			global::NPOI.Util.LittleEndian.PutInt(n, out1);
			return 4;
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00094B18 File Offset: 0x00092D18
		[global::System.Obsolete]
		public static int WriteToStream(global::System.IO.Stream out1, uint n)
		{
			int num = 4;
			byte[] array = new byte[num];
			global::NPOI.Util.LittleEndian.PutUInt(array, 0, n);
			out1.Write(array, 0, num);
			return num;
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x00094B40 File Offset: 0x00092D40
		public static int WriteToStream(global::System.IO.Stream out1, long n)
		{
			global::NPOI.Util.LittleEndian.PutLong(n, out1);
			return 8;
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x00094B4A File Offset: 0x00092D4A
		public static void WriteUShortToStream(global::System.IO.Stream out1, int n)
		{
			if ((n & -65536) != 0)
			{
				throw new global::NPOI.HPSF.IllegalPropertySetDataException("Value " + n.ToString() + " cannot be represented by 2 bytes.");
			}
			global::NPOI.Util.LittleEndian.PutUShort(n, out1);
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x00094B78 File Offset: 0x00092D78
		public static int WriteUIntToStream(global::System.IO.Stream out1, uint n)
		{
			ulong num = (ulong)n & 18446744069414584320UL;
			if (num != 0UL && num != 18446744069414584320UL)
			{
				throw new global::NPOI.HPSF.IllegalPropertySetDataException("Value " + n.ToString() + " cannot be represented by 4 bytes.");
			}
			global::NPOI.Util.LittleEndian.PutUInt((long)((ulong)n), out1);
			return 4;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00094BC8 File Offset: 0x00092DC8
		public static int WriteToStream(global::System.IO.Stream out1, global::NPOI.Util.ClassID n)
		{
			byte[] array = new byte[16];
			n.Write(array, 0);
			out1.Write(array, 0, array.Length);
			return array.Length;
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00094BF4 File Offset: 0x00092DF4
		public static void WriteToStream(global::System.IO.Stream out1, global::NPOI.HPSF.Property[] properties, int codepage)
		{
			if (properties == null)
			{
				return;
			}
			foreach (global::NPOI.HPSF.Property property in properties)
			{
				global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)property.ID);
				global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)property.Count);
			}
			foreach (global::NPOI.HPSF.Property property2 in properties)
			{
				long type = property2.Type;
				global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)type);
				global::NPOI.HPSF.VariantSupport.Write(out1, (long)((int)type), property2.Value, codepage);
			}
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00094C68 File Offset: 0x00092E68
		public static int WriteToStream(global::System.IO.Stream out1, double n)
		{
			global::NPOI.Util.LittleEndian.PutDouble(n, out1);
			return 8;
		}
	}
}
