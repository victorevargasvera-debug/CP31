using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000218 RID: 536
	internal class GroupInfo
	{
		// Token: 0x06002019 RID: 8217 RVA: 0x0008BCC3 File Offset: 0x00089EC3
		public override string ToString()
		{
			if (!string.IsNullOrWhiteSpace(this._description))
			{
				return this._description;
			}
			if (this._value != null)
			{
				return this._value.ToString();
			}
			return base.ToString();
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0008BCF3 File Offset: 0x00089EF3
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x0008BCFB File Offset: 0x00089EFB
		public object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x0008BD04 File Offset: 0x00089F04
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x0008BD0C File Offset: 0x00089F0C
		public int ChildGroupCount
		{
			get
			{
				return this._childGroupCount;
			}
			set
			{
				this._childGroupCount = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0008BD15 File Offset: 0x00089F15
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x0008BD1D File Offset: 0x00089F1D
		public int ChildDataRecordCount
		{
			get
			{
				return this._childDataRecordCount;
			}
			set
			{
				this._childDataRecordCount = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x0008BD26 File Offset: 0x00089F26
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x0008BD2E File Offset: 0x00089F2E
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x0008BD37 File Offset: 0x00089F37
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x0008BD3F File Offset: 0x00089F3F
		public object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				this._tag = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x0008BD48 File Offset: 0x00089F48
		internal int ChildCount
		{
			get
			{
				if (this._childGroupCount <= 0)
				{
					return this._childDataRecordCount;
				}
				return this._childGroupCount;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x0008BD60 File Offset: 0x00089F60
		// (set) Token: 0x06002026 RID: 8230 RVA: 0x0008BD68 File Offset: 0x00089F68
		internal global::Infragistics.Windows.DataPresenter.GroupByRecord GroupByRecord
		{
			get
			{
				return this._groupByRecord;
			}
			set
			{
				this._groupByRecord = value;
			}
		}

		// Token: 0x04000D80 RID: 3456
		private object _tag;

		// Token: 0x04000D81 RID: 3457
		private object _value;

		// Token: 0x04000D82 RID: 3458
		private int _childGroupCount;

		// Token: 0x04000D83 RID: 3459
		private int _childDataRecordCount;

		// Token: 0x04000D84 RID: 3460
		private string _description;

		// Token: 0x04000D85 RID: 3461
		private global::Infragistics.Windows.DataPresenter.GroupByRecord _groupByRecord;
	}
}
