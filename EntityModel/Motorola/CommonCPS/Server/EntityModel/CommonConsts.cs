using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200000F RID: 15
	public class CommonConsts
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00004D20 File Offset: 0x00002F20
		// Note: this type is marked as 'beforefieldinit'.
		static CommonConsts()
		{
			int a_ = 0;
			short num = (short)1029254864;
			short num2 = num;
			num = (short)1061498576;
			switch (num2 == num)
			{
			}
			num = (short)111149056;
			if (num != 0)
			{
			}
			num = (short)1807024128;
			short num3 = num;
			num = (short)427229185;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.CommonConsts.AllAppOptions = new string[]
			{
				global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("냽䇿崁倃吅䨇䔉伋帍䌏䴑娓䘕䬗䨙崛崝", a_),
				global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("냽䇿崁倃吅䨇䔉伋帍䌏䴑☓⌕北则䘛", a_)
			};
			global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName[] array = new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName[4];
			global::System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, fieldof(global::g.a).FieldHandle);
			global::Motorola.CommonCPS.Server.EntityModel.CommonConsts.AllPCRRegios = array;
		}

		// Token: 0x04000032 RID: 50
		public const global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily ProductFamilies_ASTRO = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP;

		// Token: 0x04000033 RID: 51
		public const global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily ProductFamilies_PBB = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB;

		// Token: 0x04000034 RID: 52
		public const global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily ProductFamilies_Converged = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Denali;

		// Token: 0x04000035 RID: 53
		public const global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily ProductFamilies_PCR = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Matrix | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Phoenix | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseLight | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC;

		// Token: 0x04000036 RID: 54
		public const string APP_OPTION_NPSPAC = "NA_TRBOCPS_NPSPAC";

		// Token: 0x04000037 RID: 55
		public const string APP_OPTION_25KHZ = "NA_TRBOCPS_25KHZ";

		// Token: 0x04000038 RID: 56
		public static string[] AllAppOptions;

		// Token: 0x04000039 RID: 57
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName[] AllPCRRegios;

		// Token: 0x0400003A RID: 58
		public const int MaxParameterCount = 1000;
	}
}
