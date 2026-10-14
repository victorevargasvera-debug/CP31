using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ApplicationLicense
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.Composition.Export("ApplicationLicenseMainView")]
	public class ApplicationLicenseMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public ApplicationLicenseMainView()
		{
			this.InitializeComponent();
			this.a();
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000213C File Offset: 0x0000033C
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.MainViewModel ViewModel
		{
			set
			{
				short num = (short)608164867;
				short num2 = num;
				num = (short)1360059395;
				switch (num2 == num)
				{
				}
				num = (short)760872960;
				short num3 = num;
				num = (short)138936321;
				if (num != 0)
				{
				}
				num = (short)1631387648;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F0 File Offset: 0x000003F0
		private void a()
		{
			int a_ = 16;
			short num = (short)735117313;
			if (num != 0)
			{
			}
			num = (short)1917769898;
			short num2 = num;
			num = (short)450943146;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1460142080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1764294656;
			if (num != 0)
			{
			}
			this.dgrApplicationLicense.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel.g("ힱ펳\udfb5ힷ풹", a_));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022BC File Offset: 0x000004BC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			while (this._contentLoaded)
			{
				short num = (short)1869119190;
				short num2 = num;
				num = (short)1347059414;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)548798464;
					short num3 = num;
					break;
				}
				}
				num = (short)1064501248;
				if (num != 0)
				{
				}
				num = (short)956628993;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel.g("鶱靈\ud9b5첷햹캻톽겿ꏁ藅ꟇꟉꇋꇍ뻏金蓓藕裙뷛뫝觟跡ꧣ蟥蛧诩诫语鷯韱髳苵훷꣹뇻뿽䳿儁㼃攅朇有簋愍縏眑稓戕㜗眙紛眝丟吡䴣䌥弧Щ含伭崯帱", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023A4 File Offset: 0x000005A4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			while (connectionId == 1)
			{
				short num = (short)610417619;
				short num2 = num;
				num = (short)28785619;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)107151360;
					short num3 = num;
					break;
				}
				}
				num = (short)1825701888;
				if (num != 0)
				{
				}
				num = (short)1445068801;
				if (num != 0)
				{
				}
				this.dgrApplicationLicense = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x04000003 RID: 3
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrApplicationLicense;

		// Token: 0x04000004 RID: 4
		private bool _contentLoaded;
	}
}
