using System;
using System.Diagnostics;

namespace Gibraltar.Serialization
{
	// Token: 0x0200010B RID: 267
	[global::System.Diagnostics.DebuggerDisplay("Start: {StartTime} End: {EndTime} Total Bytes: {FragmentSize}")]
	internal class FragmentStorageSummary : global::System.IComparable<global::Gibraltar.Serialization.FragmentStorageSummary>
	{
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x0001BFAC File Offset: 0x0001A1AC
		public global::System.DateTimeOffset StartTime { get; private set; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0001BFB8 File Offset: 0x0001A1B8
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		public global::System.DateTimeOffset EndTime { get; private set; }

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0001BFCC File Offset: 0x0001A1CC
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		public long FragmentSize { get; private set; }

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001BFE0 File Offset: 0x0001A1E0
		public FragmentStorageSummary(global::System.DateTimeOffset startTime, global::System.DateTimeOffset endTime, long size)
		{
			this.StartTime = startTime;
			this.EndTime = endTime;
			this.FragmentSize = size;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0001C00C File Offset: 0x0001A20C
		public int CompareTo(global::Gibraltar.Serialization.FragmentStorageSummary other)
		{
			return (int)(this.EndTime.UtcTicks - other.EndTime.UtcTicks);
		}
	}
}
