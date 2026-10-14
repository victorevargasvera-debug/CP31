using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000008 RID: 8
	public class AcpChildRecNavToolbar : global::AcpUI.AcpRecNavToolbar
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000056FC File Offset: 0x000038FC
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)572507256;
				short num2 = num;
				num = (short)933610616;
				switch (num2 == num)
				{
				}
				num = (short)1734410240;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)334102529;
			if (num != 0)
			{
			}
			num = (short)2003304448;
			short num3 = num;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000057C4 File Offset: 0x000039C4
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005874 File Offset: 0x00003A74
		public global::AcpUI.AcpParentRecNavToolbar ParentToolbar
		{
			get
			{
				short num = (short)803901821;
				short num2 = num;
				num = (short)1203409277;
				switch (num2 == num)
				{
				}
				num = (short)1062993921;
				if (num != 0)
				{
				}
				num = (short)692912128;
				short num3 = num;
				num = (short)1234567168;
				if (num != 0)
				{
				}
				return this.a;
			}
			internal set
			{
				short num = (short)1030094849;
				if (num != 0)
				{
				}
				num = (short)987280749;
				short num2 = num;
				num = (short)1979889005;
				switch (num2 == num)
				{
				}
				num = (short)1240793088;
				short num3 = num;
				num = (short)1435041792;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005924 File Offset: 0x00003B24
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000059D4 File Offset: 0x00003BD4
		public override global::AcpCommonLib.IAcpRecordset MySecondaryRecordsetDataSource
		{
			get
			{
				short num = (short)1352709399;
				short num2 = num;
				num = (short)389657879;
				switch (num2 == num)
				{
				}
				num = (short)2022506497;
				if (num != 0)
				{
				}
				num = (short)1226440704;
				short num3 = num;
				num = (short)708378624;
				if (num != 0)
				{
				}
				return base.MySecondaryRecordsetDataSource;
			}
			set
			{
				short num = (short)717280770;
				short num2 = num;
				num = (short)841471490;
				switch (num2 == num)
				{
				}
				num = (short)1539964928;
				if (num != 0)
				{
				}
				num = (short)497156096;
				short num3 = num;
				num = (short)959774721;
				if (num != 0)
				{
				}
				base.MySecondaryRecordsetDataSource = value;
				base.SyncDataSources();
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005A88 File Offset: 0x00003C88
		protected override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)499495140;
			short num2 = num;
			num = (short)1901375716;
			switch (num2 == num)
			{
			}
			num = (short)10485760;
			if (num != 0)
			{
			}
			num = (short)730464256;
			short num3 = num;
			num = (short)65404929;
			if (num != 0)
			{
			}
			base.OnLoaded(sender, e);
			this.i.Visibility = global::System.Windows.Visibility.Collapsed;
			this.p.Visibility = global::System.Windows.Visibility.Visible;
			this.t.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005B60 File Offset: 0x00003D60
		protected override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1112249212;
			short num2 = num;
			num = (short)111645564;
			switch (num2 == num)
			{
			}
			num = (short)189792256;
			if (num != 0)
			{
			}
			num = (short)1810497536;
			short num3 = num;
			num = (short)1399586817;
			if (num != 0)
			{
			}
			base.OnUnloaded(sender, e);
			this.a = null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005C18 File Offset: 0x00003E18
		protected override void OnDataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1921232228;
			short num2 = num;
			num = (short)440839524;
			switch (num2 == num)
			{
			}
			num = (short)1599143937;
			if (num != 0)
			{
			}
			num = (short)1792540672;
			short num3 = num;
			num = (short)1171521536;
			if (num != 0)
			{
			}
			base.OnDataContextChanged(sender, e);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005CCC File Offset: 0x00003ECC
		protected internal override void OnUpdate(object sender, global::AcpUI.ToolbarUpdateEventArgs e)
		{
			short num = (short)1367605255;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14C;
				case 1:
					return;
				case 2:
					return;
				case 3:
					if (base.MyDataPresenter != null)
					{
						num = (short)1957822468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)68681729;
					if (num != 0)
					{
					}
					num = (short)358154249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					global::System.Windows.Data.CollectionView collectionViewForDataSource;
					if (collectionViewForDataSource.CurrentPosition == -1)
					{
						num = (short)2101673990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14C;
				}
				case 6:
				{
					global::System.Windows.Data.CollectionView collectionViewForDataSource;
					collectionViewForDataSource.MoveCurrentToFirst();
					num = (short)1250164736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 8:
				{
					num = (short)1238892544;
					short num3 = num;
					base.MyDataPresenter.SelectedItems.Records.Clear();
					global::System.Windows.Data.CollectionView collectionViewForDataSource = base.GetCollectionViewForDataSource();
					num = (short)404881413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_11F;
				}
				IL_4E:
				num = (short)1373677937;
				short num4 = num;
				num = (short)1317775729;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_11F:
					if (base.MyDataPresenter.Records.Count > 0)
					{
						num = (short)788660232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				default:
					num = (short)1529348096;
					if (num != 0)
					{
					}
					if (sender != this.ParentToolbar)
					{
						num = (short)361234434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2134704131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_14C:
				base.a();
				num = (short)1397096449;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005F10 File Offset: 0x00004110
		protected override void OnRecsetCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
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
					goto IL_121;
				case 1:
					this.ParentToolbar.OnUpdate(this, new global::AcpUI.ToolbarUpdateEventArgs(global::AcpUI.UpdateToolbarEventType.RecordOperation));
					num2 = (short)1823866880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1193672704;
					short num3 = num2;
					if (this.ParentToolbar != null)
					{
						num2 = (short)1715273729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_1C;
			}
			IL_121:
			return;
			IL_1C:
			num2 = (short)1535466694;
			short num4 = num2;
			num2 = (short)1271618758;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)84672513;
				if (num2 != 0)
				{
				}
				num2 = (short)1173815296;
				if (num2 != 0)
				{
				}
				base.OnRecsetCollectionChanged(sender, e);
				num2 = (short)631046146;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006040 File Offset: 0x00004240
		protected override void OnRecordsetPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.ParentToolbar != null)
					{
						num2 = (short)901120000;
						short num3 = num2;
						num2 = (short)89128961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					this.ParentToolbar.OnUpdate(this, new global::AcpUI.ToolbarUpdateEventArgs(global::AcpUI.UpdateToolbarEventType.RecordOperation));
					num2 = (short)1059454977;
					if (num2 != 0)
					{
					}
					num2 = (short)57504126;
					short num4 = num2;
					num2 = (short)535982462;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1125711872;
						if (num2 != 0)
						{
						}
						num2 = (short)2029387779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (e.PropertyName == global::AcpUI.Common.Utility.c("쮩슫풯횱", a_))
					{
						num2 = (short)820379652;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					num2 = (short)58785792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2D;
			}
			return;
			IL_2D:
			base.OnRecordsetPropertyChanged(sender, e);
			num2 = (short)36700162;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000061D0 File Offset: 0x000043D0
		protected override void Dispose(bool disposing)
		{
			short num;
			try
			{
				num = (short)1663458730;
				short num2 = num;
				num = (short)1703763370;
				switch (num2 == num)
				{
				}
				num = (short)835977216;
				if (num != 0)
				{
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
			num = (short)1850343425;
			if (num != 0)
			{
			}
			num = (short)383385600;
			short num3 = num;
		}

		// Token: 0x04000023 RID: 35
		private new global::AcpUI.AcpParentRecNavToolbar a;
	}
}
