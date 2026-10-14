using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000029 RID: 41
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "StatusRegion")]
	public class StatusView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00013BB8 File Offset: 0x00011DB8
		public StatusView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000030 RID: 48
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00013BD4 File Offset: 0x00011DD4
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel ViewModel
		{
			set
			{
				short num = (short)1311460043;
				short num2 = num;
				num = (short)1670925003;
				switch (num2 == num)
				{
				}
				num = (short)903872513;
				if (num != 0)
				{
				}
				num = (short)689963008;
				short num3 = num;
				num = (short)289931264;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00013C84 File Offset: 0x00011E84
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1931958081;
			short num2 = num;
			num = (short)420108097;
			switch (num2 == num)
			{
			}
			num = (short)1719926785;
			if (num != 0)
			{
			}
			num = (short)1299120128;
			short num3 = num;
			num = (short)1385955328;
			if (num != 0)
			{
			}
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.StatusViewModel).a();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00013D3C File Offset: 0x00011F3C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			while (!this._contentLoaded)
			{
				short num = (short)1583453934;
				short num2 = num;
				num = (short)1354864366;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)30539777;
					if (num != 0)
					{
					}
					num = (short)592904192;
					short num3 = num;
					num = (short)68747264;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("쿟꿡诣鋥蟧飩菫苭釯\udcf1럳駵闷韹鏻都䏿刁圃⠅娇欉栋服缏弑甓砕礗紙礛猝䔟䰡倣ࠥ欧䔩䄫䌭弯就༳唵圷圹䰻儽⸿❁⩃㉅杇㥉㡋⽍⑏❑❓⁕ㅗ㽙⭛煝፟ᙡգብᵧᥩᩫݭᕯձ婳๵᥷᝹ၻ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00013E1C File Offset: 0x0001201C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			while (connectionId != 1)
			{
				short num = (short)1452377520;
				short num2 = num;
				num = (short)231376304;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1514864640;
					if (num != 0)
					{
					}
					num = (short)856948736;
					short num3 = num;
					num = (short)2140274689;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					return;
				}
				}
			}
			((global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target).MouseLeftButtonUp += this.a;
		}

		// Token: 0x040000D4 RID: 212
		private bool _contentLoaded;
	}
}
