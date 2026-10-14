using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F0 RID: 1520
	public abstract class BerGenerator : global::Org.BouncyCastle.Asn1.Asn1Generator
	{
		// Token: 0x060038E0 RID: 14560 RVA: 0x0010AEB3 File Offset: 0x001090B3
		protected BerGenerator(global::System.IO.Stream outStream) : base(outStream)
		{
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0010AEBC File Offset: 0x001090BC
		protected BerGenerator(global::System.IO.Stream outStream, int tagNo, bool isExplicit) : base(outStream)
		{
			this._tagged = true;
			this._isExplicit = isExplicit;
			this._tagNo = tagNo;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0010AEDA File Offset: 0x001090DA
		public override void AddObject(global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			obj.EncodeTo(base.Out);
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0010AEE8 File Offset: 0x001090E8
		public override void AddObject(global::Org.BouncyCastle.Asn1.Asn1Object obj)
		{
			obj.EncodeTo(base.Out);
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0010AEF6 File Offset: 0x001090F6
		public override global::System.IO.Stream GetRawOutputStream()
		{
			return base.Out;
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x0010AEFE File Offset: 0x001090FE
		public override void Close()
		{
			this.WriteBerEnd();
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x0010AF06 File Offset: 0x00109106
		private void WriteHdr(int tag)
		{
			base.Out.WriteByte((byte)tag);
			base.Out.WriteByte(128);
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0010AF28 File Offset: 0x00109128
		protected void WriteBerHeader(int tag)
		{
			if (!this._tagged)
			{
				this.WriteHdr(tag);
				return;
			}
			int tagNum = this._tagNo | 128;
			if (this._isExplicit)
			{
				this.WriteHdr(tagNum | 32);
				this.WriteHdr(tag);
				return;
			}
			if ((tag & 32) != 0)
			{
				this.WriteHdr(tagNum | 32);
				return;
			}
			this.WriteHdr(tagNum);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0010AF84 File Offset: 0x00109184
		protected void WriteBerBody(global::System.IO.Stream contentStream)
		{
			global::Org.BouncyCastle.Utilities.IO.Streams.PipeAll(contentStream, base.Out);
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0010AF94 File Offset: 0x00109194
		protected void WriteBerEnd()
		{
			base.Out.WriteByte(0);
			base.Out.WriteByte(0);
			if (this._tagged && this._isExplicit)
			{
				base.Out.WriteByte(0);
				base.Out.WriteByte(0);
			}
		}

		// Token: 0x0400196A RID: 6506
		private bool _tagged;

		// Token: 0x0400196B RID: 6507
		private bool _isExplicit;

		// Token: 0x0400196C RID: 6508
		private int _tagNo;
	}
}
