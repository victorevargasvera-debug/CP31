using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using AcpCommonLib;

namespace AcpUI
{
	// Token: 0x02000023 RID: 35
	public class AcpParentRecNavToolbar : global::AcpUI.AcpRecNavToolbar
	{
		// Token: 0x060001DE RID: 478 RVA: 0x00022CF0 File Offset: 0x00020EF0
		public AcpParentRecNavToolbar()
		{
			this.a = new global::AcpUI.AcpChildToolbarCollection(this);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00022D10 File Offset: 0x00020F10
		public global::AcpUI.AcpChildToolbarCollection ChildToolbars
		{
			get
			{
				short num = (short)1353968440;
				short num2 = num;
				num = (short)232123192;
				switch (num2 == num)
				{
				}
				num = (short)135462912;
				short num3 = num;
				num = (short)2144075777;
				if (num != 0)
				{
				}
				num = (short)1372782592;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00022DC0 File Offset: 0x00020FC0
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00022E6C File Offset: 0x0002106C
		public override global::AcpCommonLib.IAcpRecordset MySecondaryRecordsetDataSource
		{
			get
			{
				short num = (short)490683870;
				short num2 = num;
				num = (short)1885748702;
				switch (num2 == num)
				{
				}
				num = (short)682557440;
				short num3 = num;
				num = (short)1374420992;
				if (num != 0)
				{
				}
				num = (short)884342785;
				if (num != 0)
				{
				}
				return base.MySecondaryRecordsetDataSource;
			}
			set
			{
				base.MySecondaryRecordsetDataSource = value;
				base.SyncDataSources();
				global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpChildRecNavToolbar> enumerator = this.ChildToolbars.GetEnumerator();
				short num;
				try
				{
					num = (short)661979140;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1512769954;
							short num3 = num;
							num = (short)248842658;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1385431040;
								if (num != 0)
								{
								}
								if (!enumerator.MoveNext())
								{
									num = (short)1243283458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.SyncDataSources();
								num = (short)450756609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							num = (short)1854013443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_115;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_54;
							}
							continue;
						}
						IL_77:
						num = (short)237109248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_54:
						goto IL_77;
					}
					IL_115:;
				}
				finally
				{
					num = (short)445251586;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)836239361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1A4;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_14B;
							}
							continue;
						}
						IL_14B:
						num = (short)1769340929;
						if (num != 0)
						{
						}
						if (enumerator == null)
						{
							break;
						}
						num = (short)469172224;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1A4:;
				}
				num = (short)1319567360;
				short num4 = num;
				this.a(global::AcpUI.UpdateToolbarEventType.ForcedUpdate);
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00023064 File Offset: 0x00021264
		protected override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1552708729;
			short num2 = num;
			num = (short)853767289;
			switch (num2 == num)
			{
			}
			num = (short)1221132288;
			short num3 = num;
			num = (short)1962934272;
			if (num != 0)
			{
			}
			num = (short)1524695041;
			if (num != 0)
			{
			}
			base.OnLoaded(sender, e);
			this.p.Visibility = global::System.Windows.Visibility.Collapsed;
			this.i.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0002312C File Offset: 0x0002132C
		protected override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)529829099;
			short num2 = num;
			num = (short)683052267;
			switch (num2 == num)
			{
			}
			num = (short)1752563712;
			short num3 = num;
			num = (short)652279809;
			if (num != 0)
			{
			}
			num = (short)1425408000;
			if (num != 0)
			{
			}
			base.OnUnloaded(sender, e);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000231DC File Offset: 0x000213DC
		protected override void OnDataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1614857334;
			short num2 = num;
			num = (short)930792566;
			switch (num2 == num)
			{
			}
			num = (short)295174144;
			short num3 = num;
			num = (short)270598145;
			if (num != 0)
			{
			}
			num = (short)435945472;
			if (num != 0)
			{
			}
			base.OnDataContextChanged(sender, e);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0002328C File Offset: 0x0002148C
		protected internal override void OnUpdate(object sender, global::AcpUI.ToolbarUpdateEventArgs e)
		{
			short num = (short)321585153;
			if (num != 0)
			{
			}
			num = (short)863895552;
			short num2 = num;
			base.a();
			global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpChildRecNavToolbar> enumerator = this.ChildToolbars.GetEnumerator();
			try
			{
				num = (short)35155478;
				short num3 = num;
				num = (short)686976534;
				int num4;
				global::AcpUI.AcpChildRecNavToolbar acpChildRecNavToolbar;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_13F:
					if (!enumerator.MoveNext())
					{
						num = (short)1695940609;
						num4 = (int)((global::System.IntPtr)num);
					}
					else
					{
						acpChildRecNavToolbar = enumerator.Current;
						num = (short)973799430;
						num4 = (int)((global::System.IntPtr)num);
					}
					break;
				default:
					num = (short)2011627520;
					if (num != 0)
					{
					}
					num = (short)1039073282;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						acpChildRecNavToolbar.a();
						num = (short)1518010372;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1882652677;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_F3;
						}
						continue;
					case 3:
						goto IL_13F;
					case 5:
						goto IL_196;
					case 6:
						if (acpChildRecNavToolbar != sender)
						{
							num = (short)356777984;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_12A:
					num = (short)563609603;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_F3:
					goto IL_12A;
				}
				IL_196:;
			}
			finally
			{
				num = (short)2037317634;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						enumerator.Dispose();
						num = (short)659161089;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1FD;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1C8;
						}
						continue;
					}
					IL_1C8:
					if (enumerator == null)
					{
						break;
					}
					num = (short)422838272;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1FD:;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000234B8 File Offset: 0x000216B8
		internal override void Update(global::AcpUI.UpdateToolbarEventType eventType)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_A0;
				case 1:
					goto IL_E9;
				case 2:
					if (eventType == global::AcpUI.UpdateToolbarEventType.Navigation)
					{
						num2 = (short)1517813760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_E9:
			num2 = (short)1372127233;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			base.Update(eventType);
			num2 = (short)1307724882;
			short num3 = num2;
			num2 = (short)858999890;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A0:
				num2 = (short)607191040;
				short num4 = num2;
				base.UpdateRecordOperationButtons();
				num2 = (short)187826177;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2074214400;
				if (num2 != 0)
				{
				}
				num2 = (short)1069481986;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000235D8 File Offset: 0x000217D8
		protected override void OnRecNavBtnFirstClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)949104605;
			short num2 = num;
			num = (short)123809757;
			switch (num2 == num)
			{
			}
			num = (short)1140326400;
			short num3 = num;
			num = (short)565837825;
			if (num != 0)
			{
			}
			num = (short)660471808;
			if (num != 0)
			{
			}
			base.OnRecNavBtnFirstClick(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.Navigation);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00023690 File Offset: 0x00021890
		protected override void OnRecNavBtnPreviousClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1018978126;
			short num2 = num;
			num = (short)499998542;
			switch (num2 == num)
			{
			}
			num = (short)1214382080;
			short num3 = num;
			num = (short)1087569921;
			if (num != 0)
			{
			}
			num = (short)1635516416;
			if (num != 0)
			{
			}
			base.OnRecNavBtnPreviousClick(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.Navigation);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00023748 File Offset: 0x00021948
		protected override void OnRecNavBtnNextClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2049580623;
			short num2 = num;
			num = (short)4529743;
			switch (num2 == num)
			{
			}
			num = (short)1962147840;
			short num3 = num;
			num = (short)2025979905;
			if (num != 0)
			{
			}
			num = (short)1058340864;
			if (num != 0)
			{
			}
			base.OnRecNavBtnNextClick(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.Navigation);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00023800 File Offset: 0x00021A00
		protected override void OnRecNavBtnLastClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)56508262;
			short num2 = num;
			num = (short)1647525734;
			switch (num2 == num)
			{
			}
			num = (short)411369472;
			short num3 = num;
			num = (short)480313344;
			if (num != 0)
			{
			}
			num = (short)2049441793;
			if (num != 0)
			{
			}
			base.OnRecNavBtnLastClick(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.Navigation);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000238B8 File Offset: 0x00021AB8
		protected override void OnRecNavBtnGoToClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)203896990;
			short num2 = num;
			num = (short)725825694;
			switch (num2 == num)
			{
			}
			num = (short)619773952;
			short num3 = num;
			num = (short)807010304;
			if (num != 0)
			{
			}
			num = (short)1292566529;
			if (num != 0)
			{
			}
			base.OnRecNavBtnGoToClick(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.Navigation);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00023970 File Offset: 0x00021B70
		protected override void OnRecNavBtnAddMultipleClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_F8;
				case 1:
					return;
				case 2:
					if (base.AddMultQty > 0)
					{
						num2 = (short)746455040;
						short num3 = num2;
						num2 = (short)1099825152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			base.OnRecNavBtnAddMultipleClick(sender, e);
			num2 = (short)2143437556;
			short num4 = num2;
			num2 = (short)874398452;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F8:
				this.a(global::AcpUI.UpdateToolbarEventType.RecordOperation);
				num2 = (short)491520001;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)24641537;
				if (num2 != 0)
				{
				}
				num2 = (short)1053949952;
				if (num2 != 0)
				{
				}
				num2 = (short)605487106;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00023A9C File Offset: 0x00021C9C
		protected override void OnRecNavBtnDeleteClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1481106882;
			short num2 = num;
			num = (short)1637410242;
			switch (num2 == num)
			{
			}
			num = (short)567541760;
			short num3 = num;
			num = (short)2057568257;
			if (num != 0)
			{
			}
			num = (short)90505216;
			if (num != 0)
			{
			}
			base.OnRecNavBtnDeleteClick(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.RecordOperation);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00023B54 File Offset: 0x00021D54
		protected override void OnRecordAdded(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1088092488;
			short num2 = num;
			num = (short)188348744;
			switch (num2 == num)
			{
			}
			num = (short)565182464;
			short num3 = num;
			num = (short)895811585;
			if (num != 0)
			{
			}
			num = (short)1986527232;
			if (num != 0)
			{
			}
			base.OnRecordAdded(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.RecordOperation);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00023C08 File Offset: 0x00021E08
		protected override void OnRecordDeleted(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1441473538;
			short num2 = num;
			num = (short)1994531842;
			switch (num2 == num)
			{
			}
			num = (short)1006764032;
			short num3 = num;
			num = (short)447348736;
			if (num != 0)
			{
			}
			num = (short)1012137985;
			if (num != 0)
			{
			}
			base.OnRecordDeleted(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.RecordOperation);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00023CC0 File Offset: 0x00021EC0
		protected override void OnCollectionViewCurrentChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)1475798833;
			short num2 = num;
			num = (short)318433073;
			switch (num2 == num)
			{
			}
			num = (short)1855389696;
			short num3 = num;
			num = (short)920256513;
			if (num != 0)
			{
			}
			num = (short)1705771008;
			if (num != 0)
			{
			}
			base.OnCollectionViewCurrentChanged(sender, e);
			this.a(global::AcpUI.UpdateToolbarEventType.ForcedUpdate);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00023D78 File Offset: 0x00021F78
		private void a(global::AcpUI.UpdateToolbarEventType A_0)
		{
			global::AcpUI.ToolbarUpdateEventArgs e = new global::AcpUI.ToolbarUpdateEventArgs(A_0);
			global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpChildRecNavToolbar> enumerator = this.ChildToolbars.GetEnumerator();
			short num;
			try
			{
				num = (short)1717764098;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::AcpUI.AcpChildRecNavToolbar acpChildRecNavToolbar;
						acpChildRecNavToolbar.OnUpdate(this, e);
						acpChildRecNavToolbar.SyncDataSources();
						num = (short)1592000516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)920387589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2009202689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpUI.AcpChildRecNavToolbar acpChildRecNavToolbar = enumerator.Current;
						num = (short)1840644102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_10A;
					case 6:
					{
						global::AcpUI.AcpChildRecNavToolbar acpChildRecNavToolbar;
						if (acpChildRecNavToolbar.DataContext != null)
						{
							num = (short)1324023808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_92:
					num = (short)1480720387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55:
					goto IL_92;
				}
				IL_10A:;
			}
			finally
			{
				num = (short)259784706;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1506213889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1BF;
					case 2:
						goto IL_123;
					}
					goto IL_13F;
					IL_123:
					switch (0)
					{
					case 0:
					{
						IL_13F:
						num = (short)1416019843;
						short num3 = num;
						num = (short)1359396739;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_123;
						default:
							num = (short)289079296;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_1C1;
							}
							num = (short)1848311808;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
				IL_1BF:
				IL_1C1:;
			}
			num = (short)594542593;
			if (num != 0)
			{
			}
			num = (short)533856256;
			short num4 = num;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00023FAC File Offset: 0x000221AC
		protected override void Dispose(bool disposing)
		{
			short num;
			try
			{
				num = (short)1277984746;
				short num2 = num;
				num = (short)1012039658;
				switch (num2 == num)
				{
				}
				num = (short)1759182848;
				if (num != 0)
				{
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
			num = (short)1857814529;
			if (num != 0)
			{
			}
			num = (short)1157890048;
			short num3 = num;
		}

		// Token: 0x04000178 RID: 376
		private new global::AcpUI.AcpChildToolbarCollection a;
	}
}
