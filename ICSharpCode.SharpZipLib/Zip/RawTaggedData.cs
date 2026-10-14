using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000017 RID: 23
	public class RawTaggedData : global::ICSharpCode.SharpZipLib.Zip.ITaggedData
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x000041B8 File Offset: 0x000023B8
		public RawTaggedData(short tag)
		{
			this._tag = tag;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000041C7 File Offset: 0x000023C7
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000041CF File Offset: 0x000023CF
		public short TagID
		{
			get
			{
				return this._tag;
			}
			set
			{
				this._tag = value;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000041D8 File Offset: 0x000023D8
		public void SetData(byte[] data, int offset, int count)
		{
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			this._data = new byte[count];
			global::System.Array.Copy(data, offset, this._data, 0, count);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004203 File Offset: 0x00002403
		public byte[] GetData()
		{
			return this._data;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000420B File Offset: 0x0000240B
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00004213 File Offset: 0x00002413
		public byte[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}

		// Token: 0x040000A8 RID: 168
		private short _tag;

		// Token: 0x040000A9 RID: 169
		private byte[] _data;
	}
}
