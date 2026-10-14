using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x0200005C RID: 92
	public class PemReader
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x000141F0 File Offset: 0x000123F0
		public PemReader(global::System.IO.TextReader reader)
		{
			if (reader == null)
			{
				throw new global::System.ArgumentNullException("reader");
			}
			this.buffer = new global::System.IO.MemoryStream();
			this.textBuffer = new global::System.IO.StreamWriter(this.buffer);
			this.reader = reader;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0001423F File Offset: 0x0001243F
		public global::System.IO.TextReader Reader
		{
			get
			{
				return this.reader;
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00014248 File Offset: 0x00012448
		public global::Org.BouncyCastle.Utilities.IO.Pem.PemObject ReadPemObject()
		{
			while (this.seekDash())
			{
				if (!this.consumeDash())
				{
					throw new global::System.IO.IOException("no data after consuming leading dashes");
				}
				this.skipWhiteSpace();
				if (this.expect("BEGIN"))
				{
					this.skipWhiteSpace();
					if (!this.bufferUntilStopChar('-', false))
					{
						throw new global::System.IO.IOException("ran out of data before consuming type");
					}
					string type = this.bufferedString().Trim();
					if (!this.consumeDash())
					{
						throw new global::System.IO.IOException("ran out of data consuming header");
					}
					this.skipWhiteSpace();
					global::System.Collections.IList headers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
					while (this.seekColon(64))
					{
						if (!this.bufferUntilStopChar(':', false))
						{
							throw new global::System.IO.IOException("ran out of data reading header key value");
						}
						string key = this.bufferedString().Trim();
						this.c = this.Read();
						if (this.c != 58)
						{
							throw new global::System.IO.IOException("expected colon");
						}
						if (!this.bufferUntilStopChar('\n', false))
						{
							throw new global::System.IO.IOException("ran out of data before consuming header value");
						}
						this.skipWhiteSpace();
						string value = this.bufferedString().Trim();
						headers.Add(new global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader(key, value));
					}
					this.skipWhiteSpace();
					if (!this.bufferUntilStopChar('-', true))
					{
						throw new global::System.IO.IOException("ran out of data before consuming payload");
					}
					string payload = this.bufferedString();
					if (!this.seekDash())
					{
						throw new global::System.IO.IOException("did not find leading '-'");
					}
					if (!this.consumeDash())
					{
						throw new global::System.IO.IOException("no data after consuming trailing dashes");
					}
					if (!this.expect("END " + type))
					{
						throw new global::System.IO.IOException("END " + type + " was not found.");
					}
					if (!this.seekDash())
					{
						throw new global::System.IO.IOException("did not find ending '-'");
					}
					this.consumeDash();
					return new global::Org.BouncyCastle.Utilities.IO.Pem.PemObject(type, headers, global::Org.BouncyCastle.Utilities.Encoders.Base64.Decode(payload));
				}
			}
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000143EF File Offset: 0x000125EF
		private string bufferedString()
		{
			this.textBuffer.Flush();
			string result = global::Org.BouncyCastle.Utilities.Strings.FromUtf8ByteArray(this.buffer.ToArray());
			this.buffer.Position = 0L;
			this.buffer.SetLength(0L);
			return result;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00014428 File Offset: 0x00012628
		private bool seekDash()
		{
			this.c = 0;
			while ((this.c = this.Read()) >= 0 && this.c != 45)
			{
			}
			this.PushBack(this.c);
			return this.c == 45;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00014470 File Offset: 0x00012670
		private bool seekColon(int upTo)
		{
			this.c = 0;
			bool colonFound = false;
			global::System.Collections.IList read = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (upTo >= 0)
			{
				if (this.c < 0)
				{
					break;
				}
				this.c = this.Read();
				read.Add(this.c);
				if (this.c == 58)
				{
					colonFound = true;
					break;
				}
				upTo--;
			}
			while (read.Count > 0)
			{
				this.PushBack((int)read[read.Count - 1]);
				read.RemoveAt(read.Count - 1);
			}
			return colonFound;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00014500 File Offset: 0x00012700
		private bool consumeDash()
		{
			this.c = 0;
			while ((this.c = this.Read()) >= 0 && this.c == 45)
			{
			}
			this.PushBack(this.c);
			return this.c != -1;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001454C File Offset: 0x0001274C
		private void skipWhiteSpace()
		{
			while ((this.c = this.Read()) >= 0 && this.c <= 32)
			{
			}
			this.PushBack(this.c);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00014584 File Offset: 0x00012784
		private bool expect(string value)
		{
			for (int t = 0; t < value.Length; t++)
			{
				this.c = this.Read();
				if (this.c != (int)value[t])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000145C0 File Offset: 0x000127C0
		private bool bufferUntilStopChar(char stopChar, bool skipWhiteSpace)
		{
			while ((this.c = this.Read()) >= 0)
			{
				if (!skipWhiteSpace || this.c > 32)
				{
					if (this.c == (int)stopChar)
					{
						this.PushBack(this.c);
						break;
					}
					this.textBuffer.Write((char)this.c);
					this.textBuffer.Flush();
				}
			}
			return this.c > -1;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001462D File Offset: 0x0001282D
		private void PushBack(int value)
		{
			if (this.pushback.Count == 0)
			{
				this.pushback.Add(value);
				return;
			}
			this.pushback.Insert(0, value);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00014661 File Offset: 0x00012861
		private int Read()
		{
			if (this.pushback.Count > 0)
			{
				int result = (int)this.pushback[0];
				this.pushback.RemoveAt(0);
				return result;
			}
			return this.reader.Read();
		}

		// Token: 0x04000284 RID: 644
		private readonly global::System.IO.TextReader reader;

		// Token: 0x04000285 RID: 645
		private readonly global::System.IO.MemoryStream buffer;

		// Token: 0x04000286 RID: 646
		private readonly global::System.IO.StreamWriter textBuffer;

		// Token: 0x04000287 RID: 647
		private readonly global::System.Collections.IList pushback = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04000288 RID: 648
		private int c;
	}
}
