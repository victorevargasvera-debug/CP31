using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x02000008 RID: 8
	[global::System.ComponentModel.Composition.Export("TemplateMainView")]
	public class TemplateMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00005BB0 File Offset: 0x00003DB0
		public TemplateMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00005BCC File Offset: 0x00003DCC
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Template.MainViewModel ViewModel
		{
			set
			{
				short num = (short)1635874869;
				short num2 = num;
				num = (short)1670412341;
				switch (num2 == num)
				{
				}
				num = (short)2069168128;
				if (num != 0)
				{
				}
				num = (short)2008678401;
				if (num != 0)
				{
				}
				num = (short)770899968;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005C7C File Offset: 0x00003E7C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num;
			if (this._contentLoaded)
			{
				for (;;)
				{
					num = (short)1888288769;
					if (num != 0)
					{
					}
					num = (short)1789200291;
					short num2 = num;
					num = (short)128124835;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_71;
					}
				}
				IL_71:
				num = (short)1578369024;
				if (num != 0)
				{
				}
				return;
			}
			num = (short)1958346752;
			short num3 = num;
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("⨄䨆昈缊戌紎縐缒琔㤖娘琚瀜爞丠䴢昤眦稨Ԫ缬丮唰娲娴稶堸唺尼堾⑀⹂⁄⥆㵈敊᥌⩎㱐⍒㥔㙖ⵘ㹚晜㱞๠๢ᕤࡦݨ๪ͬ᭮幰ṲᑴṶ᝸ൺᑼ᩾궂ﶄ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005D60 File Offset: 0x00003F60
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			if (connectionId == 1)
			{
				for (;;)
				{
					num = (short)82525002;
					short num2 = num;
					num = (short)2040150858;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_3E;
					}
				}
				IL_3E:
				num = (short)1439825921;
				if (num != 0)
				{
				}
				num = (short)1156710400;
				if (num != 0)
				{
				}
				this.tplTemplates = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList)target;
				return;
			}
			num = (short)746782720;
			short num3 = num;
			this._contentLoaded = true;
		}

		// Token: 0x04000020 RID: 32
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList tplTemplates;

		// Token: 0x04000021 RID: 33
		private bool _contentLoaded;
	}
}
