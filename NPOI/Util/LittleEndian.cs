using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000279 RID: 633
	public class LittleEndian : global::NPOI.Util.LittleEndianConsts
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x000336D1 File Offset: 0x000318D1
		private LittleEndian()
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x000336DC File Offset: 0x000318DC
		public static short GetShort(byte[] data, int offset)
		{
			int num = (int)(data[offset] & byte.MaxValue);
			return (short)(((int)(data[offset + 1] & byte.MaxValue) << 8) + num);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00033704 File Offset: 0x00031904
		public static int GetUShort(byte[] data, int offset)
		{
			int num = (int)(data[offset] & byte.MaxValue);
			return ((int)(data[offset + 1] & byte.MaxValue) << 8) + num;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0003372A File Offset: 0x0003192A
		public static short GetShort(byte[] data)
		{
			return global::NPOI.Util.LittleEndian.GetShort(data, 0);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00033733 File Offset: 0x00031933
		public static int GetUShort(byte[] data)
		{
			return global::NPOI.Util.LittleEndian.GetUShort(data, 0);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0003373C File Offset: 0x0003193C
		public static int GetInt(byte[] data, int offset)
		{
			int num = offset + 1;
			int num2 = (int)(data[offset] & byte.MaxValue);
			int num3 = (int)(data[num++] & byte.MaxValue);
			int num4 = (int)(data[num++] & byte.MaxValue);
			return ((int)(data[num++] & byte.MaxValue) << 24) + (num4 << 16) + (num3 << 8) + num2;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00033790 File Offset: 0x00031990
		public static int GetInt(byte[] data)
		{
			return global::NPOI.Util.LittleEndian.GetInt(data, 0);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00033799 File Offset: 0x00031999
		public static long GetUInt(byte[] data, int offset)
		{
			return (long)global::NPOI.Util.LittleEndian.GetInt(data, offset) & (long)((ulong)-1);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x000337A6 File Offset: 0x000319A6
		public static long GetUInt(byte[] data)
		{
			return global::NPOI.Util.LittleEndian.GetUInt(data, 0);
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x000337B0 File Offset: 0x000319B0
		public static long GetLong(byte[] data, int offset)
		{
			long num = 0L;
			for (int i = offset + 8 - 1; i >= offset; i--)
			{
				num <<= 8;
				num |= (long)(255UL & (ulong)data[i]);
			}
			return num;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x000337E3 File Offset: 0x000319E3
		public static double GetDouble(byte[] data, int offset)
		{
			return global::System.BitConverter.Int64BitsToDouble(global::NPOI.Util.LittleEndian.GetLong(data, offset));
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x000337F4 File Offset: 0x000319F4
		public static void PutShort(byte[] data, int offset, short value)
		{
			int num = offset + 1;
			data[offset] = (byte)(value & 255);
			data[num++] = (byte)(value >> 8 & 255);
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00033823 File Offset: 0x00031A23
		public static void PutByte(byte[] data, int offset, int value)
		{
			data[offset] = (byte)value;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0003382A File Offset: 0x00031A2A
		public static void PutUByte(byte[] data, int offset, short value)
		{
			data[offset] = (byte)(value & 255);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00033838 File Offset: 0x00031A38
		public static void PutUShort(byte[] data, int offset, int value)
		{
			int num = offset + 1;
			data[offset] = (byte)(value & 255);
			data[num++] = (byte)(value >> 8 & 255);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00033867 File Offset: 0x00031A67
		public static void PutShort(global::System.IO.Stream outputStream, short value)
		{
			outputStream.WriteByte((byte)(value & 255));
			outputStream.WriteByte((byte)(value >> 8 & 255));
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00033888 File Offset: 0x00031A88
		public static void PutInt(byte[] data, int offset, int value)
		{
			int num = offset + 1;
			data[offset] = (byte)(value & 255);
			data[num++] = (byte)(value >> 8 & 255);
			data[num++] = (byte)(value >> 16 & 255);
			data[num++] = (byte)(value >> 24 & 255);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000338DC File Offset: 0x00031ADC
		public static void PutInt(int value, global::System.IO.Stream outputStream)
		{
			outputStream.WriteByte((byte)(value & 255));
			outputStream.WriteByte((byte)(value >> 8 & 255));
			outputStream.WriteByte((byte)(value >> 16 & 255));
			outputStream.WriteByte((byte)(value >> 24 & 255));
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0003392C File Offset: 0x00031B2C
		public static void PutLong(byte[] data, int offset, long value)
		{
			int num = 8 + offset;
			long num2 = value;
			for (int i = offset; i < num; i++)
			{
				data[i] = (byte)(num2 & 255L);
				num2 >>= 8;
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0003395C File Offset: 0x00031B5C
		public static void PutDouble(byte[] data, int offset, double value)
		{
			long value2;
			if (double.IsNaN(value))
			{
				value2 = -276939487313920L;
			}
			else
			{
				value2 = global::System.BitConverter.DoubleToInt64Bits(value);
			}
			global::NPOI.Util.LittleEndian.PutLong(data, offset, value2);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0003398F File Offset: 0x00031B8F
		public static short ReadShort(global::System.IO.Stream stream)
		{
			return (short)global::NPOI.Util.LittleEndian.ReadUShort(stream);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00033998 File Offset: 0x00031B98
		public static int ReadUShort(global::System.IO.Stream stream)
		{
			int num = stream.ReadByte();
			int num2 = stream.ReadByte();
			if ((num | num2) < 0)
			{
				throw new global::NPOI.Util.BufferUnderrunException();
			}
			return (num2 << 8) + num;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x000339C4 File Offset: 0x00031BC4
		public static int ReadInt(global::System.IO.Stream stream)
		{
			int num = stream.ReadByte();
			int num2 = stream.ReadByte();
			int num3 = stream.ReadByte();
			int num4 = stream.ReadByte();
			if ((num | num2 | num3 | num4) < 0)
			{
				throw new global::NPOI.Util.BufferUnderrunException();
			}
			return (num4 << 24) + (num3 << 16) + (num2 << 8) + num;
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00033A0C File Offset: 0x00031C0C
		public static long ReadLong(global::System.IO.Stream stream)
		{
			int num = stream.ReadByte();
			int num2 = stream.ReadByte();
			int num3 = stream.ReadByte();
			int num4 = stream.ReadByte();
			int num5 = stream.ReadByte();
			int num6 = stream.ReadByte();
			int num7 = stream.ReadByte();
			int num8 = stream.ReadByte();
			if ((num | num2 | num3 | num4 | num5 | num6 | num7 | num8) < 0)
			{
				throw new global::NPOI.Util.BufferUnderrunException();
			}
			return ((long)num8 << 56) + ((long)num7 << 48) + ((long)num6 << 40) + ((long)num5 << 32) + ((long)num4 << 24) + (long)((long)num3 << 16) + (long)((long)num2 << 8) + (long)num;
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00033AA0 File Offset: 0x00031CA0
		public static int UByteToInt(byte b)
		{
			if ((b & 128) == 0)
			{
				return (int)b;
			}
			return (int)((b & 127) + 128);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00033AB8 File Offset: 0x00031CB8
		public static byte[] GetByteArray(byte[] data, int offset, int size)
		{
			byte[] array = new byte[size];
			global::System.Array.Copy(data, offset, array, 0, size);
			return array;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00033AD7 File Offset: 0x00031CD7
		[global::System.Obsolete]
		public static double GetDouble(byte[] data)
		{
			return global::NPOI.Util.LittleEndian.GetDouble(data, 0);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00033AE0 File Offset: 0x00031CE0
		[global::System.Obsolete]
		public static long GetLong(byte[] data)
		{
			return global::NPOI.Util.LittleEndian.GetLong(data, 0);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00033AE9 File Offset: 0x00031CE9
		[global::System.Obsolete]
		public static ulong GetULong(byte[] data)
		{
			return global::NPOI.Util.LittleEndian.GetULong(data, 0);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00033AF2 File Offset: 0x00031CF2
		[global::System.Obsolete]
		public static ulong GetULong(byte[] data, int offset)
		{
			return global::System.BitConverter.ToUInt64(data, offset);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00033AFC File Offset: 0x00031CFC
		private static long GetNumber(byte[] data, int offset, int size)
		{
			long num = 0L;
			for (int i = offset + size - 1; i >= offset; i--)
			{
				num <<= 8;
				num |= (long)(255UL & (ulong)data[i]);
			}
			return num;
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00033B2F File Offset: 0x00031D2F
		public static short GetUByte(byte[] data)
		{
			return (short)(data[0] & byte.MaxValue);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00033B3B File Offset: 0x00031D3B
		public static short GetUByte(byte[] data, int offset)
		{
			return (short)(data[offset] & byte.MaxValue);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00033B47 File Offset: 0x00031D47
		[global::System.Obsolete]
		public static void PutDouble(byte[] data, double value)
		{
			global::NPOI.Util.LittleEndian.PutDouble(data, 0, value);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00033B51 File Offset: 0x00031D51
		public static void PutDouble(double value, global::System.IO.Stream outputStream)
		{
			global::NPOI.Util.LittleEndian.PutLong(global::System.BitConverter.DoubleToInt64Bits(value), outputStream);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00033B60 File Offset: 0x00031D60
		public static void PutUInt(long value, global::System.IO.Stream outputStream)
		{
			outputStream.WriteByte((byte)(value & 255L));
			outputStream.WriteByte((byte)(value >> 8 & 255L));
			outputStream.WriteByte((byte)(value >> 16 & 255L));
			outputStream.WriteByte((byte)(value >> 24 & 255L));
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00033BB1 File Offset: 0x00031DB1
		[global::System.Obsolete]
		public static void PutUInt(byte[] data, int offset, uint value)
		{
			global::NPOI.Util.LittleEndian.PutNumber(data, offset, global::System.Convert.ToInt64(value), 4);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00033BC4 File Offset: 0x00031DC4
		public static void PutUInt(byte[] data, int offset, long value)
		{
			int num = offset + 1;
			data[offset] = (byte)(value & 255L);
			data[num++] = (byte)(value >> 8 & 255L);
			data[num++] = (byte)(value >> 16 & 255L);
			data[num++] = (byte)(value >> 24 & 255L);
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00033C1B File Offset: 0x00031E1B
		[global::System.Obsolete]
		public static void PutLong(byte[] data, long value)
		{
			global::NPOI.Util.LittleEndian.PutLong(data, 0, value);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00033C28 File Offset: 0x00031E28
		public static void PutLong(long value, global::System.IO.Stream outputStream)
		{
			outputStream.WriteByte((byte)(value & 255L));
			outputStream.WriteByte((byte)(value >> 8 & 255L));
			outputStream.WriteByte((byte)(value >> 16 & 255L));
			outputStream.WriteByte((byte)(value >> 24 & 255L));
			outputStream.WriteByte((byte)(value >> 32 & 255L));
			outputStream.WriteByte((byte)(value >> 40 & 255L));
			outputStream.WriteByte((byte)(value >> 48 & 255L));
			outputStream.WriteByte((byte)(value >> 56 & 255L));
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00033CC1 File Offset: 0x00031EC1
		[global::System.Obsolete]
		public static void PutULong(byte[] data, ulong value)
		{
			global::NPOI.Util.LittleEndian.PutULong(data, 0, value);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00033CCB File Offset: 0x00031ECB
		[global::System.Obsolete]
		public static void PutULong(byte[] data, int offset, ulong value)
		{
			global::NPOI.Util.LittleEndian.PutNumber(data, offset, value, 8);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00033CD8 File Offset: 0x00031ED8
		private static void PutNumber(byte[] data, int offset, long value, int size)
		{
			int num = size + offset;
			long num2 = value;
			for (int i = offset; i < num; i++)
			{
				data[i] = (byte)(num2 & 255L);
				num2 >>= 8;
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00033D08 File Offset: 0x00031F08
		private static void PutNumber(byte[] data, int offset, ulong value, int size)
		{
			int num = size + offset;
			ulong num2 = value;
			for (int i = offset; i < num; i++)
			{
				data[i] = (byte)(num2 & 255UL);
				num2 >>= 8;
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00033D38 File Offset: 0x00031F38
		[global::System.Obsolete]
		public static void PutShortArray(byte[] data, int offset, short[] value)
		{
			global::NPOI.Util.LittleEndian.PutNumber(data, offset, global::System.Convert.ToInt64(value.Length), 2);
			for (int i = 0; i < value.Length; i++)
			{
				global::NPOI.Util.LittleEndian.PutNumber(data, offset + 2 + i * 2, global::System.Convert.ToInt64(value[i]), 2);
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00033D79 File Offset: 0x00031F79
		[global::System.Obsolete]
		public static void PutUShort(byte[] data, int value)
		{
			global::NPOI.Util.LittleEndian.PutNumber(data, 0, global::System.Convert.ToInt64(value), 2);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00033D89 File Offset: 0x00031F89
		public static void PutUShort(int value, global::System.IO.Stream outputStream)
		{
			outputStream.WriteByte((byte)(value & 255));
			outputStream.WriteByte((byte)(value >> 8 & 255));
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00033DAC File Offset: 0x00031FAC
		[global::System.Obsolete]
		public static byte[] ReadFromStream(global::System.IO.Stream stream, int size)
		{
			byte[] array = new byte[size];
			int num = stream.Read(array, 0, array.Length);
			if (num == 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = 0;
				}
				return array;
			}
			if (num != size)
			{
				throw new global::NPOI.Util.BufferUnderrunException();
			}
			return array;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00033DEE File Offset: 0x00031FEE
		[global::System.Obsolete]
		public static ulong ReadULong(global::System.IO.Stream stream)
		{
			return global::System.BitConverter.ToUInt64(global::NPOI.Util.LittleEndian.ReadFromStream(stream, 8), 0);
		}
	}
}
