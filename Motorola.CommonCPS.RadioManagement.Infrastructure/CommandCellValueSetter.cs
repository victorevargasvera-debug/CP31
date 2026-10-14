using System;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000034 RID: 52
	public class CommandCellValueSetter : global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBase
	{
		// Token: 0x060000CD RID: 205 RVA: 0x0000DC08 File Offset: 0x0000BE08
		public CommandCellValueSetter(global::System.Windows.Input.ICommand editModeStartedCommand, global::System.Windows.Input.ICommand editModeEndedCommand, global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver editabilityResolver)
		{
			int a_ = 2;
			base..ctor(editabilityResolver);
			if (editModeStartedCommand == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("缙砛眝吟漡䬣䈥䴧礩堫伭䈯䘱儳刵笷唹儻匽ℿⱁ⁃", a_));
			}
			if (editModeEndedCommand == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("缙砛眝吟漡䬣䈥䴧漩䈫䨭唯嘱眳夵唷圹崻倽␿", a_));
			}
			this.a = editModeStartedCommand;
			this.b = editModeEndedCommand;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000DC68 File Offset: 0x0000BE68
		protected virtual object GetCommandParameter(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh)
		{
			short num = (short)488857336;
			short num2 = num;
			num = (short)1379360504;
			switch (num2 == num)
			{
			default:
			{
				num = (short)152698880;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2135359489;
			if (num != 0)
			{
			}
			num = (short)1171390464;
			if (num != 0)
			{
			}
			return new object[]
			{
				cell.Record.DataItem,
				cell.Field.Name,
				value,
				supressNotification,
				commit,
				refresh
			};
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000DD58 File Offset: 0x0000BF58
		public override bool CanSetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value)
		{
			int a_ = 13;
			if (cell != null)
			{
				short num = (short)1055457280;
				short num2 = num;
				num = (short)1524103407;
				short num3 = num;
				num = (short)1974728943;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)418840576;
					if (num != 0)
					{
					}
					num = (short)1782775809;
					if (num != 0)
					{
					}
					return cell.Record.DataItem != null;
				}
			}
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䘤䈦䔨䜪", a_));
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000DE30 File Offset: 0x0000C030
		public override void SetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh)
		{
			int a_ = 9;
			if (cell != null)
			{
				short num = (short)159776768;
				short num2 = num;
				num = (short)1406397872;
				short num3 = num;
				num = (short)1827532208;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1453981697;
					if (num != 0)
					{
					}
					num = (short)1092616192;
					if (num != 0)
					{
					}
					this.CheckSettability(cell, value);
					cell.IsActive = true;
					object commandParameter = this.GetCommandParameter(cell, value, supressNotification, commit, refresh);
					this.a.Execute(commandParameter);
					this.b.Execute(commandParameter);
					return;
				}
				}
			}
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䈠䘢䤤䬦", a_));
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000DF30 File Offset: 0x0000C130
		public override bool TrySetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh, out global::System.Exception ex)
		{
			int a_ = 18;
			short num = (short)256573441;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						this.SetValue(cell, value, supressNotification, commit, refresh);
						goto IL_13C;
					}
					catch (global::System.Exception ex2)
					{
						ex = ex2;
						goto IL_13C;
					}
					goto IL_10A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					goto IL_F2;
				}
				IL_3A:
				num = (short)1504968705;
				if (num != 0)
				{
				}
				num = (short)138691283;
				short num3 = num;
				num = (short)401228499;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_128;
				default:
				{
					num = (short)43778048;
					short num4 = num;
					num = (short)383844352;
					if (num != 0)
					{
					}
					if (cell == null)
					{
						num = (short)843186178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_10A:
				ex = null;
				num = (short)757465088;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F2:
			IL_128:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䤩䤫䈭尯", a_));
			IL_13C:
			return ex == null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000E090 File Offset: 0x0000C290
		protected void CheckSettability(global::Infragistics.Windows.DataPresenter.Cell cell, object value)
		{
			int a_ = 5;
			short num = (short)1499136002;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_125;
				case 1:
					goto IL_D7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					if (!this.CanSetValue(cell, value))
					{
						num = (short)1270808576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_3E:
				if (!base.IsEditable(cell))
				{
					num = (short)537296561;
					short num3 = num;
					num = (short)499482289;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						num = (short)815202305;
						if (num != 0)
						{
						}
						num = (short)640679936;
						if (num != 0)
						{
						}
						num = (short)1346961409;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)22806531;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_D7:
			num = (short)1338245120;
			short num4 = num;
			throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("帜稞䴠伢Ԥ並娨ପ䌬䀮䔰ጲ倴匶倸伺尼崾ⵀ♂", a_));
			IL_D9:
			throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䬜縞䴠嘢䀤ܦ䀨堪ബ䄮帰䜲ᔴ䐶尸伺䤼帾⍀⽂⁄杆⽈⑊㽌潎═㭒㱔⑖祘㡚㡜㍞ൠ", a_));
			IL_125:
			goto IL_D9;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000E204 File Offset: 0x0000C404
		protected global::System.Windows.Input.ICommand EditModeStartedCommand
		{
			get
			{
				short num = (short)1735734696;
				short num2 = num;
				num = (short)338965928;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1904345088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1066598401;
				if (num != 0)
				{
				}
				num = (short)1314783232;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		protected global::System.Windows.Input.ICommand EditModeEndedCommand
		{
			get
			{
				short num = (short)1147467879;
				short num2 = num;
				num = (short)883226727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)976945152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1246494721;
				if (num != 0)
				{
				}
				num = (short)428539904;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Input.ICommand a;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Input.ICommand b;
	}
}
