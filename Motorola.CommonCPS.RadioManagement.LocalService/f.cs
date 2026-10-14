using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000044 RID: 68
	internal static class f
	{
		// Token: 0x06000236 RID: 566 RVA: 0x00028D2C File Offset: 0x00026F2C
		public static void a(this global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase A_0)
		{
			short num = (short)549257219;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1C2;
				case 1:
					goto IL_213;
				case 2:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)
					{
						num = (short)1692336138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 4:
					goto IL_EE;
				case 5:
				{
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)
					{
						num = (short)1525219328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1251557724;
					short num3 = num;
					num = (short)1219641692;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17B;
					default:
						num = (short)1692991488;
						if (num != 0)
						{
						}
						num = (short)1696464898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_24F;
				case 7:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)
					{
						num = (short)320012294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1289355269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)
					{
						num = (short)1905917956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)72548359;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_6E;
				case 10:
					A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.e();
					num = (short)338165761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_52:
				if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)
				{
					num = (short)880279561;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)371720200;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6E:
			goto IL_17B;
			IL_EE:
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.a();
			return;
			IL_17B:
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.d();
			return;
			IL_1C2:
			num = (short)1708851200;
			short num4 = num;
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.c();
			return;
			IL_213:
			return;
			IL_24F:
			num = (short)608370689;
			if (num != 0)
			{
			}
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.b();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00028F9C File Offset: 0x0002719C
		public static void a(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num = (short)1087936292;
			short num2 = num;
			num = (short)1566611236;
			switch (num2 == num)
			{
			default:
			{
				num = (short)869400576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)724107264;
			if (num != 0)
			{
			}
			num = (short)941490177;
			if (num != 0)
			{
			}
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.d();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00029050 File Offset: 0x00027250
		public static void a(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0, global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer A_1)
		{
			short num = (short)656125697;
			short num2 = num;
			num = (short)1968811777;
			switch (num2 == num)
			{
			default:
			{
				num = (short)869072896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1817509889;
			if (num != 0)
			{
			}
			num = (short)2095513600;
			if (num != 0)
			{
			}
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.d(A_1);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00029104 File Offset: 0x00027304
		public static void a(this global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num = (short)1362566173;
			short num2 = num;
			num = (short)1396972573;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1335492608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1317076993;
			if (num != 0)
			{
			}
			num = (short)1998848000;
			if (num != 0)
			{
			}
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.a();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000291B8 File Offset: 0x000273B8
		public static void a(this global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
		{
			short num = (short)881121971;
			short num2 = num;
			num = (short)1858591411;
			switch (num2 == num)
			{
			default:
			{
				num = (short)877330432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)421527552;
			if (num != 0)
			{
			}
			num = (short)1585774593;
			if (num != 0)
			{
			}
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.b();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00029270 File Offset: 0x00027470
		public static void a(this global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0)
		{
			short num = (short)2056977900;
			short num2 = num;
			num = (short)1333067244;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1013579776;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)320733185;
			if (num != 0)
			{
			}
			num = (short)817037312;
			if (num != 0)
			{
			}
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.c();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00029324 File Offset: 0x00027524
		public static void a(this global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0)
		{
			short num = (short)320606023;
			short num2 = num;
			num = (short)1387925319;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1427177472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1022427137;
			if (num != 0)
			{
			}
			num = (short)1282801664;
			if (num != 0)
			{
			}
			A_0.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.e();
		}
	}
}
