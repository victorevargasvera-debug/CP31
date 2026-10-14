using System;
using System.IO;
using System.Net;

namespace CefSharp.SchemeHandler
{
	// Token: 0x020000B3 RID: 179
	public class FolderSchemeHandlerFactory : global::CefSharp.ISchemeHandlerFactory
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x00008694 File Offset: 0x00006894
		public FolderSchemeHandlerFactory(string rootFolder, string schemeName = null, string hostName = null, string defaultPage = "index.html", global::System.IO.FileShare resourceFileShare = global::System.IO.FileShare.Read)
		{
			this.rootFolder = global::System.IO.Path.GetFullPath(rootFolder);
			this.defaultPage = defaultPage;
			this.schemeName = schemeName;
			this.hostName = hostName;
			this.resourceFileShare = resourceFileShare;
			if (!global::System.IO.Directory.Exists(this.rootFolder))
			{
				throw new global::System.IO.DirectoryNotFoundException(this.rootFolder);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000086EA File Offset: 0x000068EA
		global::CefSharp.IResourceHandler global::CefSharp.ISchemeHandlerFactory.Create(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string schemeName, global::CefSharp.IRequest request)
		{
			return this.Create(browser, frame, schemeName, request);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000086F8 File Offset: 0x000068F8
		protected virtual global::CefSharp.IResourceHandler Create(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string schemeName, global::CefSharp.IRequest request)
		{
			if (this.schemeName != null && !schemeName.Equals(this.schemeName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::CefSharp.ResourceHandler.ForErrorMessage(string.Format("SchemeName {0} does not match the expected SchemeName of {1}.", schemeName, this.schemeName), global::System.Net.HttpStatusCode.NotFound);
			}
			global::System.Uri uri = new global::System.Uri(request.Url);
			if (this.hostName != null && !uri.Host.Equals(this.hostName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::CefSharp.ResourceHandler.ForErrorMessage(string.Format("HostName {0} does not match the expected HostName of {1}.", uri.Host, this.hostName), global::System.Net.HttpStatusCode.NotFound);
			}
			string text = uri.AbsolutePath.Substring(1);
			if (string.IsNullOrEmpty(text))
			{
				text = this.defaultPage;
			}
			string text2 = global::System.Net.WebUtility.UrlDecode(global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(this.rootFolder, text)));
			if (text2.StartsWith(this.rootFolder, global::System.StringComparison.OrdinalIgnoreCase) && global::System.IO.File.Exists(text2))
			{
				string extension = global::System.IO.Path.GetExtension(text2);
				string mimeType = global::CefSharp.SchemeHandler.FolderSchemeHandlerFactory.GetMimeTypeDelegate(extension);
				global::System.IO.FileStream stream = new global::System.IO.FileStream(text2, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, this.resourceFileShare);
				return global::CefSharp.ResourceHandler.FromStream(stream, mimeType, true, null);
			}
			return global::CefSharp.ResourceHandler.ForErrorMessage("File Not Found - " + text2, global::System.Net.HttpStatusCode.NotFound);
		}

		// Token: 0x0400033E RID: 830
		private readonly string rootFolder;

		// Token: 0x0400033F RID: 831
		private readonly string defaultPage;

		// Token: 0x04000340 RID: 832
		private readonly string schemeName;

		// Token: 0x04000341 RID: 833
		private readonly string hostName;

		// Token: 0x04000342 RID: 834
		private readonly global::System.IO.FileShare resourceFileShare;

		// Token: 0x04000343 RID: 835
		public static global::System.Func<string, string> GetMimeTypeDelegate = (string s) => global::CefSharp.ResourceHandler.GetMimeType(s);
	}
}
