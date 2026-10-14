using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x02000105 RID: 261
	public class PageSecureKMFProfileTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600263F RID: 9791 RVA: 0x0025612C File Offset: 0x0025432C
		public PageSecureKMFProfileTbl()
		{
			int a_ = 4;
			base..ctor();
			try
			{
				this.InitializeComponent();
				global::AcpUI.Common.Utility.SetDirection(this);
				(this.RecNavToolbarPageSecureKMFProfile.FindName(global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많郐럒뇔髖곘럚꧜뛞釠迢胤", a_)) as global::AcpUI.AcpButton).Click += this.HandleAddBtnClick;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0025619C File Offset: 0x0025439C
		private void HandleAddBtnClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)335020032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
				int addMultQty;
				for (;;)
				{
					IL_28:
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_12F;
					case 1:
						try
						{
							num = (short)1476853762;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)804388868;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current).General.SecKmfProfileSecureProfileGUID_43662.CalculateValidity();
									num = (short)979435520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_271;
									}
									continue;
								case 3:
									goto IL_2F1;
								case 4:
									num = (short)1361969155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2A4:
								num = (short)1686896641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_271:
								goto IL_2A4;
							}
							IL_2F1:
							return;
						}
						finally
						{
							num = (short)604176384;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_328;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1092550658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_35E;
								}
								IL_328:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1575616513;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_35E:;
						}
						goto IL_361;
					case 2:
						if (this.RecNavToolbarPageSecureKMFProfile.RecordTypeToAdd != 0)
						{
							num = (short)1587675137;
							if (num != 0)
							{
							}
							num = (short)1764098058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						num3 = secureKMFProfileRecset.Count - addMultQty;
						num = (short)1107886087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)1922367489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)1790115840;
						short num4 = num;
						num = (short)372069600;
						short num5 = num;
						num = (short)42489056;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12F;
						default:
							num = (short)1827143680;
							if (num != 0)
							{
							}
							num = (short)511574018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						if (num3 >= secureKMFProfileRecset.Count)
						{
							num = (short)1171718148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_361;
					case 7:
						goto IL_D7;
					case 8:
						if (addMultQty > 0)
						{
							num = (short)2073755653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						goto IL_D7;
					case 10:
						num = (short)622592000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B;
					IL_D7:
					num = (short)731709446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12F:
					if (secureKMFProfileRecset != null)
					{
						num = (short)908656643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_361:
					(secureKMFProfileRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile).General.SecKmfProfileSecureProfileGUID_43662.Value = global::AllFeatures.CodeplugGuid.NewGuid();
					num3++;
					num = (short)278462473;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5B:
				secureKMFProfileRecset = (this.RecNavToolbarPageSecureKMFProfile.MyRecordsetDataSource as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
				addMultQty = this.RecNavToolbarPageSecureKMFProfile.AddMultQty;
				num = (short)107937800;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00256584 File Offset: 0x00254784
		public override void SetDataContext()
		{
			short num = (short)1384906755;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)715653122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_208;
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2055);
					num = (short)649920516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_15C;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					goto IL_AE;
				case 5:
					goto IL_AE;
				}
				IL_3C:
				num = (short)1553470378;
				short num3 = num;
				num = (short)1391727530;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_AE:
					num = (short)1988952064;
					short num4 = num;
					this.SecureKMFProfileList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
					this.RecNavToolbarPageSecureKMFProfile.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					this.RecNavToolbarPageSecureKMFProfile.MyDataPresenter = this.SecureKMFProfileList;
					base.MyBaseRecNavToolbar = this.RecNavToolbarPageSecureKMFProfile;
					num = (short)49348608;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)1431830528;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)32636929;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2055);
						num = (short)629604357;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_15C:
			num = (short)715849729;
			if (num != 0)
			{
			}
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2055);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSecureKMFProfile).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_208:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSecureKMFProfile).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x002567A8 File Offset: 0x002549A8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1468989440;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)921108481;
					if (num != 0)
					{
					}
					num = (short)2099773440;
					short num3 = num;
					num = (short)1226913355;
					short num4 = num;
					num = (short)977876555;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D5;
					default:
						num = (short)2123825152;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					}
					break;
				}
				case 1:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageSecureKMFProfile.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)261029890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				}
				goto IL_CD;
				IL_D5:
				num = (short)1624309761;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD:
				if (!this.b)
				{
					goto IL_D5;
				}
				break;
			}
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x002568E4 File Offset: 0x00254AE4
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
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
					num2 = (short)437321729;
					if (num2 != 0)
					{
					}
					if (!this.b)
					{
						return;
					}
					num2 = (short)691598989;
					short num3 = num2;
					num2 = (short)1921644173;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)896794624;
						if (num2 != 0)
						{
						}
						num2 = (short)1706491905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)1447952386;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.RecNavToolbarPageSecureKMFProfile.DataContext = null;
			this.RecNavToolbarPageSecureKMFProfile.MyDataPresenter = null;
			num2 = (short)763232256;
			short num4 = num2;
			num2 = (short)1271857152;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x00256A24 File Offset: 0x00254C24
		internal void OnSecureKMFProfileFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1007718569;
			short num2 = num;
			num = (short)696815785;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1157103616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1037107201;
			if (num != 0)
			{
			}
			num = (short)309788672;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile a_ = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00256AF8 File Offset: 0x00254CF8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)77355803;
			short num2 = num;
			num = (short)979655451;
			switch (num2 == num)
			{
			default:
			{
				num = (short)75038720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)199622657;
			if (num != 0)
			{
			}
			num = (short)907018240;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00256BA8 File Offset: 0x00254DA8
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
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
					if (this.a.CurrentItem != null)
					{
						goto IL_115;
					}
					num2 = (short)413191410;
					short num3 = num2;
					num2 = (short)959171826;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)999489536;
						if (num2 != 0)
						{
						}
						num2 = (short)1877409793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					this.a.MoveCurrentToFirst();
					num2 = (short)1874001922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_113;
				}
				goto IL_1C;
			}
			IL_113:
			IL_115:
			num2 = (short)410976257;
			if (num2 != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile a_ = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageSecureKMFProfile.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)728039424;
			short num4 = num2;
			num2 = (short)1083637760;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00256D0C File Offset: 0x00254F0C
		private void a(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile A_0)
		{
			short num = (short)509328700;
			short num2 = num;
			num = (short)1828109628;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2047475712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)223346688;
			if (num != 0)
			{
			}
			num = (short)2100756481;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00256DDC File Offset: 0x00254FDC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 16;
			while (this.c)
			{
				short num = (short)1898650106;
				short num2 = num;
				num = (short)196549114;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1553268736;
					short num3 = num;
					num = (short)1339883520;
					if (num != 0)
					{
					}
					num = (short)1110638593;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﻐ鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨裪苬苮臰鳲鯴鋶韸迺틼賾搀怂瀄甆氈⸊㼌㼎爐簒笔焖瀘簚栜洞䀠圢䰤䠦䜨Ъ帬䨮到䘲䜴制᰸ऺ഼吾ⱀ╂恄畆祈㭊㽌⁎㝐㩒㥔㉖癘⡚㡜㱞ᑠᅢd౦Ѩ൪ᵬᵮṰᕲᱴ᭶ᱸེὼ፾꾀ﮂ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00256EBC File Offset: 0x002550BC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1148977156;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_113;
				case 1:
					if (connectionId != 2)
					{
						num = (short)2088632323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AE;
				case 2:
					num = (short)582025217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)35651590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 5:
				{
					num = (short)401408001;
					if (num != 0)
					{
					}
					num = (short)1177812992;
					short num3 = num;
					num = (short)1711210496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (connectionId != 29)
					{
						num = (short)613023749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				}
				IL_40:
				if (connectionId == 1)
				{
					goto IL_1BE;
				}
				num = (short)1419421801;
				short num4 = num;
				num = (short)1838917737;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1BE;
				default:
					num = (short)1901199360;
					if (num != 0)
					{
					}
					num = (short)1891106818;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_AE:
			this.RecNavToolbarPageSecureKMFProfile = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageSecureKMFProfile.ModeClick += this.OnModeClick;
			return;
			IL_113:
			this.c = true;
			return;
			IL_14F:
			this.SecureKMFProfileList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1BE:
			((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.PageSecureKMFProfileTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.PageSecureKMFProfileTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x002570C0 File Offset: 0x002552C0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				break;
			case 4:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
			{
				short num = (short)309198849;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
			{
				short num = (short)1101525905;
				short num2 = num;
				num = (short)381875089;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_306;
				case 1:
					break;
				default:
				{
					num = (short)1607729152;
					short num3 = num;
					break;
				}
				}
				num = (short)1769275392;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 23:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			IL_306:
			((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000E53 RID: 3667
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000E54 RID: 3668
		private bool b;

		// Token: 0x04000E55 RID: 3669
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageSecureKMFProfile;

		// Token: 0x04000E56 RID: 3670
		internal global::AcpUI.AcpXamDataPresenter SecureKMFProfileList;

		// Token: 0x04000E57 RID: 3671
		private bool c;
	}
}
