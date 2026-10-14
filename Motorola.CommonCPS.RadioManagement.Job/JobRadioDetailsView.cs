using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x02000009 RID: 9
	public class JobRadioDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003B00 File Offset: 0x00001D00
		public JobRadioDetailsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003B1C File Offset: 0x00001D1C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			short num = (short)986447873;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)2004235040;
				short num2 = num;
				num = (short)1890792224;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)987103232;
					short num3 = num;
					break;
				}
				}
				num = (short)453443584;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("㼏弑笓戕眗栙猛爝䄟డ朣䤥䔧䜩䌫䀭猯戱朳ᠵ樷嬹堻圽⼿ཁ╃⡅⥇ⵉ⥋⍍㕏㱑⁓硕቗㕙㹛敝͟ൡॣᙥݧѩ५mѯ嵱ṳ᥵᩷ࡹᵻ᩽ﲇﶓ떙슟킡얣슥솧얩좫쮭쒯펱\uddb3\udab5쮷첹햻\udbbd랿볃Ʂꗇꛉ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003C00 File Offset: 0x00001E00
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				short num = (short)2050621441;
				if (num != 0)
				{
				}
				num = (short)1918018304;
				short num2 = num;
				num = (short)1243521792;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A2;
				case 1:
					break;
				default:
				{
					num = (short)108920832;
					short num3 = num;
					break;
				}
				}
				num = (short)397606912;
				if (num != 0)
				{
				}
				IL_A2:
				this.rdRadioDetail = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x04000015 RID: 21
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail rdRadioDetail;

		// Token: 0x04000016 RID: 22
		private bool _contentLoaded;
	}
}
