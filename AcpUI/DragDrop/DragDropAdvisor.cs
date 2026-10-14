using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUI.Common;
using AcpUtility;
using Infragistics.Windows.DataPresenter;

namespace AcpUI.DragDrop
{
	// Token: 0x02000062 RID: 98
	public class DragDropAdvisor : global::AcpUI.DragDrop.IDragSourceAdvisor, global::AcpUI.DragDrop.IDropTargetAdvisor
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x000639E8 File Offset: 0x00061BE8
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00063A98 File Offset: 0x00061C98
		public global::System.Windows.UIElement SourceUI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1285357568;
				short num2 = num;
				num = (short)576716036;
				short num3 = num;
				num = (short)1732246788;
				switch (num3 == num)
				{
				}
				num = (short)1111752705;
				if (num != 0)
				{
				}
				num = (short)976420864;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)434241536;
				short num2 = num;
				num = (short)798339304;
				short num3 = num;
				num = (short)1455141096;
				switch (num3 == num)
				{
				}
				num = (short)777191425;
				if (num != 0)
				{
				}
				num = (short)1040121856;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00063B4C File Offset: 0x00061D4C
		public global::System.Windows.DragDropEffects SupportedEffects
		{
			get
			{
				short num = (short)1346502656;
				short num2 = num;
				num = (short)2063241059;
				short num3 = num;
				num = (short)480087907;
				switch (num3 == num)
				{
				}
				num = (short)350617600;
				if (num != 0)
				{
				}
				num = (short)322764801;
				if (num != 0)
				{
				}
				return this.a(this.SourceUI, null);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00063C00 File Offset: 0x00061E00
		public bool IsDropAllowed(global::System.Windows.DragEventArgs dragData)
		{
			int a_ = 8;
			global::System.Collections.Generic.Dictionary<string, object> a_2 = (global::System.Collections.Generic.Dictionary<string, object>)dragData.Data.GetData(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab節슯ힱ톳\ud9b7캹\uddbb", a_));
			if (this.a(this.ConsumerNode, a_2) == global::System.Windows.DragDropEffects.None)
			{
				short num = (short)1298866044;
				short num2 = num;
				num = (short)440999804;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)802816001;
					if (num != 0)
					{
					}
					num = (short)1143209984;
					short num3 = num;
					num = (short)1855979520;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00063CEC File Offset: 0x00061EEC
		private global::System.Windows.DragDropEffects a(global::System.Windows.UIElement A_0, global::System.Collections.Generic.Dictionary<string, object> A_1)
		{
			short num = (short)1167785984;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpUI.AcpTreeView acpTreeView;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_18A;
				case 2:
					goto IL_106;
				case 3:
				{
					num = (short)255910671;
					short num3 = num;
					num = (short)1773658895;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)102498304;
						if (num != 0)
						{
						}
						num = (short)1969881089;
						if (num != 0)
						{
						}
						if (A_0 is global::AcpUI.AcpTreeViewItem)
						{
							num = (short)656801794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::System.Windows.DragDropEffects.Copy | global::System.Windows.DragDropEffects.Move;
					}
					break;
				}
				case 4:
					acpTreeView = (A_0 as global::AcpUI.AcpTreeView);
					num = (short)1330970629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1065746432;
					short num4 = num;
					if (acpTreeView.SelectedItem is global::AcpUI.AcpTreeViewItem)
					{
						num = (short)488374273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::System.Windows.DragDropEffects.Copy | global::System.Windows.DragDropEffects.Move;
				}
				}
				IL_3D:
				if (A_0 is global::AcpUI.AcpTreeView)
				{
					num = (short)742588420;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1202847747;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_106:
			return this.a(A_0 as global::AcpUI.AcpTreeViewItem, A_1);
			IL_18A:
			return this.a(acpTreeView.SelectedItem as global::AcpUI.AcpTreeViewItem, A_1);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00063E98 File Offset: 0x00062098
		private global::System.Windows.DragDropEffects a(global::AcpUI.AcpTreeViewItem A_0, global::System.Collections.Generic.Dictionary<string, object> A_1)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			global::System.Collections.Generic.Dictionary<string, object> dictionary;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (dictionary[global::AcpUI.Common.Utility.c("鮨鮪颬麮", a_)] is global::AcpCommonLib.IAcpRecordset)
					{
						num2 = (short)1957888001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)377602644;
					short num3 = num2;
					num2 = (short)686867028;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_186;
					default:
						num2 = (short)2109669376;
						if (num2 != 0)
						{
						}
						num2 = (short)1598554115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)561184769;
					if (num2 != 0)
					{
					}
					num2 = (short)1878196234;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)2003304453;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (dictionary[global::AcpUI.Common.Utility.c("鮨鮪颬麮", a_)] is global::AcpCommonLib.IAcpFeatureNode)
					{
						num2 = (short)193724418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::System.Windows.DragDropEffects.Copy | global::System.Windows.DragDropEffects.Move;
				case 4:
					return global::System.Windows.DragDropEffects.None;
				case 5:
					if (global::AcpUI.DragDrop.DragDropEffectsUtilitie.IsZoneDragDropDisble(dictionary[global::AcpUI.Common.Utility.c("鮨鮪颬麮", a_)] as global::AcpCommonLib.IAcpFeatureNode))
					{
						num2 = (short)133758980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::System.Windows.DragDropEffects.Copy | global::System.Windows.DragDropEffects.Move;
				case 6:
					if (dictionary.ContainsKey(global::AcpUI.Common.Utility.c("鮨鮪颬麮", a_)))
					{
						num2 = (short)725483529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::System.Windows.DragDropEffects.Copy | global::System.Windows.DragDropEffects.Move;
				case 7:
					goto IL_186;
				case 8:
					return global::System.Windows.DragDropEffects.None;
				case 9:
				{
					num2 = (short)154075136;
					short num4 = num2;
					num2 = (short)1370357760;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (global::AcpUI.DragDrop.DragDropEffectsUtilitie.IsZoneChannelAssignmentRecsetDragDropDisable(dictionary[global::AcpUI.Common.Utility.c("鮨鮪颬麮", a_)] as global::AcpCommonLib.IAcpRecordset, A_1))
					{
						num2 = (short)328663048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::System.Windows.DragDropEffects.Copy | global::System.Windows.DragDropEffects.Move;
				case 11:
					if (dictionary != null)
					{
						num2 = (short)1759444999;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::System.Windows.DragDropEffects.Copy | global::System.Windows.DragDropEffects.Move;
				}
				goto IL_49;
				IL_186:
				num2 = (short)552271878;
				num = (int)((global::System.IntPtr)num2);
			}
			return global::System.Windows.DragDropEffects.None;
			IL_49:
			dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			global::System.Collections.Generic.SortedDictionary<int, int> a_2 = new global::System.Collections.Generic.SortedDictionary<int, int>();
			this.a(dictionary, a_2, A_0);
			num2 = (short)672989195;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00064178 File Offset: 0x00062378
		private void a(global::System.Collections.Generic.Dictionary<string, object> A_0, global::System.Collections.Generic.SortedDictionary<int, int> A_1, global::AcpUI.AcpTreeViewItem A_2)
		{
			short num = (short)1315569664;
			switch (num)
			{
			default:
			{
				num = (short)1111425028;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int recsetId;
					int count;
					int nodeId;
					switch (num2)
					{
					case 0:
						if (A_2.NodeId != 0)
						{
							num = (short)626458643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CC;
					case 1:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetId);
						num = (short)2112356372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_382;
					case 3:
						goto IL_382;
					case 4:
						num = (short)668794881;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_E0;
						}
						continue;
					case 5:
						return;
					case 6:
						goto IL_342;
					case 7:
						goto IL_33D;
					case 8:
					{
						global::System.Windows.Controls.ItemCollection items = A_2.Items;
						items.MoveCurrentToFirst();
						int num3 = 0;
						num = (short)1828388880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (recsetId != 0)
						{
							num = (short)1874132992;
							short num4 = num;
							num = (short)67108871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (A_2.NodeId != 0)
						{
							num = (short)866254854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18B;
					case 11:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						A_1.Add(feature.DataTransferOrder, recsetId);
						num = (short)1139671045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						feature.CalculateVisibility(true);
						num = (short)1539899417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (recsetId != -1)
						{
							num = (short)749862933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						if (count > 0)
						{
							num = (short)964296712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CC;
					case 15:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.DataTransferOrder > 0)
						{
							num = (short)1249574923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 16:
						goto IL_49F;
					case 17:
						goto IL_2CC;
					case 18:
						if (A_2.RecsetId == 0)
						{
							num = (short)362479639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_342;
					case 19:
						goto IL_18B;
					case 20:
					{
						if (nodeId == 0)
						{
							num = (short)1266286604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature;
						feature.NodeFromId(nodeId).CalculateVisibility(true);
						A_0.Add(recsetId.ToString(global::System.Globalization.CultureInfo.InvariantCulture), feature.NodeFromId(nodeId));
						num = (short)1439891458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						num = (short)704691839;
						short num5 = num;
						num = (short)246857343;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33D;
						default:
							num = (short)2089091072;
							if (num != 0)
							{
							}
							num = (short)1659764763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
					{
						int num3;
						if (num3 >= count)
						{
							num = (short)862650385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.ItemCollection items;
						global::AcpUI.AcpTreeViewItem a_ = (global::AcpUI.AcpTreeViewItem)items.CurrentItem;
						items.MoveCurrentToNext();
						this.a(A_0, A_1, a_);
						num3++;
						num = (short)988217370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)109051914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						A_0.Add(recsetId.ToString(global::System.Globalization.CultureInfo.InvariantCulture), feature);
						num = (short)400424963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (!feature.HiddenStatic)
						{
							num = (short)1448869912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_382;
					}
					case 26:
						goto IL_49F;
					case 27:
						if (!A_0.ContainsKey(recsetId.ToString(global::System.Globalization.CultureInfo.InvariantCulture)))
						{
							num = (short)1008795649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 28:
						num = (short)885653522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E0:
					if (A_2 != null)
					{
						num = (short)451018780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_18B:
					count = A_2.Items.Count;
					num = (short)1246035982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CC:
					recsetId = A_2.RecsetId;
					nodeId = A_2.NodeId;
					num = (short)606470153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33D:
					num = (short)1120010253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_342:
					num = (short)1974730752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_382:
					num = (short)1824849935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49F:
					num = (short)92078102;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000646F8 File Offset: 0x000628F8
		public global::System.Windows.DataObject GetDataObject(global::System.Windows.UIElement draggedElement)
		{
			int a_ = 8;
			short num = (short)99493836;
			short num2 = num;
			num = (short)659302348;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F5:
				num = (short)713490438;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)258998272;
				if (num != 0)
				{
				}
				num = (short)1829240832;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_C9;
					}
					break;
				}
				break;
			}
			global::System.Windows.DataObject dataObject;
			global::System.Collections.Generic.Dictionary<string, object> dictionary;
			global::AcpUI.AcpTreeViewItem acpTreeViewItem;
			global::System.Collections.Generic.Dictionary<string, object> dictionary2;
			global::System.Collections.Generic.SortedDictionary<int, int> sortedDictionary;
			for (;;)
			{
				num = (short)1302986752;
				short num4 = num;
				switch (num3)
				{
				case 0:
					return dataObject;
				case 1:
					num = (short)1349976069;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					object versionObj;
					dataObject.SetData(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab햯삱잳\udfb5ힷ풹\udfbd뒿ꏁ", a_), versionObj);
					num = (short)1746862080;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					dictionary.Add(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab\udfaf횱톳ﺵ\uddb7\udbb9\ud8bb\udbbd늿", a_), acpTreeViewItem.Header.ToString());
					dictionary.Add(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab\udfaf횱톳\uddb7\ud9b9쾻\udbbd뒿证胃", a_), acpTreeViewItem.RecsetId);
					dictionary.Add(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab\udfaf횱톳ힷ\udeb9\ud9bb蒿", a_), acpTreeViewItem.NodeId);
					dictionary.Add(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab\udfaf횱톳\uddb7\udcb9\ud9bb첽ꖿ곁ꟃꏅ菇꿉뗋", a_), acpTreeViewItem.ReferenceKey);
					this.a(dictionary2, sortedDictionary, acpTreeViewItem);
					dictionary2.Add(global::AcpUI.Common.Utility.c("튝즟톡킣캧즫춭쎯ힱ삳억", a_), sortedDictionary);
					dataObject.SetData(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab節슯ힱ톳\ud9b7캹\uddbb", a_), dictionary);
					dataObject.SetData(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab톯욱햳", a_), dictionary2);
					dataObject.SetData(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab삯슱\ud8b3\udfb5\udbb7\udbb9좻ힽ꾿곁裃Ʂꛇ귉맋꿍럏럑", a_), global::AcpCommonLib.AppInfoManager.DndVersionManager.GetApplicationLanguage());
					object versionObj = global::AcpCommonLib.AppInfoManager.DndVersionManager.GetVersionObj();
					num = (short)275251204;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					object versionObj;
					if (versionObj != null)
					{
						num = (short)1188823042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return dataObject;
				}
				case 5:
					num = (short)1002504193;
					if (num != 0)
					{
					}
					if (acpTreeViewItem.HasHeader)
					{
						num = (short)1988952067;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FE;
				case 6:
					if (acpTreeViewItem != null)
					{
						num = (short)1264582657;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FE;
				}
				goto IL_C9;
			}
			return dataObject;
			IL_2FE:
			dataObject.SetData(global::System.Windows.DataFormats.Text, global::AcpUI.Common.Utility.c("킝芡ﲧ", a_));
			return dataObject;
			IL_C9:
			global::AcpCommonLib.AppInfoManager.DndOperation = true;
			global::AcpCommonLib.AppInfoManager.DragOperation = true;
			dataObject = new global::System.Windows.DataObject();
			dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary2 = new global::System.Collections.Generic.Dictionary<string, object>();
			sortedDictionary = new global::System.Collections.Generic.SortedDictionary<int, int>();
			acpTreeViewItem = (draggedElement as global::AcpUI.AcpTreeViewItem);
			goto IL_F5;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00064A20 File Offset: 0x00062C20
		public void FinishDrag(global::System.Windows.UIElement draggedElement, global::System.Windows.DragDropEffects finalEffects)
		{
			short num = (short)1017643079;
			short num2 = num;
			num = (short)956694599;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1280966656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)140181504;
			if (num != 0)
			{
			}
			num = (short)1248002049;
			if (num != 0)
			{
			}
			global::AcpCommonLib.AppInfoManager.DndOperation = false;
			global::AcpCommonLib.AppInfoManager.DragOperation = false;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00064AD8 File Offset: 0x00062CD8
		public bool IsDraggable(global::System.Windows.UIElement dragElement)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			bool result;
			short num2;
			global::AcpUI.AcpTreeViewItem acpTreeViewItem;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return result;
				case 1:
					num2 = (short)763035653;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_107;
				case 3:
					num2 = (short)770375684;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (acpTreeViewItem.NodeId != -1)
					{
						num2 = (short)1000144898;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					if (acpTreeViewItem.RecsetId == -1)
					{
						num2 = (short)157089795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_107;
				case 6:
					goto IL_BE;
				}
				goto IL_2C;
				IL_107:
				result = true;
				num2 = (short)821428224;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BE:
			if (acpTreeViewItem != null)
			{
				goto IL_C4;
			}
			return result;
			IL_2C:
			result = false;
			acpTreeViewItem = this.a(dragElement);
			num2 = (short)2051105749;
			short num3 = num2;
			num2 = (short)1469080533;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C4:
				num2 = (short)1039728640;
				short num4 = num2;
				num2 = (short)77594625;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1541537793;
				if (num2 != 0)
				{
				}
				num2 = (short)580976640;
				if (num2 != 0)
				{
				}
				num2 = (short)899743750;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00064C80 File Offset: 0x00062E80
		private bool b(object A_0)
		{
			bool result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				short num2;
				global::System.Windows.DependencyObject dependencyObject;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)538640384;
						short num3 = num2;
						global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
						num2 = (short)1676607491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
					{
						global::System.Windows.DependencyObject parent;
						result = this.b(parent);
						num2 = (short)580124676;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
					{
						global::System.Windows.DependencyObject parent;
						if (parent == null)
						{
							return result;
						}
						num2 = (short)1857053873;
						short num4 = num2;
						num2 = (short)1966957745;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)662110208;
							if (num2 != 0)
							{
							}
							num2 = (short)1985282049;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						if (dependencyObject is global::Infragistics.Windows.DataPresenter.RecordSelector)
						{
							num2 = (short)1461321729;
							if (num2 != 0)
							{
							}
							num2 = (short)956956678;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1791033346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						return result;
					case 5:
						return result;
					case 6:
						result = true;
						num2 = (short)1575944197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (dependencyObject != null)
						{
							num2 = (short)1725825024;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				IL_30:
				result = false;
				dependencyObject = (A_0 as global::System.Windows.DependencyObject);
				num2 = (short)1546584071;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00064E54 File Offset: 0x00063054
		private global::AcpUI.AcpTreeViewItem a(object A_0)
		{
			short num = (short)1721499648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::System.Windows.DependencyObject dependencyObject;
				global::AcpUI.AcpTreeViewItem result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)1509228544;
						short num3 = num;
						global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
						global::AcpUI.AcpTreeViewItem acpTreeViewItem = dependencyObject as global::AcpUI.AcpTreeViewItem;
						num = (short)944242691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1819437051;
						short num4 = num;
						num = (short)888760315;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D8;
						default:
						{
							num = (short)1781661696;
							if (num != 0)
							{
							}
							global::System.Windows.DependencyObject parent;
							result = this.a(parent);
							num = (short)1046806532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						global::System.Windows.DependencyObject parent;
						if (parent != null)
						{
							goto IL_D8;
						}
						return result;
					}
					case 3:
					{
						global::AcpUI.AcpTreeViewItem acpTreeViewItem;
						if (acpTreeViewItem != null)
						{
							num = (short)1442381830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)667942914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return result;
					case 5:
						goto IL_15B;
					case 6:
					{
						global::AcpUI.AcpTreeViewItem acpTreeViewItem;
						result = acpTreeViewItem;
						num = (short)2015821829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (dependencyObject != null)
						{
							num = (short)371982336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_4F;
					IL_D8:
					num = (short)382926849;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15B:
				num = (short)615383041;
				if (num != 0)
				{
				}
				return result;
				IL_4F:
				result = null;
				dependencyObject = (A_0 as global::System.Windows.DependencyObject);
				num = (short)854917127;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00065054 File Offset: 0x00063254
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00065104 File Offset: 0x00063304
		public global::System.Windows.UIElement TargetUI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)372800490;
				short num2 = num;
				num = (short)2140044266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2103967744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1389166593;
				if (num != 0)
				{
				}
				num = (short)382271488;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)722302486;
				short num2 = num;
				num = (short)1925215766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1887240192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)904396801;
				if (num != 0)
				{
				}
				num = (short)1446379520;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x000651B4 File Offset: 0x000633B4
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00065264 File Offset: 0x00063464
		public global::AcpUI.AcpTreeViewItem ConsumerNode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1353597601;
				short num2 = num;
				num = (short)32719521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)16384000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)584974337;
				if (num != 0)
				{
				}
				num = (short)1626537984;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1835597825;
				if (num != 0)
				{
				}
				num = (short)393805824;
				short num2 = num;
				num = (short)750742791;
				short num3 = num;
				num = (short)349269255;
				switch (num3 == num)
				{
				}
				num = (short)1602224128;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00065314 File Offset: 0x00063514
		public bool IsDropAllowedByApp(global::System.Windows.IDataObject obj)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			object obj2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_136;
				case 1:
					num2 = (short)7274497;
					if (num2 != 0)
					{
					}
					obj2 = obj.GetData(global::AcpUI.Common.Utility.c("\ud8a9쎫쪭얯톱톳쒵\udfb9캻춽ꦿ귁꫃苅꧇뻉귋", a_));
					num2 = (short)177668096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)760506975;
					short num3 = num2;
					num2 = (short)1782016607;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1065549824;
						if (num2 != 0)
						{
						}
						num2 = (short)1561788416;
						short num4 = num2;
						if (!obj.GetDataPresent(global::AcpUI.Common.Utility.c("\ud8a9쎫쪭얯톱톳쒵\udfb9캻춽ꦿ귁꫃苅꧇뻉귋", a_)))
						{
							return true;
						}
						break;
					}
					}
					num2 = (short)368836609;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_25;
			}
			return true;
			IL_136:
			object versionObj = global::AcpCommonLib.AppInfoManager.DndVersionManager.GetVersionObj();
			bool result = global::AcpCommonLib.AppInfoManager.DndVersionManager.IsDropAllowedByApp(obj2, versionObj);
			global::AcpCommonLib.AppInfoManager.ProducerVersion = (int)obj2;
			return result;
			IL_25:
			obj2 = null;
			num2 = (short)561119234;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0006547C File Offset: 0x0006367C
		public bool IsDropAllowedByLocalApp(global::System.Windows.IDataObject obj)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			object producerObj;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_158;
				case 1:
				{
					num2 = (short)1617208989;
					short num3 = num2;
					num2 = (short)1833674397;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)640483328;
						if (num2 != 0)
						{
						}
						producerObj = obj.GetData(global::AcpUI.Common.Utility.c("욕쎟잡횣춧\ud8a9\udfab잭\udfaf\udcb1ힵ첷\udbb9", a_));
						num2 = (short)1662713856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_129;
				case 3:
					if (obj.GetDataPresent(global::AcpUI.Common.Utility.c("욕쎟잡횣춧\ud8a9\udfab잭\udfaf\udcb1ힵ첷\udbb9", a_)))
					{
						num2 = (short)1974337537;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					producerObj = 1;
					num2 = (short)1795489794;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
			}
			IL_129:
			IL_158:
			object versionObj = global::AcpCommonLib.AppInfoManager.DndVersionManager.GetVersionObj();
			return global::AcpCommonLib.AppInfoManager.DndVersionManager.IsDropAllowedByLocalApp(producerObj, versionObj);
			IL_29:
			producerObj = null;
			num2 = (short)1989148673;
			if (num2 != 0)
			{
			}
			num2 = (short)1314258944;
			short num4 = num2;
			num2 = (short)1542520835;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000655FC File Offset: 0x000637FC
		public bool IsDropAllowedByApplicationLanguage(global::System.Windows.IDataObject obj)
		{
			int a_ = 5;
			short num = (short)844955651;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return true;
				case 1:
					goto IL_E9;
				case 2:
					if (text == null)
					{
						num = (short)1165688832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12A;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				global::System.Globalization.CultureInfo cultureInfo = obj.GetData(global::AcpUI.Common.Utility.c("쮚얠횢욤슦\udba8\uddac\udfae\uddb0\udab2횴횶춸튺튼톾跀ꋂꯄꃆ볈꫊꫌꫎", a_)) as global::System.Globalization.CultureInfo;
				string text2;
				if (cultureInfo == null)
				{
					num = (short)662886612;
					short num3 = num;
					num = (short)1409538260;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E9;
					default:
					{
						num = (short)1273495552;
						if (num != 0)
						{
						}
						num = (short)903872512;
						short num4 = num;
						num = (short)1166802945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
				}
				else
				{
					text2 = cultureInfo.Name;
				}
				IL_EE:
				text = text2;
				num = (short)2061631490;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E9:
				text2 = null;
				goto IL_EE;
			}
			return true;
			IL_12A:
			num = (short)1379008513;
			if (num != 0)
			{
			}
			string name = global::AcpCommonLib.AppInfoManager.DndVersionManager.GetApplicationLanguage().Name;
			return text == name;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00065770 File Offset: 0x00063970
		public bool IsValidDataObject(global::System.Windows.IDataObject obj)
		{
			int a_ = 5;
			short num;
			if (!obj.GetDataPresent(global::AcpUI.Common.Utility.c("쮚얠횢욤슦\udba8ﾪ\udfac쪮풰풴쎶\ud8b8", a_)))
			{
				num = (short)1261285717;
				short num2 = num;
				num = (short)289386837;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)719847424;
					if (num != 0)
					{
					}
					num = (short)962920449;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)917438464;
			short num3 = num;
			return obj.GetDataPresent(global::AcpUI.Common.Utility.c("쮚얠횢욤슦\udba8첬\udbae킰", a_));
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00065850 File Offset: 0x00063A50
		public global::AcpUI.AcpTreeViewItem IsValidConsumerNode(object uiObj, global::System.Windows.DragEventArgs e)
		{
			int a_ = 7;
			short num = (short)385548288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C0;
				}
				global::AcpUI.AcpTreeViewItem result;
				int num4;
				int num5;
				string text;
				int num7;
				for (;;)
				{
					IL_31:
					global::System.Windows.DependencyObject dependencyObject;
					global::AcpUI.AcpTreeViewItem acpTreeViewItem;
					switch (num2)
					{
					case 0:
						num = (short)1857355791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1513685003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						num = (short)1858666500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (dependencyObject == null)
						{
							num = (short)1794703365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BA;
					case 5:
						goto IL_5EE;
					case 6:
						num = (short)887554067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1080426496;
						short num3 = num;
						goto IL_3BA;
					}
					case 8:
						return result;
					case 9:
					{
						global::System.Collections.Generic.Dictionary<string, object> dictionary = (global::System.Collections.Generic.Dictionary<string, object>)e.Data.GetData(global::AcpUI.Common.Utility.c("출캠잢키쒦첨\ud9aa怜\uddae풰횲횶춸\udaba", a_));
						object obj;
						if (dictionary.TryGetValue(global::AcpUI.Common.Utility.c("출캠잢키쒦첨\ud9aa삮햰횲튶\udab8좺\ud8bc쮾裀蟂", a_), out obj))
						{
							num4 = (int)obj;
						}
						if (dictionary.TryGetValue(global::AcpUI.Common.Utility.c("출캠잢키쒦첨\ud9aa삮햰횲﮴\ud8b6\uddb8\udeba﮾", a_), out obj))
						{
							num5 = (int)obj;
						}
						if (dictionary.TryGetValue(global::AcpUI.Common.Utility.c("출캠잢키쒦첨\ud9aa삮햰횲튶\udfb8\udeba쾼\udabe꿀ꃂꃄ賆곈닊", a_), out obj))
						{
							text = (string)obj;
						}
						if (dictionary.TryGetValue(global::AcpUI.Common.Utility.c("햜햠쾢첤풦\udda8ﮪ첬\uddae풰\uddb2솴\udcb8\ud8ba캼\udabe뗀諂ꇄ", a_), out obj))
						{
							num = (short)167247888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_185;
					}
					case 10:
						goto IL_185;
					case 11:
						if (num5 == acpTreeViewItem.NodeId)
						{
							num = (short)1158873101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 12:
						if (acpTreeViewItem.ReferenceKey != null)
						{
							goto IL_4D1;
						}
						goto IL_570;
					case 13:
						num = (short)1814364190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)900530177;
						if (num != 0)
						{
						}
						num = (short)1199460463;
						short num6 = num;
						num = (short)250564719;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D1;
						default:
							num = (short)2084175872;
							if (num != 0)
							{
							}
							num = (short)1568210968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						if (acpTreeViewItem.NodeId == 0)
						{
							num = (short)1353777184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 16:
					{
						object obj;
						num7 = (int)obj;
						num = (short)1310261258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (num5 == 0)
						{
							num = (short)1022623745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2136211476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						result = acpTreeViewItem;
						num = (short)1649344520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (num4 == acpTreeViewItem.RecsetId)
						{
							num = (short)1905524750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 20:
						if (text != null)
						{
							num = (short)917897244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_570;
					case 21:
						if (dependencyObject is global::System.Windows.Controls.TextBlock)
						{
							num = (short)1982267399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 22:
						num = (short)396558353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						acpTreeViewItem = (global::AcpUI.AcpTreeViewItem)dependencyObject;
						num = (short)1541275674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (!string.Equals(text, acpTreeViewItem.ReferenceKey, global::System.StringComparison.CurrentCulture))
						{
							num = (short)1078460416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48C;
					case 25:
						if (!(dependencyObject is global::AcpUI.AcpTreeViewItem))
						{
							num = (short)1410727939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EE;
					case 26:
						if (num7 == -1)
						{
							num = (short)1818755094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 27:
						if (dependencyObject != null)
						{
							num = (short)21037079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 28:
						num = (short)393478156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						result = acpTreeViewItem;
						num = (short)1496317985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (num4 == acpTreeViewItem.RecsetId)
						{
							num = (short)858980381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 31:
						if (num4 == acpTreeViewItem.RecsetId)
						{
							num = (short)176750610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 32:
						goto IL_48C;
					case 33:
						return result;
					}
					goto IL_C0;
					IL_185:
					global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)uiObj;
					global::System.Windows.Point position = e.GetPosition(uielement);
					dependencyObject = (global::System.Windows.DependencyObject)uielement.InputHitTest(position);
					num = (short)2140798997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BA:
					dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
					num = (short)250150937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48C:
					result = acpTreeViewItem;
					num = (short)672268290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D1:
					num = (short)1243545606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_570:
					num = (short)103415839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EE:
					num = (short)514392091;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_C0:
				num4 = -1;
				num5 = -1;
				text = null;
				num7 = -1;
				result = null;
				num = (short)201261065;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00065F00 File Offset: 0x00064100
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1, global::AcpCommonLib.UndoRedo.ContainerTask A_2, bool A_3)
		{
			int a_ = 1;
			short num = (short)1141047296;
			switch (num)
			{
			default:
			{
				global::AcpBusinessLayer.FeatureNode featureNode = A_0 as global::AcpBusinessLayer.FeatureNode;
				global::AcpBusinessLayer.FeatureNode featureNode2 = A_1 as global::AcpBusinessLayer.FeatureNode;
				bool flag = true;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollectionByOrder.GetEnumerator();
				try
				{
					num = (short)1122762795;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpCommonLib.IAcpRecordset embeddedRecset;
						global::AcpCommonLib.IAcpRecordset embeddedRecset2;
						global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>> dictionary;
						switch (num2)
						{
						case 0:
							goto IL_8CF;
						case 1:
						{
							global::AcpBusinessLayer.FeatureSection featureSection;
							embeddedRecset = featureSection.EmbeddedRecset;
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
							embeddedRecset2 = acpFeatureSection.EmbeddedRecset;
							num = (short)81723434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (embeddedRecset2.Min != embeddedRecset2.Max)
							{
								num = (short)942342168;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1625;
						case 3:
							try
							{
								num = (short)1883897861;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_85C;
									case 1:
									{
										global::AcpBusinessLayer.FeatureNode featureNode3;
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator2 = featureNode3.KeyField.ReferencingFields.GetEnumerator();
										num = (short)1798242310;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_843;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator3;
										if (!enumerator3.MoveNext())
										{
											num = (short)750125058;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpBusinessLayer.FeatureNode featureNode3 = enumerator3.Current;
										num = (short)2101542916;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::AcpBusinessLayer.FeatureNode featureNode3;
										if (featureNode3.KeyField.ReferencingFields != null)
										{
											num = (short)234618881;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_656;
										}
										continue;
									case 6:
										try
										{
											num = (short)66912259;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 1:
													num = (short)203030530;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_7CF;
												case 3:
													switch (0)
													{
													case 0:
														goto IL_745;
													}
													continue;
												case 4:
												{
													global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1548681217;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator2.Current;
													global::AcpUI.DragDrop.DragDropAdvisor.h[acpRecRefField] = acpRecRefField.UIValue;
													num = (short)1077215232;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_747:
												num = (short)3145732;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_745:
												goto IL_747;
											}
											IL_7CF:
											break;
										}
										finally
										{
											num = (short)591265794;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator2;
												switch (num2)
												{
												case 0:
													enumerator2.Dispose();
													num = (short)1116536833;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_840;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_808;
													}
													continue;
												}
												IL_808:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)1759444992;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_840:;
										}
										goto IL_843;
									}
									IL_6CC:
									num = (short)1564540931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_656:
									goto IL_6CC;
									IL_843:
									num = (short)1653473280;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_85C:
								goto IL_223;
							}
							finally
							{
								num = (short)2097154;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator3;
									switch (num2)
									{
									case 0:
										enumerator3.Dispose();
										num = (short)986513409;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_8CC;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_893;
										}
										continue;
									}
									IL_893:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)1994850304;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_8CC:;
							}
							goto IL_8CF;
							IL_223:
							((global::AcpBusinessLayer.Recordset)embeddedRecset2).FindNewFieldsInEmbeddedRecset_DnD(embeddedRecset, dictionary);
							embeddedRecset2.ClearRecordset(embeddedRecset2, A_2);
							num = (short)1317994540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (featureNode4 != null)
							{
								num = (short)153944095;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1625;
						}
						case 5:
							num = (short)190644247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::AcpBusinessLayer.FeatureSection featureSection;
							bool hasEmbeddedRecset = featureSection.HasEmbeddedRecset;
							dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>>();
							if (hasEmbeddedRecset)
							{
								num = (short)520617985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25C;
						}
						case 7:
							if (embeddedRecset2.Count > 0)
							{
								num = (short)272367655;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_30A;
						case 8:
							num = (short)738656290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (!embeddedRecset2.HiddenStatic)
							{
								num = (short)1613758469;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25C;
						case 10:
							num = (short)95158284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)1483210765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (featureNode4.KeyField.Editable)
							{
								num = (short)953286694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1625;
						}
						case 13:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (featureNode4.KeyField != null)
							{
								num = (short)66715662;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1625;
						}
						case 14:
							num = (short)2020278322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							num = (short)1747268063;
							short num3 = num;
							num = (short)1230254559;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D5;
							default:
								num = (short)204603392;
								if (num != 0)
								{
								}
								num = (short)970915877;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							if (!A_3)
							{
								num = (short)1460338718;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_30A;
						case 17:
							if (embeddedRecset2.Min != embeddedRecset2.Max)
							{
								num = (short)556859441;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_30A;
						case 18:
							num = (short)798883847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							try
							{
								num = (short)1947467811;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										num = (short)1617428512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (((global::AcpBusinessLayer.AcpFieldBase)acpField).HiddenStatic)
										{
											num = (short)1263665185;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_13D5;
									}
									case 3:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (!acpFieldBase.Editable)
										{
											num = (short)1471741963;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)65273893;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (acpFieldBase.AllowsDataTransfer())
										{
											num = (short)809631760;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_123C;
									}
									case 5:
										num = (short)83755046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_123C;
									case 7:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (featureNode2.KeyField == acpFieldBase)
										{
											num = (short)2142109701;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_13D5;
									}
									case 8:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (!acpFieldBase.HiddenStatic)
										{
											num = (short)506331170;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
									{
										global::AcpBusinessLayer.AcpField<bool> acpField2;
										if (acpField2 != null)
										{
											num = (short)387186718;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_134F;
									}
									case 10:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										acpFieldBase.Editable = true;
										num = (short)213188626;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(acpFieldBase, global::AcpCommonResources.AcpResources.Value_Not_Copied_Uneditable_Destination, false);
										num = (short)1082785811;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										num = (short)1307443202;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (!acpField.HiddenStatic)
										{
											num = (short)904855583;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 14:
										num = (short)998703125;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 15:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(acpFieldBase, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unacceptable_Destination, false);
										num = (short)1813250077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
										goto IL_111A;
									case 17:
										num = (short)342097945;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
										goto IL_134F;
									case 20:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4;
										if (!enumerator4.MoveNext())
										{
											num = (short)724697089;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpField acpField = enumerator4.Current;
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase = acpFeatureSection[acpField.UIName] as global::AcpBusinessLayer.AcpFieldBase;
										num = (short)1244594198;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (((global::AcpBusinessLayer.AcpFieldBase)acpField).UIInvalid)
										{
											num = (short)550305798;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_121E;
									}
									case 22:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (acpFieldBase != null)
										{
											num = (short)857735185;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpField acpField;
										string message = global::AcpCommonResources.AcpResources.Cannot_Copy_Not_Exists.AcpStringFormat(new object[]
										{
											acpField.Name
										});
										global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message, false);
										num = (short)2072051712;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 23:
										try
										{
											switch (0)
											{
											case 0:
												goto IL_E8D;
											}
											global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
											global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
											for (;;)
											{
												IL_E3E:
												switch (num2)
												{
												case 0:
													if (acpRecRefField2.SlaveRecRef)
													{
														num = (short)188874768;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_F35;
												case 1:
													num = (short)1343488011;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													flag = false;
													num = (short)1204355085;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													if (acpRecRefField2.SlaveRecRef)
													{
														num = (short)1300037633;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_1036;
												case 4:
													goto IL_F35;
												case 5:
													global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(acpFieldBase, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unsupported_Value, false);
													num = (short)2100494344;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
												{
													global::AcpCommonLib.IAcpField acpField;
													A_2.AddTask(acpFieldBase.CopyValueOf(acpField));
													num = (short)290586634;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 7:
													if (flag)
													{
														num = (short)500826118;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_10F6;
												case 8:
													goto IL_10F6;
												case 9:
													num = (short)630521873;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 10:
													if (acpFieldBase.UnsupportedValue)
													{
														num = (short)65732613;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_10F6;
												case 11:
													if (!acpRecRefField2.Applicable)
													{
														num = (short)1290403849;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_1036;
												case 12:
													if (acpRecRefField2 != null)
													{
														num = (short)1383530510;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_F35;
												case 13:
													goto IL_F35;
												case 14:
													global::AcpUI.DragDrop.DragDropAdvisor.h.Remove(acpRecRefField2);
													num = (short)1705967619;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 15:
													goto IL_110F;
												case 16:
												{
													global::AcpCommonLib.IAcpField acpField;
													global::AcpUI.DragDrop.DragDropAdvisor.g[(global::AcpBusinessLayer.AcpRecRefField)acpFieldBase] = ((global::AcpBusinessLayer.AcpRecRefField)acpField).UIValue;
													num = (short)1703084036;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 17:
													if (acpRecRefField2.HasSiblingRecset)
													{
														num = (short)1287913474;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_1036;
												}
												goto IL_E8D;
												IL_F35:
												num = (short)344064007;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_1036:
												num = (short)648347648;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_10F6:
												num = (short)988741647;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_110F:
											break;
											IL_E8D:
											acpFieldBase.DisableASKRangeValidation = false;
											flag = true;
											acpRecRefField2 = (acpFieldBase as global::AcpBusinessLayer.AcpRecRefField);
											num = (short)1317863436;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_E3E;
										}
										catch
										{
											break;
										}
										goto IL_111A;
									case 25:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (acpFieldBase.Name == global::AcpUI.Common.Utility.c("쎖캜튠삤즦첨\ud9aa첬쎮삲\udeb4\udcb8쪺좼횾돀ꛂꇄ飆裈ￊ琉", a_))
										{
											num = (short)309264411;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_134F;
									}
									case 26:
										num = (short)1629880327;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 27:
									{
										global::AcpCommonLib.IAcpField acpField;
										global::AcpBusinessLayer.AcpField<bool> acpField2 = acpField as global::AcpBusinessLayer.AcpField<bool>;
										num = (short)292356105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 28:
									{
										global::AcpBusinessLayer.AcpField<bool> acpField2;
										if (acpField2.Value)
										{
											num = (short)1534787594;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_134F;
									}
									case 30:
										num = (short)325582876;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 31:
										num = (short)1865678856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 32:
										goto IL_15B1;
									case 33:
										goto IL_121E;
									case 34:
										num = (short)1361641508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 35:
										switch (0)
										{
										case 0:
											goto IL_CF8;
										}
										continue;
									case 36:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (acpFieldBase.BlockDataTransfer)
										{
											num = (short)151257128;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1055391747;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 37:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (((global::AcpBusinessLayer.AcpFieldBase)acpField).UIInvalid)
										{
											num = (short)1474494479;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 38:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (acpFieldBase.AllowsDataTransfer())
										{
											num = (short)282132492;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_13D5;
									}
									case 39:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (featureNode.KeyField == acpField)
										{
											num = (short)2083258394;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_13D5;
									}
									case 40:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(acpFieldBase, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unsupported_DataTransfer, false);
										num = (short)1042087960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 41:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (!((global::AcpBusinessLayer.AcpFieldBase)acpField).HiddenStatic)
										{
											num = (short)183435278;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_123C;
									}
									}
									goto IL_CF8;
									IL_111A:
									num = (short)429588521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_121E:
									num = (short)921108503;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_123C:
									num = (short)1170341927;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_134F:
									num = (short)1213136900;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_13D5:
									num = (short)1330774029;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_155B:
									num = (short)109314068;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_CF8:
									goto IL_155B;
								}
								IL_15B1:
								goto IL_1DA;
							}
							finally
							{
								num = (short)637927424;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_15EA;
										}
										continue;
									case 1:
										goto IL_1622;
									case 2:
										enumerator4.Dispose();
										num = (short)1448476673;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_15EA:
									if (enumerator4 == null)
									{
										break;
									}
									num = (short)678100994;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1622:;
							}
							goto IL_1625;
							IL_1DA:
							num = (short)136183814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (!embeddedRecset.HiddenStatic)
							{
								num = (short)1972240405;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25C;
						case 21:
							num = (short)350158857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
						{
							if (embeddedRecset.RecsetId == embeddedRecset2.RecsetId)
							{
								num = (short)230686767;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string message2 = global::AcpCommonResources.AcpResources.Cannot_Copy_Not_Exists.AcpStringFormat(new object[]
							{
								embeddedRecset.Path(global::AcpUI.Common.Utility.c("쮖", a_))
							});
							global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message2, false);
							num = (short)202113078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator3 = ((global::AcpBusinessLayer.Recordset)embeddedRecset2).GetEnumerator();
							num = (short)1032519683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							if (embeddedRecset2 != null)
							{
								num = (short)106758197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25C;
						case 26:
							goto IL_30A;
						case 27:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (featureNode4 != null)
							{
								num = (short)1728380928;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_384;
						}
						case 28:
							if (embeddedRecset2.Count > 0)
							{
								num = (short)1471741963;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1625;
						case 29:
							num = (short)1066401817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)1619722244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							num = (short)860749852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							goto IL_25C;
						case 33:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (featureNode4.Parent != null)
							{
								num = (short)126943247;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_384;
						}
						case 34:
							goto IL_167B;
						case 36:
							num = (short)686227473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (featureNode4.Parent.ParentSection != null)
							{
								num = (short)1990983721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_384;
						}
						case 38:
							num = (short)942211074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 39:
							num = (short)722665512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (featureNode4.KeyField == null)
							{
								num = (short)1833107492;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_30A;
						}
						case 41:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							global::AcpCommonLib.AppInfoManager.DndAndImportSection.Add(featureNode4.Parent.ParentSection.GetType());
							num = (short)1059848240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 42:
							if (embeddedRecset != null)
							{
								num = (short)2065235997;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25C;
						case 43:
							switch (0)
							{
							case 0:
								goto IL_147;
							}
							continue;
						case 44:
							goto IL_30A;
						case 45:
						{
							num = (short)774438913;
							if (num != 0)
							{
							}
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
							if (acpFeatureSection != null)
							{
								num = (short)1556676654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureSection featureSection;
							string message3 = global::AcpCommonResources.AcpResources.Cannot_Copy_Not_Exists.AcpStringFormat(new object[]
							{
								featureSection.UIName
							});
							global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message3, false);
							num = (short)2051735587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 46:
						{
							global::AcpBusinessLayer.FeatureSection featureSection;
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator4 = featureSection.FieldsCollectionByOrder.GetEnumerator();
							num = (short)1612840979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 47:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4 = (global::AcpBusinessLayer.FeatureNode)embeddedRecset2[0];
							num = (short)1003028507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 48:
							goto IL_384;
						case 49:
							goto IL_1D5;
						case 50:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (!featureNode4.KeyField.BlockDataTransfer)
							{
								num = (short)2067398666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1625;
						}
						case 51:
						{
							global::AcpBusinessLayer.FeatureNode featureNode4;
							if (featureNode4 != null)
							{
								num = (short)1464008722;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_30A;
						}
						case 52:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)217841672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator.Current;
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = A_1[featureSection.FeatureSectionId];
							num = (short)202637357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 53:
							num = (short)1258881044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
							goto IL_25C;
						}
						goto IL_147;
						IL_1D5:
						((global::AcpBusinessLayer.Recordset)embeddedRecset2).FindNewFieldsInEmbeddedRecset_DnD(embeddedRecset, dictionary);
						embeddedRecset2.ClearRecordset(embeddedRecset2, A_2);
						num = (short)353370138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_25C:
						dictionary.Clear();
						num = (short)90046486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_30A:
						this.a(embeddedRecset, embeddedRecset2, A_2, true);
						((global::AcpBusinessLayer.Recordset)embeddedRecset2).UpdateNewFieldsInEmbeddedRecset_ImpExpDnD(A_2, dictionary);
						num = (short)1035730976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_342:
						num = (short)514195508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_147:
						goto IL_342;
						IL_384:
						num = (short)1170407440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8CF:
						num = (short)1760428065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1625:
						num = (short)1183776819;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_167B:;
				}
				finally
				{
					num = (short)73859072;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_16AF;
							}
							continue;
						case 1:
							goto IL_16E7;
						case 2:
							enumerator.Dispose();
							num = (short)881524737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_16AF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)820772866;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_16E7:;
				}
				num = (short)1548746752;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0006769C File Offset: 0x0006589C
		private void a(global::AcpCommonLib.IAcpRecordset A_0, global::AcpCommonLib.IAcpRecordset A_1, global::AcpCommonLib.UndoRedo.ContainerTask A_2, bool A_3)
		{
			int a_ = 16;
			short num = (short)214106112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_173;
				}
				global::System.Collections.Generic.List<string> list;
				global::AcpBusinessLayer.Recordset recordset;
				for (;;)
				{
					IL_30:
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					int num3;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
					int num5;
					global::AcpCommonLib.IAcpFeatureNode a_2;
					int num7;
					int num8;
					global::AcpCommonLib.IAcpFeatureNode a_3;
					switch (num2)
					{
					case 0:
						if (!list.Contains(acpFeatureNode.ReferenceKey))
						{
							num = (short)1643970636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE6;
					case 1:
						goto IL_7EC;
					case 2:
						acpFeatureNode2 = A_1[num3];
						num = (short)1905852481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_AE6;
					case 4:
					{
						int num4;
						if (num4 >= 0)
						{
							num = (short)1804533816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = global::System.Math.Abs(num4);
						num = (short)208666648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_85D;
					case 6:
						num = (short)426573824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_5B2;
					case 8:
						if (acpFeatureNode2 == null)
						{
							num = (short)1154940996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F6;
					case 9:
						goto IL_2CB;
					case 10:
						if (A_1.PreDataTransferClearRecordset)
						{
							num = (short)1284767790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A34;
					case 11:
						goto IL_4C9;
					case 12:
						acpFeatureNode2 = (global::AcpBusinessLayer.FeatureNode)A_1[0];
						num = (short)1649278979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_DED;
					case 14:
						goto IL_491;
					case 15:
						num = (short)183894041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (A_1.CounterToMax < 0)
						{
							num = (short)2000683017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode = recordset.CreateDefaultRecordHelper();
						featureNode.CalculateVisibility(true);
						featureNode.CalculateEditability(true);
						A_2.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode));
						acpFeatureNode3 = (global::AcpBusinessLayer.FeatureNode)recordset.NodeFromId(featureNode.NodeId);
						num = (short)1377173527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (num3 < A_1.Count)
						{
							num = (short)1006305282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE6;
					case 18:
						((global::AcpBusinessLayer.Recordset)A_1).ClearMyEmbeddedRecsets(acpFeatureNode4, A_2, global::AcpUI.DragDrop.DragDropAdvisor.h);
						num = (short)927989780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.Undeletable, ((global::AcpBusinessLayer.FeatureNode)recordset[recordset.Count - 1]).Permissions))
						{
							num = (short)2019295270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_692;
					case 20:
						goto IL_359;
					case 21:
						return;
					case 22:
						goto IL_B5E;
					case 23:
						goto IL_CFA;
					case 24:
					{
						int num4;
						if (num4 > A_1.CounterToMin)
						{
							num = (short)1541079099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7EC;
					}
					case 25:
						if (A_1.PreDataTransferClearRecordset)
						{
							num = (short)125763602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					case 26:
						num = (short)1203896330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (A_0.HasKeyField)
						{
							num = (short)1290076205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)715522109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)1817772033;
						if (num != 0)
						{
						}
						if (num5 >= A_0.Count)
						{
							num = (short)348782613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_2 = A_0[num5];
						acpFeatureNode4 = null;
						num = (short)275841057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_692;
					case 30:
						goto IL_46D;
					case 31:
					{
						if (A_1.CounterToMax < 0)
						{
							num = (short)1241120840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1859966445;
						short num6 = num;
						num = (short)1677055469;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C9;
						default:
						{
							num = (short)248643584;
							if (num != 0)
							{
							}
							global::AcpBusinessLayer.FeatureNode featureNode2 = recordset.CreateDefaultRecordHelper();
							featureNode2.CalculateVisibility(true);
							featureNode2.CalculateEditability(true);
							A_2.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode2));
							acpFeatureNode2 = (global::AcpBusinessLayer.FeatureNode)recordset.NodeFromId(featureNode2.NodeId);
							num = (short)850264141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 32:
						goto IL_E2D;
					case 33:
						if (num5 < A_1.Count)
						{
							num = (short)47448107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85D;
					case 34:
						goto IL_5B2;
					case 35:
						if (acpFeatureNode2 != null)
						{
							num = (short)1040252954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46D;
					case 36:
						if (num3 >= A_0.Count)
						{
							num = (short)879034442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = A_0[num3];
						acpFeatureNode2 = null;
						num = (short)1227816987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_DED;
					case 38:
						goto IL_65A;
					case 39:
						if (A_1.Count > 0)
						{
							num = (short)77201414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE6;
					case 40:
						if (acpFeatureNode4 != null)
						{
							num = (short)136970255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					case 41:
						if (acpFeatureNode3 != null)
						{
							num = (short)1337262144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AB;
					case 42:
						goto IL_A34;
					case 43:
						acpFeatureNode4 = A_1[num5];
						num = (short)1934229509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						((global::AcpBusinessLayer.Recordset)A_1).ClearMyEmbeddedRecsets(acpFeatureNode3, A_2, global::AcpUI.DragDrop.DragDropAdvisor.h);
						num = (short)861208639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)235995175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						((global::AcpBusinessLayer.Recordset)A_1).ClearMyEmbeddedRecsets(acpFeatureNode2, A_2, global::AcpUI.DragDrop.DragDropAdvisor.h);
						num = (short)427491370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_5F6;
					case 48:
						goto IL_5F6;
					case 49:
						goto IL_3AB;
					case 50:
						acpFeatureNode3 = A_1[num7];
						num = (short)1637810230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (!global::AcpCommonLib.AppInfoManager.SkipValueSetter)
						{
							num = (short)1256587333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65A;
					case 52:
					{
						int num4 = A_0.Count - A_1.Count;
						num = (short)2084044804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						if (A_3)
						{
							num = (short)1902444596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = new global::System.Collections.Generic.List<string>();
						num3 = 0;
						num = (short)955842573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_CFA;
					case 55:
						if (A_1.PreDataTransferClearRecordset)
						{
							num = (short)1300889644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_739;
					case 56:
						num7 = 0;
						num = (short)642580514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_491;
					case 58:
						goto IL_E2D;
					case 59:
					{
						int num4 = A_1.CounterToMin;
						string message = global::AcpCommonResources.AcpResources.Min_Rec_Reached_Delete.AcpStringFormat(new object[]
						{
							A_1.Path(global::AcpUI.Common.Utility.c("瘟", a_))
						});
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)1818099713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						if (A_1.CounterToMax == 0)
						{
							num = (short)1944780878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)651296799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (A_0.SingleInstance)
						{
							num = (short)1211170828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)703397905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_AE6;
					case 63:
						goto IL_739;
					case 64:
						num = (short)1189085239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_AE6;
					case 66:
						if (A_1.CounterToMax == 0)
						{
							num = (short)1068171286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)537198608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (num7 < A_1.Count)
						{
							num = (short)1709965362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2081292354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)154206268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						num = (short)1805516819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
					{
						int num4;
						if (num8 >= num4)
						{
							num = (short)180813835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)808321075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						if (num7 >= A_0.Count)
						{
							num = (short)584187979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_3 = A_0[num7];
						acpFeatureNode3 = null;
						num = (short)1749942339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
					{
						string message2 = global::AcpCommonResources.AcpResources.Max_Rec_Exceeded.AcpStringFormat(new object[]
						{
							A_1.Path(global::AcpUI.Common.Utility.c("瘟", a_))
						});
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message2, false);
						num = (short)1172176943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						goto IL_1E5;
					case 74:
						goto IL_E2B;
					case 75:
						return;
					case 76:
						acpFeatureNode2 = A_1.NodeFromKey(acpFeatureNode.ReferenceKey);
						num = (short)742719550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						goto IL_5F6;
					case 78:
					{
						string message3 = global::AcpCommonResources.AcpResources.Max_Rec_Reached_Add.AcpStringFormat(new object[]
						{
							A_1.Path(global::AcpUI.Common.Utility.c("瘟", a_))
						});
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message3, false);
						num = (short)1798963248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_173;
					IL_1E5:
					num5++;
					num = (short)628359226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_359:
					this.a(a_2, acpFeatureNode4, A_2, A_3);
					num = (short)864288768;
					short num9 = num;
					num = (short)458424393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AB:
					num7++;
					num = (short)1251278855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46D:
					num3++;
					num = (short)760086565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_491:
					num = (short)845283398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C9:
					num5 = 0;
					num = (short)730595360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B2:
					num = (short)910950471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F6:
					num = (short)2145976355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65A:
					A_2.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask((global::AcpBusinessLayer.FeatureNode)recordset[recordset.Count - 1]));
					num = (short)24248349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_692:
					num8++;
					num = (short)1061027897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_739:
					this.a(a_3, acpFeatureNode3, A_2, A_3);
					num = (short)878379057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EC:
					num8 = 0;
					num = (short)700973070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_85D:
					num = (short)1413546024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A34:
					this.a(acpFeatureNode, acpFeatureNode2, A_2, A_3);
					list.Add(acpFeatureNode2.ReferenceKey);
					num = (short)855113758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE6:
					num = (short)1079902216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CFA:
					num = (short)656539689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DED:
					num = (short)2102657060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E2D:
					num = (short)1074987036;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2CB:
				string message4 = global::AcpCommonResources.AcpResources.Max_Rec_Exceeded.AcpStringFormat(new object[]
				{
					A_1.Path(global::AcpUI.Common.Utility.c("瘟", a_))
				});
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message4, false);
				return;
				IL_B5E:
				string message5 = global::AcpCommonResources.AcpResources.Max_Rec_Reached_Add.AcpStringFormat(new object[]
				{
					A_1.Path(global::AcpUI.Common.Utility.c("瘟", a_))
				});
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message5, false);
				return;
				IL_E2B:
				list.Clear();
				return;
				IL_173:
				recordset = (global::AcpBusinessLayer.Recordset)A_1;
				num = (short)1617035317;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0006854C File Offset: 0x0006674C
		public void OnDropCompleted(global::System.Windows.IDataObject obj, global::System.Windows.Point dropPoint, global::AcpUI.AcpTreeViewItem consumerNode)
		{
			int a_ = 6;
			short num = (short)1966145536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D0;
				}
				global::System.Collections.Generic.Dictionary<string, object> dictionary;
				bool flag;
				global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask modifyAppInfoStateTask;
				global::System.Collections.Generic.Dictionary<string, object> dictionary3;
				for (;;)
				{
					IL_31:
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
					global::System.Collections.Generic.SortedDictionary<int, int>.Enumerator enumerator;
					string key;
					bool flag2;
					global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>.Enumerator enumerator3;
					global::System.Collections.Generic.SortedDictionary<int, int> sortedDictionary;
					global::System.Collections.Generic.SortedDictionary<int, int> sortedDictionary2;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator4;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)1932394508;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								global::AcpCommonLib.IAcpRecordset feature2;
								global::AcpCommonLib.IAcpRecordset acpRecordset;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								switch (num2)
								{
								case 1:
									acpFeatureNode = null;
									num = (short)1514274849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1295;
								case 3:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									string message = global::AcpCommonResources.AcpResources.Max_Rec_Reached_Add.AcpStringFormat(new object[]
									{
										feature.Path(global::AcpUI.Common.Utility.c("삛", a_))
									});
									global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message, false);
									num = (short)1005322262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1295;
								case 5:
									goto IL_FFB;
								case 6:
									num = (short)1500119089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (!feature2.HiddenStatic)
									{
										num = (short)1560346630;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
								{
									if (feature2 != null)
									{
										num = (short)2069626914;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string message2 = global::AcpCommonResources.AcpResources.Cannot_Copy_Not_Exists.AcpStringFormat(new object[]
									{
										acpRecordset.Path(global::AcpUI.Common.Utility.c("삛", a_))
									});
									global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message2, false);
									num = (short)866713600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)77594644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (acpFeatureNode != null)
									{
										num = (short)1299578906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 12:
									switch (0)
									{
									case 0:
										goto IL_FB3;
									}
									continue;
								case 14:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset2;
									if (acpRecordset2 != null)
									{
										num = (short)703004707;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)514850843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									num = (short)1470562311;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									num = (short)642121765;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (!acpRecordset.HiddenStatic)
									{
										num = (short)1758658575;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 18:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									acpFeatureNode2 = acpFeatureNode3;
									int value;
									global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(value);
									num = (short)910360607;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									if (feature.Count > 0)
									{
										num = (short)948240412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FFB;
								}
								case 20:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									if (feature.CounterToMax == 0)
									{
										num = (short)923467779;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = ((global::AcpBusinessLayer.Recordset)feature).CreateDefaultRecordHelper();
									featureNode.CalculateVisibility(true);
									featureNode.CalculateEditability(true);
									containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode));
									acpFeatureNode = (global::AcpBusinessLayer.FeatureNode)feature.NodeFromId(featureNode.NodeId);
									num = (short)827392004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 21:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1571291175;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<int, int> keyValuePair = enumerator.Current;
									int value = keyValuePair.Value;
									object obj2;
									dictionary.TryGetValue(value.ToString(global::System.Globalization.CultureInfo.InvariantCulture), out obj2);
									global::AcpCommonLib.IAcpRecordset acpRecordset2 = obj2 as global::AcpCommonLib.IAcpRecordset;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = obj2 as global::AcpCommonLib.IAcpFeatureNode;
									num = (short)1136328718;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									goto IL_1295;
								case 23:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									if (feature.PreDataTransferClearRecordset)
									{
										num = (short)1443758124;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_166B;
								}
								case 24:
								{
									if (feature2 != acpRecordset)
									{
										num = (short)269156397;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string message3 = global::AcpCommonResources.AcpResources.Cannot_Drop_Itself.AcpStringFormat(new object[]
									{
										acpRecordset.Path(global::AcpUI.Common.Utility.c("삛", a_))
									});
									global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message3, false);
									num = (short)289079306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									num = (short)859439127;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									num = (short)775749670;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpFeatureNode3 != null)
									{
										num = (short)1673134098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 28:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									acpFeatureNode = feature.NodeFromKey(key);
									num = (short)605683717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 29:
									num = (short)482934803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									goto IL_11DD;
								case 31:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									if (feature != null)
									{
										num = (short)2061565953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string message4 = global::AcpCommonResources.AcpResources.Cannot_Copy_Not_Exists.AcpStringFormat(new object[]
									{
										acpFeatureNode2.Path(global::AcpUI.Common.Utility.c("삛", a_))
									});
									global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message4, false);
									num = (short)1162543147;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 32:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									if (acpFeatureNode2.Parent != feature)
									{
										num = (short)482869264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string message5 = global::AcpCommonResources.AcpResources.Cannot_Drop_Parent.AcpStringFormat(new object[]
									{
										acpFeatureNode2.Path(global::AcpUI.Common.Utility.c("삛", a_))
									});
									global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message5, false);
									num = (short)435945474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 33:
									if (consumerNode.NodeId != 0)
									{
										num = (short)1436549162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1676214304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									num = (short)1110114328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset2;
									acpRecordset = acpRecordset2;
									int value;
									feature2 = global::AcpCommonLib.FeatureManager.GetFeature(value);
									num = (short)1783496712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 36:
									goto IL_166B;
								case 37:
									if (((global::AcpBusinessLayer.FeatureNode)acpFeatureNode2).KeyField != null)
									{
										num = (short)804782109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FFB;
								case 38:
								{
									if (acpFeatureNode != acpFeatureNode2)
									{
										num = (short)1943076889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string message6 = global::AcpCommonResources.AcpResources.Cannot_Drop_Itself.AcpStringFormat(new object[]
									{
										acpFeatureNode2.Path(global::AcpUI.Common.Utility.c("삛", a_))
									});
									global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, message6, false);
									num = (short)842989616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 39:
									num = (short)493551666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 40:
									goto IL_1295;
								case 41:
									if (acpFeatureNode == null)
									{
										num = (short)705167369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1295;
								case 42:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									acpFeatureNode = feature.NodeFromId(consumerNode.NodeId);
									num = (short)465043496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 44:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									((global::AcpBusinessLayer.Recordset)feature).ClearMyEmbeddedRecsets(acpFeatureNode, containerTask, global::AcpUI.DragDrop.DragDropAdvisor.h);
									num = (short)799080484;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 45:
									num = (short)311689233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									feature2.ClearRecordset(feature2, containerTask);
									num = (short)1053098014;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 49:
									if (feature2.PreDataTransferClearRecordset && flag)
									{
										num = (short)1131544622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11DD;
								case 50:
									goto IL_1831;
								}
								goto IL_FB3;
								IL_FFB:
								num = (short)734789673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11DD:
								feature2.CalculateVisibility(true);
								feature2.CalculateEditability(true);
								this.a(acpRecordset, feature2, containerTask, flag);
								num = (short)795803695;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1295:
								num = (short)1377894411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_166B:
								acpFeatureNode.CalculateVisibility(true);
								acpFeatureNode.CalculateEditability(true);
								this.a(acpFeatureNode2, acpFeatureNode, containerTask, flag);
								num = (short)1123745805;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_173B:
								num = (short)1822556181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FB3:
								goto IL_173B;
							}
							IL_1831:
							goto IL_19BB;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1844;
						IL_19BB:
						global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, string>.Enumerator enumerator2 = global::AcpUI.DragDrop.DragDropAdvisor.g.GetEnumerator();
						num = (short)1240662027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (containerTask != null)
						{
							num = (short)757858330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E81;
					case 2:
						if (flag2)
						{
							num = (short)1291517969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76D;
					case 3:
						return;
					case 4:
						if (global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport == null)
						{
							num = (short)449904661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.Clear();
						num = (short)91684894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						object obj3;
						if (dictionary.TryGetValue(global::AcpUI.Common.Utility.c("킛펟횡삥盛쾩쾫\uddad햯욱잳", a_), out obj3))
						{
							num = (short)474677262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F7;
					}
					case 6:
						if (consumerNode.NodeId == 0)
						{
							num = (short)1339621403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_985;
					case 7:
						goto IL_76D;
					case 8:
					{
						global::AcpCommonLib.AppInfoManager.DndAndImportTask = containerTask;
						global::System.Collections.Generic.Dictionary<string, bool> dictionary2 = new global::System.Collections.Generic.Dictionary<string, bool>();
						dictionary2.Add(global::AcpUI.Common.Utility.c("\ud89b쾟튡횥춧\ud8a9춫\udaad\ud9af\uddb1\udab3", a_), false);
						dictionary2.Add(global::AcpUI.Common.Utility.c("\ud89b쒟풣쎥\udaa7쮩\ud8ab잭\udfaf\udcb1", a_), false);
						dictionary2.Add(global::AcpUI.Common.Utility.c("\ud89b쒟풣쎥\udaa7쮩\ud8ab잭\udfaf\udcb1\ud9b5햷쪹킻\udbbd뒿ꟁꃃ", a_), true);
						this.f.PostProcess(containerTask);
						containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask(dictionary2));
						global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
						num = (short)1713373200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						try
						{
							num = (short)319815684;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.ValueSetter(acpRecRefField.Parent, containerTask);
									num = (short)1838612482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField.ValueSetter != null)
									{
										num = (short)357564416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (!acpRecRefField.HiddenStatic)
									{
										num = (short)913965063;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_201;
									}
									continue;
								case 5:
									num = (short)1616904198;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_32C;
								case 7:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									global::System.Collections.Generic.KeyValuePair<global::AcpCommonLib.IAcpField, string> keyValuePair2;
									containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(acpRecRefField, keyValuePair2.Value));
									num = (short)620036097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)1005322245;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::AcpCommonLib.IAcpField, string> keyValuePair2 = enumerator3.Current;
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = keyValuePair2.Key as global::AcpBusinessLayer.AcpRecRefField;
									num = (short)1993342979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_2A4:
								num = (short)1414070280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_201:
								goto IL_2A4;
							}
							IL_32C:
							goto IL_1A0D;
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto Block_3;
					case 10:
						try
						{
							num = (short)106627073;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)345833474;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::AcpCommonLib.IAcpField, string> keyValuePair3 = enumerator3.Current;
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField2 = keyValuePair3.Key as global::AcpBusinessLayer.AcpRecRefField;
									num = (short)1360003076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_DA5;
									}
									continue;
								case 2:
									num = (short)1747910662;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
									if (acpRecRefField2.HiddenStatic)
									{
										num = (short)2020605957;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
									acpRecRefField2.ResetToDefaultWithUndo(containerTask);
									num = (short)878444547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_E6E;
								}
								IL_DC7:
								num = (short)1445920768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DA5:
								goto IL_DC7;
							}
							IL_E6E:
							goto IL_19E4;
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto IL_E81;
						IL_19E4:
						enumerator3 = global::AcpUI.DragDrop.DragDropAdvisor.h.GetEnumerator();
						num = (short)1872363529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_33F;
					case 12:
						containerTask.AddTask(modifyAppInfoStateTask);
						sortedDictionary = new global::System.Collections.Generic.SortedDictionary<int, int>();
						enumerator = sortedDictionary2.GetEnumerator();
						num = (short)1515126807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (containerTask.Tasks.Count > 0)
						{
							num = (short)570556424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E81;
					case 14:
					{
						object obj3;
						sortedDictionary2 = (global::System.Collections.Generic.SortedDictionary<int, int>)obj3;
						num = (short)799277074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (sortedDictionary2 != null)
						{
							num = (short)742457356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A0D;
					case 16:
						goto IL_8A3;
					case 17:
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)1416101895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_7F7;
					case 19:
						goto IL_985;
					case 20:
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)123469849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
						num = (short)1895497760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						object obj4;
						if (dictionary3.TryGetValue(global::AcpUI.Common.Utility.c("첛쾟욡톣얥춧\ud8a9솭풯ힱ펵\udeb7\udfb9캻\udbbd꺿ꇁꇃ跅귇돉", a_), out obj4))
						{
							num = (short)383844388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_483;
					}
					case 23:
						try
						{
							num = (short)1712979969;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset3;
									int value2;
									sortedDictionary.Add(acpRecordset3.DataTransferOrder, value2);
									num = (short)1394999302;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A19;
									}
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset3;
									if (acpRecordset3 != null)
									{
										num = (short)856031237;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int value2;
									global::System.Collections.Generic.KeyValuePair<int, int> keyValuePair4;
									sortedDictionary.Add(keyValuePair4.Key, value2);
									num = (short)1280638980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset3;
									if (acpRecordset3.DataTransferOrder > 0)
									{
										num = (short)1849425920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)260571139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)463339528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<int, int> keyValuePair4 = enumerator.Current;
									int value2 = keyValuePair4.Value;
									object obj5;
									dictionary.TryGetValue(value2.ToString(global::System.Globalization.CultureInfo.InvariantCulture), out obj5);
									global::AcpCommonLib.IAcpRecordset acpRecordset3 = obj5 as global::AcpCommonLib.IAcpRecordset;
									num = (short)1468727298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1030225929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_B7D;
								}
								IL_B24:
								num = (short)423952391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A19:
								goto IL_B24;
							}
							IL_B7D:
							goto IL_CD5;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_B90;
						IL_CD5:
						num = (short)988282917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						try
						{
							num = (short)1692270592;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4FE;
									}
									continue;
								case 1:
									goto IL_6FA;
								case 2:
									goto IL_6E1;
								case 3:
								{
									if (!enumerator4.MoveNext())
									{
										num = (short)2017198082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator5 = ((global::AcpBusinessLayer.Recordset)enumerator4.Current).RecRefFields.GetEnumerator();
									num = (short)467992580;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									try
									{
										num = (short)1088552960;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											num = (short)1308699979;
											short num3 = num;
											num = (short)1888890187;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)556859392;
												if (num != 0)
												{
												}
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_5F3;
													}
													continue;
												case 1:
													goto IL_66D;
												case 2:
													num = (short)272629761;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
												{
													global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator5;
													if (!enumerator5.MoveNext())
													{
														num = (short)922222594;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													enumerator5.Current.CleanupDuplicates();
													goto IL_63A;
												}
												}
												IL_5F5:
												num = (short)110493699;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_5F3:
												goto IL_5F5;
											}
											IL_63A:
											num = (short)1380974596;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_66D:
										break;
									}
									finally
									{
										num = (short)1294270465;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator5;
											switch (num2)
											{
											case 0:
												goto IL_6DE;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_6A5;
												}
												continue;
											case 2:
												enumerator5.Dispose();
												num = (short)1545863168;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_6A5:
											if (enumerator5 == null)
											{
												break;
											}
											num = (short)1805778946;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_6DE:;
									}
									goto IL_6E1;
								}
								IL_500:
								num = (short)124583939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4FE:
								goto IL_500;
								IL_6E1:
								num = (short)2108817409;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6FA:
							goto IL_1844;
						}
						finally
						{
							num = (short)1588592641;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_76A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_731;
									}
									continue;
								case 2:
									enumerator4.Dispose();
									num = (short)2115371008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_731:
								if (enumerator4 == null)
								{
									break;
								}
								num = (short)1067057154;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_76A:;
						}
						goto IL_76D;
					case 25:
						goto IL_8A3;
					case 26:
						num = (short)1790050317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						flag = true;
						num = (short)5439507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpUI.Common.Utility.c("\ud89b솟얡蒣장욧캩貫슯\uddb1쒳", a_));
						num = (short)115081231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_483;
					case 30:
						goto IL_1967;
					case 31:
					{
						num = (short)1556283392;
						short num4 = num;
						num = (short)1669464070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_1967;
					case 33:
						if (consumerNode != null)
						{
							num = (short)102105116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A3;
					case 34:
						try
						{
							dictionary3 = (global::System.Collections.Generic.Dictionary<string, object>)obj.GetData(global::AcpUI.Common.Utility.c("첛쾟욡톣얥춧\ud8a9\udcad햯ힱힵ첷\udbb9", a_));
							dictionary = (global::System.Collections.Generic.Dictionary<string, object>)obj.GetData(global::AcpUI.Common.Utility.c("첛쾟욡톣얥춧\ud8a9쾭쒯펱", a_));
							goto IL_B90;
						}
						catch (global::System.Exception ex)
						{
							global::AcpUI.Common.Utility.c("톛ﮝ펟톡얣솥춧邩貫", a_) + ex.InnerException.Message + global::AcpUI.Common.Utility.c("ꞛ뺝춡톣풥쮧쾩隫躭", a_) + ex.InnerException.Source;
							global::AcpCommonLib.ConstraintManager.Resume();
							global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
							global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion = false;
							global::AcpCommonLib.AppInfoManager.DropOperation = false;
							global::AcpCommonLib.AppInfoManager.DndOperation = false;
							global::AcpCommonLib.AppInfoManager.DndOperationCompleted = false;
							global::AcpCommonLib.AppInfoManager.SkipValueSetter = false;
							string error_Drop_Opn = global::AcpCommonResources.AcpResources.Error_Drop_Opn;
							global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, error_Drop_Opn, false);
							global::AcpUI.Common.Utility.FieldsReportChanged(this, global::AcpCommonLib.FieldReportType.DnD);
							return;
						}
						goto IL_1967;
					case 35:
						if (!global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
						{
							num = (short)98697236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A3;
					case 36:
					{
						object obj4;
						key = (string)obj4;
						num = (short)954007581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						if (consumerNode.RecsetId == 0)
						{
							num = (short)1902641183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_985;
					}
					goto IL_D0;
					IL_483:
					containerTask = null;
					num = (short)226230305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_33F:
						num = (short)340066306;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpBusinessLayer.AcpRecRefField key2;
								key2.ValueSetter(key2.Parent, containerTask);
								num = (short)2035351556;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)1383792643;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_382;
								}
								continue;
							case 3:
								goto IL_470;
							case 5:
							{
								global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, string>.Enumerator enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)73334785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::AcpBusinessLayer.AcpRecRefField, string> keyValuePair5 = enumerator2.Current;
								global::AcpBusinessLayer.AcpRecRefField key2 = keyValuePair5.Key;
								containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(key2, keyValuePair5.Value));
								num = (short)881197062;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::AcpBusinessLayer.AcpRecRefField key2;
								if (key2.ValueSetter != null)
								{
									num = (short)86900736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_384:
							num = (short)1048248325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_382:
							goto IL_384;
						}
						IL_470:
						goto IL_D15;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, string>.Enumerator enumerator2;
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto IL_483;
					IL_D15:
					enumerator3 = global::AcpUI.DragDrop.DragDropAdvisor.h.GetEnumerator();
					num = (short)424017930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76D:
					global::AcpUI.DragDrop.DragDropAdvisor.g.Clear();
					global::AcpUI.DragDrop.DragDropAdvisor.h.Clear();
					global::AcpCommonLib.AppInfoManager.DndAndImportSection.Clear();
					global::AcpCommonLib.AppInfoManager.DndAndImportTask = null;
					num = (short)1149304835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F7:
					key = null;
					num = (short)267649046;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8A3:
					flag2 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					enumerator4 = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
					num = (short)1449721880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_985:
					global::AcpCommonLib.AppInfoManager.SkipValueSetter = flag;
					this.f.Data = dictionary;
					this.f.PreProcess(containerTask);
					enumerator = sortedDictionary.GetEnumerator();
					num = (short)1865482240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B90:
					global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion = false;
					global::AcpCommonLib.ConstraintManager.Resume();
					global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
					sortedDictionary2 = null;
					num = (short)523960325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E81:
					num = (short)599130147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1844:
					num = (short)811270145;
					if (num != 0)
					{
					}
					num = (short)1909719042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1967:
					global::AcpCommonLib.ConstraintManager.Suspend();
					global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion = true;
					num = (short)984743970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A0D:
					global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, global::AcpCommonResources.AcpResources.Drag_Drop_Opn_Complete, false);
					global::AcpUI.Common.Utility.FieldsReportChanged(this, global::AcpCommonLib.FieldReportType.DnD);
					num = (short)1439629313;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_D0:
				modifyAppInfoStateTask = new global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask(new global::System.Collections.Generic.Dictionary<string, bool>
				{
					{
						global::AcpUI.Common.Utility.c("\ud89b쒟풣쎥\udaa7쮩\ud8ab잭\udfaf\udcb1", a_),
						true
					},
					{
						global::AcpUI.Common.Utility.c("\ud89b쾟튡횥춧\ud8a9춫\udaad\ud9af\uddb1\udab3", a_),
						true
					},
					{
						global::AcpUI.Common.Utility.c("\ud89b쒟풣쎥\udaa7쮩\ud8ab잭\udfaf\udcb1\ud9b5햷쪹킻\udbbd뒿ꟁꃃ", a_),
						false
					}
				});
				modifyAppInfoStateTask.Do();
				dictionary3 = null;
				dictionary = null;
				global::AcpUI.DragDrop.DragDropAdvisor.g.Clear();
				flag = false;
				num = (short)190840836;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0006A080 File Offset: 0x00068280
		public global::System.Windows.UIElement GetVisualFeedback(global::System.Windows.IDataObject obj)
		{
			int a_ = 8;
			int num;
			global::System.Windows.Controls.TextBlock textBlock;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						object obj2;
						textBlock.Text = (obj2 as string);
						num2 = (short)1485438977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_AE;
					case 2:
					{
						object obj2;
						if (((global::System.Collections.Generic.Dictionary<string, object>)obj.GetData(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab節슯ힱ톳\ud9b7캹\uddbb", a_))).TryGetValue(global::AcpUI.Common.Utility.c("캝튟춡삣펥쮧쾩\udeab\udfaf횱톳ﺵ\uddb7\udbb9\ud8bb\udbbd늿", a_), out obj2))
						{
							num2 = (short)466944000;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_14D;
					}
					}
					goto IL_25;
				}
				IL_AE:
				num2 = (short)156866639;
				short num3 = num2;
				num2 = (short)1182308431;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2B;
				default:
				{
					num2 = (short)2140274689;
					if (num2 != 0)
					{
					}
					num2 = (short)1745485824;
					if (num2 != 0)
					{
					}
					num2 = (short)576323584;
					short num4 = num2;
					break;
				}
				}
				IL_14D:
				textBlock.Background = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Gray);
				textBlock.Foreground = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.White);
				textBlock.Width = (double)(textBlock.Text.Length + 125);
				textBlock.Height = 25.0;
				textBlock.Opacity = 0.5;
				return textBlock;
			}
			}
			IL_25:
			textBlock = new global::System.Windows.Controls.TextBlock();
			IL_2B:
			num2 = (short)455344130;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0006A230 File Offset: 0x00068430
		public void SetProcess(global::AcpCommonLib.IAcpBatchOperation process)
		{
			short num = (short)1288190420;
			short num2 = num;
			num = (short)753547732;
			switch (num2 == num)
			{
			}
			num = (short)109445121;
			if (num != 0)
			{
			}
			num = (short)464912384;
			short num3 = num;
			num = (short)289734656;
			if (num != 0)
			{
			}
			this.f = process;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0006A2FC File Offset: 0x000684FC
		// Note: this type is marked as 'beforefieldinit'.
		static DragDropAdvisor()
		{
			short num = (short)1607218327;
			short num2 = num;
			num = (short)2021995671;
			switch (num2 == num)
			{
			}
			num = (short)799342593;
			if (num != 0)
			{
			}
			num = (short)1573519360;
			short num3 = num;
			num = (short)1022296064;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropAdvisor.g = new global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, string>();
			global::AcpUI.DragDrop.DragDropAdvisor.h = new global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>();
		}

		// Token: 0x040002CC RID: 716
		private const string a = "2051";

		// Token: 0x040002CD RID: 717
		private const string b = "ProducerTreeData";

		// Token: 0x040002CE RID: 718
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.UIElement c;

		// Token: 0x040002CF RID: 719
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.UIElement d;

		// Token: 0x040002D0 RID: 720
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpUI.AcpTreeViewItem e;

		// Token: 0x040002D1 RID: 721
		private global::AcpCommonLib.IAcpBatchOperation f;

		// Token: 0x040002D2 RID: 722
		private static global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, string> g;

		// Token: 0x040002D3 RID: 723
		private static global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> h;
	}
}
