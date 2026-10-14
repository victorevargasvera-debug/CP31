using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A9 RID: 937
	public class IsoTrailers
	{
		// Token: 0x06002628 RID: 9768 RVA: 0x000A63C0 File Offset: 0x000A45C0
		private static global::System.Collections.IDictionary CreateTrailerMap()
		{
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			dictionary.Add("RIPEMD128", 13004);
			dictionary.Add("RIPEMD160", 12748);
			dictionary.Add("SHA-1", 13260);
			dictionary.Add("SHA-224", 14540);
			dictionary.Add("SHA-256", 13516);
			dictionary.Add("SHA-384", 14028);
			dictionary.Add("SHA-512", 13772);
			dictionary.Add("SHA-512/224", 14796);
			dictionary.Add("SHA-512/256", 16588);
			dictionary.Add("Whirlpool", 14284);
			return global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(dictionary);
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x000A64A9 File Offset: 0x000A46A9
		public static int GetTrailer(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			return (int)global::Org.BouncyCastle.Crypto.Signers.IsoTrailers.trailerMap[digest.AlgorithmName];
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000A64C0 File Offset: 0x000A46C0
		public static bool NoTrailerAvailable(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			return !global::Org.BouncyCastle.Crypto.Signers.IsoTrailers.trailerMap.Contains(digest.AlgorithmName);
		}

		// Token: 0x04000F4C RID: 3916
		public const int TRAILER_IMPLICIT = 188;

		// Token: 0x04000F4D RID: 3917
		public const int TRAILER_RIPEMD160 = 12748;

		// Token: 0x04000F4E RID: 3918
		public const int TRAILER_RIPEMD128 = 13004;

		// Token: 0x04000F4F RID: 3919
		public const int TRAILER_SHA1 = 13260;

		// Token: 0x04000F50 RID: 3920
		public const int TRAILER_SHA256 = 13516;

		// Token: 0x04000F51 RID: 3921
		public const int TRAILER_SHA512 = 13772;

		// Token: 0x04000F52 RID: 3922
		public const int TRAILER_SHA384 = 14028;

		// Token: 0x04000F53 RID: 3923
		public const int TRAILER_WHIRLPOOL = 14284;

		// Token: 0x04000F54 RID: 3924
		public const int TRAILER_SHA224 = 14540;

		// Token: 0x04000F55 RID: 3925
		public const int TRAILER_SHA512_224 = 14796;

		// Token: 0x04000F56 RID: 3926
		public const int TRAILER_SHA512_256 = 16588;

		// Token: 0x04000F57 RID: 3927
		private static readonly global::System.Collections.IDictionary trailerMap = global::Org.BouncyCastle.Crypto.Signers.IsoTrailers.CreateTrailerMap();
	}
}
