using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000556 RID: 1366
	public class RecipientInformationStore
	{
		// Token: 0x06003462 RID: 13410 RVA: 0x000FA55C File Offset: 0x000F875C
		public RecipientInformationStore(global::System.Collections.ICollection recipientInfos)
		{
			foreach (object obj in recipientInfos)
			{
				global::Org.BouncyCastle.Cms.RecipientInformation recipientInformation = (global::Org.BouncyCastle.Cms.RecipientInformation)obj;
				global::Org.BouncyCastle.Cms.RecipientID rid = recipientInformation.RecipientID;
				global::System.Collections.IList list = (global::System.Collections.IList)this.table[rid];
				if (list == null)
				{
					list = (this.table[rid] = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1));
				}
				list.Add(recipientInformation);
			}
			this.all = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(recipientInfos);
		}

		// Token: 0x170006E3 RID: 1763
		public global::Org.BouncyCastle.Cms.RecipientInformation this[global::Org.BouncyCastle.Cms.RecipientID selector]
		{
			get
			{
				return this.GetFirstRecipient(selector);
			}
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x000FA610 File Offset: 0x000F8810
		public global::Org.BouncyCastle.Cms.RecipientInformation GetFirstRecipient(global::Org.BouncyCastle.Cms.RecipientID selector)
		{
			global::System.Collections.IList list = (global::System.Collections.IList)this.table[selector];
			if (list != null)
			{
				return (global::Org.BouncyCastle.Cms.RecipientInformation)list[0];
			}
			return null;
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x000FA640 File Offset: 0x000F8840
		public int Count
		{
			get
			{
				return this.all.Count;
			}
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x000FA64D File Offset: 0x000F884D
		public global::System.Collections.ICollection GetRecipients()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.all);
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x000FA65C File Offset: 0x000F885C
		public global::System.Collections.ICollection GetRecipients(global::Org.BouncyCastle.Cms.RecipientID selector)
		{
			global::System.Collections.IList list = (global::System.Collections.IList)this.table[selector];
			if (list != null)
			{
				return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(list);
			}
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
		}

		// Token: 0x0400176B RID: 5995
		private readonly global::System.Collections.IList all;

		// Token: 0x0400176C RID: 5996
		private readonly global::System.Collections.IDictionary table = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
