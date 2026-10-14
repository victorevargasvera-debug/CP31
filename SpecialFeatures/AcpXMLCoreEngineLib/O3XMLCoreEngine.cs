using System;
using System.Collections.Generic;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x02000237 RID: 567
	public class O3XMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine
	{
		// Token: 0x06001C91 RID: 7313 RVA: 0x002718B0 File Offset: 0x0026FAB0
		public O3XMLCoreEngine()
		{
			this.a = (global::AcpCommonLib.FeatureManager.GetFeature(2127)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3);
			this.d = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
			if (this.d != null)
			{
				this.b = (this.d[0][10235].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset);
				this.c = (this.d[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
				this.e = (this.d[0][10732].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset);
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00271974 File Offset: 0x0026FB74
		private void c(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 7;
			short num = (short)1717501952;
			switch (num)
			{
			default:
			{
				num = (short)1856634881;
				if (num != 0)
				{
				}
				num = (short)728629248;
				short num2 = num;
				num = (short)608043010;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num3)
					{
					case 0:
						try
						{
							num = (short)693960708;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_4B0;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)249036803;
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
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection = acpFeatureNode[10210] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection;
									int cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Value = o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Value;
									int cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Value = o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Value;
									string text = (string)o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Converter.Convert(cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Value, null, null, base.ci);
									string text2 = (string)o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Converter.Convert(cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Value, null, null, base.ci);
									this.AddMultiValueByRTL(new bool?(!o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic), new bool?(!o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenStatic), text2.ToString(), text.ToString(), ref this.rptFields);
									this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner)acpFeatureNode).O3HHCHButtonInnerSection.CntrlHeadO3HHCHButtonName_A22523.UIName.ToString();
									string uiName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner)acpFeatureNode).O3HHCHButtonInnerSection.CntrlHeadO3HHCHButtonName_A22523_UIValue.ToString();
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쒏\udd91쒓쒕톗\udd99풛쪝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쒏\udd91쒓쒕톗\udd99풛쪝", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쒏\udd91쒓\udb95톗\ude99\ud89b튝ﲧ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쒏\udd91쒓\udb95톗\ude99\ud89b튝ﲧ", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쎏\udb91킓펕첗햙첛\udc9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쎏\udb91킓펕첗햙첛\udc9d", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쎏\udb91킓펕햗펙\ud89b\uda9dﲧﺩ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쎏\udb91킓펕햗펙\ud89b\uda9dﲧﺩ", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쎏\udb91킓펕\uda97햙좛쪝ﲧﺩ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍쎏\udb91킓펕\uda97햙좛쪝ﲧﺩ", a_), base.ci));
									this.AddUiFieldDescByCondition(ref this.rptFields, uiName, null, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎉좋톍\udf8fꆑ횓쎕첗캙펛킝", a_), base.ci));
									base.rptRec.UIFields.Add(this.rptFields);
									A_0.RecSet.Add(base.rptRec);
									num = (short)1592524801;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1077084160;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_10C;
									}
									continue;
								}
								IL_111:
								num = (short)757792770;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_10C:
								goto IL_111;
							}
							IL_4B0:
							return;
						}
						finally
						{
							num = (short)711524354;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_51E;
								case 1:
									enumerator.Dispose();
									num = (short)2022572032;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4E7;
									}
									continue;
								}
								goto IL_4E7;
								IL_4EA:
								num = (short)598081537;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_51E:
								num = (short)1558320887;
								short num4 = num;
								num = (short)797644535;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_4EA;
								default:
									goto IL_555;
								}
								IL_4E7:
								if (enumerator != null)
								{
									goto IL_4EA;
								}
								goto IL_51E;
							}
							IL_555:
							num = (short)488898560;
							if (num != 0)
							{
							}
						}
						goto IL_56C;
					case 1:
						goto IL_56C;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					}
					IL_AD:
					if (this.b != null)
					{
						num = (short)2083651585;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_56C:
					enumerator = this.b.GetEnumerator();
					num = (short)135725056;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00271F34 File Offset: 0x00270134
		private void b(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 10;
			short num = (short)1840250880;
			switch (num)
			{
			default:
			{
				num = (short)1137704961;
				if (num != 0)
				{
				}
				num = (short)23068675;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_3A7;
					case 1:
						try
						{
							num = (short)1440481284;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1686044674;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									for (;;)
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
										global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection o3NavigationControlsTableInnerSection = acpFeatureNode[10733] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection;
										int radErgoControlO3NaviControlFeature_A41375Value = o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375Value;
										string text = (string)o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375.Converter.Convert(radErgoControlO3NaviControlFeature_A41375Value, null, null, base.ci);
										this.AddMultiValueByRTL(new bool?(!base.refTrunking.Parent.HiddenStatic), null, text.ToString(), text.ToString(), ref this.rptFields);
										this.rptFields.UIFieldName = o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlName_A41374.UIName.ToString();
										string uiName = o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlName_A41374_UIValue.ToString();
										this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐욒얔햖처쾚즜킞", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐욒얔햖처쾚즜킞", a_), base.ci));
										this.AddUiFieldDescByCondition(ref this.rptFields, uiName, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌ﶒ쪔햖쾠", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌ﶒ쪔햖쾠", a_), base.ci));
										base.rptRec.UIFields.Add(this.rptFields);
										num = (short)352143428;
										short num3 = num;
										num = (short)1063405636;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_2AD;
										}
									}
									IL_2AD:
									num = (short)363003904;
									if (num != 0)
									{
									}
									num = (short)196149248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)374931459;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_335;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_10F;
									}
									continue;
								}
								IL_2DE:
								num = (short)867893249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10F:
								goto IL_2DE;
							}
							IL_335:
							goto IL_42D;
						}
						finally
						{
							num = (short)430309378;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)306380801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3A4;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_36E;
									}
									continue;
								}
								IL_36E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1582497792;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A4:;
						}
						goto IL_3A7;
						IL_42D:
						A_0.RecSet.Add(base.rptRec);
						num = (short)379977730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					}
					IL_84:
					if (this.e != null)
					{
						num = (short)610533376;
						short num4 = num;
						num = (short)423559168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_3A7:
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int count = base.count;
					base.count = count + 1;
					base.rptRec.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐\udd92풔솖킘\udc9a\udc9c쮞怜ﶮﺰﾲ", a_), base.ci);
					base.rptRec.RecNo = base.count.ToString();
					enumerator = this.e.GetEnumerator();
					num = (short)1538981889;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x002723B8 File Offset: 0x002705B8
		private void a(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table A_0)
		{
			int a_ = 15;
			short num = (short)1014300672;
			switch (num)
			{
			default:
			{
				num = (short)2140667909;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					string text2;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
					switch (num2)
					{
					case 0:
					{
						num = (short)1429995520;
						short num3 = num;
						string cho3DataButtonConvIndex_A41419_UIValue;
						text = text + base.indexSeparator + cho3DataButtonConvIndex_A41419_UIValue;
						num = (short)520945671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string cho3DataButtonTrkIndex_A41420_UIValue;
						text2 = text2 + base.indexSeparator + cho3DataButtonTrkIndex_A41420_UIValue;
						num = (short)955404707;
						short num4 = num;
						num = (short)188895651;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_40D;
						default:
							num = (short)1118240768;
							if (num != 0)
							{
							}
							num = (short)865468422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						return;
					case 3:
						if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕\ud997\ud999좛힝囹羚", a_), base.ci))
						{
							num = (short)565379072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10F;
					case 4:
						if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕\ud997\ud999좛힝囹羚", a_), base.ci))
						{
							num = (short)1409482753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EE;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 6:
						goto IL_2EE;
					case 7:
						goto IL_40D;
					case 8:
					{
						base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						int count = base.count;
						base.count = count + 1;
						base.rptRec.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + base.count.ToString();
						base.rptRec.RecNo = base.count.ToString();
						acpFeatureNode = this.c[0];
						dataButtonInnerSection = (acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection);
						int value = dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value;
						int value2 = dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value;
						text = (string)dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Converter.Convert(value, null, null, base.ci);
						text2 = (string)dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Converter.Convert(value2, null, null, base.ci);
						string cho3DataButtonConvIndex_A41419_UIValue = dataButtonInnerSection.CHO3DataButtonConvIndex_A41419_UIValue;
						string cho3DataButtonTrkIndex_A41420_UIValue = dataButtonInnerSection.CHO3DataButtonTrkIndex_A41420_UIValue;
						num = (short)1824260099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_70:
					if (this.c != null)
					{
						num = (short)864419848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_10F:
					num = (short)825688068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40D:
					goto IL_10F;
					IL_2EE:
					this.AddMultiValueByRTL(new bool?(!dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic), new bool?(!dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenStatic), text2, text, ref this.rptFields);
					this.rptFields.UIFieldName = (acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3DataButtonName_A22591.UIName.ToString();
					this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕\udc97\udb99좛\udf9d龭", a_), base.ci);
					base.rptRec.UIFields.Add(this.rptFields);
					A_0.RecSet.Add(base.rptRec);
					num = (short)601554945;
					if (num != 0)
					{
					}
					num = (short)300023810;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x002727D8 File Offset: 0x002709D8
		public override void BuildDataTables(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData XMLRptDataObj)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					this.c(ref this.rptTable);
					this.b(ref this.rptTable);
					this.a(ref this.rptTable);
					this.AddKeypadButton(ref this.rptTable);
					num2 = (short)1710817281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_138;
				case 2:
					goto IL_D1;
				}
				goto IL_1C;
			}
			IL_138:
			goto IL_13A;
			IL_1C:
			this.AddGeneral(ref XMLRptDataObj);
			this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
			base.acpr = new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
			this.CreateTableHeader(ref this.rptTable);
			num2 = (short)622944456;
			short num3 = num2;
			num2 = (short)710107336;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D1:
				if (global::ConstraintHelper.UtilityMack.IsMobile())
				{
					num2 = (short)1330184192;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)640352256;
				if (num2 != 0)
				{
				}
				num2 = (short)1821507584;
				short num4 = num2;
				num2 = (short)717029378;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_13A:
			num2 = (short)1489960961;
			if (num2 != 0)
			{
			}
			XMLRptDataObj.tables.Add(this.rptTable);
			base.AddZonesAndChannels(ref XMLRptDataObj);
		}

		// Token: 0x04000E17 RID: 3607
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3 a;

		// Token: 0x04000E18 RID: 3608
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset b;

		// Token: 0x04000E19 RID: 3609
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset c;

		// Token: 0x04000E1A RID: 3610
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset d;

		// Token: 0x04000E1B RID: 3611
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset e;
	}
}
