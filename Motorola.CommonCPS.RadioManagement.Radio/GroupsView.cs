using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000015 RID: 21
	public class GroupsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00008010 File Offset: 0x00006210
		public GroupsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000802C File Offset: 0x0000622C
		public void PrepareRename(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group)
		{
			short num = (short)2076614732;
			short num2 = num;
			num = (short)193765452;
			switch (num2 == num)
			{
			}
			num = (short)843251713;
			if (num != 0)
			{
			}
			num = (short)784531456;
			short num3 = num;
			num = (short)1370947584;
			if (num != 0)
			{
			}
			this.gplGroups.PrepareRename(group);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000080E0 File Offset: 0x000062E0
		public void EndEditMode()
		{
			short num = (short)2029400090;
			short num2 = num;
			num = (short)816066586;
			switch (num2 == num)
			{
			}
			num = (short)60882945;
			if (num != 0)
			{
			}
			num = (short)736755712;
			short num3 = num;
			num = (short)1545469952;
			if (num != 0)
			{
			}
			this.gplGroups.EndEditMode();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008198 File Offset: 0x00006398
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			if (this._contentLoaded)
			{
				short num = (short)1085734912;
				short num2 = num;
				num = (short)2099910676;
				short num3 = num;
				num = (short)1110382612;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1514602497;
					if (num != 0)
					{
					}
					num = (short)65404928;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("藇ꗉ룋ꇍꋏ뷑룓럕駙돛돝跟跡諣ꗥ룧맩싫볭釯雱鷳駵뗷鯹鋻鿽柿朁椃挅昇縉∋對焏瘑紓礕⌗礙猛猝借䴡䨣䌥䘧帩̫䤭䈯崱䄳䘵䬷䰹唻嬽㜿流⍃㑅❇㽉㱋㵍♏㭑ㅓ⅕癗≙㵛㍝౟", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000827C File Offset: 0x0000647C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				short num = (short)1008599040;
				short num2 = num;
				num = (short)510658775;
				short num3 = num;
				num = (short)1801390295;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1116405760;
					if (num != 0)
					{
					}
					num = (short)694550529;
					if (num != 0)
					{
					}
					this.gplGroups = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList)target;
					return;
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x0400003F RID: 63
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList gplGroups;

		// Token: 0x04000040 RID: 64
		private bool _contentLoaded;
	}
}
