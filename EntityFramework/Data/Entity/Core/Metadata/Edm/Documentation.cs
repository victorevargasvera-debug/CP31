using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004A1 RID: 1185
	public sealed class Documentation : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003A4D RID: 14925 RVA: 0x000BFEA0 File Offset: 0x000BE0A0
		internal Documentation()
		{
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x000BFEBE File Offset: 0x000BE0BE
		public Documentation(string summary, string longDescription)
		{
			this.Summary = summary;
			this.LongDescription = longDescription;
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x000BFEEA File Offset: 0x000BE0EA
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Documentation;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x000BFEEE File Offset: 0x000BE0EE
		// (set) Token: 0x06003A51 RID: 14929 RVA: 0x000BFEF6 File Offset: 0x000BE0F6
		public string Summary
		{
			get
			{
				return this._summary;
			}
			internal set
			{
				if (value != null)
				{
					this._summary = value;
					return;
				}
				this._summary = "";
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06003A52 RID: 14930 RVA: 0x000BFF0E File Offset: 0x000BE10E
		// (set) Token: 0x06003A53 RID: 14931 RVA: 0x000BFF16 File Offset: 0x000BE116
		public string LongDescription
		{
			get
			{
				return this._longDescription;
			}
			internal set
			{
				if (value != null)
				{
					this._longDescription = value;
					return;
				}
				this._longDescription = "";
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x000BFF2E File Offset: 0x000BE12E
		internal override string Identity
		{
			get
			{
				return "Documentation";
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x000BFF35 File Offset: 0x000BE135
		public bool IsEmpty
		{
			get
			{
				return string.IsNullOrEmpty(this._summary) && string.IsNullOrEmpty(this._longDescription);
			}
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x000BFF54 File Offset: 0x000BE154
		public override string ToString()
		{
			return this._summary;
		}

		// Token: 0x04001374 RID: 4980
		private string _summary = "";

		// Token: 0x04001375 RID: 4981
		private string _longDescription = "";
	}
}
