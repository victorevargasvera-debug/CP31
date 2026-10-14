using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect
{
	// Token: 0x0200000E RID: 14
	public class SelectAgencyViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00004FEC File Offset: 0x000031EC
		public SelectAgencyViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext selectAgencyContext)
		{
			int a_ = 18;
			base..ctor(eventAggregator, commandHandler);
			if (selectAgencyContext == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("䐶尸场堼尾㕀ɂ≄≆❈⡊㑌౎㹐㵒⅔㉖⅘⽚", a_));
			}
			this.a = selectAgencyContext;
			this.b = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.OnSelectAgency), new global::System.Func<bool>(this.CanSelectAgency));
			this.SelectAgencyContext.PropertyChanged += this.a;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00005064 File Offset: 0x00003264
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext SelectAgencyContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1199269918;
				short num2 = num;
				num = (short)1415604254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199819264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40108033;
				if (num != 0)
				{
				}
				num = (short)270270464;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00005110 File Offset: 0x00003310
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectAgencyCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1892782256;
				short num2 = num;
				num = (short)51613872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)62324736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)131923969;
				if (num != 0)
				{
				}
				num = (short)1865089024;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000051C0 File Offset: 0x000033C0
		public void OnSelectAgency()
		{
			short num;
			try
			{
				num = (short)935044327;
				short num2 = num;
				num = (short)1907008743;
				switch (num2 == num)
				{
				}
				num = (short)1257504768;
				if (num != 0)
				{
				}
				base.CommandHandler.SelectAgencyCommand.Execute(new object[]
				{
					this.SelectAgencyContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SelectAgencyContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)690618369;
			if (num != 0)
			{
			}
			num = (short)1079902208;
			short num3 = num;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000052BC File Offset: 0x000034BC
		protected override void OnWindowClosed()
		{
			short num = (short)2088763393;
			if (num != 0)
			{
			}
			num = (short)1449132032;
			short num2 = num;
			num = (short)800156398;
			short num3 = num;
			num = (short)1069181678;
			switch (num3 == num)
			{
			}
			num = (short)205914112;
			if (num != 0)
			{
			}
			this.SelectAgencyContext.PropertyChanged -= this.a;
			base.OnWindowClosed();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005384 File Offset: 0x00003584
		public bool CanSelectAgency()
		{
			short num;
			bool result;
			try
			{
				num = (short)887912473;
				short num2 = num;
				num = (short)206731289;
				switch (num2 == num)
				{
				}
				num = (short)317587456;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SelectAgencyCommand.CanExecute(new object[]
				{
					this.SelectAgencyContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)526843905;
			if (num != 0)
			{
			}
			num = (short)982843392;
			short num3 = num;
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005468 File Offset: 0x00003668
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 19;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("紷䈹弻嬽〿㙁ⵃ⥅♇݉⥋㵍⍏㍑㍓㍕", a_))
			{
				short num;
				for (;;)
				{
					num = (short)401801216;
					short num2 = num;
					num = (short)246721472;
					short num3 = num;
					num = (short)1876667328;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_87;
					}
				}
				IL_87:
				num = (short)1873936384;
				if (num != 0)
				{
				}
				num = (short)971964417;
				if (num != 0)
				{
				}
				return;
			}
			this.SelectAgencyContext.ExceptionMessage = string.Empty;
			this.SelectAgencyCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005558 File Offset: 0x00003758
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1327511433 + A_1) + (global::System.IntPtr)64 + (global::System.IntPtr)25 + (global::System.IntPtr)66);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x0400002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext a;

		// Token: 0x0400002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
