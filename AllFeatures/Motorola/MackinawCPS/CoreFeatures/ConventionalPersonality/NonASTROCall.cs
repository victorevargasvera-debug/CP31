using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C4 RID: 1476
	[global::System.Serializable]
	public class NonASTROCall : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C7E3 RID: 51171 RVA: 0x00BAED28 File Offset: 0x00BACF28
		public NonASTROCall(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C7E4 RID: 51172 RVA: 0x00BAED44 File Offset: 0x00BACF44
		protected NonASTROCall(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C7E5 RID: 51173 RVA: 0x00BAED5C File Offset: 0x00BACF5C
		public override void Init()
		{
			int a_ = 16;
			short num = (short)1753636532;
			short num2 = num;
			num = (short)1688166068;
			switch (num2 == num)
			{
			}
			num = (short)205193217;
			if (num != 0)
			{
			}
			num = (short)389873664;
			if (num != 0)
			{
			}
			num = (short)1528102912;
			short num3 = num;
			this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ蟖볘꧚鏜냞迠ꋢ뛤돦믨ꓪ껬軮鷰鿲듴苶跸铺껼髾洀昂昄猆䨈樊愌挎䔐愒琔礖樘瘚琜欞縠戢ሤሦᬨᬪ", a_), global::CommonResources.AcgResources.ID_MDCAUTOSELECTCALLTRANSMIT);
			this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.DataTransferOrder = 84;
			this.cnvPerNonASTROCallCallAlertRxTx_A7588 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ蟖볘꧚鏜냞迠ꋢ뛤돦믨ꓪ껬軮鷰鿲뛴零闸韺볼鏾搀焂焄唆焈弊甌倎倐␒—⼖℘", a_), global::CommonResources.AcgResources.ID_CALLALERTCALLALERTRXTX, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerNonASTROCallCallAlertRxTx_A7588LovStrs);
			this.cnvPerNonASTROCallCallAlertRxTx_A7588.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerNonASTROCallCallAlertRxTx_A7588.DataTransferOrder = 31;
			this.cnvPerNonASTROCallInCallUserAlertEnable_A8252 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ蟖볘꧚鏜냞迠ꋢ뛤돦믨ꓪ껬軮鷰鿲보駶뫸髺釼鏾吀瀂怄甆䠈朊栌紎攐嘒笔瘖笘眚砜䀞怠ᬢᜤሦᬨ", a_), global::CommonResources.AcgResources.ID_CALLALERTINCALLUSERALERTENABLE);
			this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.DataTransferOrder = 94;
			this.cnvPerNonASTROCallRTTButtonAccess_A8493 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ蟖볘꧚鏜냞迠ꋢ뛤돦믨ꓪ껬軮鷰鿲ꟴꏶ그맺裼课甀氂欄䘆樈栊栌簎成䰒吔⼖ⴘ√⸜", a_), global::CommonResources.AcgResources.ID_MDCRTTBUTTONACCESS, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerNonASTROCallRTTButtonAccess_A8493LovStrs);
			this.cnvPerNonASTROCallRTTButtonAccess_A8493.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerNonASTROCallRTTButtonAccess_A8493.DataTransferOrder = 116;
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ蟖볘꧚鏜냞迠ꋢ뛤돦믨ꓪ껬軮鷰鿲꛴鋶闸黺黼课栀甂怄䐆栈朊愌崎椐䜒洔䠖堘√Ⱌ⸞ᜠ", a_), global::CommonResources.AcgResources.ID_SELECTIVECALLSELECTIVECALLRXTX, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerNonASTROCallSelectiveCallRxTx_A9116LovStrs);
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.DataTransferOrder = 32;
			this.cnvPerNonASTROCallUnlimitedCalling_A9597 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ蟖볘꧚鏜냞迠ꋢ뛤돦믨ꓪ껬軮鷰鿲ꃴ駶闸鋺郼雾甀昂愄䐆栈朊愌明缐琒䨔嘖‘⸚␜⠞", a_), global::CommonResources.AcgResources.ID_MDCUNLIMITEDCALLING);
			this.cnvPerNonASTROCallUnlimitedCalling_A9597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerNonASTROCallUnlimitedCalling_A9597.DataTransferOrder = 106;
			this.cnvPerNonASTROCallUnmuteType_A9601 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ蟖볘꧚鏜냞迠ꋢ뛤돦믨ꓪ껬軮鷰鿲ꃴ駶铸軺觼髾唀稂甄戆嘈䨊㐌㤎ℐ−", a_), global::CommonResources.AcgResources.ID_SELECTIVECALLUNMUTETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerNonASTROCallUnmuteType_A9601LovStrs);
			this.cnvPerNonASTROCallUnmuteType_A9601.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerNonASTROCallUnmuteType_A9601.DataTransferOrder = 98;
			this.cnvPerLabtoolAnalogHotListItemID_A21918 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ蟖볘꧚釜뻞菠韢諤裦藨ꫪ菬軮鷰鳲鋴뿶雸迺뇼雾爀眂䰄猆氈昊䐌䬎丐划✔☖‘⨚├", a_), global::CommonResources.AcgResources.ID_NONASTROCALLHOTLIST, null, null, true, false);
			this.cnvPerLabtoolAnalogHotListItemID_A21918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerLabtoolAnalogHotListItemID_A21918.DataTransferOrder = 130;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿐볒믔𥳐飘裚觜跞껠쏢ꛤ蛦藨蟪", a_);
			base.Id = 10143;
			base.UIName = global::CommonResources.AcgResources.ID_NONASTROCALL;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600C7E6 RID: 51174 RVA: 0x00BAF024 File Offset: 0x00BAD224
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)2087125013;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)997392409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤ꛦ鳨鿪苬볮铰鿲郴银跸룺鳼鏾洀圂眄昆月砊怌明攐䰒吔‖Ⱈ⤚ⴜ", a_), global::CommonResources.AcgResources.ID_MDCAUTOSELECTCALLTRANSMIT);
					this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.DataTransferOrder = 84;
					num = (short)1421410315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_487;
				case 3:
					goto IL_354;
				case 4:
					this.cnvPerNonASTROCallUnmuteType_A9601 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤닦蟨蛪飬鯮铰ꟲ賴蟶鳸ꓺ볼웾㜀㌂㐄", a_), global::CommonResources.AcgResources.ID_SELECTIVECALLUNMUTETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerNonASTROCallUnmuteType_A9601LovStrs);
					this.cnvPerNonASTROCallUnmuteType_A9601.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerNonASTROCallUnmuteType_A9601.DataTransferOrder = 98;
					num = (short)1583939590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤ꛦ鳨鿪苬볮铰鿲郴银跸룺鳼鏾洀圂眄昆月砊怌明攐䰒吔‖Ⱈ⤚ⴜ", a_)))
					{
						num = (short)913899521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15B;
				case 6:
					goto IL_2EF;
				case 7:
					this.cnvPerNonASTROCallCallAlertRxTx_A7588 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤ꓦ裨蟪臬껮鷰雲蟴菶꯸菺ꧼ蟾帀䈂㈄㈆ㄈ㌊", a_), global::CommonResources.AcgResources.ID_CALLALERTCALLALERTRXTX, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerNonASTROCallCallAlertRxTx_A7588LovStrs);
					this.cnvPerNonASTROCallCallAlertRxTx_A7588.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerNonASTROCallCallAlertRxTx_A7588.DataTransferOrder = 31;
					num = (short)961282068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.cnvPerNonASTROCallUnlimitedCalling_A9597 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤닦蟨蟪蓬苮飰蟲郴鏶뫸髺釼鏾栀洂戄堆䠈㈊㠌㘎☐", a_), global::CommonResources.AcgResources.ID_MDCUNLIMITEDCALLING);
					this.cnvPerNonASTROCallUnlimitedCalling_A9597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerNonASTROCallUnlimitedCalling_A9597.DataTransferOrder = 106;
					num = (short)1361379338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌菎냐뇒ꇔ룖뛘럚鳜뇞胠迢諤胦ꇨ蓪駬ꏮ飰胲致뻶跸黺郼뛾䔀専䐄㔆㠈㈊㰌㜎", a_)))
					{
						num = (short)1561460752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C5;
				case 10:
					goto IL_3E4;
				case 11:
					goto IL_15B;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤닦蟨蛪飬鯮铰ꟲ賴蟶鳸ꓺ볼웾㜀㌂㐄", a_)))
					{
						num = (short)541196292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2EF;
				case 13:
					goto IL_111;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤닦蟨蟪蓬苮飰蟲郴鏶뫸髺釼鏾栀洂戄堆䠈㈊㠌㘎☐", a_)))
					{
						num = (short)337182728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E4;
				case 15:
					this.cnvPerNonASTROCallRTTButtonAccess_A8493 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤뗦뷨뿪꿬髮藰蟲髴駶룸飺黼髾爀瀂娄䘆ㄈ㼊㐌㰎", a_), global::CommonResources.AcgResources.ID_MDCRTTBUTTONACCESS, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerNonASTROCallRTTButtonAccess_A8493LovStrs);
					this.cnvPerNonASTROCallRTTButtonAccess_A8493.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerNonASTROCallRTTButtonAccess_A8493.DataTransferOrder = 116;
					num = (short)1592918029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.cnvPerLabtoolAnalogHotListItemID_A21918 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌菎냐뇒ꇔ룖뛘럚鳜뇞胠迢諤胦ꇨ蓪駬ꏮ飰胲致뻶跸黺郼뛾䔀専䐄㔆㠈㈊㰌㜎", a_), global::CommonResources.AcgResources.ID_NONASTROCALLHOTLIST, null, null, true, false);
					this.cnvPerLabtoolAnalogHotListItemID_A21918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerLabtoolAnalogHotListItemID_A21918.DataTransferOrder = 130;
					num = (short)2068185090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_33C;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤듦賨蟪裬賮藰髲菴鋶뫸髺釼鏾匀笂億缆嘈䨊㐌㸎‐┒", a_)))
					{
						num = (short)1460797466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				case 19:
				{
					num = (short)894416866;
					short num3 = num;
					num = (short)1689565154;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_354;
					default:
						num = (short)1740505088;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤ꓦ裨蟪臬껮鷰雲蟴菶꯸菺ꧼ蟾帀䈂㈄㈆ㄈ㌊", a_)))
						{
							num = (short)1894973447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48C;
					}
					break;
				}
				case 20:
					goto IL_48C;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 22:
					num = (short)1892155393;
					if (num != 0)
					{
					}
					goto IL_C3;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤껦蟨꣪賬菮鷰꛲蛴鋶诸뫺釼髾猀眂䀄椆栈椊愌樎丐划ⴔ┖Ⱈ⤚", a_)))
					{
						num = (short)1523843099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_33C;
				case 24:
				{
					num = (short)396296192;
					short num4 = num;
					num = (short)1586102277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 25:
					if (producerFields != null)
					{
						num = (short)916520984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C5;
				case 26:
					this.cnvPerNonASTROCallSelectiveCallRxTx_A9116 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤듦賨蟪裬賮藰髲菴鋶뫸髺釼鏾匀笂億缆嘈䨊㐌㸎‐┒", a_), global::CommonResources.AcgResources.ID_SELECTIVECALLSELECTIVECALLRXTX, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerNonASTROCallSelectiveCallRxTx_A9116LovStrs);
					this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.DataTransferOrder = 32;
					num = (short)271581206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.cnvPerNonASTROCallInCallUserAlertEnable_A8252 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤껦蟨꣪賬菮鷰꛲蛴鋶诸뫺釼髾猀眂䀄椆栈椊愌樎丐划ⴔ┖Ⱈ⤚", a_), global::CommonResources.AcgResources.ID_CALLALERTINCALLUSERALERTENABLE);
					this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.DataTransferOrder = 94;
					num = (short)2121334801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)765460480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C3:
				num = (short)1786576910;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_111:
				num = (short)1555759122;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_354:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌臎뻐뷒铔蓖跘觚鋜鳞胠迢觤뗦뷨뿪꿬髮藰蟲髴駶룸飺黼髾爀瀂娄䘆ㄈ㼊㐌㰎", a_)))
				{
					num = (short)1561985039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_111;
				IL_15B:
				num = (short)1141178387;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2EF:
				num = (short)742719497;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_33C:
				num = (short)159842307;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E4:
				num = (short)1264058380;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48C:
				num = (short)1242693655;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_487:
			IL_6C5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跂꫄꧆諊黌鯎菐鳒铖룘럚뇜", a_);
			base.Id = 10143;
			base.UIName = global::CommonResources.AcgResources.ID_NONASTROCALL;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600C7E7 RID: 51175 RVA: 0x00BAF728 File Offset: 0x00BAD928
		public override void PopulateReferences()
		{
			short num = (short)1114592211;
			short num2 = num;
			num = (short)1916621779;
			switch (num2 == num)
			{
			}
			num = (short)666959873;
			if (num != 0)
			{
			}
			num = (short)516030464;
			if (num != 0)
			{
			}
			num = (short)525926400;
			short num3 = num;
			this.cnvPerLabtoolAnalogHotListItemID_A21918.SetRecset(this.a(2212));
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x00BAF7E4 File Offset: 0x00BAD9E4
		public override void DropReferences()
		{
			short num = (short)1692726710;
			short num2 = num;
			num = (short)158922166;
			switch (num2 == num)
			{
			}
			num = (short)1391788033;
			if (num != 0)
			{
			}
			num = (short)1941241856;
			if (num != 0)
			{
			}
			num = (short)842530816;
			short num3 = num;
		}

		// Token: 0x0600C7E9 RID: 51177 RVA: 0x00BAF890 File Offset: 0x00BADA90
		public override void SetConstraints()
		{
			short num = (short)722125693;
			short num2 = num;
			num = (short)1552597885;
			switch (num2 == num)
			{
			}
			num = (short)1070923777;
			if (num != 0)
			{
			}
			num = (short)1218117632;
			if (num != 0)
			{
			}
			num = (short)1889533952;
			short num3 = num;
			this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conConventionalPerSignallingIsMDCAndSelCallEncodeEnabled);
			this.cnvPerNonASTROCallCallAlertRxTx_A7588.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxTypeIsNotAstroAndSigTypeIsMdcOrQciiOrDTMF);
			this.cnvPerNonASTROCallCallAlertRxTx_A7588.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConNonAstroSeleCallNotDecOrNonAstroCallAlertNotDecOrMDCSigNotDvrsViaCallAlert);
			this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConMdcCaDecIsEnabledAndCnvPerRxSigTypeIsNotASTRO);
			this.cnvPerNonASTROCallRTTButtonAccess_A8493.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxTypeIsNotAstroAndSigTypeIsMdc);
			this.cnvPerNonASTROCallRTTButtonAccess_A8493.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerMdcRttButtonAccessIsNotAutoOrRepeaterAccessTypeIsNotAuto);
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSignalingTypeIsMdcORQuikCallIIORDTMF);
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conNonAstroSelectiveCallNotDecodeOrNonAstroCallAlertNotDecodeOrMDCSignalling);
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConUpdateCnvSysSelectCallInCallValue);
			this.cnvPerNonASTROCallUnlimitedCalling_A9597.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConUnlimitedCalling);
			this.cnvPerNonASTROCallUnmuteType_A9601.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerTypeIsMdcAndMdcBasicSelCallDecodeIsEnabled);
			this.cnvPerLabtoolAnalogHotListItemID_A21918.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxTypeIsNotAstroAndSigTypeIsNotNone);
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x00BAFA4C File Offset: 0x00BADC4C
		public override void SetupDependencies()
		{
			short num = (short)1539710662;
			short num2 = num;
			num = (short)77799110;
			switch (num2 == num)
			{
			}
			num = (short)105775105;
			if (num != 0)
			{
			}
			num = (short)1356201984;
			if (num != 0)
			{
			}
			num = (short)88145920;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.AddDependentObject(this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerNonASTROCallCallAlertRxTx_A7588);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerNonASTROCallCallAlertRxTx_A7588);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerNonASTROCallCallAlertRxTx_A7588);
			conventionalPersonality.General.CnvPerFeaturesDVRSProf_A41794.AddDependentObject(this.cnvPerNonASTROCallCallAlertRxTx_A7588);
			this.cnvPerNonASTROCallCallAlertRxTx_A7588.AddDependentObject(this.cnvPerNonASTROCallInCallUserAlertEnable_A8252);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerNonASTROCallInCallUserAlertEnable_A8252);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerNonASTROCallInCallUserAlertEnable_A8252);
			conventionalPersonality.RAC.CnvPerRACAccessType_A7388.AddDependentObject(this.cnvPerNonASTROCallRTTButtonAccess_A8493);
			conventionalPersonality.RAC.CnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerNonASTROCallRTTButtonAccess_A8493);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerNonASTROCallRTTButtonAccess_A8493);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerNonASTROCallRTTButtonAccess_A8493);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerNonASTROCallRTTButtonAccess_A8493);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerNonASTROCallRTTButtonAccess_A8493);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerNonASTROCallSelectiveCallRxTx_A9116);
			this.cnvPerNonASTROCallCallAlertRxTx_A7588.AddDependentObject(this.cnvPerNonASTROCallSelectiveCallRxTx_A9116);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerNonASTROCallSelectiveCallRxTx_A9116);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerNonASTROCallUnlimitedCalling_A9597);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerNonASTROCallUnlimitedCalling_A9597);
			this.cnvPerNonASTROCallCallAlertRxTx_A7588.AddDependentObject(this.cnvPerNonASTROCallUnlimitedCalling_A9597);
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.AddDependentObject(this.cnvPerNonASTROCallUnlimitedCalling_A9597);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerNonASTROCallUnmuteType_A9601);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerNonASTROCallUnmuteType_A9601);
			this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.AddDependentObject(this.cnvPerNonASTROCallUnmuteType_A9601);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerLabtoolAnalogHotListItemID_A21918);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerLabtoolAnalogHotListItemID_A21918);
		}

		// Token: 0x1700643F RID: 25663
		// (get) Token: 0x0600C7EB RID: 51179 RVA: 0x00BAFD70 File Offset: 0x00BADF70
		public bool HasDiffs
		{
			get
			{
				short num = (short)433164679;
				short num2 = num;
				num = (short)666538375;
				switch (num2 == num)
				{
				}
				num = (short)838205440;
				if (num != 0)
				{
				}
				num = (short)1009451009;
				if (num != 0)
				{
				}
				num = (short)251789312;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17006440 RID: 25664
		// (get) Token: 0x0600C7EC RID: 51180 RVA: 0x00BAFE20 File Offset: 0x00BAE020
		// (set) Token: 0x0600C7ED RID: 51181 RVA: 0x00BAFED4 File Offset: 0x00BAE0D4
		public bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520Value
		{
			get
			{
				short num = (short)108624311;
				short num2 = num;
				num = (short)223181239;
				switch (num2 == num)
				{
				}
				num = (short)199557121;
				if (num != 0)
				{
				}
				num = (short)1861812224;
				if (num != 0)
				{
				}
				num = (short)436011008;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Value;
			}
			set
			{
				short num = (short)152612091;
				short num2 = num;
				num = (short)1026010363;
				switch (num2 == num)
				{
				}
				num = (short)895352833;
				if (num != 0)
				{
				}
				num = (short)1212678144;
				if (num != 0)
				{
				}
				num = (short)296615936;
				short num3 = num;
				this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Value = value;
			}
		}

		// Token: 0x17006441 RID: 25665
		// (get) Token: 0x0600C7EE RID: 51182 RVA: 0x00BAFF8C File Offset: 0x00BAE18C
		public global::AcpBusinessLayer.AcpField<bool> CnvPerNonASTROCallAutoSelectCallTransmit_A7520
		{
			get
			{
				short num = (short)1970912475;
				short num2 = num;
				num = (short)649575643;
				switch (num2 == num)
				{
				}
				num = (short)2099249153;
				if (num != 0)
				{
				}
				num = (short)1556611072;
				if (num != 0)
				{
				}
				num = (short)1291321344;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520;
			}
		}

		// Token: 0x17006442 RID: 25666
		// (get) Token: 0x0600C7EF RID: 51183 RVA: 0x00BB003C File Offset: 0x00BAE23C
		// (set) Token: 0x0600C7F0 RID: 51184 RVA: 0x00BB00F4 File Offset: 0x00BAE2F4
		public bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520_UIValue
		{
			get
			{
				short num = (short)1116748358;
				short num2 = num;
				num = (short)1800092230;
				switch (num2 == num)
				{
				}
				num = (short)474546177;
				if (num != 0)
				{
				}
				num = (short)1121976320;
				if (num != 0)
				{
				}
				num = (short)1090912256;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Value;
			}
			set
			{
				short num = (short)1235638632;
				short num2 = num;
				num = (short)477649256;
				switch (num2 == num)
				{
				}
				num = (short)853606401;
				if (num != 0)
				{
				}
				num = (short)456654848;
				if (num != 0)
				{
				}
				num = (short)927465472;
				short num3 = num;
				this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Value = value;
			}
		}

		// Token: 0x17006443 RID: 25667
		// (get) Token: 0x0600C7F1 RID: 51185 RVA: 0x00BB01AC File Offset: 0x00BAE3AC
		// (set) Token: 0x0600C7F2 RID: 51186 RVA: 0x00BB0260 File Offset: 0x00BAE460
		public bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520_Applicable
		{
			get
			{
				short num = (short)1028975572;
				short num2 = num;
				num = (short)1630596052;
				switch (num2 == num)
				{
				}
				num = (short)981860353;
				if (num != 0)
				{
				}
				num = (short)413859840;
				if (num != 0)
				{
				}
				num = (short)1917059072;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Applicable;
			}
			set
			{
				short num = (short)1818101863;
				short num2 = num;
				num = (short)979306599;
				switch (num2 == num)
				{
				}
				num = (short)1939079169;
				if (num != 0)
				{
				}
				num = (short)1582956544;
				if (num != 0)
				{
				}
				num = (short)101777408;
				short num3 = num;
				this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Applicable = value;
			}
		}

		// Token: 0x17006444 RID: 25668
		// (get) Token: 0x0600C7F3 RID: 51187 RVA: 0x00BB0318 File Offset: 0x00BAE518
		// (set) Token: 0x0600C7F4 RID: 51188 RVA: 0x00BB03CC File Offset: 0x00BAE5CC
		public bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520_Valid
		{
			get
			{
				short num = (short)2021414510;
				short num2 = num;
				num = (short)1610372718;
				switch (num2 == num)
				{
				}
				num = (short)314114048;
				if (num != 0)
				{
				}
				num = (short)1301282817;
				if (num != 0)
				{
				}
				num = (short)1979973632;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Valid;
			}
			set
			{
				short num = (short)140592284;
				short num2 = num;
				num = (short)2091861148;
				switch (num2 == num)
				{
				}
				num = (short)1384906753;
				if (num != 0)
				{
				}
				num = (short)653590528;
				if (num != 0)
				{
				}
				num = (short)2049835008;
				short num3 = num;
				this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Valid = value;
			}
		}

		// Token: 0x17006445 RID: 25669
		// (get) Token: 0x0600C7F5 RID: 51189 RVA: 0x00BB0480 File Offset: 0x00BAE680
		// (set) Token: 0x0600C7F6 RID: 51190 RVA: 0x00BB0534 File Offset: 0x00BAE734
		public bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520_Visible
		{
			get
			{
				short num = (short)1668546561;
				if (num != 0)
				{
				}
				num = (short)467705007;
				short num2 = num;
				num = (short)1723571375;
				switch (num2 == num)
				{
				}
				num = (short)482082816;
				if (num != 0)
				{
				}
				num = (short)298713088;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Visible;
			}
			set
			{
				short num = (short)376355602;
				short num2 = num;
				num = (short)217889554;
				switch (num2 == num)
				{
				}
				num = (short)906166273;
				if (num != 0)
				{
				}
				num = (short)702349312;
				if (num != 0)
				{
				}
				num = (short)1167327232;
				short num3 = num;
				this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Visible = value;
			}
		}

		// Token: 0x17006446 RID: 25670
		// (get) Token: 0x0600C7F7 RID: 51191 RVA: 0x00BB05EC File Offset: 0x00BAE7EC
		// (set) Token: 0x0600C7F8 RID: 51192 RVA: 0x00BB069C File Offset: 0x00BAE89C
		public bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520_Editable
		{
			get
			{
				short num = (short)625848101;
				short num2 = num;
				num = (short)720678693;
				switch (num2 == num)
				{
				}
				num = (short)85655553;
				if (num != 0)
				{
				}
				num = (short)865075200;
				if (num != 0)
				{
				}
				num = (short)1467809792;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Editable;
			}
			set
			{
				short num = (short)1852182647;
				short num2 = num;
				num = (short)762187895;
				switch (num2 == num)
				{
				}
				num = (short)150536192;
				if (num != 0)
				{
				}
				num = (short)1779302401;
				if (num != 0)
				{
				}
				num = (short)612958208;
				short num3 = num;
				this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.Editable = value;
			}
		}

		// Token: 0x17006447 RID: 25671
		// (get) Token: 0x0600C7F9 RID: 51193 RVA: 0x00BB0754 File Offset: 0x00BAE954
		internal string CnvPerNonASTROCallAutoSelectCallTransmit_A7520_UILabel
		{
			get
			{
				short num = (short)1905241891;
				short num2 = num;
				num = (short)945598243;
				switch (num2 == num)
				{
				}
				num = (short)1563099137;
				if (num != 0)
				{
				}
				num = (short)6291456;
				if (num != 0)
				{
				}
				num = (short)1792344064;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.UIName;
			}
		}

		// Token: 0x17006448 RID: 25672
		// (get) Token: 0x0600C7FA RID: 51194 RVA: 0x00BB080C File Offset: 0x00BAEA0C
		// (set) Token: 0x0600C7FB RID: 51195 RVA: 0x00BB08C0 File Offset: 0x00BAEAC0
		internal bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520_HiddenStatic
		{
			get
			{
				short num = (short)1595354125;
				short num2 = num;
				num = (short)1035611149;
				switch (num2 == num)
				{
				}
				num = (short)73924609;
				if (num != 0)
				{
				}
				num = (short)606470144;
				if (num != 0)
				{
				}
				num = (short)677576704;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.HiddenStatic;
			}
			set
			{
				short num = (short)1974921015;
				short num2 = num;
				num = (short)15460151;
				switch (num2 == num)
				{
				}
				num = (short)749469696;
				if (num != 0)
				{
				}
				num = (short)538640385;
				if (num != 0)
				{
				}
				num = (short)1292697600;
				short num3 = num;
				this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.HiddenStatic = value;
			}
		}

		// Token: 0x17006449 RID: 25673
		// (get) Token: 0x0600C7FC RID: 51196 RVA: 0x00BB0974 File Offset: 0x00BAEB74
		// (set) Token: 0x0600C7FD RID: 51197 RVA: 0x00BB0A28 File Offset: 0x00BAEC28
		internal bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520_HiddenDynamic
		{
			get
			{
				short num = (short)902067516;
				short num2 = num;
				num = (short)649098556;
				switch (num2 == num)
				{
				}
				num = (short)1418526721;
				if (num != 0)
				{
				}
				num = (short)2001010688;
				if (num != 0)
				{
				}
				num = (short)1593901056;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.HiddenDynamic;
			}
			set
			{
				short num = (short)1322213822;
				short num2 = num;
				num = (short)1036804542;
				switch (num2 == num)
				{
				}
				num = (short)2007629825;
				if (num != 0)
				{
				}
				num = (short)343015424;
				if (num != 0)
				{
				}
				num = (short)24313856;
				short num3 = num;
				this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520.HiddenDynamic = value;
			}
		}

		// Token: 0x1700644A RID: 25674
		// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x00BB0ADC File Offset: 0x00BAECDC
		public bool CnvPerNonASTROCallAutoSelectCallTransmit_A7520_HasDiffs
		{
			get
			{
				short num = (short)1239125898;
				short num2 = num;
				num = (short)821792650;
				switch (num2 == num)
				{
				}
				num = (short)527171585;
				if (num != 0)
				{
				}
				num = (short)293142528;
				if (num != 0)
				{
				}
				num = (short)1581252608;
				short num3 = num;
				return this.cnvPerNonASTROCallAutoSelectCallTransmit_A7520._HasDiffs;
			}
		}

		// Token: 0x1700644B RID: 25675
		// (get) Token: 0x0600C7FF RID: 51199 RVA: 0x00BB0B90 File Offset: 0x00BAED90
		// (set) Token: 0x0600C800 RID: 51200 RVA: 0x00BB0C48 File Offset: 0x00BAEE48
		public int CnvPerNonASTROCallCallAlertRxTx_A7588Value
		{
			get
			{
				short num = (short)473523715;
				short num2 = num;
				num = (short)406676995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)549126144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1204486144;
				if (num != 0)
				{
				}
				num = (short)224395265;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.Value;
			}
			set
			{
				short num = (short)1396563920;
				short num2 = num;
				num = (short)1792925648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1595604992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1227227136;
				if (num != 0)
				{
				}
				num = (short)1380712449;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallCallAlertRxTx_A7588.Value = value;
			}
		}

		// Token: 0x1700644C RID: 25676
		// (get) Token: 0x0600C801 RID: 51201 RVA: 0x00BB0CFC File Offset: 0x00BAEEFC
		// (set) Token: 0x0600C802 RID: 51202 RVA: 0x00BB0DB0 File Offset: 0x00BAEFB0
		public string CnvPerNonASTROCallCallAlertRxTx_A7588_UIValue
		{
			get
			{
				short num = (short)727318529;
				if (num != 0)
				{
				}
				num = (short)547487744;
				short num2 = num;
				num = (short)780060814;
				short num3 = num;
				num = (short)1529661582;
				switch (num3 == num)
				{
				}
				num = (short)710606848;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.UIValue;
			}
			set
			{
				short num = (short)1607474430;
				short num2 = num;
				num = (short)914758910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)93192192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)709361665;
				if (num != 0)
				{
				}
				num = (short)1459683328;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallCallAlertRxTx_A7588.UIValue = value;
			}
		}

		// Token: 0x1700644D RID: 25677
		// (get) Token: 0x0600C803 RID: 51203 RVA: 0x00BB0E68 File Offset: 0x00BAF068
		public global::AcpBusinessLayer.AcpListField CnvPerNonASTROCallCallAlertRxTx_A7588
		{
			get
			{
				short num = (short)826432802;
				short num2 = num;
				num = (short)1258118434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)502398976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2062811136;
				if (num != 0)
				{
				}
				num = (short)1917124609;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588;
			}
		}

		// Token: 0x1700644E RID: 25678
		// (get) Token: 0x0600C804 RID: 51204 RVA: 0x00BB0F18 File Offset: 0x00BAF118
		// (set) Token: 0x0600C805 RID: 51205 RVA: 0x00BB0FCC File Offset: 0x00BAF1CC
		public bool CnvPerNonASTROCallCallAlertRxTx_A7588_Applicable
		{
			get
			{
				short num = (short)357019063;
				short num2 = num;
				num = (short)202026423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)200867840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662306816;
				if (num != 0)
				{
				}
				num = (short)530972673;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.Applicable;
			}
			set
			{
				short num = (short)1011910691;
				short num2 = num;
				num = (short)1335330851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1365704704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)83755008;
				if (num != 0)
				{
				}
				num = (short)780075009;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallCallAlertRxTx_A7588.Applicable = value;
			}
		}

		// Token: 0x1700644F RID: 25679
		// (get) Token: 0x0600C806 RID: 51206 RVA: 0x00BB1084 File Offset: 0x00BAF284
		// (set) Token: 0x0600C807 RID: 51207 RVA: 0x00BB113C File Offset: 0x00BAF33C
		public bool CnvPerNonASTROCallCallAlertRxTx_A7588_Valid
		{
			get
			{
				short num = (short)1867056834;
				short num2 = num;
				num = (short)1878722242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1623326720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1128071168;
				if (num != 0)
				{
				}
				num = (short)699990017;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.Valid;
			}
			set
			{
				short num = (short)1902049669;
				short num2 = num;
				num = (short)1516632453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550188544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)342294529;
				if (num != 0)
				{
				}
				num = (short)552402944;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallCallAlertRxTx_A7588.Valid = value;
			}
		}

		// Token: 0x17006450 RID: 25680
		// (get) Token: 0x0600C808 RID: 51208 RVA: 0x00BB11F0 File Offset: 0x00BAF3F0
		// (set) Token: 0x0600C809 RID: 51209 RVA: 0x00BB12A4 File Offset: 0x00BAF4A4
		public bool CnvPerNonASTROCallCallAlertRxTx_A7588_Visible
		{
			get
			{
				short num = (short)828869999;
				short num2 = num;
				num = (short)489393519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1726873600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532428289;
				if (num != 0)
				{
				}
				num = (short)1457192960;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.Visible;
			}
			set
			{
				short num = (short)140289749;
				short num2 = num;
				num = (short)1198827221;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2055798784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000996865;
				if (num != 0)
				{
				}
				num = (short)487194624;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallCallAlertRxTx_A7588.Visible = value;
			}
		}

		// Token: 0x17006451 RID: 25681
		// (get) Token: 0x0600C80A RID: 51210 RVA: 0x00BB135C File Offset: 0x00BAF55C
		// (set) Token: 0x0600C80B RID: 51211 RVA: 0x00BB140C File Offset: 0x00BAF60C
		public bool CnvPerNonASTROCallCallAlertRxTx_A7588_Editable
		{
			get
			{
				short num = (short)871237940;
				short num2 = num;
				num = (short)2042497332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1352466432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1897857025;
				if (num != 0)
				{
				}
				num = (short)1982857216;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.Editable;
			}
			set
			{
				short num = (short)1468118968;
				short num2 = num;
				num = (short)840873912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1741422592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1983184897;
				if (num != 0)
				{
				}
				num = (short)1450704896;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallCallAlertRxTx_A7588.Editable = value;
			}
		}

		// Token: 0x17006452 RID: 25682
		// (get) Token: 0x0600C80C RID: 51212 RVA: 0x00BB14C0 File Offset: 0x00BAF6C0
		internal string CnvPerNonASTROCallCallAlertRxTx_A7588_UILabel
		{
			get
			{
				short num = (short)1858863105;
				if (num != 0)
				{
				}
				num = (short)991821824;
				short num2 = num;
				num = (short)2140662378;
				short num3 = num;
				num = (short)625273450;
				switch (num3 == num)
				{
				}
				num = (short)381157376;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.UIName;
			}
		}

		// Token: 0x17006453 RID: 25683
		// (get) Token: 0x0600C80D RID: 51213 RVA: 0x00BB1574 File Offset: 0x00BAF774
		// (set) Token: 0x0600C80E RID: 51214 RVA: 0x00BB1628 File Offset: 0x00BAF828
		internal bool CnvPerNonASTROCallCallAlertRxTx_A7588_HiddenStatic
		{
			get
			{
				short num = (short)2127092058;
				short num2 = num;
				num = (short)221305178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1680998400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2142306304;
				if (num != 0)
				{
				}
				num = (short)1181089793;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.HiddenStatic;
			}
			set
			{
				short num = (short)100051383;
				short num2 = num;
				num = (short)791652791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1385496576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2064121857;
				if (num != 0)
				{
				}
				num = (short)533659648;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallCallAlertRxTx_A7588.HiddenStatic = value;
			}
		}

		// Token: 0x17006454 RID: 25684
		// (get) Token: 0x0600C80F RID: 51215 RVA: 0x00BB16DC File Offset: 0x00BAF8DC
		// (set) Token: 0x0600C810 RID: 51216 RVA: 0x00BB178C File Offset: 0x00BAF98C
		internal bool CnvPerNonASTROCallCallAlertRxTx_A7588_HiddenDynamic
		{
			get
			{
				short num = (short)71565313;
				if (num != 0)
				{
				}
				num = (short)491585536;
				short num2 = num;
				num = (short)169211362;
				short num3 = num;
				num = (short)525268450;
				switch (num3 == num)
				{
				}
				num = (short)847642624;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588.HiddenDynamic;
			}
			set
			{
				short num = (short)1925421479;
				short num2 = num;
				num = (short)1218746791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)703594496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)377815041;
				if (num != 0)
				{
				}
				num = (short)1694957568;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallCallAlertRxTx_A7588.HiddenDynamic = value;
			}
		}

		// Token: 0x17006455 RID: 25685
		// (get) Token: 0x0600C811 RID: 51217 RVA: 0x00BB1840 File Offset: 0x00BAFA40
		public bool CnvPerNonASTROCallCallAlertRxTx_A7588_HasDiffs
		{
			get
			{
				short num = (short)1882558916;
				short num2 = num;
				num = (short)1799262660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889978880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)402522113;
				if (num != 0)
				{
				}
				num = (short)1559232512;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallCallAlertRxTx_A7588._HasDiffs;
			}
		}

		// Token: 0x17006456 RID: 25686
		// (get) Token: 0x0600C812 RID: 51218 RVA: 0x00BB18F8 File Offset: 0x00BAFAF8
		// (set) Token: 0x0600C813 RID: 51219 RVA: 0x00BB19AC File Offset: 0x00BAFBAC
		public bool CnvPerNonASTROCallInCallUserAlertEnable_A8252Value
		{
			get
			{
				short num = (short)539654710;
				short num2 = num;
				num = (short)432503350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)838139904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)547815425;
				if (num != 0)
				{
				}
				num = (short)814415872;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Value;
			}
			set
			{
				short num = (short)172921941;
				short num2 = num;
				num = (short)932418645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591410688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)306774016;
				if (num != 0)
				{
				}
				num = (short)656736257;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Value = value;
			}
		}

		// Token: 0x17006457 RID: 25687
		// (get) Token: 0x0600C814 RID: 51220 RVA: 0x00BB1A60 File Offset: 0x00BAFC60
		public global::AcpBusinessLayer.AcpField<bool> CnvPerNonASTROCallInCallUserAlertEnable_A8252
		{
			get
			{
				short num = (short)1649977730;
				short num2 = num;
				num = (short)912107906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)275709952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1878654977;
				if (num != 0)
				{
				}
				num = (short)1466236928;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252;
			}
		}

		// Token: 0x17006458 RID: 25688
		// (get) Token: 0x0600C815 RID: 51221 RVA: 0x00BB1B10 File Offset: 0x00BAFD10
		// (set) Token: 0x0600C816 RID: 51222 RVA: 0x00BB1BC4 File Offset: 0x00BAFDC4
		public bool CnvPerNonASTROCallInCallUserAlertEnable_A8252_UIValue
		{
			get
			{
				short num = (short)1024727544;
				short num2 = num;
				num = (short)331356664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)846659584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)427753473;
				if (num != 0)
				{
				}
				num = (short)1899298816;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Value;
			}
			set
			{
				short num = (short)939560103;
				short num2 = num;
				num = (short)1799589031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1423048704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1949171713;
				if (num != 0)
				{
				}
				num = (short)1942093824;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Value = value;
			}
		}

		// Token: 0x17006459 RID: 25689
		// (get) Token: 0x0600C817 RID: 51223 RVA: 0x00BB1C78 File Offset: 0x00BAFE78
		// (set) Token: 0x0600C818 RID: 51224 RVA: 0x00BB1D2C File Offset: 0x00BAFF2C
		public bool CnvPerNonASTROCallInCallUserAlertEnable_A8252_Applicable
		{
			get
			{
				short num = (short)472474576;
				short num2 = num;
				num = (short)2126799824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320274432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)492765184;
				if (num != 0)
				{
				}
				num = (short)1361444865;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Applicable;
			}
			set
			{
				short num = (short)15358073;
				short num2 = num;
				num = (short)107763833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)598999040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979252736;
				if (num != 0)
				{
				}
				num = (short)621412353;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Applicable = value;
			}
		}

		// Token: 0x1700645A RID: 25690
		// (get) Token: 0x0600C819 RID: 51225 RVA: 0x00BB1DE0 File Offset: 0x00BAFFE0
		// (set) Token: 0x0600C81A RID: 51226 RVA: 0x00BB1E94 File Offset: 0x00BB0094
		public bool CnvPerNonASTROCallInCallUserAlertEnable_A8252_Valid
		{
			get
			{
				short num = (short)1002137997;
				short num2 = num;
				num = (short)2044553613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)175767552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)950730753;
				if (num != 0)
				{
				}
				num = (short)2016280576;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Valid;
			}
			set
			{
				short num = (short)1476526081;
				if (num != 0)
				{
				}
				num = (short)1653080064;
				short num2 = num;
				num = (short)1750081309;
				short num3 = num;
				num = (short)797843229;
				switch (num3 == num)
				{
				}
				num = (short)1582563328;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Valid = value;
			}
		}

		// Token: 0x1700645B RID: 25691
		// (get) Token: 0x0600C81B RID: 51227 RVA: 0x00BB1F48 File Offset: 0x00BB0148
		// (set) Token: 0x0600C81C RID: 51228 RVA: 0x00BB1FFC File Offset: 0x00BB01FC
		public bool CnvPerNonASTROCallInCallUserAlertEnable_A8252_Visible
		{
			get
			{
				short num = (short)635278177;
				short num2 = num;
				num = (short)878941025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1007484928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)892272641;
				if (num != 0)
				{
				}
				num = (short)1296629760;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Visible;
			}
			set
			{
				short num = (short)1553609382;
				short num2 = num;
				num = (short)1555640998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)588382208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951189504;
				if (num != 0)
				{
				}
				num = (short)2122973185;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Visible = value;
			}
		}

		// Token: 0x1700645C RID: 25692
		// (get) Token: 0x0600C81D RID: 51229 RVA: 0x00BB20B0 File Offset: 0x00BB02B0
		// (set) Token: 0x0600C81E RID: 51230 RVA: 0x00BB2168 File Offset: 0x00BB0368
		public bool CnvPerNonASTROCallInCallUserAlertEnable_A8252_Editable
		{
			get
			{
				short num = (short)1978388650;
				short num2 = num;
				num = (short)1874186410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2061107200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039466497;
				if (num != 0)
				{
				}
				num = (short)533987328;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Editable;
			}
			set
			{
				short num = (short)337305239;
				short num2 = num;
				num = (short)2017255063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)171573248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1568014337;
				if (num != 0)
				{
				}
				num = (short)1277427712;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.Editable = value;
			}
		}

		// Token: 0x1700645D RID: 25693
		// (get) Token: 0x0600C81F RID: 51231 RVA: 0x00BB221C File Offset: 0x00BB041C
		internal string CnvPerNonASTROCallInCallUserAlertEnable_A8252_UILabel
		{
			get
			{
				short num = (short)1932956663;
				short num2 = num;
				num = (short)27235319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1722613760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17629184;
				if (num != 0)
				{
				}
				num = (short)1779236865;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.UIName;
			}
		}

		// Token: 0x1700645E RID: 25694
		// (get) Token: 0x0600C820 RID: 51232 RVA: 0x00BB22D0 File Offset: 0x00BB04D0
		// (set) Token: 0x0600C821 RID: 51233 RVA: 0x00BB2388 File Offset: 0x00BB0588
		internal bool CnvPerNonASTROCallInCallUserAlertEnable_A8252_HiddenStatic
		{
			get
			{
				short num = (short)1478964210;
				short num2 = num;
				num = (short)1445934066;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121517568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)335347712;
				if (num != 0)
				{
				}
				num = (short)1811939329;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.HiddenStatic;
			}
			set
			{
				short num = (short)1154988226;
				short num2 = num;
				num = (short)1666234562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2127036416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)416808961;
				if (num != 0)
				{
				}
				num = (short)1537867776;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.HiddenStatic = value;
			}
		}

		// Token: 0x1700645F RID: 25695
		// (get) Token: 0x0600C822 RID: 51234 RVA: 0x00BB243C File Offset: 0x00BB063C
		// (set) Token: 0x0600C823 RID: 51235 RVA: 0x00BB24F0 File Offset: 0x00BB06F0
		internal bool CnvPerNonASTROCallInCallUserAlertEnable_A8252_HiddenDynamic
		{
			get
			{
				short num = (short)1129709569;
				if (num != 0)
				{
				}
				num = (short)1607335936;
				short num2 = num;
				num = (short)515617207;
				short num3 = num;
				num = (short)1935192503;
				switch (num3 == num)
				{
				}
				num = (short)680067072;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.HiddenDynamic;
			}
			set
			{
				short num = (short)310030632;
				short num2 = num;
				num = (short)1785966888;
				switch (num2 == num)
				{
				}
				num = (short)636092417;
				if (num != 0)
				{
				}
				num = (short)2087911424;
				if (num != 0)
				{
				}
				num = (short)1855062016;
				short num3 = num;
				this.cnvPerNonASTROCallInCallUserAlertEnable_A8252.HiddenDynamic = value;
			}
		}

		// Token: 0x17006460 RID: 25696
		// (get) Token: 0x0600C824 RID: 51236 RVA: 0x00BB25A8 File Offset: 0x00BB07A8
		public bool CnvPerNonASTROCallInCallUserAlertEnable_A8252_HasDiffs
		{
			get
			{
				short num = (short)1943244796;
				short num2 = num;
				num = (short)102404092;
				switch (num2 == num)
				{
				}
				num = (short)193789952;
				if (num != 0)
				{
				}
				num = (short)715128833;
				if (num != 0)
				{
				}
				num = (short)190316544;
				short num3 = num;
				return this.cnvPerNonASTROCallInCallUserAlertEnable_A8252._HasDiffs;
			}
		}

		// Token: 0x17006461 RID: 25697
		// (get) Token: 0x0600C825 RID: 51237 RVA: 0x00BB265C File Offset: 0x00BB085C
		// (set) Token: 0x0600C826 RID: 51238 RVA: 0x00BB270C File Offset: 0x00BB090C
		public int CnvPerNonASTROCallRTTButtonAccess_A8493Value
		{
			get
			{
				short num = (short)453664696;
				short num2 = num;
				num = (short)158425016;
				switch (num2 == num)
				{
				}
				num = (short)1010958337;
				if (num != 0)
				{
				}
				num = (short)953155584;
				if (num != 0)
				{
				}
				num = (short)664076288;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.Value;
			}
			set
			{
				short num = (short)6720655;
				short num2 = num;
				num = (short)1337298063;
				switch (num2 == num)
				{
				}
				num = (short)606076929;
				if (num != 0)
				{
				}
				num = (short)343670784;
				if (num != 0)
				{
				}
				num = (short)1930297344;
				short num3 = num;
				this.cnvPerNonASTROCallRTTButtonAccess_A8493.Value = value;
			}
		}

		// Token: 0x17006462 RID: 25698
		// (get) Token: 0x0600C827 RID: 51239 RVA: 0x00BB27C0 File Offset: 0x00BB09C0
		// (set) Token: 0x0600C828 RID: 51240 RVA: 0x00BB2878 File Offset: 0x00BB0A78
		public string CnvPerNonASTROCallRTTButtonAccess_A8493_UIValue
		{
			get
			{
				short num = (short)1734267204;
				short num2 = num;
				num = (short)1270600004;
				switch (num2 == num)
				{
				}
				num = (short)996802561;
				if (num != 0)
				{
				}
				num = (short)1878982656;
				if (num != 0)
				{
				}
				num = (short)29360128;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.UIValue;
			}
			set
			{
				short num = (short)1099359506;
				short num2 = num;
				num = (short)677897490;
				switch (num2 == num)
				{
				}
				num = (short)1802174464;
				if (num != 0)
				{
				}
				num = (short)879362049;
				if (num != 0)
				{
				}
				num = (short)872677376;
				short num3 = num;
				this.cnvPerNonASTROCallRTTButtonAccess_A8493.UIValue = value;
			}
		}

		// Token: 0x17006463 RID: 25699
		// (get) Token: 0x0600C829 RID: 51241 RVA: 0x00BB292C File Offset: 0x00BB0B2C
		public global::AcpBusinessLayer.AcpListField CnvPerNonASTROCallRTTButtonAccess_A8493
		{
			get
			{
				short num = (short)1870073569;
				short num2 = num;
				num = (short)1062211297;
				switch (num2 == num)
				{
				}
				num = (short)389808129;
				if (num != 0)
				{
				}
				num = (short)1005060096;
				if (num != 0)
				{
				}
				num = (short)506527744;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493;
			}
		}

		// Token: 0x17006464 RID: 25700
		// (get) Token: 0x0600C82A RID: 51242 RVA: 0x00BB29D8 File Offset: 0x00BB0BD8
		// (set) Token: 0x0600C82B RID: 51243 RVA: 0x00BB2A8C File Offset: 0x00BB0C8C
		public bool CnvPerNonASTROCallRTTButtonAccess_A8493_Applicable
		{
			get
			{
				short num = (short)1978059006;
				short num2 = num;
				num = (short)60737790;
				switch (num2 == num)
				{
				}
				num = (short)57016321;
				if (num != 0)
				{
				}
				num = (short)1691287552;
				if (num != 0)
				{
				}
				num = (short)1162805248;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.Applicable;
			}
			set
			{
				short num = (short)1393401287;
				short num2 = num;
				num = (short)88513991;
				switch (num2 == num)
				{
				}
				num = (short)720830464;
				if (num != 0)
				{
				}
				num = (short)1646854145;
				if (num != 0)
				{
				}
				num = (short)1037959168;
				short num3 = num;
				this.cnvPerNonASTROCallRTTButtonAccess_A8493.Applicable = value;
			}
		}

		// Token: 0x17006465 RID: 25701
		// (get) Token: 0x0600C82C RID: 51244 RVA: 0x00BB2B40 File Offset: 0x00BB0D40
		// (set) Token: 0x0600C82D RID: 51245 RVA: 0x00BB2BF4 File Offset: 0x00BB0DF4
		public bool CnvPerNonASTROCallRTTButtonAccess_A8493_Valid
		{
			get
			{
				short num = (short)1966642043;
				short num2 = num;
				num = (short)1407685499;
				switch (num2 == num)
				{
				}
				num = (short)960430081;
				if (num != 0)
				{
				}
				num = (short)2090926080;
				if (num != 0)
				{
				}
				num = (short)1613234176;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.Valid;
			}
			set
			{
				short num = (short)486015834;
				short num2 = num;
				num = (short)289473370;
				switch (num2 == num)
				{
				}
				num = (short)1893007360;
				if (num != 0)
				{
				}
				num = (short)2006712321;
				if (num != 0)
				{
				}
				num = (short)392626176;
				short num3 = num;
				this.cnvPerNonASTROCallRTTButtonAccess_A8493.Valid = value;
			}
		}

		// Token: 0x17006466 RID: 25702
		// (get) Token: 0x0600C82E RID: 51246 RVA: 0x00BB2CAC File Offset: 0x00BB0EAC
		// (set) Token: 0x0600C82F RID: 51247 RVA: 0x00BB2D60 File Offset: 0x00BB0F60
		public bool CnvPerNonASTROCallRTTButtonAccess_A8493_Visible
		{
			get
			{
				short num = (short)1352910011;
				short num2 = num;
				num = (short)1328137403;
				switch (num2 == num)
				{
				}
				num = (short)495583233;
				if (num != 0)
				{
				}
				num = (short)190709760;
				if (num != 0)
				{
				}
				num = (short)943325184;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.Visible;
			}
			set
			{
				short num = (short)568721409;
				if (num != 0)
				{
				}
				num = (short)1888761629;
				short num2 = num;
				num = (short)1954494237;
				switch (num2 == num)
				{
				}
				num = (short)1775763456;
				if (num != 0)
				{
				}
				num = (short)1236795392;
				short num3 = num;
				this.cnvPerNonASTROCallRTTButtonAccess_A8493.Visible = value;
			}
		}

		// Token: 0x17006467 RID: 25703
		// (get) Token: 0x0600C830 RID: 51248 RVA: 0x00BB2E18 File Offset: 0x00BB1018
		// (set) Token: 0x0600C831 RID: 51249 RVA: 0x00BB2ECC File Offset: 0x00BB10CC
		public bool CnvPerNonASTROCallRTTButtonAccess_A8493_Editable
		{
			get
			{
				short num = (short)998507884;
				short num2 = num;
				num = (short)747832684;
				switch (num2 == num)
				{
				}
				num = (short)1810890752;
				if (num != 0)
				{
				}
				num = (short)1486159873;
				if (num != 0)
				{
				}
				num = (short)1281425408;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.Editable;
			}
			set
			{
				short num = (short)1918121515;
				short num2 = num;
				num = (short)1782330923;
				switch (num2 == num)
				{
				}
				num = (short)1636564993;
				if (num != 0)
				{
				}
				num = (short)2127167488;
				if (num != 0)
				{
				}
				num = (short)450428928;
				short num3 = num;
				this.cnvPerNonASTROCallRTTButtonAccess_A8493.Editable = value;
			}
		}

		// Token: 0x17006468 RID: 25704
		// (get) Token: 0x0600C832 RID: 51250 RVA: 0x00BB2F84 File Offset: 0x00BB1184
		internal string CnvPerNonASTROCallRTTButtonAccess_A8493_UILabel
		{
			get
			{
				short num = (short)1369656720;
				short num2 = num;
				num = (short)814042512;
				switch (num2 == num)
				{
				}
				num = (short)2119630849;
				if (num != 0)
				{
				}
				num = (short)1513357312;
				if (num != 0)
				{
				}
				num = (short)1121648640;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.UIName;
			}
		}

		// Token: 0x17006469 RID: 25705
		// (get) Token: 0x0600C833 RID: 51251 RVA: 0x00BB303C File Offset: 0x00BB123C
		// (set) Token: 0x0600C834 RID: 51252 RVA: 0x00BB30F0 File Offset: 0x00BB12F0
		internal bool CnvPerNonASTROCallRTTButtonAccess_A8493_HiddenStatic
		{
			get
			{
				short num = (short)1850598263;
				short num2 = num;
				num = (short)896918391;
				switch (num2 == num)
				{
				}
				num = (short)548864000;
				if (num != 0)
				{
				}
				num = (short)2621441;
				if (num != 0)
				{
				}
				num = (short)1207762944;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.HiddenStatic;
			}
			set
			{
				short num = (short)459990920;
				short num2 = num;
				num = (short)1861674888;
				switch (num2 == num)
				{
				}
				num = (short)2064318464;
				if (num != 0)
				{
				}
				num = (short)478806017;
				if (num != 0)
				{
				}
				num = (short)2101542912;
				short num3 = num;
				this.cnvPerNonASTROCallRTTButtonAccess_A8493.HiddenStatic = value;
			}
		}

		// Token: 0x1700646A RID: 25706
		// (get) Token: 0x0600C835 RID: 51253 RVA: 0x00BB31A4 File Offset: 0x00BB13A4
		// (set) Token: 0x0600C836 RID: 51254 RVA: 0x00BB3258 File Offset: 0x00BB1458
		internal bool CnvPerNonASTROCallRTTButtonAccess_A8493_HiddenDynamic
		{
			get
			{
				short num = (short)1153956661;
				short num2 = num;
				num = (short)1809054517;
				switch (num2 == num)
				{
				}
				num = (short)952303617;
				if (num != 0)
				{
				}
				num = (short)1920008192;
				if (num != 0)
				{
				}
				num = (short)767098880;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493.HiddenDynamic;
			}
			set
			{
				short num = (short)614317185;
				short num2 = num;
				num = (short)1342684289;
				switch (num2 == num)
				{
				}
				num = (short)745013249;
				if (num != 0)
				{
				}
				num = (short)587464704;
				if (num != 0)
				{
				}
				num = (short)452984832;
				short num3 = num;
				this.cnvPerNonASTROCallRTTButtonAccess_A8493.HiddenDynamic = value;
			}
		}

		// Token: 0x1700646B RID: 25707
		// (get) Token: 0x0600C837 RID: 51255 RVA: 0x00BB3310 File Offset: 0x00BB1510
		public bool CnvPerNonASTROCallRTTButtonAccess_A8493_HasDiffs
		{
			get
			{
				short num = (short)469419479;
				short num2 = num;
				num = (short)1595590103;
				switch (num2 == num)
				{
				}
				num = (short)1295187969;
				if (num != 0)
				{
				}
				num = (short)1543307264;
				if (num != 0)
				{
				}
				num = (short)347144192;
				short num3 = num;
				return this.cnvPerNonASTROCallRTTButtonAccess_A8493._HasDiffs;
			}
		}

		// Token: 0x1700646C RID: 25708
		// (get) Token: 0x0600C838 RID: 51256 RVA: 0x00BB33C8 File Offset: 0x00BB15C8
		// (set) Token: 0x0600C839 RID: 51257 RVA: 0x00BB3480 File Offset: 0x00BB1680
		public int CnvPerNonASTROCallSelectiveCallRxTx_A9116Value
		{
			get
			{
				short num = (short)1556036582;
				short num2 = num;
				num = (short)1403534310;
				switch (num2 == num)
				{
				}
				num = (short)413597697;
				if (num != 0)
				{
				}
				num = (short)1577320448;
				if (num != 0)
				{
				}
				num = (short)371130368;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Value;
			}
			set
			{
				short num = (short)1814214958;
				short num2 = num;
				num = (short)1229830446;
				switch (num2 == num)
				{
				}
				num = (short)2022113281;
				if (num != 0)
				{
				}
				num = (short)1059061760;
				if (num != 0)
				{
				}
				num = (short)2067005440;
				short num3 = num;
				this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Value = value;
			}
		}

		// Token: 0x1700646D RID: 25709
		// (get) Token: 0x0600C83A RID: 51258 RVA: 0x00BB3538 File Offset: 0x00BB1738
		// (set) Token: 0x0600C83B RID: 51259 RVA: 0x00BB35F0 File Offset: 0x00BB17F0
		public string CnvPerNonASTROCallSelectiveCallRxTx_A9116_UIValue
		{
			get
			{
				short num = (short)1738081448;
				short num2 = num;
				num = (short)270271656;
				switch (num2 == num)
				{
				}
				num = (short)1067515904;
				if (num != 0)
				{
				}
				num = (short)2058092545;
				if (num != 0)
				{
				}
				num = (short)2007302144;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.UIValue;
			}
			set
			{
				short num = (short)957432874;
				short num2 = num;
				num = (short)993477674;
				switch (num2 == num)
				{
				}
				num = (short)2086862849;
				if (num != 0)
				{
				}
				num = (short)1071120384;
				if (num != 0)
				{
				}
				num = (short)167903232;
				short num3 = num;
				this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.UIValue = value;
			}
		}

		// Token: 0x1700646E RID: 25710
		// (get) Token: 0x0600C83C RID: 51260 RVA: 0x00BB36A4 File Offset: 0x00BB18A4
		public global::AcpBusinessLayer.AcpListField CnvPerNonASTROCallSelectiveCallRxTx_A9116
		{
			get
			{
				short num = (short)1148283141;
				short num2 = num;
				num = (short)1285777669;
				switch (num2 == num)
				{
				}
				num = (short)1229914112;
				if (num != 0)
				{
				}
				num = (short)888078337;
				if (num != 0)
				{
				}
				num = (short)1717960704;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116;
			}
		}

		// Token: 0x1700646F RID: 25711
		// (get) Token: 0x0600C83D RID: 51261 RVA: 0x00BB3750 File Offset: 0x00BB1950
		// (set) Token: 0x0600C83E RID: 51262 RVA: 0x00BB3808 File Offset: 0x00BB1A08
		public bool CnvPerNonASTROCallSelectiveCallRxTx_A9116_Applicable
		{
			get
			{
				short num = (short)1631875936;
				short num2 = num;
				num = (short)2137944928;
				switch (num2 == num)
				{
				}
				num = (short)760414209;
				if (num != 0)
				{
				}
				num = (short)1086652416;
				if (num != 0)
				{
				}
				num = (short)289931264;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Applicable;
			}
			set
			{
				short num = (short)1237501663;
				short num2 = num;
				num = (short)1182058207;
				switch (num2 == num)
				{
				}
				num = (short)1149108225;
				if (num != 0)
				{
				}
				num = (short)581435392;
				if (num != 0)
				{
				}
				num = (short)1664614400;
				short num3 = num;
				this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Applicable = value;
			}
		}

		// Token: 0x17006470 RID: 25712
		// (get) Token: 0x0600C83F RID: 51263 RVA: 0x00BB38C0 File Offset: 0x00BB1AC0
		// (set) Token: 0x0600C840 RID: 51264 RVA: 0x00BB3974 File Offset: 0x00BB1B74
		public bool CnvPerNonASTROCallSelectiveCallRxTx_A9116_Valid
		{
			get
			{
				short num = (short)327204036;
				short num2 = num;
				num = (short)1840299204;
				switch (num2 == num)
				{
				}
				num = (short)34603009;
				if (num != 0)
				{
				}
				num = (short)1591869440;
				if (num != 0)
				{
				}
				num = (short)1112276992;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Valid;
			}
			set
			{
				short num = (short)1394788414;
				short num2 = num;
				num = (short)1045547070;
				switch (num2 == num)
				{
				}
				num = (short)195493889;
				if (num != 0)
				{
				}
				num = (short)1374945280;
				if (num != 0)
				{
				}
				num = (short)174718976;
				short num3 = num;
				this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Valid = value;
			}
		}

		// Token: 0x17006471 RID: 25713
		// (get) Token: 0x0600C841 RID: 51265 RVA: 0x00BB3A28 File Offset: 0x00BB1C28
		// (set) Token: 0x0600C842 RID: 51266 RVA: 0x00BB3AD8 File Offset: 0x00BB1CD8
		public bool CnvPerNonASTROCallSelectiveCallRxTx_A9116_Visible
		{
			get
			{
				short num = (short)1487697212;
				short num2 = num;
				num = (short)1182627132;
				switch (num2 == num)
				{
				}
				num = (short)2036531201;
				if (num != 0)
				{
				}
				num = (short)1467482112;
				if (num != 0)
				{
				}
				num = (short)720961536;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Visible;
			}
			set
			{
				short num = (short)2094564293;
				short num2 = num;
				num = (short)1199145925;
				switch (num2 == num)
				{
				}
				num = (short)611844097;
				if (num != 0)
				{
				}
				num = (short)1412890624;
				if (num != 0)
				{
				}
				num = (short)2109734912;
				short num3 = num;
				this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Visible = value;
			}
		}

		// Token: 0x17006472 RID: 25714
		// (get) Token: 0x0600C843 RID: 51267 RVA: 0x00BB3B8C File Offset: 0x00BB1D8C
		// (set) Token: 0x0600C844 RID: 51268 RVA: 0x00BB3C40 File Offset: 0x00BB1E40
		public bool CnvPerNonASTROCallSelectiveCallRxTx_A9116_Editable
		{
			get
			{
				short num = (short)590098855;
				short num2 = num;
				num = (short)718811559;
				switch (num2 == num)
				{
				}
				num = (short)1920204801;
				if (num != 0)
				{
				}
				num = (short)853606400;
				if (num != 0)
				{
				}
				num = (short)1590624256;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Editable;
			}
			set
			{
				short num = (short)253372323;
				short num2 = num;
				num = (short)2083923875;
				switch (num2 == num)
				{
				}
				num = (short)1376256000;
				if (num != 0)
				{
				}
				num = (short)334233601;
				if (num != 0)
				{
				}
				num = (short)1001062400;
				short num3 = num;
				this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.Editable = value;
			}
		}

		// Token: 0x17006473 RID: 25715
		// (get) Token: 0x0600C845 RID: 51269 RVA: 0x00BB3CF4 File Offset: 0x00BB1EF4
		internal string CnvPerNonASTROCallSelectiveCallRxTx_A9116_UILabel
		{
			get
			{
				short num = (short)291897345;
				if (num != 0)
				{
				}
				num = (short)539949198;
				short num2 = num;
				num = (short)1368782990;
				switch (num2 == num)
				{
				}
				num = (short)601882624;
				if (num != 0)
				{
				}
				num = (short)1821114368;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.UIName;
			}
		}

		// Token: 0x17006474 RID: 25716
		// (get) Token: 0x0600C846 RID: 51270 RVA: 0x00BB3DAC File Offset: 0x00BB1FAC
		// (set) Token: 0x0600C847 RID: 51271 RVA: 0x00BB3E60 File Offset: 0x00BB2060
		internal bool CnvPerNonASTROCallSelectiveCallRxTx_A9116_HiddenStatic
		{
			get
			{
				short num = (short)1674313729;
				if (num != 0)
				{
				}
				num = (short)2096588261;
				short num2 = num;
				num = (short)62940645;
				switch (num2 == num)
				{
				}
				num = (short)1858273280;
				if (num != 0)
				{
				}
				num = (short)2128412672;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.HiddenStatic;
			}
			set
			{
				short num = (short)700856814;
				short num2 = num;
				num = (short)422918638;
				switch (num2 == num)
				{
				}
				num = (short)923009024;
				if (num != 0)
				{
				}
				num = (short)1044185089;
				if (num != 0)
				{
				}
				num = (short)1947664384;
				short num3 = num;
				this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.HiddenStatic = value;
			}
		}

		// Token: 0x17006475 RID: 25717
		// (get) Token: 0x0600C848 RID: 51272 RVA: 0x00BB3F1C File Offset: 0x00BB211C
		// (set) Token: 0x0600C849 RID: 51273 RVA: 0x00BB3FD0 File Offset: 0x00BB21D0
		internal bool CnvPerNonASTROCallSelectiveCallRxTx_A9116_HiddenDynamic
		{
			get
			{
				short num = (short)978453813;
				short num2 = num;
				num = (short)494142773;
				switch (num2 == num)
				{
				}
				num = (short)349700097;
				if (num != 0)
				{
				}
				num = (short)1189609472;
				if (num != 0)
				{
				}
				num = (short)1520435200;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.HiddenDynamic;
			}
			set
			{
				short num = (short)2002823409;
				short num2 = num;
				num = (short)225618161;
				switch (num2 == num)
				{
				}
				num = (short)1379074049;
				if (num != 0)
				{
				}
				num = (short)1918173184;
				if (num != 0)
				{
				}
				num = (short)1430126592;
				short num3 = num;
				this.cnvPerNonASTROCallSelectiveCallRxTx_A9116.HiddenDynamic = value;
			}
		}

		// Token: 0x17006476 RID: 25718
		// (get) Token: 0x0600C84A RID: 51274 RVA: 0x00BB4088 File Offset: 0x00BB2288
		public bool CnvPerNonASTROCallSelectiveCallRxTx_A9116_HasDiffs
		{
			get
			{
				short num = (short)173473793;
				if (num != 0)
				{
				}
				num = (short)1210298179;
				short num2 = num;
				num = (short)655339331;
				switch (num2 == num)
				{
				}
				num = (short)887422976;
				if (num != 0)
				{
				}
				num = (short)968753152;
				short num3 = num;
				return this.cnvPerNonASTROCallSelectiveCallRxTx_A9116._HasDiffs;
			}
		}

		// Token: 0x17006477 RID: 25719
		// (get) Token: 0x0600C84B RID: 51275 RVA: 0x00BB4140 File Offset: 0x00BB2340
		// (set) Token: 0x0600C84C RID: 51276 RVA: 0x00BB41F8 File Offset: 0x00BB23F8
		public bool CnvPerNonASTROCallUnlimitedCalling_A9597Value
		{
			get
			{
				short num = (short)162175648;
				short num2 = num;
				num = (short)1205181088;
				switch (num2 == num)
				{
				}
				num = (short)853213185;
				if (num != 0)
				{
				}
				num = (short)887422976;
				if (num != 0)
				{
				}
				num = (short)14811136;
				short num3 = num;
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.Value;
			}
			set
			{
				short num = (short)181948666;
				short num2 = num;
				num = (short)1891913978;
				switch (num2 == num)
				{
				}
				num = (short)1802829825;
				if (num != 0)
				{
				}
				num = (short)458555392;
				if (num != 0)
				{
				}
				num = (short)194707456;
				short num3 = num;
				this.cnvPerNonASTROCallUnlimitedCalling_A9597.Value = value;
			}
		}

		// Token: 0x17006478 RID: 25720
		// (get) Token: 0x0600C84D RID: 51277 RVA: 0x00BB42AC File Offset: 0x00BB24AC
		public global::AcpBusinessLayer.AcpField<bool> CnvPerNonASTROCallUnlimitedCalling_A9597
		{
			get
			{
				short num = (short)1923018464;
				short num2 = num;
				num = (short)977727200;
				switch (num2 == num)
				{
				}
				num = (short)2050359296;
				if (num != 0)
				{
				}
				num = (short)2084241409;
				if (num != 0)
				{
				}
				num = (short)2081816576;
				short num3 = num;
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597;
			}
		}

		// Token: 0x17006479 RID: 25721
		// (get) Token: 0x0600C84E RID: 51278 RVA: 0x00BB435C File Offset: 0x00BB255C
		// (set) Token: 0x0600C84F RID: 51279 RVA: 0x00BB4410 File Offset: 0x00BB2610
		public bool CnvPerNonASTROCallUnlimitedCalling_A9597_UIValue
		{
			get
			{
				short num = (short)1323106305;
				if (num != 0)
				{
				}
				num = (short)2047201364;
				short num2 = num;
				num = (short)111661140;
				switch (num2 == num)
				{
				}
				num = (short)1569718272;
				if (num != 0)
				{
				}
				num = (short)1054146560;
				short num3 = num;
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.Value;
			}
			set
			{
				short num = (short)1375229215;
				short num2 = num;
				num = (short)1082021151;
				switch (num2 == num)
				{
				}
				num = (short)785907712;
				if (num != 0)
				{
				}
				num = (short)1790115841;
				if (num != 0)
				{
				}
				num = (short)468320256;
				short num3 = num;
				this.cnvPerNonASTROCallUnlimitedCalling_A9597.Value = value;
			}
		}

		// Token: 0x1700647A RID: 25722
		// (get) Token: 0x0600C850 RID: 51280 RVA: 0x00BB44C4 File Offset: 0x00BB26C4
		// (set) Token: 0x0600C851 RID: 51281 RVA: 0x00BB4578 File Offset: 0x00BB2778
		public bool CnvPerNonASTROCallUnlimitedCalling_A9597_Applicable
		{
			get
			{
				short num = (short)2058331345;
				short num2 = num;
				num = (short)261989585;
				switch (num2 == num)
				{
				}
				num = (short)986513408;
				if (num != 0)
				{
				}
				num = (short)867893249;
				if (num != 0)
				{
				}
				num = (short)985268224;
				short num3 = num;
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.Applicable;
			}
			set
			{
				short num = (short)1842937857;
				if (num != 0)
				{
				}
				num = (short)304670720;
				short num2 = num;
				num = (short)1592387584;
				switch (num2 == num)
				{
				}
				num = (short)559153152;
				if (num != 0)
				{
				}
				num = (short)1829109760;
				short num3 = num;
				this.cnvPerNonASTROCallUnlimitedCalling_A9597.Applicable = value;
			}
		}

		// Token: 0x1700647B RID: 25723
		// (get) Token: 0x0600C852 RID: 51282 RVA: 0x00BB462C File Offset: 0x00BB282C
		// (set) Token: 0x0600C853 RID: 51283 RVA: 0x00BB46E0 File Offset: 0x00BB28E0
		public bool CnvPerNonASTROCallUnlimitedCalling_A9597_Valid
		{
			get
			{
				short num = (short)93949429;
				short num2 = num;
				num = (short)306482677;
				switch (num2 == num)
				{
				}
				num = (short)1307181057;
				if (num != 0)
				{
				}
				num = (short)1557266432;
				if (num != 0)
				{
				}
				num = (short)780533760;
				short num3 = num;
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.Valid;
			}
			set
			{
				short num = (short)1684733050;
				short num2 = num;
				num = (short)1611005050;
				switch (num2 == num)
				{
				}
				num = (short)682164225;
				if (num != 0)
				{
				}
				num = (short)1053753344;
				if (num != 0)
				{
				}
				num = (short)771162112;
				short num3 = num;
				this.cnvPerNonASTROCallUnlimitedCalling_A9597.Valid = value;
			}
		}

		// Token: 0x1700647C RID: 25724
		// (get) Token: 0x0600C854 RID: 51284 RVA: 0x00BB4798 File Offset: 0x00BB2998
		// (set) Token: 0x0600C855 RID: 51285 RVA: 0x00BB4850 File Offset: 0x00BB2A50
		public bool CnvPerNonASTROCallUnlimitedCalling_A9597_Visible
		{
			get
			{
				short num = (short)2032173850;
				short num2 = num;
				num = (short)536445722;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1335099392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490223104;
				if (num != 0)
				{
				}
				num = (short)110755841;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.Visible;
			}
			set
			{
				short num = (short)971242272;
				short num2 = num;
				num = (short)183565088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1469186048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1507459073;
				if (num != 0)
				{
				}
				num = (short)1729167360;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnlimitedCalling_A9597.Visible = value;
			}
		}

		// Token: 0x1700647D RID: 25725
		// (get) Token: 0x0600C856 RID: 51286 RVA: 0x00BB4904 File Offset: 0x00BB2B04
		// (set) Token: 0x0600C857 RID: 51287 RVA: 0x00BB49BC File Offset: 0x00BB2BBC
		public bool CnvPerNonASTROCallUnlimitedCalling_A9597_Editable
		{
			get
			{
				short num = (short)1197146113;
				if (num != 0)
				{
				}
				num = (short)1657667584;
				short num2 = num;
				num = (short)1979821166;
				short num3 = num;
				num = (short)417901678;
				switch (num3 == num)
				{
				}
				num = (short)1095237632;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.Editable;
			}
			set
			{
				short num = (short)1688535041;
				if (num != 0)
				{
				}
				num = (short)1566769152;
				short num2 = num;
				num = (short)711669949;
				short num3 = num;
				num = (short)1900820669;
				switch (num3 == num)
				{
				}
				num = (short)1927086080;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnlimitedCalling_A9597.Editable = value;
			}
		}

		// Token: 0x1700647E RID: 25726
		// (get) Token: 0x0600C858 RID: 51288 RVA: 0x00BB4A70 File Offset: 0x00BB2C70
		internal string CnvPerNonASTROCallUnlimitedCalling_A9597_UILabel
		{
			get
			{
				short num = (short)187890753;
				short num2 = num;
				num = (short)434043969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1561853952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502857729;
				if (num != 0)
				{
				}
				num = (short)974782464;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.UIName;
			}
		}

		// Token: 0x1700647F RID: 25727
		// (get) Token: 0x0600C859 RID: 51289 RVA: 0x00BB4B28 File Offset: 0x00BB2D28
		// (set) Token: 0x0600C85A RID: 51290 RVA: 0x00BB4BDC File Offset: 0x00BB2DDC
		internal bool CnvPerNonASTROCallUnlimitedCalling_A9597_HiddenStatic
		{
			get
			{
				short num = (short)1343482847;
				short num2 = num;
				num = (short)1511386079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)698220544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2071461889;
				if (num != 0)
				{
				}
				num = (short)754122752;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.HiddenStatic;
			}
			set
			{
				short num = (short)1899459906;
				short num2 = num;
				num = (short)160986434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1261830144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51445760;
				if (num != 0)
				{
				}
				num = (short)783679489;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnlimitedCalling_A9597.HiddenStatic = value;
			}
		}

		// Token: 0x17006480 RID: 25728
		// (get) Token: 0x0600C85B RID: 51291 RVA: 0x00BB4C94 File Offset: 0x00BB2E94
		// (set) Token: 0x0600C85C RID: 51292 RVA: 0x00BB4D4C File Offset: 0x00BB2F4C
		internal bool CnvPerNonASTROCallUnlimitedCalling_A9597_HiddenDynamic
		{
			get
			{
				short num = (short)1386731214;
				short num2 = num;
				num = (short)1600181966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1500184576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)320667649;
				if (num != 0)
				{
				}
				num = (short)936837120;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597.HiddenDynamic;
			}
			set
			{
				short num = (short)2038323984;
				short num2 = num;
				num = (short)23812880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)356909056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)804978688;
				if (num != 0)
				{
				}
				num = (short)1526792193;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnlimitedCalling_A9597.HiddenDynamic = value;
			}
		}

		// Token: 0x17006481 RID: 25729
		// (get) Token: 0x0600C85D RID: 51293 RVA: 0x00BB4E04 File Offset: 0x00BB3004
		public bool CnvPerNonASTROCallUnlimitedCalling_A9597_HasDiffs
		{
			get
			{
				short num = (short)450840677;
				short num2 = num;
				num = (short)1066813541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482293248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)316145665;
				if (num != 0)
				{
				}
				num = (short)1792081920;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnlimitedCalling_A9597._HasDiffs;
			}
		}

		// Token: 0x17006482 RID: 25730
		// (get) Token: 0x0600C85E RID: 51294 RVA: 0x00BB4EB8 File Offset: 0x00BB30B8
		// (set) Token: 0x0600C85F RID: 51295 RVA: 0x00BB4F6C File Offset: 0x00BB316C
		public int CnvPerNonASTROCallUnmuteType_A9601Value
		{
			get
			{
				short num = (short)656304190;
				short num2 = num;
				num = (short)2047699006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1693188096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)950665217;
				if (num != 0)
				{
				}
				num = (short)375259136;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.Value;
			}
			set
			{
				short num = (short)2091676081;
				short num2 = num;
				num = (short)2057925041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1599864832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770179073;
				if (num != 0)
				{
				}
				num = (short)974848000;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnmuteType_A9601.Value = value;
			}
		}

		// Token: 0x17006483 RID: 25731
		// (get) Token: 0x0600C860 RID: 51296 RVA: 0x00BB5020 File Offset: 0x00BB3220
		// (set) Token: 0x0600C861 RID: 51297 RVA: 0x00BB50D8 File Offset: 0x00BB32D8
		public string CnvPerNonASTROCallUnmuteType_A9601_UIValue
		{
			get
			{
				short num = (short)285558786;
				short num2 = num;
				num = (short)1687111682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2077163520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1040777216;
				if (num != 0)
				{
				}
				num = (short)1970339841;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.UIValue;
			}
			set
			{
				short num = (short)1305873465;
				short num2 = num;
				num = (short)1896746041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)313131008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688338432;
				if (num != 0)
				{
				}
				num = (short)1186332673;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnmuteType_A9601.UIValue = value;
			}
		}

		// Token: 0x17006484 RID: 25732
		// (get) Token: 0x0600C862 RID: 51298 RVA: 0x00BB5190 File Offset: 0x00BB3390
		public global::AcpBusinessLayer.AcpListField CnvPerNonASTROCallUnmuteType_A9601
		{
			get
			{
				short num = (short)965465480;
				short num2 = num;
				num = (short)2129515912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1015414784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79495169;
				if (num != 0)
				{
				}
				num = (short)1547304960;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601;
			}
		}

		// Token: 0x17006485 RID: 25733
		// (get) Token: 0x0600C863 RID: 51299 RVA: 0x00BB5240 File Offset: 0x00BB3440
		// (set) Token: 0x0600C864 RID: 51300 RVA: 0x00BB52F4 File Offset: 0x00BB34F4
		public bool CnvPerNonASTROCallUnmuteType_A9601_Applicable
		{
			get
			{
				short num = (short)52297729;
				if (num != 0)
				{
				}
				num = (short)1444216832;
				short num2 = num;
				num = (short)1728716350;
				short num3 = num;
				num = (short)1930239550;
				switch (num3 == num)
				{
				}
				num = (short)1775894528;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.Applicable;
			}
			set
			{
				short num = (short)2064220052;
				short num2 = num;
				num = (short)645955476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1861550080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)101842945;
				if (num != 0)
				{
				}
				num = (short)1740898304;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnmuteType_A9601.Applicable = value;
			}
		}

		// Token: 0x17006486 RID: 25734
		// (get) Token: 0x0600C865 RID: 51301 RVA: 0x00BB53A8 File Offset: 0x00BB35A8
		// (set) Token: 0x0600C866 RID: 51302 RVA: 0x00BB545C File Offset: 0x00BB365C
		public bool CnvPerNonASTROCallUnmuteType_A9601_Valid
		{
			get
			{
				short num = (short)1804243731;
				short num2 = num;
				num = (short)956011283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)56819712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)70451200;
				if (num != 0)
				{
				}
				num = (short)1712193537;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.Valid;
			}
			set
			{
				short num = (short)1291190273;
				if (num != 0)
				{
				}
				num = (short)144310272;
				short num2 = num;
				num = (short)1687687034;
				short num3 = num;
				num = (short)175509370;
				switch (num3 == num)
				{
				}
				num = (short)1507852288;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnmuteType_A9601.Valid = value;
			}
		}

		// Token: 0x17006487 RID: 25735
		// (get) Token: 0x0600C867 RID: 51303 RVA: 0x00BB5510 File Offset: 0x00BB3710
		// (set) Token: 0x0600C868 RID: 51304 RVA: 0x00BB55CC File Offset: 0x00BB37CC
		public bool CnvPerNonASTROCallUnmuteType_A9601_Visible
		{
			get
			{
				short num = (short)991497437;
				short num2 = num;
				num = (short)1104350429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1434583040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)190382080;
				if (num != 0)
				{
				}
				num = (short)1098973185;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.Visible;
			}
			set
			{
				short num = (short)1592643654;
				short num2 = num;
				num = (short)200593478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1284243456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770113537;
				if (num != 0)
				{
				}
				num = (short)753008640;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnmuteType_A9601.Visible = value;
			}
		}

		// Token: 0x17006488 RID: 25736
		// (get) Token: 0x0600C869 RID: 51305 RVA: 0x00BB5680 File Offset: 0x00BB3880
		// (set) Token: 0x0600C86A RID: 51306 RVA: 0x00BB5734 File Offset: 0x00BB3934
		public bool CnvPerNonASTROCallUnmuteType_A9601_Editable
		{
			get
			{
				short num = (short)222368674;
				short num2 = num;
				num = (short)878056354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1018429440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370737153;
				if (num != 0)
				{
				}
				num = (short)936706048;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.Editable;
			}
			set
			{
				short num = (short)1241439810;
				short num2 = num;
				num = (short)1215028802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)911933440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71892993;
				if (num != 0)
				{
				}
				num = (short)1707081728;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnmuteType_A9601.Editable = value;
			}
		}

		// Token: 0x17006489 RID: 25737
		// (get) Token: 0x0600C86B RID: 51307 RVA: 0x00BB57E8 File Offset: 0x00BB39E8
		internal string CnvPerNonASTROCallUnmuteType_A9601_UILabel
		{
			get
			{
				short num = (short)1239891607;
				short num2 = num;
				num = (short)85606039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618659840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1256718337;
				if (num != 0)
				{
				}
				num = (short)627572736;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.UIName;
			}
		}

		// Token: 0x1700648A RID: 25738
		// (get) Token: 0x0600C86C RID: 51308 RVA: 0x00BB589C File Offset: 0x00BB3A9C
		// (set) Token: 0x0600C86D RID: 51309 RVA: 0x00BB5950 File Offset: 0x00BB3B50
		internal bool CnvPerNonASTROCallUnmuteType_A9601_HiddenStatic
		{
			get
			{
				short num = (short)1915636721;
				short num2 = num;
				num = (short)1018121201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1476722688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195559425;
				if (num != 0)
				{
				}
				num = (short)917110784;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.HiddenStatic;
			}
			set
			{
				short num = (short)1387078112;
				short num2 = num;
				num = (short)54075872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1579220992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1963327488;
				if (num != 0)
				{
				}
				num = (short)412876801;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnmuteType_A9601.HiddenStatic = value;
			}
		}

		// Token: 0x1700648B RID: 25739
		// (get) Token: 0x0600C86E RID: 51310 RVA: 0x00BB5A08 File Offset: 0x00BB3C08
		// (set) Token: 0x0600C86F RID: 51311 RVA: 0x00BB5ABC File Offset: 0x00BB3CBC
		internal bool CnvPerNonASTROCallUnmuteType_A9601_HiddenDynamic
		{
			get
			{
				short num = (short)2047046877;
				short num2 = num;
				num = (short)2066576605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1863450624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056650753;
				if (num != 0)
				{
				}
				num = (short)792985600;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601.HiddenDynamic;
			}
			set
			{
				short num = (short)1204309253;
				short num2 = num;
				num = (short)1205882117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1995505664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)812843009;
				if (num != 0)
				{
				}
				num = (short)1267662848;
				if (num != 0)
				{
				}
				this.cnvPerNonASTROCallUnmuteType_A9601.HiddenDynamic = value;
			}
		}

		// Token: 0x1700648C RID: 25740
		// (get) Token: 0x0600C870 RID: 51312 RVA: 0x00BB5B70 File Offset: 0x00BB3D70
		public bool CnvPerNonASTROCallUnmuteType_A9601_HasDiffs
		{
			get
			{
				short num = (short)520349913;
				short num2 = num;
				num = (short)665446617;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1945042944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717815809;
				if (num != 0)
				{
				}
				num = (short)181927936;
				if (num != 0)
				{
				}
				return this.cnvPerNonASTROCallUnmuteType_A9601._HasDiffs;
			}
		}

		// Token: 0x1700648D RID: 25741
		// (get) Token: 0x0600C871 RID: 51313 RVA: 0x00BB5C24 File Offset: 0x00BB3E24
		// (set) Token: 0x0600C872 RID: 51314 RVA: 0x00BB5CD8 File Offset: 0x00BB3ED8
		public int CnvPerLabtoolAnalogHotListItemID_A21918Value
		{
			get
			{
				short num = (short)2097786761;
				short num2 = num;
				num = (short)1798549385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135017984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1977024512;
				if (num != 0)
				{
				}
				num = (short)1816002561;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.Value;
			}
			set
			{
				short num = (short)1184931672;
				short num2 = num;
				num = (short)1235459928;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366149632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1861615617;
				if (num != 0)
				{
				}
				num = (short)1286275072;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAnalogHotListItemID_A21918.Value = value;
			}
		}

		// Token: 0x1700648E RID: 25742
		// (get) Token: 0x0600C873 RID: 51315 RVA: 0x00BB5D8C File Offset: 0x00BB3F8C
		// (set) Token: 0x0600C874 RID: 51316 RVA: 0x00BB5E40 File Offset: 0x00BB4040
		public string CnvPerLabtoolAnalogHotListItemID_A21918_UIValue
		{
			get
			{
				short num = (short)539656453;
				short num2 = num;
				num = (short)1109229829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)491913216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266286592;
				if (num != 0)
				{
				}
				num = (short)1536819201;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.UIValue;
			}
			set
			{
				short num = (short)249298945;
				if (num != 0)
				{
				}
				num = (short)1246625792;
				short num2 = num;
				num = (short)2099373419;
				short num3 = num;
				num = (short)1052108139;
				switch (num3 == num)
				{
				}
				num = (short)1124139008;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAnalogHotListItemID_A21918.UIValue = value;
			}
		}

		// Token: 0x1700648F RID: 25743
		// (get) Token: 0x0600C875 RID: 51317 RVA: 0x00BB5EF4 File Offset: 0x00BB40F4
		public global::AcpBusinessLayer.AcpRecRefField CnvPerLabtoolAnalogHotListItemID_A21918
		{
			get
			{
				short num = (short)962775652;
				short num2 = num;
				num = (short)60017252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1276575744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2060189696;
				if (num != 0)
				{
				}
				num = (short)106627073;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918;
			}
		}

		// Token: 0x17006490 RID: 25744
		// (get) Token: 0x0600C876 RID: 51318 RVA: 0x00BB5FA4 File Offset: 0x00BB41A4
		// (set) Token: 0x0600C877 RID: 51319 RVA: 0x00BB6058 File Offset: 0x00BB4258
		public bool CnvPerLabtoolAnalogHotListItemID_A21918_Applicable
		{
			get
			{
				short num = (short)1940928938;
				short num2 = num;
				num = (short)614218154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)962527232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)218562561;
				if (num != 0)
				{
				}
				num = (short)472317952;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.Applicable;
			}
			set
			{
				short num = (short)959827229;
				short num2 = num;
				num = (short)1394330909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1621032960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)797179904;
				if (num != 0)
				{
				}
				num = (short)1410007041;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAnalogHotListItemID_A21918.Applicable = value;
			}
		}

		// Token: 0x17006491 RID: 25745
		// (get) Token: 0x0600C878 RID: 51320 RVA: 0x00BB6110 File Offset: 0x00BB4310
		// (set) Token: 0x0600C879 RID: 51321 RVA: 0x00BB61C4 File Offset: 0x00BB43C4
		public bool CnvPerLabtoolAnalogHotListItemID_A21918_Valid
		{
			get
			{
				short num = (short)1412155598;
				short num2 = num;
				num = (short)98158798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1530527744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)656277505;
				if (num != 0)
				{
				}
				num = (short)1592000512;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.Valid;
			}
			set
			{
				short num = (short)270027528;
				short num2 = num;
				num = (short)245320456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1473380352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1676017665;
				if (num != 0)
				{
				}
				num = (short)1430716416;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAnalogHotListItemID_A21918.Valid = value;
			}
		}

		// Token: 0x17006492 RID: 25746
		// (get) Token: 0x0600C87A RID: 51322 RVA: 0x00BB6278 File Offset: 0x00BB4478
		// (set) Token: 0x0600C87B RID: 51323 RVA: 0x00BB632C File Offset: 0x00BB452C
		public bool CnvPerLabtoolAnalogHotListItemID_A21918_Visible
		{
			get
			{
				short num = (short)922484737;
				if (num != 0)
				{
				}
				num = (short)1818099712;
				short num2 = num;
				num = (short)1100690789;
				short num3 = num;
				num = (short)860370277;
				switch (num3 == num)
				{
				}
				num = (short)461832192;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.Visible;
			}
			set
			{
				short num = (short)2003385284;
				short num2 = num;
				num = (short)813579204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1795948544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)484245505;
				if (num != 0)
				{
				}
				num = (short)1922367488;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAnalogHotListItemID_A21918.Visible = value;
			}
		}

		// Token: 0x17006493 RID: 25747
		// (get) Token: 0x0600C87C RID: 51324 RVA: 0x00BB63E0 File Offset: 0x00BB45E0
		// (set) Token: 0x0600C87D RID: 51325 RVA: 0x00BB6498 File Offset: 0x00BB4698
		public bool CnvPerLabtoolAnalogHotListItemID_A21918_Editable
		{
			get
			{
				short num = (short)1604551500;
				short num2 = num;
				num = (short)955286348;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1161494528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)395182081;
				if (num != 0)
				{
				}
				num = (short)503578624;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.Editable;
			}
			set
			{
				short num = (short)772902678;
				short num2 = num;
				num = (short)1115524886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2104688640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546177024;
				if (num != 0)
				{
				}
				num = (short)1360199681;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAnalogHotListItemID_A21918.Editable = value;
			}
		}

		// Token: 0x17006494 RID: 25748
		// (get) Token: 0x0600C87E RID: 51326 RVA: 0x00BB654C File Offset: 0x00BB474C
		internal string CnvPerLabtoolAnalogHotListItemID_A21918_UILabel
		{
			get
			{
				short num = (short)173858525;
				short num2 = num;
				num = (short)1072684765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)303431680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1153171456;
				if (num != 0)
				{
				}
				num = (short)1775632385;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.UIName;
			}
		}

		// Token: 0x17006495 RID: 25749
		// (get) Token: 0x0600C87F RID: 51327 RVA: 0x00BB6600 File Offset: 0x00BB4800
		// (set) Token: 0x0600C880 RID: 51328 RVA: 0x00BB66B8 File Offset: 0x00BB48B8
		internal bool CnvPerLabtoolAnalogHotListItemID_A21918_HiddenStatic
		{
			get
			{
				short num = (short)353549520;
				short num2 = num;
				num = (short)1005108432;
				switch (num2 == num)
				{
				default:
				{
					num = (short)274006016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)654245889;
				if (num != 0)
				{
				}
				num = (short)1516437504;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.HiddenStatic;
			}
			set
			{
				short num = (short)1591738369;
				if (num != 0)
				{
				}
				num = (short)288948224;
				short num2 = num;
				num = (short)606093491;
				short num3 = num;
				num = (short)294928563;
				switch (num3 == num)
				{
				}
				num = (short)1127088128;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAnalogHotListItemID_A21918.HiddenStatic = value;
			}
		}

		// Token: 0x17006496 RID: 25750
		// (get) Token: 0x0600C881 RID: 51329 RVA: 0x00BB676C File Offset: 0x00BB496C
		// (set) Token: 0x0600C882 RID: 51330 RVA: 0x00BB6820 File Offset: 0x00BB4A20
		internal bool CnvPerLabtoolAnalogHotListItemID_A21918_HiddenDynamic
		{
			get
			{
				short num = (short)873217426;
				short num2 = num;
				num = (short)229391762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80609280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)213647360;
				if (num != 0)
				{
				}
				num = (short)1955659777;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918.HiddenDynamic;
			}
			set
			{
				short num = (short)2107527838;
				short num2 = num;
				num = (short)1644384926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)619773952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1599209473;
				if (num != 0)
				{
				}
				num = (short)2090008576;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAnalogHotListItemID_A21918.HiddenDynamic = value;
			}
		}

		// Token: 0x17006497 RID: 25751
		// (get) Token: 0x0600C883 RID: 51331 RVA: 0x00BB68D4 File Offset: 0x00BB4AD4
		public bool CnvPerLabtoolAnalogHotListItemID_A21918_HasDiffs
		{
			get
			{
				short num = (short)705316032;
				short num2 = num;
				num = (short)1920877760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)163119104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1082195969;
				if (num != 0)
				{
				}
				num = (short)1437859840;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAnalogHotListItemID_A21918._HasDiffs;
			}
		}

		// Token: 0x17006498 RID: 25752
		// (get) Token: 0x0600C884 RID: 51332 RVA: 0x00BB6988 File Offset: 0x00BB4B88
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1137711447;
				short num2 = num;
				num = (short)736041303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)166002688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1796014081;
				if (num != 0)
				{
				}
				num = (short)176488448;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x00BB6A48 File Offset: 0x00BB4C48
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)956543509;
					short num3 = num2;
					num2 = (short)2065412629;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_139;
					case 1:
						break;
					default:
					{
						num2 = (short)1370292224;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)969605120;
					if (num2 != 0)
					{
					}
					num2 = (short)1975713794;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1944256516;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)912785409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)564330496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				case 4:
					goto IL_FA;
				}
				goto IL_24;
			}
			IL_FA:
			IL_139:
			num2 = (short)575930369;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1876033539;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040064B5 RID: 25781
		private global::AcpBusinessLayer.AcpField<bool> cnvPerNonASTROCallAutoSelectCallTransmit_A7520;

		// Token: 0x040064B6 RID: 25782
		private global::AcpBusinessLayer.AcpListField cnvPerNonASTROCallCallAlertRxTx_A7588;

		// Token: 0x040064B7 RID: 25783
		private global::AcpBusinessLayer.AcpField<bool> cnvPerNonASTROCallInCallUserAlertEnable_A8252;

		// Token: 0x040064B8 RID: 25784
		private global::AcpBusinessLayer.AcpListField cnvPerNonASTROCallRTTButtonAccess_A8493;

		// Token: 0x040064B9 RID: 25785
		private global::AcpBusinessLayer.AcpListField cnvPerNonASTROCallSelectiveCallRxTx_A9116;

		// Token: 0x040064BA RID: 25786
		private global::AcpBusinessLayer.AcpField<bool> cnvPerNonASTROCallUnlimitedCalling_A9597;

		// Token: 0x040064BB RID: 25787
		private global::AcpBusinessLayer.AcpListField cnvPerNonASTROCallUnmuteType_A9601;

		// Token: 0x040064BC RID: 25788
		private global::AcpBusinessLayer.AcpRecRefField cnvPerLabtoolAnalogHotListItemID_A21918;
	}
}
