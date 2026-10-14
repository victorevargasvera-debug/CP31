using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200001A RID: 26
	internal interface ITaggedDataFactory
	{
		// Token: 0x060000E6 RID: 230
		global::ICSharpCode.SharpZipLib.Zip.ITaggedData Create(short tag, byte[] data, int offset, int count);
	}
}
