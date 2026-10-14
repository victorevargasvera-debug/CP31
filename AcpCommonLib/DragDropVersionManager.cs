using System;
using System.Globalization;

namespace AcpCommonLib
{
	// Token: 0x0200001D RID: 29
	public abstract class DragDropVersionManager
	{
		// Token: 0x0600014C RID: 332
		public abstract object GetVersionObj();

		// Token: 0x0600014D RID: 333
		public abstract global::System.Globalization.CultureInfo GetApplicationLanguage();

		// Token: 0x0600014E RID: 334
		public abstract bool IsDropAllowedByApp(object producerObj, object consumerObj);

		// Token: 0x0600014F RID: 335
		public abstract bool IsDropAllowedByLocalApp(object producerObj, object consumerObj);
	}
}
