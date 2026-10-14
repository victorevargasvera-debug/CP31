using System;
using AcpCommonLib;
using CommonResources;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000D5 RID: 213
	public class Option
	{
		// Token: 0x06000D04 RID: 3332 RVA: 0x00002FCC File Offset: 0x000011CC
		internal Option(string name, string desc, int fcodePos, global::SpecialFeatures.Flashport.FlashRadio.OptionIDs optionID)
		{
			this.a = name;
			this.b = desc;
			this.c = fcodePos;
			this.f = null;
			this.h = null;
			this.k = optionID;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0010B934 File Offset: 0x00109B34
		internal Option(string name, int dispOrder, global::AcpCommonLib.IAcpField field, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fldLayout, global::SpecialFeatures.Flashport.FlashRadio.OptionIDs optionID)
		{
			this.a = name;
			this.b = fldLayout.Name;
			this.c = 8 * (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout).Offset - (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout).BitOffset;
			this.d = dispOrder;
			this.e = 1;
			this.g = field;
			this.f = null;
			this.h = (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout).Mask;
			this.j = null;
			this.i = fldLayout;
			this.k = optionID;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0010B9C4 File Offset: 0x00109BC4
		internal Option(string name, int dispOrder, global::AcpCommonLib.IAcpField field, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fldLayout, global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint optionGate, global::SpecialFeatures.Flashport.FlashRadio.OptionIDs optionID)
		{
			this.a = name;
			this.b = fldLayout.Name;
			this.c = 8 * (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout).Offset - (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout).BitOffset;
			this.d = dispOrder;
			this.e = 1;
			this.g = field;
			this.f = null;
			this.h = (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout).Mask;
			this.j = optionGate;
			this.i = fldLayout;
			this.k = optionID;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0010BA54 File Offset: 0x00109C54
		internal Option(string name, int dispOrder, int bitsVal, global::AcpCommonLib.IAcpField field, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fldLayout, global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint optionGate, global::SpecialFeatures.Flashport.FlashRadio.OptionIDs optionID)
		{
			this.a = name;
			this.b = fldLayout.Name;
			this.c = 8 * (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout).Offset - (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout).Mask.BitOffset;
			this.d = dispOrder;
			this.e = bitsVal;
			this.g = field;
			this.f = null;
			this.h = (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout).Mask;
			this.j = optionGate;
			this.i = fldLayout;
			this.k = optionID;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0010BAE8 File Offset: 0x00109CE8
		internal Option(string name, int dispOrder, int bitsVal, global::AcpCommonLib.IAcpField field, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fldLayout, global::SpecialFeatures.Flashport.FlashRadio.OptionIDs optionID)
		{
			this.a = name;
			this.b = fldLayout.Name;
			this.c = 8 * (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout).Offset - (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout).Mask.BitOffset;
			this.d = dispOrder;
			this.e = bitsVal;
			this.g = field;
			this.f = null;
			this.h = (fldLayout as global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout).Mask;
			this.j = null;
			this.i = fldLayout;
			this.k = optionID;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0010BB7C File Offset: 0x00109D7C
		public override string ToString()
		{
			int a_ = 19;
			short num = (short)1241203837;
			short num2 = num;
			num = (short)2088256637;
			switch (num2 == num)
			{
			default:
			{
				num = (short)177537024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1675296768;
			if (num != 0)
			{
			}
			num = (short)2059665409;
			if (num != 0)
			{
			}
			return this.a + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뮕", a_) + this.b;
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0010BC4C File Offset: 0x00109E4C
		public string Name
		{
			get
			{
				short num = (short)105674421;
				short num2 = num;
				num = (short)1963161269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1056112640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)529596417;
				if (num != 0)
				{
				}
				num = (short)680067072;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0010BCFC File Offset: 0x00109EFC
		public string Description
		{
			get
			{
				short num = (short)984743937;
				if (num != 0)
				{
				}
				num = (short)1515257856;
				short num2 = num;
				num = (short)605440578;
				short num3 = num;
				num = (short)1871596098;
				switch (num3 == num)
				{
				}
				num = (short)1705967616;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0010BDB0 File Offset: 0x00109FB0
		internal int Position
		{
			get
			{
				short num = (short)849346561;
				if (num != 0)
				{
				}
				num = (short)902889472;
				short num2 = num;
				num = (short)2076098246;
				short num3 = num;
				num = (short)890355398;
				switch (num3 == num)
				{
				}
				num = (short)1907752960;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0010BE5C File Offset: 0x0010A05C
		internal int BitsValue
		{
			get
			{
				short num = (short)1976801628;
				short num2 = num;
				num = (short)1092983132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)444792832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1463156737;
				if (num != 0)
				{
				}
				num = (short)1476001792;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0010BF0C File Offset: 0x0010A10C
		internal int DisplayOrder
		{
			get
			{
				short num = (short)29294593;
				if (num != 0)
				{
				}
				num = (short)800391168;
				short num2 = num;
				num = (short)1960814738;
				short num3 = num;
				num = (short)1856088210;
				switch (num3 == num)
				{
				}
				num = (short)1504182272;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0010BFBC File Offset: 0x0010A1BC
		public global::AcpCommonLib.IAcpField DbField
		{
			get
			{
				short num = (short)255426959;
				short num2 = num;
				num = (short)1124565391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1278869504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)337707009;
				if (num != 0)
				{
				}
				num = (short)1742929920;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0010C06C File Offset: 0x0010A26C
		internal int[] PositionArray
		{
			get
			{
				short num = (short)972423169;
				if (num != 0)
				{
				}
				num = (short)1617362944;
				short num2 = num;
				num = (short)1823479547;
				short num3 = num;
				num = (short)1796347643;
				switch (num3 == num)
				{
				}
				num = (short)888930304;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0010C11C File Offset: 0x0010A31C
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask Mask
		{
			get
			{
				short num = (short)1537044446;
				short num2 = num;
				num = (short)549023710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)434569216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)907018241;
				if (num != 0)
				{
				}
				num = (short)1396965376;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0010C1CC File Offset: 0x0010A3CC
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x0010C27C File Offset: 0x0010A47C
		internal global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint IsOptionUsed
		{
			get
			{
				short num = (short)833006103;
				short num2 = num;
				num = (short)1926998551;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1330315264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)671940609;
				if (num != 0)
				{
				}
				num = (short)1546846208;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1121717181;
				short num2 = num;
				num = (short)446041021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)494731264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1060569088;
				if (num != 0)
				{
				}
				num = (short)424607745;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0010C32C File Offset: 0x0010A52C
		internal int BitOffset
		{
			get
			{
				short num = (short)232390656;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1478754304;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					}
					case 1:
						goto IL_A4;
					case 2:
						goto IL_145;
					case 3:
					{
						if (!(this.i is global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout))
						{
							goto IL_15B;
						}
						num = (short)538237760;
						short num4 = num;
						num = (short)2010831680;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1710620672;
							if (num != 0)
							{
							}
							num = (short)1176961026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_5C:
					if (this.i is global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout)
					{
						num = (short)386924545;
						if (num != 0)
						{
						}
						num = (short)1912340481;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)2109145091;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A4:
				return (this.i as global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout).BitOffset;
				IL_145:
				return (this.i as global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout).Mask.BitOffset;
				IL_15B:
				throw new global::System.NotImplementedException(global::CommonResources.AppResources.Option_Layout_Type_Not_Supported);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0010C4A0 File Offset: 0x0010A6A0
		internal int ByteOffset
		{
			get
			{
				short num = (short)1899626496;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)683278336;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					}
					case 1:
						goto IL_7F;
					case 2:
						goto IL_144;
					case 3:
					{
						if (!(this.i is global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout))
						{
							goto IL_15A;
						}
						num = (short)1143971059;
						short num4 = num;
						num = (short)63020275;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)537788416;
							if (num != 0)
							{
							}
							num = (short)129302530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_5E:
					if (this.i is global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout)
					{
						num = (short)1619918849;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1548156931;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_7F:
				num = (short)1207173121;
				if (num != 0)
				{
				}
				return (this.i as global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout).Offset;
				IL_144:
				return (this.i as global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout).Offset;
				IL_15A:
				throw new global::System.NotImplementedException(global::CommonResources.AppResources.Option_Layout_Type_Not_Supported);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0010C614 File Offset: 0x0010A814
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x0010C6C4 File Offset: 0x0010A8C4
		public global::SpecialFeatures.Flashport.FlashRadio.OptionIDs OptionID
		{
			get
			{
				short num = (short)885495118;
				short num2 = num;
				num = (short)1821087054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1975517184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1406074881;
				if (num != 0)
				{
				}
				num = (short)786694144;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)728607179;
				short num2 = num;
				num = (short)1169598923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1219493888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2114453505;
				if (num != 0)
				{
				}
				num = (short)1236074496;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x04000642 RID: 1602
		private string a;

		// Token: 0x04000643 RID: 1603
		private string b;

		// Token: 0x04000644 RID: 1604
		private int c;

		// Token: 0x04000645 RID: 1605
		private int d;

		// Token: 0x04000646 RID: 1606
		private int e;

		// Token: 0x04000647 RID: 1607
		private int[] f;

		// Token: 0x04000648 RID: 1608
		private global::AcpCommonLib.IAcpField g;

		// Token: 0x04000649 RID: 1609
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask h;

		// Token: 0x0400064A RID: 1610
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout i;

		// Token: 0x0400064B RID: 1611
		private global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint j;

		// Token: 0x0400064C RID: 1612
		private global::SpecialFeatures.Flashport.FlashRadio.OptionIDs k;
	}
}
