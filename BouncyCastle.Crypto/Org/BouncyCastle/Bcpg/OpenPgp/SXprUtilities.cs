using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C9 RID: 1481
	public sealed class SXprUtilities
	{
		// Token: 0x060037DF RID: 14303 RVA: 0x00108373 File Offset: 0x00106573
		private SXprUtilities()
		{
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x0010837C File Offset: 0x0010657C
		private static int ReadLength(global::System.IO.Stream input, int ch)
		{
			int len = ch - 48;
			while ((ch = input.ReadByte()) >= 0 && ch != 58)
			{
				len = len * 10 + ch - 48;
			}
			return len;
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x001083AC File Offset: 0x001065AC
		internal static string ReadString(global::System.IO.Stream input, int ch)
		{
			char[] chars = new char[global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadLength(input, ch)];
			for (int i = 0; i != chars.Length; i++)
			{
				chars[i] = (char)input.ReadByte();
			}
			return new string(chars);
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x001083E4 File Offset: 0x001065E4
		internal static byte[] ReadBytes(global::System.IO.Stream input, int ch)
		{
			byte[] data = new byte[global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadLength(input, ch)];
			global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, data);
			return data;
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x00108408 File Offset: 0x00106608
		internal static global::Org.BouncyCastle.Bcpg.S2k ParseS2k(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipOpenParenthesis(input);
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(input, input.ReadByte());
			byte[] iv = global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadBytes(input, input.ReadByte());
			long iterationCount = long.Parse(global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.ReadString(input, input.ReadByte()));
			global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.SkipCloseParenthesis(input);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.SXprUtilities.MyS2k(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1, iv, iterationCount);
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x00108455 File Offset: 0x00106655
		internal static void SkipOpenParenthesis(global::System.IO.Stream input)
		{
			if (input.ReadByte() != 40)
			{
				throw new global::System.IO.IOException("unknown character encountered");
			}
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x0010846C File Offset: 0x0010666C
		internal static void SkipCloseParenthesis(global::System.IO.Stream input)
		{
			if (input.ReadByte() != 41)
			{
				throw new global::System.IO.IOException("unknown character encountered");
			}
		}

		// Token: 0x0200084A RID: 2122
		private class MyS2k : global::Org.BouncyCastle.Bcpg.S2k
		{
			// Token: 0x06004749 RID: 18249 RVA: 0x0013B4EA File Offset: 0x001396EA
			internal MyS2k(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag algorithm, byte[] iv, long iterationCount64) : base(algorithm, iv, (int)iterationCount64)
			{
				this.mIterationCount64 = iterationCount64;
			}

			// Token: 0x17000ABB RID: 2747
			// (get) Token: 0x0600474A RID: 18250 RVA: 0x0013B4FD File Offset: 0x001396FD
			public override long IterationCount
			{
				get
				{
					return this.mIterationCount64;
				}
			}

			// Token: 0x040025B9 RID: 9657
			private readonly long mIterationCount64;
		}
	}
}
