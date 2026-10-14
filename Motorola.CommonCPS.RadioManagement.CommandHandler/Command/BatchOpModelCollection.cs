using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000070 RID: 112
	public class BatchOpModelCollection
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0002F130 File Offset: 0x0002D330
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.TasksContext Instance
		{
			get
			{
				short num = (short)1046151168;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					object obj = global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.a;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						for (;;)
						{
							IL_31:
							switch (num2)
							{
							case 0:
							{
								global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.b = new global::Motorola.CommonCPS.RadioManagement.UIModels.TasksContext();
								global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>();
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance.BatchOpList.ToList<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>().GetEnumerator();
								num = (short)1743388675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_244;
							case 2:
								goto IL_22B;
							case 3:
							{
								global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection;
								try
								{
									num = (short)85131270;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>.Enumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)616300545;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp = enumerator.Current;
											num = (short)1785004034;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											num = (short)1210253315;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
										{
											global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp;
											if (batchOp.IsVisible)
											{
												num = (short)39190532;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 3:
											goto IL_218;
										case 4:
										{
											global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp;
											global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer item = global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.a(batchOp);
											observableCollection.Insert(0, item);
											num = (short)358744069;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
											switch (0)
											{
											case 0:
												goto IL_151;
											}
											continue;
										}
										IL_153:
										num = (short)486866944;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_151:
										goto IL_153;
									}
									IL_218:
									goto IL_CB;
								}
								finally
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>.Enumerator enumerator;
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_22B;
								IL_CB:
								global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.b.JobContainers = observableCollection;
								global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance.BatchOpList.CollectionChanged += global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.a;
								num = (short)1981022210;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								if (global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.b == null)
								{
									num = (short)1351024640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_22B;
							}
							goto IL_4C;
							IL_22B:
							num = (short)1977745409;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_244:
						goto IL_302;
						IL_4C:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)87490564;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_31;
					}
					finally
					{
						num = (short)1119485954;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2FF;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1675821056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_27B;
								}
								continue;
							}
							IL_27B:
							num = (short)483177996;
							short num3 = num;
							num = (short)1844688396;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)34013184;
								if (num != 0)
								{
								}
								if (!flag)
								{
									goto IL_301;
								}
								break;
							}
							num = (short)2027487233;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2FF:
						IL_301:;
					}
					IL_302:
					num = (short)1013841921;
					if (num != 0)
					{
					}
					num = (short)1767243776;
					short num4 = num;
					return global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.b;
				}
				}
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0002F4CC File Offset: 0x0002D6CC
		private static void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)17694720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)542507013;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_7A;
					case 1:
						goto IL_A0;
					case 2:
					{
						num = (short)1341789860;
						short num3 = num;
						num = (short)1601967780;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7A;
						default:
							num = (short)419495936;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1573257222;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp;
										if (batchOp.IsVisible)
										{
											num = (short)684457989;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)221577220;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp = (global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp)enumerator.Current;
										num = (short)118620161;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_21A;
									case 4:
										num = (short)883556355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp;
										global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer item2 = global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.a(batchOp);
										global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.b.JobContainers.Insert(0, item2);
										num = (short)1181089792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_152;
										}
										continue;
									}
									IL_1C8:
									num = (short)1239220226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_152:
									goto IL_1C8;
								}
								IL_21A:
								return;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_23C;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_229:
									switch (num2)
									{
									case 0:
										goto IL_291;
									case 1:
										disposable.Dispose();
										num = (short)1164640256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										if (disposable != null)
										{
											num = (short)1229651969;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_293;
									}
									goto IL_23C;
								}
								IL_291:
								IL_293:
								goto EndFinally_14;
								IL_23C:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1298661378;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_229;
								EndFinally_14:;
							}
							goto IL_294;
						}
						break;
					}
					case 3:
						enumerator = A_1.OldItems.GetEnumerator();
						num = (short)2069823489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_1.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
						{
							num = (short)76546051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					}
					IL_5C:
					if (A_1.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num = (short)1528954880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)542900228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_294:
					num = (short)1685192704;
					short num4 = num;
					enumerator = A_1.NewItems.GetEnumerator();
					num = (short)507314178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A:
					goto IL_294;
				}
				IL_A0:
				num = (short)747241473;
				if (num != 0)
				{
				}
				try
				{
					num = (short)680067074;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1315897349;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp item = (global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp)enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer = global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.b.JobContainers.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer rc)
							{
								switch (0)
								{
								case 0:
									goto IL_20;
								}
								global::System.Guid? id;
								short num6;
								for (;;)
								{
									IL_0A:
									int num5;
									switch (num5)
									{
									case 0:
										if (id == null)
										{
											num6 = (short)932511747;
											num5 = (int)((global::System.IntPtr)num6);
											continue;
										}
										num6 = (short)1278476289;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									case 1:
										goto IL_F7;
									case 2:
										return true;
									case 3:
										goto IL_DB;
									}
									goto IL_20;
								}
								IL_DB:
								num6 = (short)1095041024;
								short num7 = num6;
								return false;
								IL_20:
								num6 = (short)1233584129;
								if (num6 != 0)
								{
								}
								id = rc.ID;
								global::System.Guid id2 = item.ID;
								num6 = (short)648266556;
								short num8 = num6;
								num6 = (short)781435708;
								switch ((num8 == num6) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_F7:
									if (id == null)
									{
										num6 = (short)885587970;
										int num5 = (int)((global::System.IntPtr)num6);
										goto IL_0A;
									}
									return id.GetValueOrDefault() == id2;
								default:
								{
									num6 = (short)1709768704;
									if (num6 != 0)
									{
									}
									num6 = (short)156565504;
									int num5 = (int)((global::System.IntPtr)num6);
									goto IL_0A;
								}
								}
							}).FirstOrDefault<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>();
							num = (short)1334968326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_471;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_378;
							}
							continue;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
							global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.b.JobContainers.Remove(jobContainer);
							num = (short)82837507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1803616257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
							if (jobContainer != null)
							{
								num = (short)1123024900;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_37A:
						num = (short)1894973440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_378:
						goto IL_37A;
					}
					IL_471:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_490;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_47D:
						switch (num2)
						{
						case 0:
							goto IL_4E4;
						case 1:
							if (disposable != null)
							{
								num = (short)267190274;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4E6;
						case 2:
							disposable.Dispose();
							num = (short)402063360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_490;
					}
					IL_4E4:
					IL_4E6:
					goto EndFinally_13;
					IL_490:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)755826689;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_47D;
					EndFinally_13:;
				}
				return;
			}
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0002F9F4 File Offset: 0x0002DBF4
		private static global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer a(global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp A_0)
		{
			short num = (short)808976384;
			short num2 = num;
			num = (short)237443766;
			short num3 = num;
			num = (short)406788790;
			switch (num3 == num)
			{
			}
			num = (short)72155136;
			if (num != 0)
			{
			}
			num = (short)819200001;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer uiModel = new global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer();
			uiModel.ID = new global::System.Guid?(A_0.ID);
			uiModel.Type = A_0.Type;
			uiModel.Status = A_0.Status;
			uiModel.ContainerName = A_0.JobName;
			uiModel.ItemsCompleted = A_0.CurrentItemIndex;
			uiModel.TotalCount = A_0.TotalItemCount;
			uiModel.CreatedTime = A_0.CreatedTime;
			A_0.ProgressChanged += delegate(object sender, global::System.ComponentModel.ProgressChangedEventArgs e)
			{
				short num4 = (short)627179520;
				short num5 = num4;
				num4 = (short)1410749294;
				short num6 = num4;
				num4 = (short)1468683118;
				switch (num6 == num4)
				{
				}
				num4 = (short)470745089;
				if (num4 != 0)
				{
				}
				num4 = (short)1427177472;
				if (num4 != 0)
				{
				}
				uiModel.ProgressPercentage = e.ProgressPercentage;
				uiModel.Comments = ((e.UserState != null) ? e.UserState.ToString() : string.Empty);
				uiModel.ItemsCompleted = ((global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp)sender).CurrentItemIndex;
				uiModel.Status = ((global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp)sender).Status;
			};
			A_0.RunWorkerCompleted += delegate(object sender, global::System.ComponentModel.RunWorkerCompletedEventArgs e)
			{
				int a_ = 2;
				short num4 = (short)342753280;
				int num5 = (int)num4;
				switch (num5)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					for (;;)
					{
						IL_32:
						string text;
						string text2;
						switch (num5)
						{
						case 0:
							num4 = (short)1820983299;
							num5 = (int)((global::System.IntPtr)num4);
							continue;
						case 1:
							num4 = (short)363659273;
							num5 = (int)((global::System.IntPtr)num4);
							continue;
						case 2:
							if (string.IsNullOrEmpty(text))
							{
								num4 = (short)1975451668;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							goto IL_16A;
						case 3:
						{
							global::Motorola.Common.CustomException.CommonException ex;
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
							{
								num4 = (short)970784790;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							goto IL_25C;
						}
						case 4:
						{
							global::Motorola.Common.CustomException.CommonException ex;
							if (ex != null)
							{
								num4 = (short)1851785216;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							num4 = (short)116025959;
							short num6 = num4;
							num4 = (short)1277717095;
							switch ((num6 == num4) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_33F;
							default:
							{
								num4 = (short)2038104064;
								short num7 = num4;
								num4 = (short)1664024576;
								if (num4 != 0)
								{
								}
								global::System.Exception ex2 = ex2.InnerException;
								num4 = (short)195166227;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							}
							break;
						}
						case 5:
							goto IL_458;
						case 6:
							if (uiModel.Status == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.FAILED)
							{
								num4 = (short)225968136;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							return;
						case 7:
							goto IL_458;
						case 8:
							try
							{
								global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>().GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActivateDockedPaneRequestedEvent>().Publish(global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames.TaskView);
								return;
							}
							catch
							{
								return;
							}
							goto IL_16A;
						case 9:
						{
							global::Motorola.Common.CustomException.CommonException ex;
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg)
							{
								num4 = (short)149487632;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							goto IL_25C;
						}
						case 10:
							goto IL_16A;
						case 11:
						{
							global::Motorola.Common.CustomException.CommonException ex;
							text2 = ex.Message;
							goto IL_43D;
						}
						case 12:
							goto IL_344;
						case 13:
							if (e.Error != null)
							{
								num4 = (short)1534197774;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							goto IL_344;
						case 14:
						{
							uiModel.Comments = e.Error.ToString();
							global::Motorola.Common.CustomException.CommonException ex = null;
							text = null;
							global::System.Exception ex2 = e.Error;
							num4 = (short)812056591;
							num5 = (int)((global::System.IntPtr)num4);
							continue;
						}
						case 15:
							goto IL_27F;
						case 16:
							num4 = (short)885391377;
							num5 = (int)((global::System.IntPtr)num4);
							continue;
						case 17:
						{
							global::Motorola.Common.CustomException.CommonException ex;
							text2 = string.Concat(new string[]
							{
								global::Motorola.CommonCPS.ResourceRepository.Resources.Left_Square_Brackets,
								global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("탲", a_),
								((int)ex.ErrorCode).ToString(),
								global::Motorola.CommonCPS.ResourceRepository.Resources.Right_Square_Brackets,
								global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null)
							});
							goto IL_43D;
						}
						case 18:
						{
							global::System.Exception ex2;
							if (ex2 == null)
							{
								num4 = (short)720633861;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							global::Motorola.Common.CustomException.CommonException ex = ex2 as global::Motorola.Common.CustomException.CommonException;
							num4 = (short)1749549057;
							if (num4 != 0)
							{
							}
							num4 = (short)1839464452;
							num5 = (int)((global::System.IntPtr)num4);
							continue;
						}
						case 19:
							goto IL_27F;
						case 20:
							text = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null);
							num4 = (short)1677066250;
							num5 = (int)((global::System.IntPtr)num4);
							continue;
						case 21:
						{
							global::Motorola.Common.CustomException.CommonException ex;
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
							{
								num4 = (short)151519233;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							goto IL_25C;
						}
						case 22:
							goto IL_33F;
						}
						goto IL_95;
						IL_16A:
						uiModel.UnhandledExceptionMsg = text;
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꇲ룴듶꛸럺鋼飾昀昂眄", a_)).Error(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뇲铴菶髸鏺닼迾℀瘂欄漆栈攊椌挎琐眒㔔爖愘砚砜漞唠䨢䨤䤦ጨପ", a_) + uiModel.ContainerName + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("鱗", a_) + e.Error.ToString());
						num4 = (short)736231436;
						num5 = (int)((global::System.IntPtr)num4);
						continue;
						IL_25C:
						num4 = (short)2018443275;
						num5 = (int)((global::System.IntPtr)num4);
						continue;
						IL_27F:
						num4 = (short)1358037010;
						num5 = (int)((global::System.IntPtr)num4);
						continue;
						IL_33F:
						num4 = (short)1862860821;
						num5 = (int)((global::System.IntPtr)num4);
						continue;
						IL_344:
						num4 = (short)1158676486;
						num5 = (int)((global::System.IntPtr)num4);
						continue;
						IL_43D:
						text = text2;
						num4 = (short)706740231;
						num5 = (int)((global::System.IntPtr)num4);
						continue;
						IL_458:
						num4 = (short)599785474;
						num5 = (int)((global::System.IntPtr)num4);
					}
					return;
					IL_95:
					uiModel.UnhandledExceptionMsg = null;
					uiModel.Status = A_0.Status;
					uiModel.ItemsCompleted = ((global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp)sender).CurrentItemIndex;
					uiModel.TotalCount = global::System.Math.Max(uiModel.TotalCount, ((global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp)sender).CurrentItemIndex);
					uiModel.InitializationError = A_0.InitializationError;
					num4 = (short)1339621389;
					num5 = (int)((global::System.IntPtr)num4);
					goto IL_32;
				}
			};
			return uiModel;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0002FBA0 File Offset: 0x0002DDA0
		// Note: this type is marked as 'beforefieldinit'.
		static BatchOpModelCollection()
		{
			short num = (short)785383424;
			short num2 = num;
			num = (short)1409653617;
			short num3 = num;
			num = (short)1371642737;
			switch (num3 == num)
			{
			}
			num = (short)1328349185;
			if (num != 0)
			{
			}
			num = (short)909967360;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.a = new object();
		}

		// Token: 0x04000083 RID: 131
		private static object a;

		// Token: 0x04000084 RID: 132
		private static global::Motorola.CommonCPS.RadioManagement.UIModels.TasksContext b;
	}
}
