using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x0200050C RID: 1292
	public class EncryptedValueBuilder
	{
		// Token: 0x0600328C RID: 12940 RVA: 0x000F228D File Offset: 0x000F048D
		public EncryptedValueBuilder(global::Org.BouncyCastle.Crypto.IKeyWrapper wrapper, global::Org.BouncyCastle.Crypto.ICipherBuilderWithKey encryptor) : this(wrapper, encryptor, null)
		{
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000F2298 File Offset: 0x000F0498
		public EncryptedValueBuilder(global::Org.BouncyCastle.Crypto.IKeyWrapper wrapper, global::Org.BouncyCastle.Crypto.ICipherBuilderWithKey encryptor, global::Org.BouncyCastle.Crmf.IEncryptedValuePadder padder)
		{
			this.wrapper = wrapper;
			this.encryptor = encryptor;
			this.padder = padder;
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000F22B5 File Offset: 0x000F04B5
		public global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue Build(char[] revocationPassphrase)
		{
			return this.EncryptData(this.PadData(global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(revocationPassphrase)));
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000F22CC File Offset: 0x000F04CC
		public global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue Build(global::Org.BouncyCastle.X509.X509Certificate holder)
		{
			global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue result;
			try
			{
				result = this.EncryptData(this.PadData(holder.GetEncoded()));
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Crmf.CrmfException("cannot encode certificate: " + e.Message, e);
			}
			return result;
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000F2318 File Offset: 0x000F0518
		public global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue Build(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privateKeyInfo)
		{
			global::Org.BouncyCastle.Pkcs.Pkcs8EncryptedPrivateKeyInfoBuilder encInfoBldr = new global::Org.BouncyCastle.Pkcs.Pkcs8EncryptedPrivateKeyInfoBuilder(privateKeyInfo);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier intendedAlg = privateKeyInfo.PrivateKeyAlgorithm;
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier symmAlg = (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.encryptor.AlgorithmDetails;
			global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue result;
			try
			{
				global::Org.BouncyCastle.Pkcs.Pkcs8EncryptedPrivateKeyInfo encInfo = encInfoBldr.Build(this.encryptor);
				global::Org.BouncyCastle.Asn1.DerBitString encSymmKey = new global::Org.BouncyCastle.Asn1.DerBitString(this.wrapper.Wrap(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)this.encryptor.Key).GetKey()).Collect());
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyAlg = (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.wrapper.AlgorithmDetails;
				global::Org.BouncyCastle.Asn1.Asn1OctetString valueHint = null;
				result = new global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue(intendedAlg, symmAlg, encSymmKey, keyAlg, valueHint, new global::Org.BouncyCastle.Asn1.DerBitString(encInfo.GetEncryptedData()));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Crmf.CrmfException("cannot wrap key: " + e.Message, e);
			}
			return result;
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000F23DC File Offset: 0x000F05DC
		private global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue EncryptData(byte[] data)
		{
			global::Org.BouncyCastle.Utilities.IO.MemoryOutputStream bOut = new global::Org.BouncyCastle.Utilities.IO.MemoryOutputStream();
			global::System.IO.Stream eOut = this.encryptor.BuildCipher(bOut).Stream;
			try
			{
				eOut.Write(data, 0, data.Length);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(eOut);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Crmf.CrmfException("cannot process data: " + e.Message, e);
			}
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier intendedAlg = null;
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier symmAlg = (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.encryptor.AlgorithmDetails;
			global::Org.BouncyCastle.Asn1.DerBitString encSymmKey;
			try
			{
				encSymmKey = new global::Org.BouncyCastle.Asn1.DerBitString(this.wrapper.Wrap(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)this.encryptor.Key).GetKey()).Collect());
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Crmf.CrmfException("cannot wrap key: " + e2.Message, e2);
			}
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyAlg = (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.wrapper.AlgorithmDetails;
			global::Org.BouncyCastle.Asn1.Asn1OctetString valueHint = null;
			global::Org.BouncyCastle.Asn1.DerBitString encValue = new global::Org.BouncyCastle.Asn1.DerBitString(bOut.ToArray());
			return new global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue(intendedAlg, symmAlg, encSymmKey, keyAlg, valueHint, encValue);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000F24D8 File Offset: 0x000F06D8
		private byte[] PadData(byte[] data)
		{
			if (this.padder != null)
			{
				return this.padder.GetPaddedData(data);
			}
			return data;
		}

		// Token: 0x04001675 RID: 5749
		private readonly global::Org.BouncyCastle.Crypto.IKeyWrapper wrapper;

		// Token: 0x04001676 RID: 5750
		private readonly global::Org.BouncyCastle.Crypto.ICipherBuilderWithKey encryptor;

		// Token: 0x04001677 RID: 5751
		private readonly global::Org.BouncyCastle.Crmf.IEncryptedValuePadder padder;
	}
}
