using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000119 RID: 281
	public class RMConfirmationWindow : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x00092CD8 File Offset: 0x00090ED8
		public RMConfirmationWindow()
		{
			this.InitializeComponent();
			base.KeyDown += this.RMConfirmationWindow_KeyDown;
			this.CanBeClose = true;
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00092D0C File Offset: 0x00090F0C
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00092DBC File Offset: 0x00090FBC
		public bool CanBeClose
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)84926533;
				short num2 = num;
				num = (short)1367007301;
				switch (num2 == num)
				{
				}
				num = (short)1294663681;
				if (num != 0)
				{
				}
				num = (short)629276672;
				if (num != 0)
				{
				}
				num = (short)1789591552;
				short num3 = num;
				return this.<CanBeClose>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1878628798;
				short num2 = num;
				num = (short)34183614;
				switch (num2 == num)
				{
				}
				num = (short)537657344;
				if (num != 0)
				{
				}
				num = (short)8978433;
				if (num != 0)
				{
				}
				num = (short)777650176;
				short num3 = num;
				this.<CanBeClose>k__BackingField = value;
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00092E6C File Offset: 0x0009106C
		private void RMConfirmationWindow_KeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)154140677;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)726663168;
					short num3 = num;
					num = (short)2010710020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)140958087;
					short num4 = num;
					num = (short)461035911;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E8;
					default:
						num = (short)85786624;
						if (num != 0)
						{
						}
						if (A_1.KeyStates == global::System.Windows.Input.Keyboard.GetKeyStates(global::System.Windows.Input.Key.F4))
						{
							num = (short)1786904576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					goto IL_E8;
				case 3:
					num = (short)2109865985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (base.WindowStyle == global::System.Windows.WindowStyle.SingleBorderWindow)
					{
						num = (short)1129512962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 6:
					goto IL_82;
				}
				IL_41:
				if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Alt)
				{
					num = (short)349700099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_E8:
				A_1.Handled = true;
				num = (short)1858994182;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_82:
			num = (short)1958281217;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0009301C File Offset: 0x0009121C
		private void btnYes_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1347760612;
			short num2 = num;
			num = (short)353776100;
			switch (num2 == num)
			{
			}
			num = (short)163250176;
			if (num != 0)
			{
			}
			num = (short)341442561;
			if (num != 0)
			{
			}
			num = (short)776077312;
			short num3 = num;
			((global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation)base.DataContext).Confirmed = true;
			this.CanBeClose = true;
			base.Close();
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000930E4 File Offset: 0x000912E4
		private void Window_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)313311279;
			short num2 = num;
			num = (short)105693231;
			switch (num2 == num)
			{
			}
			num = (short)202833921;
			if (num != 0)
			{
			}
			num = (short)206176256;
			if (num != 0)
			{
			}
			num = (short)792199168;
			short num3 = num;
			base.Topmost = true;
			base.Activate();
			base.Topmost = false;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000931A4 File Offset: 0x000913A4
		protected override void OnSourceInitialized(global::System.EventArgs e)
		{
			short num = (short)1247602956;
			short num2 = num;
			num = (short)893315340;
			switch (num2 == num)
			{
			}
			num = (short)1653080065;
			if (num != 0)
			{
			}
			num = (short)2119106560;
			if (num != 0)
			{
			}
			num = (short)1151074304;
			short num3 = num;
			base.OnSourceInitialized(e);
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			global::Motorola.CommonCPS.RadioManagement.Controls.UnsafeNativeMethods.SetWindowLong(windowInteropHelper.Handle, -16, global::Motorola.CommonCPS.RadioManagement.Controls.UnsafeNativeMethods.GetWindowLong(windowInteropHelper.Handle, -16) & -524289);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0009327C File Offset: 0x0009147C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this._contentLoaded)
			{
				short num = (short)1661786320;
				short num2 = num;
				num = (short)326752464;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1376452609;
					if (num != 0)
					{
					}
					num = (short)1880424448;
					short num3 = num;
					num = (short)379387904;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("趡즥\udca7얩\udeab솭\udcaf펱骳ힷힹ톻톽꺿臁铃闅飉귋꫍맏뷑駓럕뛗믙믛믝跟蟡諣鋥웧ꧩ菫胭蓯胱鯳髵请쇹鿻釽淿爁欃栅洇搉砋ℍ朏笑稓爕眗洙漛ㄝ刟伡䜣䤥䘧䰩䔫尭崯匱䀳張圷吹䬻圽⸿♁⭃ㅅ晇㉉ⵋ⍍㱏", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00093360 File Offset: 0x00091560
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1771310889;
			short num2 = num;
			num = (short)219746089;
			switch (num2 == num)
			{
			}
			num = (short)1223884800;
			if (num != 0)
			{
			}
			num = (short)1082130433;
			if (num != 0)
			{
			}
			num = (short)1190330368;
			short num3 = num;
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00093414 File Offset: 0x00091614
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)554500098;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)332791809;
					if (num != 0)
					{
					}
					num = (short)1009844225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_BC;
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
					goto IL_67;
				case 2:
					goto IL_5A;
				case 3:
				{
					num = (short)424209309;
					short num3 = num;
					num = (short)1542515613;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_11F;
					}
					goto Block_2;
				}
				default:
					num = (short)1054212096;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_5A:
			this.btnYes = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_67:
			((global::Motorola.CommonCPS.RadioManagement.Controls.RMConfirmationWindow)target).Loaded += this.Window_Loaded;
			return;
			IL_BC:
			this._contentLoaded = true;
			return;
			Block_2:
			num = (short)1337327616;
			short num4 = num;
			IL_11F:
			num = (short)146604032;
			if (num != 0)
			{
			}
			this.btnNo = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x0400041E RID: 1054
		private const int GWL_STYLE = -16;

		// Token: 0x0400041F RID: 1055
		private const int WS_SYSMENU = 524288;

		// Token: 0x04000420 RID: 1056
		private const uint MF_BYCOMMAND = 0U;

		// Token: 0x04000421 RID: 1057
		private const uint MF_GRAYED = 1U;

		// Token: 0x04000422 RID: 1058
		private const uint SC_CLOSE = 61536U;

		// Token: 0x04000424 RID: 1060
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnYes;

		// Token: 0x04000425 RID: 1061
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnNo;

		// Token: 0x04000426 RID: 1062
		private bool _contentLoaded;
	}
}
