using System;
using System.IO;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x0200005D RID: 93
	public class PemWriter
	{
		// Token: 0x060003EF RID: 1007 RVA: 0x0001469A File Offset: 0x0001289A
		public PemWriter(global::System.IO.TextWriter writer)
		{
			if (writer == null)
			{
				throw new global::System.ArgumentNullException("writer");
			}
			this.writer = writer;
			this.nlLength = global::Org.BouncyCastle.Utilities.Platform.NewLine.Length;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000146D4 File Offset: 0x000128D4
		public global::System.IO.TextWriter Writer
		{
			get
			{
				return this.writer;
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000146DC File Offset: 0x000128DC
		public int GetOutputSize(global::Org.BouncyCastle.Utilities.IO.Pem.PemObject obj)
		{
			int size = 2 * (obj.Type.Length + 10 + this.nlLength) + 6 + 4;
			if (obj.Headers.Count > 0)
			{
				foreach (object obj2 in obj.Headers)
				{
					global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader header = (global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader)obj2;
					size += header.Name.Length + ": ".Length + header.Value.Length + this.nlLength;
				}
				size += this.nlLength;
			}
			int dataLen = (obj.Content.Length + 2) / 3 * 4;
			size += dataLen + (dataLen + 64 - 1) / 64 * this.nlLength;
			return size;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000147B8 File Offset: 0x000129B8
		public void WriteObject(global::Org.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator objGen)
		{
			global::Org.BouncyCastle.Utilities.IO.Pem.PemObject obj = objGen.Generate();
			this.WritePreEncapsulationBoundary(obj.Type);
			if (obj.Headers.Count > 0)
			{
				foreach (object obj2 in obj.Headers)
				{
					global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader header = (global::Org.BouncyCastle.Utilities.IO.Pem.PemHeader)obj2;
					this.writer.Write(header.Name);
					this.writer.Write(": ");
					this.writer.WriteLine(header.Value);
				}
				this.writer.WriteLine();
			}
			this.WriteEncoded(obj.Content);
			this.WritePostEncapsulationBoundary(obj.Type);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00014880 File Offset: 0x00012A80
		private void WriteEncoded(byte[] bytes)
		{
			bytes = global::Org.BouncyCastle.Utilities.Encoders.Base64.Encode(bytes);
			for (int i = 0; i < bytes.Length; i += this.buf.Length)
			{
				int index = 0;
				while (index != this.buf.Length && i + index < bytes.Length)
				{
					this.buf[index] = (char)bytes[i + index];
					index++;
				}
				this.writer.WriteLine(this.buf, 0, index);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000148E5 File Offset: 0x00012AE5
		private void WritePreEncapsulationBoundary(string type)
		{
			this.writer.WriteLine("-----BEGIN " + type + "-----");
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00014902 File Offset: 0x00012B02
		private void WritePostEncapsulationBoundary(string type)
		{
			this.writer.WriteLine("-----END " + type + "-----");
		}

		// Token: 0x04000289 RID: 649
		private const int LineLength = 64;

		// Token: 0x0400028A RID: 650
		private readonly global::System.IO.TextWriter writer;

		// Token: 0x0400028B RID: 651
		private readonly int nlLength;

		// Token: 0x0400028C RID: 652
		private char[] buf = new char[64];
	}
}
