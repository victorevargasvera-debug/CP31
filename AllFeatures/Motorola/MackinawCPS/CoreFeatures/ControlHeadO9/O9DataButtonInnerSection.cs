using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000372 RID: 882
	[global::System.Serializable]
	public class O9DataButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008286 RID: 33414 RVA: 0x0079902C File Offset: 0x0079722C
		public O9DataButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x00799048 File Offset: 0x00797248
		protected O9DataButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x00799060 File Offset: 0x00797260
		public override void Init()
		{
			int a_ = 9;
			short num = (short)1183757693;
			short num2 = num;
			num = (short)160085373;
			switch (num2 == num)
			{
			}
			num = (short)1064566785;
			if (num != 0)
			{
			}
			num = (short)814415872;
			if (num != 0)
			{
			}
			num = (short)2102001664;
			short num3 = num;
			this.radErgCtrlHeadO9DataButtonName_A36523 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ퇧껩跫髭釯냱至苵賷闹鋻냽懿漁愃夅䤇㤉㨋㬍∏ℑ", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgCtrlHeadO9DataButtonName_A36523.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO9DataButtonName_A36523.DataTransferOrder = -1;
			this.radErgCtrlHeadO9DataButtonTrkFeature_A36526 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DataButtonTrkFeature_A36526LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DataButtonTrkFeature_A36526LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ퇧껩跫髭釯냱至苵賷闹鋻꫽狿椁䈃挅椇縉礋簍甏䴑唓┕⸗⼙⸛⠝", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DataButtonTrkFeature_A36526LovStrs);
			this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.DataTransferOrder = 1;
			this.radErgCtrlHeadO9DataButtonTrkBCO_A36527 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DataButtonTrkBCO_A36527LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DataButtonTrkBCO_A36527LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ퇧껩跫髭釯냱至苵賷闹鋻꫽狿椁䘃䔅䜇唉䴋㴍☏✑☓ℕ", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DataButtonTrkBCO_A36527LovStrs);
			this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.IgnoreOnCompare = true;
			this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.DataTransferOrder = -1;
			this.radErgCtrlHeadO9DataButtonCnvFeature_A36528 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DataButtonCnvFeature_A36528LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DataButtonCnvFeature_A36528LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ퇧껩跫髭釯냱至苵賷闹鋻뷽滿琁䈃挅椇縉礋簍甏䴑唓┕⸗⼙⸛☝", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DataButtonCnvFeature_A36528LovStrs);
			this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.DataTransferOrder = 3;
			this.radErgCtrlHeadO9DataButtonCnvBCO_A36529 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DataButtonCnvBCO_A36529LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DataButtonCnvBCO_A36529LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ퇧껩跫髭釯냱至苵賷闹鋻뷽滿琁䘃䔅䜇唉䴋㴍☏✑☓⼕", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DataButtonCnvBCO_A36529LovStrs);
			this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.IgnoreOnCompare = true;
			this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.DataTransferOrder = -1;
			this.cHO9DataButtonConvIndex_A41414 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("觉蓋臍雑뗓ꋕ맗飙꧛ꫝ铟跡諣ꗥ蟧蓩髫꟭黯雱釳軵ꟷ믹죻쿽㓿㌁〃", a_), global::CommonResources.AcgResources.ID_CONVENTIONALINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO9DataButtonConvIndex_A41414.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9DataButtonConvIndex_A41414.DataTransferOrder = 5;
			this.cHO9DataButtonTrkIndex_A41416 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("觉蓋臍雑뗓ꋕ맗飙꧛ꫝ铟跡諣닥髧臩ꗫ胭铯韱賳꧵맷컹췻쫽ㇿ㐁", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO9DataButtonTrkIndex_A41416.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9DataButtonTrkIndex_A41416.DataTransferOrder = 7;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏雓ꏕ곗껙돛냝", a_);
			base.Id = 10608;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON_1;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x00799374 File Offset: 0x00797574
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)294387729;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_64E;
				case 1:
					num = (short)848429070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.radErgCtrlHeadO9DataButtonTrkBCO_A36527 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DataButtonTrkBCO_A36527LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DataButtonTrkBCO_A36527LovStrs), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸꿺迼链䌀䀂䨄堆䠈㠊㬌㨎⌐␒", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DataButtonTrkBCO_A36527LovStrs);
					this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.IgnoreOnCompare = true;
					this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.DataTransferOrder = -1;
					num = (short)1724252160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_4C5;
				case 4:
				{
					num = (short)229141661;
					short num3 = num;
					num = (short)943352989;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69A;
					default:
						num = (short)1638401;
						if (num != 0)
						{
						}
						num = (short)1281294336;
						if (num != 0)
						{
						}
						this.radErgCtrlHeadO9DataButtonName_A36523 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸뗺鳼鋾搀専䐄㐆㼈㸊㼌㰎", a_), global::CommonResources.AcgResources.ID_NAME, 100);
						this.radErgCtrlHeadO9DataButtonName_A36523.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radErgCtrlHeadO9DataButtonName_A36523.DataTransferOrder = -1;
						num = (short)1219493897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸뗺鳼鋾搀専䐄㐆㼈㸊㼌㰎", a_)))
					{
						num = (short)1127284740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_479;
				case 6:
					this.cHO9DataButtonTrkIndex_A41416 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆臈蓊诎냐꟒듔闖곘꿚꧜냞迠럢韤賦ꃨ藪觬諮觰곲듴쏶죸쿺쳼짾", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO9DataButtonTrkIndex_A41416.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9DataButtonTrkIndex_A41416.DataTransferOrder = 7;
					num = (short)746717202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸룺鏼觾䜀昂搄猆簈礊栌倎倐‒⌔∖⬘⌚", a_)))
					{
						num = (short)251133960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_322;
				case 8:
					this.radErgCtrlHeadO9DataButtonCnvFeature_A36528 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DataButtonCnvFeature_A36528LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DataButtonCnvFeature_A36528LovStrs), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸룺鏼觾䜀昂搄猆簈礊栌倎倐‒⌔∖⬘⌚", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DataButtonCnvFeature_A36528LovStrs);
					this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.DataTransferOrder = 3;
					num = (short)494993418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_479;
				case 10:
					goto IL_322;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆臈蓊诎냐꟒듔闖곘꿚꧜냞迠ꃢ諤触鿨ꋪ菬诮铰诲ꫴ뛶췸쫺짼컾㔀", a_)))
					{
						num = (short)1874264088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C5;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸꿺迼链䜀昂搄猆簈礊栌倎倐‒⌔∖⬘ⴚ", a_)))
					{
						num = (short)664666128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_603;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆臈蓊诎냐꟒듔闖곘꿚꧜냞迠럢韤賦ꃨ藪觬諮觰곲듴쏶죸쿺쳼짾", a_)))
					{
						num = (short)1431109638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69A;
				case 14:
					if (producerFields != null)
					{
						num = (short)1416167444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69A;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸꿺迼链䌀䀂䨄堆䠈㠊㬌㨎⌐␒", a_)))
					{
						num = (short)974651394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64E;
				case 16:
					this.radErgCtrlHeadO9DataButtonTrkFeature_A36526 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DataButtonTrkFeature_A36526LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DataButtonTrkFeature_A36526LovStrs), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸꿺迼链䜀昂搄猆簈礊栌倎倐‒⌔∖⬘ⴚ", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DataButtonTrkFeature_A36526LovStrs);
					this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.DataTransferOrder = 1;
					num = (short)574423062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 18:
					goto IL_3FC;
				case 19:
					goto IL_511;
				case 20:
					num = (short)1119289349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸룺鏼觾䌀䀂䨄堆䠈㠊㬌㨎⌐⨒", a_)))
					{
						num = (short)944635927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_511;
				case 22:
					goto IL_603;
				case 23:
					this.radErgCtrlHeadO9DataButtonCnvBCO_A36529 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgCtrlHeadO9DataButtonCnvBCO_A36529LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgCtrlHeadO9DataButtonCnvBCO_A36529LovStrs), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐郒ꇔꗖ뗘鏚룜뻞藠곢\udce4ꏦ裨鿪賬귮蓰蟲致飶韸룺鏼觾䌀䀂䨄堆䠈㠊㬌㨎⌐⨒", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgCtrlHeadO9DataButtonCnvBCO_A36529LovStrs);
					this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.IgnoreOnCompare = true;
					this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.DataTransferOrder = -1;
					num = (short)2130116627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.cHO9DataButtonConvIndex_A41414 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆臈蓊诎냐꟒듔闖곘꿚꧜냞迠ꃢ諤触鿨ꋪ菬诮铰诲ꫴ뛶췸쫺짼컾㔀", a_), global::CommonResources.AcgResources.ID_CONVENTIONALINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO9DataButtonConvIndex_A41414.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9DataButtonConvIndex_A41414.DataTransferOrder = 5;
					num = (short)307494915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_91:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1412497409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_322:
				num = (short)1439105024;
				short num4 = num;
				num = (short)736165909;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_479:
				num = (short)1813839884;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C5:
				num = (short)638582797;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_511:
				num = (short)1958215691;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_603:
				num = (short)1822949391;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64E:
				num = (short)1770323975;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3FC:
			IL_69A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鏐ꛒꇔꏖ뛘뗚", a_);
			base.Id = 10608;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON_1;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x00799A4C File Offset: 0x00797C4C
		public override void PopulateReferences()
		{
			short num = (short)543925894;
			short num2 = num;
			num = (short)1421911686;
			switch (num2 == num)
			{
			}
			num = (short)2066415616;
			if (num != 0)
			{
			}
			num = (short)1722744833;
			if (num != 0)
			{
			}
			num = (short)931921920;
			short num3 = num;
			this.cHO9DataButtonConvIndex_A41414.SetRecset(this.a(4008));
			this.cHO9DataButtonTrkIndex_A41416.SetRecset(this.a(4008));
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x00799B20 File Offset: 0x00797D20
		public override void DropReferences()
		{
			short num = (short)987871026;
			short num2 = num;
			num = (short)1499379506;
			switch (num2 == num)
			{
			}
			num = (short)2145189888;
			if (num != 0)
			{
			}
			num = (short)279642113;
			if (num != 0)
			{
			}
			num = (short)1461911552;
			short num3 = num;
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x00799BC8 File Offset: 0x00797DC8
		public override void SetConstraints()
		{
			short num = (short)1165426689;
			if (num != 0)
			{
			}
			num = (short)504807486;
			short num2 = num;
			num = (short)1253687358;
			switch (num2 == num)
			{
			}
			num = (short)253100032;
			if (num != 0)
			{
			}
			num = (short)1067057152;
			short num3 = num;
			this.radErgCtrlHeadO9DataButtonName_A36523.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.conDataBtnTrkFeatureValid);
			this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConSyncTrkDataBtnFeature);
			this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.conDataBtnConvFeatureValid);
			this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConSyncCnvDataBtnFeature);
			this.cHO9DataButtonConvIndex_A41414.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConO9DataButtonConvIndexApplicable);
			this.cHO9DataButtonConvIndex_A41414.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConDataButtonIndexValid);
			this.cHO9DataButtonConvIndex_A41414.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetIfDataCnvIndexChanged);
			this.cHO9DataButtonTrkIndex_A41416.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConO9DataButtonTrkIndexApplicable);
			this.cHO9DataButtonTrkIndex_A41416.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConDataButtonIndexValid);
			this.cHO9DataButtonTrkIndex_A41416.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetIfDataTrkIndexChanged);
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x00799DA0 File Offset: 0x00797FA0
		public override void SetupDependencies()
		{
			short num = (short)1676446952;
			short num2 = num;
			num = (short)1313311976;
			switch (num2 == num)
			{
			}
			num = (short)1443954689;
			if (num != 0)
			{
			}
			num = (short)773521408;
			if (num != 0)
			{
			}
			num = (short)1973551104;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgCtrlHeadO9DataButtonTrkFeature_A36526);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgCtrlHeadO9DataButtonCnvFeature_A36528);
			this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.AddDependentObject(this.cHO9DataButtonConvIndex_A41414);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9DataButtonConvIndex_A41414);
			this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.AddDependentObject(this.cHO9DataButtonTrkIndex_A41416);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9DataButtonTrkIndex_A41416);
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x0600828E RID: 33422 RVA: 0x00799EE0 File Offset: 0x007980E0
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForCHO9DataButtonConvIndex_A41414
		{
			get
			{
				short num = (short)491997447;
				short num2 = num;
				num = (short)1887586567;
				switch (num2 == num)
				{
				}
				num = (short)1900740609;
				if (num != 0)
				{
				}
				num = (short)919011328;
				if (num != 0)
				{
				}
				num = (short)252182528;
				short num3 = num;
				return this.cHO9DataButtonConvIndex_A41414.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x0600828F RID: 33423 RVA: 0x00799F98 File Offset: 0x00798198
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForCHO9DataButtonTrkIndex_A41416
		{
			get
			{
				short num = (short)277236647;
				short num2 = num;
				num = (short)208358311;
				switch (num2 == num)
				{
				}
				num = (short)119275521;
				if (num != 0)
				{
				}
				num = (short)2014248960;
				if (num != 0)
				{
				}
				num = (short)1860173824;
				short num3 = num;
				return this.cHO9DataButtonTrkIndex_A41416.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x06008290 RID: 33424 RVA: 0x0079A054 File Offset: 0x00798254
		public bool HasDiffs
		{
			get
			{
				short num = (short)1365513068;
				short num2 = num;
				num = (short)465638252;
				switch (num2 == num)
				{
				}
				num = (short)553385984;
				if (num != 0)
				{
				}
				num = (short)881786881;
				if (num != 0)
				{
				}
				num = (short)364511232;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x06008291 RID: 33425 RVA: 0x0079A104 File Offset: 0x00798304
		// (set) Token: 0x06008292 RID: 33426 RVA: 0x0079A1B8 File Offset: 0x007983B8
		public string RadErgCtrlHeadO9DataButtonName_A36523Value
		{
			get
			{
				short num = (short)609502008;
				short num2 = num;
				num = (short)1305166648;
				switch (num2 == num)
				{
				}
				num = (short)767950848;
				if (num != 0)
				{
				}
				num = (short)619315201;
				if (num != 0)
				{
				}
				num = (short)71499776;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.Value;
			}
			set
			{
				short num = (short)58388941;
				short num2 = num;
				num = (short)604434893;
				switch (num2 == num)
				{
				}
				num = (short)892993536;
				if (num != 0)
				{
				}
				num = (short)638517249;
				if (num != 0)
				{
				}
				num = (short)556400640;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonName_A36523.Value = value;
			}
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x06008293 RID: 33427 RVA: 0x0079A26C File Offset: 0x0079846C
		public global::AcpBusinessLayer.AcpField<string> RadErgCtrlHeadO9DataButtonName_A36523
		{
			get
			{
				short num = (short)560334356;
				short num2 = num;
				num = (short)422053396;
				switch (num2 == num)
				{
				}
				num = (short)213057537;
				if (num != 0)
				{
				}
				num = (short)147390464;
				if (num != 0)
				{
				}
				num = (short)1168244736;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523;
			}
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x06008294 RID: 33428 RVA: 0x0079A31C File Offset: 0x0079851C
		// (set) Token: 0x06008295 RID: 33429 RVA: 0x0079A3D0 File Offset: 0x007985D0
		public string RadErgCtrlHeadO9DataButtonName_A36523_UIValue
		{
			get
			{
				short num = (short)1291612203;
				short num2 = num;
				num = (short)542404651;
				switch (num2 == num)
				{
				}
				num = (short)355663872;
				if (num != 0)
				{
				}
				num = (short)1361248257;
				if (num != 0)
				{
				}
				num = (short)289734656;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.Value;
			}
			set
			{
				short num = (short)1512729719;
				short num2 = num;
				num = (short)658992247;
				switch (num2 == num)
				{
				}
				num = (short)2085421057;
				if (num != 0)
				{
				}
				num = (short)1959788544;
				if (num != 0)
				{
				}
				num = (short)127991808;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonName_A36523.Value = value;
			}
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x06008296 RID: 33430 RVA: 0x0079A484 File Offset: 0x00798684
		// (set) Token: 0x06008297 RID: 33431 RVA: 0x0079A538 File Offset: 0x00798738
		public bool RadErgCtrlHeadO9DataButtonName_A36523_Applicable
		{
			get
			{
				short num = (short)233665146;
				short num2 = num;
				num = (short)1902735994;
				switch (num2 == num)
				{
				}
				num = (short)120061953;
				if (num != 0)
				{
				}
				num = (short)544669696;
				if (num != 0)
				{
				}
				num = (short)410910720;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.Applicable;
			}
			set
			{
				short num = (short)722764111;
				short num2 = num;
				num = (short)1032290639;
				switch (num2 == num)
				{
				}
				num = (short)1937309696;
				if (num != 0)
				{
				}
				num = (short)1804402689;
				if (num != 0)
				{
				}
				num = (short)1763639296;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonName_A36523.Applicable = value;
			}
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x06008298 RID: 33432 RVA: 0x0079A5F0 File Offset: 0x007987F0
		// (set) Token: 0x06008299 RID: 33433 RVA: 0x0079A6A4 File Offset: 0x007988A4
		public bool RadErgCtrlHeadO9DataButtonName_A36523_Valid
		{
			get
			{
				short num = (short)728711852;
				short num2 = num;
				num = (short)959136428;
				switch (num2 == num)
				{
				}
				num = (short)1383727104;
				if (num != 0)
				{
				}
				num = (short)523173889;
				if (num != 0)
				{
				}
				num = (short)1915748352;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.Valid;
			}
			set
			{
				short num = (short)2095185921;
				if (num != 0)
				{
				}
				num = (short)778197972;
				short num2 = num;
				num = (short)599612372;
				switch (num2 == num)
				{
				}
				num = (short)57868288;
				if (num != 0)
				{
				}
				num = (short)1864826880;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonName_A36523.Valid = value;
			}
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x0600829A RID: 33434 RVA: 0x0079A75C File Offset: 0x0079895C
		// (set) Token: 0x0600829B RID: 33435 RVA: 0x0079A810 File Offset: 0x00798A10
		public bool RadErgCtrlHeadO9DataButtonName_A36523_Visible
		{
			get
			{
				short num = (short)725236122;
				short num2 = num;
				num = (short)970013082;
				switch (num2 == num)
				{
				}
				num = (short)1591803904;
				if (num != 0)
				{
				}
				num = (short)510394369;
				if (num != 0)
				{
				}
				num = (short)78577664;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.Visible;
			}
			set
			{
				short num = (short)887781870;
				short num2 = num;
				num = (short)1243642350;
				switch (num2 == num)
				{
				}
				num = (short)1883111425;
				if (num != 0)
				{
				}
				num = (short)608305152;
				if (num != 0)
				{
				}
				num = (short)494141440;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonName_A36523.Visible = value;
			}
		}

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x0600829C RID: 33436 RVA: 0x0079A8C4 File Offset: 0x00798AC4
		// (set) Token: 0x0600829D RID: 33437 RVA: 0x0079A978 File Offset: 0x00798B78
		public bool RadErgCtrlHeadO9DataButtonName_A36523_Editable
		{
			get
			{
				short num = (short)815503358;
				short num2 = num;
				num = (short)1514706942;
				switch (num2 == num)
				{
				}
				num = (short)2023948289;
				if (num != 0)
				{
				}
				num = (short)1304494080;
				if (num != 0)
				{
				}
				num = (short)661389312;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.Editable;
			}
			set
			{
				short num = (short)83772977;
				short num2 = num;
				num = (short)998655537;
				switch (num2 == num)
				{
				}
				num = (short)550699009;
				if (num != 0)
				{
				}
				num = (short)30212096;
				if (num != 0)
				{
				}
				num = (short)218169344;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonName_A36523.Editable = value;
			}
		}

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x0600829E RID: 33438 RVA: 0x0079AA2C File Offset: 0x00798C2C
		internal string RadErgCtrlHeadO9DataButtonName_A36523_UILabel
		{
			get
			{
				short num = (short)121634817;
				if (num != 0)
				{
				}
				num = (short)355969741;
				short num2 = num;
				num = (short)1840491213;
				switch (num2 == num)
				{
				}
				num = (short)909574144;
				if (num != 0)
				{
				}
				num = (short)659947520;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.UIName;
			}
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x0600829F RID: 33439 RVA: 0x0079AAE0 File Offset: 0x00798CE0
		// (set) Token: 0x060082A0 RID: 33440 RVA: 0x0079AB94 File Offset: 0x00798D94
		internal bool RadErgCtrlHeadO9DataButtonName_A36523_HiddenStatic
		{
			get
			{
				short num = (short)2021398653;
				short num2 = num;
				num = (short)1697978493;
				switch (num2 == num)
				{
				}
				num = (short)884080640;
				if (num != 0)
				{
				}
				num = (short)1787494401;
				if (num != 0)
				{
				}
				num = (short)709689344;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.HiddenStatic;
			}
			set
			{
				short num = (short)409358667;
				short num2 = num;
				num = (short)1739411787;
				switch (num2 == num)
				{
				}
				num = (short)655687681;
				if (num != 0)
				{
				}
				num = (short)544210944;
				if (num != 0)
				{
				}
				num = (short)2009792512;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonName_A36523.HiddenStatic = value;
			}
		}

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x060082A1 RID: 33441 RVA: 0x0079AC48 File Offset: 0x00798E48
		// (set) Token: 0x060082A2 RID: 33442 RVA: 0x0079ACFC File Offset: 0x00798EFC
		internal bool RadErgCtrlHeadO9DataButtonName_A36523_HiddenDynamic
		{
			get
			{
				short num = (short)803090612;
				short num2 = num;
				num = (short)1035350196;
				switch (num2 == num)
				{
				}
				num = (short)2032467969;
				if (num != 0)
				{
				}
				num = (short)1774387200;
				if (num != 0)
				{
				}
				num = (short)4194304;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523.HiddenDynamic;
			}
			set
			{
				short num = (short)1987247275;
				short num2 = num;
				num = (short)732363947;
				switch (num2 == num)
				{
				}
				num = (short)1765474305;
				if (num != 0)
				{
				}
				num = (short)1679228928;
				if (num != 0)
				{
				}
				num = (short)1402404864;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonName_A36523.HiddenDynamic = value;
			}
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x060082A3 RID: 33443 RVA: 0x0079ADB4 File Offset: 0x00798FB4
		public bool RadErgCtrlHeadO9DataButtonName_A36523_HasDiffs
		{
			get
			{
				short num = (short)1625554945;
				if (num != 0)
				{
				}
				num = (short)1820753935;
				short num2 = num;
				num = (short)1514242063;
				switch (num2 == num)
				{
				}
				num = (short)566296576;
				if (num != 0)
				{
				}
				num = (short)360251392;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonName_A36523._HasDiffs;
			}
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x060082A4 RID: 33444 RVA: 0x0079AE68 File Offset: 0x00799068
		// (set) Token: 0x060082A5 RID: 33445 RVA: 0x0079AF1C File Offset: 0x0079911C
		public int RadErgCtrlHeadO9DataButtonTrkFeature_A36526Value
		{
			get
			{
				short num = (short)248080051;
				short num2 = num;
				num = (short)1405183667;
				switch (num2 == num)
				{
				}
				num = (short)2042494976;
				if (num != 0)
				{
				}
				num = (short)669057025;
				if (num != 0)
				{
				}
				num = (short)2046099456;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Value;
			}
			set
			{
				short num = (short)323485697;
				if (num != 0)
				{
				}
				num = (short)2089214929;
				short num2 = num;
				num = (short)8184785;
				switch (num2 == num)
				{
				}
				num = (short)36962304;
				if (num != 0)
				{
				}
				num = (short)619708416;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Value = value;
			}
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x060082A6 RID: 33446 RVA: 0x0079AFD0 File Offset: 0x007991D0
		// (set) Token: 0x060082A7 RID: 33447 RVA: 0x0079B084 File Offset: 0x00799284
		public string RadErgCtrlHeadO9DataButtonTrkFeature_A36526_UIValue
		{
			get
			{
				short num = (short)1298435902;
				short num2 = num;
				num = (short)793284414;
				switch (num2 == num)
				{
				}
				num = (short)152698881;
				if (num != 0)
				{
				}
				num = (short)1110441984;
				if (num != 0)
				{
				}
				num = (short)410714112;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.UIValue;
			}
			set
			{
				short num = (short)767822378;
				short num2 = num;
				num = (short)703597098;
				switch (num2 == num)
				{
				}
				num = (short)1252655105;
				if (num != 0)
				{
				}
				num = (short)1184759808;
				if (num != 0)
				{
				}
				num = (short)1358299136;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.UIValue = value;
			}
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x060082A8 RID: 33448 RVA: 0x0079B138 File Offset: 0x00799338
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO9DataButtonTrkFeature_A36526
		{
			get
			{
				short num = (short)931790849;
				if (num != 0)
				{
				}
				num = (short)997374926;
				short num2 = num;
				num = (short)1835908046;
				switch (num2 == num)
				{
				}
				num = (short)654573568;
				if (num != 0)
				{
				}
				num = (short)1856503808;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526;
			}
		}

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x060082A9 RID: 33449 RVA: 0x0079B1E8 File Offset: 0x007993E8
		// (set) Token: 0x060082AA RID: 33450 RVA: 0x0079B2A0 File Offset: 0x007994A0
		public bool RadErgCtrlHeadO9DataButtonTrkFeature_A36526_Applicable
		{
			get
			{
				short num = (short)1202846851;
				short num2 = num;
				num = (short)231275651;
				switch (num2 == num)
				{
				}
				num = (short)859111424;
				if (num != 0)
				{
				}
				num = (short)1434058753;
				if (num != 0)
				{
				}
				num = (short)686686208;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Applicable;
			}
			set
			{
				short num = (short)1563784601;
				short num2 = num;
				num = (short)1583052185;
				switch (num2 == num)
				{
				}
				num = (short)416677889;
				if (num != 0)
				{
				}
				num = (short)1978138624;
				if (num != 0)
				{
				}
				num = (short)1282408448;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Applicable = value;
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x060082AB RID: 33451 RVA: 0x0079B358 File Offset: 0x00799558
		// (set) Token: 0x060082AC RID: 33452 RVA: 0x0079B410 File Offset: 0x00799610
		public bool RadErgCtrlHeadO9DataButtonTrkFeature_A36526_Valid
		{
			get
			{
				short num = (short)1811739846;
				short num2 = num;
				num = (short)83358918;
				switch (num2 == num)
				{
				}
				num = (short)723386369;
				if (num != 0)
				{
				}
				num = (short)2012413952;
				if (num != 0)
				{
				}
				num = (short)1512308736;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Valid;
			}
			set
			{
				short num = (short)1301938177;
				if (num != 0)
				{
				}
				num = (short)437723537;
				short num2 = num;
				num = (short)1312629137;
				switch (num2 == num)
				{
				}
				num = (short)122552320;
				if (num != 0)
				{
				}
				num = (short)361496576;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Valid = value;
			}
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x060082AD RID: 33453 RVA: 0x0079B4C8 File Offset: 0x007996C8
		// (set) Token: 0x060082AE RID: 33454 RVA: 0x0079B580 File Offset: 0x00799780
		public bool RadErgCtrlHeadO9DataButtonTrkFeature_A36526_Visible
		{
			get
			{
				short num = (short)1249895347;
				short num2 = num;
				num = (short)1964696499;
				switch (num2 == num)
				{
				}
				num = (short)1054932992;
				if (num != 0)
				{
				}
				num = (short)1337589761;
				if (num != 0)
				{
				}
				num = (short)636354560;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Visible;
			}
			set
			{
				short num = (short)1477312513;
				if (num != 0)
				{
				}
				num = (short)512633642;
				short num2 = num;
				num = (short)1752181546;
				switch (num2 == num)
				{
				}
				num = (short)818216960;
				if (num != 0)
				{
				}
				num = (short)1197342720;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Visible = value;
			}
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x060082AF RID: 33455 RVA: 0x0079B634 File Offset: 0x00799834
		// (set) Token: 0x060082B0 RID: 33456 RVA: 0x0079B6E4 File Offset: 0x007998E4
		public bool RadErgCtrlHeadO9DataButtonTrkFeature_A36526_Editable
		{
			get
			{
				short num = (short)276947362;
				short num2 = num;
				num = (short)501997986;
				switch (num2 == num)
				{
				}
				num = (short)1285816321;
				if (num != 0)
				{
				}
				num = (short)1668939776;
				if (num != 0)
				{
				}
				num = (short)1601306624;
				short num3 = num;
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Editable;
			}
			set
			{
				short num = (short)1411197013;
				short num2 = num;
				num = (short)2019043413;
				switch (num2 == num)
				{
				}
				num = (short)1809055745;
				if (num != 0)
				{
				}
				num = (short)1147535360;
				if (num != 0)
				{
				}
				num = (short)1832124416;
				short num3 = num;
				this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.Editable = value;
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x060082B1 RID: 33457 RVA: 0x0079B79C File Offset: 0x0079999C
		internal string RadErgCtrlHeadO9DataButtonTrkFeature_A36526_UILabel
		{
			get
			{
				short num = (short)1792095720;
				short num2 = num;
				num = (short)1996699112;
				switch (num2 == num)
				{
				}
				num = (short)2022703105;
				if (num != 0)
				{
				}
				num = (short)668860416;
				short num3 = num;
				num = (short)1570897920;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.UIName;
			}
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x060082B2 RID: 33458 RVA: 0x0079B850 File Offset: 0x00799A50
		// (set) Token: 0x060082B3 RID: 33459 RVA: 0x0079B908 File Offset: 0x00799B08
		internal bool RadErgCtrlHeadO9DataButtonTrkFeature_A36526_HiddenStatic
		{
			get
			{
				short num = (short)463863809;
				if (num != 0)
				{
				}
				num = (short)128480859;
				short num2 = num;
				num = (short)609908315;
				switch (num2 == num)
				{
				}
				num = (short)848822272;
				short num3 = num;
				num = (short)865075200;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenStatic;
			}
			set
			{
				short num = (short)611909633;
				if (num != 0)
				{
				}
				num = (short)811041832;
				short num2 = num;
				num = (short)1514505256;
				switch (num2 == num)
				{
				}
				num = (short)331153408;
				short num3 = num;
				num = (short)196476928;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenStatic = value;
			}
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x060082B4 RID: 33460 RVA: 0x0079B9BC File Offset: 0x00799BBC
		// (set) Token: 0x060082B5 RID: 33461 RVA: 0x0079BA70 File Offset: 0x00799C70
		internal bool RadErgCtrlHeadO9DataButtonTrkFeature_A36526_HiddenDynamic
		{
			get
			{
				short num = (short)769025292;
				short num2 = num;
				num = (short)1943823628;
				switch (num2 == num)
				{
				}
				num = (short)996605953;
				if (num != 0)
				{
				}
				num = (short)2130903040;
				short num3 = num;
				num = (short)1493041152;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenDynamic;
			}
			set
			{
				short num = (short)1895650791;
				short num2 = num;
				num = (short)318133735;
				switch (num2 == num)
				{
				}
				num = (short)1208418305;
				if (num != 0)
				{
				}
				num = (short)1644888064;
				short num3 = num;
				num = (short)1739653120;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenDynamic = value;
			}
		}

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x0079BB24 File Offset: 0x00799D24
		public bool RadErgCtrlHeadO9DataButtonTrkFeature_A36526_HasDiffs
		{
			get
			{
				short num = (short)485684592;
				short num2 = num;
				num = (short)1954608496;
				switch (num2 == num)
				{
				}
				num = (short)1636696065;
				if (num != 0)
				{
				}
				num = (short)1535180800;
				short num3 = num;
				num = (short)719716352;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkFeature_A36526._HasDiffs;
			}
		}

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x060082B7 RID: 33463 RVA: 0x0079BBD8 File Offset: 0x00799DD8
		// (set) Token: 0x060082B8 RID: 33464 RVA: 0x0079BC8C File Offset: 0x00799E8C
		public int RadErgCtrlHeadO9DataButtonTrkBCO_A36527Value
		{
			get
			{
				short num = (short)823321423;
				short num2 = num;
				num = (short)2035802959;
				switch (num2 == num)
				{
				}
				num = (short)496762880;
				if (num != 0)
				{
				}
				num = (short)1642987520;
				short num3 = num;
				num = (short)352387073;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Value;
			}
			set
			{
				short num = (short)1242345233;
				short num2 = num;
				num = (short)1768730385;
				switch (num2 == num)
				{
				}
				num = (short)1889730561;
				if (num != 0)
				{
				}
				num = (short)1724121088;
				short num3 = num;
				num = (short)575930368;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Value = value;
			}
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x060082B9 RID: 33465 RVA: 0x0079BD40 File Offset: 0x00799F40
		// (set) Token: 0x060082BA RID: 33466 RVA: 0x0079BDF4 File Offset: 0x00799FF4
		public string RadErgCtrlHeadO9DataButtonTrkBCO_A36527_UIValue
		{
			get
			{
				short num = (short)1613496321;
				if (num != 0)
				{
				}
				num = (short)1619323657;
				short num2 = num;
				num = (short)71756553;
				switch (num2 == num)
				{
				}
				num = (short)1888288768;
				short num3 = num;
				num = (short)615907328;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.UIValue;
			}
			set
			{
				short num = (short)844598847;
				short num2 = num;
				num = (short)943623743;
				switch (num2 == num)
				{
				}
				num = (short)858193921;
				if (num != 0)
				{
				}
				num = (short)275382272;
				short num3 = num;
				num = (short)1268776960;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.UIValue = value;
			}
		}

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x060082BB RID: 33467 RVA: 0x0079BEA8 File Offset: 0x0079A0A8
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO9DataButtonTrkBCO_A36527
		{
			get
			{
				short num = (short)1869807617;
				if (num != 0)
				{
				}
				num = (short)1282796633;
				short num2 = num;
				num = (short)1242819673;
				switch (num2 == num)
				{
				}
				num = (short)1327562752;
				short num3 = num;
				num = (short)1047134208;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527;
			}
		}

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x060082BC RID: 33468 RVA: 0x0079BF58 File Offset: 0x0079A158
		// (set) Token: 0x060082BD RID: 33469 RVA: 0x0079C00C File Offset: 0x0079A20C
		public bool RadErgCtrlHeadO9DataButtonTrkBCO_A36527_Applicable
		{
			get
			{
				short num = (short)1084380947;
				short num2 = num;
				num = (short)1665619731;
				switch (num2 == num)
				{
				}
				num = (short)572522496;
				if (num != 0)
				{
				}
				num = (short)747241472;
				short num3 = num;
				num = (short)188219393;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Applicable;
			}
			set
			{
				short num = (short)2115455927;
				short num2 = num;
				num = (short)1846299575;
				switch (num2 == num)
				{
				}
				num = (short)1383923712;
				if (num != 0)
				{
				}
				num = (short)1630339072;
				short num3 = num;
				num = (short)1398407169;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Applicable = value;
			}
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x060082BE RID: 33470 RVA: 0x0079C0C0 File Offset: 0x0079A2C0
		// (set) Token: 0x060082BF RID: 33471 RVA: 0x0079C178 File Offset: 0x0079A378
		public bool RadErgCtrlHeadO9DataButtonTrkBCO_A36527_Valid
		{
			get
			{
				short num = (short)1870033174;
				short num2 = num;
				num = (short)1443655958;
				switch (num2 == num)
				{
				}
				num = (short)1786970113;
				if (num != 0)
				{
				}
				num = (short)1019084800;
				short num3 = num;
				num = (short)243793920;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Valid;
			}
			set
			{
				short num = (short)1871081291;
				short num2 = num;
				num = (short)2099605323;
				switch (num2 == num)
				{
				}
				num = (short)1508835328;
				if (num != 0)
				{
				}
				num = (short)41353216;
				short num3 = num;
				num = (short)1846149121;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Valid = value;
			}
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x060082C0 RID: 33472 RVA: 0x0079C22C File Offset: 0x0079A42C
		// (set) Token: 0x060082C1 RID: 33473 RVA: 0x0079C2E4 File Offset: 0x0079A4E4
		public bool RadErgCtrlHeadO9DataButtonTrkBCO_A36527_Visible
		{
			get
			{
				short num = (short)367968719;
				short num2 = num;
				num = (short)1723515343;
				switch (num2 == num)
				{
				}
				num = (short)260636673;
				if (num != 0)
				{
				}
				num = (short)1358888960;
				short num3 = num;
				num = (short)456523776;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Visible;
			}
			set
			{
				short num = (short)988909064;
				short num2 = num;
				num = (short)232099336;
				switch (num2 == num)
				{
				}
				num = (short)2018181121;
				if (num != 0)
				{
				}
				num = (short)658112512;
				short num3 = num;
				num = (short)1095958528;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Visible = value;
			}
		}

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x060082C2 RID: 33474 RVA: 0x0079C398 File Offset: 0x0079A598
		// (set) Token: 0x060082C3 RID: 33475 RVA: 0x0079C450 File Offset: 0x0079A650
		public bool RadErgCtrlHeadO9DataButtonTrkBCO_A36527_Editable
		{
			get
			{
				short num = (short)376530406;
				short num2 = num;
				num = (short)2089838054;
				switch (num2 == num)
				{
				}
				num = (short)746848256;
				if (num != 0)
				{
				}
				num = (short)313524224;
				short num3 = num;
				num = (short)871038977;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Editable;
			}
			set
			{
				short num = (short)1459261322;
				short num2 = num;
				num = (short)1915129738;
				switch (num2 == num)
				{
				}
				num = (short)497942529;
				if (num != 0)
				{
				}
				num = (short)639303680;
				short num3 = num;
				num = (short)1320943616;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.Editable = value;
			}
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x060082C4 RID: 33476 RVA: 0x0079C504 File Offset: 0x0079A704
		internal string RadErgCtrlHeadO9DataButtonTrkBCO_A36527_UILabel
		{
			get
			{
				short num = (short)94474300;
				short num2 = num;
				num = (short)926191676;
				switch (num2 == num)
				{
				}
				num = (short)1997012992;
				if (num != 0)
				{
				}
				num = (short)1482358784;
				short num3 = num;
				num = (short)2118320129;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.UIName;
			}
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x060082C5 RID: 33477 RVA: 0x0079C5B8 File Offset: 0x0079A7B8
		// (set) Token: 0x060082C6 RID: 33478 RVA: 0x0079C670 File Offset: 0x0079A870
		internal bool RadErgCtrlHeadO9DataButtonTrkBCO_A36527_HiddenStatic
		{
			get
			{
				short num = (short)432457975;
				short num2 = num;
				num = (short)1239402743;
				switch (num2 == num)
				{
				}
				num = (short)1768292353;
				if (num != 0)
				{
				}
				num = (short)1872429056;
				short num3 = num;
				num = (short)1312882688;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.HiddenStatic;
			}
			set
			{
				short num = (short)731178228;
				short num2 = num;
				num = (short)831251700;
				switch (num2 == num)
				{
				}
				num = (short)670367745;
				if (num != 0)
				{
				}
				num = (short)2069233664;
				short num3 = num;
				num = (short)118816768;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.HiddenStatic = value;
			}
		}

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x060082C7 RID: 33479 RVA: 0x0079C728 File Offset: 0x0079A928
		// (set) Token: 0x060082C8 RID: 33480 RVA: 0x0079C7DC File Offset: 0x0079A9DC
		internal bool RadErgCtrlHeadO9DataButtonTrkBCO_A36527_HiddenDynamic
		{
			get
			{
				short num = (short)1582313370;
				short num2 = num;
				num = (short)1614098330;
				switch (num2 == num)
				{
				}
				num = (short)1921449985;
				if (num != 0)
				{
				}
				num = (short)1024524288;
				short num3 = num;
				num = (short)2022768640;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.HiddenDynamic;
			}
			set
			{
				short num = (short)2086469633;
				if (num != 0)
				{
				}
				num = (short)716289018;
				short num2 = num;
				num = (short)757314554;
				switch (num2 == num)
				{
				}
				num = (short)1693450240;
				short num3 = num;
				num = (short)141623296;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonTrkBCO_A36527.HiddenDynamic = value;
			}
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x060082C9 RID: 33481 RVA: 0x0079C894 File Offset: 0x0079AA94
		public bool RadErgCtrlHeadO9DataButtonTrkBCO_A36527_HasDiffs
		{
			get
			{
				short num = (short)961210274;
				short num2 = num;
				num = (short)1895163810;
				switch (num2 == num)
				{
				}
				num = (short)1818689537;
				if (num != 0)
				{
				}
				num = (short)1217789952;
				short num3 = num;
				num = (short)333447168;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonTrkBCO_A36527._HasDiffs;
			}
		}

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x060082CA RID: 33482 RVA: 0x0079C948 File Offset: 0x0079AB48
		// (set) Token: 0x060082CB RID: 33483 RVA: 0x0079C9FC File Offset: 0x0079ABFC
		public int RadErgCtrlHeadO9DataButtonCnvFeature_A36528Value
		{
			get
			{
				short num = (short)1793083973;
				short num2 = num;
				num = (short)509954629;
				switch (num2 == num)
				{
				}
				num = (short)1779761153;
				if (num != 0)
				{
				}
				num = (short)719781888;
				short num3 = num;
				num = (short)488964096;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Value;
			}
			set
			{
				short num = (short)182809512;
				short num2 = num;
				num = (short)1844081576;
				switch (num2 == num)
				{
				}
				num = (short)2036727808;
				if (num != 0)
				{
				}
				num = (short)95551488;
				short num3 = num;
				num = (short)1818361857;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Value = value;
			}
		}

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x060082CC RID: 33484 RVA: 0x0079CAB4 File Offset: 0x0079ACB4
		// (set) Token: 0x060082CD RID: 33485 RVA: 0x0079CB68 File Offset: 0x0079AD68
		public string RadErgCtrlHeadO9DataButtonCnvFeature_A36528_UIValue
		{
			get
			{
				short num = (short)417724126;
				short num2 = num;
				num = (short)446428894;
				switch (num2 == num)
				{
				}
				num = (short)1677197313;
				if (num != 0)
				{
				}
				num = (short)1958412288;
				short num3 = num;
				num = (short)470941696;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.UIValue;
			}
			set
			{
				short num = (short)1065909684;
				short num2 = num;
				num = (short)2137685428;
				switch (num2 == num)
				{
				}
				num = (short)239271936;
				if (num != 0)
				{
				}
				num = (short)567803904;
				short num3 = num;
				num = (short)806879233;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.UIValue = value;
			}
		}

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x060082CE RID: 33486 RVA: 0x0079CC1C File Offset: 0x0079AE1C
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO9DataButtonCnvFeature_A36528
		{
			get
			{
				short num = (short)1139826622;
				short num2 = num;
				num = (short)1185243070;
				switch (num2 == num)
				{
				}
				num = (short)51576832;
				if (num != 0)
				{
				}
				num = (short)277413888;
				short num3 = num;
				num = (short)1211301889;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528;
			}
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x060082CF RID: 33487 RVA: 0x0079CCD0 File Offset: 0x0079AED0
		// (set) Token: 0x060082D0 RID: 33488 RVA: 0x0079CD84 File Offset: 0x0079AF84
		public bool RadErgCtrlHeadO9DataButtonCnvFeature_A36528_Applicable
		{
			get
			{
				short num = (short)1779654392;
				short num2 = num;
				num = (short)1955421944;
				switch (num2 == num)
				{
				}
				num = (short)2018770944;
				if (num != 0)
				{
				}
				num = (short)925892608;
				short num3 = num;
				num = (short)1270808577;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Applicable;
			}
			set
			{
				short num = (short)1527840769;
				if (num != 0)
				{
				}
				num = (short)1347891369;
				short num2 = num;
				num = (short)997732521;
				switch (num2 == num)
				{
				}
				num = (short)1066139648;
				short num3 = num;
				num = (short)469630976;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Applicable = value;
			}
		}

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x060082D1 RID: 33489 RVA: 0x0079CE38 File Offset: 0x0079B038
		// (set) Token: 0x060082D2 RID: 33490 RVA: 0x0079CEEC File Offset: 0x0079B0EC
		public bool RadErgCtrlHeadO9DataButtonCnvFeature_A36528_Valid
		{
			get
			{
				short num = (short)1854822392;
				short num2 = num;
				num = (short)753096696;
				switch (num2 == num)
				{
				}
				num = (short)372244481;
				if (num != 0)
				{
				}
				num = (short)965607424;
				short num3 = num;
				num = (short)1057882112;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Valid;
			}
			set
			{
				short num = (short)1004491161;
				short num2 = num;
				num = (short)298537369;
				switch (num2 == num)
				{
				}
				num = (short)1422786561;
				if (num != 0)
				{
				}
				num = (short)1292632064;
				short num3 = num;
				num = (short)716177408;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Valid = value;
			}
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x060082D3 RID: 33491 RVA: 0x0079CFA4 File Offset: 0x0079B1A4
		// (set) Token: 0x060082D4 RID: 33492 RVA: 0x0079D058 File Offset: 0x0079B258
		public bool RadErgCtrlHeadO9DataButtonCnvFeature_A36528_Visible
		{
			get
			{
				short num = (short)1935368726;
				short num2 = num;
				num = (short)1423598102;
				switch (num2 == num)
				{
				}
				num = (short)81788929;
				if (num != 0)
				{
				}
				num = (short)701497344;
				short num3 = num;
				num = (short)145752064;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Visible;
			}
			set
			{
				short num = (short)1730138070;
				short num2 = num;
				num = (short)1508954070;
				switch (num2 == num)
				{
				}
				num = (short)1137704961;
				if (num != 0)
				{
				}
				num = (short)380960768;
				short num3 = num;
				num = (short)958070784;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Visible = value;
			}
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x060082D5 RID: 33493 RVA: 0x0079D10C File Offset: 0x0079B30C
		// (set) Token: 0x060082D6 RID: 33494 RVA: 0x0079D1C4 File Offset: 0x0079B3C4
		public bool RadErgCtrlHeadO9DataButtonCnvFeature_A36528_Editable
		{
			get
			{
				short num = (short)1621960357;
				short num2 = num;
				num = (short)1074079397;
				switch (num2 == num)
				{
				}
				num = (short)20709376;
				if (num != 0)
				{
				}
				num = (short)42598400;
				short num3 = num;
				num = (short)1801388033;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Editable;
			}
			set
			{
				short num = (short)1743192065;
				if (num != 0)
				{
				}
				num = (short)762295153;
				short num2 = num;
				num = (short)878097265;
				switch (num2 == num)
				{
				}
				num = (short)2026307584;
				short num3 = num;
				num = (short)1376911360;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.Editable = value;
			}
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x060082D7 RID: 33495 RVA: 0x0079D27C File Offset: 0x0079B47C
		internal string RadErgCtrlHeadO9DataButtonCnvFeature_A36528_UILabel
		{
			get
			{
				short num = (short)692976484;
				short num2 = num;
				num = (short)1151597412;
				switch (num2 == num)
				{
				}
				num = (short)1563230208;
				if (num != 0)
				{
				}
				num = (short)360054784;
				short num3 = num;
				num = (short)297992193;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.UIName;
			}
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x060082D8 RID: 33496 RVA: 0x0079D330 File Offset: 0x0079B530
		// (set) Token: 0x060082D9 RID: 33497 RVA: 0x0079D3E4 File Offset: 0x0079B5E4
		internal bool RadErgCtrlHeadO9DataButtonCnvFeature_A36528_HiddenStatic
		{
			get
			{
				short num = (short)385628995;
				short num2 = num;
				num = (short)1598962499;
				switch (num2 == num)
				{
				}
				num = (short)417923073;
				if (num != 0)
				{
				}
				num = (short)35323904;
				short num3 = num;
				num = (short)131727360;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic;
			}
			set
			{
				short num = (short)471472475;
				short num2 = num;
				num = (short)1860770139;
				switch (num2 == num)
				{
				}
				num = (short)1546059776;
				if (num != 0)
				{
				}
				num = (short)834076672;
				short num3 = num;
				num = (short)1499987969;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic = value;
			}
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x060082DA RID: 33498 RVA: 0x0079D498 File Offset: 0x0079B698
		// (set) Token: 0x060082DB RID: 33499 RVA: 0x0079D54C File Offset: 0x0079B74C
		internal bool RadErgCtrlHeadO9DataButtonCnvFeature_A36528_HiddenDynamic
		{
			get
			{
				short num = (short)1115148542;
				short num2 = num;
				num = (short)435933438;
				switch (num2 == num)
				{
				}
				num = (short)863764481;
				if (num != 0)
				{
				}
				num = (short)1155006464;
				short num3 = num;
				num = (short)340066304;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenDynamic;
			}
			set
			{
				short num = (short)74415018;
				short num2 = num;
				num = (short)756710314;
				switch (num2 == num)
				{
				}
				num = (short)1339031552;
				if (num != 0)
				{
				}
				num = (short)1705705472;
				short num3 = num;
				num = (short)1084424193;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenDynamic = value;
			}
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x060082DC RID: 33500 RVA: 0x0079D600 File Offset: 0x0079B800
		public bool RadErgCtrlHeadO9DataButtonCnvFeature_A36528_HasDiffs
		{
			get
			{
				short num = (short)507598226;
				short num2 = num;
				num = (short)1040012690;
				switch (num2 == num)
				{
				}
				num = (short)1087897601;
				if (num != 0)
				{
				}
				num = (short)1244135424;
				short num3 = num;
				num = (short)48627712;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvFeature_A36528._HasDiffs;
			}
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x060082DD RID: 33501 RVA: 0x0079D6B4 File Offset: 0x0079B8B4
		// (set) Token: 0x060082DE RID: 33502 RVA: 0x0079D768 File Offset: 0x0079B968
		public int RadErgCtrlHeadO9DataButtonCnvBCO_A36529Value
		{
			get
			{
				short num = (short)583377636;
				short num2 = num;
				num = (short)1066509028;
				switch (num2 == num)
				{
				}
				num = (short)1689255937;
				if (num != 0)
				{
				}
				num = (short)975175680;
				short num3 = num;
				num = (short)1592393728;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Value;
			}
			set
			{
				short num = (short)1585099542;
				short num2 = num;
				num = (short)377795350;
				switch (num2 == num)
				{
				}
				num = (short)235732993;
				if (num != 0)
				{
				}
				num = (short)1508704256;
				short num3 = num;
				num = (short)506265600;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Value = value;
			}
		}

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x060082DF RID: 33503 RVA: 0x0079D820 File Offset: 0x0079BA20
		// (set) Token: 0x060082E0 RID: 33504 RVA: 0x0079D8D4 File Offset: 0x0079BAD4
		public string RadErgCtrlHeadO9DataButtonCnvBCO_A36529_UIValue
		{
			get
			{
				short num = (short)820080662;
				short num2 = num;
				num = (short)1685221398;
				switch (num2 == num)
				{
				}
				num = (short)1313210369;
				if (num != 0)
				{
				}
				num = (short)396820480;
				short num3 = num;
				num = (short)178651136;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.UIValue;
			}
			set
			{
				short num = (short)2032044908;
				short num2 = num;
				num = (short)773294956;
				switch (num2 == num)
				{
				}
				num = (short)1677721601;
				if (num != 0)
				{
				}
				num = (short)2011955200;
				short num3 = num;
				num = (short)404619264;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.UIValue = value;
			}
		}

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x060082E1 RID: 33505 RVA: 0x0079D98C File Offset: 0x0079BB8C
		public global::AcpBusinessLayer.AcpListField RadErgCtrlHeadO9DataButtonCnvBCO_A36529
		{
			get
			{
				short num = (short)1159333453;
				short num2 = num;
				num = (short)1235158605;
				switch (num2 == num)
				{
				}
				num = (short)631701505;
				if (num != 0)
				{
				}
				num = (short)1902313472;
				short num3 = num;
				num = (short)1416953856;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529;
			}
		}

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x060082E2 RID: 33506 RVA: 0x0079DA3C File Offset: 0x0079BC3C
		// (set) Token: 0x060082E3 RID: 33507 RVA: 0x0079DAF4 File Offset: 0x0079BCF4
		public bool RadErgCtrlHeadO9DataButtonCnvBCO_A36529_Applicable
		{
			get
			{
				short num = (short)1432354817;
				if (num != 0)
				{
				}
				num = (short)1699164918;
				short num2 = num;
				num = (short)1736061686;
				switch (num2 == num)
				{
				}
				num = (short)1583153152;
				short num3 = num;
				num = (short)2144141312;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Applicable;
			}
			set
			{
				short num = (short)507614089;
				short num2 = num;
				num = (short)1665962889;
				switch (num2 == num)
				{
				}
				num = (short)1213923328;
				if (num != 0)
				{
				}
				num = (short)1709244416;
				short num3 = num;
				num = (short)1288372225;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Applicable = value;
			}
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x060082E4 RID: 33508 RVA: 0x0079DBA8 File Offset: 0x0079BDA8
		// (set) Token: 0x060082E5 RID: 33509 RVA: 0x0079DC60 File Offset: 0x0079BE60
		public bool RadErgCtrlHeadO9DataButtonCnvBCO_A36529_Valid
		{
			get
			{
				short num = (short)750780417;
				if (num != 0)
				{
				}
				num = (short)1589149133;
				short num2 = num;
				num = (short)2048032205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1508573184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1133182976;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Valid;
			}
			set
			{
				short num = (short)1611504543;
				short num2 = num;
				num = (short)1861524383;
				switch (num2 == num)
				{
				}
				num = (short)1539112960;
				short num3 = num;
				num = (short)1360658433;
				if (num != 0)
				{
				}
				num = (short)84344832;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Valid = value;
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x060082E6 RID: 33510 RVA: 0x0079DD14 File Offset: 0x0079BF14
		// (set) Token: 0x060082E7 RID: 33511 RVA: 0x0079DDC4 File Offset: 0x0079BFC4
		public bool RadErgCtrlHeadO9DataButtonCnvBCO_A36529_Visible
		{
			get
			{
				short num = (short)1255887205;
				short num2 = num;
				num = (short)1931563365;
				switch (num2 == num)
				{
				}
				num = (short)442957824;
				short num3 = num;
				num = (short)177602561;
				if (num != 0)
				{
				}
				num = (short)229179392;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Visible;
			}
			set
			{
				short num = (short)1141440513;
				if (num != 0)
				{
				}
				num = (short)1262968669;
				short num2 = num;
				num = (short)200171357;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1673265152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)248643584;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Visible = value;
			}
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x060082E8 RID: 33512 RVA: 0x0079DE78 File Offset: 0x0079C078
		// (set) Token: 0x060082E9 RID: 33513 RVA: 0x0079DF2C File Offset: 0x0079C12C
		public bool RadErgCtrlHeadO9DataButtonCnvBCO_A36529_Editable
		{
			get
			{
				short num = (short)1032519681;
				if (num != 0)
				{
				}
				num = (short)447369459;
				short num2 = num;
				num = (short)1002787059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2145648640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1098317824;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Editable;
			}
			set
			{
				short num = (short)388122304;
				short num2 = num;
				num = (short)1101612736;
				switch (num2 == num)
				{
				}
				num = (short)1625227264;
				short num3 = num;
				num = (short)1960902657;
				if (num != 0)
				{
				}
				num = (short)1164247040;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.Editable = value;
			}
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x060082EA RID: 33514 RVA: 0x0079DFE0 File Offset: 0x0079C1E0
		internal string RadErgCtrlHeadO9DataButtonCnvBCO_A36529_UILabel
		{
			get
			{
				short num = (short)1379258413;
				short num2 = num;
				num = (short)1282396205;
				switch (num2 == num)
				{
				}
				num = (short)73531392;
				short num3 = num;
				num = (short)266797056;
				if (num != 0)
				{
				}
				num = (short)1394671617;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.UIName;
			}
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x060082EB RID: 33515 RVA: 0x0079E094 File Offset: 0x0079C294
		// (set) Token: 0x060082EC RID: 33516 RVA: 0x0079E148 File Offset: 0x0079C348
		internal bool RadErgCtrlHeadO9DataButtonCnvBCO_A36529_HiddenStatic
		{
			get
			{
				short num = (short)1428585833;
				short num2 = num;
				num = (short)1933802857;
				switch (num2 == num)
				{
				}
				num = (short)636354560;
				short num3 = num;
				num = (short)1970667520;
				if (num != 0)
				{
				}
				num = (short)1994653697;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.HiddenStatic;
			}
			set
			{
				short num = (short)2102987681;
				short num2 = num;
				num = (short)575605665;
				switch (num2 == num)
				{
				}
				num = (short)1205665792;
				short num3 = num;
				num = (short)2058944512;
				if (num != 0)
				{
				}
				num = (short)1382023169;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.HiddenStatic = value;
			}
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x060082ED RID: 33517 RVA: 0x0079E1FC File Offset: 0x0079C3FC
		// (set) Token: 0x060082EE RID: 33518 RVA: 0x0079E2B0 File Offset: 0x0079C4B0
		internal bool RadErgCtrlHeadO9DataButtonCnvBCO_A36529_HiddenDynamic
		{
			get
			{
				short num = (short)840335816;
				short num2 = num;
				num = (short)1050837448;
				switch (num2 == num)
				{
				}
				num = (short)1501233152;
				short num3 = num;
				num = (short)522190849;
				if (num != 0)
				{
				}
				num = (short)758906880;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.HiddenDynamic;
			}
			set
			{
				short num = (short)1980165233;
				short num2 = num;
				num = (short)465955953;
				switch (num2 == num)
				{
				}
				num = (short)1751449600;
				short num3 = num;
				num = (short)1480654849;
				if (num != 0)
				{
				}
				num = (short)1525284864;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO9DataButtonCnvBCO_A36529.HiddenDynamic = value;
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x060082EF RID: 33519 RVA: 0x0079E368 File Offset: 0x0079C568
		public bool RadErgCtrlHeadO9DataButtonCnvBCO_A36529_HasDiffs
		{
			get
			{
				short num = (short)297939293;
				short num2 = num;
				num = (short)1551315293;
				switch (num2 == num)
				{
				}
				num = (short)944242688;
				short num3 = num;
				num = (short)1045626881;
				if (num != 0)
				{
				}
				num = (short)1323106304;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO9DataButtonCnvBCO_A36529._HasDiffs;
			}
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x060082F0 RID: 33520 RVA: 0x0079E41C File Offset: 0x0079C61C
		// (set) Token: 0x060082F1 RID: 33521 RVA: 0x0079E4D4 File Offset: 0x0079C6D4
		public int CHO9DataButtonConvIndex_A41414Value
		{
			get
			{
				short num = (short)414354250;
				short num2 = num;
				num = (short)891718474;
				switch (num2 == num)
				{
				}
				num = (short)1781530624;
				short num3 = num;
				num = (short)1578631169;
				if (num != 0)
				{
				}
				num = (short)747503616;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.Value;
			}
			set
			{
				short num = (short)2058891078;
				short num2 = num;
				num = (short)1340813126;
				switch (num2 == num)
				{
				}
				num = (short)1341128704;
				short num3 = num;
				num = (short)1779367936;
				if (num != 0)
				{
				}
				num = (short)1243611137;
				if (num != 0)
				{
				}
				this.cHO9DataButtonConvIndex_A41414.Value = value;
			}
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x060082F2 RID: 33522 RVA: 0x0079E58C File Offset: 0x0079C78C
		// (set) Token: 0x060082F3 RID: 33523 RVA: 0x0079E640 File Offset: 0x0079C840
		public string CHO9DataButtonConvIndex_A41414_UIValue
		{
			get
			{
				short num = (short)1006091183;
				short num2 = num;
				num = (short)1450949551;
				switch (num2 == num)
				{
				}
				num = (short)533135360;
				short num3 = num;
				num = (short)704839680;
				if (num != 0)
				{
				}
				num = (short)1384448001;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.UIValue;
			}
			set
			{
				short num = (short)1568014107;
				short num2 = num;
				num = (short)1366294299;
				switch (num2 == num)
				{
				}
				num = (short)176488448;
				short num3 = num;
				num = (short)843710465;
				if (num != 0)
				{
				}
				num = (short)65601536;
				if (num != 0)
				{
				}
				this.cHO9DataButtonConvIndex_A41414.UIValue = value;
			}
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x060082F4 RID: 33524 RVA: 0x0079E6F8 File Offset: 0x0079C8F8
		public global::AcpBusinessLayer.AcpRecRefField CHO9DataButtonConvIndex_A41414
		{
			get
			{
				short num = (short)2002778653;
				short num2 = num;
				num = (short)2067724829;
				switch (num2 == num)
				{
				}
				num = (short)1174994944;
				short num3 = num;
				num = (short)9043969;
				if (num != 0)
				{
				}
				num = (short)1108148224;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414;
			}
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x060082F5 RID: 33525 RVA: 0x0079E7A8 File Offset: 0x0079C9A8
		// (set) Token: 0x060082F6 RID: 33526 RVA: 0x0079E860 File Offset: 0x0079CA60
		public bool CHO9DataButtonConvIndex_A41414_Applicable
		{
			get
			{
				short num = (short)737021696;
				short num2 = num;
				num = (short)519835392;
				switch (num2 == num)
				{
				}
				num = (short)1104609280;
				short num3 = num;
				num = (short)1134297089;
				if (num != 0)
				{
				}
				num = (short)737411072;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.Applicable;
			}
			set
			{
				short num = (short)1444257652;
				short num2 = num;
				num = (short)1558028148;
				switch (num2 == num)
				{
				}
				num = (short)705036288;
				short num3 = num;
				num = (short)1450770433;
				if (num != 0)
				{
				}
				num = (short)1669070848;
				if (num != 0)
				{
				}
				this.cHO9DataButtonConvIndex_A41414.Applicable = value;
			}
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x060082F7 RID: 33527 RVA: 0x0079E914 File Offset: 0x0079CB14
		// (set) Token: 0x060082F8 RID: 33528 RVA: 0x0079E9CC File Offset: 0x0079CBCC
		public bool CHO9DataButtonConvIndex_A41414_Valid
		{
			get
			{
				short num = (short)398367529;
				short num2 = num;
				num = (short)1168284457;
				switch (num2 == num)
				{
				}
				num = (short)1077608448;
				short num3 = num;
				num = (short)349569025;
				if (num != 0)
				{
				}
				num = (short)502005760;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.Valid;
			}
			set
			{
				short num = (short)955908097;
				if (num != 0)
				{
				}
				num = (short)1749998231;
				short num2 = num;
				num = (short)1902041751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)41484288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1773731840;
				if (num != 0)
				{
				}
				this.cHO9DataButtonConvIndex_A41414.Valid = value;
			}
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x060082F9 RID: 33529 RVA: 0x0079EA84 File Offset: 0x0079CC84
		// (set) Token: 0x060082FA RID: 33530 RVA: 0x0079EB3C File Offset: 0x0079CD3C
		public bool CHO9DataButtonConvIndex_A41414_Visible
		{
			get
			{
				short num = (short)718236290;
				short num2 = num;
				num = (short)923495042;
				switch (num2 == num)
				{
				}
				num = (short)408748032;
				short num3 = num;
				num = (short)815857664;
				if (num != 0)
				{
				}
				num = (short)1746075649;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.Visible;
			}
			set
			{
				short num = (short)1110594630;
				short num2 = num;
				num = (short)550720582;
				switch (num2 == num)
				{
				}
				num = (short)2082799616;
				short num3 = num;
				num = (short)549257217;
				if (num != 0)
				{
				}
				num = (short)325910528;
				if (num != 0)
				{
				}
				this.cHO9DataButtonConvIndex_A41414.Visible = value;
			}
		}

		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x060082FB RID: 33531 RVA: 0x0079EBF4 File Offset: 0x0079CDF4
		// (set) Token: 0x060082FC RID: 33532 RVA: 0x0079ECA8 File Offset: 0x0079CEA8
		public bool CHO9DataButtonConvIndex_A41414_Editable
		{
			get
			{
				short num = (short)1628241921;
				if (num != 0)
				{
				}
				num = (short)107902689;
				short num2 = num;
				num = (short)1230796513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1454047232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1833369600;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.Editable;
			}
			set
			{
				short num = (short)629143545;
				short num2 = num;
				num = (short)175568889;
				switch (num2 == num)
				{
				}
				num = (short)1612251136;
				short num3 = num;
				num = (short)1678311425;
				if (num != 0)
				{
				}
				num = (short)98369536;
				if (num != 0)
				{
				}
				this.cHO9DataButtonConvIndex_A41414.Editable = value;
			}
		}

		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x060082FD RID: 33533 RVA: 0x0079ED5C File Offset: 0x0079CF5C
		internal string CHO9DataButtonConvIndex_A41414_UILabel
		{
			get
			{
				short num = (short)399272266;
				short num2 = num;
				num = (short)1960929610;
				switch (num2 == num)
				{
				}
				num = (short)1791688704;
				short num3 = num;
				num = (short)1530003457;
				if (num != 0)
				{
				}
				num = (short)1030422528;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.UIName;
			}
		}

		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x060082FE RID: 33534 RVA: 0x0079EE10 File Offset: 0x0079D010
		// (set) Token: 0x060082FF RID: 33535 RVA: 0x0079EEC4 File Offset: 0x0079D0C4
		internal bool CHO9DataButtonConvIndex_A41414_HiddenStatic
		{
			get
			{
				short num = (short)782359048;
				short num2 = num;
				num = (short)171629064;
				switch (num2 == num)
				{
				}
				num = (short)318111744;
				short num3 = num;
				num = (short)1016463361;
				if (num != 0)
				{
				}
				num = (short)1066270720;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.HiddenStatic;
			}
			set
			{
				short num = (short)1579290901;
				short num2 = num;
				num = (short)1335169301;
				switch (num2 == num)
				{
				}
				num = (short)1886650368;
				short num3 = num;
				num = (short)1036058625;
				if (num != 0)
				{
				}
				num = (short)822018048;
				if (num != 0)
				{
				}
				this.cHO9DataButtonConvIndex_A41414.HiddenStatic = value;
			}
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x06008300 RID: 33536 RVA: 0x0079EF7C File Offset: 0x0079D17C
		// (set) Token: 0x06008301 RID: 33537 RVA: 0x0079F030 File Offset: 0x0079D230
		internal bool CHO9DataButtonConvIndex_A41414_HiddenDynamic
		{
			get
			{
				short num = (short)1381053579;
				short num2 = num;
				num = (short)832451723;
				switch (num2 == num)
				{
				}
				num = (short)2033844224;
				short num3 = num;
				num = (short)728170497;
				if (num != 0)
				{
				}
				num = (short)135200768;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414.HiddenDynamic;
			}
			set
			{
				short num = (short)594345985;
				if (num != 0)
				{
				}
				num = (short)1650186798;
				short num2 = num;
				num = (short)1871567406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170196992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1638400;
				if (num != 0)
				{
				}
				this.cHO9DataButtonConvIndex_A41414.HiddenDynamic = value;
			}
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x06008302 RID: 33538 RVA: 0x0079F0E8 File Offset: 0x0079D2E8
		public bool CHO9DataButtonConvIndex_A41414_HasDiffs
		{
			get
			{
				short num = (short)2008672315;
				short num2 = num;
				num = (short)1210116155;
				switch (num2 == num)
				{
				}
				num = (short)281608192;
				short num3 = num;
				num = (short)386924545;
				if (num != 0)
				{
				}
				num = (short)1391132672;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonConvIndex_A41414._HasDiffs;
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x06008303 RID: 33539 RVA: 0x0079F1A0 File Offset: 0x0079D3A0
		// (set) Token: 0x06008304 RID: 33540 RVA: 0x0079F254 File Offset: 0x0079D454
		public int CHO9DataButtonTrkIndex_A41416Value
		{
			get
			{
				short num = (short)857206928;
				short num2 = num;
				num = (short)2116939920;
				switch (num2 == num)
				{
				}
				num = (short)1486553088;
				short num3 = num;
				num = (short)1845231616;
				if (num != 0)
				{
				}
				num = (short)1201405953;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.Value;
			}
			set
			{
				short num = (short)75385533;
				short num2 = num;
				num = (short)632572605;
				switch (num2 == num)
				{
				}
				num = (short)1358036992;
				short num3 = num;
				num = (short)1388445697;
				if (num != 0)
				{
				}
				num = (short)2084175872;
				if (num != 0)
				{
				}
				this.cHO9DataButtonTrkIndex_A41416.Value = value;
			}
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x06008305 RID: 33541 RVA: 0x0079F30C File Offset: 0x0079D50C
		// (set) Token: 0x06008306 RID: 33542 RVA: 0x0079F3C0 File Offset: 0x0079D5C0
		public string CHO9DataButtonTrkIndex_A41416_UIValue
		{
			get
			{
				short num = (short)1934674996;
				short num2 = num;
				num = (short)1130810420;
				switch (num2 == num)
				{
				}
				num = (short)1165754368;
				short num3 = num;
				num = (short)182714368;
				if (num != 0)
				{
				}
				num = (short)1137836033;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.UIValue;
			}
			set
			{
				short num = (short)924573995;
				short num2 = num;
				num = (short)2078990635;
				switch (num2 == num)
				{
				}
				num = (short)2032402432;
				short num3 = num;
				num = (short)203554816;
				if (num != 0)
				{
				}
				num = (short)101974017;
				if (num != 0)
				{
				}
				this.cHO9DataButtonTrkIndex_A41416.UIValue = value;
			}
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x06008307 RID: 33543 RVA: 0x0079F478 File Offset: 0x0079D678
		public global::AcpBusinessLayer.AcpRecRefField CHO9DataButtonTrkIndex_A41416
		{
			get
			{
				short num = (short)232822025;
				short num2 = num;
				num = (short)2035782921;
				switch (num2 == num)
				{
				}
				num = (short)2016804864;
				short num3 = num;
				num = (short)135856129;
				if (num != 0)
				{
				}
				num = (short)671875072;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416;
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x06008308 RID: 33544 RVA: 0x0079F528 File Offset: 0x0079D728
		// (set) Token: 0x06008309 RID: 33545 RVA: 0x0079F5E0 File Offset: 0x0079D7E0
		public bool CHO9DataButtonTrkIndex_A41416_Applicable
		{
			get
			{
				short num = (short)1370424978;
				short num2 = num;
				num = (short)1814562450;
				switch (num2 == num)
				{
				}
				num = (short)1580072960;
				short num3 = num;
				num = (short)86507521;
				if (num != 0)
				{
				}
				num = (short)1980104704;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.Applicable;
			}
			set
			{
				short num = (short)1949954620;
				short num2 = num;
				num = (short)512619068;
				switch (num2 == num)
				{
				}
				num = (short)540344320;
				short num3 = num;
				num = (short)1578041345;
				if (num != 0)
				{
				}
				num = (short)740294656;
				if (num != 0)
				{
				}
				this.cHO9DataButtonTrkIndex_A41416.Applicable = value;
			}
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x0600830A RID: 33546 RVA: 0x0079F694 File Offset: 0x0079D894
		// (set) Token: 0x0600830B RID: 33547 RVA: 0x0079F748 File Offset: 0x0079D948
		public bool CHO9DataButtonTrkIndex_A41416_Valid
		{
			get
			{
				short num = (short)269029667;
				short num2 = num;
				num = (short)505286947;
				switch (num2 == num)
				{
				}
				num = (short)1230372864;
				short num3 = num;
				num = (short)786433;
				if (num != 0)
				{
				}
				num = (short)906690560;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.Valid;
			}
			set
			{
				short num = (short)841940993;
				if (num != 0)
				{
				}
				num = (short)1680312598;
				short num2 = num;
				num = (short)1908377878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1500053504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238288896;
				if (num != 0)
				{
				}
				this.cHO9DataButtonTrkIndex_A41416.Valid = value;
			}
		}

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x0600830C RID: 33548 RVA: 0x0079F7FC File Offset: 0x0079D9FC
		// (set) Token: 0x0600830D RID: 33549 RVA: 0x0079F8B4 File Offset: 0x0079DAB4
		public bool CHO9DataButtonTrkIndex_A41416_Visible
		{
			get
			{
				short num = (short)1876099073;
				if (num != 0)
				{
				}
				num = (short)1715426935;
				short num2 = num;
				num = (short)1931892343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1526464512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632291328;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.Visible;
			}
			set
			{
				short num = (short)1095054855;
				short num2 = num;
				num = (short)926299655;
				switch (num2 == num)
				{
				}
				num = (short)1317797888;
				short num3 = num;
				num = (short)1694040065;
				if (num != 0)
				{
				}
				num = (short)548601856;
				if (num != 0)
				{
				}
				this.cHO9DataButtonTrkIndex_A41416.Visible = value;
			}
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x0600830E RID: 33550 RVA: 0x0079F96C File Offset: 0x0079DB6C
		// (set) Token: 0x0600830F RID: 33551 RVA: 0x0079FA20 File Offset: 0x0079DC20
		public bool CHO9DataButtonTrkIndex_A41416_Editable
		{
			get
			{
				short num = (short)1395130369;
				if (num != 0)
				{
				}
				num = (short)1199108034;
				short num2 = num;
				num = (short)1262874562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813498368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1620770816;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.Editable;
			}
			set
			{
				short num = (short)1759623547;
				short num2 = num;
				num = (short)2131999099;
				switch (num2 == num)
				{
				}
				num = (short)1699020800;
				short num3 = num;
				num = (short)1166868480;
				if (num != 0)
				{
				}
				num = (short)745865217;
				if (num != 0)
				{
				}
				this.cHO9DataButtonTrkIndex_A41416.Editable = value;
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x06008310 RID: 33552 RVA: 0x0079FAD8 File Offset: 0x0079DCD8
		internal string CHO9DataButtonTrkIndex_A41416_UILabel
		{
			get
			{
				short num = (short)547487745;
				if (num != 0)
				{
				}
				num = (short)619785450;
				short num2 = num;
				num = (short)2133667050;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1005191168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)688717824;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.UIName;
			}
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x06008311 RID: 33553 RVA: 0x0079FB8C File Offset: 0x0079DD8C
		// (set) Token: 0x06008312 RID: 33554 RVA: 0x0079FC44 File Offset: 0x0079DE44
		internal bool CHO9DataButtonTrkIndex_A41416_HiddenStatic
		{
			get
			{
				short num = (short)2013372321;
				short num2 = num;
				num = (short)1009295265;
				switch (num2 == num)
				{
				}
				num = (short)221904896;
				short num3 = num;
				num = (short)43515904;
				if (num != 0)
				{
				}
				num = (short)1124139009;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.HiddenStatic;
			}
			set
			{
				short num = (short)296743007;
				short num2 = num;
				num = (short)1161687135;
				switch (num2 == num)
				{
				}
				num = (short)233766912;
				short num3 = num;
				num = (short)1150484481;
				if (num != 0)
				{
				}
				num = (short)146997248;
				if (num != 0)
				{
				}
				this.cHO9DataButtonTrkIndex_A41416.HiddenStatic = value;
			}
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x06008313 RID: 33555 RVA: 0x0079FCFC File Offset: 0x0079DEFC
		// (set) Token: 0x06008314 RID: 33556 RVA: 0x0079FDB4 File Offset: 0x0079DFB4
		internal bool CHO9DataButtonTrkIndex_A41416_HiddenDynamic
		{
			get
			{
				short num = (short)940320332;
				short num2 = num;
				num = (short)273032780;
				switch (num2 == num)
				{
				}
				num = (short)1709703168;
				short num3 = num;
				num = (short)700383232;
				if (num != 0)
				{
				}
				num = (short)1172242433;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416.HiddenDynamic;
			}
			set
			{
				short num = (short)957605685;
				short num2 = num;
				num = (short)591521589;
				switch (num2 == num)
				{
				}
				num = (short)998309888;
				short num3 = num;
				num = (short)151584769;
				if (num != 0)
				{
				}
				num = (short)1635450880;
				if (num != 0)
				{
				}
				this.cHO9DataButtonTrkIndex_A41416.HiddenDynamic = value;
			}
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x06008315 RID: 33557 RVA: 0x0079FE6C File Offset: 0x0079E06C
		public bool CHO9DataButtonTrkIndex_A41416_HasDiffs
		{
			get
			{
				short num = (short)955167739;
				short num2 = num;
				num = (short)1041282043;
				switch (num2 == num)
				{
				}
				num = (short)1510342656;
				short num3 = num;
				num = (short)1669005312;
				if (num != 0)
				{
				}
				num = (short)233832449;
				if (num != 0)
				{
				}
				return this.cHO9DataButtonTrkIndex_A41416._HasDiffs;
			}
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x06008316 RID: 33558 RVA: 0x0079FF20 File Offset: 0x0079E120
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1682273785;
				short num2 = num;
				num = (short)287340025;
				switch (num2 == num)
				{
				}
				num = (short)468385792;
				short num3 = num;
				num = (short)1800536064;
				if (num != 0)
				{
				}
				num = (short)1030356993;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008317 RID: 33559 RVA: 0x0079FFE4 File Offset: 0x0079E1E4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1010761729;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)254935043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)389545988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					num = (short)1240137730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1917811819;
					short num3 = num;
					num = (short)1415412843;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					case 1:
						break;
					default:
					{
						num = (short)1098448896;
						short num4 = num;
						break;
					}
					}
					num = (short)446300160;
					if (num != 0)
					{
					}
					num = (short)1316290560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_4A;
			}
			return result;
			IL_4A:
			result = null;
			num = (short)697106433;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x04003E4A RID: 15946
		private global::AcpBusinessLayer.AcpField<string> radErgCtrlHeadO9DataButtonName_A36523;

		// Token: 0x04003E4B RID: 15947
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO9DataButtonTrkFeature_A36526;

		// Token: 0x04003E4C RID: 15948
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO9DataButtonTrkBCO_A36527;

		// Token: 0x04003E4D RID: 15949
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO9DataButtonCnvFeature_A36528;

		// Token: 0x04003E4E RID: 15950
		private global::AcpBusinessLayer.AcpListField radErgCtrlHeadO9DataButtonCnvBCO_A36529;

		// Token: 0x04003E4F RID: 15951
		private global::AcpBusinessLayer.AcpRecRefField cHO9DataButtonConvIndex_A41414;

		// Token: 0x04003E50 RID: 15952
		private global::AcpBusinessLayer.AcpRecRefField cHO9DataButtonTrkIndex_A41416;
	}
}
