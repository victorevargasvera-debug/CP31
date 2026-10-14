using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUI.Common;
using AcpUILib;
using AcpUtility;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;

namespace AcpUI
{
	// Token: 0x0200004C RID: 76
	public class AcpXamDataPresenter : global::Infragistics.Windows.DataPresenter.XamDataPresenter, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUICommon
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00045D54 File Offset: 0x00043F54
		public static global::System.Windows.Input.RoutedCommand CopyCommand
		{
			get
			{
				short num = (short)323813376;
				short num2 = num;
				num = (short)814219265;
				if (num != 0)
				{
				}
				num = (short)558689891;
				short num3 = num;
				num = (short)756477539;
				switch (num3 == num)
				{
				}
				num = (short)199819264;
				if (num != 0)
				{
				}
				return global::AcpUI.AcpXamDataPresenter.c;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00045E00 File Offset: 0x00044000
		public static global::System.Windows.Input.RoutedCommand PasteCommand
		{
			get
			{
				short num = (short)816119808;
				short num2 = num;
				num = (short)1880512881;
				short num3 = num;
				num = (short)630086001;
				switch (num3 == num)
				{
				}
				num = (short)765001729;
				if (num != 0)
				{
				}
				num = (short)1187708928;
				if (num != 0)
				{
				}
				return global::AcpUI.AcpXamDataPresenter.d;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00045EAC File Offset: 0x000440AC
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00045F68 File Offset: 0x00044168
		public bool IsAcpValid
		{
			get
			{
				short num = (short)106037248;
				short num2 = num;
				num = (short)267097464;
				short num3 = num;
				num = (short)478254456;
				switch (num3 == num)
				{
				}
				num = (short)1913782273;
				if (num != 0)
				{
				}
				num = (short)114819072;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpXamDataPresenter.IsAcpValidProperty);
			}
			set
			{
				short num = (short)2097283072;
				short num2 = num;
				num = (short)400676036;
				short num3 = num;
				num = (short)521393348;
				switch (num3 == num)
				{
				}
				num = (short)346161152;
				if (num != 0)
				{
				}
				num = (short)437387265;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00046028 File Offset: 0x00044228
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x000460E0 File Offset: 0x000442E0
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)385155072;
				short num2 = num;
				num = (short)298313441;
				short num3 = num;
				num = (short)772728545;
				switch (num3 == num)
				{
				}
				num = (short)61734912;
				if (num != 0)
				{
				}
				num = (short)1038024705;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpXamDataPresenter.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)640417792;
				short num2 = num;
				num = (short)1472067117;
				short num3 = num;
				num = (short)2146629165;
				switch (num3 == num)
				{
				}
				num = (short)1778253825;
				if (num != 0)
				{
				}
				num = (short)1220214784;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0004619C File Offset: 0x0004439C
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00046258 File Offset: 0x00044458
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)135790592;
				short num2 = num;
				num = (short)1451134676;
				short num3 = num;
				num = (short)312184532;
				switch (num3 == num)
				{
				}
				num = (short)1965096961;
				if (num != 0)
				{
				}
				num = (short)2123563008;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpXamDataPresenter.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1153302528;
				short num2 = num;
				num = (short)672399361;
				if (num != 0)
				{
				}
				num = (short)754098233;
				short num3 = num;
				num = (short)1956683833;
				switch (num3 == num)
				{
				}
				num = (short)464322560;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00046314 File Offset: 0x00044514
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x000463D0 File Offset: 0x000445D0
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)469172224;
				short num2 = num;
				num = (short)1302855681;
				if (num != 0)
				{
				}
				num = (short)526478320;
				short num3 = num;
				num = (short)2015718384;
				switch (num3 == num)
				{
				}
				num = (short)1719271424;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpXamDataPresenter.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1771700224;
				short num2 = num;
				num = (short)622543663;
				short num3 = num;
				num = (short)1828209455;
				switch (num3 == num)
				{
				}
				num = (short)860946433;
				if (num != 0)
				{
				}
				num = (short)1202323456;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0004648C File Offset: 0x0004468C
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00046548 File Offset: 0x00044748
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)467664896;
				short num2 = num;
				num = (short)2081644730;
				short num3 = num;
				num = (short)1891393722;
				switch (num3 == num)
				{
				}
				num = (short)2089353217;
				if (num != 0)
				{
				}
				num = (short)297730048;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpXamDataPresenter.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1769537536;
				short num2 = num;
				num = (short)2042219313;
				short num3 = num;
				num = (short)1766574897;
				switch (num3 == num)
				{
				}
				num = (short)1850081281;
				if (num != 0)
				{
				}
				num = (short)309067776;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00046600 File Offset: 0x00044800
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x000466B8 File Offset: 0x000448B8
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)238419968;
				short num2 = num;
				num = (short)1985282049;
				if (num != 0)
				{
				}
				num = (short)35334718;
				short num3 = num;
				num = (short)27601470;
				switch (num3 == num)
				{
				}
				num = (short)377028608;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpXamDataPresenter.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)863174656;
				short num2 = num;
				num = (short)827712875;
				short num3 = num;
				num = (short)340977003;
				switch (num3 == num)
				{
				}
				num = (short)1809973249;
				if (num != 0)
				{
				}
				num = (short)1937571840;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00046770 File Offset: 0x00044970
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00046828 File Offset: 0x00044A28
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)44040192;
				short num2 = num;
				num = (short)30932993;
				if (num != 0)
				{
				}
				num = (short)1709395020;
				short num3 = num;
				num = (short)609438796;
				switch (num3 == num)
				{
				}
				num = (short)1625096192;
				if (num != 0)
				{
				}
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpXamDataPresenter.MyBLObjectProperty);
			}
			set
			{
				short num = (short)507183104;
				short num2 = num;
				num = (short)495614336;
				short num3 = num;
				num = (short)395868544;
				switch (num3 == num)
				{
				}
				num = (short)83820544;
				if (num != 0)
				{
				}
				num = (short)454819841;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000468E0 File Offset: 0x00044AE0
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x0004699C File Offset: 0x00044B9C
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)587137024;
				short num2 = num;
				num = (short)174950705;
				short num3 = num;
				num = (short)862357809;
				switch (num3 == num)
				{
				}
				num = (short)754909185;
				if (num != 0)
				{
				}
				num = (short)554893312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpXamDataPresenter.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)84017152;
				short num2 = num;
				num = (short)1425521426;
				short num3 = num;
				num = (short)460045074;
				switch (num3 == num)
				{
				}
				num = (short)1000538112;
				if (num != 0)
				{
				}
				num = (short)900268033;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00046A58 File Offset: 0x00044C58
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00046B14 File Offset: 0x00044D14
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)1632043008;
				short num2 = num;
				num = (short)1921903795;
				short num3 = num;
				num = (short)109178035;
				switch (num3 == num)
				{
				}
				num = (short)798490625;
				if (num != 0)
				{
				}
				num = (short)2077163520;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpXamDataPresenter.MyExpanderProperty);
			}
			set
			{
				short num = (short)1788018688;
				short num2 = num;
				num = (short)918552577;
				if (num != 0)
				{
				}
				num = (short)1101150554;
				short num3 = num;
				num = (short)1105803610;
				switch (num3 == num)
				{
				}
				num = (short)555679744;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00046BC8 File Offset: 0x00044DC8
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00046C80 File Offset: 0x00044E80
		public bool ShowDiffIcon
		{
			get
			{
				short num = (short)718929920;
				short num2 = num;
				num = (short)162004993;
				if (num != 0)
				{
				}
				num = (short)1521531059;
				short num3 = num;
				num = (short)1707980979;
				switch (num3 == num)
				{
				}
				num = (short)115081216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpXamDataPresenter.ShowDiffIconProperty);
			}
			set
			{
				short num = (short)781123584;
				short num2 = num;
				num = (short)1329790977;
				if (num != 0)
				{
				}
				num = (short)1070626418;
				short num3 = num;
				num = (short)1367045746;
				switch (num3 == num)
				{
				}
				num = (short)869662720;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.ShowDiffIconProperty, value);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00046D3C File Offset: 0x00044F3C
		public AcpXamDataPresenter()
		{
			int a_ = 5;
			this.e = global::AcpUI.Common.Utility.c("銚", a_);
			this.f = global::AcpUI.Common.Utility.c("隚鞜", a_);
			base..ctor();
			base.FieldSettings.CellClickAction = global::Infragistics.Windows.DataPresenter.CellClickAction.SelectCell;
			this.b();
			if (this.q == null)
			{
				this.q = new global::AcpUI.XamDataGridDragDropBehavior();
				this.q.Attach(this);
			}
			base.Background = global::System.Windows.Media.Brushes.Transparent;
			base.GroupByAreaLocation = global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.None;
			if (!(bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
			{
				base.InitializeRecord += this.OnInitializeRecord;
				this.k.Click += this.mItemFillUp_Click;
				this.l.Click += this.mItemFillDown_Click;
				this.m.Click += this.OnContextMenuItemCopyClick;
				this.n.Click += this.OnContextMenuItemPasteClick;
				this.o.Click += this.OnContextMenuItemGoto;
				this.p.Click += this.OnContextMenuItemDelete;
				base.Loaded += this.OnLoaded;
				base.Unloaded += this.OnUnloaded;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00046EBC File Offset: 0x000450BC
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00046F78 File Offset: 0x00045178
		public string Header
		{
			get
			{
				short num = (short)693043200;
				short num2 = num;
				num = (short)285605889;
				if (num != 0)
				{
				}
				num = (short)1795531216;
				short num3 = num;
				num = (short)1331405264;
				switch (num3 == num)
				{
				}
				num = (short)866385920;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::AcpUI.AcpXamDataPresenter.HeaderProperty);
			}
			set
			{
				short num = (short)364838912;
				short num2 = num;
				num = (short)244025551;
				short num3 = num;
				num = (short)1378584783;
				switch (num3 == num)
				{
				}
				num = (short)657260544;
				if (num != 0)
				{
				}
				num = (short)1274216449;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpXamDataPresenter.HeaderProperty, value);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00047030 File Offset: 0x00045230
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x000470E0 File Offset: 0x000452E0
		protected new string ClipboardCellSeparator
		{
			get
			{
				short num = (short)541261824;
				short num2 = num;
				num = (short)710877713;
				short num3 = num;
				num = (short)1961435665;
				switch (num3 == num)
				{
				}
				num = (short)1270022144;
				if (num != 0)
				{
				}
				num = (short)2142961665;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)606994432;
				short num2 = num;
				num = (short)1987510273;
				if (num != 0)
				{
				}
				num = (short)492674696;
				short num3 = num;
				num = (short)1947442824;
				switch (num3 == num)
				{
				}
				num = (short)1734606848;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00047190 File Offset: 0x00045390
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00047244 File Offset: 0x00045444
		protected new string ClipboardRecordSeparator
		{
			get
			{
				short num = (short)1594818560;
				short num2 = num;
				num = (short)1469830272;
				short num3 = num;
				num = (short)849335424;
				switch (num3 == num)
				{
				}
				num = (short)1172373504;
				if (num != 0)
				{
				}
				num = (short)307101697;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1692991488;
				short num2 = num;
				num = (short)1771990674;
				short num3 = num;
				num = (short)1213099666;
				switch (num3 == num)
				{
				}
				num = (short)1512964097;
				if (num != 0)
				{
				}
				num = (short)684457984;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000472F4 File Offset: 0x000454F4
		protected virtual void OnContextMenuItemDelete(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)157155328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				global::AcpBusinessLayer.Recordset recordset;
				for (;;)
				{
					IL_29:
					global::System.Windows.Data.CollectionView collectionView;
					switch (num2)
					{
					case 0:
						num = (short)1691615233;
						if (num != 0)
						{
						}
						base.Records[collectionView.CurrentPosition].IsActive = true;
						base.Records[collectionView.CurrentPosition].IsSelected = true;
						num = (short)169345028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (base.SelectedItems.Records.Count == 1)
						{
							num = (short)207749127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode[] array = new global::AcpBusinessLayer.FeatureNode[base.SelectedItems.Records.Count];
						global::System.Collections.Generic.SortedList<int, global::AcpBusinessLayer.FeatureNode> sortedList = new global::System.Collections.Generic.SortedList<int, global::AcpBusinessLayer.FeatureNode>(array.Length);
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = base.SelectedItems.Records.GetEnumerator();
						num = (short)200605707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::AcpBusinessLayer.FeatureNode[] array;
						recordset.RemoveMultipleRecords(array);
						num = (short)1791361034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_249;
					case 4:
						return;
					case 5:
						if (collectionView.Count > 0)
						{
							num = (short)554958848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						global::System.Collections.Generic.SortedList<int, global::AcpBusinessLayer.FeatureNode> sortedList;
						int num3;
						if (num3 >= sortedList.Values.Count)
						{
							num = (short)1029636098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode[] array;
						array[num3] = sortedList.Values[sortedList.Values.Count - num3 - 1];
						num3++;
						num = (short)1950285827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Infragistics.Windows.DataPresenter.Record record = base.SelectedItems.Records[0];
						recordset.RemoveRecordAt(record.Index);
						num = (short)1523580936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_16E;
					case 9:
						goto IL_249;
					case 10:
						goto IL_16E;
					case 11:
					{
						try
						{
							num = (short)2101346304;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_31A;
									}
									continue;
								case 1:
									num = (short)781516803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_3B0;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1948712961;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.Record record2 = enumerator.Current;
									global::System.Collections.Generic.SortedList<int, global::AcpBusinessLayer.FeatureNode> sortedList;
									sortedList.Add(record2.Index, (global::AcpBusinessLayer.FeatureNode)recordset[record2.Index]);
									num = (short)1984167938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_31C:
								num = (short)336527364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_31A:
								goto IL_31C;
							}
							IL_3B0:;
						}
						finally
						{
							num = (short)380567553;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_471;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3E7;
									}
									continue;
								case 2:
								{
									num = (short)587216829;
									short num4 = num;
									num = (short)210843581;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_471;
									default:
										num = (short)998899712;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)340131840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_3E7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)444530690;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_471:;
						}
						int num3 = 0;
						num = (short)972816393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_60;
					IL_16E:
					collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(recordset);
					num = (short)1576075264;
					short num5 = num;
					num = (short)81526789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_249:
					num = (short)1714683910;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_60:
				recordset = (global::AcpBusinessLayer.Recordset)base.DataSource;
				num = (short)814022657;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000477A8 File Offset: 0x000459A8
		protected virtual void OnContextMenuItemGoto(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1822425090;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					global::AcpBusinessLayer.FeatureNode featureNode;
					if (featureNode != null)
					{
						num = (short)727449605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
				{
					global::AcpBusinessLayer.FeatureNode featureNode;
					global::AcpCommonLib.IAcpField keyField = featureNode.KeyField;
					global::AcpBusinessLayer.Recordset recordset;
					if (recordset.IsEmbeddedRecset && recordset.Contains(featureNode))
					{
						featureNode = (recordset.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode);
						recordset = (featureNode.Parent as global::AcpBusinessLayer.Recordset);
					}
					global::AcpCommonLib.FieldInfo a_ = new global::AcpCommonLib.FieldInfo(keyField);
					num = (short)1221001217;
					if (num != 0)
					{
					}
					num = (short)1564672007;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					global::AcpBusinessLayer.FeatureNode featureNode = ((global::AcpBusinessLayer.AcpRecRefField)this.h).ReferencedNode;
					num = (short)1995177985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					for (;;)
					{
						num = (short)1703477248;
						short num3 = num;
						global::AcpBusinessLayer.FeatureNode featureNode;
						global::AcpBusinessLayer.Recordset recordset = featureNode.Parent as global::AcpBusinessLayer.Recordset;
						num = (short)1521534491;
						short num4 = num;
						num = (short)1390200347;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_11D;
						}
					}
					IL_11D:
					num = (short)1606483968;
					if (num != 0)
					{
					}
					num = (short)335151107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					global::AcpCommonLib.FieldInfo a_;
					global::AcpUI.Common.Utility.a(sender, a_);
					num = (short)1212612608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					global::AcpBusinessLayer.FeatureNode featureNode;
					global::AcpBusinessLayer.Recordset recordset;
					if (recordset.Contains(featureNode))
					{
						num = (short)1966473222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_45:
				if (!(this.h is global::AcpBusinessLayer.AcpRecRefField))
				{
					break;
				}
				num = (short)1274871812;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000479C4 File Offset: 0x00045BC4
		protected virtual void OnContextMenuItemCopyClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)342777427;
			short num2 = num;
			num = (short)2015714899;
			switch (num2 == num)
			{
			}
			num = (short)1628635136;
			short num3 = num;
			num = (short)328204289;
			if (num != 0)
			{
			}
			num = (short)1611595776;
			if (num != 0)
			{
			}
			this.DoClipboardCopy();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00047A74 File Offset: 0x00045C74
		protected virtual void OnContextMenuItemPasteClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)308196353;
			short num2 = num;
			num = (short)1979560961;
			switch (num2 == num)
			{
			}
			num = (short)269025280;
			short num3 = num;
			num = (short)564264960;
			if (num != 0)
			{
			}
			num = (short)900726785;
			if (num != 0)
			{
			}
			this.DoClipboardPaste();
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00047B24 File Offset: 0x00045D24
		private void OnExecuteCopyCommand(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)254363084;
			short num2 = num;
			num = (short)1611023820;
			switch (num2 == num)
			{
			}
			num = (short)322830336;
			short num3 = num;
			num = (short)2103050241;
			if (num != 0)
			{
			}
			num = (short)1404764160;
			if (num != 0)
			{
			}
			this.DoClipboardCopy();
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00047BD4 File Offset: 0x00045DD4
		private void CanExecuteCopyCommand(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1423833214;
			short num2 = num;
			num = (short)1202190462;
			switch (num2 == num)
			{
			}
			num = (short)1785004032;
			short num3 = num;
			num = (short)649723905;
			if (num != 0)
			{
			}
			num = (short)1335558144;
			if (num != 0)
			{
			}
			A_1.CanExecute = this.CanEnableClipboardCopy;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00047C88 File Offset: 0x00045E88
		private void OnExecutePasteCommand(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)422735894;
			short num2 = num;
			num = (short)1894674454;
			switch (num2 == num)
			{
			}
			num = (short)1829961728;
			short num3 = num;
			num = (short)756809729;
			if (num != 0)
			{
			}
			num = (short)578879488;
			if (num != 0)
			{
			}
			this.DoClipboardPaste();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00047D38 File Offset: 0x00045F38
		private void CanExecutePasteCommand(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)842203137;
			if (num != 0)
			{
			}
			num = (short)69437244;
			short num2 = num;
			num = (short)1395820348;
			switch (num2 == num)
			{
			default:
			{
				num = (short)417529856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1167458304;
			if (num != 0)
			{
			}
			A_1.CanExecute = this.CanEnableClipboardPaste;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00047DEC File Offset: 0x00045FEC
		private void a(global::AcpCommonLib.IAcpField A_0, string A_1, global::AcpCommonLib.UndoRedo.ContainerTask A_2)
		{
			int a_ = 2;
			short num = (short)1860698112;
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
				global::System.Reflection.PropertyInfo propertyInfo;
				global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
				object obj;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_629;
					case 1:
					{
						global::System.Type type;
						if (type != null)
						{
							num = (short)823197715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_391;
					}
					case 2:
					{
						global::System.Type type2 = typeof(global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<>);
						global::System.Type type3;
						global::System.Type type = this.b(type3);
						propertyInfo = type3.GetProperty(global::AcpUI.Common.Utility.c("춗펙쪛ﾝ첟힡솣", a_));
						num = (short)1748762624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (undoableTask == null)
						{
							num = (short)2087321607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2.AddTask(undoableTask);
						object value = propertyInfo.GetValue(A_0, null);
						num = (short)1770258450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						if (A_0 is global::AcpBusinessLayer.AcpCustomRangeField)
						{
							num = (short)799277068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Type type2 = null;
						global::System.Type type = null;
						global::System.Type type3 = A_0.GetType();
						num = (short)393609249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_391;
					case 6:
						undoableTask = ((global::AcpBusinessLayer.AcpFrequencyField)A_0).CopyUIValue(obj);
						num = (short)628490249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_3C7;
					case 8:
						goto IL_391;
					case 9:
					{
						num = (short)816038196;
						short num3 = num;
						num = (short)2108145972;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_709;
						default:
							num = (short)444923904;
							if (num != 0)
							{
							}
							goto IL_391;
						}
						break;
					}
					case 10:
						goto IL_709;
					case 11:
						goto IL_391;
					case 12:
					{
						global::AcpBusinessLayer.AcpCustomRangeField acpCustomRangeField = (global::AcpBusinessLayer.AcpCustomRangeField)A_0;
						propertyInfo = acpCustomRangeField.GetType().GetProperty(global::AcpUI.Common.Utility.c("춗펙쪛ﾝ첟힡솣", a_));
						num = (short)1938751511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::System.Type type3;
						if (this.a(typeof(global::AcpBusinessLayer.AcpField<>), type3))
						{
							num = (short)1425080334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_629;
					}
					case 14:
					{
						global::System.Type type2 = typeof(global::AcpBusinessLayer.UndoRedo.ModifyDataTask<>);
						global::System.Type type3;
						global::System.Type type = this.a(type3);
						propertyInfo = type3.GetProperty(global::AcpUI.Common.Utility.c("캗ﮙ얟", a_));
						num = (short)658309135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)730791937;
						if (num != 0)
						{
						}
						goto IL_629;
					case 16:
					{
						global::System.Type type3;
						if (this.a(typeof(global::AcpBusinessLayer.AcpFieldX<, >), type3))
						{
							num = (short)1557987357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						undoableTask = A_0.CopyValue(obj);
						num = (short)870055944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (A_0 is global::AcpBusinessLayer.AcpRecRefField)
						{
							num = (short)1999372315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)489685020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						object value;
						if (!this.a(value, obj))
						{
							num = (short)176685078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 19:
					{
						global::System.Type type;
						global::System.Type type2;
						global::System.Type type4 = type2.MakeGenericType(new global::System.Type[]
						{
							type
						});
						obj = global::System.Convert.ChangeType(A_1, type);
						num = (short)2147090448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						if (A_0 is global::AcpBusinessLayer.AcpFrequencyField)
						{
							num = (short)1465581574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Type type4;
						undoableTask = (global::AcpCommonLib.UndoRedo.UndoableTask)global::System.Activator.CreateInstance(type4, new object[]
						{
							A_0,
							obj
						});
						num = (short)445579274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						obj = A_1;
						num = (short)1887043608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_342;
					case 23:
					{
						int num4;
						if (int.TryParse(A_1, out num4))
						{
							num = (short)1168113694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpCustomRangeField acpCustomRangeField;
						obj = acpCustomRangeField.GetSpecialValue(A_1);
						num = (short)1517158426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_5A3;
					case 25:
						goto IL_391;
					case 26:
						goto IL_4B5;
					case 27:
					{
						object obj2 = (global::AcpBusinessLayer.AcpRecRefField)A_0;
						obj = A_1;
						undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((global::AcpBusinessLayer.AcpRecRefField)A_0, A_1);
						propertyInfo = obj2.GetType().GetProperty(global::AcpUI.Common.Utility.c("춗펙쪛ﾝ첟힡솣", a_));
						num = (short)2014838789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						if (A_0 is global::AcpBusinessLayer.AcpSparseLOVField)
						{
							num = (short)1621032992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_472;
					case 29:
						num = (short)523829268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						try
						{
							global::AcpBusinessLayer.AcpCustomRangeField acpCustomRangeField;
							int value2 = (int)acpCustomRangeField.Converter.ConvertBack(A_1, null, acpCustomRangeField, null);
							obj = acpCustomRangeField.GetSpecialValue(value2);
							goto IL_4B5;
						}
						catch
						{
							goto IL_4B5;
						}
						goto IL_472;
					case 31:
						if (obj == null)
						{
							num = (short)887422997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A3;
					case 32:
					{
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField = (global::AcpBusinessLayer.AcpSparseLOVField)A_0;
						obj = A_1;
						int newValue = (int)acpSparseLOVField.Converter.ConvertBack(A_1, null, acpSparseLOVField.Parent, null);
						undoableTask = acpSparseLOVField.GetModifyDataTask(newValue);
						propertyInfo = acpSparseLOVField.GetType().GetProperty(global::AcpUI.Common.Utility.c("춗펙쪛ﾝ첟힡솣", a_));
						num = (short)576126987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						global::System.Type type3;
						if (this.a(typeof(global::AcpBusinessLayer.AcpFieldX<, >), type3))
						{
							num = (short)320733186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1671692301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_C0;
					IL_391:
					num = (short)816644099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_709:
					goto IL_391;
					IL_472:
					num = (short)750190596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B5:
					num = (short)492306432;
					short num5 = num;
					num = (short)1178927135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A3:
					undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<string>((global::AcpBusinessLayer.AcpCustomRangeField)A_0, A_1);
					num = (short)1419903001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_629:
					num = (short)108920833;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_342:
				throw new global::System.InvalidOperationException(global::AcpUI.Common.Utility.c("첗ﮙ劣얟횡蒣삥솧쾩삫쪭邯쒱햳\udab5춷\udfb9鲻ힽ뎿꫃꧅볇뿋믍ꃏꋑ믓ꓕ곗뿙룛", a_));
				IL_3C7:
				throw new global::System.InvalidOperationException(global::AcpUI.Common.Utility.c("첗ﮙ劣얟횡蒣삥솧쾩삫쪭邯욱춳욵\uddb7骹튻톽뒿곃Ʂꛇ껉ꃋꯍ듏", a_));
				IL_C0:
				undoableTask = null;
				obj = null;
				propertyInfo = null;
				num = (short)1801912337;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00048588 File Offset: 0x00046788
		private bool a(object A_0, object A_1)
		{
			short num = (short)149356544;
			int num2 = (int)((global::System.IntPtr)num);
			double num4;
			double num5;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
				{
					IL_5C:
					num = (short)1888288768;
					short num3 = num;
					num = (short)829489154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (double.TryParse(global::System.Convert.ToString(A_1), out num4))
					{
						num = (short)654835715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CE;
				case 3:
					goto IL_CC;
				}
				IL_35:
				if (double.TryParse(global::System.Convert.ToString(A_0), out num5))
				{
					num = (short)1077608449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CE:
				num = (short)1587675137;
				if (num != 0)
				{
				}
				num = (short)1377115157;
				short num6 = num;
				num = (short)189996053;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5C;
				default:
					goto IL_12A;
				}
			}
			IL_CC:
			return num5 == num4;
			IL_12A:
			num = (short)2099773440;
			if (num != 0)
			{
			}
			return object.Equals(A_0, A_1);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000486DC File Offset: 0x000468DC
		private global::System.Type b(global::System.Type A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Type type;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_18C;
				case 1:
					if (type.IsGenericType)
					{
						goto IL_91;
					}
					goto IL_4B;
				case 2:
					goto IL_147;
				case 3:
					if (!(type != typeof(object)))
					{
						num2 = (short)1371602944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)144834561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_147;
				case 5:
				{
					num2 = (short)1887806157;
					short num3 = num2;
					num2 = (short)1133421261;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						num2 = (short)29032449;
						if (num2 != 0)
						{
						}
						num2 = (short)511049728;
						if (num2 != 0)
						{
						}
						num2 = (short)1546911751;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_1D6;
				case 7:
					if (type.GetGenericTypeDefinition() == typeof(global::AcpBusinessLayer.AcpFieldX<, >))
					{
						num2 = (short)463667206;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4B;
				}
				goto IL_30;
				IL_4B:
				type = type.BaseType;
				num2 = (short)1518927876;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_91:
				num2 = (short)1083899904;
				short num4 = num2;
				num2 = (short)1354825733;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_147:
				num2 = (short)288948227;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_18C:
			return null;
			IL_1D6:
			return type.GetGenericArguments()[1];
			IL_30:
			type = A_0;
			num2 = (short)1177485314;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000488C8 File Offset: 0x00046AC8
		private global::System.Type a(global::System.Type A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Type type;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_167;
				case 1:
					if (type.IsGenericType)
					{
						goto IL_96;
					}
					goto IL_4C;
				case 2:
					goto IL_124;
				case 3:
					if (!(type != typeof(object)))
					{
						num2 = (short)25165824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)663617537;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_124;
				case 5:
				{
					num2 = (short)1176387173;
					short num3 = num2;
					num2 = (short)223493733;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num2 = (short)2140078080;
						if (num2 != 0)
						{
						}
						num2 = (short)2131755015;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_1B1;
				case 7:
					if (type.GetGenericTypeDefinition() == typeof(global::AcpBusinessLayer.AcpField<>))
					{
						num2 = (short)1889337350;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4C;
				}
				goto IL_30;
				IL_4C:
				type = type.BaseType;
				num2 = (short)1435566084;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_96:
				num2 = (short)1743519744;
				short num4 = num2;
				num2 = (short)415891461;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_124:
				num2 = (short)874905603;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_167:
			return null;
			IL_1B1:
			num2 = (short)1336016897;
			if (num2 != 0)
			{
			}
			return type.GetGenericArguments()[0];
			IL_30:
			type = A_0;
			num2 = (short)292814850;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00048AB4 File Offset: 0x00046CB4
		private bool a(global::System.Type A_0, global::System.Type A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::System.Type type;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return true;
				case 1:
					if (type == A_0)
					{
						goto IL_8E;
					}
					type = type.BaseType;
					num2 = (short)887619589;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_158;
				case 3:
					goto IL_70;
				case 4:
					type = type.GetGenericTypeDefinition();
					num2 = (short)566886403;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_158;
				case 6:
					num2 = (short)1733558273;
					if (num2 != 0)
					{
					}
					if (type.IsGenericType)
					{
						num2 = (short)322502660;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_70;
				case 7:
					goto IL_19B;
				case 8:
				{
					if (!(type != typeof(object)))
					{
						num2 = (short)779419655;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)50349157;
					short num3 = num2;
					num2 = (short)838878309;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8E;
					default:
						num2 = (short)75104256;
						if (num2 != 0)
						{
						}
						num2 = (short)215220230;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_34;
				IL_70:
				num2 = (short)1219493889;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_8E:
				num2 = (short)1647378432;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_158:
				num2 = (short)1805254664;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_19B:
			num2 = (short)488701952;
			short num4 = num2;
			return false;
			IL_34:
			type = A_1;
			num2 = (short)1181745154;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00048CAC File Offset: 0x00046EAC
		public bool CanDragDrop
		{
			get
			{
				int a_ = 9;
				short num = (short)945094656;
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
					bool result;
					for (;;)
					{
						IL_31:
						global::AcpBusinessLayer.Recordset recordset;
						global::AcpBusinessLayer.FeatureNode featureNode;
						switch (num2)
						{
						case 0:
							num = (short)563609611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)745013258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return false;
						case 3:
							return false;
						case 4:
							return false;
						case 5:
							try
							{
								num = (short)2141716483;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										string text;
										if (!(text == global::AcpUI.Common.Utility.c("\udb9e쒠펢쪤펦", a_)))
										{
											num = (short)2054881282;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_38A;
									}
									case 1:
										goto IL_3FF;
									case 2:
										result = true;
										num = (short)381353991;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_2B2;
										}
										continue;
									case 5:
										num = (short)1528037376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										string text;
										if (!(text == global::AcpUI.Common.Utility.c("펞삠솢톤좦욨잪", a_)))
										{
											num = (short)471793669;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_38A;
									}
									case 7:
										goto IL_385;
									case 8:
										num = (short)561840129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1961426952;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string text = enumerator.Current.DifferentiatedUserView.ToString();
										num = (short)1141833734;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_2B2;
									IL_38A:
									result = false;
									num = (short)582615044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_3A7:
									num = (short)865402889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2B2:
									goto IL_3A7;
								}
								IL_385:
								IL_3FF:
								goto IL_17F;
							}
							finally
							{
								num = (short)1838874624;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_437;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1344143362;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_46E;
									}
									goto IL_437;
									IL_43A:
									num = (short)917110785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_46E:
									num = (short)695845643;
									short num3 = num;
									num = (short)1670300427;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_43A;
									default:
										goto IL_4A4;
									}
									IL_437:
									if (enumerator != null)
									{
										goto IL_43A;
									}
									goto IL_46E;
								}
								IL_4A4:
								num = (short)495124480;
								if (num != 0)
								{
								}
							}
							goto IL_4BC;
						case 6:
							if (recordset.IsEmbeddedRecset)
							{
								num = (short)743505920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17F;
						case 7:
							goto IL_4BC;
						case 8:
							if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
							{
								num = (short)381485060;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							recordset = (global::AcpBusinessLayer.Recordset)base.DataSource;
							num = (short)942669830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = featureNode.AllFields.GetEnumerator();
							num = (short)1839136773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							if (!recordset.CanDelete)
							{
								num = (short)911474690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 11:
							if (recordset.ParentSection != null)
							{
								num = (short)99090439;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17F;
						case 12:
							if (recordset.RecordsetName == global::AcpUI.Common.Utility.c("쪞쾠쪢쎤캦첨쾪趬킰\udfb2\ud9b4鞶튺캼쮾", a_))
							{
								num = (short)1959657475;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1548353550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (featureNode != null)
							{
								num = (short)1645281289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17F;
						case 14:
							num = (short)1128398849;
							if (num != 0)
							{
							}
							if (!recordset.CanAdd)
							{
								num = (short)2080768001;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						goto IL_74;
						IL_17F:
						num = (short)278265868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4BC:
						featureNode = (recordset[0] as global::AcpBusinessLayer.FeatureNode);
						num = (short)1583742976;
						short num4 = num;
						num = (short)287637517;
						num2 = (int)((global::System.IntPtr)num);
					}
					return false;
					IL_74:
					result = true;
					num = (short)1678901256;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00049208 File Offset: 0x00047408
		protected virtual bool CanEnableDelete
		{
			get
			{
				short num = (short)2147024898;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (base.Records.Count - base.SelectedItems.Records.Count < recordset.Min)
						{
							num = (short)409993224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)114950151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return false;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 3:
						return false;
					case 4:
						goto IL_1FA;
					case 5:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (!recordset.CanBeEmpty)
						{
							num = (short)1402798089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82;
					}
					case 6:
						return false;
					case 7:
						if (base.SelectedItems.Records.Count <= 0)
						{
							num = (short)942407686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						return false;
					case 9:
						num = (short)526516236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (!recordset.CanDelete)
						{
							num = (short)308477952;
							short num3 = num;
							num = (short)163774465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1899233285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)416874509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (base.SelectedItems.Records.Count == recordset.Count)
						{
							num = (short)1321861123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82;
					}
					case 13:
					{
						num = (short)374779798;
						short num4 = num;
						num = (short)862039958;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
						{
							num = (short)1063714816;
							if (num != 0)
							{
							}
							if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
							{
								num = (short)526123012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)base.DataSource;
							num = (short)1060241418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_5D:
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)456196107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_82:
					num = (short)1468596224;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1FA:
				num = (short)1041760257;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000494F8 File Offset: 0x000476F8
		protected virtual bool CanEnableClipboardCopy
		{
			get
			{
				short num = (short)29949952;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					bool flag;
					bool flag2;
					for (;;)
					{
						IL_27:
						int num4;
						switch (num2)
						{
						case 0:
							goto IL_159;
						case 1:
							goto IL_101;
						case 2:
						{
							num = (short)888375772;
							short num3 = num;
							num = (short)292653532;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_171;
							default:
								num = (short)866516992;
								if (num != 0)
								{
								}
								num = (short)436142081;
								if (num != 0)
								{
								}
								flag = false;
								num = (short)1219690497;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_19C;
						case 4:
							if (flag2)
							{
								num = (short)2021654534;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25C;
						case 5:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.CopyDisabled, featureNode.Permissions))
							{
								num = (short)1171259394;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4++;
							num = (short)1401749511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							num = (short)781647872;
							short num5 = num;
							global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)base.DataSource;
							num4 = 0;
							num = (short)1877147648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_159;
						case 8:
							goto IL_171;
						}
						goto IL_52;
						IL_159:
						num = (short)666763272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_171:
						if (num4 >= base.SelectedItems.Records.Count)
						{
							num = (short)1984954371;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							global::AcpBusinessLayer.Recordset recordset;
							global::AcpBusinessLayer.FeatureNode featureNode = (global::AcpBusinessLayer.FeatureNode)recordset[base.SelectedItems.Records[num4].Index];
							num = (short)438501381;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_101:
					IL_19C:
					IL_25C:
					return this.IsDataRecordView && flag2 && flag;
					IL_52:
					flag2 = (base.SelectedItems.Records.Count > 0);
					flag = true;
					num = (short)1652555780;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0004976C File Offset: 0x0004796C
		protected virtual bool CanEnableClipboardPaste
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				int num;
				short num2;
				bool flag;
				bool flag2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)2027094021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (flag)
						{
							num2 = (short)57475080;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AC;
					case 2:
					{
						num2 = (short)954793984;
						short num3 = num2;
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.CopyDisabled, featureNode.Permissions))
						{
							num2 = (short)2139160586;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AC;
					}
					case 3:
						num2 = (short)1947795463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_19F;
					case 5:
						goto IL_99;
					case 6:
						goto IL_AC;
					case 7:
					{
						if (!global::System.Windows.Clipboard.ContainsText())
						{
							goto IL_187;
						}
						num2 = (short)1873370204;
						short num4 = num2;
						num2 = (short)1812618332;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_187;
						default:
							num2 = (short)1805320192;
							if (num2 != 0)
							{
							}
							num2 = (short)310837249;
							if (num2 != 0)
							{
							}
							num2 = (short)1664745472;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 8:
					{
						global::AcpBusinessLayer.FeatureNode featureNode = (global::AcpBusinessLayer.FeatureNode)((global::AcpBusinessLayer.Recordset)base.DataSource)[base.SelectedItems.Records[0].Index];
						num2 = (short)437387266;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 9:
						if (this.IsDataRecordView)
						{
							num2 = (short)934215683;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_187;
					case 10:
						flag2 = false;
						num2 = (short)1034354694;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3C;
					IL_AC:
					num2 = (short)910622729;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_187:
					num2 = (short)1086980100;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_99:
				bool flag3 = base.Records.Count > 0;
				goto IL_26F;
				IL_19F:
				flag3 = false;
				IL_26F:
				return flag3 && flag && flag2;
				IL_3C:
				flag = (base.SelectedItems.Records.Count == 1);
				flag2 = true;
				num2 = (short)19267585;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000499EC File Offset: 0x00047BEC
		private int b(global::System.Collections.Generic.List<string[]> A_0, int A_1)
		{
			int num;
			int count;
			short num2;
			for (;;)
			{
				num = global::AcpUI.CellPosition.b(base.ActiveCell);
				count = base.Records.Count;
				if (A_1 + num > count)
				{
					break;
				}
				num2 = (short)854720512;
				short num3 = num2;
				num2 = (short)2043293512;
				short num4 = num2;
				num2 = (short)784084808;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_81;
				}
			}
			return count - num;
			IL_81:
			num2 = (short)657063937;
			if (num2 != 0)
			{
			}
			num2 = (short)621215744;
			if (num2 != 0)
			{
			}
			return A_1;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00049ABC File Offset: 0x00047CBC
		private int a(global::System.Collections.Generic.List<string[]> A_0, int A_1)
		{
			int num;
			int totalColumnsGenerated;
			short num2;
			for (;;)
			{
				num = global::AcpUI.CellPosition.c(base.ActiveCell);
				totalColumnsGenerated = base.FieldLayouts[0].TotalColumnsGenerated;
				if (A_1 + num > totalColumnsGenerated)
				{
					break;
				}
				num2 = (short)361179249;
				short num3 = num2;
				num2 = (short)1881942129;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_AE;
				}
			}
			num2 = (short)1642987521;
			if (num2 != 0)
			{
			}
			num2 = (short)585498624;
			short num4 = num2;
			return totalColumnsGenerated - num;
			IL_AE:
			num2 = (short)1783037952;
			if (num2 != 0)
			{
			}
			return A_1;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00049B90 File Offset: 0x00047D90
		private global::System.Collections.Generic.List<bool?> f()
		{
			short num = (short)1857945600;
			switch (num)
			{
			default:
			{
				num = (short)409272321;
				if (num != 0)
				{
				}
				bool flag = false;
				global::System.Collections.Generic.List<bool?> list = null;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)base.Records).GetEnumerator();
				try
				{
					num = (short)539557893;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1726480384;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_10C;
										}
										continue;
									case 1:
									{
										global::Infragistics.Windows.DataPresenter.Cell cell;
										if (cell.Value != null)
										{
											num = (short)497156102;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										list.Add(new bool?(false));
										num = (short)627441676;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_326;
									case 6:
									{
										global::Infragistics.Windows.DataPresenter.Cell cell;
										global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(cell);
										num = (short)2087125003;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
										if (cellValuePresenter.Value is global::AcpCommonLib.IAcpField)
										{
											num = (short)1623457801;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2BB;
									}
									case 8:
									{
										global::Infragistics.Windows.DataPresenter.Cell cell;
										if (cell.Field.Visibility == global::System.Windows.Visibility.Visible)
										{
											num = (short)727973903;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										list.Add(null);
										num = (short)1942618115;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										list.Add(new bool?(true));
										flag = true;
										num = (short)327286786;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1655898126;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Infragistics.Windows.DataPresenter.Cell cell = enumerator2.Current;
										num = (short)940310536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
										if (cellValuePresenter != null)
										{
											num = (short)1813446669;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2BB;
									}
									case 13:
										num = (short)2014248967;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
										num = (short)1071120388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 15:
										num = (short)80347137;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_179:
									num = (short)822083594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_10C:
									goto IL_179;
									IL_2BB:
									list.Add(new bool?(false));
									num = (short)1319305221;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_326:
								goto IL_486;
							}
							finally
							{
								num = (short)440664065;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator2;
									switch (num2)
									{
									case 0:
										goto IL_398;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_35E;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)497680384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_35E;
									IL_362:
									num = (short)1350369282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_398:
									num = (short)630370201;
									short num3 = num;
									num = (short)241217433;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_362;
									default:
										goto IL_3CE;
									}
									IL_35E:
									if (enumerator2 != null)
									{
										goto IL_362;
									}
									goto IL_398;
								}
								IL_3CE:
								num = (short)213778432;
								if (num != 0)
								{
								}
							}
							break;
							IL_486:
							num = (short)1307770883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_4D8;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)354680838;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.CellCollection cells = ((global::Infragistics.Windows.DataPresenter.DataRecord)enumerator.Current).Cells;
							list = new global::System.Collections.Generic.List<bool?>(cells.Count);
							global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator2 = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>)cells).GetEnumerator();
							num = (short)1471217664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (flag)
							{
								num = (short)331743236;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							num = (short)1342832647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_A0;
							}
							continue;
						case 6:
							num = (short)210698241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_481;
						}
						IL_3E4:
						num = (short)1894383618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A0:
						goto IL_3E4;
					}
					IL_481:
					IL_4D8:;
				}
				finally
				{
					num = (short)611385345;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_544;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_50E;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)242417664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_50E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2096234498;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_544:;
				}
				num = (short)1562574848;
				short num4 = num;
				return list;
			}
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0004A144 File Offset: 0x00048344
		private global::System.Collections.Generic.List<global::AcpUI.AcpFieldToTableCellPairingInfo> a(global::Infragistics.Windows.DataPresenter.DataRecord A_0)
		{
			short num = (short)1851195393;
			if (num != 0)
			{
			}
			num = (short)1198391296;
			short num2 = num;
			num = (short)1942290432;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::AcpUI.AcpFieldToTableCellPairingInfo> list = new global::System.Collections.Generic.List<global::AcpUI.AcpFieldToTableCellPairingInfo>();
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>)A_0.Cells).GetEnumerator();
				try
				{
					num = (short)1515061259;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Infragistics.Windows.DataPresenter.Cell cell;
						global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
						global::AcpUI.AcpFieldToTableCellPairingInfo item;
						switch (num3)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1923153929;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							cell = enumerator.Current;
							num = (short)729153538;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (cellValuePresenter != null)
							{
								num = (short)828637191;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D9;
						case 2:
							if (cell.Field.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)17498117;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							item = global::AcpUI.AcpFieldToTableCellPairingInfo.a((global::AcpCommonLib.IAcpField)cellValuePresenter.Value, cell);
							num = (short)667615236;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_121;
						case 5:
							cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(cell);
							num = (short)1058209793;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_121;
						case 7:
							num = (short)485949448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_28A;
						case 9:
							num = (short)1428946956;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							num = (short)1589011800;
							short num4 = num;
							num = (short)308831576;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_28A;
							default:
								num = (short)1813118976;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 11:
							switch (0)
							{
							case 0:
								goto IL_DE;
							}
							continue;
						case 12:
							goto IL_2CE;
						}
						goto IL_DE;
						IL_121:
						list.Add(item);
						num = (short)1135017994;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D9:
						item = global::AcpUI.AcpFieldToTableCellPairingInfo.a(null, cell);
						num = (short)350814214;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_28A:
						if (cellValuePresenter.Value is global::AcpCommonLib.IAcpField)
						{
							num = (short)1684996099;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9;
						IL_201:
						num = (short)845021184;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DE:
						goto IL_201;
					}
					IL_2CE:;
				}
				finally
				{
					num = (short)1250623489;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)976748546;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_303;
							}
							continue;
						case 2:
							goto IL_33A;
						}
						IL_303:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1370685440;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_33A:;
				}
				return list;
			}
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0004A4AC File Offset: 0x000486AC
		protected global::System.Collections.Generic.SortedList<int, global::Infragistics.Windows.DataPresenter.Record> GetSortedSelectedRecords()
		{
			global::System.Collections.Generic.SortedList<int, global::Infragistics.Windows.DataPresenter.Record> sortedList = new global::System.Collections.Generic.SortedList<int, global::Infragistics.Windows.DataPresenter.Record>(base.SelectedItems.Records.Count);
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = base.SelectedItems.Records.GetEnumerator();
			short num;
			try
			{
				num = (short)24051715;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1770389506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.Record record = enumerator.Current;
						sortedList.Add(record.Index, record);
						num = (short)1779695617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1594294276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						IL_3D:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 4:
						goto IL_12E;
					}
					IL_8D:
					num = (short)1983052175;
					short num3 = num;
					num = (short)1793980815;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						num = (short)418643968;
						if (num != 0)
						{
						}
						num = (short)1282080768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					goto IL_8D;
				}
				IL_12E:;
			}
			finally
			{
				num = (short)538836993;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1239220226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_161;
						}
						continue;
					case 2:
						goto IL_197;
					}
					IL_161:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1193476096;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_197:;
			}
			num = (short)1299709952;
			short num4 = num;
			num = (short)573308929;
			if (num != 0)
			{
			}
			return sortedList;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0004A6C4 File Offset: 0x000488C4
		protected global::System.Windows.Media.HitTestResultBehavior HitTestResultFunc(global::System.Windows.Media.HitTestResult result)
		{
			short num = (short)2042691585;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_53;
			}
			int num2;
			global::Infragistics.Windows.DataPresenter.Record record;
			global::System.Windows.DependencyObject parent;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					if (record.IsActive)
					{
						num = (short)2110914563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BB;
				case 1:
				{
					global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector;
					if (recordSelector == null)
					{
						num = (short)1034485766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					record = recordSelector.Record;
					num = (short)102236160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_12B;
				case 3:
					goto IL_107;
				case 4:
					return global::System.Windows.Media.HitTestResultBehavior.Continue;
				case 5:
				{
					num = (short)414842880;
					short num3 = num;
					if (parent == null)
					{
						num = (short)1800863748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)661538733;
					short num4 = num;
					num = (short)1946896301;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_107;
					default:
					{
						num = (short)437125120;
						if (num != 0)
						{
						}
						global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = parent as global::Infragistics.Windows.DataPresenter.RecordSelector;
						num = (short)103546881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					return global::System.Windows.Media.HitTestResultBehavior.Continue;
				}
				goto IL_53;
				IL_107:
				record.DataPresenter.ActiveCell = null;
				num = (short)15728642;
				num2 = (int)((global::System.IntPtr)num);
			}
			return global::System.Windows.Media.HitTestResultBehavior.Continue;
			IL_12B:
			IL_1BB:
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FromRecord(record).Focus();
			return global::System.Windows.Media.HitTestResultBehavior.Stop;
			IL_53:
			parent = global::System.Windows.Media.VisualTreeHelper.GetParent(result.VisualHit);
			num = (short)1506476037;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0004A89C File Offset: 0x00048A9C
		internal global::System.Windows.Media.HitTestFilterBehavior a(global::System.Windows.DependencyObject A_0)
		{
			short num = (short)1828456864;
			short num2 = num;
			num = (short)1742342560;
			switch (num2 == num)
			{
			}
			num = (short)463339520;
			short num3 = num;
			num = (short)919142401;
			if (num != 0)
			{
			}
			num = (short)25231360;
			if (num != 0)
			{
			}
			return global::System.Windows.Media.HitTestFilterBehavior.Continue;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0004A944 File Offset: 0x00048B44
		protected virtual void DoClipboardCopy()
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)2026962944;
				switch (num)
				{
				default:
				{
					num = (short)515571713;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Text.StringBuilder stringBuilder;
						int num3;
						global::System.Collections.Generic.List<bool?> list;
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)882704395;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Infragistics.Windows.DataPresenter.CellCollection cells;
									int num4;
									global::Infragistics.Windows.DataPresenter.Cell cell;
									bool flag2;
									string text;
									int count;
									switch (num2)
									{
									case 0:
										goto IL_4D1;
									case 1:
										num = (short)1700134917;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										stringBuilder.Append(this.ClipboardRecordSeparator);
										num3++;
										num = (short)290979842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_3FB;
									case 5:
									{
										global::AcpUI.AcpPasswordEyeBox acpPasswordEyeBox;
										if (!acpPasswordEyeBox.IsCopyEnabled)
										{
											num = (short)1817640979;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3D0;
									}
									case 6:
										goto IL_25C;
									case 7:
									{
										global::System.Windows.UIElement uielement;
										if (!(uielement is global::AcpUI.AcpPasswordBox))
										{
											num = (short)2059468823;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2DD;
									}
									case 8:
										goto IL_3FB;
									case 9:
										goto IL_2B3;
									case 10:
										num = (short)535953432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										switch (0)
										{
										case 0:
											goto IL_131;
										}
										continue;
									case 12:
									{
										bool? flag;
										if (flag != null)
										{
											num = (short)1954611210;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3FB;
									}
									case 13:
										goto IL_4D1;
									case 14:
										num = (short)869007375;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 15:
										goto IL_527;
									case 16:
									{
										cell = cells[num4];
										global::System.Windows.UIElement uielement = global::AcpUI.TableCellInfo.a(cell);
										num = (short)1355087879;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
									{
										global::AcpUI.AcpPasswordEyeBox acpPasswordEyeBox;
										if (acpPasswordEyeBox != null)
										{
											num = (short)1048117249;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3D0;
									}
									case 18:
										goto IL_4D1;
									case 19:
									{
										num = (short)555360114;
										short num5 = num;
										num = (short)1569070962;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2B3;
										default:
											num = (short)1619918848;
											if (num != 0)
											{
											}
											goto IL_2DD;
										}
										break;
									}
									case 20:
										if (flag2)
										{
											num = (short)1393033241;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										stringBuilder.AppendFormat(global::AcpUI.Common.Utility.c("\ud9a1钣\udba5펧鮩톫", a_), this.ClipboardCellSeparator, text);
										num = (short)1275985924;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 21:
									{
										if (num4 >= count)
										{
											num = (short)1461977091;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool? flag = list[num4];
										num = (short)806551564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 22:
										goto IL_25C;
									case 23:
									{
										global::System.Windows.UIElement uielement;
										global::AcpUI.AcpPasswordEyeBox acpPasswordEyeBox = uielement as global::AcpUI.AcpPasswordEyeBox;
										num = (short)425328657;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 24:
									{
										bool? flag;
										if (flag.Value)
										{
											num = (short)814153744;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										text = string.Empty;
										num = (short)519176192;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 25:
										stringBuilder.Append(text);
										flag2 = false;
										num = (short)426704904;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_131;
									IL_25C:
									num = (short)845217813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_29A:
									num = (short)366477321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_131:
									goto IL_29A;
									IL_2B3:
									if (!enumerator.MoveNext())
									{
										num = (short)1694892046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)enumerator.Current;
									flag2 = true;
									cells = dataRecord.Cells;
									count = cells.Count;
									num4 = 0;
									num = (short)773324806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2DD:
									text = string.Empty;
									num = (short)1010565133;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_3D0:
									text = cell.ConvertedValue.ToString();
									num = (short)2076573714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_3FB:
									num4++;
									num = (short)17760278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_4D1:
									num = (short)1130364948;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_527:
								goto IL_5D7;
							}
							finally
							{
								num = (short)888930305;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1081999362;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_55E;
										}
										continue;
									case 2:
										goto IL_596;
									}
									IL_55E:
									if (enumerator == null)
									{
										break;
									}
									num = (short)254738432;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_596:;
							}
							goto IL_599;
							IL_5D7:
							global::System.Windows.Clipboard.Clear();
							global::System.Windows.Clipboard.SetText(stringBuilder.ToString());
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, global::AcpCommonResources.AcpResources.Num_Recs_Copied_to_Clipboard.AcpStringFormat(new object[]
							{
								num3
							}));
							num = (short)663945218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1213726721;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_80;
							}
							continue;
						case 2:
							goto IL_624;
						}
						goto IL_80;
						IL_599:
						global::System.Collections.Generic.SortedList<int, global::Infragistics.Windows.DataPresenter.Record> sortedSelectedRecords;
						enumerator = sortedSelectedRecords.Values.GetEnumerator();
						num = (short)1015283712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_80:
						sortedSelectedRecords = this.GetSortedSelectedRecords();
						stringBuilder = new global::System.Text.StringBuilder();
						num3 = 0;
						list = this.f();
						if (list == null)
						{
							break;
						}
						goto IL_599;
					}
					throw new global::System.InvalidOperationException(global::AcpUI.Common.Utility.c("얣좥욧얩\ud8ab躭슯ힱ삳쒵톷\udfb9쪻\udbbdꇁꇃ꫅꓇뫋꿍볏ꟑ뇓ꗕ", a_));
					IL_624:
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::AcpCommonResources.AcpResources.Clipboard_Copy_Aborted);
			}
			num = (short)626589696;
			short num6 = num;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0004AFE8 File Offset: 0x000491E8
		private bool a(global::AcpCommonLib.IAcpField A_0, string A_1, global::AcpUI.TableCellInfo A_2)
		{
			int a_ = 2;
			short num = (short)1283391499;
			int num2 = (int)((global::System.IntPtr)num);
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					xamMaskedEditor.Mask = xamMaskedEditor.Mask.Replace(global::AcpUI.Common.Utility.c("ꮗ뒙ꦛ", a_), global::AcpUI.Common.Utility.c("ꮗ뒙ꪛ", a_));
					num = (short)417529861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (!(A_0 is global::AcpBusinessLayer.AcpFrequencyField))
					{
						goto IL_331;
					}
					num = (short)817102849;
					if (num != 0)
					{
					}
					num = (short)182097710;
					short num3 = num;
					num = (short)396990254;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_276;
					default:
						num = (short)1540292608;
						if (num != 0)
						{
						}
						num = (short)1935409152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return true;
				case 3:
					num = (short)678559751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_32C;
				case 5:
					goto IL_276;
				case 6:
					return true;
				case 7:
					if (A_0.Applicable)
					{
						num = (short)514588684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					if (!A_0.Visible)
					{
						num = (short)1401159684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2039480333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (A_1 == bool.TrueString)
					{
						num = (short)876412930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B7;
				case 10:
					num = (short)1465909257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				case 12:
					num = (short)1643708424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)1509818368;
					short num4 = num;
					if (!(A_2 is global::AcpUI.MaskedTableCellInfo))
					{
						num = (short)1209991174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					xamMaskedEditor = new global::Infragistics.Windows.Editors.XamMaskedEditor();
					xamMaskedEditor.Mask = ((global::AcpUI.MaskedTableCellInfo)A_2).Mask;
					xamMaskedEditor.PadChar = ' ';
					xamMaskedEditor.PromptChar = '_';
					xamMaskedEditor.DisplayMode = global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals;
					num = (short)2059403265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					if (A_0.Editable)
					{
						num = (short)826146819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_6A:
				if (A_0.Name == global::AcpUI.Common.Utility.c("첗춝\ud99f톡쎥욧쾩\udeab쾭\udcaf잳\uddb5\udfb9춻쮽ꦿ냁ꇃꋅ韇诉鬒", a_))
				{
					num = (short)889323530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2B7:
				num = (short)1616510990;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_276:
			goto IL_331;
			IL_32C:
			return false;
			IL_331:
			global::System.Exception ex;
			return xamMaskedEditor.ValidateValue(A_1, out ex);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0004B330 File Offset: 0x00049530
		private int a(global::System.Collections.Generic.List<string[]> A_0, global::Infragistics.Windows.DataPresenter.Cell A_1, int A_2, int A_3)
		{
			int a_ = 5;
			short num = (short)1136721921;
			if (num != 0)
			{
			}
			num = (short)961165451;
			short num2 = num;
			num = (short)200947851;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1189675008;
				if (num != 0)
				{
				}
				num = (short)1835204608;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					global::AcpCommonLib.IAcpField acpField = null;
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask = null;
					num4 = 0;
					int result;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_121;
						}
						global::AcpBusinessLayer.Recordset recordset;
						global::System.Collections.Generic.List<global::AcpUI.AcpFieldToTableCellPairingInfo> list;
						for (;;)
						{
							IL_AE:
							int num5;
							int num8;
							switch (num3)
							{
							case 0:
							{
								global::AcpUI.AcpFieldToTableCellPairingInfo acpFieldToTableCellPairingInfo;
								if (acpFieldToTableCellPairingInfo != null)
								{
									num = (short)791085071;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_177;
							}
							case 1:
							{
								string text;
								if (text != null)
								{
									num = (short)1409679377;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6DD;
							}
							case 2:
							{
								int num6;
								if (num5 > num6)
								{
									num = (short)1282539540;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = recordset[num5];
								num = (short)1663959051;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_30A;
							case 4:
							{
								global::System.Text.StringBuilder stringBuilder;
								stringBuilder.Clear().Append(global::AcpCommonResources.AcpResources.Paste_Not_Allowed.AcpStringFormat(new object[]
								{
									num5 + 1
								}));
								global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, stringBuilder.ToString());
								num = (short)1690304520;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_30A;
							case 6:
								try
								{
									num = (short)618594311;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::AcpUI.AcpFieldToTableCellPairingInfo acpFieldToTableCellPairingInfo2;
										switch (num3)
										{
										case 0:
											goto IL_53E;
										case 1:
											goto IL_515;
										case 2:
										{
											global::AcpCommonLib.IAcpField acpField2 = acpField;
											string text;
											string text2 = text;
											global::AcpUI.AcpFieldToTableCellPairingInfo acpFieldToTableCellPairingInfo = acpFieldToTableCellPairingInfo2;
											num = (short)231997441;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
										{
											string text;
											if (text == bool.TrueString)
											{
												num = (short)2042036226;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_4A9;
										}
										case 4:
											if (acpField.Name == global::AcpUI.Common.Utility.c("쾚\udaa2횤첨얪좬\uddae킰\udfb2쒶트\ud8bc캾듀ꫂ럄ꋆ귈铊賌﯎", a_))
											{
												num = (short)155779081;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_4A9;
										case 5:
											num = (short)316538880;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											goto IL_3BA;
										case 7:
											switch (0)
											{
											case 0:
												goto IL_39C;
											}
											continue;
										case 8:
										{
											string text;
											if (this.a(acpField, text, acpFieldToTableCellPairingInfo2.CellInfo))
											{
												num = (short)981336074;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_51A;
										}
										case 9:
											num = (short)1551761411;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 10:
										{
											string text;
											this.a(acpField, text, containerTask);
											int num7;
											num7++;
											num = (short)290193413;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_39C:
										if (acpFieldToTableCellPairingInfo2.FieldInfo == null)
										{
											num = (short)1570570246;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										acpField = acpFeatureNode[acpFieldToTableCellPairingInfo2.FieldInfo.SectionID][acpFieldToTableCellPairingInfo2.FieldInfo.FieldName];
										num = (short)1411842052;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_4A9:
										num = (short)1439105032;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_3BA:
									throw new global::System.InvalidOperationException(global::AcpCommonResources.AcpResources.Field_Cannot_Accept_Value);
									IL_515:
									goto IL_6DD;
									IL_51A:
									throw new global::System.InvalidOperationException(global::AcpCommonResources.AcpResources.Field_Cannot_Accept_Value);
									IL_53E:
									goto IL_6DD;
								}
								catch (global::System.Exception ex)
								{
									global::System.Text.StringBuilder stringBuilder;
									global::AcpUI.AcpFieldToTableCellPairingInfo acpFieldToTableCellPairingInfo2;
									stringBuilder.Clear().Append(global::AcpCommonResources.AcpResources.Value_Not_Pasted.AcpStringFormat(new object[]
									{
										acpFieldToTableCellPairingInfo2.CellInfo.ColumnName,
										num5 + 1
									}));
									stringBuilder.Append(global::AcpUI.Common.Utility.c("뮚", a_));
									stringBuilder.Append(ex.Message);
									global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, stringBuilder.ToString());
									goto IL_6DD;
								}
								goto IL_5B9;
							case 7:
							{
								if (num8 >= A_3)
								{
									num = (short)1353973781;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								string[] array;
								string text = array[num8];
								num = (short)1721434113;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_247;
							case 9:
							{
								global::AcpCommonLib.IAcpField acpField2;
								if (acpField2 != null)
								{
									num = (short)1396375562;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_177;
							}
							case 10:
								num = (short)1740898328;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.CopyDisabled, acpFeatureNode.Permissions))
								{
									num = (short)2070544388;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								int num9;
								int index = num5 - num9;
								string[] array = A_0[index];
								int num7 = 0;
								global::AcpCommonLib.IAcpField acpField2 = null;
								string text2 = null;
								global::AcpUI.AcpFieldToTableCellPairingInfo acpFieldToTableCellPairingInfo = null;
								num8 = 0;
								num = (short)381943833;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								goto IL_5D6;
							case 13:
							{
								if (recordset == null)
								{
									num = (short)609943575;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								int count = list.Count;
								containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.Paste_Id);
								global::AcpUI.CellPosition cellPosition = global::AcpUI.CellPosition.a(A_1);
								int num10 = cellPosition.ColumnIndex;
								global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
								int num9 = cellPosition.RowIndex;
								num5 = num9;
								int num6 = num5 + A_2 - 1;
								num = (short)394002435;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
								goto IL_26B;
							case 15:
								try
								{
									num = (short)1198653440;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::AcpCommonLib.IAcpField acpField2;
										string text2;
										switch (num3)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_7D2;
											}
											continue;
										case 1:
											num = (short)828899331;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
										{
											this.a(acpField2, text2, containerTask);
											int num7;
											num7++;
											num = (short)621608961;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											goto IL_84A;
										}
										IL_7D2:
										global::AcpUI.AcpFieldToTableCellPairingInfo acpFieldToTableCellPairingInfo;
										if (!this.a(acpField2, text2, acpFieldToTableCellPairingInfo.CellInfo))
										{
											break;
										}
										num = (short)919273474;
										num3 = (int)((global::System.IntPtr)num);
									}
									throw new global::System.InvalidOperationException(global::AcpCommonResources.AcpResources.Field_Cannot_Accept_Value);
									IL_84A:
									goto IL_177;
								}
								catch (global::System.Exception ex2)
								{
									global::AcpUI.AcpFieldToTableCellPairingInfo acpFieldToTableCellPairingInfo;
									global::System.Text.StringBuilder stringBuilder;
									stringBuilder.Clear().Append(global::AcpCommonResources.AcpResources.Value_Not_Pasted.AcpStringFormat(new object[]
									{
										acpFieldToTableCellPairingInfo.CellInfo.ColumnName,
										num5 + 1
									}));
									stringBuilder.Append(global::AcpUI.Common.Utility.c("뮚", a_));
									stringBuilder.Append(ex2.Message);
									global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, stringBuilder.ToString());
									goto IL_177;
								}
								goto IL_8C5;
							case 16:
							{
								int num7;
								if (num7 > 0)
								{
									num = (short)198377494;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_247;
							}
							case 17:
							{
								int num10;
								global::AcpUI.AcpFieldToTableCellPairingInfo acpFieldToTableCellPairingInfo2 = list[num10 + num8];
								num = (short)1286602758;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 18:
								goto IL_247;
							case 19:
								goto IL_8E4;
							case 20:
								goto IL_8C5;
							case 21:
								num = (short)1678639113;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
								num4++;
								num = (short)940638226;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 23:
								goto IL_5B9;
							case 24:
							{
								string text2;
								if (text2 != null)
								{
									num = (short)237568026;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_177;
							}
							case 25:
								goto IL_26B;
							case 26:
								num = (short)1069678592;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_121;
							IL_177:
							num = (short)1390477328;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_247:
							num5++;
							num = (short)1556480005;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_26B:
							num = (short)217972743;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_30A:
							num = (short)2111504386;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_5B9:
							result = 0;
							num = (short)1548550156;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_6DD:
							num8++;
							num = (short)718536718;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_8C5:
							global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
							num = (short)1786183699;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_5D6:
						goto IL_8F7;
						IL_8E4:
						break;
						IL_121:
						list = this.a(A_1.Record);
						recordset = (base.DataSource as global::AcpBusinessLayer.Recordset);
						num = (short)1788542989;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_AE;
					}
					catch (global::System.Exception ex3)
					{
						if (containerTask != null)
						{
							containerTask.Undo();
						}
						throw ex3;
					}
					IL_8F7:
					num = (short)1621688320;
					short num11 = num;
					return result;
				}
				}
				break;
			}
			}
			return num4;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0004BCAC File Offset: 0x00049EAC
		private void e()
		{
			short num = (short)1774977025;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1930887169;
					if (num != 0)
					{
					}
					num = (short)126384113;
					short num3 = num;
					num = (short)574781425;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						num = (short)1410400256;
						if (num != 0)
						{
						}
						(base.SelectedItems.Records[0] as global::Infragistics.Windows.DataPresenter.DataRecord).Cells[0].IsActive = true;
						num = (short)1079443458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_101;
				}
				IL_30:
				if (base.ActiveCell != null)
				{
					return;
				}
				num = (short)416612352;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_101:
			num = (short)771620864;
			short num4 = num;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0004BDE8 File Offset: 0x00049FE8
		protected virtual void DoClipboardPaste()
		{
			short num;
			try
			{
				num = (short)560922624;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					global::System.Collections.Generic.List<string[]> clipboardData;
					for (;;)
					{
						IL_28:
						int num3;
						int num4;
						switch (num2)
						{
						case 0:
							if (clipboardData.Count > num3)
							{
								num = (short)1415118850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9B;
						case 1:
							goto IL_9B;
						case 2:
						{
							string message = global::AcpCommonResources.AcpResources.Insufficient_Num_Rows.AcpStringFormat(new object[]
							{
								clipboardData.Count - num3
							});
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, message);
							num = (short)1991507969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_20F;
						case 4:
							goto IL_1BE;
						case 5:
							if (clipboardData[0].Length > num4)
							{
								num = (short)557449222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_267;
						case 6:
						{
							string message2 = global::AcpCommonResources.AcpResources.Insufficient_Num_Columns.AcpStringFormat(new object[]
							{
								clipboardData[0].Length - num4
							});
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, message2);
							num = (short)655491075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							if (clipboardData.Count == 0)
							{
								num = (short)1598226441;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.e();
							num3 = this.b(clipboardData, clipboardData.Count);
							num = (short)572391424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_2B3;
						case 9:
						{
							num = (short)96909217;
							short num5 = num;
							num = (short)261207969;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_20F;
							default:
								num = (short)255393792;
								if (num != 0)
								{
								}
								global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, global::AcpCommonResources.AcpResources.No_Records_Clipboard.AcpStringFormat(global::System.Array.Empty<object>()));
								num = (short)339804164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_57;
						IL_9B:
						num4 = this.a(clipboardData, clipboardData[0].Length);
						num = (short)1181548549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_267:
						int num6 = this.a(clipboardData, base.ActiveCell, num3, num4);
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, global::AcpCommonResources.AcpResources.Recs_Pasted_Clipboard.AcpStringFormat(new object[]
						{
							num6
						}));
						num = (short)1411710984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20F:
						goto IL_267;
					}
					IL_1BE:
					IL_2B3:
					break;
					IL_57:
					clipboardData = this.GetClipboardData();
					num = (short)1606156295;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::AcpCommonResources.AcpResources.Paste_Opn_Abort);
			}
			num = (short)510001153;
			if (num != 0)
			{
			}
			num = (short)1361248256;
			short num7 = num;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0004C140 File Offset: 0x0004A340
		protected virtual global::System.Collections.Generic.List<string[]> GetClipboardData()
		{
			int a_ = 8;
			short num = (short)1904803840;
			switch (num)
			{
			default:
			{
				num = (short)1166737418;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string[] array2;
					string[] separator;
					switch (num2)
					{
					case 0:
						goto IL_1A8;
					case 1:
					{
						int num3;
						if (num3 == -1)
						{
							num = (short)1372520459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_169;
					}
					case 2:
					{
						global::System.Collections.Generic.List<string[]> list;
						return list;
					}
					case 3:
						goto IL_169;
					case 4:
					{
						int num3;
						string[] array;
						if (num3 != array.Length)
						{
							goto IL_189;
						}
						global::System.Collections.Generic.List<string[]> list;
						list.Add(array);
						int num4;
						num4++;
						num = (short)1139212294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1A3;
					case 6:
						goto IL_1A8;
					case 7:
					{
						int num4;
						int num5;
						if (num4 >= num5)
						{
							num = (short)1899757570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = array2[num4].Split(separator, global::System.StringSplitOptions.None);
						num = (short)1684144129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						if (array2.Length == 0)
						{
							num = (short)627834889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)627838121;
						short num6 = num;
						num = (short)1352731817;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_189;
						default:
						{
							num = (short)408158208;
							if (num != 0)
							{
							}
							int num5 = array2.Length;
							global::System.Collections.Generic.List<string[]> list = new global::System.Collections.Generic.List<string[]>(num5);
							separator = new string[]
							{
								this.ClipboardCellSeparator
							};
							int num3 = -1;
							int num4 = 0;
							num = (short)680656897;
							if (num != 0)
							{
							}
							num = (short)1345978368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
						goto IL_134;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					case 11:
					{
						string[] array;
						int num3 = array.Length;
						num = (short)2030043139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_9F;
					}
					IL_82:
					if (!global::System.Windows.Clipboard.ContainsText())
					{
						num = (short)2014773260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					string text = global::System.Windows.Clipboard.GetText();
					separator = new string[]
					{
						this.ClipboardRecordSeparator
					};
					array2 = text.Split(separator, global::System.StringSplitOptions.RemoveEmptyEntries);
					num = (short)1862139912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_169:
					num = (short)2039873540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_189:
					num = (short)1738014725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A8:
					num = (short)1168441344;
					short num7 = num;
					num = (short)408092679;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9F:
				return new global::System.Collections.Generic.List<string[]>();
				IL_134:
				return new global::System.Collections.Generic.List<string[]>();
				IL_1A3:
				throw new global::System.RankException(global::AcpUI.Common.Utility.c("첝얟송쮣풥첧\ud9a9貫쎭얯솱삳隵\ud9b7횹킻麽ꢿꏁ닃ꏅ뻉꓋ꯍꇑ뗓믕뷗龎닛ꯝ跟胡臣铥죧藩諫컭雯鯱釳髵鳷觹틻", a_));
			}
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0004C464 File Offset: 0x0004A664
		private void d(global::Infragistics.Windows.DataPresenter.CellValuePresenter A_0)
		{
			short num = (short)477082290;
			short num2 = num;
			num = (short)601469618;
			switch (num2 == num)
			{
			default:
			{
				num = (short)555089920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2039873537;
			if (num != 0)
			{
			}
			num = (short)1377370112;
			if (num != 0)
			{
			}
			base.ActiveCell = this.c(A_0);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0004C518 File Offset: 0x0004A718
		private global::Infragistics.Windows.DataPresenter.Cell c(global::Infragistics.Windows.DataPresenter.CellValuePresenter A_0)
		{
			short num = (short)2015053913;
			short num2 = num;
			num = (short)170870873;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1958084608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1659895809;
			if (num != 0)
			{
			}
			num = (short)233439232;
			if (num != 0)
			{
			}
			return A_0.Record.Cells[A_0.Field];
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0004C5D8 File Offset: 0x0004A7D8
		private global::AcpUI.CellPosition d()
		{
			short num = (short)1962615213;
			short num2 = num;
			num = (short)398664109;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1354104832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)584712192;
			if (num != 0)
			{
			}
			num = (short)1896480769;
			if (num != 0)
			{
			}
			return global::AcpUI.CellPosition.a(base.ActiveCell);
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0004C68C File Offset: 0x0004A88C
		internal bool IsDataRecordView
		{
			get
			{
				short num = (short)1972445249;
				short num2 = num;
				num = (short)225779777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1172045824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557659649;
				if (num != 0)
				{
				}
				num = (short)543227904;
				if (num != 0)
				{
				}
				return base.Records is global::Infragistics.Windows.DataPresenter.DataRecordCollection;
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0004C744 File Offset: 0x0004A944
		protected override void OnRecordAdded(global::Infragistics.Windows.DataPresenter.Events.RecordAddedEventArgs args)
		{
			short num = (short)671443068;
			short num2 = num;
			num = (short)474835068;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1577254912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)948699137;
			if (num != 0)
			{
			}
			num = (short)481886208;
			if (num != 0)
			{
			}
			base.OnRecordAdded(args);
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.Windows.DataPresenter.RecordPresenter.FromRecord(args.Record);
			base.Height += recordPresenter.ActualHeight;
			base.InvalidateVisual();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0004C81C File Offset: 0x0004AA1C
		protected override void OnRecordsDeleted(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletedEventArgs args)
		{
			short num = (short)91226113;
			if (num != 0)
			{
			}
			num = (short)1945698304;
			short num2 = num;
			num = (short)1255187924;
			short num3 = num;
			num = (short)1868735956;
			switch (num3 == num)
			{
			}
			num = (short)292290560;
			if (num != 0)
			{
			}
			base.OnRecordsDeleted(args);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0004C8CC File Offset: 0x0004AACC
		protected override void OnRecordsInViewChanged(global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs args)
		{
			short num = (short)13828096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num4;
				global::Infragistics.Windows.DataPresenter.Record[] recordsInView;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1674379265;
						if (num != 0)
						{
						}
						goto IL_DD;
					case 1:
						try
						{
							num = (short)1357905934;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								object obj;
								global::AcpUI.AcpTableComboBox acpTableComboBox;
								switch (num2)
								{
								case 0:
									num = (short)1666121743;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Windows.Controls.ContentPresenter contentPresenter;
									if (contentPresenter != null)
									{
										num = (short)751108098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_296;
								}
								case 2:
								{
									global::System.Windows.Controls.ContentPresenter contentPresenter;
									obj = (global::System.Windows.Media.VisualTreeHelper.GetChild(contentPresenter, 0) as global::System.Windows.UIElement);
									num = (short)344064004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									if (acpTableComboBox != null)
									{
										num = (short)1461977093;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_296;
								case 5:
									acpTableComboBox.GetBindingExpression(global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty).UpdateTarget();
									num = (short)1101332493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Windows.Controls.ContentPresenter contentPresenter = null;
									global::System.Windows.Controls.Panel panel;
									global::System.Collections.IEnumerator enumerator = panel.Children.GetEnumerator();
									num = (short)1341383900;
									short num3 = num;
									num = (short)1356129500;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_29F;
									default:
										num = (short)302055424;
										if (num != 0)
										{
										}
										num = (short)1803943946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Windows.Controls.Panel panel;
									if (panel != null)
									{
										num = (short)1200422918;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_296;
								}
								case 8:
								{
									global::Infragistics.Windows.DataPresenter.Cell cell;
									if (cell.Field.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)417267721;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Infragistics.Windows.DataPresenter.Cell cell;
									global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(cell);
									num = (short)106692620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									try
									{
										num = (short)1767571461;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)297664515;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												global::System.Windows.Controls.ContentPresenter contentPresenter;
												if (contentPresenter != null)
												{
													num = (short)841940996;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
												goto IL_484;
											case 3:
												goto IL_4EE;
											case 4:
												num = (short)1524563970;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												switch (0)
												{
												case 0:
													goto IL_436;
												}
												continue;
											case 6:
											{
												global::System.Collections.IEnumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)11599872;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Windows.Controls.ContentPresenter contentPresenter = ((global::System.Windows.UIElement)enumerator.Current) as global::System.Windows.Controls.ContentPresenter;
												num = (short)265158657;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_438:
											num = (short)1063714822;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_436:
											goto IL_438;
										}
										IL_484:
										IL_4EE:;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_50D;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_4FA:
											switch (num2)
											{
											case 0:
												disposable.Dispose();
												num = (short)158597121;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_564;
											case 2:
												if (disposable != null)
												{
													num = (short)305332224;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_566;
											}
											goto IL_50D;
										}
										IL_564:
										IL_566:
										goto EndFinally_16;
										IL_50D:
										global::System.Collections.IEnumerator enumerator;
										disposable = (enumerator as global::System.IDisposable);
										num = (short)1506803714;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_4FA;
										EndFinally_16:;
									}
									num = (short)726663169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
									obj = global::System.Windows.Media.VisualTreeHelper.GetChild(cellValuePresenter, 0);
									global::System.Windows.Controls.Panel panel = global::System.Windows.Media.VisualTreeHelper.GetChild(cellValuePresenter, 0) as global::System.Windows.Controls.Panel;
									num = (short)1443233799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
									if (cellValuePresenter != null)
									{
										num = (short)1322909707;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 14:
									switch (0)
									{
									case 0:
										goto IL_1B2;
									}
									continue;
								case 15:
									goto IL_5BE;
								case 16:
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1472856064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.Cell cell = enumerator2.Current;
									num = (short)766771208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1E0:
								num = (short)1697251344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B2:
								goto IL_1E0;
								IL_29F:
								num = (short)1494417411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_296:
								acpTableComboBox = (obj as global::AcpUI.AcpTableComboBox);
								goto IL_29F;
							}
							IL_5BE:
							goto IL_6E;
						}
						finally
						{
							num = (short)921305090;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator2;
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1875116033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_62B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5F5;
									}
									continue;
								}
								IL_5F5:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1514143744;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_62B:;
						}
						return;
						IL_6E:
						num4++;
						num = (short)724434944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (num4 >= recordsInView.Length)
						{
							num = (short)1385103363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator2 = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>)((global::Infragistics.Windows.DataPresenter.DataRecord)recordsInView[num4]).Cells).GetEnumerator();
						num = (short)1074003969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_118;
					case 4:
						goto IL_DD;
					}
					goto IL_42;
					IL_DD:
					num = (short)1167327234;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_118:
				num = (short)963837952;
				short num5 = num;
				return;
				IL_42:
				base.OnRecordsInViewChanged(args);
				recordsInView = base.GetRecordsInView(false);
				num4 = 0;
				num = (short)123600900;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0004CF3C File Offset: 0x0004B13C
		private void a(global::Infragistics.Windows.DataPresenter.FieldCollection A_0)
		{
			short num = (short)1732050944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::AcpBusinessLayer.Recordset recordset;
				for (;;)
				{
					IL_27:
					object obj;
					switch (num2)
					{
					case 0:
					{
						int count;
						obj = A_0[count - 1];
						goto IL_1FB;
					}
					case 1:
					{
						int count = A_0.Count;
						num = (short)1301348355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)964493312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1032957113;
						short num3 = num;
						num = (short)733850809;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7A;
						default:
						{
							num = (short)2041446401;
							if (num != 0)
							{
							}
							num = (short)641728512;
							if (num != 0)
							{
							}
							int count;
							if (count <= 1)
							{
								num = (short)144179202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)620756996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
					{
						int count;
						obj = A_0[count - 2];
						goto IL_1FB;
					}
					case 5:
						if (recordset.IsEmbeddedRecset)
						{
							num = (short)1338966017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (recordset != null)
						{
							goto IL_7A;
						}
						return;
					case 7:
						return;
					case 8:
					{
						num = (short)692912128;
						short num4 = num;
						num = (short)225902597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_52;
					IL_7A:
					num = (short)1053491208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FB:
					object obj2 = obj;
					double num5 = obj2.CalculateAutoSizeExtent(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.DataCells, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView);
					double num6 = obj2.CalculateAutoSizeExtent(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView);
					global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options = (num5 < num6) ? global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.DataCells : global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label;
					obj2.PerformAutoSize(options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView);
					obj2.PerformAutoSize(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.All, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView);
					num = (short)1050476551;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_52:
				recordset = (base.DataSource as global::AcpBusinessLayer.Recordset);
				num = (short)25821190;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0004D190 File Offset: 0x0004B390
		protected override void OnPreviewMouseRightButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)756319588;
			short num2 = num;
			num = (short)446334308;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1251016704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1016070145;
			if (num != 0)
			{
			}
			num = (short)902823936;
			if (num != 0)
			{
			}
			base.ActiveRecord.IsSelected = true;
			this.SaveLastMouseButtonChangedInfo(e);
			base.OnPreviewMouseRightButtonDown(e);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0004D250 File Offset: 0x0004B450
		protected override void OnCellActivated(global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs args)
		{
			short num = (short)1439956992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_AA;
				}
				for (;;)
				{
					IL_27:
					global::System.Windows.UIElement uielement;
					object obj;
					global::Infragistics.Windows.DataPresenter.Cell cell;
					switch (num2)
					{
					case 0:
						num = (short)144179227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Windows.DependencyObject dependencyObject;
						if (dependencyObject != null)
						{
							num = (short)1149894671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						if (this.b == global::System.Windows.Input.MouseButtonState.Pressed)
						{
							num = (short)556072967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147;
					case 3:
						goto IL_FE;
					case 4:
					{
						global::System.Windows.Controls.ContentPresenter contentPresenter = null;
						global::System.Windows.Controls.Panel panel;
						global::System.Collections.IEnumerator enumerator = panel.Children.GetEnumerator();
						num = (short)395378717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (uielement.IsVisible)
						{
							num = (short)1943994391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_3E4;
					case 7:
						goto IL_1CC;
					case 8:
						if (obj is global::AcpUILib.IAcpUICtrlBase)
						{
							num = (short)194445321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						num = (short)17367045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return;
					case 11:
						if (this.a == global::System.Windows.Input.MouseButton.Left)
						{
							num = (short)1191182355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147;
					case 12:
						goto IL_147;
					case 13:
					{
						global::System.Windows.Controls.ContentPresenter contentPresenter;
						if (contentPresenter != null)
						{
							num = (short)335609857;
							if (num != 0)
							{
							}
							num = (short)1530331154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					}
					case 14:
						num = (short)258277387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::System.Windows.DependencyObject dependencyObject;
						obj = global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, 0);
						global::System.Windows.Controls.Panel panel = global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, 0) as global::System.Windows.Controls.Panel;
						num = (short)1056833552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::System.Windows.Controls.Panel panel;
						if (panel != null)
						{
							num = (short)1379205124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					}
					case 17:
						if (uielement.IsEnabled)
						{
							goto IL_1AE;
						}
						return;
					case 18:
					{
						global::System.Windows.Controls.ContentPresenter contentPresenter;
						obj = (global::System.Windows.Media.VisualTreeHelper.GetChild(contentPresenter, 0) as global::System.Windows.UIElement);
						num = (short)990838787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						num = (short)661848066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (cell != null)
						{
							num = (short)516358168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						goto IL_569;
					case 22:
						num = (short)370081818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)371720209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::System.Windows.DependencyObject dependencyObject = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(cell);
						num = (short)190644225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						uielement.Focus();
						num = (short)1511129098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (((global::AcpUILib.IAcpUICtrlBase)obj).IsAcpApplicable)
						{
							num = (short)944898073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						if (uielement.Focusable)
						{
							num = (short)477036566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 28:
						if (args.Cell.Record.IsSelected)
						{
							num = (short)430768142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CC;
					case 29:
						try
						{
							num = (short)633995268;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1212022790;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Controls.ContentPresenter contentPresenter = ((global::System.Windows.UIElement)enumerator.Current) as global::System.Windows.Controls.ContentPresenter;
									num = (short)52428805;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1581449218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2C6;
								case 3:
									goto IL_369;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_2AF;
									}
									continue;
								case 5:
								{
									global::System.Windows.Controls.ContentPresenter contentPresenter;
									if (contentPresenter != null)
									{
										num = (short)388759553;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1070530563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2CB:
								num = (short)1042546688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2AF:
								goto IL_2CB;
							}
							IL_2C6:
							IL_369:
							goto IL_681;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_38B;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_378:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)2018050050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3E3;
								case 1:
									goto IL_3E1;
								case 2:
									disposable.Dispose();
									num = (short)174194689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_38B;
							}
							IL_3E1:
							IL_3E3:
							goto EndFinally_18;
							IL_38B:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1703411712;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_378;
							EndFinally_18:;
						}
						goto IL_3E4;
						IL_681:
						num = (short)2114715661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (this.a == global::System.Windows.Input.MouseButton.Right)
						{
							num = (short)232521734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_569;
					}
					goto IL_AA;
					IL_FE:
					uielement = (global::System.Windows.UIElement)obj;
					num = (short)862257160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_147:
					num = (short)244121630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AE:
					num = (short)2084044800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E4:
					num = (short)803602432;
					short num3 = num;
					base.ActiveRecord.IsSelected = true;
					num = (short)831205824;
					short num4 = num;
					num = (short)1110454720;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AE;
					default:
						num = (short)1664417792;
						if (num != 0)
						{
						}
						num = (short)1266090005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1CC:
					base.SelectedItems.Records.Clear();
					num = (short)1475477516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_569:
					cell = args.Cell;
					num = (short)396165140;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_AA:
				base.OnCellActivated(args);
				num = (short)2074476572;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0004D990 File Offset: 0x0004BB90
		protected override void OnInitializeRecord(global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs args)
		{
			short num = (short)1272053761;
			if (num != 0)
			{
			}
			num = (short)204764501;
			short num2 = num;
			num = (short)1285911893;
			switch (num2 == num)
			{
			}
			num = (short)332988416;
			if (num != 0)
			{
			}
			num = (short)1607401472;
			short num3 = num;
			base.OnInitializeRecord(args);
			args.Record.ExpansionIndicatorVisibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0004DA4C File Offset: 0x0004BC4C
		protected override void OnSelectedItemsChanging(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs args)
		{
			short num = (short)762904579;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1446182914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1950023684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (args.Type != typeof(global::Infragistics.Windows.DataPresenter.GroupByRecord))
					{
						num = (short)1784938501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF;
				case 3:
					goto IL_16;
				case 4:
				{
					num = (short)155189248;
					short num3 = num;
					if (args.Type != typeof(global::Infragistics.Windows.DataPresenter.DataRecord))
					{
						num = (short)624820224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF;
				}
				case 5:
				{
					num = (short)494206977;
					if (num != 0)
					{
					}
					num = (short)1967113488;
					short num4 = num;
					num = (short)140428560;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						goto IL_A6;
					}
					break;
				}
				}
				goto IL_3E;
				IL_16:
				switch (0)
				{
				case 0:
					IL_3E:
					if (!(args.Type != typeof(global::Infragistics.Windows.DataPresenter.Record)))
					{
						goto IL_1AF;
					}
					num = (short)1984430081;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_A6:
			num = (short)603324416;
			if (num != 0)
			{
			}
			args.Cancel = true;
			return;
			IL_1AF:
			base.OnSelectedItemsChanging(args);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0004DC10 File Offset: 0x0004BE10
		protected override void OnSelectedItemsChanged(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs args)
		{
			short num = (short)309788672;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_8D;
				case 2:
					num = (short)1151598593;
					if (num != 0)
					{
					}
					base.OnSelectedItemsChanged(args);
					num = (short)777060353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_30;
				IL_33:
				num = (short)213450754;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8D:
				num = (short)1673312332;
				short num3 = num;
				num = (short)2052438092;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_33;
				default:
					goto IL_C3;
				}
				IL_30:
				if (args != null)
				{
					goto IL_33;
				}
				goto IL_8D;
			}
			IL_C3:
			num = (short)524615680;
			short num4 = num;
			num = (short)622985216;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0004DD20 File Offset: 0x0004BF20
		protected override void OnRecordActivated(global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs args)
		{
			short num = (short)1820683548;
			short num2 = num;
			num = (short)885091612;
			switch (num2 == num)
			{
			}
			num = (short)1975517185;
			if (num != 0)
			{
			}
			num = (short)53542912;
			if (num != 0)
			{
			}
			num = (short)1549860864;
			short num3 = num;
			base.OnRecordActivated(args);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0004DDD0 File Offset: 0x0004BFD0
		private void OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1756102656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				for (;;)
				{
					IL_27:
					double num3;
					switch (num2)
					{
					case 0:
					{
						int height;
						num3 = (double)(30 * height / 994);
						num = (short)1473904645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num3 -= 2.0;
						num = (short)451805188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int height;
						if (height > 0)
						{
							num = (short)1688797184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 3:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset != null)
						{
							num = (short)106496007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 4:
						goto IL_2CD;
					case 5:
					{
						int height;
						if (height < 900)
						{
							num = (short)1850998785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CD;
					}
					case 6:
					{
						num = (short)270073857;
						if (num != 0)
						{
						}
						num = (short)2100428800;
						short num4 = num;
						int height = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
						num = (short)1909915650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_1BF;
					case 8:
						goto IL_307;
					case 9:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.IsEmbeddedRecset)
						{
							num = (short)1717108742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					}
					goto IL_56;
					IL_2CD:
					base.MaxHeight = 25.0 * global::System.Math.Floor(num3) + 1.0;
					num = (short)337510408;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_307:
				IL_359:
				base.Loaded -= this.OnLoaded;
				return;
				IL_56:
				num = (short)1763186756;
				short num5 = num;
				num = (short)1335236676;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1BF:
					num = (short)377815049;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
				{
					num = (short)264634368;
					if (num != 0)
					{
					}
					global::System.Windows.Input.KeyGesture gesture = new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.C, global::System.Windows.Input.ModifierKeys.Control);
					global::System.Windows.Input.KeyBinding inputBinding = new global::System.Windows.Input.KeyBinding(global::AcpUI.AcpXamDataPresenter.CopyCommand, gesture);
					base.InputBindings.Add(inputBinding);
					global::System.Windows.Input.KeyGesture gesture2 = new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.V, global::System.Windows.Input.ModifierKeys.Control);
					global::System.Windows.Input.KeyBinding inputBinding2 = new global::System.Windows.Input.KeyBinding(global::AcpUI.AcpXamDataPresenter.PasteCommand, gesture2);
					base.InputBindings.Add(inputBinding2);
					global::System.Windows.Input.CommandBinding commandBinding = new global::System.Windows.Input.CommandBinding(global::AcpUI.AcpXamDataPresenter.CopyCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.OnExecuteCopyCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteCopyCommand));
					base.CommandBindings.Add(commandBinding);
					global::System.Windows.Input.CommandBinding commandBinding2 = new global::System.Windows.Input.CommandBinding(global::AcpUI.AcpXamDataPresenter.PasteCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.OnExecutePasteCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecutePasteCommand));
					base.CommandBindings.Add(commandBinding2);
					base.FieldLayoutSettings.HighlightAlternateRecords = new bool?(true);
					this.g = this.a(this);
					base.GroupByAreaLocation = global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.None;
					base.FieldSettings.LabelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
					global::AcpBusinessLayer.Recordset recordset = base.DataSource as global::AcpBusinessLayer.Recordset;
					num = (short)1328480259;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0004E148 File Offset: 0x0004C348
		private void OnUnloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)8847360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)355729410;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Input.CommandBinding commandBinding;
				global::System.Windows.Input.CommandBinding commandBinding3;
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_EB;
					case 1:
						this.q.Detach();
						this.q = null;
						num = (short)361496576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 3:
						goto IL_3C2;
					case 4:
						try
						{
							num = (short)892403715;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_345;
								case 1:
								{
									global::System.Windows.Input.CommandBinding commandBinding2;
									commandBinding = commandBinding2;
									num = (short)1333919746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_221;
									}
									continue;
								case 4:
								{
									global::System.Windows.Input.CommandBinding commandBinding2;
									commandBinding3 = commandBinding2;
									num = (short)394264584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Windows.Input.CommandBinding commandBinding2;
									if (commandBinding2.Command == global::AcpUI.AcpXamDataPresenter.CopyCommand)
									{
										num = (short)1145110529;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1093271559;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1967390720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Windows.Input.CommandBinding commandBinding2;
									if (commandBinding2.Command == global::AcpUI.AcpXamDataPresenter.PasteCommand)
									{
										num = (short)225902596;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1579155462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Input.CommandBinding commandBinding2 = (global::System.Windows.Input.CommandBinding)enumerator.Current;
									num = (short)1305804805;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_2B3:
								num = (short)1612120073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_221:
								goto IL_2B3;
							}
							IL_345:
							goto IL_654;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_367;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_354:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)564527106;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3C1;
								case 1:
									goto IL_3BF;
								case 2:
									disposable.Dispose();
									num = (short)852623361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_367;
							}
							IL_3BF:
							IL_3C1:
							goto EndFinally_16;
							IL_367:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1142685696;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_354;
							EndFinally_16:;
						}
						goto Block_3;
					}
					IL_57:
					if (this.q != null)
					{
						num = (short)1505558529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
					Block_3:
					global::System.Windows.Input.KeyBinding inputBinding2;
					global::System.Windows.Input.KeyBinding inputBinding3;
					try
					{
						IL_3C2:
						num = (short)108789765;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_588;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)894959626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.Input.InputBinding inputBinding = (global::System.Windows.Input.InputBinding)enumerator.Current;
								num = (short)1815216137;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1809186822;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_418;
								}
								continue;
							case 6:
							{
								global::System.Windows.Input.InputBinding inputBinding;
								if (inputBinding.Command == global::AcpUI.AcpXamDataPresenter.CopyCommand)
								{
									num = (short)1603862535;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1835859979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::System.Windows.Input.InputBinding inputBinding;
								inputBinding2 = (global::System.Windows.Input.KeyBinding)inputBinding;
								num = (short)1230897152;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								global::System.Windows.Input.InputBinding inputBinding;
								inputBinding3 = (global::System.Windows.Input.KeyBinding)inputBinding;
								num = (short)1494024194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
							{
								global::System.Windows.Input.InputBinding inputBinding;
								if (inputBinding is global::System.Windows.Input.KeyBinding)
								{
									num = (short)623771652;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								num = (short)723648513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
							{
								global::System.Windows.Input.InputBinding inputBinding;
								if (inputBinding.Command == global::AcpUI.AcpXamDataPresenter.PasteCommand)
								{
									num = (short)644612104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_50C:
							num = (short)2098003971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_418:
							goto IL_50C;
						}
						IL_588:
						goto IL_7C;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_5AA;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_597:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1784807426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_653;
							case 1:
								goto IL_651;
							case 2:
								goto IL_630;
							}
							goto IL_5AA;
						}
						IL_651:
						IL_653:
						break;
						IL_5AA:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)476687949;
						short num3 = num;
						num = (short)71937613;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_630:
							disposable.Dispose();
							num = (short)1047134209;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_597;
						default:
							num = (short)1195311104;
							if (num != 0)
							{
							}
							num = (short)1292828672;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_597;
						}
					}
					break;
					IL_7C:
					num = (short)1532690433;
					if (num != 0)
					{
					}
					base.InputBindings.Remove(inputBinding2);
					base.InputBindings.Remove(inputBinding3);
					commandBinding = null;
					commandBinding3 = null;
					enumerator = base.CommandBindings.GetEnumerator();
					num = (short)833355780;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EB:
					num = (short)1362362368;
					short num4 = num;
					base.FieldLayoutSettings = null;
					base.Loaded -= this.OnLoaded;
					base.Unloaded -= this.OnUnloaded;
					this.g = null;
					this.m.Click -= this.OnContextMenuItemCopyClick;
					this.n.Click -= this.OnContextMenuItemPasteClick;
					inputBinding2 = null;
					inputBinding3 = null;
					enumerator = base.InputBindings.GetEnumerator();
					num = (short)1416757251;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_654:
				base.CommandBindings.Remove(commandBinding);
				base.CommandBindings.Remove(commandBinding3);
				this.o.Click -= this.OnContextMenuItemGoto;
				this.k.Click -= this.mItemFillUp_Click;
				this.l.Click -= this.mItemFillDown_Click;
				base.FieldSettings = null;
				this.h = null;
				this.i = null;
				this.a();
				return;
			}
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0004E858 File Offset: 0x0004CA58
		private void c()
		{
			global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)this.j.Items).GetEnumerator();
			short num;
			try
			{
				num = (short)1008664579;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EB;
					case 1:
						num = (short)1308884992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1356005377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1800601601;
						if (num != 0)
						{
						}
						((global::System.Windows.Controls.MenuItem)enumerator.Current).IsEnabled = false;
						num = (short)1791950852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_4B;
						}
						continue;
					}
					IL_9B:
					num = (short)1739390978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B:
					goto IL_9B;
				}
				IL_EB:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_10C;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_FA:
					switch (num2)
					{
					case 0:
						goto IL_1AD;
					case 1:
						goto IL_128;
					case 2:
					{
						disposable.Dispose();
						num = (short)37549301;
						short num3 = num;
						num = (short)1570960629;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_128;
						default:
							num = (short)382926848;
							if (num != 0)
							{
							}
							num = (short)2027945984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_10C;
					IL_128:
					if (disposable == null)
					{
						break;
					}
					num = (short)19660802;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1AD:
				goto EndFinally_5;
				IL_10C:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1925709825;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_FA;
				EndFinally_5:;
			}
			num = (short)802816000;
			short num4 = num;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0004EA50 File Offset: 0x0004CC50
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter a(object A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Infragistics.Windows.DataPresenter.CellValuePresenter result;
			for (;;)
			{
				IL_0A:
				global::System.Windows.DependencyObject parent;
				switch (num)
				{
				case 0:
				{
					global::System.Windows.DependencyObject dependencyObject;
					if (dependencyObject is global::Infragistics.Windows.DataPresenter.CellValuePresenter)
					{
						num2 = (short)1506082819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					parent = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
					num2 = (short)146407431;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
					result = this.a(parent);
					num2 = (short)1021771777;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					global::System.Windows.DependencyObject dependencyObject;
					result = (global::Infragistics.Windows.DataPresenter.CellValuePresenter)dependencyObject;
					num2 = (short)1374027781;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (A_0 is global::System.Windows.DependencyObject)
					{
						num2 = (short)1444413446;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					return result;
				case 6:
				{
					num2 = (short)1352070567;
					short num3 = num2;
					num2 = (short)1543959975;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
					{
						num2 = (short)1140129792;
						if (num2 != 0)
						{
						}
						num2 = (short)100335616;
						short num4 = num2;
						num2 = (short)37814273;
						if (num2 != 0)
						{
						}
						global::System.Windows.DependencyObject dependencyObject = (global::System.Windows.DependencyObject)A_0;
						num2 = (short)983105536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 7:
					goto IL_86;
				}
				goto IL_30;
				IL_86:
				if (parent == null)
				{
					break;
				}
				num2 = (short)1877606402;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_30:
			result = null;
			num2 = (short)1859649540;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0004EC30 File Offset: 0x0004CE30
		private void a(global::AcpCommonLib.UndoRedo.ContainerTask A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			short num = (short)1066532875;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.IAcpField acpField;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (((global::AcpBusinessLayer.AcpFieldBase)acpField).UnsupportedValue)
					{
						num = (short)261881869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
					acpField = acpFeatureSection[this.h.UIName];
					num = (short)243073032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = A_1[this.i.FeatureSectionId];
					num = (short)1273757699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
					if (acpFeatureSection != null)
					{
						num = (short)40239105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					num = (short)697434122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1662844934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (acpField.Editable)
					{
						num = (short)128647177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DA;
				case 7:
					if (acpField.Applicable)
					{
						num = (short)374734852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DA;
				case 8:
				{
					if (acpField == null)
					{
						return;
					}
					num = (short)1026737883;
					short num3 = num;
					num = (short)1571210971;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2146762752;
						if (num != 0)
						{
						}
						num = (short)452001797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
				{
					num = (short)766967808;
					short num4 = num;
					num = (short)718929927;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					if (acpField.Visible)
					{
						num = (short)732168206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DA;
				case 11:
					num = (short)2076639233;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 12:
					return;
				case 13:
					goto IL_FA;
				case 14:
					A_0.AddTask(acpField.CopyValueOf(this.h));
					num = (short)823197696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_89:
				if (A_1 != null)
				{
					num = (short)1543307266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_1DA:
				global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.RegisterFieldInReport(acpField, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unacceptable_Destination, false);
				num = (short)1876951052;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.RegisterFieldInReport(acpField, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unsupported_Value, false);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0004EF50 File Offset: 0x0004D150
		private void a(global::AcpCommonLib.FillOperation A_0)
		{
			short num = (short)1741881344;
			switch (num)
			{
			default:
			{
				num = (short)1817116695;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
					global::AcpBusinessLayer.Recordset recordset;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_1D6;
					case 1:
						num = (short)426967041;
						if (num != 0)
						{
						}
						if (A_0 == global::AcpCommonLib.FillOperation.FillUp)
						{
							num = (short)2047934481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1673265181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (containerTask != null)
						{
							num = (short)1110835210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37F;
					case 3:
						containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.Fill_Down.AcpStringFormat(new object[]
						{
							this.h.UIName
						}));
						num = (short)1535115290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_59F;
					case 5:
						goto IL_29B;
					case 6:
						recordset = (global::AcpBusinessLayer.Recordset)this.i.ParentRecset;
						num = (short)592510990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						int num3;
						if (num3 >= recordset.Count)
						{
							num = (short)1258029087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = recordset[num3];
						this.a(containerTask, acpFeatureNode);
						num3++;
						num = (short)990445577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (A_0 == global::AcpCommonLib.FillOperation.FillUp)
						{
							num = (short)1691222043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)134021140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1D6;
					case 10:
						global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
						num = (short)250478624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)761724956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_305;
					case 13:
						goto IL_305;
					case 14:
						if (recordset != null)
						{
							num = (short)1214447640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						goto IL_59F;
					case 16:
						acpFeatureNode = this.i.Parent;
						num = (short)1960902686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						int num4 = num5 - 1;
						num = (short)265551876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_234;
					case 19:
						global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
						num = (short)1797259276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (A_0 == global::AcpCommonLib.FillOperation.FillDown)
						{
							num = (short)1501757443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_567;
					case 21:
					{
						num = (short)131203072;
						short num6 = num;
						int num3 = num5 + 1;
						num = (short)1248722944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_3B0;
					case 23:
						switch (0)
						{
						case 0:
							goto IL_C7;
						}
						continue;
					case 24:
						num = (short)399310866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						int num4;
						if (num4 < 0)
						{
							num = (short)987103243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = recordset[num4];
						this.a(containerTask, acpFeatureNode);
						num4--;
						num = (short)553261044;
						short num7 = num;
						num = (short)1206065140;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_234;
						default:
							num = (short)947912704;
							if (num != 0)
							{
							}
							num = (short)762183695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 26:
						goto IL_29B;
					case 27:
						containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.Fill_Up.AcpStringFormat(new object[]
						{
							this.h.UIName
						}));
						num = (short)299368453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_345;
					case 29:
						if (A_0 == global::AcpCommonLib.FillOperation.FillDown)
						{
							num = (short)1180172309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_345;
					case 30:
						if (acpFeatureNode != null)
						{
							num = (short)1012203526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 31:
						goto IL_345;
					case 32:
						goto IL_37F;
					}
					IL_C7:
					if (this.i != null)
					{
						num = (short)176226320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_234:
					if (global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport == null)
					{
						num = (short)35454995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.Clear();
					num = (short)1947074573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D6:
					num = (short)1144717319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29B:
					num5 = recordset.IndexOf(acpFeatureNode);
					num = (short)215351297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_305:
					containerTask = null;
					num = (short)632750088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_345:
					num = (short)1843986434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37F:
					global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.RegisterFieldInReport(null, global::AcpCommonResources.AcpResources.Fill_Opn_Complete, false);
					global::AcpUI.Common.Utility.FieldsReportChanged(this, global::AcpCommonLib.FieldReportType.FillUpFillDown);
					num = (short)788529174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59F:
					num = (short)1178468377;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B0:
				return;
				IL_567:
				global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.RegisterFieldInReport(null, global::AcpCommonResources.AcpResources.Unsupported_Opn, false);
				global::AcpUI.Common.Utility.FieldsReportChanged(this, global::AcpCommonLib.FieldReportType.FillUpFillDown);
				return;
			}
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0004F58C File Offset: 0x0004D78C
		private void mItemFillUp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)329722994;
			short num2 = num;
			num = (short)2098670706;
			switch (num2 == num)
			{
			}
			num = (short)345571328;
			if (num != 0)
			{
			}
			num = (short)807075841;
			if (num != 0)
			{
			}
			num = (short)905838592;
			short num3 = num;
			this.a(global::AcpCommonLib.FillOperation.FillUp);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0004F63C File Offset: 0x0004D83C
		private void mItemFillDown_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)55964360;
			short num2 = num;
			num = (short)2111369928;
			switch (num2 == num)
			{
			}
			num = (short)233766913;
			if (num != 0)
			{
			}
			num = (short)936574976;
			if (num != 0)
			{
			}
			num = (short)2036989952;
			short num3 = num;
			this.a(global::AcpCommonLib.FillOperation.FillDown);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0004F6EC File Offset: 0x0004D8EC
		private void b()
		{
			short num = (short)1005352471;
			short num2 = num;
			num = (short)1347253783;
			switch (num2 == num)
			{
			}
			num = (short)2087321601;
			if (num != 0)
			{
			}
			num = (short)2010578944;
			if (num != 0)
			{
			}
			num = (short)516030464;
			short num3 = num;
			this.k = new global::System.Windows.Controls.MenuItem();
			this.k.Header = global::AcpCommonResources.AcpResources.Fill_Up.AcpStringFormat(new object[]
			{
				string.Empty
			});
			this.l = new global::System.Windows.Controls.MenuItem();
			this.l.Header = global::AcpCommonResources.AcpResources.Fill_Down.AcpStringFormat(new object[]
			{
				string.Empty
			});
			this.m = new global::System.Windows.Controls.MenuItem();
			this.m.Header = global::AcpCommonResources.AcpResources.Copy_Id;
			this.n = new global::System.Windows.Controls.MenuItem();
			this.n.Header = global::AcpCommonResources.AcpResources.Paste_Id;
			this.o = new global::System.Windows.Controls.MenuItem();
			this.o.Header = global::AcpCommonResources.AcpResources.GoToItem_Id;
			this.p = new global::System.Windows.Controls.MenuItem();
			this.p.Header = global::AcpCommonResources.AcpResources.Delete_Id;
			this.j = new global::System.Windows.Controls.ContextMenu();
			this.j.Items.Add(this.k);
			this.j.Items.Add(this.l);
			this.j.Items.Add(this.m);
			this.j.Items.Add(this.n);
			this.j.Items.Add(this.o);
			this.j.Items.Add(this.p);
			base.ContextMenu = this.j;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0004F904 File Offset: 0x0004DB04
		private void a()
		{
			short num = (short)1882334438;
			short num2 = num;
			num = (short)1961567462;
			switch (num2 == num)
			{
			}
			num = (short)1861222401;
			if (num != 0)
			{
			}
			num = (short)2089025536;
			if (num != 0)
			{
			}
			num = (short)859242496;
			short num3 = num;
			this.k = null;
			this.l = null;
			this.m = null;
			this.n = null;
			this.o = null;
			this.p = null;
			this.j = null;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0004F9DC File Offset: 0x0004DBDC
		private global::AcpUI.AcpExpander a(global::AcpUI.AcpXamDataPresenter A_0)
		{
			short num = (short)89587721;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.DependencyObject dependencyObject;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					dependencyObject = A_0;
					num = (short)1768161285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_146;
				case 2:
					goto IL_112;
				case 3:
					goto IL_10D;
				case 4:
					if (!(dependencyObject is global::System.Windows.Media.Visual))
					{
						num = (short)1325334535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_77;
				case 5:
					goto IL_112;
				case 6:
				{
					if (dependencyObject is global::AcpUI.AcpExpander)
					{
						num = (short)801243139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)855312697;
					short num3 = num;
					num = (short)2142832953;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D1;
					default:
						num = (short)1442316289;
						if (num != 0)
						{
						}
						num = (short)747503616;
						if (num != 0)
						{
						}
						num = (short)157548548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num = (short)1203634184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					if (dependencyObject is global::System.Windows.Media.Media3D.Visual3D)
					{
						num = (short)264568844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)246939648;
					short num4 = num;
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
					num = (short)1146355714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 10:
					if (dependencyObject == null)
					{
						num = (short)1137442817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1213005830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_112;
				case 12:
					goto IL_D1;
				}
				IL_58:
				if (A_0 != null)
				{
					num = (short)810221568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_26D;
				IL_77:
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
				num = (short)210698251;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D1:
				goto IL_77;
				IL_112:
				num = (short)850460682;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10D:
			return dependencyObject as global::AcpUI.AcpExpander;
			IL_146:
			IL_26D:
			return null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0004FC58 File Offset: 0x0004DE58
		private void OnInitializeRecord(object A_0, global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs A_1)
		{
			short num = (short)615579649;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1818902062;
					short num3 = num;
					num = (short)205405742;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)699203585;
						if (num != 0)
						{
						}
						num = (short)688717824;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					}
					break;
				}
				case 2:
					A_1.Record.ExpansionIndicatorVisibility = global::System.Windows.Visibility.Hidden;
					num = (short)519897088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A5:
				num = (short)1993277440;
				short num4 = num;
				if (A_1.Record.HasChildren)
				{
					break;
				}
				num = (short)599523330;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0004FD80 File Offset: 0x0004DF80
		protected internal void BringRecordIntoView(int index)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (scrollInfo == null)
					{
						return;
					}
					num2 = (short)1583906414;
					short num3 = num2;
					num2 = (short)1533705838;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)141492224;
						short num4 = num2;
						num2 = (short)1337982977;
						if (num2 != 0)
						{
						}
						num2 = (short)1475543040;
						if (num2 != 0)
						{
						}
						num2 = (short)1559887873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
				{
					double verticalOffset = scrollInfo.ExtentHeight * (double)index / (double)base.Records.Count;
					scrollInfo.SetVerticalOffset(verticalOffset);
					num2 = (short)963641346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			scrollInfo = base.ScrollInfo;
			num2 = (short)1399914496;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)917569536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::System.Windows.Media.HitTestResult hitTestResult;
				for (;;)
				{
					IL_27:
					global::System.Windows.DependencyObject dependencyObject;
					global::Infragistics.Windows.DataPresenter.Record record;
					switch (num2)
					{
					case 0:
						goto IL_17F;
					case 1:
					{
						if (dependencyObject == null)
						{
							num = (short)1683947520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = dependencyObject as global::Infragistics.Windows.DataPresenter.RecordSelector;
						num = (short)1800994824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_DA;
					case 3:
						goto IL_B0;
					case 4:
						if (hitTestResult != null)
						{
							num = (short)165347331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28D;
					case 5:
					{
						global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector;
						record = recordSelector.Record;
						num = (short)252531891;
						short num3 = num;
						num = (short)1486378163;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B0;
						default:
							num = (short)573964288;
							if (num != 0)
							{
							}
							num = (short)1685389322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_B5;
					case 7:
						goto IL_14B;
					case 8:
					{
						global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector;
						if (recordSelector != null)
						{
							num = (short)1024655365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
						num = (short)1617756167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						record.DataPresenter.ActiveCell = null;
						num = (short)1359872006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (record.IsActive)
						{
							num = (short)1867448329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5;
					case 11:
						goto IL_14B;
					}
					goto IL_5E;
					IL_B0:
					num = (short)562626560;
					short num4 = num;
					dependencyObject = hitTestResult.VisualHit;
					num = (short)559742987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B5:
					global::Infragistics.Windows.DataPresenter.RecordPresenter.FromRecord(record).Focus();
					num = (short)963575810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B:
					num = (short)1607794689;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DA:
				IL_17F:
				IL_28D:
				num = (short)888471553;
				if (num != 0)
				{
				}
				base.OnPreviewMouseLeftButtonDown(e);
				return;
				IL_5E:
				this.SaveLastMouseButtonChangedInfo(e);
				hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(this, e.GetPosition((global::System.Windows.UIElement)e.Source));
				num = (short)1284702212;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00050180 File Offset: 0x0004E380
		protected override void OnPreviewMouseRightButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			global::System.Windows.Media.HitTestResult hitTestResult;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
					if (cellValuePresenter != null)
					{
						num2 = (short)106627079;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
					num2 = (short)785776652;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)589272206;
					short num3 = num2;
					num2 = (short)1172804750;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
					{
						num2 = (short)483459072;
						if (num2 != 0)
						{
						}
						global::System.Windows.DependencyObject dependencyObject = hitTestResult.VisualHit;
						num2 = (short)587268109;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					num2 = (short)442695691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_10F;
				case 4:
					goto IL_1E2;
				case 5:
					if (base.ContextMenu != null)
					{
						goto IL_131;
					}
					goto IL_2E9;
				case 6:
					num2 = (short)1601306625;
					if (num2 != 0)
					{
					}
					if (hitTestResult != null)
					{
						num2 = (short)743768065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10F;
				case 7:
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
					cellValuePresenter.Focus();
					base.ContextMenu = this.j;
					this.b(cellValuePresenter);
					base.ContextMenu.PlacementTarget = cellValuePresenter;
					base.ContextMenu.IsOpen = true;
					num2 = (short)794886147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
				{
					global::System.Windows.DependencyObject dependencyObject;
					if (dependencyObject == null)
					{
						num2 = (short)222101514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = dependencyObject as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
					num2 = (short)578093056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					base.ContextMenu = null;
					num2 = (short)1506017284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_10F;
				case 11:
					if (!base.ContextMenu.IsOpen)
					{
						num2 = (short)461635593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 12:
				{
					num2 = (short)74579968;
					short num4 = num2;
					goto IL_14E;
				}
				case 13:
					goto IL_14E;
				}
				goto IL_48;
				IL_10F:
				num2 = (short)1361772549;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_131:
				num2 = (short)2083520514;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_14E:
				num2 = (short)881328136;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1E2:
			IL_2E9:
			base.OnPreviewMouseRightButtonUp(e);
			return;
			IL_48:
			this.SaveLastMouseButtonChangedInfo(e);
			hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(this, e.GetPosition((global::System.Windows.UIElement)e.Source));
			num2 = (short)1677131782;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00050480 File Offset: 0x0004E680
		protected void SaveLastMouseButtonChangedInfo(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)142257822;
			short num2 = num;
			num = (short)61386398;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1063649280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1906573313;
			if (num != 0)
			{
			}
			num = (short)2099576832;
			if (num != 0)
			{
			}
			this.a = e.ChangedButton;
			this.b = e.ButtonState;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00050540 File Offset: 0x0004E740
		private void b(global::Infragistics.Windows.DataPresenter.CellValuePresenter A_0)
		{
			short num = (short)1492189184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C2;
				}
				global::System.Collections.IEnumerator enumerator2;
				for (;;)
				{
					IL_27:
					bool isEnabled;
					switch (num2)
					{
					case 0:
					{
						bool canEnableClipboardCopy;
						bool canEnableClipboardPaste;
						if (canEnableClipboardCopy || canEnableClipboardPaste)
						{
							num = (short)1766719501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40A;
					}
					case 1:
						isEnabled = false;
						num = (short)901971997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1958477824;
						short num3 = num;
						isEnabled = true;
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField = this.h as global::AcpBusinessLayer.AcpRecRefField;
						num = (short)1890779140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset == null)
						{
							num = (short)558301212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode parent = this.i.Parent;
						num = (short)1108279331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						if (acpRecRefField == null)
						{
							num = (short)1521090561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1785069593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_4CF;
					case 6:
						return;
					case 7:
						try
						{
							num = (short)163446784;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_746;
									}
									continue;
								case 1:
									num = (short)1153040388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<int> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1580007425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)6029318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_7F2;
								case 5:
									isEnabled = false;
									num = (short)164036610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									global::System.Collections.Generic.IEnumerator<int> enumerator;
									if (enumerator.Current == acpRecRefField.Value)
									{
										num = (short)604372997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_748:
								num = (short)1831993347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_746:
								goto IL_748;
							}
							IL_7F2:
							goto IL_259;
						}
						finally
						{
							num = (short)875364352;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<int> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_829;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1203175426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_862;
								}
								IL_829:
								if (enumerator == null)
								{
									break;
								}
								num = (short)779485185;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_862:;
						}
						return;
					case 8:
						if (((global::AcpBusinessLayer.AcpFieldBase)this.h).AllowFillUpFillDown())
						{
							num = (short)1745747989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
					{
						try
						{
							num = (short)1599340545;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_510;
									}
									continue;
								case 2:
								{
									num = (short)293519346;
									short num4 = num;
									num = (short)804569074;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1120796672;
										if (num != 0)
										{
										}
										if (!enumerator2.MoveNext())
										{
											num = (short)335413252;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										((global::System.Windows.Controls.MenuItem)enumerator2.Current).IsEnabled = false;
										num = (short)25493504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_5D9;
								case 4:
									num = (short)1470038019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_53B:
								num = (short)1062862850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_510:
								goto IL_53B;
							}
							IL_5D9:
							goto IL_334;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_5FB;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_5E8:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)133627905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_655;
								case 1:
									disposable.Dispose();
									num = (short)456916994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_653;
								}
								goto IL_5FB;
							}
							IL_653:
							IL_655:
							goto EndFinally_24;
							IL_5FB:
							disposable = (enumerator2 as global::System.IDisposable);
							num = (short)823721984;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_5E8;
							EndFinally_24:;
						}
						goto IL_656;
						IL_334:
						bool canEnableClipboardCopy = this.CanEnableClipboardCopy;
						bool canEnableClipboardPaste = this.CanEnableClipboardPaste;
						((global::System.Windows.Controls.MenuItem)this.j.Items[2]).IsEnabled = canEnableClipboardCopy;
						((global::System.Windows.Controls.MenuItem)this.j.Items[3]).IsEnabled = canEnableClipboardPaste;
						num = (short)356057114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						((global::System.Windows.Controls.MenuItem)this.j.Items[5]).IsEnabled = (this.IsDataRecordView && this.CanEnableDelete);
						num = (short)73859108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.h is global::AcpBusinessLayer.AcpRecRefField)
						{
							num = (short)111017986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91E;
					case 12:
						goto IL_259;
					case 13:
						this.d(A_0);
						num = (short)1705574423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						if (acpRecRefField.Value == -1)
						{
							num = (short)247201808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)28704798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)191823894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						isEnabled = false;
						num = (short)921239583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_91E;
					case 18:
						isEnabled = false;
						num = (short)1817247756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_9DD;
					case 20:
						goto IL_8D6;
					case 21:
					{
						global::AcpBusinessLayer.Recordset recordset;
						global::AcpCommonLib.IAcpFeatureNode parent;
						int num5 = recordset.IndexOf(parent);
						((global::System.Windows.Controls.MenuItem)this.j.Items[0]).IsEnabled = (num5 > 0);
						((global::System.Windows.Controls.MenuItem)this.j.Items[1]).IsEnabled = (num5 < recordset.Count - 1);
						num = (short)155648005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						if (!((global::AcpBusinessLayer.FeatureSection)this.i).CanFill(this.h))
						{
							num = (short)790298644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)this.i.ParentRecset;
						num = (short)2135097347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_40A;
					case 24:
						if (this.i != null)
						{
							num = (short)1297809423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 25:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						if (acpRecRefField.UIValue == acpRecRefField.InvalidText)
						{
							num = (short)1927675922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1373044737;
						if (num != 0)
						{
						}
						num = (short)1473249294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (!this.a(A_0))
						{
							num = (short)1248854049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_656;
					case 27:
						goto IL_1A5;
					case 28:
						return;
					case 29:
						goto IL_259;
					case 30:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						if (acpRecRefField.PrependValues != null)
						{
							num = (short)803274786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_259;
					}
					case 31:
						goto IL_259;
					case 32:
						if (this.h == null)
						{
							num = (short)1407451142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.i = this.h.Parent;
						num = (short)917766168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						((global::System.Windows.Controls.MenuItem)this.j.Items[5]).IsEnabled = false;
						num = (short)974716955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						global::System.Collections.Generic.IEnumerator<int> enumerator = acpRecRefField.PrependValues.GetEnumerator();
						num = (short)1466695687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if (parent == null)
						{
							num = (short)928841747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1160839179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						goto IL_1A5;
					}
					goto IL_C2;
					IL_1A5:
					num = (short)1607270400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_259:
					((global::System.Windows.Controls.MenuItem)this.j.Items[4]).IsEnabled = isEnabled;
					num = (short)463208465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40A:
					this.h = null;
					this.i = null;
					this.h = (A_0.Value as global::AcpCommonLib.IAcpField);
					num = (short)1507065888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_656:
					num = (short)1346895882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_91E:
					num = (short)436731912;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4CF:
				return;
				IL_8D6:
				return;
				IL_9DD:
				return;
				IL_C2:
				enumerator2 = ((global::System.Collections.IEnumerable)this.j.Items).GetEnumerator();
				num = (short)1637351433;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00050FBC File Offset: 0x0004F1BC
		private bool a(global::Infragistics.Windows.DataPresenter.CellValuePresenter A_0)
		{
			short num = (short)731971584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)530186241;
				if (num != 0)
				{
				}
				this.h = null;
				this.i = null;
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_100;
					}
					for (;;)
					{
						IL_89:
						global::AcpCommonLib.IAcpFeatureNode parent2;
						switch (num2)
						{
						case 0:
							goto IL_6B7;
						case 1:
						{
							global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)base.DataSource;
							num = (short)1389297669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_42F;
						case 3:
						{
							this.i = (A_0.Value as global::AcpCommonLib.IAcpFeatureSection);
							global::AcpCommonLib.IAcpFeatureNode parent = this.i.Parent;
							num = (short)1398013967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::AcpBusinessLayer.Recordset recordset2;
							if (recordset2 == null)
							{
								num = (short)943259648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = base.SelectedItems.Records.GetEnumerator();
							num = (short)1989214224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset == null)
							{
								num = (short)1349845002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = base.SelectedItems.Records.GetEnumerator();
							num = (short)1092354066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (base.SelectedItems.Records.Count > 1)
							{
								num = (short)263979025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_405;
						case 7:
							num = (short)1414922246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!((global::AcpBusinessLayer.FeatureSection)this.i).CanFill(this.h))
							{
								num = (short)228392979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							parent2 = this.i.Parent;
							num = (short)1112670219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (this.i != null)
							{
								num = (short)97583118;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_79E;
						case 10:
							result = true;
							num = (short)592379916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (parent2 != null)
							{
								num = (short)1717108743;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_862;
						case 12:
							goto IL_284;
						case 13:
							num = (short)291700756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							num = (short)342097928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							global::AcpCommonLib.IAcpFeatureNode parent;
							if (parent != null)
							{
								num = (short)2082668557;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_862;
						}
						case 16:
							try
							{
								num = (short)2109210630;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										result = false;
										num = (short)379060227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1173225474;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Infragistics.Windows.DataPresenter.Record record = enumerator.Current;
										num = (short)1740374021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)272695300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_376;
									case 4:
										goto IL_394;
									case 5:
									{
										global::AcpBusinessLayer.Recordset recordset2;
										global::Infragistics.Windows.DataPresenter.Record record;
										if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.Undeletable, ((global::AcpBusinessLayer.FeatureNode)recordset2[record.Index]).Permissions))
										{
											num = (short)1968111616;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_2CB;
										}
										continue;
									}
									IL_2CD:
									num = (short)1062535169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2CB:
									goto IL_2CD;
								}
								IL_376:
								return result;
								IL_394:
								goto IL_862;
							}
							finally
							{
								num = (short)88080386;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_402;
									case 1:
										enumerator.Dispose();
										num = (short)1223360512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_3CB;
										}
										continue;
									}
									IL_3CB:
									if (enumerator == null)
									{
										break;
									}
									num = (short)953548801;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_402:;
							}
							goto IL_405;
						case 17:
						{
							global::AcpBusinessLayer.Recordset recordset2 = (global::AcpBusinessLayer.Recordset)base.DataSource;
							num = (short)239468548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							try
							{
								num = (short)2002714630;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										IL_60D:
										num = (short)1943994372;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::AcpBusinessLayer.Recordset recordset;
										global::Infragistics.Windows.DataPresenter.Record record2;
										if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.Undeletable, ((global::AcpBusinessLayer.FeatureNode)recordset[record2.Index]).Permissions))
										{
											num = (short)375652354;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										result = false;
										num = (short)6488067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_62A;
									case 4:
										goto IL_647;
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1341849600;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Infragistics.Windows.DataPresenter.Record record2 = enumerator.Current;
										num = (short)656736257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_52D;
										}
										continue;
									}
									IL_587:
									num = (short)210696228;
									short num3 = num;
									num = (short)74381348;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_60D;
									default:
										num = (short)1882783744;
										if (num != 0)
										{
										}
										num = (short)918224901;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_52D:
									goto IL_587;
								}
								IL_62A:
								return result;
								IL_647:
								goto IL_862;
							}
							finally
							{
								num = (short)1599995906;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_6B4;
									case 1:
										enumerator.Dispose();
										num = (short)1687617536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_67E;
										}
										continue;
									}
									IL_67E:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1631191041;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_6B4:;
							}
							goto IL_6B7;
						case 19:
							goto IL_79E;
						case 20:
						{
							if (base.SelectedItems.Records.Count > 1)
							{
								num = (short)1850802177;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode parent;
							result = !global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.Undeletable, parent.Permissions);
							num = (short)458227735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							goto IL_87A;
						case 22:
							if (A_0.Value is global::AcpCommonLib.IAcpFeatureSection)
							{
								num = (short)1845035011;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_862;
						case 23:
							goto IL_74A;
						case 24:
							goto IL_7B9;
						case 25:
							if (this.h == null)
							{
								num = (short)849215515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.i = this.h.Parent;
							num = (short)1552547849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							goto IL_6D3;
						case 27:
							num = (short)336265238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_100;
						IL_405:
						result = !global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.Undeletable, parent2.Permissions);
						num = (short)481820674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6B7:
						result = true;
						num = (short)1445593114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_79E:
						result = true;
						num = (short)1990262808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_862:
						num = (short)2037973013;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_284:
					IL_42F:
					IL_6D3:
					IL_74A:
					IL_7B9:
					return result;
					IL_87A:
					goto IL_54;
					IL_100:
					this.h = (A_0.Value as global::AcpCommonLib.IAcpField);
					num = (short)1523318809;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_89;
				}
				catch (global::System.Exception)
				{
					goto IL_54;
				}
				return result;
				IL_54:
				num = (short)675217408;
				short num4 = num;
				return true;
			}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0005189C File Offset: 0x0004FA9C
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num;
			if (e.Key == global::System.Windows.Input.Key.Apps)
			{
				num = (short)1636696064;
				short num2 = num;
				num = (short)1661063066;
				short num3 = num;
				num = (short)1212403610;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)669974528;
					if (num != 0)
					{
					}
					e.Handled = true;
					return;
				}
			}
			num = (short)771031041;
			if (num != 0)
			{
			}
			base.OnPreviewKeyDown(e);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00051964 File Offset: 0x0004FB64
		protected override void OnPreviewKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Apps)
			{
				short num = (short)1562836992;
				short num2 = num;
				num = (short)1292481674;
				short num3 = num;
				num = (short)1553546;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)331939840;
					if (num != 0)
					{
					}
					num = (short)863174657;
					if (num != 0)
					{
					}
					e.Handled = true;
					return;
				}
			}
			base.OnPreviewKeyUp(e);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00051A2C File Offset: 0x0004FC2C
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)992176482;
				short num2 = num;
				num = (short)544106850;
				switch (num2 == num)
				{
				}
				num = (short)753205248;
				if (num != 0)
				{
				}
			}
			finally
			{
				num = (short)1257897985;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)133365760;
			short num3 = num;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00051AF0 File Offset: 0x0004FCF0
		// Note: this type is marked as 'beforefieldinit'.
		static AcpXamDataPresenter()
		{
			int a_ = 18;
			short num = (short)2062113396;
			short num2 = num;
			num = (short)519395956;
			switch (num2 == num)
			{
			}
			num = (short)908394497;
			if (num != 0)
			{
			}
			num = (short)1378484224;
			short num3 = num;
			num = (short)2050359296;
			if (num != 0)
			{
			}
			global::AcpUI.AcpXamDataPresenter.c = new global::System.Windows.Input.RoutedCommand();
			global::AcpUI.AcpXamDataPresenter.d = new global::System.Windows.Input.RoutedCommand();
			global::AcpUI.AcpXamDataPresenter.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯햳\udab5톷\udeb9", a_), typeof(bool), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpXamDataPresenter.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯쒳욵풷펹\udfbb\udfbdꊿ껁ꇃ", a_), typeof(bool), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpXamDataPresenter.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯킳\udfb5첷\udbb9\udebb튽ꖿ", a_), typeof(bool), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpXamDataPresenter.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯\uddb3억톷\ud8b9킻\udbbd", a_), typeof(bool), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpXamDataPresenter.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩쾭튯ힱ\ud8b3첷좹킻", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpXamDataPresenter.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩솭삯쮱쎵첷캹펻킽莿뛁뛃꫅", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpXamDataPresenter.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩ﾯ킱\udeb3펵\udbb7캹", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpXamDataPresenter.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud8a9즫톯\udeb1솳펵쮷ﾹ춻쮽ꆿ껁", a_), typeof(bool), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpXamDataPresenter.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩횭삯펱\udab3튵\uddb7좹", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpXamDataPresenter.ShowDiffIconProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("ﮧ슩쎫\ud9ad\udbb1튳킵\ud9b9펻킽", a_), typeof(bool), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpXamDataPresenter.HeaderProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("쾩춫쪭햯삱", a_), typeof(string), typeof(global::AcpUI.AcpXamDataPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x04000254 RID: 596
		private global::System.Windows.Input.MouseButton a;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Input.MouseButtonState b;

		// Token: 0x04000256 RID: 598
		private static global::System.Windows.Input.RoutedCommand c;

		// Token: 0x04000257 RID: 599
		private static global::System.Windows.Input.RoutedCommand d;

		// Token: 0x04000258 RID: 600
		private string e;

		// Token: 0x04000259 RID: 601
		private string f;

		// Token: 0x0400025A RID: 602
		private global::AcpUI.AcpExpander g;

		// Token: 0x0400025B RID: 603
		private global::AcpCommonLib.IAcpField h;

		// Token: 0x0400025C RID: 604
		private global::AcpCommonLib.IAcpFeatureSection i;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Controls.ContextMenu j;

		// Token: 0x0400025E RID: 606
		private global::System.Windows.Controls.MenuItem k;

		// Token: 0x0400025F RID: 607
		private global::System.Windows.Controls.MenuItem l;

		// Token: 0x04000260 RID: 608
		private global::System.Windows.Controls.MenuItem m;

		// Token: 0x04000261 RID: 609
		private global::System.Windows.Controls.MenuItem n;

		// Token: 0x04000262 RID: 610
		private global::System.Windows.Controls.MenuItem o;

		// Token: 0x04000263 RID: 611
		private global::System.Windows.Controls.MenuItem p;

		// Token: 0x04000264 RID: 612
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x04000265 RID: 613
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000266 RID: 614
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000267 RID: 615
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000268 RID: 616
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000269 RID: 617
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x0400026A RID: 618
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x0400026B RID: 619
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x0400026C RID: 620
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x0400026D RID: 621
		public static readonly global::System.Windows.DependencyProperty ShowDiffIconProperty;

		// Token: 0x0400026E RID: 622
		private global::AcpUI.XamDataGridDragDropBehavior q;

		// Token: 0x0400026F RID: 623
		public static readonly global::System.Windows.DependencyProperty HeaderProperty;
	}
}
