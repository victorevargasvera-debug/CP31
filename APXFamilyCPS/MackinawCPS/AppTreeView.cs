using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using AcpCommonLib;
using AcpUI;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200000A RID: 10
	public class AppTreeView : global::AcpUI.AcpTreeView
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00004288 File Offset: 0x00002488
		public override bool UpdateTreeView(int nRecsetID)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_141;
				case 1:
					if (nRecsetID != 4228)
					{
						num2 = (short)398000136;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_141;
				case 2:
					num2 = (short)1107492867;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (nRecsetID != 2300)
					{
						num2 = (short)1362165764;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_141;
				case 4:
					IL_13F:
					num2 = (short)1421213697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_1A8;
				case 6:
					if (nRecsetID == 4234)
					{
						num2 = (short)1377959937;
						if (num2 != 0)
						{
						}
						num2 = (short)879493120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 7:
					if (nRecsetID != 2200)
					{
						num2 = (short)1089011714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_141;
				case 8:
					num2 = (short)942407686;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_141:
				result = false;
				num2 = (short)1313335025;
				short num3 = num2;
				num2 = (short)1240786673;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_13F;
				default:
					num2 = (short)1138688000;
					if (num2 != 0)
					{
					}
					num2 = (short)1486028805;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_1A8:
			num2 = (short)782368768;
			short num4 = num2;
			return result;
			IL_34:
			result = true;
			num2 = (short)1624768519;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004468 File Offset: 0x00002668
		public override void LaunchPage(string pageUri)
		{
			int a_ = 14;
			global::System.Windows.Controls.Frame frameCenterTop;
			global::System.Uri uri;
			for (;;)
			{
				IL_09:
				short num = (short)687472640;
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
					global::AcpUI.AcpTreeViewItem acpTreeViewItem;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							num = (short)251723778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (acpTreeViewItem != null)
							{
								num = (short)80478212;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_36A;
						case 2:
						{
							num = (short)1091987194;
							short num3 = num;
							num = (short)1480550138;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)1062993920;
								if (num != 0)
								{
								}
								if (frameCenterTop.Content is global::AcpUI.AcpPageFeature)
								{
									num = (short)1206976515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E9;
							}
							break;
						}
						case 3:
							num = (short)760217606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)964952076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)2141192193;
							if (num != 0)
							{
							}
							uri = new global::System.Uri(global::System.Uri.EscapeUriString(pageUri.Replace(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("닭", a_), global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쇭", a_))), global::System.UriKind.RelativeOrAbsolute);
							frameCenterTop = ((global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow).FrameCenterTop;
							num = (short)2109669390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (frameCenterTop.CurrentSource.OriginalString == uri.OriginalString)
							{
								num = (short)1780482056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23F;
						case 7:
							num = (short)262995969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_365;
						case 9:
							goto IL_2F8;
						case 10:
						{
							num = (short)213188608;
							short num4 = num;
							if (!string.IsNullOrEmpty(pageUri))
							{
								num = (short)77529093;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FD;
						}
						case 11:
							goto IL_36A;
						case 12:
							if (acpTreeViewItem.NodeId != 0)
							{
								num = (short)1961099273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_36A;
						case 13:
							if (base.CurrentRecord == null)
							{
								num = (short)607649799;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F8;
						case 14:
							if (frameCenterTop.Content != null)
							{
								num = (short)218497024;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25A;
						}
						break;
						IL_2F8:
						this.SetFocusOnCurrentRecord();
						num = (short)1085407243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_36A:
						num = (short)1645871114;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_74:
					string[] array = global::MackinawCPS.AppTreeView.a();
					bool isTampered = !global::PreEmptive.SoS.Runtime.Verifier.Verify(global::PreEmptive.SoS.Runtime.Verifier.FindMyAddress(global::System.Reflection.Assembly.GetAssembly(typeof(global::MackinawCPS.AppTreeView))), array[0], array[1], array[2]);
					global::MackinawCPS.DotfDetect.handle(isTampered);
					acpTreeViewItem = (base.SelectedItem as global::AcpUI.AcpTreeViewItem);
					num = (short)1350500365;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			IL_1E9:
			frameCenterTop.ContentRendered += this.LoadCompleteHandler;
			frameCenterTop.Navigate(uri);
			return;
			IL_23F:
			frameCenterTop.ContentRendered += this.LoadCompleteHandler;
			frameCenterTop.Navigate(uri);
			return;
			IL_25A:
			frameCenterTop.ContentRendered += this.LoadCompleteHandler;
			frameCenterTop.Navigate(uri);
			return;
			IL_365:
			frameCenterTop.NavigationService.LoadCompleted += this.SamePageLoadCompleteHandler;
			frameCenterTop.Navigate(uri);
			return;
			IL_3FD:
			this.LoadCompleteHandler(this, null);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000487C File Offset: 0x00002A7C
		private void SetFocusOnCurrentRecord()
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num3;
			global::AcpCommonLib.IAcpFeatureNode currentRecord;
			for (;;)
			{
				IL_0A:
				int num2;
				global::AcpUI.AcpTreeViewItem acpTreeViewItem;
				switch (num)
				{
				case 0:
					IL_F8:
					num2 = 0;
					goto IL_1A8;
				case 1:
					num3 = (short)845873154;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					if (!currentRecord.Parent.SingleInstance)
					{
						num3 = (short)1950679050;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1048969216;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					return;
				case 4:
					num2 = currentRecord.NodeId;
					goto IL_1A8;
				case 5:
					acpTreeViewItem.IsSelected = true;
					num3 = (short)1719730179;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					if (acpTreeViewItem != null)
					{
						num3 = (short)849149959;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 7:
					acpTreeViewItem.BringIntoView();
					num3 = (short)1177354248;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					if (!acpTreeViewItem.IsSelected)
					{
						num3 = (short)452919301;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 9:
					num3 = (short)1563164673;
					if (num3 != 0)
					{
					}
					if (currentRecord != null)
					{
						num3 = (short)1570766849;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 10:
				{
					num3 = (short)289472512;
					short num4 = num3;
					num3 = (short)673775620;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				}
				goto IL_3C;
				IL_1A8:
				int nodeId = num2;
				acpTreeViewItem = base.FindChildTreeViewItem(currentRecord.Parent.RecsetId, nodeId);
				num3 = (short)56239052;
				short num5 = num3;
				num3 = (short)1359487948;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F8;
				default:
					num3 = (short)2037645312;
					if (num3 != 0)
					{
					}
					num3 = (short)196614;
					num = (int)((global::System.IntPtr)num3);
					break;
				}
			}
			return;
			IL_3C:
			currentRecord = base.CurrentRecord;
			num3 = (short)1508573193;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004AC8 File Offset: 0x00002CC8
		private void SamePageLoadCompleteHandler(object sender, global::System.Windows.Navigation.NavigationEventArgs e)
		{
			short num = (short)1165240276;
			short num2 = num;
			num = (short)125380564;
			switch (num2 == num)
			{
			}
			num = (short)508166145;
			if (num != 0)
			{
			}
			num = (short)409731072;
			if (num != 0)
			{
			}
			num = (short)698875904;
			short num3 = num;
			this.LoadCompleteHandler(this, null);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004B78 File Offset: 0x00002D78
		private void LoadCompleteHandler(object sender, global::System.EventArgs e)
		{
			short num = (short)1104412672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				object selectedItemContent;
				global::System.Windows.Controls.Frame frameCenterTop;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::AcpUI.AcpPageFeature acpPageFeature;
						global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpExpander> enumerator = acpPageFeature.Expanders.GetEnumerator();
						num = (short)315752449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1910702080;
						short num3 = num;
						try
						{
							num = (short)516751367;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpUI.AcpExpander acpExpander;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpExpander> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)353959947;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = enumerator.Current;
									num = (short)668270604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_42C;
								case 2:
									if (!acpExpander.IsExpanded)
									{
										num = (short)2117664782;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_42C;
								case 3:
									num = (short)764149770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (acpExpander.IsAcpVisible)
									{
										num = (short)2111504392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									goto IL_44C;
								case 6:
									num = (short)197197837;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_269;
									}
									continue;
								case 8:
									num = (short)122814466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_26E;
								case 10:
									if (this.sectionToLaunch.Parent.Parent.ParentSection.UIName.CompareTo(acpExpander.Header) == 0)
									{
										num = (short)117702665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									num = (short)1812660239;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (this.sectionToLaunch.UIName.CompareTo(acpExpander.Header) != 0)
									{
										num = (short)355598342;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_26E;
								case 13:
									if (this.sectionToLaunch.Parent.Parent.ParentSection != null)
									{
										num = (short)697892867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 14:
									acpExpander.IsExpanded = true;
									num = (short)586547201;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_48F;
								}
								goto IL_269;
								IL_26E:
								num = (short)159580164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3ED:
								num = (short)2013986816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_269:
								goto IL_3ED;
								IL_42C:
								acpExpander.Focus();
								num = (short)1106444293;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_44C:
							IL_48F:;
						}
						finally
						{
							num = (short)257622016;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpExpander> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4C3;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1744175106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4FA;
								}
								IL_4C3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1919811585;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4FA:;
						}
						goto IL_4FD;
					}
					case 2:
						try
						{
							num = (short)1218576386;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpUI.AcpExpander acpExpander2;
								switch (num2)
								{
								case 0:
								{
									num = (short)1158737532;
									short num4 = num;
									num = (short)168160892;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_6BB;
									default:
										num = (short)1684406272;
										if (num != 0)
										{
										}
										num = (short)1601044486;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_6BB;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5D1;
									}
									continue;
								case 3:
									goto IL_5F2;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpExpander> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)687276032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander2 = enumerator.Current;
									num = (short)1212416005;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									if (acpExpander2.IsAcpVisible)
									{
										num = (short)679542785;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									goto IL_6D8;
								}
								IL_5F7:
								num = (short)1523384324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5D1:
								goto IL_5F7;
								IL_6BB:
								acpExpander2.Focus();
								num = (short)1701904387;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5F2:
							IL_6D8:
							goto IL_521;
						}
						finally
						{
							num = (short)47316992;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpExpander> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_710;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)57278466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_748;
								}
								IL_710:
								if (enumerator == null)
								{
									break;
								}
								num = (short)66846721;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_748:;
						}
						goto IL_74B;
					case 3:
					{
						global::AcpUI.AcpPageFeature acpPageFeature;
						if (acpPageFeature.Expanders != null)
						{
							num = (short)1483866124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_521;
					}
					case 4:
						if (this.sectionToLaunch != null)
						{
							num = (short)115605510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FD;
					case 5:
					{
						global::MackinawCPS.PageTreeView pageTreeView = (global::MackinawCPS.PageTreeView)selectedItemContent;
						((global::MackinawCPS.AppTreeView)pageTreeView.Content).OnLoadComplete(frameCenterTop);
						pageTreeView.preSelectedItem = (base.SelectedItem as global::AcpUI.AcpTreeViewItem);
						global::AcpUI.AcpPageFeature acpPageFeature = frameCenterTop.Content as global::AcpUI.AcpPageFeature;
						num = (short)1554644995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1713307649;
						if (num != 0)
						{
						}
						num = (short)1113849866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_74B;
					case 8:
					{
						global::AcpUI.AcpPageFeature acpPageFeature;
						if (acpPageFeature.Expanders != null)
						{
							num = (short)1993342976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FD;
					}
					case 9:
						goto IL_51C;
					case 10:
						if (this.sectionToLaunch.UIName != null)
						{
							num = (short)1615986695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FD;
					case 11:
						if (selectedItemContent is global::MackinawCPS.PageTreeView)
						{
							num = (short)1920139269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_78D;
					case 12:
					{
						global::AcpUI.AcpPageFeature acpPageFeature;
						global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpExpander> enumerator = acpPageFeature.Expanders.GetEnumerator();
						num = (short)1951662082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_62;
					IL_4FD:
					this.sectionToLaunch = null;
					num = (short)1251606537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_521:
					base.Focus();
					num = (short)287244292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74B:
					num = (short)1129054216;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_51C:
				IL_78D:
				frameCenterTop.ContentRendered -= this.LoadCompleteHandler;
				frameCenterTop.NavigationService.LoadCompleted -= this.SamePageLoadCompleteHandler;
				return;
				IL_62:
				global::MackinawCPS.WindowMain windowMain = (global::MackinawCPS.WindowMain)global::System.Windows.Application.Current.MainWindow;
				frameCenterTop = windowMain.FrameCenterTop;
				selectedItemContent = ((global::MackinawCPS.PageNavPaneButtons)windowMain.FrameLeft.Content).GetSelectedItemContent();
				num = (short)1731723275;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005384 File Offset: 0x00003584
		public static string[] a()
		{
			int a_ = 2;
			short num = (short)424280065;
			if (num != 0)
			{
			}
			num = (short)872101950;
			short num2 = num;
			num = (short)146880574;
			switch (num2 == num)
			{
			}
			num = (short)372899840;
			short num3 = num;
			num = (short)1013645312;
			if (num != 0)
			{
			}
			return new string[]
			{
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛇㚈匿؁ﯳ䩰﻽ÿȁЃ؅ࠇ鰉ఋญဏ蠑ᐓᘕ᠗ꈙᰛḝ‟︡␣☥⠧", a_),
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("搑㺸䉸앏﻽ÿ阁Ѓ؅ࠇ鈉ఋญဏ먑ᐓᘕ᠗숙ᰛḝ‟숡␣☥⠧", a_),
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("砟⨃킗刯쾭닜딞牔袚㧒떣曽\ud81b쒀ꥧ髲⭦૨꾕ꅫ觷쪡ᅞ볂肥ᭈ㬏ⵯ\u0006\udd55咙쎺翑悼憻闍ⳅ㔪톭䛦羻홧亹ꬉ륳㮸者无0쯌✑硽텋\uda6c㫽튈欟嫅왫帅ⵉ拁㫕汰ᇟⵍ뀒撎ꕤ鮯Ɫ膆藗鲔냻ꤍ쐹晽᩺쎋", a_)
			};
		}

		// Token: 0x04000015 RID: 21
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
