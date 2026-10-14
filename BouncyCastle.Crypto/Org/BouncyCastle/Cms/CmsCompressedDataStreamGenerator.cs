using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000526 RID: 1318
	public class CmsCompressedDataStreamGenerator
	{
		// Token: 0x060032FC RID: 13052 RVA: 0x000F3760 File Offset: 0x000F1960
		public void SetBufferSize(int bufferSize)
		{
			this._bufferSize = bufferSize;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000F3769 File Offset: 0x000F1969
		public global::System.IO.Stream Open(global::System.IO.Stream outStream, string compressionOID)
		{
			return this.Open(outStream, global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data.Id, compressionOID);
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x000F3780 File Offset: 0x000F1980
		public global::System.IO.Stream Open(global::System.IO.Stream outStream, string contentOID, string compressionOID)
		{
			global::Org.BouncyCastle.Asn1.BerSequenceGenerator sGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(outStream);
			sGen.AddObject(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.CompressedData);
			global::Org.BouncyCastle.Asn1.BerSequenceGenerator cGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(sGen.GetRawOutputStream(), 0, true);
			cGen.AddObject(new global::Org.BouncyCastle.Asn1.DerInteger(0));
			cGen.AddObject(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.3.8")));
			global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(cGen.GetRawOutputStream());
			eiGen.AddObject(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(contentOID));
			return new global::Org.BouncyCastle.Cms.CmsCompressedDataStreamGenerator.CmsCompressedOutputStream(new global::Org.BouncyCastle.Utilities.Zlib.ZOutputStream(global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerOctetOutputStream(eiGen.GetRawOutputStream(), 0, true, this._bufferSize), -1), sGen, cGen, eiGen);
		}

		// Token: 0x040016B6 RID: 5814
		public const string ZLib = "1.2.840.113549.1.9.16.3.8";

		// Token: 0x040016B7 RID: 5815
		private int _bufferSize;

		// Token: 0x0200083A RID: 2106
		private class CmsCompressedOutputStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
		{
			// Token: 0x0600470E RID: 18190 RVA: 0x0013A017 File Offset: 0x00138217
			internal CmsCompressedOutputStream(global::Org.BouncyCastle.Utilities.Zlib.ZOutputStream outStream, global::Org.BouncyCastle.Asn1.BerSequenceGenerator sGen, global::Org.BouncyCastle.Asn1.BerSequenceGenerator cGen, global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen)
			{
				this._out = outStream;
				this._sGen = sGen;
				this._cGen = cGen;
				this._eiGen = eiGen;
			}

			// Token: 0x0600470F RID: 18191 RVA: 0x0013A03C File Offset: 0x0013823C
			public override void WriteByte(byte b)
			{
				this._out.WriteByte(b);
			}

			// Token: 0x06004710 RID: 18192 RVA: 0x0013A04A File Offset: 0x0013824A
			public override void Write(byte[] bytes, int off, int len)
			{
				this._out.Write(bytes, off, len);
			}

			// Token: 0x06004711 RID: 18193 RVA: 0x0013A05A File Offset: 0x0013825A
			public override void Close()
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this._out);
				this._eiGen.Close();
				this._cGen.Close();
				this._sGen.Close();
				base.Close();
			}

			// Token: 0x04002581 RID: 9601
			private global::Org.BouncyCastle.Utilities.Zlib.ZOutputStream _out;

			// Token: 0x04002582 RID: 9602
			private global::Org.BouncyCastle.Asn1.BerSequenceGenerator _sGen;

			// Token: 0x04002583 RID: 9603
			private global::Org.BouncyCastle.Asn1.BerSequenceGenerator _cGen;

			// Token: 0x04002584 RID: 9604
			private global::Org.BouncyCastle.Asn1.BerSequenceGenerator _eiGen;
		}
	}
}
