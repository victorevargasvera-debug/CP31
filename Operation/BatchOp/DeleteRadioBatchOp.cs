using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200004D RID: 77
	public class DeleteRadioBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x0002CBC4 File Offset: 0x0002ADC4
		public DeleteRadioBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> rds)
		{
			base.SelectedItems = rds;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)784400385;
				if (num != 0)
				{
				}
				num = (short)2138636288;
				short num2 = num;
				num = (short)938370781;
				short num3 = num;
				num = (short)919103197;
				switch (num3 == num)
				{
				}
				num = (short)1002045440;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteRadios;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0002CC8C File Offset: 0x0002AE8C
		public override string JobName
		{
			get
			{
				short num = (short)1261349760;
				short num2 = num;
				num = (short)637840256;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1704656896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1856765953;
				if (num != 0)
				{
				}
				num = (short)386531328;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.DeleteRadioBatchJob;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0002CD3C File Offset: 0x0002AF3C
		public override bool IsSafe
		{
			get
			{
				short num = (short)1711743565;
				short num2 = num;
				num = (short)179839565;
				switch (num2 == num)
				{
				default:
				{
					num = (short)315162624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1654521856;
				if (num != 0)
				{
				}
				num = (short)1654521857;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)70844416;
			switch (num)
			{
			default:
			{
				num = (short)2064318464;
				short num2 = num;
				num = (short)1233453057;
				if (num != 0)
				{
				}
				int num3 = 0;
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1691025411;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1410269186;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.Radio item = enumerator.Current.ToServerModel();
							list.Add(item);
							num = (short)1350172672;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)824901636;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_386;
							}
							continue;
						case 4:
							goto IL_401;
						}
						IL_3B2:
						num = (short)294584321;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_386:
						goto IL_3B2;
					}
					IL_401:
					goto IL_33E;
				}
				finally
				{
					num = (short)1068171265;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)835780610;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_438;
							}
							continue;
						case 2:
							goto IL_470;
						}
						IL_438:
						if (enumerator == null)
						{
							break;
						}
						num = (short)216858624;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_470:;
				}
				return;
				for (;;)
				{
					IL_33E:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Radio> enumerator2 = list.GetEnumerator();
					try
					{
						num = (short)126287873;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								if (base.CancellationPending)
								{
									num = (short)1098317826;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)115146756;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_D3;
								}
								continue;
							case 2:
								goto IL_298;
							case 3:
								num = (short)124780550;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								try
								{
									global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.DeleteDevice(base.JobContainerGuid, radio);
									goto IL_177;
								}
								catch (global::Motorola.Common.CustomException.CommonException ex)
								{
									global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
									global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
									batchOperationJob.JobDescription = radio.SerialNumber;
									batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
									batchOperationJob.ErrorMessage = ex.Message;
									if (ex.CommonExceptionData != null)
									{
										for (;;)
										{
											num = (short)1265475524;
											short num5 = num;
											num = (short)1846190020;
											switch ((num5 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												goto IL_237;
											}
										}
										IL_237:
										num = (short)119406592;
										if (num != 0)
										{
										}
										batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
									}
									batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
									batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(batchOperationJob);
									goto IL_177;
								}
								goto IL_298;
								IL_177:
								num3++;
								base.ReportProgress(num3);
								num = (short)1245380613;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_2CD;
							case 7:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1277493251;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.Radio radio = enumerator2.Current;
								num = (short)691535872;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_2B0;
							}
							IL_D8:
							num = (short)1508179975;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_D3:
							goto IL_D8;
							IL_298:
							num = (short)1410400264;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2B0:
						IL_2CD:
						break;
					}
					finally
					{
						num = (short)722534401;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								enumerator2.Dispose();
								num = (short)2037776386;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_304;
								}
								continue;
							case 2:
								goto IL_33B;
							}
							IL_304:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)117374976;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_33B:;
					}
				}
				return;
			}
			}
		}
	}
}
