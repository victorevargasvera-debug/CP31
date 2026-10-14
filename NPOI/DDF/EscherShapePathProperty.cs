using System;

namespace NPOI.DDF
{
	// Token: 0x02000548 RID: 1352
	public class EscherShapePathProperty : global::NPOI.DDF.EscherSimpleProperty
	{
		// Token: 0x0600330D RID: 13069 RVA: 0x0009F6ED File Offset: 0x0009D8ED
		public EscherShapePathProperty(short propertyNumber, int shapePath) : base(propertyNumber, false, false, shapePath)
		{
		}

		// Token: 0x040017F2 RID: 6130
		public const int LINE_OF_STRAIGHT_SEGMENTS = 0;

		// Token: 0x040017F3 RID: 6131
		public const int CLOSED_POLYGON = 1;

		// Token: 0x040017F4 RID: 6132
		public const int CURVES = 2;

		// Token: 0x040017F5 RID: 6133
		public const int CLOSED_CURVES = 3;

		// Token: 0x040017F6 RID: 6134
		public const int COMPLEX = 4;
	}
}
