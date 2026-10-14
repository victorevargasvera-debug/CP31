using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ACPBrowser;
using AcpCommonLib;
using AcpUI.Common;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.ReadWritePassword
{
	// Token: 0x02000061 RID: 97
	public partial class PromptReadWritePassword : Window
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0008FE48 File Offset: 0x0008E048
		internal bool IsCanceled
		{
			get
			{
				short num = (short)1145223573;
				short num2 = num;
				num = (short)312785301;
				switch (num2 == num)
				{
				}
				num = (short)765788160;
				if (num != 0)
				{
				}
				num = (short)117309440;
				short num3 = num;
				num = (short)1018101761;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000029DD File Offset: 0x00000BDD
		public PromptReadWritePassword()
		{
			this.b = true;
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.CodeplugPasswordBox.Focus();
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0008FEF8 File Offset: 0x0008E0F8
		public PromptReadWritePassword(string serialNumber)
		{
			this.b = true;
			this.InitializeComponent();
			if (serialNumber != null)
			{
				this.SerialNumberValue.Content = serialNumber;
			}
			else
			{
				RadioInformation radioInformation = FeatureManager.GetFeature(2049)[0] as RadioInformation;
				this.SerialNumberValue.Content = radioInformation.General.RadInfoGeneralSerialNumber_A9122Value;
			}
			AcpUI.Common.Utility.SetDirection(this);
			this.CodeplugPasswordBox.Focus();
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0008FF78 File Offset: 0x0008E178
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x00090028 File Offset: 0x0008E228
		internal string UserEnteredPassword
		{
			get
			{
				short num = (short)1488584704;
				short num2 = num;
				num = (short)1258149677;
				short num3 = num;
				num = (short)1183897389;
				switch (num3 == num)
				{
				}
				num = (short)833552385;
				if (num != 0)
				{
				}
				num = (short)1397358592;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)814546944;
				short num2 = num;
				num = (short)715115488;
				short num3 = num;
				num = (short)89574368;
				switch (num3 == num)
				{
				}
				num = (short)1295450113;
				if (num != 0)
				{
				}
				num = (short)758710272;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000900D8 File Offset: 0x0008E2D8
		private void OnClickOK(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)60424192;
			short num2 = num;
			num = (short)1498864459;
			short num3 = num;
			num = (short)583523147;
			switch (num3 == num)
			{
			}
			num = (short)1255866369;
			if (num != 0)
			{
			}
			num = (short)1650262016;
			if (num != 0)
			{
			}
			this.a = this.CodeplugPasswordBox.Password;
			this.b = false;
			base.Close();
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000901A0 File Offset: 0x0008E3A0
		private void OnClickCancel(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1631584256;
			short num2 = num;
			num = (short)895596288;
			short num3 = num;
			num = (short)478263040;
			switch (num3 == num)
			{
			}
			num = (short)1890779137;
			if (num != 0)
			{
			}
			num = (short)1888288768;
			if (num != 0)
			{
			}
			this.b = true;
			base.Close();
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00090258 File Offset: 0x0008E458
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)856096768;
			short num2 = num;
			num = (short)281008447;
			short num3 = num;
			num = (short)214817087;
			switch (num3 == num)
			{
			}
			num = (short)1026686977;
			if (num != 0)
			{
			}
			num = (short)579993600;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00090304 File Offset: 0x0008E504
		private void OnHelpButton_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)607927427;
				short num2 = num;
				num = (short)868301955;
				switch (num2 == num)
				{
				}
				num = (short)850329600;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("떕ꦗꊙꖛ겝슟鎡鶣장", a_));
			}
			catch (Exception)
			{
			}
			num = (short)185466881;
			if (num != 0)
			{
			}
			num = (short)796393472;
			short num3 = num;
		}

		// Token: 0x04000360 RID: 864
		private string a = string.Empty;

		// Token: 0x04000361 RID: 865
		private bool b;
	}
}
