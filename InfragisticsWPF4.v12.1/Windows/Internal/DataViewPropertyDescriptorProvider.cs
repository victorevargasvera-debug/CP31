using System;
using System.Data;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001CE RID: 462
	public class DataViewPropertyDescriptorProvider : global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider
	{
		// Token: 0x06001117 RID: 4375 RVA: 0x0003DFFE File Offset: 0x0003C1FE
		public DataViewPropertyDescriptorProvider(global::System.Data.DataView view) : base(view)
		{
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0003E007 File Offset: 0x0003C207
		public global::System.Data.DataView View
		{
			get
			{
				return base.Source as global::System.Data.DataView;
			}
		}
	}
}
