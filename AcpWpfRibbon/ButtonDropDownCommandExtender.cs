using System;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200001A RID: 26
	public class ButtonDropDownCommandExtender : global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender
	{
		// Token: 0x06000239 RID: 569 RVA: 0x00033A98 File Offset: 0x00031C98
		public ButtonDropDownCommandExtender()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00033AD4 File Offset: 0x00031CD4
		public ButtonDropDownCommandExtender(string header) : this(header, null, null)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00033AEC File Offset: 0x00031CEC
		public ButtonDropDownCommandExtender(string header, string image) : this(header, image, null)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00033B04 File Offset: 0x00031D04
		public ButtonDropDownCommandExtender(string header, string image, string imageSmall)
		{
			this.m_Header = header;
			if (image != null && image.Length > 0)
			{
				this.m_ImageSource = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(image, global::System.UriKind.RelativeOrAbsolute));
			}
			if (imageSmall != null && imageSmall.Length > 0)
			{
				this.m_ImageSmallSource = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(imageSmall, global::System.UriKind.RelativeOrAbsolute));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00033B90 File Offset: 0x00031D90
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00033C40 File Offset: 0x00031E40
		public string Header
		{
			get
			{
				short num = (short)1672059305;
				short num2 = num;
				num = (short)1106221481;
				switch (num2 == num)
				{
				}
				num = (short)292487169;
				if (num != 0)
				{
				}
				num = (short)1911357440;
				short num3 = num;
				num = (short)1734279168;
				if (num != 0)
				{
				}
				return this.m_Header;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)546832385;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							this.m_Header = value;
							global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
							num = (short)495536798;
							short num3 = num;
							num = (short)469256862;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)1593769984;
								short num4 = num;
								break;
							}
							}
							num = (short)463667200;
							if (num != 0)
							{
							}
							num = (short)341311490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							continue;
						case 2:
							return;
						}
						IL_31:
						num = (short)154599425;
						if (num != 0)
						{
						}
						if (!(this.m_Header != value))
						{
							return;
						}
						num = (short)2016018432;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00033D64 File Offset: 0x00031F64
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00033E10 File Offset: 0x00032010
		public global::System.Windows.Media.ImageSource ImageSource
		{
			get
			{
				short num = (short)244252721;
				short num2 = num;
				num = (short)331153457;
				switch (num2 == num)
				{
				}
				num = (short)442171393;
				if (num != 0)
				{
				}
				num = (short)235077632;
				short num3 = num;
				num = (short)1452212224;
				if (num != 0)
				{
				}
				return this.m_ImageSource;
			}
			set
			{
				short num;
				for (;;)
				{
					IL_00:
					num = (short)411893761;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							this.m_ImageSource = value;
							global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
							num = (short)666178314;
							short num3 = num;
							num = (short)1954485002;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1797914624;
								short num4 = num;
								num = (short)1290731520;
								if (num != 0)
								{
								}
								num = (short)914423810;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 2:
							goto IL_E9;
						}
						IL_30:
						if (this.m_ImageSource == value)
						{
							return;
						}
						num = (short)218693632;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_E9:
				num = (short)947126273;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00033F30 File Offset: 0x00032130
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00033FE4 File Offset: 0x000321E4
		public global::System.Windows.Media.ImageSource ImageSmallSource
		{
			get
			{
				short num = (short)653536539;
				short num2 = num;
				num = (short)714943771;
				switch (num2 == num)
				{
				}
				num = (short)1586888704;
				if (num != 0)
				{
				}
				num = (short)569835520;
				short num3 = num;
				num = (short)1031733249;
				if (num != 0)
				{
				}
				return this.m_ImageSmallSource;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)273154049;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							this.m_ImageSmallSource = value;
							global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
							num = (short)907152086;
							short num3 = num;
							num = (short)2112752342;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)757202944;
								short num4 = num;
								break;
							}
							}
							num = (short)774569984;
							if (num != 0)
							{
							}
							num = (short)1185349634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 2:
							return;
						}
						IL_30:
						num = (short)1637744641;
						if (num != 0)
						{
						}
						if (this.m_ImageSmallSource == value)
						{
							return;
						}
						num = (short)1075970048;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00034104 File Offset: 0x00032304
		// (set) Token: 0x06000244 RID: 580 RVA: 0x000341B8 File Offset: 0x000323B8
		public bool IsChecked
		{
			get
			{
				short num = (short)856312641;
				short num2 = num;
				num = (short)764758849;
				switch (num2 == num)
				{
				}
				num = (short)1877868545;
				if (num != 0)
				{
				}
				num = (short)917635072;
				short num3 = num;
				num = (short)721223680;
				if (num != 0)
				{
				}
				return this.m_IsChecked;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)164626433;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							this.m_IsChecked = value;
							global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
							num = (short)1411872634;
							short num3 = num;
							num = (short)629438330;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)123273216;
								short num4 = num;
								break;
							}
							}
							num = (short)287899648;
							if (num != 0)
							{
							}
							num = (short)1933115394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1294073857;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_58;
							}
							continue;
						case 2:
							return;
						}
						IL_58:
						if (this.m_IsChecked == value)
						{
							return;
						}
						num = (short)1305542656;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000245 RID: 581 RVA: 0x000342D8 File Offset: 0x000324D8
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00034388 File Offset: 0x00032588
		public bool SyncIsChecked
		{
			get
			{
				short num = (short)1758927035;
				short num2 = num;
				num = (short)33626299;
				switch (num2 == num)
				{
				}
				num = (short)1458044929;
				if (num != 0)
				{
				}
				num = (short)734789632;
				short num3 = num;
				num = (short)1801912320;
				if (num != 0)
				{
				}
				return this.m_SyncIsChecked;
			}
			set
			{
				short num = (short)1058930689;
				if (num != 0)
				{
				}
				num = (short)1669427736;
				short num2 = num;
				num = (short)354316824;
				switch (num2 == num)
				{
				}
				num = (short)2003173376;
				short num3 = num;
				num = (short)1291190272;
				if (num != 0)
				{
				}
				this.m_SyncIsChecked = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00034438 File Offset: 0x00032638
		// (set) Token: 0x06000248 RID: 584 RVA: 0x000344E8 File Offset: 0x000326E8
		public bool SyncHeader
		{
			get
			{
				short num = (short)292989540;
				short num2 = num;
				num = (short)302492260;
				switch (num2 == num)
				{
				}
				num = (short)1472921601;
				if (num != 0)
				{
				}
				num = (short)1924530176;
				short num3 = num;
				num = (short)409206784;
				if (num != 0)
				{
				}
				return this.m_SyncHeader;
			}
			set
			{
				short num = (short)1759399135;
				short num2 = num;
				num = (short)957369567;
				switch (num2 == num)
				{
				}
				num = (short)1725366273;
				if (num != 0)
				{
				}
				num = (short)617283584;
				short num3 = num;
				num = (short)1409941504;
				if (num != 0)
				{
				}
				this.m_SyncHeader = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0003459C File Offset: 0x0003279C
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00034650 File Offset: 0x00032850
		public bool SyncImageSource
		{
			get
			{
				short num = (short)1287103763;
				short num2 = num;
				num = (short)391161107;
				switch (num2 == num)
				{
				}
				num = (short)6225921;
				if (num != 0)
				{
				}
				num = (short)547946496;
				short num3 = num;
				num = (short)1379991552;
				if (num != 0)
				{
				}
				return this.m_SyncImageSource;
			}
			set
			{
				short num = (short)1804541216;
				short num2 = num;
				num = (short)1383712;
				switch (num2 == num)
				{
				}
				num = (short)866385920;
				if (num != 0)
				{
				}
				num = (short)1439432704;
				short num3 = num;
				num = (short)1791492097;
				if (num != 0)
				{
				}
				this.m_SyncImageSource = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00034704 File Offset: 0x00032904
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000347B4 File Offset: 0x000329B4
		public bool SyncImageSmallSource
		{
			get
			{
				short num = (short)1944322049;
				if (num != 0)
				{
				}
				num = (short)753169813;
				short num2 = num;
				num = (short)1090221461;
				switch (num2 == num)
				{
				}
				num = (short)1908867072;
				short num3 = num;
				num = (short)1823277056;
				if (num != 0)
				{
				}
				return this.m_SyncImageSmallSource;
			}
			set
			{
				short num = (short)1290818425;
				short num2 = num;
				num = (short)1111053177;
				switch (num2 == num)
				{
				}
				num = (short)114425857;
				if (num != 0)
				{
				}
				num = (short)2003959808;
				short num3 = num;
				num = (short)1854210048;
				if (num != 0)
				{
				}
				this.m_SyncImageSmallSource = value;
			}
		}

		// Token: 0x040000C9 RID: 201
		private string m_Header = string.Empty;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Media.ImageSource m_ImageSource;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Media.ImageSource m_ImageSmallSource;

		// Token: 0x040000CC RID: 204
		private bool m_IsChecked;

		// Token: 0x040000CD RID: 205
		private bool m_SyncIsChecked = true;

		// Token: 0x040000CE RID: 206
		private bool m_SyncHeader = true;

		// Token: 0x040000CF RID: 207
		private bool m_SyncImageSource = true;

		// Token: 0x040000D0 RID: 208
		private bool m_SyncImageSmallSource = true;
	}
}
