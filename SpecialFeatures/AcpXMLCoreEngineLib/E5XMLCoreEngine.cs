using System;
using System.Collections.Generic;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x0200023A RID: 570
	public class E5XMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x00275884 File Offset: 0x00273A84
		public E5XMLCoreEngine()
		{
			this.a = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset);
			if (this.a != null)
			{
				this.c = (this.a[0][10902].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset);
				this.d = (this.a[0][10903].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset);
				this.b = (this.a[0][10896].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset);
			}
			this.f = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
			if (this.f != null)
			{
				this.e = (this.f[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset);
				this.g = (this.f[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x002759A0 File Offset: 0x00273BA0
		private void e(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 12;
			short num = (short)250675200;
			switch (num)
			{
			default:
			{
				num = (short)969342977;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1478295552;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)638320640;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_DF;
									}
									continue;
								case 1:
									num = (short)1794703361;
									if (num != 0)
									{
									}
									break;
								case 2:
									num = (short)1332215811;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_2C3;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)955580418;
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
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection e5InnerSection = acpFeatureNode[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection;
									int che5EmergencyButtonFeature_43768Value = e5InnerSection.CHE5EmergencyButtonFeature_43768Value;
									string text = e5InnerSection.CHE5EmergencyButtonFeature_43768.Converter.Convert(che5EmergencyButtonFeature_43768Value, null, null, base.ci).ToString();
									this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text, text, ref this.rptFields);
									this.rptFields.UIFieldName = (acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5Inner).E5InnerSection.CHE5EmergencyButtonName_43766Value.ToString();
									this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒\uda94얖\ud898햚\uda9c\uda9e", a_), base.ci);
									base.rptRec.UIFields.Add(this.rptFields);
									A_0.RecSet.Add(base.rptRec);
									num = (short)348454913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_E4:
								num = (short)148504580;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DF:
								goto IL_E4;
							}
							IL_2C3:
							return;
						}
						finally
						{
							for (;;)
							{
								num = (short)1227751425;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_332;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2FC;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)893845504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2FC:
									if (enumerator == null)
									{
										break;
									}
									num = (short)879886338;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_334:
								num = (short)1518293420;
								short num4 = num;
								num = (short)1735807404;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_36A;
								}
								IL_332:
								goto IL_334;
							}
							IL_36A:
							num = (short)876150784;
							if (num != 0)
							{
							}
						}
						goto IL_380;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 2:
						goto IL_380;
					}
					IL_80:
					if (this.c != null)
					{
						num = (short)694747138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_380:
					enumerator = this.c.GetEnumerator();
					num = (short)1468858368;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00275D74 File Offset: 0x00273F74
		private void d(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 17;
			short num = (short)2015363072;
			switch (num)
			{
			default:
			{
				num = (short)1640824834;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)330891264;
						short num3 = num;
						try
						{
							num = (short)23986178;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection;
								switch (num2)
								{
								case 0:
								{
									string text;
									base.AddFieldValue(ref this.rptFields, text.ToString());
									num = (short)1676279817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_55A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_123;
									}
									continue;
								case 3:
									if (e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759_Applicable)
									{
										num = (short)1220870154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									base.AddFieldValue(ref this.rptFields, "");
									num = (short)1023541267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)771620865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (string.IsNullOrEmpty(this.rptFields.UIFieldDes))
									{
										num = (short)572784655;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_20E;
								case 6:
									goto IL_20E;
								case 7:
									goto IL_4D2;
								case 8:
									goto IL_4D2;
								case 9:
									goto IL_464;
								case 10:
								{
									string str = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쾙튛\udf9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꢓ", a_) + str + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪓ", a_);
									string fieldValue = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759_UIValue;
									num = (short)245104654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									goto IL_159;
								case 13:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)647954436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									e5BottomFunctionButtonInnerSection = (acpFeatureNode[10904] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection);
									int e5BottomFunctionButtonFeature_43758Value = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonFeature_43758Value;
									string text = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonFeature_43758.Converter.Convert(e5BottomFunctionButtonFeature_43758Value, null, null, base.ci).ToString();
									num = (short)1821573137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									string str;
									string fieldValue;
									if (fieldValue == str)
									{
										num = (short)1912864788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									base.AddFieldValue(ref this.rptFields, e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759_UIValue);
									num = (short)1053360135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횓秊ﾟ톣튥\udca7얩슫羚", a_), base.ci);
									num = (short)2031026182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if (base.isRTL)
									{
										num = (short)888668178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_159;
								case 17:
									if (!base.isRTL)
									{
										num = (short)1836974080;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_464;
								case 18:
								{
									string text;
									base.AddFieldValue(ref this.rptFields, text.ToString());
									num = (short)2107572236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									goto IL_4D2;
								case 20:
								{
									string fieldValue = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쾙튛\udf9d", a_), base.ci);
									base.AddFieldValue(ref this.rptFields, fieldValue);
									num = (short)1564803080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_123;
								IL_159:
								this.rptFields.UIFieldName = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonName_43756.UIName;
								string e5BottomFunctionButtonName_43756_UIValue = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonName_43756_UIValue;
								this.AddUiFieldDescByCondition(ref this.rptFields, e5BottomFunctionButtonName_43756_UIValue, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쪙", a_), base.ci));
								num = (short)490602501;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20E:
								base.rptRec.UIFields.Add(this.rptFields);
								num = (short)796262411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34C:
								num = (short)591069197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_123:
								goto IL_34C;
								IL_464:
								num = (short)1822687235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D2:
								num = (short)1441726480;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_55A:
							goto IL_6C8;
						}
						finally
						{
							for (;;)
							{
								num = (short)2021720065;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_5C9;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_593;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)1410793472;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_593:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1315176450;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_5CB:
								num = (short)668464965;
								short num4 = num;
								num = (short)1314060101;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_601;
								}
								IL_5C9:
								goto IL_5CB;
							}
							IL_601:
							num = (short)1645281280;
							if (num != 0)
							{
							}
						}
						goto IL_618;
						IL_6C8:
						A_0.RecSet.Add(base.rptRec);
						num = (short)664600577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 3:
						goto IL_618;
					}
					IL_5C:
					if (this.d != null)
					{
						num = (short)60424193;
						if (num != 0)
						{
						}
						num = (short)1332019203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_618:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횓秊ﾟ톣튥\udca7얩슫\uddad", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.d.GetEnumerator();
					num = (short)1483931648;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00276494 File Offset: 0x00274694
		private void c(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 19;
			short num = (short)452984832;
			switch (num)
			{
			default:
			{
				num = (short)2009530369;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2019491842;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3DF;
								case 1:
									goto IL_483;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_11B;
									}
									continue;
								case 3:
									this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙\ud99bꮝ", a_), base.ci);
									num = (short)610664448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (string.IsNullOrEmpty(this.rptFields.UIFieldDes))
									{
										num = (short)1262288899;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3DF;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1117650951;
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
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝嶺節ﶱ荒", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝嶺節ﶱ荒", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝ﲧﺩ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝ﲧﺩ", a_), base.ci));
									num = (short)705298436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1465843713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_120:
								num = (short)95289350;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11B:
								goto IL_120;
								IL_3DF:
								base.rptRec.UIFields.Add(this.rptFields);
								A_0.RecSet.Add(base.rptRec);
								num = (short)1048576005;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_483:
							return;
						}
						finally
						{
							for (;;)
							{
								num = (short)1623392257;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_4EF;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_4BA;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)1283784704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4BA:
									if (enumerator == null)
									{
										break;
									}
									num = (short)797310978;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4F1:
								num = (short)2114646505;
								short num3 = num;
								num = (short)1581249001;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_528;
								}
								IL_4EF:
								goto IL_4F1;
							}
							IL_528:
							num = (short)303431680;
							if (num != 0)
							{
							}
						}
						goto IL_53F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 2:
						goto IL_53F;
					}
					IL_5B:
					num = (short)927793153;
					if (num != 0)
					{
					}
					num = (short)557449216;
					short num4 = num;
					if (this.e != null)
					{
						num = (short)232325122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_53F:
					enumerator = this.e.GetEnumerator();
					num = (short)1480130560;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00276A28 File Offset: 0x00274C28
		private void b(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 18;
			short num = (short)320274432;
			switch (num)
			{
			default:
			{
				num = (short)1098448898;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)744357888;
						short num3 = num;
						try
						{
							num = (short)500563968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_C0;
									}
									continue;
								case 1:
									num = (short)958529539;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1248788481;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection e5NavigationControlsTableInnerSection = acpFeatureNode[10897] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection;
									int radErgoControlE5UpDownButton_43752Value = e5NavigationControlsTableInnerSection.RadErgoControlE5UpDownButton_43752Value;
									string text = e5NavigationControlsTableInnerSection.RadErgoControlE5UpDownButton_43752.Converter.Convert(radErgoControlE5UpDownButton_43752Value, null, null, base.ci).ToString();
									this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
									this.rptFields.UIFieldName = e5NavigationControlsTableInnerSection.RadErgoControlE5UpDownButton_43752.UIName.ToString();
									string uiName = e5NavigationControlsTableInnerSection.E5UpDownButtonName_43753_UIValue.ToString();
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc94펖욘캚출\udd9e", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc94펖욘캚출\udd9e", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톔슜\udd9e풠힢톤좦잨", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톔슜\udd9e풠힢톤좦잨", a_), base.ci));
									base.rptRec.UIFields.Add(this.rptFields);
									num = (short)1626013700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_29A;
								}
								IL_243:
								num = (short)124649474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C0:
								goto IL_243;
							}
							IL_29A:
							goto IL_42F;
						}
						finally
						{
							for (;;)
							{
								num = (short)394788865;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_32F;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2D1;
										}
										continue;
									case 2:
										num = (short)1439891457;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)121634816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2D1:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1653407746;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_331:
								num = (short)629867281;
								short num4 = num;
								num = (short)846529297;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_366;
								}
								IL_32F:
								goto IL_331;
							}
							IL_366:
							num = (short)1383727104;
							if (num != 0)
							{
							}
						}
						goto IL_37D;
						IL_42F:
						A_0.RecSet.Add(base.rptRec);
						num = (short)1003814913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 3:
						goto IL_37D;
					}
					IL_5F:
					if (this.b != null)
					{
						num = (short)1604976643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_37D:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc94펖욘햚\udc9c즞ﺰﶲ", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.b.GetEnumerator();
					num = (short)2050883584;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00276EB0 File Offset: 0x002750B0
		private void a(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 12;
			short num = (short)528351232;
			switch (num)
			{
			default:
			{
				num = (short)511922459;
				short num2 = num;
				num = (short)1470583067;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
				string text;
				string text2;
				string radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
				string radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1BE:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
					base.rptRec.RecNo = base.count.ToString();
					acpFeatureNode = this.g[0];
					dataButtonInnerSection = (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection);
					int radErgoCfgKMConventionalKMDatatButtonFeature_A22603Value = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603Value;
					int radErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value;
					text = (string)dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Converter.Convert(radErgoCfgKMConventionalKMDatatButtonFeature_A22603Value, null, null, base.ci);
					text2 = (string)dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Converter.Convert(radErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value, null, null, base.ci);
					radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
					radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
					num = (short)282918912;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
				{
					num = (short)1387069440;
					short num4 = num;
					num = (short)2009137152;
					if (num != 0)
					{
					}
					num = (short)605945859;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒풔풖춘튚튜톞ﲴ", a_), base.ci))
						{
							num = (short)407306246;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 1:
						return;
					case 2:
						goto IL_12D;
					case 3:
						num = (short)1722613761;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_10D;
						}
						continue;
					case 4:
						goto IL_15E;
					case 5:
						text2 = text2 + base.indexSeparator + radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
						num = (short)1094516743;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						text = text + base.indexSeparator + radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						num = (short)1432944644;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_309;
					case 8:
						if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒풔풖춘튚튜톞ﲴ", a_), base.ci))
						{
							num = (short)1482358789;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_309;
					}
					IL_10D:
					if (this.g != null)
					{
						num = (short)743768066;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_15E:
					num = (short)1558708232;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_309:
					this.AddMultiValueByRTL(new bool?(!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic), new bool?(!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic), text2.ToString(), text.ToString(), ref this.rptFields);
					this.rptFields.UIFieldName = (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMDataButtonName_A22601.UIName.ToString();
					this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒톔횖춘\uda9a\udf9c쪞骪", a_), base.ci);
					base.rptRec.UIFields.Add(this.rptFields);
					A_0.RecSet.Add(base.rptRec);
					num = (short)2144927745;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				goto IL_1BE;
			}
			}
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x002772CC File Offset: 0x002754CC
		public override void BuildDataTables(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData XMLRptDataObj)
		{
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						goto IL_152;
					case 1:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num2 = (short)1523384322;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_154;
					case 2:
					{
						num2 = (short)2102001664;
						short num3 = num2;
						this.e(ref this.rptTable);
						this.d(ref this.rptTable);
						this.c(ref this.rptTable);
						this.b(ref this.rptTable);
						this.a(ref this.rptTable);
						this.AddKeypadButton(ref this.rptTable);
						num2 = (short)706150400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				IL_1C:
				this.AddGeneral(ref XMLRptDataObj);
				this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				base.acpr = new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
				this.CreateTableHeader(ref this.rptTable);
				num2 = (short)1937584838;
				short num4 = num2;
				num2 = (short)108147398;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)935264256;
					if (num2 != 0)
					{
					}
					num2 = (short)1414987777;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			IL_152:
			IL_154:
			num2 = (short)123994113;
			if (num2 != 0)
			{
			}
			XMLRptDataObj.tables.Add(this.rptTable);
			base.AddZonesAndChannels(ref XMLRptDataObj);
		}

		// Token: 0x04000E2C RID: 3628
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset a;

		// Token: 0x04000E2D RID: 3629
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset b;

		// Token: 0x04000E2E RID: 3630
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset c;

		// Token: 0x04000E2F RID: 3631
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset d;

		// Token: 0x04000E30 RID: 3632
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset e;

		// Token: 0x04000E31 RID: 3633
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset f;

		// Token: 0x04000E32 RID: 3634
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset g;
	}
}
