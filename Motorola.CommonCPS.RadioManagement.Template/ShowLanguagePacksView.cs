using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x0200000F RID: 15
	public class ShowLanguagePacksView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000AB00 File Offset: 0x00008D00
		public ShowLanguagePacksView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000AB1C File Offset: 0x00008D1C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num = (short)1816788993;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)1097618467;
				short num2 = num;
				num = (short)1919964195;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AF;
				case 1:
					break;
				default:
				{
					num = (short)1447821312;
					short num3 = num;
					break;
				}
				}
				num = (short)725745664;
				if (num != 0)
				{
				}
				return;
			}
			IL_AF:
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("⤅䔇攉砋愍戏紑砓眕㘗夙猛猝䴟䴡䨣攥砧礩ȫ簭儯嘱崳夵男嬹刻弽✿❁⥃⍅♇㹉手ᩍ㕏㽑⑓㩕㥗⹙㥛敝͟ൡॣᙥݧѩ५mѯ嵱ݳṵ᝷൹ၻώﲋ撚ﾙ놝펟쪡쮣톥쒧쮩슫즭얯펱펳펵좷\udbb9\udfbb햽뎿듁귃ꏅ뿇듋꿍뷏뻑", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000ABFC File Offset: 0x00008DFC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)242679811;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1146930459;
					short num3 = num;
					num = (short)1073333531;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61;
					default:
						goto IL_115;
					}
					break;
				}
				case 1:
					if (connectionId != 2)
					{
						num = (short)1922236418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AC;
				case 2:
					goto IL_61;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 4:
					num = (short)467271681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3A:
				if (connectionId != 1)
				{
					num = (short)1137901572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_61:
				num = (short)1105985536;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.dgrLanguagePacks = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_AC:
			num = (short)165609473;
			if (num != 0)
			{
			}
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_115:
			num = (short)678952960;
			if (num != 0)
			{
			}
			num = (short)2006777856;
			short num4 = num;
			this._contentLoaded = true;
		}

		// Token: 0x0400003B RID: 59
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrLanguagePacks;

		// Token: 0x0400003C RID: 60
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400003D RID: 61
		private bool _contentLoaded;
	}
}
