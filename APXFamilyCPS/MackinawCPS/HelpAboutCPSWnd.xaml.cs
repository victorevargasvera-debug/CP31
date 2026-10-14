using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Shapes;
using AcpUI.Common;
using Common;
using CommonResources;
using Microsoft.Win32;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000034 RID: 52
	public partial class HelpAboutCPSWnd : Window
	{
		// Token: 0x17000012 RID: 18
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0003B41C File Offset: 0x0003961C
		internal static string CPS_Version
		{
			set
			{
				short num = (short)1406670001;
				short num2 = num;
				num = (short)1499600049;
				switch (num2 == num)
				{
				}
				num = (short)1741488129;
				if (num != 0)
				{
				}
				num = (short)1249771520;
				short num3 = num;
				num = (short)294060032;
				if (num != 0)
				{
				}
				HelpAboutCPSWnd.productVersion = value;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0003B4CC File Offset: 0x000396CC
		public HelpAboutCPSWnd()
		{
			int a_ = 9;
			base..ctor();
			this.InitializeComponent();
			Utility.SetDirection(this);
			this.Version.Content = AppResources.Version_ID + HelpAboutCPSWnd.productVersion;
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(FixedLengthStream.b("뫨ꓪ꯬믮꛰닲ꟴ닶", a_));
				RegistryKey registryKey2;
				if (registryKey == null)
				{
					registryKey2 = null;
					goto IL_243;
				}
				IL_20B:
				RegistryKey registryKey3 = registryKey.OpenSubKey(FixedLengthStream.b("ꓨ苪軬鷮黰胲髴釶跸", a_));
				if (registryKey3 == null)
				{
					registryKey2 = null;
				}
				else
				{
					RegistryKey registryKey4 = registryKey3.OpenSubKey(FixedLengthStream.b("뻨苪菬诮黰蓲蛴ퟶ럸꿺", a_));
					registryKey2 = ((registryKey4 != null) ? registryKey4.OpenSubKey(FixedLengthStream.b("ꫨ黪鿬鷮铰鷲致ꇶ鳸觺軼雾渀洂", a_)) : null);
				}
				IL_243:
				using (RegistryKey registryKey5 = registryKey2)
				{
					if (registryKey5 != null)
					{
						HelpAboutCPSWnd.productLicensedToPerson = registryKey5.GetValue(FixedLengthStream.b("믨軪諬蛮苰蟲郴藶鳸鿺닼裾漀昂眄", a_)).ToString();
						HelpAboutCPSWnd.productLicensedToCompany = registryKey5.GetValue(FixedLengthStream.b("믨軪諬蛮苰蟲郴藶鳸鿺닼跾昀戂欄渆猈樊礌明縐紒", a_)).ToString();
					}
					else
					{
						RegistryKey registryKey6 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(FixedLengthStream.b("뫨ꓪ꯬믮꛰닲ꟴ닶", a_));
						RegistryKey registryKey7;
						if (registryKey6 == null)
						{
							registryKey7 = null;
						}
						else
						{
							RegistryKey registryKey8 = registryKey6.OpenSubKey(FixedLengthStream.b("ꓨ苪軬鷮黰胲髴釶跸", a_));
							if (registryKey8 == null)
							{
								registryKey7 = null;
							}
							else
							{
								RegistryKey registryKey9 = registryKey8.OpenSubKey(FixedLengthStream.b("뻨苪菬诮黰蓲蛴ퟶ럸꿺", a_));
								registryKey7 = ((registryKey9 != null) ? registryKey9.OpenSubKey(FixedLengthStream.b("ꫨ黪鿬鷮铰鷲致ꇶ鳸觺軼雾渀洂", a_)) : null);
							}
						}
						using (RegistryKey registryKey10 = registryKey7)
						{
							if (registryKey10 != null)
							{
								HelpAboutCPSWnd.productLicensedToPerson = registryKey10.GetValue(FixedLengthStream.b("믨軪諬蛮苰蟲郴藶鳸鿺닼裾漀昂眄", a_)).ToString();
								HelpAboutCPSWnd.productLicensedToCompany = registryKey10.GetValue(FixedLengthStream.b("믨軪諬蛮苰蟲郴藶鳸鿺닼跾昀戂欄渆猈樊礌明縐紒", a_)).ToString();
							}
						}
					}
					goto IL_262;
				}
				goto IL_20B;
				IL_262:
				goto IL_49;
			}
			catch (Exception ex)
			{
				Trace.WriteLine(FixedLengthStream.b("껨軪駬鯮飰鷲鋴ퟶ뛸賺鏼髾猀⌂樄甆⤈䠊戌戎愐爒笔渖㤘唚簜爞䐠̢儤伦嬨个娬༮倰崲ᔴ制䄸堺堼伾㕀⩂⩄⥆效歊⡌㵎⍐㱒❔浖祘", a_) + ex.Message);
				goto IL_49;
			}
			goto IL_28B;
			IL_49:
			this.licensed_to_Per.Content = HelpAboutCPSWnd.productLicensedToPerson.Replace(FixedLengthStream.b("뛨", a_), FixedLengthStream.b("뛨듪", a_));
			this.licensed_to_Company.Content = HelpAboutCPSWnd.productLicensedToCompany.Replace(FixedLengthStream.b("뛨", a_), FixedLengthStream.b("뛨듪", a_));
			if (Product.IsVertex())
			{
				this.ModelSupported_Vertex.Visibility = Visibility.Visible;
				this.ModelSupported_APX.Visibility = Visibility.Collapsed;
				this.label2.Content = AppResources.VERTEX_STANDARD_CPS;
				this.label2.FontSize = 40.0;
				this.label3.Content = AppResources.VERTEX_STANDARD_CPS;
				this.label3.FontSize = 40.0;
				this.Motorola_Icon_Copy.Visibility = Visibility.Hidden;
				this.Motorola_Icon_Vertex.Visibility = Visibility.Visible;
				this.copyrightlbl.Content = AppResources.Copyright_2017_Vertex_Standard_LMR_Incoporated;
				return;
			}
			if (!Product.IsAll())
			{
				return;
			}
			IL_28B:
			this.VXP949.Visibility = Visibility.Visible;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0003B84C File Offset: 0x00039A4C
		private void OnOkClick(object sender, RoutedEventArgs e)
		{
			short num = (short)971912348;
			short num2 = num;
			num = (short)495465628;
			switch (num2 == num)
			{
			}
			num = (short)814415873;
			if (num != 0)
			{
			}
			num = (short)863109120;
			if (num != 0)
			{
			}
			num = (short)1655308288;
			short num3 = num;
			base.Close();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0003BC64 File Offset: 0x00039E64
		// Note: this type is marked as 'beforefieldinit'.
		static HelpAboutCPSWnd()
		{
			short num = (short)60208399;
			short num2 = num;
			num = (short)1617671439;
			switch (num2 == num)
			{
			default:
			{
				num = (short)494665728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1389494273;
			if (num != 0)
			{
			}
			num = (short)1144455168;
			if (num != 0)
			{
			}
			HelpAboutCPSWnd.productVersion = "";
			HelpAboutCPSWnd.productLicensedToCompany = AppResources.Unregistered_ID;
			HelpAboutCPSWnd.productLicensedToPerson = AppResources.Unregistered_ID;
		}

		// Token: 0x040000C9 RID: 201
		private static string productVersion;

		// Token: 0x040000CA RID: 202
		private static string productLicensedToCompany;

		// Token: 0x040000CB RID: 203
		private static string productLicensedToPerson;

		// Token: 0x040000E0 RID: 224
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
