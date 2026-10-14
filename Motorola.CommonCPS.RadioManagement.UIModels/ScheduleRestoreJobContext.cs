using System;
using System.Windows;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000089 RID: 137
	public class ScheduleRestoreJobContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x00049784 File Offset: 0x00047984
		public ScheduleRestoreJobContext()
		{
			base.ContentOfWriteLabel = global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Restore;
			base.InvisibleWhileRestoreJob = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000497AC File Offset: 0x000479AC
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x0004985C File Offset: 0x00047A5C
		public global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob RestoreJob
		{
			get
			{
				short num = (short)16553316;
				short num2 = num;
				num = (short)1441568100;
				switch (num2 == num)
				{
				}
				num = (short)1987575809;
				if (num != 0)
				{
				}
				num = (short)1974861824;
				if (num != 0)
				{
				}
				num = (short)758972416;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)2037776385;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
					{
						num = (short)957284353;
						if (num != 0)
						{
						}
						num = (short)1711988303;
						short num3 = num;
						num = (short)1888280143;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1536884736;
							if (num != 0)
							{
							}
							num = (short)527433728;
							short num4 = num;
							this.a = value;
							break;
						}
						}
						num = (short)1479933952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_32:
					if (value == this.a)
					{
						break;
					}
					num = (short)700317698;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0400024E RID: 590
		private global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob a;
	}
}
