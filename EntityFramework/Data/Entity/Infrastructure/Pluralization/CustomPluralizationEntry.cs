using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Pluralization
{
	// Token: 0x0200026A RID: 618
	public class CustomPluralizationEntry
	{
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00055EB6 File Offset: 0x000540B6
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x00055EBE File Offset: 0x000540BE
		public string Singular { get; private set; }

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00055EC7 File Offset: 0x000540C7
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x00055ECF File Offset: 0x000540CF
		public string Plural { get; private set; }

		// Token: 0x06001F66 RID: 8038 RVA: 0x00055ED8 File Offset: 0x000540D8
		public CustomPluralizationEntry(string singular, string plural)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(singular, "singular");
			global::System.Data.Entity.Utilities.Check.NotEmpty(plural, "plural");
			this.Singular = singular;
			this.Plural = plural;
		}
	}
}
