using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUI.Common;
using AcpUILib;
using AcpUtility;

namespace AcpUI.Comparator
{
	// Token: 0x02000074 RID: 116
	public static class ComparatorManager
	{
		// Token: 0x060005C9 RID: 1481 RVA: 0x00074C20 File Offset: 0x00072E20
		public static void CompareDocuments(global::AcpCommonLib.Document activeDoc, global::AcpCommonLib.Document compDoc)
		{
			int a_ = 8;
			short num = (short)1343619072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1191837696;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_81;
				}
				for (;;)
				{
					IL_5A:
					switch (num2)
					{
					case 0:
						if (compDoc != null)
						{
							num = (short)98631684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50F;
					case 1:
						goto IL_45E;
					case 2:
						try
						{
							num = (short)663814157;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)2020868110;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									if (!acpRecordset.HiddenStatic)
									{
										num = (short)308019203;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1874984971;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1371537418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									string message = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Comparison.AcpStringFormat(new object[]
									{
										acpRecordset.Path(global::AcpUI.Common.Utility.c("슝", a_))
									});
									global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message, false);
									num = (short)2113011727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)851970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									global::AcpCommonLib.IAcpRecordset feature;
									global::AcpUI.Comparator.ComparatorManager.a(acpRecordset, feature, false);
									num = (short)1100808192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1134297092;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
									global::AcpCommonLib.IAcpRecordset feature = compDoc.GetFeature(acpRecordset.RecsetId);
									num = (short)2000945161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									if (!acpRecordset.HiddenStatic)
									{
										num = (short)537001985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_34B;
								}
								case 10:
									goto IL_39F;
								case 11:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									if (acpRecordset.HasVisibleObjects)
									{
										num = (short)959840261;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									if (feature == null)
									{
										num = (short)493879302;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									switch (0)
									{
									case 0:
										goto IL_187;
									}
									continue;
								case 14:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									if (feature != null)
									{
										num = (short)124649479;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_34B;
								}
								}
								IL_189:
								num = (short)1694040072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_187:
								goto IL_189;
								IL_34B:
								num = (short)1961820172;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39F:
							goto IL_BF;
						}
						finally
						{
							num = (short)1089273857;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)797050005;
								short num4 = num;
								num = (short)1428161685;
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)894107648;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_45B;
									case 1:
										goto IL_3BB;
									case 2:
										enumerator.Dispose();
										num = (short)1038680064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_422;
								}
								IL_3BB:
								switch (0)
								{
								case 0:
									IL_422:
									if (enumerator == null)
									{
										goto IL_45D;
									}
									num = (short)1326579714;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_45B:
							IL_45D:;
						}
						goto IL_45E;
						IL_BF:
						global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, global::AcpCommonResources.AcpResources.Comparison_Completed, false);
						global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.FieldsReportChanged = true;
						num = (short)2123628550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_4DE;
					case 4:
					{
						num = (short)2077884417;
						if (num != 0)
						{
						}
						global::AcpCommonLib.UndoRedo.UndoManager.Reset();
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = activeDoc.Features.GetEnumerator();
						num = (short)685178882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (activeDoc != null)
						{
							num = (short)552861697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50F;
					case 6:
						if (global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.HasFields)
						{
							num = (short)1899757575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50F;
					case 7:
						global::AcpUI.Common.Utility.FieldsReportChanged(null, global::AcpCommonLib.FieldReportType.Comparator);
						num = (short)1769603075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_81;
					IL_45E:
					num = (short)1180303360;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4DE:
				IL_50F:
				global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
				return;
				IL_81:
				global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
				num = (short)514195461;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00075160 File Offset: 0x00073360
		private static void a(global::AcpCommonLib.IAcpRecordset A_0, global::AcpCommonLib.IAcpRecordset A_1, bool A_2)
		{
			int a_ = 9;
			short num = (short)1308688384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				int num3;
				bool flag;
				for (;;)
				{
					IL_30:
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
					switch (num2)
					{
					case 0:
						if (num3 < A_1.Count)
						{
							num = (short)1601830935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)337575962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1866399746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_1.Count > 0)
						{
							num = (short)139264014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE1;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode == null)
						{
							num = (short)663617556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F49;
					}
					case 4:
						num = (short)838860801;
						if (num != 0)
						{
						}
						goto IL_BE1;
					case 5:
						goto IL_F49;
					case 6:
						global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.FieldsReportChanged = true;
						num = (short)687210518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_F49;
					case 8:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode != null)
						{
							num = (short)465698840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1C;
					}
					case 9:
					{
						if (num3 >= A_0.Count)
						{
							num = (short)1290272786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0.CalculateVisibility(true);
						acpFeatureNode2 = A_0[num3];
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
						num = (short)349044757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_F49;
					case 11:
						goto IL_D6D;
					case 12:
						goto IL_B8D;
					case 13:
						try
						{
							num = (short)775684121;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
								switch (num2)
								{
								case 0:
									num = (short)502792215;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1422917649;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureSection = enumerator.Current;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2 = acpFeatureNode[acpFeatureSection.FeatureSectionId];
									num = (short)700121115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									if (acpFeatureSection.HasVisibleObjects)
									{
										num = (short)156893198;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
								{
									string message = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Comparison.AcpStringFormat(new object[]
									{
										acpFeatureSection.Path(global::AcpUI.Common.Utility.c("쎞", a_))
									});
									global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message, false);
									num = (short)481230866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_B1A;
								case 6:
									num = (short)1096155155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_A84;
								case 8:
									num = (short)1299054614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)736755714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_17B;
								case 11:
								{
									global::AcpCommonLib.IAcpRecordset embeddedRecset = acpFeatureSection.EmbeddedRecset;
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
									global::AcpCommonLib.IAcpRecordset embeddedRecset2 = acpFeatureSection2.EmbeddedRecset;
									num = (short)209911824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									string message2 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Comparison.AcpStringFormat(new object[]
									{
										acpFeatureSection.Path(global::AcpUI.Common.Utility.c("쎞", a_))
									});
									global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message2, false);
									num = (short)2029584388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									num = (short)1103626266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									num = (short)360621587;
									short num4 = num;
									num = (short)509519379;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_17B;
									default:
										num = (short)186580992;
										if (num != 0)
										{
										}
										goto IL_A84;
									}
									break;
								}
								case 16:
								{
									global::AcpCommonLib.IAcpRecordset embeddedRecset;
									if (embeddedRecset != null)
									{
										num = (short)1676673030;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A84;
								}
								case 17:
									num = (short)325320709;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_A84;
								case 19:
								{
									global::AcpCommonLib.IAcpRecordset embeddedRecset2;
									if (embeddedRecset2 != null)
									{
										num = (short)1544486920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A84;
								}
								case 20:
									if (acpFeatureSection.HasEmbeddedRecset)
									{
										num = (short)601358347;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A84;
								case 21:
								{
									global::AcpCommonLib.IAcpRecordset embeddedRecset;
									global::AcpCommonLib.IAcpRecordset embeddedRecset2;
									global::AcpUI.Comparator.ComparatorManager.a(embeddedRecset, embeddedRecset2, A_2);
									num = (short)1414070287;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
								{
									global::AcpCommonLib.IAcpRecordset embeddedRecset;
									if (!embeddedRecset.HiddenStatic)
									{
										num = (short)1616510976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A84;
								}
								case 23:
								{
									global::AcpCommonLib.IAcpRecordset embeddedRecset;
									global::AcpCommonLib.IAcpRecordset embeddedRecset2;
									if (embeddedRecset.RecsetId == embeddedRecset2.RecsetId)
									{
										num = (short)1568931861;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)508821514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
									try
									{
										num = (short)1714487316;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::AcpCommonLib.IAcpField acpField;
											switch (num2)
											{
											case 0:
											{
												string message3 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Comparison.AcpStringFormat(new object[]
												{
													acpField.Path(global::AcpUI.Common.Utility.c("쎞", a_))
												});
												global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message3, false);
												num = (short)1576665093;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												acpField._HasDiffs = true;
												num = (short)1064894485;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												global::AcpCommonLib.IAcpField acpField2;
												if (acpField.CompareTo(acpField2) == 0)
												{
													num = (short)2012348429;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												string text = global::AcpCommonLib.Utility.FormatFieldValue(acpField2);
												num = (short)1916076044;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
												global::AcpCommonLib.IAcpField acpField2 = acpFeatureSection2[acpField.UIName];
												num = (short)1455292440;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)327614489;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												goto IL_479;
											case 9:
												if (global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.ContainsField(acpField))
												{
													num = (short)639369242;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_685;
											case 10:
												goto IL_30A;
											case 11:
											{
												string text = global::AcpCommonLib.Utility.displayReverseForSpecialLanguageAndField(acpField, text);
												global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(acpField, text, false);
												num = (short)1820327946;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 12:
												if (!global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.ContainsField(acpField))
												{
													num = (short)1288372235;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_30A;
											case 13:
												num = (short)1644888073;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 14:
												if (((global::AcpBusinessLayer.AcpFieldBase)acpField).AllowsCompare())
												{
													num = (short)865337348;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 15:
												goto IL_685;
											case 16:
												num = (short)1770192918;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 17:
												num = (short)2134048771;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 18:
												if (!enumerator2.MoveNext())
												{
													num = (short)643694608;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												acpField = enumerator2.Current;
												num = (short)1639251982;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 19:
												if (!acpField._HasDiffs)
												{
													num = (short)1652228098;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_479;
											case 20:
												switch (0)
												{
												case 0:
													goto IL_2CA;
												}
												continue;
											case 21:
												goto IL_479;
											case 22:
												goto IL_6C2;
											case 23:
												if (!A_2)
												{
													num = (short)434438161;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 24:
											{
												global::AcpCommonLib.IAcpField acpField2;
												if (acpField2 == null)
												{
													num = (short)538443782;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)905576471;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 25:
											{
												if (!A_2)
												{
													num = (short)241041408;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												string message4 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Active.AcpStringFormat(new object[]
												{
													acpField.Path(global::AcpUI.Common.Utility.c("쎞", a_))
												});
												global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message4, false);
												num = (short)241238017;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 26:
												global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.UnregisterFieldInReport(acpField);
												num = (short)690552847;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2CA;
											IL_30A:
											num = (short)1577844755;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_479:
											flag = true;
											num = (short)2012217351;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4F0:
											num = (short)2077163538;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2CA:
											goto IL_4F0;
											IL_685:
											acpField._HasDiffs = false;
											num = (short)167903240;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_6C2:
										break;
									}
									finally
									{
										num = (short)326434817;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)2085093378;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_6FB;
												}
												continue;
											case 2:
												goto IL_735;
											}
											IL_6FB:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1450967040;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_735:;
									}
									goto IL_738;
								case 25:
									switch (0)
									{
									case 0:
										goto IL_15E;
									}
									continue;
								case 26:
									if (!A_2)
									{
										num = (short)1760100364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_738;
								case 27:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
									if (acpFeatureSection2 == null)
									{
										num = (short)1794637833;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1522335764;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_15E;
								IL_17B:
								if (!A_2)
								{
									num = (short)1599995907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string message5 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Active.AcpStringFormat(new object[]
								{
									acpFeatureSection.Path(global::AcpUI.Common.Utility.c("쎞", a_))
								});
								global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message5, false);
								num = (short)2000027655;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_738:
								string message6 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Active.AcpStringFormat(new object[]
								{
									acpFeatureSection.Path(global::AcpUI.Common.Utility.c("쎞", a_))
								});
								global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message6, false);
								num = (short)2132148237;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9C0:
								num = (short)843448321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15E:
								goto IL_9C0;
								IL_A84:
								enumerator2 = acpFeatureSection.FieldsCollection.GetEnumerator();
								num = (short)1513488408;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B1A:
							goto IL_C1C;
						}
						finally
						{
							num = (short)373751809;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)990969858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_B51;
									}
									continue;
								case 2:
									goto IL_B8A;
								}
								IL_B51:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1062207488;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B8A:;
						}
						goto IL_B8D;
					case 14:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = A_1.NodeFromKey(acpFeatureNode2.ReferenceKey);
						num = (short)537264132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						if (!A_2)
						{
							num = (short)796786715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string message7 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Active.AcpStringFormat(new object[]
						{
							acpFeatureNode2.Path(global::AcpUI.Common.Utility.c("쎞", a_))
						});
						global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message7, false);
						num = (short)659423239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (flag)
						{
							num = (short)1255997446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						goto IL_F49;
					case 18:
						num = (short)1835794448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_F49;
					case 20:
						num = (short)1896939535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (A_0.HasKeyField)
						{
							num = (short)232718337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)118489088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						return;
					case 23:
					{
						num = (short)2090795008;
						short num5 = num;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = A_1[num3];
						num = (short)1095434259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = acpFeatureNode2.FeatureSectionsCollection.GetEnumerator();
						num = (short)2115895309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_D6D;
					case 26:
					{
						if (!A_2)
						{
							num = (short)1120665612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string message8 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Active.AcpStringFormat(new object[]
						{
							acpFeatureNode2.Path(global::AcpUI.Common.Utility.c("쎞", a_))
						});
						global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message8, false);
						num = (short)237764613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						string message9 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Comparison.AcpStringFormat(new object[]
						{
							acpFeatureNode2.Path(global::AcpUI.Common.Utility.c("쎞", a_))
						});
						global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message9, false);
						num = (short)1635450897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A7;
					IL_B8D:
					string message10 = global::AcpCommonResources.AcpResources.Cannot_Compare_Field_Does_Not_Exist_In_Comparison.AcpStringFormat(new object[]
					{
						acpFeatureNode2.Path(global::AcpUI.Common.Utility.c("쎞", a_))
					});
					global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(null, message10, false);
					num = (short)1426587658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE1:
					num = (short)602537987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1C:
					num3++;
					num = (short)1511849995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6D:
					num = (short)883752969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F49:
					num = (short)785776648;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A7:
				flag = false;
				num3 = 0;
				num = (short)899285017;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000761D0 File Offset: 0x000743D0
		private static void a(global::AcpCommonLib.Document A_0, global::AcpCommonLib.Document A_1)
		{
			short num = (short)668663808;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = A_0.Features.GetEnumerator();
			try
			{
				num = (short)363724805;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1A6;
					case 1:
					{
						num = (short)1185513506;
						short num4 = num;
						num = (short)1437433890;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)308412416;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)1832845315;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
							global::AcpCommonLib.IAcpRecordset feature = A_1.GetFeature(acpRecordset.RecsetId);
							num = (short)1855651844;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						global::AcpCommonLib.IAcpRecordset feature;
						global::AcpUI.Comparator.ComparatorManager.a(acpRecordset, feature, true);
						num = (short)775684102;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1190854656;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)384499714;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_76;
						}
						continue;
					case 6:
						num = (short)944308225;
						if (num != 0)
						{
						}
						break;
					}
					IL_BD:
					num = (short)1894973441;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_76:
					goto IL_BD;
				}
				IL_1A6:;
			}
			finally
			{
				num = (short)983367681;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)214171650;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1D9;
						}
						continue;
					case 2:
						goto IL_20D;
					}
					IL_1D9:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1602420736;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_20D:;
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0007640C File Offset: 0x0007460C
		public static void CopyAllFields(global::AcpUILib.IAcpPageFeature page)
		{
			int a_ = 11;
			short num = (short)119078912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = feature.NodeFromKey(acpFeatureNode2.ReferenceKey);
						num = (short)1442709507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (acpRecordset.Count == 0)
						{
							num = (short)179765250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(acpRecordset.RecsetId);
						num = (short)691994628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					case 3:
						goto IL_159;
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature == null)
						{
							num = (short)1825439756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int currentPosition = ((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(((global::System.Windows.Controls.Page)page).DataContext)).CurrentPosition;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = acpRecordset[currentPosition];
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
						num = (short)1688010761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						int currentPosition;
						if (currentPosition < feature.Count)
						{
							num = (short)470876176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					}
					case 6:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
						acpFeatureNode2.CalculateVisibility(true);
						acpFeatureNode2.CalculateEditability(true);
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						global::AcpUI.Comparator.ComparatorManager.a(acpFeatureNode2, acpFeatureNode, containerTask);
						num = (short)1276444691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1802633229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
						{
							num = (short)820314132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
						if (acpFeatureNode2.Parent.HasKeyField)
						{
							num = (short)605683719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					}
					case 10:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode != null)
						{
							num = (short)828243974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E;
					}
					case 11:
						goto IL_238;
					case 12:
						return;
					case 13:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count > 0)
						{
							num = (short)274530304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					}
					case 14:
						goto IL_370;
					case 15:
						if (containerTask != null)
						{
							num = (short)1592918037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EE;
					case 16:
					{
						num = (short)1738604544;
						short num3 = num;
						num = (short)539760029;
						short num4 = num;
						num = (short)1752241565;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23D;
						default:
						{
							num = (short)860028928;
							if (num != 0)
							{
							}
							global::AcpCommonLib.IAcpRecordset feature;
							int currentPosition;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = feature[currentPosition];
							num = (short)995885073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 17:
						goto IL_159;
					case 18:
						if (containerTask.Tasks.Count > 0)
						{
							num = (short)1251213326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EE;
					case 19:
						goto IL_11E;
					case 20:
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)917241867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)807075858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_90;
					IL_11E:
					num = (short)1868759055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_159:
					num = (short)58654730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23D:
					num = (short)1595998213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EE:
					num = (short)162529288;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_238:
				return;
				IL_370:
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
				return;
				IL_90:
				num = (short)984481793;
				if (num != 0)
				{
				}
				containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpUI.Common.Utility.c("첢햤\udea6覨솬쎮", a_));
				acpRecordset = (global::AcpCommonLib.IAcpRecordset)((global::System.Windows.Controls.Page)page).DataContext;
				num = (short)705363969;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00076898 File Offset: 0x00074A98
		private static void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1, global::AcpCommonLib.UndoRedo.ContainerTask A_2)
		{
			short num = (short)911998976;
			switch (num)
			{
			default:
			{
				num = (short)457310208;
				short num2 = num;
				num = (short)1714028545;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollectionByOrder.GetEnumerator();
				try
				{
					num = (short)366936064;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpCommonLib.IAcpRecordset embeddedRecset;
						global::AcpCommonLib.IAcpRecordset embeddedRecset2;
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_ED;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)203358223;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2 = A_1[acpFeatureSection.FeatureSectionId];
							num = (short)495058955;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_31B;
						case 3:
							if (embeddedRecset != null)
							{
								num = (short)100139020;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							if (embeddedRecset.RecsetId == embeddedRecset2.RecsetId)
							{
								num = (short)1302265858;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							goto IL_568;
						case 7:
						{
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
							if (acpFeatureSection.HasEmbeddedRecset)
							{
								num = (short)777715726;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							num = (short)2080374789;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2 = acpFeatureSection.FieldsCollectionByOrder.GetEnumerator();
							num = (short)369229837;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							if (embeddedRecset2 != null)
							{
								num = (short)252903440;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 11:
						{
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
							if (acpFeatureSection2 != null)
							{
								num = (short)1208352777;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							num = (short)15204362;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							try
							{
								num = (short)2027290628;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (((global::AcpBusinessLayer.AcpFieldBase)acpField).UnsupportedValue)
										{
											num = (short)1654194183;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
										global::AcpCommonLib.IAcpField acpField;
										global::AcpCommonLib.IAcpField acpField2 = acpFeatureSection2[acpField.UIName];
										num = (short)1869217800;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::AcpCommonLib.IAcpField acpField;
										global::AcpCommonLib.IAcpField acpField2;
										A_2.AddTask(acpField.CopyValueOf(acpField2));
										num = (short)1218904064;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_145;
										}
										continue;
									case 5:
										num = (short)1996161030;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_2AA;
									case 7:
									{
										global::AcpCommonLib.IAcpField acpField;
										global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(acpField, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unsupported_Value, false);
										num = (short)1405026305;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::AcpCommonLib.IAcpField acpField2;
										if (acpField2 != null)
										{
											num = (short)2099445763;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1863843845;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpField acpField = enumerator2.Current;
										num = (short)204210186;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (((global::AcpBusinessLayer.AcpFieldBase)acpField).AllowsCopy())
										{
											num = (short)2030501890;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_227:
									num = (short)1888354313;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_145:
									goto IL_227;
								}
								IL_2AA:
								goto IL_50C;
							}
							finally
							{
								num = (short)735510530;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
									switch (num3)
									{
									case 0:
										goto IL_318;
									case 1:
										enumerator2.Dispose();
										num = (short)20578304;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2E2;
										}
										continue;
									}
									IL_2E2:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)783089665;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_318:;
							}
							goto IL_31B;
							IL_50C:
							num = (short)1614413831;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						{
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
							embeddedRecset = acpFeatureSection.EmbeddedRecset;
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
							embeddedRecset2 = acpFeatureSection2.EmbeddedRecset;
							num = (short)377815043;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							num = (short)757202950;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							num = (short)1918566417;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (!embeddedRecset.HiddenStatic)
							{
								num = (short)818151432;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						goto IL_ED;
						IL_31B:
						global::AcpUI.Comparator.ComparatorManager.a(embeddedRecset, embeddedRecset2, A_2);
						num = (short)1591869444;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3AB:
						num = (short)1072103425;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_ED:
						goto IL_3AB;
					}
					IL_568:;
				}
				finally
				{
					num = (short)1207238658;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)957155078;
						short num4 = num;
						num = (short)1220216582;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_625;
						default:
							num = (short)1347747840;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								goto IL_625;
							case 1:
								enumerator.Dispose();
								num = (short)1455292416;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_5ED;
								}
								continue;
							}
							IL_5ED:
							if (enumerator == null)
							{
								goto IL_627;
							}
							num = (short)1802633217;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_625:
					IL_627:;
				}
				return;
			}
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00076F04 File Offset: 0x00075104
		private static void a(global::AcpCommonLib.IAcpRecordset A_0, global::AcpCommonLib.IAcpRecordset A_1, global::AcpCommonLib.UndoRedo.ContainerTask A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = A_1.NodeFromKey(acpFeatureNode2.ReferenceKey);
					num2 = (short)1338572810;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)427032576;
					short num3 = num2;
					goto IL_1CE;
				}
				case 2:
					return;
				case 3:
					num2 = (short)832372741;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					global::AcpUI.Comparator.ComparatorManager.a(acpFeatureNode2, acpFeatureNode, A_2);
					num2 = (short)666763272;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (A_1.Count > 0)
					{
						goto IL_10A;
					}
					goto IL_195;
				case 6:
					if (num4 < A_1.Count)
					{
						num2 = (short)1567752203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_195;
				case 7:
				{
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					if (acpFeatureNode != null)
					{
						num2 = (short)1483079684;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_126;
				}
				case 8:
					goto IL_126;
				case 9:
				{
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
					if (acpFeatureNode2.Parent.HasKeyField)
					{
						num2 = (short)1473183747;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)835059718;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					goto IL_195;
				case 11:
				{
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = A_1[num4];
					num2 = (short)868352014;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					goto IL_1CE;
				case 13:
				{
					num2 = (short)77266945;
					if (num2 != 0)
					{
					}
					num2 = (short)801060955;
					short num5 = num2;
					num2 = (short)1986410587;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
					{
						num2 = (short)1016922112;
						if (num2 != 0)
						{
						}
						if (num4 >= A_0.Count)
						{
							num2 = (short)194969602;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = A_0[num4];
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
						num2 = (short)2096300041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 14:
					goto IL_195;
				}
				goto IL_4C;
				IL_10A:
				num2 = (short)1174142976;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_126:
				num4++;
				num2 = (short)1785200652;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_195:
				num2 = (short)1101398023;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1CE:
				num2 = (short)793051149;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_4C:
			A_0.CalculateVisibility(true);
			A_0.CalculateEditability(true);
			num4 = 0;
			num2 = (short)1765277697;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000771F8 File Offset: 0x000753F8
		public static void RefreshTree(global::System.Windows.Controls.Page treeViewPage)
		{
			short num = (short)753139712;
			switch (num)
			{
			default:
			{
				num = (short)1853030402;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int nodeId;
					int recsetId;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
					global::System.Windows.Controls.ItemCollection items;
					switch (num2)
					{
					case 0:
						if (treeViewPage.Content is global::System.Windows.Controls.TreeView)
						{
							num = (short)1872429057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_5C5;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 3:
						if (treeViewPage.Content != null)
						{
							num = (short)1389232133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)1631780865;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1426259970;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpUI.AcpTreeViewItem acpTreeViewItem;
								global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
								switch (num2)
								{
								case 0:
									goto IL_504;
								case 1:
								{
									global::AcpCommonLib.IAcpField acpField;
									if (!acpField.Parent.Parent.Parent.ParentSection.Parent.Parent.SingleInstance)
									{
										num = (short)460259337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F6;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_12A;
									}
									continue;
								case 3:
									goto IL_47B;
								case 4:
									if (acpTreeViewItem != null)
									{
										num = (short)1156317189;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									acpTreeViewItem.ShowDiffIcon = true;
									acpTreeViewItem2 = acpTreeViewItem;
									num = (short)1744896020;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpField acpField;
									if (!acpField.Parent.Parent.Parent.SingleInstance)
									{
										num = (short)227999759;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4CC;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpField acpField;
									if (acpField.Parent.Parent.Parent.ParentSection.Parent.Parent.HideRecordsFromTree)
									{
										num = (short)1156382733;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									nodeId = acpField.Parent.Parent.Parent.ParentSection.Parent.NodeId;
									num = (short)1134952465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)312541184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)783024135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::AcpCommonLib.IAcpField acpField;
									recsetId = acpField.Parent.Parent.Parent.ParentSection.Parent.Parent.RecsetId;
									num = (short)504823809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_4CC;
								case 12:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)532480008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpField acpField = enumerator.Current;
									num = (short)813236238;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									goto IL_3F6;
								case 14:
								{
									global::AcpCommonLib.IAcpField acpField;
									if (acpField.Parent.Parent.Parent.IsEmbeddedRecset)
									{
										num = (short)1181876234;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									recsetId = acpField.Parent.Parent.Parent.RecsetId;
									num = (short)571211782;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									num = (short)1953038358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if (!(acpTreeViewItem2.Parent is global::AcpUI.AcpTreeViewItem))
									{
										num = (short)1299775506;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_15F;
								case 17:
									goto IL_47B;
								case 19:
									goto IL_47B;
								case 20:
									goto IL_15F;
								case 21:
									goto IL_47B;
								case 22:
								{
									global::AcpCommonLib.IAcpField acpField;
									if (acpField.Parent.Parent.Parent.HideRecordsFromTree)
									{
										num = (short)1476395019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									nodeId = acpField.Parent.Parent.NodeId;
									num = (short)101580803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_12A;
								IL_15F:
								((global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Parent).ShowDiffIcon = true;
								acpTreeViewItem2 = (global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Parent;
								num = (short)1774452752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_29E:
								num = (short)1443168268;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12A:
								goto IL_29E;
								IL_3F6:
								nodeId = 0;
								num = (short)17694741;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_47B:
								acpTreeViewItem = ((global::AcpUI.AcpTreeView)treeViewPage.Content).FindChildTreeViewItem(recsetId, nodeId, items);
								num = (short)991166468;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4CC:
								nodeId = 0;
								num = (short)95354899;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_504:
							return;
						}
						finally
						{
							num = (short)727777282;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1326277179;
								short num3 = num;
								num = (short)1714643515;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_5C2;
								default:
									num = (short)1206190080;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_5C2;
									case 1:
										enumerator.Dispose();
										num = (short)180748288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_589;
										}
										continue;
									}
									IL_589:
									if (enumerator == null)
									{
										goto IL_5C4;
									}
									num = (short)1997209601;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_5C2:
							IL_5C4:;
						}
						goto IL_5C5;
					case 5:
						num = (short)861929472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1116536835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5F:
					if (treeViewPage != null)
					{
						num = (short)1560215552;
						short num4 = num;
						num = (short)667615238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_5C5:
					items = ((global::System.Windows.Controls.TreeView)treeViewPage.Content).Items;
					global::AcpUI.Comparator.ComparatorManager.a((global::AcpUI.AcpTreeViewItem)items[0]);
					recsetId = 0;
					nodeId = 0;
					enumerator = global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.AllFields.GetEnumerator();
					num = (short)1142423556;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000778E4 File Offset: 0x00075AE4
		private static void a(global::AcpUI.AcpTreeViewItem A_0)
		{
			short num = (short)624558080;
			switch (num)
			{
			default:
			{
				num = (short)1534394375;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						int count;
						if (count > 0)
						{
							num = (short)988938245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						A_0.ShowDiffIcon = false;
						int count = A_0.Items.Count;
						num = (short)1362034688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_189;
					case 3:
						goto IL_189;
					case 4:
					{
						int count;
						int num3;
						if (num3 >= count)
						{
							num = (short)988610566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.ItemCollection items;
						global::AcpUI.AcpTreeViewItem a_ = (global::AcpUI.AcpTreeViewItem)items.CurrentItem;
						items.MoveCurrentToNext();
						global::AcpUI.Comparator.ComparatorManager.a(a_);
						num3++;
						num = (short)1000210434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)1021509633;
						if (num != 0)
						{
						}
						global::System.Windows.Controls.ItemCollection items = A_0.Items;
						items.MoveCurrentToFirst();
						int num3 = 0;
						num = (short)789053443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)1078112408;
						short num4 = num;
						num = (short)1565372568;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6A;
						default:
							goto IL_1F8;
						}
						break;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					}
					goto IL_64;
					IL_6A:
					num = (short)774438912;
					short num5 = num;
					num = (short)1520500737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64:
					if (A_0 != null)
					{
						goto IL_6A;
					}
					return;
					IL_189:
					num = (short)1566507012;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F8:
				num = (short)877199360;
				if (num != 0)
				{
				}
				return;
			}
			}
		}
	}
}
