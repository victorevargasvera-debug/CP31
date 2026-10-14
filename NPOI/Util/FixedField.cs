using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000268 RID: 616
	public interface FixedField
	{
		// Token: 0x06001014 RID: 4116
		void ReadFromBytes(byte[] data);

		// Token: 0x06001015 RID: 4117
		void ReadFromStream(global::System.IO.Stream stream);

		// Token: 0x06001016 RID: 4118
		string ToString();

		// Token: 0x06001017 RID: 4119
		void WriteToBytes(byte[] data);
	}
}
