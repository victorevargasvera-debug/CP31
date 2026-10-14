using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.Common.LogUtility.PerformanceMeasurement;
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
	// Token: 0x02000025 RID: 37
	public class ASTROUpgradeFirmwareBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
		public ASTROUpgradeFirmwareBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedAllRadios, global::System.Collections.Generic.IList<global::System.Guid> cross712Radios, global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware selectedFirmware, string codeplugVersion = null)
		{
			base.SelectedItems = selectedAllRadios;
			this.Cross712Radios = (cross712Radios as global::System.Collections.Generic.List<global::System.Guid>);
			this.Firmware = selectedFirmware;
			this.CodeplugVersion = codeplugVersion;
			this.Service = (global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService)global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0001D740 File Offset: 0x0001B940
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)163971073;
				if (num != 0)
				{
				}
				num = (short)187196783;
				short num2 = num;
				num = (short)774661487;
				switch (num2 == num)
				{
				}
				num = (short)86441984;
				if (num != 0)
				{
				}
				num = (short)1236992000;
				short num3 = num;
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeFirmware;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0001D7EC File Offset: 0x0001B9EC
		public override string JobName
		{
			get
			{
				short num = (short)1185709092;
				short num2 = num;
				num = (short)1094220836;
				switch (num2 == num)
				{
				}
				num = (short)931528705;
				if (num != 0)
				{
				}
				num = (short)1272840192;
				if (num != 0)
				{
				}
				num = (short)1993932800;
				short num3 = num;
				return global::Motorola.CommonCPS.ResourceRepository.Resources.General_UpgradeFirmware;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0001D898 File Offset: 0x0001BA98
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0001D948 File Offset: 0x0001BB48
		private global::System.Collections.Generic.List<global::System.Guid> Cross712Radios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)462793104;
				short num2 = num;
				num = (short)1285532048;
				switch (num2 == num)
				{
				}
				num = (short)638189568;
				if (num != 0)
				{
				}
				num = (short)835846145;
				if (num != 0)
				{
				}
				num = (short)1218641920;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1589022079;
				short num2 = num;
				num = (short)1454542207;
				switch (num2 == num)
				{
				}
				num = (short)578617345;
				if (num != 0)
				{
				}
				num = (short)1209008128;
				if (num != 0)
				{
				}
				num = (short)1256062976;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0001D9FC File Offset: 0x0001BBFC
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0001DAAC File Offset: 0x0001BCAC
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware Firmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)382026158;
				short num2 = num;
				num = (short)1262240174;
				switch (num2 == num)
				{
				}
				num = (short)688848897;
				if (num != 0)
				{
				}
				num = (short)491782144;
				if (num != 0)
				{
				}
				num = (short)1321598976;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1514074825;
				short num2 = num;
				num = (short)1103229641;
				switch (num2 == num)
				{
				}
				num = (short)1478033409;
				if (num != 0)
				{
				}
				num = (short)1605894144;
				if (num != 0)
				{
				}
				num = (short)2020147200;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0001DB5C File Offset: 0x0001BD5C
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		private string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)222167040;
				short num2 = num;
				num = (short)425889390;
				short num3 = num;
				num = (short)1932824174;
				switch (num3 == num)
				{
				}
				num = (short)1508966401;
				if (num != 0)
				{
				}
				num = (short)1670774784;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)598540288;
				short num2 = num;
				num = (short)2104939061;
				short num3 = num;
				num = (short)22729269;
				switch (num3 == num)
				{
				}
				num = (short)1352204289;
				if (num != 0)
				{
				}
				num = (short)1915944960;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0001DCC0 File Offset: 0x0001BEC0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0001DD70 File Offset: 0x0001BF70
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService Service
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2123169792;
				short num2 = num;
				num = (short)835863901;
				short num3 = num;
				num = (short)1808090461;
				switch (num3 == num)
				{
				}
				num = (short)547880961;
				if (num != 0)
				{
				}
				num = (short)2102132736;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)29818880;
				short num2 = num;
				num = (short)449776547;
				short num3 = num;
				num = (short)1344736163;
				switch (num3 == num)
				{
				}
				num = (short)392626177;
				if (num != 0)
				{
				}
				num = (short)2080374784;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001DE20 File Offset: 0x0001C020
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer DoWork()
		{
			short num = (short)864550912;
			short num2 = num;
			num = (short)1979203360;
			short num3 = num;
			num = (short)1826111264;
			switch (num3 == num)
			{
			}
			num = (short)1043988481;
			if (num != 0)
			{
			}
			num = (short)436928512;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer result = base.AddBatchJobContainer();
			this.OnDoWork(null);
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001DEDC File Offset: 0x0001C0DC
		private global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> a()
		{
			int a_ = 6;
			short num = (short)904593408;
			short num2 = num;
			num = (short)1449394176;
			switch (num)
			{
			default:
			{
				num = (short)580517889;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware>();
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> result;
				try
				{
					num = (short)555417600;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E4;
							}
							continue;
						case 1:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
							num = (short)437256195;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							bool? isVirtualSummaryFirmware;
							bool flag;
							if (isVirtualSummaryFirmware.GetValueOrDefault() == flag & isVirtualSummaryFirmware != null)
							{
								num = (short)1739784203;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
							num = (short)1283588103;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							try
							{
								num = (short)139526144;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
									switch (num3)
									{
									case 0:
										IL_4ED:
										switch (0)
										{
										case 0:
											goto IL_51A;
										}
										continue;
									case 1:
									{
										global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
										if (measurer == null)
										{
											num = (short)189267972;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										automaticPerformanceMeasurer = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("賊꣌믎胒ꃔ뗖鿘닚꿜닞雠苢韤苦", a_), null).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飊꣌뷎룐닒맔韘껚냜뷞蓠釢", a_), radioBase.SerialNumber));
										goto IL_597;
									}
									case 2:
										goto IL_A1F;
									case 3:
										num = (short)633602050;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										automaticPerformanceMeasurer = null;
										goto IL_597;
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1788542979;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
										num = (short)1556873217;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										try
										{
											num = (short)664928257;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
												switch (num3)
												{
												case 0:
												{
													global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware;
													if (astrofirmware == null)
													{
														num = (short)1508376578;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													dictionary.Add(radioBase.DeviceUuid, astrofirmware);
													num = (short)699793413;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
													switch (0)
													{
													case 0:
														goto IL_66B;
													}
													continue;
												case 2:
													goto IL_909;
												case 3:
													goto IL_8D2;
												case 4:
												{
													global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
													CS$<>8__locals1.targetModel = ((astroradio.ModelNumber.Substring(0, 1)[0] == 'H') ? global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("꿊꓌볎닐賒ꗔ룖ꯘ", a_) : global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("꿊꓌볎닐賒룔룖믘", a_));
													global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
													global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware = subFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
													{
														switch (0)
														{
														case 0:
															goto IL_20;
														}
														int num6;
														bool? flag2;
														bool flag3;
														short num7;
														for (;;)
														{
															IL_0A:
															switch (num6)
															{
															case 0:
															{
																if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
																{
																	return false;
																}
																num7 = (short)1182197548;
																short num8 = num7;
																num7 = (short)36824876;
																switch ((num8 == num7) ? 1 : 0)
																{
																case 0:
																case 2:
																	goto IL_6C;
																default:
																{
																	num7 = (short)1143406593;
																	if (num7 != 0)
																	{
																	}
																	num7 = (short)718405632;
																	short num9 = num7;
																	num7 = (short)885587968;
																	if (num7 != 0)
																	{
																	}
																	num7 = (short)1802633218;
																	num6 = (int)((global::System.IntPtr)num7);
																	continue;
																}
																}
																break;
															}
															case 1:
																flag2 = x.IsFreonFirmwareUpgradeFile;
																flag3 = true;
																num7 = (short)1196163072;
																num6 = (int)((global::System.IntPtr)num7);
																continue;
															case 2:
																goto IL_169;
															case 3:
																if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
																{
																	num7 = (short)112066561;
																	num6 = (int)((global::System.IntPtr)num7);
																	continue;
																}
																return false;
															}
															goto IL_20;
														}
														IL_6C:
														return x.TargetModel == CS$<>8__locals1.targetModel;
														IL_169:
														goto IL_6C;
														IL_20:
														flag2 = x.IsSubFirmware;
														flag3 = true;
														num7 = (short)1128333315;
														num6 = (int)((global::System.IntPtr)num7);
														goto IL_0A;
													});
													num = (short)1283194883;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 5:
													goto IL_940;
												case 6:
												{
													global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = radioBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
													global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware = null;
													num = (short)2138636298;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 7:
												{
													global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
													if (astroradio.ModelNumber.Substring(0, 1)[0] != 'H')
													{
														num = (short)844955661;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_8D2;
												}
												case 8:
												{
													global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
													if (astroradio.ModelNumber.Substring(0, 1)[0] == 'H')
													{
														num = (short)144113679;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1692729351;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 9:
													goto IL_8D2;
												case 10:
												{
													global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
													if (this.Service.IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX, astroradio.ModelNumber))
													{
														num = (short)324927499;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)397148168;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 11:
													num = (short)411107332;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 12:
													goto IL_8D2;
												case 13:
													num = (short)567214096;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 14:
													goto IL_959;
												case 15:
													num = (short)1456996369;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 16:
												{
													global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
													global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware = subFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
													{
														int a_2 = 8;
														for (;;)
														{
															IL_09:
															switch (0)
															{
															case 0:
																goto IL_5A;
															}
															short num6;
															int num8;
															bool? flag2;
															bool flag3;
															for (;;)
															{
																IL_13:
																num6 = (short)883163136;
																short num7 = num6;
																switch (num8)
																{
																case 0:
																	num6 = (short)1185218561;
																	if (num6 != 0)
																	{
																	}
																	if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
																	{
																		num6 = (short)287113219;
																		num8 = (int)((global::System.IntPtr)num6);
																		continue;
																	}
																	return false;
																case 1:
																	if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
																	{
																		num6 = (short)1026162690;
																		num8 = (int)((global::System.IntPtr)num6);
																		continue;
																	}
																	return false;
																case 2:
																{
																	num6 = (short)1447012628;
																	short num9 = num6;
																	num6 = (short)690399508;
																	switch ((num9 == num6) ? 1 : 0)
																	{
																	case 0:
																	case 2:
																		goto IL_09;
																	default:
																		num6 = (short)1871839232;
																		if (num6 != 0)
																		{
																		}
																		flag2 = x.IsFreonFirmwareUpgradeFile;
																		flag3 = true;
																		num6 = (short)2042232832;
																		num8 = (int)((global::System.IntPtr)num6);
																		continue;
																	}
																	break;
																}
																case 3:
																	goto IL_144;
																case 4:
																	if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
																	{
																		num6 = (short)627310597;
																		num8 = (int)((global::System.IntPtr)num6);
																		continue;
																	}
																	return false;
																case 5:
																	flag2 = x.IsOMAPFirmwareUpgradeFile;
																	flag3 = true;
																	num6 = (short)211681281;
																	num8 = (int)((global::System.IntPtr)num6);
																	continue;
																}
																break;
															}
															IL_5A:
															flag2 = x.IsSubFirmware;
															flag3 = true;
															num6 = (short)1409155076;
															num8 = (int)((global::System.IntPtr)num6);
															goto IL_13;
														}
														IL_144:
														return x.TargetModel.Substring(0, 1) != global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("藌", a_2);
													});
													num = (short)103940105;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 17:
												{
													global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
													global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware = subFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
													{
														int a_2 = 3;
														for (;;)
														{
															IL_09:
															switch (0)
															{
															case 0:
																goto IL_5B;
															}
															short num6;
															int num8;
															bool? flag2;
															bool flag3;
															for (;;)
															{
																IL_13:
																num6 = (short)427950080;
																short num7 = num6;
																switch (num8)
																{
																case 0:
																	if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
																	{
																		num6 = (short)1716846595;
																		num8 = (int)((global::System.IntPtr)num6);
																		continue;
																	}
																	return false;
																case 1:
																	if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
																	{
																		num6 = (short)731643906;
																		num8 = (int)((global::System.IntPtr)num6);
																		continue;
																	}
																	return false;
																case 2:
																{
																	num6 = (short)1868365096;
																	short num9 = num6;
																	num6 = (short)590544168;
																	switch ((num9 == num6) ? 1 : 0)
																	{
																	case 0:
																	case 2:
																		goto IL_09;
																	default:
																		num6 = (short)699334656;
																		if (num6 != 0)
																		{
																		}
																		flag2 = x.IsFreonFirmwareUpgradeFile;
																		flag3 = true;
																		num6 = (short)765067264;
																		num8 = (int)((global::System.IntPtr)num6);
																		continue;
																	}
																	break;
																}
																case 3:
																	goto IL_13F;
																case 4:
																	if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
																	{
																		num6 = (short)1311965189;
																		num8 = (int)((global::System.IntPtr)num6);
																		continue;
																	}
																	return false;
																case 5:
																	num6 = (short)2077229057;
																	if (num6 != 0)
																	{
																	}
																	flag2 = x.IsOMAPFirmwareUpgradeFile;
																	flag3 = true;
																	num6 = (short)1225719809;
																	num8 = (int)((global::System.IntPtr)num6);
																	continue;
																}
																break;
															}
															IL_5B:
															flag2 = x.IsSubFirmware;
															flag3 = true;
															num6 = (short)958398468;
															num8 = (int)((global::System.IntPtr)num6);
															goto IL_13;
														}
														IL_13F:
														return x.TargetModel.Substring(0, 1) == global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("胇", a_2);
													});
													num = (short)2094792716;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_66B:
												if (radioBase is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)
												{
													num = (short)547291142;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_940;
												IL_8D2:
												num = (short)1147928576;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_940:
												num = (short)420085774;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_909:
											throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
											IL_959:;
										}
										finally
										{
											num = (short)1669136384;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_98D;
													}
													continue;
												case 1:
													goto IL_9C4;
												case 2:
													automaticPerformanceMeasurer2.Dispose();
													num = (short)1754071041;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_98D:
												if (automaticPerformanceMeasurer2 == null)
												{
													break;
												}
												num = (short)133300226;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_9C4:;
										}
										break;
									}
									IL_9C7:
									num = (short)2014052357;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_51A:
									goto IL_9C7;
									IL_597:
									automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
									num = (short)481345470;
									short num4 = num;
									num = (short)249610174;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_4ED;
									default:
										num = (short)362545152;
										if (num != 0)
										{
										}
										num = (short)210567174;
										num3 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_A1F:;
							}
							finally
							{
								num = (short)245432320;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_A54;
										}
										continue;
									case 1:
										goto IL_A8C;
									case 2:
										enumerator.Dispose();
										num = (short)963706881;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_A54:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1535115266;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_A8C:;
							}
							goto IL_A8F;
						case 4:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2;
							if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(astrofirmware2.Timestamp, this.Firmware.Timestamp))
							{
								num = (short)314572812;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							bool? isVirtualSummaryFirmware = astrofirmware2.IsVirtualSummaryFirmware;
							bool flag = true;
							num = (short)2026766338;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2;
							if (astrofirmware2 == null)
							{
								num = (short)1172242440;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1937440772;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							automaticPerformanceMeasurer3 = null;
							goto IL_42B;
						case 7:
							try
							{
								num = (short)753598464;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_33A;
										}
										continue;
									case 1:
										goto IL_3B8;
									case 3:
										num = (short)1237254145;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)643891203;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase2 = enumerator.Current;
										global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2;
										dictionary.Add(radioBase2.DeviceUuid, astrofirmware2);
										num = (short)264962050;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_36B:
									num = (short)526254084;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_33A:
									goto IL_36B;
								}
								IL_3B8:
								goto IL_A8F;
							}
							finally
							{
								num = (short)895025152;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_3EF;
										}
										continue;
									case 1:
										goto IL_428;
									case 2:
										enumerator.Dispose();
										num = (short)1680211969;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_3EF:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1231618050;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_428:;
							}
							goto IL_42B;
						case 8:
							goto IL_133;
						case 9:
						{
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
							if (subFirmwares.Any<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware>())
							{
								num = (short)862322689;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F5;
						}
						case 10:
							goto IL_AA7;
						case 11:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2;
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares = astrofirmware2.SubFirmwares;
							num = (short)97517581;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_4AB;
						case 13:
						{
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> subFirmwares;
							if (subFirmwares != null)
							{
								num = (short)1025048591;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F5;
						}
						case 14:
							try
							{
								global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetPackage(this.Firmware.Uuid) as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware;
								goto IL_100;
							}
							finally
							{
								num = (short)1869217792;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_193;
										}
										continue;
									case 1:
										goto IL_1CA;
									case 2:
										automaticPerformanceMeasurer2.Dispose();
										num = (short)2077491201;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_193:
									if (automaticPerformanceMeasurer2 == null)
									{
										break;
									}
									num = (short)515112962;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1CA:;
							}
							goto IL_1CD;
							IL_100:
							num = (short)352714757;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_1CD;
						}
						IL_E4:
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer2 = this.Measurer;
						if (measurer2 == null)
						{
							num = (short)1320747014;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						automaticPerformanceMeasurer3 = measurer2.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("賊꣌믎闒볔ꗖ듘곚볜귞蓠", a_));
						goto IL_42B;
						IL_1CD:
						num = (short)1452539913;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_42B:
						automaticPerformanceMeasurer2 = automaticPerformanceMeasurer3;
						num = (short)679084046;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A8F:
						num = (short)286195722;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_F5:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
					IL_133:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
					IL_4AB:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
					IL_AA7:
					return dictionary;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					string[] paramters = null;
					if (ex.CommonExceptionData != null)
					{
						paramters = ex.CommonExceptionData.Paramters;
					}
					int num5 = 0;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
					try
					{
						num = (short)351928320;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_B1A;
								}
								continue;
							case 1:
								num = (short)1892417540;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1093992449;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase3 = enumerator.Current;
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpUtility.CreateFailureJob(base.JobContainerGuid, radioBase3.SerialNumber, ex.ErrorCode, paramters);
								this.Service.AddBatchOperationJob(job);
								num5++;
								base.ReportProgress(num5);
								num = (short)884998147;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_BCC;
							}
							IL_B77:
							num = (short)43515906;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_B1A:
							goto IL_B77;
						}
						IL_BCC:;
					}
					finally
					{
						num = (short)1568669697;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)550043650;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_C00;
								}
								continue;
							case 2:
								goto IL_C37;
							}
							IL_C00:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2022637568;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_C37:;
					}
					result = null;
				}
				return result;
			}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0001EBC0 File Offset: 0x0001CDC0
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData>> a(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> A_0, ref int A_1)
		{
			int a_ = 1;
			short num = (short)488177664;
			short num2 = num;
			num = (short)18546688;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData astrosyncData = null;
				global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData>> list = new global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData>>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)2014052354;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
						switch (num3)
						{
						case 0:
							goto IL_50A;
						case 1:
						{
							global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
							if (measurer == null)
							{
								num = (short)1791754245;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							automaticPerformanceMeasurer = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("臅귇뻉鳍뇏뛑뷓맕", a_), null).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("闅귇룉ꗋ꿍볏髓ꏕ뗗룙맛곝", a_), radioBase.SerialNumber));
							goto IL_123;
						}
						case 2:
							IL_7B:
							switch (0)
							{
							case 0:
								goto IL_A8;
							}
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1518272518;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)1744044033;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1C3;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
								for (;;)
								{
									IL_194:
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
									global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid2;
									switch (num3)
									{
									case 0:
										goto IL_3D3;
									case 1:
										if (astrosyncData != null)
										{
											num = (short)254279684;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_267;
									case 2:
										if (radioByDeviceUuid.WorkMode == global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration)
										{
											num = (short)977272841;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3AC;
									case 3:
										goto IL_20A;
									case 4:
										num = (short)931594242;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										if (radioByDeviceUuid == null)
										{
											num = (short)1495924739;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)523108359;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_319;
									case 7:
										if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radioByDeviceUuid.Timestamp, radioBase.RadioTimestamp))
										{
											num = (short)2035286022;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										astroradio = (radioBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
										radioByDeviceUuid2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(astroradio.DeviceUuid, true);
										num = (short)1029832705;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_3AC;
									case 9:
										goto IL_267;
									}
									goto IL_1C3;
									IL_267:
									byte[] flashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroEncodeFlashCode(astroradio.AstroPurchasedFlashCode);
									this.Service.GetSyncDataForUpgrade(radioByDeviceUuid2, A_0[astroradio.DeviceUuid], flashCode, null, this.Cross712Radios, base.SelectedItems.Count<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(), true, null, out astrosyncData, this.CodeplugVersion);
									num = (short)1165361160;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_3AC:
									list.Add(new global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData>(astroradio, astrosyncData));
									num = (short)76742656;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_20A:
								global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("铅藇觉鏋鳍뇏뛑뷓맕雗뗙꣛鯝食诡韣鋥", a_));
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
								IL_319:
								global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("铅藇觉鏋苍뿏뇑뗓뫕蟗黙뷛ꫝ臟뷡ꯣ鏥鳧藩諫뇭듯鏱胳鏵", a_));
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
								IL_3D3:
								break;
								IL_1C3:
								radioByDeviceUuid = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(radioBase.DeviceUuid, true);
								num = (short)1271005189;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_194;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								string[] paramters = null;
								if (ex.CommonExceptionData != null)
								{
									paramters = ex.CommonExceptionData.Paramters;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpUtility.CreateFailureJob(base.JobContainerGuid, radioBase.SerialNumber, ex.ErrorCode, paramters);
								this.Service.AddBatchOperationJob(job);
								this.Service.CleanForUpgrade(null, this.Cross712Radios, astrosyncData);
								A_1++;
								base.ReportProgress(A_1);
							}
							finally
							{
								num = (short)564527105;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										automaticPerformanceMeasurer2.Dispose();
										num = (short)1499398146;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_477;
										}
										continue;
									case 2:
										goto IL_4B1;
									}
									IL_477:
									if (automaticPerformanceMeasurer2 == null)
									{
										break;
									}
									num = (short)108331008;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_4B1:;
							}
							break;
						case 5:
							automaticPerformanceMeasurer = null;
							goto IL_123;
						case 6:
							num = (short)1632108544;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_4B4:
						num = (short)298254339;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A8:
						goto IL_4B4;
						IL_123:
						automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
						num = (short)1856110523;
						short num4 = num;
						num = (short)1999896507;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7B;
						default:
							num = (short)906100736;
							if (num != 0)
							{
							}
							num = (short)716177412;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_50A:;
				}
				finally
				{
					num = (short)1013317633;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1062273026;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_53E;
							}
							continue;
						case 2:
							goto IL_574;
						}
						IL_53E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1992359936;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_574:;
				}
				num = (short)257556481;
				if (num != 0)
				{
				}
				return list;
			}
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
		private void a(global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData>> A_0, ref int A_1)
		{
			int a_ = 10;
			short num = (short)468254720;
			switch (num)
			{
			default:
			{
				num = (short)1970536448;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData>> enumerator;
				global::System.Collections.Generic.List<global::System.Guid> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 1:
						goto IL_A2;
					case 2:
						goto IL_204;
					case 3:
						num = (short)2028339201;
						if (num != 0)
						{
						}
						try
						{
							num = (short)194641920;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_10B;
									}
									continue;
								case 2:
									num = (short)1638989828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1968701442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData> tuple = enumerator.Current;
									this.Service.CleanForUpgrade(null, this.Cross712Radios, tuple.Item2);
									num = (short)1143799809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_194;
								}
								IL_10D:
								num = (short)1231618051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10B:
								goto IL_10D;
							}
							IL_194:
							return;
						}
						finally
						{
							num = (short)2076639234;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)806682625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_201;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1CB;
									}
									continue;
								}
								IL_1CB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1042939904;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_201:;
						}
						goto IL_204;
					}
					IL_5C:
					if (base.CancellationPending)
					{
						num = (short)1358626818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					list = new global::System.Collections.Generic.List<global::System.Guid>();
					enumerator = A_0.GetEnumerator();
					num = (short)1047003137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_204:
					enumerator = A_0.GetEnumerator();
					num = (short)811859971;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A2:
				num = (short)745209856;
				short num3 = num;
				try
				{
					num = (short)962592773;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
						switch (num2)
						{
						case 0:
							automaticPerformanceMeasurer = null;
							goto IL_311;
						case 1:
						{
							num = (short)1560265252;
							short num4 = num;
							num = (short)1354809892;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_77D;
							default:
								num = (short)210501632;
								if (num != 0)
								{
								}
								try
								{
									switch (0)
									{
									case 0:
										goto IL_39B;
									}
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData item;
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio item3;
									for (;;)
									{
										IL_380:
										switch (num2)
										{
										case 0:
											this.Service.CleanForUpgrade(list, this.Cross712Radios, item);
											num = (short)550567938;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											try
											{
												switch (0)
												{
												case 0:
													goto IL_461;
												}
												global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
												for (;;)
												{
													IL_436:
													switch (num2)
													{
													case 0:
													{
														global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
														if (radioSummary != null)
														{
															num = (short)28114946;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("髎ꇐ듒꟔뛖뷘뻚鳜賞뗠뇢ꫤ뗦裨迪蓬胮돰鋲致银釸쇺\uddfc곾搀焂猄戆笈⬊缌樎攐昒朔礖㤘甚栜猞䴠̢", a_));
														num = (short)101187587;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 1:
														if (radioByDeviceUuid == null)
														{
															num = (short)1497104392;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														num = (short)2137915398;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 2:
													{
														global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
														global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary2 = radioSummary;
														list.Add(radioSummary2.Uuid);
														global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item2 = radioSummary2.ToUiModel(true);
														base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
														{
															item2
														});
														num = (short)540475397;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 3:
														goto IL_634;
													case 4:
														goto IL_62F;
													case 5:
														goto IL_634;
													case 6:
													{
														if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radioByDeviceUuid.Timestamp, item3.RadioTimestamp))
														{
															num = (short)647954436;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = this.Service.UpgradeASTRORadioBatch(base.JobContainerGuid, radioByDeviceUuid as global::Motorola.CommonCPS.Server.EntityModel.APXRadio, item, null, this.Cross712Radios);
														num = (short)1379270656;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 7:
														goto IL_64D;
													case 8:
														goto IL_4AA;
													}
													goto IL_461;
													IL_634:
													num = (short)1168113671;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_4AA:
												global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鷎鳐郒諔鏖볘귚드볞蓠귢諤鏦골鏪蓬鳮藰", a_));
												throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
												IL_62F:
												global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鷎鳐郒諔鯖뛘룚볜돞뻠꟢蓤鏦裨듪ꋬ髮藰鳲鏴ꣶ뷸髺觼髾", a_));
												throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
												IL_64D:
												goto IL_6AD;
												IL_461:
												radioByDeviceUuid = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(item3.DeviceUuid, true);
												num = (short)285081601;
												num2 = (int)((global::System.IntPtr)num);
												goto IL_436;
											}
											catch (global::Motorola.Common.CustomException.CommonException ex)
											{
												string[] paramters = null;
												if (ex.CommonExceptionData != null)
												{
													paramters = ex.CommonExceptionData.Paramters;
												}
												global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpUtility.CreateFailureJob(base.JobContainerGuid, item3.SerialNumber, ex.ErrorCode, paramters);
												this.Service.AddBatchOperationJob(job);
												A_1++;
												base.ReportProgress(A_1);
												goto IL_75A;
											}
											IL_6AD:
											A_1++;
											base.ReportProgress(A_1);
											this.Service.CleanForUpgrade(list, this.Cross712Radios, item);
											num = (short)773324803;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_40B;
										case 3:
											goto IL_6E9;
										case 4:
											if (base.CancellationPending)
											{
												num = (short)10027008;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1729101825;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_39B;
									}
									IL_40B:
									return;
									IL_6E9:
									break;
									IL_39B:
									global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData> tuple2;
									item3 = tuple2.Item1;
									item = tuple2.Item2;
									num = (short)591462404;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_380;
								}
								finally
								{
									num = (short)507772930;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											automaticPerformanceMeasurer2.Dispose();
											num = (short)901054465;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_757;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_71E;
											}
											continue;
										}
										IL_71E:
										if (automaticPerformanceMeasurer2 == null)
										{
											break;
										}
										num = (short)786235392;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_757:;
								}
								break;
							}
							break;
						}
						case 2:
							num = (short)1085997059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_7B0;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								goto IL_77D;
							}
							global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData> tuple2 = enumerator.Current;
							num = (short)1626669062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_292;
							}
							continue;
						case 6:
						{
							global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
							if (measurer == null)
							{
								num = (short)318504960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData> tuple2;
							automaticPerformanceMeasurer = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("髎ꇐ듒꟔뛖뷘뻚﷜跞胠蟢賤裦", a_), null).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鳎듐ꇒ볔뛖뗘ﯚ鏜꫞賠臢胤闦", a_), tuple2.Item1.SerialNumber));
							goto IL_311;
						}
						}
						goto IL_292;
						IL_311:
						automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
						num = (short)1217331201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_75A:
						num = (short)1520828420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_292:
						goto IL_75A;
						IL_77D:
						num = (short)1084751874;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7B0:;
				}
				finally
				{
					num = (short)289996802;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)493486081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_81C;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7E4;
							}
							continue;
						}
						IL_7E4:
						if (enumerator == null)
						{
							break;
						}
						num = (short)639893504;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_81C:;
				}
				return;
			}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0001FA48 File Offset: 0x0001DC48
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> dictionary;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.CancellationPending)
						{
							num2 = (short)1186070530;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_12C;
					case 1:
					{
						num2 = (short)1047943886;
						short num3 = num2;
						num2 = (short)1496144590;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1828847617;
							if (num2 != 0)
							{
							}
							num2 = (short)240910336;
							if (num2 != 0)
							{
							}
							num2 = (short)1685258240;
							short num4 = num2;
							num2 = (short)1212547072;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_12A;
					case 3:
						if (dictionary != null)
						{
							num2 = (short)1833369601;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_20:
				dictionary = this.a();
				num2 = (short)913702915;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return;
			IL_12A:
			return;
			IL_12C:
			int num5 = 0;
			global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROSyncData>> a_ = this.a(dictionary, ref num5);
			this.a(a_, ref num5);
		}

		// Token: 0x04000051 RID: 81
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::System.Guid> a;

		// Token: 0x04000052 RID: 82
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware b;

		// Token: 0x04000053 RID: 83
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000054 RID: 84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService d;
	}
}
