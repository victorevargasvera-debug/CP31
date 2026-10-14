using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect
{
	// Token: 0x0200000D RID: 13
	public class SelectAgencyView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00004BAC File Offset: 0x00002DAC
		public SelectAgencyView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00004BC8 File Offset: 0x00002DC8
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel ViewModel
		{
			set
			{
				short num = (short)497357949;
				short num2 = num;
				num = (short)623187069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2123431936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211367425;
				if (num != 0)
				{
				}
				num = (short)641662976;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004C78 File Offset: 0x00002E78
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)681067407;
			short num2 = num;
			num = (short)155599759;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1121714176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1604255745;
			if (num != 0)
			{
			}
			num = (short)2117664768;
			if (num != 0)
			{
			}
			this.userControlWindow = global::System.Windows.Window.GetWindow(this);
			this.userControlWindow.Topmost = true;
			this.userControlWindow.Activate();
			this.userControlWindow.Topmost = false;
			this.userControlWindow.ShowInTaskbar = true;
			this.userControlWindow.ResizeMode = global::System.Windows.ResizeMode.CanResizeWithGrip;
			this.userControlWindow.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterScreen;
			this.userControlWindow.MinWidth = 480.0;
			this.userControlWindow.MinHeight = 180.0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004D9C File Offset: 0x00002F9C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 2;
			if (this._contentLoaded)
			{
				short num;
				for (;;)
				{
					num = (short)505151488;
					short num2 = num;
					num = (short)1411764204;
					short num3 = num;
					num = (short)1768607724;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_75;
					}
				}
				IL_75:
				num = (short)1573847041;
				if (num != 0)
				{
				}
				num = (short)1271660544;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("ࠦ搨䐪夬䀮䌰尲头嘶᜸砺刼刾ⱀⱂ⭄ц᥈ᡊ捌ᵎぐ㝒㱔㡖ᑘ㩚㍜㹞٠٢ࡤɦݨὪ䍬⁮ばٲŴὶ㙸୺᡼ᅾ좀잂욄ꢒ쒠춢톤袦\udaa8캪솬쪮튰잲풴킶\udcb8햺\udebc욾럀ꫂꃄ냆룊꣌ꏎ듐냒ꇔ뛖뻘뻚돜볞飠闢賤苦黨엪闬軮鳰鿲", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004E80 File Offset: 0x00003080
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1363542018;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					for (;;)
					{
						num = (short)187144572;
						short num3 = num;
						num = (short)2142935420;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B0;
						}
					}
					IL_B0:
					num = (short)1503985664;
					short num4 = num;
					num = (short)1145569280;
					if (num != 0)
					{
					}
					num = (short)496566273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_107;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_116;
				case 2:
					goto IL_6C;
				case 3:
					goto IL_5F;
				case 4:
					goto IL_109;
				default:
					num = (short)1896153088;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_5F:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_6C:
			this.AgencyCmboBox = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_107:
			this._contentLoaded = true;
			return;
			IL_109:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_116:
			num = (short)1948319745;
			if (num != 0)
			{
			}
			((global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyView)target).Loaded += this.a;
		}

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Window userControlWindow;

		// Token: 0x04000028 RID: 40
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox AgencyCmboBox;

		// Token: 0x04000029 RID: 41
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400002A RID: 42
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400002B RID: 43
		private bool _contentLoaded;
	}
}
