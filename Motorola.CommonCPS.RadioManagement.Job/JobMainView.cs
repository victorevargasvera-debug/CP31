using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x0200000F RID: 15
	[global::System.ComponentModel.Composition.Export("JobMainView")]
	public class JobMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000051E0 File Offset: 0x000033E0
		public JobMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000051FC File Offset: 0x000033FC
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Job.MainViewModel ViewModel
		{
			set
			{
				short num = (short)267081380;
				short num2 = num;
				num = (short)783701668;
				switch (num2 == num)
				{
				}
				num = (short)681312256;
				short num3 = num;
				num = (short)1238237184;
				if (num != 0)
				{
				}
				num = (short)472383489;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000052AC File Offset: 0x000034AC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (this._contentLoaded)
			{
				short num = (short)2115872233;
				short num2 = num;
				num = (short)666215913;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1697382400;
					short num3 = num;
					num = (short)776273921;
					if (num != 0)
					{
					}
					num = (short)62783488;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("㈜刞丠圢䨤唦䘨䜪䰬Į爰尲場娶嘸唺縼漾ቀ浂ᝄ♆ⵈ≊≌Ɏぐ㵒㑔ざ㱘㙚㡜ㅞᕠ䵢⽤ࡦ୨偪๬nᱰͲᩴ᥶ᱸᕺॼ偾ﾈ뾐殺", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005390 File Offset: 0x00003590
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2123563009;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)324665344;
					short num3 = num;
					num = (short)1050275754;
					short num4 = num;
					num = (short)1683615658;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)173604864;
						if (num != 0)
						{
						}
						num = (short)287571970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_105;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_DF;
				case 2:
					goto IL_D2;
				case 3:
					goto IL_12D;
				default:
					num = (short)717488128;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D2:
			this.rbtProgramming = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_DF:
			this.rbtAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_105:
			num = (short)1713242113;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			IL_12D:
			this.rbtOperational = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
		}

		// Token: 0x0400001E RID: 30
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtAll;

		// Token: 0x0400001F RID: 31
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtProgramming;

		// Token: 0x04000020 RID: 32
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtOperational;

		// Token: 0x04000021 RID: 33
		private bool _contentLoaded;
	}
}
