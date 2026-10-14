using System;
using System.IO;
using System.Text;

namespace CefSharp.Web
{
	// Token: 0x020000A7 RID: 167
	public class HtmlString
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x000080F9 File Offset: 0x000062F9
		public HtmlString(string html, bool base64Encode = false, string charSet = null)
		{
			this.base64Encode = base64Encode;
			this.html = html;
			this.charSet = charSet;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00008118 File Offset: 0x00006318
		public string ToDataUriString()
		{
			string str = "data:text/html";
			if (!string.IsNullOrEmpty(this.charSet))
			{
				str = str + ";charset=" + this.charSet;
			}
			if (this.base64Encode)
			{
				string str2 = global::System.Convert.ToBase64String(global::System.Text.Encoding.UTF8.GetBytes(this.html));
				return str + ";base64," + str2;
			}
			string str3 = global::System.Uri.EscapeDataString(this.html);
			return str + "," + str3;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000818D File Offset: 0x0000638D
		public static explicit operator global::CefSharp.Web.HtmlString(string html)
		{
			return new global::CefSharp.Web.HtmlString(html, true, null);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00008198 File Offset: 0x00006398
		public static global::CefSharp.Web.HtmlString FromFile(string fileName)
		{
			string text = global::System.IO.File.ReadAllText(fileName, global::System.Text.Encoding.UTF8);
			return (global::CefSharp.Web.HtmlString)text;
		}

		// Token: 0x04000310 RID: 784
		private readonly string html;

		// Token: 0x04000311 RID: 785
		private readonly bool base64Encode;

		// Token: 0x04000312 RID: 786
		private readonly string charSet;
	}
}
