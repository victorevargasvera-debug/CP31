using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200006B RID: 107
	public class PathFilter : global::ICSharpCode.SharpZipLib.Core.IScanFilter
	{
		// Token: 0x06000476 RID: 1142 RVA: 0x00013C30 File Offset: 0x00011E30
		public PathFilter(string filter)
		{
			this.nameFilter_ = new global::ICSharpCode.SharpZipLib.Core.NameFilter(filter);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00013C44 File Offset: 0x00011E44
		public virtual bool IsMatch(string name)
		{
			bool result = false;
			if (name != null)
			{
				string name2 = (name.Length > 0) ? global::System.IO.Path.GetFullPath(name) : "";
				result = this.nameFilter_.IsMatch(name2);
			}
			return result;
		}

		// Token: 0x040002A1 RID: 673
		private readonly global::ICSharpCode.SharpZipLib.Core.NameFilter nameFilter_;
	}
}
