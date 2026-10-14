using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200006C RID: 108
	public class ExtendedPathFilter : global::ICSharpCode.SharpZipLib.Core.PathFilter
	{
		// Token: 0x06000478 RID: 1144 RVA: 0x00013C7B File Offset: 0x00011E7B
		public ExtendedPathFilter(string filter, long minSize, long maxSize) : base(filter)
		{
			this.MinSize = minSize;
			this.MaxSize = maxSize;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00013CB7 File Offset: 0x00011EB7
		public ExtendedPathFilter(string filter, global::System.DateTime minDate, global::System.DateTime maxDate) : base(filter)
		{
			this.MinDate = minDate;
			this.MaxDate = maxDate;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00013CF4 File Offset: 0x00011EF4
		public ExtendedPathFilter(string filter, long minSize, long maxSize, global::System.DateTime minDate, global::System.DateTime maxDate) : base(filter)
		{
			this.MinSize = minSize;
			this.MaxSize = maxSize;
			this.MinDate = minDate;
			this.MaxDate = maxDate;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00013D4C File Offset: 0x00011F4C
		public override bool IsMatch(string name)
		{
			bool flag = base.IsMatch(name);
			if (flag)
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(name);
				flag = (this.MinSize <= fileInfo.Length && this.MaxSize >= fileInfo.Length && this.MinDate <= fileInfo.LastWriteTime && this.MaxDate >= fileInfo.LastWriteTime);
			}
			return flag;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00013DB0 File Offset: 0x00011FB0
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00013DB8 File Offset: 0x00011FB8
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00013DDA File Offset: 0x00011FDA
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00013DE2 File Offset: 0x00011FE2
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00013E04 File Offset: 0x00012004
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00013E0C File Offset: 0x0001200C
		public global::System.DateTime MinDate
		{
			get
			{
				return this.minDate_;
			}
			set
			{
				if (value > this.maxDate_)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "Exceeds MaxDate");
				}
				this.minDate_ = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00013E33 File Offset: 0x00012033
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00013E3B File Offset: 0x0001203B
		public global::System.DateTime MaxDate
		{
			get
			{
				return this.maxDate_;
			}
			set
			{
				if (this.minDate_ > value)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "Exceeds MinDate");
				}
				this.maxDate_ = value;
			}
		}

		// Token: 0x040002A2 RID: 674
		private long minSize_;

		// Token: 0x040002A3 RID: 675
		private long maxSize_ = long.MaxValue;

		// Token: 0x040002A4 RID: 676
		private global::System.DateTime minDate_ = global::System.DateTime.MinValue;

		// Token: 0x040002A5 RID: 677
		private global::System.DateTime maxDate_ = global::System.DateTime.MaxValue;
	}
}
