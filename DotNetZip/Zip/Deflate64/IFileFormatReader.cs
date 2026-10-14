using System;

namespace Ionic.Zip.Deflate64
{
	// Token: 0x0200005B RID: 91
	internal interface IFileFormatReader
	{
		// Token: 0x0600048C RID: 1164
		bool ReadHeader(global::Ionic.Zip.Deflate64.InputBuffer input);

		// Token: 0x0600048D RID: 1165
		bool ReadFooter(global::Ionic.Zip.Deflate64.InputBuffer input);

		// Token: 0x0600048E RID: 1166
		void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy);

		// Token: 0x0600048F RID: 1167
		void Validate();
	}
}
