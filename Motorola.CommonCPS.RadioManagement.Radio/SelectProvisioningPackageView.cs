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
	// Token: 0x02000027 RID: 39
	public class SelectProvisioningPackageView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x0002039C File Offset: 0x0001E59C
		public SelectProvisioningPackageView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000203B8 File Offset: 0x0001E5B8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			short num = (short)619468710;
			short num2 = num;
			num = (short)1430149030;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)456261633;
				if (num != 0)
				{
				}
				num = (short)1996816384;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("軂꫄돆ꛈ맊ꋌꏎ냐﷒雔룖듘뛚닜뇞ꋠ돢뛤짦믨諪觬蛮黰뻲铴駶飸鳺飼鋾搀洂焄⤆嬈樊椌明縐⠒瘔砖琘欚爜焞䐠䴢儤ࠦ娨个䄬䨮到䜲䔴䔶嘸䴺吼䰾⡀ⱂ⭄⹆❈ⱊ㵌⹎㉐㡒㑔ざ㱘ⵚ㑜㩞ᙠ䱢ᙤɦը๪๬᭮ŰŲᩴŶၸࡺᑼၾ麗ﺚ놞\ud9a0슢좤쮦", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				num = (short)575930368;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0002049C File Offset: 0x0001E69C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1128595458;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1762681274;
					short num3 = num;
					num = (short)441868730;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)618135552;
						if (num != 0)
						{
						}
						num = (short)821886977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_D7;
				case 2:
					goto IL_14;
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
					IL_30:
					switch (connectionId)
					{
					case 1:
						goto IL_67;
					case 2:
						goto IL_5A;
					case 3:
						goto IL_D9;
					default:
						num = (short)665911296;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_5A:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_67:
			this.dgrGeneralPackages = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_D7:
			num = (short)1117323265;
			if (num != 0)
			{
			}
			num = (short)75431936;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_D9:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x040000CD RID: 205
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrGeneralPackages;

		// Token: 0x040000CE RID: 206
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000CF RID: 207
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000D0 RID: 208
		private bool _contentLoaded;
	}
}
