using System;
using System.Collections.Generic;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x02000238 RID: 568
	public class O5XMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine
	{
		// Token: 0x06001C96 RID: 7318 RVA: 0x00272964 File Offset: 0x00270B64
		public O5XMLCoreEngine()
		{
			this.a = (global::AcpCommonLib.FeatureManager.GetFeature(2130)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5);
			this.b = (global::AcpCommonLib.FeatureManager.GetFeature(2128)[0] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories);
			this.f = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
			if (this.f != null)
			{
				this.c = (this.f[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset);
				this.g = (this.f[0][10735].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset);
			}
			this.h = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
			if (this.h != null)
			{
				this.d = (this.h[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset);
				this.e = (this.h[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00272A88 File Offset: 0x00270C88
		private void d(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 1;
			short num = (short)1564606464;
			switch (num)
			{
			default:
			{
				num = (short)1262485506;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)262864896;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_392;
					case 1:
						try
						{
							num = (short)1190920196;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)628722987;
									short num4 = num;
									num = (short)1826917675;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)1626144768;
										if (num != 0)
										{
										}
										if (!enumerator.MoveNext())
										{
											num = (short)2074017793;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
										this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
										int count = base.count;
										base.count = count + 1;
										base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
										base.rptRec.RecNo = base.count.ToString();
										global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection o5InnerSection = acpFeatureNode[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection;
										int cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Value = o5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Value;
										string text = (string)o5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Converter.Convert(cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Value, null, null, base.ci);
										this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
										this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner)acpFeatureNode).O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.UIName.ToString();
										this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇얉\ude8b쾍\ude8f햑톓풕춗캙좛톝", a_), base.ci);
										base.rptRec.UIFields.Add(this.rptFields);
										A_0.RecSet.Add(base.rptRec);
										num = (short)1827078146;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 1:
									num = (short)1654259715;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_2FA;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E1;
									}
									continue;
								}
								IL_E6:
								num = (short)595525632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E1:
								goto IL_E6;
							}
							IL_2FA:
							return;
						}
						finally
						{
							num = (short)605880322;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)66060289;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)411369473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_38F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_331;
									}
									continue;
								}
								IL_331:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2140864512;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_38F:;
						}
						goto IL_392;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					}
					IL_82:
					if (this.c != null)
					{
						num = (short)1554776064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_392:
					enumerator = this.c.GetEnumerator();
					num = (short)2101215233;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00272E6C File Offset: 0x0027106C
		private void c(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 12;
			short num = (short)1273954304;
			switch (num)
			{
			default:
			{
				num = (short)881786882;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1804402689;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_514;
					case 1:
					{
						num = (short)340066304;
						short num3 = num;
						try
						{
							num = (short)561643524;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)116195334;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									IL_3AE:
									this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒\uda94ꊖ\udb98캚즜쮞", a_), base.ci);
									num = (short)798425093;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (string.IsNullOrEmpty(this.rptFields.UIFieldDes))
									{
										num = (short)1645150210;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B3;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_EB;
									}
									continue;
								case 5:
									goto IL_3B3;
								case 6:
									goto IL_4A4;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1638400000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									int count = base.count;
									base.count = count + 1;
									base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
									base.rptRec.RecNo = base.count.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection = acpFeatureNode[10239] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection;
									int radErgoCfgKMConventionalKMButtonFeature_A19646Value = kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646Value;
									int radErgoCfgKMTrunkingKMButtonFeature_A19746Value = kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746Value;
									string text = (string)kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Converter.Convert(radErgoCfgKMConventionalKMButtonFeature_A19646Value, null, null, base.ci);
									string text2 = (string)kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Converter.Convert(radErgoCfgKMTrunkingKMButtonFeature_A19746Value, null, null, base.ci);
									this.AddMultiValueByRTL(new bool?(!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic), new bool?(!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic), text2.ToString(), text.ToString(), ref this.rptFields);
									this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561.UIName.ToString();
									string uiName = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561_UIValue.ToString();
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a즜킞ﶨ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a즜킞ﶨ", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a킜횞ﺪ怜ﮮﺰﶲ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a킜횞ﺪ怜ﮮﺰﶲ", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a\udf9c킞ﺪ怜ﮮﺰﶲ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a\udf9c킞ﺪ怜ﮮﺰﶲ", a_), base.ci));
									num = (short)2062155779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_F0:
								num = (short)1682178055;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EB:
								goto IL_F0;
								IL_3B3:
								base.rptRec.UIFields.Add(this.rptFields);
								A_0.RecSet.Add(base.rptRec);
								num = (short)423386579;
								short num4 = num;
								num = (short)248864211;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3AE;
								default:
									num = (short)150667264;
									if (num != 0)
									{
									}
									num = (short)1364918273;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_4A4:
							return;
						}
						finally
						{
							num = (short)1578762242;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1224212481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_511;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4DB;
									}
									continue;
								}
								IL_4DB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1771044864;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_511:;
						}
						goto IL_514;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					}
					IL_7F:
					if (this.d != null)
					{
						num = (short)162856960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_514:
					enumerator = this.d.GetEnumerator();
					num = (short)1674182657;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x002733FC File Offset: 0x002715FC
		private void b(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 9;
			short num = (short)1031077888;
			switch (num)
			{
			default:
			{
				num = (short)299499523;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_3A2;
					case 1:
						try
						{
							num = (short)788463620;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)468516866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									for (;;)
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
										global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection o5NavigationControlsTableInnerSection = acpFeatureNode[10736] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection;
										int radErgoControlO5NaviControlFeature_A41379Value = o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379Value;
										string text = (string)o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379.Converter.Convert(radErgoControlO5NaviControlFeature_A41379Value, null, null, base.ci);
										this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
										this.rptFields.UIFieldName = o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlName_A41378.UIName.ToString();
										string uiName = o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlName_A41378_UIValue.ToString();
										this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋쪍쾏작쒓풕춗캙좛톝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋쪍쾏작쒓풕춗캙좛톝", a_), base.ci));
										this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좋ﲑ쮓풕캟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좋ﲑ쮓풕캟", a_), base.ci));
										base.rptRec.UIFields.Add(this.rptFields);
										num = (short)557174562;
										short num3 = num;
										num = (short)1948307234;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_284;
										}
									}
									IL_284:
									num = (short)1345323009;
									if (num != 0)
									{
									}
									num = (short)868483072;
									if (num != 0)
									{
									}
									num = (short)499843072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1077608451;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_331;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E7;
									}
									continue;
								}
								IL_2DC:
								num = (short)2022637569;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E7:
								goto IL_2DC;
							}
							IL_331:
							goto IL_429;
						}
						finally
						{
							num = (short)26279938;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1793327105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_39F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_368;
									}
									continue;
								}
								IL_368:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1140326400;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39F:;
						}
						goto IL_3A2;
						IL_429:
						A_0.RecSet.Add(base.rptRec);
						num = (short)915865602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					}
					IL_5E:
					if (this.g != null)
					{
						num = (short)811335680;
						short num4 = num;
						num = (short)1834745856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_3A2:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋쪍쾏\udc91햓삕톗\udd99\udd9b쪝ﲭﾯﺱ", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.g.GetEnumerator();
					num = (short)954007553;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0027387C File Offset: 0x00271A7C
		private void a(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 1;
			short num = (short)284098560;
			switch (num)
			{
			default:
			{
				num = (short)1259864067;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
					string text;
					string text2;
					switch (num2)
					{
					case 0:
					{
						base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						int count = base.count;
						base.count = count + 1;
						base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
						base.rptRec.RecNo = base.count.ToString();
						acpFeatureNode = this.e[0];
						dataButtonInnerSection = (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection);
						int radErgoCfgKMConventionalKMDatatButtonFeature_A22603Value = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603Value;
						int radErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value;
						text = (string)dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Converter.Convert(radErgoCfgKMConventionalKMDatatButtonFeature_A22603Value, null, null, base.ci);
						text2 = (string)dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Converter.Convert(radErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value, null, null, base.ci);
						string radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						string radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
						num = (short)1975255041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇쮉쾋\uda8d\ud98f\udd91\uda93햕힗풙쾛톝ﲧ", a_), base.ci))
						{
							num = (short)920715269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_136;
					case 2:
						goto IL_2E2;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 4:
						goto IL_136;
					case 5:
					{
						string radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						text = text + base.indexSeparator + radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						goto IL_3C8;
					}
					case 6:
						if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇쮉쾋\uda8d\ud98f\udd91\uda93햕힗풙쾛톝ﲧ", a_), base.ci))
						{
							num = (short)628949000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E2;
					case 7:
						goto IL_3B5;
					case 8:
					{
						string radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
						text2 = text2 + base.indexSeparator + radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
						num = (short)299815919;
						short num3 = num;
						num = (short)1535824879;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C8;
						default:
							num = (short)807010305;
							if (num != 0)
							{
							}
							num = (short)1967915008;
							if (num != 0)
							{
							}
							num = (short)1310261250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_71:
					if (this.e != null)
					{
						num = (short)1795883008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_136:
					num = (short)1033306118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E2:
					this.AddMultiValueByRTL(new bool?(!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic), new bool?(!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic), text2.ToString(), text.ToString(), ref this.rptFields);
					this.rptFields.UIFieldName = (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMDataButtonName_A22601.UIName.ToString();
					this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇캉춋\uda8d톏킑솓슕첗햙튛솝醟", a_), base.ci);
					base.rptRec.UIFields.Add(this.rptFields);
					A_0.RecSet.Add(base.rptRec);
					num = (short)822542343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C8:
					num = (short)1250426884;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B5:
				num = (short)1448214528;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00273C98 File Offset: 0x00271E98
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
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num2 = (short)1461977090;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16F;
				case 1:
					goto IL_16D;
				case 2:
				{
					num2 = (short)613284329;
					short num3 = num2;
					num2 = (short)573241833;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)445382657;
						if (num2 != 0)
						{
						}
						num2 = (short)1442316288;
						if (num2 != 0)
						{
						}
						this.d(ref this.rptTable);
						this.c(ref this.rptTable);
						this.b(ref this.rptTable);
						this.a(ref this.rptTable);
						this.AddKeypadButton(ref this.rptTable);
						num2 = (short)1432223745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_16D:
			IL_16F:
			XMLRptDataObj.tables.Add(this.rptTable);
			base.AddZonesAndChannels(ref XMLRptDataObj);
			return;
			IL_1C:
			num2 = (short)384827392;
			short num4 = num2;
			this.AddGeneral(ref XMLRptDataObj);
			this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
			base.acpr = new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
			this.CreateTableHeader(ref this.rptTable);
			num2 = (short)840892416;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000E1C RID: 3612
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5 a;

		// Token: 0x04000E1D RID: 3613
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories b;

		// Token: 0x04000E1E RID: 3614
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset c;

		// Token: 0x04000E1F RID: 3615
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset d;

		// Token: 0x04000E20 RID: 3616
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset e;

		// Token: 0x04000E21 RID: 3617
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset f;

		// Token: 0x04000E22 RID: 3618
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset g;

		// Token: 0x04000E23 RID: 3619
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset h;
	}
}
