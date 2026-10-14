using System;
using System.ServiceModel;
using System.Threading;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.ServiceModel.CallBack;
using Motorola.CommonCPS.ServerCallbackContract;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000057 RID: 87
	[global::System.ServiceModel.CallbackBehavior(UseSynchronizationContext = false)]
	public class RMServerCallback : global::Motorola.CommonCPS.ServerCallbackContract.IServerCallback
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x00044748 File Offset: 0x00042948
		public RMServerCallback(global::System.Threading.SynchronizationContext synchronizationContext)
		{
			this.a = synchronizationContext;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00044764 File Offset: 0x00042964
		public void OnServerEvent(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventInfo e)
		{
			short num = (short)55181313;
			if (num != 0)
			{
			}
			num = (short)1838893758;
			short num2 = num;
			num = (short)1870744254;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A1:
				num = (short)234029058;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)904003584;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_104;
				case 1:
					this.a.Post(delegate
					{
						short num5 = (short)1371340802;
						int num6 = (int)((global::System.IntPtr)num5);
						for (;;)
						{
							switch (num6)
							{
							case 0:
								goto IL_AE;
							case 1:
								this.ServerEventArrived(e);
								num5 = (short)1718026240;
								num6 = (int)((global::System.IntPtr)num5);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_30;
								}
								continue;
							}
							goto IL_30;
							IL_3D:
							num5 = (short)1140129792;
							short num7 = num5;
							num5 = (short)404881409;
							num6 = (int)((global::System.IntPtr)num5);
							continue;
							IL_AE:
							num5 = (short)1187203384;
							short num8 = num5;
							num5 = (short)1953712440;
							switch ((num8 == num5) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3D;
							default:
								goto IL_E3;
							}
							IL_30:
							if (this.ServerEventArrived != null)
							{
								goto IL_3D;
							}
							goto IL_AE;
						}
						IL_E3:
						num5 = (short)212533248;
						if (num5 != 0)
						{
						}
						num5 = (short)1688666113;
						if (num5 != 0)
						{
						}
					}, null);
					num = (short)1376256000;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.a != null)
					{
						num = (short)2065498113;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_106;
				}
				goto IL_8D;
			}
			IL_104:
			IL_106:
			num = (short)381222912;
			short num4 = num;
			return;
			IL_8D:
			goto IL_A1;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000448A0 File Offset: 0x00042AA0
		public void OnRMServerEvent(global::Motorola.CommonCPS.Server.ServiceModel.CallBack.ServerEventInfo e)
		{
			short num = (short)1790905621;
			short num2 = num;
			num = (short)1105267989;
			switch (num2 == num)
			{
			}
			num = (short)1960509440;
			short num3 = num;
			num = (short)84017152;
			if (num != 0)
			{
			}
			num = (short)826015745;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000078 RID: 120
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler ServerEventArrived;

		// Token: 0x04000079 RID: 121
		private global::System.Threading.SynchronizationContext a;
	}
}
