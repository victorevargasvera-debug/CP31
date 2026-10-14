using System;
using System.Runtime.CompilerServices;
using System.Threading;
using MassTransit.NewIdFormatters;
using MassTransit.NewIdProviders;

namespace MassTransit
{
	// Token: 0x0200000A RID: 10
	public readonly struct NewId : global::System.IEquatable<global::MassTransit.NewId>, global::System.IComparable<global::MassTransit.NewId>, global::System.IComparable, global::System.IFormattable
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002060 File Offset: 0x00000260
		public NewId(in byte[] bytes)
		{
			if (bytes == null)
			{
				throw new global::System.ArgumentNullException("bytes");
			}
			if (bytes.Length != 16)
			{
				throw new global::System.ArgumentException("Exactly 16 bytes expected", "bytes");
			}
			global::MassTransit.NewId.FromByteArray(bytes, out this._a, out this._b, out this._c, out this._d);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B4 File Offset: 0x000002B4
		public NewId(in string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new global::System.ArgumentException("must not be null or empty", "value");
			}
			global::System.Guid guid = new global::System.Guid(value);
			byte[] array = guid.ToByteArray();
			global::MassTransit.NewId.FromByteArray(array, out this._a, out this._b, out this._c, out this._d);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000210A File Offset: 0x0000030A
		public NewId(int a, int b, int c, int d)
		{
			this._a = a;
			this._b = b;
			this._c = c;
			this._d = d;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000212C File Offset: 0x0000032C
		public NewId(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			this._a = ((int)f << 24 | (int)g << 16 | (int)h << 8 | (int)i);
			this._b = ((int)j << 24 | (int)k << 16 | (int)d << 8 | (int)e);
			this._c = ((int)c << 16 | (int)b);
			this._d = ((int)((long)a & (long)((ulong)-65536)) | (a >> 8 & 255) | (a << 8 & 65280));
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000219B File Offset: 0x0000039B
		private static global::MassTransit.IWorkerIdProvider WorkerIdProvider
		{
			get
			{
				global::MassTransit.IWorkerIdProvider result;
				if ((result = global::MassTransit.NewId._workerIdProvider) == null)
				{
					result = (global::MassTransit.NewId._workerIdProvider = new global::MassTransit.NewIdProviders.BestPossibleWorkerIdProvider());
				}
				return result;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000021B1 File Offset: 0x000003B1
		private static global::MassTransit.IProcessIdProvider ProcessIdProvider
		{
			get
			{
				return global::MassTransit.NewId._processIdProvider;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000021B8 File Offset: 0x000003B8
		private static global::MassTransit.ITickProvider TickProvider
		{
			get
			{
				global::MassTransit.ITickProvider result;
				if ((result = global::MassTransit.NewId._tickProvider) == null)
				{
					result = (global::MassTransit.NewId._tickProvider = new global::MassTransit.NewIdProviders.StopwatchTickProvider());
				}
				return result;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021D0 File Offset: 0x000003D0
		public global::System.DateTime Timestamp
		{
			get
			{
				long ticks = (long)this._a << 32 | (long)((ulong)this._b);
				return new global::System.DateTime(ticks, global::System.DateTimeKind.Utc);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021F7 File Offset: 0x000003F7
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is global::MassTransit.NewId))
			{
				throw new global::System.ArgumentException("Argument must be a NewId");
			}
			return this.CompareTo((global::MassTransit.NewId)obj);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002220 File Offset: 0x00000420
		public int CompareTo(global::MassTransit.NewId other)
		{
			if (this._a != other._a)
			{
				if (this._a >= other._a)
				{
					return 1;
				}
				return -1;
			}
			else if (this._b != other._b)
			{
				if (this._b >= other._b)
				{
					return 1;
				}
				return -1;
			}
			else if (this._c != other._c)
			{
				if (this._c >= other._c)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (this._d == other._d)
				{
					return 0;
				}
				if (this._d >= other._d)
				{
					return 1;
				}
				return -1;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022AE File Offset: 0x000004AE
		public bool Equals(global::MassTransit.NewId other)
		{
			return other._a == this._a && other._b == this._b && other._c == this._c && other._d == this._d;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022EC File Offset: 0x000004EC
		public string ToString(string format, global::System.IFormatProvider formatProvider)
		{
			if (string.IsNullOrEmpty(format))
			{
				format = "D";
			}
			bool flag = false;
			if (format.Length == 2 && (format[1] == 'S' || format[1] == 's'))
			{
				flag = true;
			}
			else if (format.Length != 1)
			{
				throw new global::System.FormatException("The format string must be exactly one character or null");
			}
			char c = format[0];
			byte[] array = flag ? this.GetSequentialFormatterArray() : this.GetFormatterArray();
			if (c == 'B' || c == 'b')
			{
				return global::MassTransit.NewId.BraceFormatter.Format(array);
			}
			if (c == 'P' || c == 'p')
			{
				return global::MassTransit.NewId.ParenFormatter.Format(array);
			}
			if (c == 'D' || c == 'd')
			{
				return global::MassTransit.NewId.DashedHexFormatter.Format(array);
			}
			if (c == 'N' || c == 'n')
			{
				return global::MassTransit.NewId.HexFormatter.Format(array);
			}
			throw new global::System.FormatException("The format string was not valid");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023C4 File Offset: 0x000005C4
		public string ToString(global::MassTransit.INewIdFormatter formatter, bool sequential = false)
		{
			byte[] array = sequential ? this.GetSequentialFormatterArray() : this.GetFormatterArray();
			return formatter.Format(array);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023EC File Offset: 0x000005EC
		private byte[] GetFormatterArray()
		{
			byte[] value = global::MassTransit.NewId._formatterArray.Value;
			value[15] = (byte)(this._b >> 16);
			value[14] = (byte)(this._b >> 24);
			value[13] = (byte)this._a;
			value[12] = (byte)(this._a >> 8);
			value[11] = (byte)(this._a >> 16);
			value[10] = (byte)(this._a >> 24);
			value[9] = (byte)this._b;
			value[8] = (byte)(this._b >> 8);
			value[7] = (byte)(this._c >> 16);
			value[6] = (byte)(this._c >> 24);
			value[5] = (byte)this._c;
			value[4] = (byte)(this._c >> 8);
			value[3] = (byte)(this._d >> 8);
			value[2] = (byte)this._d;
			value[1] = (byte)(this._d >> 16);
			value[0] = (byte)(this._d >> 24);
			return value;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000024CC File Offset: 0x000006CC
		private byte[] GetSequentialFormatterArray()
		{
			byte[] value = global::MassTransit.NewId._formatterArray.Value;
			value[15] = (byte)this._d;
			value[14] = (byte)(this._d >> 8);
			value[13] = (byte)(this._d >> 16);
			value[12] = (byte)(this._d >> 24);
			value[11] = (byte)this._c;
			value[10] = (byte)(this._c >> 8);
			value[9] = (byte)(this._c >> 16);
			value[8] = (byte)(this._c >> 24);
			value[7] = (byte)this._b;
			value[6] = (byte)(this._b >> 8);
			value[5] = (byte)(this._b >> 16);
			value[4] = (byte)(this._b >> 24);
			value[3] = (byte)this._a;
			value[2] = (byte)(this._a >> 8);
			value[1] = (byte)(this._a >> 16);
			value[0] = (byte)(this._a >> 24);
			return value;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000025AC File Offset: 0x000007AC
		public global::System.Guid ToGuid()
		{
			int a = (int)((long)this._d & (long)((ulong)-65536)) | (this._d >> 8 & 255) | (this._d << 8 & 65280);
			short b = (short)this._c;
			short c = (short)(this._c >> 16);
			byte d = (byte)(this._b >> 8);
			byte e = (byte)this._b;
			byte f = (byte)(this._a >> 24);
			byte g = (byte)(this._a >> 16);
			byte h = (byte)(this._a >> 8);
			byte i = (byte)this._a;
			byte j = (byte)(this._b >> 24);
			byte k = (byte)(this._b >> 16);
			return new global::System.Guid(a, b, c, d, e, f, g, h, i, j, k);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002668 File Offset: 0x00000868
		public global::System.Guid ToSequentialGuid()
		{
			int a = this._a;
			short b = (short)(this._b >> 16);
			short c = (short)this._b;
			byte d = (byte)(this._c >> 24);
			byte e = (byte)(this._c >> 16);
			byte f = (byte)(this._c >> 8);
			byte g = (byte)this._c;
			byte h = (byte)(this._d >> 24);
			byte i = (byte)(this._d >> 16);
			byte j = (byte)(this._d >> 8);
			byte k = (byte)this._d;
			return new global::System.Guid(a, b, c, d, e, f, g, h, i, j, k);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002700 File Offset: 0x00000900
		public byte[] ToByteArray()
		{
			byte[] array = new byte[]
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				(byte)(this._b >> 16)
			};
			array[14] = (byte)(this._b >> 24);
			array[13] = (byte)this._a;
			array[12] = (byte)(this._a >> 8);
			array[11] = (byte)(this._a >> 16);
			array[10] = (byte)(this._a >> 24);
			array[9] = (byte)this._b;
			array[8] = (byte)(this._b >> 8);
			array[7] = (byte)(this._c >> 24);
			array[6] = (byte)(this._c >> 16);
			array[5] = (byte)(this._c >> 8);
			array[4] = (byte)this._c;
			array[3] = (byte)(this._d >> 24);
			array[2] = (byte)(this._d >> 16);
			array[1] = (byte)this._d;
			array[0] = (byte)(this._d >> 8);
			return array;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000027DD File Offset: 0x000009DD
		public override string ToString()
		{
			return this.ToString("D", null);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000027EB File Offset: 0x000009EB
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000027F5 File Offset: 0x000009F5
		public override bool Equals(object obj)
		{
			return obj != null && !(obj.GetType() != typeof(global::MassTransit.NewId)) && this.Equals((global::MassTransit.NewId)obj);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002824 File Offset: 0x00000A24
		public override int GetHashCode()
		{
			int num = this._a;
			num = (num * 397 ^ this._b);
			num = (num * 397 ^ this._c);
			return num * 397 ^ this._d;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002866 File Offset: 0x00000A66
		public static bool operator ==(in global::MassTransit.NewId left, in global::MassTransit.NewId right)
		{
			return left._a == right._a && left._b == right._b && left._c == right._c && left._d == right._d;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000028A2 File Offset: 0x00000AA2
		public static bool operator !=(in global::MassTransit.NewId left, in global::MassTransit.NewId right)
		{
			return !(left == right);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000028AE File Offset: 0x00000AAE
		public static bool operator <(in global::MassTransit.NewId left, in global::MassTransit.NewId right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000028BF File Offset: 0x00000ABF
		public static bool operator >(in global::MassTransit.NewId left, in global::MassTransit.NewId right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000028D0 File Offset: 0x00000AD0
		public static void SetGenerator(global::MassTransit.INewIdGenerator generator)
		{
			global::MassTransit.NewId._generator = generator;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000028D8 File Offset: 0x00000AD8
		public static void SetWorkerIdProvider(global::MassTransit.IWorkerIdProvider provider)
		{
			global::MassTransit.NewId._workerIdProvider = provider;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000028E0 File Offset: 0x00000AE0
		public static void SetProcessIdProvider(global::MassTransit.IProcessIdProvider provider)
		{
			global::MassTransit.NewId._processIdProvider = provider;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000028E8 File Offset: 0x00000AE8
		public static void SetTickProvider(global::MassTransit.ITickProvider provider)
		{
			global::MassTransit.NewId._tickProvider = provider;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000028F0 File Offset: 0x00000AF0
		private static global::MassTransit.INewIdGenerator _getGenerator()
		{
			if (global::MassTransit.NewId._generator != null)
			{
				return global::MassTransit.NewId._generator;
			}
			bool flag = false;
			try
			{
				global::MassTransit.NewId._spinLock.Enter(ref flag);
				if (global::MassTransit.NewId._generator == null)
				{
					global::MassTransit.NewId._generator = new global::MassTransit.NewIdGenerator(global::MassTransit.NewId.TickProvider, global::MassTransit.NewId.WorkerIdProvider, global::MassTransit.NewId.ProcessIdProvider, 0);
				}
			}
			finally
			{
				if (flag)
				{
					global::MassTransit.NewId._spinLock.Exit();
				}
			}
			return global::MassTransit.NewId._generator;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002960 File Offset: 0x00000B60
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::MassTransit.NewId Next()
		{
			return global::MassTransit.NewId._getGenerator().Next();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000296C File Offset: 0x00000B6C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::MassTransit.NewId[] Next(int count)
		{
			global::MassTransit.NewId[] array = new global::MassTransit.NewId[count];
			global::MassTransit.NewId._getGenerator().Next(array, 0, count);
			return array;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000298F File Offset: 0x00000B8F
		public static global::System.ArraySegment<global::MassTransit.NewId> Next(global::MassTransit.NewId[] ids, int index, int count)
		{
			return global::MassTransit.NewId._getGenerator().Next(ids, index, count);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000299E File Offset: 0x00000B9E
		public static global::System.Guid NextGuid()
		{
			return global::MassTransit.NewId._getGenerator().NextGuid();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000029AC File Offset: 0x00000BAC
		private static void FromByteArray(in byte[] bytes, out int a, out int b, out int c, out int d)
		{
			a = ((int)bytes[10] << 24 | (int)bytes[11] << 16 | (int)bytes[12] << 8 | (int)bytes[13]);
			b = ((int)bytes[14] << 24 | (int)bytes[15] << 16 | (int)bytes[8] << 8 | (int)bytes[9]);
			c = ((int)bytes[7] << 24 | (int)bytes[6] << 16 | (int)bytes[5] << 8 | (int)bytes[4]);
			d = ((int)bytes[3] << 24 | (int)bytes[2] << 16 | (int)bytes[0] << 8 | (int)bytes[1]);
		}

		// Token: 0x04000001 RID: 1
		public static readonly global::MassTransit.NewId Empty = new global::MassTransit.NewId(0, 0, 0, 0);

		// Token: 0x04000002 RID: 2
		private static readonly global::MassTransit.INewIdFormatter BraceFormatter = new global::MassTransit.NewIdFormatters.DashedHexFormatter('{', '}', false);

		// Token: 0x04000003 RID: 3
		private static readonly global::MassTransit.INewIdFormatter DashedHexFormatter = new global::MassTransit.NewIdFormatters.DashedHexFormatter('\0', '\0', false);

		// Token: 0x04000004 RID: 4
		private static readonly global::MassTransit.INewIdFormatter HexFormatter = new global::MassTransit.NewIdFormatters.HexFormatter(false);

		// Token: 0x04000005 RID: 5
		private static readonly global::MassTransit.INewIdFormatter ParenFormatter = new global::MassTransit.NewIdFormatters.DashedHexFormatter('(', ')', false);

		// Token: 0x04000006 RID: 6
		private static global::MassTransit.INewIdGenerator _generator;

		// Token: 0x04000007 RID: 7
		private static global::MassTransit.ITickProvider _tickProvider;

		// Token: 0x04000008 RID: 8
		private static global::MassTransit.IWorkerIdProvider _workerIdProvider;

		// Token: 0x04000009 RID: 9
		private static global::MassTransit.IProcessIdProvider _processIdProvider;

		// Token: 0x0400000A RID: 10
		private readonly int _a;

		// Token: 0x0400000B RID: 11
		private readonly int _b;

		// Token: 0x0400000C RID: 12
		private readonly int _c;

		// Token: 0x0400000D RID: 13
		private readonly int _d;

		// Token: 0x0400000E RID: 14
		private static readonly global::System.Threading.ThreadLocal<byte[]> _formatterArray = new global::System.Threading.ThreadLocal<byte[]>(() => new byte[16]);

		// Token: 0x0400000F RID: 15
		private static global::System.Threading.SpinLock _spinLock = new global::System.Threading.SpinLock(false);
	}
}
