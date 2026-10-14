using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CefSharp.Event;

namespace CefSharp
{
	// Token: 0x02000087 RID: 135
	public static class JavascriptBindingExtensions
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00003640 File Offset: 0x00001840
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> EnsureObjectBoundAsync(this global::CefSharp.IWebBrowser browser, params string[] names)
		{
			global::System.Threading.Tasks.TaskCompletionSource<global::System.Collections.Generic.IList<string>> objBoundTasks = new global::System.Threading.Tasks.TaskCompletionSource<global::System.Collections.Generic.IList<string>>();
			global::System.EventHandler<global::CefSharp.Event.JavascriptBindingMultipleCompleteEventArgs> handler = null;
			handler = delegate(object sender, global::CefSharp.Event.JavascriptBindingMultipleCompleteEventArgs args)
			{
				browser.JavascriptObjectRepository.ObjectsBoundInJavascript -= handler;
				bool flag = names.ToList<string>().SequenceEqual(args.ObjectNames);
				if (flag)
				{
					objBoundTasks.SetResult(args.ObjectNames);
					return;
				}
				objBoundTasks.SetException(new global::System.Exception("Not all objects were bound successfully, bound objects were " + string.Join(",", args.ObjectNames)));
			};
			browser.JavascriptObjectRepository.ObjectsBoundInJavascript += handler;
			string script = "(function() { CefSharp.BindObjectAsync({ NotifyIfAlreadyBound: true, IgnoreCache: false }, '" + string.Join("', '", names) + "'); })();";
			browser.ExecuteScriptAsync(script);
			return objBoundTasks.Task;
		}
	}
}
