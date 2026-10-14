using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000404 RID: 1028
	[global::System.Serializable]
	public class DataButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008DFF RID: 36351 RVA: 0x0086062C File Offset: 0x0085E82C
		public DataButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x00860648 File Offset: 0x0085E848
		protected DataButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008E01 RID: 36353 RVA: 0x00860660 File Offset: 0x0085E860
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1076706228;
			short num2 = num;
			num = (short)939932596;
			switch (num2 == num)
			{
			}
			num = (short)2067726336;
			short num3 = num;
			num = (short)1515520001;
			if (num != 0)
			{
			}
			num = (short)2095972352;
			if (num != 0)
			{
			}
			this.btnTrunkingButtonDatatButtonFeature_A22608 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnTrunkingButtonDatatButtonFeature_A22608LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnTrunkingButtonDatatButtonFeature_A22608LovStrs), this, global::AllFeatures.CodeplugGuid.b("觊만ꇎ藐ꇒꃔ맖님닚돜룞ꏠ離釤鏦蛨藪ꧬ軮藰鋲致뗶賸迺觼郾漀䔂怄昆紈縊缌樎丐划✔┖⼘⬚├", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnTrunkingButtonDatatButtonFeature_A22608LovStrs);
			this.btnTrunkingButtonDatatButtonFeature_A22608.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnTrunkingButtonDatatButtonFeature_A22608.DataTransferOrder = 33;
			this.btnTrunkingButtonDataButtonBCO_A22609 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnTrunkingButtonDataButtonBCO_A22609LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnTrunkingButtonDataButtonBCO_A22609LovStrs), this, global::AllFeatures.CodeplugGuid.b("觊만ꇎ藐ꇒꃔ맖님닚돜룞ꏠ離釤鏦蛨藪ꧬ軮藰鋲럴苶跸迺鋼釾䌀䀂䨄堆䠈㤊㼌㤎ℐ⨒", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnTrunkingButtonDataButtonBCO_A22609LovStrs);
			this.btnTrunkingButtonDataButtonBCO_A22609.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.btnTrunkingButtonDataButtonBCO_A22609.DataTransferOrder = 34;
			this.btnConventionalButtonDatatButtonFeature_A22610 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnConventionalButtonDatatButtonFeature_A22610LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnConventionalButtonDatatButtonFeature_A22610LovStrs), this, global::AllFeatures.CodeplugGuid.b("觊만ꇎ鋐볒믔ꇖ볘뗚꧜뛞軠跢蓤详ꯨ黪駬鯮黰鷲뇴零跸髺觼뷾琀眂焄栆月䴊栌渎攐昒朔爖䘘娚⼜ⴞᜠሢᔤ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnConventionalButtonDatatButtonFeature_A22610LovStrs);
			this.btnConventionalButtonDatatButtonFeature_A22610.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnConventionalButtonDatatButtonFeature_A22610.DataTransferOrder = 35;
			this.btnConventionalButtonDataButtonBCO_A22611 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnConventionalButtonDataButtonBCO_A22611LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnConventionalButtonDataButtonBCO_A22611LovStrs), this, global::AllFeatures.CodeplugGuid.b("觊만ꇎ鋐볒믔ꇖ볘뗚꧜뛞軠跢蓤详ꯨ黪駬鯮黰鷲뇴零跸髺뿼諾甀眂樄椆䬈䠊䈌倎倐ℒ✔№⠘⨚", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnConventionalButtonDataButtonBCO_A22611LovStrs);
			this.btnConventionalButtonDataButtonBCO_A22611.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.btnConventionalButtonDataButtonBCO_A22611.DataTransferOrder = 36;
			this.btnButtonDataButtonName_A22612 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("觊만ꇎ鏐ꛒꇔꏖ뛘뗚駜뻞闠苢꟤鋦鷨鿪苬臮뿰鋲飴鋶꛸뫺쿼췾㜀㈂㜄", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.btnButtonDataButtonName_A22612.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnButtonDataButtonName_A22612.DataTransferOrder = -1;
			this.btnButtonDataButtonKey_A22613 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("觊만ꇎ鏐ꛒꇔꏖ뛘뗚駜뻞闠苢꟤鋦鷨鿪苬臮뫰雲賴ꣶ룸짺쿼짾\u3000。", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.btnButtonDataButtonKey_A22613.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.btnButtonDataButtonKey_A22613.DataTransferOrder = 38;
			this.btnPortableDataButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("觊만ꇎ臐볒꟔ꏖ룘맚뇜뫞ꗠ苢釤蛦ꯨ黪駬鯮黰鷲꛴鿶雸觺觼꿾猀昂瘄理崈戊怌樎", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.btnPortableDataButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnPortableDataButtonShortPressTime.DataTransferOrder = 39;
			this.btnPortableDataButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.btnPortableDataButtonShortPressTime.ShowHexValue = false;
			this.btnPortableDataButtonShortPressTime.ValidateAcrossRecset = true;
			this.btnButtonDataButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("觊만ꇎ鏐ꛒꇔꏖ뛘뗚駜뻞闠苢꟤鋦鷨鿪苬臮뷰鳲鯴郶꧸觺飼賾爀圂氄樆氈", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.btnButtonDataButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnButtonDataButtonLongPressTime.DataTransferOrder = 40;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.btnButtonDataButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.btnButtonDataButtonLongPressTime.ShowHexValue = false;
			this.btnButtonDataButtonLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迊곌믎냐闖곘꿚꧜냞迠", a_);
			base.Id = 10090;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008E02 RID: 36354 RVA: 0x008609EC File Offset: 0x0085EBEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)650772487;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					IL_3D8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ觉ꏋꃍꛏ럑뫓ꋕ뇗뗙닛뿝賟ꃡ釣鋥鳧藩苫ꫭ釯蛱闳듵跷軹裻釽滿䀁䜃䤅圇䬉㸋㰍☏⌑┓", a_)))
					{
						num = (short)202571781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AB;
				case 1:
					this.btnPortableDataButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ髉ꏋ볍꓏돑뛓뫕뷗黙뷛ꫝ臟ꃡ釣鋥鳧藩苫뷭飯鷱蛳苵ꣷ裹駻跽珿嘁洃欅洇", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.btnPortableDataButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnPortableDataButtonShortPressTime.DataTransferOrder = 39;
					this.btnPortableDataButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.btnPortableDataButtonShortPressTime.ShowHexValue = false;
					this.btnPortableDataButtonShortPressTime.ValidateAcrossRecset = true;
					num = (short)129564691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.btnButtonDataButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ裉맋뫍꓏뷑뫓鋕맗껙뷛鳝闟雡郣觥蛧ꛩ菫胭韯ꋱ蛳鏵请觹ꣻ韽淿朁", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.btnButtonDataButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnButtonDataButtonLongPressTime.DataTransferOrder = 40;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.btnButtonDataButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.btnButtonDataButtonLongPressTime.ShowHexValue = false;
					this.btnButtonDataButtonLongPressTime.ValidateAcrossRecset = true;
					num = (short)1189675028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1AB;
				case 4:
					goto IL_C3;
				case 5:
					this.btnConventionalButtonDataButtonBCO_A22611 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnConventionalButtonDataButtonBCO_A22611LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnConventionalButtonDataButtonBCO_A22611LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ觉ꏋꃍꛏ럑뫓ꋕ뇗뗙닛뿝賟ꃡ釣鋥鳧藩苫ꫭ釯蛱闳듵跷軹裻釽滿䀁䜃䤅圇䬉㸋㰍☏⌑┓", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnConventionalButtonDataButtonBCO_A22611LovStrs);
					this.btnConventionalButtonDataButtonBCO_A22611.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.btnConventionalButtonDataButtonBCO_A22611.DataTransferOrder = 36;
					num = (short)1306263555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)964624401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ黉뻋믍뻏맑뷓룕뿗飙꧛ꫝ铟跡諣ꋥ觧黩跫곭藯蛱胳駵雷룹뿻뇽忿䌁㘃㐅㸇㨉㔋", a_)))
					{
						num = (short)723386383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_560;
				case 9:
					goto IL_47B;
				case 10:
					this.btnButtonDataButtonName_A22612 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ裉맋뫍꓏뷑뫓鋕맗껙뷛鳝闟雡郣觥蛧ꓩ跫菭闯귱뗳쓵쫷쳹췻쳽", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.btnButtonDataButtonName_A22612.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnButtonDataButtonName_A22612.DataTransferOrder = -1;
					num = (short)2049572868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ觉ꏋꃍꛏ럑뫓ꋕ뇗뗙닛뿝賟ꃡ釣鋥鳧藩苫ꫭ釯蛱闳苵뫷迹裻諽濿氁䈃挅椇縉礋簍甏䴑唓␕⨗Ⱉⴛ⸝", a_)))
					{
						num = (short)227278874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C1;
				case 12:
					this.btnTrunkingButtonDatatButtonFeature_A22608 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnTrunkingButtonDatatButtonFeature_A22608LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnTrunkingButtonDatatButtonFeature_A22608LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ黉뻋믍뻏맑뷓룕뿗飙꧛ꫝ铟跡諣ꋥ觧黩跫髭닯蟱胳苵韷铹뫻鯽懿瘁焃琅洇唉䴋㰍∏␑␓⸕", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnTrunkingButtonDatatButtonFeature_A22608LovStrs);
					this.btnTrunkingButtonDatatButtonFeature_A22608.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnTrunkingButtonDatatButtonFeature_A22608.DataTransferOrder = 33;
					num = (short)1292304406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ裉맋뫍꓏뷑뫓鋕맗껙뷛鳝闟雡郣觥蛧ꓩ跫菭闯귱뗳쓵쫷쳹췻쳽", a_)))
					{
						num = (short)510787594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				case 14:
					goto IL_3C1;
				case 15:
					this.btnTrunkingButtonDataButtonBCO_A22609 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnTrunkingButtonDataButtonBCO_A22609LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnTrunkingButtonDataButtonBCO_A22609LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ黉뻋믍뻏맑뷓룕뿗飙꧛ꫝ铟跡諣ꋥ觧黩跫곭藯蛱胳駵雷룹뿻뇽忿䌁㘃㐅㸇㨉㔋", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnTrunkingButtonDataButtonBCO_A22609LovStrs);
					this.btnTrunkingButtonDataButtonBCO_A22609.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.btnTrunkingButtonDataButtonBCO_A22609.DataTransferOrder = 34;
					num = (short)695140377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ黉뻋믍뻏맑뷓룕뿗飙꧛ꫝ铟跡諣ꋥ觧黩跫髭닯蟱胳苵韷铹뫻鯽懿瘁焃琅洇唉䴋㰍∏␑␓⸕", a_)))
					{
						num = (short)1092550668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				case 17:
					if (producerFields != null)
					{
						num = (short)1200816151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78D;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ裉맋뫍꓏뷑뫓鋕맗껙뷛鳝闟雡郣觥蛧ꛩ菫胭韯ꋱ蛳鏵请觹ꣻ韽淿朁", a_)))
					{
						num = (short)1061289986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78D;
				case 19:
					goto IL_374;
				case 20:
					goto IL_55B;
				case 21:
					this.btnButtonDataButtonKey_A22613 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ裉맋뫍꓏뷑뫓鋕맗껙뷛鳝闟雡郣觥蛧ꇩ觫韭꿯돱웳쓵컷쯹쿻", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.btnButtonDataButtonKey_A22613.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.btnButtonDataButtonKey_A22613.DataTransferOrder = 38;
					num = (short)1561133065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_1F8;
				case 23:
					num = (short)692977680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ髉ꏋ볍꓏돑뛓뫕뷗黙뷛ꫝ臟ꃡ釣鋥鳧藩苫뷭飯鷱蛳苵ꣷ裹駻跽珿嘁洃欅洇", a_)))
					{
						num = (short)1670578177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_374;
				case 25:
					goto IL_560;
				case 26:
					this.btnConventionalButtonDatatButtonFeature_A22610 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnConventionalButtonDatatButtonFeature_A22610LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnConventionalButtonDatatButtonFeature_A22610LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ觉ꏋꃍꛏ럑뫓ꋕ뇗뗙닛뿝賟ꃡ釣鋥鳧藩苫ꫭ釯蛱闳苵뫷迹裻諽濿氁䈃挅椇縉礋簍甏䴑唓␕⨗Ⱉⴛ⸝", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnConventionalButtonDatatButtonFeature_A22610LovStrs);
					this.btnConventionalButtonDatatButtonFeature_A22610.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnConventionalButtonDatatButtonFeature_A22610.DataTransferOrder = 35;
					num = (short)2110717966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛃닅ꛇ裉맋뫍꓏뷑뫓鋕맗껙뷛鳝闟雡郣觥蛧ꇩ觫韭꿯돱웳쓵컷쯹쿻", a_)))
					{
						num = (short)105644053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_47B;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1657274374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C3:
				num = (short)1070077786;
				short num3 = num;
				num = (short)1879512922;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3D8;
				case 1:
					break;
				default:
				{
					num = (short)1233387520;
					short num4 = num;
					break;
				}
				}
				num = (short)1797652480;
				if (num != 0)
				{
				}
				num = (short)2105147393;
				if (num != 0)
				{
				}
				num = (short)862388251;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AB:
				num = (short)215810061;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F8:
				num = (short)239140872;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_374:
				num = (short)1556480018;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C1:
				num = (short)1225392128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_47B:
				num = (short)839712792;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_560:
				num = (short)2131623947;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_55B:
			IL_78D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鋏ꟑꃓꋕ럗듙", a_);
			base.Id = 10090;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008E03 RID: 36355 RVA: 0x008611B8 File Offset: 0x0085F3B8
		public override void PopulateReferences()
		{
			short num = (short)639441944;
			short num2 = num;
			num = (short)1065753624;
			switch (num2 == num)
			{
			}
			num = (short)1202257921;
			if (num != 0)
			{
			}
			num = (short)950009856;
			if (num != 0)
			{
			}
			num = (short)583204864;
			short num3 = num;
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x00861260 File Offset: 0x0085F460
		public override void DropReferences()
		{
			short num = (short)494578294;
			short num2 = num;
			num = (short)325036662;
			switch (num2 == num)
			{
			}
			num = (short)1881604096;
			if (num != 0)
			{
			}
			num = (short)392560641;
			if (num != 0)
			{
			}
			num = (short)953221120;
			short num3 = num;
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x00861308 File Offset: 0x0085F508
		public override void SetConstraints()
		{
			short num = (short)1383564974;
			short num2 = num;
			num = (short)1983743662;
			switch (num2 == num)
			{
			}
			num = (short)1930166273;
			if (num != 0)
			{
			}
			num = (short)123928576;
			if (num != 0)
			{
			}
			num = (short)858587136;
			short num3 = num;
			this.btnTrunkingButtonDatatButtonFeature_A22608.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.conDataBtnTrkFeatureValid);
			this.btnTrunkingButtonDatatButtonFeature_A22608.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ConSyncTrkDataBtnFeature);
			this.btnConventionalButtonDatatButtonFeature_A22610.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ConSyncCnvDataBtnFeature);
			this.btnButtonDataButtonName_A22612.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.BtnButtonDataButtonLongPressTime.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.RadConfigDataButtonLongPressDurIsValid);
			this.BtnPortableDataButtonShortPressTime.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.RadConfigDataButtonShortPressDurIsValid);
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x0086143C File Offset: 0x0085F63C
		public override void SetupDependencies()
		{
			short num = (short)1357112003;
			short num2 = num;
			num = (short)148366019;
			switch (num2 == num)
			{
			}
			num = (short)758448128;
			if (num != 0)
			{
			}
			num = (short)1835270145;
			if (num != 0)
			{
			}
			num = (short)1603993600;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.btnTrunkingButtonDatatButtonFeature_A22608);
		}

		// Token: 0x170047AD RID: 18349
		// (get) Token: 0x06008E07 RID: 36359 RVA: 0x00861500 File Offset: 0x0085F700
		public bool HasDiffs
		{
			get
			{
				short num = (short)1858927620;
				short num2 = num;
				num = (short)690093060;
				switch (num2 == num)
				{
				}
				num = (short)987693057;
				if (num != 0)
				{
				}
				num = (short)1383530496;
				if (num != 0)
				{
				}
				num = (short)168296448;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170047AE RID: 18350
		// (get) Token: 0x06008E08 RID: 36360 RVA: 0x008615B0 File Offset: 0x0085F7B0
		// (set) Token: 0x06008E09 RID: 36361 RVA: 0x00861660 File Offset: 0x0085F860
		public int BtnTrunkingButtonDatatButtonFeature_A22608Value
		{
			get
			{
				short num = (short)1896546305;
				if (num != 0)
				{
				}
				num = (short)6348285;
				short num2 = num;
				num = (short)1026416125;
				switch (num2 == num)
				{
				}
				num = (short)1511260160;
				if (num != 0)
				{
				}
				num = (short)1860370432;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.Value;
			}
			set
			{
				short num = (short)1757008304;
				short num2 = num;
				num = (short)895799728;
				switch (num2 == num)
				{
				}
				num = (short)927924225;
				if (num != 0)
				{
				}
				num = (short)207486976;
				if (num != 0)
				{
				}
				num = (short)1984823296;
				short num3 = num;
				this.btnTrunkingButtonDatatButtonFeature_A22608.Value = value;
			}
		}

		// Token: 0x170047AF RID: 18351
		// (get) Token: 0x06008E0A RID: 36362 RVA: 0x00861718 File Offset: 0x0085F918
		// (set) Token: 0x06008E0B RID: 36363 RVA: 0x008617CC File Offset: 0x0085F9CC
		public string BtnTrunkingButtonDatatButtonFeature_A22608_UIValue
		{
			get
			{
				short num = (short)1812134888;
				short num2 = num;
				num = (short)1509948392;
				switch (num2 == num)
				{
				}
				num = (short)38404097;
				if (num != 0)
				{
				}
				num = (short)1165885440;
				if (num != 0)
				{
				}
				num = (short)1834876928;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.UIValue;
			}
			set
			{
				short num = (short)1787559937;
				if (num != 0)
				{
				}
				num = (short)891039485;
				short num2 = num;
				num = (short)1827811069;
				switch (num2 == num)
				{
				}
				num = (short)346816512;
				if (num != 0)
				{
				}
				num = (short)1970601984;
				short num3 = num;
				this.btnTrunkingButtonDatatButtonFeature_A22608.UIValue = value;
			}
		}

		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x06008E0C RID: 36364 RVA: 0x00861884 File Offset: 0x0085FA84
		public global::AcpBusinessLayer.AcpListField BtnTrunkingButtonDatatButtonFeature_A22608
		{
			get
			{
				short num = (short)970697068;
				short num2 = num;
				num = (short)682928492;
				switch (num2 == num)
				{
				}
				num = (short)1920794625;
				if (num != 0)
				{
				}
				num = (short)613875712;
				if (num != 0)
				{
				}
				num = (short)1449656320;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608;
			}
		}

		// Token: 0x170047B1 RID: 18353
		// (get) Token: 0x06008E0D RID: 36365 RVA: 0x00861934 File Offset: 0x0085FB34
		// (set) Token: 0x06008E0E RID: 36366 RVA: 0x008619E8 File Offset: 0x0085FBE8
		public bool BtnTrunkingButtonDatatButtonFeature_A22608_Applicable
		{
			get
			{
				short num = (short)572982630;
				short num2 = num;
				num = (short)1431635302;
				switch (num2 == num)
				{
				}
				num = (short)969015297;
				if (num != 0)
				{
				}
				num = (short)1744961536;
				if (num != 0)
				{
				}
				num = (short)1929838592;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.Applicable;
			}
			set
			{
				short num = (short)1488572392;
				short num2 = num;
				num = (short)1294323688;
				switch (num2 == num)
				{
				}
				num = (short)944177153;
				if (num != 0)
				{
				}
				num = (short)1265238016;
				if (num != 0)
				{
				}
				num = (short)1531248640;
				short num3 = num;
				this.btnTrunkingButtonDatatButtonFeature_A22608.Applicable = value;
			}
		}

		// Token: 0x170047B2 RID: 18354
		// (get) Token: 0x06008E0F RID: 36367 RVA: 0x00861A9C File Offset: 0x0085FC9C
		// (set) Token: 0x06008E10 RID: 36368 RVA: 0x00861B50 File Offset: 0x0085FD50
		public bool BtnTrunkingButtonDatatButtonFeature_A22608_Valid
		{
			get
			{
				short num = (short)2099813064;
				short num2 = num;
				num = (short)2053806792;
				switch (num2 == num)
				{
				}
				num = (short)1349976065;
				if (num != 0)
				{
				}
				num = (short)2103574528;
				if (num != 0)
				{
				}
				num = (short)1806499840;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.Valid;
			}
			set
			{
				short num = (short)101078972;
				short num2 = num;
				num = (short)531060668;
				switch (num2 == num)
				{
				}
				num = (short)1676017665;
				if (num != 0)
				{
				}
				num = (short)952172544;
				if (num != 0)
				{
				}
				num = (short)15925248;
				short num3 = num;
				this.btnTrunkingButtonDatatButtonFeature_A22608.Valid = value;
			}
		}

		// Token: 0x170047B3 RID: 18355
		// (get) Token: 0x06008E11 RID: 36369 RVA: 0x00861C08 File Offset: 0x0085FE08
		// (set) Token: 0x06008E12 RID: 36370 RVA: 0x00861CBC File Offset: 0x0085FEBC
		public bool BtnTrunkingButtonDatatButtonFeature_A22608_Visible
		{
			get
			{
				short num = (short)752644922;
				short num2 = num;
				num = (short)755528506;
				switch (num2 == num)
				{
				}
				num = (short)1485045760;
				if (num != 0)
				{
				}
				num = (short)1264189441;
				if (num != 0)
				{
				}
				num = (short)801374208;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.Visible;
			}
			set
			{
				short num = (short)77585716;
				short num2 = num;
				num = (short)1767169332;
				switch (num2 == num)
				{
				}
				num = (short)1250426880;
				if (num != 0)
				{
				}
				num = (short)2130182145;
				if (num != 0)
				{
				}
				num = (short)1187577856;
				short num3 = num;
				this.btnTrunkingButtonDatatButtonFeature_A22608.Visible = value;
			}
		}

		// Token: 0x170047B4 RID: 18356
		// (get) Token: 0x06008E13 RID: 36371 RVA: 0x00861D70 File Offset: 0x0085FF70
		// (set) Token: 0x06008E14 RID: 36372 RVA: 0x00861E28 File Offset: 0x00860028
		public bool BtnTrunkingButtonDatatButtonFeature_A22608_Editable
		{
			get
			{
				short num = (short)163185289;
				short num2 = num;
				num = (short)57672329;
				switch (num2 == num)
				{
				}
				num = (short)2140209152;
				if (num != 0)
				{
				}
				num = (short)293142529;
				if (num != 0)
				{
				}
				num = (short)2046623744;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.Editable;
			}
			set
			{
				short num = (short)1068348607;
				short num2 = num;
				num = (short)1255191743;
				switch (num2 == num)
				{
				}
				num = (short)400556032;
				if (num != 0)
				{
				}
				num = (short)1787166721;
				if (num != 0)
				{
				}
				num = (short)1897922560;
				short num3 = num;
				this.btnTrunkingButtonDatatButtonFeature_A22608.Editable = value;
			}
		}

		// Token: 0x170047B5 RID: 18357
		// (get) Token: 0x06008E15 RID: 36373 RVA: 0x00861EE0 File Offset: 0x008600E0
		internal string BtnTrunkingButtonDatatButtonFeature_A22608_UILabel
		{
			get
			{
				short num = (short)844822139;
				short num2 = num;
				num = (short)1102706299;
				switch (num2 == num)
				{
				}
				num = (short)1258946561;
				if (num != 0)
				{
				}
				num = (short)1691222016;
				if (num != 0)
				{
				}
				num = (short)345505792;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.UIName;
			}
		}

		// Token: 0x170047B6 RID: 18358
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x00861F94 File Offset: 0x00860194
		// (set) Token: 0x06008E17 RID: 36375 RVA: 0x00862048 File Offset: 0x00860248
		internal bool BtnTrunkingButtonDatatButtonFeature_A22608_HiddenStatic
		{
			get
			{
				short num = (short)817438980;
				short num2 = num;
				num = (short)2110398724;
				switch (num2 == num)
				{
				}
				num = (short)751239168;
				if (num != 0)
				{
				}
				num = (short)420413441;
				if (num != 0)
				{
				}
				num = (short)487129088;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.HiddenStatic;
			}
			set
			{
				short num = (short)2091175491;
				short num2 = num;
				num = (short)964808259;
				switch (num2 == num)
				{
				}
				num = (short)296550401;
				if (num != 0)
				{
				}
				num = (short)241631232;
				if (num != 0)
				{
				}
				num = (short)1027145728;
				short num3 = num;
				this.btnTrunkingButtonDatatButtonFeature_A22608.HiddenStatic = value;
			}
		}

		// Token: 0x170047B7 RID: 18359
		// (get) Token: 0x06008E18 RID: 36376 RVA: 0x008620FC File Offset: 0x008602FC
		// (set) Token: 0x06008E19 RID: 36377 RVA: 0x008621B4 File Offset: 0x008603B4
		internal bool BtnTrunkingButtonDatatButtonFeature_A22608_HiddenDynamic
		{
			get
			{
				short num = (short)19579378;
				short num2 = num;
				num = (short)477807090;
				switch (num2 == num)
				{
				}
				num = (short)1843134464;
				if (num != 0)
				{
				}
				num = (short)1945960449;
				if (num != 0)
				{
				}
				num = (short)580452352;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608.HiddenDynamic;
			}
			set
			{
				short num = (short)1595184911;
				short num2 = num;
				num = (short)2121373455;
				switch (num2 == num)
				{
				}
				num = (short)1872625664;
				if (num != 0)
				{
				}
				num = (short)1136066561;
				if (num != 0)
				{
				}
				num = (short)1128792064;
				short num3 = num;
				this.btnTrunkingButtonDatatButtonFeature_A22608.HiddenDynamic = value;
			}
		}

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x06008E1A RID: 36378 RVA: 0x00862268 File Offset: 0x00860468
		public bool BtnTrunkingButtonDatatButtonFeature_A22608_HasDiffs
		{
			get
			{
				short num = (short)1544983087;
				short num2 = num;
				num = (short)1270583855;
				switch (num2 == num)
				{
				}
				num = (short)79626241;
				if (num != 0)
				{
				}
				num = (short)661979136;
				if (num != 0)
				{
				}
				num = (short)747569152;
				short num3 = num;
				return this.btnTrunkingButtonDatatButtonFeature_A22608._HasDiffs;
			}
		}

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x00862320 File Offset: 0x00860520
		// (set) Token: 0x06008E1C RID: 36380 RVA: 0x008623D4 File Offset: 0x008605D4
		public int BtnTrunkingButtonDataButtonBCO_A22609Value
		{
			get
			{
				short num = (short)2104049396;
				short num2 = num;
				num = (short)2134785780;
				switch (num2 == num)
				{
				}
				num = (short)1658191873;
				if (num != 0)
				{
				}
				num = (short)1181614080;
				if (num != 0)
				{
				}
				num = (short)1365114880;
				short num3 = num;
				return this.btnTrunkingButtonDataButtonBCO_A22609.Value;
			}
			set
			{
				short num = (short)773198085;
				short num2 = num;
				num = (short)589959429;
				switch (num2 == num)
				{
				}
				num = (short)2036334592;
				if (num != 0)
				{
				}
				num = (short)392364033;
				if (num != 0)
				{
				}
				num = (short)1539964928;
				short num3 = num;
				this.btnTrunkingButtonDataButtonBCO_A22609.Value = value;
			}
		}

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x06008E1D RID: 36381 RVA: 0x0086248C File Offset: 0x0086068C
		// (set) Token: 0x06008E1E RID: 36382 RVA: 0x00862540 File Offset: 0x00860740
		public string BtnTrunkingButtonDataButtonBCO_A22609_UIValue
		{
			get
			{
				short num = (short)1783333787;
				short num2 = num;
				num = (short)229475227;
				switch (num2 == num)
				{
				}
				num = (short)509280257;
				if (num != 0)
				{
				}
				num = (short)1044119552;
				if (num != 0)
				{
				}
				num = (short)949288960;
				short num3 = num;
				return this.btnTrunkingButtonDataButtonBCO_A22609.UIValue;
			}
			set
			{
				short num = (short)128319489;
				if (num != 0)
				{
				}
				num = (short)671852709;
				short num2 = num;
				num = (short)634366117;
				switch (num2 == num)
				{
				}
				num = (short)2118582272;
				if (num != 0)
				{
				}
				num = (short)918290432;
				short num3 = num;
				this.btnTrunkingButtonDataButtonBCO_A22609.UIValue = value;
			}
		}

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x06008E1F RID: 36383 RVA: 0x008625F8 File Offset: 0x008607F8
		public global::AcpBusinessLayer.AcpListField BtnTrunkingButtonDataButtonBCO_A22609
		{
			get
			{
				short num = (short)1810041213;
				short num2 = num;
				num = (short)405080445;
				switch (num2 == num)
				{
				}
				num = (short)1447755777;
				if (num != 0)
				{
				}
				num = (short)361627648;
				if (num != 0)
				{
				}
				num = (short)161611776;
				short num3 = num;
				return this.btnTrunkingButtonDataButtonBCO_A22609;
			}
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x06008E20 RID: 36384 RVA: 0x008626A4 File Offset: 0x008608A4
		// (set) Token: 0x06008E21 RID: 36385 RVA: 0x00862758 File Offset: 0x00860958
		public bool BtnTrunkingButtonDataButtonBCO_A22609_Applicable
		{
			get
			{
				short num = (short)1658779506;
				short num2 = num;
				num = (short)115537778;
				switch (num2 == num)
				{
				}
				num = (short)89456640;
				if (num != 0)
				{
				}
				num = (short)31522817;
				if (num != 0)
				{
				}
				num = (short)1984364544;
				short num3 = num;
				return this.btnTrunkingButtonDataButtonBCO_A22609.Applicable;
			}
			set
			{
				short num = (short)888656009;
				short num2 = num;
				num = (short)322162825;
				switch (num2 == num)
				{
				}
				num = (short)1964441601;
				if (num != 0)
				{
				}
				num = (short)220266496;
				if (num != 0)
				{
				}
				num = (short)1530331136;
				short num3 = num;
				this.btnTrunkingButtonDataButtonBCO_A22609.Applicable = value;
			}
		}

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x06008E22 RID: 36386 RVA: 0x00862810 File Offset: 0x00860A10
		// (set) Token: 0x06008E23 RID: 36387 RVA: 0x008628C4 File Offset: 0x00860AC4
		public bool BtnTrunkingButtonDataButtonBCO_A22609_Valid
		{
			get
			{
				short num = (short)1940210520;
				short num2 = num;
				num = (short)1919828824;
				switch (num2 == num)
				{
				}
				num = (short)1842741249;
				if (num != 0)
				{
				}
				num = (short)1122893824;
				if (num != 0)
				{
				}
				num = (short)786432000;
				short num3 = num;
				return this.btnTrunkingButtonDataButtonBCO_A22609.Valid;
			}
			set
			{
				short num = (short)33191782;
				short num2 = num;
				num = (short)1998026598;
				switch (num2 == num)
				{
				}
				num = (short)2059862017;
				if (num != 0)
				{
				}
				num = (short)813563904;
				if (num != 0)
				{
				}
				num = (short)29229056;
				short num3 = num;
				this.btnTrunkingButtonDataButtonBCO_A22609.Valid = value;
			}
		}

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x06008E24 RID: 36388 RVA: 0x00862978 File Offset: 0x00860B78
		// (set) Token: 0x06008E25 RID: 36389 RVA: 0x00862A30 File Offset: 0x00860C30
		public bool BtnTrunkingButtonDataButtonBCO_A22609_Visible
		{
			get
			{
				short num = (short)1077675887;
				short num2 = num;
				num = (short)745211759;
				switch (num2 == num)
				{
				}
				num = (short)72286209;
				if (num != 0)
				{
				}
				num = (short)385024000;
				if (num != 0)
				{
				}
				num = (short)2118189056;
				short num3 = num;
				return this.btnTrunkingButtonDataButtonBCO_A22609.Visible;
			}
			set
			{
				short num = (short)1329434541;
				short num2 = num;
				num = (short)1260031917;
				switch (num2 == num)
				{
				}
				num = (short)1696464897;
				if (num != 0)
				{
				}
				num = (short)1588461568;
				if (num != 0)
				{
				}
				num = (short)1247543296;
				short num3 = num;
				this.btnTrunkingButtonDataButtonBCO_A22609.Visible = value;
			}
		}

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x06008E26 RID: 36390 RVA: 0x00862AE8 File Offset: 0x00860CE8
		// (set) Token: 0x06008E27 RID: 36391 RVA: 0x00862B9C File Offset: 0x00860D9C
		public bool BtnTrunkingButtonDataButtonBCO_A22609_Editable
		{
			get
			{
				short num = (short)1489324575;
				short num2 = num;
				num = (short)173427231;
				switch (num2 == num)
				{
				}
				num = (short)326369281;
				if (num != 0)
				{
				}
				num = (short)1228472320;
				if (num != 0)
				{
				}
				num = (short)277348352;
				short num3 = num;
				return this.btnTrunkingButtonDataButtonBCO_A22609.Editable;
			}
			set
			{
				short num = (short)1062573893;
				short num2 = num;
				num = (short)553293637;
				switch (num2 == num)
				{
				}
				num = (short)1839726593;
				if (num != 0)
				{
				}
				num = (short)456982528;
				if (num != 0)
				{
				}
				num = (short)1874132992;
				short num3 = num;
				this.btnTrunkingButtonDataButtonBCO_A22609.Editable = value;
			}
		}

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x00862C50 File Offset: 0x00860E50
		internal string BtnTrunkingButtonDataButtonBCO_A22609_UILabel
		{
			get
			{
				short num = (short)664373656;
				short num2 = num;
				num = (short)1743620504;
				switch (num2 == num)
				{
				}
				num = (short)626851841;
				if (num != 0)
				{
				}
				num = (short)1064435712;
				if (num != 0)
				{
				}
				num = (short)1098711040;
				short num3 = num;
				return this.btnTrunkingButtonDataButtonBCO_A22609.UIName;
			}
		}

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x06008E29 RID: 36393 RVA: 0x00862D04 File Offset: 0x00860F04
		// (set) Token: 0x06008E2A RID: 36394 RVA: 0x00862DB8 File Offset: 0x00860FB8
		internal bool BtnTrunkingButtonDataButtonBCO_A22609_HiddenStatic
		{
			get
			{
				short num = (short)1172442532;
				short num2 = num;
				num = (short)1197739428;
				switch (num2 == num)
				{
				}
				num = (short)1171062784;
				short num3 = num;
				num = (short)1613299712;
				if (num != 0)
				{
				}
				num = (short)1739718657;
				if (num != 0)
				{
				}
				return this.btnTrunkingButtonDataButtonBCO_A22609.HiddenStatic;
			}
			set
			{
				short num = (short)11556549;
				short num2 = num;
				num = (short)462116549;
				switch (num2 == num)
				{
				}
				num = (short)1038680064;
				short num3 = num;
				num = (short)575537153;
				if (num != 0)
				{
				}
				num = (short)1001717760;
				if (num != 0)
				{
				}
				this.btnTrunkingButtonDataButtonBCO_A22609.HiddenStatic = value;
			}
		}

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x06008E2B RID: 36395 RVA: 0x00862E70 File Offset: 0x00861070
		// (set) Token: 0x06008E2C RID: 36396 RVA: 0x00862F28 File Offset: 0x00861128
		internal bool BtnTrunkingButtonDataButtonBCO_A22609_HiddenDynamic
		{
			get
			{
				short num = (short)2020653683;
				short num2 = num;
				num = (short)351386227;
				switch (num2 == num)
				{
				}
				num = (short)737542144;
				short num3 = num;
				num = (short)58130433;
				if (num != 0)
				{
				}
				num = (short)1089798144;
				if (num != 0)
				{
				}
				return this.btnTrunkingButtonDataButtonBCO_A22609.HiddenDynamic;
			}
			set
			{
				short num = (short)99987454;
				short num2 = num;
				num = (short)187609086;
				switch (num2 == num)
				{
				}
				num = (short)61603840;
				short num3 = num;
				num = (short)779616257;
				if (num != 0)
				{
				}
				num = (short)508690432;
				if (num != 0)
				{
				}
				this.btnTrunkingButtonDataButtonBCO_A22609.HiddenDynamic = value;
			}
		}

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x06008E2D RID: 36397 RVA: 0x00862FDC File Offset: 0x008611DC
		public bool BtnTrunkingButtonDataButtonBCO_A22609_HasDiffs
		{
			get
			{
				short num = (short)499817398;
				short num2 = num;
				num = (short)2052234166;
				switch (num2 == num)
				{
				}
				num = (short)2017394688;
				short num3 = num;
				num = (short)467271680;
				if (num != 0)
				{
				}
				num = (short)1110310913;
				if (num != 0)
				{
				}
				return this.btnTrunkingButtonDataButtonBCO_A22609._HasDiffs;
			}
		}

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x00863094 File Offset: 0x00861294
		// (set) Token: 0x06008E2F RID: 36399 RVA: 0x00863148 File Offset: 0x00861348
		public int BtnConventionalButtonDatatButtonFeature_A22610Value
		{
			get
			{
				short num = (short)536543233;
				if (num != 0)
				{
				}
				num = (short)1506816259;
				short num2 = num;
				num = (short)473903363;
				switch (num2 == num)
				{
				default:
				{
					num = (short)32047104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1712914432;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.Value;
			}
			set
			{
				short num = (short)399136807;
				short num2 = num;
				num = (short)521558055;
				switch (num2 == num)
				{
				}
				num = (short)1081868288;
				short num3 = num;
				num = (short)2033713153;
				if (num != 0)
				{
				}
				num = (short)1686241280;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDatatButtonFeature_A22610.Value = value;
			}
		}

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x06008E30 RID: 36400 RVA: 0x00863200 File Offset: 0x00861400
		// (set) Token: 0x06008E31 RID: 36401 RVA: 0x008632B8 File Offset: 0x008614B8
		public string BtnConventionalButtonDatatButtonFeature_A22610_UIValue
		{
			get
			{
				short num = (short)241828811;
				short num2 = num;
				num = (short)1571619787;
				switch (num2 == num)
				{
				}
				num = (short)1785266176;
				short num3 = num;
				num = (short)2079260673;
				if (num != 0)
				{
				}
				num = (short)1050214400;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.UIValue;
			}
			set
			{
				short num = (short)1087285610;
				short num2 = num;
				num = (short)1176086890;
				switch (num2 == num)
				{
				}
				num = (short)1353908224;
				short num3 = num;
				num = (short)273612800;
				if (num != 0)
				{
				}
				num = (short)2144665601;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDatatButtonFeature_A22610.UIValue = value;
			}
		}

		// Token: 0x170047C6 RID: 18374
		// (get) Token: 0x06008E32 RID: 36402 RVA: 0x0086336C File Offset: 0x0086156C
		public global::AcpBusinessLayer.AcpListField BtnConventionalButtonDatatButtonFeature_A22610
		{
			get
			{
				short num = (short)1680298208;
				short num2 = num;
				num = (short)366104800;
				switch (num2 == num)
				{
				}
				num = (short)344457216;
				short num3 = num;
				num = (short)2009530368;
				if (num != 0)
				{
				}
				num = (short)278331393;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610;
			}
		}

		// Token: 0x170047C7 RID: 18375
		// (get) Token: 0x06008E33 RID: 36403 RVA: 0x00863418 File Offset: 0x00861618
		// (set) Token: 0x06008E34 RID: 36404 RVA: 0x008634D0 File Offset: 0x008616D0
		public bool BtnConventionalButtonDatatButtonFeature_A22610_Applicable
		{
			get
			{
				short num = (short)855364651;
				short num2 = num;
				num = (short)1135531051;
				switch (num2 == num)
				{
				}
				num = (short)899481600;
				short num3 = num;
				num = (short)1566900225;
				if (num != 0)
				{
				}
				num = (short)1196425216;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.Applicable;
			}
			set
			{
				short num = (short)931986560;
				short num2 = num;
				num = (short)1252523136;
				switch (num2 == num)
				{
				}
				num = (short)1447165952;
				short num3 = num;
				num = (short)574291969;
				if (num != 0)
				{
				}
				num = (short)1514995712;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDatatButtonFeature_A22610.Applicable = value;
			}
		}

		// Token: 0x170047C8 RID: 18376
		// (get) Token: 0x06008E35 RID: 36405 RVA: 0x00863588 File Offset: 0x00861788
		// (set) Token: 0x06008E36 RID: 36406 RVA: 0x0086363C File Offset: 0x0086183C
		public bool BtnConventionalButtonDatatButtonFeature_A22610_Valid
		{
			get
			{
				short num = (short)947498158;
				short num2 = num;
				num = (short)1559342254;
				switch (num2 == num)
				{
				}
				num = (short)865927168;
				short num3 = num;
				num = (short)2022965248;
				if (num != 0)
				{
				}
				num = (short)930480129;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.Valid;
			}
			set
			{
				short num = (short)1940491782;
				short num2 = num;
				num = (short)369724934;
				switch (num2 == num)
				{
				}
				num = (short)403636224;
				short num3 = num;
				num = (short)1586102273;
				if (num != 0)
				{
				}
				num = (short)1928593408;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDatatButtonFeature_A22610.Valid = value;
			}
		}

		// Token: 0x170047C9 RID: 18377
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x008636F4 File Offset: 0x008618F4
		// (set) Token: 0x06008E38 RID: 36408 RVA: 0x008637A8 File Offset: 0x008619A8
		public bool BtnConventionalButtonDatatButtonFeature_A22610_Visible
		{
			get
			{
				short num = (short)689605641;
				short num2 = num;
				num = (short)2065009673;
				switch (num2 == num)
				{
				}
				num = (short)1470169088;
				short num3 = num;
				num = (short)1038024704;
				if (num != 0)
				{
				}
				num = (short)733872129;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.Visible;
			}
			set
			{
				short num = (short)1744640687;
				short num2 = num;
				num = (short)1997609647;
				switch (num2 == num)
				{
				}
				num = (short)1062862848;
				short num3 = num;
				num = (short)1948385281;
				if (num != 0)
				{
				}
				num = (short)1996881920;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDatatButtonFeature_A22610.Visible = value;
			}
		}

		// Token: 0x170047CA RID: 18378
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x00863860 File Offset: 0x00861A60
		// (set) Token: 0x06008E3A RID: 36410 RVA: 0x00863914 File Offset: 0x00861B14
		public bool BtnConventionalButtonDatatButtonFeature_A22610_Editable
		{
			get
			{
				short num = (short)2096974102;
				short num2 = num;
				num = (short)1459505430;
				switch (num2 == num)
				{
				}
				num = (short)1160773632;
				short num3 = num;
				num = (short)1631125505;
				if (num != 0)
				{
				}
				num = (short)1662451712;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.Editable;
			}
			set
			{
				short num = (short)44849701;
				short num2 = num;
				num = (short)1616992805;
				switch (num2 == num)
				{
				}
				num = (short)270270464;
				short num3 = num;
				num = (short)746061825;
				if (num != 0)
				{
				}
				num = (short)345374720;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDatatButtonFeature_A22610.Editable = value;
			}
		}

		// Token: 0x170047CB RID: 18379
		// (get) Token: 0x06008E3B RID: 36411 RVA: 0x008639C8 File Offset: 0x00861BC8
		internal string BtnConventionalButtonDatatButtonFeature_A22610_UILabel
		{
			get
			{
				short num = (short)1488458598;
				short num2 = num;
				num = (short)509612902;
				switch (num2 == num)
				{
				}
				num = (short)1383923712;
				short num3 = num;
				num = (short)633012225;
				if (num != 0)
				{
				}
				num = (short)627441664;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.UIName;
			}
		}

		// Token: 0x170047CC RID: 18380
		// (get) Token: 0x06008E3C RID: 36412 RVA: 0x00863A80 File Offset: 0x00861C80
		// (set) Token: 0x06008E3D RID: 36413 RVA: 0x00863B38 File Offset: 0x00861D38
		internal bool BtnConventionalButtonDatatButtonFeature_A22610_HiddenStatic
		{
			get
			{
				short num = (short)450491518;
				short num2 = num;
				num = (short)1505162366;
				switch (num2 == num)
				{
				}
				num = (short)590807040;
				short num3 = num;
				num = (short)343801856;
				if (num != 0)
				{
				}
				num = (short)767426561;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.HiddenStatic;
			}
			set
			{
				short num = (short)361472974;
				short num2 = num;
				num = (short)2130486222;
				switch (num2 == num)
				{
				}
				num = (short)280821760;
				short num3 = num;
				num = (short)1755185153;
				if (num != 0)
				{
				}
				num = (short)121765888;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDatatButtonFeature_A22610.HiddenStatic = value;
			}
		}

		// Token: 0x170047CD RID: 18381
		// (get) Token: 0x06008E3E RID: 36414 RVA: 0x00863BF4 File Offset: 0x00861DF4
		// (set) Token: 0x06008E3F RID: 36415 RVA: 0x00863CA8 File Offset: 0x00861EA8
		internal bool BtnConventionalButtonDatatButtonFeature_A22610_HiddenDynamic
		{
			get
			{
				short num = (short)1837755135;
				short num2 = num;
				num = (short)55634687;
				switch (num2 == num)
				{
				}
				num = (short)1047986176;
				short num3 = num;
				num = (short)2140012545;
				if (num != 0)
				{
				}
				num = (short)1179713536;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610.HiddenDynamic;
			}
			set
			{
				short num = (short)90724962;
				short num2 = num;
				num = (short)1657100898;
				switch (num2 == num)
				{
				}
				num = (short)632094720;
				short num3 = num;
				num = (short)1143537664;
				if (num != 0)
				{
				}
				num = (short)1662189569;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDatatButtonFeature_A22610.HiddenDynamic = value;
			}
		}

		// Token: 0x170047CE RID: 18382
		// (get) Token: 0x06008E40 RID: 36416 RVA: 0x00863D5C File Offset: 0x00861F5C
		public bool BtnConventionalButtonDatatButtonFeature_A22610_HasDiffs
		{
			get
			{
				short num = (short)599140619;
				short num2 = num;
				num = (short)111683851;
				switch (num2 == num)
				{
				}
				num = (short)308740096;
				short num3 = num;
				num = (short)1816788993;
				if (num != 0)
				{
				}
				num = (short)1985871872;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDatatButtonFeature_A22610._HasDiffs;
			}
		}

		// Token: 0x170047CF RID: 18383
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x00863E10 File Offset: 0x00862010
		// (set) Token: 0x06008E42 RID: 36418 RVA: 0x00863EC0 File Offset: 0x008620C0
		public int BtnConventionalButtonDataButtonBCO_A22611Value
		{
			get
			{
				short num = (short)769127018;
				short num2 = num;
				num = (short)750776938;
				switch (num2 == num)
				{
				}
				num = (short)720175104;
				short num3 = num;
				num = (short)1233649664;
				if (num != 0)
				{
				}
				num = (short)249495553;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.Value;
			}
			set
			{
				short num = (short)308950922;
				short num2 = num;
				num = (short)711407498;
				switch (num2 == num)
				{
				}
				num = (short)334036992;
				short num3 = num;
				num = (short)1807745025;
				if (num != 0)
				{
				}
				num = (short)322699264;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDataButtonBCO_A22611.Value = value;
			}
		}

		// Token: 0x170047D0 RID: 18384
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x00863F74 File Offset: 0x00862174
		// (set) Token: 0x06008E44 RID: 36420 RVA: 0x00864028 File Offset: 0x00862228
		public string BtnConventionalButtonDataButtonBCO_A22611_UIValue
		{
			get
			{
				short num = (short)1757927650;
				short num2 = num;
				num = (short)1815992546;
				switch (num2 == num)
				{
				}
				num = (short)537657344;
				short num3 = num;
				num = (short)1528430593;
				if (num != 0)
				{
				}
				num = (short)1035141120;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.UIValue;
			}
			set
			{
				short num = (short)935445005;
				short num2 = num;
				num = (short)292930061;
				switch (num2 == num)
				{
				}
				num = (short)1657274368;
				short num3 = num;
				num = (short)888406017;
				if (num != 0)
				{
				}
				num = (short)359399424;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDataButtonBCO_A22611.UIValue = value;
			}
		}

		// Token: 0x170047D1 RID: 18385
		// (get) Token: 0x06008E45 RID: 36421 RVA: 0x008640E0 File Offset: 0x008622E0
		public global::AcpBusinessLayer.AcpListField BtnConventionalButtonDataButtonBCO_A22611
		{
			get
			{
				short num = (short)1019566209;
				short num2 = num;
				num = (short)745035905;
				switch (num2 == num)
				{
				}
				num = (short)1866072064;
				short num3 = num;
				num = (short)1970798593;
				if (num != 0)
				{
				}
				num = (short)159842304;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611;
			}
		}

		// Token: 0x170047D2 RID: 18386
		// (get) Token: 0x06008E46 RID: 36422 RVA: 0x00864190 File Offset: 0x00862390
		// (set) Token: 0x06008E47 RID: 36423 RVA: 0x00864244 File Offset: 0x00862444
		public bool BtnConventionalButtonDataButtonBCO_A22611_Applicable
		{
			get
			{
				short num = (short)1632932697;
				short num2 = num;
				num = (short)694850393;
				switch (num2 == num)
				{
				}
				num = (short)794689536;
				short num3 = num;
				num = (short)2110062592;
				if (num != 0)
				{
				}
				num = (short)693043201;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.Applicable;
			}
			set
			{
				short num = (short)1854523406;
				short num2 = num;
				num = (short)934987790;
				switch (num2 == num)
				{
				}
				num = (short)1360986112;
				short num3 = num;
				num = (short)502726657;
				if (num != 0)
				{
				}
				num = (short)323223552;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDataButtonBCO_A22611.Applicable = value;
			}
		}

		// Token: 0x170047D3 RID: 18387
		// (get) Token: 0x06008E48 RID: 36424 RVA: 0x008642FC File Offset: 0x008624FC
		// (set) Token: 0x06008E49 RID: 36425 RVA: 0x008643B4 File Offset: 0x008625B4
		public bool BtnConventionalButtonDataButtonBCO_A22611_Valid
		{
			get
			{
				short num = (short)1845176602;
				short num2 = num;
				num = (short)1178347802;
				switch (num2 == num)
				{
				}
				num = (short)11141120;
				short num3 = num;
				num = (short)704708609;
				if (num != 0)
				{
				}
				num = (short)1051131904;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.Valid;
			}
			set
			{
				short num = (short)1556104686;
				short num2 = num;
				num = (short)1729644014;
				switch (num2 == num)
				{
				}
				num = (short)1889927168;
				short num3 = num;
				num = (short)1942487041;
				if (num != 0)
				{
				}
				num = (short)1926168576;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDataButtonBCO_A22611.Valid = value;
			}
		}

		// Token: 0x170047D4 RID: 18388
		// (get) Token: 0x06008E4A RID: 36426 RVA: 0x00864468 File Offset: 0x00862668
		// (set) Token: 0x06008E4B RID: 36427 RVA: 0x0086451C File Offset: 0x0086271C
		public bool BtnConventionalButtonDataButtonBCO_A22611_Visible
		{
			get
			{
				short num = (short)257652977;
				short num2 = num;
				num = (short)1940224241;
				switch (num2 == num)
				{
				}
				num = (short)2046951424;
				short num3 = num;
				num = (short)298975233;
				if (num != 0)
				{
				}
				num = (short)1726021632;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.Visible;
			}
			set
			{
				short num = (short)839821082;
				short num2 = num;
				num = (short)1154524954;
				switch (num2 == num)
				{
				}
				num = (short)213450752;
				short num3 = num;
				num = (short)225443840;
				if (num != 0)
				{
				}
				num = (short)1271136257;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDataButtonBCO_A22611.Visible = value;
			}
		}

		// Token: 0x170047D5 RID: 18389
		// (get) Token: 0x06008E4C RID: 36428 RVA: 0x008645D0 File Offset: 0x008627D0
		// (set) Token: 0x06008E4D RID: 36429 RVA: 0x00864688 File Offset: 0x00862888
		public bool BtnConventionalButtonDataButtonBCO_A22611_Editable
		{
			get
			{
				short num = (short)1507041205;
				short num2 = num;
				num = (short)499097525;
				switch (num2 == num)
				{
				}
				num = (short)945684480;
				short num3 = num;
				num = (short)425394176;
				if (num != 0)
				{
				}
				num = (short)878051329;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.Editable;
			}
			set
			{
				short num = (short)142239377;
				short num2 = num;
				num = (short)1241081489;
				switch (num2 == num)
				{
				}
				num = (short)128319488;
				short num3 = num;
				num = (short)646447104;
				if (num != 0)
				{
				}
				num = (short)1695023105;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDataButtonBCO_A22611.Editable = value;
			}
		}

		// Token: 0x170047D6 RID: 18390
		// (get) Token: 0x06008E4E RID: 36430 RVA: 0x00864740 File Offset: 0x00862940
		internal string BtnConventionalButtonDataButtonBCO_A22611_UILabel
		{
			get
			{
				short num = (short)1669865029;
				short num2 = num;
				num = (short)1038294597;
				switch (num2 == num)
				{
				}
				num = (short)474873856;
				short num3 = num;
				num = (short)712245249;
				if (num != 0)
				{
				}
				num = (short)848625664;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.UIName;
			}
		}

		// Token: 0x170047D7 RID: 18391
		// (get) Token: 0x06008E4F RID: 36431 RVA: 0x008647F4 File Offset: 0x008629F4
		// (set) Token: 0x06008E50 RID: 36432 RVA: 0x008648AC File Offset: 0x00862AAC
		internal bool BtnConventionalButtonDataButtonBCO_A22611_HiddenStatic
		{
			get
			{
				short num = (short)1405298235;
				short num2 = num;
				num = (short)1002710587;
				switch (num2 == num)
				{
				}
				num = (short)400556032;
				short num3 = num;
				num = (short)776404992;
				if (num != 0)
				{
				}
				num = (short)1346699265;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.HiddenStatic;
			}
			set
			{
				short num = (short)51930636;
				short num2 = num;
				num = (short)1261856268;
				switch (num2 == num)
				{
				}
				num = (short)200343552;
				short num3 = num;
				num = (short)1514012672;
				if (num != 0)
				{
				}
				num = (short)1433600001;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDataButtonBCO_A22611.HiddenStatic = value;
			}
		}

		// Token: 0x170047D8 RID: 18392
		// (get) Token: 0x06008E51 RID: 36433 RVA: 0x00864964 File Offset: 0x00862B64
		// (set) Token: 0x06008E52 RID: 36434 RVA: 0x00864A18 File Offset: 0x00862C18
		internal bool BtnConventionalButtonDataButtonBCO_A22611_HiddenDynamic
		{
			get
			{
				short num = (short)935198721;
				if (num != 0)
				{
				}
				num = (short)728250888;
				short num2 = num;
				num = (short)1587427848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231211008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17498112;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611.HiddenDynamic;
			}
			set
			{
				short num = (short)125909800;
				short num2 = num;
				num = (short)1267743528;
				switch (num2 == num)
				{
				}
				num = (short)887881728;
				short num3 = num;
				num = (short)714604545;
				if (num != 0)
				{
				}
				num = (short)882966528;
				if (num != 0)
				{
				}
				this.btnConventionalButtonDataButtonBCO_A22611.HiddenDynamic = value;
			}
		}

		// Token: 0x170047D9 RID: 18393
		// (get) Token: 0x06008E53 RID: 36435 RVA: 0x00864ACC File Offset: 0x00862CCC
		public bool BtnConventionalButtonDataButtonBCO_A22611_HasDiffs
		{
			get
			{
				short num = (short)334168065;
				if (num != 0)
				{
				}
				num = (short)1711499162;
				short num2 = num;
				num = (short)1869506458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478937088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1101332480;
				if (num != 0)
				{
				}
				return this.btnConventionalButtonDataButtonBCO_A22611._HasDiffs;
			}
		}

		// Token: 0x170047DA RID: 18394
		// (get) Token: 0x06008E54 RID: 36436 RVA: 0x00864B80 File Offset: 0x00862D80
		// (set) Token: 0x06008E55 RID: 36437 RVA: 0x00864C34 File Offset: 0x00862E34
		public string BtnButtonDataButtonName_A22612Value
		{
			get
			{
				short num = (short)1175663291;
				short num2 = num;
				num = (short)2089038523;
				switch (num2 == num)
				{
				}
				num = (short)5242880;
				short num3 = num;
				num = (short)526450689;
				if (num != 0)
				{
				}
				num = (short)277676032;
				if (num != 0)
				{
				}
				return this.btnButtonDataButtonName_A22612.Value;
			}
			set
			{
				short num = (short)2023806073;
				short num2 = num;
				num = (short)1723520121;
				switch (num2 == num)
				{
				}
				num = (short)444792832;
				short num3 = num;
				num = (short)1284505600;
				if (num != 0)
				{
				}
				num = (short)420413441;
				if (num != 0)
				{
				}
				this.btnButtonDataButtonName_A22612.Value = value;
			}
		}

		// Token: 0x170047DB RID: 18395
		// (get) Token: 0x06008E56 RID: 36438 RVA: 0x00864CE8 File Offset: 0x00862EE8
		public global::AcpBusinessLayer.AcpField<string> BtnButtonDataButtonName_A22612
		{
			get
			{
				short num = (short)264572157;
				short num2 = num;
				num = (short)352914685;
				switch (num2 == num)
				{
				}
				num = (short)1241317376;
				short num3 = num;
				num = (short)827326464;
				if (num != 0)
				{
				}
				num = (short)1741553665;
				if (num != 0)
				{
				}
				return this.btnButtonDataButtonName_A22612;
			}
		}

		// Token: 0x170047DC RID: 18396
		// (get) Token: 0x06008E57 RID: 36439 RVA: 0x00864D94 File Offset: 0x00862F94
		// (set) Token: 0x06008E58 RID: 36440 RVA: 0x00864E48 File Offset: 0x00863048
		public string BtnButtonDataButtonName_A22612_UIValue
		{
			get
			{
				short num = (short)81218244;
				short num2 = num;
				num = (short)1910590148;
				switch (num2 == num)
				{
				}
				num = (short)25886720;
				short num3 = num;
				num = (short)2013724672;
				if (num != 0)
				{
				}
				num = (short)1370619905;
				if (num != 0)
				{
				}
				return this.btnButtonDataButtonName_A22612.Value;
			}
			set
			{
				short num = (short)1505247875;
				short num2 = num;
				num = (short)130695811;
				switch (num2 == num)
				{
				}
				num = (short)313524224;
				short num3 = num;
				num = (short)953221120;
				if (num != 0)
				{
				}
				num = (short)1738932225;
				if (num != 0)
				{
				}
				this.btnButtonDataButtonName_A22612.Value = value;
			}
		}

		// Token: 0x170047DD RID: 18397
		// (get) Token: 0x06008E59 RID: 36441 RVA: 0x00864F00 File Offset: 0x00863100
		// (set) Token: 0x06008E5A RID: 36442 RVA: 0x00864FB4 File Offset: 0x008631B4
		public bool BtnButtonDataButtonName_A22612_Applicable
		{
			get
			{
				short num = (short)805287758;
				short num2 = num;
				num = (short)1646573390;
				switch (num2 == num)
				{
				}
				num = (short)96403456;
				short num3 = num;
				num = (short)1279066113;
				if (num != 0)
				{
				}
				num = (short)977600512;
				if (num != 0)
				{
				}
				return this.btnButtonDataButtonName_A22612.Applicable;
			}
			set
			{
				short num = (short)805985463;
				short num2 = num;
				num = (short)405167287;
				switch (num2 == num)
				{
				}
				num = (short)386334720;
				short num3 = num;
				num = (short)84672513;
				if (num != 0)
				{
				}
				num = (short)2041446400;
				if (num != 0)
				{
				}
				this.btnButtonDataButtonName_A22612.Applicable = value;
			}
		}

		// Token: 0x170047DE RID: 18398
		// (get) Token: 0x06008E5B RID: 36443 RVA: 0x0086506C File Offset: 0x0086326C
		// (set) Token: 0x06008E5C RID: 36444 RVA: 0x00865124 File Offset: 0x00863324
		public bool BtnButtonDataButtonName_A22612_Valid
		{
			get
			{
				short num = (short)1792409601;
				if (num != 0)
				{
				}
				num = (short)917945944;
				short num2 = num;
				num = (short)1948696152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1170407424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2102722560;
				if (num != 0)
				{
				}
				return this.btnButtonDataButtonName_A22612.Valid;
			}
			set
			{
				short num = (short)2036675975;
				short num2 = num;
				num = (short)1360868743;
				switch (num2 == num)
				{
				}
				num = (short)63176704;
				short num3 = num;
				num = (short)296026112;
				if (num != 0)
				{
				}
				num = (short)2140733441;
				if (num != 0)
				{
				}
				this.btnButtonDataButtonName_A22612.Valid = value;
			}
		}

		// Token: 0x170047DF RID: 18399
		// (get) Token: 0x06008E5D RID: 36445 RVA: 0x008651D8 File Offset: 0x008633D8
		// (set) Token: 0x06008E5E RID: 36446 RVA: 0x0086528C File Offset: 0x0086348C
		public bool BtnButtonDataButtonName_A22612_Visible
		{
			get
			{
				short num = (short)264896513;
				if (num != 0)
				{
				}
				num = (short)1325545144;
				short num2 = num;
				num = (short)2119907000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872494592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1078591488;
				if (num != 0)
				{
				}
				return this.btnButtonDataButtonName_A22612.Visible;
			}
			set
			{
				short num = (short)962503366;
				short num2 = num;
				num = (short)1155113670;
				switch (num2 == num)
				{
				}
				num = (short)1583349761;
				if (num != 0)
				{
				}
				num = (short)511770624;
				if (num != 0)
				{
				}
				num = (short)1007747072;
				short num3 = num;
				this.btnButtonDataButtonName_A22612.Visible = value;
			}
		}

		// Token: 0x170047E0 RID: 18400
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x00865340 File Offset: 0x00863540
		// (set) Token: 0x06008E60 RID: 36448 RVA: 0x008653F8 File Offset: 0x008635F8
		public bool BtnButtonDataButtonName_A22612_Editable
		{
			get
			{
				short num = (short)425715145;
				short num2 = num;
				num = (short)1888871881;
				switch (num2 == num)
				{
				}
				num = (short)1939079168;
				if (num != 0)
				{
				}
				num = (short)1650458625;
				if (num != 0)
				{
				}
				num = (short)529596416;
				short num3 = num;
				return this.btnButtonDataButtonName_A22612.Editable;
			}
			set
			{
				short num = (short)793125541;
				short num2 = num;
				num = (short)1276256933;
				switch (num2 == num)
				{
				}
				num = (short)938868737;
				if (num != 0)
				{
				}
				num = (short)191365120;
				if (num != 0)
				{
				}
				num = (short)1471283200;
				short num3 = num;
				this.btnButtonDataButtonName_A22612.Editable = value;
			}
		}

		// Token: 0x170047E1 RID: 18401
		// (get) Token: 0x06008E61 RID: 36449 RVA: 0x008654B0 File Offset: 0x008636B0
		internal string BtnButtonDataButtonName_A22612_UILabel
		{
			get
			{
				short num = (short)444726371;
				short num2 = num;
				num = (short)925236323;
				switch (num2 == num)
				{
				}
				num = (short)204931073;
				if (num != 0)
				{
				}
				num = (short)5046272;
				if (num != 0)
				{
				}
				num = (short)1089929216;
				short num3 = num;
				return this.btnButtonDataButtonName_A22612.UIName;
			}
		}

		// Token: 0x170047E2 RID: 18402
		// (get) Token: 0x06008E62 RID: 36450 RVA: 0x00865568 File Offset: 0x00863768
		// (set) Token: 0x06008E63 RID: 36451 RVA: 0x00865620 File Offset: 0x00863820
		internal bool BtnButtonDataButtonName_A22612_HiddenStatic
		{
			get
			{
				short num = (short)484544872;
				short num2 = num;
				num = (short)2055901544;
				switch (num2 == num)
				{
				}
				num = (short)988938240;
				if (num != 0)
				{
				}
				num = (short)480313345;
				if (num != 0)
				{
				}
				num = (short)374669312;
				short num3 = num;
				return this.btnButtonDataButtonName_A22612.HiddenStatic;
			}
			set
			{
				short num = (short)1117830547;
				short num2 = num;
				num = (short)1210957203;
				switch (num2 == num)
				{
				}
				num = (short)324665345;
				if (num != 0)
				{
				}
				num = (short)678363136;
				if (num != 0)
				{
				}
				num = (short)271777792;
				short num3 = num;
				this.btnButtonDataButtonName_A22612.HiddenStatic = value;
			}
		}

		// Token: 0x170047E3 RID: 18403
		// (get) Token: 0x06008E64 RID: 36452 RVA: 0x008656D4 File Offset: 0x008638D4
		// (set) Token: 0x06008E65 RID: 36453 RVA: 0x00865788 File Offset: 0x00863988
		internal bool BtnButtonDataButtonName_A22612_HiddenDynamic
		{
			get
			{
				short num = (short)1331127339;
				short num2 = num;
				num = (short)809985067;
				switch (num2 == num)
				{
				}
				num = (short)1303052289;
				if (num != 0)
				{
				}
				num = (short)1556873216;
				if (num != 0)
				{
				}
				num = (short)1587085312;
				short num3 = num;
				return this.btnButtonDataButtonName_A22612.HiddenDynamic;
			}
			set
			{
				short num = (short)1275418656;
				short num2 = num;
				num = (short)356145184;
				switch (num2 == num)
				{
				}
				num = (short)1788411905;
				if (num != 0)
				{
				}
				num = (short)1412694016;
				if (num != 0)
				{
				}
				num = (short)668598272;
				short num3 = num;
				this.btnButtonDataButtonName_A22612.HiddenDynamic = value;
			}
		}

		// Token: 0x170047E4 RID: 18404
		// (get) Token: 0x06008E66 RID: 36454 RVA: 0x0086583C File Offset: 0x00863A3C
		public bool BtnButtonDataButtonName_A22612_HasDiffs
		{
			get
			{
				short num = (short)1043398657;
				if (num != 0)
				{
				}
				num = (short)842110489;
				short num2 = num;
				num = (short)1184142873;
				switch (num2 == num)
				{
				}
				num = (short)368377856;
				if (num != 0)
				{
				}
				num = (short)677117952;
				short num3 = num;
				return this.btnButtonDataButtonName_A22612._HasDiffs;
			}
		}

		// Token: 0x170047E5 RID: 18405
		// (get) Token: 0x06008E67 RID: 36455 RVA: 0x008658F4 File Offset: 0x00863AF4
		// (set) Token: 0x06008E68 RID: 36456 RVA: 0x008659A8 File Offset: 0x00863BA8
		public string BtnButtonDataButtonKey_A22613Value
		{
			get
			{
				short num = (short)2122558281;
				short num2 = num;
				num = (short)815835977;
				switch (num2 == num)
				{
				}
				num = (short)693370881;
				if (num != 0)
				{
				}
				num = (short)415367168;
				if (num != 0)
				{
				}
				num = (short)116588544;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.Value;
			}
			set
			{
				short num = (short)1402142722;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1776686609;
						short num3 = num;
						num = (short)1576539665;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1825767424;
							if (num != 0)
							{
							}
							this.btnButtonDataButtonKey_A22613.Value = value;
							num = (short)582025217;
							if (num != 0)
							{
							}
							num = (short)674103296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1310916608;
					short num4 = num;
					num = (short)1658519553;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170047E6 RID: 18406
		// (get) Token: 0x06008E69 RID: 36457 RVA: 0x00865ACC File Offset: 0x00863CCC
		// (set) Token: 0x06008E6A RID: 36458 RVA: 0x00865B80 File Offset: 0x00863D80
		public string BtnButtonDataButtonKey_A22613_UIValue
		{
			get
			{
				short num = (short)1282342913;
				if (num != 0)
				{
				}
				num = (short)859015377;
				short num2 = num;
				num = (short)816613585;
				switch (num2 == num)
				{
				}
				num = (short)2066284544;
				if (num != 0)
				{
				}
				num = (short)1795227648;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.Value;
			}
			set
			{
				short num = (short)213166864;
				short num2 = num;
				num = (short)617851664;
				switch (num2 == num)
				{
				}
				num = (short)1332281345;
				if (num != 0)
				{
				}
				num = (short)442236928;
				if (num != 0)
				{
				}
				num = (short)3276800;
				short num3 = num;
				this.btnButtonDataButtonKey_A22613.Value = value;
			}
		}

		// Token: 0x170047E7 RID: 18407
		// (get) Token: 0x06008E6B RID: 36459 RVA: 0x00865C38 File Offset: 0x00863E38
		public global::AcpBusinessLayer.AcpKeyField BtnButtonDataButtonKey_A22613
		{
			get
			{
				short num = (short)1563492353;
				if (num != 0)
				{
				}
				num = (short)1067038353;
				short num2 = num;
				num = (short)3651217;
				switch (num2 == num)
				{
				}
				num = (short)1284177920;
				if (num != 0)
				{
				}
				num = (short)2058223616;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613;
			}
		}

		// Token: 0x170047E8 RID: 18408
		// (get) Token: 0x06008E6C RID: 36460 RVA: 0x00865CE8 File Offset: 0x00863EE8
		// (set) Token: 0x06008E6D RID: 36461 RVA: 0x00865D9C File Offset: 0x00863F9C
		public bool BtnButtonDataButtonKey_A22613_Applicable
		{
			get
			{
				short num = (short)1885025212;
				short num2 = num;
				num = (short)44250044;
				switch (num2 == num)
				{
				}
				num = (short)918028289;
				if (num != 0)
				{
				}
				num = (short)242286592;
				if (num != 0)
				{
				}
				num = (short)337051648;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.Applicable;
			}
			set
			{
				short num = (short)1321592555;
				short num2 = num;
				num = (short)2004084459;
				switch (num2 == num)
				{
				}
				num = (short)229048320;
				if (num != 0)
				{
				}
				num = (short)1547501569;
				if (num != 0)
				{
				}
				num = (short)2026373120;
				short num3 = num;
				this.btnButtonDataButtonKey_A22613.Applicable = value;
			}
		}

		// Token: 0x170047E9 RID: 18409
		// (get) Token: 0x06008E6E RID: 36462 RVA: 0x00865E54 File Offset: 0x00864054
		// (set) Token: 0x06008E6F RID: 36463 RVA: 0x00865F0C File Offset: 0x0086410C
		public bool BtnButtonDataButtonKey_A22613_Valid
		{
			get
			{
				short num = (short)940572673;
				if (num != 0)
				{
				}
				num = (short)1136847956;
				short num2 = num;
				num = (short)790096980;
				switch (num2 == num)
				{
				}
				num = (short)244580352;
				if (num != 0)
				{
				}
				num = (short)577372160;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.Valid;
			}
			set
			{
				short num = (short)1466151966;
				short num2 = num;
				num = (short)1571599390;
				switch (num2 == num)
				{
				}
				num = (short)1281753088;
				if (num != 0)
				{
				}
				num = (short)1042874369;
				if (num != 0)
				{
				}
				num = (short)1432485888;
				short num3 = num;
				this.btnButtonDataButtonKey_A22613.Valid = value;
			}
		}

		// Token: 0x170047EA RID: 18410
		// (get) Token: 0x06008E70 RID: 36464 RVA: 0x00865FC4 File Offset: 0x008641C4
		// (set) Token: 0x06008E71 RID: 36465 RVA: 0x00866078 File Offset: 0x00864278
		public bool BtnButtonDataButtonKey_A22613_Visible
		{
			get
			{
				short num = (short)791554769;
				short num2 = num;
				num = (short)1424698065;
				switch (num2 == num)
				{
				}
				num = (short)933101569;
				if (num != 0)
				{
				}
				num = (short)908984320;
				if (num != 0)
				{
				}
				num = (short)835780608;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.Visible;
			}
			set
			{
				short num = (short)1472934890;
				short num2 = num;
				num = (short)1818833898;
				switch (num2 == num)
				{
				}
				num = (short)1342046208;
				if (num != 0)
				{
				}
				num = (short)1330315265;
				if (num != 0)
				{
				}
				num = (short)1740767232;
				short num3 = num;
				this.btnButtonDataButtonKey_A22613.Visible = value;
			}
		}

		// Token: 0x170047EB RID: 18411
		// (get) Token: 0x06008E72 RID: 36466 RVA: 0x00866130 File Offset: 0x00864330
		// (set) Token: 0x06008E73 RID: 36467 RVA: 0x008661E4 File Offset: 0x008643E4
		public bool BtnButtonDataButtonKey_A22613_Editable
		{
			get
			{
				short num = (short)1048882522;
				short num2 = num;
				num = (short)1039576410;
				switch (num2 == num)
				{
				}
				num = (short)1556283393;
				if (num != 0)
				{
				}
				num = (short)1075642368;
				if (num != 0)
				{
				}
				num = (short)83034112;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.Editable;
			}
			set
			{
				short num = (short)1719843446;
				short num2 = num;
				num = (short)330218102;
				switch (num2 == num)
				{
				}
				num = (short)1281556480;
				if (num != 0)
				{
				}
				num = (short)1787887617;
				if (num != 0)
				{
				}
				num = (short)893779968;
				short num3 = num;
				this.btnButtonDataButtonKey_A22613.Editable = value;
			}
		}

		// Token: 0x170047EC RID: 18412
		// (get) Token: 0x06008E74 RID: 36468 RVA: 0x00866294 File Offset: 0x00864494
		internal string BtnButtonDataButtonKey_A22613_UILabel
		{
			get
			{
				short num = (short)988217345;
				if (num != 0)
				{
				}
				num = (short)651258022;
				short num2 = num;
				num = (short)1108371622;
				switch (num2 == num)
				{
				}
				num = (short)1364852736;
				if (num != 0)
				{
				}
				num = (short)6356992;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.UIName;
			}
		}

		// Token: 0x170047ED RID: 18413
		// (get) Token: 0x06008E75 RID: 36469 RVA: 0x0086634C File Offset: 0x0086454C
		// (set) Token: 0x06008E76 RID: 36470 RVA: 0x00866400 File Offset: 0x00864600
		internal bool BtnButtonDataButtonKey_A22613_HiddenStatic
		{
			get
			{
				short num = (short)1381794660;
				short num2 = num;
				num = (short)963609444;
				switch (num2 == num)
				{
				}
				num = (short)1629618177;
				if (num != 0)
				{
				}
				num = (short)1523843072;
				if (num != 0)
				{
				}
				num = (short)2005794816;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.HiddenStatic;
			}
			set
			{
				short num = (short)737552295;
				short num2 = num;
				num = (short)2112759719;
				switch (num2 == num)
				{
				}
				num = (short)1377894401;
				if (num != 0)
				{
				}
				num = (short)564789248;
				if (num != 0)
				{
				}
				num = (short)1400307712;
				short num3 = num;
				this.btnButtonDataButtonKey_A22613.HiddenStatic = value;
			}
		}

		// Token: 0x170047EE RID: 18414
		// (get) Token: 0x06008E77 RID: 36471 RVA: 0x008664B4 File Offset: 0x008646B4
		// (set) Token: 0x06008E78 RID: 36472 RVA: 0x00866568 File Offset: 0x00864768
		internal bool BtnButtonDataButtonKey_A22613_HiddenDynamic
		{
			get
			{
				short num = (short)1142248593;
				short num2 = num;
				num = (short)166614161;
				switch (num2 == num)
				{
				}
				num = (short)307757057;
				if (num != 0)
				{
				}
				num = (short)1783169024;
				if (num != 0)
				{
				}
				num = (short)1301086208;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613.HiddenDynamic;
			}
			set
			{
				short num = (short)226354541;
				short num2 = num;
				num = (short)756344173;
				switch (num2 == num)
				{
				}
				num = (short)1835663360;
				if (num != 0)
				{
				}
				num = (short)1247150081;
				if (num != 0)
				{
				}
				num = (short)405536768;
				short num3 = num;
				this.btnButtonDataButtonKey_A22613.HiddenDynamic = value;
			}
		}

		// Token: 0x170047EF RID: 18415
		// (get) Token: 0x06008E79 RID: 36473 RVA: 0x00866620 File Offset: 0x00864820
		public bool BtnButtonDataButtonKey_A22613_HasDiffs
		{
			get
			{
				short num = (short)1185148102;
				short num2 = num;
				num = (short)1878650054;
				switch (num2 == num)
				{
				}
				num = (short)650969089;
				if (num != 0)
				{
				}
				num = (short)856752128;
				if (num != 0)
				{
				}
				num = (short)559611904;
				short num3 = num;
				return this.btnButtonDataButtonKey_A22613._HasDiffs;
			}
		}

		// Token: 0x170047F0 RID: 18416
		// (get) Token: 0x06008E7A RID: 36474 RVA: 0x008666D4 File Offset: 0x008648D4
		// (set) Token: 0x06008E7B RID: 36475 RVA: 0x00866788 File Offset: 0x00864988
		public int BtnPortableDataButtonShortPressTimeValue
		{
			get
			{
				short num = (short)1347393119;
				short num2 = num;
				num = (short)309696095;
				switch (num2 == num)
				{
				}
				num = (short)38862849;
				if (num != 0)
				{
				}
				num = (short)821559296;
				if (num != 0)
				{
				}
				num = (short)344260608;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)552405695;
				short num2 = num;
				num = (short)945359551;
				switch (num2 == num)
				{
				}
				num = (short)1359609856;
				if (num != 0)
				{
				}
				num = (short)641007617;
				if (num != 0)
				{
				}
				num = (short)387776512;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.Value = value;
			}
		}

		// Token: 0x170047F1 RID: 18417
		// (get) Token: 0x06008E7C RID: 36476 RVA: 0x0086683C File Offset: 0x00864A3C
		// (set) Token: 0x06008E7D RID: 36477 RVA: 0x008668F0 File Offset: 0x00864AF0
		public string BtnPortableDataButtonShortPressTime_UIValue
		{
			get
			{
				short num = (short)546962378;
				short num2 = num;
				num = (short)1089338314;
				switch (num2 == num)
				{
				}
				num = (short)1921384449;
				if (num != 0)
				{
				}
				num = (short)1133182976;
				if (num != 0)
				{
				}
				num = (short)1546780672;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.UIValue;
			}
			set
			{
				short num = (short)1119016192;
				short num2 = num;
				num = (short)127980800;
				switch (num2 == num)
				{
				}
				num = (short)193003520;
				if (num != 0)
				{
				}
				num = (short)1199570945;
				if (num != 0)
				{
				}
				num = (short)919207936;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.UIValue = value;
			}
		}

		// Token: 0x170047F2 RID: 18418
		// (get) Token: 0x06008E7E RID: 36478 RVA: 0x008669A4 File Offset: 0x00864BA4
		public global::AcpBusinessLayer.AcpSimpleRangeField BtnPortableDataButtonShortPressTime
		{
			get
			{
				short num = (short)1846121095;
				short num2 = num;
				num = (short)507810439;
				switch (num2 == num)
				{
				}
				num = (short)429916160;
				if (num != 0)
				{
				}
				num = (short)309592065;
				if (num != 0)
				{
				}
				num = (short)73596928;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime;
			}
		}

		// Token: 0x170047F3 RID: 18419
		// (get) Token: 0x06008E7F RID: 36479 RVA: 0x00866A54 File Offset: 0x00864C54
		// (set) Token: 0x06008E80 RID: 36480 RVA: 0x00866B08 File Offset: 0x00864D08
		internal int BtnPortableDataButtonShortPressTimeMin
		{
			get
			{
				short num = (short)707719777;
				short num2 = num;
				num = (short)1817440865;
				switch (num2 == num)
				{
				}
				num = (short)836894721;
				if (num != 0)
				{
				}
				num = (short)2123563008;
				if (num != 0)
				{
				}
				num = (short)1529741312;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.Min;
			}
			set
			{
				short num = (short)1362535208;
				short num2 = num;
				num = (short)1979097896;
				switch (num2 == num)
				{
				}
				num = (short)1815478273;
				if (num != 0)
				{
				}
				num = (short)810483712;
				if (num != 0)
				{
				}
				num = (short)913178624;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.Min = value;
			}
		}

		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x06008E81 RID: 36481 RVA: 0x00866BC0 File Offset: 0x00864DC0
		// (set) Token: 0x06008E82 RID: 36482 RVA: 0x00866C78 File Offset: 0x00864E78
		internal int BtnPortableDataButtonShortPressTimeMax
		{
			get
			{
				short num = (short)1111855912;
				short num2 = num;
				num = (short)102339368;
				switch (num2 == num)
				{
				}
				num = (short)88604673;
				if (num != 0)
				{
				}
				num = (short)961544192;
				if (num != 0)
				{
				}
				num = (short)147783680;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.Max;
			}
			set
			{
				short num = (short)1282376820;
				short num2 = num;
				num = (short)142312564;
				switch (num2 == num)
				{
				}
				num = (short)1399455745;
				if (num != 0)
				{
				}
				num = (short)1386741760;
				if (num != 0)
				{
				}
				num = (short)1353973760;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.Max = value;
			}
		}

		// Token: 0x170047F5 RID: 18421
		// (get) Token: 0x06008E83 RID: 36483 RVA: 0x00866D2C File Offset: 0x00864F2C
		// (set) Token: 0x06008E84 RID: 36484 RVA: 0x00866DE4 File Offset: 0x00864FE4
		internal int BtnPortableDataButtonShortPressTimeStep
		{
			get
			{
				short num = (short)2038866770;
				short num2 = num;
				num = (short)1689756498;
				switch (num2 == num)
				{
				}
				num = (short)1184301057;
				if (num != 0)
				{
				}
				num = (short)126353408;
				if (num != 0)
				{
				}
				num = (short)1325006848;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.StepSize;
			}
			set
			{
				short num = (short)560857089;
				if (num != 0)
				{
				}
				num = (short)1444074792;
				short num2 = num;
				num = (short)1077400872;
				switch (num2 == num)
				{
				}
				num = (short)552534016;
				if (num != 0)
				{
				}
				num = (short)1017643008;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.StepSize = value;
			}
		}

		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x06008E85 RID: 36485 RVA: 0x00866E98 File Offset: 0x00865098
		// (set) Token: 0x06008E86 RID: 36486 RVA: 0x00866F4C File Offset: 0x0086514C
		public bool BtnPortableDataButtonShortPressTime_Applicable
		{
			get
			{
				short num = (short)1808334849;
				if (num != 0)
				{
				}
				num = (short)866672818;
				short num2 = num;
				num = (short)1489002674;
				switch (num2 == num)
				{
				}
				num = (short)617611264;
				if (num != 0)
				{
				}
				num = (short)1845297152;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.Applicable;
			}
			set
			{
				short num = (short)1953677840;
				short num2 = num;
				num = (short)590201360;
				switch (num2 == num)
				{
				}
				num = (short)1966473217;
				if (num != 0)
				{
				}
				num = (short)314114048;
				if (num != 0)
				{
				}
				num = (short)1486422016;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.Applicable = value;
			}
		}

		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x06008E87 RID: 36487 RVA: 0x00867000 File Offset: 0x00865200
		// (set) Token: 0x06008E88 RID: 36488 RVA: 0x008670B4 File Offset: 0x008652B4
		public bool BtnPortableDataButtonShortPressTime_Valid
		{
			get
			{
				short num = (short)1508249067;
				short num2 = num;
				num = (short)2099973611;
				switch (num2 == num)
				{
				}
				num = (short)780468225;
				if (num != 0)
				{
				}
				num = (short)903282688;
				if (num != 0)
				{
				}
				num = (short)711000064;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.Valid;
			}
			set
			{
				short num = (short)219545601;
				if (num != 0)
				{
				}
				num = (short)2003018735;
				short num2 = num;
				num = (short)1996792815;
				switch (num2 == num)
				{
				}
				num = (short)1857290240;
				if (num != 0)
				{
				}
				num = (short)1051459584;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.Valid = value;
			}
		}

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x06008E89 RID: 36489 RVA: 0x0086716C File Offset: 0x0086536C
		// (set) Token: 0x06008E8A RID: 36490 RVA: 0x00867224 File Offset: 0x00865424
		public bool BtnPortableDataButtonShortPressTime_Visible
		{
			get
			{
				short num = (short)1435799518;
				short num2 = num;
				num = (short)1859882974;
				switch (num2 == num)
				{
				}
				num = (short)753729537;
				if (num != 0)
				{
				}
				num = (short)338100224;
				if (num != 0)
				{
				}
				num = (short)1875378176;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.Visible;
			}
			set
			{
				short num = (short)807752072;
				short num2 = num;
				num = (short)1282953608;
				switch (num2 == num)
				{
				}
				num = (short)241696769;
				if (num != 0)
				{
				}
				num = (short)1499332608;
				if (num != 0)
				{
				}
				num = (short)914292736;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.Visible = value;
			}
		}

		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x06008E8B RID: 36491 RVA: 0x008672D8 File Offset: 0x008654D8
		// (set) Token: 0x06008E8C RID: 36492 RVA: 0x0086738C File Offset: 0x0086558C
		public bool BtnPortableDataButtonShortPressTime_Editable
		{
			get
			{
				short num = (short)2064165353;
				short num2 = num;
				num = (short)1689758185;
				switch (num2 == num)
				{
				}
				num = (short)1433862145;
				if (num != 0)
				{
				}
				num = (short)1107296256;
				if (num != 0)
				{
				}
				num = (short)2020671488;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.Editable;
			}
			set
			{
				short num = (short)1792747880;
				short num2 = num;
				num = (short)234367336;
				switch (num2 == num)
				{
				}
				num = (short)1544093697;
				if (num != 0)
				{
				}
				num = (short)1573453824;
				if (num != 0)
				{
				}
				num = (short)2122776576;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.Editable = value;
			}
		}

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x06008E8D RID: 36493 RVA: 0x00867440 File Offset: 0x00865640
		internal string BtnPortableDataButtonShortPressTime_UILabel
		{
			get
			{
				short num = (short)1141724780;
				short num2 = num;
				num = (short)886658668;
				switch (num2 == num)
				{
				}
				num = (short)1872429056;
				if (num != 0)
				{
				}
				num = (short)386007041;
				if (num != 0)
				{
				}
				num = (short)1179713536;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.UIName;
			}
		}

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x06008E8E RID: 36494 RVA: 0x008674F4 File Offset: 0x008656F4
		// (set) Token: 0x06008E8F RID: 36495 RVA: 0x008675A8 File Offset: 0x008657A8
		internal bool BtnPortableDataButtonShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1753421575;
				short num2 = num;
				num = (short)923866887;
				switch (num2 == num)
				{
				}
				num = (short)1707802625;
				if (num != 0)
				{
				}
				num = (short)2109407232;
				if (num != 0)
				{
				}
				num = (short)1289289728;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1157782423;
				short num2 = num;
				num = (short)1504992151;
				switch (num2 == num)
				{
				}
				num = (short)372899841;
				if (num != 0)
				{
				}
				num = (short)1799815168;
				if (num != 0)
				{
				}
				num = (short)1907818496;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x06008E90 RID: 36496 RVA: 0x0086765C File Offset: 0x0086585C
		// (set) Token: 0x06008E91 RID: 36497 RVA: 0x00867710 File Offset: 0x00865910
		internal bool BtnPortableDataButtonShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1428146938;
				short num2 = num;
				num = (short)1632357114;
				switch (num2 == num)
				{
				}
				num = (short)1783365633;
				if (num != 0)
				{
				}
				num = (short)828178432;
				if (num != 0)
				{
				}
				num = (short)412876800;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1943644312;
				short num2 = num;
				num = (short)718776472;
				switch (num2 == num)
				{
				}
				num = (short)850722816;
				if (num != 0)
				{
				}
				num = (short)775684097;
				if (num != 0)
				{
				}
				num = (short)484638720;
				short num3 = num;
				this.btnPortableDataButtonShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170047FD RID: 18429
		// (get) Token: 0x06008E92 RID: 36498 RVA: 0x008677C8 File Offset: 0x008659C8
		public bool BtnPortableDataButtonShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)244683655;
				short num2 = num;
				num = (short)1347916679;
				switch (num2 == num)
				{
				}
				num = (short)124780544;
				if (num != 0)
				{
				}
				num = (short)1666252801;
				if (num != 0)
				{
				}
				num = (short)630718464;
				short num3 = num;
				return this.btnPortableDataButtonShortPressTime._HasDiffs;
			}
		}

		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x06008E93 RID: 36499 RVA: 0x0086787C File Offset: 0x00865A7C
		// (set) Token: 0x06008E94 RID: 36500 RVA: 0x0086792C File Offset: 0x00865B2C
		public int BtnButtonDataButtonLongPressTimeValue
		{
			get
			{
				short num = (short)232194049;
				if (num != 0)
				{
				}
				num = (short)2009792925;
				short num2 = num;
				num = (short)1778385309;
				switch (num2 == num)
				{
				}
				num = (short)1150943232;
				if (num != 0)
				{
				}
				num = (short)1115422720;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.Value;
			}
			set
			{
				short num = (short)1409780062;
				short num2 = num;
				num = (short)541100382;
				switch (num2 == num)
				{
				}
				num = (short)1631191041;
				if (num != 0)
				{
				}
				num = (short)415236096;
				if (num != 0)
				{
				}
				num = (short)1206910976;
				short num3 = num;
				this.btnButtonDataButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x06008E95 RID: 36501 RVA: 0x008679E0 File Offset: 0x00865BE0
		// (set) Token: 0x06008E96 RID: 36502 RVA: 0x00867A98 File Offset: 0x00865C98
		public string BtnButtonDataButtonLongPressTime_UIValue
		{
			get
			{
				short num = (short)358148176;
				short num2 = num;
				num = (short)473622608;
				switch (num2 == num)
				{
				}
				num = (short)114556929;
				if (num != 0)
				{
				}
				num = (short)1924071424;
				if (num != 0)
				{
				}
				num = (short)12582912;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.UIValue;
			}
			set
			{
				short num = (short)364346659;
				short num2 = num;
				num = (short)1251507491;
				switch (num2 == num)
				{
				}
				num = (short)287768576;
				if (num != 0)
				{
				}
				num = (short)1845690369;
				if (num != 0)
				{
				}
				num = (short)1967980544;
				short num3 = num;
				this.btnButtonDataButtonLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x06008E97 RID: 36503 RVA: 0x00867B50 File Offset: 0x00865D50
		public global::AcpBusinessLayer.AcpCustomRangeField BtnButtonDataButtonLongPressTime
		{
			get
			{
				short num = (short)1818206017;
				short num2 = num;
				num = (short)478125889;
				switch (num2 == num)
				{
				}
				num = (short)23330816;
				if (num != 0)
				{
				}
				num = (short)19267585;
				if (num != 0)
				{
				}
				num = (short)100204544;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime;
			}
		}

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x06008E98 RID: 36504 RVA: 0x00867C00 File Offset: 0x00865E00
		// (set) Token: 0x06008E99 RID: 36505 RVA: 0x00867CB4 File Offset: 0x00865EB4
		public bool BtnButtonDataButtonLongPressTime_Applicable
		{
			get
			{
				short num = (short)348127233;
				if (num != 0)
				{
				}
				num = (short)259839163;
				short num2 = num;
				num = (short)1840305339;
				switch (num2 == num)
				{
				}
				num = (short)904986624;
				if (num != 0)
				{
				}
				num = (short)1574502400;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.Applicable;
			}
			set
			{
				short num = (short)1843936470;
				short num2 = num;
				num = (short)1074347222;
				switch (num2 == num)
				{
				}
				num = (short)1946746881;
				if (num != 0)
				{
				}
				num = (short)915734528;
				if (num != 0)
				{
				}
				num = (short)360906752;
				short num3 = num;
				this.btnButtonDataButtonLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x06008E9A RID: 36506 RVA: 0x00867D6C File Offset: 0x00865F6C
		// (set) Token: 0x06008E9B RID: 36507 RVA: 0x00867E24 File Offset: 0x00866024
		public bool BtnButtonDataButtonLongPressTime_Valid
		{
			get
			{
				short num = (short)788912165;
				short num2 = num;
				num = (short)2140919845;
				switch (num2 == num)
				{
				}
				num = (short)1095237633;
				if (num != 0)
				{
				}
				num = (short)2004811776;
				if (num != 0)
				{
				}
				num = (short)1263599616;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.Valid;
			}
			set
			{
				short num = (short)1356363621;
				short num2 = num;
				num = (short)498235237;
				switch (num2 == num)
				{
				}
				num = (short)1451819009;
				if (num != 0)
				{
				}
				num = (short)824311808;
				if (num != 0)
				{
				}
				num = (short)1665728512;
				short num3 = num;
				this.btnButtonDataButtonLongPressTime.Valid = value;
			}
		}

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x06008E9C RID: 36508 RVA: 0x00867ED8 File Offset: 0x008660D8
		// (set) Token: 0x06008E9D RID: 36509 RVA: 0x00867F90 File Offset: 0x00866190
		public bool BtnButtonDataButtonLongPressTime_Visible
		{
			get
			{
				short num = (short)1702150592;
				short num2 = num;
				num = (short)989774272;
				switch (num2 == num)
				{
				}
				num = (short)421068800;
				if (num != 0)
				{
				}
				num = (short)1986985985;
				if (num != 0)
				{
				}
				num = (short)132579328;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.Visible;
			}
			set
			{
				short num = (short)1764395865;
				short num2 = num;
				num = (short)1710525273;
				switch (num2 == num)
				{
				}
				num = (short)1190658049;
				if (num != 0)
				{
				}
				num = (short)1374420992;
				if (num != 0)
				{
				}
				num = (short)1386872832;
				short num3 = num;
				this.btnButtonDataButtonLongPressTime.Visible = value;
			}
		}

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x06008E9E RID: 36510 RVA: 0x00868044 File Offset: 0x00866244
		// (set) Token: 0x06008E9F RID: 36511 RVA: 0x008680F8 File Offset: 0x008662F8
		public bool BtnButtonDataButtonLongPressTime_Editable
		{
			get
			{
				short num = (short)2079567743;
				short num2 = num;
				num = (short)1653190527;
				switch (num2 == num)
				{
				}
				num = (short)1270939649;
				if (num != 0)
				{
				}
				num = (short)1080295424;
				if (num != 0)
				{
				}
				num = (short)2146107392;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.Editable;
			}
			set
			{
				short num = (short)1859666193;
				short num2 = num;
				num = (short)1157906705;
				switch (num2 == num)
				{
				}
				num = (short)1362427904;
				if (num != 0)
				{
				}
				num = (short)1483014145;
				if (num != 0)
				{
				}
				num = (short)2117533696;
				short num3 = num;
				this.btnButtonDataButtonLongPressTime.Editable = value;
			}
		}

		// Token: 0x17004805 RID: 18437
		// (get) Token: 0x06008EA0 RID: 36512 RVA: 0x008681AC File Offset: 0x008663AC
		internal string BtnButtonDataButtonLongPressTime_UILabel
		{
			get
			{
				short num = (short)310572618;
				short num2 = num;
				num = (short)2045900362;
				switch (num2 == num)
				{
				}
				num = (short)422641665;
				if (num != 0)
				{
				}
				num = (short)1824391168;
				if (num != 0)
				{
				}
				num = (short)549126144;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.UIName;
			}
		}

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x06008EA1 RID: 36513 RVA: 0x00868260 File Offset: 0x00866460
		// (set) Token: 0x06008EA2 RID: 36514 RVA: 0x00868314 File Offset: 0x00866514
		internal bool BtnButtonDataButtonLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1688189102;
				short num2 = num;
				num = (short)1340520622;
				switch (num2 == num)
				{
				}
				num = (short)292814848;
				if (num != 0)
				{
				}
				num = (short)12713985;
				if (num != 0)
				{
				}
				num = (short)137101312;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1621758825;
				short num2 = num;
				num = (short)1942033257;
				switch (num2 == num)
				{
				}
				num = (short)246546433;
				if (num != 0)
				{
				}
				num = (short)1592197120;
				if (num != 0)
				{
				}
				num = (short)372572160;
				short num3 = num;
				this.btnButtonDataButtonLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x06008EA3 RID: 36515 RVA: 0x008683C8 File Offset: 0x008665C8
		// (set) Token: 0x06008EA4 RID: 36516 RVA: 0x0086847C File Offset: 0x0086667C
		internal bool BtnButtonDataButtonLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1169620993;
				if (num != 0)
				{
				}
				num = (short)1204986004;
				short num2 = num;
				num = (short)1415225492;
				switch (num2 == num)
				{
				}
				num = (short)1108606976;
				if (num != 0)
				{
				}
				num = (short)1738014720;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)885219958;
				short num2 = num;
				num = (short)1283220086;
				switch (num2 == num)
				{
				}
				num = (short)1563295745;
				if (num != 0)
				{
				}
				num = (short)441319424;
				if (num != 0)
				{
				}
				num = (short)240254976;
				short num3 = num;
				this.btnButtonDataButtonLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x06008EA5 RID: 36517 RVA: 0x00868534 File Offset: 0x00866734
		public bool BtnButtonDataButtonLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)1372276994;
				short num2 = num;
				num = (short)3623170;
				switch (num2 == num)
				{
				}
				num = (short)1919090688;
				if (num != 0)
				{
				}
				num = (short)1759707137;
				if (num != 0)
				{
				}
				num = (short)2077818880;
				short num3 = num;
				return this.btnButtonDataButtonLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x06008EA6 RID: 36518 RVA: 0x008685EC File Offset: 0x008667EC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1755045622;
				short num2 = num;
				num = (short)1978916598;
				switch (num2 == num)
				{
				}
				num = (short)1519386624;
				if (num != 0)
				{
				}
				num = (short)2060976129;
				if (num != 0)
				{
				}
				num = (short)1217134592;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008EA7 RID: 36519 RVA: 0x008686AC File Offset: 0x008668AC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1375666176;
					short num3 = num2;
					num2 = (short)390987778;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1086914560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					num2 = (short)1679228929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_AD;
				}
				goto IL_24;
			}
			IL_AD:
			if (base.ParentRecset != null)
			{
				goto IL_B8;
			}
			return result;
			IL_24:
			num2 = (short)439287809;
			if (num2 != 0)
			{
			}
			num2 = (short)259377695;
			short num4 = num2;
			num2 = (short)1380108831;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B8:
				num2 = (short)1810956291;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)968425472;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)210042884;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0400463E RID: 17982
		private global::AcpBusinessLayer.AcpListField btnTrunkingButtonDatatButtonFeature_A22608;

		// Token: 0x0400463F RID: 17983
		private global::AcpBusinessLayer.AcpListField btnTrunkingButtonDataButtonBCO_A22609;

		// Token: 0x04004640 RID: 17984
		private global::AcpBusinessLayer.AcpListField btnConventionalButtonDatatButtonFeature_A22610;

		// Token: 0x04004641 RID: 17985
		private global::AcpBusinessLayer.AcpListField btnConventionalButtonDataButtonBCO_A22611;

		// Token: 0x04004642 RID: 17986
		private global::AcpBusinessLayer.AcpField<string> btnButtonDataButtonName_A22612;

		// Token: 0x04004643 RID: 17987
		private global::AcpBusinessLayer.AcpKeyField btnButtonDataButtonKey_A22613;

		// Token: 0x04004644 RID: 17988
		private global::AcpBusinessLayer.AcpSimpleRangeField btnPortableDataButtonShortPressTime;

		// Token: 0x04004645 RID: 17989
		private global::AcpBusinessLayer.AcpCustomRangeField btnButtonDataButtonLongPressTime;
	}
}
