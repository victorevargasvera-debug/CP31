using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000450 RID: 1104
	[global::System.Serializable]
	public class FactoryOverrides : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060093BA RID: 37818 RVA: 0x008B43C0 File Offset: 0x008B25C0
		public FactoryOverrides(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胅꧇꧉룋ꇍꋏꯑ駕껗뿙껛곝觟蛡臣闥", a_);
			base.UIName = global::CommonResources.AcgResources.ID_FACTORYOVERRIDES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯등闳闵賷闹軻蟽⃿䴁爃挅稇砉攋樍甏愑䠓倕礗礙栛焝刟嬡欣倥䴧堩師䜭启圱䜳ᠵ䀷嬹儻刽", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIRateTXMode(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequency(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequency(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x008B4480 File Offset: 0x008B2680
		protected FactoryOverrides(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雏돑럓ꋕ럗꣙ꗛﻝ꿟铡臣铥髧菩裫语華", a_);
			base.UIName = global::CommonResources.AcgResources.ID_FACTORYOVERRIDES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹뫻鿽揿瘁欃琅焇⨉䌋砍甏怑易缕簗缙漛䈝星䌡䜣別䜧堩唫愭䘯圱䘳䐵儷帹夻䴽渿㩁╃⭅⑇", a_);
			this.a(info, context);
		}

		// Token: 0x17004A67 RID: 19047
		// (get) Token: 0x060093BC RID: 37820 RVA: 0x008B44DC File Offset: 0x008B26DC
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.General General
		{
			get
			{
				short num = (short)488243200;
				short num2 = num;
				num = (short)247762668;
				short num3 = num;
				num = (short)1747160812;
				switch (num3 == num)
				{
				}
				num = (short)917635073;
				if (num != 0)
				{
				}
				num = (short)661127168;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.General)base[10005];
			}
		}

		// Token: 0x17004A68 RID: 19048
		// (get) Token: 0x060093BD RID: 37821 RVA: 0x008B4594 File Offset: 0x008B2794
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerList RxSynthesizerReferenceDividerList
		{
			get
			{
				short num = (short)2042036224;
				short num2 = num;
				num = (short)2143681572;
				short num3 = num;
				num = (short)833616932;
				switch (num3 == num)
				{
				}
				num = (short)1548025856;
				if (num != 0)
				{
				}
				num = (short)196214785;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerList)base[10006];
			}
		}

		// Token: 0x17004A69 RID: 19049
		// (get) Token: 0x060093BE RID: 37822 RVA: 0x008B464C File Offset: 0x008B284C
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerList TxSynthesizerReferenceDividerList
		{
			get
			{
				short num = (short)1222115328;
				short num2 = num;
				num = (short)297951914;
				short num3 = num;
				num = (short)1842176682;
				switch (num3 == num)
				{
				}
				num = (short)2128150529;
				if (num != 0)
				{
				}
				num = (short)1009123328;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerList)base[10008];
			}
		}

		// Token: 0x17004A6A RID: 19050
		// (get) Token: 0x060093BF RID: 37823 RVA: 0x008B4708 File Offset: 0x008B2908
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateList TxSSIClockRateList
		{
			get
			{
				short num = (short)2064777216;
				short num2 = num;
				num = (short)1283649012;
				short num3 = num;
				num = (short)1963257332;
				switch (num3 == num)
				{
				}
				num = (short)579600385;
				if (num != 0)
				{
				}
				num = (short)2115239936;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateList)base[10612];
			}
		}

		// Token: 0x17004A6B RID: 19051
		// (get) Token: 0x060093C0 RID: 37824 RVA: 0x008B47C0 File Offset: 0x008B29C0
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateList RxSSIClockRateList
		{
			get
			{
				short num = (short)1119289344;
				short num2 = num;
				num = (short)592709611;
				short num3 = num;
				num = (short)1847789547;
				switch (num3 == num)
				{
				}
				num = (short)815529985;
				if (num != 0)
				{
				}
				num = (short)1318912000;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateList)base[10791];
			}
		}

		// Token: 0x17004A6C RID: 19052
		// (get) Token: 0x060093C1 RID: 37825 RVA: 0x008B4878 File Offset: 0x008B2A78
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIRateTXMode RxSSIRateTXMode
		{
			get
			{
				short num = (short)656474112;
				short num2 = num;
				num = (short)707220266;
				short num3 = num;
				num = (short)2053919530;
				switch (num3 == num)
				{
				}
				num = (short)1725956097;
				if (num != 0)
				{
				}
				num = (short)2104164352;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIRateTXMode)base[10801];
			}
		}

		// Token: 0x17004A6D RID: 19053
		// (get) Token: 0x060093C2 RID: 37826 RVA: 0x008B4930 File Offset: 0x008B2B30
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequency SecondLOInjectionFrequency
		{
			get
			{
				short num = (short)1524105216;
				short num2 = num;
				num = (short)924385281;
				if (num != 0)
				{
				}
				num = (short)1047804298;
				short num3 = num;
				num = (short)870070666;
				switch (num3 == num)
				{
				}
				num = (short)1358561280;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequency)base[10010];
			}
		}

		// Token: 0x17004A6E RID: 19054
		// (get) Token: 0x060093C3 RID: 37827 RVA: 0x008B49EC File Offset: 0x008B2BEC
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequency RxFrequency
		{
			get
			{
				short num = (short)1740308480;
				short num2 = num;
				num = (short)10698226;
				short num3 = num;
				num = (short)1400520178;
				switch (num3 == num)
				{
				}
				num = (short)1574633473;
				if (num != 0)
				{
				}
				num = (short)591134720;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequency)base[10905];
			}
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x008B4AA4 File Offset: 0x008B2CA4
		public static global::AcpCommonLib.IAcpFeatureNode GetFactoryOverrides()
		{
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_00:
				short num = (short)2097938432;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				int num3;
				for (;;)
				{
					IL_34:
					switch (num3)
					{
					case 0:
					{
						num = (short)882180097;
						if (num != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)973078531;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2003)[0];
						num = (short)526784227;
						short num4 = num;
						num = (short)688264931;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1349779456;
							if (num != 0)
							{
							}
							num = (short)1833304065;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2003)[0];
						num = (short)240058370;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_4A:
				result = null;
				num = (short)1181810688;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			return result;
		}

		// Token: 0x060093C5 RID: 37829 RVA: 0x008B4C00 File Offset: 0x008B2E00
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)559939584;
			short num2 = num;
			num = (short)1150287484;
			short num3 = num;
			num = (short)1562246780;
			switch (num3 == num)
			{
			}
			num = (short)1813905408;
			if (num != 0)
			{
			}
			num = (short)2123038721;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x008B4CB0 File Offset: 0x008B2EB0
		private void a()
		{
			short num;
			for (;;)
			{
				num = (short)1661861888;
				short num2 = num;
				num = (short)236519424;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 1:
						if (this.TxSSIClockRateList == null)
						{
							num = (short)1668218883;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_D1;
					case 3:
						base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateList(this));
						num = (short)368771073;
						if (num != 0)
						{
						}
						num = (short)369623042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1357250561;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					if (global::AcpCommonLib.AppInfoManager.DndOperation)
					{
						return;
					}
					num = (short)89325572;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_D1:
				num = (short)1021962087;
				short num4 = num;
				num = (short)1028843367;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_105;
				}
			}
			IL_105:
			num = (short)707985408;
			if (num != 0)
			{
			}
		}
	}
}
