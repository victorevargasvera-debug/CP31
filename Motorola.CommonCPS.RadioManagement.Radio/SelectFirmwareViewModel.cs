using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000024 RID: 36
	public class SelectFirmwareViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x060001AD RID: 429 RVA: 0x0001F10C File Offset: 0x0001D30C
		public SelectFirmwareViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext) : base(eventAggregator, commandHandler)
		{
			this.SelectFirmwareContext = selectFirmwareContext;
			this.SelectFirmwareContext.PropertyChanged += this.a;
			this.SelectFirmwareCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d), new global::System.Func<bool>(this.b));
			this.SelectFirmwareContext.OKCommandExecuted = false;
			this.SelectFirmwareContext.CancelCommandExecuted = false;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001F17C File Offset: 0x0001D37C
		private void a(global::System.Action A_0)
		{
			short num;
			try
			{
				this.SelectFirmwareContext.OKCommandExecuted = true;
				global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
				try
				{
					A_0();
				}
				finally
				{
					num = (short)737345537;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)279983109;
						short num3 = num;
						num = (short)15086597;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1077018624;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_CE;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_98;
								}
								continue;
							case 2:
								goto IL_AF;
							}
							IL_98:
							if (waitCursor != null)
							{
								num = (short)150274050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D0;
						}
						IL_AF:
						((global::System.IDisposable)waitCursor).Dispose();
						num = (short)1743519744;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_CE:
					IL_D0:;
				}
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SelectFirmwareContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1392574465;
			if (num != 0)
			{
			}
			num = (short)2104426496;
			short num4 = num;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		private bool a(global::System.Func<bool> A_0)
		{
			short num;
			bool result;
			try
			{
				num = (short)1872866584;
				short num2 = num;
				num = (short)1196666136;
				switch (num2 == num)
				{
				}
				num = (short)1694433280;
				if (num != 0)
				{
				}
				result = A_0();
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1631191041;
			if (num != 0)
			{
			}
			num = (short)1599995904;
			short num3 = num;
			return result;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0001F3BC File Offset: 0x0001D5BC
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0001F46C File Offset: 0x0001D66C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext SelectFirmwareContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1795686401;
				if (num != 0)
				{
				}
				num = (short)508559360;
				short num2 = num;
				num = (short)719528051;
				short num3 = num;
				num = (short)484384883;
				switch (num3 == num)
				{
				}
				num = (short)214237184;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1483390546;
				short num2 = num;
				num = (short)612154962;
				switch (num2 == num)
				{
				}
				num = (short)1668415488;
				short num3 = num;
				num = (short)411435008;
				if (num != 0)
				{
				}
				num = (short)1345191937;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0001F51C File Offset: 0x0001D71C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0001F5CC File Offset: 0x0001D7CC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectFirmwareCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)496815981;
				short num2 = num;
				num = (short)1450364781;
				switch (num2 == num)
				{
				}
				num = (short)1003618304;
				short num3 = num;
				num = (short)167772161;
				if (num != 0)
				{
				}
				num = (short)799670272;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)888799233;
				if (num != 0)
				{
				}
				num = (short)1305210849;
				short num2 = num;
				num = (short)1484451809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785266176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1537409024;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0001F67C File Offset: 0x0001D87C
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)640583023;
			short num2 = num;
			num = (short)256148847;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1004797952;
				if (num != 0)
				{
				}
				if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("蓀믂ꛄꋆ마뿊꓌ꃎ뿐黒냔ꓖ꫘뫚뫜뫞", a_)))
				{
					this.SelectFirmwareContext.ExceptionMessage = string.Empty;
					this.SelectFirmwareCommand.RaiseCanExecuteChanged();
					return;
				}
				num = (short)2079784961;
				if (num != 0)
				{
				}
				num = (short)437387264;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001F764 File Offset: 0x0001D964
		protected override void OnWindowClosed()
		{
			short num = (short)1762969136;
			short num2 = num;
			num = (short)797623856;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)467599360;
				if (num != 0)
				{
				}
				base.OnWindowClosed();
				if (!this.SelectFirmwareContext.OKCommandExecuted)
				{
					this.SelectFirmwareContext.CancelCommandExecuted = true;
					return;
				}
				num = (short)1246494721;
				if (num != 0)
				{
				}
				num = (short)2115305472;
				short num3 = num;
				break;
			}
			}
			this.SelectFirmwareContext.CancelCommandExecuted = false;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001F83C File Offset: 0x0001DA3C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d()
		{
			short num = (short)1853955856;
			short num2 = num;
			num = (short)1044258576;
			switch (num2 == num)
			{
			}
			num = (short)973012992;
			short num3 = num;
			num = (short)181927937;
			if (num != 0)
			{
			}
			num = (short)1169096704;
			if (num != 0)
			{
			}
			this.a(new global::System.Action(this.c));
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001F8F4 File Offset: 0x0001DAF4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c()
		{
			short num = (short)948043777;
			if (num != 0)
			{
			}
			num = (short)614894118;
			short num2 = num;
			num = (short)818186790;
			switch (num2 == num)
			{
			default:
			{
				num = (short)281673728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)831389696;
			if (num != 0)
			{
			}
			base.CommandHandler.SelectFirmwareForUpgradeCommand.Execute(new object[]
			{
				this.SelectFirmwareContext
			});
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b()
		{
			short num = (short)613677753;
			short num2 = num;
			num = (short)212597433;
			switch (num2 == num)
			{
			}
			num = (short)1466040320;
			short num3 = num;
			num = (short)1346961408;
			if (num != 0)
			{
			}
			num = (short)1860632577;
			if (num != 0)
			{
			}
			return this.a(new global::System.Func<bool>(this.a));
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001FA78 File Offset: 0x0001DC78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a()
		{
			short num = (short)2131654395;
			short num2 = num;
			num = (short)894924539;
			switch (num2 == num)
			{
			}
			num = (short)1102839808;
			short num3 = num;
			num = (short)1328939009;
			if (num != 0)
			{
			}
			num = (short)186646528;
			if (num != 0)
			{
			}
			return base.CommandHandler.SelectFirmwareForUpgradeCommand.CanExecute(new object[]
			{
				this.SelectFirmwareContext
			});
		}

		// Token: 0x040000C5 RID: 197
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext a;

		// Token: 0x040000C6 RID: 198
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
