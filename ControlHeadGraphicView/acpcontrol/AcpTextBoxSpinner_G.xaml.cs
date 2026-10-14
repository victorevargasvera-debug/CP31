using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUILib;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView.acpcontrol
{
	// Token: 0x02000015 RID: 21
	public partial class AcpTextBoxSpinner_G : UserControl, IAcpUICtrlBase, IAcpUIValueCtrlBase<string>, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon
	{
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x000C7594 File Offset: 0x000C5794
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x000C7640 File Offset: 0x000C5840
		public string Value
		{
			get
			{
				short num = (short)989253174;
				short num2 = num;
				num = (short)476237366;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2142175232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1940520961;
				if (num != 0)
				{
				}
				num = (short)1634467840;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)1930231809;
				if (num != 0)
				{
				}
				num = (short)673906688;
				short num2 = num;
				num = (short)215525753;
				short num3 = num;
				num = (short)1485744505;
				switch (num3 == num)
				{
				}
				num = (short)1669005312;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x000C76F0 File Offset: 0x000C58F0
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x000C77A8 File Offset: 0x000C59A8
		public bool IsAcpValid
		{
			get
			{
				short num = (short)451558538;
				short num2 = num;
				num = (short)53492874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)428802048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)328073216;
				if (num != 0)
				{
				}
				num = (short)44105729;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner_G.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1319698433;
				if (num != 0)
				{
				}
				num = (short)1349648384;
				short num2 = num;
				num = (short)438292064;
				short num3 = num;
				num = (short)528928352;
				switch (num3 == num)
				{
				}
				num = (short)1015218176;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x000C7864 File Offset: 0x000C5A64
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x000C791C File Offset: 0x000C5B1C
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1230942047;
				short num2 = num;
				num = (short)1761652575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1540816896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1984233473;
				if (num != 0)
				{
				}
				num = (short)425132032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner_G.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)342238895;
				short num2 = num;
				num = (short)1821976239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)739770368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1730215937;
				if (num != 0)
				{
				}
				num = (short)2095906816;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x000C79D4 File Offset: 0x000C5BD4
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x000C7A8C File Offset: 0x000C5C8C
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1853402324;
				short num2 = num;
				num = (short)29273300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1340276736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)529268737;
				if (num != 0)
				{
				}
				num = (short)1820786688;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner_G.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1788066658;
				short num2 = num;
				num = (short)706919266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)767623168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966524929;
				if (num != 0)
				{
				}
				num = (short)1921318912;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x000C7B48 File Offset: 0x000C5D48
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x000C7C00 File Offset: 0x000C5E00
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1733754881;
				if (num != 0)
				{
				}
				num = (short)1376256;
				short num2 = num;
				num = (short)780693900;
				short num3 = num;
				num = (short)1647735180;
				switch (num3 == num)
				{
				}
				num = (short)2131886080;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner_G.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)862867399;
				short num2 = num;
				num = (short)427315143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1202257920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)910557185;
				if (num != 0)
				{
				}
				num = (short)2021851136;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x000C7CBC File Offset: 0x000C5EBC
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x000C7D74 File Offset: 0x000C5F74
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)292305085;
				short num2 = num;
				num = (short)1493055677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)783613952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1150812160;
				if (num != 0)
				{
				}
				num = (short)94306305;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxSpinner_G.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1745931020;
				short num2 = num;
				num = (short)1773783820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1638531072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676003840;
				if (num != 0)
				{
				}
				num = (short)1501691905;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x000C7E2C File Offset: 0x000C602C
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x000C7EE8 File Offset: 0x000C60E8
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)2147941;
				short num2 = num;
				num = (short)1082377829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1227620352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)393871361;
				if (num != 0)
				{
				}
				num = (short)594214912;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxSpinner_G.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)503382450;
				short num2 = num;
				num = (short)994640306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1186791424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577961985;
				if (num != 0)
				{
				}
				num = (short)1415053312;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x000C7F9C File Offset: 0x000C619C
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x000C8054 File Offset: 0x000C6254
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1574330362;
				short num2 = num;
				num = (short)1925603322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1186398208;
				if (num != 0)
				{
				}
				num = (short)1621032961;
				if (num != 0)
				{
				}
				return (AcpFieldBase)base.GetValue(AcpTextBoxSpinner_G.MyBLObjectProperty);
			}
			set
			{
				short num = (short)245572137;
				short num2 = num;
				num = (short)770449961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)473432064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963248129;
				if (num != 0)
				{
				}
				num = (short)1650065408;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x000C8108 File Offset: 0x000C6308
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x000C81C0 File Offset: 0x000C63C0
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)2079463534;
				short num2 = num;
				num = (short)1157109870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536098304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1558118401;
				if (num != 0)
				{
				}
				num = (short)1952645120;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner_G.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)569245697;
				if (num != 0)
				{
				}
				num = (short)1524629504;
				short num2 = num;
				num = (short)1391492216;
				short num3 = num;
				num = (short)1869249656;
				switch (num3 == num)
				{
				}
				num = (short)483262464;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x000C8278 File Offset: 0x000C6478
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x000C8330 File Offset: 0x000C6530
		public Expander MyExpander
		{
			get
			{
				short num = (short)1435811484;
				short num2 = num;
				num = (short)488554140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)654508032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1823277057;
				if (num != 0)
				{
				}
				num = (short)779288576;
				if (num != 0)
				{
				}
				return (Expander)base.GetValue(AcpTextBoxSpinner_G.MyExpanderProperty);
			}
			set
			{
				short num = (short)1646724779;
				short num2 = num;
				num = (short)1783498411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2141454336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1167982593;
				if (num != 0)
				{
				}
				num = (short)1692729344;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x000C83E8 File Offset: 0x000C65E8
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x000C84A4 File Offset: 0x000C66A4
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)212096001;
				short num2 = num;
				num = (short)474895361;
				switch (num2 == num)
				{
				default:
				{
					num = (short)832307200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)562495489;
				if (num != 0)
				{
				}
				num = (short)1545535488;
				if (num != 0)
				{
				}
				return (IAcpUIParentCtrlBase)base.GetValue(AcpTextBoxSpinner_G.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1858622417;
				short num2 = num;
				num = (short)410080209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)368377856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2142568448;
				if (num != 0)
				{
				}
				num = (short)1321992193;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x000C8558 File Offset: 0x000C6758
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x000C8610 File Offset: 0x000C6810
		public string Text
		{
			get
			{
				short num = (short)1766326273;
				if (num != 0)
				{
				}
				num = (short)1350565888;
				short num2 = num;
				num = (short)2137799011;
				short num3 = num;
				num = (short)301152611;
				switch (num3 == num)
				{
				}
				num = (short)5111808;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTextBoxSpinner_G.TextProperty);
			}
			set
			{
				short num = (short)1865412446;
				short num2 = num;
				num = (short)2129588062;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1725038592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)997785600;
				if (num != 0)
				{
				}
				num = (short)492699649;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner_G.TextProperty, value);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x000C86C4 File Offset: 0x000C68C4
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x000C8784 File Offset: 0x000C6984
		public string MaskTypeSpinner
		{
			get
			{
				if (AcpTextBoxSpinner_G.DisableMask)
				{
					short num = (short)255473392;
					short num2 = num;
					num = (short)1478440688;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)826343424;
						short num3 = num;
						num = (short)2032861185;
						if (num != 0)
						{
						}
						num = (short)435224576;
						if (num != 0)
						{
						}
						break;
					}
					}
					return null;
				}
				return this.maskTypeSpinner;
			}
			set
			{
				short num = (short)995604154;
				short num2 = num;
				num = (short)1611249338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589772288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1175060481;
				if (num != 0)
				{
				}
				num = (short)808452096;
				if (num != 0)
				{
				}
				this.maskTypeSpinner = value;
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x000C8834 File Offset: 0x000C6A34
		private void OnLostFocus(object sender, RoutedEventArgs e)
		{
			short num = (short)925343291;
			short num2 = num;
			num = (short)929734203;
			switch (num2 == num)
			{
			default:
			{
				num = (short)848166912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)163643392;
			if (num != 0)
			{
			}
			num = (short)737673217;
			if (num != 0)
			{
			}
			this.Text = this.AcpTextBoxMember.Text;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000C88F0 File Offset: 0x000C6AF0
		private void AcpTextBoxSpinner_GotFocus(object sender, RoutedEventArgs e)
		{
			short num = (short)1738569427;
			short num2 = num;
			num = (short)1990883027;
			switch (num2 == num)
			{
			default:
			{
				num = (short)94961664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2000027649;
			if (num != 0)
			{
			}
			num = (short)1997144064;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000C899C File Offset: 0x000C6B9C
		public AcpTextBoxSpinner_G()
		{
			this.InitializeComponent();
			base.Focusable = true;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000C89BC File Offset: 0x000C6BBC
		internal static void MyOnClick(object sender, AcpFieldBase myBLObject)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_7E;
			}
			short num;
			int num3;
			RepeatButton repeatButton;
			IAcpRangeField acpRangeField;
			for (;;)
			{
				IL_13:
				num = (short)1713339496;
				short num2 = num;
				num = (short)1882946664;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1513947136;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (repeatButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("樭弯䔱娳电吷匹弻唽", a_), StringComparison.Ordinal))
						{
							num = (short)1173094402;
							num3 = (int)((IntPtr)num);
							continue;
						}
						acpRangeField.StepUp();
						num = (short)1819148293;
						num3 = (int)((IntPtr)num);
						continue;
					case 1:
						if (acpRangeField != null)
						{
							num = (short)1759969283;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_13B;
					case 3:
					{
						num = (short)317849600;
						short num4 = num;
						num = (short)1061617664;
						num3 = (int)((IntPtr)num);
						continue;
					}
					case 4:
						num = (short)2091319297;
						num3 = (int)((IntPtr)num);
						continue;
					case 5:
						return;
					case 6:
						num = (short)1547501569;
						if (num != 0)
						{
						}
						if (repeatButton != null)
						{
							num = (short)673447940;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_7E;
				}
			}
			IL_13B:
			acpRangeField.StepDown();
			return;
			IL_7E:
			repeatButton = (sender as RepeatButton);
			acpRangeField = (myBLObject as IAcpRangeField);
			num = (short)802619398;
			num3 = (int)((IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000C8B88 File Offset: 0x000C6D88
		private void OnClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1481048064;
			short num2 = num;
			num = (short)77721354;
			short num3 = num;
			num = (short)1719136010;
			switch (num3 == num)
			{
			}
			num = (short)2134638593;
			if (num != 0)
			{
			}
			num = (short)778371072;
			if (num != 0)
			{
			}
			AcpTextBoxSpinner_G.MyOnClick(sender, this.MyBLObject);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000C8F48 File Offset: 0x000C7148
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTextBoxSpinner_G()
		{
			int a_ = 8;
			short num = (short)1143865344;
			short num2 = num;
			num = (short)1647065049;
			short num3 = num;
			num = (short)1226717145;
			switch (num3 == num)
			{
			}
			num = (short)342818816;
			if (num != 0)
			{
			}
			num = (short)2052063233;
			if (num != 0)
			{
			}
			AcpTextBoxSpinner_G.IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("稲䘴瘶娸䬺欼帾ⵀ⩂⅄", a_), typeof(bool), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner_G.IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("稲䘴瘶娸䬺簼伾ㅀ⽂ⱄ⑆⡈⥊⅌⩎", a_), typeof(bool), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner_G.IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("稲䘴瘶娸䬺砼嬾⡀㝂⑄╆╈⹊", a_), typeof(bool), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner_G.IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("稲䘴瘶娸䬺欼嘾㉀⩂❄⭆ⱈ", a_), typeof(bool), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner_G.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(O9GraphicviewMenuItemsVisibilityConverter.b("縲䰴笶堸夺堼匾ɀ㝂㝄⭆", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner_G.MyCopyButtonProperty = DependencyProperty.RegisterAttached(O9GraphicviewMenuItemsVisibilityConverter.b("縲䰴琶嘸䬺䐼紾㑀㝂ㅄ⡆❈ࡊ㥌㵎㵐", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner_G.MyBLObjectProperty = DependencyProperty.RegisterAttached(O9GraphicviewMenuItemsVisibilityConverter.b("縲䰴甶甸琺弼唾⑀⁂ㅄ", a_), typeof(AcpFieldBase), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner_G.AreValuesEqualProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("爲䜴制漸娺儼䨾⑀あD㙆㱈⩊⅌", a_), typeof(bool), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner_G.MyExpanderProperty = DependencyProperty.RegisterAttached(O9GraphicviewMenuItemsVisibilityConverter.b("縲䰴父䄸䬺尼儾╀♂㝄", a_), typeof(Expander), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner_G.MyParentCtrlProperty = DependencyProperty.RegisterAttached(O9GraphicviewMenuItemsVisibilityConverter.b("縲䰴朶堸䤺堼儾㕀Bㅄ㕆╈", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner_G.TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("朲倴伶䴸", a_), typeof(string), typeof(AcpTextBoxSpinner_G), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner_G.DisableMask = false;
		}

		// Token: 0x04000F26 RID: 3878
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x04000F27 RID: 3879
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000F28 RID: 3880
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000F29 RID: 3881
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000F2A RID: 3882
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000F2B RID: 3883
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000F2C RID: 3884
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x04000F2D RID: 3885
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000F2E RID: 3886
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x04000F2F RID: 3887
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000F30 RID: 3888
		public static readonly DependencyProperty TextProperty;

		// Token: 0x04000F31 RID: 3889
		private string maskTypeSpinner;

		// Token: 0x04000F32 RID: 3890
		public static bool DisableMask;
	}
}
