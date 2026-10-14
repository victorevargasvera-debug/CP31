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
	// Token: 0x0200000B RID: 11
	public class RadioJobsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00003190 File Offset: 0x00001390
		public RadioJobsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000031AC File Offset: 0x000013AC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 1;
			short num = (short)50967441;
			short num2 = num;
			num = (short)59945873;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1025835008;
				if (num != 0)
				{
				}
				num = (short)712966145;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					num = (short)233766912;
					short num3 = num;
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("벒\ud894춠슢认욨욪사삮\udfb0鞸\udcbc\udbbeꣀ곂裄ꛆꟈ꫊꫌꫎볐뛒믔ꏖ髚軜诞돠곢뛤黦髨鿪裬苮쫰郲髴髶觸铺鏼髾漀眂⨄甆栈漊搌怎笐簒眔搖漘爚砜栞ภ儢䐤䌦䀨䐪䜬䀮匰䀲䌴帶尸䰺ጼ䜾⁀⹂⥄", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003290 File Offset: 0x00001490
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2024231727;
			short num2 = num;
			num = (short)712528687;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)10551296;
				if (num != 0)
				{
				}
				num = (short)763559937;
				if (num != 0)
				{
				}
				if (connectionId != 1)
				{
					num = (short)45875200;
					short num3 = num;
					this._contentLoaded = true;
					return;
				}
				break;
			}
			this.rdRadioDetail = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail)target;
		}

		// Token: 0x0400000A RID: 10
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail rdRadioDetail;

		// Token: 0x0400000B RID: 11
		private bool _contentLoaded;
	}
}
