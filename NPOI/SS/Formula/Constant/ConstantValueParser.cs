using System;
using NPOI.Util;

namespace NPOI.SS.Formula.Constant
{
	// Token: 0x020000E6 RID: 230
	public class ConstantValueParser
	{
		// Token: 0x060007CB RID: 1995 RVA: 0x0000253E File Offset: 0x0000073E
		private ConstantValueParser()
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00015960 File Offset: 0x00013B60
		public static object[] Parse(global::NPOI.Util.ILittleEndianInput in1, int nValues)
		{
			object[] array = new object[nValues];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = global::NPOI.SS.Formula.Constant.ConstantValueParser.ReadAConstantValue(in1);
			}
			return array;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0001598C File Offset: 0x00013B8C
		private static object ReadAConstantValue(global::NPOI.Util.ILittleEndianInput in1)
		{
			byte b = (byte)in1.ReadByte();
			switch (b)
			{
			case 0:
				in1.ReadLong();
				return null;
			case 1:
				return in1.ReadDouble();
			case 2:
				return global::NPOI.Util.StringUtil.ReadUnicodeString(in1);
			case 3:
				break;
			case 4:
				return global::NPOI.SS.Formula.Constant.ConstantValueParser.ReadBoolean(in1);
			default:
				if (b == 16)
				{
					int errorCode = in1.ReadUShort();
					in1.ReadUShort();
					in1.ReadInt();
					return global::NPOI.SS.Formula.Constant.ErrorConstant.ValueOf(errorCode);
				}
				break;
			}
			throw new global::System.Exception("Unknown grbit value (" + b.ToString() + ")");
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00015A1C File Offset: 0x00013C1C
		private static object ReadBoolean(global::NPOI.Util.ILittleEndianInput in1)
		{
			byte b = (byte)in1.ReadLong();
			if (b == 0)
			{
				return false;
			}
			if (b != 1)
			{
				throw new global::System.Exception("unexpected bool encoding (" + b.ToString() + ")");
			}
			return true;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00015A64 File Offset: 0x00013C64
		public static int GetEncodedSize(global::System.Array values)
		{
			int num = values.Length;
			for (int i = 0; i < values.Length; i++)
			{
				num += global::NPOI.SS.Formula.Constant.ConstantValueParser.GetEncodedSize(values.GetValue(i));
			}
			return num;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00015A9C File Offset: 0x00013C9C
		private static int GetEncodedSize(object obj)
		{
			if (obj == null)
			{
				return 8;
			}
			global::System.Type type = obj.GetType();
			if (type == typeof(bool) || type == typeof(double) || type == typeof(global::NPOI.SS.Formula.Constant.ErrorConstant))
			{
				return 8;
			}
			return global::NPOI.Util.StringUtil.GetEncodedSize((string)obj);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00015AF8 File Offset: 0x00013CF8
		public static void Encode(global::NPOI.Util.ILittleEndianOutput out1, global::System.Array values)
		{
			for (int i = 0; i < values.Length; i++)
			{
				global::NPOI.SS.Formula.Constant.ConstantValueParser.EncodeSingleValue(out1, values.GetValue(i));
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00015B24 File Offset: 0x00013D24
		private static void EncodeSingleValue(global::NPOI.Util.ILittleEndianOutput out1, object value)
		{
			if (value == null)
			{
				out1.WriteByte(0);
				out1.WriteLong(0L);
				return;
			}
			if (value is bool)
			{
				bool flag = (bool)value;
				out1.WriteByte(4);
				long v = flag ? 1L : 0L;
				out1.WriteLong(v);
				return;
			}
			if (value is double)
			{
				double v2 = (double)value;
				out1.WriteByte(1);
				out1.WriteDouble(v2);
				return;
			}
			if (value is string)
			{
				string value2 = (string)value;
				out1.WriteByte(2);
				global::NPOI.Util.StringUtil.WriteUnicodeString(out1, value2);
				return;
			}
			if (value is global::NPOI.SS.Formula.Constant.ErrorConstant)
			{
				global::NPOI.SS.Formula.Constant.ErrorConstant errorConstant = (global::NPOI.SS.Formula.Constant.ErrorConstant)value;
				out1.WriteByte(16);
				long v3 = (long)errorConstant.ErrorCode;
				out1.WriteLong(v3);
				return;
			}
			throw new global::System.Exception("Unexpected value type (" + value.GetType().Name + "'");
		}

		// Token: 0x04000420 RID: 1056
		private const int TYPE_EMPTY = 0;

		// Token: 0x04000421 RID: 1057
		private const int TYPE_NUMBER = 1;

		// Token: 0x04000422 RID: 1058
		private const int TYPE_STRING = 2;

		// Token: 0x04000423 RID: 1059
		private const int TYPE_BOOLEAN = 4;

		// Token: 0x04000424 RID: 1060
		private const int TYPE_ERROR_CODE = 16;

		// Token: 0x04000425 RID: 1061
		private const int TRUE_ENCODING = 1;

		// Token: 0x04000426 RID: 1062
		private const int FALSE_ENCODING = 0;

		// Token: 0x04000427 RID: 1063
		private const object EMPTY_REPRESENTATION = null;
	}
}
