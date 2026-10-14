using System;
using System.Collections.Generic;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000040 RID: 64
	public class IconSet
	{
		// Token: 0x06000262 RID: 610 RVA: 0x00009F8A File Offset: 0x0000818A
		public static global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IconSet> Values()
		{
			return global::NPOI.SS.UserModel.IconSet.values;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00009F91 File Offset: 0x00008191
		public override string ToString()
		{
			return this.id.ToString() + " - " + this.name;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00009FAE File Offset: 0x000081AE
		public static global::NPOI.SS.UserModel.IconSet ById(int id)
		{
			return global::NPOI.SS.UserModel.IconSet.Values()[id];
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009FBC File Offset: 0x000081BC
		public static global::NPOI.SS.UserModel.IconSet ByName(string name)
		{
			foreach (global::NPOI.SS.UserModel.IconSet iconSet in global::NPOI.SS.UserModel.IconSet.Values())
			{
				if (iconSet.name.Equals(name))
				{
					return iconSet;
				}
			}
			return null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000A01C File Offset: 0x0000821C
		public static global::NPOI.SS.UserModel.IconSet ByOOXMLName(string name)
		{
			if (name.StartsWith("Item"))
			{
				name = name.Remove(0, 4);
			}
			return global::NPOI.SS.UserModel.IconSet.ByName(name);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000A03B File Offset: 0x0000823B
		private IconSet(int id, int num, string name)
		{
			this.id = id;
			this.num = num;
			this.name = name;
		}

		// Token: 0x040000F8 RID: 248
		public static global::NPOI.SS.UserModel.IconSet GYR_3_ARROW = new global::NPOI.SS.UserModel.IconSet(0, 3, "3Arrows");

		// Token: 0x040000F9 RID: 249
		public static global::NPOI.SS.UserModel.IconSet GREY_3_ARROWS = new global::NPOI.SS.UserModel.IconSet(1, 3, "3ArrowsGray");

		// Token: 0x040000FA RID: 250
		public static global::NPOI.SS.UserModel.IconSet GYR_3_FLAGS = new global::NPOI.SS.UserModel.IconSet(2, 3, "3Flags");

		// Token: 0x040000FB RID: 251
		public static global::NPOI.SS.UserModel.IconSet GYR_3_TRAFFIC_LIGHTS = new global::NPOI.SS.UserModel.IconSet(3, 3, "3TrafficLights1");

		// Token: 0x040000FC RID: 252
		public static global::NPOI.SS.UserModel.IconSet GYR_3_TRAFFIC_LIGHTS_BOX = new global::NPOI.SS.UserModel.IconSet(4, 3, "3TrafficLights2");

		// Token: 0x040000FD RID: 253
		public static global::NPOI.SS.UserModel.IconSet GYR_3_SHAPES = new global::NPOI.SS.UserModel.IconSet(5, 3, "3Signs");

		// Token: 0x040000FE RID: 254
		public static global::NPOI.SS.UserModel.IconSet GYR_3_SYMBOLS_CIRCLE = new global::NPOI.SS.UserModel.IconSet(6, 3, "3Symbols");

		// Token: 0x040000FF RID: 255
		public static global::NPOI.SS.UserModel.IconSet GYR_3_SYMBOLS = new global::NPOI.SS.UserModel.IconSet(7, 3, "3Symbols2");

		// Token: 0x04000100 RID: 256
		public static global::NPOI.SS.UserModel.IconSet GYR_4_ARROWS = new global::NPOI.SS.UserModel.IconSet(8, 4, "4Arrows");

		// Token: 0x04000101 RID: 257
		public static global::NPOI.SS.UserModel.IconSet GREY_4_ARROWS = new global::NPOI.SS.UserModel.IconSet(9, 4, "4ArrowsGray");

		// Token: 0x04000102 RID: 258
		public static global::NPOI.SS.UserModel.IconSet RB_4_TRAFFIC_LIGHTS = new global::NPOI.SS.UserModel.IconSet(10, 4, "4RedToBlack");

		// Token: 0x04000103 RID: 259
		public static global::NPOI.SS.UserModel.IconSet RATINGS_4 = new global::NPOI.SS.UserModel.IconSet(11, 4, "4Rating");

		// Token: 0x04000104 RID: 260
		public static global::NPOI.SS.UserModel.IconSet GYRB_4_TRAFFIC_LIGHTS = new global::NPOI.SS.UserModel.IconSet(12, 4, "4TrafficLights");

		// Token: 0x04000105 RID: 261
		public static global::NPOI.SS.UserModel.IconSet GYYYR_5_ARROWS = new global::NPOI.SS.UserModel.IconSet(13, 5, "5Arrows");

		// Token: 0x04000106 RID: 262
		public static global::NPOI.SS.UserModel.IconSet GREY_5_ARROWS = new global::NPOI.SS.UserModel.IconSet(14, 5, "5ArrowsGray");

		// Token: 0x04000107 RID: 263
		public static global::NPOI.SS.UserModel.IconSet RATINGS_5 = new global::NPOI.SS.UserModel.IconSet(15, 5, "5Rating");

		// Token: 0x04000108 RID: 264
		public static global::NPOI.SS.UserModel.IconSet QUARTERS_5 = new global::NPOI.SS.UserModel.IconSet(16, 5, "5Quarters");

		// Token: 0x04000109 RID: 265
		protected static global::NPOI.SS.UserModel.IconSet DEFAULT_ICONSET = global::NPOI.SS.UserModel.IconSet.GYR_3_TRAFFIC_LIGHTS;

		// Token: 0x0400010A RID: 266
		public int id;

		// Token: 0x0400010B RID: 267
		public int num;

		// Token: 0x0400010C RID: 268
		public string name;

		// Token: 0x0400010D RID: 269
		private static global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IconSet> values = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IconSet>
		{
			global::NPOI.SS.UserModel.IconSet.GYR_3_ARROW,
			global::NPOI.SS.UserModel.IconSet.GREY_3_ARROWS,
			global::NPOI.SS.UserModel.IconSet.GYR_3_FLAGS,
			global::NPOI.SS.UserModel.IconSet.GYR_3_TRAFFIC_LIGHTS,
			global::NPOI.SS.UserModel.IconSet.GYR_3_TRAFFIC_LIGHTS_BOX,
			global::NPOI.SS.UserModel.IconSet.GYR_3_SHAPES,
			global::NPOI.SS.UserModel.IconSet.GYR_3_SYMBOLS_CIRCLE,
			global::NPOI.SS.UserModel.IconSet.GYR_3_SYMBOLS,
			global::NPOI.SS.UserModel.IconSet.GYR_4_ARROWS,
			global::NPOI.SS.UserModel.IconSet.GREY_4_ARROWS,
			global::NPOI.SS.UserModel.IconSet.RB_4_TRAFFIC_LIGHTS,
			global::NPOI.SS.UserModel.IconSet.RATINGS_4,
			global::NPOI.SS.UserModel.IconSet.GYRB_4_TRAFFIC_LIGHTS,
			global::NPOI.SS.UserModel.IconSet.GYYYR_5_ARROWS,
			global::NPOI.SS.UserModel.IconSet.GREY_5_ARROWS,
			global::NPOI.SS.UserModel.IconSet.RATINGS_5,
			global::NPOI.SS.UserModel.IconSet.QUARTERS_5
		};
	}
}
