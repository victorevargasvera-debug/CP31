using System;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000348 RID: 840
	public class ServerSrpParams
	{
		// Token: 0x0600229F RID: 8863 RVA: 0x00098764 File Offset: 0x00096964
		public ServerSrpParams(global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger g, byte[] s, global::Org.BouncyCastle.Math.BigInteger B)
		{
			this.m_N = N;
			this.m_g = g;
			this.m_s = global::Org.BouncyCastle.Utilities.Arrays.Clone(s);
			this.m_B = B;
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x0009878E File Offset: 0x0009698E
		public virtual global::Org.BouncyCastle.Math.BigInteger B
		{
			get
			{
				return this.m_B;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00098796 File Offset: 0x00096996
		public virtual global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.m_g;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x0009879E File Offset: 0x0009699E
		public virtual global::Org.BouncyCastle.Math.BigInteger N
		{
			get
			{
				return this.m_N;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000987A6 File Offset: 0x000969A6
		public virtual byte[] S
		{
			get
			{
				return this.m_s;
			}
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x000987AE File Offset: 0x000969AE
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.WriteSrpParameter(this.m_N, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.WriteSrpParameter(this.m_g, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(this.m_s, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.WriteSrpParameter(this.m_B, output);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x000987E0 File Offset: 0x000969E0
		public static global::Org.BouncyCastle.Crypto.Tls.ServerSrpParams Parse(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Math.BigInteger n = global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.ReadSrpParameter(input);
			global::Org.BouncyCastle.Math.BigInteger g = global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.ReadSrpParameter(input);
			byte[] s = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input);
			global::Org.BouncyCastle.Math.BigInteger B = global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.ReadSrpParameter(input);
			return new global::Org.BouncyCastle.Crypto.Tls.ServerSrpParams(n, g, s, B);
		}

		// Token: 0x04000E01 RID: 3585
		protected global::Org.BouncyCastle.Math.BigInteger m_N;

		// Token: 0x04000E02 RID: 3586
		protected global::Org.BouncyCastle.Math.BigInteger m_g;

		// Token: 0x04000E03 RID: 3587
		protected global::Org.BouncyCastle.Math.BigInteger m_B;

		// Token: 0x04000E04 RID: 3588
		protected byte[] m_s;
	}
}
