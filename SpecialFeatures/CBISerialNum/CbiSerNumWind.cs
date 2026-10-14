using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ACPBrowser;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;

namespace SpecialFeatures.CBISerialNum
{
	// Token: 0x020001B0 RID: 432
	public class CbiSerNumWind : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600146A RID: 5226 RVA: 0x001D6448 File Offset: 0x001D4648
		public CbiSerNumWind()
		{
			int a_ = 16;
			base..ctor();
			this.InitializeComponent();
			this.CbiSerEntry.Focus();
			global::AcpUI.Common.Utility.SetDirection(this);
			if (global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
			{
				this.CbiSerEntry.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
				this.CbiSerEntry.TextAlignment = global::System.Windows.TextAlignment.Right;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x001D64C4 File Offset: 0x001D46C4
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x001D6574 File Offset: 0x001D4774
		public string SerNum
		{
			get
			{
				short num = (short)972276263;
				short num2 = num;
				num = (short)658096679;
				switch (num2 == num)
				{
				}
				num = (short)159711233;
				if (num != 0)
				{
				}
				num = (short)1679949824;
				short num3 = num;
				num = (short)548143104;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1670058029;
				short num2 = num;
				num = (short)184029229;
				switch (num2 == num)
				{
				}
				num = (short)1471217664;
				if (num != 0)
				{
				}
				num = (short)736362496;
				short num3 = num;
				num = (short)245432321;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x001D6624 File Offset: 0x001D4824
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)124347194;
			short num2 = num;
			num = (short)1440637754;
			switch (num2 == num)
			{
			}
			num = (short)513277952;
			if (num != 0)
			{
			}
			num = (short)508493824;
			short num3 = num;
			num = (short)1386872833;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x001D66D4 File Offset: 0x001D48D4
		private void buttonHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)1379934984;
				short num2 = num;
				num = (short)200811272;
				switch (num2 == num)
				{
				}
				num = (short)547815425;
				if (num != 0)
				{
				}
				num = (short)1871380480;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(null);
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1262682112;
			short num3 = num;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x001D67A0 File Offset: 0x001D49A0
		private void CbiSerEntryOK_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			string text;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						if (string.IsNullOrEmpty(this.CbiSerEntry.Text))
						{
							num2 = (short)347406338;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						goto IL_FC;
					case 2:
						num2 = (short)1908670465;
						if (num2 != 0)
						{
						}
						this.CbiSerEntry.GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty).UpdateSource();
						num2 = (short)508624899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return;
					case 4:
						if (global::SpecialFeatures.Comms.SerialNumberValidator.ValidateSerialNumber(global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(text))))
						{
							num2 = (short)1559625728;
							short num3 = num2;
							num2 = (short)1456144385;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.CbiSerEntry.Focus();
						num2 = (short)1713176576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_24:
				num2 = (short)932562974;
				short num4 = num2;
				num2 = (short)1381353502;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)870318080;
					if (num2 != 0)
					{
					}
					text = this.CbiSerEntry.ToString();
					int length = text.Length;
					text = text.Substring(length - 10, 10);
					num2 = (short)1063124996;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			IL_FC:
			this.a = text;
			base.Close();
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x001D6968 File Offset: 0x001D4B68
		private void CbiSerEntryCancel_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)753951170;
			short num2 = num;
			num = (short)1957257666;
			switch (num2 == num)
			{
			}
			num = (short)1171783681;
			if (num != 0)
			{
			}
			num = (short)2121924608;
			short num3 = num;
			num = (short)1865089024;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x001D6A18 File Offset: 0x001D4C18
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 0;
			if (this.b)
			{
				short num = (short)1800866574;
				short num2 = num;
				num = (short)275057422;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)405340161;
					if (num != 0)
					{
					}
					num = (short)650313728;
					if (num != 0)
					{
					}
					num = (short)1360592896;
					short num3 = num;
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겂횄﶐햒爵튠颢욤좦쒨\udbaa슬솮풰\uddb2솴颶\udab8\ud9ba풼邾ꋀꇂ계듆곈맊ꏌ뫎볐ꓒ볔맖뷘ꗜ뻞賠迢", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x001D6AFC File Offset: 0x001D4CFC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1542455298;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D7;
				case 1:
					num = (short)379060224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_181;
				case 2:
					goto IL_13A;
				case 3:
					goto IL_201;
				case 4:
					goto IL_1B3;
				case 5:
					goto IL_1F4;
				case 6:
					goto IL_102;
				case 7:
					goto IL_18E;
				case 8:
					goto IL_F5;
				case 9:
					goto IL_1DC;
				case 10:
					goto IL_169;
				case 11:
					goto IL_19B;
				default:
				{
					num = (short)1405812737;
					if (num != 0)
					{
					}
					num = (short)1106965647;
					short num3 = num;
					num = (short)575730831;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F5;
					default:
						num = (short)1097990144;
						if (num != 0)
						{
						}
						num = (short)465436673;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_F5:
			this.textBoxError = (global::System.Windows.Controls.TextBox)target;
			return;
			IL_102:
			num = (short)68222976;
			short num4 = num;
			this.stackPanelError = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_13A:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.buttonHelp_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_169:
			((global::System.Windows.Controls.Button)target).Click += this.CbiSerEntryCancel_Click;
			return;
			IL_181:
			this.myCbiWindow = (global::SpecialFeatures.CBISerialNum.CbiSerNumWind)target;
			return;
			IL_18E:
			this.imageError = (global::System.Windows.Controls.Image)target;
			return;
			IL_19B:
			((global::System.Windows.Controls.Button)target).Click += this.CbiSerEntryOK_Click;
			return;
			IL_1B3:
			this.Main = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1D7:
			this.b = true;
			return;
			IL_1DC:
			((global::System.Windows.Controls.Button)target).Click += this.buttonHelp_Click;
			return;
			IL_1F4:
			this.CbiSerEntry = (global::System.Windows.Controls.TextBox)target;
			return;
			IL_201:
			this.operationLabel = (global::System.Windows.Controls.Label)target;
		}

		// Token: 0x04000B2E RID: 2862
		private string a;

		// Token: 0x04000B2F RID: 2863
		internal global::SpecialFeatures.CBISerialNum.CbiSerNumWind myCbiWindow;

		// Token: 0x04000B30 RID: 2864
		internal global::System.Windows.Controls.Label operationLabel;

		// Token: 0x04000B31 RID: 2865
		internal global::System.Windows.Controls.Grid Main;

		// Token: 0x04000B32 RID: 2866
		internal global::System.Windows.Controls.TextBox CbiSerEntry;

		// Token: 0x04000B33 RID: 2867
		internal global::System.Windows.Controls.StackPanel stackPanelError;

		// Token: 0x04000B34 RID: 2868
		internal global::System.Windows.Controls.Image imageError;

		// Token: 0x04000B35 RID: 2869
		internal global::System.Windows.Controls.TextBox textBoxError;

		// Token: 0x04000B36 RID: 2870
		private bool b;
	}
}
