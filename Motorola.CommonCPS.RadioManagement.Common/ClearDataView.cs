using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200000E RID: 14
	public class ClearDataView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00004B1C File Offset: 0x00002D1C
		public ClearDataView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004B38 File Offset: 0x00002D38
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 9;
			if (this._contentLoaded)
			{
				short num;
				for (;;)
				{
					num = (short)470089728;
					short num2 = num;
					num = (short)1904900231;
					short num3 = num;
					num = (short)697137287;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_73;
					}
				}
				IL_73:
				num = (short)724041729;
				if (num != 0)
				{
				}
				num = (short)1427111936;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郜냞闠賢韤裦藨諪쏬곮黰黲飴飶韸룺근곾⼀儂搄挆怈搊䀌渎缐爒爔爖琘縚猜欞༠怢䨤䨦䐨䐪䌬ᐮ到尲場䜶嘸唺堼儾㕀求⅄╆⑈≊⩌㵎ぐ❒㱔㡖㝘ⵚ㑜㩞ᙠ䱢٤୦౨੪Ὤ୮ၰݲᑴŶၸṺ੼兾呂", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004C1C File Offset: 0x00002E1C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)710803457;
			if (num != 0)
			{
			}
			num = (short)1744961537;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)555483138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1266155520;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_7F;
					}
					continue;
				}
				case 2:
					goto IL_12C;
				}
				IL_7F:
				switch (connectionId)
				{
				case 1:
					goto IL_13B;
				case 2:
					goto IL_108;
				case 3:
					goto IL_FB;
				case 4:
					goto IL_12E;
				default:
				{
					num = (short)2146060563;
					short num4 = num;
					num = (short)1844922643;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_148;
					default:
						num = (short)13631488;
						if (num != 0)
						{
						}
						num = (short)2065367040;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_FB:
			this.dgrJobContainer = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_108:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_12C:
			goto IL_148;
			IL_12E:
			this.btnClose = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_13B:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_148:
			this._contentLoaded = true;
		}

		// Token: 0x04000033 RID: 51
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000034 RID: 52
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000035 RID: 53
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrJobContainer;

		// Token: 0x04000036 RID: 54
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnClose;

		// Token: 0x04000037 RID: 55
		private bool _contentLoaded;
	}
}
