using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200001A RID: 26
	public class ProgressView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000B194 File Offset: 0x00009394
		public ProgressView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000B1B0 File Offset: 0x000093B0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			short num = (short)1054768565;
			short num2 = num;
			num = (short)150633909;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1722744832;
				short num3 = num;
				num = (short)1337589761;
				if (num != 0)
				{
				}
				num = (short)1616248832;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏝迟雡诣铥蟧蛩跫샭돯鷱駳鯵韷铹뿻껽叿Ⰱ嘃朅氇按挋䌍焏簑甓焕紗眙礛瀝吟డ朣䤥䔧䜩䌫䀭ଯ儱嬳嬵䠷唹刻嬽⸿㙁歃㙅㩇╉⭋㱍㕏⅑❓⁕ㅗ㽙⭛煝ၟၡୣťᩧཀྵὫᵭٯ᭱ᅳŵ噷ɹᵻ፽", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000B290 File Offset: 0x00009490
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1417510115;
			short num2 = num;
			num = (short)404192483;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1524367360;
				short num3 = num;
				num = (short)1439563777;
				if (num != 0)
				{
				}
				num = (short)68288512;
				if (num != 0)
				{
				}
				if (connectionId != 1)
				{
					this._contentLoaded = true;
					return;
				}
				break;
			}
			}
			this.rwiProgress = (global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator)target;
		}

		// Token: 0x04000094 RID: 148
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator rwiProgress;

		// Token: 0x04000095 RID: 149
		private bool _contentLoaded;
	}
}
