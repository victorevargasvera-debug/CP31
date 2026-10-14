using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000503 RID: 1283
	public class UnicodeString
	{
		// Token: 0x06002FF2 RID: 12274 RVA: 0x000915B8 File Offset: 0x0008F7B8
		public UnicodeString(byte[] data, int offset)
		{
			int @int = global::NPOI.Util.LittleEndian.GetInt(data, offset);
			int offset2 = offset + 4;
			if (!this.validLength(@int, data, offset2))
			{
				bool flag = false;
				int num = offset % 4;
				if (num != 0)
				{
					offset += num;
					@int = global::NPOI.Util.LittleEndian.GetInt(data, offset);
					offset2 = offset + 4;
					flag = this.validLength(@int, data, offset2);
				}
				if (!flag)
				{
					throw new global::NPOI.HPSF.IllegalPropertySetDataException("UnicodeString started at offset #" + offset.ToString() + " is not NULL-terminated");
				}
			}
			if (@int == 0)
			{
				this._value = new byte[0];
				return;
			}
			this._value = global::NPOI.Util.LittleEndian.GetByteArray(data, offset2, @int * 2);
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00091648 File Offset: 0x0008F848
		private bool validLength(int length, byte[] data, int offset)
		{
			if (length == 0)
			{
				return true;
			}
			int num = offset + length * 2;
			return num <= data.Length && data[num - 1] == 0 && data[num - 2] == 0;
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x00091677 File Offset: 0x0008F877
		public int Size
		{
			get
			{
				return 4 + this._value.Length;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x00091683 File Offset: 0x0008F883
		public byte[] Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0009168C File Offset: 0x0008F88C
		public string ToJavaString()
		{
			if (this._value.Length == 0)
			{
				return null;
			}
			string fromUnicodeLE = global::NPOI.Util.StringUtil.GetFromUnicodeLE(this._value, 0, this._value.Length >> 1);
			int num = fromUnicodeLE.IndexOf('\0');
			if (num == -1)
			{
				return fromUnicodeLE;
			}
			int num2 = fromUnicodeLE.Length - 1;
			return fromUnicodeLE.Substring(0, num);
		}

		// Token: 0x0400157C RID: 5500
		private byte[] _value;
	}
}
