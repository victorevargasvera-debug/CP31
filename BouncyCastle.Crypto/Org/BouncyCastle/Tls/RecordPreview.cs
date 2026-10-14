using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E4 RID: 228
	public sealed class RecordPreview
	{
		// Token: 0x06000826 RID: 2086 RVA: 0x00021FE4 File Offset: 0x000201E4
		internal static global::Org.BouncyCastle.Tls.RecordPreview CombineAppData(global::Org.BouncyCastle.Tls.RecordPreview a, global::Org.BouncyCastle.Tls.RecordPreview b)
		{
			return new global::Org.BouncyCastle.Tls.RecordPreview(a.RecordSize + b.RecordSize, a.ContentLimit + b.ContentLimit);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00022005 File Offset: 0x00020205
		internal static global::Org.BouncyCastle.Tls.RecordPreview ExtendRecordSize(global::Org.BouncyCastle.Tls.RecordPreview a, int recordSize)
		{
			return new global::Org.BouncyCastle.Tls.RecordPreview(a.RecordSize + recordSize, a.ContentLimit);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0002201A File Offset: 0x0002021A
		internal RecordPreview(int recordSize, int contentLimit)
		{
			this.recordSize = recordSize;
			this.contentLimit = contentLimit;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00022030 File Offset: 0x00020230
		public int ContentLimit
		{
			get
			{
				return this.contentLimit;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00022038 File Offset: 0x00020238
		public int RecordSize
		{
			get
			{
				return this.recordSize;
			}
		}

		// Token: 0x04000633 RID: 1587
		private readonly int recordSize;

		// Token: 0x04000634 RID: 1588
		private readonly int contentLimit;
	}
}
