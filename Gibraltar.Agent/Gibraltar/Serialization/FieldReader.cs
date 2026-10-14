using System;
using System.Globalization;
using System.IO;
using System.Text;
using Gibraltar.Data;
using Gibraltar.Serialization.Internal;

namespace Gibraltar.Serialization
{
	// Token: 0x020000F5 RID: 245
	internal class FieldReader : global::Gibraltar.Serialization.IFieldReader
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x000189D4 File Offset: 0x00016BD4
		public FieldReader(global::System.IO.Stream stream, global::Gibraltar.Serialization.UniqueStringList stringList, int majorVersion, int minorVersion)
		{
			this.m_Stream = stream;
			this.m_Encoding = new global::System.Text.UTF8Encoding();
			this.m_Strings = stringList;
			this.m_MajorVersion = majorVersion;
			this.m_MinorVersion = minorVersion;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00018A04 File Offset: 0x00016C04
		public FieldReader(global::System.IO.Stream stream) : this(stream, new global::Gibraltar.Serialization.UniqueStringList(), (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00018A1C File Offset: 0x00016C1C
		public FieldReader(byte[] data) : this(new global::System.IO.MemoryStream(data))
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00018A2C File Offset: 0x00016C2C
		public FieldReader(byte[] data, global::Gibraltar.Serialization.UniqueStringList stringList) : this(new global::System.IO.MemoryStream(data), stringList, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00018A48 File Offset: 0x00016C48
		public void ReplaceStream(global::System.IO.Stream newStream)
		{
			this.m_Stream = newStream;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00018A54 File Offset: 0x00016C54
		public global::Gibraltar.Serialization.UniqueStringList Strings
		{
			get
			{
				return this.m_Strings;
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00018A5C File Offset: 0x00016C5C
		public ulong PeekUInt64()
		{
			long position = this.m_Stream.Position;
			ulong result;
			try
			{
				result = this.ReadUInt64();
			}
			finally
			{
				this.m_Stream.Position = position;
			}
			return result;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00018AA0 File Offset: 0x00016CA0
		public bool ReadBool()
		{
			return this.ReadByte() > 0;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00018AAC File Offset: 0x00016CAC
		public bool[] ReadBoolArray()
		{
			int num = (int)this.ReadUInt32();
			bool[] array = new bool[num];
			int[] array2 = this.ReadInt32Array();
			int num2 = 0;
			int minValue = int.MinValue;
			foreach (int num3 in array2)
			{
				if (num - num2 < 32)
				{
					int num4 = 32 - num % 32;
					num3 <<= num4;
				}
				int num5 = 0;
				while (num5 < 32 & num2 < num)
				{
					array[num2] = ((num3 & minValue) == minValue);
					num2++;
					num3 <<= 1;
					num5++;
				}
			}
			return array;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00018B48 File Offset: 0x00016D48
		public string ReadString()
		{
			if (this.m_MajorVersion > 1)
			{
				return this.ReadStringDirect();
			}
			int num = (int)this.ReadUInt32();
			if (num == 0)
			{
				return null;
			}
			string text;
			if (--num == this.m_Strings.Count)
			{
				text = this.ReadStringDirect();
				this.m_Strings.AddOrGet(text);
			}
			else
			{
				text = this.m_Strings[num];
				this.CompensateForPossibleSerializationError(text);
			}
			return text;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00018BC0 File Offset: 0x00016DC0
		private void CompensateForPossibleSerializationError(string stringValue)
		{
			if (!string.IsNullOrEmpty(stringValue))
			{
				long position = this.m_Stream.Position;
				bool flag = true;
				try
				{
					long num = this.m_Stream.Length - position;
					if ((long)stringValue.Length <= num)
					{
						uint num2 = this.ReadUInt32();
						if ((ulong)num2 == (ulong)((long)stringValue.Length))
						{
							byte[] array = new byte[num2];
							if ((long)this.m_Stream.Read(array, 0, (int)num2) == (long)((ulong)num2))
							{
								string @string = this.m_Encoding.GetString(array);
								if (string.Equals(stringValue, @string))
								{
									flag = false;
								}
							}
						}
					}
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
				finally
				{
					if (flag)
					{
						this.m_Stream.Position = position;
					}
				}
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00018C94 File Offset: 0x00016E94
		public string[] ReadStringArray()
		{
			return global::Gibraltar.Serialization.FieldReader.StringArrayReader.Read(this);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00018CA4 File Offset: 0x00016EA4
		public int ReadInt32()
		{
			byte b = this.ReadByte();
			int num = (int)(b & 63);
			int num2 = 6;
			if ((b & 64) != 0)
			{
				byte b2;
				do
				{
					b2 = this.ReadByte();
					num |= (int)(b2 & 127) << num2;
					num2 += 7;
				}
				while ((b2 & 128) != 0);
			}
			if ((b & 128) == 0)
			{
				return num;
			}
			return -num;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00018CFC File Offset: 0x00016EFC
		public int[] ReadInt32Array()
		{
			return global::Gibraltar.Serialization.FieldReader.Int32ArrayReader.Read(this);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00018D0C File Offset: 0x00016F0C
		public long ReadInt64()
		{
			byte b = this.ReadByte();
			ulong num = (ulong)((long)(b & 63));
			int num2 = 6;
			if ((b & 64) != 0)
			{
				byte b2;
				do
				{
					b2 = this.ReadByte();
					num |= (ulong)((ulong)((long)(b2 & 127)) << num2);
					num2 += 7;
				}
				while ((b2 & 128) != 0);
			}
			if ((b & 128) == 0)
			{
				return (long)num;
			}
			return (long)(-(long)num);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00018D68 File Offset: 0x00016F68
		public long[] ReadInt64Array()
		{
			return global::Gibraltar.Serialization.FieldReader.Int64ArrayReader.Read(this);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00018D78 File Offset: 0x00016F78
		public uint ReadUInt32()
		{
			uint num = 0U;
			int num2 = 0;
			byte b;
			do
			{
				b = this.ReadByte();
				num |= (uint)((uint)(b & 127) << num2);
				num2 += 7;
			}
			while ((b & 128) != 0);
			return num;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00018DB0 File Offset: 0x00016FB0
		public uint[] ReadUInt32Array()
		{
			return global::Gibraltar.Serialization.FieldReader.UInt32ArrayReader.Read(this);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00018DC0 File Offset: 0x00016FC0
		public ulong ReadUInt64()
		{
			ulong num = 0UL;
			int num2 = 0;
			byte b;
			do
			{
				b = this.ReadByte();
				if (num2 >= 56)
				{
					goto IL_34;
				}
				num |= ((ulong)b & 127UL) << num2;
				num2 += 7;
			}
			while ((b & 128) != 0);
			return num;
			IL_34:
			num |= ((ulong)b & 255UL) << 56;
			return num;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00018E18 File Offset: 0x00017018
		public ulong[] ReadUInt64Array()
		{
			return global::Gibraltar.Serialization.FieldReader.UInt64ArrayReader.Read(this);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00018E28 File Offset: 0x00017028
		public double ReadDouble()
		{
			ulong num = 0UL;
			int num2 = 0;
			byte b;
			do
			{
				b = this.ReadByte();
				if (num2 >= 56)
				{
					goto IL_3B;
				}
				num = (num << 7 | ((ulong)b & 127UL));
				num2 += 7;
			}
			while ((b & 128) != 0);
			num <<= 64 - num2;
			goto IL_49;
			IL_3B:
			num = (num << 8 | ((ulong)b & 255UL));
			IL_49:
			return global::System.BitConverter.Int64BitsToDouble((long)num);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00018E88 File Offset: 0x00017088
		public double[] ReadDoubleArray()
		{
			return global::Gibraltar.Serialization.FieldReader.DoubleArrayReader.Read(this);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00018E98 File Offset: 0x00017098
		public global::System.TimeSpan ReadTimeSpan()
		{
			long ticks = (long)this.ReadUInt64();
			return new global::System.TimeSpan(ticks);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00018EB8 File Offset: 0x000170B8
		public global::System.TimeSpan[] ReadTimeSpanArray()
		{
			return global::Gibraltar.Serialization.FieldReader.TimeSpanArrayReader.Read(this);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00018EC8 File Offset: 0x000170C8
		public global::System.DateTime ReadDateTime()
		{
			return this.ReadDateTimeOffset().DateTime;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00018EE8 File Offset: 0x000170E8
		public global::System.DateTimeOffset ReadDateTimeOffset()
		{
			int minutes = this.ReadInt32();
			global::System.TimeSpan offset = new global::System.TimeSpan(0, minutes, 0);
			global::Gibraltar.Serialization.DateTimeEncoding dateTimeEncoding;
			long num;
			long num2;
			for (;;)
			{
				dateTimeEncoding = (global::Gibraltar.Serialization.DateTimeEncoding)this.ReadByte();
				num = (long)this.ReadUInt64();
				switch (dateTimeEncoding)
				{
				case global::Gibraltar.Serialization.DateTimeEncoding.RawTicks:
					goto IL_3A;
				case global::Gibraltar.Serialization.DateTimeEncoding.NewReference:
					goto IL_46;
				case global::Gibraltar.Serialization.DateTimeEncoding.SetFactor:
					num2 = num;
					this.m_Strings.GenericFactor = num2;
					continue;
				case global::Gibraltar.Serialization.DateTimeEncoding.SetReference:
					num *= 10000000L;
					this.m_Strings.ReferenceTime = new global::System.DateTimeOffset(num, offset).DateTime;
					continue;
				}
				break;
			}
			if ((dateTimeEncoding & global::Gibraltar.Serialization.DateTimeEncoding.NewReference) != global::Gibraltar.Serialization.DateTimeEncoding.RawTicks)
			{
				num = -num;
			}
			switch (dateTimeEncoding)
			{
			case global::Gibraltar.Serialization.DateTimeEncoding.RawTicks:
			case global::Gibraltar.Serialization.DateTimeEncoding.NewReference:
			case global::Gibraltar.Serialization.DateTimeEncoding.SetFactor:
			case global::Gibraltar.Serialization.DateTimeEncoding.SetReference:
				throw new global::System.ArgumentOutOfRangeException();
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicksNet:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicksNet:
				num2 = 1L;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicksFactor:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicksFactor:
				num2 = this.m_Strings.GenericFactor;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicks1s:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicks1s:
				num2 = 10000000L;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicks100ms:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicks100ms:
				num2 = 1000000L;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicks16ms:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicks16ms:
				num2 = 160000L;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicks10ms:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicks10ms:
				num2 = 100000L;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicks1ms:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicks1ms:
				num2 = 10000L;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicks100us:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicks100us:
				num2 = 1000L;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicks10us:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicks10us:
				num2 = 100L;
				break;
			case global::Gibraltar.Serialization.DateTimeEncoding.LaterTicks1us:
			case global::Gibraltar.Serialization.DateTimeEncoding.EarlierTicks1us:
				num2 = 10L;
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
			num *= num2;
			global::System.DateTimeOffset result = new global::System.DateTimeOffset(this.m_Strings.ReferenceTime.Ticks + num, offset);
			return result;
			IL_3A:
			result = new global::System.DateTimeOffset(num, offset);
			return result;
			IL_46:
			result = new global::System.DateTimeOffset(num, offset);
			this.m_Strings.ReferenceTime = result.DateTime;
			return result;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000190BC File Offset: 0x000172BC
		public global::System.DateTime[] ReadDateTimeArray()
		{
			return global::Gibraltar.Serialization.FieldReader.DateTimeArrayReader.Read(this);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000190CC File Offset: 0x000172CC
		public global::System.DateTimeOffset[] ReadDateTimeOffsetArray()
		{
			return global::Gibraltar.Serialization.FieldReader.DateTimeOffsetArrayReader.Read(this);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000190DC File Offset: 0x000172DC
		public global::System.DateTime ReadTimestamp()
		{
			long num = this.ReadInt64();
			global::System.DateTime result;
			if (num == 0L)
			{
				long num2 = this.ReadInt64();
				if (num2 == 0L)
				{
					result = this.m_Strings.ReferenceTime;
				}
				else
				{
					result = (this.m_Strings.ReferenceTime = global::System.DateTime.SpecifyKind(new global::System.DateTime(num2), global::System.DateTimeKind.Utc));
				}
			}
			else
			{
				result = this.m_Strings.ReferenceTime.AddTicks(num);
			}
			return result;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00019150 File Offset: 0x00017350
		public global::System.DateTime[] ReadTimestampTimeArray()
		{
			return global::Gibraltar.Serialization.FieldReader.DateTimeArrayReader.Read(this);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00019160 File Offset: 0x00017360
		public global::System.Guid ReadGuid()
		{
			byte[] b = this.ReadBytes(16);
			return new global::System.Guid(b);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00019180 File Offset: 0x00017380
		public global::System.Guid[] ReadGuidArray()
		{
			return global::Gibraltar.Serialization.FieldReader.GuidArrayReader.Read(this);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00019190 File Offset: 0x00017390
		public object ReadField()
		{
			global::Gibraltar.Serialization.FieldType fieldType = this.ReadFieldType();
			return this.ReadField(fieldType);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000191B0 File Offset: 0x000173B0
		public object ReadField(global::Gibraltar.Serialization.FieldType fieldType)
		{
			switch (fieldType)
			{
			case global::Gibraltar.Serialization.FieldType.Bool:
				return this.ReadBool();
			case global::Gibraltar.Serialization.FieldType.BoolArray:
				return this.ReadBoolArray();
			case global::Gibraltar.Serialization.FieldType.String:
				return this.ReadString();
			case global::Gibraltar.Serialization.FieldType.StringArray:
				return this.ReadStringArray();
			case global::Gibraltar.Serialization.FieldType.Int32:
				return this.ReadInt32();
			case global::Gibraltar.Serialization.FieldType.Int32Array:
				return this.ReadInt32Array();
			case global::Gibraltar.Serialization.FieldType.Int64:
				return this.ReadInt64();
			case global::Gibraltar.Serialization.FieldType.Int64Array:
				return this.ReadInt64Array();
			case global::Gibraltar.Serialization.FieldType.UInt32:
				return this.ReadUInt32();
			case global::Gibraltar.Serialization.FieldType.UInt32Array:
				return this.ReadUInt32Array();
			case global::Gibraltar.Serialization.FieldType.UInt64:
				return this.ReadUInt64();
			case global::Gibraltar.Serialization.FieldType.UInt64Array:
				return this.ReadUInt64Array();
			case global::Gibraltar.Serialization.FieldType.Double:
				return this.ReadDouble();
			case global::Gibraltar.Serialization.FieldType.DoubleArray:
				return this.ReadDoubleArray();
			case global::Gibraltar.Serialization.FieldType.TimeSpan:
				return this.ReadTimeSpan();
			case global::Gibraltar.Serialization.FieldType.TimeSpanArray:
				return this.ReadTimeSpanArray();
			case global::Gibraltar.Serialization.FieldType.DateTime:
				return this.ReadDateTime();
			case global::Gibraltar.Serialization.FieldType.DateTimeArray:
				return this.ReadDateTimeArray();
			case global::Gibraltar.Serialization.FieldType.Guid:
				return this.ReadGuid();
			case global::Gibraltar.Serialization.FieldType.GuidArray:
				return this.ReadGuidArray();
			case global::Gibraltar.Serialization.FieldType.DateTimeOffset:
				return this.ReadDateTimeOffset();
			case global::Gibraltar.Serialization.FieldType.DateTimeOffsetArray:
				return this.ReadDateTimeOffsetArray();
			default:
				throw new global::System.IO.InvalidDataException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "There is no known field type for {0}, this most likely indicates a corrupt file or serialization defect.", new object[]
				{
					fieldType
				}));
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00019318 File Offset: 0x00017518
		public object[] ReadFieldArray()
		{
			int num = (int)this.ReadUInt32();
			object[] array = new object[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadField();
			}
			return array;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00019350 File Offset: 0x00017550
		public global::Gibraltar.Serialization.FieldType ReadFieldType()
		{
			return (global::Gibraltar.Serialization.FieldType)this.ReadInt32();
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00019358 File Offset: 0x00017558
		public global::Gibraltar.Serialization.FieldType[] ReadFieldTypeArray()
		{
			int num = (int)this.ReadUInt32();
			global::Gibraltar.Serialization.FieldType[] array = new global::Gibraltar.Serialization.FieldType[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadFieldType();
			}
			return array;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00019390 File Offset: 0x00017590
		private byte ReadByte()
		{
			int num = this.m_Stream.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.IOException("Unable to read beyond the end of the stream.");
			}
			return (byte)num;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000193B0 File Offset: 0x000175B0
		private byte[] ReadBytes(int length)
		{
			byte[] array = new byte[length];
			if (this.m_Stream.Read(array, 0, length) < length)
			{
				throw new global::System.IO.IOException("Unable to read beyond the end of the stream.");
			}
			return array;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000193E8 File Offset: 0x000175E8
		private string ReadStringDirect()
		{
			uint num = this.ReadUInt32();
			if (num == 0U)
			{
				return string.Empty;
			}
			byte[] array = new byte[num];
			int num2 = this.m_Stream.Read(array, 0, (int)num);
			if ((long)num2 != (long)((ulong)num))
			{
				throw new global::System.IO.IOException(string.Concat(new object[]
				{
					"Unable to read the complete string. ",
					num,
					" bytes expected, ",
					num2,
					" bytes actually read."
				}));
			}
			if (num == 1U && array[0] == 0)
			{
				return null;
			}
			string @string;
			try
			{
				@string = this.m_Encoding.GetString(array);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
				throw;
			}
			return global::Gibraltar.StringReference.GetReference(@string);
		}

		// Token: 0x04000297 RID: 663
		private global::System.IO.Stream m_Stream;

		// Token: 0x04000298 RID: 664
		private readonly global::System.Text.Encoding m_Encoding;

		// Token: 0x04000299 RID: 665
		private readonly global::Gibraltar.Serialization.UniqueStringList m_Strings;

		// Token: 0x0400029A RID: 666
		private readonly int m_MajorVersion;

		// Token: 0x0400029B RID: 667
		private readonly int m_MinorVersion;

		// Token: 0x0400029C RID: 668
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<string> StringArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<string>();

		// Token: 0x0400029D RID: 669
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<int> Int32ArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<int>();

		// Token: 0x0400029E RID: 670
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<long> Int64ArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<long>();

		// Token: 0x0400029F RID: 671
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<uint> UInt32ArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<uint>();

		// Token: 0x040002A0 RID: 672
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<ulong> UInt64ArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<ulong>();

		// Token: 0x040002A1 RID: 673
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<double> DoubleArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<double>();

		// Token: 0x040002A2 RID: 674
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.TimeSpan> TimeSpanArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.TimeSpan>();

		// Token: 0x040002A3 RID: 675
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.DateTime> DateTimeArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.DateTime>();

		// Token: 0x040002A4 RID: 676
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.DateTimeOffset> DateTimeOffsetArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.DateTimeOffset>();

		// Token: 0x040002A5 RID: 677
		private static readonly global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.Guid> GuidArrayReader = new global::Gibraltar.Serialization.Internal.ArrayEncoder<global::System.Guid>();
	}
}
