using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Programming
{
	// Token: 0x0200008F RID: 143
	public class USBProgrammingWindow : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x00002CB3 File Offset: 0x00000EB3
		public USBProgrammingWindow()
		{
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000C2DE4 File Offset: 0x000C0FE4
		internal USBProgrammingWindow(global::SpecialFeatures.Programming.ProgrammingOperation operation)
		{
			global::AcpUI.Common.Utility.SetDirection(this);
			this.a = operation;
			if (operation == global::SpecialFeatures.Programming.ProgrammingOperation.PROGRAMMING_OPERATION_READ)
			{
				this.operationLabel.Content = global::CommonResources.AppResources.USB_Read_Radio;
				this.btnOperation.Content = global::CommonResources.AppResources.Read_Radio;
				return;
			}
			this.operationLabel.Content = global::CommonResources.AppResources.USB_Write_Radio;
			this.btnOperation.Content = global::CommonResources.AppResources.Write_Radio;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000C2E4C File Offset: 0x000C104C
		private void btnOperation_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2085329101;
			short num2 = num;
			num = (short)1069848781;
			switch (num2 == num)
			{
			}
			num = (short)727449601;
			if (num != 0)
			{
			}
			num = (short)967966720;
			short num3 = num;
			num = (short)1370554368;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000C2EF8 File Offset: 0x000C10F8
		private void btnCancel_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1277347917;
			short num2 = num;
			num = (short)110741581;
			switch (num2 == num)
			{
			}
			num = (short)2014314497;
			if (num != 0)
			{
			}
			num = (short)584974336;
			short num3 = num;
			num = (short)1931018240;
			if (num != 0)
			{
			}
			base.DialogResult = new bool?(false);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000C2FAC File Offset: 0x000C11AC
		private void btnHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1686447487;
			short num2 = num;
			num = (short)242754943;
			switch (num2 == num)
			{
			}
			num = (short)66781185;
			if (num != 0)
			{
			}
			num = (short)191496192;
			short num3 = num;
			num = (short)760086528;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x000C3058 File Offset: 0x000C1258
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (this.b)
			{
				short num = (short)573046784;
				short num2 = num;
				num = (short)1868025253;
				short num3 = num;
				num = (short)1669713317;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1844707328;
					if (num != 0)
					{
					}
					num = (short)704118785;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾏솑ﮗﶛ잡얣튥\udda7\ud8a9즫\uddad讯톱\udbb3\udbb5좷햹튻\udbbd꺿뛁뛅뫇ꗉꯋ볍뇏뿑맓뿕뛗뷙ꯝ鏟胡쯣鏥鯧裩鳫鳭鿯闱蛳韵闷韹闻都柿甁洃栅氇攉笋‍栏猑礓稕", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000C313C File Offset: 0x000C133C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1685192706;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)775487489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_AC;
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
					goto IL_121;
				case 2:
					goto IL_87;
				case 3:
					goto IL_17D;
				case 4:
					goto IL_63;
				case 5:
					goto IL_FD;
				default:
					num = (short)323223552;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_63:
			this.btnCancel = (global::System.Windows.Controls.Button)target;
			this.btnCancel.Click += this.btnCancel_Click;
			return;
			IL_87:
			this.operationLabel = (global::System.Windows.Controls.Label)target;
			return;
			IL_AC:
			num = (short)780528397;
			short num3 = num;
			num = (short)567995149;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_87;
			default:
				num = (short)363331584;
				if (num != 0)
				{
				}
				this.b = true;
				return;
			}
			IL_FD:
			this.btnHelp = (global::System.Windows.Controls.Button)target;
			this.btnHelp.Click += this.btnHelp_Click;
			return;
			IL_121:
			num = (short)510656513;
			if (num != 0)
			{
			}
			num = (short)1157627904;
			short num4 = num;
			this.ProgrammingPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_17D:
			this.btnOperation = (global::System.Windows.Controls.Button)target;
			this.btnOperation.Click += this.btnOperation_Click;
		}

		// Token: 0x04000452 RID: 1106
		private global::SpecialFeatures.Programming.ProgrammingOperation a;

		// Token: 0x04000453 RID: 1107
		internal global::System.Windows.Controls.StackPanel ProgrammingPanel;

		// Token: 0x04000454 RID: 1108
		internal global::System.Windows.Controls.Label operationLabel;

		// Token: 0x04000455 RID: 1109
		internal global::System.Windows.Controls.Button btnOperation;

		// Token: 0x04000456 RID: 1110
		internal global::System.Windows.Controls.Button btnCancel;

		// Token: 0x04000457 RID: 1111
		internal global::System.Windows.Controls.Button btnHelp;

		// Token: 0x04000458 RID: 1112
		private bool b;
	}
}
