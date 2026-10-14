using System;
using System.Threading.Tasks;

namespace IdentityModel.OidcClient.Browser
{
	// Token: 0x0200002F RID: 47
	public interface IBrowser
	{
		// Token: 0x060000F2 RID: 242
		global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.Browser.BrowserResult> InvokeAsync(global::IdentityModel.OidcClient.Browser.BrowserOptions options);
	}
}
