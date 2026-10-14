using System;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x0200050E RID: 1294
	public interface IEncryptedValuePadder
	{
		// Token: 0x06003295 RID: 12949
		byte[] GetPaddedData(byte[] data);

		// Token: 0x06003296 RID: 12950
		byte[] GetUnpaddedData(byte[] paddedData);
	}
}
