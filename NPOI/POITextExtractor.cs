using System;
using NPOI.Util;

namespace NPOI
{
	// Token: 0x02000008 RID: 8
	public abstract class POITextExtractor : global::NPOI.Util.ICloseable
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000026 RID: 38
		public abstract string Text { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000027 RID: 39
		public abstract global::NPOI.POITextExtractor MetadataTextExtractor { get; }

		// Token: 0x06000028 RID: 40 RVA: 0x00002520 File Offset: 0x00000720
		public void SetFilesystem(global::NPOI.Util.ICloseable fs)
		{
			this.fsToClose = fs;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002529 File Offset: 0x00000729
		public virtual void Close()
		{
			if (this.fsToClose != null)
			{
				this.fsToClose.Close();
			}
		}

		// Token: 0x04000008 RID: 8
		private global::NPOI.Util.ICloseable fsToClose;
	}
}
