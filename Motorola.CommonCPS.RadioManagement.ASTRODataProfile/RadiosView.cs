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

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000018 RID: 24
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTRODataProfileMainRegion")]
	public class RadiosView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00007D74 File Offset: 0x00005F74
		public RadiosView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000013 RID: 19
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00007D90 File Offset: 0x00005F90
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadiosViewModel ViewModel
		{
			set
			{
				short num = (short)1293746176;
				short num2 = num;
				num = (short)1980903970;
				short num3 = num;
				num = (short)1162621474;
				switch (num3 == num)
				{
				}
				num = (short)1815674880;
				if (num != 0)
				{
				}
				num = (short)1187577857;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007E40 File Offset: 0x00006040
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 12;
			short num = (short)571237874;
			short num2 = num;
			num = (short)1084843506;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_AC;
			case 1:
				break;
			default:
			{
				num = (short)787808256;
				short num3 = num;
				break;
			}
			}
			num = (short)1369309185;
			if (num != 0)
			{
			}
			num = (short)1934884864;
			if (num != 0)
			{
			}
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
			{
				this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쒪쎬즮\ud8b0풲살얶\ud8b8쾺풼킾꿀跂꓄꫆곈", a_));
				return;
			}
			IL_AC:
			this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﶨ캪사\udfae\uddb0튲솴튶\udaba킼\udabe", a_));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007F2C File Offset: 0x0000612C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			if (this._contentLoaded)
			{
				short num = (short)592504814;
				short num2 = num;
				num = (short)1526654958;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1276116993;
					if (num != 0)
					{
					}
					num = (short)866320384;
					short num3 = num;
					num = (short)300089344;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("貢좦\udda8쒪\udfac삮\uddb0튲鮴횸횺킼킾꿀胂闄铆駊곌ꯎ룐볒飔뛖럘뫚뫜뫞賠蛢诤鏦쟨ꫪ뻬믮ꏰ볲뇴零跸髺근跾渀攂氄欆氈《渌怎簐挒稔礖簘甚検〞匠䈢䄤並䘨堪嬬䘮吰䐲ᨴ䔶堸强吼倾㉀㕂ⱄ≆㹈敊㕌⹎㱐㽒", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000800C File Offset: 0x0000620C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1640890370;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)10394820;
				short num3 = num;
				num = (short)274308292;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14D;
				case 1:
					break;
				default:
				{
					num = (short)1658585088;
					short num4 = num;
					break;
				}
				}
				num = (short)1476984832;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)317521921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_12F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_AE;
					}
					continue;
				case 3:
					num = (short)588447748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (connectionId != 2)
					{
						goto IL_14D;
					}
					goto IL_166;
				}
				IL_AE:
				if (connectionId != 1)
				{
					num = (short)1696333827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_14D:
				num = (short)19202048;
				num2 = (int)((global::System.IntPtr)num);
			}
			num = (short)521994241;
			if (num != 0)
			{
			}
			this.uscRadios = (global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadiosView)target;
			this.uscRadios.Loaded += this.a;
			return;
			IL_12F:
			this._contentLoaded = true;
			return;
			IL_166:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000030 RID: 48
		internal global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadiosView uscRadios;

		// Token: 0x04000031 RID: 49
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x04000032 RID: 50
		private bool _contentLoaded;
	}
}
