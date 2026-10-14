using System;
using Motorola.CommonCPS.RadioManagement.BatchOp;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000024 RID: 36
	internal class CancelDBMigrationBacthOpCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x000191C0 File Offset: 0x000173C0
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1216526651;
			short num2 = num;
			num = (short)198293819;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1305542656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)628293632;
			if (num != 0)
			{
			}
			num = (short)259850241;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001926C File Offset: 0x0001746C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1451032576;
			short num2 = num;
			num = (short)294176724;
			short num3 = num;
			num = (short)1352779732;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)477888512;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				int num4;
				global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp;
				for (;;)
				{
					IL_7D:
					switch (num4)
					{
					case 0:
						if (batchOp != null)
						{
							num = (short)1243283457;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 1:
						batchOp.CancelAsync();
						num = (short)1952841730;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_EE;
					}
					goto IL_8F;
				}
				IL_EE:
				break;
				IL_8F:
				global::System.Guid jbcId = (global::System.Guid)paras[0];
				batchOp = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance.FindByJbcId(jbcId);
				num = (short)1267662848;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
			}
			IL_F0:
			num = (short)998965249;
			if (num != 0)
			{
			}
			return true;
		}
	}
}
