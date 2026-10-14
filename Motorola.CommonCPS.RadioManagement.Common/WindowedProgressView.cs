using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000031 RID: 49
	public class WindowedProgressView : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00017678 File Offset: 0x00015878
		public WindowedProgressView(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext progressContext)
		{
			this.InitializeComponent();
			base.DataContext = progressContext;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00017698 File Offset: 0x00015898
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this._contentLoaded)
			{
				short num = (short)70906151;
				short num2 = num;
				num = (short)3862823;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)453836800;
					short num3 = num;
					num = (short)1585709057;
					if (num != 0)
					{
					}
					num = (short)931069952;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏝迟雡诣铥蟧蛩跫샭돯鷱駳鯵韷铹뿻껽叿Ⰱ嘃朅氇按挋䌍焏簑甓焕紗眙礛瀝吟డ朣䤥䔧䜩䌫䀭ଯ儱嬳嬵䠷唹刻嬽⸿㙁歃ㅅⅇ⑉⡋⅍❏㝑こ♕⩗㕙㭛ⱝ՟ᅡᝣၥŧཀྵ᭫䅭ݯ᭱ᩳት᝷൹᥻᩽慎ﾋﶍﮑ뚗ﶛ첟", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001777C File Offset: 0x0001597C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1479589805;
			short num2 = num;
			num = (short)112639917;
			switch (num2 == num)
			{
			}
			num = (short)1100808193;
			if (num != 0)
			{
			}
			num = (short)1973288960;
			short num3 = num;
			num = (short)1808072704;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
		}

		// Token: 0x040000F2 RID: 242
		private bool _contentLoaded;
	}
}
