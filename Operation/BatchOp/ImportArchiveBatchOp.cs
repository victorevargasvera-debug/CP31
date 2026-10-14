using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200004E RID: 78
	public class ImportArchiveBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x0002D2B4 File Offset: 0x0002B4B4
		public ImportArchiveBatchOp(global::System.Collections.Generic.IList<string> filePath, global::System.Guid? groupID, global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption? overwriteOption, global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> readPassWordDictionary, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption importOp)
		{
			base.SelectedItems = filePath;
			this.b = groupID;
			this.c = overwriteOption;
			this.d = readPassWordDictionary;
			this.a = importOp;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0002D2EC File Offset: 0x0002B4EC
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)735847399;
				short num2 = num;
				num = (short)1838293991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727252992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211498496;
				if (num != 0)
				{
				}
				num = (short)1691222017;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportArchive;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0002D398 File Offset: 0x0002B598
		public override string JobName
		{
			get
			{
				short num = (short)1668397919;
				short num2 = num;
				num = (short)956545887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1533345792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)959840257;
				if (num != 0)
				{
				}
				num = (short)1290797056;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.ImportRadioJobName;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0002D444 File Offset: 0x0002B644
		private global::System.Guid? GroupID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1945436161;
				if (num != 0)
				{
				}
				num = (short)430505984;
				short num2 = num;
				num = (short)1172407224;
				short num3 = num;
				num = (short)1285784504;
				switch (num3 == num)
				{
				}
				num = (short)1768685568;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		private global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption? OverwriteOption
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)875774794;
				short num2 = num;
				num = (short)1745306442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)149684224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1361772545;
				if (num != 0)
				{
				}
				num = (short)422707200;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> ReadPassWordDictionary
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1273693443;
				short num2 = num;
				num = (short)1648100611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301217280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760283137;
				if (num != 0)
				{
				}
				num = (short)20709376;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0002D65C File Offset: 0x0002B85C
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 6;
			short num = (short)637009920;
			switch (num)
			{
			default:
			{
				num = (short)2072772608;
				short num2 = num;
				num = (short)854917121;
				if (num != 0)
				{
				}
				int num3 = 0;
				bool flag = false;
				global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)340525056;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer10;
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_CB;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1871446021;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = enumerator.Current;
							num = (short)88735750;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							try
							{
								num = (short)703922177;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
									global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
									switch (num4)
									{
									case 0:
										num = (short)24969218;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1AC;
										}
										continue;
									case 2:
										goto IL_1613;
									case 3:
										automaticPerformanceMeasurer = automaticPerformanceMeasurer2.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportArchive, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("駊꣌뿎뻐ꇒꇔ뻖럘볚﷜连鏠賢苤闦賨飪黬", a_)));
										goto IL_15DF;
									case 4:
										try
										{
											num = (short)1067319311;
											num4 = (int)((global::System.IntPtr)num);
											string text;
											for (;;)
											{
												global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
												global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer5;
												global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer6;
												string warningMsg;
												global::System.Collections.Generic.Dictionary<int, int> optionCount;
												global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer9;
												switch (num4)
												{
												case 0:
													automaticPerformanceMeasurer3 = automaticPerformanceMeasurer2.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportArchive, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯊곌뷎ꋐ뫒믔냖律髚꿜볞觠諢鏤苦", a_)));
													goto IL_1184;
												case 1:
													try
													{
														switch (0)
														{
														case 0:
															goto IL_64B;
														}
														global::System.Collections.Generic.Dictionary<string, string> errorList;
														for (;;)
														{
															IL_638:
															switch (num4)
															{
															case 0:
																goto IL_694;
															case 1:
																goto IL_6B7;
															case 2:
															{
																global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
																if (!base.ValidationServiceFactory.UIValidateService.ValidateAllRadioFields(radio, errorList))
																{
																	num = (short)502726656;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																num = (short)989921281;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															}
															}
															goto IL_64B;
														}
														IL_694:
														throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_InvalidDevice_Error);
														IL_6B7:
														goto IL_805;
														IL_64B:
														errorList = new global::System.Collections.Generic.Dictionary<string, string>();
														num = (short)237174786;
														num4 = (int)((global::System.IntPtr)num);
														goto IL_638;
													}
													finally
													{
														num = (short)963117058;
														num4 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num4)
															{
															case 0:
																automaticPerformanceMeasurer4.Dispose();
																num = (short)13893633;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																goto IL_726;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_6EE;
																}
																continue;
															}
															IL_6EE:
															if (automaticPerformanceMeasurer4 == null)
															{
																break;
															}
															num = (short)2092433408;
															num4 = (int)((global::System.IntPtr)num);
														}
														IL_726:;
													}
													goto IL_729;
												case 2:
													automaticPerformanceMeasurer3 = null;
													goto IL_1184;
												case 3:
													goto IL_1248;
												case 4:
													if (automaticPerformanceMeasurer2 == null)
													{
														num = (short)94765061;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)871694336;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 5:
													num = (short)850132994;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
												{
													global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
													if (radio.WorkingCodeplug.Configuration == null)
													{
														num = (short)1386610719;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_317;
												}
												case 7:
													automaticPerformanceMeasurer5 = automaticPerformanceMeasurer2.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportArchive, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鷊곌ꏎ룐럒듔ꏖ볘ﯚ黜뻞迠쏢곤諦駨蓪鿬鯮", a_)));
													goto IL_1164;
												case 8:
													if (this.a != global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.ConfigurationOnly)
													{
														num = (short)1021181969;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_842;
												case 9:
													automaticPerformanceMeasurer6 = automaticPerformanceMeasurer2.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportArchive, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鷊곌ꏎ룐럒듔ꏖ볘ﯚ꿜뻞藠諢諤쟦迨苪裬菮闰胲", a_)));
													goto IL_50C;
												case 10:
													if (automaticPerformanceMeasurer2 == null)
													{
														num = (short)726466582;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)319553564;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 11:
												{
													global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
													if (radio != null)
													{
														num = (short)1215299620;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_317;
												}
												case 12:
												{
													global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
													if (!string.Equals(radio.DeviceID, radio.SerialNumber))
													{
														num = (short)1761673237;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_1248;
												}
												case 13:
													try
													{
														num = (short)1948516356;
														num4 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num4)
															{
															case 0:
															{
																global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator2;
																if (!enumerator2.MoveNext())
																{
																	goto IL_1074;
																}
																global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword filePassword = enumerator2.Current;
																num = (short)2062286851;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 2:
															{
																num = (short)162719515;
																short num5 = num;
																num = (short)1229776667;
																switch ((num5 == num) ? 1 : 0)
																{
																case 0:
																case 2:
																	goto IL_1074;
																default:
																	goto IL_10DB;
																}
																break;
															}
															case 3:
															{
																global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword filePassword;
																if (global::System.IO.Path.GetFileNameWithoutExtension(text) == filePassword.FileName)
																{
																	num = (short)1885536262;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																break;
															}
															case 4:
																switch (0)
																{
																case 0:
																	goto IL_FE0;
																}
																continue;
															case 5:
																num = (short)77201410;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 6:
															{
																global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword filePassword;
																string password = filePassword.Password;
																num = (short)1663107073;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															}
															}
															IL_104F:
															num = (short)1915486208;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_FE0:
															goto IL_104F;
															IL_1074:
															num = (short)1033437189;
															num4 = (int)((global::System.IntPtr)num);
														}
														IL_10DB:
														num = (short)1444872192;
														if (num != 0)
														{
														}
														goto IL_11E0;
													}
													finally
													{
														num = (short)1002045440;
														num4 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator2;
															switch (num4)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_1127;
																}
																continue;
															case 1:
																goto IL_1161;
															case 2:
																enumerator2.Dispose();
																num = (short)127336449;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_1127:
															if (enumerator2 == null)
															{
																break;
															}
															num = (short)45350914;
															num4 = (int)((global::System.IntPtr)num);
														}
														IL_1161:;
													}
													goto IL_1164;
												case 14:
													if (automaticPerformanceMeasurer2 == null)
													{
														num = (short)112132130;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_729;
												case 15:
													switch (0)
													{
													case 0:
														goto IL_2C3;
													}
													continue;
												case 16:
												{
													global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator2 = this.ReadPassWordDictionary.GetEnumerator();
													num = (short)1969553421;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 17:
													num = (short)1698037770;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 18:
												{
													global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
													if (radio == null)
													{
														num = (short)1532166163;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1825177611;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 19:
													goto IL_4CD;
												case 20:
													goto IL_133B;
												case 21:
												{
													global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
													radio.DeviceID = radio.SerialNumber;
													num = (short)1028653059;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 22:
													num = (short)1196032027;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 23:
													try
													{
														switch (0)
														{
														case 0:
															goto IL_959;
														}
														global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption? overwriteOption;
														for (;;)
														{
															IL_8EE:
															global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer7;
															global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption op;
															bool isOverwirted;
															global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer8;
															switch (num4)
															{
															case 0:
																goto IL_A95;
															case 1:
																goto IL_B70;
															case 2:
															{
																global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
																radio.DeviceID = radio.SerialNumber;
																num = (short)1635778577;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 3:
																automaticPerformanceMeasurer7 = null;
																goto IL_A76;
															case 4:
																if (automaticPerformanceMeasurer2 == null)
																{
																	num = (short)2061434898;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																num = (short)1577910293;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 5:
																goto IL_A95;
															case 6:
															{
																overwriteOption = this.OverwriteOption;
																global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption overwriteOption2 = global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_Never;
																num = (short)1448149005;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 7:
																goto IL_F3C;
															case 8:
															{
																global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
																if (!string.Equals(radio.DeviceID, radio.SerialNumber))
																{
																	num = (short)1340014594;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_ADB;
															}
															case 9:
															{
																global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult overrideResult;
																if (overrideResult == global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.NeverOverrideAndCreateConfig)
																{
																	num = (short)1004994583;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_B70;
															}
															case 10:
																automaticPerformanceMeasurer7 = automaticPerformanceMeasurer2.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportArchive, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("藊ꋌ믎룐뗒곔还닚룜꣞", a_)));
																goto IL_A76;
															case 11:
																try
																{
																	switch (0)
																	{
																	case 0:
																		goto IL_C2C;
																	}
																	global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item;
																	for (;;)
																	{
																		IL_C09:
																		switch (num4)
																		{
																		case 0:
																			base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
																			{
																				item
																			});
																			num = (short)274857989;
																			num4 = (int)((global::System.IntPtr)num);
																			continue;
																		case 1:
																		{
																			global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult overrideResult;
																			if (overrideResult == global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.NeverOverride)
																			{
																				num = (short)1610481664;
																				num4 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			goto IL_D05;
																		}
																		case 2:
																			goto IL_D1E;
																		case 3:
																			base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
																			{
																				item
																			});
																			num = (short)1974403078;
																			num4 = (int)((global::System.IntPtr)num);
																			continue;
																		case 4:
																		{
																			global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult overrideResult;
																			if (overrideResult == global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.Override)
																			{
																				num = (short)1605107715;
																				num4 = (int)((global::System.IntPtr)num);
																				continue;
																			}
																			num = (short)62521345;
																			num4 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		case 5:
																			goto IL_D05;
																		case 6:
																			goto IL_D05;
																		}
																		goto IL_C2C;
																		IL_D05:
																		num = (short)745734146;
																		num4 = (int)((global::System.IntPtr)num);
																	}
																	IL_D1E:
																	goto IL_F06;
																	IL_C2C:
																	global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
																	item = radioSummary.ToUiModel(true);
																	num = (short)1788018692;
																	num4 = (int)((global::System.IntPtr)num);
																	goto IL_C09;
																}
																finally
																{
																	num = (short)1414332416;
																	num4 = (int)((global::System.IntPtr)num);
																	for (;;)
																	{
																		switch (num4)
																		{
																		case 0:
																			switch (0)
																			{
																			case 0:
																				goto IL_D55;
																			}
																			continue;
																		case 1:
																			goto IL_D8D;
																		case 2:
																			automaticPerformanceMeasurer4.Dispose();
																			num = (short)1672544257;
																			num4 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		IL_D55:
																		if (automaticPerformanceMeasurer4 == null)
																		{
																			break;
																		}
																		num = (short)23330818;
																		num4 = (int)((global::System.IntPtr)num);
																	}
																	IL_D8D:;
																}
																goto IL_D90;
															case 12:
																try
																{
																	global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
																	global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
																	global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
																	global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = radioService.ImportRadioToServer(base.JobContainerGuid, this.GroupID, text, radio, op, isOverwirted, validateEntitySet, warningMsg, optionCount);
																	goto IL_E1A;
																}
																finally
																{
																	num = (short)558694402;
																	num4 = (int)((global::System.IntPtr)num);
																	for (;;)
																	{
																		switch (num4)
																		{
																		case 0:
																			automaticPerformanceMeasurer4.Dispose();
																			num = (short)1575550977;
																			num4 = (int)((global::System.IntPtr)num);
																			continue;
																		case 1:
																			goto IL_A53;
																		case 2:
																			switch (0)
																			{
																			case 0:
																				goto IL_A1C;
																			}
																			continue;
																		}
																		IL_A1C:
																		if (automaticPerformanceMeasurer4 == null)
																		{
																			break;
																		}
																		num = (short)723189760;
																		num4 = (int)((global::System.IntPtr)num);
																	}
																	IL_A53:;
																}
																goto IL_A56;
																IL_E1A:
																num = (short)1261174800;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 13:
															{
																global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption overwriteOption2;
																if (overwriteOption.GetValueOrDefault() == overwriteOption2 & overwriteOption != null)
																{
																	num = (short)1483472910;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																isOverwirted = true;
																num = (short)208994304;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 14:
																goto IL_E90;
															case 15:
																automaticPerformanceMeasurer8 = null;
																goto IL_BE0;
															case 16:
															{
																global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
																if (radioSummary != null)
																{
																	num = (short)1588658198;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_F06;
															}
															case 17:
																goto IL_ADB;
															case 18:
																goto IL_A56;
															case 19:
																num = (short)1371930627;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 20:
																if (automaticPerformanceMeasurer2 == null)
																{
																	num = (short)888668179;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																num = (short)1596325898;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 21:
																automaticPerformanceMeasurer8 = automaticPerformanceMeasurer2.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportArchive, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("苊ꃌ뿎뻐ꇒꇔꯘ뫚맜뛞軠쏢釤裦짨飪裬鷮蟰雲蟴", a_)));
																goto IL_BE0;
															case 22:
																goto IL_D90;
															case 23:
																op = global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.ConfigurationOnly;
																num = (short)234618881;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 24:
																if (overwriteOption != null)
																{
																	num = (short)1990590470;
																	num4 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_E90;
															}
															goto IL_959;
															IL_A56:
															num = (short)581173263;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_A76:
															automaticPerformanceMeasurer4 = automaticPerformanceMeasurer7;
															num = (short)1320681483;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_A95:
															op = this.a;
															num = (short)1509818377;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_ADB:
															global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ꋊꃌ뿎뻐ꇒꇔ뻖럘볚﷜귞胠蟢賤裦짨飪駬軮菰蟲", a_));
															num = (short)1087242244;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_B70:
															num = (short)1340342280;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_BE0:
															automaticPerformanceMeasurer4 = automaticPerformanceMeasurer8;
															num = (short)557252620;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_D90:
															num = (short)1547304980;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_E90:
															isOverwirted = false;
															num = (short)1878589445;
															num4 = (int)((global::System.IntPtr)num);
															continue;
															IL_F06:
															global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ꋊꃌ뿎뻐ꇒꇔ뻖럘볚﷜귞胠蟢賤裦짨軪菬诮", a_));
															num = (short)696320007;
															num4 = (int)((global::System.IntPtr)num);
														}
														IL_F3C:
														goto IL_1322;
														IL_959:
														overwriteOption = this.OverwriteOption;
														num = (short)1506934808;
														num4 = (int)((global::System.IntPtr)num);
														goto IL_8EE;
													}
													catch (global::Motorola.Common.CustomException.CommonException ex)
													{
														if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_MAXLIMIT_LICENSE)
														{
															flag = true;
															goto IL_1322;
														}
														throw;
													}
													goto IL_F5A;
												case 24:
													if (automaticPerformanceMeasurer2 == null)
													{
														num = (short)1557397537;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1982660615;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 25:
													try
													{
														global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
														global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
														global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
														global::Motorola.CommonCPS.Server.EntityModel.Radio radio2;
														global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult overrideResult = radioService.ValidateCanImportArchive(radio, this.GroupID, this.OverwriteOption, this.a, validateEntitySet, out radio2, out warningMsg);
														goto IL_842;
													}
													finally
													{
														num = (short)1882324992;
														num4 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num4)
															{
															case 0:
																switch (0)
																{
																case 0:
																	goto IL_12E7;
																}
																continue;
															case 1:
																goto IL_131F;
															case 2:
																automaticPerformanceMeasurer4.Dispose();
																num = (short)1441988609;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_12E7:
															if (automaticPerformanceMeasurer4 == null)
															{
																break;
															}
															num = (short)1958084610;
															num4 = (int)((global::System.IntPtr)num);
														}
														IL_131F:;
													}
													goto IL_1322;
												case 26:
													automaticPerformanceMeasurer5 = null;
													goto IL_1164;
												case 27:
													automaticPerformanceMeasurer9 = null;
													goto IL_763;
												case 28:
													automaticPerformanceMeasurer9 = automaticPerformanceMeasurer2.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportArchive, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鿊뿌ꛎ볐雔룖뷘뻚규돞铠蓢", a_)));
													goto IL_763;
												case 29:
													automaticPerformanceMeasurer6 = null;
													goto IL_50C;
												case 30:
													try
													{
														global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
														base.LocalService.TrimCodeplug(radio.WorkingCodeplug);
														goto IL_41D;
													}
													finally
													{
														num = (short)1405878274;
														num4 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num4)
															{
															case 0:
																automaticPerformanceMeasurer4.Dispose();
																num = (short)1962475521;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																goto IL_802;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_7CA;
																}
																continue;
															}
															IL_7CA:
															if (automaticPerformanceMeasurer4 == null)
															{
																break;
															}
															num = (short)509345792;
															num4 = (int)((global::System.IntPtr)num);
														}
														IL_802:;
													}
													goto IL_805;
													IL_41D:
													num = (short)1555300366;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 31:
													global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯊곌뷎ꋐ뛒뇔ꯘ뫚맜뛞軠쏢跤蛦髨쯪菬胮퇰郲髴駶鿸鋺髼", a_));
													num = (short)816971811;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 32:
													try
													{
														string password;
														global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
														global::Motorola.CommonCPS.Server.EntityModel.Radio radio = radioService.ParseArchive(text, false, password, out optionCount);
														goto IL_478;
													}
													finally
													{
														num = (short)846200834;
														num4 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num4)
															{
															case 0:
																automaticPerformanceMeasurer4.Dispose();
																num = (short)1283522561;
																num4 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																goto IL_5E3;
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_5AA;
																}
																continue;
															}
															IL_5AA:
															if (automaticPerformanceMeasurer4 == null)
															{
																break;
															}
															num = (short)30015488;
															num4 = (int)((global::System.IntPtr)num);
														}
														IL_5E3:;
													}
													goto IL_5E6;
													IL_478:
													global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯊곌뷎ꋐ뫒믔냖律뻚돜믞", a_));
													num = (short)1080623122;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 33:
													num = (short)2145845274;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 34:
													num = (short)1002373149;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 35:
													goto IL_317;
												case 36:
													goto IL_5E6;
												}
												IL_2C3:
												if (this.ReadPassWordDictionary != null)
												{
													num = (short)1129512976;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_11E0;
												IL_317:
												num = (short)106496012;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_50C:
												automaticPerformanceMeasurer4 = automaticPerformanceMeasurer6;
												num = (short)716505089;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_5E6:
												num = (short)685899782;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_729:
												num = (short)5767177;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_763:
												automaticPerformanceMeasurer4 = automaticPerformanceMeasurer9;
												num = (short)2071199774;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_805:
												num = (short)740098072;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_842:
												num = (short)2058092567;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_1164:
												automaticPerformanceMeasurer4 = automaticPerformanceMeasurer5;
												num = (short)1350631449;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_1184:
												automaticPerformanceMeasurer4 = automaticPerformanceMeasurer3;
												num = (short)912130080;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_11E0:
												global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventInfo(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯊곌뷎ꋐ뫒믔냖律꣚꧜뻞鏠韢엤韦裨鿪藬쿮쳰폲軴쟶蓸", a_), text));
												optionCount = null;
												num = (short)2115436548;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_1248:
												warningMsg = null;
												num = (short)1956577288;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_1322:
												num = (short)783351828;
												num4 = (int)((global::System.IntPtr)num);
											}
											IL_4CD:
											IL_F5A:
											global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯊곌뷎ꋐ뛒뇔ꯘ뫚맜뛞軠쏢賤铦짨藪飬菮鷰", a_));
											throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_File_colon_could_not_be_opened, new string[]
											{
												global::System.IO.Path.GetFileName(text),
												string.Empty
											}));
											IL_133B:
											goto IL_1588;
										}
										catch (global::Motorola.Common.CustomException.CommonException ex2)
										{
											global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex2, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
											global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
											if (ex2.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
											{
												goto IL_14C9;
											}
											if (!(ex2.Message == global::Motorola.CommonCPS.ResourceRepository.Resources.RADIO_HAS_EXISTS))
											{
												if (!(ex2.Message == global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Warning_ImportCP_FlashCodeChanged_Override))
												{
													goto IL_14C9;
												}
											}
											batchOperationJob.ErrorCode = null;
											if (ex2.Message == global::Motorola.CommonCPS.ResourceRepository.Resources.RADIO_HAS_EXISTS)
											{
												batchOperationJob.WarningMessage = global::Motorola.CommonCPS.Common.CommonUtility.WarningMessageConverter.OriginalToSource(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(null, methodof(global::Motorola.CommonCPS.ResourceRepository.Resources.get_RADIO_HAS_EXISTS())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())), 0);
											}
											else
											{
												batchOperationJob.WarningMessage = global::Motorola.CommonCPS.Common.CommonUtility.WarningMessageConverter.OriginalToSource(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(null, methodof(global::Motorola.CommonCPS.ResourceRepository.Resources.get_RMC_Warning_ImportCP_FlashCodeChanged_Override())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())), 0);
											}
											batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED;
											string text;
											global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
											global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
											batchOperationJob.JobDescription = radioService.GetJobDescriptionForImportRadio(text, (radio != null) ? radio.SerialNumber : null);
											IL_13C9:
											if (ex2.CommonExceptionData != null)
											{
												batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex2.CommonExceptionData.Paramters);
											}
											batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
											radioService.AddBatchOperationJob(batchOperationJob);
											num3++;
											base.ReportProgress(num3);
											goto IL_173F;
											IL_14C9:
											if (ex2.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
											{
												if (ex2.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
												{
													goto IL_13DA;
												}
											}
											batchOperationJob.ErrorMessage = ex2.Message;
											IL_13DA:
											batchOperationJob.ErrorCode = new int?((int)ex2.ErrorCode);
											batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
											batchOperationJob.JobDescription = radioService.GetJobDescriptionForImportRadio(text, (radio != null) ? radio.SerialNumber : null);
											goto IL_13C9;
										}
										goto IL_1533;
										IL_1588:
										num = (short)2111569928;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_15DA;
									case 6:
										automaticPerformanceMeasurer = null;
										goto IL_15DF;
									case 7:
										goto IL_1533;
									case 8:
										if (automaticPerformanceMeasurer2 == null)
										{
											num = (short)175702023;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1108475907;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										num = (short)614006789;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										goto IL_15F9;
									case 11:
									{
										if (flag)
										{
											num = (short)1041825801;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
										global::Motorola.CommonCPS.Server.EntityModel.Radio radio = null;
										global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
										string password = null;
										global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult overrideResult = global::Motorola.CommonCPS.RadioManagement.SharedServices.OverrideResult.NeverOverride;
										num = (short)648085508;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1AC:
									if (base.CancellationPending)
									{
										num = (short)1442578432;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)482213899;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1533:
									num = (short)887947270;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_15DF:
									automaticPerformanceMeasurer4 = automaticPerformanceMeasurer;
									num = (short)2126249994;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_15DA:
								return;
								IL_15F9:
								try
								{
									num3++;
									base.ReportProgress(num3);
									break;
								}
								finally
								{
									num = (short)951386112;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1696;
											}
											continue;
										case 1:
											goto IL_16CF;
										case 2:
											automaticPerformanceMeasurer4.Dispose();
											num = (short)526712833;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1696:
										if (automaticPerformanceMeasurer4 == null)
										{
											break;
										}
										num = (short)23068674;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_16CF:;
								}
								IL_1613:
								return;
							}
							finally
							{
								num = (short)249102336;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1704;
										}
										continue;
									case 1:
										goto IL_173C;
									case 2:
										automaticPerformanceMeasurer2.Dispose();
										num = (short)1054670849;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1704:
									if (automaticPerformanceMeasurer2 == null)
									{
										break;
									}
									num = (short)77791234;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_173C:;
							}
							break;
						case 3:
							automaticPerformanceMeasurer10 = null;
							goto IL_138;
						case 4:
							goto IL_1796;
						case 5:
							num = (short)1239547908;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
							if (measurer == null)
							{
								num = (short)1455357955;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text;
							automaticPerformanceMeasurer10 = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ImportArchive, null).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯊곌믎말", a_), global::System.IO.Path.GetFileName(text)));
							goto IL_138;
						}
						}
						goto IL_CB;
						IL_138:
						automaticPerformanceMeasurer2 = automaticPerformanceMeasurer10;
						num = (short)1128726530;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_173F:
						num = (short)210632705;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_CB:
						goto IL_173F;
					}
					IL_1796:;
				}
				finally
				{
					num = (short)619905024;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_17CA;
							}
							continue;
						case 1:
							goto IL_1800;
						case 2:
							enumerator.Dispose();
							num = (short)1929707521;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_17CA:
						if (enumerator == null)
						{
							break;
						}
						num = (short)240975874;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1800:;
				}
				return;
			}
			}
		}

		// Token: 0x04000090 RID: 144
		private readonly global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption a;

		// Token: 0x04000091 RID: 145
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Guid? b;

		// Token: 0x04000092 RID: 146
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption? c;

		// Token: 0x04000093 RID: 147
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> d;
	}
}
