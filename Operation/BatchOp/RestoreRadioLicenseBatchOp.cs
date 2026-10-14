using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASK.Interface;
using EntityModel.GenericModel;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200002D RID: 45
	public class RestoreRadioLicenseBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00023008 File Offset: 0x00021208
		public RestoreRadioLicenseBatchOp(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> selectRadioLicenses, global::System.Collections.Generic.Dictionary<string, global::ASK.Interface.ISystemKeyData> userSelectedKeys = null)
		{
			this.SelectRadioLicenses = selectRadioLicenses;
			if (selectRadioLicenses.Count > 0)
			{
				this.Radios = selectRadioLicenses.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase license)
				{
					short num = (short)1889402880;
					short num2 = num;
					num = (short)690697898;
					short num3 = num;
					num = (short)845100714;
					switch (num3 == num)
					{
					}
					num = (short)1896808449;
					if (num != 0)
					{
					}
					num = (short)1469579264;
					if (num != 0)
					{
					}
					return license.SerialNumber;
				}).Distinct<string>().ToList<string>();
			}
			base.SelectedItems = this.Radios;
			this.a = userSelectedKeys;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0002307C File Offset: 0x0002127C
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0002312C File Offset: 0x0002132C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> SelectRadioLicenses
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)65863681;
				if (num != 0)
				{
				}
				num = (short)618362839;
				short num2 = num;
				num = (short)643987415;
				switch (num2 == num)
				{
				}
				num = (short)1127809024;
				if (num != 0)
				{
				}
				num = (short)23789568;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)475546523;
				short num2 = num;
				num = (short)829375387;
				switch (num2 == num)
				{
				}
				num = (short)544145408;
				if (num != 0)
				{
				}
				num = (short)152698881;
				if (num != 0)
				{
				}
				num = (short)1702100992;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000231DC File Offset: 0x000213DC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0002328C File Offset: 0x0002148C
		public global::System.Collections.Generic.List<string> Radios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1982080955;
				short num2 = num;
				num = (short)1657415611;
				switch (num2 == num)
				{
				}
				num = (short)311164929;
				if (num != 0)
				{
				}
				num = (short)1561853952;
				if (num != 0)
				{
				}
				num = (short)1032519680;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)881070252;
				short num2 = num;
				num = (short)140775596;
				switch (num2 == num)
				{
				}
				num = (short)1624965121;
				if (num != 0)
				{
				}
				num = (short)2035744768;
				if (num != 0)
				{
				}
				num = (short)175308800;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0002333C File Offset: 0x0002153C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1189362672;
				short num2 = num;
				num = (short)476462064;
				switch (num2 == num)
				{
				}
				num = (short)186384385;
				if (num != 0)
				{
				}
				num = (short)388300800;
				if (num != 0)
				{
				}
				num = (short)1243414528;
				short num3 = num;
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RestoreRadioLicense;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000233E8 File Offset: 0x000215E8
		public override string JobName
		{
			get
			{
				short num = (short)447032488;
				short num2 = num;
				num = (short)803679400;
				switch (num2 == num)
				{
				}
				num = (short)379387905;
				if (num != 0)
				{
				}
				num = (short)825556992;
				if (num != 0)
				{
				}
				num = (short)2099642368;
				short num3 = num;
				return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_RestoreRadioLicense;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00023494 File Offset: 0x00021694
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 1;
			short num = (short)2121859072;
			short num2 = num;
			num = (short)631439360;
			switch (num)
			{
			default:
			{
				num = (short)1050542081;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>> newTemplateDic = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>>();
				int num3 = 0;
				using (global::System.Collections.Generic.List<string>.Enumerator enumerator = this.Radios.GetEnumerator())
				{
					num = (short)809893896;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
						switch (num4)
						{
						case 0:
							goto IL_6A7;
						case 1:
						{
							global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
							if (measurer == null)
							{
								num = (short)1805647881;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							automaticPerformanceMeasurer = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("铅귇막룋ꇍꋏ럑髕뇗맙맛냝鏟蟡", a_), null).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("闅귇룉ꗋ꿍볏髓ꏕ뗗룙맛곝", a_), CS$<>8__locals1.rd));
							goto IL_670;
						}
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)183762947;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							string rd = enumerator.Current;
							num = (short)687669255;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)402456576;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							try
							{
								try
								{
									switch (0)
									{
									case 0:
										goto IL_20C;
									}
									global::EntityModel.GenericModel.CFSUpdateResult cfsUpdatedResult;
									global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService manageRadioLicenseService;
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> selectedList;
									for (;;)
									{
										IL_1D5:
										global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
										global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
										switch (num4)
										{
										case 0:
											if (this.a != null)
											{
												num = (short)2077097990;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_35B;
										case 1:
											try
											{
												base.ViewCacheNotifier.CFSNotifyViewCacheLicenseChanged(cfsUpdatedResult, true);
												goto IL_45A;
											}
											finally
											{
												num = (short)1780416514;
												num4 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num4)
													{
													case 0:
														automaticPerformanceMeasurer2.Dispose();
														num = (short)54198273;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														goto IL_425;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_3ED;
														}
														continue;
													}
													IL_3ED:
													if (automaticPerformanceMeasurer2 == null)
													{
														break;
													}
													num = (short)2030960640;
													num4 = (int)((global::System.IntPtr)num);
												}
												IL_425:;
											}
											goto IL_428;
											IL_45A:
											num = (short)1596719111;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											if (this.a.Keys.Contains(CS$<>8__locals1.rd))
											{
												num = (short)1820590085;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_35B;
										case 3:
											automaticPerformanceMeasurer3 = automaticPerformanceMeasurer4.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("装Ꟈ뻉ꗋ꣍ꧏ韓럕믗닙맛", a_));
											goto IL_38B;
										case 4:
											if (automaticPerformanceMeasurer4 == null)
											{
												num = (short)2111635467;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_428;
										case 5:
											cfsUpdatedResult = manageRadioLicenseService.RestoreDevice(selectedList, newTemplateDic, base.JobContainerGuid, this.a[CS$<>8__locals1.rd]);
											num = (short)843251721;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											num = (short)30932994;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
											goto IL_472;
										case 8:
											goto IL_274;
										case 9:
											goto IL_274;
										case 10:
											automaticPerformanceMeasurer3 = null;
											goto IL_38B;
										case 11:
											num = (short)1419247626;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_20C;
										IL_274:
										num = (short)447938564;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_35B:
										cfsUpdatedResult = manageRadioLicenseService.RestoreDevice(selectedList, newTemplateDic, base.JobContainerGuid, null);
										num = (short)1146683400;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_38B:
										automaticPerformanceMeasurer2 = automaticPerformanceMeasurer3;
										num = (short)228392961;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_428:
										num = (short)872415235;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_472:
									goto IL_569;
									IL_20C:
									selectedList = this.SelectRadioLicenses.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase license)
									{
										short num6 = (short)1596719104;
										short num7 = num6;
										num6 = (short)1862398771;
										short num8 = num6;
										num6 = (short)1749021491;
										switch (num8 == num6)
										{
										}
										num6 = (short)1811152897;
										if (num6 != 0)
										{
										}
										num6 = (short)1120927744;
										if (num6 != 0)
										{
										}
										return license.SerialNumber == CS$<>8__locals1.rd;
									}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>();
									manageRadioLicenseService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService;
									cfsUpdatedResult = null;
									num = (short)226295808;
									num4 = (int)((global::System.IntPtr)num);
									goto IL_1D5;
								}
								catch (global::Motorola.Common.CustomException.CommonException ex)
								{
									global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
									{
										JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
										ErrorCode = new int?((int)ex.ErrorCode),
										ErrorMessage = ex.Message,
										JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
										JobDescription = CS$<>8__locals1.rd
									};
									batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
									if (ex.CommonExceptionData != null)
									{
										batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
									}
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.AddBatchOperationJob(batchOperationJob);
								}
								catch (global::System.Exception ex2)
								{
									global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
									{
										ErrorCode = new int?(1),
										ErrorMessage = ex2.Message,
										Parameters = string.Empty,
										JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
										JobDescription = CS$<>8__locals1.rd,
										JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED
									};
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService.AddBatchOperationJob(job);
								}
								IL_569:
								num3++;
								base.ReportProgress(num3);
							}
							finally
							{
								num = (short)1157418054;
								short num5 = num;
								num = (short)609209414;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_60F:
									automaticPerformanceMeasurer4.Dispose();
									num = (short)1355743233;
									num4 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)938868736;
									if (num != 0)
									{
									}
									num = (short)2062286850;
									num4 = (int)((global::System.IntPtr)num);
									break;
								}
								for (;;)
								{
									switch (num4)
									{
									case 0:
										goto IL_60F;
									case 1:
										goto IL_62D;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5F6;
										}
										continue;
									}
									IL_5F6:
									if (automaticPerformanceMeasurer4 == null)
									{
										break;
									}
									num = (short)316801024;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_62D:;
							}
							break;
						case 5:
							num = (short)996868102;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_18F;
						case 7:
							if (base.CancellationPending)
							{
								num = (short)1168834565;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)503185409;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						case 9:
							automaticPerformanceMeasurer = null;
							goto IL_670;
						}
						IL_630:
						num = (short)1839005698;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_DD:
						goto IL_630;
						IL_670:
						automaticPerformanceMeasurer4 = automaticPerformanceMeasurer;
						num = (short)156368900;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_18F:
					IL_6A7:;
				}
				return;
			}
			}
		}

		// Token: 0x04000060 RID: 96
		private global::System.Collections.Generic.Dictionary<string, global::ASK.Interface.ISystemKeyData> a;

		// Token: 0x04000061 RID: 97
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> b;

		// Token: 0x04000062 RID: 98
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<string> c;
	}
}
