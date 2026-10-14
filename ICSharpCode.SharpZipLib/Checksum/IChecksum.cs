using System;

namespace ICSharpCode.SharpZipLib.Checksum
{
	// Token: 0x02000074 RID: 116
	public interface IChecksum
	{
		// Token: 0x060004B1 RID: 1201
		void Reset();

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004B2 RID: 1202
		long Value { get; }

		// Token: 0x060004B3 RID: 1203
		void Update(int bval);

		// Token: 0x060004B4 RID: 1204
		void Update(byte[] buffer);

		// Token: 0x060004B5 RID: 1205
		void Update(global::System.ArraySegment<byte> segment);
	}
}
