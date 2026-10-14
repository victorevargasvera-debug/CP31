using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200006D RID: 109
	[global::System.Obsolete("Use ExtendedPathFilter instead")]
	public class NameAndSizeFilter : global::ICSharpCode.SharpZipLib.Core.PathFilter
	{
		// Token: 0x06000484 RID: 1156 RVA: 0x00013E62 File Offset: 0x00012062
		public NameAndSizeFilter(string filter, long minSize, long maxSize) : base(filter)
		{
			this.MinSize = minSize;
			this.MaxSize = maxSize;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00013E88 File Offset: 0x00012088
		public override bool IsMatch(string name)
		{
			bool flag = base.IsMatch(name);
			if (flag)
			{
				long length = new global::System.IO.FileInfo(name).Length;
				flag = (this.MinSize <= length && this.MaxSize >= length);
			}
			return flag;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00013EC6 File Offset: 0x000120C6
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00013ECE File Offset: 0x000120CE
		public long MinSize
		{
			get
			{
				return this.minSize_;
			}
			set
			{
				if (value < 0L || this.maxSize_ < value)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.minSize_ = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00013EF0 File Offset: 0x000120F0
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00013EF8 File Offset: 0x000120F8
		public long MaxSize
		{
			get
			{
				return this.maxSize_;
			}
			set
			{
				if (value < 0L || this.minSize_ > value)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.maxSize_ = value;
			}
		}

		// Token: 0x040002A6 RID: 678
		private long minSize_;

		// Token: 0x040002A7 RID: 679
		private long maxSize_ = long.MaxValue;
	}
}
