using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000AF RID: 175
	public class ProgressIndicator : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600046A RID: 1130 RVA: 0x000486F0 File Offset: 0x000468F0
		public ProgressIndicator()
		{
			this.InitializeComponent();
			this.dispatcherTimer = new global::System.Windows.Threading.DispatcherTimer();
			this.dispatcherTimer.Interval = new global::System.TimeSpan(0, 0, 0, 0, 500);
			this.dispatcherTimer.Tick += this.dispatcherTimer_Tick;
			this.StackPanel.Loaded += this.stackPanel_Loaded;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0004875C File Offset: 0x0004695C
		private void stackPanel_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1090519041;
			if (num != 0)
			{
			}
			num = (short)228292546;
			short num2 = num;
			num = (short)894007234;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1910898688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)254935040;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00048808 File Offset: 0x00046A08
		private void dispatcherTimer_Tick(object A_0, global::System.EventArgs A_1)
		{
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				global::System.Windows.Controls.UIElementCollection children;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						num2 = (short)1618477057;
						if (num2 != 0)
						{
						}
						if (children != null)
						{
							num2 = (short)1758527489;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						int num3 = this.index;
						global::System.Windows.FrameworkElement a_ = children[num3] as global::System.Windows.FrameworkElement;
						this.a(a_);
						this.index = (this.index + 1) % children.Count;
						num2 = (short)543424514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						return;
					}
					break;
				}
				IL_1C:
				children = this.StackPanel.Children;
				num2 = (short)384027281;
				short num4 = num2;
				num2 = (short)813288081;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)569180160;
					short num5 = num2;
					num2 = (short)1235222528;
					if (num2 != 0)
					{
					}
					num2 = (short)2041053184;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00048958 File Offset: 0x00046B58
		private void c()
		{
			short num = (short)1984102400;
			short num2 = num;
			num = (short)1905490056;
			short num3 = num;
			num = (short)927234184;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E8:
				this.dispatcherTimer.Start();
				num = (short)2145779714;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1371144192;
				if (num != 0)
				{
				}
				num = (short)1323368448;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				case 1:
					goto IL_E6;
				case 2:
					return;
				}
				IL_A2:
				if (this.dispatcherTimer == null)
				{
					return;
				}
				num = (short)958267393;
				if (num != 0)
				{
				}
				num = (short)532086785;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			goto IL_E8;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00048A70 File Offset: 0x00046C70
		private void a(global::System.Windows.FrameworkElement A_0)
		{
			int a_ = 19;
			short num = (short)1009952092;
			short num2 = num;
			num = (short)320120156;
			global::System.Windows.Media.Animation.Storyboard storyboard;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1878392832;
				if (num != 0)
				{
				}
				num = (short)1325793280;
				short num3 = num;
				num = (short)1664548865;
				if (num != 0)
				{
				}
				storyboard = (base.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캪솬쪮\udcb0횲\udbb4쎶쾺튼춾룀ꇂ꫄ꛆ믈꿊", a_)] as global::System.Windows.Media.Animation.Storyboard);
				global::System.Windows.NameScope.SetNameScope(this, new global::System.Windows.NameScope());
				A_0.Name = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("솬쪮\udcb0횲\udbb4쎶", a_);
				global::System.Windows.NameScope.SetNameScope(A_0, global::System.Windows.NameScope.GetNameScope(this));
				global::System.Windows.NameScope.GetNameScope(this).RegisterName(A_0.Name, A_0);
				global::System.Windows.NameScope.SetNameScope(storyboard, global::System.Windows.NameScope.GetNameScope(this));
				using (global::System.Windows.Media.Animation.TimelineCollection.Enumerator enumerator = storyboard.Children.GetEnumerator())
				{
					num = (short)1694040066;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)495058947;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Media.Animation.Timeline element = enumerator.Current;
							global::System.Windows.Media.Animation.Storyboard.SetTargetName(element, A_0.Name);
							num = (short)1086521345;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_151;
							}
							continue;
						case 3:
							num = (short)1007288324;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1C9;
						}
						IL_17D:
						num = (short)910622720;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_151:
						goto IL_17D;
					}
					IL_1C9:;
				}
				break;
			}
			}
			storyboard.Begin(A_0);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00048C70 File Offset: 0x00046E70
		public void Stop()
		{
			short num;
			for (;;)
			{
				num = (short)1312686080;
				short num2 = num;
				if (base.Dispatcher.CheckAccess())
				{
					goto IL_C8;
				}
				num = (short)898816180;
				short num3 = num;
				num = (short)110614708;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_70;
				}
			}
			IL_70:
			num = (short)121569281;
			if (num != 0)
			{
			}
			num = (short)223608832;
			if (num != 0)
			{
			}
			base.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(this.b));
			return;
			IL_C8:
			this.dispatcherTimer.Stop();
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00048D50 File Offset: 0x00046F50
		public void Start()
		{
			short num;
			for (;;)
			{
				num = (short)257228800;
				short num2 = num;
				if (base.Dispatcher.CheckAccess())
				{
					goto IL_C6;
				}
				num = (short)124841880;
				short num3 = num;
				num = (short)2126770072;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6D;
				}
			}
			IL_6D:
			num = (short)500760577;
			if (num != 0)
			{
			}
			num = (short)1580793856;
			if (num != 0)
			{
			}
			base.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(this.a));
			return;
			IL_C6:
			this.dispatcherTimer.Start();
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00048E30 File Offset: 0x00047030
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num;
			for (;;)
			{
				num = (short)23134208;
				short num2 = num;
				if (!this._contentLoaded)
				{
					goto IL_87;
				}
				num = (short)1453491752;
				short num3 = num;
				num = (short)1236436520;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6F;
				}
			}
			IL_6F:
			num = (short)1959264256;
			if (num != 0)
			{
			}
			return;
			IL_87:
			num = (short)140771329;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("薩솭쒯\uddb1욳\ud9b5풷\udbb9銻ﶽ꾿꿁꧃꧅ꛇ觉鳋鷍ﻏ胑뗓닕뇗뗙釛뿝軟菡菣菥藧迩苫髭\udeef뇱鯳飵賷裹鏻鋽珿㤁會椅攇稉挋怍甏簑怓㤕洗椙礛氝䌟䴡䨣別娧䔩䀫崭Ἧ䈱䘳夵強䠹夻䴽㌿⭁⩃≅ⅇ⥉ⵋ㩍㽏⁑穓⹕㥗㝙せ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00048F10 File Offset: 0x00047110
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)972029952;
				short num2 = num;
				if (connectionId != 1)
				{
					goto IL_B3;
				}
				num = (short)836017306;
				short num3 = num;
				num = (short)1338743962;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_69;
				}
			}
			IL_69:
			num = (short)966459393;
			if (num != 0)
			{
			}
			num = (short)2085683200;
			if (num != 0)
			{
			}
			this.StackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_B3:
			this._contentLoaded = true;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00048FD8 File Offset: 0x000471D8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b()
		{
			short num = (short)1426425364;
			short num2 = num;
			num = (short)819234324;
			switch (num2 == num)
			{
			}
			num = (short)1999896576;
			short num3 = num;
			num = (short)1194983425;
			if (num != 0)
			{
			}
			num = (short)1568014336;
			if (num != 0)
			{
			}
			this.dispatcherTimer.Stop();
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0004908C File Offset: 0x0004728C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a()
		{
			short num = (short)1306984449;
			if (num != 0)
			{
			}
			num = (short)1234307944;
			short num2 = num;
			num = (short)2016480104;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1986265088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)409337856;
			if (num != 0)
			{
			}
			this.dispatcherTimer.Start();
		}

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.Threading.DispatcherTimer dispatcherTimer;

		// Token: 0x040001A6 RID: 422
		private int index;

		// Token: 0x040001A7 RID: 423
		internal global::System.Windows.Controls.StackPanel StackPanel;

		// Token: 0x040001A8 RID: 424
		private bool _contentLoaded;
	}
}
