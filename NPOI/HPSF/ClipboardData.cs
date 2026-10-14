using System;
using System.IO;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004F9 RID: 1273
	public class ClipboardData
	{
		// Token: 0x06002FCC RID: 12236 RVA: 0x00090BB0 File Offset: 0x0008EDB0
		public ClipboardData(byte[] data, int offset)
		{
			int @int = global::NPOI.Util.LittleEndian.GetInt(data, offset);
			if (@int < 4)
			{
				this._format = 0;
				this._value = new byte[0];
				return;
			}
			this._format = global::NPOI.Util.LittleEndian.GetInt(data, offset + 4);
			this._value = global::NPOI.Util.LittleEndian.GetByteArray(data, offset + 8, @int - 4);
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002FCD RID: 12237 RVA: 0x00090C04 File Offset: 0x0008EE04
		public int Size
		{
			get
			{
				return 8 + this._value.Length;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002FCE RID: 12238 RVA: 0x00090C10 File Offset: 0x0008EE10
		public byte[] Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00090C18 File Offset: 0x0008EE18
		public byte[] ToByteArray()
		{
			byte[] array = new byte[this.Size];
			global::NPOI.Util.LittleEndian.PutInt(array, 0, 4 + this._value.Length);
			global::NPOI.Util.LittleEndian.PutInt(array, 4, this._format);
			global::System.Array.Copy(this._value, 0, array, 8, this._value.Length);
			return array;
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00090C66 File Offset: 0x0008EE66
		public int Write(global::System.IO.Stream out1)
		{
			global::NPOI.Util.LittleEndian.PutInt(4 + this._value.Length, out1);
			global::NPOI.Util.LittleEndian.PutInt(this._format, out1);
			out1.Write(this._value, 0, this._value.Length);
			return 8 + this._value.Length;
		}

		// Token: 0x04001563 RID: 5475
		private int _format;

		// Token: 0x04001564 RID: 5476
		private byte[] _value;
	}
}
