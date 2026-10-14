using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x0200050D RID: 1293
	[global::System.Serializable]
	public class DataProfiles : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600AB42 RID: 43842 RVA: 0x009FA844 File Offset: 0x009F8A44
		public DataProfiles(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铏돑ꃓ럕諙껛뇝蛟诡裣菥鯧", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATAPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹룻鿽瓿持␃䔅朇搉樋服眏朑易眕気猙猛瀝簟昡䔣別䤧਩簫尭弯吱崳娵崷䤹总稽ℿ㙁╃ᙅ㩇╉⩋❍㱏㝑❓硕⁗㭙ㅛ㉝", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DAC(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupID(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EnhancedData(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LabtoolDATA_PROF(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x009FA910 File Offset: 0x009F8B10
		protected DataProfiles(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑蛕꫗뗙뫛럝賟蟡韣", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATAPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("跋ꋍ볏铑뇓럕곗꿙껛믝鏟\ud9e1꟣觥藧髩菫胭闯鳱胳ꫵ볷鯹裻鿽⃿䄁欃栅渇按欋笍戏猑怓缕眗琙䀛娝䄟嘡䔣إ砧堩䌫䠭夯帱儳䔵搷縹崻䨽ℿቁ㙃⥅⹇⍉⁋⭍⍏籑ⱓ㝕㕗㙙", a_);
			this.a(info, context);
		}

		// Token: 0x170055B5 RID: 21941
		// (get) Token: 0x0600AB44 RID: 43844 RVA: 0x009FA96C File Offset: 0x009F8B6C
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General General
		{
			get
			{
				short num = (short)12984167;
				short num2 = num;
				num = (short)1571626855;
				switch (num2 == num)
				{
				}
				num = (short)199950337;
				if (num != 0)
				{
				}
				num = (short)783089664;
				if (num != 0)
				{
				}
				num = (short)563544064;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General)base[10121];
			}
		}

		// Token: 0x170055B6 RID: 21942
		// (get) Token: 0x0600AB45 RID: 43845 RVA: 0x009FAA28 File Offset: 0x009F8C28
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features Features
		{
			get
			{
				short num = (short)1182543774;
				short num2 = num;
				num = (short)1666264990;
				switch (num2 == num)
				{
				}
				num = (short)1380122625;
				if (num != 0)
				{
				}
				num = (short)1319698432;
				if (num != 0)
				{
				}
				num = (short)1321598976;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features)base[10122];
			}
		}

		// Token: 0x170055B7 RID: 21943
		// (get) Token: 0x0600AB46 RID: 43846 RVA: 0x009FAAE0 File Offset: 0x009F8CE0
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DAC DAC
		{
			get
			{
				short num = (short)393966909;
				short num2 = num;
				num = (short)1166832957;
				switch (num2 == num)
				{
				}
				num = (short)1637875712;
				if (num != 0)
				{
				}
				num = (short)178323457;
				if (num != 0)
				{
				}
				num = (short)315752448;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DAC)base[10504];
			}
		}

		// Token: 0x170055B8 RID: 21944
		// (get) Token: 0x0600AB47 RID: 43847 RVA: 0x009FAB98 File Offset: 0x009F8D98
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupID TrunkingGroupID
		{
			get
			{
				short num = (short)2114982319;
				short num2 = num;
				num = (short)95424943;
				switch (num2 == num)
				{
				}
				num = (short)395182080;
				if (num != 0)
				{
				}
				num = (short)1439629313;
				if (num != 0)
				{
				}
				num = (short)2021720064;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupID)base[10505];
			}
		}

		// Token: 0x170055B9 RID: 21945
		// (get) Token: 0x0600AB48 RID: 43848 RVA: 0x009FAC50 File Offset: 0x009F8E50
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE LTE
		{
			get
			{
				short num = (short)674122125;
				short num2 = num;
				num = (short)1397901709;
				switch (num2 == num)
				{
				}
				num = (short)1705115649;
				if (num != 0)
				{
				}
				num = (short)473169920;
				if (num != 0)
				{
				}
				num = (short)395182080;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE)base[10773];
			}
		}

		// Token: 0x170055BA RID: 21946
		// (get) Token: 0x0600AB49 RID: 43849 RVA: 0x009FAD08 File Offset: 0x009F8F08
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity NetworkLayerSecurity
		{
			get
			{
				short num = (short)1690927123;
				short num2 = num;
				num = (short)722305043;
				switch (num2 == num)
				{
				}
				num = (short)90570753;
				if (num != 0)
				{
				}
				num = (short)119734272;
				if (num != 0)
				{
				}
				num = (short)1134166016;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity)base[10600];
			}
		}

		// Token: 0x170055BB RID: 21947
		// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x009FADC0 File Offset: 0x009F8FC0
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassList EIDBypassList
		{
			get
			{
				short num = (short)1295168205;
				short num2 = num;
				num = (short)1425453773;
				switch (num2 == num)
				{
				}
				num = (short)465960961;
				if (num != 0)
				{
				}
				num = (short)1722023936;
				if (num != 0)
				{
				}
				num = (short)1302855680;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassList)base[10601];
			}
		}

		// Token: 0x170055BC RID: 21948
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x009FAE78 File Offset: 0x009F9078
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EnhancedData EnhancedData
		{
			get
			{
				short num = (short)914882561;
				if (num != 0)
				{
				}
				num = (short)96277189;
				short num2 = num;
				num = (short)3412677;
				switch (num2 == num)
				{
				}
				num = (short)1394933760;
				if (num != 0)
				{
				}
				num = (short)773062656;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EnhancedData)base[10770];
			}
		}

		// Token: 0x170055BD RID: 21949
		// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x009FAF30 File Offset: 0x009F9130
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LabtoolDATA_PROF LabtoolDATA_PROF
		{
			get
			{
				short num = (short)587767465;
				short num2 = num;
				num = (short)1983618729;
				switch (num2 == num)
				{
				}
				num = (short)126222337;
				if (num != 0)
				{
				}
				num = (short)646709248;
				if (num != 0)
				{
				}
				num = (short)1679949824;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LabtoolDATA_PROF)base[10123];
			}
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x009FAFE8 File Offset: 0x009F91E8
		public static global::AcpCommonLib.IAcpFeatureNode GetDataProfiles()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return result;
				case 1:
					return result;
				case 2:
					goto IL_F5;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)983957506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2054)[0];
					num2 = (short)1261305857;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			num2 = (short)1978990592;
			short num3 = num2;
			num2 = (short)634489496;
			short num4 = num2;
			num2 = (short)949389976;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F5:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2054)[0];
				num2 = (short)1294073856;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1590427649;
				if (num2 != 0)
				{
				}
				num2 = (short)1110245376;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)1657798659;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x009FB148 File Offset: 0x009F9348
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)50928573;
			short num2 = num;
			num = (short)1873091517;
			switch (num2 == num)
			{
			}
			num = (short)1882193921;
			if (num != 0)
			{
			}
			num = (short)287506432;
			if (num != 0)
			{
			}
			num = (short)1630404608;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600AB4F RID: 43855 RVA: 0x009FB1F8 File Offset: 0x009F93F8
		private void a()
		{
			short num = (short)2073493511;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)1746796547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity(this));
					num = (short)849477637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (this.NetworkLayerSecurity != null)
					{
						goto IL_8B;
					}
					num = (short)246965095;
					short num3 = num;
					num = (short)414802791;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)42926080;
						if (num != 0)
						{
						}
						num = (short)1965686786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
				{
					num = (short)1539375104;
					short num4 = num;
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassList(this));
					num = (short)116850688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_8B;
				case 6:
					if (this.EIDBypassList == null)
					{
						num = (short)591986692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				}
				IL_44:
				num = (short)867762177;
				if (num != 0)
				{
				}
				if (!global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					num = (short)1640431617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_8B:
				num = (short)150339590;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
