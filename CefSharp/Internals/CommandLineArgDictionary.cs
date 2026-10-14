using System;
using System.Collections.Generic;

namespace CefSharp.Internals
{
	// Token: 0x020000CD RID: 205
	public class CommandLineArgDictionary : global::System.Collections.Generic.Dictionary<string, string>
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00009C87 File Offset: 0x00007E87
		public void Add(string arg)
		{
			base.Add(arg, string.Empty);
		}
	}
}
