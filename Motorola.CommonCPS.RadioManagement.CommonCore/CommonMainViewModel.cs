using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.CommonCore
{
	// Token: 0x02000004 RID: 4
	public abstract class CommonMainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public CommonMainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.EnableMainViewEvent>().Subscribe(new global::System.Action<object>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.DisableMainViewEvent>().Subscribe(new global::System.Action<object>(this.a));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000217C File Offset: 0x0000037C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002230 File Offset: 0x00000430
		public bool MainViewEnable
		{
			get
			{
				short num = (short)1733865480;
				short num2 = num;
				num = (short)950710280;
				switch (num2 == num)
				{
				}
				num = (short)1069416448;
				if (num != 0)
				{
				}
				num = (short)1275920384;
				short num3 = num;
				num = (short)682295297;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1162477569;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)966732292;
						short num3 = num;
						num = (short)1169697284;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_D8;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						this.a = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.CommonCore.CommonMainViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.CommonCore.CommonMainViewModel.get_MainViewEnable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1708392448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					if (value == this.a)
					{
						return;
					}
					num = (short)1399128066;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D8:
				num = (short)2048917504;
				short num4 = num;
				num = (short)501743617;
				if (num != 0)
				{
				}
				num = (short)414253056;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000237C File Offset: 0x0000057C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(object A_0)
		{
			short num = (short)957350722;
			short num2 = num;
			num = (short)801375042;
			switch (num2 == num)
			{
			}
			num = (short)302383105;
			if (num != 0)
			{
			}
			num = (short)591200256;
			short num3 = num;
			num = (short)1873018880;
			if (num != 0)
			{
			}
			this.MainViewEnable = true;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000242C File Offset: 0x0000062C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0)
		{
			short num = (short)176871860;
			short num2 = num;
			num = (short)1091295668;
			switch (num2 == num)
			{
			}
			num = (short)573112321;
			if (num != 0)
			{
			}
			num = (short)4784128;
			short num3 = num;
			num = (short)579338240;
			if (num != 0)
			{
			}
			this.MainViewEnable = false;
		}

		// Token: 0x04000003 RID: 3
		private bool a = true;
	}
}
