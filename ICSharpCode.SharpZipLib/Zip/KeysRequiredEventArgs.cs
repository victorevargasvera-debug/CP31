using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200001C RID: 28
	public class KeysRequiredEventArgs : global::System.EventArgs
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00004DB6 File Offset: 0x00002FB6
		public KeysRequiredEventArgs(string name)
		{
			this.fileName = name;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004DC5 File Offset: 0x00002FC5
		public KeysRequiredEventArgs(string name, byte[] keyValue)
		{
			this.fileName = name;
			this.key = keyValue;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004DDB File Offset: 0x00002FDB
		public string FileName
		{
			get
			{
				return this.fileName;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004DE3 File Offset: 0x00002FE3
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00004DEB File Offset: 0x00002FEB
		public byte[] Key
		{
			get
			{
				return this.key;
			}
			set
			{
				this.key = value;
			}
		}

		// Token: 0x040000B6 RID: 182
		private readonly string fileName;

		// Token: 0x040000B7 RID: 183
		private byte[] key;
	}
}
