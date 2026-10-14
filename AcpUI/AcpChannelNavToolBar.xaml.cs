using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using AcpCommonLib;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000005 RID: 5
	public partial class AcpChannelNavToolBar : UserControl
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00003424 File Offset: 0x00001624
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000034D4 File Offset: 0x000016D4
		public CollectionView MyCollectionView
		{
			get
			{
				short num = (short)198901761;
				if (num != 0)
				{
				}
				num = (short)65994752;
				short num2 = num;
				num = (short)1051586936;
				short num3 = num;
				num = (short)82440568;
				switch (num3 == num)
				{
				}
				num = (short)1026949120;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1570547725;
				short num2 = num;
				num = (short)264284173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1315110912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)382992385;
				if (num != 0)
				{
				}
				num = (short)1654849536;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003584 File Offset: 0x00001784
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00003634 File Offset: 0x00001834
		public AcpPageFeature MyOwner
		{
			get
			{
				short num = (short)1341657343;
				short num2 = num;
				num = (short)652349695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816330240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189806081;
				if (num != 0)
				{
				}
				num = (short)968687616;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)290554605;
				short num2 = num;
				num = (short)524583661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685323776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2095251456;
				if (num != 0)
				{
				}
				num = (short)149225473;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000036E0 File Offset: 0x000018E0
		public virtual void OnClick(object sender, RoutedEventArgs e)
		{
			int a_ = 0;
			short num = (short)704446464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				CollectionView myCollectionView;
				AcpPageFeature myOwner;
				string name;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_143;
					case 1:
						goto IL_39F;
					case 2:
						myCollectionView.MoveCurrentToNext();
						num = (short)726073365;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
					{
						int currentPosition;
						myOwner.DataContext = myCollectionView.GetItemAt(currentPosition - 1);
						num = (short)294256669;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1269497871;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						goto IL_3CF;
					case 6:
					{
						bool flag = (IAcpFeatureNode)myCollectionView.CurrentItem != null;
						int count = myCollectionView.Count;
						if (flag)
						{
							num = (short)1154875410;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3CF;
					}
					case 7:
					{
						int currentPosition;
						int count;
						if (currentPosition < count - 1)
						{
							num = (short)24117270;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3CF;
					}
					case 8:
						if (myCollectionView.IsCurrentAfterLast)
						{
							num = (short)776339466;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a(myCollectionView);
						num = (short)1679818775;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						goto IL_3CF;
					case 10:
						myCollectionView.MoveCurrentToPrevious();
						num = (short)396623898;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
					{
						int currentPosition;
						if (currentPosition != 0)
						{
							num = (short)955449347;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3CF;
					}
					case 12:
						num = (short)255131673;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
					{
						if (name == AcpUI.Common.Utility.c("쒕ﶗ蓮튛ﾝ횟킣좥쎩\udeab\uddad쒯", a_))
						{
							myCollectionView.MoveCurrentToFirst();
							myOwner.DataContext = myCollectionView.GetItemAt(0);
							this.a(myCollectionView);
							num = (short)1872887822;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1213253883;
						short num3 = num;
						num = (short)1342949627;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39F;
						default:
							num = (short)1254621184;
							if (num != 0)
							{
							}
							num = (short)521928732;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						goto IL_3CF;
					case 15:
						if (!(name == AcpUI.Common.Utility.c("쒕ﶗ蓮튛ﾝ횟킣좥쾩풫\udaad", a_)))
						{
							num = (short)1262551052;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)583598081;
						if (num != 0)
						{
						}
						myCollectionView.MoveCurrentToNext();
						num = (short)745013256;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						goto IL_3CF;
					case 17:
						return;
					case 18:
						num = (short)302907405;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						if (!(name == AcpUI.Common.Utility.c("쒕ﶗ蓮튛ﾝ횟킣좥\ud8a9즫\ud8ad\ud9af\uddb1솳억", a_)))
						{
							num = (short)432799748;
							num2 = (int)((IntPtr)num);
							continue;
						}
						myCollectionView.MoveCurrentToPrevious();
						num = (short)458489883;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						if (myCollectionView != null)
						{
							num = (short)326959128;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 21:
						goto IL_143;
					case 22:
					{
						int currentPosition;
						myOwner.DataContext = myCollectionView.GetItemAt(currentPosition + 1);
						num = (short)481361929;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 23:
						goto IL_1F8;
					case 24:
					{
						int currentPosition = myCollectionView.CurrentPosition;
						num = (short)2104098822;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 25:
					{
						if (!(name == AcpUI.Common.Utility.c("쒕ﶗ蓮튛ﾝ횟킣좥쮩\udfab\udaad", a_)))
						{
							num = (short)1877278721;
							num2 = (int)((IntPtr)num);
							continue;
						}
						myCollectionView.MoveCurrentToLast();
						int count;
						myOwner.DataContext = myCollectionView.GetItemAt(count - 1);
						this.a(myCollectionView);
						num = (short)1239154693;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 26:
						goto IL_1F8;
					case 27:
						if (myCollectionView.IsCurrentBeforeFirst)
						{
							num = (short)1820065794;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a(myCollectionView);
						num = (short)1224998912;
						num2 = (int)((IntPtr)num);
						continue;
					case 28:
						num = (short)1944911891;
						num2 = (int)((IntPtr)num);
						continue;
					case 29:
						goto IL_3CF;
					}
					goto IL_B0;
					IL_143:
					num = (short)626589696;
					short num4 = num;
					num = (short)893583371;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1F8:
					num = (short)1584398343;
					num2 = (int)((IntPtr)num);
					continue;
					IL_39F:
					num = (short)54460432;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3CF:
					this.OnUpdateChanNavBar(myCollectionView);
					num = (short)1666580497;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_B0:
				AcpButton acpButton = (AcpButton)sender;
				AcpChannelNavToolBar acpChannelNavToolBar = (AcpChannelNavToolBar)((Grid)acpButton.Parent).Parent;
				name = acpButton.Name;
				myCollectionView = acpChannelNavToolBar.MyCollectionView;
				myOwner = acpChannelNavToolBar.MyOwner;
				num = (short)1132986388;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003CE4 File Offset: 0x00001EE4
		private void a(CollectionView A_0)
		{
			short num = (short)1896742915;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (!A_0.IsCurrentAfterLast)
					{
						num = (short)590807044;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_D4;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 4:
				{
					object currentItem = A_0.CurrentItem;
					A_0.MoveCurrentTo(null);
					A_0.MoveCurrentTo(currentItem);
					num = (short)1868496896;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 5:
					if (!A_0.IsCurrentBeforeFirst)
					{
						num = (short)88801281;
						if (num != 0)
						{
						}
						num = (short)497745926;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)661913601;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_41:
				if (A_0 == null)
				{
					break;
				}
				num = (short)1435680836;
				short num3 = num;
				num = (short)442220612;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1014038528;
					short num4 = num;
					num = (short)1495203840;
					if (num != 0)
					{
					}
					num = (short)839450626;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_D4:
				num = (short)1384972293;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003E98 File Offset: 0x00002098
		public void OnUpdateChanNavBar(CollectionView myCollect)
		{
			int a_ = 16;
			short num = (short)1952361020;
			short num2 = num;
			num = (short)1085516348;
			switch (num2 == num)
			{
			default:
			{
				num = (short)30670848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)750977025;
			if (num != 0)
			{
			}
			num = (short)1480720384;
			if (num != 0)
			{
			}
			int num4 = myCollect.CurrentPosition + 1;
			int count = myCollect.Count;
			string content = num4.ToString() + AcpUI.Common.Utility.c("蚥잧첩貫", a_) + count.ToString();
			this.c.Content = content;
			this.c.VerticalAlignment = VerticalAlignment.Center;
			this.c.FontWeight = FontWeights.Black;
			this.c.FontWeight = FontWeights.Bold;
			this.c.FontSize = 12.0;
			this.c.Background = Brushes.White;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003FD8 File Offset: 0x000021D8
		public AcpChannelNavToolBar()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000040D8 File Offset: 0x000022D8
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[DebuggerNonUserCode]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)338623770;
			short num2 = num;
			num = (short)8912154;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1706885120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)361299969;
			if (num != 0)
			{
			}
			num = (short)670302208;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0400000D RID: 13
		private CollectionView a;

		// Token: 0x0400000E RID: 14
		private AcpPageFeature b;
	}
}
