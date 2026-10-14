using System;
using System.Windows.Media;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000022 RID: 34
	internal abstract class ColorFactory
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x0003CD70 File Offset: 0x0003AF70
		public ColorFactory()
		{
		}

		// Token: 0x060002A2 RID: 674
		public abstract global::System.Windows.Media.Color GetColor(int color);

		// Token: 0x060002A3 RID: 675
		public abstract global::System.Windows.Media.Color GetColor(global::System.Windows.Media.Color color);
	}
}
