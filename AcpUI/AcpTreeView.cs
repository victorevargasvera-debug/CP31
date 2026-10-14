using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpUI.DragDrop;

namespace AcpUI
{
	// Token: 0x02000038 RID: 56
	public abstract class AcpTreeView : global::System.Windows.Controls.TreeView
	{
		// Token: 0x06000383 RID: 899 RVA: 0x0003BAF4 File Offset: 0x00039CF4
		public AcpTreeView()
		{
			base.Loaded += this.AcpTreeView_Loaded;
			base.Unloaded += this.AcpTreeView_Unloaded;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0003BB38 File Offset: 0x00039D38
		public global::System.Collections.Generic.Dictionary<int, global::AcpUI.AcpTreeViewItem> RootNodes
		{
			get
			{
				short num = (short)1744815599;
				short num2 = num;
				num = (short)635618799;
				switch (num2 == num)
				{
				}
				num = (short)681050112;
				if (num != 0)
				{
				}
				num = (short)2084372480;
				short num3 = num;
				num = (short)374407169;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0003BBE8 File Offset: 0x00039DE8
		private void AcpTreeView_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)777120880;
			short num2 = num;
			num = (short)133557360;
			switch (num2 == num)
			{
			}
			num = (short)1633419264;
			if (num != 0)
			{
			}
			num = (short)1118765056;
			short num3 = num;
			num = (short)1200160769;
			if (num != 0)
			{
			}
			global::AcpCommonLib.UndoRedo.UndoManager.LaunchSectionHandler = (global::AcpCommonLib.LaunchSection)global::System.Delegate.Combine(global::AcpCommonLib.UndoRedo.UndoManager.LaunchSectionHandler, new global::AcpCommonLib.LaunchSection(this.LaunchSection));
			base.PreviewMouseLeftButtonDown += this.AcpTreeView_PreviewMouseLeftButtonDown;
			base.PreviewMouseLeftButtonUp += this.AcpTreeView_PreviewMouseLeftButtonUp;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0003BCD8 File Offset: 0x00039ED8
		private void AcpTreeView_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)445427963;
					short num3 = num2;
					num2 = (short)2054533371;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)821231616;
						if (num2 != 0)
						{
						}
						num2 = (short)1491206145;
						if (num2 != 0)
						{
						}
						this.b.Clear();
						num2 = (short)524289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_13A;
				case 2:
					if (this.b != null)
					{
						num2 = (short)1356988416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_13A:
			num2 = (short)2949120;
			short num4 = num2;
			return;
			IL_1C:
			base.PreviewMouseLeftButtonDown -= this.AcpTreeView_PreviewMouseLeftButtonDown;
			base.PreviewMouseLeftButtonUp -= this.AcpTreeView_PreviewMouseLeftButtonUp;
			global::AcpCommonLib.UndoRedo.UndoManager.LaunchSectionHandler = (global::AcpCommonLib.LaunchSection)global::System.Delegate.Remove(global::AcpCommonLib.UndoRedo.UndoManager.LaunchSectionHandler, new global::AcpCommonLib.LaunchSection(this.LaunchSection));
			this.c = false;
			this.d = false;
			num2 = (short)328269826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0003BE4C File Offset: 0x0003A04C
		private void AcpTreeView_PreviewMouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num;
			if (this.c)
			{
				num = (short)1380872603;
				short num2 = num;
				num = (short)1732080027;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1030553601;
					if (num != 0)
					{
					}
					num = (short)1695940608;
					if (num != 0)
					{
					}
					this.d = true;
					A_1.Handled = true;
					return;
				}
			}
			num = (short)651231232;
			short num3 = num;
			this.d = false;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0003BF1C File Offset: 0x0003A11C
		private void AcpTreeView_PreviewMouseLeftButtonUp(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)893976580;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					A_1.Handled = true;
					this.d = false;
					num = (short)141492225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					goto IL_86;
				case 3:
				{
					num = (short)1918827431;
					short num3 = num;
					num = (short)1679096743;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)27656192;
						short num4 = num;
						num = (short)617218048;
						if (num != 0)
						{
						}
						num = (short)843841537;
						if (num != 0)
						{
						}
						if (this.d)
						{
							num = (short)1688141824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 5:
					A_1.Handled = true;
					num = (short)405012482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				if (this.c)
				{
					num = (short)368312325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_86:
				num = (short)1931935747;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0003C0A8 File Offset: 0x0003A2A8
		public void OnTreeViewRecordNavigation(global::AcpCommonLib.IAcpFeatureNode newRecord, global::System.Windows.Controls.TreeView MyTreeView)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset parent;
			for (;;)
			{
				IL_0A:
				global::AcpUI.AcpTreeViewItem acpTreeViewItem;
				switch (num)
				{
				case 0:
				{
					num2 = (short)184680448;
					short num3 = num2;
					if (acpTreeViewItem != null)
					{
						num2 = (short)670236673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					goto IL_167;
				case 2:
				{
					num2 = (short)1492300951;
					short num4 = num2;
					num2 = (short)993834135;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_167;
					default:
						goto IL_B2;
					}
					break;
				}
				case 3:
					if (parent != null)
					{
						num2 = (short)1738801156;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					acpTreeViewItem = this.FindChildTreeViewItem(parent.RecsetId, newRecord.NodeId, MyTreeView.Items);
					num2 = (short)213975041;
					if (num2 != 0)
					{
					}
					num2 = (short)1172832256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_167:
				acpTreeViewItem.Focus();
				num2 = (short)1337589762;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_B2:
			num2 = (short)1830092800;
			if (num2 != 0)
			{
			}
			return;
			IL_24:
			global::System.Diagnostics.Stopwatch.StartNew();
			parent = newRecord.Parent;
			num2 = (short)156041219;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0003C224 File Offset: 0x0003A424
		private global::AcpUI.AcpTreeViewItem a(int A_0, global::System.Windows.Controls.ItemCollection A_1)
		{
			short num = (short)182648832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)A_1).GetEnumerator();
				goto IL_28;
				global::AcpUI.AcpTreeViewItem result;
				try
				{
					for (;;)
					{
						IL_28:
						num = (short)133496844;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
								global::AcpUI.AcpTreeViewItem acpTreeViewItem = this.a(A_0, acpTreeViewItem2.Items);
								num = (short)2053701634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_286;
							case 2:
							{
								global::AcpUI.AcpTreeViewItem acpTreeViewItem;
								if (acpTreeViewItem != null)
								{
									num = (short)422248455;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18A;
							}
							case 3:
								goto IL_1E6;
							case 4:
							{
								global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
								result = acpTreeViewItem2;
								num = (short)171442179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_F0;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1820786698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpUI.AcpTreeViewItem acpTreeViewItem2 = (global::AcpUI.AcpTreeViewItem)enumerator.Current;
								num = (short)1525481480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::AcpUI.AcpTreeViewItem acpTreeViewItem;
								result = acpTreeViewItem;
								num = (short)765984773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
								if (A_0 == acpTreeViewItem2.RecsetId)
								{
									num = (short)1418199053;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_226;
							}
							case 9:
							{
								global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
								if (acpTreeViewItem2.NodeId == 0)
								{
									num = (short)586874884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_226;
							}
							case 10:
								num = (short)127533057;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
							{
								global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
								if (acpTreeViewItem2.Items.Count > 0)
								{
									num = (short)1062928384;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18A;
							}
							case 12:
								switch (0)
								{
								case 0:
									goto IL_87;
								}
								continue;
							case 13:
								num = (short)1343881225;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_87;
							IL_18A:
							num = (short)1296957446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_87:
							num = (short)2105623926;
							short num3 = num;
							num = (short)104023414;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_28;
							default:
								num = (short)98238464;
								if (num != 0)
								{
								}
								goto IL_18A;
							}
							IL_226:
							num = (short)150536203;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_F0:
					IL_1E6:
					goto IL_301;
					IL_286:
					goto IL_26;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2A8;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_295:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)287375361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2FE;
						case 2:
							if (disposable != null)
							{
								num = (short)10158080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_300;
						}
						goto IL_2A8;
					}
					IL_2FE:
					IL_300:
					goto EndFinally_9;
					IL_2A8:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1957232642;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_295;
					EndFinally_9:;
				}
				goto IL_301;
				IL_26:
				return null;
				IL_301:
				num = (short)842465280;
				short num4 = num;
				num = (short)1065418753;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0003C5A0 File Offset: 0x0003A7A0
		private void a(int A_0, int A_1, global::System.Windows.Controls.ItemCollection A_2, global::AcpCommonLib.IAcpRecordset A_3)
		{
			short num = (short)116129792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::System.Windows.Controls.TreeViewItem insertItem;
				for (;;)
				{
					IL_27:
					int num4;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_1CC;
					case 2:
						if (A_0 < A_1)
						{
							num = (short)335151109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163;
					case 3:
						goto IL_1CC;
					case 4:
					{
						num = (short)1473904641;
						if (num != 0)
						{
						}
						num = (short)2135293952;
						short num3 = num;
						if (num4 >= A_0 + 1)
						{
							num = (short)1909850112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpTreeViewItem)A_2[num4]).Header = A_3[num4].ReferenceKey;
						((global::AcpUI.AcpTreeViewItem)A_2[num4]).ReferenceKey = A_3[num4].ReferenceKey;
						num4++;
						num = (short)924057601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num5 = A_0;
						num = (short)1565655050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
						try
						{
							A_2.RemoveAt(A_0);
							goto IL_2B7;
						}
						catch (global::System.ArgumentOutOfRangeException)
						{
							goto IL_2B7;
						}
						catch (global::System.Exception ex)
						{
							throw new global::System.Exception(ex.Message, ex.InnerException);
						}
						goto IL_163;
						IL_2B7:
						A_2.Insert(A_1, insertItem);
						num = (short)2004090882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_279;
					case 9:
					{
						int num5;
						if (num5 >= A_1 + 1)
						{
							num = (short)599261190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpTreeViewItem)A_2[num5]).Header = A_3[num5].ReferenceKey;
						((global::AcpUI.AcpTreeViewItem)A_2[num5]).ReferenceKey = A_3[num5].ReferenceKey;
						num5++;
						num = (short)186974216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_279;
					}
					goto IL_5A;
					IL_163:
					num4 = A_1;
					num = (short)1193977632;
					short num6 = num;
					num = (short)388474656;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_279:
						num = (short)25690121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)1359675392;
						if (num != 0)
						{
						}
						num = (short)1353056259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1CC:
					num = (short)1708457988;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5A:
				insertItem = (global::System.Windows.Controls.TreeViewItem)A_2[A_0];
				num = (short)618004487;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0003C8C4 File Offset: 0x0003AAC4
		public void OnTreeViewRecordOperation(global::AcpCommonLib.IAcpRecordset recset, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e, global::System.Windows.Controls.TreeView MyTreeView)
		{
			short num = (short)2037252096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AB;
				}
				global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
				global::AcpUI.AcpTreeViewItem acpTreeViewItem3;
				for (;;)
				{
					IL_28:
					int num4;
					global::System.Collections.IEnumerator enumerator;
					int num6;
					switch (num2)
					{
					case 0:
					{
						int num3 = e.NewStartingIndex;
						num = (short)668532756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (num4 < 0)
						{
							num = (short)450953218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpUI.AcpTreeViewItem acpTreeViewItem = (global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Items[num4];
						enumerator = e.OldItems.GetEnumerator();
						num = (short)828178453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_5C5;
					case 3:
						if (e.OldStartingIndex < recset.Count)
						{
							num = (short)757399582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E28;
					case 4:
					{
						num = (short)1568145408;
						short num5 = num;
						int num3;
						if (num3 >= recset.Count)
						{
							num = (short)1057161245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Items[num3]).Header = recset[num3].ReferenceKey;
						((global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Items[num3]).ReferenceKey = recset[num3].ReferenceKey;
						num3++;
						num = (short)46465052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (num6 >= recset.Count)
						{
							num = (short)396296204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_521;
					case 6:
						goto IL_D90;
					case 7:
					{
						global::System.Collections.Specialized.NotifyCollectionChangedAction action = e.Action;
						num = (short)109051927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return;
					case 9:
						acpTreeViewItem2 = this.a(recset.RecsetId, MyTreeView.Items);
						num = (short)196804625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (recset != null)
						{
							num = (short)1050673161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						try
						{
							num = (short)1857290247;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpBusinessLayer.FeatureNode featureNode;
								switch (num2)
								{
								case 1:
									acpTreeViewItem2.Focus();
									this.a = null;
									num = (short)1318780928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									acpTreeViewItem3.ReferenceKey = featureNode.ReferenceKey;
									num = (short)1116995587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_325;
								case 5:
									goto IL_4A8;
								case 6:
									if (recset.HasKeyField)
									{
										num = (short)1718419458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_325;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_320;
									}
									continue;
								case 8:
									if (acpTreeViewItem2.IsSelected)
									{
										num = (short)1322254337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpTreeViewItem3.Focus();
									num = (short)73531396;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1988624389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (!enumerator.MoveNext())
									{
										num = (short)1723793417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									featureNode = (global::AcpBusinessLayer.FeatureNode)enumerator.Current;
									acpTreeViewItem3.Header = featureNode.ReferenceKey;
									num = (short)1360330758;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_320;
								IL_325:
								acpTreeViewItem3.RecsetId = recset.RecsetId;
								acpTreeViewItem3.NodeId = featureNode.NodeId;
								acpTreeViewItem2.Items.Add(acpTreeViewItem3);
								num = (short)22872072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F8:
								num = (short)1307181066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_320:
								goto IL_3F8;
							}
							IL_4A8:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_4CA;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_4B7:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1672609794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_520;
								case 1:
									goto IL_51E;
								case 2:
									disposable.Dispose();
									num = (short)1732575233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4CA;
							}
							IL_51E:
							IL_520:
							goto EndFinally_34;
							IL_4CA:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)874446848;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_4B7;
							EndFinally_34:;
						}
						goto IL_521;
					case 12:
						goto IL_E28;
					case 13:
						num = (short)40763393;
						if (num != 0)
						{
						}
						goto IL_58C;
					case 14:
					{
						int num7;
						if (num7 >= e.NewItems.Count)
						{
							num = (short)1050542080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C86;
					}
					case 15:
						goto IL_58C;
					case 16:
					{
						if (e.NewStartingIndex == acpTreeViewItem2.Items.Count)
						{
							num = (short)22478874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num7 = 0;
						num = (short)206176262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (acpTreeViewItem2 != null)
						{
							num = (short)1080492039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						goto IL_266;
					case 19:
						if (this.UpdateTreeView(recset.RecsetId))
						{
							num = (short)1931477019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
						goto IL_CAF;
					case 21:
						try
						{
							num = (short)47644684;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpBusinessLayer.FeatureNode featureNode2;
								switch (num2)
								{
								case 0:
								{
									acpTreeViewItem2.Items.MoveCurrentToFirst();
									global::AcpUI.AcpTreeViewItem acpTreeViewItem;
									acpTreeViewItem2.Items.Remove(acpTreeViewItem);
									num = (short)715370494;
									short num8 = num;
									num = (short)191999998;
									switch ((num8 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_926;
									default:
										num = (short)1183121408;
										if (num != 0)
										{
										}
										num = (short)1114701832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_A23;
								case 3:
									num = (short)648151046;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpUI.AcpTreeViewItem acpTreeViewItem4 = (global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Items[num4 - 1];
									num = (short)805240848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									if (!acpTreeViewItem2.IsSelected)
									{
										num = (short)1239089162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
								{
									global::AcpUI.AcpTreeViewItem acpTreeViewItem;
									if (acpTreeViewItem.NodeId == featureNode2.NodeId)
									{
										num = (short)863174656;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									if (acpTreeViewItem2.Items.Count > 0)
									{
										num = (short)1554382865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
								{
									global::AcpUI.AcpTreeViewItem acpTreeViewItem;
									if (acpTreeViewItem.RecsetId == recset.RecsetId)
									{
										num = (short)1839267854;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									acpTreeViewItem2.IsSelected = true;
									num = (short)344129538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)2105540627;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									switch (0)
									{
									case 0:
										goto IL_8FF;
									}
									continue;
								case 13:
									if (!enumerator.MoveNext())
									{
										num = (short)953810955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_926;
								case 14:
									num = (short)742326279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									if (this.a == null)
									{
										num = (short)526450691;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpUI.AcpTreeViewItem acpTreeViewItem4;
									acpTreeViewItem4.Focus();
									num = (short)1829044228;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									goto IL_A23;
								case 17:
									num = (short)1682178066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									if (num4 == acpTreeViewItem2.Items.Count)
									{
										num = (short)626196485;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpUI.AcpTreeViewItem acpTreeViewItem4 = (global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Items[num4];
									num = (short)476708865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									goto IL_C0B;
								}
								goto IL_8FF;
								IL_926:
								featureNode2 = (global::AcpBusinessLayer.FeatureNode)enumerator.Current;
								num = (short)373948425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A23:
								num = (short)1630273551;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B06:
								num = (short)1968766989;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8FF:
								goto IL_B06;
							}
							IL_C0B:
							goto IL_843;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_C2D;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_C1A:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)485687298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)553517056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C85;
								case 2:
									goto IL_C83;
								}
								goto IL_C2D;
							}
							IL_C83:
							IL_C85:
							goto EndFinally_33;
							IL_C2D:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)312147969;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_C1A;
							EndFinally_33:;
						}
						goto IL_C86;
						IL_843:
						num = (short)388628483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_D90;
					case 23:
					{
						global::System.Collections.Specialized.NotifyCollectionChangedAction action;
						switch (action)
						{
						case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
							num = (short)742457360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
							num4 = acpTreeViewItem2.Items.Count - 1;
							num = (short)1840775181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
							return;
						case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
							goto IL_808;
						default:
							num = (short)470679560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 24:
					{
						try
						{
							num = (short)1628110853;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpBusinessLayer.FeatureNode featureNode3;
								switch (num2)
								{
								case 0:
									acpTreeViewItem3.ReferenceKey = featureNode3.ReferenceKey;
									num = (short)1470496775;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (recset.HasKeyField)
									{
										num = (short)1999568896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6C5;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)566099971;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									featureNode3 = (global::AcpBusinessLayer.FeatureNode)enumerator.Current;
									acpTreeViewItem3.Header = featureNode3.ReferenceKey;
									num = (short)1306198017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1232797702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_611;
									}
									continue;
								case 6:
									goto IL_727;
								case 7:
									goto IL_6C5;
								}
								IL_662:
								num = (short)503709698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_611:
								goto IL_662;
								IL_6C5:
								acpTreeViewItem3.RecsetId = recset.RecsetId;
								acpTreeViewItem3.NodeId = featureNode3.NodeId;
								acpTreeViewItem2.Items.Insert(e.NewStartingIndex, acpTreeViewItem3);
								num = (short)468910084;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_727:
							goto IL_D6F;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_749;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_736:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)915275778;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7A1;
								case 1:
									goto IL_79F;
								case 2:
									disposable.Dispose();
									num = (short)197459969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_749;
							}
							IL_79F:
							IL_7A1:
							goto EndFinally_32;
							IL_749:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1178927104;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_736;
							EndFinally_32:;
						}
						goto IL_7A2;
						IL_D6F:
						int num7;
						num7++;
						num = (short)1468071958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_266;
					case 26:
						enumerator = e.NewItems.GetEnumerator();
						num = (short)358416395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_7A2;
					case 28:
						goto IL_CAF;
					case 29:
						return;
					case 30:
						num6 = e.OldStartingIndex;
						num = (short)785252377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
					IL_266:
					num = (short)564396037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_521:
					((global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Items[num6]).Header = recset[num6].ReferenceKey;
					((global::AcpUI.AcpTreeViewItem)acpTreeViewItem2.Items[num6]).ReferenceKey = recset[num6].ReferenceKey;
					num6++;
					num = (short)997457938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58C:
					num = (short)664862721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A2:
					num = (short)494338058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C86:
					enumerator = e.NewItems.GetEnumerator();
					num = (short)1081344024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CAF:
					num = (short)2146566148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D90:
					num = (short)1680146446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E28:
					num4--;
					num = (short)1643249679;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_5C5:
				return;
				IL_808:
				this.a(e.OldStartingIndex, e.NewStartingIndex, acpTreeViewItem2.Items, recset);
				return;
				IL_AB:
				acpTreeViewItem3 = new global::AcpUI.AcpTreeViewItem();
				num = (short)1292238867;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0003D76C File Offset: 0x0003B96C
		public global::AcpUI.AcpTreeViewItem FindChildTreeViewItem(int recsetId, int nodeId, global::System.Windows.Controls.ItemCollection items)
		{
			short num = (short)514785280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)items).GetEnumerator();
				global::AcpUI.AcpTreeViewItem result;
				try
				{
					num = (short)531038214;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
						switch (num2)
						{
						case 0:
						{
							global::AcpUI.AcpTreeViewItem acpTreeViewItem;
							if (nodeId == acpTreeViewItem.NodeId)
							{
								num = (short)1529085955;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_253;
						}
						case 1:
							goto IL_213;
						case 2:
						{
							global::AcpUI.AcpTreeViewItem acpTreeViewItem;
							if (acpTreeViewItem.Items.Count > 0)
							{
								num = (short)1205534730;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::AcpUI.AcpTreeViewItem acpTreeViewItem;
							result = acpTreeViewItem;
							num = (short)1046806529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1736245255;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpUI.AcpTreeViewItem acpTreeViewItem = (global::AcpUI.AcpTreeViewItem)enumerator.Current;
							num = (short)2110652424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							num = (short)658432759;
							short num3 = num;
							num = (short)147972855;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1B2;
							default:
								goto IL_104;
							}
							break;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_B3;
							}
							continue;
						case 7:
							num = (short)677969933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::AcpUI.AcpTreeViewItem acpTreeViewItem;
							if (recsetId == acpTreeViewItem.RecsetId)
							{
								num = (short)556728331;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_253;
						}
						case 9:
							if (acpTreeViewItem2 != null)
							{
								num = (short)695402508;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 10:
						{
							global::AcpUI.AcpTreeViewItem acpTreeViewItem;
							acpTreeViewItem2 = this.FindChildTreeViewItem(recsetId, nodeId, acpTreeViewItem.Items);
							num = (short)1711996937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							num = (short)1037893632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_1B2;
						case 13:
							goto IL_2B5;
						}
						goto IL_B3;
						IL_1B2:
						result = acpTreeViewItem2;
						num = (short)1774583813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B7:
						num = (short)1215037444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B3:
						goto IL_1B7;
						IL_253:
						num = (short)1391329282;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_104:
					num = (short)748093440;
					if (num != 0)
					{
					}
					IL_213:
					return result;
					IL_2B5:
					goto IL_26;
				}
				finally
				{
					num = (short)853016577;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_2FF;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_2EC:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)65667074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (disposable != null)
							{
								num = (short)1295712256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_356;
						case 2:
							goto IL_354;
						}
						goto IL_2FF;
					}
					IL_354:
					IL_356:
					goto EndFinally_9;
					IL_2FF:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1724973057;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2EC;
					EndFinally_9:;
				}
				return result;
				IL_26:
				num = (short)2043346944;
				short num4 = num;
				return null;
			}
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0003DAF0 File Offset: 0x0003BCF0
		public global::AcpUI.AcpTreeViewItem FindChildTreeViewItem(int recsetId, int nodeId)
		{
			short num = (short)1522466816;
			short num2 = num;
			num = (short)1101229047;
			short num3 = num;
			num = (short)1443654647;
			global::AcpUI.AcpTreeViewItem acpTreeViewItem;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)855310336;
				if (num != 0)
				{
				}
				num = (short)1983053824;
				int num4 = (int)num;
				switch (num4)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_B8;
					}
					for (;;)
					{
						IL_9D:
						global::System.Collections.IEnumerator enumerator;
						switch (num4)
						{
						case 0:
							if (!this.RootNodes.TryGetValue(recsetId, out acpTreeViewItem))
							{
								num = (short)53411841;
								if (num != 0)
								{
								}
								num = (short)482213889;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1043726339;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_122;
						case 2:
							try
							{
								num = (short)215154690;
								num4 = (int)((global::System.IntPtr)num);
								global::AcpUI.AcpTreeViewItem result;
								for (;;)
								{
									switch (num4)
									{
									case 0:
										goto IL_182;
									case 1:
									{
										global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
										result = acpTreeViewItem2;
										num = (short)1195114496;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_169;
										}
										continue;
									case 3:
									{
										global::AcpUI.AcpTreeViewItem acpTreeViewItem2;
										if (acpTreeViewItem2.NodeId == nodeId)
										{
											num = (short)1676541953;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1242824710;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpUI.AcpTreeViewItem acpTreeViewItem2 = (global::AcpUI.AcpTreeViewItem)enumerator.Current;
										num = (short)501219331;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_220;
									case 6:
										num = (short)1393623045;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1CE:
									num = (short)1664548868;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_169:
									goto IL_1CE;
								}
								IL_182:
								return result;
								IL_220:
								goto IL_303;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_242;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_22F:
									switch (num4)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1059717121;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_299;
									case 1:
										disposable.Dispose();
										num = (short)1765539842;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_297;
									}
									goto IL_242;
								}
								IL_297:
								IL_299:
								goto EndFinally_8;
								IL_242:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)2043543552;
								num4 = (int)((global::System.IntPtr)num);
								goto IL_22F;
								EndFinally_8:;
							}
							goto IL_29A;
						case 3:
							if (acpTreeViewItem.Items.Count == 0)
							{
								num = (short)119668740;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29A;
						case 4:
							return acpTreeViewItem;
						}
						goto IL_B8;
						IL_29A:
						enumerator = ((global::System.Collections.IEnumerable)acpTreeViewItem.Items).GetEnumerator();
						num = (short)279183362;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_122:
					return null;
					IL_303:
					return null;
					IL_B8:
					acpTreeViewItem = null;
					num = (short)1998127104;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_9D;
				}
				break;
			}
			}
			return acpTreeViewItem;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0003DE18 File Offset: 0x0003C018
		public void OnReferenceKeyChanged(global::AcpCommonLib.IAcpFeatureNode node, global::System.Windows.Controls.TreeView MyTreeView)
		{
			short num = (short)807982973;
			short num2 = num;
			num = (short)667080573;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1850540032;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7E;
				}
				break;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset parent;
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					return;
				case 1:
				{
					global::AcpUI.AcpTreeViewItem acpTreeViewItem;
					acpTreeViewItem.ReferenceKey = node.ReferenceKey;
					num = (short)2138570752;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)2026045440;
					short num4 = num;
					if (parent.HasKeyField)
					{
						num = (short)480116737;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					num = (short)1271726081;
					if (num != 0)
					{
					}
					global::AcpUI.AcpTreeViewItem acpTreeViewItem = this.FindChildTreeViewItem(parent.RecsetId, node.NodeId, MyTreeView.Items);
					num = (short)1712324615;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (parent != null)
					{
						num = (short)249888771;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (node.ReferenceKey != "")
					{
						num = (short)125632518;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
				{
					global::AcpUI.AcpTreeViewItem acpTreeViewItem;
					acpTreeViewItem.Header = node.ReferenceKey;
					num = (short)1231749122;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					global::AcpUI.AcpTreeViewItem acpTreeViewItem;
					if (acpTreeViewItem != null)
					{
						num = (short)1866989576;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 8:
					num = (short)169869317;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_7E;
			}
			return;
			IL_7E:
			parent = node.Parent;
			num = (short)938082308;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0003E044 File Offset: 0x0003C244
		public virtual bool UpdateTreeView(int nRecsetID)
		{
			short num = (short)605749248;
			short num2 = num;
			num = (short)1534210248;
			short num3 = num;
			num = (short)1179988168;
			switch (num3 == num)
			{
			}
			num = (short)816119808;
			if (num != 0)
			{
			}
			num = (short)246218753;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0003E0F0 File Offset: 0x0003C2F0
		public void NavigateToContentPage(global::System.Windows.Controls.TreeView MyTreeView)
		{
			short num;
			global::AcpCommonLib.IAcpRecordset acpRecordset;
			for (;;)
			{
				IL_00:
				num = (short)854065152;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					global::AcpUI.AcpTreeViewItem acpTreeViewItem;
					string text;
					for (;;)
					{
						IL_29:
						switch (num2)
						{
						case 0:
							if (this.a == null)
							{
								num = (short)1365639190;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_208;
						case 1:
							if (acpTreeViewItem != null)
							{
								num = (short)360972292;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							goto IL_411;
						case 3:
							goto IL_208;
						case 4:
						{
							num = (short)685861483;
							short num3 = num;
							num = (short)1484155499;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1397686272;
								if (num != 0)
								{
								}
								acpRecordset = null;
								num = (short)46923804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)1739653145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 6:
							goto IL_514;
						case 7:
							goto IL_45B;
						case 8:
							if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
							{
								num = (short)417923095;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_208;
						case 9:
							return;
						case 10:
							if (!acpRecordset.SingleInstance)
							{
								num = (short)1531838482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_28B;
						case 11:
							if (acpRecordset == null)
							{
								num = (short)2039283721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)574619658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView((global::AcpBusinessLayer.Recordset)this.a.Parent)).MoveCurrentTo(this.a);
							num = (short)894959618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (!acpRecordset.SingleInstance)
							{
								num = (short)1072627733;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_514;
						case 14:
							acpRecordset = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(acpTreeViewItem.RecsetId);
							num = (short)1957232670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (acpTreeViewItem.NodeId == 0)
							{
								num = (short)1848573972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_514;
						case 16:
							goto IL_39D;
						case 17:
							num = (short)1563164685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							num = (short)813891603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							if (acpTreeViewItem.NodeId != 0)
							{
								num = (short)1820000282;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_28B;
						case 20:
							num = (short)950861848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							num = (short)1800208399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							this.a = acpRecordset[0];
							text = this.a.UIPagePath;
							num = (short)1984167939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							num = (short)1288437760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							if (!acpRecordset.HideRecordsFromTree)
							{
								num = (short)257228816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_514;
						case 25:
							this.c = true;
							global::AcpUI.DragDrop.DragDropManager.TreeNavigationStart();
							num = (short)361824283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = acpRecordset.NodeFromId(acpTreeViewItem.NodeId);
							text = acpFeatureNode.UIPagePath;
							this.a = acpFeatureNode;
							num = (short)1727987741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 27:
							if (this.a != null)
							{
								num = (short)400818188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_411;
						case 28:
							if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
							{
								num = (short)624361486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(acpTreeViewItem.RecsetId);
							num = (short)1296302086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							goto IL_208;
						case 30:
							if (acpRecordset != null)
							{
								num = (short)1347551249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_514;
						}
						break;
						IL_208:
						num = (short)1620574213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_28B:
						text = acpRecordset.UIPagePath;
						this.a = null;
						num = (short)460390408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_411:
						this.LaunchPage(text);
						num = (short)477429760;
						short num4 = num;
						num = (short)1515585543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_514:
						num = (short)343998475;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_AC:
					acpTreeViewItem = (global::AcpUI.AcpTreeViewItem)MyTreeView.SelectedItem;
					text = null;
					num = (short)55836673;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
			}
			IL_39D:
			num = (short)834600961;
			if (num != 0)
			{
			}
			acpRecordset = null;
			return;
			IL_45B:;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0003E6BC File Offset: 0x0003C8BC
		public void LaunchSection(global::AcpCommonLib.IAcpFeatureSection section)
		{
			short num = (short)1154154498;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
				{
					global::AcpCommonLib.IAcpRecordset parentRecset;
					if (parentRecset.IsEmbeddedRecset)
					{
						num = (short)648085507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)62455617;
					short num3 = num;
					num = (short)395181889;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E4;
					default:
						num = (short)405995520;
						if (num != 0)
						{
						}
						this.a = section.Parent;
						num = (short)243466255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_327;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 3:
				{
					num = (short)26279937;
					if (num != 0)
					{
					}
					global::AcpCommonLib.IAcpRecordset parentRecset;
					this.a = parentRecset.ParentSection.Parent;
					goto IL_2E4;
				}
				case 4:
					num = (short)1328545792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1F7;
				case 6:
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)2055733261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
				{
					global::AcpCommonLib.IAcpRecordset parentRecset = section.ParentRecset;
					text = null;
					num = (short)935526412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_1F7;
				case 9:
					goto IL_23F;
				case 10:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView((global::AcpBusinessLayer.Recordset)this.a.Parent)).MoveCurrentTo(this.a);
					num = (short)1014497289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (this.a != null)
					{
						num = (short)940900362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23F;
				case 12:
				{
					global::AcpCommonLib.IAcpRecordset parentRecset;
					if (!parentRecset.SingleInstance)
					{
						num = (short)1683750916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = parentRecset.UIPagePath;
					this.a = parentRecset[0];
					num = (short)853737480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					this.c = true;
					global::AcpUI.DragDrop.DragDropManager.TreeNavigationStart();
					num = (short)1029570571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					return;
				case 15:
					goto IL_327;
				}
				IL_66:
				if (!this.c)
				{
					num = (short)246743047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1F7:
				this.sectionToLaunch = section;
				num = (short)1138294790;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23F:
				this.LaunchPage(text);
				num = (short)1634926606;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E4:
				num = (short)1723858944;
				short num4 = num;
				num = (short)2109800449;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_327:
				text = this.a.UIPagePath;
				num = (short)1726611461;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		public virtual void LaunchPage(string pageUri)
		{
			short num = (short)1440546816;
			short num2 = num;
			num = (short)759884253;
			short num3 = num;
			num = (short)2073160157;
			switch (num3 == num)
			{
			}
			num = (short)1279787009;
			if (num != 0)
			{
			}
			num = (short)1601699840;
			if (num != 0)
			{
			}
			this.OnLoadComplete(null);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0003EACC File Offset: 0x0003CCCC
		public void OnLoadComplete(global::System.Windows.Controls.Frame frmCenter)
		{
			short num = (short)1874984960;
			short num2 = num;
			num = (short)112078846;
			short num3 = num;
			num = (short)814690302;
			switch (num3 == num)
			{
			}
			num = (short)41091072;
			if (num != 0)
			{
			}
			num = (short)2042691585;
			if (num != 0)
			{
			}
			this.c = false;
			global::AcpUI.DragDrop.DragDropManager.TreeNavigationStop();
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0003EB88 File Offset: 0x0003CD88
		// (set) Token: 0x06000396 RID: 918 RVA: 0x0003EC38 File Offset: 0x0003CE38
		public global::AcpCommonLib.IAcpFeatureNode CurrentRecord
		{
			get
			{
				short num = (short)919928832;
				short num2 = num;
				num = (short)1361093154;
				short num3 = num;
				num = (short)236102178;
				switch (num3 == num)
				{
				}
				num = (short)1039663105;
				if (num != 0)
				{
				}
				num = (short)1693908992;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1028325376;
				short num2 = num;
				num = (short)292007397;
				short num3 = num;
				num = (short)348827109;
				switch (num3 == num)
				{
				}
				num = (short)1346371585;
				if (num != 0)
				{
				}
				num = (short)139198464;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0003ECE8 File Offset: 0x0003CEE8
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)1061763343;
			short num2 = num;
			num = (short)1810577679;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1182400513;
				if (num != 0)
				{
				}
				num = (short)1654849536;
				if (num != 0)
				{
				}
				if (e.Key != global::System.Windows.Input.Key.F5)
				{
					num = (short)721223680;
					short num3 = num;
					base.OnKeyDown(e);
					return;
				}
				break;
			}
			e.Handled = true;
		}

		// Token: 0x04000222 RID: 546
		private global::AcpCommonLib.IAcpFeatureNode a;

		// Token: 0x04000223 RID: 547
		private global::System.Collections.Generic.Dictionary<int, global::AcpUI.AcpTreeViewItem> b = new global::System.Collections.Generic.Dictionary<int, global::AcpUI.AcpTreeViewItem>();

		// Token: 0x04000224 RID: 548
		private bool c;

		// Token: 0x04000225 RID: 549
		private bool d;

		// Token: 0x04000226 RID: 550
		protected global::AcpCommonLib.IAcpFeatureSection sectionToLaunch;
	}
}
