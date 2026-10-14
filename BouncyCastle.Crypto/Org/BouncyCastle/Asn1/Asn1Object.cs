using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005E0 RID: 1504
	public abstract class Asn1Object : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003864 RID: 14436 RVA: 0x00109A27 File Offset: 0x00107C27
		public override void EncodeTo(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(output).WriteObject(this);
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x00109A35 File Offset: 0x00107C35
		public override void EncodeTo(global::System.IO.Stream output, string encoding)
		{
			global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(output, encoding).WriteObject(this);
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x00109A44 File Offset: 0x00107C44
		public static global::Org.BouncyCastle.Asn1.Asn1Object FromByteArray(byte[] data)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				global::System.IO.MemoryStream input = new global::System.IO.MemoryStream(data, false);
				global::Org.BouncyCastle.Asn1.Asn1Object asn1Object = new global::Org.BouncyCastle.Asn1.Asn1InputStream(input, data.Length).ReadObject();
				if (input.Position != input.Length)
				{
					throw new global::System.IO.IOException("extra data found after object");
				}
				result = asn1Object;
			}
			catch (global::System.InvalidCastException)
			{
				throw new global::System.IO.IOException("cannot recognise object in byte array");
			}
			return result;
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x00109AA0 File Offset: 0x00107CA0
		public static global::Org.BouncyCastle.Asn1.Asn1Object FromStream(global::System.IO.Stream inStr)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				result = new global::Org.BouncyCastle.Asn1.Asn1InputStream(inStr).ReadObject();
			}
			catch (global::System.InvalidCastException)
			{
				throw new global::System.IO.IOException("cannot recognise object in stream");
			}
			return result;
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x00109AD8 File Offset: 0x00107CD8
		public sealed override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this;
		}

		// Token: 0x06003869 RID: 14441
		internal abstract int EncodedLength(bool withID);

		// Token: 0x0600386A RID: 14442
		internal abstract void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID);

		// Token: 0x0600386B RID: 14443
		protected abstract bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object);

		// Token: 0x0600386C RID: 14444
		protected abstract int Asn1GetHashCode();

		// Token: 0x0600386D RID: 14445 RVA: 0x00109ADB File Offset: 0x00107CDB
		internal bool CallAsn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object obj)
		{
			return this.Asn1Equals(obj);
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00109AE4 File Offset: 0x00107CE4
		internal int CallAsn1GetHashCode()
		{
			return this.Asn1GetHashCode();
		}
	}
}
