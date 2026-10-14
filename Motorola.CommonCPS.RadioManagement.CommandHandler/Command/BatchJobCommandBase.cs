using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.CommonCPS.RadioManagement.BatchOp;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000015 RID: 21
	public abstract class BatchJobCommandBase : global::Motorola.CommonCPS.RadioManagement.Command.SimpleCommandBase
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00007624 File Offset: 0x00005824
		protected BatchJobCommandBase(global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOpManager batchOpManager)
		{
			this.a = batchOpManager;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00007640 File Offset: 0x00005840
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000076F0 File Offset: 0x000058F0
		private protected global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp BatchOp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)1809686138;
				short num2 = num;
				num = (short)1106288250;
				switch (num2 == num)
				{
				}
				num = (short)1733689345;
				if (num != 0)
				{
				}
				num = (short)1891827712;
				if (num != 0)
				{
				}
				num = (short)191037440;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)930316068;
				short num2 = num;
				num = (short)1010663204;
				switch (num2 == num)
				{
				}
				num = (short)1265303553;
				if (num != 0)
				{
				}
				num = (short)1818296320;
				if (num != 0)
				{
				}
				num = (short)323420160;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000077A0 File Offset: 0x000059A0
		public global::System.Guid? WaitBatchOpDone()
		{
			short num = (short)1307947120;
			short num2 = num;
			num = (short)576368752;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_87:
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)1177026560;
				short num3 = num;
				goto IL_5D;
			}
			}
			int num4;
			for (;;)
			{
				IL_91:
				switch (num4)
				{
				case 0:
					num = (short)955187201;
					if (num != 0)
					{
					}
					goto IL_D0;
				case 1:
					if (this.BatchOp.Completed)
					{
						num = (short)50003972;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Threading.Thread.Sleep(5);
					num = (short)1653342211;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2103443456;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_D0;
				case 4:
					goto IL_108;
				case 5:
					goto IL_87;
				}
				goto IL_AF;
				IL_D0:
				num = (short)597622785;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_108:
			return new global::System.Guid?(this.BatchOp.JobContainerGuid);
			IL_5D:
			num = (short)2064646144;
			if (num != 0)
			{
			}
			num = (short)1393557509;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_91;
			IL_AF:
			if (this.BatchOp != null)
			{
				num = (short)1357250562;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_91;
			}
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007938 File Offset: 0x00005B38
		protected void ExecuteBatchOp<T>(global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<T> op)
		{
			short num = (short)459262418;
			short num2 = num;
			num = (short)1531169234;
			switch (num2 == num)
			{
			}
			num = (short)1748893697;
			if (num != 0)
			{
			}
			num = (short)226295808;
			if (num != 0)
			{
			}
			num = (short)315162624;
			short num3 = num;
			op.CreatedTime = global::System.DateTime.UtcNow;
			this.BatchOp = op;
			this.a.Run(op);
		}

		// Token: 0x0400001B RID: 27
		private readonly global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOpManager a;

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp b;
	}
}
