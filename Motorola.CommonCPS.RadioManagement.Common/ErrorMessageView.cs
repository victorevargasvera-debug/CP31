using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000016 RID: 22
	public class ErrorMessageView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00008B9C File Offset: 0x00006D9C
		public ErrorMessageView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00008BB8 File Offset: 0x00006DB8
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.ErrorMessageViewModel ViewModel
		{
			set
			{
				short num = (short)1924720879;
				short num2 = num;
				num = (short)823978223;
				switch (num2 == num)
				{
				}
				num = (short)111869953;
				if (num != 0)
				{
				}
				num = (short)1571815424;
				if (num != 0)
				{
				}
				num = (short)756219904;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008C68 File Offset: 0x00006E68
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			while (!this._contentLoaded)
			{
				short num = (short)553030766;
				short num2 = num;
				num = (short)2028115054;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1268645888;
					if (num != 0)
					{
					}
					num = (short)1781268480;
					short num3 = num;
					num = (short)1795948545;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("쿟꿡诣鋥蟧飩菫苭釯\udcf1럳駵闷韹鏻都䏿刁圃⠅娇欉栋服缏弑甓砕礗紙礛猝䔟䰡倣ࠥ欧䔩䄫䌭弯就༳唵圷圹䰻儽⸿❁⩃㉅杇⽉㹋㱍㽏⁑㥓㍕⭗⥙㵛㥝՟ᑡൣͥὧ䕩५ᱭɯᵱٳ᭵ᵷॹཻώﶉꊋﾑ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008D4C File Offset: 0x00006F4C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			while (connectionId != 1)
			{
				short num = (short)121302337;
				short num2 = num;
				num = (short)332655937;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1368129537;
					if (num != 0)
					{
					}
					num = (short)1215234048;
					short num3 = num;
					num = (short)491061248;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					return;
				}
				}
			}
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x0400005C RID: 92
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400005D RID: 93
		private bool _contentLoaded;
	}
}
