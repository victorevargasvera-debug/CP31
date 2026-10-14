using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUI.Common;

namespace AcpUI.ImportExport
{
	// Token: 0x0200005E RID: 94
	public static class ImportExportManager
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x000601D0 File Offset: 0x0005E3D0
		public static void SetImportProcess(global::AcpCommonLib.IAcpBatchOperation process)
		{
			short num = (short)902520531;
			short num2 = num;
			num = (short)1972461267;
			switch (num2 == num)
			{
			}
			num = (short)2032402433;
			if (num != 0)
			{
			}
			num = (short)1485963264;
			if (num != 0)
			{
			}
			num = (short)1137967104;
			short num3 = num;
			global::AcpUI.ImportExport.ImportExportManager.a = process;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00060280 File Offset: 0x0005E480
		internal static global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem> a(global::System.Xml.XmlDocument A_0)
		{
			int a_ = 18;
			short num = (short)1597112321;
			if (num != 0)
			{
			}
			num = (short)618790912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Xml.XmlNode lastChild = A_0.ChildNodes[1].LastChild;
				global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem> list = new global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem>();
				global::System.Collections.IEnumerator enumerator = lastChild.ChildNodes.GetEnumerator();
				try
				{
					num = (short)574423044;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_286;
						case 1:
							goto IL_26E;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1224278017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
							num = (short)570163203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_169;
								}
								global::System.Xml.XmlNode xmlNode;
								global::AcpCommonLib.IAcpRecordset feature;
								for (;;)
								{
									IL_14A:
									switch (num2)
									{
									case 0:
										goto IL_24A;
									case 1:
										goto IL_263;
									case 2:
										if (!feature.HiddenStatic)
										{
											num = (short)1553137667;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_24A;
									case 3:
										list.Add(new global::AcpUI.ImportExport.ImportExportItem(xmlNode.Attributes[global::AcpUI.Common.Utility.c("쮩솫쮭", a_)].Value, feature.DataTransferOrder));
										num = (short)1621426176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										num = (short)1501822978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										if (feature != null)
										{
											num = (short)360513540;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_24A;
									}
									goto IL_169;
									IL_24A:
									num = (short)1199964161;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_263:
								break;
								IL_169:
								feature = global::AcpCommonLib.FeatureManager.GetFeature(global::System.Convert.ToInt32(xmlNode.Attributes[global::AcpUI.Common.Utility.c("캩", a_)].Value));
								num = (short)2069626885;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_14A;
							}
							catch (global::System.FormatException)
							{
								break;
							}
							goto IL_26E;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_E4;
							}
							continue;
						}
						IL_109:
						num = (short)685113346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_E4:
						goto IL_109;
						IL_26E:
						num = (short)1200095232;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_286:
					goto IL_70;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2A8;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_295:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)757137409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_350;
						case 2:
						{
							if (disposable == null)
							{
								goto IL_352;
							}
							num = (short)824371206;
							short num3 = num;
							num = (short)1572071430;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_352;
							default:
								num = (short)1438908416;
								if (num != 0)
								{
								}
								num = (short)327680000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_2A8;
					}
					IL_350:
					IL_352:
					goto EndFinally_10;
					IL_2A8:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)876412930;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_295;
					EndFinally_10:;
				}
				goto IL_353;
				IL_70:
				num = (short)883490816;
				short num4 = num;
				global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem> list2 = list;
				global::System.Comparison<global::AcpUI.ImportExport.ImportExportItem> comparison;
				if ((comparison = global::AcpUI.ImportExport.ImportExportManager.<>c.<>9__2_0) != null)
				{
					goto IL_36C;
				}
				IL_353:
				comparison = (global::AcpUI.ImportExport.ImportExportManager.<>c.<>9__2_0 = new global::System.Comparison<global::AcpUI.ImportExport.ImportExportItem>(global::AcpUI.ImportExport.ImportExportManager.<>c.<>9.a));
				IL_36C:
				list2.Sort(comparison);
				return list;
			}
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00060634 File Offset: 0x0005E834
		internal static global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem> a()
		{
			short num = (short)750387201;
			if (num != 0)
			{
			}
			num = (short)360972288;
			short num2 = num;
			global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem> list = new global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem>();
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
			try
			{
				num = (short)1135869958;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						if (!acpRecordset.HiddenStatic)
						{
							num = (short)476184581;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_1CA;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1250164740;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
						num = (short)2002124800;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)560988162;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						list.Add(new global::AcpUI.ImportExport.ImportExportItem(acpRecordset.UIName, acpRecordset.DataTransferOrder));
						num = (short)1419771905;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					}
					IL_F2:
					num = (short)1177723574;
					short num4 = num;
					num = (short)374121142;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_B3:
						goto IL_F2;
					default:
						num = (short)1265238016;
						if (num != 0)
						{
						}
						num = (short)1285554179;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1CA:
				goto IL_62;
			}
			finally
			{
				num = (short)964493314;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)763953153;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_234;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1FF;
						}
						continue;
					}
					IL_1FF:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1115357184;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_234:;
			}
			goto IL_237;
			IL_62:
			global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem> list2 = list;
			global::System.Comparison<global::AcpUI.ImportExport.ImportExportItem> comparison;
			if ((comparison = global::AcpUI.ImportExport.ImportExportManager.<>c.<>9__3_0) != null)
			{
				goto IL_250;
			}
			IL_237:
			comparison = (global::AcpUI.ImportExport.ImportExportManager.<>c.<>9__3_0 = new global::System.Comparison<global::AcpUI.ImportExport.ImportExportItem>(global::AcpUI.ImportExport.ImportExportManager.<>c.<>9.b));
			IL_250:
			list2.Sort(comparison);
			return list;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000608B4 File Offset: 0x0005EAB4
		internal static bool a(global::System.Xml.XmlDocument A_0, global::System.Collections.IList A_1, global::AcpCommonLib.XmlFileType A_2, bool A_3)
		{
			int a_ = 0;
			short num = (short)783155200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_78;
				}
				bool result;
				int num3;
				global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem> list;
				global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> dictionary;
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
				global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> dictionary3;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>.Enumerator enumerator;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_364;
					case 1:
						return result;
					case 2:
					{
						bool flag;
						if (flag)
						{
							num = (short)152698884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 3:
						if (num3 >= A_1.Count)
						{
							num = (short)2145255434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list.Add((global::AcpUI.ImportExport.ImportExportItem)A_1[num3]);
						num3++;
						num = (short)1331560457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)1053229057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						enumerator = dictionary.GetEnumerator();
						num = (short)1709178895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						list.Sort(new global::System.Comparison<global::AcpUI.ImportExport.ImportExportItem>(global::AcpUI.ImportExport.ImportExportManager.<>c.<>9.c));
						global::System.Xml.XmlNode lastChild = A_0.ChildNodes[1].LastChild;
						dictionary.Clear();
						num4 = 0;
						num = (short)1445920781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						try
						{
							num = (short)580059141;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_351;
								case 1:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (!acpRecRefField.HiddenStatic)
									{
										num = (short)1286733831;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpRecRefField.ResetToDefaultWithUndo(containerTask);
									num = (short)808124422;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.ValueSetter(acpRecRefField.Parent, containerTask);
									num = (short)1328087043;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1123090432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1FC;
									}
									continue;
								case 7:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									global::System.Collections.Generic.KeyValuePair<global::AcpCommonLib.IAcpField, string> keyValuePair;
									containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(acpRecRefField, keyValuePair.Value));
									num = (short)2082734088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField.ValueSetter != null)
									{
										num = (short)2132606978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1201733636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::AcpCommonLib.IAcpField, string> keyValuePair = enumerator.Current;
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = keyValuePair.Key as global::AcpBusinessLayer.AcpRecRefField;
									num = (short)1357643777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1FE:
								num = (short)730464265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FC:
								goto IL_1FE;
							}
							IL_351:
							goto IL_7F1;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_3;
						IL_7F1:
						global::AcpCommonLib.AppInfoManager.DndAndImportTask = containerTask;
						global::System.Collections.Generic.Dictionary<string, bool> dictionary2 = new global::System.Collections.Generic.Dictionary<string, bool>();
						dictionary2.Add(global::AcpUI.Common.Utility.c("\udf95풟풣쎥\udaa7쮩\ud8ab잭\udfaf\udcb1\ud9b5햷쪹킻\udbbd뒿ꟁꃃ", a_), true);
						dictionary2.Add(global::AcpUI.Common.Utility.c("\udf95풟쮣횥톧\udcab쮭슯펱삳\udfb5ힷ풹", a_), false);
						global::AcpUI.ImportExport.ImportExportManager.a.PostProcess(containerTask);
						global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask task = new global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask(dictionary2);
						containerTask.AddTask(task);
						global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
						dictionary.Clear();
						dictionary3.Clear();
						global::AcpCommonLib.AppInfoManager.DndAndImportSection.Clear();
						global::AcpCommonLib.AppInfoManager.DndAndImportTask = null;
						bool flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
						num = (short)1973682188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						if (num4 >= list.Count)
						{
							num = (short)465895429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string recsetName = list[num4].RecsetName;
						global::System.Xml.XmlNode lastChild;
						global::System.Collections.IEnumerator enumerator3 = lastChild.ChildNodes.GetEnumerator();
						num = (short)277413888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_169;
					case 10:
						num = (short)1887043590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_169;
					case 12:
						try
						{
							num = (short)788725763;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)136511491;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
												goto IL_A05;
											case 2:
												num = (short)1031536641;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												IL_919:
												switch (0)
												{
												case 0:
													goto IL_93E;
												}
												continue;
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator4;
												if (!enumerator4.MoveNext())
												{
													num = (short)1794179074;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												enumerator4.Current.CleanupDuplicates();
												num = (short)1540423680;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_963:
											num = (short)1378027709;
											short num5 = num;
											num = (short)954665149;
											switch ((num5 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_919;
											default:
												num = (short)1218117632;
												if (num != 0)
												{
												}
												num = (short)2090532868;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_93E:
											goto IL_963;
										}
										IL_A05:;
									}
									finally
									{
										num = (short)511115265;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator4;
											switch (num2)
											{
											case 0:
												goto IL_A70;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_A39;
												}
												continue;
											case 2:
												enumerator4.Dispose();
												num = (short)235601920;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_A39:
											if (enumerator4 == null)
											{
												break;
											}
											num = (short)1747714050;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_A70:;
									}
									break;
								case 1:
									goto IL_ACC;
								case 2:
									num = (short)1289027585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_8CD;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)578420738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator4 = ((global::AcpBusinessLayer.Recordset)enumerator2.Current).RecRefFields.GetEnumerator();
									num = (short)1395392512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_A73:
								num = (short)709296132;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8CD:
								goto IL_A73;
							}
							IL_ACC:
							goto IL_C85;
						}
						finally
						{
							num = (short)182714369;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_B3C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_B03;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)273874944;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B03:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)2105671682;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B3C:;
						}
						goto Block_7;
					case 13:
						goto IL_711;
					case 14:
					{
						num = (short)1971978240;
						short num6 = num;
						num = (short)1268842497;
						if (num != 0)
						{
						}
						goto IL_711;
					}
					case 15:
						goto IL_B3F;
					}
					goto IL_78;
					Block_7:
					try
					{
						IL_B3F:
						num = (short)1976434693;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_C72;
							case 1:
								num = (short)397737984;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
								acpRecRefField2.ValueSetter(acpRecRefField2.Parent, containerTask);
								num = (short)1883504644;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2061238273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::AcpCommonLib.IAcpField, string> keyValuePair2 = enumerator.Current;
								global::AcpBusinessLayer.AcpRecRefField acpRecRefField2 = keyValuePair2.Key as global::AcpBusinessLayer.AcpRecRefField;
								containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(acpRecRefField2, keyValuePair2.Value));
								num = (short)1178009606;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_B81;
								}
								continue;
							case 6:
							{
								global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
								if (acpRecRefField2.ValueSetter != null)
								{
									num = (short)1158610946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_B83:
							num = (short)995950595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B81:
							goto IL_B83;
						}
						IL_C72:
						goto IL_11F;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_C85;
					IL_11F:
					enumerator = dictionary3.GetEnumerator();
					num = (short)701169671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_169:
					num = (short)1648623619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_364:
						num = (short)1533935628;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								string recsetName;
								global::System.Xml.XmlNode xmlNode;
								if (string.Equals(xmlNode.Attributes[global::AcpUI.Common.Utility.c("\ud895聯鍊", a_)].Value, recsetName, global::System.StringComparison.CurrentCulture))
								{
									num = (short)1642856456;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								int id;
								try
								{
									global::System.Xml.XmlAttribute xmlAttribute;
									id = int.Parse(xmlAttribute.Value, global::System.Globalization.CultureInfo.InvariantCulture);
									goto IL_546;
								}
								catch (global::System.ArgumentNullException)
								{
									result = false;
									goto IL_67D;
								}
								catch (global::System.FormatException)
								{
									result = false;
									goto IL_67D;
								}
								catch (global::System.OverflowException)
								{
									result = false;
									goto IL_67D;
								}
								goto IL_5EB;
								IL_546:
								global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(id);
								num = (short)673120265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::AcpCommonLib.IAcpRecordset feature;
								if (!feature.HiddenStatic)
								{
									num = (short)854065158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5EB;
							}
							case 3:
								goto IL_603;
							case 4:
							{
								global::System.Collections.IEnumerator enumerator3;
								if (!enumerator3.MoveNext())
								{
									num = (short)782303242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator3.Current;
								num = (short)1454047232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::AcpCommonLib.IAcpRecordset feature;
								feature.CalculateVisibility(true);
								feature.CalculateEditability(true);
								num = (short)1488060418;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::System.Xml.XmlNode xmlNode;
								global::AcpCommonLib.IAcpRecordset feature;
								feature.ReadFromXml(xmlNode, containerTask, A_2, A_3, dictionary, dictionary3);
								num = (short)1719992331;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_3E5;
							case 8:
							{
								int id = 0;
								global::System.Xml.XmlNode xmlNode;
								global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::AcpUI.Common.Utility.c("\udf95ﲗ", a_)];
								num = (short)270401549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
							{
								global::AcpCommonLib.IAcpRecordset feature;
								if (feature != null)
								{
									num = (short)68288517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.XmlNode xmlNode;
								global::AcpCommonLib.Utility.LogMissingXmlNode(xmlNode);
								num = (short)1763311623;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								goto IL_5EB;
							case 11:
								goto IL_5B6;
							case 12:
								switch (0)
								{
								case 0:
									goto IL_3C3;
								}
								continue;
							case 13:
							{
								global::System.Xml.XmlAttribute xmlAttribute;
								if (xmlAttribute != null)
								{
									num = (short)384368641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5EB;
							}
							}
							IL_3EA:
							num = (short)1263730692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3C3:
							goto IL_3EA;
							IL_5EB:
							num = (short)994902019;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3E5:
						IL_5B6:
						IL_603:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_622;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_60F:
							switch (num2)
							{
							case 0:
								goto IL_67A;
							case 1:
								if (disposable != null)
								{
									num = (short)913965058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_67C;
							case 2:
								disposable.Dispose();
								num = (short)636682240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_622;
						}
						IL_67A:
						IL_67C:
						goto EndFinally_34;
						IL_622:
						global::System.Collections.IEnumerator enumerator3;
						disposable = (enumerator3 as global::System.IDisposable);
						num = (short)738721793;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_60F;
						EndFinally_34:;
					}
					IL_67D:
					num4++;
					num = (short)468647950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_711:
					num = (short)691273736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C85:
					num = (short)368836610;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_78:
				containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.XML_Import);
				global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask task2 = new global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask(new global::System.Collections.Generic.Dictionary<string, bool>
				{
					{
						global::AcpUI.Common.Utility.c("\udf95풟풣쎥\udaa7쮩\ud8ab잭\udfaf\udcb1\ud9b5햷쪹킻\udbbd뒿ꟁꃃ", a_),
						false
					},
					{
						global::AcpUI.Common.Utility.c("\udf95풟쮣횥톧\udcab쮭슯펱삳\udfb5ힷ풹", a_),
						true
					}
				});
				containerTask.AddTask(task2);
				global::System.Collections.IList list2 = new global::System.Collections.Generic.List<object>();
				list2.Add(A_1);
				list2.Add(A_0);
				global::AcpUI.ImportExport.ImportExportManager.a.Data = list2;
				global::AcpUI.ImportExport.ImportExportManager.a.PreProcess(containerTask);
				result = true;
				list = new global::System.Collections.Generic.List<global::AcpUI.ImportExport.ImportExportItem>();
				dictionary = new global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>();
				dictionary3 = new global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>();
				num3 = 0;
				num = (short)334168075;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000616A0 File Offset: 0x0005F8A0
		internal static global::System.Xml.XmlDocument a(global::System.Collections.IList A_0, bool A_1)
		{
			int a_ = 2;
			short num = (short)1647575040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				global::System.Xml.XmlDocument xmlDocument;
				int num4;
				global::System.Xml.XmlElement xmlElement;
				for (;;)
				{
					IL_32:
					num = (short)884473856;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_221;
					case 1:
						return xmlDocument;
					case 2:
					{
						if (num4 >= A_0.Count)
						{
							num = (short)1445068801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1551499265;
						if (num != 0)
						{
						}
						string recsetName = ((global::AcpUI.ImportExport.ImportExportItem)A_0[num4]).RecsetName;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
						num = (short)806551556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_221;
					case 4:
						try
						{
							num = (short)151388171;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpRecordset acpRecordset;
								switch (num2)
								{
								case 0:
									acpRecordset.CalculateVisibility(true);
									num = (short)1057554438;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2E1;
								case 2:
									if (!acpRecordset.HasVisibleObjects)
									{
										num = (short)89915397;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2C1;
								case 3:
									if (acpRecordset.Count == 0)
									{
										num = (short)1826947079;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_434;
								case 4:
									goto IL_44D;
								case 5:
									num = (short)192544771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!acpRecordset.HiddenStatic)
									{
										num = (short)1479737354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_434;
								case 7:
									goto IL_2C1;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1239875593;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpRecordset = enumerator.Current;
									num = (short)629800972;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_434;
								case 10:
									num = (short)236322818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_2BF;
									}
									continue;
								case 12:
								{
									string recsetName;
									if (string.Equals(acpRecordset.UIName, recsetName, global::System.StringComparison.CurrentCulture))
									{
										num = (short)62062592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_2BF;
								IL_2C1:
								acpRecordset.AddToXml(xmlElement, global::AcpCommonLib.XmlFileType.ImpExp);
								num = (short)700121089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2E6:
								num = (short)462553096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2BF:
								goto IL_2E6;
								IL_434:
								num = (short)1332936708;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E1:
							IL_44D:
							goto IL_1A0;
						}
						finally
						{
							num = (short)529465345;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_50F;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_484;
									}
									continue;
								case 2:
								{
									num = (short)211652643;
									short num5 = num;
									num = (short)90869795;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)202440704;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1408958464;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_484:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1683685378;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_50F:;
						}
						return xmlDocument;
						IL_1A0:
						num4++;
						num = (short)1363148800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_76;
					IL_221:
					num = (short)62062594;
					num2 = (int)((global::System.IntPtr)num);
				}
				return xmlDocument;
				IL_76:
				xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration(global::AcpUI.Common.Utility.c("ꦗ뒙겛", a_), global::AcpUI.Common.Utility.c("춗캙\uda9b뎝颟", a_), null));
				global::System.Xml.XmlElement xmlElement2 = xmlDocument.CreateElement(global::AcpUI.Common.Utility.c("튟횡ﮣ쎥킧\udaa9쎫\udcad쒯킳\ud9b5\udbb7", a_));
				xmlDocument.AppendChild(xmlElement2);
				global::System.Xml.XmlElement xmlElement3 = xmlDocument.CreateElement(global::AcpUI.Common.Utility.c("캗ﾙ즟춡쪣", a_));
				xmlElement3.InnerText = global::AcpUI.Common.Utility.c("ꪗ", a_);
				xmlElement2.AppendChild(xmlElement3);
				global::System.Xml.XmlElement xmlElement4 = xmlDocument.CreateElement(global::AcpUI.Common.Utility.c("풗ﮙ劣햟쎡쎣쎥", a_));
				xmlElement4.InnerText = global::System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
				xmlElement2.AppendChild(xmlElement4);
				xmlElement = xmlDocument.CreateElement(global::AcpUI.Common.Utility.c("쪗", a_));
				xmlElement.SetAttribute(global::AcpUI.Common.Utility.c("\udd97튟횡솣슥용삫햯펱삳쎵쪷\udfb9쾻", a_), A_1.ToString());
				xmlElement.SetAttribute(global::AcpUI.Common.Utility.c("\udb97얟킡킣쎥\udaa7즫삭햯삱햳습\uddb7\udeb9", a_), global::AcpUI.Common.Utility.c("\ude97ﮙ얟", a_));
				xmlElement2.AppendChild(xmlElement);
				num4 = 0;
				num = (short)580059139;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x040002BB RID: 699
		private static global::AcpCommonLib.IAcpBatchOperation a;
	}
}
