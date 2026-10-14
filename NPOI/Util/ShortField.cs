using System;
using System.Globalization;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200028E RID: 654
	public class ShortField
	{
		// Token: 0x060011C1 RID: 4545 RVA: 0x000354A7 File Offset: 0x000336A7
		public ShortField(int offset)
		{
			if (offset < 0)
			{
				throw new global::System.IndexOutOfRangeException("Illegal offset: " + offset.ToString());
			}
			this._offset = offset;
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x000354D1 File Offset: 0x000336D1
		public ShortField(int offset, short value) : this(offset)
		{
			this._value = value;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x000354E1 File Offset: 0x000336E1
		public ShortField(int offset, byte[] data) : this(offset)
		{
			this.ReadFromBytes(data);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000354F1 File Offset: 0x000336F1
		public ShortField(int offset, short value, ref byte[] data) : this(offset)
		{
			this.Set(value, ref data);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00035502 File Offset: 0x00033702
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x0003550A File Offset: 0x0003370A
		public short Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00035513 File Offset: 0x00033713
		public void Set(short value, ref byte[] data)
		{
			this._value = value;
			this.WriteToBytes(data);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00035524 File Offset: 0x00033724
		public void ReadFromBytes(byte[] data)
		{
			this._value = global::NPOI.Util.LittleEndian.GetShort(data, this._offset);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00035538 File Offset: 0x00033738
		public void ReadFromStream(global::System.IO.Stream stream)
		{
			this._value = global::NPOI.Util.LittleEndian.ReadShort(stream);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00035546 File Offset: 0x00033746
		public void WriteToBytes(byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, this._offset, this._value);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0003555A File Offset: 0x0003375A
		public static void Write(int offset, short value, ref byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, offset, value);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00035565 File Offset: 0x00033765
		public override string ToString()
		{
			return global::System.Convert.ToString(this._value, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x0400076A RID: 1898
		private short _value;

		// Token: 0x0400076B RID: 1899
		private int _offset;
	}
}
