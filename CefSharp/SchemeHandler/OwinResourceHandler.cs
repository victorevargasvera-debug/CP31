using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CefSharp.SchemeHandler
{
	// Token: 0x020000B4 RID: 180
	public class OwinResourceHandler : global::CefSharp.ResourceHandler
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x00008828 File Offset: 0x00006A28
		public OwinResourceHandler(global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, global::System.Threading.Tasks.Task> appFunc) : base("text/html", null, false, null)
		{
			this.appFunc = appFunc;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00008840 File Offset: 0x00006A40
		public override global::CefSharp.CefReturnValue ProcessRequestAsync(global::CefSharp.IRequest request, global::CefSharp.ICallback callback)
		{
			global::CefSharp.SchemeHandler.OwinResourceHandler.<>c__DisplayClass3_0 CS$<>8__locals1 = new global::CefSharp.SchemeHandler.OwinResourceHandler.<>c__DisplayClass3_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			CS$<>8__locals1.responseStream = new global::System.IO.MemoryStream();
			global::System.IO.Stream value = global::System.IO.Stream.Null;
			if (request.Method == "POST")
			{
				using (global::CefSharp.IPostData postData = request.PostData)
				{
					if (postData != null)
					{
						global::System.Collections.Generic.IList<global::CefSharp.IPostDataElement> elements = postData.Elements;
						global::CefSharp.IPostDataElement postDataElement = elements.First<global::CefSharp.IPostDataElement>();
						byte[] bytes = postDataElement.Bytes;
						value = new global::System.IO.MemoryStream(bytes, 0, bytes.Length);
					}
				}
			}
			global::System.Uri uri = new global::System.Uri(request.Url);
			global::System.Collections.Generic.IDictionary<string, string[]> dictionary = global::CefSharp.SchemeHandler.OwinResourceHandler.ToDictionary(request.Headers);
			dictionary.Add("Host", new string[]
			{
				uri.Host + ((uri.Port > 0) ? (":" + uri.Port.ToString()) : "")
			});
			CS$<>8__locals1.owinEnvironment = new global::System.Collections.Generic.Dictionary<string, object>(global::System.StringComparer.Ordinal)
			{
				{
					"owin.RequestBody",
					value
				},
				{
					"owin.RequestHeaders",
					dictionary
				},
				{
					"owin.RequestMethod",
					request.Method
				},
				{
					"owin.RequestPath",
					uri.AbsolutePath
				},
				{
					"owin.RequestPathBase",
					"/"
				},
				{
					"owin.RequestProtocol",
					"HTTP/1.1"
				},
				{
					"owin.RequestQueryString",
					string.IsNullOrEmpty(uri.Query) ? string.Empty : uri.Query.Substring(1)
				},
				{
					"owin.RequestScheme",
					uri.Scheme
				},
				{
					"owin.ResponseHeaders",
					new global::System.Collections.Generic.Dictionary<string, string[]>(global::System.StringComparer.OrdinalIgnoreCase)
				},
				{
					"owin.ResponseBody",
					CS$<>8__locals1.responseStream
				},
				{
					"owin.Version",
					"1.0.0"
				}
			};
			global::System.Threading.Tasks.Task.Run(delegate()
			{
				global::CefSharp.SchemeHandler.OwinResourceHandler.<>c__DisplayClass3_0.<<ProcessRequestAsync>b__0>d <<ProcessRequestAsync>b__0>d;
				<<ProcessRequestAsync>b__0>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
				<<ProcessRequestAsync>b__0>d.<>4__this = CS$<>8__locals1;
				<<ProcessRequestAsync>b__0>d.<>1__state = -1;
				<<ProcessRequestAsync>b__0>d.<>t__builder.Start<global::CefSharp.SchemeHandler.OwinResourceHandler.<>c__DisplayClass3_0.<<ProcessRequestAsync>b__0>d>(ref <<ProcessRequestAsync>b__0>d);
				return <<ProcessRequestAsync>b__0>d.<>t__builder.Task;
			});
			return global::CefSharp.CefReturnValue.ContinueAsync;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00008A28 File Offset: 0x00006C28
		private static global::System.Collections.Generic.IDictionary<string, string[]> ToDictionary(global::System.Collections.Specialized.NameValueCollection nameValueCollection)
		{
			global::System.Collections.Generic.Dictionary<string, string[]> dictionary = new global::System.Collections.Generic.Dictionary<string, string[]>(global::System.StringComparer.OrdinalIgnoreCase);
			foreach (string text in nameValueCollection.AllKeys)
			{
				if (!dictionary.ContainsKey(text))
				{
					dictionary.Add(text, new string[0]);
				}
				string[] values = nameValueCollection.GetValues(text);
				if (values != null)
				{
					foreach (string item in values)
					{
						global::System.Collections.Generic.List<string> list = dictionary[text].ToList<string>();
						list.Add(item);
						dictionary[text] = list.ToArray();
					}
				}
			}
			return dictionary;
		}

		// Token: 0x04000344 RID: 836
		private static readonly global::System.Collections.Generic.Dictionary<int, string> StatusCodeToStatusTextMapping = new global::System.Collections.Generic.Dictionary<int, string>
		{
			{
				200,
				"OK"
			},
			{
				301,
				"Moved Permanently"
			},
			{
				304,
				"Not Modified"
			},
			{
				404,
				"Not Found"
			}
		};

		// Token: 0x04000345 RID: 837
		private readonly global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, global::System.Threading.Tasks.Task> appFunc;
	}
}
