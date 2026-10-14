using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200003B RID: 59
	public class ConvertRadioInBackgroundCommand : global::Motorola.CommonCPS.RadioManagement.Command.BatchJobCommandBase
	{
		// Token: 0x0600024F RID: 591 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
		public ConvertRadioInBackgroundCommand(global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOpManager batchOpManager, global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase validationUiServiceBase) : base(batchOpManager)
		{
			this.a = validationUiServiceBase;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001EA14 File Offset: 0x0001CC14
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1747779584;
			switch (num)
			{
			default:
			{
				num = (short)571670529;
				if (num != 0)
				{
				}
				num = (short)1191444485;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3AD;
					case 1:
						goto IL_2FE;
					case 2:
					{
						if (!paras.Any<object>())
						{
							num = (short)896532481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerable = paras[0] as global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
						num = (short)1125908486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						IL_AC:
						num = (short)2064973826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_3ED;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 6:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerable;
						if (enumerable != null)
						{
							num = (short)1189937159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D2;
					}
					case 7:
						num = (short)36831240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerable;
						if (!enumerable.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>())
						{
							num = (short)1224278020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = enumerable.GetEnumerator();
						num = (short)714866688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_90:
					if (paras != null)
					{
						num = (short)442433539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2FE:
					num = (short)2084666415;
					short num3 = num;
					num = (short)1809218607;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AC;
					default:
						goto IL_334;
					}
				}
				IL_2D2:
				num = (short)1145044992;
				short num4 = num;
				return false;
				IL_334:
				num = (short)1735393280;
				if (num != 0)
				{
				}
				return false;
				IL_3AD:
				try
				{
					num = (short)1127415816;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							if (this.a(radioBase))
							{
								num = (short)2111438853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FD;
						}
						case 1:
							goto IL_15A;
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1154613254;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)1586429963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							result = false;
							num = (short)304676865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_262;
						case 5:
							result = false;
							num = (short)940179465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1403125764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							if (!this.a.CanCreateJob(radioBase.JobStatus))
							{
								num = (short)1152385027;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							switch (0)
							{
							case 0:
								goto IL_107;
							}
							continue;
						case 9:
							goto IL_1F8;
						case 10:
							num = (short)1498415104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							if (!this.b(radioBase))
							{
								num = (short)893845514;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FD;
						}
						}
						IL_109:
						num = (short)1070465026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_107:
						goto IL_109;
						IL_1FD:
						num = (short)374734855;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_15A:
					IL_1F8:
					return result;
					IL_262:
					return true;
				}
				finally
				{
					num = (short)83427328;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_299;
							}
							continue;
						case 1:
							goto IL_2CF;
						case 2:
							enumerator.Dispose();
							num = (short)726401025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_299:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1247281154;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2CF:;
				}
				IL_3ED:
				goto IL_2D2;
			}
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001EE78 File Offset: 0x0001D078
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)448873479;
			short num2 = num;
			num = (short)953107463;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1156972544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1529413632;
			if (num != 0)
			{
			}
			num = (short)1003028481;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.RadioConversionBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.RadioConversionBatchOp((global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>)paras[0]);
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
			return true;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001EF3C File Offset: 0x0001D13C
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			short num;
			int num2;
			global::System.Guid? workingTemplateUuid;
			global::System.Guid empty;
			for (;;)
			{
				IL_0A:
				num = (short)1323827201;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_147;
				case 1:
					if (workingTemplateUuid == null)
					{
						num = (short)299106309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_191;
				case 2:
					if (workingTemplateUuid != null)
					{
						num = (short)61669376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
				{
					if (workingTemplateUuid == null)
					{
						num = (short)703070212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1988611321;
					short num3 = num;
					num = (short)1578814713;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_147;
					default:
					{
						num = (short)246743040;
						if (num != 0)
						{
						}
						num = (short)1644232704;
						short num4 = num;
						num = (short)1779040257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					return true;
				case 5:
					return false;
				}
				goto IL_4F;
				IL_147:
				workingTemplateUuid = A_0.WorkingTemplateUuid;
				empty = global::System.Guid.Empty;
				num = (short)1182728195;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_191:
			return workingTemplateUuid.GetValueOrDefault() != empty;
			IL_4F:
			workingTemplateUuid = A_0.WorkingTemplateUuid;
			num = (short)1422458882;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001F0EC File Offset: 0x0001D2EC
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::System.Guid? workingConfigurationUuid;
			global::System.Guid empty;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
				{
					num2 = (short)239796225;
					if (num2 != 0)
					{
					}
					num2 = (short)1897136128;
					short num3 = num2;
					if (workingConfigurationUuid == null)
					{
						num2 = (short)2129723392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1894645765;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					workingConfigurationUuid = A_0.WorkingConfigurationUuid;
					empty = global::System.Guid.Empty;
					num2 = (short)1124728834;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (workingConfigurationUuid != null)
					{
						num2 = (short)1517289475;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					if (workingConfigurationUuid == null)
					{
						num2 = (short)527630337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_191;
				}
				goto IL_28;
			}
			return false;
			IL_191:
			return workingConfigurationUuid.GetValueOrDefault() != empty;
			IL_28:
			workingConfigurationUuid = A_0.WorkingConfigurationUuid;
			num2 = (short)781175171;
			short num4 = num2;
			num2 = (short)810797443;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
			{
				num2 = (short)239599616;
				if (num2 != 0)
				{
				}
				num2 = (short)389939204;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0400003F RID: 63
		private readonly global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase a;
	}
}
