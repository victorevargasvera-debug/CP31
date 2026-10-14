using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000016 RID: 22
	public interface ITaggedData
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C4 RID: 196
		short TagID { get; }

		// Token: 0x060000C5 RID: 197
		void SetData(byte[] data, int offset, int count);

		// Token: 0x060000C6 RID: 198
		byte[] GetData();
	}
}
