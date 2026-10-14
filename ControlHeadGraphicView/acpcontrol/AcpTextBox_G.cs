using System;
using System.Windows;
using System.Windows.Controls;
using AcpBusinessLayer;
using AcpUILib;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView.acpcontrol
{
	// Token: 0x02000016 RID: 22
	public class AcpTextBox_G : global::System.Windows.Controls.TextBox, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x000C9268 File Offset: 0x000C7468
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x000C9318 File Offset: 0x000C7518
		public string Value
		{
			get
			{
				short num = (short)857669632;
				short num2 = num;
				num = (short)1693713933;
				short num3 = num;
				num = (short)1079379469;
				switch (num3 == num)
				{
				}
				num = (short)585498625;
				if (num != 0)
				{
				}
				num = (short)1821769728;
				if (num != 0)
				{
				}
				return base.Text;
			}
			set
			{
				short num = (short)103677952;
				short num2 = num;
				num = (short)1989415866;
				short num3 = num;
				num = (short)1233982394;
				switch (num3 == num)
				{
				}
				num = (short)642777089;
				if (num != 0)
				{
				}
				num = (short)103153664;
				if (num != 0)
				{
				}
				base.Text = value;
				this.GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty).UpdateSource();
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x000C93D8 File Offset: 0x000C75D8
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x000C9490 File Offset: 0x000C7690
		public bool IsAcpValid
		{
			get
			{
				short num = (short)924844032;
				short num2 = num;
				num = (short)532763744;
				short num3 = num;
				num = (short)676549728;
				switch (num3 == num)
				{
				}
				num = (short)584384513;
				if (num != 0)
				{
				}
				num = (short)1340211200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpValidProperty);
			}
			set
			{
				short num = (short)456130560;
				short num2 = num;
				num = (short)893715819;
				short num3 = num;
				num = (short)633668971;
				switch (num3 == num)
				{
				}
				num = (short)1008664576;
				if (num != 0)
				{
				}
				num = (short)1340276737;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x000C954C File Offset: 0x000C774C
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x000C9604 File Offset: 0x000C7804
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1442906112;
				short num2 = num;
				num = (short)2137387358;
				short num3 = num;
				num = (short)1700524382;
				switch (num3 == num)
				{
				}
				num = (short)656932865;
				if (num != 0)
				{
				}
				num = (short)1054801920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)762839040;
				short num2 = num;
				num = (short)1774691624;
				short num3 = num;
				num = (short)1877452072;
				switch (num3 == num)
				{
				}
				num = (short)1650262017;
				if (num != 0)
				{
				}
				num = (short)1024000000;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x000C96BC File Offset: 0x000C78BC
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x000C9778 File Offset: 0x000C7978
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1490026496;
				short num2 = num;
				num = (short)1871429609;
				short num3 = num;
				num = (short)97959913;
				switch (num3 == num)
				{
				}
				num = (short)191430656;
				if (num != 0)
				{
				}
				num = (short)468189185;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1166213120;
				short num2 = num;
				num = (short)37421057;
				if (num != 0)
				{
				}
				num = (short)571317626;
				short num3 = num;
				num = (short)307535226;
				switch (num3 == num)
				{
				}
				num = (short)1647247360;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000C9834 File Offset: 0x000C7A34
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x000C98EC File Offset: 0x000C7AEC
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1285881856;
				short num2 = num;
				num = (short)1533737441;
				short num3 = num;
				num = (short)733018593;
				switch (num3 == num)
				{
				}
				num = (short)904527873;
				if (num != 0)
				{
				}
				num = (short)383516672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)550502400;
				short num2 = num;
				num = (short)111007231;
				short num3 = num;
				num = (short)502453759;
				switch (num3 == num)
				{
				}
				num = (short)1800667137;
				if (num != 0)
				{
				}
				num = (short)458489856;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x000C99A8 File Offset: 0x000C7BA8
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x000C9A60 File Offset: 0x000C7C60
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)283901952;
				short num2 = num;
				num = (short)1100971040;
				short num3 = num;
				num = (short)1726250016;
				switch (num3 == num)
				{
				}
				num = (short)912326657;
				if (num != 0)
				{
				}
				num = (short)198901760;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)191627264;
				short num2 = num;
				num = (short)616681567;
				short num3 = num;
				num = (short)443600991;
				switch (num3 == num)
				{
				}
				num = (short)904462336;
				if (num != 0)
				{
				}
				num = (short)783417345;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x000C9B14 File Offset: 0x000C7D14
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x000C9BD0 File Offset: 0x000C7DD0
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)79429632;
				short num2 = num;
				num = (short)1324752480;
				short num3 = num;
				num = (short)1435639392;
				switch (num3 == num)
				{
				}
				num = (short)490274816;
				if (num != 0)
				{
				}
				num = (short)383582209;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)1987182592;
				short num2 = num;
				num = (short)286901349;
				short num3 = num;
				num = (short)834913381;
				switch (num3 == num)
				{
				}
				num = (short)1600389121;
				if (num != 0)
				{
				}
				num = (short)528875520;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x000C9C88 File Offset: 0x000C7E88
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x000C9D44 File Offset: 0x000C7F44
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)200015872;
				short num2 = num;
				num = (short)1790051883;
				short num3 = num;
				num = (short)183698987;
				switch (num3 == num)
				{
				}
				num = (short)143982593;
				if (num != 0)
				{
				}
				num = (short)1335623680;
				if (num != 0)
				{
				}
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyBLObjectProperty);
			}
			set
			{
				short num = (short)48431104;
				short num2 = num;
				num = (short)59052024;
				short num3 = num;
				num = (short)457445368;
				switch (num3 == num)
				{
				}
				num = (short)837419009;
				if (num != 0)
				{
				}
				num = (short)968556544;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x000C9DF8 File Offset: 0x000C7FF8
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x000C9EB0 File Offset: 0x000C80B0
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)1579286528;
				short num2 = num;
				num = (short)811155142;
				short num3 = num;
				num = (short)2085764806;
				switch (num3 == num)
				{
				}
				num = (short)1080426497;
				if (num != 0)
				{
				}
				num = (short)173670400;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)2105081856;
				short num2 = num;
				num = (short)1769824529;
				short num3 = num;
				num = (short)710107409;
				switch (num3 == num)
				{
				}
				num = (short)336789505;
				if (num != 0)
				{
				}
				num = (short)369360896;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000C9F70 File Offset: 0x000C8170
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x000CA028 File Offset: 0x000C8228
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)1577451520;
				short num2 = num;
				num = (short)941108669;
				short num3 = num;
				num = (short)56503741;
				switch (num3 == num)
				{
				}
				num = (short)581632001;
				if (num != 0)
				{
				}
				num = (short)363855872;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyExpanderProperty);
			}
			set
			{
				short num = (short)594608128;
				short num2 = num;
				num = (short)1585389837;
				short num3 = num;
				num = (short)650387725;
				switch (num3 == num)
				{
				}
				num = (short)915668992;
				if (num != 0)
				{
				}
				num = (short)131203073;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x000CA0E0 File Offset: 0x000C82E0
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x000CA19C File Offset: 0x000C839C
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1865220096;
				short num2 = num;
				num = (short)1986849806;
				short num3 = num;
				num = (short)119204878;
				switch (num3 == num)
				{
				}
				num = (short)737673217;
				if (num != 0)
				{
				}
				num = (short)1926365184;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)978124800;
				short num2 = num;
				num = (short)1793358437;
				short num3 = num;
				num = (short)653294181;
				switch (num3 == num)
				{
				}
				num = (short)814874625;
				if (num != 0)
				{
				}
				num = (short)1773928448;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x000CA254 File Offset: 0x000C8454
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x000CA30C File Offset: 0x000C850C
		public string MaskType
		{
			get
			{
				short num = (short)1072889856;
				short num2 = num;
				num = (short)436039701;
				short num3 = num;
				num = (short)796225557;
				switch (num3 == num)
				{
				}
				num = (short)303497216;
				if (num != 0)
				{
				}
				num = (short)105381889;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MaskTypeProperty);
			}
			set
			{
				short num = (short)212402176;
				short num2 = num;
				num = (short)270224684;
				short num3 = num;
				num = (short)1181437228;
				switch (num3 == num)
				{
				}
				num = (short)1769734145;
				if (num != 0)
				{
				}
				num = (short)1612578816;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MaskTypeProperty, value);
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x000CA3C4 File Offset: 0x000C85C4
		private static void MaskTypePropertyChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			short num = (short)946995200;
			int num2 = (int)((global::System.IntPtr)num);
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G acpTextBox_G;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					if (!string.IsNullOrEmpty((string)args.NewValue))
					{
						num = (short)1427898371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					acpTextBox_G.IsMasked = false;
					num = (short)660013060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					acpTextBox_G = (global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G)sender;
					num = (short)1097859073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)2064357231;
					short num3 = num;
					num = (short)1207146351;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E0;
					}
					break;
				}
				case 4:
					goto IL_A4;
				}
				IL_38:
				num = (short)879558656;
				short num4 = num;
				if (!(sender is global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G))
				{
					break;
				}
				num = (short)303693826;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A4:
			return;
			IL_E0:
			num = (short)39583745;
			if (num != 0)
			{
			}
			num = (short)1201668096;
			if (num != 0)
			{
			}
			acpTextBox_G.IsMasked = true;
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x000CA548 File Offset: 0x000C8748
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x000CA604 File Offset: 0x000C8804
		public bool IsMasked
		{
			get
			{
				short num = (short)1985216512;
				short num2 = num;
				num = (short)1828585473;
				if (num != 0)
				{
				}
				num = (short)1917384869;
				short num3 = num;
				num = (short)446953637;
				switch (num3 == num)
				{
				}
				num = (short)778240000;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsMaskedProperty);
			}
			set
			{
				short num = (short)1561264128;
				short num2 = num;
				num = (short)300583028;
				short num3 = num;
				num = (short)526420084;
				switch (num3 == num)
				{
				}
				num = (short)849215489;
				if (num != 0)
				{
				}
				num = (short)1556414464;
				if (num != 0)
				{
				}
				base.SetValue(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsMaskedProperty, value);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000CA6C0 File Offset: 0x000C88C0
		public AcpTextBox_G()
		{
			base.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
			base.ContextMenu = null;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000CA6E4 File Offset: 0x000C88E4
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTextBox_G()
		{
			int a_ = 0;
			short num = (short)1058734080;
			short num2 = num;
			num = (short)373569024;
			short num3 = num;
			num = (short)470365696;
			switch (num3 == num)
			{
			}
			num = (short)700121088;
			if (num != 0)
			{
			}
			num = (short)920256513;
			if (num != 0)
			{
			}
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("截帬渮到䌲挴嘶唸刺夼", a_), typeof(bool), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("截帬渮到䌲琴䜶䤸场吼尾⁀⅂⥄≆", a_), typeof(bool), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("截帬渮到䌲瀴匶倸伺尼崾ⵀ♂", a_), typeof(bool), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("截帬渮到䌲挴帶䨸刺弼匾⑀", a_), typeof(bool), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("昪听挮倰儲倴嬶稸伺似匾", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("昪听氮帰䌲䰴甶䰸伺䤼倾⽀Bㅄ㕆╈", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("昪听洮細簲圴崶尸堺䤼", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("横弬䨮朰刲头䈶尸䠺砼举㑀≂⥄", a_), typeof(bool), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("昪听樮䤰䌲吴夶崸帺似", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("昪听缮倰䄲倴夶䴸砺䤼䴾ⵀ", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MaskTypeProperty = global::System.Windows.DependencyProperty.Register(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("昪䰬尮娰朲䰴䜶尸", a_), typeof(string), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.MaskTypePropertyChanged)));
			global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G.IsMaskedProperty = global::System.Windows.DependencyProperty.Register(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("截帬戮倰䀲帴制崸", a_), typeof(bool), typeof(global::ControlHeadGraphicView.acpcontrol.AcpTextBox_G), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000F37 RID: 3895
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x04000F38 RID: 3896
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000F39 RID: 3897
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000F3A RID: 3898
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000F3B RID: 3899
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000F3C RID: 3900
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000F3D RID: 3901
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x04000F3E RID: 3902
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000F3F RID: 3903
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x04000F40 RID: 3904
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000F41 RID: 3905
		public static readonly global::System.Windows.DependencyProperty MaskTypeProperty;

		// Token: 0x04000F42 RID: 3906
		public static readonly global::System.Windows.DependencyProperty IsMaskedProperty;
	}
}
