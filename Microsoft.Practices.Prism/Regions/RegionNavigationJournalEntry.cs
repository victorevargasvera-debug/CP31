using System;
using System.Globalization;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200007B RID: 123
	public class RegionNavigationJournalEntry : global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00009A43 File Offset: 0x00007C43
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00009A4B File Offset: 0x00007C4B
		public global::System.Uri Uri { get; set; }

		// Token: 0x06000365 RID: 869 RVA: 0x00009A54 File Offset: 0x00007C54
		public override string ToString()
		{
			if (this.Uri != null)
			{
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "RegionNavigationJournalEntry:'{0}'", new object[]
				{
					this.Uri.ToString()
				});
			}
			return base.ToString();
		}
	}
}
