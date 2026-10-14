using System;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000022 RID: 34
	public class Result
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000058D8 File Offset: 0x00003AD8
		public bool IsError
		{
			get
			{
				return this.Error.IsPresent();
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000058E8 File Offset: 0x00003AE8
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000058F0 File Offset: 0x00003AF0
		public string Error { get; set; }
	}
}
