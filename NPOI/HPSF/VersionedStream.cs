using System;

namespace NPOI.HPSF
{
	// Token: 0x02000507 RID: 1287
	public class VersionedStream
	{
		// Token: 0x06003000 RID: 12288 RVA: 0x00091817 File Offset: 0x0008FA17
		public VersionedStream(byte[] data, int offset)
		{
			this._versionGuid = new global::NPOI.HPSF.GUID(data, offset);
			this._streamName = new global::NPOI.HPSF.IndirectPropertyName(data, offset + 16);
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x0009183C File Offset: 0x0008FA3C
		public int Size
		{
			get
			{
				return 16 + this._streamName.Size;
			}
		}

		// Token: 0x04001581 RID: 5505
		private global::NPOI.HPSF.GUID _versionGuid;

		// Token: 0x04001582 RID: 5506
		private global::NPOI.HPSF.IndirectPropertyName _streamName;
	}
}
