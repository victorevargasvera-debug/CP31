using System;
using System.IO;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommonUtility
{
	// Token: 0x0200000E RID: 14
	public static class GlobalConstansts
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00006548 File Offset: 0x00004748
		public static string DeviceComunicationLogsFolderName
		{
			get
			{
				short num = (short)1339043020;
				short num2 = num;
				num = (short)407252172;
				switch (num2 == num)
				{
				}
				num = (short)553844736;
				short num3 = num;
				num = (short)1062141953;
				if (num != 0)
				{
				}
				num = (short)178257920;
				if (num != 0)
				{
				}
				return string.Format(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.a, global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.a());
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000673C File Offset: 0x0000493C
		public static string LogFilePath
		{
			get
			{
				short num = (short)8323073;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)893255680;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_80;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 2:
					{
						num = (short)482087869;
						short num4 = num;
						num = (short)1844057021;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_80;
						default:
							goto IL_EA;
						}
						break;
					}
					}
					IL_5B:
					if (string.IsNullOrEmpty(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.b))
					{
						num = (short)958791680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_127;
					IL_80:
					global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.b = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + "\\Motorola\\CommonCPS\\" + global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.DeviceComunicationLogsFolderName;
					num = (short)67305474;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EA:
				num = (short)458752;
				if (num != 0)
				{
				}
				num = (short)13238273;
				if (num != 0)
				{
				}
				IL_127:
				return global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.b;
			}
			set
			{
				short num = (short)245432191;
				short num2 = num;
				num = (short)1795227519;
				switch (num2 == num)
				{
				}
				num = (short)181862400;
				short num3 = num;
				num = (short)319553536;
				if (num != 0)
				{
				}
				num = (short)1283325953;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.b = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000067F0 File Offset: 0x000049F0
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000068A0 File Offset: 0x00004AA0
		public static global::Motorola.Common.Communication.CommonUtil.ProductFamily ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1564808484;
				short num2 = num;
				num = (short)257365284;
				switch (num2 == num)
				{
				}
				num = (short)1549205504;
				short num3 = num;
				num = (short)1394081793;
				if (num != 0)
				{
				}
				num = (short)71827456;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1780394840;
				short num2 = num;
				num = (short)1943710552;
				switch (num2 == num)
				{
				}
				num = (short)1842216960;
				short num3 = num;
				num = (short)1801781249;
				if (num != 0)
				{
				}
				num = (short)1272512512;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.c = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006950 File Offset: 0x00004B50
		public static string StorageFolder
		{
			get
			{
				short num = (short)230222779;
				short num2 = num;
				num = (short)1890184123;
				switch (num2 == num)
				{
				}
				num = (short)948502528;
				short num3 = num;
				num = (short)1534853121;
				if (num != 0)
				{
				}
				num = (short)2043609088;
				if (num != 0)
				{
				}
				return global::System.IO.Path.Combine(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.LogFilePath, "Storage");
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006A08 File Offset: 0x00004C08
		private static string a()
		{
			short num = (short)1359675398;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B6;
				case 1:
				{
					global::Motorola.Common.Communication.CommonUtil.ProductFamily productFamily;
					if (productFamily != global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio)
					{
						num = (short)58458114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.d = "LEX-Si ";
					num = (short)2107965448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)705560583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					global::Motorola.Common.Communication.CommonUtil.ProductFamily productFamily;
					if (productFamily != global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio)
					{
						num = (short)28246021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.d = "APX ";
					num = (short)694222848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)334495745;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.ProductFamily productFamily = global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.ProductFamily;
					num = (short)1683179229;
					short num3 = num;
					num = (short)1194608349;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E6;
					case 1:
						break;
					default:
					{
						num = (short)865206272;
						short num4 = num;
						break;
					}
					}
					num = (short)127008768;
					if (num != 0)
					{
					}
					num = (short)1043005443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)330432513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 7:
					goto IL_D2;
				case 8:
					goto IL_1A9;
				}
				IL_49:
				if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.d))
				{
					break;
				}
				num = (short)1147076612;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B6:
			IL_D2:
			IL_1A9:
			IL_1E6:
			return global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.d;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006C00 File Offset: 0x00004E00
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalConstansts()
		{
			short num = (short)27425375;
			short num2 = num;
			num = (short)288389727;
			switch (num2 == num)
			{
			}
			num = (short)252444672;
			short num3 = num;
			num = (short)138412033;
			if (num != 0)
			{
			}
			num = (short)990773248;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.a = "Motorola {0}Device Communication";
			global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.d = string.Empty;
		}

		// Token: 0x04000033 RID: 51
		public const string ASTRO_VirtualRadio_PID = "99999";

		// Token: 0x04000034 RID: 52
		public const string PCR_VirtualRadio_PID = "99998";

		// Token: 0x04000035 RID: 53
		public const string Tetra_VirtualRadio_PID = "99997";

		// Token: 0x04000036 RID: 54
		public const string PBB_VirtualRadio_PID = "_PBB_VirtualDevice";

		// Token: 0x04000037 RID: 55
		private static string a;

		// Token: 0x04000038 RID: 56
		private static string b;

		// Token: 0x04000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::Motorola.Common.Communication.CommonUtil.ProductFamily c;

		// Token: 0x0400003A RID: 58
		private static string d;
	}
}
