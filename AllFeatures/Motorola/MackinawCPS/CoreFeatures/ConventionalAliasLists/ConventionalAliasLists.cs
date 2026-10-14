using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D2 RID: 1490
	[global::System.Serializable]
	public class ConventionalAliasLists : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600CE68 RID: 52840 RVA: 0x00C01CA4 File Offset: 0x00BFFEA4
		public ConventionalAliasLists(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 11;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("迋ꇍ뻏ꓑ뇓룕곗동돛냝臟軡쓣꟥蓧菩跫鷭탯뻱鷳藵賷觹", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALALIASLISTS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("跋ꋍ볏铑뇓럕곗꿙껛믝鏟\ud9e1꟣觥藧髩菫胭闯鳱胳ꫵ믷闹鋻製旿氁瀃漅朇搉洋戍』儑笓砕縗猙笛欝刟䌡倣伥䜧䐩瀫洭弯就䈳匵嘷丹唻儽⸿⍁⡃晅े♉╋⽍⍏牑ᡓ㽕⭗⹙⽛ɝ⍟ൡ੣ၥ൧ѩᡫݭὯᱱᕳ᩵㥷ᙹᕻώ캁ﲇ黎ꊋﾑ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600CE69 RID: 52841 RVA: 0x00C01D28 File Offset: 0x00BFFF28
		protected ConventionalAliasLists(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臁ꯃꣅ뻇꿉ꋋ뫍맏뷑뫓럕듗龎鷛닝觟菡韣웥ꓧ菩鿫髭華", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALALIASLISTS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫귭鿯鳱苳鏵雷軹闻釽滿持栃★䬇攉戋栍礏甑愓搕礗渙甛焝丟縡朣䤥䘧尩䤫䀭䐯嬱嬳堵夷嘹᰻缽ⰿ⭁╃㕅桇ى╋㵍⑏⅑ࡓᕕ㝗㑙⩛㭝๟ᙡൣ॥٧୩k⽭ᱯ᭱ᕳյ㑷፹ཻ੽겁ﲃ", a_);
		}

		// Token: 0x170067D7 RID: 26583
		// (get) Token: 0x0600CE6A RID: 52842 RVA: 0x00C01D7C File Offset: 0x00BFFF7C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasList MessageAliasList
		{
			get
			{
				short num = (short)1936130048;
				short num2 = num;
				num = (short)2014434171;
				short num3 = num;
				num = (short)1058788219;
				switch (num3 == num)
				{
				}
				num = (short)766181377;
				if (num != 0)
				{
				}
				num = (short)1174274048;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasList)base[10012];
			}
		}

		// Token: 0x170067D8 RID: 26584
		// (get) Token: 0x0600CE6B RID: 52843 RVA: 0x00C01E34 File Offset: 0x00C00034
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasList StatusAliasList
		{
			get
			{
				short num = (short)908066816;
				short num2 = num;
				num = (short)1268713647;
				short num3 = num;
				num = (short)902367407;
				switch (num3 == num)
				{
				}
				num = (short)1056505857;
				if (num != 0)
				{
				}
				num = (short)959250432;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasList)base[10014];
			}
		}

		// Token: 0x170067D9 RID: 26585
		// (get) Token: 0x0600CE6C RID: 52844 RVA: 0x00C01EEC File Offset: 0x00C000EC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.Labtool Labtool
		{
			get
			{
				short num = (short)554696704;
				short num2 = num;
				num = (short)1276444673;
				if (num != 0)
				{
				}
				num = (short)1456563848;
				short num3 = num;
				num = (short)1329751688;
				switch (num3 == num)
				{
				}
				num = (short)601686016;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.Labtool)base[10016];
			}
		}

		// Token: 0x0600CE6D RID: 52845 RVA: 0x00C01FA4 File Offset: 0x00C001A4
		public static global::AcpCommonLib.IAcpFeatureNode GetConventionalAliasLists()
		{
			short num = (short)50855937;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_BF;
			}
			int num4;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_32:
				num = (short)463893927;
				short num2 = num;
				num = (short)636646823;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1486290944;
					short num3 = num;
					num = (short)1133314048;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_126;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)971440128;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2007)[0];
						num = (short)1147207682;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						return result;
					}
					goto IL_BF;
				}
				}
				IL_126:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2007)[0];
				num = (short)1146421251;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_BF:
			result = null;
			num = (short)262799361;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}
	}
}
