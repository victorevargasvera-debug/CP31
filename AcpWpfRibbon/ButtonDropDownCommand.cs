using System;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000018 RID: 24
	public class ButtonDropDownCommand : global::System.Windows.Input.RoutedCommand, global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender
	{
		// Token: 0x06000218 RID: 536 RVA: 0x00032CAC File Offset: 0x00030EAC
		public ButtonDropDownCommand()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00032CF8 File Offset: 0x00030EF8
		public ButtonDropDownCommand(string header, string name, global::System.Type ownerType) : this(header, name, string.Empty, string.Empty, ownerType, null)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00032D1C File Offset: 0x00030F1C
		public ButtonDropDownCommand(string header, string name, global::System.Type ownerType, global::System.Windows.Input.InputGestureCollection inputGestures) : this(header, name, string.Empty, string.Empty, ownerType, inputGestures)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00032D40 File Offset: 0x00030F40
		public ButtonDropDownCommand(string header, string name, string image, global::System.Type ownerType) : this(header, name, image, string.Empty, ownerType, null)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00032D60 File Offset: 0x00030F60
		public ButtonDropDownCommand(string header, string name, string image, global::System.Type ownerType, global::System.Windows.Input.InputGestureCollection inputGestures) : this(header, name, image, string.Empty, ownerType, inputGestures)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00032D80 File Offset: 0x00030F80
		public ButtonDropDownCommand(string header, string name, string image, string imageSmall, global::System.Type ownerType) : this(header, name, image, imageSmall, ownerType, null)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00032D9C File Offset: 0x00030F9C
		public ButtonDropDownCommand(string header, string name, string image, string imageSmall, global::System.Type ownerType, global::System.Windows.Input.InputGestureCollection inputGestures) : base(name, ownerType, inputGestures)
		{
			if (header != null)
			{
				this.m_Header = header;
			}
			if (image != null && image.Length > 0)
			{
				this.m_ImageSourceString = image;
			}
			if (imageSmall != null && imageSmall.Length > 0)
			{
				this.m_ImageSmallSourceString = imageSmall;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00032E30 File Offset: 0x00031030
		public ButtonDropDownCommand(string header, string name, global::System.Windows.Media.ImageSource image, global::System.Windows.Media.ImageSource imageSmall, global::System.Type ownerType, global::System.Windows.Input.InputGestureCollection inputGestures) : base(name, ownerType, inputGestures)
		{
			if (header != null)
			{
				this.m_Header = header;
			}
			this.m_ImageSource = image;
			this.m_ImageSmallSource = imageSmall;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00032E9C File Offset: 0x0003109C
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00032F4C File Offset: 0x0003114C
		public string Header
		{
			get
			{
				short num = (short)124407840;
				short num2 = num;
				num = (short)1875791904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1822294016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1790377985;
				if (num != 0)
				{
				}
				num = (short)321716224;
				if (num != 0)
				{
				}
				return this.m_Header;
			}
			set
			{
				short num = (short)855179264;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						goto IL_EF;
					case 2:
					{
						for (;;)
						{
							this.m_Header = value;
							global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
							num = (short)1145390727;
							short num3 = num;
							num = (short)783959687;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_9A;
							}
						}
						IL_9A:
						num = (short)199032832;
						short num4 = num;
						num = (short)57802752;
						if (num != 0)
						{
						}
						num = (short)1966014465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (!(this.m_Header != value))
					{
						return;
					}
					num = (short)1937833986;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EF:
				num = (short)733806593;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00033074 File Offset: 0x00031274
		// (set) Token: 0x06000223 RID: 547 RVA: 0x000331F0 File Offset: 0x000313F0
		public global::System.Windows.Media.ImageSource ImageSource
		{
			get
			{
				short num = (short)568066050;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)550547505;
						short num3 = num;
						num = (short)1250471985;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_112;
						default:
							num = (short)509214721;
							if (num != 0)
							{
							}
							num = (short)2003435520;
							if (num != 0)
							{
							}
							num = (short)1547960321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_112;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
						this.m_ImageSource = this.LoadImage(this.m_ImageSourceString);
						num = (short)1649213444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_81;
					}
					IL_38:
					if (this.m_ImageSource == null)
					{
						num = (short)580583424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_112:
					if (this.m_ImageSourceString.Length <= 0)
					{
						break;
					}
					num = (short)1357447168;
					short num4 = num;
					num = (short)611319811;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_81:
				return this.m_ImageSource;
			}
			set
			{
				short num = (short)761004032;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						for (;;)
						{
							this.m_ImageSource = value;
							global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
							num = (short)1318801184;
							short num3 = num;
							num = (short)1519341344;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_95;
							}
						}
						IL_95:
						num = (short)1371406336;
						short num4 = num;
						num = (short)1021837313;
						if (num != 0)
						{
						}
						num = (short)2112749568;
						if (num != 0)
						{
						}
						num = (short)1620508673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (this.m_ImageSource == value)
					{
						break;
					}
					num = (short)1241710594;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00033310 File Offset: 0x00031510
		private global::System.Windows.Media.ImageSource LoadImage(string source)
		{
			short num = (short)874184704;
			short num2 = num;
			num = (short)1567452327;
			short num3 = num;
			num = (short)826698919;
			global::System.Windows.Media.ImageSource result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)765657089;
				if (num != 0)
				{
				}
				num = (short)397869056;
				if (num != 0)
				{
				}
				result = null;
				try
				{
					result = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(source, global::System.UriKind.RelativeOrAbsolute));
				}
				catch
				{
				}
				break;
			}
			return result;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000333E0 File Offset: 0x000315E0
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00033558 File Offset: 0x00031758
		public global::System.Windows.Media.ImageSource ImageSmallSource
		{
			get
			{
				for (;;)
				{
					IL_00:
					short num = (short)1410662403;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (this.m_ImageSmallSourceString.Length > 0)
							{
								num = (short)16318468;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_164;
						case 1:
							goto IL_83;
						case 2:
						{
							num = (short)1371042276;
							short num3 = num;
							num = (short)1993372132;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)950403072;
								if (num != 0)
								{
								}
								num = (short)128909312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_38;
							}
							continue;
						case 4:
						{
							num = (short)1296957441;
							if (num != 0)
							{
							}
							num = (short)569704448;
							short num4 = num;
							this.m_ImageSmallSource = this.LoadImage(this.m_ImageSmallSourceString);
							num = (short)1073872897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_38:
						if (this.m_ImageSmallSource != null)
						{
							goto IL_164;
						}
						num = (short)1257701378;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_83:
				IL_164:
				return this.m_ImageSmallSource;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)2105868289;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							this.m_ImageSmallSource = value;
							global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
							num = (short)2035445713;
							short num3 = num;
							num = (short)2138271697;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)46465024;
								short num4 = num;
								break;
							}
							}
							num = (short)811663360;
							if (num != 0)
							{
							}
							num = (short)449118210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1329987585;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_57;
							}
							continue;
						case 2:
							return;
						}
						IL_57:
						if (this.m_ImageSmallSource == value)
						{
							return;
						}
						num = (short)527958016;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00033678 File Offset: 0x00031878
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00033728 File Offset: 0x00031928
		public bool SyncHeader
		{
			get
			{
				short num = (short)382650056;
				short num2 = num;
				num = (short)458671816;
				switch (num2 == num)
				{
				}
				num = (short)1021968385;
				if (num != 0)
				{
				}
				num = (short)1837367296;
				short num3 = num;
				num = (short)1508638720;
				if (num != 0)
				{
				}
				return this.m_SyncHeader;
			}
			set
			{
				short num = (short)1441716173;
				short num2 = num;
				num = (short)1788598221;
				switch (num2 == num)
				{
				}
				num = (short)1320681473;
				if (num != 0)
				{
				}
				num = (short)13697024;
				short num3 = num;
				num = (short)1566113792;
				if (num != 0)
				{
				}
				this.m_SyncHeader = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000337D8 File Offset: 0x000319D8
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00033888 File Offset: 0x00031A88
		public bool SyncImageSource
		{
			get
			{
				short num = (short)897017465;
				short num2 = num;
				num = (short)144402041;
				switch (num2 == num)
				{
				}
				num = (short)1814233089;
				if (num != 0)
				{
				}
				num = (short)735182848;
				short num3 = num;
				num = (short)101646336;
				if (num != 0)
				{
				}
				return this.m_SyncImageSource;
			}
			set
			{
				short num = (short)1743902201;
				short num2 = num;
				num = (short)1042011641;
				switch (num2 == num)
				{
				}
				num = (short)662896640;
				if (num != 0)
				{
				}
				num = (short)1598685184;
				short num3 = num;
				num = (short)570097665;
				if (num != 0)
				{
				}
				this.m_SyncImageSource = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00033938 File Offset: 0x00031B38
		// (set) Token: 0x0600022C RID: 556 RVA: 0x000339E8 File Offset: 0x00031BE8
		public bool SyncImageSmallSource
		{
			get
			{
				short num = (short)1619397076;
				short num2 = num;
				num = (short)1199442388;
				switch (num2 == num)
				{
				}
				num = (short)110428161;
				if (num != 0)
				{
				}
				num = (short)1775304704;
				short num3 = num;
				num = (short)1319829504;
				if (num != 0)
				{
				}
				return this.m_SyncImageSmallSource;
			}
			set
			{
				short num = (short)813965346;
				short num2 = num;
				num = (short)616898594;
				switch (num2 == num)
				{
				}
				num = (short)777191424;
				if (num != 0)
				{
				}
				num = (short)1581318144;
				short num3 = num;
				num = (short)856031233;
				if (num != 0)
				{
				}
				this.m_SyncImageSmallSource = value;
			}
		}

		// Token: 0x040000C1 RID: 193
		private string m_Header = string.Empty;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Media.ImageSource m_ImageSource;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Media.ImageSource m_ImageSmallSource;

		// Token: 0x040000C4 RID: 196
		private string m_ImageSourceString = "";

		// Token: 0x040000C5 RID: 197
		private string m_ImageSmallSourceString = "";

		// Token: 0x040000C6 RID: 198
		private bool m_SyncHeader = true;

		// Token: 0x040000C7 RID: 199
		private bool m_SyncImageSource = true;

		// Token: 0x040000C8 RID: 200
		private bool m_SyncImageSmallSource = true;
	}
}
