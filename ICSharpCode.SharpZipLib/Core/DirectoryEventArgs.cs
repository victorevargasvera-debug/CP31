using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200005F RID: 95
	public class DirectoryEventArgs : global::ICSharpCode.SharpZipLib.Core.ScanEventArgs
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x000134E2 File Offset: 0x000116E2
		public DirectoryEventArgs(string name, bool hasMatchingFiles) : base(name)
		{
			this.hasMatchingFiles_ = hasMatchingFiles;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x000134F2 File Offset: 0x000116F2
		public bool HasMatchingFiles
		{
			get
			{
				return this.hasMatchingFiles_;
			}
		}

		// Token: 0x04000292 RID: 658
		private readonly bool hasMatchingFiles_;
	}
}
