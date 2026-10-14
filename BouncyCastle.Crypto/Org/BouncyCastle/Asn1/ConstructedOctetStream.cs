using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005FE RID: 1534
	internal class ConstructedOctetStream : global::Org.BouncyCastle.Utilities.IO.BaseInputStream
	{
		// Token: 0x0600392E RID: 14638 RVA: 0x0010B730 File Offset: 0x00109930
		internal ConstructedOctetStream(global::Org.BouncyCastle.Asn1.Asn1StreamParser parser)
		{
			this._parser = parser;
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x0010B748 File Offset: 0x00109948
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._currentStream == null)
			{
				if (!this._first)
				{
					return 0;
				}
				global::Org.BouncyCastle.Asn1.Asn1OctetStringParser next = this.GetNextParser();
				if (next == null)
				{
					return 0;
				}
				this._first = false;
				this._currentStream = next.GetOctetStream();
			}
			int totalRead = 0;
			for (;;)
			{
				int numRead = this._currentStream.Read(buffer, offset + totalRead, count - totalRead);
				if (numRead > 0)
				{
					totalRead += numRead;
					if (totalRead == count)
					{
						break;
					}
				}
				else
				{
					global::Org.BouncyCastle.Asn1.Asn1OctetStringParser next2 = this.GetNextParser();
					if (next2 == null)
					{
						goto Block_6;
					}
					this._currentStream = next2.GetOctetStream();
				}
			}
			return totalRead;
			Block_6:
			this._currentStream = null;
			return totalRead;
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x0010B7CC File Offset: 0x001099CC
		public override int ReadByte()
		{
			if (this._currentStream == null)
			{
				if (!this._first)
				{
					return 0;
				}
				global::Org.BouncyCastle.Asn1.Asn1OctetStringParser next = this.GetNextParser();
				if (next == null)
				{
					return 0;
				}
				this._first = false;
				this._currentStream = next.GetOctetStream();
			}
			int b;
			for (;;)
			{
				b = this._currentStream.ReadByte();
				if (b >= 0)
				{
					break;
				}
				global::Org.BouncyCastle.Asn1.Asn1OctetStringParser next2 = this.GetNextParser();
				if (next2 == null)
				{
					goto Block_5;
				}
				this._currentStream = next2.GetOctetStream();
			}
			return b;
			Block_5:
			this._currentStream = null;
			return -1;
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x0010B83C File Offset: 0x00109A3C
		private global::Org.BouncyCastle.Asn1.Asn1OctetStringParser GetNextParser()
		{
			global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Obj = this._parser.ReadObject();
			if (asn1Obj == null)
			{
				return null;
			}
			if (asn1Obj is global::Org.BouncyCastle.Asn1.Asn1OctetStringParser)
			{
				return (global::Org.BouncyCastle.Asn1.Asn1OctetStringParser)asn1Obj;
			}
			throw new global::System.IO.IOException("unknown object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(asn1Obj));
		}

		// Token: 0x04001979 RID: 6521
		private readonly global::Org.BouncyCastle.Asn1.Asn1StreamParser _parser;

		// Token: 0x0400197A RID: 6522
		private bool _first = true;

		// Token: 0x0400197B RID: 6523
		private global::System.IO.Stream _currentStream;
	}
}
