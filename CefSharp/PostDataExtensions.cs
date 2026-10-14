using System;
using System.Collections.Specialized;
using System.Text;

namespace CefSharp
{
	// Token: 0x0200008F RID: 143
	public static class PostDataExtensions
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00003A38 File Offset: 0x00001C38
		public static string GetCharSet(this global::CefSharp.IRequest request)
		{
			global::System.Collections.Specialized.NameValueCollection headers = request.Headers;
			string text = null;
			foreach (object obj in headers)
			{
				string text2 = (string)obj;
				if (text2.Equals("content-type", global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					string[] values = headers.GetValues(text2);
					int num = 0;
					if (num >= values.Length)
					{
						break;
					}
					string text3 = values[num];
					text = text3;
					break;
				}
			}
			if (text == null)
			{
				return null;
			}
			int num2 = text.IndexOf(";", global::System.StringComparison.InvariantCulture);
			if (num2 == -1)
			{
				return null;
			}
			string text4 = text.Substring(num2 + 1).Trim();
			int num3 = text4.IndexOf("=", global::System.StringComparison.InvariantCulture);
			if (num3 == -1)
			{
				return null;
			}
			string text5 = text4.Substring(0, num3).Trim();
			if (!text5.Equals("charset", global::System.StringComparison.InvariantCultureIgnoreCase))
			{
				return null;
			}
			string text6 = text4.Substring(num3 + 1).Trim();
			text6 = text6.TrimStart(new char[]
			{
				' ',
				'"'
			});
			return text6.TrimEnd(new char[]
			{
				' ',
				'"',
				';'
			});
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003B70 File Offset: 0x00001D70
		public static string GetBody(this global::CefSharp.IPostDataElement postDataElement, string charSet = null)
		{
			byte[] bytes = postDataElement.Bytes;
			if (bytes.Length == 0)
			{
				return null;
			}
			global::System.Text.Encoding encoding = global::System.Text.Encoding.Default;
			if (charSet != null)
			{
				try
				{
					encoding = global::System.Text.Encoding.GetEncoding(charSet);
				}
				catch (global::System.ArgumentException)
				{
				}
			}
			return encoding.GetString(bytes, 0, bytes.Length);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00003BBC File Offset: 0x00001DBC
		public static void AddFile(this global::CefSharp.IPostData postData, string fileName)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			global::CefSharp.IPostDataElement postDataElement = postData.CreatePostDataElement();
			postDataElement.File = fileName;
			postData.AddElement(postDataElement);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public static void AddData(this global::CefSharp.IPostData postData, string data, global::System.Text.Encoding encoding = null)
		{
			if (string.IsNullOrEmpty(data))
			{
				throw new global::System.ArgumentNullException("data");
			}
			if (encoding == null)
			{
				encoding = global::System.Text.Encoding.Default;
			}
			global::CefSharp.IPostDataElement postDataElement = postData.CreatePostDataElement();
			postDataElement.Bytes = encoding.GetBytes(data);
			postData.AddElement(postDataElement);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003C3C File Offset: 0x00001E3C
		public static void AddData(this global::CefSharp.IPostData postData, byte[] bytes)
		{
			if (bytes == null)
			{
				throw new global::System.ArgumentNullException("bytes");
			}
			global::CefSharp.IPostDataElement postDataElement = postData.CreatePostDataElement();
			postDataElement.Bytes = bytes;
			postData.AddElement(postDataElement);
		}
	}
}
