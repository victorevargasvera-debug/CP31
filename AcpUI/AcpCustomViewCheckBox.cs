using System;
using System.Windows;
using System.Windows.Controls;
using AcpCommonLib;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000012 RID: 18
	public class AcpCustomViewCheckBox : global::System.Windows.Controls.CheckBox, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIChildCtrlBase
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00014F54 File Offset: 0x00013154
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00015010 File Offset: 0x00013210
		public bool IsAcpValid
		{
			get
			{
				short num = (short)1708119055;
				short num2 = num;
				num = (short)1142281231;
				switch (num2 == num)
				{
				}
				num = (short)1084751873;
				if (num != 0)
				{
				}
				num = (short)1939931136;
				short num3 = num;
				num = (short)465043456;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCustomViewCheckBox.IsAcpValidProperty);
			}
			set
			{
				short num = (short)657981441;
				if (num != 0)
				{
				}
				num = (short)1321834174;
				short num2 = num;
				num = (short)1333302974;
				switch (num2 == num)
				{
				}
				num = (short)704249856;
				short num3 = num;
				num = (short)2124349440;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCustomViewCheckBox.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000150CC File Offset: 0x000132CC
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00015188 File Offset: 0x00013388
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1566702389;
				short num2 = num;
				num = (short)1686240053;
				switch (num2 == num)
				{
				}
				num = (short)1349648384;
				if (num != 0)
				{
				}
				num = (short)1692729344;
				short num3 = num;
				num = (short)778960897;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCustomViewCheckBox.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)307172536;
				short num2 = num;
				num = (short)1224938680;
				switch (num2 == num)
				{
				}
				num = (short)1058013184;
				if (num != 0)
				{
				}
				num = (short)854458368;
				short num3 = num;
				num = (short)771096577;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCustomViewCheckBox.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00015244 File Offset: 0x00013444
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00015304 File Offset: 0x00013504
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)458336034;
				short num2 = num;
				num = (short)231319330;
				switch (num2 == num)
				{
				}
				num = (short)1807089664;
				short num3 = num;
				num = (short)366280705;
				if (num != 0)
				{
				}
				num = (short)2062548992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCustomViewCheckBox.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1496121345;
				if (num != 0)
				{
				}
				num = (short)1679370565;
				short num2 = num;
				num = (short)449980741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1204092928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)156565504;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCustomViewCheckBox.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000153C0 File Offset: 0x000135C0
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00015478 File Offset: 0x00013678
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)2143592734;
				short num2 = num;
				num = (short)1545117982;
				switch (num2 == num)
				{
				}
				num = (short)1653800960;
				short num3 = num;
				num = (short)479854593;
				if (num != 0)
				{
				}
				num = (short)1930821632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCustomViewCheckBox.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)959036040;
				short num2 = num;
				num = (short)156285576;
				switch (num2 == num)
				{
				}
				num = (short)518324224;
				short num3 = num;
				num = (short)929497089;
				if (num != 0)
				{
				}
				num = (short)1679163392;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCustomViewCheckBox.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00015534 File Offset: 0x00013734
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000155EC File Offset: 0x000137EC
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)667895252;
				short num2 = num;
				num = (short)873678292;
				switch (num2 == num)
				{
				}
				num = (short)156499968;
				short num3 = num;
				num = (short)1555955713;
				if (num != 0)
				{
				}
				num = (short)2117009408;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpCustomViewCheckBox.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)802357249;
				if (num != 0)
				{
				}
				num = (short)1702392767;
				short num2 = num;
				num = (short)1679455167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1189150720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526254080;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCustomViewCheckBox.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000156A4 File Offset: 0x000138A4
		public AcpCustomViewCheckBox()
		{
			base.Loaded += this.AcpCustomViewCheckBox_Loaded;
			base.Unloaded += this.AcpCustomViewCheckBox_Unloaded;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000156DC File Offset: 0x000138DC
		private void AcpCustomViewCheckBox_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)200212481;
			if (num != 0)
			{
			}
			num = (short)376121962;
			short num2 = num;
			num = (short)401091178;
			switch (num2 == num)
			{
			default:
			{
				num = (short)179568640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)666894336;
			if (num != 0)
			{
			}
			base.Click += this.AcpCustomViewCheckBox_Click;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00015798 File Offset: 0x00013998
		private void AcpCustomViewCheckBox_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)476113660;
			short num2 = num;
			num = (short)237562620;
			switch (num2 == num)
			{
			}
			num = (short)643956736;
			short num3 = num;
			num = (short)865796096;
			if (num != 0)
			{
			}
			num = (short)677445633;
			if (num != 0)
			{
			}
			base.Click -= this.AcpCustomViewCheckBox_Click;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00015854 File Offset: 0x00013A54
		private void AcpCustomViewCheckBox_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)297598982;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					bool? isChecked;
					if (isChecked.Value)
					{
						num = (short)1189740546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpCommonLib.IAcpField)this.MyParentCtrl.MyBLObject).CustomViewVisibility = false;
					num = (short)495779848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (this.MyParentCtrl.MyBLObject != null)
					{
						num = (short)622985221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B8;
				case 2:
					((global::AcpCommonLib.IAcpField)this.MyParentCtrl.MyBLObject).CustomViewVisibility = true;
					num = (short)165871620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1B8;
				case 4:
					goto IL_150;
				case 5:
				{
					bool? isChecked = base.IsChecked;
					num = (short)1591934976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					num = (short)142999553;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 7:
					num = (short)1166737409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_150;
				}
				IL_70:
				num = (short)501940224;
				short num3 = num;
				if (this.MyParentCtrl != null)
				{
					num = (short)81330183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1B8;
				IL_150:
				A_1.Handled = true;
				num = (short)1306394627;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B8:
				num = (short)1099450051;
				short num4 = num;
				num = (short)2028095171;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1EF;
				}
			}
			IL_1EF:
			num = (short)1493565440;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00015A68 File Offset: 0x00013C68
		// Note: this type is marked as 'beforefieldinit'.
		static AcpCustomViewCheckBox()
		{
			int a_ = 5;
			short num = (short)689842498;
			short num2 = num;
			num = (short)95693122;
			switch (num2 == num)
			{
			}
			num = (short)753664000;
			short num3 = num;
			num = (short)1611923457;
			if (num != 0)
			{
			}
			num = (short)687079424;
			if (num != 0)
			{
			}
			global::AcpUI.AcpCustomViewCheckBox.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("튚\ude9e슠펢욦얨슪즬", a_), typeof(bool), typeof(global::AcpUI.AcpCustomViewCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCustomViewCheckBox.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("튚\ude9e슠펢힦\ud9a8잪쒬첮킰톲\ud9b4튶", a_), typeof(bool), typeof(global::AcpUI.AcpCustomViewCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCustomViewCheckBox.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("튚\ude9e슠펢쎦삨\udfaa첬춮\uddb0횲", a_), typeof(bool), typeof(global::AcpUI.AcpCustomViewCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCustomViewCheckBox.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("튚\ude9e슠펢캦\udaa8슪쾬쎮풰", a_), typeof(bool), typeof(global::AcpUI.AcpCustomViewCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCustomViewCheckBox.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("횚쾞삠톢삤즦\udda8\ud9ac\uddae\uddb0", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpCustomViewCheckBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000126 RID: 294
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x04000127 RID: 295
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000128 RID: 296
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000129 RID: 297
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x0400012A RID: 298
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;
	}
}
