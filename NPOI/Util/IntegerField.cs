using System;
using System.Globalization;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200026E RID: 622
	public class IntegerField : global::NPOI.Util.FixedField
	{
		// Token: 0x06001054 RID: 4180 RVA: 0x0003214B File Offset: 0x0003034B
		public IntegerField(int offset)
		{
			if (offset < 0)
			{
				throw new global::System.IndexOutOfRangeException("negative offset");
			}
			this._offset = offset;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00032169 File Offset: 0x00030369
		public IntegerField(int offset, int value) : this(offset)
		{
			this._value = value;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00032179 File Offset: 0x00030379
		public IntegerField(int offset, byte[] data) : this(offset)
		{
			this.ReadFromBytes(data);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00032189 File Offset: 0x00030389
		public IntegerField(int offset, int value, byte[] data) : this(offset)
		{
			this.Set(value, data);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0003219A File Offset: 0x0003039A
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x000321A2 File Offset: 0x000303A2
		public int Value
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

		// Token: 0x0600105A RID: 4186 RVA: 0x000321AB File Offset: 0x000303AB
		public void Set(int value, byte[] data)
		{
			this._value = value;
			this.WriteToBytes(data);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000321BB File Offset: 0x000303BB
		public void ReadFromBytes(byte[] data)
		{
			this._value = global::NPOI.Util.LittleEndian.GetInt(data, this._offset);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x000321CF File Offset: 0x000303CF
		public void ReadFromStream(global::System.IO.Stream stream)
		{
			this._value = global::NPOI.Util.LittleEndian.ReadInt(stream);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000321DD File Offset: 0x000303DD
		public void WriteToBytes(byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutInt(data, this._offset, this._value);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000321F1 File Offset: 0x000303F1
		public static void Write(int offset, int value, byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutInt(data, offset, value);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x000321FB File Offset: 0x000303FB
		public override string ToString()
		{
			return global::System.Convert.ToString(this._value, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x0400072D RID: 1837
		private int _value;

		// Token: 0x0400072E RID: 1838
		private int _offset;
	}
}
