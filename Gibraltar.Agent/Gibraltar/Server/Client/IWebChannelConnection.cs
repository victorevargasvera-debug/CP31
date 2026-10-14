using System;
using System.Collections.Generic;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200012A RID: 298
	internal interface IWebChannelConnection
	{
		// Token: 0x06000C21 RID: 3105
		byte[] DownloadData(string relativeUrl, int? timeout = -1);

		// Token: 0x06000C22 RID: 3106
		byte[] DownloadData(string relativeUrl, global::System.Collections.Generic.IList<global::Gibraltar.NameValuePair<string>> additionalHeaders, int? timeout = -1);

		// Token: 0x06000C23 RID: 3107
		void DownloadFile(string relativeUrl, string destinationFileName, int? timeout = -1);

		// Token: 0x06000C24 RID: 3108
		string DownloadString(string relativeUrl, int? timeout = -1);

		// Token: 0x06000C25 RID: 3109
		byte[] UploadData(string relativeUrl, string method, string contentType, byte[] data, global::System.Collections.Generic.IList<global::Gibraltar.NameValuePair<string>> additionalHeaders = null, int? timeout = -1);

		// Token: 0x06000C26 RID: 3110
		byte[] UploadFile(string relativeUrl, string method, string contentType, string sourceFileNamePath, int? timeout = -1);

		// Token: 0x06000C27 RID: 3111
		string UploadString(string relativeUrl, string method, string contentType, string data, int? timeout = -1);
	}
}
