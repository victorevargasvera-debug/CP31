using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Operation.RadioConversion
{
	// Token: 0x02000003 RID: 3
	public abstract class AbstractConversionSequence : global::System.IDisposable
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		protected AbstractConversionSequence()
		{
			this._serverAccessor = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
			this._migrationOpUtility = global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.Instance;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002148 File Offset: 0x00000348
		protected AbstractConversionSequence(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.IMigrationOpUtility migrationOpUtility)
		{
			this._serverAccessor = serverAccessor;
			this._migrationOpUtility = migrationOpUtility;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000216C File Offset: 0x0000036C
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)366219488;
				short num2 = num;
				num = (short)1928204512;
				switch (num2 == num)
				{
				}
				num = (short)429785088;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)1807810561;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)796065792;
			short num3 = num;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002234 File Offset: 0x00000434
		public void Dispose()
		{
			short num = (short)378282453;
			short num2 = num;
			num = (short)1963794901;
			switch (num2 == num)
			{
			}
			num = (short)727908353;
			if (num != 0)
			{
			}
			num = (short)1117716480;
			short num3 = num;
			num = (short)866385920;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022EC File Offset: 0x000004EC
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1593835520;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
				{
					num = (short)1294336001;
					if (num != 0)
					{
					}
					num = (short)755571609;
					short num3 = num;
					num = (short)1701321625;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					case 1:
						goto IL_104;
					}
					goto Block_2;
				}
				case 2:
					this._migrationOpUtility.ClearLocalFolder(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.CpdFile);
					this.a = true;
					num = (short)1990262785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
					IL_30:
					if (this.a)
					{
						return;
					}
					num = (short)966918146;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			Block_2:
			num = (short)1954283520;
			short num4 = num;
			IL_104:
			num = (short)254672896;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000003 RID: 3
		private bool a;

		// Token: 0x04000004 RID: 4
		protected readonly global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor _serverAccessor;

		// Token: 0x04000005 RID: 5
		protected readonly global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.IMigrationOpUtility _migrationOpUtility;
	}
}
