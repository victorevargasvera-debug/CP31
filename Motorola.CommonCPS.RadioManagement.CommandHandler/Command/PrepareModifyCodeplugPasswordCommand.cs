using System;
using System.Collections;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000055 RID: 85
	public class PrepareModifyCodeplugPasswordCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002CC RID: 716 RVA: 0x000296B8 File Offset: 0x000278B8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1924333568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::System.Collections.ICollection collection;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (collection.Count != 0)
						{
							num = (short)1587740672;
							short num3 = num;
							num = (short)1526202383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						return true;
					case 2:
					{
						if (collection.Count > 1)
						{
							num = (short)1425735685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = collection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().FirstOrDefault<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						num = (short)186581000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_19F;
					case 4:
						if (collection != null)
						{
							num = (short)1370554382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						goto IL_1E1;
					case 6:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
						if (jobStatus.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CANCELED)
						{
							num = (short)926482441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 7:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
						if (jobStatus.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_EXPIRED)
						{
							num = (short)1382416395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 8:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						if (radioBase.RadioStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New)
						{
							return false;
						}
						num = (short)1533997109;
						short num4 = num;
						num = (short)2021781557;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3FC;
						default:
							num = (short)1243676672;
							if (num != 0)
							{
							}
							num = (short)927858701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
						num = (short)1753546759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
						if (jobStatus.Value == global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED)
						{
							num = (short)408027139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
						num = (short)305332236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
						if (jobStatus.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED)
						{
							num = (short)1457782800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 13:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						bool? isOutOfSync = radioBase.IsOutOfSync;
						bool flag = true;
						num = (short)1525219345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)486735872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1913454594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
						num = (short)1558773770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						bool? isOutOfSync;
						bool flag;
						if (isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null)
						{
							num = (short)1768292370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
						num = (short)1928658963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_3FC;
					case 19:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
						if (jobStatus == null)
						{
							num = (short)983171073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						jobStatus = radioBase.JobStatus;
						num = (short)2069889030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7F;
				}
				return true;
				IL_19F:
				return true;
				IL_1E1:
				num = (short)2058551297;
				if (num != 0)
				{
				}
				return false;
				IL_3FC:
				return false;
				IL_7F:
				collection = (paras[0] as global::System.Collections.ICollection);
				num = (short)1912406020;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00029AC8 File Offset: 0x00027CC8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)39811742;
			short num2 = num;
			num = (short)464550558;
			switch (num2 == num)
			{
			default:
			{
				num = (short)611123200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1742667777;
			if (num != 0)
			{
			}
			num = (short)1287127040;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
