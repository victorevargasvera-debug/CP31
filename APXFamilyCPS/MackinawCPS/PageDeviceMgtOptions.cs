using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200002F RID: 47
	public class PageDeviceMgtOptions : global::System.Windows.Controls.Page, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00013AEC File Offset: 0x00011CEC
		public PageDeviceMgtOptions()
		{
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00013B0C File Offset: 0x00011D0C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 15;
			short num = (short)1396730388;
			short num2 = num;
			num = (short)1041263124;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)421462017;
				if (num != 0)
				{
				}
				num = (short)2081226752;
				short num3 = num;
				num = (short)976420864;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("샮냰ꏲ귴뇶飸雺铼鏾砀䀂唄吆㈈栊戌戎愐簒笔爖眘漚㈜笞䐠唢䰤䐦䰨䘪䰬䄮倰吲倴䔶ᘸ䬺尼堾⑀❂⁄ㅆ⁈⡊⡌≎㙐❒㩔❖ⵘ㉚㉜ㅞበ䵢ᵤ٦Ѩݪ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00013BEC File Offset: 0x00011DEC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1249837057;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_106;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_13D;
				case 2:
				{
					num = (short)1587743448;
					short num3 = num;
					num = (short)705039064;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A3;
					}
					break;
				}
				case 3:
					goto IL_61;
				case 4:
					goto IL_108;
				default:
					num = (short)2147352576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5C:
				num = (short)1440874498;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_61:
			this.ButtonCloneradio = (global::System.Windows.Controls.Button)target;
			return;
			IL_A3:
			num = (short)2005467136;
			if (num != 0)
			{
			}
			num = (short)1019871232;
			short num4 = num;
			this.ButtonWriteRadio = (global::System.Windows.Controls.Button)target;
			return;
			IL_106:
			this._contentLoaded = true;
			return;
			IL_108:
			num = (short)1960312833;
			if (num != 0)
			{
			}
			this.ButtonFlashradio = (global::System.Windows.Controls.Button)target;
			return;
			IL_13D:
			this.ButtonReadRadio = (global::System.Windows.Controls.Button)target;
		}

		// Token: 0x040000B4 RID: 180
		internal global::System.Windows.Controls.Button ButtonReadRadio;

		// Token: 0x040000B5 RID: 181
		internal global::System.Windows.Controls.Button ButtonWriteRadio;

		// Token: 0x040000B6 RID: 182
		internal global::System.Windows.Controls.Button ButtonCloneradio;

		// Token: 0x040000B7 RID: 183
		internal global::System.Windows.Controls.Button ButtonFlashradio;

		// Token: 0x040000B8 RID: 184
		private bool _contentLoaded;

		// Token: 0x040000B9 RID: 185
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
