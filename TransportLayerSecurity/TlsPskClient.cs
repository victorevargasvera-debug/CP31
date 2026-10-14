using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000017 RID: 23
	internal class TlsPskClient : global::Org.BouncyCastle.Crypto.Tls.PskTlsClient
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00005B6C File Offset: 0x00003D6C
		public TlsPskClient(global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity pskIdentity, int[] cipherSuites, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version) : base(pskIdentity)
		{
			this.a = cipherSuites;
			this.b = version;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005B90 File Offset: 0x00003D90
		public override int[] GetCipherSuites()
		{
			short num = (short)485773998;
			short num2 = num;
			num = (short)486822574;
			switch (num2 == num)
			{
			}
			num = (short)1566965760;
			short num3 = num;
			num = (short)1035862016;
			if (num != 0)
			{
			}
			num = (short)1327104001;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00005C40 File Offset: 0x00003E40
		public override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1418873510;
				short num2 = num;
				num = (short)1673743014;
				switch (num2 == num)
				{
				}
				num = (short)1944059904;
				short num3 = num;
				num = (short)117309440;
				if (num != 0)
				{
				}
				num = (short)700252161;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005CF0 File Offset: 0x00003EF0
		public override global::System.Collections.IDictionary GetClientExtensions()
		{
			short num = (short)1026962868;
			short num2 = num;
			num = (short)1635399092;
			switch (num2 == num)
			{
			}
			num = (short)1465253888;
			short num3 = num;
			num = (short)1825308673;
			if (num != 0)
			{
			}
			num = (short)431095808;
			if (num != 0)
			{
			}
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(base.GetClientExtensions());
			global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddEncryptThenMacExtension(dictionary);
			return dictionary;
		}

		// Token: 0x0400002C RID: 44
		private readonly int[] a;

		// Token: 0x0400002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion b;
	}
}
