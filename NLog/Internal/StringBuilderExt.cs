using System;
using System.IO;
using System.Text;
using NLog.MessageTemplates;

namespace NLog.Internal
{
	// Token: 0x02000127 RID: 295
	internal static class StringBuilderExt
	{
		// Token: 0x06000DAE RID: 3502 RVA: 0x000228D0 File Offset: 0x00020AD0
		public static void AppendFormattedValue(this global::System.Text.StringBuilder builder, object value, string format, global::System.IFormatProvider formatProvider)
		{
			if (value is string && string.IsNullOrEmpty(format))
			{
				builder.Append(value);
				return;
			}
			if (format == "@")
			{
				global::NLog.MessageTemplates.ValueFormatter.Instance.FormatValue(value, null, global::NLog.MessageTemplates.CaptureType.Serialize, formatProvider, builder);
				return;
			}
			if (value != null)
			{
				global::NLog.MessageTemplates.ValueFormatter.Instance.FormatValue(value, format, global::NLog.MessageTemplates.CaptureType.Normal, formatProvider, builder);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00022928 File Offset: 0x00020B28
		public static void AppendInvariant(this global::System.Text.StringBuilder builder, int value)
		{
			if (value < 0)
			{
				builder.Append('-');
				uint value2 = (uint)(-1 - value + 1);
				builder.AppendInvariant(value2);
				return;
			}
			builder.AppendInvariant((uint)value);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00022958 File Offset: 0x00020B58
		public static void AppendInvariant(this global::System.Text.StringBuilder builder, uint value)
		{
			if (value == 0U)
			{
				builder.Append('0');
				return;
			}
			int i = 0;
			uint num = value;
			do
			{
				num /= 10U;
				i++;
			}
			while (num > 0U);
			builder.Append('0', i);
			int num2 = builder.Length;
			while (i > 0)
			{
				num2--;
				builder[num2] = global::NLog.Internal.StringBuilderExt.charToInt[(int)(value % 10U)];
				value /= 10U;
				i--;
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000229B9 File Offset: 0x00020BB9
		public static void ClearBuilder(this global::System.Text.StringBuilder builder)
		{
			builder.Clear();
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000229C4 File Offset: 0x00020BC4
		public static void CopyToStream(this global::System.Text.StringBuilder builder, global::System.IO.MemoryStream ms, global::System.Text.Encoding encoding, char[] transformBuffer)
		{
			if (transformBuffer != null)
			{
				int num = encoding.GetMaxByteCount(builder.Length);
				ms.SetLength(ms.Position + (long)num);
				for (int i = 0; i < builder.Length; i += transformBuffer.Length)
				{
					int num2 = global::System.Math.Min(builder.Length - i, transformBuffer.Length);
					builder.CopyTo(i, transformBuffer, 0, num2);
					num = encoding.GetBytes(transformBuffer, 0, num2, ms.GetBuffer(), (int)ms.Position);
					ms.Position += (long)num;
				}
				if (ms.Position != ms.Length)
				{
					ms.SetLength(ms.Position);
					return;
				}
			}
			else
			{
				string s = builder.ToString();
				byte[] bytes = encoding.GetBytes(s);
				ms.Write(bytes, 0, bytes.Length);
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00022A84 File Offset: 0x00020C84
		public static void CopyTo(this global::System.Text.StringBuilder builder, global::System.Text.StringBuilder destination)
		{
			int length = builder.Length;
			if (length > 0)
			{
				destination.EnsureCapacity(length + destination.Length);
				if (length < 8)
				{
					for (int i = 0; i < length; i++)
					{
						destination.Append(builder[i]);
					}
					return;
				}
				if (length < 512)
				{
					destination.Append(builder.ToString());
					return;
				}
				char[] array = new char[256];
				for (int j = 0; j < length; j += array.Length)
				{
					int num = global::System.Math.Min(length - j, array.Length);
					builder.CopyTo(j, array, 0, num);
					destination.Append(array, 0, num);
				}
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00022B20 File Offset: 0x00020D20
		public static int IndexOf(this global::System.Text.StringBuilder builder, char needle, int startPos = 0)
		{
			for (int i = startPos; i < builder.Length; i++)
			{
				if (builder[i] == needle)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00022B4C File Offset: 0x00020D4C
		public static bool EqualTo(this global::System.Text.StringBuilder builder, global::System.Text.StringBuilder other)
		{
			if (builder.Length != other.Length)
			{
				return false;
			}
			for (int i = 0; i < builder.Length; i++)
			{
				if (builder[i] != other[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00022B90 File Offset: 0x00020D90
		public static bool EqualTo(this global::System.Text.StringBuilder builder, string other)
		{
			if (builder.Length != other.Length)
			{
				return false;
			}
			for (int i = 0; i < other.Length; i++)
			{
				if (builder[i] != other[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00022BD1 File Offset: 0x00020DD1
		internal static void Append2DigitsZeroPadded(this global::System.Text.StringBuilder builder, int number)
		{
			builder.Append((char)(number / 10 + 48));
			builder.Append((char)(number % 10 + 48));
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00022BF4 File Offset: 0x00020DF4
		internal static void Append4DigitsZeroPadded(this global::System.Text.StringBuilder builder, int number)
		{
			builder.Append((char)(number / 1000 % 10 + 48));
			builder.Append((char)(number / 100 % 10 + 48));
			builder.Append((char)(number / 10 % 10 + 48));
			builder.Append((char)(number / 1 % 10 + 48));
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00022C4C File Offset: 0x00020E4C
		internal static void AppendIntegerAsString(this global::System.Text.StringBuilder sb, object value, global::System.TypeCode objTypeCode)
		{
			switch (objTypeCode)
			{
			case global::System.TypeCode.SByte:
				sb.AppendInvariant((int)((sbyte)value));
				return;
			case global::System.TypeCode.Byte:
				sb.AppendInvariant((int)((byte)value));
				return;
			case global::System.TypeCode.Int16:
				sb.AppendInvariant((int)((short)value));
				return;
			case global::System.TypeCode.UInt16:
				sb.AppendInvariant((int)((ushort)value));
				return;
			case global::System.TypeCode.Int32:
				sb.AppendInvariant((int)value);
				return;
			case global::System.TypeCode.UInt32:
				sb.AppendInvariant((uint)value);
				return;
			case global::System.TypeCode.Int64:
			{
				long num = (long)value;
				if (num < 2147483647L && num > -2147483648L)
				{
					sb.AppendInvariant((int)num);
					return;
				}
				sb.Append(num);
				return;
			}
			case global::System.TypeCode.UInt64:
			{
				ulong num2 = (ulong)value;
				if (num2 < (ulong)-1)
				{
					sb.AppendInvariant((uint)num2);
					return;
				}
				sb.Append(num2);
				return;
			}
			default:
				sb.Append(global::NLog.Internal.XmlHelper.XmlConvertToString(value, objTypeCode));
				return;
			}
		}

		// Token: 0x040003C4 RID: 964
		private static readonly char[] charToInt = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9'
		};
	}
}
