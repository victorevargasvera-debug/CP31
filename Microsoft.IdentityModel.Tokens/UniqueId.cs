using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000046 RID: 70
	public static class UniqueId
	{
		// Token: 0x06000209 RID: 521 RVA: 0x000079CA File Offset: 0x00005BCA
		public static string CreateUniqueId()
		{
			return global::Microsoft.IdentityModel.Tokens.UniqueId.optimizedNcNamePrefix + global::Microsoft.IdentityModel.Tokens.UniqueId.GetNextId();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000079DB File Offset: 0x00005BDB
		public static string CreateUniqueId(string prefix)
		{
			if (string.IsNullOrEmpty(prefix))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("prefix");
			}
			return prefix + global::Microsoft.IdentityModel.Tokens.UniqueId.reusableUuid + "-" + global::Microsoft.IdentityModel.Tokens.UniqueId.GetNextId();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007A05 File Offset: 0x00005C05
		public static string CreateRandomId()
		{
			return "_" + global::Microsoft.IdentityModel.Tokens.UniqueId.GetRandomUuid();
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00007A16 File Offset: 0x00005C16
		public static string CreateRandomId(string prefix)
		{
			if (string.IsNullOrEmpty(prefix))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("prefix");
			}
			return prefix + global::Microsoft.IdentityModel.Tokens.UniqueId.GetRandomUuid();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007A36 File Offset: 0x00005C36
		public static global::System.Uri CreateRandomUri()
		{
			return new global::System.Uri("urn:uuid:" + global::Microsoft.IdentityModel.Tokens.UniqueId.GetRandomUuid());
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00007A4C File Offset: 0x00005C4C
		private static string GetNextId()
		{
			global::System.Security.Cryptography.RandomNumberGenerator randomNumberGenerator = global::System.Security.Cryptography.RandomNumberGenerator.Create();
			byte[] array = new byte[16];
			randomNumberGenerator.GetBytes(array);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.AppendFormat("{0:X2}", array[i]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007A9C File Offset: 0x00005C9C
		private static string GetRandomUuid()
		{
			return global::System.Guid.NewGuid().ToString("D");
		}

		// Token: 0x0400018E RID: 398
		private const int RandomSaltSize = 16;

		// Token: 0x0400018F RID: 399
		private const string NcNamePrefix = "_";

		// Token: 0x04000190 RID: 400
		private const string UuidUriPrefix = "urn:uuid:";

		// Token: 0x04000191 RID: 401
		private static readonly string reusableUuid = global::Microsoft.IdentityModel.Tokens.UniqueId.GetRandomUuid();

		// Token: 0x04000192 RID: 402
		private static readonly string optimizedNcNamePrefix = "_" + global::Microsoft.IdentityModel.Tokens.UniqueId.reusableUuid + "-";
	}
}
