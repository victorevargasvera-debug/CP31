using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200001B RID: 27
	[global::System.ComponentModel.Composition.Export]
	public class ProgressViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000B354 File Offset: 0x00009554
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public ProgressViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext progressContext)
		{
			int a_ = 1;
			base..ctor(eventAggregator);
			this.ProgressContext = progressContext;
			this.ProgressContext.PropertyChanged += this.a;
			this.ProgressContext.InvokeRaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("臒듔ꏖ볘", a_));
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000B3A8 File Offset: 0x000095A8
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000B454 File Offset: 0x00009654
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext ProgressContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1294139392;
				short num2 = num;
				num = (short)1594590917;
				short num3 = num;
				num = (short)48465605;
				switch (num3 == num)
				{
				}
				num = (short)1876951041;
				if (num != 0)
				{
				}
				num = (short)1203568640;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)422969344;
				short num2 = num;
				num = (short)1199918293;
				short num3 = num;
				num = (short)1869827285;
				switch (num3 == num)
				{
				}
				num = (short)1377239041;
				if (num != 0)
				{
				}
				num = (short)2103181312;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000B504 File Offset: 0x00009704
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 5;
			short num = (short)1332150272;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 1:
				{
					num = (short)921436160;
					short num3 = num;
					num = (short)128057346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)1539500496;
					short num4 = num;
					num = (short)2033248720;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)696057856;
						if (num != 0)
						{
						}
						if (this.ProgressContext.Rate == 100.0)
						{
							num = (short)133431300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
					return;
				case 4:
					global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(this.a), global::System.Array.Empty<object>());
					num = (short)542572547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_42:
				if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藖룘꿚룜", a_)))
				{
					break;
				}
				num = (short)1236598785;
				if (num != 0)
				{
				}
				num = (short)504299521;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000B6AC File Offset: 0x000098AC
		protected override void OnWindowClosed()
		{
			short num = (short)1143341056;
			short num2 = num;
			num = (short)1294397212;
			short num3 = num;
			num = (short)459271964;
			switch (num3 == num)
			{
			}
			num = (short)1757806593;
			if (num != 0)
			{
			}
			num = (short)422903808;
			if (num != 0)
			{
			}
			base.OnWindowClosed();
			global::System.Threading.CancellationTokenSource cancellationToken = this.ProgressContext.CancellationToken;
			if (cancellationToken == null)
			{
				return;
			}
			cancellationToken.Cancel();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000B774 File Offset: 0x00009974
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a()
		{
			short num = (short)567803904;
			short num2 = num;
			num = (short)1442447361;
			if (num != 0)
			{
			}
			num = (short)702653510;
			short num3 = num;
			num = (short)1105568838;
			switch (num3 == num)
			{
			}
			num = (short)1446903808;
			if (num != 0)
			{
			}
			base.CloseCommand.Execute();
		}

		// Token: 0x04000096 RID: 150
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext a;
	}
}
