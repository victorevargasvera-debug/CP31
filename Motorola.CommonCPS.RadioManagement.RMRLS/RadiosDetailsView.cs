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
	// Token: 0x0200000F RID: 15
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "RadioLicenseMainRegion")]
	public class RadiosDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000070 RID: 112 RVA: 0x000086AC File Offset: 0x000068AC
		public RadiosDetailsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000086C8 File Offset: 0x000068C8
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.RadioLicense.RadiosDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)214465421;
				short num2 = num;
				num = (short)2140961677;
				switch (num2 == num)
				{
				}
				num = (short)1091436545;
				if (num != 0)
				{
				}
				num = (short)652804096;
				if (num != 0)
				{
				}
				num = (short)1119813632;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008778 File Offset: 0x00006978
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			while (this._contentLoaded)
			{
				short num = (short)1296083150;
				short num2 = num;
				num = (short)960669902;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1600585728;
					if (num != 0)
					{
					}
					num = (short)551878656;
					short num3 = num;
					num = (short)2060255233;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("ᴱ礳夵䰷唹主儽ⰿ⍁橃Յ❇❉⅋⅍㹏ᅑѓՕ癗࡙㵛㩝य़ൡ⥣ݥ٧୩୫୭ᵯ᝱ᩳɵ噷⡹ㅻⱽ챿톁뾃ﲋﺏ望랗ﶛ瞧즟춡힣슥춧\udea9춫잭\udcaf솱슳\udfb5\uddb7춹鎻첽ꆿꛁ귃꧅믇껉꧋뫍뇏믑룓ꗕ껗동맛꧝컟髡藣该蓧", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008860 File Offset: 0x00006A60
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			while (connectionId == 1)
			{
				short num = (short)1010963372;
				short num2 = num;
				num = (short)306058156;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)276103168;
					if (num != 0)
					{
					}
					num = (short)101253120;
					short num3 = num;
					num = (short)1664352257;
					if (num != 0)
					{
					}
					this.dgrFeatures = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
					return;
				}
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x0400002C RID: 44
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrFeatures;

		// Token: 0x0400002D RID: 45
		private bool _contentLoaded;
	}
}
