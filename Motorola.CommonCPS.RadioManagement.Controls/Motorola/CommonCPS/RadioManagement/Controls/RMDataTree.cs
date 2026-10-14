using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Input;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Menus;
using Infragistics.Controls.Menus.Primitives;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000059 RID: 89
	public class RMDataTree : global::Infragistics.Controls.Menus.XamDataTree
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00015170 File Offset: 0x00013370
		static RMDataTree()
		{
			int a_ = 11;
			short num = (short)254738432;
			short num2 = num;
			num = (short)1598136635;
			short num3 = num;
			num = (short)1496228155;
			switch (num3 == num)
			{
			}
			num = (short)726269953;
			if (num != 0)
			{
			}
			num = (short)1950416896;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.EnableDragDropProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮤욦쮨잪좬쎰튲튴쮸풺춼", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.a)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Controls.Menus.XamDataTreeNodeControl), global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.OnMouseLeftButtonDown));
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000161 RID: 353 RVA: 0x000152A8 File Offset: 0x000134A8
		// (remove) Token: 0x06000162 RID: 354 RVA: 0x000153E4 File Offset: 0x000135E4
		public event global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> XamDataTreeNodeControlLeftButtonClicked
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						goto IL_65;
					case 1:
						goto IL_105;
					case 2:
					{
						num2 = (short)1788082942;
						short num3 = num2;
						num2 = (short)643627774;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1652621312;
							if (num2 != 0)
							{
							}
							if (eventHandler != eventHandler2)
							{
								goto IL_65;
							}
							break;
						}
						num2 = (short)1902837761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_1C;
					IL_65:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> value2 = (global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs>>(ref this.XamDataTreeNodeControlLeftButtonClicked, value2, eventHandler2);
					num2 = (short)337051650;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_105:
				num2 = (short)1434058753;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				num2 = (short)1475149824;
				short num4 = num2;
				eventHandler = this.XamDataTreeNodeControlLeftButtonClicked;
				num2 = (short)1495400448;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						goto IL_91;
					case 1:
						return;
					case 2:
					{
						num2 = (short)193369335;
						short num3 = num2;
						num2 = (short)411407607;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)421462016;
							if (num2 != 0)
							{
							}
							if (eventHandler != eventHandler2)
							{
								goto IL_91;
							}
							break;
						}
						num2 = (short)276561921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_1C;
					IL_91:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> value2 = (global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs>>(ref this.XamDataTreeNodeControlLeftButtonClicked, value2, eventHandler2);
					num2 = (short)1494351874;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)537526272;
				short num4 = num2;
				num2 = (short)717422593;
				if (num2 != 0)
				{
				}
				eventHandler = this.XamDataTreeNodeControlLeftButtonClicked;
				num2 = (short)617086976;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00015524 File Offset: 0x00013724
		private static void OnMouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_123;
				case 1:
				{
					if (rmdataTree == null)
					{
						return;
					}
					num2 = (short)1903362049;
					if (num2 != 0)
					{
					}
					num2 = (short)1717381392;
					short num3 = num2;
					num2 = (short)930359568;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_123;
					default:
						num2 = (short)98435072;
						if (num2 != 0)
						{
						}
						num2 = (short)1725366275;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return;
				case 3:
					num2 = (short)1488453632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_123:
				global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> xamDataTreeNodeControlLeftButtonClicked = rmdataTree.XamDataTreeNodeControlLeftButtonClicked;
				if (xamDataTreeNodeControlLeftButtonClicked == null)
				{
					break;
				}
				xamDataTreeNodeControlLeftButtonClicked(A_0, A_1);
				num2 = (short)2143027202;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			num2 = (short)1087438848;
			short num4 = num2;
			rmdataTree = (((global::Infragistics.Controls.Menus.Primitives.NodesPanel)((global::System.Windows.FrameworkElement)A_0).Parent).Tree as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree);
			num2 = (short)2081947649;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00015684 File Offset: 0x00013884
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00015734 File Offset: 0x00013934
		public global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.RMDataTreeAutomationPeerManager AutomationPeerManager
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1418330112;
				short num2 = num;
				num = (short)673841153;
				if (num != 0)
				{
				}
				num = (short)119125974;
				short num3 = num;
				num = (short)1942599638;
				switch (num3 == num)
				{
				}
				num = (short)5636096;
				if (num != 0)
				{
				}
				return this.<AutomationPeerManager>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1340669952;
				short num2 = num;
				num = (short)187730025;
				short num3 = num;
				num = (short)2143783017;
				switch (num3 == num)
				{
				}
				num = (short)1991573504;
				if (num != 0)
				{
				}
				num = (short)1042874369;
				if (num != 0)
				{
				}
				this.<AutomationPeerManager>k__BackingField = value;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000157E4 File Offset: 0x000139E4
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			short num = (short)1696530432;
			short num2 = num;
			num = (short)1604982987;
			short num3 = num;
			num = (short)1867389131;
			switch (num3 == num)
			{
			}
			num = (short)1889861633;
			if (num != 0)
			{
			}
			num = (short)1051131904;
			if (num != 0)
			{
			}
			global::Infragistics.AutomationPeers.XamDataTreeAutomationPeer xamDataTreeAutomationPeer = new global::Infragistics.AutomationPeers.XamDataTreeAutomationPeer(this);
			this.AutomationPeerManager = new global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.RMDataTreeAutomationPeerManager(xamDataTreeAutomationPeer);
			return xamDataTreeAutomationPeer;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000158A0 File Offset: 0x00013AA0
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00015958 File Offset: 0x00013B58
		public bool EnableDragDrop
		{
			get
			{
				short num = (short)26476544;
				short num2 = num;
				num = (short)2025634965;
				short num3 = num;
				num = (short)1200471189;
				switch (num3 == num)
				{
				}
				num = (short)1933508609;
				if (num != 0)
				{
				}
				num = (short)1114308608;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.EnableDragDropProperty);
			}
			set
			{
				short num = (short)1287585792;
				short num2 = num;
				num = (short)1640459135;
				short num3 = num;
				num = (short)2077649791;
				switch (num3 == num)
				{
				}
				num = (short)1469120513;
				if (num != 0)
				{
				}
				num = (short)637927424;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.EnableDragDropProperty, value);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00015A10 File Offset: 0x00013C10
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree)A_0;
				bool flag = (bool)A_1.NewValue;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.SetIsDragDropSource(rmdataTree, flag);
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.SetIsDropTarget(rmdataTree, flag);
				if (!flag)
				{
					goto IL_FA;
				}
				num = (short)581697536;
				short num2 = num;
				num = (short)1306066945;
				if (num != 0)
				{
				}
				num = (short)209219695;
				short num3 = num;
				num = (short)209154159;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B0;
				}
			}
			IL_B0:
			num = (short)1584332800;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDropped += global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.DragDropExtention_TargetDropped;
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequest += global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.DragDropExtention_DragDataRequest;
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequest += global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.DragDropExtention_AcceptDropRequest;
			return;
			IL_FA:
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDropped -= global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.DragDropExtention_TargetDropped;
			global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequest -= global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree.DragDropExtention_DragDataRequest;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00015B3C File Offset: 0x00013D3C
		private static bool DragDropExtention_AcceptDropRequest(object A_0, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
			for (;;)
			{
				IL_0A:
				num = (short)846331904;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (rmdataTree != null)
					{
						num = (short)1571749891;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					num = (short)1561460737;
					if (num != 0)
					{
					}
					if (rmdataTree.EnableDragDrop)
					{
						num = (short)512950274;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)1182400517;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1360527361;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_11D;
				case 5:
				{
					num = (short)1149162669;
					short num4 = num;
					num = (short)37213357;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1283850240;
						if (num != 0)
						{
						}
						if (rmdataTree.AcceptDropRequest != null)
						{
							num = (short)577699844;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				}
				goto IL_51;
			}
			IL_11D:
			return rmdataTree.AcceptDropRequest(rmdataTree, A_1);
			IL_51:
			rmdataTree = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree);
			num = (short)302776320;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00015CD0 File Offset: 0x00013ED0
		private static object DragDropExtention_DragDataRequest(object A_0, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventArgs A_1)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_A6;
			}
			short num;
			int num4;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
			for (;;)
			{
				IL_13:
				num = (short)354156544;
				short num2 = num;
				num = (short)1453958110;
				short num3 = num;
				num = (short)1001825246;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1115422720;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (rmdataTree != null)
						{
							num = (short)1543897091;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A1;
					case 1:
						if (rmdataTree.EnableDragDrop)
						{
							num = (short)1451556865;
							if (num != 0)
							{
							}
							num = (short)983760898;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A1;
					case 2:
						num = (short)630456325;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)831520769;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_129;
					case 5:
						if (rmdataTree.DragDataRequest != null)
						{
							goto IL_111;
						}
						goto IL_18D;
					}
					goto IL_A6;
				}
				IL_111:
				num = (short)1188757508;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_129:
			return rmdataTree.DragDataRequest(rmdataTree, A_1);
			IL_18D:
			throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎙肟쾡톣향\udca7誩\udeab쮭힯\udbb1잳습\uddb7좹鲻諾늿ꏁꏃ苅꧇뻉귋鳍뗏ꏑꇓ돕ꯗ껙ﳛ믝雟蟡諣鋥죧黩菫컭胯胱鯳胵釷黹駻\udefd擿持瀃朅⠇氉挋簍』瘑易眕缗紙甛瀝䜟", a_));
			IL_1A1:
			return string.Empty;
			IL_A6:
			rmdataTree = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree);
			num = (short)164036608;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00015E84 File Offset: 0x00014084
		private static void DragDropExtention_TargetDropped(object A_0, global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_A1;
			}
			short num;
			int num4;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
			for (;;)
			{
				IL_0A:
				num = (short)1188720695;
				short num2 = num;
				num = (short)889417783;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_185;
				case 1:
					break;
				default:
				{
					num = (short)437583872;
					short num3 = num;
					break;
				}
				}
				num = (short)921370624;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					if (rmdataTree.EnableDragDrop)
					{
						goto IL_185;
					}
					return;
				case 1:
					if (rmdataTree != null)
					{
						num = (short)628883458;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)1238892544;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					rmdataTree.TargetDropped(rmdataTree, A_1);
					num = (short)907411462;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1442643973;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (rmdataTree.TargetDropped != null)
					{
						num = (short)322502659;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					return;
				}
				goto IL_A1;
				IL_185:
				num = (short)75235332;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_A1:
			rmdataTree = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree);
			num = (short)150536193;
			if (num != 0)
			{
			}
			num = (short)1577189377;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600016D RID: 365 RVA: 0x00016030 File Offset: 0x00014230
		// (remove) Token: 0x0600016E RID: 366 RVA: 0x00016168 File Offset: 0x00014368
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> TargetDropped
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)1348927489;
						if (num2 != 0)
						{
						}
						goto IL_89;
					case 1:
						return;
					case 2:
					{
						num2 = (short)1405241508;
						short num3 = num2;
						num2 = (short)404113572;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1488453632;
							if (num2 != 0)
							{
							}
							if (eventHandler != eventHandler2)
							{
								goto IL_89;
							}
							break;
						}
						num2 = (short)852819969;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_1C;
					IL_89:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs>>(ref this.TargetDropped, value2, eventHandler2);
					num2 = (short)1199964162;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)383844352;
				short num4 = num2;
				eventHandler = this.TargetDropped;
				num2 = (short)868745216;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						goto IL_65;
					case 1:
						return;
					case 2:
					{
						num2 = (short)263216792;
						short num3 = num2;
						num2 = (short)1641569944;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1645281280;
							if (num2 != 0)
							{
							}
							if (eventHandler != eventHandler2)
							{
								goto IL_65;
							}
							break;
						}
						num2 = (short)108396545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_1C;
					IL_65:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.TargetDroppedEventArgs>>(ref this.TargetDropped, value2, eventHandler2);
					num2 = (short)1071644673;
					if (num2 != 0)
					{
					}
					num2 = (short)1695350786;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)461111296;
				short num4 = num2;
				eventHandler = this.TargetDropped;
				num2 = (short)1239154688;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600016F RID: 367 RVA: 0x000162A4 File Offset: 0x000144A4
		// (remove) Token: 0x06000170 RID: 368 RVA: 0x000163DC File Offset: 0x000145DC
		public event global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler DragDataRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler dragDataRequestEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler dragDataRequestEventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)1619853313;
						if (num2 != 0)
						{
						}
						goto IL_8A;
					case 1:
						return;
					case 2:
					{
						num2 = (short)1645044887;
						short num3 = num2;
						num2 = (short)65627287;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)548864000;
							if (num2 != 0)
							{
							}
							if (dragDataRequestEventHandler != dragDataRequestEventHandler2)
							{
								goto IL_8A;
							}
							break;
						}
						num2 = (short)1110900737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_1C;
					IL_8A:
					dragDataRequestEventHandler2 = dragDataRequestEventHandler;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler)global::System.Delegate.Combine(dragDataRequestEventHandler2, value);
					dragDataRequestEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler>(ref this.DragDataRequest, value2, dragDataRequestEventHandler2);
					num2 = (short)1724383234;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)693370880;
				short num4 = num2;
				dragDataRequestEventHandler = this.DragDataRequest;
				num2 = (short)1237319680;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler dragDataRequestEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler dragDataRequestEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)476446720;
						short num3 = num2;
						num2 = (short)1657470977;
						if (num2 != 0)
						{
						}
						if (dragDataRequestEventHandler == dragDataRequestEventHandler2)
						{
							num2 = (short)2070806529;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_85;
					}
					case 1:
						return;
					case 2:
					{
						num2 = (short)1758598968;
						short num4 = num2;
						num2 = (short)1081415480;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_85;
						default:
							num2 = (short)98107392;
							if (num2 != 0)
							{
							}
							goto IL_85;
						}
						break;
					}
					}
					goto IL_1C;
					IL_85:
					dragDataRequestEventHandler2 = dragDataRequestEventHandler;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler)global::System.Delegate.Remove(dragDataRequestEventHandler2, value);
					dragDataRequestEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.DragDataRequestEventHandler>(ref this.DragDataRequest, value2, dragDataRequestEventHandler2);
					num2 = (short)2096824320;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				dragDataRequestEventHandler = this.DragDataRequest;
				num2 = (short)1887698946;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000171 RID: 369 RVA: 0x00016518 File Offset: 0x00014718
		// (remove) Token: 0x06000172 RID: 370 RVA: 0x0001664C File Offset: 0x0001484C
		public event global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler AcceptDropRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler acceptDropRequestEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler acceptDropRequestEventHandler2;
					switch (num)
					{
					case 0:
						if (acceptDropRequestEventHandler == acceptDropRequestEventHandler2)
						{
							num2 = (short)237240321;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AB;
					case 1:
						return;
					case 2:
					{
						num2 = (short)1294540287;
						short num3 = num2;
						num2 = (short)597302783;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AB;
						default:
							num2 = (short)892076032;
							if (num2 != 0)
							{
							}
							num2 = (short)472252417;
							if (num2 != 0)
							{
							}
							goto IL_AB;
						}
						break;
					}
					}
					goto IL_1C;
					IL_AB:
					acceptDropRequestEventHandler2 = acceptDropRequestEventHandler;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler)global::System.Delegate.Combine(acceptDropRequestEventHandler2, value);
					acceptDropRequestEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler>(ref this.AcceptDropRequest, value2, acceptDropRequestEventHandler2);
					num2 = (short)1966669824;
					short num4 = num2;
					num2 = (short)678887424;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				acceptDropRequestEventHandler = this.AcceptDropRequest;
				num2 = (short)548929538;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler acceptDropRequestEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler acceptDropRequestEventHandler2;
					switch (num)
					{
					case 0:
						if (acceptDropRequestEventHandler == acceptDropRequestEventHandler2)
						{
							num2 = (short)94502913;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AB;
					case 1:
						return;
					case 2:
					{
						num2 = (short)819111254;
						short num3 = num2;
						num2 = (short)462202198;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AB;
						default:
							num2 = (short)1574305793;
							if (num2 != 0)
							{
							}
							num2 = (short)546045952;
							if (num2 != 0)
							{
							}
							goto IL_AB;
						}
						break;
					}
					}
					goto IL_1C;
					IL_AB:
					acceptDropRequestEventHandler2 = acceptDropRequestEventHandler;
					global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler)global::System.Delegate.Remove(acceptDropRequestEventHandler2, value);
					acceptDropRequestEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.Controls.DragDropExtention.AcceptDropRequestEventHandler>(ref this.AcceptDropRequest, value2, acceptDropRequestEventHandler2);
					num2 = (short)815136768;
					short num4 = num2;
					num2 = (short)1095499776;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				acceptDropRequestEventHandler = this.AcceptDropRequest;
				num2 = (short)1646329858;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000173 RID: 371 RVA: 0x00016780 File Offset: 0x00014980
		// (remove) Token: 0x06000174 RID: 372 RVA: 0x000168BC File Offset: 0x00014ABC
		public event global::System.EventHandler ConnectionToServerLost
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1835466753;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AF;
					case 1:
						return;
					case 2:
					{
						num2 = (short)783993083;
						short num3 = num2;
						num2 = (short)26527995;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AF;
						default:
							num2 = (short)208928769;
							if (num2 != 0)
							{
							}
							num2 = (short)946733056;
							if (num2 != 0)
							{
							}
							goto IL_AF;
						}
						break;
					}
					}
					goto IL_1C;
					IL_AF:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.ConnectionToServerLost, value2, eventHandler2);
					num2 = (short)2096431104;
					short num4 = num2;
					num2 = (short)47644672;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler = this.ConnectionToServerLost;
				num2 = (short)1064108034;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)346554369;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AC;
					case 1:
						return;
					case 2:
					{
						num2 = (short)1714996364;
						short num3 = num2;
						num2 = (short)339002508;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AC;
						default:
							num2 = (short)1623982081;
							if (num2 != 0)
							{
							}
							num2 = (short)1811677184;
							if (num2 != 0)
							{
							}
							goto IL_AC;
						}
						break;
					}
					}
					goto IL_1C;
					IL_AC:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.ConnectionToServerLost, value2, eventHandler2);
					num2 = (short)418381824;
					short num4 = num2;
					num2 = (short)1595277312;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler = this.ConnectionToServerLost;
				num2 = (short)1667629058;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000169F0 File Offset: 0x00014BF0
		public void RaiseConnectionToServerLostEvent(object sender, global::System.EventArgs e)
		{
			short num = (short)1402599839;
			short num2 = num;
			num = (short)142539167;
			switch (num2 == num)
			{
			}
			num = (short)317718529;
			if (num != 0)
			{
			}
			num = (short)235274240;
			short num3 = num;
			num = (short)1609302016;
			if (num != 0)
			{
			}
			global::System.EventHandler connectionToServerLost = this.ConnectionToServerLost;
			if (connectionToServerLost == null)
			{
				return;
			}
			connectionToServerLost(sender, e);
		}

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty EnableDragDropProperty;
	}
}
