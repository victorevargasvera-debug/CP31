using System;

namespace NPOI.Util
{
	// Token: 0x0200025A RID: 602
	public class ByteBuffer
	{
		// Token: 0x06000ED6 RID: 3798 RVA: 0x0002BC48 File Offset: 0x00029E48
		private ByteBuffer(int mark, int pos, int lim, int cap, byte[] buffer, int offset)
		{
			if (cap < 0)
			{
				throw new global::System.ArgumentException();
			}
			this.capacity = cap;
			this.Limit = lim;
			this.Position = pos;
			if (mark >= 0)
			{
				if (mark > pos)
				{
					throw new global::System.ArgumentException();
				}
				this.mark = mark;
			}
			this.buffer = buffer;
			this.offset = offset;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0002BCA8 File Offset: 0x00029EA8
		public ByteBuffer(byte[] buffer, int off, int len) : this(-1, off, off + len, buffer.Length, buffer, 0)
		{
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0002BCBA File Offset: 0x00029EBA
		public ByteBuffer(int capacity, int limit) : this(-1, 0, limit, capacity, new byte[capacity], 0)
		{
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0002BCCD File Offset: 0x00029ECD
		protected ByteBuffer(byte[] buffer, int mark, int pos, int lim, int cap, int off) : this(mark, pos, lim, cap, buffer, off)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0002BCDE File Offset: 0x00029EDE
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x0002BCE6 File Offset: 0x00029EE6
		public int Position
		{
			get
			{
				return this.position;
			}
			set
			{
				if (value < 0 || value > this.limit)
				{
					throw new global::System.ArgumentException();
				}
				this.position = value;
				if (this.mark > this.position)
				{
					this.mark = -1;
				}
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0002BD17 File Offset: 0x00029F17
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x0002BD20 File Offset: 0x00029F20
		public int Limit
		{
			get
			{
				return this.limit;
			}
			set
			{
				if (value > this.capacity || value < 0)
				{
					throw new global::System.ArgumentException();
				}
				this.limit = value;
				if (this.position > this.limit)
				{
					this.position = this.limit;
				}
				if (this.mark > this.limit)
				{
					this.mark = -1;
				}
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0002BD76 File Offset: 0x00029F76
		public int Remaining()
		{
			return this.limit - this.position;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0002BD85 File Offset: 0x00029F85
		public bool HasRemaining()
		{
			return this.position < this.limit;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0002BD95 File Offset: 0x00029F95
		public static global::NPOI.Util.ByteBuffer CreateBuffer(int capacity)
		{
			if (capacity < 0)
			{
				throw new global::System.ArgumentException();
			}
			return new global::NPOI.Util.ByteBuffer(capacity, capacity);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0002BDA8 File Offset: 0x00029FA8
		public static global::NPOI.Util.ByteBuffer CreateBuffer(byte[] buffer, int offset, int length)
		{
			global::NPOI.Util.ByteBuffer result;
			try
			{
				result = new global::NPOI.Util.ByteBuffer(buffer, offset, length);
			}
			catch (global::System.ArgumentException)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			return result;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0002BDD8 File Offset: 0x00029FD8
		public static global::NPOI.Util.ByteBuffer CreateBuffer(byte[] buffer)
		{
			return global::NPOI.Util.ByteBuffer.CreateBuffer(buffer, 0, buffer.Length);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0002BDE4 File Offset: 0x00029FE4
		public global::NPOI.Util.ByteBuffer Slice()
		{
			return new global::NPOI.Util.ByteBuffer(this.buffer, -1, 0, this.Remain, this.Remain, this.Position + this.offset);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0002BE0C File Offset: 0x0002A00C
		public global::NPOI.Util.ByteBuffer Duplicate()
		{
			return null;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0002BE10 File Offset: 0x0002A010
		protected int NextGetIndex()
		{
			if (this.position >= this.limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			int num = this.position;
			this.position = num + 1;
			return num;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0002BE42 File Offset: 0x0002A042
		protected int NextGetIndex(int nb)
		{
			if (this.limit - this.position < nb)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			int result = this.position;
			this.position += nb;
			return result;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0002BE6E File Offset: 0x0002A06E
		protected int NextPutIndex()
		{
			return this.NextGetIndex();
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0002BE76 File Offset: 0x0002A076
		protected int NextPutIndex(int nb)
		{
			return this.NextGetIndex(nb);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0002BE7F File Offset: 0x0002A07F
		protected int Index(int i)
		{
			return i + this.offset;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0002BE89 File Offset: 0x0002A089
		protected int CheckIndex(int i)
		{
			if (i < 0 || i >= this.limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			return i;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0002BE9F File Offset: 0x0002A09F
		protected int CheckIndex(int i, int nb)
		{
			if (i < 0 || nb > this.limit - i)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			return i;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0002BEB7 File Offset: 0x0002A0B7
		public byte Read()
		{
			return this.buffer[this.Index(this.NextGetIndex())];
		}

		// Token: 0x17000323 RID: 803
		public byte this[int index]
		{
			get
			{
				return this.buffer[this.Index(this.CheckIndex(index))];
			}
			set
			{
				if (index < 0 || index >= this.limit)
				{
					throw new global::System.IndexOutOfRangeException();
				}
				this.buffer[this.Index(index)] = value;
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0002BF06 File Offset: 0x0002A106
		protected void CheckBounds(int off, int len, int size)
		{
			if ((off | len | off + len | size - (off + len)) < 0)
			{
				throw new global::System.IndexOutOfRangeException();
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0002BF1E File Offset: 0x0002A11E
		public global::NPOI.Util.ByteBuffer Read(byte[] buf)
		{
			return this.Read(buf, 0, buf.Length);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0002BF2C File Offset: 0x0002A12C
		public global::NPOI.Util.ByteBuffer Read(byte[] dst, int offset, int length)
		{
			this.CheckBounds(offset, length, dst.Length);
			if (length > this.Remain)
			{
				throw new global::System.ArgumentException();
			}
			global::System.Array.Copy(this.buffer, this.Index(this.position), dst, offset, length);
			this.Position += length;
			return this;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0002BF7C File Offset: 0x0002A17C
		public global::NPOI.Util.ByteBuffer Write(byte x)
		{
			this.buffer[this.Index(this.NextPutIndex())] = x;
			return this;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0002BF94 File Offset: 0x0002A194
		public global::NPOI.Util.ByteBuffer Write(byte[] src, int offset, int length)
		{
			this.CheckBounds(offset, length, src.Length);
			if (length > this.Remain)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			global::System.Array.Copy(src, offset, this.buffer, this.Index(this.Position), length);
			this.Position += length;
			return this;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0002BFE4 File Offset: 0x0002A1E4
		public global::NPOI.Util.ByteBuffer Write(global::NPOI.Util.ByteBuffer src)
		{
			if (src == this)
			{
				throw new global::System.ArgumentException();
			}
			int remain = src.Remain;
			if (remain > this.Remain)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			for (int i = 0; i < remain; i++)
			{
				this.Write(src.Read());
			}
			return this;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0002C02B File Offset: 0x0002A22B
		public global::NPOI.Util.ByteBuffer Write(byte[] data)
		{
			return this.Write(data, 0, data.Length);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0002BD76 File Offset: 0x00029F76
		public int Remain
		{
			get
			{
				return this.limit - this.position;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x0002C038 File Offset: 0x0002A238
		public byte[] Buffer
		{
			get
			{
				return this.buffer;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0002C040 File Offset: 0x0002A240
		public int Offset
		{
			get
			{
				return this.offset;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00008875 File Offset: 0x00006A75
		public bool HasBuffer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0002C048 File Offset: 0x0002A248
		public int Length
		{
			get
			{
				return this.capacity;
			}
		}

		// Token: 0x040006B2 RID: 1714
		private byte[] buffer;

		// Token: 0x040006B3 RID: 1715
		private int mark = -1;

		// Token: 0x040006B4 RID: 1716
		private int position;

		// Token: 0x040006B5 RID: 1717
		private int limit;

		// Token: 0x040006B6 RID: 1718
		private int capacity;

		// Token: 0x040006B7 RID: 1719
		private int offset;
	}
}
