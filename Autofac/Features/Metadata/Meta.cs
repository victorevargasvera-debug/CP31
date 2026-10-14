using System;

namespace Autofac.Features.Metadata
{
	// Token: 0x0200003E RID: 62
	public class Meta<T, TMetadata>
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00006F19 File Offset: 0x00005119
		public Meta(T value, TMetadata metadata)
		{
			this.Value = value;
			this.Metadata = metadata;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006F2F File Offset: 0x0000512F
		public T Value { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00006F37 File Offset: 0x00005137
		public TMetadata Metadata { get; }
	}
}
