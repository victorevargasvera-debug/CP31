using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200000A RID: 10
	public class GroupsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002FD0 File Offset: 0x000011D0
		public GroupsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002FEC File Offset: 0x000011EC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num;
			if (this._contentLoaded)
			{
				num = (short)311062249;
				short num2 = num;
				num = (short)1936092905;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2082209793;
					if (num != 0)
					{
					}
					num = (short)591921152;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)110755840;
			short num3 = num;
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("릕햗튟춡좣장蚧쎫쎭\uddaf\uddb1\udab3銻ꆿꛁ귃꧅藇ꯉꋋ꿍럏럑맓돕뛗껙鿝돟뛡뛣ꧥ믧鏩鿫髭闯鿱쿳闵韷韹賻釽滿朁樃爅✇洉縋愍攏我朓怕焗缙欛ㄝ䜟倡䬣匥堧天娫䜭唯䔱ᨳ丵夷圹倻", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000030CC File Offset: 0x000012CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1698315912;
			short num2 = num;
			num = (short)1222000264;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)958922752;
				if (num != 0)
				{
				}
				num = (short)99221505;
				if (num != 0)
				{
				}
				if (connectionId != 1)
				{
					num = (short)1496645632;
					short num3 = num;
					this._contentLoaded = true;
					return;
				}
				break;
			}
			this.gplGroups = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList)target;
		}

		// Token: 0x04000008 RID: 8
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList gplGroups;

		// Token: 0x04000009 RID: 9
		private bool _contentLoaded;
	}
}
