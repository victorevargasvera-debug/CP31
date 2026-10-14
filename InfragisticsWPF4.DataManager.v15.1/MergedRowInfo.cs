using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x0200000F RID: 15
	public class MergedRowInfo
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00006C8E File Offset: 0x00004E8E
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00006C96 File Offset: 0x00004E96
		public global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo> MergedGroups { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00006C9F File Offset: 0x00004E9F
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00006CA7 File Offset: 0x00004EA7
		public object Data { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00006CB0 File Offset: 0x00004EB0
		public global::System.Collections.Generic.Dictionary<object, bool> IsLastRowInGroup
		{
			get
			{
				return this._lastRowInGroup;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public global::System.Collections.Generic.Dictionary<object, bool> IsFirstRowInGroup
		{
			get
			{
				return this._firstRowInGroup;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public override bool Equals(object obj)
		{
			global::Infragistics.MergedRowInfo mergedRowInfo = obj as global::Infragistics.MergedRowInfo;
			if (this.Data != null && mergedRowInfo != null)
			{
				return this.Data.Equals(mergedRowInfo.Data);
			}
			return base.Equals(obj);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006CF8 File Offset: 0x00004EF8
		public override int GetHashCode()
		{
			if (this.Data != null)
			{
				return this.Data.GetHashCode();
			}
			return base.GetHashCode();
		}

		// Token: 0x04000036 RID: 54
		private global::System.Collections.Generic.Dictionary<object, bool> _lastRowInGroup = new global::System.Collections.Generic.Dictionary<object, bool>();

		// Token: 0x04000037 RID: 55
		private global::System.Collections.Generic.Dictionary<object, bool> _firstRowInGroup = new global::System.Collections.Generic.Dictionary<object, bool>();
	}
}
