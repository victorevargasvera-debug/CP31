using System;
using System.Collections.Generic;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200055D RID: 1373
	public class CT_Revisions
	{
		// Token: 0x06003B85 RID: 15237 RVA: 0x00092DDD File Offset: 0x00090FDD
		public CT_Revisions()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x00092DF0 File Offset: 0x00090FF0
		// (set) Token: 0x06003B87 RID: 15239 RVA: 0x00092DF8 File Offset: 0x00090FF8
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x04002634 RID: 9780
		private global::System.Collections.Generic.List<object> itemsField;
	}
}
