using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000EB RID: 235
	public class RMItemsPositionMover : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x0006864C File Offset: 0x0006684C
		public RMItemsPositionMover()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00068668 File Offset: 0x00066868
		private void btnUp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1297285120;
			short num2 = num;
			num = (short)669856001;
			short num3 = num;
			num = (short)155726081;
			switch (num3 == num)
			{
			}
			num = (short)676986880;
			if (num != 0)
			{
			}
			num = (short)644546561;
			if (num != 0)
			{
			}
			object selectedItem = this.lbItems.SelectedItem;
			global::System.Collections.IList list = this.lbItems.ItemsSource as global::System.Collections.IList;
			int num4 = list.IndexOf(selectedItem);
			list.RemoveAt(num4);
			list.Insert(num4 - 1, selectedItem);
			this.lbItems.SelectedItem = selectedItem;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00068758 File Offset: 0x00066958
		private void btnDown_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)970522624;
			short num2 = num;
			num = (short)1252917249;
			if (num != 0)
			{
			}
			num = (short)428429104;
			short num3 = num;
			num = (short)1809141552;
			switch (num3 == num)
			{
			}
			num = (short)1180499968;
			if (num != 0)
			{
			}
			object selectedItem = this.lbItems.SelectedItem;
			global::System.Collections.IList list = this.lbItems.ItemsSource as global::System.Collections.IList;
			int num4 = list.IndexOf(selectedItem);
			list.RemoveAt(num4);
			list.Insert(num4 + 1, selectedItem);
			this.lbItems.SelectedItem = selectedItem;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00068840 File Offset: 0x00066A40
		private void lbItems_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)854130688;
			short num2 = num;
			num = (short)1354760193;
			if (num != 0)
			{
			}
			num = (short)1128960331;
			short num3 = num;
			num = (short)21205323;
			switch (num3 == num)
			{
			}
			num = (short)19267584;
			if (num != 0)
			{
			}
			this.btnUp.IsEnabled = (this.lbItems.SelectedIndex > 0);
			this.btnDown.IsEnabled = (this.lbItems.SelectedIndex != this.lbItems.Items.Count - 1 && this.lbItems.SelectedIndex != -1);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00068944 File Offset: 0x00066B44
		public void itemsMover_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)823394304;
			short num2 = num;
			num = (short)2020345952;
			short num3 = num;
			num = (short)1789069408;
			switch (num3 == num)
			{
			}
			num = (short)1955332097;
			if (num != 0)
			{
			}
			num = (short)1305280512;
			if (num != 0)
			{
			}
			this.btnUp.IsEnabled = false;
			this.btnDown.IsEnabled = false;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00068A08 File Offset: 0x00066C08
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 7;
			while (this._contentLoaded)
			{
				short num = (short)1014300672;
				short num2 = num;
				num = (short)1678770177;
				if (num != 0)
				{
				}
				num = (short)1775635430;
				short num3 = num;
				num = (short)424414182;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)548012032;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("낞첢톤좦\udba8쒪솬캮龰\udab4\udab6풸풺펼ﲾ釀郂闆꣈꿊꓌ꃎ鳐닒믔뛖뻘뻚냜뫞迠韢쯤ꓦ蛨藪駬鷮黰鿲蛴쳶髸铺郼迾渀洂怄椆紈␊砌簎琐愒瘔砖眘漚漜瀞䴠倢ਤ唦䐨䈪夬䨮尰䀲䔴堶䨸刺䤼嘾⹀ⵂ⡄⡆㽈⹊㽌慎⥐㉒㡔㭖", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00068AEC File Offset: 0x00066CEC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1417150464;
			short num2 = num;
			num = (short)1326936156;
			short num3 = num;
			num = (short)965505116;
			switch (num3 == num)
			{
			}
			num = (short)990511105;
			if (num != 0)
			{
			}
			num = (short)1989935104;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00068B9C File Offset: 0x00066D9C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)499646465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_144;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_153;
				case 2:
					goto IL_108;
				case 3:
					goto IL_FB;
				case 4:
					goto IL_146;
				default:
				{
					num = (short)1588264960;
					short num3 = num;
					num = (short)1942731115;
					short num4 = num;
					num = (short)588953963;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1924399105;
						if (num != 0)
						{
						}
						num = (short)1222639616;
						if (num != 0)
						{
						}
						num = (short)433979392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_12C:
				num = (short)1364721666;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FB:
			this.btnUp = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_108:
			this.lbItems = (global::System.Windows.Controls.ListView)target;
			this.lbItems.SelectionChanged += this.lbItems_SelectionChanged;
			return;
			IL_144:
			this._contentLoaded = true;
			return;
			IL_146:
			this.btnDown = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_153:
			this.itemsMover = (global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsPositionMover)target;
			this.itemsMover.DataContextChanged += this.itemsMover_DataContextChanged;
		}

		// Token: 0x040002DA RID: 730
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsPositionMover itemsMover;

		// Token: 0x040002DB RID: 731
		internal global::System.Windows.Controls.ListView lbItems;

		// Token: 0x040002DC RID: 732
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnUp;

		// Token: 0x040002DD RID: 733
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnDown;

		// Token: 0x040002DE RID: 734
		private bool _contentLoaded;
	}
}
