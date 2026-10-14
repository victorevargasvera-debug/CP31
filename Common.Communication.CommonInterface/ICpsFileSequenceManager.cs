using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public interface ICpsFileSequenceManager
	{
		// Token: 0x0600002B RID: 43
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir);

		// Token: 0x0600002C RID: 44
		void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x0600002D RID: 45
		global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x0600002E RID: 46
		void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x0600002F RID: 47
		long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir);
	}
}
