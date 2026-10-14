using System;
using System.Windows;
using System.Windows.Controls;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUI.Common;
using AcpUILib;
using AcpUtility;

namespace AcpUI
{
	// Token: 0x02000011 RID: 17
	public class AcpCopyButton : global::System.Windows.Controls.Button, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIChildCtrlBase
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00013DBC File Offset: 0x00011FBC
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00013E74 File Offset: 0x00012074
		public bool IsAcpValid
		{
			get
			{
				short num = (short)732075544;
				short num2 = num;
				num = (short)321885720;
				switch (num2 == num)
				{
				}
				num = (short)1546190849;
				if (num != 0)
				{
				}
				num = (short)1752301568;
				short num3 = num;
				num = (short)1715339264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCopyButton.IsAcpValidProperty);
			}
			set
			{
				short num = (short)351180872;
				short num2 = num;
				num = (short)481531976;
				switch (num2 == num)
				{
				}
				num = (short)1983905793;
				if (num != 0)
				{
				}
				num = (short)285147136;
				short num3 = num;
				num = (short)1136852992;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCopyButton.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00013F2C File Offset: 0x0001212C
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00013FE4 File Offset: 0x000121E4
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)2122436873;
				short num2 = num;
				num = (short)1355403529;
				switch (num2 == num)
				{
				}
				num = (short)106168321;
				if (num != 0)
				{
				}
				num = (short)1507393536;
				short num3 = num;
				num = (short)1190330368;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCopyButton.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1688687079;
				short num2 = num;
				num = (short)293949927;
				switch (num2 == num)
				{
				}
				num = (short)1635581952;
				if (num != 0)
				{
				}
				num = (short)388431872;
				short num3 = num;
				num = (short)2033582081;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCopyButton.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0001409C File Offset: 0x0001229C
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00014154 File Offset: 0x00012354
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1295337684;
				short num2 = num;
				num = (short)2141931732;
				switch (num2 == num)
				{
				}
				num = (short)1787625472;
				if (num != 0)
				{
				}
				num = (short)1722286080;
				short num3 = num;
				num = (short)1996816385;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCopyButton.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1459711677;
				short num2 = num;
				num = (short)114716349;
				switch (num2 == num)
				{
				}
				num = (short)1531904001;
				if (num != 0)
				{
				}
				num = (short)871890944;
				short num3 = num;
				num = (short)878903296;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCopyButton.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00014210 File Offset: 0x00012410
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000142C8 File Offset: 0x000124C8
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1729627788;
				short num2 = num;
				num = (short)702088844;
				switch (num2 == num)
				{
				}
				num = (short)251854848;
				if (num != 0)
				{
				}
				num = (short)961544192;
				short num3 = num;
				num = (short)1341521921;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCopyButton.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2083419368;
				short num2 = num;
				num = (short)405042408;
				switch (num2 == num)
				{
				}
				num = (short)1699741696;
				if (num != 0)
				{
				}
				num = (short)1399980032;
				short num3 = num;
				num = (short)574881793;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCopyButton.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00014384 File Offset: 0x00012584
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0001443C File Offset: 0x0001263C
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1131093752;
				short num2 = num;
				num = (short)1272061688;
				switch (num2 == num)
				{
				}
				num = (short)80543744;
				if (num != 0)
				{
				}
				num = (short)2074017792;
				short num3 = num;
				num = (short)315424769;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpCopyButton.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1351338718;
				short num2 = num;
				num = (short)2000538334;
				switch (num2 == num)
				{
				}
				num = (short)1932066816;
				if (num != 0)
				{
				}
				num = (short)1660420096;
				short num3 = num;
				num = (short)731906049;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCopyButton.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000144F0 File Offset: 0x000126F0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000145AC File Offset: 0x000127AC
		public global::AcpUILib.IAcpUIParentCtrlBase MyCompCtrl
		{
			get
			{
				short num = (short)139264001;
				if (num != 0)
				{
				}
				num = (short)2077278992;
				short num2 = num;
				num = (short)1805370128;
				switch (num2 == num)
				{
				}
				num = (short)1874919424;
				short num3 = num;
				num = (short)915406848;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpCopyButton.MyCompCtrlProperty);
			}
			set
			{
				short num = (short)1484397566;
				short num2 = num;
				num = (short)254221310;
				switch (num2 == num)
				{
				}
				num = (short)1034616833;
				if (num != 0)
				{
				}
				num = (short)42074112;
				short num3 = num;
				num = (short)2031550464;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCopyButton.MyCompCtrlProperty, value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00014664 File Offset: 0x00012864
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00014720 File Offset: 0x00012920
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)659772056;
				short num2 = num;
				num = (short)1600541336;
				switch (num2 == num)
				{
				}
				num = (short)536936449;
				if (num != 0)
				{
				}
				num = (short)973537280;
				short num3 = num;
				num = (short)975175680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCopyButton.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)301662209;
				if (num != 0)
				{
				}
				num = (short)2103472369;
				short num2 = num;
				num = (short)1547727089;
				switch (num2 == num)
				{
				}
				num = (short)1606221824;
				short num3 = num;
				num = (short)2025390080;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCopyButton.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000147D8 File Offset: 0x000129D8
		internal void AcpCopyButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_9F;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpFieldBase myBLObject;
			global::AcpBusinessLayer.AcpFieldBase myBLObject2;
			for (;;)
			{
				IL_0A:
				num = (short)481624064;
				short num2 = num;
				num = (short)285671425;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					goto IL_29D;
				case 1:
				{
					num = (short)1476158051;
					short num4 = num;
					num = (short)1153655395;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2BD;
					default:
						num = (short)349634560;
						if (num != 0)
						{
						}
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)1149239296;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (myBLObject != null)
					{
						num = (short)1051328522;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(myBLObject2, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unsupported_Value, false);
					num = (short)885915660;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
					num = (short)1603207177;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (myBLObject2 != null)
					{
						num = (short)714276870;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
				{
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.Copy_Value_Of.AcpStringFormat(new object[]
					{
						myBLObject.UIName
					}));
					containerTask.AddTask(myBLObject2.CopyValueOf(myBLObject));
					num = (short)611516430;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
					if (containerTask.Tasks.Count > 0)
					{
						num = (short)1413939204;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F2;
				}
				case 8:
					if (!global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
					{
						num = (short)560988161;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29D;
				case 9:
					goto IL_29D;
				case 10:
					num = (short)8192005;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					return;
				case 12:
					goto IL_2BD;
				case 13:
				{
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
					if (containerTask != null)
					{
						num = (short)2081423375;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F2;
				}
				case 14:
					if (myBLObject2.UnsupportedValue)
					{
						num = (short)931528707;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BD;
				case 15:
					num = (short)207880199;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_9F;
				IL_F2:
				num = (short)236781576;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_29D:
				A_1.Handled = true;
				num = (short)346554379;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BD:
				num = (short)439812109;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_9F:
			myBLObject = this.MyCompCtrl.MyBLObject;
			myBLObject2 = this.MyParentCtrl.MyBLObject;
			num = (short)1281032194;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00014B08 File Offset: 0x00012D08
		public AcpCopyButton()
		{
			base.Loaded += this.AcpCopyButton_Loaded;
			base.Unloaded += this.AcpCopyButton_Unloaded;
			base.ToolTip = global::AcpCommonResources.AcpResources.Copy_Value;
			base.Width = 40.0;
			base.Height = 23.2766666666667;
			base.Margin = new global::System.Windows.Thickness(10.0, 0.0, 10.0, 0.0);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00014B98 File Offset: 0x00012D98
		private void AcpCopyButton_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)277610497;
			if (num != 0)
			{
			}
			num = (short)1663751309;
			short num2 = num;
			num = (short)1290392717;
			switch (num2 == num)
			{
			}
			num = (short)837746688;
			short num3 = num;
			num = (short)441647104;
			if (num != 0)
			{
			}
			base.Click += this.AcpCopyButton_Click;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00014C54 File Offset: 0x00012E54
		private void AcpCopyButton_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)968685556;
			short num2 = num;
			num = (short)1521022964;
			switch (num2 == num)
			{
			}
			num = (short)1918435329;
			if (num != 0)
			{
			}
			num = (short)1019740160;
			short num3 = num;
			num = (short)1681457152;
			if (num != 0)
			{
			}
			base.Click -= this.AcpCopyButton_Click;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00014D10 File Offset: 0x00012F10
		// Note: this type is marked as 'beforefieldinit'.
		static AcpCopyButton()
		{
			int a_ = 15;
			short num = (short)298041610;
			short num2 = num;
			num = (short)1731707146;
			switch (num2 == num)
			{
			}
			num = (short)1294204929;
			if (num != 0)
			{
			}
			num = (short)1242890240;
			short num3 = num;
			num = (short)2125725696;
			if (num != 0)
			{
			}
			global::AcpUI.AcpCopyButton.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("풦좪\uddac瑩킰\udfb2\udcb4펶", a_), typeof(bool), typeof(global::AcpUI.AcpCopyButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCopyButton.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("풦좪\uddac솰쎲\ud9b4\udeb6\udab8\udaba\udfbc펾꓀", a_), typeof(bool), typeof(global::AcpUI.AcpCopyButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCopyButton.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("풦좪\uddac햰\udab2솴횶\udbb8ힺ\ud8bc", a_), typeof(bool), typeof(global::AcpUI.AcpCopyButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCopyButton.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("풦좪\uddac瑩\ud8b0삲\udcb4햶햸\udeba", a_), typeof(bool), typeof(global::AcpUI.AcpCopyButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCopyButton.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udea6令쪪\udfac쪮\udfb0잲쎶쮸ힺ", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpCopyButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpCopyButton.MyCompCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udea6쒪사\udfae잲잴\udbb6", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpCopyButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpCopyButton.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("햦첨ﶪ첬쎮쒰횲운좸캺\udcbc펾", a_), typeof(bool), typeof(global::AcpUI.AcpCopyButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x0400011F RID: 287
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x04000120 RID: 288
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000121 RID: 289
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000122 RID: 290
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000123 RID: 291
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000124 RID: 292
		public static readonly global::System.Windows.DependencyProperty MyCompCtrlProperty;

		// Token: 0x04000125 RID: 293
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;
	}
}
