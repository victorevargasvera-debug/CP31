using System;
using System.IO;
using System.Text;

namespace DevAge.IO
{
	// Token: 0x020002B2 RID: 690
	internal static class StreamPersistence
	{
		// Token: 0x0600223E RID: 8766 RVA: 0x0007907C File Offset: 0x0007727C
		public static void Write(global::System.IO.Stream p_Stream, string p_Value, global::System.Text.Encoding encoding)
		{
			byte[] bytes = encoding.GetBytes(p_Value);
			global::DevAge.IO.StreamPersistence.Write(p_Stream, bytes);
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0007909C File Offset: 0x0007729C
		public static void Write(global::System.IO.Stream p_Stream, byte p_Value)
		{
			p_Stream.WriteByte(p_Value);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x000790A8 File Offset: 0x000772A8
		public static void Write(global::System.IO.Stream p_Stream, global::System.Guid p_Value)
		{
			byte[] p_Bytes = p_Value.ToByteArray();
			global::DevAge.IO.StreamPersistence.Write(p_Stream, p_Bytes);
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x000790C8 File Offset: 0x000772C8
		public static void Write(global::System.IO.Stream p_Stream, decimal p_Value)
		{
			int[] bits = decimal.GetBits(p_Value);
			global::DevAge.IO.StreamPersistence.Write(p_Stream, bits[0]);
			global::DevAge.IO.StreamPersistence.Write(p_Stream, bits[1]);
			global::DevAge.IO.StreamPersistence.Write(p_Stream, bits[2]);
			global::DevAge.IO.StreamPersistence.Write(p_Stream, bits[3]);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00079104 File Offset: 0x00077304
		public static void Write(global::System.IO.Stream p_Stream, global::System.DateTime p_Value)
		{
			global::DevAge.IO.StreamPersistence.Write(p_Stream, p_Value.ToOADate());
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00079114 File Offset: 0x00077314
		public static void Write(global::System.IO.Stream p_Stream, short p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00079124 File Offset: 0x00077324
		public static void Write(global::System.IO.Stream p_Stream, int p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00079134 File Offset: 0x00077334
		public static void Write(global::System.IO.Stream p_Stream, long p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00079144 File Offset: 0x00077344
		public static void Write(global::System.IO.Stream p_Stream, float p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00079154 File Offset: 0x00077354
		public static void Write(global::System.IO.Stream p_Stream, double p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00079164 File Offset: 0x00077364
		public static void Write(global::System.IO.Stream p_Stream, char p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00079174 File Offset: 0x00077374
		public static void Write(global::System.IO.Stream p_Stream, bool p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00079184 File Offset: 0x00077384
		[global::System.CLSCompliant(false)]
		public static void Write(global::System.IO.Stream p_Stream, ushort p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00079194 File Offset: 0x00077394
		[global::System.CLSCompliant(false)]
		public static void Write(global::System.IO.Stream p_Stream, uint p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x000791A4 File Offset: 0x000773A4
		[global::System.CLSCompliant(false)]
		public static void Write(global::System.IO.Stream p_Stream, ulong p_Value)
		{
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, global::System.BitConverter.GetBytes(p_Value));
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x000791B4 File Offset: 0x000773B4
		public static void Write(global::System.IO.Stream p_Stream, byte[] p_Bytes)
		{
			global::DevAge.IO.StreamPersistence.Write(p_Stream, p_Bytes.Length);
			global::DevAge.IO.StreamPersistence.WriteBytes(p_Stream, p_Bytes);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x000791C8 File Offset: 0x000773C8
		public static void Write(global::System.IO.Stream stream, global::System.Type valueType, object val)
		{
			if (valueType == typeof(string))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (string)val, global::System.Text.Encoding.UTF8);
				return;
			}
			if (valueType == typeof(short))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (short)val);
				return;
			}
			if (valueType == typeof(int))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (int)val);
				return;
			}
			if (valueType == typeof(long))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (long)val);
				return;
			}
			if (valueType == typeof(float))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (float)val);
				return;
			}
			if (valueType == typeof(double))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (double)val);
				return;
			}
			if (valueType == typeof(bool))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (bool)val);
				return;
			}
			if (valueType == typeof(decimal))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (decimal)val);
				return;
			}
			if (valueType == typeof(char))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (char)val);
				return;
			}
			if (valueType == typeof(byte))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (byte)val);
				return;
			}
			if (valueType == typeof(byte[]))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (byte[])val);
				return;
			}
			if (valueType == typeof(global::System.DateTime))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (global::System.DateTime)val);
				return;
			}
			if (valueType == typeof(global::System.Guid))
			{
				global::DevAge.IO.StreamPersistence.Write(stream, (global::System.Guid)val);
				return;
			}
			throw new global::DevAge.IO.TypeNotSupportedException(valueType);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00079360 File Offset: 0x00077560
		public static void WriteBytes(global::System.IO.Stream p_Stream, byte[] p_Bytes)
		{
			p_Stream.Write(p_Bytes, 0, p_Bytes.Length);
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00079370 File Offset: 0x00077570
		public static global::System.Guid ReadGuid(global::System.IO.Stream stream)
		{
			byte[] b = global::DevAge.IO.StreamPersistence.ReadByteArray(stream);
			global::System.Guid result = new global::System.Guid(b);
			return result;
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x00079394 File Offset: 0x00077594
		public static decimal ReadDecimal(global::System.IO.Stream stream)
		{
			int num = global::DevAge.IO.StreamPersistence.ReadInt32(stream);
			int num2 = global::DevAge.IO.StreamPersistence.ReadInt32(stream);
			int num3 = global::DevAge.IO.StreamPersistence.ReadInt32(stream);
			int num4 = global::DevAge.IO.StreamPersistence.ReadInt32(stream);
			decimal result = new decimal(new int[]
			{
				num,
				num2,
				num3,
				num4
			});
			return result;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x000793E8 File Offset: 0x000775E8
		public static global::System.DateTime ReadDateTime(global::System.IO.Stream p_Stream)
		{
			double d = global::DevAge.IO.StreamPersistence.ReadDouble(p_Stream);
			return global::System.DateTime.FromOADate(d);
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00079408 File Offset: 0x00077608
		public static float ReadSingle(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(0f);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToSingle(bytes, 0);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00079434 File Offset: 0x00077634
		public static double ReadDouble(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(0.0);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToDouble(bytes, 0);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00079464 File Offset: 0x00077664
		public static short ReadInt16(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(0);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToInt16(bytes, 0);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x0007948C File Offset: 0x0007768C
		public static int ReadInt32(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(0);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToInt32(bytes, 0);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x000794B4 File Offset: 0x000776B4
		public static long ReadInt64(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(0L);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToInt64(bytes, 0);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x000794E0 File Offset: 0x000776E0
		[global::System.CLSCompliant(false)]
		public static ushort ReadUInt16(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(0);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToUInt16(bytes, 0);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00079508 File Offset: 0x00077708
		[global::System.CLSCompliant(false)]
		public static uint ReadUInt32(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(0U);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToUInt32(bytes, 0);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00079530 File Offset: 0x00077730
		[global::System.CLSCompliant(false)]
		public static ulong ReadUInt64(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(0UL);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToUInt64(bytes, 0);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0007955C File Offset: 0x0007775C
		public static byte ReadByte(global::System.IO.Stream p_Stream)
		{
			int num = p_Stream.ReadByte();
			if (num == -1)
			{
				throw new global::DevAge.IO.InvalidDataException();
			}
			return (byte)num;
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00079584 File Offset: 0x00077784
		public static char ReadChar(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes('\0');
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToChar(bytes, 0);
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000795AC File Offset: 0x000777AC
		public static bool ReadBoolean(global::System.IO.Stream p_Stream)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(false);
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, bytes);
			return global::System.BitConverter.ToBoolean(bytes, 0);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x000795D4 File Offset: 0x000777D4
		public static string ReadString(global::System.IO.Stream p_Stream, global::System.Text.Encoding encoding)
		{
			byte[] bytes = global::DevAge.IO.StreamPersistence.ReadByteArray(p_Stream);
			return encoding.GetString(bytes);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x000795F8 File Offset: 0x000777F8
		public static byte[] ReadByteArray(global::System.IO.Stream p_Stream)
		{
			int num = global::DevAge.IO.StreamPersistence.ReadInt32(p_Stream);
			byte[] array = new byte[num];
			global::DevAge.IO.StreamPersistence.ReadBytes(p_Stream, array);
			return array;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00079620 File Offset: 0x00077820
		public static object Read(global::System.IO.Stream stream, global::System.Type valueType)
		{
			if (valueType == typeof(string))
			{
				return global::DevAge.IO.StreamPersistence.ReadString(stream, global::System.Text.Encoding.UTF8);
			}
			if (valueType == typeof(char))
			{
				return global::DevAge.IO.StreamPersistence.ReadChar(stream);
			}
			if (valueType == typeof(bool))
			{
				return global::DevAge.IO.StreamPersistence.ReadBoolean(stream);
			}
			if (valueType == typeof(decimal))
			{
				return global::DevAge.IO.StreamPersistence.ReadDecimal(stream);
			}
			if (valueType == typeof(short))
			{
				return global::DevAge.IO.StreamPersistence.ReadInt16(stream);
			}
			if (valueType == typeof(int))
			{
				return global::DevAge.IO.StreamPersistence.ReadInt32(stream);
			}
			if (valueType == typeof(long))
			{
				return global::DevAge.IO.StreamPersistence.ReadInt64(stream);
			}
			if (valueType == typeof(float))
			{
				return global::DevAge.IO.StreamPersistence.ReadSingle(stream);
			}
			if (valueType == typeof(double))
			{
				return global::DevAge.IO.StreamPersistence.ReadDouble(stream);
			}
			if (valueType == typeof(byte))
			{
				return global::DevAge.IO.StreamPersistence.ReadByte(stream);
			}
			if (valueType == typeof(byte[]))
			{
				return global::DevAge.IO.StreamPersistence.ReadByteArray(stream);
			}
			if (valueType == typeof(global::System.DateTime))
			{
				return global::DevAge.IO.StreamPersistence.ReadDateTime(stream);
			}
			if (valueType == typeof(global::System.Guid))
			{
				return global::DevAge.IO.StreamPersistence.ReadGuid(stream);
			}
			throw new global::DevAge.IO.TypeNotSupportedException(valueType);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000797A0 File Offset: 0x000779A0
		public static void ReadBytes(global::System.IO.Stream p_Stream, byte[] p_Value)
		{
			if (p_Stream.Read(p_Value, 0, p_Value.Length) != p_Value.Length)
			{
				throw new global::DevAge.IO.InvalidDataException();
			}
		}
	}
}
