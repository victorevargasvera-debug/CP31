using System;
using System.Globalization;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200027E RID: 638
	public class LongField
	{
		// Token: 0x0600111E RID: 4382 RVA: 0x00033EF1 File Offset: 0x000320F1
		public LongField(int offset)
		{
			if (offset < 0)
			{
				throw new global::System.IndexOutOfRangeException("Illegal offset: " + offset.ToString());
			}
			this._offset = offset;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00033F1B File Offset: 0x0003211B
		public LongField(int offset, long value) : this(offset)
		{
			this.Value = value;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00033F2B File Offset: 0x0003212B
		public LongField(int offset, byte[] data) : this(offset)
		{
			this.ReadFromBytes(data);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00033F3B File Offset: 0x0003213B
		public LongField(int offset, long value, byte[] data) : this(offset)
		{
			this.Set(value, data);
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x00033F4C File Offset: 0x0003214C
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x00033F54 File Offset: 0x00032154
		public long Value
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

		// Token: 0x06001124 RID: 4388 RVA: 0x00033F5D File Offset: 0x0003215D
		public void Set(long value, byte[] data)
		{
			this._value = value;
			this.WriteToBytes(data);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00033F6D File Offset: 0x0003216D
		public void ReadFromBytes(byte[] data)
		{
			this._value = global::NPOI.Util.LittleEndian.GetLong(data, this._offset);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00033F81 File Offset: 0x00032181
		public void ReadFromStream(global::System.IO.Stream stream)
		{
			this._value = global::NPOI.Util.LittleEndian.ReadLong(stream);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00033F8F File Offset: 0x0003218F
		public void WriteToBytes(byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutLong(data, this._offset, this._value);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00033FA3 File Offset: 0x000321A3
		public static void Write(int offset, long value, byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutLong(data, offset, value);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00033FAD File Offset: 0x000321AD
		public override string ToString()
		{
			return global::System.Convert.ToString(this._value, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x0400074C RID: 1868
		private long _value;

		// Token: 0x0400074D RID: 1869
		private int _offset;
	}
}
