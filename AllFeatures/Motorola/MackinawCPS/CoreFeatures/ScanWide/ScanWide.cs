using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanWide
{
	// Token: 0x02000109 RID: 265
	[global::System.Serializable]
	public class ScanWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060026CA RID: 9930 RVA: 0x0025D390 File Offset: 0x0025B590
		public ScanWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苐냒듔맖律賚드믞蓠", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SCANWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6ꫨ蓪胬鿮黰鷲郴駶跸ꟺ껼鳾怀洂┄䐆昈攊欌明瘐昒朔瘖洘爚爜焞素瀢䘤䘦䜨ପ稬䘮唰嘲椴搶娸娺匼栾⡀❂⁄楆ㅈ⩊⁌⍎", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ScanWide.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Conventional(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Trunking(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0025D420 File Offset: 0x0025B620
		protected ScanWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("髈꣊곌ꇎ蓒볔돖볘", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SCANWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲꛴银飸闺\uddfc볾渀洂挄渆済縊缌渎攐稒稔礖䔘䠚縜縞传̢爤並䴨个焬簮到刲嬴怶倸强堼ᄾ㥀≂⡄⭆", a_);
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x0025D474 File Offset: 0x0025B674
		public global::Motorola.MackinawCPS.CoreFeatures.ScanWide.General General
		{
			get
			{
				short num = (short)548841812;
				short num2 = num;
				num = (short)754362708;
				switch (num2 == num)
				{
				}
				num = (short)1744044033;
				if (num != 0)
				{
				}
				num = (short)1370619904;
				if (num != 0)
				{
				}
				num = (short)604438528;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanWide.General)base[10049];
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x0025D52C File Offset: 0x0025B72C
		public global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Conventional Conventional
		{
			get
			{
				short num = (short)1397310208;
				short num2 = num;
				num = (short)500777728;
				switch (num2 == num)
				{
				}
				num = (short)1445396481;
				if (num != 0)
				{
				}
				num = (short)1205796864;
				if (num != 0)
				{
				}
				num = (short)2094727168;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Conventional)base[10048];
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x0025D5E8 File Offset: 0x0025B7E8
		public global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Trunking Trunking
		{
			get
			{
				short num = (short)1012030621;
				short num2 = num;
				num = (short)364141725;
				switch (num2 == num)
				{
				}
				num = (short)1096548353;
				if (num != 0)
				{
				}
				num = (short)1745944576;
				if (num != 0)
				{
				}
				num = (short)784400384;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Trunking)base[10050];
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x0025D6A0 File Offset: 0x0025B8A0
		public global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Labtool Labtool
		{
			get
			{
				short num = (short)1387724006;
				short num2 = num;
				num = (short)1836711142;
				switch (num2 == num)
				{
				}
				num = (short)1219756033;
				if (num != 0)
				{
				}
				num = (short)103415808;
				if (num != 0)
				{
				}
				num = (short)1129906176;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanWide.Labtool)base[10047];
			}
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0025D75C File Offset: 0x0025B95C
		public static global::AcpCommonLib.IAcpFeatureNode GetScanWide()
		{
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			short num;
			int num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)1046609921;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_68;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2023)[0];
					num = (short)464781314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_102;
				case 2:
					goto IL_102;
				case 3:
				{
					num = (short)29229056;
					short num3 = num;
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2023)[0];
					num = (short)1847001089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_49;
				IL_68:
				num = (short)927006723;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_102:
				num = (short)141587897;
				short num4 = num;
				num = (short)1713665465;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_68;
				default:
					goto IL_136;
				}
			}
			IL_136:
			num = (short)1654587392;
			if (num != 0)
			{
			}
			return result;
			IL_49:
			result = null;
			num = (short)1797062656;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
