using System;
using System.Collections.Generic;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x02000239 RID: 569
	public class O7XMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine
	{
		// Token: 0x06001C9C RID: 7324 RVA: 0x00273E30 File Offset: 0x00272030
		public O7XMLCoreEngine()
		{
			this.a = (global::AcpCommonLib.FeatureManager.GetFeature(4114)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7);
			this.b = (global::AcpCommonLib.FeatureManager.GetFeature(2128)[0] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories);
			this.f = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
			if (this.f != null)
			{
				this.c = (this.f[0][10719].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset);
				this.g = (this.f[0][10727].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset);
				this.e = (this.f[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
			}
			this.h = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
			if (this.h != null)
			{
				this.d = (this.h[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset);
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00273F5C File Offset: 0x0027215C
		private void e(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 13;
			short num = (short)1396572160;
			switch (num)
			{
			default:
			{
				num = (short)1211105280;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						IL_3B:
						num = (short)407961600;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					}
					case 1:
						try
						{
							num = (short)1215627264;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_E3;
									}
									continue;
								case 1:
									goto IL_2AE;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1501036548;
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
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection o7InnerSection = acpFeatureNode[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection;
									int cho7EmergencyButtonFeature_A41291Value = o7InnerSection.CHO7EmergencyButtonFeature_A41291Value;
									string text = (string)o7InnerSection.CHO7EmergencyButtonFeature_A41291.Converter.Convert(cho7EmergencyButtonFeature_A41291Value, null, null, base.ci);
									this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
									this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7Inner)acpFeatureNode).O7InnerSection.CHO7EmergencyButtonName_A41289Value.ToString();
									this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓\ud995쪗\udb99튛\ud99dﲧ", a_), base.ci);
									base.rptRec.UIFields.Add(this.rptFields);
									A_0.RecSet.Add(base.rptRec);
									num = (short)2045050883;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)745537537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E8:
								num = (short)350355458;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E3:
								goto IL_E8;
							}
							IL_2AE:
							return;
						}
						finally
						{
							num = (short)1626079232;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2E5;
									}
									continue;
								case 1:
									goto IL_31A;
								case 2:
									enumerator.Dispose();
									num = (short)1826488321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2E5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1571160066;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_31A:;
						}
						goto IL_31D;
					case 2:
						goto IL_31D;
					}
					IL_82:
					if (this.c != null)
					{
						num = (short)1087504386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_31D:
					num = (short)1718988374;
					short num4 = num;
					num = (short)1173204566;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
					{
						num = (short)693764097;
						if (num != 0)
						{
						}
						num = (short)1490354176;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.c.GetEnumerator();
						num = (short)1717174273;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
			}
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0027433C File Offset: 0x0027253C
		private void d(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 14;
			short num = (short)1517682688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7 controlHeadO;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection o7MFKAssignmentControlInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection o7MFKAssignmentControlInnerSection2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (!controlHeadO.O7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.HiddenStatic)
						{
							num = (short)1906114568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DF;
					case 1:
						num = (short)480837633;
						if (num != 0)
						{
						}
						num = (short)1181286400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2D1;
					case 3:
					{
						num = (short)918209575;
						short num3 = num;
						num = (short)2409511;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C5;
						default:
							num = (short)814415872;
							if (num != 0)
							{
							}
							if (o7MFKAssignmentControlInnerRecset != null)
							{
								num = (short)682688518;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C5;
						}
						break;
					}
					case 4:
						if (controlHeadO != null)
						{
							num = (short)806682625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DF;
					case 5:
						goto IL_1DF;
					case 6:
						o7MFKAssignmentControlInnerSection = (o7MFKAssignmentControlInnerRecset[0][10724] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection);
						o7MFKAssignmentControlInnerSection2 = (o7MFKAssignmentControlInnerRecset[1][10724] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection);
						num = (short)1378025474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (controlHeadO != null)
						{
							num = (short)1354170368;
							short num4 = num;
							num = (short)315031561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C5;
					case 8:
					{
						this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						int value = controlHeadO.O7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.Value;
						string text = (string)controlHeadO.O7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.Converter.Convert(value, null, null, base.ci);
						this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text, text, ref this.rptFields);
						this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc90햒\ude94잖ﺚ욢춤욦\udfa8슪슬\uddae", a_);
						this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔\uda96\udf98킚출춞瑩ﲲ", a_), base.ci);
						base.rptRec.UIFields.Add(this.rptFields);
						num = (short)1049886725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						o7MFKAssignmentControlInnerRecset = (controlHeadO[10718].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset);
						num = (short)1491009539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_60;
					IL_1DF:
					num = (short)1729626119;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2D1:
				IL_3C5:
				this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int value2 = o7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.Value;
				string text2 = (string)o7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.Converter.Convert(value2, null, null, base.ci);
				this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text2, text2, ref this.rptFields);
				this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("손ﲔ殺\ud99e풠춢욤펦삨쒪쎬", a_);
				this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("손ﲔ殺삞횢쮤쒦\udda8슪슬솮", a_), base.ci);
				base.rptRec.UIFields.Add(this.rptFields);
				this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int value3 = o7MFKAssignmentControlInnerSection2.RadErgoControlO7MFKFeatureAssignment_A41295.Value;
				string text3 = (string)o7MFKAssignmentControlInnerSection2.RadErgoControlO7MFKFeatureAssignment_A41295.Converter.Convert(value3, null, null, base.ci);
				this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text3, text3, ref this.rptFields);
				this.rptFields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐ﾚﲜ\ud8a0키즦쪨\udfaa쒬삮\udfb0", a_);
				this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐ﾚﲜ\ud8a0ﲢ튦잨좪\ud9ac욮\udeb0\uddb2", a_), base.ci);
				base.rptRec.UIFields.Add(this.rptFields);
				A_0.RecSet.Add(base.rptRec);
				return;
				IL_60:
				base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				int count = base.count;
				base.count = count + 1;
				base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔\uda96처힚즜횞ﶨ練ﶲ華", a_), base.ci);
				base.rptRec.RecNo = base.count.ToString();
				o7MFKAssignmentControlInnerRecset = null;
				o7MFKAssignmentControlInnerSection = null;
				o7MFKAssignmentControlInnerSection2 = null;
				controlHeadO = null;
				controlHeadO = (global::AcpCommonLib.FeatureManager.GetFeature(4114)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7);
				num = (short)105644036;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x002748B0 File Offset: 0x00272AB0
		private void c(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 3;
			short num = (short)1368457216;
			switch (num)
			{
			default:
			{
				num = (short)1765539841;
				if (num != 0)
				{
				}
				num = (short)652214272;
				short num2 = num;
				num = (short)255131648;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						IL_8B:
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 1:
						try
						{
							num = (short)1536622594;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_47B;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1479737348;
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
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection = acpFeatureNode[10239] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection;
									int radErgoCfgKMConventionalKMButtonFeature_A19646Value = kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646Value;
									int radErgoCfgKMTrunkingKMButtonFeature_A19746Value = kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746Value;
									string text = (string)kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Converter.Convert(radErgoCfgKMConventionalKMButtonFeature_A19646Value, null, null, base.ci);
									string text2 = (string)kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Converter.Convert(radErgoCfgKMTrunkingKMButtonFeature_A19746Value, null, null, base.ci);
									this.AddMultiValueByRTL(new bool?(!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic), new bool?(!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic), text2.ToString(), text.ToString(), ref this.rptFields);
									this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561.UIName.ToString();
									string uiName = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561_UIValue.ToString();
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍풏힑삓\ud995좗\ud899즛쪝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍풏힑삓\ud995좗\ud899즛쪝", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍풏힑\ud993\udf95\udc97\ude99킛\udb9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍풏힑\ud993\udf95\udc97\ude99킛\udb9d", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍풏힑횓\ud995첗캙펛펝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행\udf8b잍풏힑횓\ud995첗캙펛펝", a_), base.ci));
									num = (short)1357905925;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_113;
									}
									continue;
								case 4:
									num = (short)1446707200;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (string.IsNullOrEmpty(this.rptFields.UIFieldDes))
									{
										num = (short)833683463;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D5;
								case 6:
									goto IL_3D5;
								case 7:
									this.rptFields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾅첇행쎋뮍튏작삓슕힗풙", a_), base.ci);
									num = (short)758644742;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_118:
								num = (short)4194305;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_113:
								goto IL_118;
								IL_3D5:
								base.rptRec.UIFields.Add(this.rptFields);
								A_0.RecSet.Add(base.rptRec);
								num = (short)524291;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_47B:
							return;
						}
						finally
						{
							num = (short)841285632;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4B3;
									}
									continue;
								case 1:
									goto IL_4E8;
								case 2:
									enumerator.Dispose();
									num = (short)1110245377;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4B3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)606076930;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_4E8:;
						}
						goto IL_4EB;
					case 2:
						goto IL_4EB;
					}
					IL_A8:
					if (this.d != null)
					{
						num = (short)1452474370;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_4EB:
					num = (short)741771540;
					short num4 = num;
					num = (short)728402196;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8B;
					default:
					{
						num = (short)603783168;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.d.GetEnumerator();
						num = (short)107675649;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
			}
			}
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00274E3C File Offset: 0x0027303C
		private void b(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 17;
			for (;;)
			{
				IL_09:
				short num = (short)1113587712;
				switch (num)
				{
				default:
				{
					num = (short)566034432;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
						{
							num = (short)591724545;
							if (num != 0)
							{
							}
							num = (short)900894196;
							short num3 = num;
							num = (short)2038402548;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)325124096;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_D3;
								}
								continue;
							}
							break;
						}
						case 1:
						{
							num = (short)1803812864;
							short num4 = num;
							goto IL_3AB;
						}
						case 2:
							return;
						case 3:
							try
							{
								num = (short)443285504;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_15D;
										}
										continue;
									case 1:
										goto IL_338;
									case 3:
										num = (short)1315438593;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1277100035;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
										global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection o7NavigationControlsTableInnerSection = acpFeatureNode[10728] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection;
										int radErgoControlO7UpDownButton_A41293Value = o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293Value;
										string text = (string)o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293.Converter.Convert(radErgoControlO7UpDownButton_A41293Value, null, null, base.ci);
										this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
										this.rptFields.UIFieldName = o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293.UIName.ToString();
										string uiName = o7NavigationControlsTableInnerSection.O7UpDownButtonName_A41292_UIValue.ToString();
										this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쾙첛\udc9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗쾙첛\udc9d", a_), base.ci));
										this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킓秊쎛\udc9d햟횡킣즥욧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킓秊쎛\udc9d햟횡킣즥욧", a_), base.ci));
										base.rptRec.UIFields.Add(this.rptFields);
										num = (short)1475411970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_2E0:
									num = (short)293076996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_15D:
									goto IL_2E0;
								}
								IL_338:
								goto IL_431;
							}
							finally
							{
								num = (short)1650917376;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_370;
										}
										continue;
									case 1:
										goto IL_3A8;
									case 2:
										enumerator.Dispose();
										num = (short)521142273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_370:
									if (enumerator == null)
									{
										break;
									}
									num = (short)495845378;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3A8:;
							}
							goto IL_3AB;
							IL_431:
							A_0.RecSet.Add(base.rptRec);
							num = (short)367460354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D3:
						if (this.g != null)
						{
							num = (short)864419841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
						IL_3AB:
						base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						int count = base.count;
						base.count = count + 1;
						base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd93튕잗풙\udd9b좝ﾯﲱ", a_), base.ci);
						base.rptRec.RecNo = base.count.ToString();
						enumerator = this.g.GetEnumerator();
						num = (short)1278083075;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x002752C4 File Offset: 0x002734C4
		private void a(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 18;
			short num = (short)1284308992;
			switch (num)
			{
			default:
			{
				num = (short)981073923;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
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
						o7DataButtonInnerSection = (acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection);
						int value = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value;
						int value2 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value;
						text = (string)o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Converter.Convert(value, null, null, base.ci);
						text2 = (string)o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Converter.Convert(value2, null, null, base.ci);
						string cho7DataButtonConvIndex_A41417_UIValue = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417_UIValue;
						string cho7DataButtonTrkIndex_A41418_UIValue = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418_UIValue;
						num = (short)1333854209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc94펖욘\uda9a\ude9c쮞ﺬﶰ者", a_), base.ci))
						{
							num = (short)279904261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					case 2:
						num = (short)1168900097;
						if (num != 0)
						{
						}
						goto IL_2EB;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 4:
						goto IL_135;
					case 5:
					{
						string cho7DataButtonConvIndex_A41417_UIValue;
						text = text + base.indexSeparator + cho7DataButtonConvIndex_A41417_UIValue;
						goto IL_3C8;
					}
					case 6:
						if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc94펖욘\uda9a\ude9c쮞ﺬﶰ者", a_), base.ci))
						{
							num = (short)2046033928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EB;
					case 7:
						goto IL_3B5;
					case 8:
					{
						string cho7DataButtonTrkIndex_A41418_UIValue;
						text2 = text2 + base.indexSeparator + cho7DataButtonTrkIndex_A41418_UIValue;
						num = (short)418728594;
						short num3 = num;
						num = (short)139152018;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C8;
						default:
							num = (short)873922560;
							if (num != 0)
							{
							}
							num = (short)242417666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_70:
					if (this.e != null)
					{
						num = (short)98500608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_135:
					num = (short)557842438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EB:
					this.AddMultiValueByRTL(new bool?(!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic), new bool?(!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenStatic), text2, text, ref this.rptFields);
					this.rptFields.UIFieldName = (acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonName_A41296.UIName.ToString();
					this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc94펖욘\udf9a\udc9c쮞ﶨ肰", a_), base.ci);
					base.rptRec.UIFields.Add(this.rptFields);
					A_0.RecSet.Add(base.rptRec);
					num = (short)25886727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C8:
					num = (short)571539460;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B5:
				num = (short)275251200;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x002756E0 File Offset: 0x002738E0
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
						num2 = (short)499908610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17B;
				case 1:
					goto IL_179;
				case 2:
				{
					num2 = (short)193303008;
					short num3 = num2;
					num2 = (short)257004000;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1632305153;
						if (num2 != 0)
						{
						}
						num2 = (short)1565917184;
						if (num2 != 0)
						{
						}
						this.e(ref this.rptTable);
						this.d(ref this.rptTable);
						this.c(ref this.rptTable);
						this.b(ref this.rptTable);
						this.a(ref this.rptTable);
						this.AddKeypadButton(ref this.rptTable);
						num2 = (short)143720449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_179:
			IL_17B:
			XMLRptDataObj.tables.Add(this.rptTable);
			base.AddZonesAndChannels(ref XMLRptDataObj);
			return;
			IL_1C:
			num2 = (short)2123759616;
			short num4 = num2;
			this.AddGeneral(ref XMLRptDataObj);
			this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
			base.acpr = new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
			this.CreateTableHeader(ref this.rptTable);
			num2 = (short)1907490816;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000E24 RID: 3620
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7 a;

		// Token: 0x04000E25 RID: 3621
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories b;

		// Token: 0x04000E26 RID: 3622
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset c;

		// Token: 0x04000E27 RID: 3623
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset d;

		// Token: 0x04000E28 RID: 3624
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset e;

		// Token: 0x04000E29 RID: 3625
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset f;

		// Token: 0x04000E2A RID: 3626
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset g;

		// Token: 0x04000E2B RID: 3627
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset h;
	}
}
