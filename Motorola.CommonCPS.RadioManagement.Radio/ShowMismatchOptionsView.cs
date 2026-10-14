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
	// Token: 0x02000035 RID: 53
	public class ShowMismatchOptionsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00027234 File Offset: 0x00025434
		public ShowMismatchOptionsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00027250 File Offset: 0x00025450
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (!this._contentLoaded)
			{
				short num = (short)1908115565;
				short num2 = num;
				num = (short)364742765;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)587923456;
					short num3 = num;
					break;
				}
				}
				num = (short)82771969;
				if (num != 0)
				{
				}
				num = (short)1781923840;
				if (num != 0)
				{
				}
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("醽趿귁냃꧅뫇ꗉꃋ꿍ﻏ金믓믕뗗뗙닛鷝냟뇡쫣듥觧軩藫臭뷯鏱髳韵鿷鿹釻鯽滿瘁⨃吅椇渉攋愍⬏焑笓笕栗甙爛笝丟嘡ଣ唥䀧䔩嬫䌭夯䄱夳圵䰷夹吻儽〿㙁ⵃ⥅♇㥉㩋❍㕏║筓╕し㕙⭛㍝य़ᅡॣݥᱧ३ѫŭoٱᵳ᥵ᙷॹ੻᝽ꪃﺅ", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00027330 File Offset: 0x00025530
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1321664512;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)921825947;
				short num3 = num;
				num = (short)1551954587;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1547894784;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 1:
						goto IL_F2;
					case 2:
						num = (short)449970177;
						if (num != 0)
						{
						}
						num = (short)1204420609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_10C;
					case 4:
						num = (short)1012662275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_85:
					if (connectionId != 1)
					{
						num = (short)1145831424;
						short num4 = num;
						num = (short)2114322436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CE;
				}
				IL_10C:
				if (connectionId == 2)
				{
					goto IL_152;
				}
				num = (short)191299586;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CE:
			this.dgrMismatchOptions = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_F2:
			this._contentLoaded = true;
			return;
			IL_152:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x04000127 RID: 295
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrMismatchOptions;

		// Token: 0x04000128 RID: 296
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000129 RID: 297
		private bool _contentLoaded;
	}
}
