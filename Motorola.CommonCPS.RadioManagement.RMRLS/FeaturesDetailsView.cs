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
	// Token: 0x02000006 RID: 6
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "RadioLicenseMainRegion")]
	public class FeaturesDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00003190 File Offset: 0x00001390
		public FeaturesDetailsView()
		{
			this.InitializeComponent();
			this.a();
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000031B0 File Offset: 0x000013B0
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.RadioLicense.FeaturesDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)1771307009;
				if (num != 0)
				{
				}
				num = (short)930001998;
				short num2 = num;
				num = (short)2011870286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873543168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704525824;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003260 File Offset: 0x00001460
		private void a()
		{
			short num = (short)1349542629;
			short num2 = num;
			num = (short)1779327717;
			switch (num2 == num)
			{
			}
			num = (short)994705408;
			short num3 = num;
			num = (short)1926692864;
			if (num != 0)
			{
			}
			num = (short)1027932161;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000330C File Offset: 0x0000150C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)1057904759;
			short num2 = num;
			num = (short)1024284791;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1495924736;
				short num3 = num;
				break;
			}
			}
			num = (short)1101004800;
			if (num != 0)
			{
			}
			if (!this._contentLoaded)
			{
				num = (short)1437073409;
				if (num != 0)
				{
				}
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("Ἧ缱嬳䈵圷䠹医刽ℿ汁݃⥅╇❉⍋⁍ፏɑݓ硕੗㭙㡛㝝ཟ⽡գࡥ१൩५ͭᕯᱱs塵⩷㝹⹻㉽퍿릁憎ﲑ릕ﺗﾙﶛ풟킡솣향첧쾩\ud8ab쾭\ud9af\udeb1잳삵톷\udfb9쮻醽ꚿꟁꗃ닅뷇룉꧋뷍듏럑ꃓ럕뇗뛙꿛꣝觟蟡鏣죥郧诩臫苭", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000033EC File Offset: 0x000015EC
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1844022115;
			short num2 = num;
			num = (short)1706658659;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_7D;
			case 1:
				break;
			default:
			{
				num = (short)569638912;
				short num3 = num;
				break;
			}
			}
			num = (short)629342208;
			if (num != 0)
			{
			}
			if (connectionId != 1)
			{
				this._contentLoaded = true;
				return;
			}
			IL_7D:
			num = (short)118554625;
			if (num != 0)
			{
			}
			this.dgrASTRORadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000009 RID: 9
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrASTRORadios;

		// Token: 0x0400000A RID: 10
		private bool _contentLoaded;
	}
}
