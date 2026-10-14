using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000540 RID: 1344
	internal class CmsUtilities
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060033F0 RID: 13296 RVA: 0x000F89CC File Offset: 0x000F6BCC
		internal static int MaximumMemory
		{
			get
			{
				long maxMem = 2147483647L;
				if (maxMem > 2147483647L)
				{
					return int.MaxValue;
				}
				return (int)maxMem;
			}
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000F89F1 File Offset: 0x000F6BF1
		internal static global::Org.BouncyCastle.Asn1.Cms.ContentInfo ReadContentInfo(byte[] input)
		{
			return global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(new global::Org.BouncyCastle.Asn1.Asn1InputStream(input));
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000F89FE File Offset: 0x000F6BFE
		internal static global::Org.BouncyCastle.Asn1.Cms.ContentInfo ReadContentInfo(global::System.IO.Stream input)
		{
			return global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(new global::Org.BouncyCastle.Asn1.Asn1InputStream(input, global::Org.BouncyCastle.Cms.CmsUtilities.MaximumMemory));
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000F8A10 File Offset: 0x000F6C10
		private static global::Org.BouncyCastle.Asn1.Cms.ContentInfo ReadContentInfo(global::Org.BouncyCastle.Asn1.Asn1InputStream aIn)
		{
			global::Org.BouncyCastle.Asn1.Cms.ContentInfo instance;
			try
			{
				instance = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(aIn.ReadObject());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("IOException reading content.", e);
			}
			catch (global::System.InvalidCastException e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("Malformed content.", e2);
			}
			catch (global::System.ArgumentException e3)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("Malformed content.", e3);
			}
			return instance;
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x000F8A7C File Offset: 0x000F6C7C
		public static byte[] StreamToByteArray(global::System.IO.Stream inStream)
		{
			return global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(inStream);
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x000F8A84 File Offset: 0x000F6C84
		public static byte[] StreamToByteArray(global::System.IO.Stream inStream, int limit)
		{
			return global::Org.BouncyCastle.Utilities.IO.Streams.ReadAllLimited(inStream, limit);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x000F8A90 File Offset: 0x000F6C90
		public static global::System.Collections.IList GetCertificatesFromStore(global::Org.BouncyCastle.X509.Store.IX509Store certStore)
		{
			global::System.Collections.IList result;
			try
			{
				global::System.Collections.IList certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				if (certStore != null)
				{
					foreach (object obj in certStore.GetMatches(null))
					{
						global::Org.BouncyCastle.X509.X509Certificate c = (global::Org.BouncyCastle.X509.X509Certificate)obj;
						certs.Add(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(c.GetEncoded())));
					}
				}
				result = certs;
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("error encoding certs", e);
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("error processing certs", e2);
			}
			return result;
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x000F8B40 File Offset: 0x000F6D40
		public static global::System.Collections.IList GetCrlsFromStore(global::Org.BouncyCastle.X509.Store.IX509Store crlStore)
		{
			global::System.Collections.IList result;
			try
			{
				global::System.Collections.IList crls = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				if (crlStore != null)
				{
					foreach (object obj in crlStore.GetMatches(null))
					{
						global::Org.BouncyCastle.X509.X509Crl c = (global::Org.BouncyCastle.X509.X509Crl)obj;
						crls.Add(global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(c.GetEncoded())));
					}
				}
				result = crls;
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CrlException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("error encoding crls", e);
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("error processing crls", e2);
			}
			return result;
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x000F8BF0 File Offset: 0x000F6DF0
		public static global::Org.BouncyCastle.Asn1.Asn1Set CreateBerSetFromList(global::System.Collections.IList berObjects)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in berObjects)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
				v.Add(ae);
			}
			return new global::Org.BouncyCastle.Asn1.BerSet(v);
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x000F8C50 File Offset: 0x000F6E50
		public static global::Org.BouncyCastle.Asn1.Asn1Set CreateDerSetFromList(global::System.Collections.IList derObjects)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in derObjects)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
				v.Add(ae);
			}
			return new global::Org.BouncyCastle.Asn1.DerSet(v);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x000F8CB0 File Offset: 0x000F6EB0
		internal static global::System.IO.Stream CreateBerOctetOutputStream(global::System.IO.Stream s, int tagNo, bool isExplicit, int bufferSize)
		{
			return new global::Org.BouncyCastle.Asn1.BerOctetStringGenerator(s, tagNo, isExplicit).GetOctetOutputStream(bufferSize);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000F8CC0 File Offset: 0x000F6EC0
		internal static global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure GetTbsCertificateStructure(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			return global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(cert.GetTbsCertificate()));
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x000F8CD4 File Offset: 0x000F6ED4
		internal static global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber GetIssuerAndSerialNumber(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert = global::Org.BouncyCastle.Cms.CmsUtilities.GetTbsCertificateStructure(cert);
			return new global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber(tbsCert.Issuer, tbsCert.SerialNumber.Value);
		}
	}
}
