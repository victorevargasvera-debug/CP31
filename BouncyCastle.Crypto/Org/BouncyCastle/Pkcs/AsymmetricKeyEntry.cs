using System;
using System.Collections;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001A9 RID: 425
	public class AsymmetricKeyEntry : global::Org.BouncyCastle.Pkcs.Pkcs12Entry
	{
		// Token: 0x0600101D RID: 4125 RVA: 0x0003FE15 File Offset: 0x0003E015
		public AsymmetricKeyEntry(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key) : base(global::Org.BouncyCastle.Utilities.Platform.CreateHashtable())
		{
			this.key = key;
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0003FE29 File Offset: 0x0003E029
		[global::System.Obsolete]
		public AsymmetricKeyEntry(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, global::System.Collections.Hashtable attributes) : base(attributes)
		{
			this.key = key;
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0003FE39 File Offset: 0x0003E039
		public AsymmetricKeyEntry(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, global::System.Collections.IDictionary attributes) : base(attributes)
		{
			this.key = key;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0003FE49 File Offset: 0x0003E049
		public global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0003FE54 File Offset: 0x0003E054
		public override bool Equals(object obj)
		{
			global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry other = obj as global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry;
			return other != null && this.key.Equals(other.key);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0003FE7E File Offset: 0x0003E07E
		public override int GetHashCode()
		{
			return ~this.key.GetHashCode();
		}

		// Token: 0x0400089A RID: 2202
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key;
	}
}
