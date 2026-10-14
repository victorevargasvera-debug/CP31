using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using AcpUI;
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.CloneWiFi
{
	// Token: 0x02000198 RID: 408
	public class PageCloneWiFiView : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06001376 RID: 4982 RVA: 0x000037F4 File Offset: 0x000019F4
		public PageCloneWiFiView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x001C3444 File Offset: 0x001C1644
		public override void SetDataContext()
		{
			short num = (short)1503199233;
			if (num != 0)
			{
			}
			num = (short)864092160;
			short num2 = num;
			num = (short)929933234;
			short num3 = num;
			num = (short)546351026;
			switch (num3 == num)
			{
			}
			num = (short)869400576;
			if (num != 0)
			{
			}
			base.DataContext = new global::SpecialFeatures.CloneWiFi.PageCloneWiFiViewModel(this);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x001C34FC File Offset: 0x001C16FC
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			double height;
			short num2;
			double width;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.ExpanderWifiConfiguredNetworksList.MaxHeight = 0.6 * height;
					num2 = (short)132186114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)653908700;
					short num3 = num2;
					num2 = (short)1141562076;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1109786624;
						if (num2 != 0)
						{
						}
						if (width < 620.0)
						{
							goto IL_1BF;
						}
						break;
					}
					num2 = (short)1009057795;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_DB;
				case 3:
					goto IL_160;
				case 4:
				{
					num2 = (short)1775828992;
					short num4 = num2;
					if (height >= 500.0)
					{
						num2 = (short)927793152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DB;
				}
				}
				goto IL_24;
				IL_DB:
				num2 = (short)1059520513;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_160:
			num2 = (short)1112211457;
			if (num2 != 0)
			{
			}
			this.DataWideWiFiNetworkEncryptedNetworkPassword_42517_Col.Width = new global::Infragistics.Windows.DataPresenter.FieldLength?(new global::Infragistics.Windows.DataPresenter.FieldLength(180.0 + width - 620.0));
			return;
			IL_1BF:
			this.DataWideWiFiNetworkEncryptedNetworkPassword_42517_Col.Width = new global::Infragistics.Windows.DataPresenter.FieldLength?(new global::Infragistics.Windows.DataPresenter.FieldLength(180.0));
			return;
			IL_24:
			base.OnRenderSizeChanged(sizeInfo);
			width = sizeInfo.NewSize.Width;
			height = sizeInfo.NewSize.Height;
			num2 = (short)1914503172;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x001C36E8 File Offset: 0x001C18E8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)158072834;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_EC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1076953089;
				if (num != 0)
				{
				}
				num = (short)1364192908;
				short num3 = num;
				num = (short)1061023372;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_EC:
					global::System.Windows.Input.Keyboard.Focus(this);
					num = (short)1370685440;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)496041984;
					if (num != 0)
					{
					}
					num = (short)1504575488;
					short num4 = num;
					if (base.IsKeyboardFocusWithin)
					{
						return;
					}
					num = (short)1798242305;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x001C3804 File Offset: 0x001C1A04
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			short num;
			if (this.a)
			{
				num = (short)715874362;
				short num2 = num;
				num = (short)1613979706;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1036910592;
					short num3 = num;
					num = (short)27131904;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			num = (short)849281025;
			if (num != 0)
			{
			}
			this.a = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂꓆ꗈ꓊ꏌ꫎듖뛘뗚믜뛞蛠離韤蛦鷨苪苬臮\udef0郲駴飶韸黺\ud8fc췾㄀琂氄愆怈␊紌渎瘐瘒瘔笖瘘甚砜栞䠠䔢䰤儦䀨个娬Į䤰刲場嬶", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x001C38E0 File Offset: 0x001C1AE0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)105381890;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11C;
				case 1:
					num = (short)901578752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				for (;;)
				{
					IL_30:
					switch (connectionId)
					{
					case 1:
					{
						num = (short)134053020;
						short num3 = num;
						num = (short)530807964;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_CA;
						}
						break;
					}
					case 2:
						goto IL_172;
					case 3:
						goto IL_1B3;
					case 4:
						goto IL_165;
					case 5:
						goto IL_87;
					case 6:
						goto IL_1A6;
					case 7:
						goto IL_7A;
					case 8:
						goto IL_121;
					case 9:
						goto IL_F8;
					case 10:
						goto IL_158;
					}
					break;
				}
				num = (short)39714817;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7A:
			this.LblCloneWiFiWarning = (global::System.Windows.Controls.Label)target;
			return;
			IL_87:
			this.DataWideWiFiNetworkSSID_42519_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_CA:
			num = (short)1401815040;
			if (num != 0)
			{
			}
			((global::SpecialFeatures.CloneWiFi.PageCloneWiFiView)target).Loaded += this.OnLoaded;
			return;
			IL_F8:
			this.buttonCancel = (global::System.Windows.Controls.Button)target;
			return;
			IL_11C:
			this.a = true;
			return;
			IL_121:
			num = (short)1706098688;
			short num4 = num;
			this.buttonOK = (global::System.Windows.Controls.Button)target;
			return;
			IL_158:
			this.buttonHelp = (global::System.Windows.Controls.Button)target;
			return;
			IL_165:
			this.DataWideFeatureName_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_172:
			num = (short)1125384193;
			if (num != 0)
			{
			}
			this.LblCloneWiFiDescription = (global::System.Windows.Controls.Label)target;
			return;
			IL_1A6:
			this.DataWideWiFiNetworkEncryptedNetworkPassword_42517_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1B3:
			this.ExpanderWifiConfiguredNetworksList = (global::AcpUI.AcpXamDataPresenter)target;
		}

		// Token: 0x04000A9D RID: 2717
		internal global::System.Windows.Controls.Label LblCloneWiFiDescription;

		// Token: 0x04000A9E RID: 2718
		internal global::AcpUI.AcpXamDataPresenter ExpanderWifiConfiguredNetworksList;

		// Token: 0x04000A9F RID: 2719
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideFeatureName_Col;

		// Token: 0x04000AA0 RID: 2720
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideWiFiNetworkSSID_42519_Col;

		// Token: 0x04000AA1 RID: 2721
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideWiFiNetworkEncryptedNetworkPassword_42517_Col;

		// Token: 0x04000AA2 RID: 2722
		internal global::System.Windows.Controls.Label LblCloneWiFiWarning;

		// Token: 0x04000AA3 RID: 2723
		internal global::System.Windows.Controls.Button buttonOK;

		// Token: 0x04000AA4 RID: 2724
		internal global::System.Windows.Controls.Button buttonCancel;

		// Token: 0x04000AA5 RID: 2725
		internal global::System.Windows.Controls.Button buttonHelp;

		// Token: 0x04000AA6 RID: 2726
		private bool a;
	}
}
