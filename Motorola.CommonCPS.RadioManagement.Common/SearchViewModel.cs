using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200003F RID: 63
	[global::System.ComponentModel.Composition.Export]
	public class SearchViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0001DDB4 File Offset: 0x0001BFB4
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public SearchViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.SearchCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.b), new global::System.Func<string, bool>(this.a));
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0001DE9C File Offset: 0x0001C09C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> SearchCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1884762912;
				short num2 = num;
				num = (short)221197088;
				switch (num2 == num)
				{
				}
				num = (short)366411776;
				short num3 = num;
				num = (short)1046740993;
				if (num != 0)
				{
				}
				num = (short)612237312;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1723093521;
				short num2 = num;
				num = (short)1538806289;
				switch (num2 == num)
				{
				}
				num = (short)435224576;
				short num3 = num;
				num = (short)1346174976;
				if (num != 0)
				{
				}
				num = (short)2069692417;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001DF50 File Offset: 0x0001C150
		private void b(string A_0)
		{
			int a_ = 9;
			short num = (short)635633666;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11A;
				case 1:
					base.ServiceProxy.CommandHandler.FilterCommand.Execute(new object[]
					{
						A_0
					});
					num = (short)1593114624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1F;
				}
				goto IL_3B;
				IL_1F:
				switch (0)
				{
				case 0:
				{
					IL_3B:
					num = (short)2131628994;
					short num3 = num;
					num = (short)1031934914;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F;
					default:
					{
						num = (short)1322582016;
						short num4 = num;
						num = (short)675086336;
						if (num != 0)
						{
						}
						if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("觚볜믞裠賢", a_)))
						{
							return;
						}
						num = (short)2122186753;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
				}
			}
			IL_11A:
			num = (short)567672833;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001E0A0 File Offset: 0x0001C2A0
		private bool a(string A_0)
		{
			short num = (short)129695745;
			if (num != 0)
			{
			}
			num = (short)121427932;
			short num2 = num;
			num = (short)299358172;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1071120384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1802895360;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x04000141 RID: 321
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> a;
	}
}
