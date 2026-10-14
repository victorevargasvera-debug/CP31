using System;
using System.Collections.Generic;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000038 RID: 56
	public class ConditionType
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000950B File Offset: 0x0000770B
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00009513 File Offset: 0x00007713
		public byte Id { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000951C File Offset: 0x0000771C
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00009524 File Offset: 0x00007724
		public string Type { get; set; }

		// Token: 0x0600021B RID: 539 RVA: 0x00009530 File Offset: 0x00007730
		public override string ToString()
		{
			return this.Id.ToString() + " - " + this.Type;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000955C File Offset: 0x0000775C
		public override int GetHashCode()
		{
			return this.Id.GetHashCode() ^ this.Type.GetHashCode();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00009584 File Offset: 0x00007784
		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is global::NPOI.SS.UserModel.ConditionType))
			{
				return false;
			}
			global::NPOI.SS.UserModel.ConditionType conditionType = obj as global::NPOI.SS.UserModel.ConditionType;
			return this.Id == conditionType.Id && this.Type == conditionType.Type;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000095C6 File Offset: 0x000077C6
		public static global::NPOI.SS.UserModel.ConditionType ForId(byte id)
		{
			return global::NPOI.SS.UserModel.ConditionType.ForId((int)id);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000095CE File Offset: 0x000077CE
		public static global::NPOI.SS.UserModel.ConditionType ForId(int id)
		{
			return global::NPOI.SS.UserModel.ConditionType.lookup[id];
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000095DB File Offset: 0x000077DB
		private ConditionType(int id, string type)
		{
			this.Id = (byte)id;
			this.Type = type;
			global::NPOI.SS.UserModel.ConditionType.lookup.Add(id, this);
		}

		// Token: 0x040000D0 RID: 208
		private static global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.ConditionType> lookup = new global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.ConditionType>();

		// Token: 0x040000D1 RID: 209
		public static global::NPOI.SS.UserModel.ConditionType CellValueIs = new global::NPOI.SS.UserModel.ConditionType(1, "cellIs");

		// Token: 0x040000D2 RID: 210
		public static global::NPOI.SS.UserModel.ConditionType Formula = new global::NPOI.SS.UserModel.ConditionType(2, "expression");

		// Token: 0x040000D3 RID: 211
		public static global::NPOI.SS.UserModel.ConditionType ColorScale = new global::NPOI.SS.UserModel.ConditionType(3, "colorScale");

		// Token: 0x040000D4 RID: 212
		public static global::NPOI.SS.UserModel.ConditionType DataBar = new global::NPOI.SS.UserModel.ConditionType(4, "dataBar");

		// Token: 0x040000D5 RID: 213
		public static global::NPOI.SS.UserModel.ConditionType Filter = new global::NPOI.SS.UserModel.ConditionType(5, null);

		// Token: 0x040000D6 RID: 214
		public static global::NPOI.SS.UserModel.ConditionType IconSet = new global::NPOI.SS.UserModel.ConditionType(6, "iconSet");
	}
}
