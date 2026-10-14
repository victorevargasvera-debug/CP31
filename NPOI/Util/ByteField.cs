using System;
using System.Globalization;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000262 RID: 610
	public class ByteField : global::NPOI.Util.FixedField
	{
		// Token: 0x06000FD5 RID: 4053 RVA: 0x00030D93 File Offset: 0x0002EF93
		public ByteField(int offset) : this(offset, 0)
		{
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00030D9D File Offset: 0x0002EF9D
		public ByteField(int offset, byte value)
		{
			if (offset < 0)
			{
				throw new global::System.IndexOutOfRangeException("offset cannot be negative");
			}
			this._offset = offset;
			this.Value = value;
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00030DC2 File Offset: 0x0002EFC2
		public ByteField(int offset, byte[] data) : this(offset)
		{
			this.ReadFromBytes(data);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00030DD2 File Offset: 0x0002EFD2
		public ByteField(int offset, byte _value, byte[] data) : this(offset, _value)
		{
			this.WriteToBytes(data);
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00030DE3 File Offset: 0x0002EFE3
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00030DEB File Offset: 0x0002EFEB
		public virtual byte Value
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

		// Token: 0x06000FDB RID: 4059 RVA: 0x00030DF4 File Offset: 0x0002EFF4
		public virtual void ReadFromBytes(byte[] data)
		{
			this._value = data[this._offset];
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00030E04 File Offset: 0x0002F004
		public virtual void ReadFromStream(global::System.IO.Stream stream)
		{
			int num = stream.ReadByte();
			if (num < 0)
			{
				throw new global::NPOI.Util.BufferUnderflowException();
			}
			this._value = (byte)num;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00030E2A File Offset: 0x0002F02A
		public virtual void Set(byte value, byte[] data)
		{
			this.Value = value;
			this.WriteToBytes(data);
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00030E3A File Offset: 0x0002F03A
		public override string ToString()
		{
			return global::System.Convert.ToString(this._value, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00030E4C File Offset: 0x0002F04C
		public virtual void WriteToBytes(byte[] data)
		{
			data[this._offset] = this._value;
		}

		// Token: 0x040006E5 RID: 1765
		private const byte _default_value = 0;

		// Token: 0x040006E6 RID: 1766
		private int _offset;

		// Token: 0x040006E7 RID: 1767
		private byte _value;
	}
}
