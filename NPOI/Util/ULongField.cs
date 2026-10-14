using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000294 RID: 660
	[global::System.Obsolete]
	public class ULongField
	{
		// Token: 0x06001216 RID: 4630 RVA: 0x0003637F File Offset: 0x0003457F
		public ULongField(int offset)
		{
			if (offset < 0)
			{
				throw new global::System.IndexOutOfRangeException("Illegal offset: " + offset.ToString());
			}
			this._offset = offset;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x000363A9 File Offset: 0x000345A9
		public ULongField(int offset, ulong value) : this(offset)
		{
			this.Value = value;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000363B9 File Offset: 0x000345B9
		public ULongField(int offset, byte[] data)
		{
			this._offset = offset;
			this.ReadFromBytes(data);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000363CF File Offset: 0x000345CF
		public ULongField(int offset, ulong value, byte[] data)
		{
			this._offset = offset;
			this.Set(value, data);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000363E6 File Offset: 0x000345E6
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x000363EE File Offset: 0x000345EE
		public ulong Value
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

		// Token: 0x0600121C RID: 4636 RVA: 0x000363F7 File Offset: 0x000345F7
		public void Set(ulong value, byte[] data)
		{
			this._value = value;
			this.WriteToBytes(data);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00036407 File Offset: 0x00034607
		public void ReadFromBytes(byte[] data)
		{
			this._value = global::NPOI.Util.LittleEndian.GetULong(data, this._offset);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0003641B File Offset: 0x0003461B
		public void ReadFromStream(global::System.IO.Stream stream)
		{
			this._value = global::NPOI.Util.LittleEndian.ReadULong(stream);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00036429 File Offset: 0x00034629
		public void WriteToBytes(byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutULong(data, this._offset, this._value);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0003643D File Offset: 0x0003463D
		public override string ToString()
		{
			return global::System.Convert.ToString(this._value);
		}

		// Token: 0x0400077B RID: 1915
		private ulong _value;

		// Token: 0x0400077C RID: 1916
		private int _offset;
	}
}
