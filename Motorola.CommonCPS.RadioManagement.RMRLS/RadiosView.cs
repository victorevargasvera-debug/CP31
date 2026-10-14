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
	// Token: 0x02000011 RID: 17
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "RadioLicenseMainRegion")]
	public class RadiosView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00009504 File Offset: 0x00007704
		public RadiosView()
		{
			this.InitializeComponent();
			this.a();
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00009524 File Offset: 0x00007724
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.RadioLicense.RadiosViewModel ViewModel
		{
			set
			{
				short num = (short)664555156;
				short num2 = num;
				num = (short)179457684;
				switch (num2 == num)
				{
				}
				num = (short)2029715457;
				if (num != 0)
				{
				}
				num = (short)1809711104;
				if (num != 0)
				{
				}
				num = (short)1193279488;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000095D4 File Offset: 0x000077D4
		private void a()
		{
			short num = (short)398329034;
			short num2 = num;
			num = (short)1228342474;
			switch (num2 == num)
			{
			}
			num = (short)1368784897;
			if (num != 0)
			{
			}
			num = (short)84475904;
			if (num != 0)
			{
			}
			num = (short)946208768;
			short num3 = num;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00009680 File Offset: 0x00007880
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 5;
			while (this._contentLoaded)
			{
				short num = (short)1162989575;
				short num2 = num;
				num = (short)264753159;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)754974721;
					if (num != 0)
					{
					}
					num = (short)852492288;
					short num3 = num;
					num = (short)1832452096;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("ب昪䈬嬮帰䄲娴嬶堸ᔺ縼倾ⱀ⹂⩄⥆ੈᭊṌ慎͐㉒ㅔ㹖㙘ᙚ㱜ㅞ`Ѣd੦౨ժᥬ䅮⍰㹲❴㭶⩸䁺Ṽၾ歷ꂎﺖ쒠풢誤햦좨쾪쒬삮슰얲\udcb4튶캸閺얼\udebe곀꿂", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00009764 File Offset: 0x00007964
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1558249474;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1858338820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_10F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 3:
					num = (short)298582017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_F5;
				}
				IL_3A:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1728216089;
				short num3 = num;
				num = (short)1052212249;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1484849152;
					if (num != 0)
					{
					}
					num = (short)101056512;
					short num4 = num;
					num = (short)1971257347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_10F:
				num = (short)583663617;
				if (num != 0)
				{
				}
				if (connectionId == 2)
				{
					goto IL_156;
				}
				num = (short)1703936;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.dgrASTRORadioLicenses = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_F5:
			this._contentLoaded = true;
			return;
			IL_156:
			this.dgrPCRRadioLicenses = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000032 RID: 50
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrASTRORadioLicenses;

		// Token: 0x04000033 RID: 51
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrPCRRadioLicenses;

		// Token: 0x04000034 RID: 52
		private bool _contentLoaded;
	}
}
