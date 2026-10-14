using System;
using System.Collections.Generic;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.Keypad;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x02000236 RID: 566
	public class O2XMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine
	{
		// Token: 0x06001C8A RID: 7306 RVA: 0x0026FE7C File Offset: 0x0026E07C
		public O2XMLCoreEngine()
		{
			this.a = (global::AcpCommonLib.FeatureManager.GetFeature(4115)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2);
			this.b = (global::AcpCommonLib.FeatureManager.GetFeature(2128)[0] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories);
			this.f = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
			if (this.f != null)
			{
				this.c = (this.f[0][10723].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset);
				this.g = (this.f[0][10722].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset);
			}
			this.h = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
			if (this.h != null)
			{
				this.d = (this.h[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset);
				this.e = (this.h[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
			}
			this.i = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
			if (this.i != null)
			{
				this.j = (this.i[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
			}
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0026FFF8 File Offset: 0x0026E1F8
		private void e(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 8;
			short num = (short)66387968;
			switch (num)
			{
			default:
			{
				num = (short)1893138434;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1120272388;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2A9;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)862978051;
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
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection o2InnerSection = acpFeatureNode[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection;
									int cho2EmergencyButtonFeature_A41272Value = o2InnerSection.CHO2EmergencyButtonFeature_A41272Value;
									string text = (string)o2InnerSection.CHO2EmergencyButtonFeature_A41272.Converter.Convert(cho2EmergencyButtonFeature_A41272Value, null, null, base.ci);
									this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
									this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2Inner)acpFeatureNode).O2InnerSection.CHO2EmergencyButtonName_A41270.ToString();
									this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\ude90솒풔\ud996\ude98\ude9a\udf9c쪞", a_), base.ci);
									base.rptRec.UIFields.Add(this.rptFields);
									A_0.RecSet.Add(base.rptRec);
									num = (short)743374849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)619577344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E1;
									}
									continue;
								}
								IL_E6:
								num = (short)1084358658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E1:
								goto IL_E6;
							}
							IL_2A9:
							return;
						}
						finally
						{
							num = (short)1522663426;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_319;
								case 1:
									enumerator.Dispose();
									num = (short)1795424256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2E0;
									}
									continue;
								}
								goto IL_2E0;
								IL_2E3:
								num = (short)1781006337;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_319:
								num = (short)1454914093;
								short num3 = num;
								num = (short)1859271213;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2E3;
								default:
									goto IL_34F;
								}
								IL_2E0:
								if (enumerator != null)
								{
									goto IL_2E3;
								}
								goto IL_319;
							}
							IL_34F:
							num = (short)1393623040;
							if (num != 0)
							{
							}
						}
						goto IL_366;
					case 1:
						goto IL_366;
					case 2:
					{
						num = (short)1414070272;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					}
					}
					IL_80:
					if (this.c != null)
					{
						num = (short)156303361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_366:
					enumerator = this.c.GetEnumerator();
					num = (short)893386753;
					if (num != 0)
					{
					}
					num = (short)1237712896;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x002703D8 File Offset: 0x0026E5D8
		private void d(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 15;
			short num = (short)1543176192;
			short num2 = num;
			num = (short)876609536;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2 controlHeadO;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection o2MFKAssignmentControlInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection o2MFKAssignmentControlInnerSection2;
				for (;;)
				{
					IL_58:
					switch (num3)
					{
					case 0:
						goto IL_207;
					case 1:
						if (controlHeadO != null)
						{
							num = (short)1671233544;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C5;
					case 2:
						if (!controlHeadO.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.HiddenStatic)
						{
							num = (short)1125318660;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_207;
					case 3:
						if (o2MFKAssignmentControlInnerRecset != null)
						{
							num = (short)848363527;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C5;
					case 4:
					{
						this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						int value = controlHeadO.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Value;
						string text = (string)controlHeadO.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Converter.Convert(value, null, null, base.ci);
						this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text, text, ref this.rptFields);
						this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf91튓\udd95좗鍊펟솣캥즧\udca9얫솭슯", a_);
						this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗\udc99힛캝ﮱ﮳", a_), base.ci);
						base.rptRec.UIFields.Add(this.rptFields);
						num = (short)1309868032;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_11E;
					case 6:
						goto IL_2D0;
					case 7:
						o2MFKAssignmentControlInnerSection = (o2MFKAssignmentControlInnerRecset[0][10726] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection);
						o2MFKAssignmentControlInnerSection2 = (o2MFKAssignmentControlInnerRecset[1][10726] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection);
						num = (short)1313603590;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)199268346;
						short num4 = num;
						num = (short)113022970;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11E;
						default:
							num = (short)991821824;
							if (num != 0)
							{
							}
							o2MFKAssignmentControlInnerRecset = (controlHeadO[10721].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset);
							num = (short)2003828737;
							if (num != 0)
							{
							}
							num = (short)595525635;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						num = (short)54525954;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_87;
					IL_11E:
					if (controlHeadO != null)
					{
						num = (short)2128740361;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_207:
					num = (short)685244417;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_2D0:
				IL_3C5:
				this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int value2 = o2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.Value;
				string text2 = (string)o2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.Converter.Convert(value2, null, null, base.ci);
				this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text2, text2, ref this.rptFields);
				this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ﾕﮙ힡쪣얥\udca7쎩쎫삭", a_);
				this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ﾕﮙﾟ톣좥쮧\udea9얫솭\udeaf", a_), base.ci);
				base.rptRec.UIFields.Add(this.rptFields);
				this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int value3 = o2MFKAssignmentControlInnerSection2.RadErgoControlO2MFKFeatureAssignment_A41275.Value;
				string text3 = (string)o2MFKAssignmentControlInnerSection2.RadErgoControlO2MFKFeatureAssignment_A41275.Converter.Convert(value3, null, null, base.ci);
				this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text3, text3, ref this.rptFields);
				this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﾝ튟\udba1펥욧즩\ud8ab잭\udfaf\udcb1", a_);
				this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﾝ튟\udba1ﮣ\udda7쒩쾫\udaad\ud9af\uddb1\udab3", a_), base.ci);
				base.rptRec.UIFields.Add(this.rptFields);
				A_0.RecSet.Add(base.rptRec);
				return;
				IL_87:
				base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				int count = base.count;
				base.count = count + 1;
				base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗쾙킛쪝ﺩﺯ鈴荒例覆", a_), base.ci);
				base.rptRec.RecNo = base.count.ToString();
				o2MFKAssignmentControlInnerRecset = null;
				o2MFKAssignmentControlInnerSection = null;
				o2MFKAssignmentControlInnerSection2 = null;
				controlHeadO = null;
				controlHeadO = (global::AcpCommonLib.FeatureManager.GetFeature(4115)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2);
				num = (short)437846021;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0027094C File Offset: 0x0026EB4C
		private void c(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 8;
			short num = (short)1457520640;
			switch (num)
			{
			default:
			{
				num = (short)445513730;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1525481473;
						if (num != 0)
						{
						}
						try
						{
							num = (short)660865028;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3ED;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1724514307;
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
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖춘풚출\udd9e", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖춘풚출\udd9e", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖풘튚\ud99c\udb9eﶨﾪ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖풘튚\ud99c\udb9eﶨﾪ", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖\udb98풚즜쮞ﶨﾪ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖\udb98풚즜쮞ﶨﾪ", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, null, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\ude90Ꚓ힔슖춘쾚튜톞", a_), base.ci));
									base.rptRec.UIFields.Add(this.rptFields);
									A_0.RecSet.Add(base.rptRec);
									num = (short)1066663937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1991311360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E2;
									}
									continue;
								}
								IL_E7:
								num = (short)216203266;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E2:
								goto IL_E7;
							}
							IL_3ED:
							return;
						}
						finally
						{
							num = (short)309723138;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_45E;
								case 1:
									enumerator.Dispose();
									num = (short)1696727040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_425;
									}
									continue;
								}
								goto IL_425;
								IL_428:
								num = (short)982384641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_45E:
								num = (short)1460547639;
								short num3 = num;
								num = (short)2009673783;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_428;
								default:
									goto IL_494;
								}
								IL_425:
								if (enumerator != null)
								{
									goto IL_428;
								}
								goto IL_45E;
							}
							IL_494:
							num = (short)216006656;
							if (num != 0)
							{
							}
						}
						goto IL_4AA;
					case 1:
						goto IL_4AA;
					case 2:
					{
						num = (short)1678508032;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					}
					}
					IL_83:
					if (this.d != null)
					{
						num = (short)719978497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_4AA:
					enumerator = this.d.GetEnumerator();
					num = (short)1284571136;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00270E74 File Offset: 0x0026F074
		private void b(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 2;
			short num = (short)395051008;
			switch (num)
			{
			default:
			{
				num = (short)1803026435;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)57999361;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)128319492;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2C1;
								case 1:
									num = (short)1933639680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1701183489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection o2NavigationControlsTableInnerSection = acpFeatureNode[10725] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection;
									int radErgoControlO2UpDownButton_A41278Value = o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278Value;
									string text = (string)o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278.Converter.Convert(radErgoControlO2UpDownButton_A41278Value, null, null, base.ci);
									this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
									this.rptFields.UIFieldName = o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278.UIName.ToString();
									string uiName = o2NavigationControlsTableInnerSection.O2UpDownButtonName_A41277_UIValue.ToString();
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈\ude8a\udd8c춎쒐잒솔\ud896힘", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈\ude8a\udd8c춎쒐잒솔\ud896힘", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솄ﺈ튌춎", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솄ﺈ튌춎", a_), base.ci));
									base.rptRec.UIFields.Add(this.rptFields);
									num = (short)1138819074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E7;
									}
									continue;
								}
								IL_269:
								num = (short)493355011;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E7:
								goto IL_269;
							}
							IL_2C1:
							goto IL_402;
						}
						finally
						{
							num = (short)870645762;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_330;
								case 1:
									enumerator.Dispose();
									num = (short)818085888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2F8;
									}
									continue;
								}
								goto IL_2F8;
								IL_2FB:
								num = (short)1198325761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_330:
								num = (short)1294666082;
								short num3 = num;
								num = (short)378079586;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2FB;
								default:
									goto IL_365;
								}
								IL_2F8:
								if (enumerator != null)
								{
									goto IL_2FB;
								}
								goto IL_330;
							}
							IL_365:
							num = (short)758382592;
							if (num != 0)
							{
							}
						}
						goto IL_37B;
						IL_402:
						A_0.RecSet.Add(base.rptRec);
						num = (short)237305857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_42E;
					case 2:
						goto IL_37B;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					}
					IL_86:
					if (this.g != null)
					{
						num = (short)2080374786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_37B:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈얊첌\ud98e\ud890풒풔쎖킘풚펜\udc9eﺬ", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.g.GetEnumerator();
					num = (short)2005401600;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_42E:
				num = (short)1997275136;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x002712F8 File Offset: 0x0026F4F8
		private void a(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 0;
			short num;
			for (;;)
			{
				IL_09:
				num = (short)1619263488;
				short num2 = num;
				num = (short)1373372416;
				switch (num)
				{
				default:
				{
					num = (short)821821444;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text;
						string text2;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						switch (num3)
						{
						case 0:
						{
							string radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
							text = text + base.indexSeparator + radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
							num = (short)854589442;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪂솄\ud886좈좊\ud98c욎\ude90\udd92횔\ud896힘좚튜펞", a_), base.ci))
							{
								num = (short)1921384448;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EB;
						case 2:
							goto IL_EB;
						case 3:
							goto IL_2DF;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_99;
							}
							continue;
						case 5:
							goto IL_3B2;
						case 6:
							if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪂솄\ud886좈좊\ud98c욎\ude90\udd92횔\ud896힘좚튜펞", a_), base.ci))
							{
								num = (short)1825898503;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DF;
						case 7:
						{
							num = (short)1727764959;
							short num4 = num;
							num = (short)1290705375;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
							{
								num = (short)1194065920;
								if (num != 0)
								{
								}
								string radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
								text2 = text2 + base.indexSeparator + radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
								num = (short)562823171;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 8:
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
							num = (short)618921985;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_99:
						if (this.e != null)
						{
							num = (short)1220280328;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
						IL_EB:
						num = (short)67698694;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2DF:
						this.AddMultiValueByRTL(new bool?(!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic), new bool?(!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic), text2.ToString(), text.ToString(), ref this.rptFields);
						this.rptFields.UIFieldName = (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMDataButtonName_A22601.UIName.ToString();
						this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪂솄\ud886춈쪊\ud98c캎펐욒솔쎖횘햚슜꺞", a_), base.ci);
						base.rptRec.UIFields.Add(this.rptFields);
						A_0.RecSet.Add(base.rptRec);
						num = (short)450625541;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_3B2:
			IL_3E3:
			num = (short)142016513;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00271710 File Offset: 0x0026F910
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
					goto IL_14D;
				case 1:
					goto IL_EE;
				case 2:
				{
					if (!global::ConstraintHelper.UtilityMack.IsMobile())
					{
						goto IL_177;
					}
					num2 = (short)152043521;
					if (num2 != 0)
					{
					}
					num2 = (short)1908540657;
					short num3 = num2;
					num2 = (short)1003750641;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EE;
					default:
						num2 = (short)89587712;
						if (num2 != 0)
						{
						}
						num2 = (short)17825793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
				IL_EE:
				this.e(ref this.rptTable);
				this.d(ref this.rptTable);
				this.c(ref this.rptTable);
				this.b(ref this.rptTable);
				this.a(ref this.rptTable);
				this.AddKeypadButton(ref this.rptTable);
				num2 = (short)1810497536;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14D:
			num2 = (short)15466496;
			short num4 = num2;
			IL_177:
			XMLRptDataObj.tables.Add(this.rptTable);
			base.AddZonesAndChannels(ref XMLRptDataObj);
			return;
			IL_1C:
			this.AddGeneral(ref XMLRptDataObj);
			this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
			base.acpr = new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
			this.CreateTableHeader(ref this.rptTable);
			num2 = (short)1229389826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000E0D RID: 3597
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2 a;

		// Token: 0x04000E0E RID: 3598
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories b;

		// Token: 0x04000E0F RID: 3599
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset c;

		// Token: 0x04000E10 RID: 3600
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset d;

		// Token: 0x04000E11 RID: 3601
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset e;

		// Token: 0x04000E12 RID: 3602
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset f;

		// Token: 0x04000E13 RID: 3603
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset g;

		// Token: 0x04000E14 RID: 3604
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset h;

		// Token: 0x04000E15 RID: 3605
		private global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset i;

		// Token: 0x04000E16 RID: 3606
		private global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset j;
	}
}
