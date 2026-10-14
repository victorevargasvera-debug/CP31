using System;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000035 RID: 53
	public class PostFillActionResolver : global::Motorola.CommonCPS.UI.CellRangeFill.IPostFillActionResolver
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x0000E364 File Offset: 0x0000C564
		public global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction Resolve(bool changesPending, global::System.Exception ex)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			string content;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1039514826;
					short num3 = num2;
					num2 = (short)1443085514;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4A;
					default:
						goto IL_E0;
					}
					break;
				}
				case 1:
					goto IL_1AC;
				case 2:
				{
					num2 = (short)1180958721;
					if (num2 != 0)
					{
					}
					num2 = (short)524222464;
					short num4 = num2;
					this.InteractionHelper.ShowNotificationDialog(content, global::Motorola.CommonCPS.ResourceRepository.Resources.Attention_ID);
					num2 = (short)265355265;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)210436102;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_4A;
				case 5:
					if (!this.InteractionHelper.ShowConfirmationDialog(content, global::Motorola.CommonCPS.ResourceRepository.Resources.Attention_ID))
					{
						num2 = (short)253100032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction.Commit;
				case 6:
					if (ex != null)
					{
						num2 = (short)306380802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction.None;
				}
				goto IL_2C;
				IL_4A:
				if (!changesPending)
				{
					num2 = (short)585105411;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)797900805;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_E0:
			num2 = (short)1564016640;
			if (num2 != 0)
			{
			}
			return global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction.Undo;
			IL_1AC:
			return global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction.None;
			IL_2C:
			content = this.a(changesPending, ex);
			num2 = (short)1201209348;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000E524 File Offset: 0x0000C724
		private string a(bool A_0, global::System.Exception A_1)
		{
			int a_ = 9;
			short num = (short)600571904;
			short num2 = num;
			num = (short)311558148;
			int num3 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					text = text + global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("Ġ", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_CommitChanges;
					num = (short)67371009;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return text;
				case 2:
					goto IL_D7;
				case 3:
					text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_Successful;
					num = (short)97320962;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1431924078;
					short num4 = num;
					num = (short)205221230;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_150;
					default:
						num = (short)1807548416;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BE;
						}
						continue;
					}
					break;
				}
				case 5:
					if (A_0)
					{
						num = (short)389677057;
						if (num != 0)
						{
						}
						num = (short)39452672;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 6:
					goto IL_150;
				}
				IL_BE:
				if (A_1 == null)
				{
					num = (short)1788346371;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_Aborted;
				num = (short)985661446;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_D7:
				num = (short)1628307461;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_150:
				goto IL_D7;
			}
			return text;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000E6DC File Offset: 0x0000C8DC
		private global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction InteractionHelper
		{
			get
			{
				short num = (short)450973935;
				short num2 = num;
				num = (short)1885098223;
				switch (num2 == num)
				{
				}
				num = (short)102236161;
				if (num != 0)
				{
				}
				num = (short)912064512;
				if (num != 0)
				{
				}
				num = (short)1796407296;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance();
			}
		}
	}
}
