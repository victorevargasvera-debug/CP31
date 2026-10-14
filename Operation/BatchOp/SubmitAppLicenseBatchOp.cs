using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000030 RID: 48
	public class SubmitAppLicenseBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00023E20 File Offset: 0x00022020
		public SubmitAppLicenseBatchOp(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> selectedEidInfor)
		{
			base.SelectedItems = selectedEidInfor;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00023E3C File Offset: 0x0002203C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1638989824;
				short num2 = num;
				num = (short)1397722306;
				short num3 = num;
				num = (short)1937870018;
				switch (num3 == num)
				{
				}
				num = (short)515047425;
				if (num != 0)
				{
				}
				num = (short)837812224;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SubmitAppLicense;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00023EE8 File Offset: 0x000220E8
		public override string JobName
		{
			get
			{
				short num = (short)1850933248;
				short num2 = num;
				num = (short)22325231;
				short num3 = num;
				num = (short)310880239;
				switch (num3 == num)
				{
				}
				num = (short)519569408;
				if (num != 0)
				{
				}
				num = (short)768540673;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SubmitAppLicense;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00023F9C File Offset: 0x0002219C
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num;
			try
			{
				num = (short)1016856576;
				switch (num)
				{
				default:
					this.a();
					goto IL_83A;
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
				{
					JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
					ErrorCode = new int?((int)ex.ErrorCode),
					ErrorMessage = ex.Message,
					Parameters = string.Empty,
					JobDescription = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_AppLicense,
					JobContainerUuid = new global::System.Guid?(base.JobContainerGuid)
				};
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.AddBatchOperationJob(job);
				goto IL_85E;
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> enumerator;
			global::Motorola.CommonCPS.Server.EntityModel.FeatureList appLicensesFromLicenseServer;
			int num5;
			try
			{
				IL_90:
				num = (short)736952321;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_7C6;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_CF;
						}
						continue;
					case 2:
						goto IL_787;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1609039874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo eidinfo = enumerator.Current;
						num = (short)2092302341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1CB;
							}
							bool flag;
							for (;;)
							{
								IL_178:
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> list;
								int num3;
								switch (num2)
								{
								case 0:
									if (list.Count > 0)
									{
										num = (short)505872400;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_62C;
								case 1:
									if (flag)
									{
										num = (short)1933443077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num3 = CS$<>8__locals1.eidinfo.RadioCountUpdates;
									num = (short)1234305037;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_62C;
								case 3:
									num = (short)749010955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_62C;
								case 5:
								{
									global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
									{
										JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
										JobDescription = CS$<>8__locals1.eidinfo.FeatureName,
										JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED,
										ErrorCode = null
									};
									string warningMessage = global::Motorola.CommonCPS.Common.CommonUtility.WarningMessageConverter.OriginalToSource(global::Motorola.CommonCPS.Common.CommonUtility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(null, methodof(global::Motorola.CommonCPS.ResourceRepository.Resources.get_RMC_Warning_AppLicenseHasRegistered())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())), 0);
									batchOperationJob.WarningMessage = warningMessage;
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.AddBatchOperationJob(batchOperationJob);
									num = (short)1282605058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									if (list != null)
									{
										num = (short)716636168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_62C;
								case 7:
									if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsAppLicense(CS$<>8__locals1.eidinfo.ProductName))
									{
										num = (short)464977923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_302;
								case 8:
									num = (short)527564800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (this.a(CS$<>8__locals1.eidinfo.ProductName))
									{
										num = (short)239927306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_302;
								case 10:
									flag = true;
									num = (short)1483866129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsAppLicense_RadioManagement(CS$<>8__locals1.eidinfo.ProductName))
									{
										num = (short)189267982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_302;
								case 12:
									goto IL_645;
								case 13:
									if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsAppLicense_RadioManagement(CS$<>8__locals1.eidinfo.ProductName))
									{
										num = (short)1971126290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_425;
								case 14:
									goto IL_5DF;
								case 15:
									try
									{
										num = (short)172228608;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_54E;
												}
												continue;
											case 1:
												num = (short)2139947011;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)321716225;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.Server.EntityModel.FeatureItem featureItem = enumerator2.Current;
												num3 += featureItem.featureCount;
												num = (short)1457455108;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												goto IL_5CC;
											}
											IL_57D:
											num = (short)70778882;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_54E:
											goto IL_57D;
										}
										IL_5CC:
										goto IL_425;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_5DF;
								case 16:
									base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>(list);
									num = (short)1288372228;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_302;
								case 18:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>.Enumerator enumerator2 = appLicensesFromLicenseServer.features.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.FeatureItem ft)
									{
										short num7 = (short)2043026721;
										short num8 = num7;
										num7 = (short)1681005857;
										switch (num8 == num7)
										{
										default:
										{
											num7 = (short)177078272;
											short num9 = num7;
											break;
										}
										case true:
											break;
										}
										num7 = (short)1068957697;
										if (num7 != 0)
										{
										}
										num7 = (short)1508376576;
										if (num7 != 0)
										{
										}
										return CS$<>8__locals1.<>4__this.a(ft, CS$<>8__locals1.eidinfo.ActivationID);
									}).ToList<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>().GetEnumerator();
									num = (short)615383055;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_1CB;
								IL_302:
								num = (short)1935605761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_425:
								global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.SubmitAppLicense(CS$<>8__locals1.eidinfo.ActivationID, num3);
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job2 = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
								{
									JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
									JobDescription = CS$<>8__locals1.eidinfo.FeatureName,
									JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED
								};
								global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.AddBatchOperationJob(job2);
								list = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.ListAppLicenses();
								num = (short)1372258310;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5DF:
								num = (short)1797193737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_62C:
								num = (short)9437196;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_645:
							goto IL_109;
							IL_1CB:
							flag = false;
							num = (short)262406151;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_178;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex2)
						{
							global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob2 = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
							{
								JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
								ErrorCode = new int?((int)ex2.ErrorCode),
								ErrorMessage = ex2.Message
							};
							if (ex2.CommonExceptionData != null)
							{
								num = (short)514751852;
								short num4 = num;
								num = (short)69303660;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1608187904;
									if (num != 0)
									{
									}
									batchOperationJob2.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex2.CommonExceptionData.Paramters);
									break;
								}
							}
							batchOperationJob2.JobDescription = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_AppLicense;
							batchOperationJob2.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.AddBatchOperationJob(batchOperationJob2);
							goto IL_109;
						}
						catch (global::System.Exception ex3)
						{
							global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job3 = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
							{
								JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
								ErrorCode = new int?(1),
								ErrorMessage = ex3.Message,
								Parameters = string.Empty,
								JobDescription = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_AppLicense,
								JobContainerUuid = new global::System.Guid?(base.JobContainerGuid)
							};
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.AddBatchOperationJob(job3);
							goto IL_109;
						}
						goto IL_787;
						IL_109:
						num5++;
						base.ReportProgress(num5);
						num = (short)1189347332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_12B:
					num = (short)419168259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CF:
					goto IL_12B;
					IL_787:
					num = (short)969998337;
					if (num != 0)
					{
					}
					num = (short)1166737408;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7C6:
				goto IL_85E;
			}
			finally
			{
				num = (short)779681794;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1765998593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_837;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7FF;
						}
						continue;
					}
					IL_7FF:
					if (enumerator == null)
					{
						break;
					}
					num = (short)409403392;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_837:;
			}
			IL_83A:
			appLicensesFromLicenseServer = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.GetAppLicensesFromLicenseServer();
			num5 = 0;
			enumerator = base.SelectedItems.GetEnumerator();
			goto IL_90;
			IL_85E:
			num = (short)1426784256;
			short num6 = num;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000248AC File Offset: 0x00022AAC
		private void a()
		{
			int a_ = 5;
			short num = (short)1526333440;
			switch (num)
			{
			default:
			{
				num = (short)343670785;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1477181440;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_C2;
							}
							continue;
						case 1:
							goto IL_34E;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1594294281;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo eidinfo = enumerator.Current;
							num = (short)679739395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (dictionary.Keys.Contains(CS$<>8__locals1.eidinfo.Entitlement))
							{
								num = (short)1728839691;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)479330316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_DF;
						case 5:
							goto IL_29E;
						case 6:
							goto IL_DF;
						case 7:
							goto IL_192;
						case 8:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> list;
							global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo eidinfo2 = list.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo einfo)
							{
								short num5 = (short)1404502018;
								int num6 = (int)((global::System.IntPtr)num5);
								for (;;)
								{
									switch (num6)
									{
									case 0:
									{
										num5 = (short)1388707841;
										if (num5 != 0)
										{
										}
										num5 = (short)1957747820;
										short num7 = num5;
										num5 = (short)1024777324;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_12F;
										default:
											goto IL_EB;
										}
										break;
									}
									case 1:
										num5 = (short)264175619;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_34;
										}
										continue;
									case 3:
										goto IL_12F;
									}
									IL_34:
									num5 = (short)1243938816;
									short num8 = num5;
									if (einfo.Entitlement == CS$<>8__locals1.eidinfo.Entitlement)
									{
										num5 = (short)910229505;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									}
									return false;
									IL_12F:
									if (!(einfo.ActivationID == CS$<>8__locals1.eidinfo.ActivationID))
									{
										return false;
									}
									num5 = (short)2071920640;
									num6 = (int)((global::System.IntPtr)num5);
								}
								IL_EB:
								num5 = (short)1142423552;
								if (num5 != 0)
								{
								}
								return einfo.ProductName == CS$<>8__locals1.eidinfo.ProductName;
							});
							if (eidinfo2 == null)
							{
								goto Block_2;
							}
							if (global::System.Convert.ToInt32(eidinfo2.Available, global::System.Globalization.NumberFormatInfo.InvariantInfo) < global::System.Convert.ToInt32(CS$<>8__locals1.eidinfo.Available, global::System.Globalization.NumberFormatInfo.InvariantInfo))
							{
								num = (short)302252042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							num = (short)1036910593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_17A;
						case 11:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> list = dictionary[CS$<>8__locals1.eidinfo.Entitlement];
							num = (short)903741446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							try
							{
								string text;
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> list = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.QueryAppEIDInfo(CS$<>8__locals1.eidinfo.Entitlement, out text);
								goto IL_263;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								string message = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_License_Submit_Error + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null);
								throw new global::Motorola.Common.CustomException.CommonException(ex.ErrorCode, message);
							}
							goto IL_17A;
							IL_263:
							num = (short)1416495117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> list;
							if (list.Count<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>() == 0)
							{
								num = (short)403636229;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							dictionary.Add(CS$<>8__locals1.eidinfo.Entitlement, list);
							num = (short)1991180292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_C2;
						IL_DF:
						num = (short)1170735112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17A:
						num = (short)1643446279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E9:
						num = (short)1863385090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C2:
						goto IL_1E9;
					}
					Block_2:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralLicensing_Error);
					IL_192:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_RadioCountExceedsAvailable);
					IL_29E:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralLicensing_Error);
					IL_34E:;
				}
				finally
				{
					num = (short)1237450753;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_3BF;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_385;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1258422272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_385:
						if (enumerator == null)
						{
							goto IL_40D;
						}
						num = (short)517013506;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3BF:
					num = (short)1450213396;
					short num3 = num;
					num = (short)1907589140;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1127350272;
						if (num != 0)
						{
						}
						break;
					}
					IL_40D:;
				}
				num = (short)1274216448;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00024D24 File Offset: 0x00022F24
		private bool a(string A_0)
		{
			short num = (short)1857439574;
			short num2 = num;
			num = (short)774784854;
			switch (num2 == num)
			{
			default:
			{
				num = (short)453115904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)37421057;
			if (num != 0)
			{
			}
			num = (short)1528168448;
			if (num != 0)
			{
			}
			return !string.IsNullOrEmpty(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.GetAppLicenseNames(null).Where(delegate(string ls)
			{
				short num4 = (short)881641565;
				short num5 = num4;
				num4 = (short)2131937373;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)849870848;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)241041409;
				if (num4 != 0)
				{
				}
				num4 = (short)766574592;
				if (num4 != 0)
				{
				}
				return ls == A_0;
			}).FirstOrDefault<string>());
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00024E10 File Offset: 0x00023010
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.FeatureItem A_0, string A_1)
		{
			int a_ = 5;
			short num;
			if (!A_0.vendorString.StartsWith(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飉藋諍", a_), global::System.StringComparison.Ordinal))
			{
				num = (short)943682447;
				short num2 = num;
				num = (short)290026383;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1066532865;
					if (num != 0)
					{
					}
					num = (short)385089536;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)1803288576;
			short num3 = num;
			return A_0.vendorString.Substring(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飉藋諍", a_).Length).Equals(A_1);
		}

		// Token: 0x04000066 RID: 102
		private const string a = "RID=";
	}
}
