using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000DD RID: 221
	public class RMPathNavigator : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x00062F18 File Offset: 0x00061118
		public RMPathNavigator()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00062F34 File Offset: 0x00061134
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1895424777;
			short num2 = num;
			num = (short)1944249097;
			switch (num2 == num)
			{
			}
			num = (short)1458110465;
			if (num != 0)
			{
			}
			num = (short)401604608;
			if (num != 0)
			{
			}
			num = (short)536543232;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator rmpathNavigator = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator;
			global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>> a_ = A_1.NewValue as global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>>;
			rmpathNavigator.a(a_);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00062FF8 File Offset: 0x000611F8
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x000630B0 File Offset: 0x000612B0
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>> PathSections
		{
			get
			{
				short num = (short)276365313;
				if (num != 0)
				{
				}
				num = (short)1085288261;
				short num2 = num;
				num = (short)1038888773;
				switch (num2 == num)
				{
				}
				num = (short)2119237632;
				if (num != 0)
				{
				}
				num = (short)105119744;
				short num3 = num;
				return (global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.PathSectionsProperty);
			}
			set
			{
				short num = (short)1424286801;
				short num2 = num;
				num = (short)1007281233;
				switch (num2 == num)
				{
				}
				num = (short)1886388225;
				if (num != 0)
				{
				}
				num = (short)818282496;
				if (num != 0)
				{
				}
				num = (short)187695104;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.PathSectionsProperty, value);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00063164 File Offset: 0x00061364
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x0006321C File Offset: 0x0006141C
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				short num = (short)1962739028;
				short num2 = num;
				num = (short)1852573012;
				switch (num2 == num)
				{
				}
				num = (short)1395261441;
				if (num != 0)
				{
				}
				num = (short)2129526784;
				if (num != 0)
				{
				}
				num = (short)1428815872;
				short num3 = num;
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.CommandProperty);
			}
			set
			{
				short num = (short)218759169;
				if (num != 0)
				{
				}
				num = (short)547826804;
				short num2 = num;
				num = (short)457714804;
				switch (num2 == num)
				{
				}
				num = (short)968491008;
				if (num != 0)
				{
				}
				num = (short)49610752;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.CommandProperty, value);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600062B RID: 1579 RVA: 0x000632D4 File Offset: 0x000614D4
		// (remove) Token: 0x0600062C RID: 1580 RVA: 0x00063388 File Offset: 0x00061588
		public event global::Motorola.CommonCPS.RadioManagement.Controls.SectionClickEventHandler SectionClick
		{
			add
			{
				short num = (short)332340059;
				short num2 = num;
				num = (short)1851661147;
				switch (num2 == num)
				{
				}
				num = (short)600440833;
				if (num != 0)
				{
				}
				num = (short)1012989952;
				if (num != 0)
				{
				}
				num = (short)1494220800;
				short num3 = num;
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.SectionClickEvent, value);
			}
			remove
			{
				short num = (short)254108067;
				short num2 = num;
				num = (short)987783587;
				switch (num2 == num)
				{
				}
				num = (short)170786817;
				if (num != 0)
				{
				}
				num = (short)1057554432;
				if (num != 0)
				{
				}
				num = (short)686882816;
				short num3 = num;
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.SectionClickEvent, value);
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00063440 File Offset: 0x00061640
		private bool a(global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>> A_0)
		{
			short num;
			if (A_0 == null)
			{
				num = (short)743618433;
				short num2 = num;
				num = (short)463714177;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1536491521;
					if (num != 0)
					{
					}
					num = (short)1920663552;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)1004011520;
			short num3 = num;
			this.breadCrumbsbar.ItemsSource = null;
			this.breadCrumbsbar.ItemsSource = A_0;
			A_0.CollectionChanged += this.breadCrumbs_CollectionChanged;
			return true;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0006351C File Offset: 0x0006171C
		private void Hyperlink_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			short num;
			int num2;
			global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
			for (;;)
			{
				IL_0A:
				num = (short)382009345;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1747779584;
					short num3 = num;
					this.Command.Execute(keyValuePair.Key);
					num = (short)1773268704;
					short num4 = num;
					num = (short)848686816;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)76742656;
						if (num != 0)
						{
						}
						num = (short)139264000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (this.Command != null)
					{
						num = (short)99811329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_43;
			}
			return;
			IL_43:
			global::System.Windows.Documents.Hyperlink hyperlink = A_0 as global::System.Windows.Documents.Hyperlink;
			keyValuePair = (global::System.Collections.Generic.KeyValuePair<string, string>)hyperlink.Tag;
			base.RaiseEvent(new global::Motorola.CommonCPS.RadioManagement.Controls.PathNavigatorSectionClickEventArgs(keyValuePair.Key, global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.SectionClickEvent));
			num = (short)2083127298;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00063678 File Offset: 0x00061878
		private void breadCrumbs_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)2033916083;
			short num2 = num;
			num = (short)276895923;
			switch (num2 == num)
			{
			}
			num = (short)1635516416;
			if (num != 0)
			{
			}
			num = (short)90243073;
			if (num != 0)
			{
			}
			num = (short)181993472;
			short num3 = num;
			this.breadCrumbsbar.Items.Refresh();
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00063734 File Offset: 0x00061934
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			short num;
			if (this._contentLoaded)
			{
				num = (short)845845822;
				short num2 = num;
				num = (short)2117178686;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1262944256;
					if (num != 0)
					{
					}
					num = (short)929759233;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)184614912;
			short num3 = num;
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("誤욨\udfaa슬\uddae\udeb0\udfb2풴馶視풺킼튾껀귂蛄韆髈鿌껎뗐뫒뫔髖룘뗚볜룞蓠転胤触鷨엪껬胮鿰蟲蟴飶闸裺웼鳾渀渂甄栆月渊挌笎㸐昒昔爖欘砚爜焞唠儢䨤䬦娨Ъ崬丮䔰嬲嬴嘶伸刺娼帾㕀ⱂ㝄框㭈♊㵌⹎═㭒㭔㙖⽘㉚㩜㹞ᕠౢᝤ䥦ᅨ੪lͮ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00063814 File Offset: 0x00061A14
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			if (connectionId == 1)
			{
				num = (short)1380667041;
				short num2 = num;
				num = (short)92163745;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1660420097;
					if (num != 0)
					{
					}
					num = (short)625999872;
					if (num != 0)
					{
					}
					this.breadCrumbsbar = (global::System.Windows.Controls.ItemsControl)target;
					return;
				}
			}
			num = (short)1302462464;
			short num3 = num;
			this._contentLoaded = true;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000638D8 File Offset: 0x00061AD8
		// Note: this type is marked as 'beforefieldinit'.
		static RMPathNavigator()
		{
			int a_ = 18;
			short num = (short)746175190;
			short num2 = num;
			num = (short)1698216662;
			switch (num2 == num)
			{
			}
			num = (short)1604255745;
			if (num != 0)
			{
			}
			num = (short)1891041280;
			if (num != 0)
			{
			}
			num = (short)287506432;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.PathSectionsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("睊춫\udaad\ud8af톳햵첷펹펻킽뎿", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::System.Collections.Generic.KeyValuePair<string, string>>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator), new global::System.Windows.UIPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.CommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎫쎭\uddaf펱\udab3튵", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator.SectionClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("囹즫춭쒯\udbb1\udbb3\ud8b5﮷횹햻\uddbdꮿ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::Motorola.CommonCPS.RadioManagement.Controls.SectionClickEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPathNavigator));
		}

		// Token: 0x040002A6 RID: 678
		public static readonly global::System.Windows.DependencyProperty PathSectionsProperty;

		// Token: 0x040002A7 RID: 679
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x040002A9 RID: 681
		internal global::System.Windows.Controls.ItemsControl breadCrumbsbar;

		// Token: 0x040002AA RID: 682
		private bool _contentLoaded;
	}
}
