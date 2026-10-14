using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000B4 RID: 180
	internal class FilterCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x000407A8 File Offset: 0x0003E9A8
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 16;
			short num = (short)732561408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				string searchString;
				string viewInfo;
				global::System.Predicate<object> <>9__0;
				for (;;)
				{
					IL_30:
					object obj;
					global::System.Collections.Generic.List<global::System.ComponentModel.ICollectionView> list;
					switch (num2)
					{
					case 0:
						goto IL_3A4;
					case 1:
						if (obj is global::System.ComponentModel.ICollectionView)
						{
							num = (short)1596325890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)767688708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						list = new global::System.Collections.Generic.List<global::System.ComponentModel.ICollectionView>();
						num = (short)1219887121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (paras.Length >= 3)
						{
							num = (short)1253048330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					case 4:
						if (obj is global::Infragistics.Windows.DataPresenter.RecordCollectionBase)
						{
							num = (short)1958871059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2080243719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (obj != null)
						{
							num = (short)95682566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B40;
					case 6:
						num = (short)1989214209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (obj is global::Infragistics.Windows.DataPresenter.DataRecord)
						{
							num = (short)2081292306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_298;
					case 8:
						if (paras[0] is string)
						{
							num = (short)495910928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_212;
					case 9:
						goto IL_90D;
					case 10:
						viewInfo = (string)paras[2];
						num = (short)373030925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_212;
					case 12:
						if (paras.Length >= 2)
						{
							num = (short)1277034511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B40;
					case 13:
						goto IL_E0;
					case 14:
					{
						global::System.ComponentModel.ICollectionView item = obj as global::System.ComponentModel.ICollectionView;
						list.Add(item);
						num = (short)504365056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)284753928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_AA8;
					case 17:
						if ((obj as global::System.ComponentModel.ICollectionView).SourceCollection == null)
						{
							num = (short)1307181070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A4;
					case 18:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_168;
							}
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
							for (;;)
							{
								IL_151:
								switch (num2)
								{
								case 0:
									if (!global::Motorola.CommonCPS.RadioManagement.Command.Filters.Filter(dataRecord.DataItem, searchString, viewInfo))
									{
										num = (short)616235011;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DA;
								case 1:
									goto IL_1DA;
								case 2:
									goto IL_1F2;
								case 3:
									dataRecord.Visibility = global::System.Windows.Visibility.Collapsed;
									num = (short)126681089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_168;
								IL_1DA:
								num = (short)1877213186;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1F2:
							goto IL_256;
							IL_168:
							dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)obj;
							num = (short)23396352;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_151;
						}
						catch (global::System.Exception e)
						{
							global::Motorola.CommonCPS.RadioManagement.Command.CommandBase.Logger.Error(e, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䐀焂眄栆笈⬊戌氎爐昒朔爖紘㬚琜焞Ġ倢䀤䘦嬨䠪䔬༮尰嘲䄴弶嘸强ᴼ嬾㑀ㅂⱄ⥆⹈歊ⱌ㽎⅐㽒ⱔ㹖㝘㱚絜㥞ࡠརᅤɦ᭨䭪ᥬn兰ᱲ᭴ቶ奸ॺ᡼᱾", a_));
							goto IL_256;
						}
						goto IL_212;
					case 19:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_42F;
							}
							global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase;
							for (;;)
							{
								IL_414:
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_8E7;
								case 1:
									if (string.IsNullOrWhiteSpace(searchString))
									{
										num = (short)2060517380;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)recordCollectionBase).GetEnumerator();
									num = (short)1916796930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									try
									{
										num = (short)270073862;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
											{
												global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
												if (global::Motorola.CommonCPS.RadioManagement.Command.Filters.Filter(dataRecord2.DataItem, searchString, viewInfo))
												{
													num = (short)1900675081;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												dataRecord2.Visibility = global::System.Windows.Visibility.Collapsed;
												dataRecord2.IsSelected = false;
												num = (short)1805713413;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::Infragistics.Windows.DataPresenter.Record record;
												if (record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord)
												{
													num = (short)924975111;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												goto IL_80E;
											case 4:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)230948872;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Infragistics.Windows.DataPresenter.Record record = enumerator.Current;
												num = (short)2100297730;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												switch (0)
												{
												case 0:
													goto IL_6CA;
												}
												continue;
											case 7:
											{
												global::Infragistics.Windows.DataPresenter.Record record;
												global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = (global::Infragistics.Windows.DataPresenter.DataRecord)record;
												num = (short)403767297;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
												num = (short)136445955;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
												dataRecord2.Visibility = global::System.Windows.Visibility.Visible;
												num = (short)587071488;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_749:
											num = (short)2134966276;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_6CA:
											goto IL_749;
										}
										IL_80E:;
									}
									finally
									{
										num = (short)1539899394;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												num = (short)1099925696;
												short num3 = num;
												num = (short)348489920;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													continue;
												default:
													goto IL_8B6;
												}
												break;
											}
											case 1:
												enumerator.Dispose();
												num = (short)2073100288;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_845;
												}
												continue;
											}
											IL_845:
											if (enumerator == null)
											{
												goto IL_8CE;
											}
											num = (short)1786707969;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_8B6:
										num = (short)195493888;
										if (num != 0)
										{
										}
										IL_8CE:;
									}
									goto IL_8CF;
								case 3:
									try
									{
										num = (short)183894021;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1203830786;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												global::Infragistics.Windows.DataPresenter.Record record2;
												record2.Visibility = global::System.Windows.Visibility.Visible;
												num = (short)811663364;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_5BC;
											case 3:
												num = (short)1978859527;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												switch (0)
												{
												case 0:
													goto IL_4C0;
												}
												continue;
											case 6:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1461321728;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Infragistics.Windows.DataPresenter.Record record2 = enumerator.Current;
												num = (short)150208520;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::Infragistics.Windows.DataPresenter.Record record2;
												if (record2.Visibility != global::System.Windows.Visibility.Visible)
												{
													num = (short)728825857;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
											{
												global::Infragistics.Windows.DataPresenter.Record record2;
												if (record2 != null)
												{
													num = (short)493944835;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_565:
											num = (short)1485897734;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4C0:
											goto IL_565;
										}
										IL_5BC:
										goto IL_8CF;
									}
									finally
									{
										num = (short)1024720898;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_62C;
											case 1:
												enumerator.Dispose();
												num = (short)1738932224;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_5F4;
												}
												continue;
											}
											IL_5F4:
											if (enumerator == null)
											{
												break;
											}
											num = (short)55050241;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_62C:;
									}
									goto IL_62F;
								case 4:
									goto IL_62F;
								}
								goto IL_42F;
								IL_62F:
								enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)recordCollectionBase).GetEnumerator();
								num = (short)2036072451;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8CF:
								num = (short)7536640;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8E7:
							goto IL_254;
							IL_42F:
							recordCollectionBase = (global::Infragistics.Windows.DataPresenter.RecordCollectionBase)obj;
							num = (short)346619905;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_414;
						}
						catch (global::System.Exception e2)
						{
							global::Motorola.CommonCPS.RadioManagement.Command.CommandBase.Logger.Error(e2, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䐀焂眄栆笈⬊戌氎爐昒朔爖紘㬚琜焞Ġ倢䀤䘦嬨䠪䔬༮尰嘲䄴弶嘸强", a_));
							goto IL_254;
						}
						goto Block_10;
					}
					goto IL_87;
					IL_E0:
					num = (short)1642332160;
					short num4 = num;
					num = (short)1205272581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_212:
					obj = paras[1];
					num = (short)1983447043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A4:
					global::System.Collections.Generic.List<global::System.ComponentModel.ICollectionView>.Enumerator enumerator2 = list.GetEnumerator();
					num = (short)941031433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA8:
					num = (short)1350828033;
					if (num != 0)
					{
					}
					searchString = string.Copy(paras[0] as string);
					num = (short)995491851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_10:
					try
					{
						IL_90D:
						num = (short)910950405;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.ComponentModel.ICollectionView collectionView;
								(collectionView as global::System.Windows.Data.ListCollectionView).CommitEdit();
								collectionView.Filter = null;
								num = (short)314769409;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_A95;
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1240858631;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.ComponentModel.ICollectionView collectionView = enumerator2.Current;
								num = (short)1311440902;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::System.ComponentModel.ICollectionView collectionView;
								global::System.ComponentModel.ICollectionView collectionView2 = collectionView;
								global::System.Predicate<object> filter;
								if ((filter = <>9__0) == null)
								{
									filter = (<>9__0 = delegate(object o)
									{
										short num5 = (short)305860129;
										short num6 = num5;
										num5 = (short)784666145;
										switch (num6 == num5)
										{
										}
										num5 = (short)1171128321;
										if (num5 != 0)
										{
										}
										num5 = (short)1682571264;
										if (num5 != 0)
										{
										}
										num5 = (short)51511296;
										short num7 = num5;
										return global::Motorola.CommonCPS.RadioManagement.Command.Filters.Filter(o, searchString, viewInfo);
									});
								}
								collectionView2.Filter = filter;
								num = (short)917372936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_958;
								}
								continue;
							case 6:
							{
								if (string.IsNullOrWhiteSpace(searchString))
								{
									num = (short)1878261760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.ComponentModel.ICollectionView collectionView;
								(collectionView as global::System.Windows.Data.ListCollectionView).CommitEdit();
								num = (short)2083258372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								num = (short)128581634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_9C3:
							num = (short)375324675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_958:
							goto IL_9C3;
						}
						IL_A95:
						break;
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto IL_AA8;
				}
				return null;
				IL_254:
				return null;
				IL_256:
				return null;
				IL_298:
				throw new global::System.NotSupportedException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("伀氂焄✆稈縊紌缎縐愒愔㜖稘琚焜猞䐠䀢儤並䘨䔪ബ嬮䠰䌲倴᜶倸䠺ܼ", a_) + global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext.GetType().FullName);
				IL_B40:
				return null;
				IL_87:
				searchString = string.Empty;
				viewInfo = null;
				num = (short)1029046284;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
