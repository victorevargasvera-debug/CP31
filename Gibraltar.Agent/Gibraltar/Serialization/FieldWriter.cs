using System;
using System.IO;
using System.Text;
using Gibraltar.Data;
using Gibraltar.Serialization.Internal;

namespace Gibraltar.Serialization
{
	// Token: 0x020000F8 RID: 248
	internal class FieldWriter : global::Gibraltar.Serialization.IFieldWriter
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x0001951C File Offset: 0x0001771C
		internal FieldWriter(global::System.IO.Stream stream, global::Gibraltar.Serialization.UniqueStringList stringList, int majorVersion, int minorVersion)
		{
			this.m_Stream = stream;
			this.m_Encoding = new global::System.Text.UTF8Encoding();
			this.m_Strings = stringList;
			this.m_MajorVersion = majorVersion;
			this.m_MinorVersion = minorVersion;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0001954C File Offset: 0x0001774C
		public FieldWriter(global::System.IO.Stream stream) : this(stream, new global::Gibraltar.Serialization.UniqueStringList(), (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
			this.m_Stream = stream;
			this.m_Encoding = new global::System.Text.UTF8Encoding();
			this.m_Strings = new global::Gibraltar.Serialization.UniqueStringList();
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00019584 File Offset: 0x00017784
		public FieldWriter() : this(new global::System.IO.MemoryStream())
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00019594 File Offset: 0x00017794
		public long Position
		{
			get
			{
				return this.m_Stream.Position;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x000195A4 File Offset: 0x000177A4
		public long Length
		{
			get
			{
				return this.m_Stream.Length;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000195B4 File Offset: 0x000177B4
		public global::Gibraltar.Serialization.UniqueStringList Strings
		{
			get
			{
				return this.m_Strings;
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000195BC File Offset: 0x000177BC
		public void Commit()
		{
			this.m_Strings.Commit();
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000195CC File Offset: 0x000177CC
		public void Rollback()
		{
			this.m_Strings.Abort();
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000195DC File Offset: 0x000177DC
		public void Write(object value)
		{
			global::Gibraltar.Serialization.FieldType serializableType = global::Gibraltar.Serialization.PacketDefinition.GetSerializableType(value.GetType());
			this.Write((int)serializableType);
			this.Write(value, serializableType);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00019608 File Offset: 0x00017808
		public void Write(object value, global::Gibraltar.Serialization.FieldType fieldType)
		{
			switch (fieldType)
			{
			case global::Gibraltar.Serialization.FieldType.Bool:
				this.Write((bool)value);
				return;
			case global::Gibraltar.Serialization.FieldType.BoolArray:
				this.Write((bool[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.String:
				this.Write((string)value);
				return;
			case global::Gibraltar.Serialization.FieldType.StringArray:
				this.Write((string[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.Int32:
				this.Write(global::System.Convert.ToInt32(value));
				return;
			case global::Gibraltar.Serialization.FieldType.Int32Array:
				this.Write((int[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.Int64:
				this.Write(global::System.Convert.ToInt64(value));
				return;
			case global::Gibraltar.Serialization.FieldType.Int64Array:
				this.Write((long[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.UInt32:
				this.Write(global::System.Convert.ToUInt32(value));
				return;
			case global::Gibraltar.Serialization.FieldType.UInt32Array:
				this.Write((uint[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.UInt64:
				this.Write(global::System.Convert.ToUInt64(value));
				return;
			case global::Gibraltar.Serialization.FieldType.UInt64Array:
				this.Write((ulong[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.Double:
				this.Write(global::System.Convert.ToDouble(value));
				return;
			case global::Gibraltar.Serialization.FieldType.DoubleArray:
				this.Write((double[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.TimeSpan:
				this.Write((global::System.TimeSpan)value);
				return;
			case global::Gibraltar.Serialization.FieldType.TimeSpanArray:
				this.Write((global::System.TimeSpan[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.DateTime:
				this.Write((global::System.DateTime)value);
				return;
			case global::Gibraltar.Serialization.FieldType.DateTimeArray:
				this.Write((global::System.DateTime[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.Guid:
				this.Write((global::System.Guid)value);
				return;
			case global::Gibraltar.Serialization.FieldType.GuidArray:
				this.Write((global::System.Guid[])value);
				return;
			case global::Gibraltar.Serialization.FieldType.DateTimeOffset:
				this.Write((global::System.DateTimeOffset)value);
				return;
			case global::Gibraltar.Serialization.FieldType.DateTimeOffsetArray:
				this.Write((global::System.DateTimeOffset[])value);
				return;
			default:
				throw new global::System.ArgumentOutOfRangeException("value");
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000197A8 File Offset: 0x000179A8
		public void Write(bool value)
		{
			this.WriteByte(value ? 1 : 0);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000197C0 File Offset: 0x000179C0
		public void Write(bool[] array)
		{
			int[] array2 = new int[(array.Length + 31) / 32];
			int num = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				int num2 = 0;
				while (num2 < 32 && num < array.Length)
				{
					array2[i] <<= 1;
					if (array[num])
					{
						array2[i] |= 1;
					}
					num++;
					num2++;
				}
			}
			this.Write((uint)array.Length);
			this.Write(array2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00019840 File Offset: 0x00017A40
		public void Write(string value)
		{
			if (this.m_MajorVersion > 1)
			{
				this.WriteString(value);
				return;
			}
			if (value == null)
			{
				this.WriteByte(0);
				return;
			}
			int num = this.m_Strings.Count + 1;
			int num2 = this.m_Strings.AddOrGet(value) + 1;
			this.Write((uint)num2);
			if (num2 == num)
			{
				this.WriteString(value);
				return;
			}
			if (num2 > num)
			{
				throw new global::Gibraltar.GibraltarException("Something went wrong with string serialization, we got a bogus index from our string table: " + num2);
			}
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000198C4 File Offset: 0x00017AC4
		public void Write(string[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.StringArrayWriter.Write(array, this);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000198D4 File Offset: 0x00017AD4
		public void Write(int value)
		{
			byte b;
			if (value < 0)
			{
				b = 128;
				value = -value;
			}
			else
			{
				b = 0;
			}
			uint num = (uint)value;
			b |= (byte)(num & 63U);
			num >>= 6;
			if (num == 0U)
			{
				this.WriteByte(b);
				return;
			}
			b |= 64;
			this.WriteByte(b);
			while (num >= 128U)
			{
				this.WriteByte((byte)(num | 128U));
				num >>= 7;
			}
			this.WriteByte((byte)num);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00019950 File Offset: 0x00017B50
		public void Write(int[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.Int32ArrayWriter.Write(array, this);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00019960 File Offset: 0x00017B60
		public void Write(long value)
		{
			byte b;
			if (value < 0L)
			{
				b = 128;
				value = -value;
			}
			else
			{
				b = 0;
			}
			ulong num = (ulong)value;
			b |= (byte)(num & 63UL);
			num >>= 6;
			if (num == 0UL)
			{
				this.WriteByte(b);
				return;
			}
			b |= 64;
			this.WriteByte(b);
			while (num >= 128UL)
			{
				this.WriteByte((byte)(num | 128UL));
				num >>= 7;
			}
			this.WriteByte((byte)num);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000199E0 File Offset: 0x00017BE0
		public void Write(long[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.Int64ArrayWriter.Write(array, this);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000199F0 File Offset: 0x00017BF0
		public void Write(uint value)
		{
			while (value >= 128U)
			{
				this.WriteByte((byte)(value | 128U));
				value >>= 7;
			}
			this.WriteByte((byte)value);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00019A1C File Offset: 0x00017C1C
		public void Write(uint[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.UInt32ArrayWriter.Write(array, this);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00019A2C File Offset: 0x00017C2C
		public void Write(ulong value)
		{
			int num = 0;
			while (num < 8 && value >= 128UL)
			{
				this.WriteByte((byte)(value | 128UL));
				value >>= 7;
				num++;
			}
			this.WriteByte((byte)value);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00019A74 File Offset: 0x00017C74
		public static global::System.IO.MemoryStream WriteLength(long length)
		{
			byte[] array = new byte[9];
			int num = 0;
			while (num < 8 && length >= 128L)
			{
				array[num] = (byte)(length | 128L);
				length >>= 7;
				num++;
			}
			array[num++] = (byte)length;
			return new global::System.IO.MemoryStream(array, 0, num);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00019ACC File Offset: 0x00017CCC
		public void Write(ulong[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.UInt64ArrayWriter.Write(array, this);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00019ADC File Offset: 0x00017CDC
		public void Write(double value)
		{
			ulong num = (ulong)global::System.BitConverter.DoubleToInt64Bits(value);
			if (num == 0UL)
			{
				this.WriteByte(0);
				return;
			}
			int num2 = 0;
			while (num2 < 8 && num != 0UL)
			{
				byte b = (byte)((num & 18302628885633695744UL) >> 57);
				num <<= 7;
				if (num != 0UL)
				{
					b |= 128;
				}
				this.WriteByte(b);
				num2++;
			}
			if (num != 0UL)
			{
				this.WriteByte((byte)(num >> 56));
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00019B54 File Offset: 0x00017D54
		public void Write(double[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.DoubleArrayWriter.Write(array, this);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00019B64 File Offset: 0x00017D64
		public void Write(global::System.TimeSpan value)
		{
			this.Write((ulong)value.Ticks);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00019B74 File Offset: 0x00017D74
		public void Write(global::System.TimeSpan[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.TimeSpanArrayWriter.Write(array, this);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00019B84 File Offset: 0x00017D84
		public void Write(global::System.DateTime value)
		{
			this.Write(new global::System.DateTimeOffset(value));
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00019B94 File Offset: 0x00017D94
		public void Write(global::System.DateTimeOffset value)
		{
			this.Write((int)value.Offset.TotalMinutes);
			if (this.m_Strings.ReferenceTime == global::System.DateTime.MinValue)
			{
				this.m_Strings.ReferenceTime = value.DateTime;
				this.WriteByte(1);
				this.Write((ulong)value.Ticks);
				return;
			}
			global::System.TimeSpan timeSpan = value.DateTime - this.m_Strings.ReferenceTime;
			if (timeSpan.Ticks < 0L)
			{
				this.WriteByte(5);
				this.Write((ulong)(-(ulong)timeSpan.Ticks));
				return;
			}
			this.WriteByte(4);
			this.Write((ulong)timeSpan.Ticks);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00019C4C File Offset: 0x00017E4C
		public void Write(global::System.DateTime[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.DateTimeArrayWriter.Write(array, this);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00019C5C File Offset: 0x00017E5C
		public void Write(global::System.DateTimeOffset[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.DateTimeOffsetArrayWriter.Write(array, this);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00019C6C File Offset: 0x00017E6C
		public void WriteTimestamp(global::System.DateTime value)
		{
			global::System.DateTime dateTime = value.ToUniversalTime();
			if (this.m_Strings.ReferenceTime == global::System.DateTime.MinValue)
			{
				this.m_Strings.ReferenceTime = dateTime;
				this.Write(global::System.TimeSpan.Zero.Ticks);
				this.Write(dateTime.Ticks);
				return;
			}
			global::System.TimeSpan timeSpan = dateTime - this.m_Strings.ReferenceTime;
			this.Write(timeSpan.Ticks);
			if (timeSpan.Ticks == 0L)
			{
				this.Write(0L);
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00019D00 File Offset: 0x00017F00
		public void WriteTimestamp(global::System.DateTime[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.DateTimeArrayWriter.Write(array, this);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00019D10 File Offset: 0x00017F10
		public void Write(global::System.Guid value)
		{
			byte[] values = value.ToByteArray();
			this.WriteBytes(values);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00019D30 File Offset: 0x00017F30
		public void Write(global::System.Guid[] array)
		{
			global::Gibraltar.Serialization.FieldWriter.GuidArrayWriter.Write(array, this);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00019D40 File Offset: 0x00017F40
		public byte[] ToArray()
		{
			global::System.IO.MemoryStream memoryStream = this.m_Stream as global::System.IO.MemoryStream;
			if (memoryStream != null)
			{
				return memoryStream.ToArray();
			}
			return null;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00019D6C File Offset: 0x00017F6C
		private void WriteByte(byte value)
		{
			this.m_Stream.WriteByte(value);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00019D7C File Offset: 0x00017F7C
		private void WriteBytes(byte[] values)
		{
			this.m_Stream.Write(values, 0, values.Length);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00019D90 File Offset: 0x00017F90
		private void WriteString(string value)
		{
			if (value == null)
			{
				this.WriteByte(1);
				this.WriteByte(0);
				return;
			}
			if (value.Length == 0)
			{
				this.WriteByte(0);
				return;
			}
			byte[] bytes = this.m_Encoding.GetBytes(value);
			this.Write((uint)bytes.Length);
			this.m_Stream.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x040002D7 RID: 727
		private readonly global::System.IO.Stream m_Stream;

		// Token: 0x040002D8 RID: 728
		private readonly global::System.Text.Encoding m_Encoding;

		// Token: 0x040002D9 RID: 729
		private readonly global::Gibraltar.Serialization.UniqueStringList m_Strings;

		// Token: 0x040002DA RID: 730
		private readonly int m_MajorVersion;

		// Token: 0x040002DB RID: 731
		private readonly int m_MinorVersion;

		// Token: 0x040002DC RID: 732
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<string> StringArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<string>();

		// Token: 0x040002DD RID: 733
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<int> Int32ArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<int>();

		// Token: 0x040002DE RID: 734
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<long> Int64ArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<long>();

		// Token: 0x040002DF RID: 735
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<uint> UInt32ArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<uint>();

		// Token: 0x040002E0 RID: 736
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<ulong> UInt64ArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<ulong>();

		// Token: 0x040002E1 RID: 737
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<double> DoubleArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<double>();

		// Token: 0x040002E2 RID: 738
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.TimeSpan> TimeSpanArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.TimeSpan>();

		// Token: 0x040002E3 RID: 739
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.DateTime> DateTimeArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.DateTime>();

		// Token: 0x040002E4 RID: 740
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.DateTimeOffset> DateTimeOffsetArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.DateTimeOffset>();

		// Token: 0x040002E5 RID: 741
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.Guid> GuidArrayWriter = new global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.Guid>();
	}
}
