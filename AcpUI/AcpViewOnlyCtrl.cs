using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000044 RID: 68
	public class AcpViewOnlyCtrl : global::System.Windows.Controls.Label, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00042B98 File Offset: 0x00040D98
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00042C5C File Offset: 0x00040E5C
		public string Value
		{
			get
			{
				if (base.Content != null)
				{
					short num;
					for (;;)
					{
						num = (short)272674572;
						short num2 = num;
						num = (short)220180236;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_43;
						}
					}
					IL_43:
					num = (short)235339777;
					if (num != 0)
					{
					}
					num = (short)1657405440;
					if (num != 0)
					{
					}
					num = (short)1608908800;
					short num3 = num;
					return base.Content.ToString();
				}
				return null;
			}
			set
			{
				short num = (short)2037074694;
				short num2 = num;
				num = (short)596724486;
				switch (num2 == num)
				{
				}
				num = (short)386007040;
				if (num != 0)
				{
				}
				num = (short)1449197569;
				if (num != 0)
				{
				}
				num = (short)176291840;
				short num3 = num;
				base.Content = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00042D0C File Offset: 0x00040F0C
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00042DC8 File Offset: 0x00040FC8
		public bool IsAcpValid
		{
			get
			{
				short num = (short)1807155947;
				short num2 = num;
				num = (short)2024866539;
				switch (num2 == num)
				{
				}
				num = (short)1849819137;
				if (num != 0)
				{
				}
				num = (short)1438842880;
				if (num != 0)
				{
				}
				num = (short)1708523520;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.IsAcpValidProperty);
			}
			set
			{
				short num = (short)294387713;
				if (num != 0)
				{
				}
				num = (short)1613194805;
				short num2 = num;
				num = (short)1029334581;
				switch (num2 == num)
				{
				}
				num = (short)1771700224;
				if (num != 0)
				{
				}
				num = (short)526909440;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00042E84 File Offset: 0x00041084
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00042F40 File Offset: 0x00041140
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)968630498;
				short num2 = num;
				num = (short)1829118178;
				switch (num2 == num)
				{
				}
				num = (short)731971584;
				if (num != 0)
				{
				}
				num = (short)1890648065;
				if (num != 0)
				{
				}
				num = (short)1364918272;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)903930247;
				short num2 = num;
				num = (short)1640096135;
				switch (num2 == num)
				{
				}
				num = (short)695992320;
				if (num != 0)
				{
				}
				num = (short)353239041;
				if (num != 0)
				{
				}
				num = (short)1220804608;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00042FFC File Offset: 0x000411FC
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000430B4 File Offset: 0x000412B4
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)229376001;
				if (num != 0)
				{
				}
				num = (short)577573883;
				short num2 = num;
				num = (short)1630868475;
				switch (num2 == num)
				{
				}
				num = (short)677249024;
				if (num != 0)
				{
				}
				num = (short)1560412160;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1233798117;
				short num2 = num;
				num = (short)222577637;
				switch (num2 == num)
				{
				}
				num = (short)141164544;
				if (num != 0)
				{
				}
				num = (short)36503553;
				if (num != 0)
				{
				}
				num = (short)306511872;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00043170 File Offset: 0x00041370
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0004322C File Offset: 0x0004142C
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1040592122;
				short num2 = num;
				num = (short)1387932922;
				switch (num2 == num)
				{
				}
				num = (short)412614656;
				if (num != 0)
				{
				}
				num = (short)1912340481;
				if (num != 0)
				{
				}
				num = (short)1488912384;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1535496237;
				short num2 = num;
				num = (short)1374015533;
				switch (num2 == num)
				{
				}
				num = (short)1023475713;
				if (num != 0)
				{
				}
				num = (short)1804926976;
				if (num != 0)
				{
				}
				num = (short)389152768;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x000432E8 File Offset: 0x000414E8
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000433A0 File Offset: 0x000415A0
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)489191947;
				short num2 = num;
				num = (short)1281718795;
				switch (num2 == num)
				{
				}
				num = (short)392167425;
				if (num != 0)
				{
				}
				num = (short)1991245824;
				if (num != 0)
				{
				}
				num = (short)1834680320;
				short num3 = num;
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1968522433;
				short num2 = num;
				num = (short)211829953;
				switch (num2 == num)
				{
				}
				num = (short)770572289;
				if (num != 0)
				{
				}
				num = (short)814022656;
				if (num != 0)
				{
				}
				num = (short)1329922048;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0004345C File Offset: 0x0004165C
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00043518 File Offset: 0x00041718
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)1823088966;
				short num2 = num;
				num = (short)1736646982;
				switch (num2 == num)
				{
				}
				num = (short)1476329473;
				if (num != 0)
				{
				}
				num = (short)1742077952;
				if (num != 0)
				{
				}
				num = (short)928186368;
				short num3 = num;
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)842009748;
				short num2 = num;
				num = (short)517213332;
				switch (num2 == num)
				{
				}
				num = (short)853344256;
				if (num != 0)
				{
				}
				num = (short)1827995649;
				if (num != 0)
				{
				}
				num = (short)2022506496;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000435D0 File Offset: 0x000417D0
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0004368C File Offset: 0x0004188C
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)2049842169;
				short num2 = num;
				num = (short)2001148921;
				switch (num2 == num)
				{
				}
				num = (short)664403968;
				if (num != 0)
				{
				}
				num = (short)2077360129;
				if (num != 0)
				{
				}
				num = (short)124977152;
				short num3 = num;
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.MyBLObjectProperty);
			}
			set
			{
				short num = (short)505188856;
				short num2 = num;
				num = (short)1197707768;
				switch (num2 == num)
				{
				}
				num = (short)668794880;
				if (num != 0)
				{
				}
				num = (short)2035154945;
				if (num != 0)
				{
				}
				num = (short)377880576;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00043740 File Offset: 0x00041940
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x000437FC File Offset: 0x000419FC
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)944664284;
				short num2 = num;
				num = (short)1136684764;
				switch (num2 == num)
				{
				}
				num = (short)44695552;
				if (num != 0)
				{
				}
				num = (short)1769537537;
				if (num != 0)
				{
				}
				num = (short)356777984;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)5636097;
				if (num != 0)
				{
				}
				num = (short)1179272679;
				short num2 = num;
				num = (short)2017084903;
				switch (num2 == num)
				{
				}
				num = (short)1440022528;
				if (num != 0)
				{
				}
				num = (short)150667264;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x000438B4 File Offset: 0x00041AB4
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00043970 File Offset: 0x00041B70
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)124911617;
				if (num != 0)
				{
				}
				num = (short)35855500;
				short num2 = num;
				num = (short)1599872140;
				switch (num2 == num)
				{
				}
				num = (short)1545928704;
				if (num != 0)
				{
				}
				num = (short)1812725760;
				short num3 = num;
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.MyExpanderProperty);
			}
			set
			{
				short num = (short)1296167224;
				short num2 = num;
				num = (short)436269368;
				switch (num2 == num)
				{
				}
				num = (short)144441345;
				if (num != 0)
				{
				}
				num = (short)2139226112;
				if (num != 0)
				{
				}
				num = (short)14942208;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00043A24 File Offset: 0x00041C24
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00043AE0 File Offset: 0x00041CE0
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)537618821;
				short num2 = num;
				num = (short)1049848197;
				switch (num2 == num)
				{
				}
				num = (short)1759707137;
				if (num != 0)
				{
				}
				num = (short)1393885184;
				if (num != 0)
				{
				}
				num = (short)1076625408;
				short num3 = num;
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpViewOnlyCtrl.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)2102009912;
				short num2 = num;
				num = (short)615129144;
				switch (num2 == num)
				{
				}
				num = (short)379387905;
				if (num != 0)
				{
				}
				num = (short)1284702208;
				if (num != 0)
				{
				}
				num = (short)1366360064;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpViewOnlyCtrl.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00043B90 File Offset: 0x00041D90
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00043C40 File Offset: 0x00041E40
		public bool IsInTable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)767404748;
				short num2 = num;
				num = (short)999336652;
				switch (num2 == num)
				{
				}
				num = (short)644022273;
				if (num != 0)
				{
				}
				num = (short)475529216;
				if (num != 0)
				{
				}
				num = (short)2141126656;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1024628475;
				short num2 = num;
				num = (short)768710395;
				switch (num2 == num)
				{
				}
				num = (short)616759297;
				if (num != 0)
				{
				}
				num = (short)1958674432;
				if (num != 0)
				{
				}
				num = (short)1826947072;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00043CF0 File Offset: 0x00041EF0
		public AcpViewOnlyCtrl()
		{
			base.MinWidth = 150.0;
			base.Height = 23.2766666666667;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00043D24 File Offset: 0x00041F24
		// Note: this type is marked as 'beforefieldinit'.
		static AcpViewOnlyCtrl()
		{
			int a_ = 2;
			short num = (short)1755185153;
			if (num != 0)
			{
			}
			num = (short)1290478341;
			short num2 = num;
			num = (short)707273477;
			switch (num2 == num)
			{
			}
			num = (short)465240064;
			if (num != 0)
			{
			}
			num = (short)1829961728;
			short num3 = num;
			global::AcpUI.AcpViewOnlyCtrl.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("톗\udd9bﶝ킟얣쪥솧캩", a_), typeof(bool), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpViewOnlyCtrl.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("톗\udd9bﶝ킟풣횥쒧쎩쾫쾭튯\udeb1톳", a_), typeof(bool), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpViewOnlyCtrl.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("톗\udd9bﶝ킟삣쾥\udca7쮩캫슭햯", a_), typeof(bool), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpViewOnlyCtrl.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("톗\udd9bﶝ킟춣향솧좩삫쮭", a_), typeof(bool), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpViewOnlyCtrl.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("햗킛ﾝ슟잡좣\udca7\ud8a9삫", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpViewOnlyCtrl.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("햗\udf9b킟\udba1펥\udca7\udea9쎫삭욱욳\udab5", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpViewOnlyCtrl.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("햗\ude9b튝삡캣쎥쮧\udea9", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpViewOnlyCtrl.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud997鍊좝솟캡톣쎥\udba7\uddab\udbad톯\udeb1", a_), typeof(bool), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpViewOnlyCtrl.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("햗\ud99b킟쎡쪣슥춧\ud8a9", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpViewOnlyCtrl.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("햗첛ﾝ튟잡쪣튥\udea9\udeab슭", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpViewOnlyCtrl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x0400023C RID: 572
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x0400023D RID: 573
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x0400023E RID: 574
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x0400023F RID: 575
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000240 RID: 576
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000241 RID: 577
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000242 RID: 578
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x04000243 RID: 579
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000244 RID: 580
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x04000245 RID: 581
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000246 RID: 582
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;
	}
}
