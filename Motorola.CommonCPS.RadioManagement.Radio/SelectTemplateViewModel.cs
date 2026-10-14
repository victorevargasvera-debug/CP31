using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200002C RID: 44
	public class SelectTemplateViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00023000 File Offset: 0x00021200
		public SelectTemplateViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext selectTemplateContext) : base(eventAggregator, commandHandler)
		{
			this.SelectTemplateContext = selectTemplateContext;
			this.SelectTemplateContext.SelectedTemplates.CollectionChanged += this.a;
			this.SelectTemplateCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.SelectTemplateContext.PropertyChanged += this.a;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00023074 File Offset: 0x00021274
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00023124 File Offset: 0x00021324
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext SelectTemplateContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1784667231;
				short num2 = num;
				num = (short)2097667167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1541013504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1049362432;
				if (num != 0)
				{
				}
				num = (short)763232257;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)727337822;
				short num2 = num;
				num = (short)529550174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)996540416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343670785;
				if (num != 0)
				{
				}
				num = (short)26607616;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000231D4 File Offset: 0x000213D4
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00023284 File Offset: 0x00021484
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectTemplateCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)138280961;
				if (num != 0)
				{
				}
				num = (short)1559953408;
				short num2 = num;
				num = (short)484429731;
				short num3 = num;
				num = (short)795070371;
				switch (num3 == num)
				{
				}
				num = (short)2078277632;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1163687852;
				short num2 = num;
				num = (short)1040021420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)626393088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1614479361;
				if (num != 0)
				{
				}
				num = (short)1549205504;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00023334 File Offset: 0x00021534
		private void b()
		{
			short num;
			try
			{
				num = (short)1043206791;
				short num2 = num;
				num = (short)761467527;
				switch (num2 == num)
				{
				}
				num = (short)1626210304;
				if (num != 0)
				{
				}
				base.CloseCommand.Execute();
				base.CommandHandler.SelectTemplateCommand.Execute(new object[]
				{
					this.SelectTemplateContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.SelectTemplateContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1640955905;
			if (num != 0)
			{
			}
			num = (short)827195392;
			short num3 = num;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00023434 File Offset: 0x00021634
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1411458426;
				short num2 = num;
				num = (short)367601018;
				switch (num2 == num)
				{
				}
				num = (short)865337344;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SelectTemplateCommand.CanExecute(new object[]
				{
					this.SelectTemplateContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1263009793;
			if (num != 0)
			{
			}
			num = (short)964362240;
			short num3 = num;
			return result;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00023520 File Offset: 0x00021720
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)844070208;
			short num2 = num;
			num = (short)1771208000;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1327955968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1483276288;
			if (num != 0)
			{
			}
			num = (short)1503461377;
			if (num != 0)
			{
			}
			this.SelectTemplateContext.ExceptionMessage = string.Empty;
			this.SelectTemplateCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000235E4 File Offset: 0x000217E4
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 12;
			short num;
			if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("薿뫁ꟃꏅ룇뻉ꗋꇍ뻏鿑뇓ꗕꯗ믙믛믝", a_)))
			{
				num = (short)582819911;
				short num2 = num;
				num = (short)2041520199;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)4063232;
					if (num != 0)
					{
					}
					this.SelectTemplateContext.ExceptionMessage = string.Empty;
					this.SelectTemplateCommand.RaiseCanExecuteChanged();
					return;
				}
			}
			num = (short)1439825921;
			if (num != 0)
			{
			}
			num = (short)519241728;
			short num3 = num;
		}

		// Token: 0x040000E2 RID: 226
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext a;

		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
