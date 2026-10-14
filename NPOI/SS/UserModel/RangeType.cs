using System;
using System.Collections.Generic;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000037 RID: 55
	public class RangeType
	{
		// Token: 0x0600020F RID: 527 RVA: 0x000092F9 File Offset: 0x000074F9
		public static global::System.Collections.Generic.List<global::NPOI.SS.UserModel.RangeType> Values()
		{
			return global::NPOI.SS.UserModel.RangeType.values;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00009300 File Offset: 0x00007500
		public override string ToString()
		{
			return this.id.ToString() + " - " + this.name;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00009320 File Offset: 0x00007520
		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is global::NPOI.SS.UserModel.RangeType))
			{
				return false;
			}
			global::NPOI.SS.UserModel.RangeType rangeType = obj as global::NPOI.SS.UserModel.RangeType;
			return this.id == rangeType.id && this.name == rangeType.name;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00009362 File Offset: 0x00007562
		public override int GetHashCode()
		{
			return this.id.GetHashCode() ^ this.name.GetHashCode();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000937B File Offset: 0x0000757B
		public static global::NPOI.SS.UserModel.RangeType ById(int id)
		{
			return global::NPOI.SS.UserModel.RangeType.Values()[id - 1];
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000938C File Offset: 0x0000758C
		public static global::NPOI.SS.UserModel.RangeType ByName(string name)
		{
			foreach (global::NPOI.SS.UserModel.RangeType rangeType in global::NPOI.SS.UserModel.RangeType.Values())
			{
				if (rangeType.name.Equals(name))
				{
					return rangeType;
				}
			}
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000093EC File Offset: 0x000075EC
		private RangeType(int id, string name)
		{
			this.id = id;
			this.name = name;
		}

		// Token: 0x040000C4 RID: 196
		public static global::NPOI.SS.UserModel.RangeType NUMBER = new global::NPOI.SS.UserModel.RangeType(1, "num");

		// Token: 0x040000C5 RID: 197
		public static global::NPOI.SS.UserModel.RangeType MIN = new global::NPOI.SS.UserModel.RangeType(2, "min");

		// Token: 0x040000C6 RID: 198
		public static global::NPOI.SS.UserModel.RangeType MAX = new global::NPOI.SS.UserModel.RangeType(3, "max");

		// Token: 0x040000C7 RID: 199
		public static global::NPOI.SS.UserModel.RangeType PERCENT = new global::NPOI.SS.UserModel.RangeType(4, "percent");

		// Token: 0x040000C8 RID: 200
		public static global::NPOI.SS.UserModel.RangeType PERCENTILE = new global::NPOI.SS.UserModel.RangeType(5, "percentile");

		// Token: 0x040000C9 RID: 201
		public static global::NPOI.SS.UserModel.RangeType UNALLOCATED = new global::NPOI.SS.UserModel.RangeType(6, null);

		// Token: 0x040000CA RID: 202
		public static global::NPOI.SS.UserModel.RangeType FORMULA = new global::NPOI.SS.UserModel.RangeType(7, "formula");

		// Token: 0x040000CB RID: 203
		public static global::NPOI.SS.UserModel.RangeType AUTOMIN = new global::NPOI.SS.UserModel.RangeType(8, "autoMin");

		// Token: 0x040000CC RID: 204
		public static global::NPOI.SS.UserModel.RangeType AUTOMAX = new global::NPOI.SS.UserModel.RangeType(9, "autoMax");

		// Token: 0x040000CD RID: 205
		public int id;

		// Token: 0x040000CE RID: 206
		public string name;

		// Token: 0x040000CF RID: 207
		private static global::System.Collections.Generic.List<global::NPOI.SS.UserModel.RangeType> values = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.RangeType>
		{
			global::NPOI.SS.UserModel.RangeType.NUMBER,
			global::NPOI.SS.UserModel.RangeType.MIN,
			global::NPOI.SS.UserModel.RangeType.MAX,
			global::NPOI.SS.UserModel.RangeType.PERCENT,
			global::NPOI.SS.UserModel.RangeType.PERCENTILE,
			global::NPOI.SS.UserModel.RangeType.UNALLOCATED,
			global::NPOI.SS.UserModel.RangeType.FORMULA,
			global::NPOI.SS.UserModel.RangeType.AUTOMIN,
			global::NPOI.SS.UserModel.RangeType.AUTOMAX
		};
	}
}
