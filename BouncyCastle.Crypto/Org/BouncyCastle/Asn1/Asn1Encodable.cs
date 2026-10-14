using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005DA RID: 1498
	public abstract class Asn1Encodable : global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x0600382C RID: 14380 RVA: 0x00108DB4 File Offset: 0x00106FB4
		public virtual void EncodeTo(global::System.IO.Stream output)
		{
			this.ToAsn1Object().EncodeTo(output);
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00108DC2 File Offset: 0x00106FC2
		public virtual void EncodeTo(global::System.IO.Stream output, string encoding)
		{
			this.ToAsn1Object().EncodeTo(output, encoding);
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00108DD4 File Offset: 0x00106FD4
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.EncodeTo(bOut);
			return bOut.ToArray();
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00108DF4 File Offset: 0x00106FF4
		public byte[] GetEncoded(string encoding)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.EncodeTo(bOut, encoding);
			return bOut.ToArray();
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00108E18 File Offset: 0x00107018
		public byte[] GetDerEncoded()
		{
			byte[] result;
			try
			{
				result = this.GetEncoded("DER");
			}
			catch (global::System.IO.IOException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00108E4C File Offset: 0x0010704C
		public sealed override int GetHashCode()
		{
			return this.ToAsn1Object().CallAsn1GetHashCode();
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00108E5C File Offset: 0x0010705C
		public sealed override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Asn1.IAsn1Convertible other = obj as global::Org.BouncyCastle.Asn1.IAsn1Convertible;
			if (other == null)
			{
				return false;
			}
			global::Org.BouncyCastle.Asn1.Asn1Object o = this.ToAsn1Object();
			global::Org.BouncyCastle.Asn1.Asn1Object o2 = other.ToAsn1Object();
			return o == o2 || (o2 != null && o.CallAsn1Equals(o2));
		}

		// Token: 0x06003833 RID: 14387
		public abstract global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object();

		// Token: 0x0400192D RID: 6445
		public const string Der = "DER";

		// Token: 0x0400192E RID: 6446
		public const string Ber = "BER";
	}
}
