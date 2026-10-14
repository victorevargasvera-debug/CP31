using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using AcpCommonLib;
using AcpFileHandlerLib;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000046 RID: 70
	public class AcpVoiceAnnRecNavToolBar : global::AcpUI.AcpRecNavToolbar
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00044028 File Offset: 0x00042228
		public string[] VoiceAnnFiles
		{
			get
			{
				short num = (short)1076690945;
				if (num != 0)
				{
				}
				num = (short)1573503015;
				short num2 = num;
				num = (short)1425391655;
				switch (num2 == num)
				{
				}
				num = (short)476315648;
				if (num != 0)
				{
				}
				num = (short)2030764032;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000440D8 File Offset: 0x000422D8
		public AcpVoiceAnnRecNavToolBar()
		{
			base.IsAddMultQtyEn = false;
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060003F8 RID: 1016 RVA: 0x000440F4 File Offset: 0x000422F4
		// (remove) Token: 0x060003F9 RID: 1017 RVA: 0x000441A8 File Offset: 0x000423A8
		public event global::System.Windows.RoutedEventHandler MultiAddClick
		{
			add
			{
				short num = (short)531764821;
				short num2 = num;
				num = (short)811406933;
				switch (num2 == num)
				{
				}
				num = (short)938868736;
				if (num != 0)
				{
				}
				num = (short)2080112641;
				if (num != 0)
				{
				}
				num = (short)950337536;
				short num3 = num;
				base.AddHandler(global::AcpUI.AcpVoiceAnnRecNavToolBar.MultiAddClickEvent, value);
			}
			remove
			{
				short num = (short)954395068;
				short num2 = num;
				num = (short)926345660;
				switch (num2 == num)
				{
				}
				num = (short)943390721;
				if (num != 0)
				{
				}
				num = (short)1310261248;
				if (num != 0)
				{
				}
				num = (short)1049165824;
				short num3 = num;
				base.RemoveHandler(global::AcpUI.AcpVoiceAnnRecNavToolBar.MultiAddClickEvent, value);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0004425C File Offset: 0x0004245C
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0004430C File Offset: 0x0004250C
		public global::System.Func<global::System.Windows.Controls.SelectionMode, global::System.Collections.Generic.List<string>> SelectVAFileDialog
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)248340090;
				short num2 = num;
				num = (short)1790336634;
				switch (num2 == num)
				{
				}
				num = (short)2129330176;
				if (num != 0)
				{
				}
				num = (short)1980039169;
				if (num != 0)
				{
				}
				num = (short)2087387136;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)876404910;
				short num2 = num;
				num = (short)1405214894;
				switch (num2 == num)
				{
				}
				num = (short)1550385153;
				if (num != 0)
				{
				}
				num = (short)1990393856;
				if (num != 0)
				{
				}
				num = (short)710279168;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000443C0 File Offset: 0x000425C0
		protected override void OnRecNavBtnAddMultipleClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int a_ = 19;
			short num = (short)666107904;
			switch (num)
			{
			default:
			{
				num = (short)366804992;
				short num2 = num;
				global::AcpCommonLib.AppInfoManager.LoadingVoiceData = true;
				string[] array = null;
				try
				{
					num = (short)531169293;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpFileHandlerLib.AcpOpenFileDialog acpOpenFileDialog;
						bool? flag;
						bool flag2;
						switch (num3)
						{
						case 0:
							num = (short)674103312;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::System.Collections.Generic.List<string> list;
							if (list.Count > 0)
							{
								num = (short)1613168649;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A3;
						}
						case 2:
						{
							global::System.Collections.Generic.List<string> list;
							if (list != null)
							{
								num = (short)155779079;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A3;
						}
						case 3:
							goto IL_2DF;
						case 4:
							if (array != null)
							{
								num = (short)60555264;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42C;
						case 5:
							goto IL_42C;
						case 6:
							goto IL_26E;
						case 7:
							num = (short)1577254913;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_2A3;
						case 9:
						{
							global::System.Collections.Generic.List<string> list;
							array = list.ToArray();
							num = (short)905707538;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_446;
						case 11:
						{
							global::System.Collections.Generic.List<string> list = this.SelectVAFileDialog(global::System.Windows.Controls.SelectionMode.Extended);
							num = (short)258867202;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							acpOpenFileDialog.Filter = global::AcpUI.Common.Utility.c("캪\udfac\udbae\ud8b0햲\udcb4풶\ud8b8쾺\ud8bc龾Ꟁꫂ꧄ꋆ뫈￐戮ﳔꯖ", a_);
							num = (short)1782644751;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_D3;
							}
							continue;
						case 14:
						{
							num = (short)1798723244;
							short num4 = num;
							num = (short)2027312812;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_26E;
							default:
								num = (short)794820608;
								if (num != 0)
								{
								}
								array = acpOpenFileDialog.FileNames;
								num = (short)765132808;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 15:
							goto IL_2DF;
						case 16:
							if (array.Length != 0)
							{
								num = (short)717357075;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42C;
						case 17:
							if (flag.GetValueOrDefault() == flag2 & flag != null)
							{
								num = (short)2034302990;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A3;
						case 18:
							goto IL_2A3;
						case 19:
							this.a = new string[array.Length];
							global::System.Array.Copy(array, this.a, array.Length);
							base.AddMultQty = this.a.Length;
							base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::AcpUI.AcpVoiceAnnRecNavToolBar.MultiAddClickEvent));
							base.OnRecNavBtnAddMultipleClick(sender, e);
							num = (short)189464581;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D3:
						if (this.SelectVAFileDialog != null)
						{
							num = (short)1463549963;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpOpenFileDialog = new global::AcpFileHandlerLib.AcpOpenFileDialog();
						num = (short)134873094;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_26E:
						if (((global::System.Windows.FrameworkElement)sender).DataContext == global::AcpCommonLib.FeatureManager.GetFeature(4228))
						{
							num = (short)1188954124;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpOpenFileDialog.Filter = global::AcpUI.Common.Utility.c("쒪\ud9ac삮쎰\udcb2\ud9b4횶馸튼횾ꋀꛂ蛆ꟈꗊꋌ뫎뿐냒냔뫖볘뗚꧜￞蟠諢觤苦髨쯪여엮\udff0黲菴零탸蟺퟼퇾氀甂搄", a_);
						num = (short)26869763;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A3:
						num = (short)2106458116;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2DF:
						num = (short)488964097;
						if (num != 0)
						{
						}
						acpOpenFileDialog.MultiSelect = true;
						flag = acpOpenFileDialog.ShowDialog();
						flag2 = true;
						num = (short)910426129;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_42C:
						num = (short)1154482186;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_446:;
				}
				finally
				{
					global::AcpCommonLib.AppInfoManager.LoadingVoiceData = false;
				}
				return;
			}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00044838 File Offset: 0x00042A38
		protected override bool CanSelectAddMode
		{
			get
			{
				short num = (short)425980121;
				short num2 = num;
				num = (short)2115301593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561184768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512505345;
				if (num != 0)
				{
				}
				num = (short)266010624;
				if (num != 0)
				{
				}
				base.RecordTypeToAdd = 0;
				return false;
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000448EC File Offset: 0x00042AEC
		// Note: this type is marked as 'beforefieldinit'.
		static AcpVoiceAnnRecNavToolBar()
		{
			int a_ = 17;
			short num = (short)466848175;
			short num2 = num;
			num = (short)96438703;
			switch (num2 == num)
			{
			default:
			{
				num = (short)312672256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)63766529;
			if (num != 0)
			{
			}
			num = (short)234553344;
			if (num != 0)
			{
			}
			global::AcpUI.AcpVoiceAnnRecNavToolBar.MultiAddClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::AcpUI.Common.Utility.c("\udca8잪\ud9ac욮ힲ톴햸튺\udebc풾", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::AcpUI.AcpRecNavToolbar));
		}

		// Token: 0x04000247 RID: 583
		private new string[] a;

		// Token: 0x04000249 RID: 585
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Func<global::System.Windows.Controls.SelectionMode, global::System.Collections.Generic.List<string>> b;
	}
}
