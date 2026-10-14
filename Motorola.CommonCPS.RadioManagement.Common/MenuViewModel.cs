using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000035 RID: 53
	[global::System.ComponentModel.Composition.Export]
	public class MenuViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00017FA4 File Offset: 0x000161A4
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MenuViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.NavigateToCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.a));
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00017FD0 File Offset: 0x000161D0
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00018084 File Offset: 0x00016284
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> NavigateToCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)425484701;
				short num2 = num;
				num = (short)356999581;
				switch (num2 == num)
				{
				}
				num = (short)348651520;
				if (num != 0)
				{
				}
				num = (short)567214080;
				short num3 = num;
				num = (short)1592852481;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)811234484;
				short num2 = num;
				num = (short)1372746932;
				switch (num2 == num)
				{
				}
				num = (short)560267265;
				if (num != 0)
				{
				}
				num = (short)1198522368;
				short num3 = num;
				num = (short)2011758592;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00018134 File Offset: 0x00016334
		private void a(string A_0)
		{
			short num = (short)328751471;
			short num2 = num;
			num = (short)578181487;
			switch (num2 == num)
			{
			}
			num = (short)625410049;
			if (num != 0)
			{
			}
			num = (short)963313664;
			short num3 = num;
			num = (short)1973616640;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(A_0, string.Empty);
		}

		// Token: 0x040000FE RID: 254
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> a;
	}
}
