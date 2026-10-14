using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E6 RID: 486
	internal class GroupInfo
	{
		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00076173 File Offset: 0x00074373
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0007617B File Offset: 0x0007437B
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

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00076184 File Offset: 0x00074384
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0007618C File Offset: 0x0007438C
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

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00076195 File Offset: 0x00074395
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0007619D File Offset: 0x0007439D
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x000761A6 File Offset: 0x000743A6
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x000761AE File Offset: 0x000743AE
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

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x000761B7 File Offset: 0x000743B7
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x000761BF File Offset: 0x000743BF
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

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x000761C8 File Offset: 0x000743C8
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

		// Token: 0x04000B6F RID: 2927
		private object _tag;

		// Token: 0x04000B70 RID: 2928
		private object _value;

		// Token: 0x04000B71 RID: 2929
		private int _childGroupCount;

		// Token: 0x04000B72 RID: 2930
		private int _childDataRecordCount;

		// Token: 0x04000B73 RID: 2931
		private string _description;
	}
}
