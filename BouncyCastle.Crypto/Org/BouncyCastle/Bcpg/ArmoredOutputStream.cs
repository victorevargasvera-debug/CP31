using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000568 RID: 1384
	public class ArmoredOutputStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x060034EB RID: 13547 RVA: 0x000FC7F8 File Offset: 0x000FA9F8
		private static void Encode(global::System.IO.Stream outStream, int[] data, int len)
		{
			byte[] bs = new byte[4];
			int d = data[0];
			bs[0] = global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.encodingTable[d >> 2 & 63];
			switch (len)
			{
			case 1:
				bs[1] = global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.encodingTable[d << 4 & 63];
				bs[2] = 61;
				bs[3] = 61;
				break;
			case 2:
			{
				int d2 = data[1];
				bs[1] = global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.encodingTable[(d << 4 | d2 >> 4) & 63];
				bs[2] = global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.encodingTable[d2 << 2 & 63];
				bs[3] = 61;
				break;
			}
			case 3:
			{
				int d3 = data[1];
				int d4 = data[2];
				bs[1] = global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.encodingTable[(d << 4 | d3 >> 4) & 63];
				bs[2] = global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.encodingTable[(d3 << 2 | d4 >> 6) & 63];
				bs[3] = global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.encodingTable[d4 & 63];
				break;
			}
			}
			outStream.Write(bs, 0, bs.Length);
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x000FC8CC File Offset: 0x000FAACC
		public ArmoredOutputStream(global::System.IO.Stream outStream)
		{
			this.outStream = outStream;
			this.headers = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(1);
			this.SetHeader(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.HeaderVersion, global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.Version);
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000FC920 File Offset: 0x000FAB20
		public ArmoredOutputStream(global::System.IO.Stream outStream, global::System.Collections.IDictionary headers) : this(outStream)
		{
			foreach (object obj in headers.Keys)
			{
				string header = (string)obj;
				global::System.Collections.IList headerList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
				headerList.Add(headers[header]);
				this.headers[header] = headerList;
			}
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x000FC99C File Offset: 0x000FAB9C
		public void SetHeader(string name, string val)
		{
			if (val == null)
			{
				this.headers.Remove(name);
				return;
			}
			global::System.Collections.IList valueList = (global::System.Collections.IList)this.headers[name];
			if (valueList == null)
			{
				valueList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
				this.headers[name] = valueList;
			}
			else
			{
				valueList.Clear();
			}
			valueList.Add(val);
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x000FC9F4 File Offset: 0x000FABF4
		public void AddHeader(string name, string val)
		{
			if (val == null || name == null)
			{
				return;
			}
			global::System.Collections.IList valueList = (global::System.Collections.IList)this.headers[name];
			if (valueList == null)
			{
				valueList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
				this.headers[name] = valueList;
			}
			valueList.Add(val);
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000FCA3C File Offset: 0x000FAC3C
		public void ResetHeaders()
		{
			global::System.Collections.IList versions = (global::System.Collections.IList)this.headers[global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.HeaderVersion];
			this.headers.Clear();
			if (versions != null)
			{
				this.headers[global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.HeaderVersion] = versions;
			}
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000FCA80 File Offset: 0x000FAC80
		public void BeginClearText(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm)
		{
			string hash;
			switch (hashAlgorithm)
			{
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.MD5:
				hash = "MD5";
				goto IL_87;
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1:
				hash = "SHA1";
				goto IL_87;
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.RipeMD160:
				hash = "RIPEMD160";
				goto IL_87;
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.MD2:
				hash = "MD2";
				goto IL_87;
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha256:
				hash = "SHA256";
				goto IL_87;
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha384:
				hash = "SHA384";
				goto IL_87;
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha512:
				hash = "SHA512";
				goto IL_87;
			}
			throw new global::System.IO.IOException("unknown hash algorithm tag in beginClearText: " + hashAlgorithm.ToString());
			IL_87:
			this.DoWrite("-----BEGIN PGP SIGNED MESSAGE-----" + global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl);
			this.DoWrite("Hash: " + hash + global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl + global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl);
			this.clearText = true;
			this.newLine = true;
			this.lastb = 0;
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000FCB59 File Offset: 0x000FAD59
		public void EndClearText()
		{
			this.clearText = false;
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x000FCB64 File Offset: 0x000FAD64
		public override void WriteByte(byte b)
		{
			if (this.clearText)
			{
				this.outStream.WriteByte(b);
				if (this.newLine)
				{
					if (b != 10 || this.lastb != 13)
					{
						this.newLine = false;
					}
					if (b == 45)
					{
						this.outStream.WriteByte(32);
						this.outStream.WriteByte(45);
					}
				}
				if (b == 13 || (b == 10 && this.lastb != 13))
				{
					this.newLine = true;
				}
				this.lastb = (int)b;
				return;
			}
			if (this.start)
			{
				int tag;
				if ((b & 64) > 0)
				{
					tag = (int)(b & 63);
				}
				else
				{
					tag = (b & 63) >> 2;
				}
				switch (tag)
				{
				case 2:
					this.type = "SIGNATURE";
					goto IL_E8;
				case 5:
					this.type = "PRIVATE KEY BLOCK";
					goto IL_E8;
				case 6:
					this.type = "PUBLIC KEY BLOCK";
					goto IL_E8;
				}
				this.type = "MESSAGE";
				IL_E8:
				this.DoWrite(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.headerStart + this.type + global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.headerTail + global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl);
				global::System.Collections.IList versionHeaders = (global::System.Collections.IList)this.headers[global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.HeaderVersion];
				if (versionHeaders != null)
				{
					this.WriteHeaderEntry(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.HeaderVersion, versionHeaders[0].ToString());
				}
				foreach (object obj in this.headers)
				{
					global::System.Collections.DictionaryEntry de = (global::System.Collections.DictionaryEntry)obj;
					string i = (string)de.Key;
					if (i != global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.HeaderVersion)
					{
						foreach (object obj2 in ((global::System.Collections.IList)de.Value))
						{
							string v = (string)obj2;
							this.WriteHeaderEntry(i, v);
						}
					}
				}
				this.DoWrite(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl);
				this.start = false;
			}
			int num;
			if (this.bufPtr == 3)
			{
				global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.Encode(this.outStream, this.buf, this.bufPtr);
				this.bufPtr = 0;
				num = this.chunkCount + 1;
				this.chunkCount = num;
				if ((num & 15) == 0)
				{
					this.DoWrite(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl);
				}
			}
			this.crc.Update((int)b);
			int[] array = this.buf;
			num = this.bufPtr;
			this.bufPtr = num + 1;
			array[num] = (b & byte.MaxValue);
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x000FCDF4 File Offset: 0x000FAFF4
		public override void Close()
		{
			if (this.type == null)
			{
				return;
			}
			this.DoClose();
			this.type = null;
			this.start = true;
			base.Close();
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000FCE1C File Offset: 0x000FB01C
		private void DoClose()
		{
			if (this.bufPtr > 0)
			{
				global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.Encode(this.outStream, this.buf, this.bufPtr);
			}
			this.DoWrite(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl + "=");
			int crcV = this.crc.Value;
			this.buf[0] = (crcV >> 16 & 255);
			this.buf[1] = (crcV >> 8 & 255);
			this.buf[2] = (crcV & 255);
			global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.Encode(this.outStream, this.buf, 3);
			this.DoWrite(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl);
			this.DoWrite(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.footerStart);
			this.DoWrite(this.type);
			this.DoWrite(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.footerTail);
			this.DoWrite(global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl);
			this.outStream.Flush();
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x000FCEF1 File Offset: 0x000FB0F1
		private void WriteHeaderEntry(string name, string v)
		{
			this.DoWrite(name + ": " + v + global::Org.BouncyCastle.Bcpg.ArmoredOutputStream.nl);
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x000FCF0C File Offset: 0x000FB10C
		private void DoWrite(string s)
		{
			byte[] bs = global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s);
			this.outStream.Write(bs, 0, bs.Length);
		}

		// Token: 0x040017A9 RID: 6057
		public static readonly string HeaderVersion = "Version";

		// Token: 0x040017AA RID: 6058
		private static readonly byte[] encodingTable = new byte[]
		{
			65,
			66,
			67,
			68,
			69,
			70,
			71,
			72,
			73,
			74,
			75,
			76,
			77,
			78,
			79,
			80,
			81,
			82,
			83,
			84,
			85,
			86,
			87,
			88,
			89,
			90,
			97,
			98,
			99,
			100,
			101,
			102,
			103,
			104,
			105,
			106,
			107,
			108,
			109,
			110,
			111,
			112,
			113,
			114,
			115,
			116,
			117,
			118,
			119,
			120,
			121,
			122,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			43,
			47
		};

		// Token: 0x040017AB RID: 6059
		private readonly global::System.IO.Stream outStream;

		// Token: 0x040017AC RID: 6060
		private int[] buf = new int[3];

		// Token: 0x040017AD RID: 6061
		private int bufPtr;

		// Token: 0x040017AE RID: 6062
		private global::Org.BouncyCastle.Bcpg.Crc24 crc = new global::Org.BouncyCastle.Bcpg.Crc24();

		// Token: 0x040017AF RID: 6063
		private int chunkCount;

		// Token: 0x040017B0 RID: 6064
		private int lastb;

		// Token: 0x040017B1 RID: 6065
		private bool start = true;

		// Token: 0x040017B2 RID: 6066
		private bool clearText;

		// Token: 0x040017B3 RID: 6067
		private bool newLine;

		// Token: 0x040017B4 RID: 6068
		private string type;

		// Token: 0x040017B5 RID: 6069
		private static readonly string nl = global::Org.BouncyCastle.Utilities.Platform.NewLine;

		// Token: 0x040017B6 RID: 6070
		private static readonly string headerStart = "-----BEGIN PGP ";

		// Token: 0x040017B7 RID: 6071
		private static readonly string headerTail = "-----";

		// Token: 0x040017B8 RID: 6072
		private static readonly string footerStart = "-----END PGP ";

		// Token: 0x040017B9 RID: 6073
		private static readonly string footerTail = "-----";

		// Token: 0x040017BA RID: 6074
		private static readonly string Version = "BCPG C# v" + global::AssemblyInfo.Version;

		// Token: 0x040017BB RID: 6075
		private readonly global::System.Collections.IDictionary headers;
	}
}
