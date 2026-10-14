using System;

namespace NPOI.XSSF.Streaming.Properties
{
	// Token: 0x020000DD RID: 221
	public class CommentProperty : global::NPOI.XSSF.Streaming.Properties.Property
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x00030319 File Offset: 0x0002E519
		public CommentProperty(object value) : base(value)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00006FBA File Offset: 0x000051BA
		public override int GetType()
		{
			return 1;
		}
	}
}
