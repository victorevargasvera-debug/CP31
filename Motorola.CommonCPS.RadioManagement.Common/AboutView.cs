using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Shapes;
using Microsoft.Win32;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000003 RID: 3
	public class AboutView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public AboutView()
		{
			int a_ = 7;
			this.copyRightEndYear = global::System.DateTime.Now.Year.ToString();
			base..ctor();
			this.InitializeComponent();
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
			{
				this.LayoutRoot.Visibility = global::System.Windows.Visibility.Collapsed;
				this.RadioCentralLayoutRoot.Visibility = global::System.Windows.Visibility.Visible;
			}
			else
			{
				this.LayoutRoot.Visibility = global::System.Windows.Visibility.Visible;
				this.RadioCentralLayoutRoot.Visibility = global::System.Windows.Visibility.Collapsed;
			}
			for (;;)
			{
				try
				{
					global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productVersion = global::System.Diagnostics.FileVersionInfo.GetVersionInfo(global::System.Reflection.Assembly.GetEntryAssembly().Location).ProductVersion.ToString();
					goto IL_43D;
				}
				catch
				{
					goto IL_43D;
				}
				return;
				IL_43D:
				this.Version.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Version + global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("律", a_) + global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productVersion;
				this.Version_1.Content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Version + global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("律", a_) + global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productVersion;
				this.CopyRight.Content = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Copyright_2008_XXXX_Motorola_Solutions_Incorporated, this.copyRightEndYear);
				this.CopyRight_1.Content = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Copyright_RadioCentral, global::System.Array.Empty<object>());
				try
				{
					if (global::System.Environment.Is64BitOperatingSystem)
					{
						using (global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.RegistryKey.OpenBaseKey(global::Microsoft.Win32.RegistryHive.LocalMachine, global::Microsoft.Win32.RegistryView.Registry64))
						{
							global::Microsoft.Win32.RegistryKey registryKey2 = registryKey.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("諘铚鯜诞뛠ꋢ럤ꋦ", a_));
							string text;
							if (registryKey2 == null)
							{
								text = null;
							}
							else
							{
								global::Microsoft.Win32.RegistryKey registryKey3 = registryKey2.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铘닚뻜귞軠郢諤臦鷨", a_));
								if (registryKey3 == null)
								{
									text = null;
								}
								else
								{
									global::Microsoft.Win32.RegistryKey registryKey4 = registryKey3.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軘닚돜믞軠铢雤쟦꟨뿪", a_));
									if (registryKey4 == null)
									{
										text = null;
									}
									else
									{
										global::Microsoft.Win32.RegistryKey registryKey5 = registryKey4.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("高껚꿜귞蓠跢釤뇦賨駪黬蛮黰鷲", a_));
										if (registryKey5 == null)
										{
											text = null;
										}
										else
										{
											object value = registryKey5.GetValue(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诘뻚뫜뛞鋠韢胤闦賨迪ꋬ飮鿰雲蟴", a_));
											text = ((value != null) ? value.ToString() : null);
										}
									}
								}
							}
							global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToPerson = text;
							global::Microsoft.Win32.RegistryKey registryKey6 = registryKey.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("諘铚鯜诞뛠ꋢ럤ꋦ", a_));
							string text2;
							if (registryKey6 == null)
							{
								text2 = null;
							}
							else
							{
								global::Microsoft.Win32.RegistryKey registryKey7 = registryKey6.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铘닚뻜귞軠郢諤臦鷨", a_));
								if (registryKey7 == null)
								{
									text2 = null;
								}
								else
								{
									global::Microsoft.Win32.RegistryKey registryKey8 = registryKey7.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軘닚돜믞軠铢雤쟦꟨뿪", a_));
									if (registryKey8 == null)
									{
										text2 = null;
									}
									else
									{
										global::Microsoft.Win32.RegistryKey registryKey9 = registryKey8.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("高껚꿜귞蓠跢釤뇦賨駪黬蛮黰鷲", a_));
										if (registryKey9 == null)
										{
											text2 = null;
										}
										else
										{
											object value2 = registryKey9.GetValue(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诘뻚뫜뛞鋠韢胤闦賨迪ꋬ鷮雰鋲鯴黶菸髺觼雾渀洂", a_));
											text2 = ((value2 != null) ? value2.ToString() : null);
										}
									}
								}
							}
							global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToCompany = text2;
							break;
						}
					}
					global::Microsoft.Win32.RegistryKey registryKey10 = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("諘铚鯜诞뛠ꋢ럤ꋦ", a_));
					string text3;
					if (registryKey10 == null)
					{
						text3 = null;
					}
					else
					{
						global::Microsoft.Win32.RegistryKey registryKey11 = registryKey10.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铘닚뻜귞軠郢諤臦鷨", a_));
						if (registryKey11 == null)
						{
							text3 = null;
						}
						else
						{
							global::Microsoft.Win32.RegistryKey registryKey12 = registryKey11.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軘닚돜믞軠铢雤쟦꟨뿪", a_));
							if (registryKey12 == null)
							{
								text3 = null;
							}
							else
							{
								global::Microsoft.Win32.RegistryKey registryKey13 = registryKey12.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("高껚꿜귞蓠跢釤뇦賨駪黬蛮黰鷲", a_));
								if (registryKey13 == null)
								{
									text3 = null;
								}
								else
								{
									object value3 = registryKey13.GetValue(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诘뻚뫜뛞鋠韢胤闦賨迪ꋬ飮鿰雲蟴", a_));
									text3 = ((value3 != null) ? value3.ToString() : null);
								}
							}
						}
					}
					global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToPerson = text3;
					global::Microsoft.Win32.RegistryKey registryKey14 = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("諘铚鯜诞뛠ꋢ럤ꋦ", a_));
					string text4;
					if (registryKey14 == null)
					{
						text4 = null;
					}
					else
					{
						global::Microsoft.Win32.RegistryKey registryKey15 = registryKey14.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铘닚뻜귞軠郢諤臦鷨", a_));
						if (registryKey15 == null)
						{
							text4 = null;
						}
						else
						{
							global::Microsoft.Win32.RegistryKey registryKey16 = registryKey15.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軘닚돜믞軠铢雤쟦꟨뿪", a_));
							if (registryKey16 == null)
							{
								text4 = null;
							}
							else
							{
								global::Microsoft.Win32.RegistryKey registryKey17 = registryKey16.OpenSubKey(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("高껚꿜귞蓠跢釤뇦賨駪黬蛮黰鷲", a_));
								if (registryKey17 == null)
								{
									text4 = null;
								}
								else
								{
									object value4 = registryKey17.GetValue(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诘뻚뫜뛞鋠韢胤闦賨迪ꋬ鷮雰鋲鯴黶菸髺觼雾渀洂", a_));
									text4 = ((value4 != null) ? value4.ToString() : null);
								}
							}
						}
					}
					global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToCompany = text4;
					break;
				}
				catch (global::System.Exception ex)
				{
					string str = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("默뻚꧜￞균諢蛤苦蟨飪裬쿮룰鷲鏴飶본觺迼郾猀", a_);
					global::System.Exception ex2 = ex;
					global::System.Console.WriteLine(str + ((ex2 != null) ? ex2.ToString() : null));
					break;
				}
			}
			if (global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToPerson != null)
			{
				this.licensed_to_Per.Content = global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToPerson.Replace(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛘", a_), global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛘蓚", a_));
				this.licensed_to_Per_1.Content = global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToPerson.Replace(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛘", a_), global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛘蓚", a_));
			}
			if (global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToCompany != null)
			{
				this.licensed_to_Company.Content = global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToCompany.Replace(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛘", a_), global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛘蓚", a_));
				this.licensed_to_Company_1.Content = global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToCompany.Replace(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛘", a_), global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蛘蓚", a_));
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002670 File Offset: 0x00000870
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			while (this._contentLoaded)
			{
				short num = (short)1006108673;
				if (num != 0)
				{
				}
				num = (short)1759379456;
				short num2 = num;
				num = (short)1981627540;
				short num3 = num;
				num = (short)1571175572;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1826357248;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("崙闗뗙꣛뇝鋟跡裣蟥웧ꧩ菫菭鷯鷱髳뗵ꣷ꧹틻곽懿昁洃椅䔇欉戋漍眏眑礓猕瘗渙㈛崝伟伡䤣䤥䘧ᄩ伫䄭崯䈱嬳堵崷吹䠻ᄽℿ⁁⭃㍅㱇㱉╋⭍❏絑㕓㑕㝗⽙⡛灝ᡟ͡ॣ੥", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002754 File Offset: 0x00000954
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)736690176;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_1E5;
				case 2:
					goto IL_1FE;
				}
				IL_31:
				num = (short)1436549120;
				short num3 = num;
				switch (connectionId)
				{
				case 1:
					goto IL_26B;
				case 2:
					goto IL_155;
				case 3:
					goto IL_203;
				case 4:
					goto IL_F1;
				case 5:
					goto IL_1B1;
				case 6:
					goto IL_210;
				case 7:
					goto IL_21D;
				case 8:
					goto IL_1D8;
				case 9:
					goto IL_244;
				case 10:
					goto IL_251;
				case 11:
					goto IL_1A4;
				case 12:
					goto IL_E4;
				case 13:
					goto IL_25E;
				case 14:
					goto IL_237;
				case 15:
					goto IL_162;
				case 16:
					goto IL_D7;
				case 17:
					goto IL_278;
				case 18:
					goto IL_22A;
				case 19:
				{
					num = (short)1269058814;
					short num4 = num;
					num = (short)703810814;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_132;
					}
					break;
				}
				case 20:
					goto IL_1BE;
				case 21:
					goto IL_16F;
				case 22:
					goto IL_1CB;
				default:
					num = (short)750256129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1E5:
				num = (short)1891958786;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D7:
			this.RNPS_Icon_Copy = (global::System.Windows.Controls.Image)target;
			return;
			IL_E4:
			this.top_line_R = (global::System.Windows.Shapes.Rectangle)target;
			return;
			IL_F1:
			this.label3 = (global::System.Windows.Controls.Label)target;
			return;
			IL_132:
			num = (short)138215424;
			if (num != 0)
			{
			}
			this.licensed_to_1 = (global::System.Windows.Controls.Label)target;
			return;
			IL_155:
			this.Motorola_Icon_Copy = (global::System.Windows.Controls.Image)target;
			return;
			IL_162:
			this.RadioCentralLayoutRoot = (global::System.Windows.Controls.Grid)target;
			return;
			IL_16F:
			num = (short)1687027713;
			if (num != 0)
			{
			}
			this.licensed_to_Company_1 = (global::System.Windows.Controls.Label)target;
			return;
			IL_1A4:
			this.top_line_L = (global::System.Windows.Shapes.Rectangle)target;
			return;
			IL_1B1:
			this.label2 = (global::System.Windows.Controls.Label)target;
			return;
			IL_1BE:
			this.licensed_to_Per_1 = (global::System.Windows.Controls.Label)target;
			return;
			IL_1CB:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1D8:
			this.licensed_to_Per = (global::System.Windows.Controls.Label)target;
			return;
			IL_1FE:
			this._contentLoaded = true;
			return;
			IL_203:
			this.APX = (global::System.Windows.Controls.Viewbox)target;
			return;
			IL_210:
			this.CopyRight = (global::System.Windows.Controls.Label)target;
			return;
			IL_21D:
			this.licensed_to = (global::System.Windows.Controls.Label)target;
			return;
			IL_22A:
			this.CopyRight_1 = (global::System.Windows.Controls.Label)target;
			return;
			IL_237:
			this._3_line_left = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_244:
			this.licensed_to_Company = (global::System.Windows.Controls.Label)target;
			return;
			IL_251:
			this.Version = (global::System.Windows.Controls.Label)target;
			return;
			IL_25E:
			this._3_line_right = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_26B:
			this.LayoutRoot = (global::System.Windows.Controls.Grid)target;
			return;
			IL_278:
			this.Version_1 = (global::System.Windows.Controls.Label)target;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000029F0 File Offset: 0x00000BF0
		// Note: this type is marked as 'beforefieldinit'.
		static AboutView()
		{
			short num = (short)781821452;
			short num2 = num;
			num = (short)1176610316;
			switch (num2 == num)
			{
			}
			num = (short)271319040;
			short num3 = num;
			num = (short)952827905;
			if (num != 0)
			{
			}
			num = (short)1302659072;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productVersion = "";
			global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToCompany = global::Motorola.CommonCPS.ResourceRepository.Resources.Unregistered;
			global::Motorola.CommonCPS.RadioManagement.Common.AboutView.productLicensedToPerson = global::Motorola.CommonCPS.ResourceRepository.Resources.Unregistered;
		}

		// Token: 0x04000003 RID: 3
		private static string productVersion;

		// Token: 0x04000004 RID: 4
		private static string productLicensedToCompany;

		// Token: 0x04000005 RID: 5
		private static string productLicensedToPerson;

		// Token: 0x04000006 RID: 6
		private readonly string copyRightEndYear;

		// Token: 0x04000007 RID: 7
		internal global::System.Windows.Controls.Grid LayoutRoot;

		// Token: 0x04000008 RID: 8
		internal global::System.Windows.Controls.Image Motorola_Icon_Copy;

		// Token: 0x04000009 RID: 9
		internal global::System.Windows.Controls.Viewbox APX;

		// Token: 0x0400000A RID: 10
		internal global::System.Windows.Controls.Label label3;

		// Token: 0x0400000B RID: 11
		internal global::System.Windows.Controls.Label label2;

		// Token: 0x0400000C RID: 12
		internal global::System.Windows.Controls.Label CopyRight;

		// Token: 0x0400000D RID: 13
		internal global::System.Windows.Controls.Label licensed_to;

		// Token: 0x0400000E RID: 14
		internal global::System.Windows.Controls.Label licensed_to_Per;

		// Token: 0x0400000F RID: 15
		internal global::System.Windows.Controls.Label licensed_to_Company;

		// Token: 0x04000010 RID: 16
		internal global::System.Windows.Controls.Label Version;

		// Token: 0x04000011 RID: 17
		internal global::System.Windows.Shapes.Rectangle top_line_L;

		// Token: 0x04000012 RID: 18
		internal global::System.Windows.Shapes.Rectangle top_line_R;

		// Token: 0x04000013 RID: 19
		internal global::System.Windows.Controls.StackPanel _3_line_right;

		// Token: 0x04000014 RID: 20
		internal global::System.Windows.Controls.StackPanel _3_line_left;

		// Token: 0x04000015 RID: 21
		internal global::System.Windows.Controls.Grid RadioCentralLayoutRoot;

		// Token: 0x04000016 RID: 22
		internal global::System.Windows.Controls.Image RNPS_Icon_Copy;

		// Token: 0x04000017 RID: 23
		internal global::System.Windows.Controls.Label Version_1;

		// Token: 0x04000018 RID: 24
		internal global::System.Windows.Controls.Label CopyRight_1;

		// Token: 0x04000019 RID: 25
		internal global::System.Windows.Controls.Label licensed_to_1;

		// Token: 0x0400001A RID: 26
		internal global::System.Windows.Controls.Label licensed_to_Per_1;

		// Token: 0x0400001B RID: 27
		internal global::System.Windows.Controls.Label licensed_to_Company_1;

		// Token: 0x0400001C RID: 28
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400001D RID: 29
		private bool _contentLoaded;
	}
}
