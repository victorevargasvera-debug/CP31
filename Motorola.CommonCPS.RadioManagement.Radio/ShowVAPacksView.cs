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
	// Token: 0x02000038 RID: 56
	public class ShowVAPacksView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600023A RID: 570 RVA: 0x000277A8 File Offset: 0x000259A8
		public ShowVAPacksView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000277C4 File Offset: 0x000259C4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 7;
			short num;
			if (!this._contentLoaded)
			{
				num = (short)256049152;
				short num2 = num;
				num = (short)513837975;
				short num3 = num;
				num = (short)585075607;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)703004672;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("钺킾뗀곂럄꣆ꗈ꫊賎뻐뻒룔룖럘飚跜賞쿠뇢蓤菦胨蓪ꃬ軮鿰鋲鋴鋶铸黺鏼课⼀儂搄挆怈搊㘌氎縐縒攔砖眘縚猜欞ภ倢䴤䠦帨崪䰬弮倰倲帴䐶伸刺堼䠾湀あⵄ⡆㹈㵊ⱌ㽎ぐげ㹔⑖⽘㉚㡜⡞你᭢Ѥ੦ը", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)875364353;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000278A4 File Offset: 0x00025AA4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1263075328;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)278660157;
				short num3 = num;
				num = (short)631571517;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)974782465;
					if (num != 0)
					{
					}
					num = (short)1197408256;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					case 1:
						goto IL_117;
					case 2:
						num = (short)532807681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_130;
					case 4:
						num = (short)1767833603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AD:
					num = (short)2072969216;
					short num4 = num;
					if (connectionId != 1)
					{
						num = (short)1461583876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F2;
				}
				}
				IL_130:
				if (connectionId == 2)
				{
					goto IL_14D;
				}
				num = (short)2061500418;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F2:
			this.dgrVAPacks = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_117:
			this._contentLoaded = true;
			return;
			IL_14D:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x0400012C RID: 300
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrVAPacks;

		// Token: 0x0400012D RID: 301
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400012E RID: 302
		private bool _contentLoaded;
	}
}
