using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001B6 RID: 438
	[global::System.Serializable]
	public class VirtualPartnerAlert : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06005184 RID: 20868 RVA: 0x004A1974 File Offset: 0x0049FB74
		public VirtualPartnerAlert(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 6;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("釆ꃈ髊꓌藒볔ꗖ귘껚볜돞쇠돢蓤闦鷨藪裬鷮퇰닲駴鋶诸迺", a_);
			base.UIName = global::CommonResources.AcgResources.ID_VIRTUALPARTNERALERT;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚鳞軠転闤裦蟨軪菬鯮귰ꇲ铴鏶郸铺\uddfc뫾猀搂樄椆昈昊搌氎成㌒嘔砖眘級琜砞吠儢䐤匦䀨䐪䌬献朰娲䜴䌶䰸娺儼Ἶᅀ≂㝄㍆❈⹊㽌潎ၐ㽒ご╖ⵘݚଡ଼㙞፠ᝢၤ٦ը㭪౬ᵮհᵲၴն㡸᝺᡼ൾ궂ﶄ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x004A19E0 File Offset: 0x0049FBE0
		protected VirtualPartnerAlert(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黇ꏉ鷋ꟍ苓뿕꫗껙꧛뿝賟싡듣蟥髧黩苫语苯틱뗳髵鷷裹裻", a_);
			base.UIName = global::CommonResources.AcgResources.ID_VIRTUALPARTNERALERT;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱꛳韵鳷鏹鏻\udefd䗿瀁挃椅昇攉愋服猏愑㐓唕眗琙稛眝䜟圡嘣䜥尧䌩䌫䀭氯搱崳䐵䰷伹崻刽怿ቁ╃㑅㱇⑉⥋㱍灏ፑ㡓㍕⩗⹙[࡝य़ၡၣ፥१٩㱫཭ɯٱᩳ፵੷㭹ၻ᭽ꪃﺅ", a_);
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x004A1A34 File Offset: 0x0049FC34
		public global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.General General
		{
			get
			{
				short num = (short)8033871;
				short num2 = num;
				num = (short)1794872911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1269694464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1285357568;
				if (num != 0)
				{
				}
				num = (short)435224577;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.General)base[10891];
			}
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x004A1AF0 File Offset: 0x0049FCF0
		public static global::AcpCommonLib.IAcpFeatureNode GetVirtualPartnerAlert()
		{
			short num;
			int num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1510932481;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4231)[0];
						num = (short)1013710848;
						short num3 = num;
						num = (short)1224393038;
						short num4 = num;
						num = (short)833012046;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_48;
						default:
							num = (short)1988165632;
							if (num != 0)
							{
							}
							num = (short)1143537667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)161546240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(4231)[0];
						num = (short)1932591106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						return result;
					}
					goto IL_46;
				}
				return result;
			}
			IL_46:
			result = null;
			IL_48:
			num = (short)1051656193;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
