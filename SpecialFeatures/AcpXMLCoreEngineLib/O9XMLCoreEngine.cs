using System;
using System.Collections.Generic;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x0200023B RID: 571
	public class O9XMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine
	{
		// Token: 0x06001CAA RID: 7338 RVA: 0x0027746C File Offset: 0x0027566C
		protected override void KeypadButtonSequenceRTL(bool? condition1, bool? condition2, string value1, string value2, ref global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields rptField)
		{
			short num = (short)1525284864;
			short num2 = num;
			num = (short)675502327;
			short num3 = num;
			num = (short)780753143;
			switch (num3 == num)
			{
			}
			num = (short)1069809665;
			if (num != 0)
			{
			}
			num = (short)1696137216;
			if (num != 0)
			{
			}
			base.KeypadButtonSequenceRTL(new bool?(false), condition2, value1, value2, ref rptField);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00277528 File Offset: 0x00275728
		public O9XMLCoreEngine()
		{
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(4003)[0];
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset = global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset;
			if (controlHeadO9Recset != null)
			{
				this.a = (controlHeadO9Recset[0][10624].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset);
				this.b = (controlHeadO9Recset[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset);
				this.c = (controlHeadO9Recset[0][10626].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset);
				this.d = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
				this.e = (controlHeadO9Recset[0][10731].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset);
				this.f = (controlHeadO9Recset[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset);
				this.g = (controlHeadO9Recset[0][10743].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset);
			}
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00277650 File Offset: 0x00275850
		private void g(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 7;
			short num = (short)76939264;
			switch (num)
			{
			default:
			{
				num = (short)1905852417;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1000117481;
						short num3 = num;
						num = (short)1901565161;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1792016384;
							if (num != 0)
							{
							}
							goto IL_5BA;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 2:
						return;
					case 3:
						try
						{
							num = (short)612171777;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection responseSelectorListInnerSection;
								string text;
								string text2;
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1799684098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									responseSelectorListInnerSection = (acpFeatureNode[10625] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection);
									int cho9PursuitKnobAction_A36684Value = responseSelectorListInnerSection.CHO9PursuitKnobAction_A36684Value;
									int cho9PursuitKnobIndex_A36685Value = responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685Value;
									text = (string)responseSelectorListInnerSection.CHO9PursuitKnobAction_A36684.Converter.Convert(cho9PursuitKnobAction_A36684Value, null, null, base.ci);
									text2 = responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685_UIValue;
									string str = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍얏\udc91햓얕쮗펙\udb9b킝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚉", a_) + str + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뒉", a_);
									num = (short)988872712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_177;
									}
									continue;
								case 2:
									num = (short)519438343;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									text2 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍얏\udc91햓얕쮗펙\udb9b킝", a_), base.ci);
									num = (short)1866072074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕", a_), base.ci);
									num = (short)1297154057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (string.IsNullOrEmpty(this.rptFields.UIFieldDes))
									{
										num = (short)923598853;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_264;
								case 7:
									goto IL_54B;
								case 8:
								{
									string str;
									if (text2 == str)
									{
										num = (short)1280114691;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D5;
								}
								case 9:
									goto IL_264;
								case 10:
									goto IL_2D5;
								}
								goto IL_177;
								IL_264:
								base.rptRec.UIFields.Add(this.rptFields);
								num = (short)824770564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_294:
								num = (short)1708064768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_177:
								goto IL_294;
								IL_2D5:
								this.AddMultiValueByRTL(new bool?(responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685_Applicable), null, text2.ToString(), text.ToString(), ref this.rptFields);
								this.rptFields.UIFieldName = responseSelectorListInnerSection.CHO9PursuitKnobMode_A36683.UIName.ToString();
								string uiName = responseSelectorListInnerSection.CHO9PursuitKnobMode_A36683_UIValue.ToString();
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕ꢗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕ꢗ", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕ꦗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕ꦗ", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕ꪗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕ꪗ", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕ꮗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udd8f\udd91킓펕ꮗ", a_), base.ci));
								num = (short)1168048134;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_54B:
							goto IL_641;
						}
						finally
						{
							num = (short)1013383168;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_582;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)141099010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_5B7;
								}
								IL_582:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1999896577;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5B7:;
						}
						goto IL_5BA;
						IL_641:
						A_0.RecSet.Add(base.rptRec);
						num = (short)27590658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5F:
					num = (short)1125842945;
					if (num != 0)
					{
					}
					num = (short)2133065728;
					short num4 = num;
					if (this.a != null)
					{
						num = (short)1988689920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_5BA:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud889ﶍ﶑望ﶗ얙쾛ﮝ첟잡잣튥잧\ud8a9", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.a.GetEnumerator();
					num = (short)82640899;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00277CE8 File Offset: 0x00275EE8
		private void f(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 2;
			short num = (short)459472896;
			switch (num)
			{
			default:
			{
				num = (short)254017537;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)101384193;
						if (num != 0)
						{
						}
						num = (short)1870494683;
						short num3 = num;
						num = (short)1658354651;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)881393664;
							if (num != 0)
							{
							}
							goto IL_566;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					case 2:
						return;
					case 3:
						try
						{
							num = (short)1550123009;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection;
								string text;
								string text2;
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1560346626;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									directionalButtonsListInnerSection = (acpFeatureNode[10610] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection);
									int radErgCtrlHeadO9DirLightBarFeature_A36597Value = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597Value;
									int radErgCtrlHeadO9DirLightBarIndex_A36601Value = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarIndex_A36601Value;
									text = (string)directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597.Converter.Convert(radErgCtrlHeadO9DirLightBarFeature_A36597Value, null, null, base.ci);
									text2 = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarIndex_A36601_UIValue;
									string str = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈\ude8a쎌캎슐삒\udc94킖힘\ude9a\ud99c", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("름", a_) + str + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뮄", a_);
									num = (short)324272136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_172;
									}
									continue;
								case 2:
									num = (short)1778909191;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									text2 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈\ude8a쎌캎슐삒\udc94킖힘\ude9a\ud99c", a_), base.ci);
									num = (short)464322570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈쾊쒌\udd8e풐킒솔\ude96횘햚\udc9c펞ﺬ", a_), base.ci);
									num = (short)576585737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (string.IsNullOrEmpty(this.rptFields.UIFieldDes))
									{
										num = (short)461438981;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_260;
								case 7:
									goto IL_4F5;
								case 8:
								{
									string str;
									if (text2 == str)
									{
										num = (short)1520041987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D2;
								}
								case 9:
									goto IL_260;
								case 10:
									goto IL_2D2;
								}
								goto IL_172;
								IL_260:
								base.rptRec.UIFields.Add(this.rptFields);
								num = (short)795738116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_290:
								num = (short)1077215232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_172:
								goto IL_290;
								IL_2D2:
								this.AddMultiValueByRTL(null, null, text2.ToString(), text.ToString(), ref this.rptFields);
								this.rptFields.UIFieldName = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarName_A36558.UIName.ToString();
								string uiName = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarName_A36558_UIValue.ToString();
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈\udf8a슌\udf8e튐횒\udb94쎖\udc98즚", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈\udf8a슌\udf8e튐횒\udb94쎖\udc98즚", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈잊좌즎얐", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈잊좌즎얐", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈\ud98a쒌좎\ud990잒", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈\ud98a쒌좎\ud990잒", a_), base.ci));
								num = (short)1602551814;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4F5:
							goto IL_5EE;
						}
						finally
						{
							num = (short)1763901440;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_52C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1133707266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_563;
								}
								IL_52C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)645398529;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_563:;
						}
						goto IL_566;
						IL_5EE:
						A_0.RecSet.Add(base.rptRec);
						num = (short)1534132226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5E:
					if (this.b != null)
					{
						num = (short)613941248;
						short num4 = num;
						num = (short)2047606784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_566:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솄ﮈﮎﲒﮔ쒚\udf9c햠힢쪤즦\udaa8", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.b.GetEnumerator();
					num = (short)1285619715;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0027832C File Offset: 0x0027652C
		private void e(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 9;
			for (;;)
			{
				IL_09:
				short num = (short)1139408896;
				switch (num)
				{
				default:
				{
					num = (short)1639907328;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_5A;
							}
							continue;
						case 1:
						{
							base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
							this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
							int count = base.count;
							base.count = count + 1;
							base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
							base.rptRec.RecNo = base.count.ToString();
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection o9InnerSection = this.c[0][10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection;
							int cho9EmergencyButtonFeature_A36682Value = o9InnerSection.CHO9EmergencyButtonFeature_A36682Value;
							string text = (string)o9InnerSection.CHO9EmergencyButtonFeature_A36682.Converter.Convert(cho9EmergencyButtonFeature_A36682Value, null, null, base.ci);
							base.AddFieldValue(ref this.rptFields, text.ToString());
							base.AddFieldValue(ref this.rptFields, text.ToString());
							this.rptFields.UIFieldName = o9InnerSection.CHO9EmergencyButtonName_A36680.UIName.ToString();
							this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋쪍쾏\udd91욓힕횗\udd99\ud99b\udc9d", a_), base.ci);
							base.rptRec.UIFields.Add(this.rptFields);
							A_0.RecSet.Add(base.rptRec);
							num = (short)726138882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							return;
						}
						IL_5A:
						num = (short)1738604544;
						short num3 = num;
						num = (short)768980374;
						short num4 = num;
						num = (short)738637206;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)550371328;
							if (num != 0)
							{
							}
							if (this.c == null)
							{
								return;
							}
							num = (short)751960065;
							if (num != 0)
							{
							}
							num = (short)1445658625;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					break;
				}
				}
			}
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x002785AC File Offset: 0x002767AC
		private void d(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 13;
			short num = (short)70254592;
			switch (num)
			{
			default:
			{
				num = (short)1914699777;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1363984624;
						short num3 = num;
						num = (short)1939456240;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)176488448;
							if (num != 0)
							{
							}
							goto IL_8D5;
						}
						break;
					}
					case 1:
						num = (short)679608321;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 2:
						return;
					case 3:
						try
						{
							num = (short)991756288;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
								string text;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1A7;
									}
									continue;
								case 1:
									goto IL_277;
								case 2:
									if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_Applicable)
									{
										num = (short)641400850;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									base.AddFieldValue(ref this.rptFields, "");
									num = (short)1266417667;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_247;
								case 4:
								{
									string str = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓쎕횗\udb99쾛춝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겏", a_) + str + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺏", a_);
									string fieldValue = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_UIValue.ToString();
									num = (short)1808531470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_5BF;
								case 6:
									if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_Applicable)
									{
										num = (short)1974861828;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									base.AddFieldValue(ref this.rptFields, "");
									num = (short)998440979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									string fieldValue2;
									string str2;
									if (fieldValue2 == str2)
									{
										num = (short)2033123352;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									base.AddFieldValue(ref this.rptFields, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_UIValue.ToString());
									num = (short)1812463639;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1494220811;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (string.IsNullOrEmpty(this.rptFields.UIFieldDes))
									{
										num = (short)191561748;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_277;
								case 10:
									base.AddFieldValue(ref this.rptFields, text.ToString());
									num = (short)364904454;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_865;
								case 12:
									goto IL_247;
								case 13:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1079312392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									bottomFunctionProgrammableButtonInnerSection = (acpFeatureNode[10619] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection);
									int cho9BottomFunctionButtonFeature_A36664Value = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664Value;
									text = (string)bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664.Converter.Convert(cho9BottomFunctionButtonFeature_A36664Value, null, null, base.ci);
									num = (short)1149370385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									string str;
									string fieldValue;
									if (fieldValue == str)
									{
										num = (short)331350037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									base.AddFieldValue(ref this.rptFields, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_UIValue.ToString());
									num = (short)2127560709;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									goto IL_5BF;
								case 16:
									goto IL_5BF;
								case 17:
									if (!base.isRTL)
									{
										num = (short)1853489162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)751632386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									string str2 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓쎕횗\udb99쾛춝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									str2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겏", a_) + str2 + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺏", a_);
									string fieldValue2 = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_UIValue.ToString();
									num = (short)716046343;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									goto IL_5BF;
								case 20:
									this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튏﶑쎛\udc9d햟횡킣즥욧", a_), base.ci);
									num = (short)1930100737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									string fieldValue = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓쎕횗\udb99쾛춝", a_), base.ci);
									base.AddFieldValue(ref this.rptFields, fieldValue);
									num = (short)1880752144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
									goto IL_247;
								case 24:
								{
									string fieldValue2 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓쎕횗\udb99쾛춝", a_), base.ci);
									base.AddFieldValue(ref this.rptFields, fieldValue2);
									num = (short)2070478860;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_1A7;
								IL_247:
								base.AddFieldValue(ref this.rptFields, text.ToString());
								num = (short)54722575;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_277:
								base.rptRec.UIFields.Add(this.rptFields);
								num = (short)276234262;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_38B:
								num = (short)168558605;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A7:
								goto IL_38B;
								IL_5BF:
								this.rptFields.UIFieldName = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonName_A36657.UIName.ToString();
								string uiName = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonName_A36657_UIValue.ToString();
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓욕ꦗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓욕ꦗ", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ꂑ쮓\udf95ﲗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ꂑ쮓\udf95ﲗ", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ꆑ쮓\udf95ﲗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ꆑ쮓\udf95ﲗ", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ꚑ쮓\udf95ﲗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ꚑ쮓\udf95ﲗ", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ꞑ쮓\udf95ﲗ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ꞑ쮓\udf95ﲗ", a_), base.ci));
								num = (short)793247753;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_865:
							goto IL_95B;
						}
						finally
						{
							num = (short)310968320;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_89C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1918238722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_8D2;
								}
								IL_89C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)351404033;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8D2:;
						}
						goto IL_8D5;
						IL_95B:
						A_0.RecSet.Add(base.rptRec);
						num = (short)1120272386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_84:
					num = (short)1385299968;
					short num4 = num;
					if (this.f != null)
					{
						num = (short)1839661056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_8D5:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튏﶑쎛\udc9d햟횡킣즥욧\ud9a9", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.f.GetEnumerator();
					num = (short)785907715;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00278F5C File Offset: 0x0027715C
		private void c(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 8;
			short num = (short)815529985;
			if (num != 0)
			{
			}
			num = (short)1163198464;
			switch (num)
			{
			default:
			{
				num = (short)1980039169;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1004671021;
						short num3 = num;
						num = (short)2029785133;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1734344704;
							if (num != 0)
							{
							}
							goto IL_3A8;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 2:
						return;
					case 3:
						try
						{
							num = (short)956432386;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)582221828;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection o9NavigationControlsTableInnerSection = acpFeatureNode[10734] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection;
									int radErgoControlO9NaviControlFeature_A41371Value = o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371Value;
									string text = (string)o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371.Converter.Convert(radErgoControlO9NaviControlFeature_A41371Value, null, null, base.ci);
									this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
									this.rptFields.UIFieldName = o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlName_A41370.UIName.ToString();
									string uiName = o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlName_A41370_UIValue.ToString();
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쒐쎒힔슖춘쾚튜톞", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쒐쎒힔슖춘쾚튜톞", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﾐ첒힔", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﾐ첒힔", a_), base.ci));
									base.rptRec.UIFields.Add(this.rptFields);
									num = (short)1295187968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_159;
									}
									continue;
								case 3:
									goto IL_335;
								case 4:
									num = (short)332136451;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2DC:
								num = (short)580386817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_159:
								goto IL_2DC;
							}
							IL_335:
							goto IL_42E;
						}
						finally
						{
							num = (short)506855424;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_36D;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)632881154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3A5;
								}
								IL_36D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)236126209;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A5:;
						}
						goto IL_3A8;
						IL_42E:
						A_0.RecSet.Add(base.rptRec);
						num = (short)1690304514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_85:
					num = (short)47316992;
					short num4 = num;
					if (this.e != null)
					{
						num = (short)1674182656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_3A8:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\udf90튒쎔\ude96\ude98\uda9a즜횞ﾪﾬﶰ", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.e.GetEnumerator();
					num = (short)415432707;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x002793E0 File Offset: 0x002775E0
		private void b(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 14;
			short num = (short)1697972224;
			switch (num)
			{
			default:
			{
				num = (short)204144641;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection;
					switch (num2)
					{
					case 0:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)694681609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_B8;
						}
						continue;
					case 2:
						goto IL_345;
					case 3:
					{
						base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						int count = base.count;
						base.count = count + 1;
						base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
						base.rptRec.RecNo = base.count.ToString();
						o9DataButtonInnerSection = (this.d[0][10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection);
						int radErgCtrlHeadO9DataButtonCnvFeature_A36528Value = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528Value;
						int radErgCtrlHeadO9DataButtonTrkFeature_A36526Value = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526Value;
						string text = (string)o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Converter.Convert(radErgCtrlHeadO9DataButtonCnvFeature_A36528Value, null, null, base.ci);
						string text2 = (string)o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Converter.Convert(radErgCtrlHeadO9DataButtonTrkFeature_A36526Value, null, null, base.ci);
						string cho9DataButtonConvIndex_A41414_UIValue = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414_UIValue;
						string cho9DataButtonTrkIndex_A41416_UIValue = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416_UIValue;
						num = (short)1508245514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1395785729;
						if (num != 0)
						{
						}
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)253689862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19C;
					case 5:
					{
						string text;
						base.AddFieldValue(ref this.rptFields, text.ToString());
						string text2;
						base.AddFieldValue(ref this.rptFields, text2.ToString());
						num = (short)1662713881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1199767578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_27A;
					case 8:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenStatic)
						{
							num = (short)483983375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					case 9:
						num = (short)1985806344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)377290752;
						short num3 = num;
						string text;
						if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔횖\uda98쾚풜킞直ﺶ", a_), base.ci))
						{
							num = (short)421199885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_345;
					}
					case 11:
					{
						num = (short)418104682;
						short num4 = num;
						num = (short)1055769962;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C8;
						default:
						{
							num = (short)673841152;
							if (num != 0)
							{
							}
							base.AddFieldValue(ref this.rptFields, "");
							string text;
							base.AddFieldValue(ref this.rptFields, text.ToString());
							num = (short)37552145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 12:
						num = (short)1718484992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						string cho9DataButtonConvIndex_A41414_UIValue;
						string text = text + base.indexSeparator + cho9DataButtonConvIndex_A41414_UIValue;
						num = (short)1436286978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_5E3;
					case 15:
					{
						string text2;
						base.AddFieldValue(ref this.rptFields, text2.ToString());
						string text;
						base.AddFieldValue(ref this.rptFields, text.ToString());
						num = (short)1104216071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						string cho9DataButtonTrkIndex_A41416_UIValue;
						string text2 = text2 + base.indexSeparator + cho9DataButtonTrkIndex_A41416_UIValue;
						num = (short)42074126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_27A;
					case 18:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)2101805080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 19:
					{
						string text2;
						if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔횖\uda98쾚풜킞直ﺶ", a_), base.ci))
						{
							num = (short)1446445072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E3;
					}
					case 20:
						goto IL_27A;
					case 21:
						if (base.isRTL)
						{
							num = (short)287375372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)749993988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)1794637835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 23:
						return;
					case 24:
					{
						string text;
						base.AddFieldValue(ref this.rptFields, text.ToString());
						base.AddFieldValue(ref this.rptFields, "");
						goto IL_3C8;
					}
					case 25:
						goto IL_27A;
					case 26:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenStatic)
						{
							num = (short)514588677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19C;
					}
					IL_B8:
					if (this.d != null)
					{
						num = (short)621543427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_126:
					num = (short)581107734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19C:
					num = (short)1939800082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					this.rptFields.UIFieldName = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonName_A36523.UIName.ToString();
					this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔펖\ud898쾚\udc9c\udd9e鲬", a_), base.ci);
					base.rptRec.UIFields.Add(this.rptFields);
					A_0.RecSet.Add(base.rptRec);
					num = (short)705167383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_345:
					num = (short)821886995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C8:
					num = (short)1879244820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E3:
					num = (short)1270087701;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00279AE4 File Offset: 0x00277CE4
		private void a(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 3;
			short num = (short)1059979264;
			switch (num)
			{
			default:
			{
				num = (short)755105795;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)718733319;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection;
								switch (num2)
								{
								case 0:
									goto IL_1C6;
								case 1:
									if (!pasirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.HiddenStatic)
									{
										num = (short)893517829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C6;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)793706502;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									pasirenButtonsListInnerSection = (acpFeatureNode[10744] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection);
									int cho9PASirenButtonsFeature_A41540Value = pasirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540Value;
									string text = (string)pasirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Converter.Convert(cho9PASirenButtonsFeature_A41540Value, null, null, base.ci);
									num = (short)884277249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_452;
								case 5:
								{
									string text;
									this.AddMultiValueByRTL(null, null, string.Empty, text.ToString(), ref this.rptFields);
									num = (short)1604059136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)656736259;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_F0;
									}
									continue;
								}
								IL_185:
								num = (short)1997406210;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F0:
								goto IL_185;
								IL_1C6:
								this.rptFields.UIFieldName = pasirenButtonsListInnerSection.CHO9PASirenButtonsName_A41537.UIName;
								string uiName = pasirenButtonsListInnerSection.CHO9PASirenButtonsName_A41537_UIValue.ToString();
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍슏힑\uda93힕톗좙풛톝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍슏힑\uda93힕톗좙풛톝", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍슏힑\uda93\udb95\ud997풙즛\udf9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍슏힑\uda93\udb95\ud997풙즛\udf9d", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍슏힑\uda93솕\ud997펙킛", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍슏힑\uda93솕\ud997펙킛", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍슏힑\uda93쾕\udd97횙첛", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍슏힑\uda93쾕\udd97횙첛", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즅놇행\udf8b望즕킗", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즅놇행\udf8b望즕킗", a_), base.ci));
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즅놇행\udf8b望즕좗\udb99", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즅놇행\udf8b望즕좗\udb99", a_), base.ci));
								base.rptRec.UIFields.Add(this.rptFields);
								num = (short)17367044;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_452:
							goto IL_595;
						}
						finally
						{
							num = (short)701038594;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1743908677;
									short num3 = num;
									num = (short)1467936581;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_48F;
									default:
										goto IL_4F7;
									}
									break;
								}
								case 1:
									enumerator.Dispose();
									num = (short)1353252864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_489;
									}
									continue;
								}
								goto IL_489;
								IL_48F:
								num = (short)457244673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_489:
								if (enumerator != null)
								{
									goto IL_48F;
								}
								goto IL_50E;
							}
							IL_4F7:
							num = (short)233177088;
							if (num != 0)
							{
							}
							IL_50E:;
						}
						goto IL_50F;
						IL_595:
						num = (short)1713963008;
						short num4 = num;
						A_0.RecSet.Add(base.rptRec);
						num = (short)1755906049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						num = (short)577503233;
						if (num != 0)
						{
						}
						goto IL_50F;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					}
					IL_5C:
					if (this.g != null)
					{
						num = (short)1863319554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_50F:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udc8b쾍쎏\udb91욓펕횗\ud899즛쪝", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.g.GetEnumerator();
					num = (short)865599488;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0027A0F8 File Offset: 0x002782F8
		public override void BuildDataTables(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData XMLRptDataObj)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_190;
				case 1:
				{
					num2 = (short)134271540;
					short num3 = num2;
					num2 = (short)1769263668;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_192;
					default:
					{
						num2 = (short)1054736385;
						if (num2 != 0)
						{
						}
						num2 = (short)2017853440;
						if (num2 != 0)
						{
						}
						num2 = (short)1722482688;
						short num4 = num2;
						this.g(ref this.rptTable);
						this.f(ref this.rptTable);
						this.e(ref this.rptTable);
						this.d(ref this.rptTable);
						this.c(ref this.rptTable);
						this.b(ref this.rptTable);
						this.AddKeypadButton(ref this.rptTable);
						this.a(ref this.rptTable);
						num2 = (short)190119936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num2 = (short)1874788353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_192;
				}
				goto IL_1C;
			}
			IL_190:
			IL_192:
			XMLRptDataObj.tables.Add(this.rptTable);
			base.AddZonesAndChannels(ref XMLRptDataObj);
			return;
			IL_1C:
			this.AddGeneral(ref XMLRptDataObj);
			this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
			base.acpr = new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
			this.CreateTableHeader(ref this.rptTable);
			num2 = (short)1679491074;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000E33 RID: 3635
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset a;

		// Token: 0x04000E34 RID: 3636
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset b;

		// Token: 0x04000E35 RID: 3637
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset c;

		// Token: 0x04000E36 RID: 3638
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset d;

		// Token: 0x04000E37 RID: 3639
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset e;

		// Token: 0x04000E38 RID: 3640
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset f;

		// Token: 0x04000E39 RID: 3641
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset g;
	}
}
