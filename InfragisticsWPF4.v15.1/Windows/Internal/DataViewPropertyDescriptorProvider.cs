using System;
using System.Data;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001FC RID: 508
	public class DataViewPropertyDescriptorProvider : global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider
	{
		// Token: 0x060012E8 RID: 4840 RVA: 0x0004373E File Offset: 0x0004193E
		public DataViewPropertyDescriptorProvider(global::System.Data.DataView view) : base(view)
		{
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00043747 File Offset: 0x00041947
		public global::System.Data.DataView View
		{
			get
			{
				return base.Source as global::System.Data.DataView;
			}
		}
	}
}
