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
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x02000004 RID: 4
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "RadioLicenseMainRegion")]
	public class FeaturesView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024EC File Offset: 0x000006EC
		public FeaturesView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002508 File Offset: 0x00000708
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.RadioLicense.FeaturesViewModel ViewModel
		{
			set
			{
				short num = (short)1932454426;
				short num2 = num;
				num = (short)38726170;
				switch (num2 == num)
				{
				}
				num = (short)1911357440;
				short num3 = num;
				num = (short)32505857;
				if (num != 0)
				{
				}
				num = (short)334299136;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000025B8 File Offset: 0x000007B8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)919965181;
			short num2 = num;
			num = (short)945524221;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1359282176;
				short num3 = num;
				break;
			}
			}
			num = (short)2003894273;
			if (num != 0)
			{
			}
			num = (short)1071513600;
			if (num != 0)
			{
			}
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("Ἧ缱嬳䈵圷䠹医刽ℿ汁݃⥅╇❉⍋⁍ፏɑݓ硕੗㭙㡛㝝ཟ⽡գࡥ१൩५ͭᕯᱱs塵⩷㝹⹻㉽퍿릁憎ﲑ릕ﺗﾙﶛ햟킡솣향\udea7쎩즫\ud9ad龯풱톳ힵ첷쾹캻\udbbd뎿듁귃ꏅ뿇듋꿍뷏뻑", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002698 File Offset: 0x00000898
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2042274822;
			short num2 = num;
			num = (short)1946592262;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A0;
			case 1:
				break;
			default:
			{
				num = (short)839647232;
				short num3 = num;
				break;
			}
			}
			num = (short)344522752;
			if (num != 0)
			{
			}
			num = (short)298582017;
			if (num != 0)
			{
			}
			if (connectionId != 1)
			{
				this._contentLoaded = true;
				return;
			}
			IL_A0:
			this.dgrFeatureList = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000003 RID: 3
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrFeatureList;

		// Token: 0x04000004 RID: 4
		private bool _contentLoaded;
	}
}
