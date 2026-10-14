using System;
using System.Collections;

namespace Infragistics
{
	// Token: 0x0200001F RID: 31
	public class TypelessDataManager : global::Infragistics.DataManagerBase
	{
		// Token: 0x060001EF RID: 495 RVA: 0x0000B30A File Offset: 0x0000950A
		protected override void SetDataSource(global::System.Collections.IEnumerable source)
		{
			base.OriginalDataSource = source;
			base.SetDataSource(source);
		}
	}
}
