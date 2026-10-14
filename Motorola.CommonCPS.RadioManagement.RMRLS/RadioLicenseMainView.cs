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
	// Token: 0x0200000C RID: 12
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "MainRegion")]
	public class RadioLicenseMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000064C0 File Offset: 0x000046C0
		public RadioLicenseMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000064DC File Offset: 0x000046DC
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.RadioLicense.MainViewModel ViewModel
		{
			set
			{
				short num = (short)382468097;
				if (num != 0)
				{
				}
				num = (short)473189065;
				short num2 = num;
				num = (short)972049097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)603652096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1628569600;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006590 File Offset: 0x00004790
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			if (!this._contentLoaded)
			{
				short num = (short)2120089601;
				if (num != 0)
				{
				}
				num = (short)1571608990;
				short num2 = num;
				num = (short)1699404190;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1315307520;
					short num3 = num;
					num = (short)1169752064;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("Ἧ缱嬳䈵圷䠹医刽ℿ汁݃⥅╇❉⍋⁍ፏɑݓ硕੗㭙㡛㝝ཟ⽡գࡥ१൩५ͭᕯᱱs塵⩷㝹⹻㉽퍿릁憎ﲑ릕ﮙ횟쮡솣톥蚧튩춫쎭\udcaf", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006670 File Offset: 0x00004870
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)529989634;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1878851585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_E8;
				case 2:
					num = (short)630587393;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				IL_59:
				switch (connectionId)
				{
				case 1:
				{
					num = (short)34403905;
					short num3 = num;
					num = (short)2074867265;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_12C;
					}
					break;
				}
				case 2:
					goto IL_C3;
				case 3:
					goto IL_14E;
				case 4:
					goto IL_B6;
				case 5:
					goto IL_EA;
				}
				num = (short)1854865408;
				short num4 = num;
				num = (short)545652736;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B6:
			this.rbtFeatures = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_C3:
			this.gspSplitter = (global::System.Windows.Controls.GridSplitter)target;
			return;
			IL_E8:
			this._contentLoaded = true;
			return;
			IL_EA:
			this.rbtRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_12C:
			num = (short)1038090240;
			if (num != 0)
			{
			}
			this.gplGroup = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList)target;
			return;
			IL_14E:
			this.rbtAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
		}

		// Token: 0x0400001D RID: 29
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList gplGroup;

		// Token: 0x0400001E RID: 30
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.GridSplitter gspSplitter;

		// Token: 0x0400001F RID: 31
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtAll;

		// Token: 0x04000020 RID: 32
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtFeatures;

		// Token: 0x04000021 RID: 33
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtRadios;

		// Token: 0x04000022 RID: 34
		private bool _contentLoaded;
	}
}
