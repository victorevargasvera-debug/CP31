using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000304 RID: 772
	public class Certificate
	{
		// Token: 0x060020F5 RID: 8437 RVA: 0x000924F6 File Offset: 0x000906F6
		public Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certificateList)
		{
			if (certificateList == null)
			{
				throw new global::System.ArgumentNullException("certificateList");
			}
			this.mCertificateList = certificateList;
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00092513 File Offset: 0x00090713
		public virtual global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] GetCertificateList()
		{
			return this.CloneCertificateList();
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0009251B File Offset: 0x0009071B
		public virtual global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure GetCertificateAt(int index)
		{
			return this.mCertificateList[index];
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x00092525 File Offset: 0x00090725
		public virtual int Length
		{
			get
			{
				return this.mCertificateList.Length;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x0009252F File Offset: 0x0009072F
		public virtual bool IsEmpty
		{
			get
			{
				return this.mCertificateList.Length == 0;
			}
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x0009253C File Offset: 0x0009073C
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::System.Collections.IList derEncodings = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.mCertificateList.Length);
			int totalLength = 0;
			global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] array = this.mCertificateList;
			for (int i = 0; i < array.Length; i++)
			{
				byte[] derEncoding = array[i].GetEncoded("DER");
				derEncodings.Add(derEncoding);
				totalLength += derEncoding.Length + 3;
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint24(totalLength);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(totalLength, output);
			foreach (object obj in derEncodings)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque24((byte[])obj, output);
			}
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000925E8 File Offset: 0x000907E8
		public static global::Org.BouncyCastle.Crypto.Tls.Certificate Parse(global::System.IO.Stream input)
		{
			int totalLength = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(input);
			if (totalLength == 0)
			{
				return global::Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain;
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(totalLength, input), false);
			global::System.Collections.IList certificate_list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object asn1Cert = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadAsn1Object(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque24(buf));
				certificate_list.Add(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(asn1Cert));
			}
			global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certificateList = new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[certificate_list.Count];
			for (int i = 0; i < certificate_list.Count; i++)
			{
				certificateList[i] = (global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure)certificate_list[i];
			}
			return new global::Org.BouncyCastle.Crypto.Tls.Certificate(certificateList);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x0009267C File Offset: 0x0009087C
		protected virtual global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] CloneCertificateList()
		{
			return (global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[])this.mCertificateList.Clone();
		}

		// Token: 0x04000B97 RID: 2967
		public static readonly global::Org.BouncyCastle.Crypto.Tls.Certificate EmptyChain = new global::Org.BouncyCastle.Crypto.Tls.Certificate(new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[0]);

		// Token: 0x04000B98 RID: 2968
		protected readonly global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] mCertificateList;
	}
}
