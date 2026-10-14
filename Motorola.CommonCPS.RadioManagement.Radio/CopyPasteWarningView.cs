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
	// Token: 0x0200000A RID: 10
	public class CopyPasteWarningView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00004EF0 File Offset: 0x000030F0
		public CopyPasteWarningView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004F0C File Offset: 0x0000310C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this._contentLoaded)
			{
				short num;
				for (;;)
				{
					num = (short)1665902236;
					short num2 = num;
					num = (short)148874908;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_75;
					}
					break;
				}
				num = (short)1868824576;
				short num3 = num;
				IL_75:
				num = (short)46596096;
				if (num != 0)
				{
				}
				num = (short)1820590081;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("醽趿귁냃꧅뫇ꗉꃋ꿍ﻏ金믓믕뗗뗙닛鷝냟뇡쫣듥觧軩藫臭뷯鏱髳韵鿷鿹釻鯽滿瘁⨃吅椇渉攋愍⬏焑笓笕栗甙爛笝丟嘡ଣ䔥䜧娩唫席儯䄱䀳匵伷嬹主倽⸿⭁⩃ⅅ㹇⍉⥋㥍罏ㅑ㭓♕⅗⩙㵛ⵝᑟݡ፣ݥᩧѩɫݭṯᕱɳήᵷ൹剻ٽ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004FF0 File Offset: 0x000031F0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)682950658;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12E;
				case 1:
				{
					num = (short)93782017;
					if (num != 0)
					{
					}
					num = (short)1468892369;
					short num3 = num;
					num = (short)141853905;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
					{
						num = (short)795017216;
						if (num != 0)
						{
						}
						num = (short)1152188416;
						short num4 = num;
						num = (short)444006400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_13D;
				case 2:
					goto IL_10A;
				case 3:
					goto IL_FD;
				case 4:
					goto IL_130;
				default:
					num = (short)99614721;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_FD:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_10A:
			this.dgrCannotPasteWarning = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_12E:
			this._contentLoaded = true;
			return;
			IL_130:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_13D:
			this.usc_CopyPasteView = (global::Motorola.CommonCPS.RadioManagement.Radio.CopyPasteWarningView)target;
		}

		// Token: 0x04000021 RID: 33
		internal global::Motorola.CommonCPS.RadioManagement.Radio.CopyPasteWarningView usc_CopyPasteView;

		// Token: 0x04000022 RID: 34
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrCannotPasteWarning;

		// Token: 0x04000023 RID: 35
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000024 RID: 36
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000025 RID: 37
		private bool _contentLoaded;
	}
}
