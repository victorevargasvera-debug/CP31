using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000096 RID: 150
	public sealed class Certificate
	{
		// Token: 0x0600062F RID: 1583 RVA: 0x00019E78 File Offset: 0x00018078
		private static global::Org.BouncyCastle.Tls.CertificateEntry[] Convert(global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] certificateList)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrContainsNull(certificateList))
			{
				throw new global::System.ArgumentException("cannot be null or contain any nulls", "certificateList");
			}
			int count = certificateList.Length;
			global::Org.BouncyCastle.Tls.CertificateEntry[] result = new global::Org.BouncyCastle.Tls.CertificateEntry[count];
			for (int i = 0; i < count; i++)
			{
				result[i] = new global::Org.BouncyCastle.Tls.CertificateEntry(certificateList[i], null);
			}
			return result;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00019EC3 File Offset: 0x000180C3
		public Certificate(global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] certificateList) : this(null, global::Org.BouncyCastle.Tls.Certificate.Convert(certificateList))
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00019ED4 File Offset: 0x000180D4
		public Certificate(byte[] certificateRequestContext, global::Org.BouncyCastle.Tls.CertificateEntry[] certificateEntryList)
		{
			if (certificateRequestContext != null && !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(certificateRequestContext.Length))
			{
				throw new global::System.ArgumentException("cannot be longer than 255", "certificateRequestContext");
			}
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrContainsNull(certificateEntryList))
			{
				throw new global::System.ArgumentException("cannot be null or contain any nulls", "certificateEntryList");
			}
			this.m_certificateRequestContext = global::Org.BouncyCastle.Tls.TlsUtilities.Clone(certificateRequestContext);
			this.m_certificateEntryList = certificateEntryList;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00019F31 File Offset: 0x00018131
		public byte[] GetCertificateRequestContext()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.Clone(this.m_certificateRequestContext);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00019F3E File Offset: 0x0001813E
		public global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] GetCertificateList()
		{
			return this.CloneCertificateList();
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00019F46 File Offset: 0x00018146
		public global::Org.BouncyCastle.Tls.Crypto.TlsCertificate GetCertificateAt(int index)
		{
			return this.m_certificateEntryList[index].Certificate;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00019F55 File Offset: 0x00018155
		public global::Org.BouncyCastle.Tls.CertificateEntry GetCertificateEntryAt(int index)
		{
			return this.m_certificateEntryList[index];
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00019F5F File Offset: 0x0001815F
		public global::Org.BouncyCastle.Tls.CertificateEntry[] GetCertificateEntryList()
		{
			return this.CloneCertificateEntryList();
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00019F67 File Offset: 0x00018167
		public short CertificateType
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00019F6A File Offset: 0x0001816A
		public int Length
		{
			get
			{
				return this.m_certificateEntryList.Length;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00019F74 File Offset: 0x00018174
		public bool IsEmpty
		{
			get
			{
				return this.m_certificateEntryList.Length == 0;
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00019F80 File Offset: 0x00018180
		public void Encode(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream messageOutput, global::System.IO.Stream endPointHashOutput)
		{
			bool isTlsV13 = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(context);
			if (this.m_certificateRequestContext != null != isTlsV13)
			{
				throw new global::System.InvalidOperationException();
			}
			if (isTlsV13)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_certificateRequestContext, messageOutput);
			}
			int count = this.m_certificateEntryList.Length;
			global::System.Collections.IList certEncodings = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(count);
			global::System.Collections.IList extEncodings = isTlsV13 ? global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(count) : null;
			long totalLength = 0L;
			for (int i = 0; i < count; i++)
			{
				global::Org.BouncyCastle.Tls.CertificateEntry entry = this.m_certificateEntryList[i];
				global::Org.BouncyCastle.Tls.Crypto.TlsCertificate cert = entry.Certificate;
				byte[] derEncoding = cert.GetEncoded();
				if (i == 0 && endPointHashOutput != null)
				{
					global::Org.BouncyCastle.Tls.Certificate.CalculateEndPointHash(context, cert, derEncoding, endPointHashOutput);
				}
				certEncodings.Add(derEncoding);
				totalLength += (long)derEncoding.Length;
				totalLength += 3L;
				if (isTlsV13)
				{
					global::System.Collections.IDictionary extensions = entry.Extensions;
					byte[] extEncoding = (extensions == null) ? global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes : global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensionsData(extensions);
					extEncodings.Add(extEncoding);
					totalLength += (long)extEncoding.Length;
					totalLength += 2L;
				}
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(totalLength);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24((int)totalLength, messageOutput);
			for (int j = 0; j < count; j++)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque24((byte[])certEncodings[j], messageOutput);
				if (isTlsV13)
				{
					global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16((byte[])extEncodings[j], messageOutput);
				}
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001A0B8 File Offset: 0x000182B8
		public static global::Org.BouncyCastle.Tls.Certificate Parse(global::Org.BouncyCastle.Tls.Certificate.ParseOptions options, global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream messageInput, global::System.IO.Stream endPointHashOutput)
		{
			bool isTlsV13 = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(context.SecurityParameters.NegotiatedVersion);
			byte[] certificateRequestContext = null;
			if (isTlsV13)
			{
				certificateRequestContext = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(messageInput);
			}
			int totalLength = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(messageInput);
			if (totalLength != 0)
			{
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(totalLength, messageInput), false);
				global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto = context.Crypto;
				int maxChainLength = global::System.Math.Max(1, options.MaxChainLength);
				global::System.Collections.IList certificate_list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				while (buf.Position < buf.Length)
				{
					if (certificate_list.Count >= maxChainLength)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, "Certificate chain longer than maximum (" + maxChainLength.ToString() + ")");
					}
					byte[] derEncoding = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque24(buf, 1);
					global::Org.BouncyCastle.Tls.Crypto.TlsCertificate cert = crypto.CreateCertificate(derEncoding);
					if (certificate_list.Count < 1 && endPointHashOutput != null)
					{
						global::Org.BouncyCastle.Tls.Certificate.CalculateEndPointHash(context, cert, derEncoding, endPointHashOutput);
					}
					global::System.Collections.IDictionary extensions = null;
					if (isTlsV13)
					{
						byte[] extEncoding = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
						extensions = global::Org.BouncyCastle.Tls.TlsProtocol.ReadExtensionsData13(11, extEncoding);
					}
					certificate_list.Add(new global::Org.BouncyCastle.Tls.CertificateEntry(cert, extensions));
				}
				global::Org.BouncyCastle.Tls.CertificateEntry[] certificateList = new global::Org.BouncyCastle.Tls.CertificateEntry[certificate_list.Count];
				for (int i = 0; i < certificate_list.Count; i++)
				{
					certificateList[i] = (global::Org.BouncyCastle.Tls.CertificateEntry)certificate_list[i];
				}
				return new global::Org.BouncyCastle.Tls.Certificate(certificateRequestContext, certificateList);
			}
			if (!isTlsV13)
			{
				return global::Org.BouncyCastle.Tls.Certificate.EmptyChain;
			}
			if (certificateRequestContext.Length >= 1)
			{
				return new global::Org.BouncyCastle.Tls.Certificate(certificateRequestContext, global::Org.BouncyCastle.Tls.Certificate.EmptyCertEntries);
			}
			return global::Org.BouncyCastle.Tls.Certificate.EmptyChainTls13;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001A20C File Offset: 0x0001840C
		private static void CalculateEndPointHash(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate cert, byte[] encoding, global::System.IO.Stream output)
		{
			byte[] endPointHash = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateEndPointHash(context, cert, encoding);
			if (endPointHash != null && endPointHash.Length != 0)
			{
				output.Write(endPointHash, 0, endPointHash.Length);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001A234 File Offset: 0x00018434
		private global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] CloneCertificateList()
		{
			int count = this.m_certificateEntryList.Length;
			if (count == 0)
			{
				return global::Org.BouncyCastle.Tls.Certificate.EmptyCerts;
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] result = new global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[count];
			for (int i = 0; i < count; i++)
			{
				result[i] = this.m_certificateEntryList[i].Certificate;
			}
			return result;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001A278 File Offset: 0x00018478
		private global::Org.BouncyCastle.Tls.CertificateEntry[] CloneCertificateEntryList()
		{
			int count = this.m_certificateEntryList.Length;
			if (count == 0)
			{
				return global::Org.BouncyCastle.Tls.Certificate.EmptyCertEntries;
			}
			global::Org.BouncyCastle.Tls.CertificateEntry[] result = new global::Org.BouncyCastle.Tls.CertificateEntry[count];
			global::System.Array.Copy(this.m_certificateEntryList, 0, result, 0, count);
			return result;
		}

		// Token: 0x0400033B RID: 827
		private static readonly global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] EmptyCerts = new global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[0];

		// Token: 0x0400033C RID: 828
		private static readonly global::Org.BouncyCastle.Tls.CertificateEntry[] EmptyCertEntries = new global::Org.BouncyCastle.Tls.CertificateEntry[0];

		// Token: 0x0400033D RID: 829
		public static readonly global::Org.BouncyCastle.Tls.Certificate EmptyChain = new global::Org.BouncyCastle.Tls.Certificate(global::Org.BouncyCastle.Tls.Certificate.EmptyCerts);

		// Token: 0x0400033E RID: 830
		public static readonly global::Org.BouncyCastle.Tls.Certificate EmptyChainTls13 = new global::Org.BouncyCastle.Tls.Certificate(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, global::Org.BouncyCastle.Tls.Certificate.EmptyCertEntries);

		// Token: 0x0400033F RID: 831
		private readonly byte[] m_certificateRequestContext;

		// Token: 0x04000340 RID: 832
		private readonly global::Org.BouncyCastle.Tls.CertificateEntry[] m_certificateEntryList;

		// Token: 0x020007A0 RID: 1952
		public sealed class ParseOptions
		{
			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x06004502 RID: 17666 RVA: 0x00132690 File Offset: 0x00130890
			public int MaxChainLength
			{
				get
				{
					return this.m_maxChainLength;
				}
			}

			// Token: 0x06004503 RID: 17667 RVA: 0x00132698 File Offset: 0x00130898
			public global::Org.BouncyCastle.Tls.Certificate.ParseOptions SetMaxChainLength(int maxChainLength)
			{
				this.m_maxChainLength = maxChainLength;
				return this;
			}

			// Token: 0x040022EB RID: 8939
			private int m_maxChainLength = int.MaxValue;
		}
	}
}
