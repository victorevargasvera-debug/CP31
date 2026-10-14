using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000022 RID: 34
	public class AcpPageFeature : global::System.Windows.Controls.Page, global::AcpUILib.IAcpPageFeature
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000215E8 File Offset: 0x0001F7E8
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00021698 File Offset: 0x0001F898
		public global::AcpUI.AcpRecNavToolbar MyBaseRecNavToolbar
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)398040642;
				short num2 = num;
				num = (short)149331522;
				switch (num2 == num)
				{
				}
				num = (short)1139081216;
				short num3 = num;
				num = (short)1236008961;
				if (num != 0)
				{
				}
				num = (short)1115160576;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1415168341;
				short num2 = num;
				num = (short)2670933;
				switch (num2 == num)
				{
				}
				num = (short)4521984;
				short num3 = num;
				num = (short)1756889089;
				if (num != 0)
				{
				}
				num = (short)185204736;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00021748 File Offset: 0x0001F948
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00021800 File Offset: 0x0001FA00
		public global::AcpUI.AcpRecNavToolbar PageRecNavToolbar
		{
			get
			{
				short num = (short)1149994131;
				short num2 = num;
				num = (short)1643938963;
				switch (num2 == num)
				{
				}
				num = (short)178716672;
				short num3 = num;
				num = (short)1362427905;
				if (num != 0)
				{
				}
				num = (short)1518534656;
				if (num != 0)
				{
				}
				return (global::AcpUI.AcpRecNavToolbar)base.GetValue(global::AcpUI.AcpPageFeature.PageRecNavToolbarProperty);
			}
			set
			{
				short num = (short)1386583766;
				short num2 = num;
				num = (short)568366806;
				switch (num2 == num)
				{
				}
				num = (short)1409941504;
				short num3 = num;
				num = (short)1011875841;
				if (num != 0)
				{
				}
				num = (short)792199168;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpPageFeature.PageRecNavToolbarProperty, value);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000218B4 File Offset: 0x0001FAB4
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00021964 File Offset: 0x0001FB64
		public int PageFeatureId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2094715695;
				short num2 = num;
				num = (short)413389615;
				switch (num2 == num)
				{
				}
				num = (short)1999241216;
				short num3 = num;
				num = (short)1295253505;
				if (num != 0)
				{
				}
				num = (short)409731072;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)643370288;
				short num2 = num;
				num = (short)525667632;
				switch (num2 == num)
				{
				}
				num = (short)1058930688;
				short num3 = num;
				num = (short)463405057;
				if (num != 0)
				{
				}
				num = (short)5832704;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00021A14 File Offset: 0x0001FC14
		public global::AcpUI.ExpanderCollection Expanders
		{
			get
			{
				short num = (short)962972035;
				short num2 = num;
				num = (short)1320274307;
				switch (num2 == num)
				{
				}
				num = (short)1184890880;
				short num3 = num;
				num = (short)2126708737;
				if (num != 0)
				{
				}
				num = (short)1203240960;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00021AC0 File Offset: 0x0001FCC0
		public virtual void SetDataContext()
		{
			short num = (short)999292929;
			if (num != 0)
			{
			}
			num = (short)1758554134;
			short num2 = num;
			num = (short)462514198;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1897857024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1463156736;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00021B70 File Offset: 0x0001FD70
		private void OnInitialized(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1460207617;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1526530049;
					if (num != 0)
					{
					}
					for (;;)
					{
						this.SetDataContext();
						num = (short)1603386442;
						short num3 = num;
						num = (short)1848818762;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_F6;
						}
					}
					IL_F6:
					num = (short)1191772160;
					if (num != 0)
					{
					}
					num = (short)68419586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1177681920;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				case 2:
					goto IL_123;
				}
				IL_58:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					break;
				}
				num = (short)334036992;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_123:
			base.Initialized -= this.OnInitialized;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00021CB4 File Offset: 0x0001FEB4
		public virtual void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::AcpBusinessLayer.FeatureNode currentNode;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpExpander> enumerator;
				switch (num)
				{
				case 0:
					goto IL_248;
				case 1:
					if (currentNode != null)
					{
						num2 = (short)976879617;
						if (num2 != 0)
						{
						}
						num2 = (short)656277504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_270;
				case 2:
					try
					{
						num2 = (short)398983170;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)1119027204;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_E1;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)4325376;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::AcpUI.AcpExpander acpExpander = enumerator.Current;
								acpExpander.IsExpanded = !global::AcpUI.AcpExpStatusManager.Contains(currentNode.NodeId, acpExpander);
								acpExpander.Collapsed += this.exp_Collapsed;
								acpExpander.Expanded += this.exp_Expanded;
								num2 = (short)857486554;
								short num3 = num2;
								num2 = (short)267793626;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1DA;
								default:
									num2 = (short)951910400;
									if (num2 != 0)
									{
									}
									num2 = (short)943456257;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 4:
								goto IL_1DA;
							}
							IL_E3:
							num2 = (short)444465155;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_E1:
							goto IL_E3;
						}
						IL_1DA:
						goto IL_270;
					}
					finally
					{
						num2 = (short)615186433;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1000013826;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_210;
								}
								continue;
							case 2:
								goto IL_245;
							}
							IL_210:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)455999488;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_245:;
					}
					goto IL_248;
				}
				goto IL_1C;
				IL_248:
				enumerator = this.Expanders.GetEnumerator();
				num2 = (short)1114374146;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_270:
			num2 = (short)1471348736;
			short num4 = num2;
			return;
			IL_1C:
			global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged += this.OnAppInfoPropertyChanged;
			global::AcpBusinessLayer.AcpDocument.PageOnLoading = true;
			this.a();
			global::AcpBusinessLayer.AcpDocument.PageOnLoading = false;
			currentNode = this.GetCurrentNode();
			num2 = (short)1832583169;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00021F78 File Offset: 0x00020178
		protected global::AcpBusinessLayer.FeatureNode GetCurrentNode()
		{
			short num = (short)1023849803;
			short num2 = num;
			num = (short)583447883;
			switch (num2 == num)
			{
			}
			num = (short)1774977024;
			short num3 = num;
			num = (short)130154497;
			if (num != 0)
			{
			}
			num = (short)602079232;
			if (num != 0)
			{
			}
			return (global::AcpBusinessLayer.FeatureNode)((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView((global::AcpCommonLib.IAcpRecordset)base.DataContext)).CurrentItem;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00022040 File Offset: 0x00020240
		private void exp_Expanded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)326303745;
			if (num != 0)
			{
			}
			num = (short)975601158;
			short num2 = num;
			num = (short)1978957318;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1019543552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1461452800;
			if (num != 0)
			{
			}
			global::AcpUI.AcpExpStatusManager.Remove(this.GetCurrentNode().NodeId, (global::AcpUI.AcpExpander)A_0);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00022100 File Offset: 0x00020300
		private void exp_Collapsed(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)315752449;
			if (num != 0)
			{
			}
			num = (short)833605966;
			short num2 = num;
			num = (short)1796329806;
			switch (num2 == num)
			{
			default:
			{
				num = (short)912785408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1966342144;
			if (num != 0)
			{
			}
			global::AcpUI.AcpExpStatusManager.Add(this.GetCurrentNode().NodeId, (global::AcpUI.AcpExpander)A_0);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000221C0 File Offset: 0x000203C0
		public void OnHLinkClick(object sender)
		{
			string key = (string)((global::System.Windows.Documents.Hyperlink)sender).Tag;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_33;
				}
				int num;
				global::AcpUI.AcpExpander acpExpander;
				for (;;)
				{
					IL_1D:
					switch (num)
					{
					case 0:
						for (;;)
						{
							acpExpander.IsExpanded = true;
							num2 = (short)1743753287;
							short num3 = num2;
							num2 = (short)1996656711;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_B1;
							}
						}
						IL_B1:
						num2 = (short)1963196416;
						if (num2 != 0)
						{
						}
						num2 = (short)148045825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_E1;
					case 2:
						goto IL_105;
					case 3:
						if (!acpExpander.IsExpanded)
						{
							num2 = (short)953679872;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E1;
					}
					goto IL_33;
					IL_E1:
					acpExpander.BringIntoView();
					acpExpander.Focus();
					num2 = (short)1834221570;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_105:
				goto IL_10A;
				IL_33:
				acpExpander = this.Expanders[key];
				num2 = (short)1480785923;
				num = (int)((global::System.IntPtr)num2);
				goto IL_1D;
			}
			catch (global::System.Exception)
			{
			}
			IL_10A:
			num2 = (short)1155923968;
			short num4 = num2;
			num2 = (short)473038849;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00022338 File Offset: 0x00020538
		private void OnAppInfoPropertyChanged(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)82313224;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)19136512;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_182;
				case 1:
					if (A_1.PropertyName == global::AcpUI.Common.Utility.c("킘펠힢힦첨\ud9aa첬\udbae\ud8b0\udcb2\udbb4횸횺춼펾꓀럂ꃄꏆ", a_))
					{
						num = (short)363069440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 2:
				{
					global::AcpCommonLib.IAcpConstraints acpConstraints;
					if (acpConstraints != null)
					{
						num = (short)1620312068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23F;
				}
				case 3:
					num = (short)1188560897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)357954271;
					short num4 = num;
					num = (short)721351391;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)902234112;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpConstraints acpConstraints;
						acpConstraints.CalculateEditability(true);
						acpConstraints.CalculateVisibility(true);
						num = (short)1098186764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					num = (short)403898369;
					if (num != 0)
					{
					}
					this.RefreshComparatorOdp();
					num = (short)511705095;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_28E;
				case 7:
					return;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					continue;
				case 9:
					if (A_1.PropertyName == global::AcpUI.Common.Utility.c("\ud898튞캠잢삤", a_))
					{
						num = (short)17694725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					if (A_1.PropertyName == global::AcpUI.Common.Utility.c("\ud898즞좠욢튤", a_))
					{
						num = (short)1221328907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23F;
				case 11:
				{
					global::AcpCommonLib.IAcpConstraints acpConstraints = base.DataContext as global::AcpCommonLib.IAcpConstraints;
					num = (short)1124335618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_23F;
				}
				IL_8B:
				if (!(A_1.PropertyName == global::AcpUI.Common.Utility.c("\udd98列킞토욢힤욦\udda8슪슬솮\udcb2\ud8b4잶햸\udeba즼\udabeꗀ", a_)))
				{
					num = (short)1434058755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_182:
				this.a();
				num = (short)1951531014;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23F:
				num = (short)1417609225;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_28E:
				num = (short)1249902602;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00022628 File Offset: 0x00020828
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::AcpCommonLib.IAcpConstraints acpConstraints;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_A5;
				case 1:
					return;
				case 2:
					if (acpConstraints != null)
					{
						num2 = (short)1451687936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			acpConstraints = (base.DataContext as global::AcpCommonLib.IAcpConstraints);
			num2 = (short)134782852;
			short num3 = num2;
			num2 = (short)2102501252;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A5:
				num2 = (short)1475215360;
				short num4 = num2;
				num2 = (short)892403713;
				if (num2 != 0)
				{
				}
				acpConstraints.CalculateApplicability();
				acpConstraints.CalculateEditability(true);
				acpConstraints.CalculateVisibility(true);
				num2 = (short)994902017;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1559756800;
				if (num2 != 0)
				{
				}
				num2 = (short)2117009410;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00022758 File Offset: 0x00020958
		public void RefreshComparatorOdp()
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)1843527681;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				int num2;
				global::System.Windows.Data.ObjectDataProvider objectDataProvider;
				for (;;)
				{
					IL_39:
					switch (num2)
					{
					case 0:
					{
						num = (short)170323134;
						short num3 = num;
						num = (short)1463610558;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)628555776;
							if (num != 0)
							{
							}
							break;
						}
						objectDataProvider.Refresh();
						num = (short)1063780353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_106;
					case 2:
						goto IL_11E;
					case 3:
						if (objectDataProvider != null)
						{
							num = (short)1821376512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_106;
					}
					goto IL_4F;
					IL_106:
					num = (short)1926627330;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11E:
				goto IL_123;
				IL_4F:
				objectDataProvider = (base.FindResource(global::AcpUI.Common.Utility.c("\ud99d얟횡즥얧\udaa9춫\udcad톯욱\udbb3쒵\udbb9캻\udbbd꺿뛁苃ꏅ꧇뻉맋볍뗏", a_)) as global::System.Windows.Data.ObjectDataProvider);
				num = (short)483983363;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_39;
			}
			catch (global::System.Windows.ResourceReferenceKeyNotFoundException)
			{
			}
			IL_123:
			num = (short)742195200;
			short num4 = num;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000228D0 File Offset: 0x00020AD0
		public virtual void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2083454977;
			if (num != 0)
			{
			}
			num = (short)1070661632;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpExpander> enumerator = this.Expanders.GetEnumerator();
			try
			{
				num = (short)236847108;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)1368418019;
						short num4 = num;
						num = (short)1789159139;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)2085486592;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)1380319234;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpUI.AcpExpander acpExpander = enumerator.Current;
							acpExpander.ExpToolbar = null;
							acpExpander.Collapsed -= this.exp_Collapsed;
							acpExpander.Expanded -= this.exp_Expanded;
							num = (short)1022361601;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						num = (short)4718595;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_17B;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_98;
						}
						continue;
					}
					IL_E0:
					num = (short)20512768;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_98:
					goto IL_E0;
				}
				IL_17B:;
			}
			finally
			{
				num = (short)904527874;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)2027618305;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1E1;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1AD;
						}
						continue;
					}
					IL_1AD:
					if (enumerator == null)
					{
						break;
					}
					num = (short)834207744;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1E1:;
			}
			this.Expanders.Clear();
			global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged -= this.OnAppInfoPropertyChanged;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00022B00 File Offset: 0x00020D00
		public AcpPageFeature()
		{
			global::System.GC.Collect();
			global::System.GC.WaitForPendingFinalizers();
			global::System.GC.Collect();
			base.Initialized += this.OnInitialized;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00022B40 File Offset: 0x00020D40
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1565982721;
				if (num != 0)
				{
				}
				num = (short)599728270;
				short num2 = num;
				num = (short)641671310;
				switch (num2 == num)
				{
				}
				num = (short)1641611264;
				if (num != 0)
				{
				}
			}
			finally
			{
				base.Finalize();
			}
			num = (short)367656960;
			short num3 = num;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00022C04 File Offset: 0x00020E04
		// Note: this type is marked as 'beforefieldinit'.
		static AcpPageFeature()
		{
			int a_ = 16;
			short num = (short)1162561665;
			short num2 = num;
			num = (short)426920065;
			switch (num2 == num)
			{
			}
			num = (short)1488650240;
			short num3 = num;
			num = (short)388956160;
			if (num != 0)
			{
			}
			num = (short)1188102145;
			if (num != 0)
			{
			}
			global::AcpUI.AcpPageFeature.PageRecNavToolbarProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("즧충즫ﲭ햯톱荒ힵ캷펻톽겿ꃁꗃ듅", a_), typeof(global::AcpUI.AcpRecNavToolbar), typeof(global::AcpUI.AcpPageFeature), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x04000174 RID: 372
		private global::AcpUI.ExpanderCollection a = new global::AcpUI.ExpanderCollection();

		// Token: 0x04000175 RID: 373
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpUI.AcpRecNavToolbar b;

		// Token: 0x04000176 RID: 374
		public static readonly global::System.Windows.DependencyProperty PageRecNavToolbarProperty;

		// Token: 0x04000177 RID: 375
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;
	}
}
