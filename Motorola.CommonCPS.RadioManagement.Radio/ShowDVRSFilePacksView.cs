using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000012 RID: 18
	public class ShowDVRSFilePacksView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00007A38 File Offset: 0x00005C38
		public ShowDVRSFilePacksView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007A54 File Offset: 0x00005C54
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this._contentLoaded)
			{
				short num = (short)139264000;
				short num2 = num;
				num = (short)484151391;
				short num3 = num;
				num = (short)2087751775;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1609826304;
					if (num != 0)
					{
					}
					num = (short)767557633;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("醽趿귁냃꧅뫇ꗉꃋ꿍ﻏ金믓믕뗗뗙닛鷝냟뇡쫣듥觧軩藫臭뷯鏱髳韵鿷鿹釻鯽滿瘁⨃吅椇渉攋愍⬏焑笓笕栗甙爛笝丟嘡ଣ唥䀧䔩嬫䨭䘯䀱䜳倵儷嘹夻䴽〿⍁❃⩅㭇㱉╋⭍❏絑❓㹕㝗ⵙ㡛⡝቟ᅡɣཥѧཀྵᱫ཭፯ᥱݳuᅷό୻偽", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007B38 File Offset: 0x00005D38
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1235943427;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 2)
					{
						num = (short)936378369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
				case 1:
				{
					num = (short)1852101711;
					short num3 = num;
					num = (short)39113807;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)766836737;
						if (num != 0)
						{
						}
						num = (short)189399040;
						if (num != 0)
						{
						}
						num = (short)309592068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)1146290176;
					short num4 = num;
					num = (short)57147392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					goto IL_115;
				}
				IL_39:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1561657346;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.dgrDVRSFilePacks = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_115:
			this._contentLoaded = true;
			return;
			IL_14E:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x0400003B RID: 59
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrDVRSFilePacks;

		// Token: 0x0400003C RID: 60
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400003D RID: 61
		private bool _contentLoaded;
	}
}
