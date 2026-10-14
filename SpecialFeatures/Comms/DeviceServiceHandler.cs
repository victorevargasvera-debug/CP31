using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Service;

namespace SpecialFeatures.Comms
{
	// Token: 0x020000E8 RID: 232
	[global::System.ServiceModel.CallbackBehavior(UseSynchronizationContext = false)]
	public class DeviceServiceHandler : global::Motorola.Common.Communication.Service.IOperationServiceEvent
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000DD2 RID: 3538 RVA: 0x00130964 File Offset: 0x0012EB64
		// (remove) Token: 0x06000DD3 RID: 3539 RVA: 0x00130A98 File Offset: 0x0012EC98
		public event global::System.ComponentModel.ProgressChangedEventHandler ProgressEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					short num = (short)444071936;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					int num3;
					global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler;
					for (;;)
					{
						IL_33:
						switch (num3)
						{
						case 0:
							num = (short)533790721;
							if (num != 0)
							{
							}
							goto IL_88;
						case 1:
							return;
						case 2:
						{
							global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler2;
							if (progressChangedEventHandler == progressChangedEventHandler2)
							{
								num = (short)1627193345;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_88;
						}
						}
						break;
						IL_88:
						num = (short)2069369829;
						short num4 = num;
						num = (short)453645285;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)202571776;
							if (num != 0)
							{
							}
							global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler2 = progressChangedEventHandler;
							global::System.ComponentModel.ProgressChangedEventHandler value2 = (global::System.ComponentModel.ProgressChangedEventHandler)global::System.Delegate.Combine(progressChangedEventHandler2, value);
							progressChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.ProgressChangedEventHandler>(ref this.a, value2, progressChangedEventHandler2);
							num = (short)881917954;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_45:
					progressChangedEventHandler = this.a;
					num = (short)1919025152;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_33;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					short num = (short)114098176;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					int num3;
					global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler;
					for (;;)
					{
						IL_34:
						switch (num3)
						{
						case 0:
							goto IL_63;
						case 1:
							return;
						case 2:
						{
							global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler2;
							if (progressChangedEventHandler == progressChangedEventHandler2)
							{
								num = (short)1116078081;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_63;
						}
						}
						break;
						IL_63:
						num = (short)937372802;
						short num4 = num;
						num = (short)1059007618;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)758710272;
							if (num != 0)
							{
							}
							num = (short)1813250049;
							if (num != 0)
							{
							}
							global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler2 = progressChangedEventHandler;
							global::System.ComponentModel.ProgressChangedEventHandler value2 = (global::System.ComponentModel.ProgressChangedEventHandler)global::System.Delegate.Remove(progressChangedEventHandler2, value);
							progressChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.ProgressChangedEventHandler>(ref this.a, value2, progressChangedEventHandler2);
							num = (short)1249116162;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_46:
					progressChangedEventHandler = this.a;
					num = (short)553975808;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_34;
				}
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00130BD0 File Offset: 0x0012EDD0
		public void OnProgress(int percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			short num = (short)424585860;
			short num2 = num;
			num = (short)1700833924;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D1:
				num = (short)1048969218;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1538654208;
				if (num != 0)
				{
				}
				num = (short)976355329;
				if (num != 0)
				{
				}
				num = (short)2037055488;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)82116608;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_C9;
					}
					continue;
				}
				case 1:
					return;
				case 2:
					this.a(this, new global::System.ComponentModel.ProgressChangedEventArgs(percent, processStatus.ToString()));
					num = (short)1422196737;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_C9:
			if (this.a != null)
			{
				goto IL_D1;
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00130CFC File Offset: 0x0012EEFC
		internal void OnClientStatusCheck()
		{
			short num = (short)708384992;
			short num2 = num;
			num = (short)588847328;
			switch (num2 == num)
			{
			}
			num = (short)350224385;
			if (num != 0)
			{
			}
			num = (short)1167458304;
			if (num != 0)
			{
			}
			num = (short)661454848;
			short num3 = num;
		}

		// Token: 0x0400071D RID: 1821
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.ProgressChangedEventHandler a;
	}
}
