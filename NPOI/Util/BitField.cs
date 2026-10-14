using System;

namespace NPOI.Util
{
	// Token: 0x02000260 RID: 608
	[global::System.Serializable]
	public class BitField
	{
		// Token: 0x06000FBF RID: 4031 RVA: 0x00030C14 File Offset: 0x0002EE14
		public BitField(int mask)
		{
			this._mask = mask;
			int num = 0;
			int num2 = mask;
			if (num2 != 0)
			{
				while ((num2 & 1) == 0)
				{
					num++;
					num2 >>= 1;
				}
			}
			this._shift_count = num;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00030C4B File Offset: 0x0002EE4B
		public BitField(uint mask) : this((int)mask)
		{
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00030C54 File Offset: 0x0002EE54
		public int Clear(int holder)
		{
			return holder & ~this._mask;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00030C5F File Offset: 0x0002EE5F
		public short ClearShort(short holder)
		{
			return (short)this.Clear((int)holder);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00030C69 File Offset: 0x0002EE69
		public int GetRawValue(int holder)
		{
			return holder & this._mask;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00030C73 File Offset: 0x0002EE73
		public short GetShortRawValue(short holder)
		{
			return (short)this.GetRawValue((int)holder);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00030C7D File Offset: 0x0002EE7D
		public short GetShortValue(short holder)
		{
			return (short)this.GetValue((int)holder);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00030C87 File Offset: 0x0002EE87
		public int GetValue(int holder)
		{
			return global::NPOI.Util.Operator.UnsignedRightShift(this.GetRawValue(holder), this._shift_count);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00030C9B File Offset: 0x0002EE9B
		public bool IsAllSet(int holder)
		{
			return (holder & this._mask) == this._mask;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00030CAD File Offset: 0x0002EEAD
		public bool IsSet(int holder)
		{
			return (holder & this._mask) != 0;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00030CBA File Offset: 0x0002EEBA
		public int Set(int holder)
		{
			return holder | this._mask;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00030CC4 File Offset: 0x0002EEC4
		public int SetBoolean(int holder, bool flag)
		{
			if (flag)
			{
				return this.Set(holder);
			}
			return this.Clear(holder);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00030CD8 File Offset: 0x0002EED8
		public short SetShort(short holder)
		{
			return (short)this.Set((int)holder);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00030CE2 File Offset: 0x0002EEE2
		public short SetShortBoolean(short holder, bool flag)
		{
			if (flag)
			{
				return this.SetShort(holder);
			}
			return this.ClearShort(holder);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00030CF6 File Offset: 0x0002EEF6
		public short SetShortValue(short holder, short value)
		{
			return (short)this.SetValue((int)holder, (int)value);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00030D01 File Offset: 0x0002EF01
		public int SetValue(int holder, int value)
		{
			return (holder & ~this._mask) | (value << this._shift_count & this._mask);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00030D1F File Offset: 0x0002EF1F
		public byte SetByteBoolean(byte holder, bool flag)
		{
			if (flag)
			{
				return this.SetByte(holder);
			}
			return this.ClearByte(holder);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00030D33 File Offset: 0x0002EF33
		public byte ClearByte(byte holder)
		{
			return (byte)this.Clear((int)holder);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00030D3D File Offset: 0x0002EF3D
		public byte SetByte(byte holder)
		{
			return (byte)this.Set((int)holder);
		}

		// Token: 0x040006E2 RID: 1762
		private int _mask;

		// Token: 0x040006E3 RID: 1763
		private int _shift_count;
	}
}
