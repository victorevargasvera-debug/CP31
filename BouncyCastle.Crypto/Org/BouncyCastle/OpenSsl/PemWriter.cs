using System;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace Org.BouncyCastle.OpenSsl
{
	// Token: 0x020001BC RID: 444
	public class PemWriter : global::Org.BouncyCastle.Utilities.IO.Pem.PemWriter
	{
		// Token: 0x060010A4 RID: 4260 RVA: 0x0004416A File Offset: 0x0004236A
		public PemWriter(global::System.IO.TextWriter writer) : base(writer)
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00044174 File Offset: 0x00042374
		public void WriteObject(object obj)
		{
			try
			{
				base.WriteObject(new global::Org.BouncyCastle.OpenSsl.MiscPemGenerator(obj));
			}
			catch (global::Org.BouncyCastle.Utilities.IO.Pem.PemGenerationException e)
			{
				if (e.InnerException is global::System.IO.IOException)
				{
					throw (global::System.IO.IOException)e.InnerException;
				}
				throw e;
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000441BC File Offset: 0x000423BC
		public void WriteObject(object obj, string algorithm, char[] password, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			base.WriteObject(new global::Org.BouncyCastle.OpenSsl.MiscPemGenerator(obj, algorithm, password, random));
		}
	}
}
