using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000016 RID: 22
	public class RadioJobsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000069 RID: 105 RVA: 0x000078C4 File Offset: 0x00005AC4
		public RadioJobsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000078E0 File Offset: 0x00005AE0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 11;
			short num = (short)1325527130;
			short num2 = num;
			num = (short)1564143706;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1653997568;
				short num3 = num;
				break;
			}
			}
			num = (short)510001153;
			if (num != 0)
			{
			}
			num = (short)1107951616;
			if (num != 0)
			{
			}
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("螧쎫\udaad\udfaf삱\udbb3\udab5\ud9b7钹ﾻ톽궿꿁ꯃꣅ诇髉鿋苏돑냓뿕럗韙뷛냝臟藡臣该跧蓩飫샭뇯ꇱꃳꓵ럷뻹鷻諽懿刁瘃椅渇按怋欍⬏焑笓笕栗甙爛笝丟嘡ଣ吥䤧丩䔫䄭娯崱嘳䔵丷匹夻䤽漿ぁ╃≅ⅇ╉♋⅍㉏⅑≓㽕㵗ⵙ牛♝şཡࡣ", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000079C0 File Offset: 0x00005BC0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1127281266;
			short num2 = num;
			num = (short)85979762;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9F;
			case 1:
				break;
			default:
			{
				num = (short)1431699456;
				short num3 = num;
				break;
			}
			}
			num = (short)1896808448;
			if (num != 0)
			{
			}
			num = (short)1563295745;
			if (num != 0)
			{
			}
			if (connectionId != 1)
			{
				this._contentLoaded = true;
				return;
			}
			IL_9F:
			this.rdRadioDetail = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail)target;
		}

		// Token: 0x0400002C RID: 44
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail rdRadioDetail;

		// Token: 0x0400002D RID: 45
		private bool _contentLoaded;
	}
}
