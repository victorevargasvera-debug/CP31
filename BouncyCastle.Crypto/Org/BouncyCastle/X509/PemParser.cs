using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200000E RID: 14
	internal class PemParser
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00005BF8 File Offset: 0x00003DF8
		internal PemParser(string type)
		{
			this._header1 = "-----BEGIN " + type + "-----";
			this._header2 = "-----BEGIN X509 " + type + "-----";
			this._footer1 = "-----END " + type + "-----";
			this._footer2 = "-----END X509 " + type + "-----";
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005C64 File Offset: 0x00003E64
		private string ReadLine(global::System.IO.Stream inStream)
		{
			global::System.Text.StringBuilder i = new global::System.Text.StringBuilder();
			int c;
			for (;;)
			{
				if ((c = inStream.ReadByte()) == 13 || c == 10 || c < 0)
				{
					if (c < 0 || i.Length != 0)
					{
						break;
					}
				}
				else if (c != 13)
				{
					i.Append((char)c);
				}
			}
			if (c < 0)
			{
				return null;
			}
			return i.ToString();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005CB4 File Offset: 0x00003EB4
		internal global::Org.BouncyCastle.Asn1.Asn1Sequence ReadPemObject(global::System.IO.Stream inStream)
		{
			global::System.Text.StringBuilder pemBuf = new global::System.Text.StringBuilder();
			string line;
			while ((line = this.ReadLine(inStream)) != null)
			{
				if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(line, this._header1) || global::Org.BouncyCastle.Utilities.Platform.StartsWith(line, this._header2))
				{
					IL_55:
					while ((line = this.ReadLine(inStream)) != null && !global::Org.BouncyCastle.Utilities.Platform.StartsWith(line, this._footer1) && !global::Org.BouncyCastle.Utilities.Platform.StartsWith(line, this._footer2))
					{
						pemBuf.Append(line);
					}
					if (pemBuf.Length == 0)
					{
						return null;
					}
					global::Org.BouncyCastle.Asn1.Asn1Object asn1Object = global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(global::Org.BouncyCastle.Utilities.Encoders.Base64.Decode(pemBuf.ToString()));
					if (!(asn1Object is global::Org.BouncyCastle.Asn1.Asn1Sequence))
					{
						throw new global::System.IO.IOException("malformed PEM data encountered");
					}
					return (global::Org.BouncyCastle.Asn1.Asn1Sequence)asn1Object;
				}
			}
			goto IL_55;
		}

		// Token: 0x04000074 RID: 116
		private readonly string _header1;

		// Token: 0x04000075 RID: 117
		private readonly string _header2;

		// Token: 0x04000076 RID: 118
		private readonly string _footer1;

		// Token: 0x04000077 RID: 119
		private readonly string _footer2;
	}
}
