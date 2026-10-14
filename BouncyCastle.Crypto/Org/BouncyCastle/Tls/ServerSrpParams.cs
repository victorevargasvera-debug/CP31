using System;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000EB RID: 235
	public sealed class ServerSrpParams
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x00022CDB File Offset: 0x00020EDB
		public ServerSrpParams(global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger g, byte[] s, global::Org.BouncyCastle.Math.BigInteger B)
		{
			this.m_N = N;
			this.m_g = g;
			this.m_s = global::Org.BouncyCastle.Utilities.Arrays.Clone(s);
			this.m_B = B;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00022D05 File Offset: 0x00020F05
		public global::Org.BouncyCastle.Math.BigInteger B
		{
			get
			{
				return this.m_B;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00022D0D File Offset: 0x00020F0D
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.m_g;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00022D15 File Offset: 0x00020F15
		public global::Org.BouncyCastle.Math.BigInteger N
		{
			get
			{
				return this.m_N;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00022D1D File Offset: 0x00020F1D
		public byte[] S
		{
			get
			{
				return this.m_s;
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00022D25 File Offset: 0x00020F25
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsSrpUtilities.WriteSrpParameter(this.m_N, output);
			global::Org.BouncyCastle.Tls.TlsSrpUtilities.WriteSrpParameter(this.m_g, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_s, output);
			global::Org.BouncyCastle.Tls.TlsSrpUtilities.WriteSrpParameter(this.m_B, output);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00022D58 File Offset: 0x00020F58
		public static global::Org.BouncyCastle.Tls.ServerSrpParams Parse(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Math.BigInteger n = global::Org.BouncyCastle.Tls.TlsSrpUtilities.ReadSrpParameter(input);
			global::Org.BouncyCastle.Math.BigInteger g = global::Org.BouncyCastle.Tls.TlsSrpUtilities.ReadSrpParameter(input);
			byte[] s = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 1);
			global::Org.BouncyCastle.Math.BigInteger B = global::Org.BouncyCastle.Tls.TlsSrpUtilities.ReadSrpParameter(input);
			return new global::Org.BouncyCastle.Tls.ServerSrpParams(n, g, s, B);
		}

		// Token: 0x0400067B RID: 1659
		private global::Org.BouncyCastle.Math.BigInteger m_N;

		// Token: 0x0400067C RID: 1660
		private global::Org.BouncyCastle.Math.BigInteger m_g;

		// Token: 0x0400067D RID: 1661
		private global::Org.BouncyCastle.Math.BigInteger m_B;

		// Token: 0x0400067E RID: 1662
		private byte[] m_s;
	}
}
