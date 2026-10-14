using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000524 RID: 1316
	public class VariantSupport : global::NPOI.HPSF.Variant
	{
		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600317F RID: 12671 RVA: 0x00095508 File Offset: 0x00093708
		// (set) Token: 0x06003180 RID: 12672 RVA: 0x0009550F File Offset: 0x0009370F
		public static bool IsLogUnsupportedTypes
		{
			get
			{
				return global::NPOI.HPSF.VariantSupport.logUnsupportedTypes;
			}
			set
			{
				global::NPOI.HPSF.VariantSupport.logUnsupportedTypes = value;
			}
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x00095518 File Offset: 0x00093718
		public static void WriteUnsupportedTypeMessage(global::NPOI.HPSF.UnsupportedVariantTypeException ex)
		{
			if (global::NPOI.HPSF.VariantSupport.IsLogUnsupportedTypes)
			{
				if (global::NPOI.HPSF.VariantSupport.unsupportedMessage == null)
				{
					global::NPOI.HPSF.VariantSupport.unsupportedMessage = new global::System.Collections.Generic.List<long>();
				}
				long variantType = ex.VariantType;
				if (!global::NPOI.HPSF.VariantSupport.unsupportedMessage.Contains(variantType))
				{
					global::System.Console.Error.WriteLine(ex.Message);
					global::NPOI.HPSF.VariantSupport.unsupportedMessage.Add(variantType);
				}
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0009556C File Offset: 0x0009376C
		public bool IsSupportedType(int variantType)
		{
			for (int i = 0; i < global::NPOI.HPSF.VariantSupport.SUPPORTED_TYPES.Length; i++)
			{
				if (variantType == global::NPOI.HPSF.VariantSupport.SUPPORTED_TYPES[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00095598 File Offset: 0x00093798
		public static object Read(byte[] src, int offset, int length, long type, int codepage)
		{
			global::NPOI.HPSF.TypedPropertyValue typedPropertyValue = new global::NPOI.HPSF.TypedPropertyValue((int)type, null);
			int num;
			try
			{
				num = typedPropertyValue.ReadValue(src, offset);
			}
			catch (global::System.InvalidOperationException)
			{
				int num2 = global::System.Math.Min(length, src.Length - offset);
				byte[] array = new byte[num2];
				global::System.Array.Copy(src, offset, array, 0, num2);
				throw new global::NPOI.HPSF.ReadingNotSupportedException(type, array);
			}
			int num3 = (int)type;
			if (num3 <= 20)
			{
				switch (num3)
				{
				case 0:
				case 3:
				case 5:
					break;
				case 1:
				case 4:
					goto IL_12A;
				case 2:
					return (short)typedPropertyValue.Value;
				default:
					if (num3 == 11)
					{
						return ((global::NPOI.HPSF.VariantBool)typedPropertyValue.Value).Value;
					}
					if (num3 != 20)
					{
						goto IL_12A;
					}
					break;
				}
				return typedPropertyValue.Value;
			}
			if (num3 <= 31)
			{
				if (num3 == 30)
				{
					return ((global::NPOI.HPSF.CodePageString)typedPropertyValue.Value).GetJavaValue(codepage);
				}
				if (num3 == 31)
				{
					return ((global::NPOI.HPSF.UnicodeString)typedPropertyValue.Value).ToJavaString();
				}
			}
			else
			{
				if (num3 == 64)
				{
					global::NPOI.HPSF.Filetime filetime = (global::NPOI.HPSF.Filetime)typedPropertyValue.Value;
					return global::NPOI.HPSF.Util.FiletimeToDate((int)filetime.High, (int)filetime.Low);
				}
				if (num3 == 71)
				{
					return ((global::NPOI.HPSF.ClipboardData)typedPropertyValue.Value).ToByteArray();
				}
			}
			IL_12A:
			byte[] array2 = new byte[num];
			global::System.Array.Copy(src, offset, array2, 0, num);
			throw new global::NPOI.HPSF.ReadingNotSupportedException(type, array2);
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x000956FC File Offset: 0x000938FC
		public static string CodepageToEncoding(int codepage)
		{
			return global::NPOI.Util.CodePageUtil.CodepageToEncoding(codepage);
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x00095704 File Offset: 0x00093904
		public static int Write(global::System.IO.Stream out1, long type, object value, int codepage)
		{
			int num = 0;
			int num2 = (int)type;
			if (num2 <= 20)
			{
				switch (num2)
				{
				case 0:
					num += global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, 0U);
					break;
				case 1:
				case 4:
					goto IL_248;
				case 2:
				{
					short n;
					try
					{
						n = global::System.Convert.ToInt16(value, global::System.Globalization.CultureInfo.InvariantCulture);
					}
					catch (global::System.OverflowException)
					{
						n = (short)((int)value);
					}
					num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, n);
					break;
				}
				case 3:
					if (!(value is int))
					{
						throw new global::System.Exception("Could not cast an object To int: " + value.GetType().Name + ", " + value.ToString());
					}
					num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, (int)value);
					break;
				case 5:
					num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, (double)value);
					break;
				default:
					if (num2 != 11)
					{
						if (num2 != 20)
						{
							goto IL_248;
						}
						num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.CurrentCulture));
					}
					else
					{
						new byte[2];
						if ((bool)value)
						{
							out1.WriteByte(byte.MaxValue);
							out1.WriteByte(byte.MaxValue);
						}
						else
						{
							out1.WriteByte(0);
							out1.WriteByte(0);
						}
						num += 2;
					}
					break;
				}
			}
			else if (num2 <= 31)
			{
				if (num2 != 30)
				{
					if (num2 != 31)
					{
						goto IL_248;
					}
					int n2 = ((string)value).Length + 1;
					num += global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)n2);
					char[] array = ((string)value).ToCharArray();
					for (int i = 0; i < array.Length; i++)
					{
						int num3 = (int)((array[i] & '＀') >> 8);
						byte b = (byte)(array[i] & 'ÿ');
						byte value2 = (byte)num3;
						byte value3 = b;
						out1.WriteByte(value3);
						out1.WriteByte(value2);
						num += 2;
					}
					out1.WriteByte(0);
					out1.WriteByte(0);
					num += 2;
				}
				else
				{
					global::NPOI.HPSF.CodePageString codePageString = new global::NPOI.HPSF.CodePageString((string)value, codepage);
					num += codePageString.Write(out1);
				}
			}
			else if (num2 != 64)
			{
				if (num2 != 71)
				{
					goto IL_248;
				}
				byte[] array2 = (byte[])value;
				out1.Write(array2, 0, array2.Length);
				num = array2.Length;
			}
			else
			{
				long num4;
				if (value != null)
				{
					num4 = global::NPOI.HPSF.Util.DateToFileTime((global::System.DateTime)value);
				}
				else
				{
					num4 = 0L;
				}
				int high = (int)(num4 >> 32 & (long)((ulong)-1));
				global::NPOI.HPSF.Filetime filetime = new global::NPOI.HPSF.Filetime((int)(num4 & (long)((ulong)-1)), high);
				num += filetime.Write(out1);
			}
			IL_28B:
			while ((num & 3) != 0)
			{
				out1.WriteByte(0);
				num++;
			}
			return num;
			IL_248:
			if (value is byte[])
			{
				byte[] array3 = (byte[])value;
				out1.Write(array3, 0, array3.Length);
				num = array3.Length;
				global::NPOI.HPSF.VariantSupport.WriteUnsupportedTypeMessage(new global::NPOI.HPSF.WritingNotSupportedException(type, value));
				goto IL_28B;
			}
			throw new global::NPOI.HPSF.WritingNotSupportedException(type, value);
		}

		// Token: 0x040015E6 RID: 5606
		private static bool logUnsupportedTypes = false;

		// Token: 0x040015E7 RID: 5607
		protected static global::System.Collections.Generic.List<long> unsupportedMessage;

		// Token: 0x040015E8 RID: 5608
		public static int[] SUPPORTED_TYPES = new int[]
		{
			0,
			2,
			3,
			20,
			5,
			64,
			30,
			31,
			71,
			11
		};
	}
}
