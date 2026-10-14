using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect
{
	// Token: 0x0200000B RID: 11
	public class OAuthLoginViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000048D4 File Offset: 0x00002AD4
		public OAuthLoginViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext oauthLoginContext) : base(eventAggregator, commandHandler)
		{
			this.OAuthLoginContext = oauthLoginContext;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000048F0 File Offset: 0x00002AF0
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000049A0 File Offset: 0x00002BA0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext OAuthLoginContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1866153064;
				short num2 = num;
				num = (short)275528808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1415053312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1295187968;
				if (num != 0)
				{
				}
				num = (short)149880833;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)906551734;
				short num2 = num;
				num = (short)816832950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1272774656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)746258433;
				if (num != 0)
				{
				}
				num = (short)661913600;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00004A4C File Offset: 0x00002C4C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00004AFC File Offset: 0x00002CFC
		public static global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.OAuthLoginEvent RaiseOAuthLoginEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)740171011;
				short num2 = num;
				num = (short)15080707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985150976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)539820033;
				if (num != 0)
				{
				}
				num = (short)74186752;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1675767854;
				short num2 = num;
				num = (short)494546990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1577517056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1058406401;
				if (num != 0)
				{
				}
				num = (short)745734144;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.b = value;
			}
		}

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext a;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.OAuthLoginEvent b;

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000025 RID: 37
		public delegate void OAuthLoginEvent(global::System.EventArgs e);
	}
}
