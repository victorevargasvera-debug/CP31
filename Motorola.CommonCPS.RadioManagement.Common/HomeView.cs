using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000032 RID: 50
	[global::System.ComponentModel.Composition.Export("HomeView")]
	public class HomeView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00017834 File Offset: 0x00015A34
		public HomeView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700003F RID: 63
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00017850 File Offset: 0x00015A50
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.HomeViewModel ViewModel
		{
			set
			{
				short num = (short)1289363054;
				short num2 = num;
				num = (short)907157102;
				switch (num2 == num)
				{
				}
				num = (short)195756032;
				if (num != 0)
				{
				}
				num = (short)786563072;
				short num3 = num;
				num = (short)155058177;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00017900 File Offset: 0x00015B00
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			short num = (short)1381236737;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)78698496;
				short num2 = num;
				num = (short)1339021312;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AE;
				case 1:
					break;
				default:
				{
					num = (short)1009582080;
					short num3 = num;
					break;
				}
				}
				num = (short)1487536128;
				if (num != 0)
				{
				}
				return;
			}
			IL_AE:
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鏝迟雡诣铥蟧蛩跫샭돯鷱駳鯵韷铹뿻껽叿Ⰱ嘃朅氇按挋䌍焏簑甓焕紗眙礛瀝吟డ朣䤥䔧䜩䌫䀭ଯ儱嬳嬵䠷唹刻嬽⸿㙁歃⹅❇❉⥋㡍㥏㝑⍓祕し㕙ㅛ㭝ᙟୡţᅥ䙧ቩ൫ͭᱯ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000179E0 File Offset: 0x00015BE0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1681457153;
			if (num != 0)
			{
			}
			num = (short)6249774;
			short num2 = num;
			num = (short)780164398;
			switch (num2 == num)
			{
			}
			num = (short)1324482560;
			short num3 = num;
			num = (short)1765081088;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
		}

		// Token: 0x040000F3 RID: 243
		private bool _contentLoaded;
	}
}
