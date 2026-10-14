using System;
using System.Collections.Generic;
using System.Linq;

namespace CefSharp.Internals
{
	// Token: 0x020000CE RID: 206
	public static class CommandLineArgsParser
	{
		// Token: 0x0600061B RID: 1563 RVA: 0x00009CA0 File Offset: 0x00007EA0
		public static bool HasArgument(this global::System.Collections.Generic.IEnumerable<string> args, string arg)
		{
			return args.Any((string a) => a.StartsWith(arg));
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00009CCC File Offset: 0x00007ECC
		public static string GetArgumentValue(this global::System.Collections.Generic.IEnumerable<string> args, string argumentName)
		{
			string text = args.FirstOrDefault((string a) => a.StartsWith(argumentName));
			if (text == null)
			{
				return null;
			}
			return text.Split(new char[]
			{
				'='
			}).Last<string>();
		}
	}
}
