using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpFileHandlerLib;
using AcpUI;
using AcpUI.Common;
using AcpUI.DragDrop;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.DVRSFiles;
using SpecialFeatures.DVRSFiles.List;
using SpecialFeatures.SystemCertificates.List;
using SpecialFeatures.VoiceAnnouncements.List;

namespace MackinawCPS
{
	// Token: 0x0200003B RID: 59
	public partial class PageTreeView : Page
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0004856C File Offset: 0x0004676C
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00048618 File Offset: 0x00046818
		public Func<SelectionMode, List<string>> SelectVAFileDialog
		{
			[CompilerGenerated]
			get
			{
				short num = (short)2072982051;
				short num2 = num;
				num = (short)313143843;
				switch (num2 == num)
				{
				}
				num = (short)896860160;
				short num3 = num;
				num = (short)1110573057;
				if (num != 0)
				{
				}
				num = (short)1635778560;
				if (num != 0)
				{
				}
				return this.<SelectVAFileDialog>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)1257339669;
				short num2 = num;
				num = (short)1282833173;
				switch (num2 == num)
				{
				}
				num = (short)435355648;
				short num3 = num;
				num = (short)697827329;
				if (num != 0)
				{
				}
				num = (short)1477967872;
				if (num != 0)
				{
				}
				this.<SelectVAFileDialog>k__BackingField = value;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000486C8 File Offset: 0x000468C8
		public PageTreeView()
		{
			this.InitializeComponent();
			this.InitializePageTreeView();
			AcpUI.Common.Utility.SetDirection(this);
			DragDropManager.SetDnDProcess(this.winMain);
			if (AppInfoManager.AppMode == ApplicationMode.CodeplugConfigurationMode && this.MyTreeView.SelectedItem == null)
			{
				RadioInformationRecset radioInformationRecset = FeatureManager.GetFeature(2049) as RadioInformationRecset;
				this.MyTreeView.FindChildTreeViewItem(radioInformationRecset.RecsetId, 0).IsSelected = true;
			}
			this.preSelectedItem = (this.MyTreeView.SelectedItem as AcpTreeViewItem);
			base.PreviewMouseRightButtonUp += this.TreeView_PreviewMouseRightButtonUp;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00048778 File Offset: 0x00046978
		private void TreeViewRecordOperationEventHandler(object sender, NotifyCollectionChangedEventArgs e)
		{
			short num = (short)97778936;
			short num2 = num;
			num = (short)124058872;
			switch (num2 == num)
			{
			}
			num = (short)385810432;
			short num3 = num;
			num = (short)890306560;
			if (num != 0)
			{
			}
			num = (short)72548353;
			if (num != 0)
			{
			}
			IAcpRecordset recset = sender as IAcpRecordset;
			this.MyTreeView.OnTreeViewRecordOperation(recset, e, this.MyTreeView);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0004883C File Offset: 0x00046A3C
		private void ReferenceKeyChangedEventHandler(object sender, EventArgs e)
		{
			short num = (short)1034714444;
			short num2 = num;
			num = (short)1981578572;
			switch (num2 == num)
			{
			}
			num = (short)917045248;
			short num3 = num;
			num = (short)681115648;
			if (num != 0)
			{
			}
			num = (short)1266941953;
			if (num != 0)
			{
			}
			IAcpFeatureNode node = sender as IAcpFeatureNode;
			this.MyTreeView.OnReferenceKeyChanged(node, this.MyTreeView);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00048904 File Offset: 0x00046B04
		private void PageTreeView_KeyDown(object sender, KeyEventArgs e)
		{
			Recordset recordset;
			for (;;)
			{
				IL_00:
				short num = (short)1817444352;
				short num2 = num;
				num = (short)762511360;
				switch (num)
				{
				default:
				{
					num = (short)1810300947;
					int num3 = (int)((IntPtr)num);
					for (;;)
					{
						IAcpRecordset feature;
						AcpTreeViewItem acpTreeViewItem;
						switch (num3)
						{
						case 0:
							goto IL_3F6;
						case 1:
							if (this.copyNode == null)
							{
								num = (short)882835488;
								num3 = (int)((IntPtr)num);
								continue;
							}
							recordset = (Recordset)this.copyNode.Parent;
							num = (short)1363542040;
							num3 = (int)((IntPtr)num);
							continue;
						case 2:
							num = (short)343277604;
							num3 = (int)((IntPtr)num);
							continue;
						case 3:
							if (e.Key == Key.C)
							{
								num = (short)324337691;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_2F7;
						case 4:
						{
							IAcpFeatureNode record = feature.NodeFromId(acpTreeViewItem.NodeId);
							num = (short)677052433;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 5:
							goto IL_292;
						case 6:
							num = (short)1957888033;
							num3 = (int)((IntPtr)num);
							continue;
						case 7:
						{
							IAcpFeatureNode record;
							feature.RemoveRecordAt(feature.IndexOf(record));
							num = (short)472121384;
							num3 = (int)((IntPtr)num);
							continue;
						}
						case 8:
							if (Keyboard.Modifiers == ModifierKeys.Control)
							{
								num = (short)424542224;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 9:
							if (acpTreeViewItem.NodeId != 0)
							{
								num = (short)870121498;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_603;
						case 10:
							if (acpTreeViewItem.NodeId == 0)
							{
								num = (short)856883220;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 11:
							goto IL_431;
						case 12:
							goto IL_1B9;
						case 13:
							if (!feature.SingleInstance)
							{
								num = (short)731119620;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_603;
						case 14:
							if (feature.SingleInstance)
							{
								num = (short)857800709;
								num3 = (int)((IntPtr)num);
								continue;
							}
							num = (short)709885961;
							num3 = (int)((IntPtr)num);
							continue;
						case 15:
							if (Keyboard.Modifiers == ModifierKeys.Control)
							{
								num = (short)1241448476;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_2F7;
						case 16:
							num = (short)375062563;
							num3 = (int)((IntPtr)num);
							continue;
						case 17:
							if (e.Key == Key.Delete)
							{
								num = (short)20971549;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_436;
						case 18:
							if (feature.Count > 1)
							{
								num = (short)778371079;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_436;
						case 19:
							switch (0)
							{
							case 0:
								goto IL_110;
							}
							continue;
						case 20:
							num = (short)132579359;
							num3 = (int)((IntPtr)num);
							continue;
						case 21:
							num = (short)1611726885;
							num3 = (int)((IntPtr)num);
							continue;
						case 22:
						{
							num = (short)1131226416;
							short num4 = num;
							num = (short)954606896;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)275316736;
								if (num != 0)
								{
								}
								goto IL_2F7;
							}
							break;
						}
						case 23:
							num = (short)621871112;
							num3 = (int)((IntPtr)num);
							continue;
						case 24:
							if (this.CanPaste(this.copyNode))
							{
								num = (short)990248962;
								num3 = (int)((IntPtr)num);
								continue;
							}
							AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Info, string.Format(AcpResources.Unable_to_Add_Recs, recordset.UIName));
							num = (short)79167499;
							num3 = (int)((IntPtr)num);
							continue;
						case 25:
							return;
						case 26:
							num = (short)1469710337;
							if (num != 0)
							{
							}
							num = (short)899022861;
							num3 = (int)((IntPtr)num);
							continue;
						case 27:
							this.copyNode = this.MyTreeView.CurrentRecord;
							num = (short)427884566;
							num3 = (int)((IntPtr)num);
							continue;
						case 28:
							num = (short)1010040835;
							num3 = (int)((IntPtr)num);
							continue;
						case 29:
							num = (short)1085472786;
							num3 = (int)((IntPtr)num);
							continue;
						case 30:
							if (Keyboard.Modifiers == ModifierKeys.Control)
							{
								num = (short)284491797;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 31:
							if (!feature.SingleInstance)
							{
								num = (short)314966039;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 32:
							return;
						case 33:
							if (acpTreeViewItem != this.myTreeViewItemRoot)
							{
								num = (short)1858535463;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 34:
							if (acpTreeViewItem.NodeId != -1)
							{
								num = (short)1963393030;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 35:
							if (e.Key == Key.V)
							{
								num = (short)650641446;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 36:
						{
							bool flag = ((Recordset)feature).AddCopyOf(feature.IndexOf(this.copyNode));
							this.FixForAstroOtarProfileGUID(feature);
							if (!flag)
							{
								num = (short)2014969856;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_6B2;
						}
						case 37:
							if (e.Key == Key.V)
							{
								num = (short)528875532;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return;
						case 38:
							num = (short)1557987329;
							num3 = (int)((IntPtr)num);
							continue;
						case 39:
							num = (short)1661730830;
							num3 = (int)((IntPtr)num);
							continue;
						case 40:
							goto IL_436;
						}
						IL_110:
						if (AppInfoManager.AppMode != ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)1520238617;
							num3 = (int)((IntPtr)num);
							continue;
						}
						acpTreeViewItem = (e.Source as AcpTreeViewItem);
						feature = FeatureManager.GetFeature(acpTreeViewItem.RecsetId);
						num = (short)358613026;
						num3 = (int)((IntPtr)num);
						continue;
						IL_2F7:
						num = (short)157679646;
						num3 = (int)((IntPtr)num);
						continue;
						IL_436:
						num = (short)317456399;
						num3 = (int)((IntPtr)num);
						continue;
						IL_603:
						num = (short)105709578;
						num3 = (int)((IntPtr)num);
					}
					break;
				}
				}
			}
			return;
			IL_1B9:
			Recordset recordset2 = (Recordset)this.copyNode.Parent;
			AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Info, string.Format(AppResources.Paste_Operation, recordset2.UIName));
			return;
			IL_292:
			return;
			IL_3F6:
			AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Info, string.Format(AppResources.Paste_Operation, recordset.UIName));
			return;
			IL_431:
			return;
			IL_6B2:
			this.MyTreeView.Focus();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00049098 File Offset: 0x00047298
		private void PageTreeView_Loaded(object sender, RoutedEventArgs e)
		{
			short num = (short)1980891816;
			short num2 = num;
			num = (short)1820328616;
			switch (num2 == num)
			{
			}
			num = (short)85196800;
			short num3 = num;
			num = (short)368312321;
			if (num != 0)
			{
			}
			num = (short)37158912;
			if (num != 0)
			{
			}
			this.PgLoaded = true;
			this.TriggerDEKAndO9TopButtonsConstraints();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00049150 File Offset: 0x00047350
		private void TriggerDEKAndO9TopButtonsConstraints()
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						if (directionalButtonsListInnerRecset != null)
						{
							num2 = (short)213319683;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_181;
					}
					case 1:
					{
						ControlHeadO9Recset controlHeadO9Recset = FeatureManager.GetFeature(4003) as ControlHeadO9Recset;
						(controlHeadO9Recset[0][10616].EmbeddedRecset as TopFunctionProgrammableButtonListInnerRecset).CallConstraints();
						BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset = controlHeadO9Recset[0][10618].EmbeddedRecset as BottomFunctionProgrammableButtonInnerRecset;
						if (bottomFunctionProgrammableButtonInnerRecset != null)
						{
							bottomFunctionProgrammableButtonInnerRecset.CalculateApplicability();
						}
						DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = controlHeadO9Recset[0][10609].EmbeddedRecset as DirectionalButtonsListInnerRecset;
						goto IL_141;
					}
					case 2:
						goto IL_181;
					case 3:
					{
						DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						directionalButtonsListInnerRecset.CalculateApplicability();
						num2 = (short)403385445;
						short num3 = num2;
						num2 = (short)1143221349;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_141;
						default:
							num2 = (short)1167458304;
							if (num2 != 0)
							{
							}
							num2 = (short)1607270402;
							num = (int)((IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
						goto IL_199;
					}
					goto IL_24;
					IL_141:
					num2 = (short)1419444224;
					num = (int)((IntPtr)num2);
					continue;
					IL_181:
					num2 = (short)737607684;
					num = (int)((IntPtr)num2);
				}
				IL_199:
				goto IL_19E;
				IL_24:
				((FeatureManager.GetFeature(2129) as DEKRecset)[0][10232].EmbeddedRecset as DEKButtonInnerRecset).CallConstraints();
				num2 = (short)481624065;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			catch (Exception)
			{
			}
			IL_19E:
			num2 = (short)1681260544;
			short num4 = num2;
			num2 = (short)999096321;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00049368 File Offset: 0x00047568
		private void PageTreeView_Unloaded(object sender, RoutedEventArgs e)
		{
			short num = (short)971177988;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					WindowMain windowMain;
					if (!windowMain.CpgOpenFlag)
					{
						num = (short)1846149126;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_193;
				}
				case 1:
					this.myTreeViewItemRoot.Items.Clear();
					num = (short)2061238277;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
				{
					WindowMain windowMain;
					if (!windowMain.CustomViewOpenFlag)
					{
						num = (short)633929729;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_193;
				}
				case 3:
				{
					num = (short)509083649;
					if (num != 0)
					{
					}
					WindowMain windowMain = (WindowMain)Application.Current.MainWindow;
					num = (short)1986128771;
					short num3 = num;
					num = (short)45738883;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DF;
					default:
						num = (short)616300544;
						if (num != 0)
						{
						}
						num = (short)1378222080;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
					goto IL_193;
				case 6:
					num = (short)657522690;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					goto IL_1DD;
				}
				IL_44:
				if (this.PgLoaded)
				{
					num = (short)1637679107;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_193:
				this.PgLoaded = false;
				num = (short)1826684928;
				short num4 = num;
				num = (short)169476103;
				num2 = (int)((IntPtr)num);
			}
			IL_1DD:
			IL_1DF:
			this.DetachMenuItems();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0004955C File Offset: 0x0004775C
		private void AddFeatureNodeItems(AcpTreeViewItem treeViewItem, int featureId, string displayText)
		{
			short num = (short)841220096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				IAcpRecordset acpRecordset;
				AcpTreeViewItem acpTreeViewItem;
				for (;;)
				{
					IL_28:
					int num3;
					AcpTreeViewItem acpTreeViewItem2;
					switch (num2)
					{
					case 0:
						if (acpRecordset != null)
						{
							num = (short)869990407;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
						this.winMain.DocumentOperations.UclTemplateNodeInit();
						num = (short)1107689481;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						goto IL_3C6;
					case 3:
						num = (short)2063859716;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						if (acpRecordset.HideRecordsFromTree)
						{
							num = (short)1065484296;
							num2 = (int)((IntPtr)num);
							continue;
						}
						acpTreeViewItem.NodeId = 0;
						num3 = 0;
						num = (short)584318994;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						if (num3 >= acpRecordset.Count)
						{
							num = (short)1981743117;
							num2 = (int)((IntPtr)num);
							continue;
						}
						acpTreeViewItem2 = new AcpTreeViewItem();
						acpTreeViewItem2.Header = acpRecordset[num3].ReferenceKey;
						num = (short)1251999761;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
					{
						if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)1993998350;
							num2 = (int)((IntPtr)num);
							continue;
						}
						acpRecordset = FeatureManager.GetFeature(featureId);
						num = (short)984781128;
						short num4 = num;
						num = (short)2086048072;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E5;
						default:
							num = (short)680263680;
							if (num != 0)
							{
							}
							num = (short)29622288;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)1286668308;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						goto IL_3A7;
					case 9:
						goto IL_325;
					case 10:
						acpTreeViewItem2.ReferenceKey = acpRecordset[num3].ReferenceKey;
						num = (short)1525415955;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						if (!acpRecordset.SingleInstance)
						{
							num = (short)193003523;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3A7;
					case 12:
						goto IL_285;
					case 13:
						goto IL_2BF;
					case 14:
						acpRecordset = AppInfoManager.DefaultDocument.GetFeature(featureId);
						num = (short)1127743503;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						num = (short)1332019201;
						if (num != 0)
						{
						}
						if (featureId == 2200)
						{
							num = (short)735641601;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_325;
					case 16:
						goto IL_325;
					case 17:
						if (acpRecordset.HasKeyField)
						{
							num = (short)335544330;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_35D;
					case 18:
					{
						num = (short)1406205952;
						short num5 = num;
						goto IL_285;
					}
					case 19:
						goto IL_35D;
					case 20:
						if (acpRecordset.HiddenStatic)
						{
							num = (short)2085617685;
							num2 = (int)((IntPtr)num);
							continue;
						}
						acpTreeViewItem = new AcpTreeViewItem();
						acpTreeViewItem.Header = displayText;
						acpTreeViewItem.RecsetId = featureId;
						treeViewItem.Items.Add(acpTreeViewItem);
						goto IL_2E5;
					case 21:
						return;
					}
					goto IL_87;
					IL_285:
					num = (short)523501573;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2E5:
					num = (short)1225457675;
					num2 = (int)((IntPtr)num);
					continue;
					IL_325:
					num = (short)2079457280;
					num2 = (int)((IntPtr)num);
					continue;
					IL_35D:
					acpTreeViewItem2.RecsetId = featureId;
					acpTreeViewItem2.NodeId = acpRecordset[num3].NodeId;
					acpTreeViewItem.Items.Add(acpTreeViewItem2);
					num3++;
					num = (short)447938572;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3A7:
					acpTreeViewItem.NodeId = 0;
					num = (short)1395523586;
					num2 = (int)((IntPtr)num);
				}
				IL_2BF:
				IL_3C6:
				Recordset recordset = (Recordset)acpRecordset;
				CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(recordset);
				recordset.CollectionChanged += this.TreeViewRecordOperationEventHandler;
				recordset.ReferenceKeyChanged += this.ReferenceKeyChangedEventHandler;
				collectionView.CurrentChanged += this.OnCollectionCurrentViewChanged;
				this.MyTreeView.RootNodes.Add(featureId, acpTreeViewItem);
				return;
				IL_87:
				acpRecordset = null;
				num = (short)127074310;
				num2 = (int)((IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00049A44 File Offset: 0x00047C44
		private void OnCollectionCurrentViewChanged(object sender, EventArgs e)
		{
			int a_ = 0;
			short num = (short)550436864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				IAcpFeatureNode acpFeatureNode;
				CollectionView collectionView;
				for (;;)
				{
					IL_31:
					AcpTreeViewItem acpTreeViewItem2;
					switch (num2)
					{
					case 0:
						if (acpFeatureNode != null)
						{
							num = (short)814219271;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
						this.MyTreeView.CurrentRecord = acpFeatureNode;
						num = (short)444137484;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
					{
						AcpPageFeature acpPageFeature = (AcpPageFeature)this.winMain.FrameCenterTop.NavigationService.Content;
						AcpTreeViewItem acpTreeViewItem = this.MyTreeView.SelectedItem as AcpTreeViewItem;
						num = (short)2085421059;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
					{
						AcpTreeViewItem acpTreeViewItem;
						if (acpTreeViewItem != null)
						{
							num = (short)778829830;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						AppMultiInstanceManager.ParentRecsetPosition = collectionView.CurrentPosition;
						num = (short)1407516682;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
					{
						num = (short)720891020;
						short num3 = num;
						num = (short)895544460;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33E;
						default:
						{
							num = (short)43253761;
							if (num != 0)
							{
							}
							num = (short)176291840;
							if (num != 0)
							{
							}
							num = (short)1517223936;
							short num4 = num;
							AcpPageFeature acpPageFeature;
							if (acpPageFeature.ToString() == FixedLengthStream.b("귟跡郣觥髧藩胫迭\udeef뿱闳闵鏷鏹鋻鿽矿䄁吃唅☇䤉挋簍甏向焓眕気漙減笝匟డ縣䤥䘧伩漫䘭儯就娳匵吷笹伻䴽⤿╁⩃⭅ⵇ⑉㡋恍O㍑㍓㍕ɗ㕙㉛㭝⍟੡գࡥ٧ཀྵk⽭ͯűᵳᅵᙷ᝹᥻ၽ", a_))
							{
								num = (short)814219268;
								num2 = (int)((IntPtr)num);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 6:
						num = (short)1200029704;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						num = (short)1861287949;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
					{
						AcpTreeViewItem acpTreeViewItem;
						if (acpTreeViewItem.NodeId != 0)
						{
							num = (short)618725390;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
						goto IL_309;
					case 10:
						return;
					case 11:
						goto IL_33E;
					case 12:
						goto IL_309;
					case 13:
						if (this.preSelectedItem.NodeId != 0)
						{
							num = (short)987955201;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.MyTreeView.CurrentRecord = null;
						num = (short)2068185097;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						this.MyTreeView.CurrentRecord = acpFeatureNode;
						acpTreeViewItem2.Focus();
						num = (short)736034821;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_74;
					IL_309:
					acpTreeViewItem2 = this.MyTreeView.FindChildTreeViewItem(acpFeatureNode.Parent.RecsetId, acpFeatureNode.NodeId);
					num = (short)1842020363;
					num2 = (int)((IntPtr)num);
					continue;
					IL_33E:
					if (acpTreeViewItem2 == null)
					{
						break;
					}
					num = (short)1305083906;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_74:
				collectionView = (CollectionView)sender;
				acpFeatureNode = (IAcpFeatureNode)collectionView.CurrentItem;
				num = (short)583794688;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00049DD8 File Offset: 0x00047FD8
		private void DetachMenuItems()
		{
			short num = (short)479854592;
			short num2 = num;
			num = (short)1117888286;
			short num3 = num;
			num = (short)1978441502;
			switch (num3 == num)
			{
			}
			num = (short)1031471105;
			if (num != 0)
			{
			}
			num = (short)587071488;
			if (num != 0)
			{
			}
			this.mItemAdd = null;
			this.mItemDelete = null;
			this.mItemCopy = null;
			this.mItemPaste = null;
			this.cntxMenu = null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00049EA4 File Offset: 0x000480A4
		private void TreeView_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1012006912;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)258146304;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					continue;
				}
				case 1:
				{
					num = (short)1966562156;
					short num4 = num;
					num = (short)857693036;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
						goto IL_122;
					}
					break;
				}
				case 2:
				{
					AcpTreeViewItem acpTreeViewItem;
					this.OnContextMenuOpening(acpTreeViewItem);
					num = (short)245432321;
					if (num != 0)
					{
					}
					num = (short)815464449;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 3:
				{
					AcpTreeViewItem acpTreeViewItem;
					if (acpTreeViewItem != null)
					{
						num = (short)2085879810;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_17B;
				}
				case 4:
					goto IL_A3;
				case 5:
				{
					AcpTreeViewItem acpTreeViewItem = e.Source as AcpTreeViewItem;
					num = (short)1200029699;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_67:
				if (AppInfoManager.AppMode == ApplicationMode.CodeplugConfigurationMode)
				{
					num = (short)517472261;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_87:
				this.DetachMenuItems();
				num = (short)465895428;
				num2 = (int)((IntPtr)num);
			}
			IL_A3:
			goto IL_17B;
			IL_122:
			num = (short)1580728320;
			if (num != 0)
			{
			}
			IL_17B:
			e.Handled = true;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0004A034 File Offset: 0x00048234
		private void OnContextMenuOpening(AcpTreeViewItem treeViewItem)
		{
			short num = (short)1265958915;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				IAcpRecordset feature;
				switch (num2)
				{
				case 0:
					num = (short)1313800200;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_500;
				case 2:
					goto IL_629;
				case 3:
				{
					num = (short)633929728;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_E6;
					}
					continue;
				}
				case 4:
					if (treeViewItem.NodeId != -1)
					{
						num = (short)409403398;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_169;
				case 5:
					goto IL_27D;
				case 6:
					num = (short)1481310235;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					goto IL_58C;
				case 8:
				{
					if (feature.SingleInstance)
					{
						goto IL_7ED;
					}
					num = (short)1599946396;
					short num4 = num;
					num = (short)710098588;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_500;
					default:
						num = (short)1496055808;
						if (num != 0)
						{
						}
						num = (short)97517588;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					if (this.copyNode != null)
					{
						num = (short)1466761233;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_27D;
				case 10:
					goto IL_140;
				case 11:
					((MenuItem)this.cntxMenu.Items[0]).IsEnabled = false;
					num = (short)2031878151;
					num2 = (int)((IntPtr)num);
					continue;
				case 12:
					goto IL_27D;
				case 13:
					this.mItemAdd.IsEnabled = false;
					num = (short)908132354;
					num2 = (int)((IntPtr)num);
					continue;
				case 14:
					if (feature.CounterToMax <= 0)
					{
						num = (short)2099183629;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.mItemAdd.IsEnabled = true;
					num = (short)1631977490;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					this.mCanPaste = false;
					num = (short)755433484;
					num2 = (int)((IntPtr)num);
					continue;
				case 16:
					goto IL_471;
				case 17:
					num = (short)1938292762;
					num2 = (int)((IntPtr)num);
					continue;
				case 18:
					goto IL_629;
				case 19:
					num = (short)821886999;
					num2 = (int)((IntPtr)num);
					continue;
				case 20:
					treeViewItem.IsSelected = true;
					treeViewItem.Focus();
					this.mItemAdd = new MenuItem();
					this.mItemAdd.Header = AppResources.Add_ID;
					this.mItemDelete = null;
					this.mItemCopy = null;
					this.mItemPaste = new MenuItem();
					this.mItemPaste.Header = AcpResources.Paste_Id;
					this.cntxMenu = new ContextMenu();
					this.cntxMenu.Items.Add(this.mItemAdd);
					this.cntxMenu.Items.Add(this.mItemPaste);
					num = (short)459997198;
					num2 = (int)((IntPtr)num);
					continue;
				case 21:
					goto IL_538;
				case 22:
					this.preSelectedItem = treeViewItem;
					num = (short)1921056802;
					num2 = (int)((IntPtr)num);
					continue;
				case 23:
					if (!this.CanPaste(this.copyNode))
					{
						num = (short)936640527;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.mCanPaste = true;
					num = (short)1754726431;
					num2 = (int)((IntPtr)num);
					continue;
				case 24:
					treeViewItem.IsSelected = true;
					treeViewItem.Focus();
					this.mItemDelete = new MenuItem();
					this.mItemDelete.Header = AcpResources.Delete_Id;
					this.mItemCopy = new MenuItem();
					this.mItemCopy.Header = AcpResources.Copy_Id;
					this.mItemPaste = null;
					this.cntxMenu = new ContextMenu();
					this.cntxMenu.Items.Add(this.mItemDelete);
					this.cntxMenu.Items.Add(this.mItemCopy);
					num = (short)698482718;
					num2 = (int)((IntPtr)num);
					continue;
				case 25:
					if (treeViewItem.NodeId > 0)
					{
						num = (short)45809688;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 26:
					if (this.copyNode.Parent.RecsetId == treeViewItem.RecsetId)
					{
						num = (short)78512147;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.mCanPaste = false;
					num = (short)220397573;
					num2 = (int)((IntPtr)num);
					continue;
				case 27:
					if (treeViewItem != this.myTreeViewItemRoot)
					{
						num = (short)115998721;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_169;
				case 28:
					if (!this.mCanPaste)
					{
						num = (short)1199439909;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5CB;
				case 29:
					((MenuItem)this.cntxMenu.Items[1]).IsEnabled = false;
					num = (short)1739259936;
					num2 = (int)((IntPtr)num);
					continue;
				case 30:
					if (!this.CanDelete(treeViewItem))
					{
						num = (short)1340080139;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_58C;
				case 31:
					goto IL_27D;
				case 32:
					goto IL_3FD;
				case 33:
					if (!this.CanCopy(treeViewItem))
					{
						num = (short)1549008925;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FD;
				case 34:
					goto IL_7A0;
				case 35:
					if (treeViewItem.NodeId == 0)
					{
						num = (short)1616904192;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7ED;
				case 36:
					if (feature.SingleInstance)
					{
						num = (short)1065811989;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1085603875;
					num2 = (int)((IntPtr)num);
					continue;
				case 37:
					((MenuItem)this.cntxMenu.Items[1]).IsEnabled = false;
					num = (short)1306787850;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_E6:
				if (this.preSelectedItem == null)
				{
					num = (short)1260716054;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_7A0;
				IL_27D:
				num = (short)473563164;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3FD:
				base.ContextMenu = this.cntxMenu;
				this.cntxMenu.IsOpen = true;
				this.mItemDelete.Click += this.mItemDelete_Click;
				this.mItemCopy.Click += this.mItemCopy_Click;
				this.cntxMenu.Closed += this.OnContextMenuClosed;
				num = (short)566558736;
				num2 = (int)((IntPtr)num);
				continue;
				IL_500:
				num = (short)1201733668;
				num2 = (int)((IntPtr)num);
				continue;
				IL_58C:
				num = (short)2085748769;
				num2 = (int)((IntPtr)num);
				continue;
				IL_629:
				num = (short)97517577;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7A0:
				feature = FeatureManager.GetFeature(treeViewItem.RecsetId);
				num = (short)77856772;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7ED:
				num = (short)2121662489;
				num2 = (int)((IntPtr)num);
			}
			IL_140:
			goto IL_5CB;
			IL_169:
			base.ContextMenu = null;
			this.DetachMenuItems();
			return;
			IL_471:
			return;
			IL_538:
			num = (short)1952645121;
			if (num != 0)
			{
			}
			goto IL_169;
			IL_5CB:
			base.ContextMenu = this.cntxMenu;
			this.cntxMenu.IsOpen = true;
			this.mItemAdd.Click += this.mItemAdd_Click;
			this.mItemPaste.Click += this.mItemPaste_Click;
			this.cntxMenu.Closed += this.OnContextMenuClosed;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0004A890 File Offset: 0x00048A90
		private void mItemAdd_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 12;
			short num = (short)2115829760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				IAcpRecordset feature;
				DVRSFileListRecSet dvrsfileListRecSet;
				VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
				AcpTreeViewItem acpTreeViewItem;
				SystemCertificateListRecSet systemCertificateListRecSet;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						num = (short)189267996;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						if (feature.RecsetId != dvrsfileListRecSet.RecsetId)
						{
							num = (short)454492185;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_16A;
					case 2:
					{
						AppInfoManager.LoadingVoiceData = true;
						string[] array = null;
						num = (short)1446117395;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
						if (feature.RecsetId == voiceAnnouncementListRecSet.RecsetId)
						{
							num = (short)896925698;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_F72;
					case 4:
						goto IL_A29;
					case 5:
						goto IL_E71;
					case 6:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_26D;
							}
							bool? flag;
							bool flag2;
							AcpOpenFileDialog acpOpenFileDialog;
							for (;;)
							{
								IL_23E:
								string text;
								switch (num2)
								{
								case 0:
									goto IL_384;
								case 1:
									num = (short)891289603;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									if (flag.GetValueOrDefault() == flag2 & flag != null)
									{
										num = (short)1482358788;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_2E2;
								case 3:
									if (feature.Count < 1)
									{
										num = (short)1276772359;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_384;
								case 4:
									text = acpOpenFileDialog.FileName;
									num = (short)1604386825;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
									goto IL_3DE;
								case 6:
									goto IL_3F7;
								case 7:
									feature.AddDefaultRecord();
									num = (short)2067070976;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
									if (!string.IsNullOrEmpty(text))
									{
										num = (short)522452993;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_3DE;
								case 9:
									goto IL_2E2;
								}
								goto IL_26D;
								IL_2E2:
								num = (short)1941766152;
								num2 = (int)((IntPtr)num);
								continue;
								IL_384:
								DVRSFilesHelper.populateDvrsFileDbRecords(feature[0][10893] as DVRSFileLabtoolSection, text);
								num = (short)118882309;
								num2 = (int)((IntPtr)num);
								continue;
								IL_3DE:
								num = (short)1703477254;
								num2 = (int)((IntPtr)num);
							}
							IL_3F7:
							goto IL_E71;
							IL_26D:
							acpOpenFileDialog = new AcpOpenFileDialog();
							acpOpenFileDialog.Filter = FixedLengthStream.b("꣫룭ꋯꇱ퓳郵釷雹駻跽⃿⨁⸃⠅氇椉栋✍氏㠑㨓爕笗縙", a_);
							acpOpenFileDialog.MultiSelect = false;
							flag = acpOpenFileDialog.ShowDialog();
							flag2 = true;
							num = (short)160169986;
							num2 = (int)((IntPtr)num);
							goto IL_23E;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_419;
							}
							for (;;)
							{
								IL_406:
								switch (num2)
								{
								case 0:
									goto IL_46A;
								case 1:
								{
									bool flag3;
									if (flag3)
									{
										num = (short)564002818;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_46C;
								}
								case 2:
									UndoManager.StartUndoRedo();
									num = (short)1891303424;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_419;
							}
							IL_46A:
							IL_46C:
							goto EndFinally_41;
							IL_419:
							AppInfoManager.LoadingVoiceData = false;
							num = (short)1875705857;
							num2 = (int)((IntPtr)num);
							goto IL_406;
							EndFinally_41:;
						}
						goto IL_46D;
					case 7:
						this.MyTreeView.LaunchPage(feature.UIPagePath);
						((CollectionView)CollectionViewSource.GetDefaultView(feature)).MoveCurrentToLast();
						this.preSelectedItem = acpTreeViewItem;
						num = (short)962461708;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
					{
						bool flag3 = UndoManager.StopUndoRedo();
						AppInfoManager.LoadingVoiceData = true;
						string text = string.Empty;
						num = (short)1021640710;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 9:
						goto IL_9E3;
					case 10:
						num = (short)624427009;
						if (num != 0)
						{
						}
						if (feature.RecsetId == systemCertificateListRecSet.RecsetId)
						{
							num = (short)1844314133;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_FB0;
					case 11:
						num = (short)1886257170;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_1E8;
					case 13:
						num = (short)1876033537;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						goto IL_46D;
					case 15:
						if (feature.RecsetId != systemCertificateListRecSet.RecsetId)
						{
							num = (short)82444301;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_16A;
					case 16:
						if (feature != null)
						{
							num = (short)2119630874;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_FB0;
					case 17:
						if (feature != null)
						{
							num = (short)1706426391;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_F72;
					case 18:
						if (feature.RecsetId != voiceAnnouncementListRecSet.RecsetId)
						{
							num = (short)1445003268;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_16A;
					case 19:
						try
						{
							num = (short)1981939723;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								bool? flag;
								bool flag2;
								AcpOpenFileDialog acpOpenFileDialog2;
								switch (num2)
								{
								case 0:
									goto IL_CCC;
								case 1:
									goto IL_E4C;
								case 2:
									goto IL_D8B;
								case 3:
								{
									int counterToMax;
									if (this.voiceAnnFiles.Length <= counterToMax)
									{
										num = (short)1316028429;
										num2 = (int)((IntPtr)num);
										continue;
									}
									feature.AddMultipleDefaultRecords(counterToMax);
									num = (short)1360003073;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
								{
									List<string> list;
									string[] array = list.ToArray();
									num = (short)1295712263;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 5:
								{
									if (this.voiceAnnFiles.Length == 1)
									{
										num = (short)1901592592;
										num2 = (int)((IntPtr)num);
										continue;
									}
									int counterToMax = feature.CounterToMax;
									num = (short)1526530051;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
									goto IL_E65;
								case 7:
									goto IL_D8B;
								case 8:
								{
									List<string> list = this.SelectVAFileDialog(SelectionMode.Extended);
									num = (short)79364117;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 9:
								{
									string[] array;
									if (array != null)
									{
										num = (short)1790050321;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_E4C;
								}
								case 10:
									goto IL_CA7;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_AF8;
									}
									continue;
								case 12:
								{
									string[] array;
									this.voiceAnnFiles = new string[array.Length];
									Array.Copy(array, this.voiceAnnFiles, array.Length);
									VoiceAnnouncementListRecSet.vaCount = 0;
									VoiceAnnouncementListRecSet.voiceFiles = null;
									VoiceAnnouncementListRecSet.voiceFiles = new string[this.voiceAnnFiles.Length];
									Array.Copy(this.voiceAnnFiles, VoiceAnnouncementListRecSet.voiceFiles, array.Length);
									CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(feature);
									num = (short)1705967621;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 13:
									feature.AddMultipleDefaultRecords(this.voiceAnnFiles.Length);
									num = (short)120389642;
									num2 = (int)((IntPtr)num);
									continue;
								case 14:
								{
									List<string> list;
									if (list.Count > 0)
									{
										num = (short)1428946948;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_D8B;
								}
								case 15:
								{
									string[] array = acpOpenFileDialog2.FileNames;
									num = (short)1136852994;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 16:
									feature.AddDefaultRecord();
									num = (short)1763966976;
									num2 = (int)((IntPtr)num);
									continue;
								case 17:
									num = (short)1309605906;
									num2 = (int)((IntPtr)num);
									continue;
								case 18:
								{
									string[] array;
									if (array.Length != 0)
									{
										num = (short)1206059020;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_E4C;
								}
								case 19:
									num = (short)6029326;
									num2 = (int)((IntPtr)num);
									continue;
								case 20:
									if (flag.GetValueOrDefault() == flag2 & flag != null)
									{
										num = (short)1802764303;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_D8B;
								case 21:
								{
									List<string> list;
									if (list != null)
									{
										num = (short)1398210579;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_D8B;
								}
								}
								IL_AF8:
								if (this.SelectVAFileDialog != null)
								{
									num = (short)1957625864;
									num2 = (int)((IntPtr)num);
									continue;
								}
								acpOpenFileDialog2 = new AcpOpenFileDialog();
								acpOpenFileDialog2.Filter = FixedLengthStream.b("ꇫ臭蓯鷱蛳駵铷鯹\udcfbꣽ濿欁會挅⠇䬉戋怍缏朑稓甕紗眙礛瀝吟ȡ䈣伥䐧伩弫อᠯᠱᨳ嬵丷嬹ᔻ䈽樿汁⥃ぅ⥇", a_);
								acpOpenFileDialog2.MultiSelect = true;
								flag = acpOpenFileDialog2.ShowDialog();
								flag2 = true;
								num = (short)313131028;
								num2 = (int)((IntPtr)num);
								continue;
								IL_D8B:
								num = (short)1387921417;
								num2 = (int)((IntPtr)num);
								continue;
								IL_E4C:
								num = (short)748158982;
								num2 = (int)((IntPtr)num);
							}
							IL_CA7:
							IL_CCC:
							IL_E65:;
						}
						finally
						{
							AppInfoManager.LoadingVoiceData = false;
						}
						goto IL_E71;
					case 20:
						if (feature != null)
						{
							num = (short)2032599051;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_16A;
					case 21:
					{
						AppInfoManager.LoadingVoiceData = true;
						string[] array2 = null;
						num = (short)488964118;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 22:
						try
						{
							num = (short)1783496715;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								bool? flag;
								bool flag2;
								AcpOpenFileDialog acpOpenFileDialog3;
								switch (num2)
								{
								case 0:
									goto IL_6BC;
								case 1:
								{
									List<string> list2;
									if (list2 != null)
									{
										num = (short)91684885;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_568;
								}
								case 2:
									feature.AddDefaultRecord();
									num = (short)216727570;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
								{
									List<string> list2;
									if (list2.Count > 0)
									{
										num = (short)1464074253;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_568;
								}
								case 4:
									num = (short)567672849;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
									if (flag.GetValueOrDefault() == flag2 & flag != null)
									{
										num = (short)1589968912;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_568;
								case 6:
									goto IL_8BA;
								case 7:
								{
									string[] array2;
									this.systemCertificateFiles = new string[array2.Length];
									Array.Copy(array2, this.systemCertificateFiles, array2.Length);
									SystemCertificateListRecSet.systemCertificateCount = 0;
									SystemCertificateListRecSet.systemCertificateFiles = null;
									SystemCertificateListRecSet.systemCertificateFiles = new string[this.systemCertificateFiles.Length];
									Array.Copy(this.systemCertificateFiles, SystemCertificateListRecSet.systemCertificateFiles, array2.Length);
									CollectionView collectionView2 = (CollectionView)CollectionViewSource.GetDefaultView(feature);
									num = (short)861470732;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 8:
								{
									List<string> list2 = this.SelectVAFileDialog(SelectionMode.Extended);
									num = (short)273416193;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 9:
									goto IL_568;
								case 10:
									goto IL_568;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_546;
									}
									continue;
								case 12:
								{
									if (this.systemCertificateFiles.Length == 1)
									{
										num = (short)475529218;
										num2 = (int)((IntPtr)num);
										continue;
									}
									int counterToMax2 = feature.CounterToMax;
									num = (short)2014511124;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 13:
								{
									List<string> list2;
									string[] array2 = list2.ToArray();
									num = (short)1671757833;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 14:
								{
									string[] array2;
									if (array2 != null)
									{
										num = (short)460455940;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_8A0;
								}
								case 15:
									feature.AddMultipleDefaultRecords(this.systemCertificateFiles.Length);
									num = (short)575143936;
									num2 = (int)((IntPtr)num);
									continue;
								case 16:
								{
									string[] array2 = acpOpenFileDialog3.FileNames;
									num = (short)1298923530;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 17:
								{
									string[] array2;
									if (array2.Length != 0)
									{
										num = (short)2017853447;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_8A0;
								}
								case 18:
									goto IL_7F9;
								case 19:
									goto IL_8A0;
								case 20:
								{
									int counterToMax2;
									if (this.systemCertificateFiles.Length <= counterToMax2)
									{
										num = (short)63504399;
										num2 = (int)((IntPtr)num);
										continue;
									}
									feature.AddMultipleDefaultRecords(counterToMax2);
									num = (short)90243091;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 21:
									num = (short)1104740355;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_546:
								if (this.SelectVAFileDialog != null)
								{
									num = (short)39321608;
									num2 = (int)((IntPtr)num);
									continue;
								}
								acpOpenFileDialog3 = new AcpOpenFileDialog();
								acpOpenFileDialog3.Filter = FixedLengthStream.b("꿫语苯蛱鷳郵釷駹鷻諽旿∁戃漅搇漉缋⸍㠏㠑㨓㰕ㄗ昙㘛〝ਟ", a_);
								acpOpenFileDialog3.MultiSelect = true;
								flag = acpOpenFileDialog3.ShowDialog();
								flag2 = true;
								num = (short)1802895365;
								num2 = (int)((IntPtr)num);
								continue;
								IL_568:
								num = (short)408813582;
								num2 = (int)((IntPtr)num);
								continue;
								IL_8A0:
								num = (short)118161414;
								num2 = (int)((IntPtr)num);
							}
							IL_6BC:
							IL_7F9:
							IL_8BA:
							goto IL_E71;
						}
						finally
						{
							AppInfoManager.LoadingVoiceData = false;
						}
						goto IL_8C6;
					case 23:
						goto IL_8C6;
					case 24:
					{
						if (this.preSelectedItem.NodeId != 0)
						{
							num = (short)1423573006;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)359149117;
						short num3 = num;
						num = (short)163982909;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A29;
						default:
							num = (short)1878196224;
							if (num != 0)
							{
							}
							this.preSelectedItem = acpTreeViewItem;
							num = (short)326369289;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 25:
						((Recordset)feature).AddDefaultRecord();
						num = (short)1197998085;
						num2 = (int)((IntPtr)num);
						continue;
					case 26:
						num = (short)1289486346;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
						if (feature != null)
						{
							num = (short)416808960;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E71;
					case 28:
						if (feature.RecsetId == dvrsfileListRecSet.RecsetId)
						{
							num = (short)980811784;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E71;
					case 29:
						goto IL_4C2;
					case 30:
					{
						if (this.preSelectedItem.RecsetId != acpTreeViewItem.RecsetId)
						{
							num = (short)1895497735;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1047265280;
						short num4 = num;
						num = (short)1264648216;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_B3;
					IL_16A:
					num = (short)1080950801;
					num2 = (int)((IntPtr)num);
					continue;
					IL_46D:
					acpTreeViewItem.IsSelected = false;
					AcpTreeViewItem acpTreeViewItem2 = this.MyTreeView.FindChildTreeViewItem(feature.RecsetId, feature[feature.Count - 1].NodeId);
					acpTreeViewItem2.IsSelected = true;
					this.preSelectedItem = acpTreeViewItem2;
					num = (short)549715997;
					num2 = (int)((IntPtr)num);
					continue;
					IL_8C6:
					num = (short)1994194947;
					num2 = (int)((IntPtr)num);
					continue;
					IL_A29:
					num = (short)1769668623;
					num2 = (int)((IntPtr)num);
					continue;
					IL_E71:
					num = (short)1911685150;
					num2 = (int)((IntPtr)num);
					continue;
					IL_F72:
					num = (short)298844176;
					num2 = (int)((IntPtr)num);
					continue;
					IL_FB0:
					num = (short)1933508635;
					num2 = (int)((IntPtr)num);
				}
				IL_1E8:
				IL_4C2:
				IL_9E3:
				this.bRecordOpPerformed = true;
				return;
				IL_B3:
				acpTreeViewItem = (this.MyTreeView.SelectedItem as AcpTreeViewItem);
				feature = FeatureManager.GetFeature(acpTreeViewItem.RecsetId);
				voiceAnnouncementListRecSet = (FeatureManager.GetFeature(2300) as VoiceAnnouncementListRecSet);
				systemCertificateListRecSet = (FeatureManager.GetFeature(4228) as SystemCertificateListRecSet);
				dvrsfileListRecSet = (FeatureManager.GetFeature(4234) as DVRSFileListRecSet);
				num = (short)1639120916;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0004B94C File Offset: 0x00049B4C
		private void mItemDelete_Click(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			AcpTreeViewItem acpTreeViewItem;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.preSelectedItem.RecsetId != acpTreeViewItem.RecsetId)
					{
						num2 = (short)1288044546;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_15C;
				case 1:
				{
					num2 = (short)1778268980;
					short num3 = num2;
					num2 = (short)473643828;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C1;
					default:
						goto IL_11F;
					}
					break;
				}
				case 2:
					goto IL_C1;
				}
				goto IL_1C;
				IL_C1:
				this.MyTreeView.NavigateToContentPage(this.MyTreeView);
				num2 = (short)1674117121;
				num = (int)((IntPtr)num2);
			}
			IL_11F:
			num2 = (short)1367867392;
			if (num2 != 0)
			{
			}
			num2 = (short)3145729;
			if (num2 != 0)
			{
			}
			IL_15C:
			this.preSelectedItem = (this.MyTreeView.SelectedItem as AcpTreeViewItem);
			this.bRecordOpPerformed = true;
			return;
			IL_1C:
			acpTreeViewItem = (this.MyTreeView.SelectedItem as AcpTreeViewItem);
			IAcpRecordset feature = FeatureManager.GetFeature(acpTreeViewItem.RecsetId);
			IAcpFeatureNode record = feature.NodeFromId(acpTreeViewItem.NodeId);
			feature.RemoveRecordAt(feature.IndexOf(record));
			num2 = (short)832569344;
			short num4 = num2;
			num2 = (short)93913088;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0004BAD4 File Offset: 0x00049CD4
		private void mItemCopy_Click(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			AcpTreeViewItem acpTreeViewItem;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_13A;
				case 1:
					if (this.preSelectedItem.RecsetId != acpTreeViewItem.RecsetId)
					{
						goto IL_76;
					}
					acpTreeViewItem.IsSelected = false;
					this.preSelectedItem.IsSelected = true;
					num2 = (short)477888514;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					goto IL_BB;
				case 3:
				{
					this.MyTreeView.NavigateToContentPage(this.MyTreeView);
					this.preSelectedItem = acpTreeViewItem;
					num2 = (short)59742305;
					short num3 = num2;
					num2 = (short)835819617;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_76;
					default:
						num2 = (short)1870987264;
						if (num2 != 0)
						{
						}
						num2 = (short)567017472;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_76:
				num2 = (short)271843331;
				num = (int)((IntPtr)num2);
			}
			IL_BB:
			goto IL_18E;
			IL_13A:
			num2 = (short)2089746433;
			if (num2 != 0)
			{
			}
			num2 = (short)50855936;
			short num4 = num2;
			IL_18E:
			this.bRecordOpPerformed = true;
			return;
			IL_20:
			acpTreeViewItem = (this.MyTreeView.SelectedItem as AcpTreeViewItem);
			IAcpFeatureNode acpFeatureNode = FeatureManager.GetFeature(acpTreeViewItem.RecsetId).NodeFromId(acpTreeViewItem.NodeId);
			this.copyNode = acpFeatureNode;
			num2 = (short)837287937;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0004BC78 File Offset: 0x00049E78
		private void mItemPaste_Click(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			AcpTreeViewItem acpTreeViewItem;
			IAcpRecordset feature;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_F8;
				case 1:
					goto IL_173;
				case 2:
					if (this.preSelectedItem.NodeId != 0)
					{
						num2 = (short)946405380;
						num = (int)((IntPtr)num2);
						continue;
					}
					this.preSelectedItem = acpTreeViewItem;
					num2 = (short)352190465;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					num2 = (short)787283969;
					if (num2 != 0)
					{
					}
					goto IL_FD;
				case 4:
				{
					acpTreeViewItem.IsSelected = false;
					AcpTreeViewItem acpTreeViewItem2 = this.MyTreeView.FindChildTreeViewItem(feature.RecsetId, feature[feature.Count - 1].NodeId);
					acpTreeViewItem2.IsSelected = true;
					this.preSelectedItem = acpTreeViewItem2;
					num2 = (short)752615424;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 5:
				{
					bool flag = ((Recordset)feature).AddCopyOf(feature.IndexOf(this.copyNode));
					this.FixForAstroOtarProfileGUID(feature);
					if (!flag)
					{
						num2 = (short)1594032134;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1015939079;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_A1;
				case 7:
					if (this.preSelectedItem.RecsetId != acpTreeViewItem.RecsetId)
					{
						num2 = (short)969272454;
						short num3 = num2;
						num2 = (short)2051927174;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FD;
						case 1:
							break;
						default:
						{
							num2 = (short)958922752;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)2084044800;
						if (num2 != 0)
						{
						}
						num2 = (short)2107244547;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)2051997698;
					num = (int)((IntPtr)num2);
					continue;
				case 8:
					goto IL_13E;
				}
				goto IL_34;
				IL_FD:
				this.MyTreeView.LaunchPage(feature.UIPagePath);
				((CollectionView)CollectionViewSource.GetDefaultView(feature)).MoveCurrentToLast();
				this.preSelectedItem = acpTreeViewItem;
				num2 = (short)1217134600;
				num = (int)((IntPtr)num2);
			}
			IL_A1:
			AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Info, AppResources.Paste_Operation);
			return;
			IL_F8:
			IL_13E:
			IL_173:
			this.bRecordOpPerformed = true;
			return;
			IL_34:
			acpTreeViewItem = (this.MyTreeView.SelectedItem as AcpTreeViewItem);
			feature = FeatureManager.GetFeature(acpTreeViewItem.RecsetId);
			num2 = (short)1804009477;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0004BF30 File Offset: 0x0004A130
		private void FixForAstroOtarProfileGUID(IAcpRecordset recset)
		{
			short num = (short)82051076;
			int num2 = (int)((IntPtr)num);
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_243;
				case 1:
				{
					string value;
					if ((recset[num3] as SecureKMFProfile).General.SecKmfProfileSecureProfileGUID_43662.Value == value)
					{
						num = (short)1422721024;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num3++;
					num = (short)324840067;
					short num4 = num;
					num = (short)1915136643;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_243;
					default:
						num = (short)433324032;
						if (num != 0)
						{
						}
						num = (short)1861550083;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_1EC;
				case 3:
					num = (short)344260609;
					if (num != 0)
					{
					}
					goto IL_18E;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
				{
					int num5 = (recset as SecureKMFProfileRecset).Count - 1;
					string value = (recset[num5] as SecureKMFProfile).General.SecKmfProfileSecureProfileGUID_43662.Value;
					(recset[num5] as SecureKMFProfile).General.SecKmfProfileSecureProfileGUID_43662.Value = CodeplugGuid.NewGuid();
					num3 = 0;
					num = (short)752025607;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 6:
				{
					int num5;
					if (num3 > num5)
					{
						num = (short)1874460672;
						short num6 = num;
						num = (short)819265538;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1490288641;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 7:
					goto IL_18E;
				}
				IL_45:
				if (this.copyNode.FeatureName == AcgResources.ID_ASTROOTARPROFILE)
				{
					num = (short)1242890245;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_18E:
				num = (short)1835073542;
				num2 = (int)((IntPtr)num);
			}
			IL_1EC:
			return;
			IL_243:
			(recset[num3] as SecureKMFProfile).General.SecKmfProfileSecureProfileGUID_43662.CalculateValidity();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0004C188 File Offset: 0x0004A388
		private bool CanDelete(AcpTreeViewItem item)
		{
			short num = (short)932511744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				bool result;
				IEnumerator<FeatureNode> enumerator;
				IAcpRecordset feature;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_2F3;
					case 1:
						IL_6E:
						try
						{
							num = (short)422313989;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)247136259;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_1E0;
								case 2:
									result = false;
									num = (short)811728903;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
								{
									IAcpFeatureNode acpFeatureNode;
									if (Permission.Have(Permissions.Undeletable, acpFeatureNode.Permissions))
									{
										num = (short)573636610;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1E0;
								}
								case 4:
									goto IL_1F9;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_FD;
									}
									continue;
								case 6:
								{
									IAcpFeatureNode acpFeatureNode;
									if (acpFeatureNode.ReferenceKey == item.ReferenceKey)
									{
										num = (short)609550336;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2095841281;
										num2 = (int)((IntPtr)num);
										continue;
									}
									IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1569849350;
									num2 = (int)((IntPtr)num);
									continue;
								}
								}
								IL_146:
								num = (short)960954376;
								num2 = (int)((IntPtr)num);
								continue;
								IL_FD:
								goto IL_146;
								IL_1E0:
								num = (short)1247019012;
								num2 = (int)((IntPtr)num);
							}
							IL_1F9:
							goto IL_70;
						}
						finally
						{
							num = (short)777125888;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_231;
									}
									continue;
								case 1:
									goto IL_266;
								case 2:
									enumerator.Dispose();
									num = (short)1840906241;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_231:
								if (enumerator == null)
								{
									break;
								}
								num = (short)610271234;
								num2 = (int)((IntPtr)num);
							}
							IL_266:;
						}
						goto IL_269;
						IL_70:
						num = (short)1040449539;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						goto IL_269;
					case 3:
						if (feature.Count == feature.Min)
						{
							num = (short)926875650;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_3E;
					IL_269:
					result = false;
					num = (short)1772534353;
					short num3 = num;
					num = (short)1969404497;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6E;
					default:
						num = (short)992018433;
						if (num != 0)
						{
						}
						num = (short)116981760;
						if (num != 0)
						{
						}
						num = (short)288292864;
						num2 = (int)((IntPtr)num);
						break;
					}
				}
				IL_2F3:
				num = (short)2133852160;
				short num4 = num;
				return result;
				IL_3E:
				result = true;
				feature = FeatureManager.GetFeature(item.RecsetId);
				enumerator = (feature as Recordset).GetEnumerator();
				num = (short)1287389185;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0004C4D0 File Offset: 0x0004A6D0
		private bool CanPaste(IAcpFeatureNode node)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool result;
			IAcpRecordset parent;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					flag = true;
					goto IL_162;
				case 1:
					if (!Permission.Have(Permissions.CopyDisabled, node.Permissions))
					{
						num2 = (short)555548679;
						num = (int)((IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					if (parent.GetCounterToMaxCopiesOf(parent.IndexOf(node)) <= 0)
					{
						num2 = (short)1941372932;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)2061977676;
					short num3 = num2;
					num2 = (short)2085570636;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E7;
					default:
						num2 = (short)1532428288;
						if (num2 != 0)
						{
						}
						num2 = (short)1147469824;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
					goto IL_1E7;
				case 5:
					if (parent.IndexOf(node) >= 0)
					{
						num2 = (short)1585577990;
						num = (int)((IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					num2 = (short)1088487425;
					if (num2 != 0)
					{
					}
					num2 = (short)682819585;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1467744258;
					num = (int)((IntPtr)num2);
					continue;
				case 8:
					flag = false;
					goto IL_162;
				}
				goto IL_34;
				IL_162:
				result = flag;
				num2 = (short)963903488;
				short num4 = num2;
				num2 = (short)1876623363;
				num = (int)((IntPtr)num2);
				continue;
				IL_1E7:
				num2 = (short)1865351176;
				num = (int)((IntPtr)num2);
			}
			return result;
			IL_34:
			result = false;
			parent = node.Parent;
			num2 = (short)1992884229;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0004C6CC File Offset: 0x0004A8CC
		private bool CanCopy(AcpTreeViewItem item)
		{
			bool result = true;
			IEnumerator<FeatureNode> enumerator = (FeatureManager.GetFeature(item.RecsetId) as Recordset).GetEnumerator();
			short num;
			try
			{
				num = (short)1572143108;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1597046785;
							num2 = (int)((IntPtr)num);
							continue;
						}
						IAcpFeatureNode acpFeatureNode = enumerator.Current;
						num = (short)727842822;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						goto IL_192;
					case 2:
						result = false;
						num = (short)477298693;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
					{
						IAcpFeatureNode acpFeatureNode;
						if (Permission.Have(Permissions.CopyDisabled, acpFeatureNode.Permissions))
						{
							num = (short)790626306;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_192;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 6:
					{
						IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode.ReferenceKey == item.ReferenceKey)
						{
							num = (short)46137352;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_1A9;
					case 8:
					{
						num = (short)1921545533;
						short num3 = num;
						num = (short)607089981;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2013003776;
							if (num != 0)
							{
							}
							num = (short)1238695939;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_F5:
					num = (short)530907136;
					num2 = (int)((IntPtr)num);
					continue;
					IL_62:
					goto IL_F5;
					IL_192:
					num = (short)2046296071;
					num2 = (int)((IntPtr)num);
				}
				IL_1A9:;
			}
			finally
			{
				num = (short)301727746;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)555941889;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						goto IL_215;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1E0;
						}
						continue;
					}
					IL_1E0:
					if (enumerator == null)
					{
						goto IL_23F;
					}
					num = (short)1926823936;
					num2 = (int)((IntPtr)num);
				}
				IL_215:
				num = (short)1139539969;
				if (num != 0)
				{
				}
				IL_23F:;
			}
			num = (short)1298530304;
			short num4 = num;
			return result;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0004C960 File Offset: 0x0004AB60
		private void OnContextMenuClosed(object sender, RoutedEventArgs e)
		{
			short num = (short)1257242626;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (this.preSelectedItem == null)
					{
						return;
					}
					num = (short)1605898578;
					short num3 = num;
					num = (short)1724518738;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)752680960;
						if (num != 0)
						{
						}
						num = (short)1978925059;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 3:
				{
					num = (short)2083454977;
					if (num != 0)
					{
					}
					num = (short)983105536;
					short num4 = num;
					this.preSelectedItem.IsSelected = true;
					num = (short)662765569;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 4:
					goto IL_58;
				}
				IL_39:
				if (this.bRecordOpPerformed)
				{
					num = (short)1792802820;
					num2 = (int)((IntPtr)num);
				}
				else
				{
					(this.MyTreeView.SelectedItem as AcpTreeViewItem).IsSelected = false;
					num = (short)1562181632;
					num2 = (int)((IntPtr)num);
				}
			}
			IL_58:
			this.bRecordOpPerformed = false;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0004CAEC File Offset: 0x0004ACEC
		protected override void OnPreviewKeyDown(KeyEventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)1478557697;
				if (num != 0)
				{
				}
				if (e.Key == Key.Apps)
				{
					num = (short)1840538289;
					short num2 = num;
					num = (short)245457585;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_92;
					}
					break;
				}
				goto IL_B0;
			}
			num = (short)51183616;
			short num3 = num;
			IL_92:
			num = (short)989134848;
			if (num != 0)
			{
			}
			e.Handled = true;
			return;
			IL_B0:
			base.OnPreviewKeyDown(e);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		protected override void OnPreviewKeyUp(KeyEventArgs e)
		{
			while (e.Key == Key.Apps)
			{
				short num = (short)2061094993;
				short num2 = num;
				num = (short)1820643409;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1124335616;
					short num3 = num;
					num = (short)1546715136;
					if (num != 0)
					{
					}
					num = (short)724041729;
					if (num != 0)
					{
					}
					e.Handled = true;
					return;
				}
				}
			}
			base.OnPreviewKeyUp(e);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0004CC78 File Offset: 0x0004AE78
		private void InitializePageTreeView()
		{
			short num = (short)1564803315;
			int num2 = (int)((IntPtr)num);
			AcpTreeViewItem acpTreeViewItem2;
			for (;;)
			{
				AcpTreeViewItem acpTreeViewItem;
				switch (num2)
				{
				case 0:
					if (AppInfoManager.DefaultDocument.GetFeature(2064).HiddenStatic)
					{
						num = (short)293273849;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_18ED;
				case 1:
					if (AppInfoManager.DefaultDocument.GetFeature(2062) != null)
					{
						num = (short)350093748;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_499F;
				case 2:
					num = (short)504365580;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_1F5C;
				case 4:
					if (FeatureManager.GetFeature(2027) != null)
					{
						num = (short)1826882070;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_DB4;
				case 5:
					if (FeatureManager.GetFeature(4148) != null)
					{
						num = (short)1721565396;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_45D0;
				case 6:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1639186759;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)575799524;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					num = (short)445317545;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					goto IL_1FA3;
				case 9:
					if (AppInfoManager.DefaultDocument.GetFeature(2212) != null)
					{
						num = (short)1330971276;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2AF1;
				case 10:
					if (!FeatureManager.GetFeature(2076).HiddenStatic)
					{
						num = (short)1027277082;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6BD2;
				case 11:
					goto IL_57D2;
				case 12:
					if (FeatureManager.GetFeature(2033) != null)
					{
						num = (short)1041301775;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_66BB;
				case 13:
					if (FeatureManager.GetFeature(4115).HiddenStatic)
					{
						num = (short)516882686;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 14:
					if (AppInfoManager.DefaultDocument.GetFeature(2086).HiddenStatic)
					{
						num = (short)1604845766;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 15:
					if (FeatureManager.GetFeature(4228) != null)
					{
						num = (short)1384186325;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7201;
				case 16:
					if (FeatureManager.GetFeature(2125) != null)
					{
						num = (short)645071220;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_581A;
				case 17:
					num = (short)421593145;
					num2 = (int)((IntPtr)num);
					continue;
				case 18:
					num = (short)305332301;
					num2 = (int)((IntPtr)num);
					continue;
				case 19:
					if (AppInfoManager.DefaultDocument.GetFeature(2214).HiddenStatic)
					{
						num = (short)1452933426;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_32CE;
				case 20:
					num = (short)617742361;
					num2 = (int)((IntPtr)num);
					continue;
				case 21:
					num = (short)732299711;
					num2 = (int)((IntPtr)num);
					continue;
				case 22:
					goto IL_6BD2;
				case 23:
					if (FeatureManager.GetFeature(2077) != null)
					{
						num = (short)812253507;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2397;
				case 24:
					num = (short)1223361204;
					num2 = (int)((IntPtr)num);
					continue;
				case 25:
					if (FeatureManager.GetFeature(2021).HiddenStatic)
					{
						num = (short)795542178;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_51E9;
				case 26:
					if (AppInfoManager.DefaultDocument.GetFeature(2200).HiddenStatic)
					{
						num = (short)102957369;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_32CE;
				case 27:
					if (AppInfoManager.DefaultDocument.GetFeature(4176) != null)
					{
						num = (short)1029898338;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1578;
				case 28:
					num = (short)902365846;
					num2 = (int)((IntPtr)num);
					continue;
				case 29:
					if (AppInfoManager.DefaultDocument.GetFeature(2087) != null)
					{
						num = (short)1655636179;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3531;
				case 30:
					if (FeatureManager.GetFeature(2127) != null)
					{
						num = (short)1046282454;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3110;
				case 31:
					if (FeatureManager.GetFeature(2125).HiddenStatic)
					{
						num = (short)2011496854;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 32:
					if (AppInfoManager.DefaultDocument.GetFeature(4115) != null)
					{
						num = (short)1057357831;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_74A1;
				case 33:
					if (FeatureManager.GetFeature(2038) != null)
					{
						goto IL_3BDF;
					}
					goto IL_2D4E;
				case 34:
					if (FeatureManager.GetFeature(4003) != null)
					{
						num = (short)1244201648;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3ECB;
				case 35:
					num = (short)601555057;
					num2 = (int)((IntPtr)num);
					continue;
				case 36:
					goto IL_6CE3;
				case 37:
					if (FeatureManager.GetFeature(4115) != null)
					{
						num = (short)991363689;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4448;
				case 38:
					num = (short)1370423643;
					num2 = (int)((IntPtr)num);
					continue;
				case 39:
					num = (short)1980563603;
					num2 = (int)((IntPtr)num);
					continue;
				case 40:
					if (AppInfoManager.DefaultDocument.GetFeature(4142).HiddenStatic)
					{
						num = (short)1511850423;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4E1D;
				case 41:
					num = (short)724173491;
					num2 = (int)((IntPtr)num);
					continue;
				case 42:
					if (AppInfoManager.DefaultDocument.GetFeature(2027).HiddenStatic)
					{
						num = (short)2105999645;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_18ED;
				case 43:
					if (FeatureManager.GetFeature(2212) != null)
					{
						num = (short)82117279;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_31A1;
				case 44:
					goto IL_3924;
				case 45:
					goto IL_1E76;
				case 46:
					if (FeatureManager.GetFeature(2057) != null)
					{
						num = (short)583139349;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 47:
					goto IL_752F;
				case 48:
					if (AppInfoManager.DefaultDocument.GetFeature(2057) != null)
					{
						num = (short)585826672;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 49:
					if (!FeatureManager.GetFeature(4234).HiddenStatic)
					{
						num = (short)1697906742;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_709B;
				case 50:
					num = (short)300614126;
					num2 = (int)((IntPtr)num);
					continue;
				case 51:
					num = (short)246874542;
					num2 = (int)((IntPtr)num);
					continue;
				case 52:
					num = (short)1392115776;
					num2 = (int)((IntPtr)num);
					continue;
				case 53:
					if (AppInfoManager.DefaultDocument.GetFeature(2038).HiddenStatic)
					{
						num = (short)692191574;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 54:
					goto IL_1ACE;
				case 55:
					if (FeatureManager.GetFeature(2210) != null)
					{
						num = (short)1568604757;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3A5D;
				case 56:
					if (!AppInfoManager.DefaultDocument.GetFeature(4148).HiddenStatic)
					{
						num = (short)1591476812;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_45D0;
				case 57:
					if (AppInfoManager.DefaultDocument.GetFeature(2210).HiddenStatic)
					{
						num = (short)632160685;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_32CE;
				case 58:
					goto IL_46B3;
				case 59:
					num = (short)302318113;
					num2 = (int)((IntPtr)num);
					continue;
				case 60:
					goto IL_230B;
				case 61:
					num = (short)211419415;
					num2 = (int)((IntPtr)num);
					continue;
				case 62:
				{
					num = (short)1166790713;
					short num3 = num;
					num = (short)1058197561;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3BDF;
					default:
						num = (short)1249116160;
						if (num != 0)
						{
						}
						num = (short)1794965725;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 63:
					goto IL_74A1;
				case 64:
					if (AppInfoManager.DefaultDocument.GetFeature(2300).HiddenStatic)
					{
						num = (short)1587216887;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 65:
					if (AppInfoManager.DefaultDocument.GetFeature(4145).HiddenStatic)
					{
						num = (short)1733427612;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 66:
					if (AppInfoManager.DefaultDocument.GetFeature(2064) != null)
					{
						num = (short)1411580079;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_14E7;
				case 67:
					goto IL_4F12;
				case 68:
					goto IL_2732;
				case 69:
					num = (short)471007688;
					num2 = (int)((IntPtr)num);
					continue;
				case 70:
					if (FeatureManager.GetFeature(2038).HiddenStatic)
					{
						num = (short)482410636;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 71:
					num = (short)124715469;
					num2 = (int)((IntPtr)num);
					continue;
				case 72:
					if (!AppInfoManager.DefaultDocument.GetFeature(2076).HiddenStatic)
					{
						num = (short)1582957224;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6BD2;
				case 73:
					num = (short)266469418;
					num2 = (int)((IntPtr)num);
					continue;
				case 74:
					goto IL_6C53;
				case 75:
					num = (short)936313254;
					num2 = (int)((IntPtr)num);
					continue;
				case 76:
					goto IL_28C0;
				case 77:
					if (AppInfoManager.DefaultDocument.GetFeature(2301).HiddenStatic)
					{
						num = (short)608174091;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_480F;
				case 78:
					if (FeatureManager.GetFeature(2038).HiddenStatic)
					{
						num = (short)1201406383;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 79:
					goto IL_226F;
				case 80:
					num = (short)188875121;
					num2 = (int)((IntPtr)num);
					continue;
				case 81:
					num = (short)397476282;
					num2 = (int)((IntPtr)num);
					continue;
				case 82:
					goto IL_66BB;
				case 83:
					if (AppInfoManager.DefaultDocument.GetFeature(4156) != null)
					{
						num = (short)78839869;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5071;
				case 84:
					num = (short)624492639;
					num2 = (int)((IntPtr)num);
					continue;
				case 85:
					goto IL_1960;
				case 86:
					if (FeatureManager.GetFeature(4176).HiddenStatic)
					{
						num = (short)1116537395;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 87:
					goto IL_4C41;
				case 88:
					goto IL_36E6;
				case 89:
					goto IL_1205;
				case 90:
					if (FeatureManager.GetFeature(2128) != null)
					{
						num = (short)980549877;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2612;
				case 91:
					goto IL_5C82;
				case 92:
					if (AppInfoManager.DefaultDocument.GetFeature(2222).HiddenStatic)
					{
						num = (short)753270954;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_32CE;
				case 93:
					if (AppInfoManager.DefaultDocument.GetFeature(2024).HiddenStatic)
					{
						num = (short)180683379;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_448B;
				case 94:
					if (AppInfoManager.DefaultDocument.GetFeature(4115).HiddenStatic)
					{
						num = (short)1077674477;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 95:
					if (FeatureManager.GetFeature(2032).HiddenStatic)
					{
						num = (short)287572347;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_40C3;
				case 96:
					num = (short)821035359;
					num2 = (int)((IntPtr)num);
					continue;
				case 97:
					if (FeatureManager.GetFeature(2131).HiddenStatic)
					{
						num = (short)1833566609;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 98:
					num = (short)1153892670;
					num2 = (int)((IntPtr)num);
					continue;
				case 99:
					if (FeatureManager.GetFeature(2028) != null)
					{
						num = (short)1386545203;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_752F;
				case 100:
					num = (short)1993605664;
					num2 = (int)((IntPtr)num);
					continue;
				case 101:
					goto IL_31A1;
				case 102:
					goto IL_322C;
				case 103:
					goto IL_6625;
				case 104:
					goto IL_4671;
				case 105:
					goto IL_16F5;
				case 106:
					if (FeatureManager.GetFeature(2086).HiddenStatic)
					{
						num = (short)1063125591;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 107:
					num = (short)716833435;
					num2 = (int)((IntPtr)num);
					continue;
				case 108:
					if (FeatureManager.GetFeature(2129).HiddenStatic)
					{
						num = (short)1674248810;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 109:
					if (FeatureManager.GetFeature(2036) != null)
					{
						num = (short)205127837;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5700;
				case 110:
					goto IL_2E77;
				case 111:
					if (FeatureManager.GetFeature(2027).HiddenStatic)
					{
						num = (short)1335951360;
						short num4 = num;
						num = (short)1682244139;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6564;
				case 112:
					if (FeatureManager.GetFeature(2053).HiddenStatic)
					{
						num = (short)427819333;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_27C1;
				case 113:
					if (AppInfoManager.DefaultDocument.GetFeature(4174).HiddenStatic)
					{
						num = (short)338821123;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 114:
					num = (short)116130069;
					num2 = (int)((IntPtr)num);
					continue;
				case 115:
					if (AppInfoManager.DefaultDocument.GetFeature(2007).HiddenStatic)
					{
						num = (short)479002715;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_448B;
				case 116:
					goto IL_47CC;
				case 117:
					if (FeatureManager.GetFeature(2036).HiddenStatic)
					{
						num = (short)586875481;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 118:
					if (FeatureManager.GetFeature(2024).HiddenStatic)
					{
						num = (short)729284712;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_27C1;
				case 119:
					num = (short)1787822545;
					num2 = (int)((IntPtr)num);
					continue;
				case 120:
					goto IL_77BE;
				case 121:
					if (AppInfoManager.DefaultDocument.GetFeature(2128).HiddenStatic)
					{
						num = (short)2083652238;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 122:
					goto IL_5F65;
				case 123:
					num = (short)1059586566;
					num2 = (int)((IntPtr)num);
					continue;
				case 124:
					if (FeatureManager.GetFeature(2212).HiddenStatic)
					{
						num = (short)1101070437;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6FE3;
				case 125:
					num = (short)1798766648;
					num2 = (int)((IntPtr)num);
					continue;
				case 126:
					num = (short)1371013434;
					num2 = (int)((IntPtr)num);
					continue;
				case 127:
					if (FeatureManager.GetFeature(2007).HiddenStatic)
					{
						num = (short)466420272;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_27C1;
				case 128:
					if (AppInfoManager.DefaultDocument.GetFeature(2214) != null)
					{
						num = (short)1413415219;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_360A;
				case 129:
					num = (short)634454181;
					num2 = (int)((IntPtr)num);
					continue;
				case 130:
					if (AppInfoManager.DefaultDocument.GetFeature(2034).HiddenStatic)
					{
						num = (short)2074477221;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_448B;
				case 131:
					num = (short)197656870;
					num2 = (int)((IntPtr)num);
					continue;
				case 132:
					num = (short)365035743;
					num2 = (int)((IntPtr)num);
					continue;
				case 133:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)760152445;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1156055044;
					num2 = (int)((IntPtr)num);
					continue;
				case 134:
					if (AppInfoManager.DefaultDocument.GetFeature(4109) != null)
					{
						num = (short)1381630095;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6EC9;
				case 135:
					if (AppInfoManager.DefaultDocument.GetFeature(2032).HiddenStatic)
					{
						num = (short)1606877350;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6E0A;
				case 136:
					if (AppInfoManager.DefaultDocument.GetFeature(2010) != null)
					{
						num = (short)1820590238;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4135;
				case 137:
					goto IL_635E;
				case 138:
					if (!FeatureManager.GetFeature(2072).HiddenStatic)
					{
						num = (short)1745420444;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52A3;
				case 139:
					if (!AppInfoManager.DefaultDocument.GetFeature(2220).HiddenStatic)
					{
						num = (short)22020593;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4A73;
				case 140:
					goto IL_2D4E;
				case 141:
					num = (short)2041184305;
					num2 = (int)((IntPtr)num);
					continue;
				case 142:
					if (FeatureManager.GetFeature(2131) != null)
					{
						num = (short)904397476;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_49E4;
				case 143:
					num = (short)1003290877;
					num2 = (int)((IntPtr)num);
					continue;
				case 144:
					goto IL_1578;
				case 145:
					if (!FeatureManager.GetFeature(2220).HiddenStatic)
					{
						num = (short)1878786317;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4A73;
				case 146:
					num = (short)1672610024;
					num2 = (int)((IntPtr)num);
					continue;
				case 147:
					if (AppInfoManager.DefaultDocument.GetFeature(2129).HiddenStatic)
					{
						num = (short)491061293;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 148:
					goto IL_716C;
				case 149:
					num = (short)1127219335;
					num2 = (int)((IntPtr)num);
					continue;
				case 150:
					num = (short)1937179206;
					num2 = (int)((IntPtr)num);
					continue;
				case 151:
					goto IL_5CCB;
				case 152:
					if (FeatureManager.GetFeature(2088) != null)
					{
						num = (short)695075090;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3C43;
				case 153:
					goto IL_4F54;
				case 154:
					goto IL_7201;
				case 155:
					if (FeatureManager.GetFeature(2300).HiddenStatic)
					{
						num = (short)1106968737;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 156:
					goto IL_6564;
				case 157:
					num = (short)166658165;
					num2 = (int)((IntPtr)num);
					continue;
				case 158:
					num = (short)1848377711;
					num2 = (int)((IntPtr)num);
					continue;
				case 159:
					if (FeatureManager.GetFeature(2130) != null)
					{
						num = (short)1923482259;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4F12;
				case 160:
					if (!AppInfoManager.DefaultDocument.GetFeature(2300).HiddenStatic)
					{
						num = (short)1874133354;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D2D;
				case 161:
					goto IL_1D5A;
				case 162:
					goto IL_3AE6;
				case 163:
					goto IL_6EC9;
				case 164:
					goto IL_D2D;
				case 165:
					if (AppInfoManager.DefaultDocument.GetFeature(2053).HiddenStatic)
					{
						num = (short)1507066156;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_448B;
				case 166:
					goto IL_1127;
				case 167:
					num = (short)2139291959;
					num2 = (int)((IntPtr)num);
					continue;
				case 168:
					if (AppInfoManager.DefaultDocument.GetFeature(4008).HiddenStatic)
					{
						num = (short)609223101;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 169:
					goto IL_6BD2;
				case 170:
					goto IL_2F8D;
				case 171:
					if (!AppInfoManager.DefaultDocument.GetFeature(2072).HiddenStatic)
					{
						num = (short)374538862;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52A3;
				case 172:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)2044395591;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2127889008;
					num2 = (int)((IntPtr)num);
					continue;
				case 173:
					if (FeatureManager.GetFeature(2128) != null)
					{
						num = (short)1142948443;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_631C;
				case 174:
					if (AppInfoManager.DefaultDocument.GetFeature(2062).HiddenStatic)
					{
						num = (short)1784873436;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_448B;
				case 175:
					num = (short)865206272;
					num2 = (int)((IntPtr)num);
					continue;
				case 176:
					if (AppInfoManager.DefaultDocument.GetFeature(4008) != null)
					{
						num = (short)1931215145;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_75BB;
				case 177:
					goto IL_76E3;
				case 178:
					goto IL_E88;
				case 179:
					goto IL_C06;
				case 180:
					goto IL_611D;
				case 181:
					if (FeatureManager.GetFeature(2007) != null)
					{
						num = (short)234750225;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5985;
				case 182:
					goto IL_152E;
				case 183:
					num = (short)1972044069;
					num2 = (int)((IntPtr)num);
					continue;
				case 184:
					goto IL_24B9;
				case 185:
					num = (short)1185874590;
					num2 = (int)((IntPtr)num);
					continue;
				case 186:
					num = (short)789906048;
					num2 = (int)((IntPtr)num);
					continue;
				case 187:
					num = (short)1705574465;
					num2 = (int)((IntPtr)num);
					continue;
				case 188:
					if (AppInfoManager.DefaultDocument.GetFeature(2028).HiddenStatic)
					{
						num = (short)1795817973;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2C09;
				case 189:
					if (FeatureManager.GetFeature(2054) != null)
					{
						num = (short)1634206149;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7845;
				case 190:
					goto IL_68B5;
				case 191:
					num = (short)1764491651;
					num2 = (int)((IntPtr)num);
					continue;
				case 192:
					if (AppInfoManager.DefaultDocument.GetFeature(4174) != null)
					{
						num = (short)739115043;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1F5C;
				case 193:
					if (AppInfoManager.DefaultDocument.GetFeature(2038) != null)
					{
						num = (short)902824566;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5ED9;
				case 194:
					goto IL_27C1;
				case 195:
					num = (short)1825833522;
					num2 = (int)((IntPtr)num);
					continue;
				case 196:
					num = (short)2118255250;
					num2 = (int)((IntPtr)num);
					continue;
				case 197:
					if (FeatureManager.GetFeature(4003) != null)
					{
						num = (short)1183252560;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_473C;
				case 198:
					goto IL_23D9;
				case 199:
					if (AppInfoManager.DefaultDocument.GetFeature(4115) != null)
					{
						num = (short)739836560;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_61F9;
				case 200:
					goto IL_5BF8;
				case 201:
					if (FeatureManager.GetFeature(4142).HiddenStatic)
					{
						num = (short)1612513852;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1ACE;
				case 202:
					if (AppInfoManager.DefaultDocument.GetFeature(2208) != null)
					{
						num = (short)698352037;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_76E3;
				case 203:
					num = (short)467468981;
					num2 = (int)((IntPtr)num);
					continue;
				case 204:
					goto IL_33CD;
				case 205:
					goto IL_3BB9;
				case 206:
					goto IL_52E3;
				case 207:
					goto IL_541E;
				case 208:
					num = (short)1183187550;
					num2 = (int)((IntPtr)num);
					continue;
				case 209:
					goto IL_3ECB;
				case 210:
					num = (short)522388150;
					num2 = (int)((IntPtr)num);
					continue;
				case 211:
					num = (short)961544750;
					num2 = (int)((IntPtr)num);
					continue;
				case 212:
					num = (short)1522663934;
					num2 = (int)((IntPtr)num);
					continue;
				case 213:
					if (AppInfoManager.DefaultDocument.GetFeature(4142) != null)
					{
						num = (short)1626145008;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2655;
				case 214:
					num = (short)158859925;
					num2 = (int)((IntPtr)num);
					continue;
				case 215:
					goto IL_5071;
				case 216:
					goto IL_14A3;
				case 217:
					if (FeatureManager.GetFeature(4143).HiddenStatic)
					{
						num = (short)1826619695;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1ACE;
				case 218:
					num = (short)134349314;
					num2 = (int)((IntPtr)num);
					continue;
				case 219:
					if (AppInfoManager.DefaultDocument.GetFeature(2013) != null)
					{
						num = (short)1840120337;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1FA3;
				case 220:
					num = (short)1189413148;
					num2 = (int)((IntPtr)num);
					continue;
				case 221:
					if (FeatureManager.GetFeature(2010).HiddenStatic)
					{
						num = (short)1262748191;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 222:
					if (FeatureManager.GetFeature(2301) != null)
					{
						num = (short)1483604360;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_73CA;
				case 223:
					if (AppInfoManager.DefaultDocument.GetFeature(2078).HiddenStatic)
					{
						num = (short)1098776698;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_448B;
				case 224:
					if (FeatureManager.GetFeature(2130).HiddenStatic)
					{
						num = (short)2048065752;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 225:
					if (AppInfoManager.DefaultDocument.GetFeature(4130) != null)
					{
						num = (short)1614217460;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3C87;
				case 226:
					if (AppInfoManager.DefaultDocument.GetFeature(4236) != null)
					{
						num = (short)554369372;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_16F5;
				case 227:
					goto IL_4E1D;
				case 228:
					if (FeatureManager.GetFeature(2032) != null)
					{
						num = (short)675414100;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2F07;
				case 229:
					if (AppInfoManager.DefaultDocument.GetFeature(2300) != null)
					{
						num = (short)153289345;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D2D;
				case 230:
					goto IL_2F4A;
				case 231:
					if (FeatureManager.GetFeature(2128).HiddenStatic)
					{
						num = (short)779092238;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 232:
					if (FeatureManager.GetFeature(2064).HiddenStatic)
					{
						num = (short)853279131;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6564;
				case 233:
					goto IL_4DAA;
				case 234:
					goto IL_19F3;
				case 235:
					goto IL_7201;
				case 236:
					num = (short)1547042971;
					num2 = (int)((IntPtr)num);
					continue;
				case 237:
					if (AppInfoManager.DefaultDocument.GetFeature(2055) != null)
					{
						num = (short)1276117311;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_277A;
				case 238:
					num = (short)1155334822;
					num2 = (int)((IntPtr)num);
					continue;
				case 239:
					if (FeatureManager.GetFeature(2062).HiddenStatic)
					{
						num = (short)1922171042;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_27C1;
				case 240:
					num = (short)1225785384;
					num2 = (int)((IntPtr)num);
					continue;
				case 241:
					if (AppInfoManager.DefaultDocument.GetFeature(4231) != null)
					{
						num = (short)854983223;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D2D;
				case 242:
					if (AppInfoManager.DefaultDocument.GetFeature(2130) != null)
					{
						num = (short)1811808521;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4329;
				case 243:
					switch (0)
					{
					case 0:
						goto IL_B08;
					}
					continue;
				case 244:
					num = (short)457507128;
					num2 = (int)((IntPtr)num);
					continue;
				case 245:
					num = (short)911016449;
					num2 = (int)((IntPtr)num);
					continue;
				case 246:
					if (FeatureManager.GetFeature(2131) != null)
					{
						num = (short)966460002;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1B58;
				case 247:
					if (AppInfoManager.DefaultDocument.GetFeature(4156) != null)
					{
						num = (short)1464008914;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_152E;
				case 248:
					if (FeatureManager.GetFeature(4231) != null)
					{
						num = (short)1548026230;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D2D;
				case 249:
					goto IL_14E7;
				case 250:
					num = (short)2009727235;
					num2 = (int)((IntPtr)num);
					continue;
				case 251:
					num = (short)116916487;
					num2 = (int)((IntPtr)num);
					continue;
				case 252:
					if (AppInfoManager.DefaultDocument.GetFeature(4130).HiddenStatic)
					{
						num = (short)29098604;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 253:
					if (AppInfoManager.DefaultDocument.GetFeature(4109).HiddenStatic)
					{
						num = (short)661782691;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 254:
					goto IL_4448;
				case 255:
					if (AppInfoManager.DefaultDocument.GetFeature(4143) != null)
					{
						num = (short)189726986;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_709B;
				case 256:
					if (AppInfoManager.DefaultDocument.GetFeature(2054) != null)
					{
						num = (short)1738932420;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2732;
				case 257:
					if (FeatureManager.GetFeature(2023) != null)
					{
						num = (short)1346306162;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2D09;
				case 258:
					acpTreeViewItem = new AcpTreeViewItem();
					acpTreeViewItem.Header = AcgResources.ID_TONESIGNALINGCONFIGURATION;
					acpTreeViewItem2.Items.Add(acpTreeViewItem);
					this.AddFeatureNodeItems(acpTreeViewItem, 4156, AcgResources.ID_TONESIGNALINGLIST);
					num = (short)161087625;
					num2 = (int)((IntPtr)num);
					continue;
				case 259:
					if (!AppInfoManager.DefaultDocument.GetFeature(2131).HiddenStatic)
					{
						num = (short)410059108;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_322C;
				case 260:
					if (AppInfoManager.DefaultDocument.GetFeature(4114).HiddenStatic)
					{
						num = (short)1239220298;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 261:
					goto IL_45D0;
				case 262:
					goto IL_52A3;
				case 263:
					if (FeatureManager.GetFeature(2214).HiddenStatic)
					{
						num = (short)2125791921;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6FE3;
				case 264:
					if (AppInfoManager.DefaultDocument.GetFeature(4236).HiddenStatic)
					{
						num = (short)1100480617;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 265:
					num = (short)1117192739;
					num2 = (int)((IntPtr)num);
					continue;
				case 266:
					num = (short)2049442180;
					num2 = (int)((IntPtr)num);
					continue;
				case 267:
					goto IL_4F9C;
				case 268:
					goto IL_4A29;
				case 269:
					goto IL_6FE3;
				case 270:
					goto IL_631C;
				case 271:
					num = (short)1613759080;
					num2 = (int)((IntPtr)num);
					continue;
				case 272:
					if (FeatureManager.GetFeature(2059) != null)
					{
						num = (short)665125194;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4F9C;
				case 273:
					num = (short)681443455;
					num2 = (int)((IntPtr)num);
					continue;
				case 274:
					num = (short)1808400980;
					num2 = (int)((IntPtr)num);
					continue;
				case 275:
					if (FeatureManager.GetFeature(4130) != null)
					{
						num = (short)1478951095;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_68B5;
				case 276:
					if (AppInfoManager.DefaultDocument.GetFeature(2127) != null)
					{
						num = (short)585826665;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_54A4;
				case 277:
					if (FeatureManager.GetFeature(2023).HiddenStatic)
					{
						num = (short)1272381772;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_42C7;
				case 278:
					num = (short)1861157257;
					num2 = (int)((IntPtr)num);
					continue;
				case 279:
					if (!AppInfoManager.DefaultDocument.GetFeature(4156).HiddenStatic)
					{
						num = (short)1418264965;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5071;
				case 280:
					num = (short)1944584842;
					num2 = (int)((IntPtr)num);
					continue;
				case 281:
					goto IL_473C;
				case 282:
					goto IL_40C3;
				case 283:
					if (AppInfoManager.DefaultDocument.GetFeature(2125) != null)
					{
						num = (short)1806041556;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6CE3;
				case 284:
					if (AppInfoManager.DefaultDocument.GetFeature(2130).HiddenStatic)
					{
						num = (short)1740570712;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 285:
					goto IL_525B;
				case 286:
					if (AppInfoManager.DefaultDocument.GetFeature(4145) != null)
					{
						num = (short)76022276;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4F54;
				case 287:
					num = (short)520683961;
					num2 = (int)((IntPtr)num);
					continue;
				case 288:
					if (AppInfoManager.DefaultDocument.GetFeature(2086) != null)
					{
						num = (short)57540677;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_58F3;
				case 289:
					if (FeatureManager.GetFeature(4145) != null)
					{
						num = (short)653853080;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_541E;
				case 290:
					num = (short)1514078379;
					num2 = (int)((IntPtr)num);
					continue;
				case 291:
					if (!FeatureManager.GetFeature(2131).HiddenStatic)
					{
						num = (short)20906428;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1B58;
				case 292:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)703922384;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1356922892;
					num2 = (int)((IntPtr)num);
					continue;
				case 293:
					if (FeatureManager.GetFeature(4130).HiddenStatic)
					{
						num = (short)362938558;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 294:
					if (AppInfoManager.DefaultDocument.GetFeature(2127).HiddenStatic)
					{
						num = (short)822280340;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 295:
					if (AppInfoManager.DefaultDocument.GetFeature(2129) != null)
					{
						num = (short)118030375;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1E76;
				case 296:
					num = (short)1999700499;
					num2 = (int)((IntPtr)num);
					continue;
				case 297:
					num = (short)1244004520;
					num2 = (int)((IntPtr)num);
					continue;
				case 298:
					goto IL_448B;
				case 299:
					if (FeatureManager.GetFeature(4114).HiddenStatic)
					{
						num = (short)1291190330;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 300:
					goto IL_4958;
				case 301:
					if (!AppInfoManager.DefaultDocument.GetFeature(4231).HiddenStatic)
					{
						num = (short)1597178194;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D2D;
				case 302:
					goto IL_7802;
				case 303:
					goto IL_1868;
				case 304:
					num = (short)1344733575;
					num2 = (int)((IntPtr)num);
					continue;
				case 305:
					goto IL_4A73;
				case 306:
					goto IL_360A;
				case 307:
					num = (short)1138229267;
					num2 = (int)((IntPtr)num);
					continue;
				case 308:
					if (AppInfoManager.DefaultDocument.GetFeature(2200) != null)
					{
						num = (short)524681898;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3A14;
				case 309:
					goto IL_2AF1;
				case 310:
					if (AppInfoManager.DefaultDocument.GetFeature(4003).HiddenStatic)
					{
						num = (short)1825767931;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 311:
					if (FeatureManager.GetFeature(2034).HiddenStatic)
					{
						num = (short)1168703577;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_27C1;
				case 312:
					if (AppInfoManager.DefaultDocument.GetFeature(4130).HiddenStatic)
					{
						num = (short)1477378716;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 313:
					goto IL_3A14;
				case 314:
					if (FeatureManager.GetFeature(2222).HiddenStatic)
					{
						num = (short)1207370146;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6FE3;
				case 315:
					if (AppInfoManager.DefaultDocument.GetFeature(4109).HiddenStatic)
					{
						num = (short)1032651421;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 316:
					if (FeatureManager.GetFeature(4114) != null)
					{
						num = (short)1847722400;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_46B3;
				case 317:
					if (FeatureManager.GetFeature(4236) != null)
					{
						num = (short)724763259;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1BF3;
				case 318:
					if (AppInfoManager.DefaultDocument.GetFeature(4176).HiddenStatic)
					{
						num = (short)864354448;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 319:
					num = (short)1110966687;
					num2 = (int)((IntPtr)num);
					continue;
				case 320:
					if (AppInfoManager.DefaultDocument.GetFeature(2086) != null)
					{
						num = (short)1053884944;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_23D9;
				case 321:
					goto IL_369D;
				case 322:
					if (FeatureManager.GetFeature(2129) != null)
					{
						num = (short)2129199604;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4C41;
				case 323:
					num = (short)1043136982;
					num2 = (int)((IntPtr)num);
					continue;
				case 324:
					goto IL_277A;
				case 325:
					goto IL_18AA;
				case 326:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)226427434;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)856031705;
					num2 = (int)((IntPtr)num);
					continue;
				case 327:
					num = (short)181273026;
					num2 = (int)((IntPtr)num);
					continue;
				case 328:
					if (AppInfoManager.DefaultDocument.GetFeature(2021) != null)
					{
						num = (short)1443758722;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_19AA;
				case 329:
					if (AppInfoManager.DefaultDocument.GetFeature(4114) != null)
					{
						num = (short)391119205;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6C53;
				case 330:
					num = (short)457245127;
					num2 = (int)((IntPtr)num);
					continue;
				case 331:
					goto IL_2397;
				case 332:
					goto IL_2D09;
				case 333:
					if (FeatureManager.GetFeature(2200) != null)
					{
						num = (short)221512308;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6400;
				case 334:
					num = (short)406192352;
					num2 = (int)((IntPtr)num);
					continue;
				case 335:
					num = (short)1046216782;
					num2 = (int)((IntPtr)num);
					continue;
				case 336:
					goto IL_58F3;
				case 337:
					if (AppInfoManager.DefaultDocument.GetFeature(4130) != null)
					{
						num = (short)147194283;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_37BE;
				case 338:
					goto IL_5D97;
				case 339:
					if (AppInfoManager.DefaultDocument.GetFeature(2036) != null)
					{
						num = (short)1590755780;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3A9F;
				case 340:
					if (FeatureManager.GetFeature(4236).HiddenStatic)
					{
						num = (short)2121597079;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 341:
					num = (short)426311772;
					num2 = (int)((IntPtr)num);
					continue;
				case 342:
					goto IL_5ED9;
				case 343:
					goto IL_109A;
				case 344:
					num = (short)161546312;
					num2 = (int)((IntPtr)num);
					continue;
				case 345:
					if (AppInfoManager.DefaultDocument.GetFeature(2036) != null)
					{
						num = (short)338690604;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D6C;
				case 346:
					if (AppInfoManager.DefaultDocument.GetFeature(2042).HiddenStatic)
					{
						num = (short)752353822;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 347:
					if (AppInfoManager.DefaultDocument.GetFeature(2222) != null)
					{
						num = (short)614924629;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2F8D;
				case 348:
					num = (short)1420820744;
					num2 = (int)((IntPtr)num);
					continue;
				case 349:
					if (AppInfoManager.DefaultDocument.GetFeature(2042).HiddenStatic)
					{
						num = (short)806486284;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 350:
					if (AppInfoManager.DefaultDocument.GetFeature(2129) != null)
					{
						num = (short)1903165635;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6D2C;
				case 351:
					if (AppInfoManager.DefaultDocument.GetFeature(4114).HiddenStatic)
					{
						num = (short)517472359;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 352:
					goto IL_5F21;
				case 353:
					if (FeatureManager.GetFeature(2034) != null)
					{
						num = (short)1700004007;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1205;
				case 354:
					if (FeatureManager.GetFeature(2076) != null)
					{
						num = (short)1518010936;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6BD2;
				case 355:
					if (AppInfoManager.DefaultDocument.GetFeature(4114) != null)
					{
						num = (short)1818689632;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6625;
				case 356:
					goto IL_5A12;
				case 357:
					num = (short)824836356;
					num2 = (int)((IntPtr)num);
					continue;
				case 358:
					goto IL_6400;
				case 359:
					goto IL_7845;
				case 360:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)952762406;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2043544217;
					num2 = (int)((IntPtr)num);
					continue;
				case 361:
					num = (short)238813561;
					num2 = (int)((IntPtr)num);
					continue;
				case 362:
					goto IL_480F;
				case 363:
					goto IL_4A73;
				case 364:
					if (AppInfoManager.DefaultDocument.GetFeature(2038) != null)
					{
						num = (short)428409136;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1960;
				case 365:
					goto IL_34EF;
				case 366:
					num = (short)2027618449;
					num2 = (int)((IntPtr)num);
					continue;
				case 367:
					if (AppInfoManager.DefaultDocument.GetFeature(2010).HiddenStatic)
					{
						num = (short)1713045939;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 368:
					num = (short)884212155;
					num2 = (int)((IntPtr)num);
					continue;
				case 369:
					if (FeatureManager.GetFeature(4003).HiddenStatic)
					{
						num = (short)578683161;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 370:
					goto IL_1BF3;
				case 371:
					if (FeatureManager.GetFeature(4156) != null)
					{
						num = (short)172032100;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_77BE;
				case 372:
					num = (short)412024863;
					num2 = (int)((IntPtr)num);
					continue;
				case 373:
					num = (short)856162416;
					num2 = (int)((IntPtr)num);
					continue;
				case 374:
					num = (short)893256365;
					num2 = (int)((IntPtr)num);
					continue;
				case 375:
					num = (short)438567050;
					num2 = (int)((IntPtr)num);
					continue;
				case 376:
					if (FeatureManager.GetFeature(2129).HiddenStatic)
					{
						num = (short)1655046231;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 377:
					if (AppInfoManager.DefaultDocument.GetFeature(2127).HiddenStatic)
					{
						num = (short)945553995;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 378:
					goto IL_3A5D;
				case 379:
					goto IL_2F07;
				case 380:
					if (AppInfoManager.DefaultDocument.GetFeature(2075) != null)
					{
						num = (short)1193476177;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2E77;
				case 381:
					num = (short)652214909;
					num2 = (int)((IntPtr)num);
					continue;
				case 382:
					if (FeatureManager.GetFeature(2075) != null)
					{
						num = (short)2034565144;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_202E;
				case 383:
					if (FeatureManager.GetFeature(2127) != null)
					{
						num = (short)568983832;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_33CD;
				case 384:
					if (AppInfoManager.DefaultDocument.GetFeature(2042) != null)
					{
						num = (short)275382718;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_39CD;
				case 385:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)653721659;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)525926499;
					num2 = (int)((IntPtr)num);
					continue;
				case 386:
					if (AppInfoManager.DefaultDocument.GetFeature(2131) != null)
					{
						num = (short)1756627194;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_322C;
				case 387:
					if (AppInfoManager.DefaultDocument.GetFeature(2088).HiddenStatic)
					{
						num = (short)1455096456;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 388:
					if (!AppInfoManager.DefaultDocument.GetFeature(4143).HiddenStatic)
					{
						num = (short)471793891;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_709B;
				case 389:
					acpTreeViewItem = new AcpTreeViewItem();
					acpTreeViewItem.Header = AcgResources.ID_TONESIGNALINGCONFIGURATION;
					acpTreeViewItem2.Items.Add(acpTreeViewItem);
					this.AddFeatureNodeItems(acpTreeViewItem, 4156, AcgResources.ID_TONESIGNALINGLIST);
					num = (short)1863844055;
					num2 = (int)((IntPtr)num);
					continue;
				case 390:
					if (AppInfoManager.DefaultDocument.GetFeature(2053) != null)
					{
						num = (short)1897857153;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4958;
				case 391:
					if (AppInfoManager.DefaultDocument.GetFeature(2038).HiddenStatic)
					{
						num = (short)1392181333;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 392:
					num = (short)1789395448;
					num2 = (int)((IntPtr)num);
					continue;
				case 393:
					if (FeatureManager.GetFeature(4115).HiddenStatic)
					{
						num = (short)1541472869;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 394:
					if (AppInfoManager.DefaultDocument.GetFeature(2212).HiddenStatic)
					{
						num = (short)1213727029;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_32CE;
				case 395:
					if (FeatureManager.GetFeature(4109) != null)
					{
						num = (short)1739850234;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6C10;
				case 396:
					num = (short)1066860659;
					num2 = (int)((IntPtr)num);
					continue;
				case 397:
					if (FeatureManager.GetFeature(4008) != null)
					{
						num = (short)1037828137;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_47CC;
				case 398:
					num = (short)1305870646;
					num2 = (int)((IntPtr)num);
					continue;
				case 399:
					if (FeatureManager.GetFeature(4114) != null)
					{
						num = (short)542966231;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7802;
				case 400:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1395786385;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)54854104;
					num2 = (int)((IntPtr)num);
					continue;
				case 401:
					goto IL_49E4;
				case 402:
					if (AppInfoManager.DefaultDocument.GetFeature(2220) != null)
					{
						num = (short)862454180;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4A73;
				case 403:
					num = (short)222888609;
					num2 = (int)((IntPtr)num);
					continue;
				case 404:
					if (!FeatureManager.GetFeature(4228).HiddenStatic)
					{
						num = (short)30868041;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7201;
				case 405:
					if (AppInfoManager.DefaultDocument.GetFeature(2059) != null)
					{
						num = (short)1860567618;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4F9C;
				case 406:
					goto IL_581A;
				case 407:
					if (!FeatureManager.GetFeature(4156).HiddenStatic)
					{
						num = (short)1812726018;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_635E;
				case 408:
					num = (short)1878983194;
					num2 = (int)((IntPtr)num);
					continue;
				case 409:
					if (AppInfoManager.DefaultDocument.GetFeature(2021).HiddenStatic)
					{
						num = (short)1043857870;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_24B9;
				case 410:
					num = (short)426049737;
					num2 = (int)((IntPtr)num);
					continue;
				case 411:
					goto IL_6B90;
				case 412:
					goto IL_487D;
				case 413:
					num = (short)1571815881;
					num2 = (int)((IntPtr)num);
					continue;
				case 414:
					num = (short)1661010541;
					num2 = (int)((IntPtr)num);
					continue;
				case 415:
					if (AppInfoManager.DefaultDocument.GetFeature(2055).HiddenStatic)
					{
						num = (short)434307396;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_24B9;
				case 416:
					num = (short)1389297963;
					num2 = (int)((IntPtr)num);
					continue;
				case 417:
					if (AppInfoManager.DefaultDocument.GetFeature(2036).HiddenStatic)
					{
						num = (short)1434714746;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 418:
					goto IL_6F59;
				case 419:
					goto IL_52A3;
				case 420:
					num = (short)1849950347;
					num2 = (int)((IntPtr)num);
					continue;
				case 421:
					num = (short)2126709194;
					num2 = (int)((IntPtr)num);
					continue;
				case 422:
					if (FeatureManager.GetFeature(2055).HiddenStatic)
					{
						num = (short)777192111;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_51E9;
				case 423:
					if (FeatureManager.GetFeature(4234) != null)
					{
						num = (short)150405261;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_709B;
				case 424:
					if (FeatureManager.GetFeature(2130).HiddenStatic)
					{
						num = (short)984350787;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 425:
					if (AppInfoManager.DefaultDocument.GetFeature(4115).HiddenStatic)
					{
						num = (short)360775743;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 426:
					if (AppInfoManager.DefaultDocument.GetFeature(2127) != null)
					{
						num = (short)1400897667;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_716C;
				case 427:
					num = (short)1620246780;
					num2 = (int)((IntPtr)num);
					continue;
				case 428:
					goto IL_5ACE;
				case 429:
					goto IL_6F10;
				case 430:
					if (FeatureManager.GetFeature(2028).HiddenStatic)
					{
						num = (short)1079705647;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4DAA;
				case 431:
					goto IL_20FA;
				case 432:
					if (FeatureManager.GetFeature(2087) != null)
					{
						num = (short)2044068058;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5461;
				case 433:
					num = (short)725614722;
					num2 = (int)((IntPtr)num);
					continue;
				case 434:
					num = (short)1795228242;
					num2 = (int)((IntPtr)num);
					continue;
				case 435:
					goto IL_4135;
				case 436:
					num = (short)2011234478;
					num2 = (int)((IntPtr)num);
					continue;
				case 437:
					if (AppInfoManager.DefaultDocument.GetFeature(4145) != null)
					{
						num = (short)647168187;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_487D;
				case 438:
					num = (short)1574830612;
					num2 = (int)((IntPtr)num);
					continue;
				case 439:
					goto IL_2655;
				case 440:
					if (FeatureManager.GetFeature(2072) != null)
					{
						num = (short)4325751;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52A3;
				case 441:
					if (!FeatureManager.GetFeature(2300).HiddenStatic)
					{
						num = (short)1015742540;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D2D;
				case 442:
					if (AppInfoManager.DefaultDocument.GetFeature(2075).HiddenStatic)
					{
						num = (short)1540030574;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6E0A;
				case 443:
					if (!AppInfoManager.DefaultDocument.GetFeature(2057).HiddenStatic)
					{
						num = (short)900203147;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 444:
					goto IL_425A;
				case 445:
					goto IL_75BB;
				case 446:
					num = (short)853147994;
					num2 = (int)((IntPtr)num);
					continue;
				case 447:
					if (!FeatureManager.GetFeature(2057).HiddenStatic)
					{
						num = (short)1619460588;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 448:
					num = (short)1096089788;
					num2 = (int)((IntPtr)num);
					continue;
				case 449:
					if (!FeatureManager.GetFeature(2125).HiddenStatic)
					{
						num = (short)1182728398;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_226F;
				case 450:
					if (AppInfoManager.DefaultDocument.GetFeature(2032) != null)
					{
						num = (short)2094137493;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1127;
				case 451:
					if (FeatureManager.GetFeature(4003).HiddenStatic)
					{
						num = (short)256442577;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 452:
					num = (short)473891298;
					num2 = (int)((IntPtr)num);
					continue;
				case 453:
					num = (short)1233388135;
					num2 = (int)((IntPtr)num);
					continue;
				case 454:
					if (AppInfoManager.DefaultDocument.GetFeature(2125) != null)
					{
						num = (short)203227574;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1293;
				case 455:
					if (!FeatureManager.GetFeature(2059).HiddenStatic)
					{
						num = (short)1736310978;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4F9C;
				case 456:
					if (AppInfoManager.DefaultDocument.GetFeature(2086).HiddenStatic)
					{
						num = (short)459145552;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5A12;
				case 457:
					if (FeatureManager.GetFeature(4145).HiddenStatic)
					{
						num = (short)220332384;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 458:
					if (AppInfoManager.DefaultDocument.GetFeature(2208).HiddenStatic)
					{
						num = (short)63373489;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_32CE;
				case 459:
					if (FeatureManager.GetFeature(2036) != null)
					{
						num = (short)382927353;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_109A;
				case 460:
					if (FeatureManager.GetFeature(4115) != null)
					{
						num = (short)983040278;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1FEB;
				case 461:
					if (AppInfoManager.DefaultDocument.GetFeature(2024) != null)
					{
						num = (short)1019806380;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_67DD;
				case 462:
					goto IL_19AA;
				case 463:
					goto IL_73CA;
				case 464:
					if (AppInfoManager.DefaultDocument.GetFeature(2301) != null)
					{
						num = (short)159514642;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_57D2;
				case 465:
					if (FeatureManager.GetFeature(2078).HiddenStatic)
					{
						num = (short)1629618355;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_27C1;
				case 466:
					num = (short)500760694;
					num2 = (int)((IntPtr)num);
					continue;
				case 467:
					goto IL_1293;
				case 468:
					num = (short)252641892;
					num2 = (int)((IntPtr)num);
					continue;
				case 469:
					num = (short)2063073684;
					num2 = (int)((IntPtr)num);
					continue;
				case 470:
					if (FeatureManager.GetFeature(2077).HiddenStatic)
					{
						num = (short)1965490507;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 471:
					num = (short)1367147086;
					num2 = (int)((IntPtr)num);
					continue;
				case 472:
					if (FeatureManager.GetFeature(2021) != null)
					{
						num = (short)746979348;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D0C;
				case 473:
					if (FeatureManager.GetFeature(4142) != null)
					{
						num = (short)1223754138;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3807;
				case 474:
					if (AppInfoManager.DefaultDocument.GetFeature(4109) != null)
					{
						num = (short)728236608;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4211;
				case 475:
					if (AppInfoManager.DefaultDocument.GetFeature(2128) != null)
					{
						num = (short)1551106631;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_FC3;
				case 476:
					goto IL_499F;
				case 477:
					if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)2041446450;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1215824129;
					num2 = (int)((IntPtr)num);
					continue;
				case 478:
					if (AppInfoManager.DefaultDocument.GetFeature(2007) != null)
					{
						num = (short)464257420;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5C82;
				case 479:
					if (AppInfoManager.DefaultDocument.GetFeature(4003) != null)
					{
						num = (short)1385955726;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_490F;
				case 480:
					this.myTreeViewItemRoot.DataContext = ((AppInfoManager.DefaultDocument.GetFeature(2049) as RadioInformationRecset)[0][10108] as Motorola.MackinawCPS.CoreFeatures.RadioInformation.General);
					num = (short)1318912178;
					num2 = (int)((IntPtr)num);
					continue;
				case 481:
					goto IL_4324;
				case 482:
					if (AppInfoManager.DefaultDocument.GetFeature(2036).HiddenStatic)
					{
						num = (short)1340801535;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 483:
					if (AppInfoManager.DefaultDocument.GetFeature(2034) != null)
					{
						num = (short)427360689;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3D64;
				case 484:
					goto IL_F79;
				case 485:
					goto IL_D2D;
				case 486:
					if (FeatureManager.GetFeature(4109).HiddenStatic)
					{
						num = (short)1705509094;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 487:
					goto IL_1418;
				case 488:
					if (FeatureManager.GetFeature(2300) != null)
					{
						num = (short)1924268268;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1D5A;
				case 489:
					if (FeatureManager.GetFeature(2042) != null)
					{
						num = (short)68420164;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_19F3;
				case 490:
					if (AppInfoManager.DefaultDocument.GetFeature(2087) != null)
					{
						num = (short)1244856855;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7283;
				case 491:
					if (FeatureManager.GetFeature(4109).HiddenStatic)
					{
						num = (short)1397883405;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 492:
					goto IL_42C7;
				case 493:
					goto IL_61F9;
				case 494:
					if (AppInfoManager.DefaultDocument.GetFeature(2023) != null)
					{
						num = (short)1304953017;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_611D;
				case 495:
					if (FeatureManager.GetFeature(4109) != null)
					{
						num = (short)575930864;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2F4A;
				case 496:
					num = (short)1653932518;
					num2 = (int)((IntPtr)num);
					continue;
				case 497:
					goto IL_32CE;
				case 498:
					num = (short)1269760217;
					num2 = (int)((IntPtr)num);
					continue;
				case 499:
					if (FeatureManager.GetFeature(2086) != null)
					{
						num = (short)1645675142;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2B7A;
				case 500:
					num = (short)1055916408;
					num2 = (int)((IntPtr)num);
					continue;
				case 501:
					goto IL_C96;
				case 502:
					if (FeatureManager.GetFeature(2220) != null)
					{
						num = (short)1535377774;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4A73;
				case 503:
					goto IL_3578;
				case 504:
					if (FeatureManager.GetFeature(2301).HiddenStatic)
					{
						num = (short)2131100111;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_28C0;
				case 505:
					num = (short)211616265;
					num2 = (int)((IntPtr)num);
					continue;
				case 506:
					num = (short)896401899;
					num2 = (int)((IntPtr)num);
					continue;
				case 507:
					goto IL_490F;
				case 508:
					if (FeatureManager.GetFeature(2200).HiddenStatic)
					{
						num = (short)293667174;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6FE3;
				case 509:
					goto IL_608D;
				case 510:
					if (!FeatureManager.GetFeature(4148).HiddenStatic)
					{
						num = (short)1969619177;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_45D0;
				case 511:
					goto IL_3A9F;
				case 512:
					if (FeatureManager.GetFeature(2064) != null)
					{
						num = (short)1553203346;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6B90;
				case 513:
					if (FeatureManager.GetFeature(2128).HiddenStatic)
					{
						num = (short)220070452;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 514:
					if (FeatureManager.GetFeature(2087).HiddenStatic)
					{
						num = (short)1465516679;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 515:
					if (AppInfoManager.DefaultDocument.GetFeature(4228) != null)
					{
						num = (short)367133247;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7201;
				case 516:
					num = (short)1452540445;
					num2 = (int)((IntPtr)num);
					continue;
				case 517:
					if (FeatureManager.GetFeature(4143) != null)
					{
						num = (short)1585775090;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1868;
				case 518:
					if (FeatureManager.GetFeature(2088).HiddenStatic)
					{
						num = (short)660013719;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 519:
					if (FeatureManager.GetFeature(2125) != null)
					{
						num = (short)367723088;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_226F;
				case 520:
					if (AppInfoManager.DefaultDocument.GetFeature(2078) != null)
					{
						num = (short)576454788;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5F65;
				case 521:
					if (FeatureManager.GetFeature(2036).HiddenStatic)
					{
						num = (short)1604059479;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 522:
					if (AppInfoManager.DefaultDocument.GetFeature(2013).HiddenStatic)
					{
						num = (short)520159240;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 523:
					if (FeatureManager.GetFeature(2062) != null)
					{
						num = (short)590505;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3AE6;
				case 524:
					if (FeatureManager.GetFeature(4174).HiddenStatic)
					{
						num = (short)1854996967;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 525:
					goto IL_6C10;
				case 526:
					if (AppInfoManager.DefaultDocument.GetFeature(4003).HiddenStatic)
					{
						num = (short)1790968236;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 527:
					goto IL_4329;
				case 528:
					num = (short)1707474958;
					num2 = (int)((IntPtr)num);
					continue;
				case 529:
					num = (short)1830289930;
					num2 = (int)((IntPtr)num);
					continue;
				case 530:
					goto IL_7283;
				case 531:
					if (FeatureManager.GetFeature(2087).HiddenStatic)
					{
						num = (short)1490158157;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_425A;
				case 532:
					if (!AppInfoManager.DefaultDocument.GetFeature(2125).HiddenStatic)
					{
						num = (short)2119500312;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1293;
				case 533:
					if (AppInfoManager.DefaultDocument.GetFeature(2210) != null)
					{
						num = (short)342556689;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6F10;
				case 534:
					num = (short)897581167;
					num2 = (int)((IntPtr)num);
					continue;
				case 535:
					num = (short)676987555;
					num2 = (int)((IntPtr)num);
					continue;
				case 536:
					goto IL_2FD6;
				case 537:
					if (FeatureManager.GetFeature(4156) != null)
					{
						num = (short)1729495640;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_635E;
				case 538:
					if (FeatureManager.GetFeature(4145).HiddenStatic)
					{
						num = (short)1941635279;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_28C0;
				case 539:
					goto IL_3110;
				case 540:
					goto IL_FC3;
				case 541:
					if (FeatureManager.GetFeature(4145).HiddenStatic)
					{
						num = (short)1538916505;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_480F;
				case 542:
					goto IL_39CD;
				case 543:
					goto IL_7603;
				case 544:
					if (FeatureManager.GetFeature(4156).HiddenStatic)
					{
						num = (short)1026031736;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 545:
					if (AppInfoManager.DefaultDocument.GetFeature(2028) != null)
					{
						num = (short)2147156416;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C96;
				case 546:
					goto IL_17D7;
				case 547:
					if (AppInfoManager.DefaultDocument.GetFeature(2130).HiddenStatic)
					{
						num = (short)584385039;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 548:
					if (AppInfoManager.DefaultDocument.GetFeature(2130) != null)
					{
						num = (short)796983516;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_36E6;
				case 549:
					if (FeatureManager.GetFeature(4174) != null)
					{
						num = (short)2017591298;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1418;
				case 550:
					goto IL_4541;
				case 551:
					num = (short)835584070;
					num2 = (int)((IntPtr)num);
					continue;
				case 552:
					if (FeatureManager.GetFeature(2087) != null)
					{
						num = (short)1630470440;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1E33;
				case 553:
					if (FeatureManager.GetFeature(2078) != null)
					{
						num = (short)1690435703;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C06;
				case 554:
					num = (short)1267925205;
					num2 = (int)((IntPtr)num);
					continue;
				case 555:
					goto IL_DB4;
				case 556:
					num = (short)743899553;
					num2 = (int)((IntPtr)num);
					continue;
				case 557:
					num = (short)1329987705;
					num2 = (int)((IntPtr)num);
					continue;
				case 558:
					if (AppInfoManager.DefaultDocument.GetFeature(2087).HiddenStatic)
					{
						num = (short)777126490;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5A12;
				case 559:
					goto IL_60D5;
				case 560:
					goto IL_5985;
				case 561:
					if (FeatureManager.GetFeature(2214) != null)
					{
						num = (short)39321851;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4D19;
				case 562:
					if (AppInfoManager.DefaultDocument.GetFeature(2129).HiddenStatic)
					{
						num = (short)2045182585;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 563:
					goto IL_3779;
				case 564:
					goto IL_2612;
				case 565:
					if (FeatureManager.GetFeature(2055) != null)
					{
						num = (short)1819213899;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_20B6;
				case 566:
					if (FeatureManager.GetFeature(4236) != null)
					{
						num = (short)1448346245;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5CCB;
				case 567:
					num = (short)1020395821;
					num2 = (int)((IntPtr)num);
					continue;
				case 568:
					num = (short)1441857546;
					num2 = (int)((IntPtr)num);
					continue;
				case 569:
					if (AppInfoManager.DefaultDocument.GetFeature(2088) != null)
					{
						num = (short)135856319;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3E3F;
				case 570:
					if (FeatureManager.GetFeature(4130) != null)
					{
						num = (short)759300719;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_230B;
				case 571:
					if (FeatureManager.GetFeature(2300) != null)
					{
						num = (short)2070151455;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D2D;
				case 572:
					goto IL_3807;
				case 573:
					goto IL_E88;
				case 574:
					if (FeatureManager.GetFeature(2088) != null)
					{
						num = (short)1113718907;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_62DC;
				case 575:
					num = (short)344916599;
					num2 = (int)((IntPtr)num);
					continue;
				case 576:
					num = (short)1739653435;
					num2 = (int)((IntPtr)num);
					continue;
				case 577:
					if (AppInfoManager.DefaultDocument.GetFeature(2300) != null)
					{
						num = (short)1938096180;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3578;
				case 578:
					num = (short)1150288536;
					num2 = (int)((IntPtr)num);
					continue;
				case 579:
					if (AppInfoManager.DefaultDocument.GetFeature(4236) != null)
					{
						num = (short)489488412;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_608D;
				case 580:
					num = (short)462815825;
					num2 = (int)((IntPtr)num);
					continue;
				case 581:
					if (FeatureManager.GetFeature(2129) != null)
					{
						num = (short)321979007;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2B38;
				case 582:
					if (AppInfoManager.DefaultDocument.GetFeature(2088).HiddenStatic)
					{
						num = (short)2030174754;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 583:
					num = (short)932184736;
					num2 = (int)((IntPtr)num);
					continue;
				case 584:
					if (FeatureManager.GetFeature(4236).HiddenStatic)
					{
						num = (short)1860764018;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 585:
					goto IL_51E9;
				case 586:
					if (FeatureManager.GetFeature(2010) != null)
					{
						num = (short)31719486;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7603;
				case 587:
					goto IL_54A4;
				case 588:
					goto IL_2C09;
				case 589:
					goto IL_1E33;
				case 590:
					if (FeatureManager.GetFeature(4114).HiddenStatic)
					{
						num = (short)938213678;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 591:
					if (FeatureManager.GetFeature(2038) != null)
					{
						num = (short)594018639;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_20FA;
				case 592:
					num = (short)2051932609;
					num2 = (int)((IntPtr)num);
					continue;
				case 593:
					if (FeatureManager.GetFeature(2042).HiddenStatic)
					{
						num = (short)291700970;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 594:
					if (AppInfoManager.DefaultDocument.GetFeature(2131).HiddenStatic)
					{
						num = (short)1289355585;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 595:
					if (AppInfoManager.DefaultDocument.GetFeature(2072) != null)
					{
						num = (short)1022820642;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52A3;
				case 596:
					if (FeatureManager.GetFeature(2088).HiddenStatic)
					{
						num = (short)248382093;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 597:
					num = (short)179634831;
					num2 = (int)((IntPtr)num);
					continue;
				case 598:
					if (FeatureManager.GetFeature(2130) != null)
					{
						num = (short)364446030;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_14A3;
				case 599:
					goto IL_2B7A;
				case 600:
					num = (short)556728727;
					num2 = (int)((IntPtr)num);
					continue;
				case 601:
					goto IL_5700;
				case 602:
					goto IL_3531;
				case 603:
					num = (short)377880807;
					num2 = (int)((IntPtr)num);
					continue;
				case 604:
					if (AppInfoManager.DefaultDocument.GetFeature(2131) != null)
					{
						num = (short)1283391922;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_369D;
				case 605:
					if (AppInfoManager.DefaultDocument.GetFeature(2077) != null)
					{
						num = (short)1949434042;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_F79;
				case 606:
					if (AppInfoManager.DefaultDocument.GetFeature(2033) != null)
					{
						num = (short)844628075;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_60D5;
				case 607:
					goto IL_202E;
				case 608:
					num = (short)424477198;
					num2 = (int)((IntPtr)num);
					continue;
				case 609:
					if (AppInfoManager.DefaultDocument.GetFeature(4148) != null)
					{
						num = (short)40042621;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_45D0;
				case 610:
					num = (short)1832648995;
					num2 = (int)((IntPtr)num);
					continue;
				case 611:
					goto IL_709B;
				case 612:
					if (AppInfoManager.DefaultDocument.GetFeature(2125).HiddenStatic)
					{
						num = (short)1845493796;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 613:
					goto IL_1FEB;
				case 614:
					if (FeatureManager.GetFeature(2053) != null)
					{
						num = (short)2073887093;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_18AA;
				case 615:
					if (FeatureManager.GetFeature(2054).HiddenStatic)
					{
						num = (short)283443559;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4DAA;
				case 616:
					if (FeatureManager.GetFeature(2033).HiddenStatic)
					{
						num = (short)883556434;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 617:
					num = (short)1754857485;
					num2 = (int)((IntPtr)num);
					continue;
				case 618:
					goto IL_2B38;
				case 619:
					if (FeatureManager.GetFeature(2013) != null)
					{
						num = (short)945750219;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5BF8;
				case 620:
					goto IL_37BE;
				case 621:
					if (FeatureManager.GetFeature(2208).HiddenStatic)
					{
						num = (short)772473382;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6FE3;
				case 622:
					goto IL_18ED;
				case 623:
					num = (short)1917649556;
					num2 = (int)((IntPtr)num);
					continue;
				case 624:
					if (FeatureManager.GetFeature(2024) != null)
					{
						num = (short)456982994;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4671;
				case 625:
					num = (short)1160183894;
					num2 = (int)((IntPtr)num);
					continue;
				case 626:
					if (FeatureManager.GetFeature(2086) != null)
					{
						num = (short)2125726099;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_34EF;
				case 627:
					goto IL_67DD;
				case 628:
					num = (short)1233912316;
					num2 = (int)((IntPtr)num);
					continue;
				case 629:
					goto IL_1B58;
				case 630:
					num = (short)959381557;
					num2 = (int)((IntPtr)num);
					continue;
				case 631:
					if (!AppInfoManager.DefaultDocument.GetFeature(4228).HiddenStatic)
					{
						num = (short)481755320;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7201;
				case 632:
					if (AppInfoManager.DefaultDocument.GetFeature(2076) != null)
					{
						num = (short)167969112;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6BD2;
				case 633:
					goto IL_6D2C;
				case 634:
					goto IL_D6C;
				case 635:
					num = (short)1456865864;
					num2 = (int)((IntPtr)num);
					continue;
				case 636:
					if (AppInfoManager.DefaultDocument.GetFeature(2042) != null)
					{
						num = (short)862716570;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4A29;
				case 637:
					if (AppInfoManager.DefaultDocument.GetFeature(2027) != null)
					{
						num = (short)1869086793;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_525B;
				case 638:
					if (AppInfoManager.DefaultDocument.GetFeature(2128) != null)
					{
						num = (short)1563623981;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_772E;
				case 639:
					num = (short)31785068;
					num2 = (int)((IntPtr)num);
					continue;
				case 640:
					if (AppInfoManager.DefaultDocument.GetFeature(2077).HiddenStatic)
					{
						num = (short)619905508;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 641:
					num = (short)1547698336;
					num2 = (int)((IntPtr)num);
					continue;
				case 642:
					num = (short)1629553049;
					num2 = (int)((IntPtr)num);
					continue;
				case 643:
					if (AppInfoManager.DefaultDocument.GetFeature(4003) != null)
					{
						num = (short)1147798112;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5ACE;
				case 644:
					goto IL_4F9C;
				case 645:
					num = (short)563806548;
					num2 = (int)((IntPtr)num);
					continue;
				case 646:
					num = (short)220069994;
					num2 = (int)((IntPtr)num);
					continue;
				case 647:
					goto IL_5461;
				case 648:
					goto IL_3E3F;
				case 649:
					if (FeatureManager.GetFeature(4145) != null)
					{
						num = (short)2126643613;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5F21;
				case 650:
					if (FeatureManager.GetFeature(2127).HiddenStatic)
					{
						num = (short)1953956044;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 651:
					goto IL_3E3A;
				case 652:
					num = (short)349766026;
					num2 = (int)((IntPtr)num);
					continue;
				case 653:
					goto IL_3C43;
				case 654:
					goto IL_772E;
				case 655:
					if (FeatureManager.GetFeature(2210).HiddenStatic)
					{
						num = (short)1194328442;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6FE3;
				case 656:
					num = (short)119472222;
					num2 = (int)((IntPtr)num);
					continue;
				case 657:
					num = (short)1725038920;
					num2 = (int)((IntPtr)num);
					continue;
				case 658:
					if (AppInfoManager.DefaultDocument.GetFeature(2054).HiddenStatic)
					{
						num = (short)2020278340;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2C09;
				case 659:
					num = (short)1589903784;
					num2 = (int)((IntPtr)num);
					continue;
				case 660:
					if (FeatureManager.GetFeature(4130).HiddenStatic)
					{
						num = (short)1886519356;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 661:
					if (FeatureManager.GetFeature(2127).HiddenStatic)
					{
						num = (short)1843528219;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 662:
					if (AppInfoManager.DefaultDocument.GetFeature(4236).HiddenStatic)
					{
						num = (short)792461821;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 663:
					goto IL_62DC;
				case 664:
					if (!AppInfoManager.DefaultDocument.GetFeature(2059).HiddenStatic)
					{
						num = (short)95879466;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4F9C;
				case 665:
					if (FeatureManager.GetFeature(2222) != null)
					{
						num = (short)284557438;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6F59;
				case 666:
					num = (short)590872925;
					num2 = (int)((IntPtr)num);
					continue;
				case 667:
					if (AppInfoManager.DefaultDocument.GetFeature(2033).HiddenStatic)
					{
						num = (short)912917039;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 668:
					goto IL_3C87;
				case 669:
					goto IL_4211;
				case 670:
					if (AppInfoManager.DefaultDocument.GetFeature(2023).HiddenStatic)
					{
						num = (short)647889076;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5539;
				case 671:
					num = (short)1044709500;
					num2 = (int)((IntPtr)num);
					continue;
				case 672:
					if (AppInfoManager.DefaultDocument.GetFeature(2128).HiddenStatic)
					{
						num = (short)139199004;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2FD6;
				case 673:
					if (FeatureManager.GetFeature(2086).HiddenStatic)
					{
						num = (short)1782972781;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_425A;
				case 674:
					goto IL_5D0C;
				case 675:
					if (AppInfoManager.DefaultDocument.GetFeature(2087).HiddenStatic)
					{
						num = (short)738656786;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 676:
					num = (short)1956708449;
					num2 = (int)((IntPtr)num);
					continue;
				case 677:
					goto IL_3D64;
				case 678:
					if (FeatureManager.GetFeature(2042).HiddenStatic)
					{
						num = (short)1418723533;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_52E3;
				case 679:
					if (FeatureManager.GetFeature(2208) != null)
					{
						num = (short)1625162142;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4541;
				case 680:
					goto IL_6E0A;
				case 681:
					num = (short)1599209711;
					num2 = (int)((IntPtr)num);
					continue;
				case 682:
					num = (short)1453260826;
					num2 = (int)((IntPtr)num);
					continue;
				case 683:
					goto IL_45D0;
				case 684:
					num = (short)644153437;
					num2 = (int)((IntPtr)num);
					continue;
				case 685:
					if (!FeatureManager.GetFeature(4231).HiddenStatic)
					{
						num = (short)1907753004;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D2D;
				case 686:
					if (AppInfoManager.DefaultDocument.GetFeature(2088) != null)
					{
						num = (short)1526726806;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_17D7;
				case 687:
					goto IL_20B6;
				case 688:
					num = (short)2137915843;
					num2 = (int)((IntPtr)num);
					continue;
				case 689:
					goto IL_4D19;
				case 690:
					if (FeatureManager.GetFeature(2042) != null)
					{
						num = (short)407240942;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3BB9;
				case 691:
					if (FeatureManager.GetFeature(4008).HiddenStatic)
					{
						num = (short)1956315252;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 692:
					if (FeatureManager.GetFeature(2075).HiddenStatic)
					{
						num = (short)884212319;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_40C3;
				case 693:
					if (FeatureManager.GetFeature(2013).HiddenStatic)
					{
						num = (short)1752694984;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3924;
				case 694:
					if (AppInfoManager.DefaultDocument.GetFeature(4156).HiddenStatic)
					{
						num = (short)1357578422;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5D97;
				case 695:
					num = (short)1080229889;
					if (num != 0)
					{
					}
					goto IL_709B;
				case 696:
					if (FeatureManager.GetFeature(4176) != null)
					{
						num = (short)2115764849;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3779;
				}
				IL_B08:
				if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)53608928;
					num2 = (int)((IntPtr)num);
					continue;
				}
				this.myTreeViewItemRoot.DataContext = ((FeatureManager.GetFeature(2049) as RadioInformationRecset)[0][10108] as Motorola.MackinawCPS.CoreFeatures.RadioInformation.General);
				num = (short)683409981;
				num2 = (int)((IntPtr)num);
				continue;
				IL_C06:
				num = (short)669712565;
				num2 = (int)((IntPtr)num);
				continue;
				IL_C96:
				num = (short)497877248;
				num2 = (int)((IntPtr)num);
				continue;
				IL_D2D:
				num = (short)1390543248;
				num2 = (int)((IntPtr)num);
				continue;
				IL_D6C:
				num = (short)1549861089;
				num2 = (int)((IntPtr)num);
				continue;
				IL_DB4:
				num = (short)750453248;
				num2 = (int)((IntPtr)num);
				continue;
				IL_E88:
				this.myTreeViewItemRoot.RecsetId = 0;
				this.myTreeViewItemRoot.NodeId = 0;
				this.myTreeViewItemRoot.IsExpanded = true;
				this.AddFeatureNodeItems(this.myTreeViewItemRoot, 2049, AcgResources.ID_RADIOINFORMATION);
				this.AddFeatureNodeItems(this.myTreeViewItemRoot, 2045, AcgResources.ID_RADIOWIDE);
				this.AddFeatureNodeItems(this.myTreeViewItemRoot, 2003, AcgResources.ID_FACTORYOVERRIDES);
				num = (short)110756132;
				num2 = (int)((IntPtr)num);
				continue;
				IL_F79:
				num = (short)439222519;
				num2 = (int)((IntPtr)num);
				continue;
				IL_FC3:
				num = (short)1973682650;
				num2 = (int)((IntPtr)num);
				continue;
				IL_109A:
				num = (short)1137771066;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1127:
				num = (short)964624764;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1205:
				num = (short)1319502347;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1293:
				this.AddFeatureNodeItems(acpTreeViewItem2, 2010, AcgResources.ID_DISPLAY);
				num = (short)1348993312;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1418:
				num = (short)840958441;
				num2 = (int)((IntPtr)num);
				continue;
				IL_14A3:
				num = (short)1509949756;
				num2 = (int)((IntPtr)num);
				continue;
				IL_14E7:
				num = (short)657654355;
				num2 = (int)((IntPtr)num);
				continue;
				IL_152E:
				num = (short)1587347697;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1578:
				num = (short)779616432;
				num2 = (int)((IntPtr)num);
				continue;
				IL_16F5:
				num = (short)1650328121;
				num2 = (int)((IntPtr)num);
				continue;
				IL_17D7:
				num = (short)695075291;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1868:
				num = (short)427426215;
				num2 = (int)((IntPtr)num);
				continue;
				IL_18AA:
				num = (short)1887895824;
				num2 = (int)((IntPtr)num);
				continue;
				IL_18ED:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_TRUNKINGCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2027, AcgResources.ID_TRUNKINGWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2064, AcgResources.ID_TRUNKINGSYSTEM);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2072, AcgResources.ID_TRUNKINGPERSONALITY);
				num = (short)1375076614;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1960:
				num = (short)47382560;
				num2 = (int)((IntPtr)num);
				continue;
				IL_19AA:
				num = (short)301465837;
				num2 = (int)((IntPtr)num);
				continue;
				IL_19F3:
				num = (short)1799160399;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1ACE:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_DVRSCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4142, AcgResources.ID_DVRSWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4143, AcgResources.ID_DVRSPROFILES);
				num = (short)1690043063;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1B58:
				this.AddFeatureNodeItems(acpTreeViewItem2, 2077, AcgResources.ID_RADIOPROFILES);
				num = (short)1949893145;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1BF3:
				num = (short)765133374;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1D5A:
				num = (short)1981153899;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1E33:
				num = (short)1200029942;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1E76:
				num = (short)1773404505;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1F5C:
				num = (short)1247543932;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1FA3:
				num = (short)359399560;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1FEB:
				num = (short)870580607;
				num2 = (int)((IntPtr)num);
				continue;
				IL_202E:
				num = (short)520028514;
				num2 = (int)((IntPtr)num);
				continue;
				IL_20B6:
				num = (short)1444544527;
				num2 = (int)((IntPtr)num);
				continue;
				IL_20FA:
				num = (short)1638269388;
				num2 = (int)((IntPtr)num);
				continue;
				IL_226F:
				this.AddFeatureNodeItems(acpTreeViewItem2, 2010, AcgResources.ID_DISPLAY);
				num = (short)664207986;
				num2 = (int)((IntPtr)num);
				continue;
				IL_230B:
				num = (short)437190672;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2397:
				num = (short)1059979635;
				num2 = (int)((IntPtr)num);
				continue;
				IL_23D9:
				num = (short)557777386;
				num2 = (int)((IntPtr)num);
				continue;
				IL_24B9:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_SECURECONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2021, AcgResources.ID_SECUREWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2055, AcgResources.ID_ASTROOTARPROFILE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4228, AppResources.System_Cerfiticate_List_ID);
				num = (short)971636971;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2612:
				num = (short)1618477551;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2655:
				num = (short)1140195583;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2732:
				num = (short)8323681;
				num2 = (int)((IntPtr)num);
				continue;
				IL_277A:
				num = (short)1035600387;
				num2 = (int)((IntPtr)num);
				continue;
				IL_27C1:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_CONVENTIONALCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2024, AcgResources.ID_CONVENTIONALWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2078, AcgResources.ID_MPLCONFIGURATION);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2007, AcgResources.ID_CONVENTIONALALIASLISTS);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2034, AcgResources.ID_REPEATERIDLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2062, AcgResources.ID_ASTROTALKGROUPLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2053, AcgResources.ID_CONVENTIONALSYSTEM);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2059, AcgResources.ID_CONVENTIONALPERSONALITY);
				num = (short)588644996;
				num2 = (int)((IntPtr)num);
				continue;
				IL_28C0:
				acpTreeViewItem = new AcpTreeViewItem();
				acpTreeViewItem.Header = AcgResources.ID_VOICEANNOUNCEMENTS;
				acpTreeViewItem2.Items.Add(acpTreeViewItem);
				this.AddFeatureNodeItems(acpTreeViewItem, 2301, AcgResources.ID_VOICEANNOUNCEMENTWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem, 4145, AppResources.ID_SITESELECTABLEALERTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem, 2300, AcgResources.ID_VOICEANNOUNCEMENTLIST);
				num = (short)2102854117;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2AF1:
				num = (short)537067922;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2B38:
				num = (short)1844379757;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2B7A:
				num = (short)1365115312;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2C09:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_DATACONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2028, AcgResources.ID_DATAWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2054, AcgResources.ID_DATAPROFILES);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4148, AcgResources.ID_ENHANCEDDATAPORTLIST);
				num = (short)2034630917;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2D09:
				num = (short)1114701870;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2D4E:
				num = (short)979304485;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2E77:
				num = (short)107414136;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2F07:
				num = (short)1238106494;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2F4A:
				num = (short)685572677;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2F8D:
				num = (short)716505396;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2FD6:
				acpTreeViewItem = new AcpTreeViewItem();
				acpTreeViewItem.Header = AcgResources.ID_CONTROLS;
				acpTreeViewItem2.Items.Add(acpTreeViewItem);
				this.AddFeatureNodeItems(acpTreeViewItem, 2042, AcgResources.ID_BUTTONS);
				this.AddFeatureNodeItems(acpTreeViewItem, 2038, AcgResources.ID_SWITCHES);
				this.AddFeatureNodeItems(acpTreeViewItem, 4115, AcgResources.ID_CONTROLHEADO2);
				this.AddFeatureNodeItems(acpTreeViewItem, 2127, AcgResources.ID_CONTROLHEADO3);
				this.AddFeatureNodeItems(acpTreeViewItem, 2130, AcgResources.ID_CONTROLHEADO5);
				this.AddFeatureNodeItems(acpTreeViewItem, 4114, AcgResources.ID_CONTROLHEADO7);
				this.AddFeatureNodeItems(acpTreeViewItem, 4003, AcgResources.ID_CONTROLHEADO9);
				this.AddFeatureNodeItems(acpTreeViewItem, 4236, AcgResources.ID_CONTROLHEADE5);
				this.AddFeatureNodeItems(acpTreeViewItem, 2088, AcgResources.ID_MENUITEMS);
				this.AddFeatureNodeItems(acpTreeViewItem, 2128, AcgResources.ID_KEYPADMICANDACCESSORIES);
				this.AddFeatureNodeItems(acpTreeViewItem, 4109, AcgResources.ID_KEYPAD);
				this.AddFeatureNodeItems(acpTreeViewItem, 2129, AcgResources.ID_DEK);
				this.AddFeatureNodeItems(acpTreeViewItem, 2036, AcgResources.ID_ACCESSORYBUTTONS);
				this.AddFeatureNodeItems(acpTreeViewItem, 4130, AcgResources.ID_SMARTKEYFOBBUTTONS);
				this.AddFeatureNodeItems(acpTreeViewItem, 2125, AcgResources.ID_RADIOVIPS);
				num = (short)1157759443;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3110:
				num = (short)27459743;
				num2 = (int)((IntPtr)num);
				continue;
				IL_31A1:
				num = (short)1303904758;
				num2 = (int)((IntPtr)num);
				continue;
				IL_322C:
				this.AddFeatureNodeItems(acpTreeViewItem2, 2077, AcgResources.ID_RADIOPROFILES);
				num = (short)1877540947;
				num2 = (int)((IntPtr)num);
				continue;
				IL_32CE:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_CALLLISTCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2222, AcgResources.ID_CALLLISTWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2200, AcgResources.ID_UNIFIEDCALLLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2208, AcgResources.ID_ASTRO25TRUNKINGHOTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2214, AcgResources.ID_TYPEIITRUNKINGHOTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2210, AcgResources.ID_ASTROCONVENTIONALHOTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2212, AcgResources.ID_MDCCONVENTIONALHOTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2220, AcgResources.ID_PHONEHOTLIST);
				num = (short)192741681;
				num2 = (int)((IntPtr)num);
				continue;
				IL_33CD:
				num = (short)1552679510;
				num2 = (int)((IntPtr)num);
				continue;
				IL_34EF:
				num = (short)1147863592;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3531:
				num = (short)282132866;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3578:
				num = (short)1518534875;
				num2 = (int)((IntPtr)num);
				continue;
				IL_360A:
				num = (short)2031092245;
				num2 = (int)((IntPtr)num);
				continue;
				IL_369D:
				num = (short)1607008861;
				num2 = (int)((IntPtr)num);
				continue;
				IL_36E6:
				num = (short)203358537;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3779:
				num = (short)320733581;
				num2 = (int)((IntPtr)num);
				continue;
				IL_37BE:
				num = (short)1052442907;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3807:
				num = (short)15401477;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3924:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_RADIOERGONOMICSCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2033, AcgResources.ID_RADIOERGONOMICSWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4176, AcgResources.ID_PERSONNELACCOUNTABILITY);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4008, AcgResources.ID_ACTIONCONSOLIDATION);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4174, AcgResources.ID_MISSIONCRITICALGEOFENCE);
				num = (short)685900466;
				num2 = (int)((IntPtr)num);
				continue;
				IL_39CD:
				num = (short)683999596;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3A14:
				num = (short)1213792458;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3A5D:
				num = (short)162136107;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3A9F:
				num = (short)1261371729;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3AE6:
				num = (short)834273894;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3BB9:
				num = (short)659882017;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3BDF:
				num = (short)71893543;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3C43:
				num = (short)181862490;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3C87:
				num = (short)1672741318;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3D64:
				num = (short)1101660161;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3E3F:
				num = (short)1870529150;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3ECB:
				num = (short)794624566;
				num2 = (int)((IntPtr)num);
				continue;
				IL_40C3:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_EMERGENCYCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2032, AcgResources.ID_EMERGENCYWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2075, AcgResources.ID_CONVENTIONALEMERGENCYPROFILES);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2076, AcgResources.ID_TRUNKINGEMERGENCYPROFILES);
				num = (short)845873174;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4135:
				num = (short)923795776;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4211:
				num = (short)2108162343;
				num2 = (int)((IntPtr)num);
				continue;
				IL_425A:
				acpTreeViewItem = new AcpTreeViewItem();
				acpTreeViewItem.Header = AcgResources.ID_NOISEREDUCTIONCONFIGURATION;
				acpTreeViewItem2.Items.Add(acpTreeViewItem);
				this.AddFeatureNodeItems(acpTreeViewItem, 2086, AcgResources.ID_RADIONOISEREDUCTIONPROFILE);
				this.AddFeatureNodeItems(acpTreeViewItem, 2087, AcgResources.ID_ACCESSORYNOISEREDUCTIONPROFILE);
				this.AddFeatureNodeItems(acpTreeViewItem, 2131, AcgResources.ID_GLOBALNOISEREDUCTIONLIST);
				num = (short)908853877;
				num2 = (int)((IntPtr)num);
				continue;
				IL_42C7:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_SCANCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2023, AcgResources.ID_SCANWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2057, AcgResources.ID_SCANLIST);
				num = (short)1353908705;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4329:
				num = (short)454820195;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4448:
				num = (short)460652574;
				num2 = (int)((IntPtr)num);
				continue;
				IL_448B:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_CONVENTIONALCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2024, AcgResources.ID_CONVENTIONALWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2078, AcgResources.ID_MPLCONFIGURATION);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2007, AcgResources.ID_CONVENTIONALALIASLISTS);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2034, AcgResources.ID_REPEATERIDLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2062, AcgResources.ID_ASTROTALKGROUPLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2053, AcgResources.ID_CONVENTIONALSYSTEM);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2059, AcgResources.ID_CONVENTIONALPERSONALITY);
				num = (short)1753481483;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4541:
				num = (short)1698366001;
				num2 = (int)((IntPtr)num);
				continue;
				IL_45D0:
				this.AddFeatureNodeItems(this.myTreeViewItemRoot, 2000, AcgResources.ID_PHONEWIDE);
				num = (short)1413939526;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4671:
				num = (short)469828137;
				num2 = (int)((IntPtr)num);
				continue;
				IL_46B3:
				num = (short)1323761861;
				num2 = (int)((IntPtr)num);
				continue;
				IL_473C:
				num = (short)1021837629;
				num2 = (int)((IntPtr)num);
				continue;
				IL_47CC:
				num = (short)917963301;
				num2 = (int)((IntPtr)num);
				continue;
				IL_480F:
				acpTreeViewItem = new AcpTreeViewItem();
				acpTreeViewItem.Header = AcgResources.ID_VOICEANNOUNCEMENTS;
				acpTreeViewItem2.Items.Add(acpTreeViewItem);
				this.AddFeatureNodeItems(acpTreeViewItem, 2301, AcgResources.ID_VOICEANNOUNCEMENTWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem, 4145, AppResources.ID_SITESELECTABLEALERTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem, 2300, AcgResources.ID_VOICEANNOUNCEMENTLIST);
				num = (short)2017067172;
				num2 = (int)((IntPtr)num);
				continue;
				IL_487D:
				num = (short)2132279873;
				num2 = (int)((IntPtr)num);
				continue;
				IL_490F:
				num = (short)2098528482;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4958:
				num = (short)59310485;
				num2 = (int)((IntPtr)num);
				continue;
				IL_499F:
				num = (short)104006022;
				num2 = (int)((IntPtr)num);
				continue;
				IL_49E4:
				num = (short)1714946071;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4A29:
				num = (short)1149632705;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4A73:
				this.AddFeatureNodeItems(this.myTreeViewItemRoot, 2051, AcgResources.ID_ZONECHANNELASSIGNMENT);
				num = (short)1245905373;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4C41:
				num = (short)702874059;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4D19:
				num = (short)1929510967;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4DAA:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_DATACONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2028, AcgResources.ID_DATAWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2054, AcgResources.ID_DATAPROFILES);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4148, AcgResources.ID_ENHANCEDDATAPORTLIST);
				num = (short)1474167467;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4E1D:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_DVRSCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4142, AcgResources.ID_DVRSWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4143, AcgResources.ID_DVRSPROFILES);
				num = (short)328401507;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4F12:
				num = (short)1031864719;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4F54:
				num = (short)1099825381;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4F9C:
				num = (short)900792453;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5071:
				this.AddFeatureNodeItems(acpTreeViewItem2, 4231, AcgResources.ID_VIRTUALPARTNERALERT);
				num = (short)2125595088;
				num2 = (int)((IntPtr)num);
				continue;
				IL_51E9:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_SECURECONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2021, AcgResources.ID_SECUREWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2055, AcgResources.ID_ASTROOTARPROFILE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4228, AppResources.System_Cerfiticate_List_ID);
				num = (short)2113863834;
				num2 = (int)((IntPtr)num);
				continue;
				IL_525B:
				num = (short)652935234;
				num2 = (int)((IntPtr)num);
				continue;
				IL_52A3:
				num = (short)249758056;
				num2 = (int)((IntPtr)num);
				continue;
				IL_52E3:
				acpTreeViewItem = new AcpTreeViewItem();
				acpTreeViewItem.Header = AcgResources.ID_CONTROLS;
				acpTreeViewItem2.Items.Add(acpTreeViewItem);
				this.AddFeatureNodeItems(acpTreeViewItem, 2042, AcgResources.ID_BUTTONS);
				this.AddFeatureNodeItems(acpTreeViewItem, 2038, AcgResources.ID_SWITCHES);
				this.AddFeatureNodeItems(acpTreeViewItem, 4115, AcgResources.ID_CONTROLHEADO2);
				this.AddFeatureNodeItems(acpTreeViewItem, 2127, AcgResources.ID_CONTROLHEADO3);
				this.AddFeatureNodeItems(acpTreeViewItem, 2130, AcgResources.ID_CONTROLHEADO5);
				this.AddFeatureNodeItems(acpTreeViewItem, 4114, AcgResources.ID_CONTROLHEADO7);
				this.AddFeatureNodeItems(acpTreeViewItem, 4003, AcgResources.ID_CONTROLHEADO9);
				this.AddFeatureNodeItems(acpTreeViewItem, 4236, AcgResources.ID_CONTROLHEADE5);
				this.AddFeatureNodeItems(acpTreeViewItem, 2088, AcgResources.ID_MENUITEMS);
				this.AddFeatureNodeItems(acpTreeViewItem, 2128, AcgResources.ID_KEYPADMICANDACCESSORIES);
				this.AddFeatureNodeItems(acpTreeViewItem, 4109, AcgResources.ID_KEYPAD);
				this.AddFeatureNodeItems(acpTreeViewItem, 2129, AcgResources.ID_DEK);
				this.AddFeatureNodeItems(acpTreeViewItem, 2036, AcgResources.ID_ACCESSORYBUTTONS);
				this.AddFeatureNodeItems(acpTreeViewItem, 4130, AcgResources.ID_SMARTKEYFOBBUTTONS);
				this.AddFeatureNodeItems(acpTreeViewItem, 2125, AcgResources.ID_RADIOVIPS);
				num = (short)958333007;
				num2 = (int)((IntPtr)num);
				continue;
				IL_541E:
				num = (short)41747003;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5461:
				num = (short)822935694;
				num2 = (int)((IntPtr)num);
				continue;
				IL_54A4:
				num = (short)1940718116;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5700:
				num = (short)733151507;
				num2 = (int)((IntPtr)num);
				continue;
				IL_57D2:
				num = (short)1930952990;
				num2 = (int)((IntPtr)num);
				continue;
				IL_581A:
				num = (short)1052836489;
				num2 = (int)((IntPtr)num);
				continue;
				IL_58F3:
				num = (short)927072285;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5985:
				num = (short)2092761441;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5A12:
				acpTreeViewItem = new AcpTreeViewItem();
				acpTreeViewItem.Header = AcgResources.ID_NOISEREDUCTIONCONFIGURATION;
				acpTreeViewItem2.Items.Add(acpTreeViewItem);
				this.AddFeatureNodeItems(acpTreeViewItem, 2086, AcgResources.ID_RADIONOISEREDUCTIONPROFILE);
				this.AddFeatureNodeItems(acpTreeViewItem, 2087, AcgResources.ID_ACCESSORYNOISEREDUCTIONPROFILE);
				this.AddFeatureNodeItems(acpTreeViewItem, 2131, AcgResources.ID_GLOBALNOISEREDUCTIONLIST);
				num = (short)1379270758;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5ACE:
				num = (short)950010435;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5BF8:
				num = (short)1062601290;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5C82:
				num = (short)2018574819;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5CCB:
				num = (short)179699864;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5D0C:
				num = (short)338625077;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5D97:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_RADIOERGONOMICSCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2033, AcgResources.ID_RADIOERGONOMICSWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4176, AcgResources.ID_PERSONNELACCOUNTABILITY);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4008, AcgResources.ID_ACTIONCONSOLIDATION);
				this.AddFeatureNodeItems(acpTreeViewItem2, 4174, AcgResources.ID_MISSIONCRITICALGEOFENCE);
				num = (short)1759248768;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5ED9:
				num = (short)297730247;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5F21:
				num = (short)2067071464;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5F65:
				num = (short)1213465054;
				num2 = (int)((IntPtr)num);
				continue;
				IL_608D:
				num = (short)1890517678;
				num2 = (int)((IntPtr)num);
				continue;
				IL_60D5:
				num = (short)1975975963;
				num2 = (int)((IntPtr)num);
				continue;
				IL_611D:
				num = (short)44695600;
				num2 = (int)((IntPtr)num);
				continue;
				IL_61F9:
				num = (short)271909290;
				num2 = (int)((IntPtr)num);
				continue;
				IL_62DC:
				num = (short)1497170093;
				num2 = (int)((IntPtr)num);
				continue;
				IL_631C:
				num = (short)1232863627;
				num2 = (int)((IntPtr)num);
				continue;
				IL_635E:
				this.AddFeatureNodeItems(acpTreeViewItem2, 4231, AcgResources.ID_VIRTUALPARTNERALERT);
				num = (short)2085945566;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6400:
				num = (short)690815655;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6564:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_TRUNKINGCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2027, AcgResources.ID_TRUNKINGWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2064, AcgResources.ID_TRUNKINGSYSTEM);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2072, AcgResources.ID_TRUNKINGPERSONALITY);
				num = (short)1770914211;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6625:
				num = (short)1678770655;
				num2 = (int)((IntPtr)num);
				continue;
				IL_66BB:
				num = (short)1551434424;
				num2 = (int)((IntPtr)num);
				continue;
				IL_67DD:
				num = (short)828441096;
				num2 = (int)((IntPtr)num);
				continue;
				IL_68B5:
				num = (short)998310407;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6B90:
				num = (short)2127823288;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6BD2:
				num = (short)799670657;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6C10:
				num = (short)1655832898;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6C53:
				num = (short)1522074243;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6CE3:
				num = (short)2092761525;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6D2C:
				num = (short)1296630099;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6E0A:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_EMERGENCYCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2032, AcgResources.ID_EMERGENCYWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2075, AcgResources.ID_CONVENTIONALEMERGENCYPROFILES);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2076, AcgResources.ID_TRUNKINGEMERGENCYPROFILES);
				num = (short)1270218921;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6EC9:
				num = (short)2070741342;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6F10:
				num = (short)1651441673;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6F59:
				num = (short)1330839885;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6FE3:
				acpTreeViewItem2 = new AcpTreeViewItem();
				acpTreeViewItem2.Header = AcgResources.ID_CALLLISTCONFIGURATION;
				this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2222, AcgResources.ID_CALLLISTWIDE);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2200, AcgResources.ID_UNIFIEDCALLLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2208, AcgResources.ID_ASTRO25TRUNKINGHOTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2214, AcgResources.ID_TYPEIITRUNKINGHOTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2210, AcgResources.ID_ASTROCONVENTIONALHOTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2212, AcgResources.ID_MDCCONVENTIONALHOTLIST);
				this.AddFeatureNodeItems(acpTreeViewItem2, 2220, AcgResources.ID_PHONEHOTLIST);
				num = (short)2104754539;
				num2 = (int)((IntPtr)num);
				continue;
				IL_709B:
				num = (short)1384448172;
				num2 = (int)((IntPtr)num);
				continue;
				IL_716C:
				num = (short)459276530;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7201:
				num = (short)710410246;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7283:
				num = (short)2041447004;
				num2 = (int)((IntPtr)num);
				continue;
				IL_73CA:
				num = (short)1061617953;
				num2 = (int)((IntPtr)num);
				continue;
				IL_74A1:
				num = (short)997916948;
				num2 = (int)((IntPtr)num);
				continue;
				IL_752F:
				num = (short)655687869;
				num2 = (int)((IntPtr)num);
				continue;
				IL_75BB:
				num = (short)624099520;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7603:
				num = (short)1393558003;
				num2 = (int)((IntPtr)num);
				continue;
				IL_76E3:
				num = (short)1839399040;
				num2 = (int)((IntPtr)num);
				continue;
				IL_772E:
				num = (short)1294860422;
				num2 = (int)((IntPtr)num);
				continue;
				IL_77BE:
				num = (short)415170808;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7802:
				num = (short)170524706;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7845:
				num = (short)416743429;
				num2 = (int)((IntPtr)num);
			}
			IL_3E3A:
			goto IL_5539;
			IL_4324:
			return;
			IL_5539:
			acpTreeViewItem2 = new AcpTreeViewItem();
			acpTreeViewItem2.Header = AcgResources.ID_SCANCONFIGURATION;
			this.myTreeViewItemRoot.Items.Add(acpTreeViewItem2);
			this.AddFeatureNodeItems(acpTreeViewItem2, 2023, AcgResources.ID_SCANWIDE);
			this.AddFeatureNodeItems(acpTreeViewItem2, 2057, AcgResources.ID_SCANLIST);
		}

		// Token: 0x0400012B RID: 299
		private WindowMain winMain = (WindowMain)Application.Current.MainWindow;

		// Token: 0x0400012C RID: 300
		private bool PgLoaded;

		// Token: 0x0400012D RID: 301
		private IAcpFeatureNode copyNode;

		// Token: 0x0400012E RID: 302
		private ContextMenu cntxMenu;

		// Token: 0x0400012F RID: 303
		private MenuItem mItemAdd;

		// Token: 0x04000130 RID: 304
		private MenuItem mItemDelete;

		// Token: 0x04000131 RID: 305
		private MenuItem mItemCopy;

		// Token: 0x04000132 RID: 306
		private MenuItem mItemPaste;

		// Token: 0x04000133 RID: 307
		private bool mCanPaste;

		// Token: 0x04000134 RID: 308
		private bool bRecordOpPerformed;

		// Token: 0x04000135 RID: 309
		internal AcpTreeViewItem preSelectedItem;

		// Token: 0x04000137 RID: 311
		private string[] voiceAnnFiles;

		// Token: 0x04000138 RID: 312
		private string[] systemCertificateFiles;

		// Token: 0x0400013C RID: 316
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
