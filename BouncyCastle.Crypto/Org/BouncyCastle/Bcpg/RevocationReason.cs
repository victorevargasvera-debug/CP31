using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000593 RID: 1427
	public class RevocationReason : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x060035E6 RID: 13798 RVA: 0x000FFF06 File Offset: 0x000FE106
		public RevocationReason(bool isCritical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.RevocationReason, isCritical, isLongLength, data)
		{
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x000FFF13 File Offset: 0x000FE113
		public RevocationReason(bool isCritical, global::Org.BouncyCastle.Bcpg.RevocationReasonTag reason, string description) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.RevocationReason, isCritical, false, global::Org.BouncyCastle.Bcpg.RevocationReason.CreateData(reason, description))
		{
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x000FFF28 File Offset: 0x000FE128
		private static byte[] CreateData(global::Org.BouncyCastle.Bcpg.RevocationReasonTag reason, string description)
		{
			byte[] descriptionBytes = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(description);
			byte[] data = new byte[1 + descriptionBytes.Length];
			data[0] = (byte)reason;
			global::System.Array.Copy(descriptionBytes, 0, data, 1, descriptionBytes.Length);
			return data;
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x000FFF58 File Offset: 0x000FE158
		public virtual global::Org.BouncyCastle.Bcpg.RevocationReasonTag GetRevocationReason()
		{
			return (global::Org.BouncyCastle.Bcpg.RevocationReasonTag)base.GetData()[0];
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x000FFF64 File Offset: 0x000FE164
		public virtual string GetRevocationDescription()
		{
			byte[] data = base.GetData();
			if (data.Length == 1)
			{
				return string.Empty;
			}
			byte[] description = new byte[data.Length - 1];
			global::System.Array.Copy(data, 1, description, 0, description.Length);
			return global::Org.BouncyCastle.Utilities.Strings.FromUtf8ByteArray(description);
		}
	}
}
