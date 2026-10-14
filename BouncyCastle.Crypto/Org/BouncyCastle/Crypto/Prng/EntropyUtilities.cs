using System;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B5 RID: 949
	public abstract class EntropyUtilities
	{
		// Token: 0x06002695 RID: 9877 RVA: 0x000A7FF4 File Offset: 0x000A61F4
		public static byte[] GenerateSeed(global::Org.BouncyCastle.Crypto.IEntropySource entropySource, int numBytes)
		{
			byte[] bytes = new byte[numBytes];
			int toCopy;
			for (int count = 0; count < numBytes; count += toCopy)
			{
				global::System.Array entropy = entropySource.GetEntropy();
				toCopy = global::System.Math.Min(bytes.Length, numBytes - count);
				global::System.Array.Copy(entropy, 0, bytes, count, toCopy);
			}
			return bytes;
		}
	}
}
