using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000555 RID: 1365
	public abstract class RecipientInformation
	{
		// Token: 0x06003458 RID: 13400 RVA: 0x000FA3FB File Offset: 0x000F85FB
		internal RecipientInformation(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncAlg, global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable)
		{
			this.keyEncAlg = keyEncAlg;
			this.secureReadable = secureReadable;
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x000FA41C File Offset: 0x000F861C
		internal string GetContentAlgorithmName()
		{
			return this.secureReadable.Algorithm.Algorithm.Id;
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600345A RID: 13402 RVA: 0x000FA433 File Offset: 0x000F8633
		public global::Org.BouncyCastle.Cms.RecipientID RecipientID
		{
			get
			{
				return this.rid;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x000FA43B File Offset: 0x000F863B
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithmID
		{
			get
			{
				return this.keyEncAlg;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x000FA443 File Offset: 0x000F8643
		public string KeyEncryptionAlgOid
		{
			get
			{
				return this.keyEncAlg.Algorithm.Id;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x000FA458 File Offset: 0x000F8658
		public global::Org.BouncyCastle.Asn1.Asn1Object KeyEncryptionAlgParams
		{
			get
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = this.keyEncAlg.Parameters;
				if (ae != null)
				{
					return ae.ToAsn1Object();
				}
				return null;
			}
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x000FA47C File Offset: 0x000F867C
		internal global::Org.BouncyCastle.Cms.CmsTypedStream GetContentFromSessionKey(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter sKey)
		{
			global::Org.BouncyCastle.Cms.CmsReadable readable = this.secureReadable.GetReadable(sKey);
			global::Org.BouncyCastle.Cms.CmsTypedStream result;
			try
			{
				result = new global::Org.BouncyCastle.Cms.CmsTypedStream(readable.GetInputStream());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("error getting .", e);
			}
			return result;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x000FA4C4 File Offset: 0x000F86C4
		public byte[] GetContent(global::Org.BouncyCastle.Crypto.ICipherParameters key)
		{
			byte[] result;
			try
			{
				result = global::Org.BouncyCastle.Cms.CmsUtilities.StreamToByteArray(this.GetContentStream(key).ContentStream);
			}
			catch (global::System.IO.IOException e)
			{
				string str = "unable to parse internal stream: ";
				global::System.IO.IOException ex = e;
				throw new global::System.Exception(str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x000FA514 File Offset: 0x000F8714
		public byte[] GetMac()
		{
			if (this.resultMac == null)
			{
				object cryptoObject = this.secureReadable.CryptoObject;
				if (cryptoObject is global::Org.BouncyCastle.Crypto.IMac)
				{
					this.resultMac = global::Org.BouncyCastle.Security.MacUtilities.DoFinal((global::Org.BouncyCastle.Crypto.IMac)cryptoObject);
				}
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.resultMac);
		}

		// Token: 0x06003461 RID: 13409
		public abstract global::Org.BouncyCastle.Cms.CmsTypedStream GetContentStream(global::Org.BouncyCastle.Crypto.ICipherParameters key);

		// Token: 0x04001767 RID: 5991
		internal global::Org.BouncyCastle.Cms.RecipientID rid = new global::Org.BouncyCastle.Cms.RecipientID();

		// Token: 0x04001768 RID: 5992
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncAlg;

		// Token: 0x04001769 RID: 5993
		internal global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable;

		// Token: 0x0400176A RID: 5994
		private byte[] resultMac;
	}
}
