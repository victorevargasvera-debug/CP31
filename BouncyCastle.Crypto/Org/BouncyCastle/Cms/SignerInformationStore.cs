using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200055C RID: 1372
	public class SignerInformationStore
	{
		// Token: 0x06003496 RID: 13462 RVA: 0x000FB618 File Offset: 0x000F9818
		public SignerInformationStore(global::Org.BouncyCastle.Cms.SignerInformation signerInfo)
		{
			this.all = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
			this.all.Add(signerInfo);
			global::Org.BouncyCastle.Cms.SignerID sid = signerInfo.SignerID;
			this.table[sid] = this.all;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x000FB668 File Offset: 0x000F9868
		public SignerInformationStore(global::System.Collections.ICollection signerInfos)
		{
			foreach (object obj in signerInfos)
			{
				global::Org.BouncyCastle.Cms.SignerInformation signer = (global::Org.BouncyCastle.Cms.SignerInformation)obj;
				global::Org.BouncyCastle.Cms.SignerID sid = signer.SignerID;
				global::System.Collections.IList list = (global::System.Collections.IList)this.table[sid];
				if (list == null)
				{
					list = (this.table[sid] = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1));
				}
				list.Add(signer);
			}
			this.all = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(signerInfos);
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x000FB710 File Offset: 0x000F9910
		public global::Org.BouncyCastle.Cms.SignerInformation GetFirstSigner(global::Org.BouncyCastle.Cms.SignerID selector)
		{
			global::System.Collections.IList list = (global::System.Collections.IList)this.table[selector];
			if (list != null)
			{
				return (global::Org.BouncyCastle.Cms.SignerInformation)list[0];
			}
			return null;
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x000FB740 File Offset: 0x000F9940
		public int Count
		{
			get
			{
				return this.all.Count;
			}
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x000FB74D File Offset: 0x000F994D
		public global::System.Collections.ICollection GetSigners()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.all);
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x000FB75C File Offset: 0x000F995C
		public global::System.Collections.ICollection GetSigners(global::Org.BouncyCastle.Cms.SignerID selector)
		{
			global::System.Collections.IList list = (global::System.Collections.IList)this.table[selector];
			if (list != null)
			{
				return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(list);
			}
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
		}

		// Token: 0x04001785 RID: 6021
		private readonly global::System.Collections.IList all;

		// Token: 0x04001786 RID: 6022
		private readonly global::System.Collections.IDictionary table = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
