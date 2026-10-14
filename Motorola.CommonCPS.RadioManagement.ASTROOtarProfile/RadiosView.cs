using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000018 RID: 24
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROOtarProfileMainRegion")]
	public class RadiosView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00009070 File Offset: 0x00007270
		public RadiosView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700001D RID: 29
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000908C File Offset: 0x0000728C
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadiosViewModel ViewModel
		{
			set
			{
				short num = (short)1643289261;
				short num2 = num;
				num = (short)516659885;
				switch (num2 == num)
				{
				}
				num = (short)263520256;
				short num3 = num;
				num = (short)587792385;
				if (num != 0)
				{
				}
				num = (short)428539904;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000913C File Offset: 0x0000733C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 7;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
			{
				short num = (short)801394947;
				short num2 = num;
				num = (short)2015252739;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)684457985;
					if (num != 0)
					{
					}
					num = (short)323813376;
					if (num != 0)
					{
					}
					num = (short)695336960;
					short num3 = num;
					this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("౗㽙ㅛ⹝౟͡ၣͥ♧୩ū୭", a_));
					return;
				}
				}
			}
			this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᭗㕙㉛㡝य़աᅣᑥ१ṩիŭṯ㱱ᕳ᭵ᵷ", a_));
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009230 File Offset: 0x00007430
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			if (this._contentLoaded)
			{
				short num = (short)1674755649;
				short num2 = num;
				num = (short)1237040705;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)38469633;
					if (num != 0)
					{
					}
					num = (short)595918848;
					if (num != 0)
					{
					}
					num = (short)661454848;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("灞Ⱡౢᅤࡦ᭨ѪŬ๮彰ひᩴ᩶ᑸᑺ፼㱾톀킂ꮄ햆\udc90ﮔﺘﺚ爵쾠힢认直ﾪﾬﺰ잲풴얶즺튼\ud9beꣀ꿂ꃄﳆ꫈꓊ꃌ뿎뻐뷒냔맖귘꿜뻞藠諢諤铦鿨苪裬飮\udef0臲铴鏶郸铺軼觾栀昂爄⤆焈樊怌挎", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00009314 File Offset: 0x00007514
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1606746116;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)648609792;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_B8;
				case 1:
					num = (short)1551237121;
					if (num != 0)
					{
					}
					num = (short)1480458240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (connectionId == 2)
					{
						goto IL_169;
					}
					num = (short)1015331152;
					short num4 = num;
					num = (short)1861794128;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_176;
					default:
						num = (short)476250112;
						if (num != 0)
						{
						}
						num = (short)478740481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)911278082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				}
				IL_63:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1399783427;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.uscRadios = (global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadiosView)target;
			this.uscRadios.Loaded += this.a;
			return;
			IL_B8:
			goto IL_176;
			IL_169:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_176:
			this._contentLoaded = true;
		}

		// Token: 0x0400003A RID: 58
		internal global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.RadiosView uscRadios;

		// Token: 0x0400003B RID: 59
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x0400003C RID: 60
		private bool _contentLoaded;
	}
}
