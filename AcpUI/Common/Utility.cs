using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;

namespace AcpUI.Common
{
	// Token: 0x020000B1 RID: 177
	public static class Utility
	{
		// Token: 0x0600069D RID: 1693 RVA: 0x000839AC File Offset: 0x00081BAC
		public static void RestoreAllFields(global::AcpUI.AcpPageFeature page)
		{
			short num = (short)523698177;
			if (num != 0)
			{
			}
			num = (short)1433337856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_50:
						global::System.Windows.Data.CollectionView collectionView;
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						switch (num2)
						{
						case 0:
							global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
							num = (short)1342242825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (page.MyBaseRecNavToolbar.TableMode)
							{
								num = (short)2059796485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A6;
						case 2:
							if (page.MyBaseRecNavToolbar != null)
							{
								num = (short)1401356294;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A6;
						case 3:
							goto IL_26E;
						case 4:
							goto IL_26E;
						case 5:
							containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.Restore_All);
							global::AcpUI.Common.Utility.a((global::AcpCommonLib.IAcpRecordset)page.DataContext, containerTask);
							num = (short)1612578820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)684785665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							int currentPosition = collectionView.CurrentPosition;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = acpRecordset[currentPosition];
							num = (short)119865355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							num = (short)90897199;
							short num3 = num;
							num = (short)204995375;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_8D;
							default:
							{
								num = (short)1676673024;
								if (num != 0)
								{
								}
								num = (short)630456320;
								short num4 = num;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								acpFeatureNode.CalculateVisibility(true);
								acpFeatureNode.CalculateEditability(true);
								containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.Restore_All);
								global::AcpUI.Common.Utility.a(acpFeatureNode, containerTask);
								num = (short)576651267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 9:
							return;
						case 10:
							if (containerTask != null)
							{
								num = (short)1171521536;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 11:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (acpFeatureNode != null)
							{
								num = (short)1202978824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_26E;
						}
						case 12:
							if (collectionView.CurrentPosition >= 0)
							{
								num = (short)2042429447;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_26E;
						}
						goto IL_8B;
						IL_26E:
						num = (short)1860304906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A6:
						acpRecordset = (global::AcpCommonLib.IAcpRecordset)page.DataContext;
						collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(page.DataContext);
						num = (short)2026307596;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
				}
				IL_8B:
				containerTask = null;
				IL_8D:
				num = (short)2136670210;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00083CBC File Offset: 0x00081EBC
		public static void RestoreAllInvalidFields()
		{
			int a_ = 2;
			short num = (short)974192640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
				for (;;)
				{
					IL_30:
					int num4;
					switch (num2)
					{
					case 0:
						global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
						num = (short)1694367761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_226;
					case 2:
					{
						num = (short)1943863297;
						if (num != 0)
						{
						}
						bool flag;
						if (flag)
						{
							num = (short)1506410511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
					}
					case 3:
						num = (short)505217034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_113;
					case 5:
						num = (short)437583886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_22B;
					case 7:
					{
						bool flag = true;
						global::AcpCommonLib.IAcpField acpField;
						((global::AcpBusinessLayer.AcpFieldBase)acpField).ResetToDefaultWithUndo(containerTask);
						num = (short)2115502086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
						{
							num = (short)1400569875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63E;
					case 9:
					{
						global::AcpCommonLib.IAcpField acpField;
						if (!((global::AcpBusinessLayer.AcpFieldBase)acpField).AllowsRestore())
						{
							goto IL_22B;
						}
						num = (short)1410598076;
						short num3 = num;
						num = (short)803996860;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5DC;
						default:
							num = (short)1193082880;
							if (num != 0)
							{
							}
							num = (short)1643184135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiHasFields)
						{
							num = (short)174063636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
					case 11:
						if (containerTask != null)
						{
							num = (short)514719749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					case 12:
						if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport != null)
						{
							num = (short)416874499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
					case 13:
					{
						try
						{
							num = (short)134086658;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
									if (fieldsReportInfo.Field != null)
									{
										num = (short)360972289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1145438214;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_298;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)854982663;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo = enumerator.Current;
									num = (short)570228736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_3A0;
								case 6:
								{
									global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
									if (fieldsReportInfo.FieldType == global::AcpCommonLib.FieldInfoType.Field)
									{
										num = (short)27394056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)2077163524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
									global::AcpCommonLib.IAcpField field = fieldsReportInfo.Field;
									global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
									list.Add(field);
									num = (short)979304453;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_29A:
								num = (short)133103619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_298:
								goto IL_29A;
							}
							IL_3A0:
							goto IL_578;
						}
						finally
						{
							num = (short)944766977;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1679556610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3D8;
									}
									continue;
								case 2:
									goto IL_411;
								}
								IL_3D8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)200015872;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_411:;
						}
						goto IL_414;
						IL_578:
						containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpUI.Common.Utility.c("쪗ﾙ쾟킡솣蚥용삫躭羚\udcb1슳ힵ풷펹\ud8bb춽", a_));
						bool flag = false;
						num4 = 0;
						num = (short)1033109526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (containerTask.Tasks.Count > 0)
						{
							num = (short)885325824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					case 15:
						global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
						num = (short)563347474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
						if (num4 >= list.Count)
						{
							num = (short)110559253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpField acpField = list[num4];
						num = (short)447545353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_175;
					case 18:
						goto IL_D5;
					case 19:
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)462815233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::System.Windows.Input.Mouse.OverrideCursor = global::System.Windows.Input.Cursors.Wait;
						global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator = global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiFields.GetEnumerator();
						num = (short)1208418304;
						short num5 = num;
						num = (short)1896218637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_5DC;
					case 22:
						goto IL_113;
					}
					goto IL_93;
					IL_D5:
					num = (short)2124087307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_113:
					num = (short)1359282192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22B:
					num4++;
					num = (short)697761796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_414:
					num = (short)390201352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DC:
					num = (short)2133131266;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_175:
				IL_226:
				IL_63E:
				global::System.Windows.Input.Mouse.OverrideCursor = null;
				return;
				IL_93:
				containerTask = null;
				num = (short)2034761740;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0008432C File Offset: 0x0008252C
		private static void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			short num = (short)355800840;
			short num2 = num;
			num = (short)840570632;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)713228289;
				if (num != 0)
				{
				}
				num = (short)574947328;
				if (num != 0)
				{
				}
				num = (short)331743232;
				switch (num)
				{
				}
				break;
			}
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollectionByOrder.GetEnumerator();
			try
			{
				num = (short)158597125;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset embeddedRecset;
					switch (num3)
					{
					case 0:
						goto IL_266;
					case 1:
						num = (short)1340276740;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1801125889;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2 = acpFeatureSection.FieldsCollectionByOrder.GetEnumerator();
						num = (short)261423107;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)685703170;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_1F6;
								case 1:
									num = (short)1853554688;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_13C;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)473694209;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)enumerator2.Current;
									num = (short)998047749;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
									if (acpFieldBase.AllowsRestore())
									{
										num = (short)956628998;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
									acpFieldBase.ResetToDefaultWithUndo(A_1);
									num = (short)489881603;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_13E:
								num = (short)699400196;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_13C:
								goto IL_13E;
							}
							IL_1F6:
							goto IL_33A;
						}
						finally
						{
							num = (short)754384896;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_22D;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)503185410;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_263;
								}
								IL_22D:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)48496641;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_263:;
						}
						goto IL_266;
						IL_33A:
						num = (short)510459914;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_3D6;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_F3;
						}
						continue;
					case 6:
						if (embeddedRecset != null)
						{
							num = (short)457637896;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 8:
						num = (short)1262026761;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!embeddedRecset.HiddenStatic)
						{
							num = (short)1030160384;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 10:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
						if (acpFeatureSection.HasEmbeddedRecset)
						{
							num = (short)1958281227;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
						embeddedRecset = acpFeatureSection.EmbeddedRecset;
						num = (short)103350278;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_F3;
					IL_266:
					global::AcpUI.Common.Utility.a(embeddedRecset, A_1);
					num = (short)456458247;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F9:
					num = (short)311427074;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_F3:
					goto IL_2F9;
				}
				IL_3D6:;
			}
			finally
			{
				num = (short)508231680;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_40C;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1893400578;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_441;
					}
					IL_40C:
					if (enumerator == null)
					{
						break;
					}
					num = (short)858193921;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_441:;
			}
			num = (short)758382592;
			short num4 = num;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000847DC File Offset: 0x000829DC
		private static void a(global::AcpCommonLib.IAcpRecordset A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			int num2;
			int count;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_4E;
				case 1:
					goto IL_4E;
				case 2:
				{
					if (num2 >= count)
					{
						num3 = (short)1732313091;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1354662888;
					short num4 = num3;
					num3 = (short)700679144;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4E;
					default:
						num3 = (short)1889206272;
						if (num3 != 0)
						{
						}
						global::AcpUI.Common.Utility.a(A_0[num2], A_1);
						num2++;
						num3 = (short)1170538496;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 3:
					goto IL_7C;
				}
				goto IL_20;
				IL_4E:
				num3 = (short)143523842;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_7C:
			num3 = (short)1945763840;
			short num5 = num3;
			num3 = (short)1526071297;
			if (num3 != 0)
			{
			}
			return;
			IL_20:
			A_0.CalculateVisibility(true);
			A_0.CalculateEditability(true);
			count = A_0.Count;
			num2 = 0;
			num3 = (short)1455423489;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060006A1 RID: 1697 RVA: 0x00084930 File Offset: 0x00082B30
		// (remove) Token: 0x060006A2 RID: 1698 RVA: 0x00084A64 File Offset: 0x00082C64
		public static event global::AcpUI.Common.CpgFieldNameEventHandler CpgFieldNameMouseClickEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.CpgFieldNameEventHandler cpgFieldNameEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.CpgFieldNameEventHandler cpgFieldNameEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_38;
					case 1:
					{
						if (cpgFieldNameEventHandler != cpgFieldNameEventHandler2)
						{
							goto IL_3A;
						}
						num2 = (short)400804413;
						short num3 = num2;
						num2 = (short)481479229;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38;
						default:
							num2 = (short)2083454976;
							if (num2 != 0)
							{
							}
							num2 = (short)91815937;
							if (num2 != 0)
							{
							}
							num2 = (short)1358036994;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_FB;
					}
					goto IL_1C;
					IL_3A:
					cpgFieldNameEventHandler2 = cpgFieldNameEventHandler;
					global::AcpUI.Common.CpgFieldNameEventHandler value2 = (global::AcpUI.Common.CpgFieldNameEventHandler)global::System.Delegate.Combine(cpgFieldNameEventHandler2, value);
					cpgFieldNameEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.CpgFieldNameEventHandler>(ref global::AcpUI.Common.Utility.a, value2, cpgFieldNameEventHandler2);
					num2 = (short)1530462209;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_38:
					goto IL_3A;
				}
				IL_FB:
				num2 = (short)2074935296;
				short num4 = num2;
				return;
				IL_1C:
				cpgFieldNameEventHandler = global::AcpUI.Common.Utility.a;
				num2 = (short)1687486464;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.CpgFieldNameEventHandler cpgFieldNameEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.CpgFieldNameEventHandler cpgFieldNameEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_5E;
					case 1:
					{
						if (cpgFieldNameEventHandler != cpgFieldNameEventHandler2)
						{
							goto IL_60;
						}
						num2 = (short)492473627;
						short num3 = num2;
						num2 = (short)1869909275;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5E;
						default:
							num2 = (short)1017708544;
							if (num2 != 0)
							{
							}
							num2 = (short)582418434;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_F9;
					}
					goto IL_1C;
					IL_60:
					cpgFieldNameEventHandler2 = cpgFieldNameEventHandler;
					global::AcpUI.Common.CpgFieldNameEventHandler value2 = (global::AcpUI.Common.CpgFieldNameEventHandler)global::System.Delegate.Remove(cpgFieldNameEventHandler2, value);
					cpgFieldNameEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.CpgFieldNameEventHandler>(ref global::AcpUI.Common.Utility.a, value2, cpgFieldNameEventHandler2);
					num2 = (short)1058078721;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_5E:
					goto IL_60;
				}
				IL_F9:
				num2 = (short)1245642752;
				short num4 = num2;
				return;
				IL_1C:
				num2 = (short)415694849;
				if (num2 != 0)
				{
				}
				cpgFieldNameEventHandler = global::AcpUI.Common.Utility.a;
				num2 = (short)42663936;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060006A3 RID: 1699 RVA: 0x00084B98 File Offset: 0x00082D98
		// (remove) Token: 0x060006A4 RID: 1700 RVA: 0x00084CC8 File Offset: 0x00082EC8
		public static event global::AcpUI.Common.CpgFieldNameEventHandler CpgFieldNameMouseDoubleClickEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.CpgFieldNameEventHandler cpgFieldNameEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.CpgFieldNameEventHandler cpgFieldNameEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_36;
					case 1:
					{
						if (cpgFieldNameEventHandler != cpgFieldNameEventHandler2)
						{
							goto IL_38;
						}
						num2 = (short)1556614572;
						short num3 = num2;
						num2 = (short)1925844396;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36;
						default:
							num2 = (short)1374879744;
							if (num2 != 0)
							{
							}
							num2 = (short)636944386;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_CD;
					}
					goto IL_1C;
					IL_38:
					cpgFieldNameEventHandler2 = cpgFieldNameEventHandler;
					global::AcpUI.Common.CpgFieldNameEventHandler value2 = (global::AcpUI.Common.CpgFieldNameEventHandler)global::System.Delegate.Combine(cpgFieldNameEventHandler2, value);
					cpgFieldNameEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.CpgFieldNameEventHandler>(ref global::AcpUI.Common.Utility.b, value2, cpgFieldNameEventHandler2);
					num2 = (short)403439617;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_36:
					goto IL_38;
				}
				IL_CD:
				num2 = (short)1380581377;
				if (num2 != 0)
				{
				}
				num2 = (short)1255604224;
				short num4 = num2;
				return;
				IL_1C:
				cpgFieldNameEventHandler = global::AcpUI.Common.Utility.b;
				num2 = (short)1265565696;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.CpgFieldNameEventHandler cpgFieldNameEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.CpgFieldNameEventHandler cpgFieldNameEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_37;
					case 1:
					{
						if (cpgFieldNameEventHandler != cpgFieldNameEventHandler2)
						{
							goto IL_5F;
						}
						num2 = (short)1208550759;
						short num3 = num2;
						num2 = (short)1350370663;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37;
						default:
							num2 = (short)2060386304;
							if (num2 != 0)
							{
							}
							num2 = (short)81788930;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_FB;
					}
					goto IL_1C;
					IL_5F:
					cpgFieldNameEventHandler2 = cpgFieldNameEventHandler;
					global::AcpUI.Common.CpgFieldNameEventHandler value2 = (global::AcpUI.Common.CpgFieldNameEventHandler)global::System.Delegate.Remove(cpgFieldNameEventHandler2, value);
					cpgFieldNameEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.CpgFieldNameEventHandler>(ref global::AcpUI.Common.Utility.b, value2, cpgFieldNameEventHandler2);
					num2 = (short)980090881;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_37:
					num2 = (short)1157169153;
					if (num2 != 0)
					{
					}
					goto IL_5F;
				}
				IL_FB:
				num2 = (short)309395456;
				short num4 = num2;
				return;
				IL_1C:
				cpgFieldNameEventHandler = global::AcpUI.Common.Utility.b;
				num2 = (short)1705246720;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060006A5 RID: 1701 RVA: 0x00084DFC File Offset: 0x00082FFC
		// (remove) Token: 0x060006A6 RID: 1702 RVA: 0x00084F30 File Offset: 0x00083130
		public static event global::AcpUI.Common.RecordNavigationEventHandler RecordNavigationEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::AcpUI.Common.RecordNavigationEventHandler recordNavigationEventHandler;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.RecordNavigationEventHandler recordNavigationEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_37;
					case 1:
					{
						num2 = (short)1901461505;
						if (num2 != 0)
						{
						}
						if (recordNavigationEventHandler != recordNavigationEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)299286150;
						short num3 = num2;
						num2 = (short)694140550;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37;
						default:
							num2 = (short)245104640;
							if (num2 != 0)
							{
							}
							num2 = (short)2136801282;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_F9;
					}
					goto IL_1C;
					IL_39:
					recordNavigationEventHandler2 = recordNavigationEventHandler;
					global::AcpUI.Common.RecordNavigationEventHandler value2 = (global::AcpUI.Common.RecordNavigationEventHandler)global::System.Delegate.Combine(recordNavigationEventHandler2, value);
					recordNavigationEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.RecordNavigationEventHandler>(ref global::AcpUI.Common.Utility.c, value2, recordNavigationEventHandler2);
					num2 = (short)708706305;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_37:
					goto IL_39;
				}
				IL_F9:
				num2 = (short)23855104;
				short num4 = num2;
				return;
				IL_1C:
				recordNavigationEventHandler = global::AcpUI.Common.Utility.c;
				num2 = (short)1808531456;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				short num;
				int num2;
				global::AcpUI.Common.RecordNavigationEventHandler recordNavigationEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)744882177;
					if (num != 0)
					{
					}
					global::AcpUI.Common.RecordNavigationEventHandler recordNavigationEventHandler2;
					switch (num2)
					{
					case 0:
						goto IL_5F;
					case 1:
					{
						if (recordNavigationEventHandler != recordNavigationEventHandler2)
						{
							goto IL_61;
						}
						num = (short)767639178;
						short num3 = num;
						num = (short)215629450;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5F;
						default:
							num = (short)653197312;
							if (num != 0)
							{
							}
							num = (short)485031938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_FB;
					}
					goto IL_44;
					IL_61:
					recordNavigationEventHandler2 = recordNavigationEventHandler;
					global::AcpUI.Common.RecordNavigationEventHandler value2 = (global::AcpUI.Common.RecordNavigationEventHandler)global::System.Delegate.Remove(recordNavigationEventHandler2, value);
					recordNavigationEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.RecordNavigationEventHandler>(ref global::AcpUI.Common.Utility.c, value2, recordNavigationEventHandler2);
					num = (short)992477185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F:
					goto IL_61;
				}
				IL_FB:
				num = (short)1448476672;
				short num4 = num;
				return;
				IL_44:
				recordNavigationEventHandler = global::AcpUI.Common.Utility.c;
				num = (short)705560576;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060006A7 RID: 1703 RVA: 0x00085064 File Offset: 0x00083264
		// (remove) Token: 0x060006A8 RID: 1704 RVA: 0x00085194 File Offset: 0x00083394
		public static event global::AcpUI.Common.RecordOperationEventHandler RecordOperationEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.RecordOperationEventHandler recordOperationEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.RecordOperationEventHandler recordOperationEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_36;
					case 1:
					{
						if (recordOperationEventHandler != recordOperationEventHandler2)
						{
							goto IL_38;
						}
						num2 = (short)1291422717;
						short num3 = num2;
						num2 = (short)2089389053;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36;
						default:
							num2 = (short)859963392;
							if (num2 != 0)
							{
							}
							num2 = (short)1380646914;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_D0;
					}
					goto IL_1C;
					IL_38:
					recordOperationEventHandler2 = recordOperationEventHandler;
					global::AcpUI.Common.RecordOperationEventHandler value2 = (global::AcpUI.Common.RecordOperationEventHandler)global::System.Delegate.Combine(recordOperationEventHandler2, value);
					recordOperationEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.RecordOperationEventHandler>(ref global::AcpUI.Common.Utility.d, value2, recordOperationEventHandler2);
					num2 = (short)1419313153;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_36:
					goto IL_38;
				}
				IL_D0:
				num2 = (short)645005313;
				if (num2 != 0)
				{
				}
				num2 = (short)240123904;
				short num4 = num2;
				return;
				IL_1C:
				recordOperationEventHandler = global::AcpUI.Common.Utility.d;
				num2 = (short)40304640;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.RecordOperationEventHandler recordOperationEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.RecordOperationEventHandler recordOperationEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_36;
					case 1:
					{
						if (recordOperationEventHandler != recordOperationEventHandler2)
						{
							goto IL_38;
						}
						num2 = (short)64083976;
						short num3 = num2;
						num2 = (short)784586760;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36;
						default:
							num2 = (short)371720193;
							if (num2 != 0)
							{
							}
							num2 = (short)450560000;
							if (num2 != 0)
							{
							}
							num2 = (short)107347970;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_F5;
					}
					goto IL_1C;
					IL_38:
					recordOperationEventHandler2 = recordOperationEventHandler;
					global::AcpUI.Common.RecordOperationEventHandler value2 = (global::AcpUI.Common.RecordOperationEventHandler)global::System.Delegate.Remove(recordOperationEventHandler2, value);
					recordOperationEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.RecordOperationEventHandler>(ref global::AcpUI.Common.Utility.d, value2, recordOperationEventHandler2);
					num2 = (short)535953409;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_36:
					goto IL_38;
				}
				IL_F5:
				num2 = (short)1097334784;
				short num4 = num2;
				return;
				IL_1C:
				recordOperationEventHandler = global::AcpUI.Common.Utility.d;
				num2 = (short)289013760;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060006A9 RID: 1705 RVA: 0x000852C0 File Offset: 0x000834C0
		// (remove) Token: 0x060006AA RID: 1706 RVA: 0x000853F4 File Offset: 0x000835F4
		public static event global::AcpUI.Common.RecordSelectionEventHandler RecordSelectionEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.RecordSelectionEventHandler recordSelectionEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.RecordSelectionEventHandler recordSelectionEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_36;
					case 1:
					{
						if (recordSelectionEventHandler != recordSelectionEventHandler2)
						{
							goto IL_62;
						}
						num2 = (short)1521079207;
						short num3 = num2;
						num2 = (short)2113065895;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36;
						default:
							num2 = (short)69599232;
							if (num2 != 0)
							{
							}
							num2 = (short)297009154;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_FC;
					}
					goto IL_1C;
					IL_62:
					recordSelectionEventHandler2 = recordSelectionEventHandler;
					global::AcpUI.Common.RecordSelectionEventHandler value2 = (global::AcpUI.Common.RecordSelectionEventHandler)global::System.Delegate.Combine(recordSelectionEventHandler2, value);
					recordSelectionEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.RecordSelectionEventHandler>(ref global::AcpUI.Common.Utility.f, value2, recordSelectionEventHandler2);
					num2 = (short)2013528065;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_36:
					num2 = (short)300351489;
					if (num2 != 0)
					{
					}
					goto IL_62;
				}
				IL_FC:
				num2 = (short)2136080384;
				short num4 = num2;
				return;
				IL_1C:
				recordSelectionEventHandler = global::AcpUI.Common.Utility.f;
				num2 = (short)1427177472;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1361248257;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num2;
				global::AcpUI.Common.RecordSelectionEventHandler recordSelectionEventHandler;
				for (;;)
				{
					IL_32:
					global::AcpUI.Common.RecordSelectionEventHandler recordSelectionEventHandler2;
					switch (num2)
					{
					case 0:
					{
						if (recordSelectionEventHandler != recordSelectionEventHandler2)
						{
							goto IL_60;
						}
						num = (short)694935332;
						short num3 = num;
						num = (short)1762778916;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7C;
						default:
						{
							num = (short)1704394752;
							short num4 = num;
							num = (short)2081882112;
							if (num != 0)
							{
							}
							num = (short)456327169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_60;
					}
					goto IL_44;
					IL_7C:
					num = (short)581107712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60:
					recordSelectionEventHandler2 = recordSelectionEventHandler;
					global::AcpUI.Common.RecordSelectionEventHandler value2 = (global::AcpUI.Common.RecordSelectionEventHandler)global::System.Delegate.Remove(recordSelectionEventHandler2, value);
					recordSelectionEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.RecordSelectionEventHandler>(ref global::AcpUI.Common.Utility.f, value2, recordSelectionEventHandler2);
					goto IL_7C;
				}
				return;
				IL_44:
				recordSelectionEventHandler = global::AcpUI.Common.Utility.f;
				num = (short)1235812354;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060006AB RID: 1707 RVA: 0x00085524 File Offset: 0x00083724
		// (remove) Token: 0x060006AC RID: 1708 RVA: 0x00085658 File Offset: 0x00083858
		public static event global::AcpUI.Common.RecordActivatedEventHandler RecordActivatedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.RecordActivatedEventHandler recordActivatedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.RecordActivatedEventHandler recordActivatedEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (recordActivatedEventHandler != recordActivatedEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)1280744274;
						short num3 = num2;
						num2 = (short)1264360274;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
						{
							num2 = (short)1980366848;
							short num4 = num2;
							num2 = (short)1605697536;
							if (num2 != 0)
							{
							}
							num2 = (short)1528299521;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_55:
					num2 = (short)1853751297;
					if (num2 != 0)
					{
					}
					num2 = (short)726728704;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					recordActivatedEventHandler2 = recordActivatedEventHandler;
					global::AcpUI.Common.RecordActivatedEventHandler value2 = (global::AcpUI.Common.RecordActivatedEventHandler)global::System.Delegate.Combine(recordActivatedEventHandler2, value);
					recordActivatedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.RecordActivatedEventHandler>(ref global::AcpUI.Common.Utility.g, value2, recordActivatedEventHandler2);
					goto IL_55;
				}
				return;
				IL_1C:
				recordActivatedEventHandler = global::AcpUI.Common.Utility.g;
				num2 = (short)1471938562;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::AcpUI.Common.RecordActivatedEventHandler recordActivatedEventHandler;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.RecordActivatedEventHandler recordActivatedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)969736193;
						if (num2 != 0)
						{
						}
						if (recordActivatedEventHandler != recordActivatedEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)46263300;
						short num3 = num2;
						num2 = (short)418900996;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
						{
							num2 = (short)1026752512;
							short num4 = num2;
							num2 = (short)2097872896;
							if (num2 != 0)
							{
							}
							num2 = (short)589758465;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_55:
					num2 = (short)680329216;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					recordActivatedEventHandler2 = recordActivatedEventHandler;
					global::AcpUI.Common.RecordActivatedEventHandler value2 = (global::AcpUI.Common.RecordActivatedEventHandler)global::System.Delegate.Remove(recordActivatedEventHandler2, value);
					recordActivatedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.RecordActivatedEventHandler>(ref global::AcpUI.Common.Utility.g, value2, recordActivatedEventHandler2);
					goto IL_55;
				}
				return;
				IL_1C:
				recordActivatedEventHandler = global::AcpUI.Common.Utility.g;
				num2 = (short)738000898;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060006AD RID: 1709 RVA: 0x00085784 File Offset: 0x00083984
		// (remove) Token: 0x060006AE RID: 1710 RVA: 0x000858B4 File Offset: 0x00083AB4
		public static event global::AcpUI.Common.FieldReportItemSelectionEventHandler FieldReportItemSelectionEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::AcpUI.Common.FieldReportItemSelectionEventHandler fieldReportItemSelectionEventHandler;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.FieldReportItemSelectionEventHandler fieldReportItemSelectionEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)936247297;
						if (num2 != 0)
						{
						}
						if (fieldReportItemSelectionEventHandler != fieldReportItemSelectionEventHandler2)
						{
							goto IL_38;
						}
						num2 = (short)1503023557;
						short num3 = num2;
						num2 = (short)186339781;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_54;
						default:
						{
							num2 = (short)1693712384;
							short num4 = num2;
							num2 = (short)810483712;
							if (num2 != 0)
							{
							}
							num2 = (short)530907137;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_38;
					}
					goto IL_1C;
					IL_54:
					num2 = (short)1111097344;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_38:
					fieldReportItemSelectionEventHandler2 = fieldReportItemSelectionEventHandler;
					global::AcpUI.Common.FieldReportItemSelectionEventHandler value2 = (global::AcpUI.Common.FieldReportItemSelectionEventHandler)global::System.Delegate.Combine(fieldReportItemSelectionEventHandler2, value);
					fieldReportItemSelectionEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.FieldReportItemSelectionEventHandler>(ref global::AcpUI.Common.Utility.h, value2, fieldReportItemSelectionEventHandler2);
					goto IL_54;
				}
				return;
				IL_1C:
				fieldReportItemSelectionEventHandler = global::AcpUI.Common.Utility.h;
				num2 = (short)896991234;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.FieldReportItemSelectionEventHandler fieldReportItemSelectionEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.FieldReportItemSelectionEventHandler fieldReportItemSelectionEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (fieldReportItemSelectionEventHandler != fieldReportItemSelectionEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)1152103104;
						short num3 = num2;
						num2 = (short)31240896;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
						{
							num2 = (short)1617231872;
							if (num2 != 0)
							{
							}
							num2 = (short)1472987136;
							short num4 = num2;
							num2 = (short)1301741569;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_F7;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_55:
					num2 = (short)720371712;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					fieldReportItemSelectionEventHandler2 = fieldReportItemSelectionEventHandler;
					global::AcpUI.Common.FieldReportItemSelectionEventHandler value2 = (global::AcpUI.Common.FieldReportItemSelectionEventHandler)global::System.Delegate.Remove(fieldReportItemSelectionEventHandler2, value);
					fieldReportItemSelectionEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.FieldReportItemSelectionEventHandler>(ref global::AcpUI.Common.Utility.h, value2, fieldReportItemSelectionEventHandler2);
					goto IL_55;
				}
				IL_F7:
				num2 = (short)1835335681;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				fieldReportItemSelectionEventHandler = global::AcpUI.Common.Utility.h;
				num2 = (short)1767178242;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060006AF RID: 1711 RVA: 0x000859E4 File Offset: 0x00083BE4
		// (remove) Token: 0x060006B0 RID: 1712 RVA: 0x00085B18 File Offset: 0x00083D18
		public static event global::AcpUI.Common.FieldReportUpdatedEventHandler FieldsReportUpdatedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.FieldReportUpdatedEventHandler fieldReportUpdatedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.FieldReportUpdatedEventHandler fieldReportUpdatedEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (fieldReportUpdatedEventHandler != fieldReportUpdatedEventHandler2)
						{
							goto IL_61;
						}
						num2 = (short)112347196;
						short num3 = num2;
						num2 = (short)1780697148;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
						{
							num2 = (short)866582528;
							short num4 = num2;
							num2 = (short)471531520;
							if (num2 != 0)
							{
							}
							num2 = (short)1253244929;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_61;
					}
					goto IL_1C;
					IL_7D:
					num2 = (short)459014144;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_61:
					fieldReportUpdatedEventHandler2 = fieldReportUpdatedEventHandler;
					global::AcpUI.Common.FieldReportUpdatedEventHandler value2 = (global::AcpUI.Common.FieldReportUpdatedEventHandler)global::System.Delegate.Combine(fieldReportUpdatedEventHandler2, value);
					fieldReportUpdatedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.FieldReportUpdatedEventHandler>(ref global::AcpUI.Common.Utility.i, value2, fieldReportUpdatedEventHandler2);
					goto IL_7D;
				}
				return;
				IL_1C:
				num2 = (short)384303105;
				if (num2 != 0)
				{
				}
				fieldReportUpdatedEventHandler = global::AcpUI.Common.Utility.i;
				num2 = (short)398852098;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.FieldReportUpdatedEventHandler fieldReportUpdatedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.FieldReportUpdatedEventHandler fieldReportUpdatedEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (fieldReportUpdatedEventHandler != fieldReportUpdatedEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)1280180225;
						if (num2 != 0)
						{
						}
						num2 = (short)553479902;
						short num3 = num2;
						num2 = (short)1687973598;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
						{
							num2 = (short)1681784832;
							short num4 = num2;
							num2 = (short)1981939712;
							if (num2 != 0)
							{
							}
							num2 = (short)1920663553;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_55:
					num2 = (short)1740701696;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					fieldReportUpdatedEventHandler2 = fieldReportUpdatedEventHandler;
					global::AcpUI.Common.FieldReportUpdatedEventHandler value2 = (global::AcpUI.Common.FieldReportUpdatedEventHandler)global::System.Delegate.Remove(fieldReportUpdatedEventHandler2, value);
					fieldReportUpdatedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.FieldReportUpdatedEventHandler>(ref global::AcpUI.Common.Utility.i, value2, fieldReportUpdatedEventHandler2);
					goto IL_55;
				}
				return;
				IL_1C:
				fieldReportUpdatedEventHandler = global::AcpUI.Common.Utility.i;
				num2 = (short)625606658;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060006B1 RID: 1713 RVA: 0x00085C4C File Offset: 0x00083E4C
		// (remove) Token: 0x060006B2 RID: 1714 RVA: 0x00085D80 File Offset: 0x00083F80
		public static event global::AcpUI.Common.DockWindowVisibilityChangedEventHandler DockWindowVisibilityChangedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.DockWindowVisibilityChangedEventHandler dockWindowVisibilityChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.DockWindowVisibilityChangedEventHandler dockWindowVisibilityChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (dockWindowVisibilityChangedEventHandler != dockWindowVisibilityChangedEventHandler2)
						{
							goto IL_38;
						}
						num2 = (short)1603206515;
						short num3 = num2;
						num2 = (short)30670195;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_54;
						default:
						{
							num2 = (short)1048117248;
							if (num2 != 0)
							{
							}
							num2 = (short)1886519296;
							short num4 = num2;
							num2 = (short)1078001665;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_FB;
					case 2:
						goto IL_38;
					}
					goto IL_1C;
					IL_54:
					num2 = (short)148701184;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_38:
					dockWindowVisibilityChangedEventHandler2 = dockWindowVisibilityChangedEventHandler;
					global::AcpUI.Common.DockWindowVisibilityChangedEventHandler value2 = (global::AcpUI.Common.DockWindowVisibilityChangedEventHandler)global::System.Delegate.Combine(dockWindowVisibilityChangedEventHandler2, value);
					dockWindowVisibilityChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.DockWindowVisibilityChangedEventHandler>(ref global::AcpUI.Common.Utility.j, value2, dockWindowVisibilityChangedEventHandler2);
					goto IL_54;
				}
				IL_FB:
				num2 = (short)1968898049;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				dockWindowVisibilityChangedEventHandler = global::AcpUI.Common.Utility.j;
				num2 = (short)2099773442;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.DockWindowVisibilityChangedEventHandler dockWindowVisibilityChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.DockWindowVisibilityChangedEventHandler dockWindowVisibilityChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (dockWindowVisibilityChangedEventHandler != dockWindowVisibilityChangedEventHandler2)
						{
							goto IL_3A;
						}
						num2 = (short)159243523;
						short num3 = num2;
						num2 = (short)1339874563;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						default:
						{
							num2 = (short)433717248;
							if (num2 != 0)
							{
							}
							num2 = (short)1317535744;
							short num4 = num2;
							num2 = (short)604110849;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_FA;
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_56:
					num2 = (short)1244266496;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					dockWindowVisibilityChangedEventHandler2 = dockWindowVisibilityChangedEventHandler;
					global::AcpUI.Common.DockWindowVisibilityChangedEventHandler value2 = (global::AcpUI.Common.DockWindowVisibilityChangedEventHandler)global::System.Delegate.Remove(dockWindowVisibilityChangedEventHandler2, value);
					dockWindowVisibilityChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.DockWindowVisibilityChangedEventHandler>(ref global::AcpUI.Common.Utility.j, value2, dockWindowVisibilityChangedEventHandler2);
					goto IL_56;
				}
				IL_FA:
				num2 = (short)1659568129;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				dockWindowVisibilityChangedEventHandler = global::AcpUI.Common.Utility.j;
				num2 = (short)892928002;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060006B3 RID: 1715 RVA: 0x00085EB0 File Offset: 0x000840B0
		// (remove) Token: 0x060006B4 RID: 1716 RVA: 0x00085FE4 File Offset: 0x000841E4
		public static event global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler DockWindowAutoRiseChangedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				short num;
				int num2;
				global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler dockWindowAutoRiseChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)1781268481;
					if (num != 0)
					{
					}
					global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler dockWindowAutoRiseChangedEventHandler2;
					switch (num2)
					{
					case 0:
					{
						if (dockWindowAutoRiseChangedEventHandler != dockWindowAutoRiseChangedEventHandler2)
						{
							goto IL_60;
						}
						num = (short)818925401;
						short num3 = num;
						num = (short)258658137;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7C;
						default:
						{
							num = (short)1916207104;
							short num4 = num;
							num = (short)1792868352;
							if (num != 0)
							{
							}
							num = (short)987561985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_60;
					}
					goto IL_44;
					IL_7C:
					num = (short)804716544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60:
					dockWindowAutoRiseChangedEventHandler2 = dockWindowAutoRiseChangedEventHandler;
					global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler value2 = (global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler)global::System.Delegate.Combine(dockWindowAutoRiseChangedEventHandler2, value);
					dockWindowAutoRiseChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler>(ref global::AcpUI.Common.Utility.k, value2, dockWindowAutoRiseChangedEventHandler2);
					goto IL_7C;
				}
				return;
				IL_44:
				dockWindowAutoRiseChangedEventHandler = global::AcpUI.Common.Utility.k;
				num = (short)1726676994;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler dockWindowAutoRiseChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler dockWindowAutoRiseChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1193476097;
						if (num2 != 0)
						{
						}
						if (dockWindowAutoRiseChangedEventHandler != dockWindowAutoRiseChangedEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)2014782607;
						short num3 = num2;
						num2 = (short)2000626831;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
						{
							num2 = (short)2067857408;
							short num4 = num2;
							num2 = (short)1808662528;
							if (num2 != 0)
							{
							}
							num2 = (short)2118778881;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_55:
					num2 = (short)345964544;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					dockWindowAutoRiseChangedEventHandler2 = dockWindowAutoRiseChangedEventHandler;
					global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler value2 = (global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler)global::System.Delegate.Remove(dockWindowAutoRiseChangedEventHandler2, value);
					dockWindowAutoRiseChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler>(ref global::AcpUI.Common.Utility.k, value2, dockWindowAutoRiseChangedEventHandler2);
					goto IL_55;
				}
				return;
				IL_1C:
				dockWindowAutoRiseChangedEventHandler = global::AcpUI.Common.Utility.k;
				num2 = (short)1596194818;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060006B5 RID: 1717 RVA: 0x00086118 File Offset: 0x00084318
		// (remove) Token: 0x060006B6 RID: 1718 RVA: 0x00086248 File Offset: 0x00084448
		public static event global::AcpUI.Common.ThemeChangedEventHandler ThemeChangedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::AcpUI.Common.ThemeChangedEventHandler themeChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.ThemeChangedEventHandler themeChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (themeChangedEventHandler != themeChangedEventHandler2)
						{
							goto IL_3A;
						}
						num2 = (short)1572948880;
						short num3 = num2;
						num2 = (short)216222608;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						default:
						{
							num2 = (short)667353088;
							if (num2 != 0)
							{
							}
							num2 = (short)1662124032;
							short num4 = num2;
							num2 = (short)2030436353;
							if (num2 != 0)
							{
							}
							num2 = (short)996147201;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_56:
					num2 = (short)17760256;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					themeChangedEventHandler2 = themeChangedEventHandler;
					global::AcpUI.Common.ThemeChangedEventHandler value2 = (global::AcpUI.Common.ThemeChangedEventHandler)global::System.Delegate.Combine(themeChangedEventHandler2, value);
					themeChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.ThemeChangedEventHandler>(ref global::AcpUI.Common.Utility.l, value2, themeChangedEventHandler2);
					goto IL_56;
				}
				return;
				IL_1C:
				themeChangedEventHandler = global::AcpUI.Common.Utility.l;
				num2 = (short)1341128706;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::AcpUI.Common.ThemeChangedEventHandler themeChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::AcpUI.Common.ThemeChangedEventHandler themeChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)268107777;
						if (num2 != 0)
						{
						}
						if (themeChangedEventHandler != themeChangedEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)1774011080;
						short num3 = num2;
						num2 = (short)522339016;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
						{
							num2 = (short)1939079168;
							short num4 = num2;
							num2 = (short)532873216;
							if (num2 != 0)
							{
							}
							num2 = (short)1035010049;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_55:
					num2 = (short)1139802112;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					themeChangedEventHandler2 = themeChangedEventHandler;
					global::AcpUI.Common.ThemeChangedEventHandler value2 = (global::AcpUI.Common.ThemeChangedEventHandler)global::System.Delegate.Remove(themeChangedEventHandler2, value);
					themeChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpUI.Common.ThemeChangedEventHandler>(ref global::AcpUI.Common.Utility.l, value2, themeChangedEventHandler2);
					goto IL_55;
				}
				return;
				IL_1C:
				themeChangedEventHandler = global::AcpUI.Common.Utility.l;
				num2 = (short)1901789186;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0008637C File Offset: 0x0008457C
		public static void GetFieldHelpText(object sender)
		{
			short num = (short)342032386;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					for (;;)
					{
						global::AcpUI.Common.Utility.a(sender, new global::AcpUI.Common.CpgFieldNameMouseEventArgs());
						num = (short)1969708326;
						short num3 = num;
						num = (short)2049465638;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_98;
						}
					}
					IL_98:
					num = (short)1956315136;
					if (num != 0)
					{
					}
					num = (short)948174849;
					if (num != 0)
					{
					}
					num = (short)1357643777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_ED;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (global::AcpUI.Common.Utility.a == null)
				{
					break;
				}
				num = (short)1378025472;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			num = (short)1717698560;
			short num4 = num;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000864A4 File Offset: 0x000846A4
		public static void OnThemeChanged(object sender, string args)
		{
			short num = (short)850591746;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1306066945;
					if (num != 0)
					{
					}
					for (;;)
					{
						global::AcpUI.Common.Utility.l(sender, new global::AcpUI.Common.ThemeChangedEventArgs(args));
						num = (short)1493789795;
						short num3 = num;
						num = (short)2074897507;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BC;
						}
					}
					IL_BC:
					num = (short)1576140800;
					if (num != 0)
					{
					}
					num = (short)1523777537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_E9;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (global::AcpUI.Common.Utility.l == null)
				{
					break;
				}
				num = (short)1227816960;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			num = (short)425852928;
			short num4 = num;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000865C8 File Offset: 0x000847C8
		internal static void b(object A_0)
		{
			short num = (short)520617986;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					for (;;)
					{
						global::AcpUI.Common.Utility.b(A_0, new global::AcpUI.Common.CpgFieldNameMouseEventArgs());
						num = (short)1289546576;
						short num3 = num;
						num = (short)1655761744;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_95;
						}
					}
					IL_95:
					num = (short)1824129024;
					if (num != 0)
					{
					}
					num = (short)173998081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_C2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (global::AcpUI.Common.Utility.b == null)
				{
					goto IL_EA;
				}
				num = (short)689373184;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C2:
			num = (short)1240399873;
			if (num != 0)
			{
			}
			IL_EA:
			num = (short)367788032;
			short num4 = num;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000866E8 File Offset: 0x000848E8
		internal static void a(object A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
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
				{
					for (;;)
					{
						global::AcpUI.Common.Utility.c(A_0, new global::AcpUI.Common.RecordNavigationEventArgs(A_1));
						num2 = (short)288358401;
						if (num2 != 0)
						{
						}
						num2 = (short)571322658;
						short num3 = num2;
						num2 = (short)2083303714;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_C3;
						}
					}
					IL_C3:
					num2 = (short)11796480;
					short num4 = num2;
					num2 = (short)1842479104;
					if (num2 != 0)
					{
					}
					num2 = (short)1550712833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					if (global::AcpUI.Common.Utility.c != null)
					{
						num2 = (short)291241984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			global::AcpUI.Common.Utility.e = A_1;
			num2 = (short)1743060994;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00086814 File Offset: 0x00084A14
		internal static void a(object A_0, global::AcpCommonLib.IAcpFeatureNode A_1, int A_2, int A_3)
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
				{
					for (;;)
					{
						global::AcpUI.Common.Utility.d(A_0, new global::AcpUI.Common.RecordOperationEventArgs(A_1, A_2, A_3));
						num2 = (short)303366145;
						if (num2 != 0)
						{
						}
						num2 = (short)1995942812;
						short num3 = num2;
						num2 = (short)2007673756;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_C4;
						}
					}
					IL_C4:
					num2 = (short)752025600;
					short num4 = num2;
					num2 = (short)1642921984;
					if (num2 != 0)
					{
					}
					num2 = (short)539230209;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					if (global::AcpUI.Common.Utility.d != null)
					{
						num2 = (short)542703616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			global::AcpUI.Common.Utility.e = A_1;
			num2 = (short)458555394;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00086940 File Offset: 0x00084B40
		internal static void a(object A_0)
		{
			short num = (short)20512770;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					for (;;)
					{
						global::AcpUI.Common.Utility.f(A_0, new global::AcpUI.Common.RecordSelectionEventArgs());
						num = (short)879830974;
						short num3 = num;
						num = (short)74983358;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_99;
						}
					}
					IL_99:
					num = (short)801832960;
					if (num != 0)
					{
					}
					num = (short)1352335361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_C7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (global::AcpUI.Common.Utility.f == null)
				{
					break;
				}
				num = (short)659554304;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C7:
			num = (short)250478593;
			if (num != 0)
			{
			}
			num = (short)278921216;
			short num4 = num;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00086A68 File Offset: 0x00084C68
		internal static void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs A_1)
		{
			short num = (short)516030466;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					for (;;)
					{
						global::AcpUI.Common.Utility.g(A_0, A_1);
						num = (short)1531810824;
						short num3 = num;
						num = (short)1337824264;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_91;
						}
					}
					IL_91:
					num = (short)1296760832;
					if (num != 0)
					{
					}
					num = (short)119734273;
					if (num != 0)
					{
					}
					num = (short)1676673025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_E5;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (global::AcpUI.Common.Utility.f == null)
				{
					break;
				}
				num = (short)231997440;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			num = (short)135331840;
			short num4 = num;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00086B88 File Offset: 0x00084D88
		internal static void a(object A_0, global::AcpCommonLib.FieldInfo A_1)
		{
			short num = (short)249692161;
			if (num != 0)
			{
			}
			num = (short)1650655232;
			short num2 = num;
			num = (short)872153090;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					for (;;)
					{
						global::AcpUI.Common.Utility.h(A_0, new global::AcpUI.Common.FieldItemSelectionEventArgs(A_1));
						num = (short)2132312241;
						short num4 = num;
						num = (short)459112625;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_E8;
						}
					}
					IL_E8:
					num = (short)869990400;
					if (num != 0)
					{
					}
					num = (short)913965057;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					continue;
				}
				IL_80:
				if (global::AcpUI.Common.Utility.h == null)
				{
					break;
				}
				num = (short)1156251648;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00086CB0 File Offset: 0x00084EB0
		public static void FieldsReportChanged(object sender, global::AcpCommonLib.FieldReportType fldRptType)
		{
			short num = (short)848560128;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1653800960;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				case 1:
					for (;;)
					{
						global::AcpUI.Common.Utility.i(sender, new global::AcpUI.Common.FieldReportUpdatedEventArgs(fldRptType));
						num = (short)1807508253;
						short num4 = num;
						num = (short)1496736541;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BF;
						}
					}
					IL_BF:
					num = (short)1309933569;
					if (num != 0)
					{
					}
					num = (short)1248264192;
					if (num != 0)
					{
					}
					num = (short)119865346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_58:
				if (global::AcpUI.Common.Utility.i == null)
				{
					break;
				}
				num = (short)301596673;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00086DD4 File Offset: 0x00084FD4
		public static void DockWindowVisibilityChanged(object sender, bool isVisible)
		{
			short num = (short)1261895680;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1265303552;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				}
				case 1:
					for (;;)
					{
						num = (short)249036801;
						if (num != 0)
						{
						}
						global::AcpUI.Common.Utility.j(sender, new global::AcpUI.Common.DockWindowVisibilityChangedEventArgs(isVisible));
						num = (short)956028496;
						short num4 = num;
						num = (short)498194000;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_E6;
						}
					}
					IL_E6:
					num = (short)1499791360;
					if (num != 0)
					{
					}
					num = (short)1042481154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_5B:
				if (global::AcpUI.Common.Utility.j == null)
				{
					break;
				}
				num = (short)704708609;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00086EF8 File Offset: 0x000850F8
		internal static void a(object A_0, bool A_1)
		{
			short num = (short)1934098432;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1350107136;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				case 1:
					for (;;)
					{
						global::AcpUI.Common.Utility.k(A_0, new global::AcpUI.Common.DockWindowAutoRiseChangedEventArgs(A_1));
						num = (short)973915212;
						short num4 = num;
						num = (short)1672201292;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_C2;
						}
					}
					IL_C2:
					num = (short)1310064641;
					if (num != 0)
					{
					}
					num = (short)1541144576;
					if (num != 0)
					{
					}
					num = (short)1769799682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_59:
				if (global::AcpUI.Common.Utility.k == null)
				{
					break;
				}
				num = (short)566689793;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00087020 File Offset: 0x00085220
		public static void SaveFieldWithFocus()
		{
			short num = (short)581238784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_EA;
				}
				global::System.Windows.FrameworkElement frameworkElement2;
				for (;;)
				{
					IL_27:
					global::System.Windows.Data.BindingExpression bindingExpression;
					global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor;
					global::AcpUI.AcpPasswordBox acpPasswordBox;
					switch (num2)
					{
					case 0:
						goto IL_349;
					case 1:
						goto IL_7F6;
					case 2:
					{
						global::System.Windows.FrameworkElement frameworkElement;
						bindingExpression = frameworkElement.GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty);
						num = (short)1239613444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						xamMaskedEditor = (frameworkElement2 as global::Infragistics.Windows.Editors.XamMaskedEditor);
						num = (short)776798247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_7F6;
					case 5:
					{
						global::System.Windows.FrameworkElement frameworkElement3;
						bindingExpression = frameworkElement3.GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty);
						num = (short)991625248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Windows.Controls.PasswordBox passwordBox;
						if (passwordBox != null)
						{
							num = (short)1672544285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bindingExpression = null;
						num = (short)749535245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_7F6;
					case 8:
						bindingExpression.UpdateSource();
						num = (short)1556217878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (frameworkElement2.TemplatedParent is global::AcpUI.AcpTableTextBoxBase)
						{
							num = (short)93650947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1281556517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						bindingExpression = frameworkElement2.GetBindingExpression(global::AcpUI.AcpTextBoxSpinnerDecHex.TextProperty);
						num = (short)893321241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						if (frameworkElement2 is global::AcpUI.AcpTextBoxSpinnerDecHex)
						{
							num = (short)242548746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.PasswordBox passwordBox = frameworkElement2 as global::System.Windows.Controls.PasswordBox;
						num = (short)693108742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (frameworkElement2 is global::AcpUI.AcpTextBoxSpinner)
						{
							num = (short)37027875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)704905227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_7F6;
					case 14:
						bindingExpression = frameworkElement2.GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty);
						num = (short)773128218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return;
					case 16:
					{
						global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor2 = (global::Infragistics.Windows.Editors.XamMaskedEditor)frameworkElement2.TemplatedParent;
						xamMaskedEditor2.EndEditMode(true, false);
						global::System.Windows.FrameworkElement frameworkElement3 = (global::System.Windows.FrameworkElement)xamMaskedEditor2.TemplatedParent;
						num = (short)69730338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (frameworkElement2 is global::System.Windows.Controls.TextBox)
						{
							num = (short)595525646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)908066844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						num = (short)1197838469;
						short num3 = num;
						num = (short)1548521605;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4BB;
						default:
							num = (short)141492224;
							if (num != 0)
							{
							}
							goto IL_7F6;
						}
						break;
					}
					case 19:
					{
						global::System.Windows.FrameworkElement frameworkElement;
						if (frameworkElement != null)
						{
							num = (short)641466370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bindingExpression = null;
						num = (short)1481703442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (bindingExpression != null)
						{
							num = (short)688979976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
					{
						global::System.Windows.Controls.PasswordBox passwordBox;
						global::AcpUI.AcpPasswordEyeBox acpPasswordEyeBox;
						acpPasswordEyeBox.PIN = passwordBox.Password;
						num = (short)268959789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						return;
					case 23:
						goto IL_7F6;
					case 24:
						if (acpPasswordBox != null)
						{
							num = (short)831717418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 25:
						goto IL_7F6;
					case 26:
						goto IL_7F6;
					case 27:
						xamMaskedEditor.EndEditMode(true, false);
						num = (short)1727791135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (frameworkElement2 is global::AcpUI.AcpTextBoxDecHex)
						{
							num = (short)1126826020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1732706316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::System.Windows.Controls.Grid grid = frameworkElement2.Parent as global::System.Windows.Controls.Grid;
						num = (short)327024673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						if (frameworkElement2 is global::System.Windows.Controls.Primitives.RepeatButton)
						{
							num = (short)628228134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1318322176;
						short num4 = num;
						num = (short)499449873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_43A;
					case 32:
						goto IL_7F6;
					case 33:
					{
						global::System.Windows.Controls.Grid grid;
						if (grid != null)
						{
							num = (short)1208746030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					}
					case 34:
					{
						global::System.Windows.FrameworkElement frameworkElement3;
						if (frameworkElement3 != null)
						{
							num = (short)311623685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bindingExpression = null;
						num = (short)1259601960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						bindingExpression = frameworkElement2.GetBindingExpression(global::AcpUI.AcpTextBoxSpinner.TextProperty);
						num = (short)935067649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						bindingExpression = frameworkElement2.GetBindingExpression(global::AcpUI.AcpTextBoxDecHex.TextProperty);
						num = (short)1632043031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (frameworkElement2.TemplatedParent is global::Infragistics.Windows.Editors.XamMaskedEditor)
						{
							num = (short)1818951696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1190395934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						global::System.Windows.FrameworkElement frameworkElement = frameworkElement2.PredictFocus(global::System.Windows.Input.FocusNavigationDirection.Left) as global::System.Windows.FrameworkElement;
						num = (short)713031699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						if (xamMaskedEditor != null)
						{
							num = (short)1659043867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 40:
						goto IL_7F6;
					case 41:
					{
						global::AcpUI.AcpPasswordEyeBox acpPasswordEyeBox;
						if (acpPasswordEyeBox != null)
						{
							num = (short)665255957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					}
					case 42:
						acpPasswordBox.PIN = acpPasswordBox.Value;
						goto IL_4BB;
					case 43:
						goto IL_7F6;
					case 44:
						if (frameworkElement2 == null)
						{
							num = (short)1256259599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bindingExpression = null;
						num = (short)694091785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_23C;
					case 46:
					{
						global::System.Windows.Controls.Grid grid;
						global::AcpUI.AcpPasswordEyeBox acpPasswordEyeBox = grid.Parent as global::AcpUI.AcpPasswordEyeBox;
						num = (short)379256873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_EA;
					IL_23C:
					acpPasswordBox = (frameworkElement2.Parent as global::AcpUI.AcpPasswordBox);
					num = (short)1373569048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_349:
					bindingExpression = null;
					num = (short)1370292231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43A:
					bindingExpression = ((global::System.Windows.FrameworkElement)xamMaskedEditor.TemplatedParent).GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty);
					num = (short)1010237483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BB:
					num = (short)627441664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F6:
					num = (short)962920468;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_EA:
				num = (short)219873281;
				if (num != 0)
				{
				}
				frameworkElement2 = (global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.FrameworkElement);
				num = (short)1584726060;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0008785C File Offset: 0x00085A5C
		public static void SetDirection(global::System.Windows.FrameworkElement sender)
		{
			while (global::System.Globalization.CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft)
			{
				short num = (short)513834907;
				short num2 = num;
				num = (short)1375633307;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)777715712;
					short num3 = num;
					num = (short)1843200001;
					if (num != 0)
					{
					}
					num = (short)1015087104;
					if (num != 0)
					{
					}
					sender.FlowDirection = global::System.Windows.FlowDirection.RightToLeft;
					return;
				}
				}
			}
			sender.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0008792C File Offset: 0x00085B2C
		public static string FilterArabicDiacritics(string textDiacritics)
		{
			short num = (short)555970622;
			short num2 = num;
			num = (short)518746174;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_4DB:
				num = (short)1240072193;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)860291072;
				short num4 = num;
				num = (short)1129185280;
				if (num != 0)
				{
				}
				num = (short)292618240;
				switch (num)
				{
				default:
					num = (short)1233059866;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			}
			for (;;)
			{
				char c;
				int num5;
				string text;
				switch (num3)
				{
				case 0:
					if (c >= 'ً')
					{
						num = (short)196149252;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_475;
				case 1:
					num = (short)662568963;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2061172744;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (c > 'ۭ')
					{
						num = (short)2055274521;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				case 4:
					num = (short)801505307;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_439;
				case 6:
					goto IL_475;
				case 7:
					if (c >= 'ؐ')
					{
						num = (short)120389650;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_439;
				case 8:
					if (c >= 'ۖ')
					{
						num = (short)1894973455;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B8;
				case 9:
					if (c >= 'ۧ')
					{
						goto IL_4DB;
					}
					goto IL_158;
				case 10:
					goto IL_399;
				case 11:
					goto IL_153;
				case 12:
					if (c > 'ﹿ')
					{
						num = (short)1326317590;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				case 13:
					if (c > 'ۤ')
					{
						num = (short)385351704;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				case 14:
					if (c > 'ؚ')
					{
						num = (short)75038721;
						if (num != 0)
						{
						}
						num = (short)1219756037;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				case 15:
					num = (short)1162674189;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)1118044172;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (c >= 'ﹰ')
					{
						num = (short)423100432;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_243;
				case 18:
					num = (short)789905422;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_2D2;
				case 20:
					if (num5 >= textDiacritics.Length)
					{
						num = (short)1966473239;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					c = textDiacritics[num5];
					num = (short)1163984903;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_2D2;
				case 22:
					goto IL_243;
				case 23:
					return text;
				case 24:
					goto IL_4B8;
				case 25:
					goto IL_158;
				case 26:
					switch (0)
					{
					case 0:
						goto IL_12E;
					}
					continue;
				case 27:
					if (c > 'ٟ')
					{
						num = (short)1447690246;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				case 28:
					if (c != 'ٰ')
					{
						num = (short)1328480258;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				}
				IL_12E:
				if (string.IsNullOrEmpty(textDiacritics))
				{
					num = (short)477167627;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				text = string.Empty;
				num5 = 0;
				num = (short)1773010963;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_158:
				num = (short)1468334097;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_243:
				text += c.ToString();
				num = (short)686227466;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D2:
				num = (short)1246101524;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_399:
				num5++;
				num = (short)1721630741;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_439:
				num = (short)54984704;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_475:
				num = (short)784597020;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B8:
				num = (short)878510089;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_153:
			return string.Empty;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00087E34 File Offset: 0x00086034
		internal static string c(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1848625249 + A_1) + (global::System.IntPtr)2 + (global::System.IntPtr)91 + (global::System.IntPtr)48 + (global::System.IntPtr)86 + (global::System.IntPtr)81);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x04000344 RID: 836
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.CpgFieldNameEventHandler a;

		// Token: 0x04000345 RID: 837
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.CpgFieldNameEventHandler b;

		// Token: 0x04000346 RID: 838
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.RecordNavigationEventHandler c;

		// Token: 0x04000347 RID: 839
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.RecordOperationEventHandler d;

		// Token: 0x04000348 RID: 840
		private static global::AcpCommonLib.IAcpFeatureNode e;

		// Token: 0x04000349 RID: 841
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.RecordSelectionEventHandler f;

		// Token: 0x0400034A RID: 842
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.RecordActivatedEventHandler g;

		// Token: 0x0400034B RID: 843
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.FieldReportItemSelectionEventHandler h;

		// Token: 0x0400034C RID: 844
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.FieldReportUpdatedEventHandler i;

		// Token: 0x0400034D RID: 845
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.DockWindowVisibilityChangedEventHandler j;

		// Token: 0x0400034E RID: 846
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.DockWindowAutoRiseChangedEventHandler k;

		// Token: 0x0400034F RID: 847
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpUI.Common.ThemeChangedEventHandler l;
	}
}
