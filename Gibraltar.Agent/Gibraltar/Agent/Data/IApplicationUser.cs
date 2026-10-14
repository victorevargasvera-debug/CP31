using System;
using System.Collections.Generic;

namespace Gibraltar.Agent.Data
{
	// Token: 0x0200003B RID: 59
	public interface IApplicationUser
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600034E RID: 846
		// (set) Token: 0x0600034F RID: 847
		string Key { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000350 RID: 848
		string FullyQualifiedUserName { get; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000351 RID: 849
		// (set) Token: 0x06000352 RID: 850
		string Caption { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000353 RID: 851
		// (set) Token: 0x06000354 RID: 852
		string EmailAddress { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000355 RID: 853
		// (set) Token: 0x06000356 RID: 854
		string Phone { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000357 RID: 855
		// (set) Token: 0x06000358 RID: 856
		string Organization { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000359 RID: 857
		// (set) Token: 0x0600035A RID: 858
		string Role { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600035B RID: 859
		// (set) Token: 0x0600035C RID: 860
		string Tenant { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600035D RID: 861
		global::System.Collections.Generic.Dictionary<string, string> Properties { get; }
	}
}
