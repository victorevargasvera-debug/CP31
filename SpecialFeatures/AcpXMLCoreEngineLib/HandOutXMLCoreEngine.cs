using System;
using System.Collections.Generic;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.SmartKeyFob;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x0200023C RID: 572
	public class HandOutXMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine
	{
		// Token: 0x06001CB4 RID: 7348 RVA: 0x0027A2B0 File Offset: 0x002784B0
		public HandOutXMLCoreEngine()
		{
			this.a = (global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
			if (this.a != null)
			{
				this.b = (this.a[10081].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset);
				if (this.b != null)
				{
					this.c = (this.b[0][10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection);
				}
			}
			if (this.a != null)
			{
				this.d = (this.a[10637].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset);
				if (this.d != null)
				{
					this.e = (this.d[0][10638] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection);
					this.f = (this.d[1][10638] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection);
				}
			}
			this.g = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
			if (this.g != null)
			{
				this.h = (this.g[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				this.i = (this.g[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
				this.j = (this.g[0][10745].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset);
			}
			this.k = (global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset);
			if (this.k != null)
			{
				this.l = (this.k[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
			}
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0027A49C File Offset: 0x0027869C
		private void j(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 17;
			short num = (short)1851157490;
			short num2 = num;
			num = (short)231304178;
			switch (num2 == num)
			{
			}
			num = (short)1980039168;
			if (num != 0)
			{
			}
			num = (short)1570504705;
			if (num != 0)
			{
			}
			num = (short)345047040;
			short num3 = num;
			base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int count = base.count;
			base.count = count + 1;
			base.rptRec.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud993솝힡쪣얥\udca7쎩쎫삭鈴\udab3\ud9b5\udab7", a_), base.ci);
			base.rptRec.RecNo = base.count.ToString();
			this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒓秊ﾙ솝욡", a_), base.ci), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒓秊ﾙ솝욡", a_), base.ci), ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒓秊", a_);
			this.rptFields.UIFieldDes = "";
			base.rptRec.UIFields.Add(this.rptFields);
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int value = this.e.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value;
			string text = (string)this.e.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Converter.Convert(value, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text, text, ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒓ﶛ\ud99f톣좥쮧\udea9얫솭\udeaf", a_);
			this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒓ﶛ\ud99fﶡ펥욧즩\ud8ab잭\udfaf\udcb1", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int value2 = this.f.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value;
			string text2 = (string)this.f.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Converter.Convert(value2, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text2, text2, ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잓ﮗ瞧솟킡\udda3\udda7쒩쾫\udaad\ud9af\uddb1\udab3", a_);
			this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잓ﮗ瞧솟킡\udda3殮\udfa9슫춭쒯\udbb1\udbb3\ud8b5", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			A_0.RecSet.Add(base.rptRec);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0027A80C File Offset: 0x00278A0C
		private void i(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 0;
			short num = (short)287898164;
			short num2 = num;
			num = (short)825752116;
			switch (num2 == num)
			{
			}
			num = (short)227868672;
			if (num != 0)
			{
			}
			num = (short)1747976193;
			if (num != 0)
			{
			}
			num = (short)928448512;
			short num3 = num;
			base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int count = base.count;
			base.count = count + 1;
			base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
			base.rptRec.RecNo = base.count.ToString();
			this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펂力튌욎", a_), base.ci), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펂力튌욎", a_), base.ci), ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펂", a_);
			this.rptFields.UIFieldDes = "";
			base.rptRec.UIFields.Add(this.rptFields);
			A_0.RecSet.Add(base.rptRec);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0027A9DC File Offset: 0x00278BDC
		private void h(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 19;
			short num = (short)562708567;
			short num2 = num;
			num = (short)908279895;
			switch (num2 == num)
			{
			}
			num = (short)1975255041;
			if (num != 0)
			{
			}
			num = (short)1611595776;
			if (num != 0)
			{
			}
			num = (short)382992384;
			short num3 = num;
			base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int count = base.count;
			base.count = count + 1;
			base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
			base.rptRec.RecNo = base.count.ToString();
			this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), base.ci), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), base.ci), ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕쪛첟", a_);
			this.rptFields.UIFieldDes = "";
			base.rptRec.UIFields.Add(this.rptFields);
			A_0.RecSet.Add(base.rptRec);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0027ABA8 File Offset: 0x00278DA8
		private void g(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 2;
			short num = (short)1448800693;
			short num2 = num;
			num = (short)326300085;
			switch (num2 == num)
			{
			}
			num = (short)1666121729;
			if (num != 0)
			{
			}
			num = (short)1753612288;
			if (num != 0)
			{
			}
			num = (short)1041629184;
			short num3 = num;
			base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int count = base.count;
			base.count = count + 1;
			base.rptRec.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톄풊\udd8c朗ﺖ슜\udc9e캠춢욤슦잨\udfaa\udfac욮튰", a_), base.ci);
			base.rptRec.RecNo = base.count.ToString();
			int value = this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.Value;
			int value2 = this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Value;
			string value3 = (string)this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.Converter.Convert(value, null, null, base.ci);
			string value4 = (string)this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Converter.Convert(value2, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.HiddenStatic), new bool?(!this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.HiddenStatic), value4, value3, ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햄愈歷ﺐﶒ풔", a_);
			this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햄愈歷ﺐﶒ쪔횖", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int value5 = this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.Value;
			int value6 = this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Value;
			string value7 = (string)this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.Converter.Convert(value5, null, null, base.ci);
			string value8 = (string)this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Converter.Convert(value6, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.HiddenStatic), new bool?(!this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.HiddenStatic), value8, value7, ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햄愈歷ﺐﶒ힔", a_);
			this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햄愈歷ﺐﶒ쪔햖", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			A_0.RecSet.Add(base.rptRec);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0027AF3C File Offset: 0x0027913C
		private void f(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 1;
			short num = (short)916443814;
			short num2 = num;
			num = (short)912380582;
			switch (num2 == num)
			{
			}
			num = (short)1438646273;
			if (num != 0)
			{
			}
			num = (short)184549376;
			if (num != 0)
			{
			}
			num = (short)980877312;
			short num3 = num;
			base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int count = base.count;
			base.count = count + 1;
			base.rptRec.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킃慎톍삏﶑ﾕﾟ쮣솥쾧용즫", a_), base.ci);
			base.rptRec.RecNo = base.count.ToString();
			int value = this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.Value;
			int value2 = this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Value;
			string value3 = (string)this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.Converter.Convert(value, null, null, base.ci);
			string value4 = (string)this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Converter.Convert(value2, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.HiddenStatic), new bool?(!this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.HiddenStatic), value4, value3, ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풃ﮇﾏﲑ햓", a_);
			this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풃ﮇﾏﲑ쮓힕", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int value5 = this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.Value;
			int value6 = this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Value;
			string value7 = (string)this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.Converter.Convert(value5, null, null, base.ci);
			string value8 = (string)this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Converter.Convert(value6, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.HiddenStatic), new bool?(!this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.HiddenStatic), value8, value7, ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풃ﮇﾏﲑ횓", a_);
			this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풃ﮇﾏﲑ쮓풕", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int value9 = this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.Value;
			int value10 = this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Value;
			string value11 = (string)this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.Converter.Convert(value9, null, null, base.ci);
			string value12 = (string)this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Converter.Convert(value10, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!this.a.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.HiddenStatic), new bool?(!this.a.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.HiddenStatic), value12, value11, ref this.rptFields);
			this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풃ﮇﾏﲑ힓", a_);
			this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풃ﮇﾏﲑ쮓햕", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			A_0.RecSet.Add(base.rptRec);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0027B408 File Offset: 0x00279608
		private void e(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 17;
			short num = (short)1763901440;
			switch (num)
			{
			default:
			{
				num = (short)1338769409;
				if (num != 0)
				{
				}
				num = (short)247791616;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.h.GetEnumerator();
				try
				{
					num = (short)1591017476;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_797;
						case 1:
							num = (short)668532736;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)690749441;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
							this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
							int count = base.count;
							base.count = count + 1;
							base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
							base.rptRec.RecNo = base.count.ToString();
							global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection = acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection;
							int btnGeneralConventionalFeature_A19544Value = (acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544Value;
							int btnTrunkingPortableButtonFeature_A19546Value = (acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546Value;
							string text = (string)(acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Converter.Convert(btnGeneralConventionalFeature_A19544Value, null, null, base.ci);
							string text2 = (string)(acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Converter.Convert(btnTrunkingPortableButtonFeature_A19546Value, null, null, base.ci);
							int num4 = (acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTopButtonShortPressTime;
							string text3 = (string)(acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTopButtonShortPressTime.Converter.Convert(num4, null, null, base.ci);
							int num5 = (acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnPortableTopButtonLongPressTime;
							string text4 = (string)(acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnPortableTopButtonLongPressTime.Converter.Convert(num5, null, null, base.ci);
							this.AddMultiValueByRTL(new bool?(!portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.HiddenStatic), new bool?(!portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.HiddenStatic), new bool?(!portableButtonInnerSection.BtnTopButtonShortPressTime.HiddenStatic), new bool?(!portableButtonInnerSection.BtnPortableTopButtonLongPressTime.HiddenStatic), text2.ToString(), text.ToString(), text3.ToString(), text4.ToString(), ref this.rptFields);
							this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner)acpFeatureNode).PortableButtonInnerSection.BtnPortableButtonName_A22558.UIName.ToString();
							string uiName = ((global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner)acpFeatureNode).PortableButtonInnerSection.BtnPortableButtonName_A22558_UIValue.ToString();
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗캙펛캝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗캙펛캝", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗즙햛\uda9dﾩ節ﾯﲱ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗즙햛\uda9dﾩ節ﾯﲱ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗즙햛\uda9d例", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗즙햛\uda9d例", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗즙햛\uda9dﲧ例", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗즙햛\uda9dﲧ例", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗즙첛\udb9dﲯ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗즙첛\udb9dﲯ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙궛\udc9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙궛\udc9d", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙꺛\udc9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙꺛\udc9d", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙꾛\udc9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙꾛\udc9d", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙ꢛ\udc9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙ꢛ\udc9d", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙ꦛ\udc9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙ꦛ\udc9d", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙ꪛ\udc9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙ꪛ\udc9d", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗풙펛쪝ﺩﺯ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗풙펛쪝ﺩﺯ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, null, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙펛첝嶺節ﶱ荒", a_), base.ci));
							base.rptRec.UIFields.Add(this.rptFields);
							A_0.RecSet.Add(base.rptRec);
							num = (short)1477640194;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_BE;
							}
							continue;
						}
						IL_741:
						num = (short)678428675;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_BE:
						goto IL_741;
					}
					IL_797:;
				}
				finally
				{
					num = (short)996016130;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)893450855;
							short num6 = num;
							num = (short)629209703;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7D4;
							default:
								goto IL_83B;
							}
							break;
						}
						case 1:
							enumerator.Dispose();
							num = (short)2044854272;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7CE;
							}
							continue;
						}
						goto IL_7CE;
						IL_7D4:
						num = (short)862453761;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_7CE:
						if (enumerator != null)
						{
							goto IL_7D4;
						}
						goto IL_853;
					}
					IL_83B:
					num = (short)1744437248;
					if (num != 0)
					{
					}
					IL_853:;
				}
				return;
			}
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0027BC88 File Offset: 0x00279E88
		private void d(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 13;
			short num = (short)1702734718;
			short num2 = num;
			num = (short)1986112382;
			switch (num2 == num)
			{
			}
			num = (short)366673921;
			if (num != 0)
			{
			}
			num = (short)685047808;
			if (num != 0)
			{
			}
			num = (short)668205056;
			short num3 = num;
			base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int count = base.count;
			base.count = count + 1;
			base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
			base.rptRec.RecNo = base.count.ToString();
			int switchGeneralRotaryControl_A8984Value = this.c.SwitchGeneralRotaryControl_A8984Value;
			string text = (string)this.c.SwitchGeneralRotaryControl_A8984.Converter.Convert(switchGeneralRotaryControl_A8984Value, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
			this.rptFields.UIFieldName = this.c.SwitchRotaryControlButtonName_A22903.UIName.ToString();
			this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓쒕힗캙\udd9b첝烈ﲧ", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			A_0.RecSet.Add(base.rptRec);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0027BE80 File Offset: 0x0027A080
		private void c(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 10;
			short num = (short)323868301;
			short num2 = num;
			num = (short)1639044749;
			switch (num2 == num)
			{
			}
			num = (short)617611265;
			if (num != 0)
			{
			}
			num = (short)1202257920;
			short num3 = num;
			num = (short)80674816;
			if (num != 0)
			{
			}
			base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
			this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
			int count = base.count;
			base.count = count + 1;
			base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
			base.rptRec.RecNo = base.count.ToString();
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = this.i[0];
			int btnConventionalButtonDatatButtonFeature_A22610Value = (acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610Value;
			int btnTrunkingButtonDatatButtonFeature_A22608Value = (acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608Value;
			string text = (string)(acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Converter.Convert(btnConventionalButtonDatatButtonFeature_A22610Value, null, null, base.ci);
			string text2 = (string)(acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Converter.Convert(btnTrunkingButtonDatatButtonFeature_A22608Value, null, null, base.ci);
			this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text2.ToString(), text.ToString(), ref this.rptFields);
			this.rptFields.UIFieldName = (acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnButtonDataButtonName_A22612.UIName.ToString();
			this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐힒풔쎖\ud898\ud99a좜쮞風", a_), base.ci);
			base.rptRec.UIFields.Add(this.rptFields);
			A_0.RecSet.Add(base.rptRec);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0027C0F0 File Offset: 0x0027A2F0
		private void b(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 6;
			short num = (short)1860763649;
			if (num != 0)
			{
			}
			num = (short)1993539584;
			switch (num)
			{
			default:
			{
				num = (short)1205010432;
				short num2 = num;
				base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				int num3 = base.count;
				base.count = num3 + 1;
				base.rptRec.RecTitle = global::CommonResources.AcgResources.ID_SIDEARROWBUTTONS;
				base.rptRec.RecNo = base.count.ToString();
				int num4 = 0;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.j.GetEnumerator();
				try
				{
					num = (short)340459526;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							if (this.rptFields.UIFieldDes == string.Empty)
							{
								num = (short)779157505;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_36A;
						case 1:
						{
							string text;
							string uiName = text;
							string conditionName = null;
							string @string = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌\udf8e\ude90솒요\ude96\udd98\ude9a\udf9c쪞", a_), base.ci);
							num4 = (num3 = num4 + 1);
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, conditionName, @string + num3.ToString());
							num = (short)1959067653;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)1060569095;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1522991107;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
							string btnSideUpDownArrowButtonPrimaryFunction_A41568_UIValue = (acpFeatureNode[10746] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection).BtnSideUpDownArrowButtonPrimaryFunction_A41568_UIValue;
							string btnSideUpDownArrowButtonSecondaryFunction_A41592_UIValue = (acpFeatureNode[10746] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection).BtnSideUpDownArrowButtonSecondaryFunction_A41592_UIValue;
							string text2 = btnSideUpDownArrowButtonPrimaryFunction_A41568_UIValue + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦈ권", a_) + btnSideUpDownArrowButtonSecondaryFunction_A41592_UIValue;
							this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text2, text2, ref this.rptFields);
							this.rptFields.UIFieldName = (acpFeatureNode[10746] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection).BtnSideArrowButtonName_A41567.UIName.ToString();
							string text = (acpFeatureNode[10746] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection).BtnSideArrowButtonName_A41567_UIValue.ToString();
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌\uda8e손튒잔얖횘첚", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌\uda8e손튒잔얖횘첚", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌쮎\ude90쒒\udb94횖쮘즚튜좞", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌쮎\ude90쒒\udb94횖쮘즚튜좞", a_), base.ci));
							goto IL_280;
						}
						case 5:
							goto IL_36A;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_112;
							}
							continue;
						case 7:
						{
							num = (short)1716092953;
							short num6 = num;
							num = (short)258768921;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_280;
							default:
								goto IL_3EB;
							}
							break;
						}
						}
						goto IL_112;
						IL_280:
						num = (short)1051983872;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CE:
						num = (short)1828716548;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_112:
						goto IL_2CE;
						IL_36A:
						base.rptRec.UIFields.Add(this.rptFields);
						num = (short)468320258;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_3EB:
					num = (short)428802048;
					if (num != 0)
					{
					}
				}
				finally
				{
					num = (short)1264844801;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							enumerator.Dispose();
							num = (short)246284290;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_435;
							}
							continue;
						case 2:
							goto IL_46A;
						}
						IL_435:
						if (enumerator == null)
						{
							break;
						}
						num = (short)347996160;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_46A:;
				}
				A_0.RecSet.Add(base.rptRec);
				return;
			}
			}
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0027C598 File Offset: 0x0027A798
		private void a(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 8;
			short num = (short)1830813696;
			switch (num)
			{
			default:
			{
				num = (short)1578696705;
				if (num != 0)
				{
				}
				num = (short)225640448;
				short num2 = num;
				base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				int num3 = base.count;
				base.count = num3 + 1;
				base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\ude92풔얖춘킚\ud89c욞ﲨﾪ怜ﾰ", a_), base.ci);
				base.rptRec.RecNo = base.count.ToString();
				int num4 = 0;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.l.GetEnumerator();
				try
				{
					num = (short)490340358;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							if (this.rptFields.UIFieldDes == string.Empty)
							{
								num = (short)689569793;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4B7;
						case 1:
						{
							string text;
							string uiName = text;
							string conditionName = null;
							string @string = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎힐\udc92힔햖처쾚즜킞", a_), base.ci);
							num4 = (num3 = num4 + 1);
							this.AddUiFieldDescByCondition(ref this.rptFields, uiName, conditionName, @string + num3.ToString());
							num = (short)171900933;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)1793327111;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)100532227;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
							global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection smartKeyFobButtonTableInnerSection = acpFeatureNode[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection;
							string radErgoCfgFobConventionalFeature_A41574_UIValue = (acpFeatureNode[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574_UIValue;
							string radErgoCfgFobTrunkingFeature_A41575_UIValue = (acpFeatureNode[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575_UIValue;
							this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), new bool?(!smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.HiddenStatic), radErgoCfgFobTrunkingFeature_A41575_UIValue, radErgoCfgFobConventionalFeature_A41574_UIValue, ref this.rptFields);
							this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner)acpFeatureNode).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobButtonName_A41573.UIName.ToString();
							string text = ((global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner)acpFeatureNode).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobButtonName_A41573_UIValue.ToString();
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잊敖첒", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잊敖첒", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잊敖첒", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잊敖첒", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8aﺐﺔ좖", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8aﺐﺔ좖", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8aﺐﺔ좖ﶘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8aﺐﺔ좖ﶘ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8aﺐﺔ좖쪠", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8aﺐﺔ좖쪠", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎킐\udf92풔얖풘", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎킐\udf92풔얖풘", a_), base.ci));
							goto IL_3CF;
						}
						case 5:
							goto IL_4B7;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_12C;
							}
							continue;
						case 7:
						{
							num = (short)1394582224;
							short num6 = num;
							num = (short)863740624;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3CF;
							default:
								goto IL_538;
							}
							break;
						}
						}
						goto IL_12C;
						IL_3CF:
						num = (short)1406337024;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_41C:
						num = (short)931725316;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_12C:
						goto IL_41C;
						IL_4B7:
						base.rptRec.UIFields.Add(this.rptFields);
						num = (short)2118778882;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_538:
					num = (short)1182859264;
					if (num != 0)
					{
					}
				}
				finally
				{
					num = (short)353632257;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1499660290;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_581;
							}
							continue;
						case 2:
							goto IL_5B8;
						}
						IL_581:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1868890112;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_5B8:;
				}
				A_0.RecSet.Add(base.rptRec);
				return;
			}
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0027CB90 File Offset: 0x0027AD90
		public override void BuildDataTables(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData XMLRptDataObj)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_D9;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_13:
				num = (short)1629093889;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (!this.k.HiddenStatic)
					{
						num = (short)1301938198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DC;
				case 1:
					num = (short)414973964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_634;
				case 3:
					if (this.j.HasVisibleObjects)
					{
						num = (short)1137639459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 4:
					goto IL_634;
				case 5:
					if (this.c != null)
					{
						num = (short)949157889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_634;
				case 6:
					goto IL_670;
				case 7:
					goto IL_5B3;
				case 8:
					if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좈\udb8a햌벎ꆐꎒꖔ", a_)))
					{
						num = (short)391577609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DC;
				case 9:
					this.a(ref this.rptTable);
					num = (short)1189675036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.g(ref this.rptTable);
					this.f(ref this.rptTable);
					num = (short)132775956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)950009882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (this.c.HasVisibleObjects)
					{
						num = (short)1024851982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_634;
				case 13:
					this.j(ref this.rptTable);
					num = (short)1256980484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.d(ref this.rptTable);
					num = (short)918159377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num = (short)470548491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DC;
				case 16:
					num = (short)911933445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_634;
				case 18:
					if (this.a != null)
					{
						num = (short)1446903827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_537;
				case 19:
					this.h(ref this.rptTable);
					num = (short)295960607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_537;
				case 21:
					this.i(ref this.rptTable);
					num = (short)897974274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1852964872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_140;
				case 24:
				{
					this.c(ref this.rptTable);
					num = (short)1980497920;
					short num3 = num;
					num = (short)1441988631;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 25:
					goto IL_1F6;
				case 26:
					if (global::ConstraintHelper.UtilityMack.IsWorldWidePro)
					{
						num = (short)1286733837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)421593120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.e(ref this.rptTable);
					num = (short)318504966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_45B;
				case 29:
					if (this.l != null)
					{
						num = (short)2093219870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DC;
				case 30:
					num = (short)1657864192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
				{
					num = (short)1815532747;
					short num4 = num;
					num = (short)1277351115;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B3;
					default:
						num = (short)616628224;
						if (num != 0)
						{
						}
						if (this.a.ConventionalSwitches.HasVisibleObjects)
						{
							num = (short)114556938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_537;
					}
					break;
				}
				case 32:
					if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좈\udb8a햌벎ꆐꎒꖔ", a_)))
					{
						num = (short)125370389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1965948946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (this.h != null)
					{
						num = (short)1671626779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_670;
				case 34:
					if (!global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좈\udb8a햌벎ꆐꎒꖔ", a_)))
					{
						num = (short)438566928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_634;
				case 35:
					this.b(ref this.rptTable);
					num = (short)1520828441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (this.j != null)
					{
						num = (short)286195719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 37:
					if (this.i.HasVisibleObjects)
					{
						num = (short)548208664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_140;
				}
				goto IL_D9;
				IL_140:
				this.AddKeypadButton(ref this.rptTable);
				num = (short)1065549860;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F6:
				num = (short)79429661;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_537:
				num = (short)2142175266;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5B3:
				num = (short)1739325443;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_634:
				num = (short)426508321;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_670:
				num = (short)1861287973;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_45B:
			IL_6DC:
			XMLRptDataObj.tables.Add(this.rptTable);
			base.AddZonesAndChannels(ref XMLRptDataObj);
			return;
			IL_D9:
			this.AddGeneral(ref XMLRptDataObj);
			this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
			base.acpr = new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
			this.CreateTableHeader(ref this.rptTable);
			num = (short)230948879;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x04000E3A RID: 3642
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches a;

		// Token: 0x04000E3B RID: 3643
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset b;

		// Token: 0x04000E3C RID: 3644
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection c;

		// Token: 0x04000E3D RID: 3645
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset d;

		// Token: 0x04000E3E RID: 3646
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection e;

		// Token: 0x04000E3F RID: 3647
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection f;

		// Token: 0x04000E40 RID: 3648
		private global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset g;

		// Token: 0x04000E41 RID: 3649
		private global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset h;

		// Token: 0x04000E42 RID: 3650
		private global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset i;

		// Token: 0x04000E43 RID: 3651
		private global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset j;

		// Token: 0x04000E44 RID: 3652
		private global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset k;

		// Token: 0x04000E45 RID: 3653
		private global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset l;
	}
}
