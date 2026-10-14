using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000498 RID: 1176
	[global::System.Serializable]
	public class DataModelErrorEventArgs : global::System.EventArgs
	{
		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06003A26 RID: 14886 RVA: 0x000BFA0C File Offset: 0x000BDC0C
		// (set) Token: 0x06003A27 RID: 14887 RVA: 0x000BFA14 File Offset: 0x000BDC14
		public string PropertyName { get; internal set; }

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06003A28 RID: 14888 RVA: 0x000BFA1D File Offset: 0x000BDC1D
		// (set) Token: 0x06003A29 RID: 14889 RVA: 0x000BFA25 File Offset: 0x000BDC25
		public string ErrorMessage { get; internal set; }

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x000BFA2E File Offset: 0x000BDC2E
		// (set) Token: 0x06003A2B RID: 14891 RVA: 0x000BFA36 File Offset: 0x000BDC36
		public global::System.Data.Entity.Core.Metadata.Edm.MetadataItem Item
		{
			get
			{
				return this._item;
			}
			set
			{
				this._item = value;
			}
		}

		// Token: 0x04001367 RID: 4967
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Metadata.Edm.MetadataItem _item;
	}
}
