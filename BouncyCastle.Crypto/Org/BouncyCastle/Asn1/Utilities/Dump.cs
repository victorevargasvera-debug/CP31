using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Utilities
{
	// Token: 0x02000694 RID: 1684
	public sealed class Dump
	{
		// Token: 0x06003DFF RID: 15871 RVA: 0x0011B1D9 File Offset: 0x001193D9
		private Dump()
		{
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x0011B1E4 File Offset: 0x001193E4
		public static void Main(string[] args)
		{
			global::Org.BouncyCastle.Asn1.Asn1InputStream bIn = new global::Org.BouncyCastle.Asn1.Asn1InputStream(global::System.IO.File.OpenRead(args[0]));
			global::Org.BouncyCastle.Asn1.Asn1Object obj;
			while ((obj = bIn.ReadObject()) != null)
			{
				global::System.Console.WriteLine(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.DumpAsString(obj));
			}
			global::Org.BouncyCastle.Utilities.Platform.Dispose(bIn);
		}
	}
}
