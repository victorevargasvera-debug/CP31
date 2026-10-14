using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200000E RID: 14
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class InputBaseControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000B510 File Offset: 0x00009710
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)73859072;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num3;
			global::DevComponents.WpfEditors.InputBaseControl inputBaseControl;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					goto IL_A0;
				case 1:
				{
					num = (short)280842491;
					short num4 = num;
					num = (short)224874747;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					default:
						goto IL_10F;
					}
					break;
				}
				case 2:
					num = (short)521404417;
					if (num != 0)
					{
					}
					if (inputBaseControl != null)
					{
						num = (short)1992622080;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_44;
				IL_A0:
				inputBaseControl.OnShowCheckBoxChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
				num = (short)650117121;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			num = (short)72220672;
			if (num != 0)
			{
			}
			return;
			IL_44:
			inputBaseControl = (A_0 as global::DevComponents.WpfEditors.InputBaseControl);
			num = (short)2014969858;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000B644 File Offset: 0x00009844
		protected virtual void OnShowCheckBoxChanged(bool oldValue, bool newValue)
		{
			short num = (short)1530776090;
			short num2 = num;
			num = (short)1344719386;
			switch (num2 == num)
			{
			}
			num = (short)1387397120;
			if (num != 0)
			{
			}
			num = (short)1319108608;
			short num3 = num;
			num = (short)1664811009;
			if (num != 0)
			{
			}
			this.UpdateLockUpdateCheckBox();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000B6F0 File Offset: 0x000098F0
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000B7A8 File Offset: 0x000099A8
		public bool ShowCheckBox
		{
			get
			{
				short num = (short)103264195;
				short num2 = num;
				num = (short)1153347523;
				switch (num2 == num)
				{
				}
				num = (short)336396289;
				if (num != 0)
				{
				}
				num = (short)1446248448;
				short num3 = num;
				num = (short)1927086080;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.ShowCheckBoxProperty);
			}
			set
			{
				short num = (short)1079688750;
				short num2 = num;
				num = (short)964804142;
				switch (num2 == num)
				{
				}
				num = (short)2046230529;
				if (num != 0)
				{
				}
				num = (short)257753088;
				short num3 = num;
				num = (short)744357888;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.ShowCheckBoxProperty, value);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000B864 File Offset: 0x00009A64
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1696268288;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num3;
			global::DevComponents.WpfEditors.InputBaseControl inputBaseControl;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					goto IL_A1;
				case 1:
				{
					num = (short)561548361;
					short num4 = num;
					num = (short)250514505;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A1;
					default:
						goto IL_10D;
					}
					break;
				}
				case 2:
					if (inputBaseControl != null)
					{
						num = (short)328138752;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_44;
				IL_A1:
				inputBaseControl.OnLockUpdateCheckedChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
				num = (short)481034241;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10D:
			num = (short)2059665408;
			if (num != 0)
			{
			}
			return;
			IL_44:
			num = (short)643825665;
			if (num != 0)
			{
			}
			inputBaseControl = (A_0 as global::DevComponents.WpfEditors.InputBaseControl);
			num = (short)563150850;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000B998 File Offset: 0x00009B98
		protected virtual void OnLockUpdateCheckedChanged(bool oldValue, bool newValue)
		{
			short num = (short)269221890;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)740622336;
					short num3 = num;
					this.a.IsChecked = new bool?(newValue);
					num = (short)1674969089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_C6;
				case 2:
					num = (short)807993345;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				if (this.a == null)
				{
					break;
				}
				num = (short)737935360;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C6:
			num = (short)1922765213;
			short num4 = num;
			num = (short)2002784669;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C6;
			default:
				num = (short)510984192;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000BB70 File Offset: 0x00009D70
		public bool LockUpdateChecked
		{
			get
			{
				short num = (short)614722861;
				short num2 = num;
				num = (short)1484057901;
				switch (num2 == num)
				{
				}
				num = (short)869138432;
				if (num != 0)
				{
				}
				num = (short)427687936;
				short num3 = num;
				num = (short)686096385;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.LockUpdateCheckedProperty);
			}
			set
			{
				short num = (short)608632833;
				if (num != 0)
				{
				}
				num = (short)1135305914;
				short num2 = num;
				num = (short)1119773882;
				switch (num2 == num)
				{
				}
				num = (short)538705920;
				short num3 = num;
				num = (short)1989476352;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.LockUpdateCheckedProperty, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600007A RID: 122 RVA: 0x0000BC2C File Offset: 0x00009E2C
		// (remove) Token: 0x0600007B RID: 123 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		public event global::System.Windows.RoutedEventHandler LockUpdateChanged
		{
			add
			{
				short num = (short)1395698937;
				short num2 = num;
				num = (short)554872057;
				switch (num2 == num)
				{
				}
				num = (short)408420353;
				if (num != 0)
				{
				}
				num = (short)1045168128;
				short num3 = num;
				num = (short)992870400;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.InputBaseControl.LockUpdateChangedEvent, value);
			}
			remove
			{
				short num = (short)392522236;
				short num2 = num;
				num = (short)261974524;
				switch (num2 == num)
				{
				}
				num = (short)222101505;
				if (num != 0)
				{
				}
				num = (short)483131392;
				short num3 = num;
				num = (short)1465909248;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.InputBaseControl.LockUpdateChangedEvent, value);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000BD94 File Offset: 0x00009F94
		protected virtual void OnLockUpdateChanged(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)141271918;
			short num2 = num;
			num = (short)781820782;
			switch (num2 == num)
			{
			}
			num = (short)243531777;
			if (num != 0)
			{
			}
			num = (short)1162280960;
			short num3 = num;
			num = (short)1592197120;
			if (num != 0)
			{
			}
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000BE44 File Offset: 0x0000A044
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000BEFC File Offset: 0x0000A0FC
		public bool IsReadOnly
		{
			get
			{
				short num = (short)675365578;
				short num2 = num;
				num = (short)1753039562;
				switch (num2 == num)
				{
				}
				num = (short)364183553;
				if (num != 0)
				{
				}
				num = (short)1129906176;
				short num3 = num;
				num = (short)325910528;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.IsReadOnlyProperty);
			}
			set
			{
				short num = (short)894700539;
				short num2 = num;
				num = (short)2146831355;
				switch (num2 == num)
				{
				}
				num = (short)1655242753;
				if (num != 0)
				{
				}
				num = (short)7602176;
				short num3 = num;
				num = (short)1869742080;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1214633479;
			short num2 = num;
			num = (short)2099172871;
			switch (num2 == num)
			{
			}
			num = (short)1827209217;
			if (num != 0)
			{
			}
			num = (short)339935232;
			short num3 = num;
			num = (short)504430592;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000C060 File Offset: 0x0000A260
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000C11C File Offset: 0x0000A31C
		public bool AutoOverwrite
		{
			get
			{
				short num = (short)132287887;
				short num2 = num;
				num = (short)1144819087;
				switch (num2 == num)
				{
				}
				num = (short)1990066177;
				if (num != 0)
				{
				}
				num = (short)1730871296;
				short num3 = num;
				num = (short)1675755520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.AutoOverwriteProperty);
			}
			set
			{
				short num = (short)583482267;
				short num2 = num;
				num = (short)1391213467;
				switch (num2 == num)
				{
				}
				num = (short)465043457;
				if (num != 0)
				{
				}
				num = (short)930938880;
				short num3 = num;
				num = (short)1547763712;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.AutoOverwriteProperty, value);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)2030764032;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num3;
			global::DevComponents.WpfEditors.InputBaseControl inputBaseControl;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					goto IL_79;
				case 1:
				{
					num = (short)1959828730;
					short num4 = num;
					num = (short)1476959482;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_79;
					default:
						goto IL_10C;
					}
					break;
				}
				case 2:
					if (inputBaseControl != null)
					{
						num = (short)461701120;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_44;
				IL_79:
				inputBaseControl.OnButtonCustomChanged((global::DevComponents.WpfEditors.InputButtonSettings)A_1.OldValue, (global::DevComponents.WpfEditors.InputButtonSettings)A_1.NewValue);
				num = (short)1149042689;
				if (num != 0)
				{
				}
				num = (short)958464001;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			num = (short)1379729408;
			if (num != 0)
			{
			}
			return;
			IL_44:
			inputBaseControl = (A_0 as global::DevComponents.WpfEditors.InputBaseControl);
			num = (short)154206210;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000C308 File Offset: 0x0000A508
		protected virtual void OnButtonCustomChanged(global::DevComponents.WpfEditors.InputButtonSettings oldValue, global::DevComponents.WpfEditors.InputButtonSettings newValue)
		{
			short num = (short)146014208;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 1:
				{
					num = (short)880164173;
					short num3 = num;
					num = (short)387595597;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_218;
					default:
						num = (short)1783169024;
						if (num != 0)
						{
						}
						num = (short)1361903618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (inputGroup.Items.Contains(oldValue.ButtonReference))
					{
						num = (short)660471812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BF;
				case 3:
					num = (short)414646280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					inputGroup.Items.Remove(oldValue.ButtonReference);
					num = (short)624033802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1FF;
				case 6:
					if (newValue != null)
					{
						num = (short)54919179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_268;
				case 7:
					if (oldValue.ButtonReference != null)
					{
						num = (short)1032978435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BF;
				case 8:
					goto IL_218;
				case 9:
					num = (short)702742529;
					if (num != 0)
					{
					}
					oldValue.Parent = null;
					inputGroup = this.GetInputGroup();
					num = (short)2080636935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_BF;
				case 11:
					newValue.Parent = this;
					newValue.ButtonReference = this.a();
					num = (short)49086469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_54:
				num = (short)1987969024;
				short num4 = num;
				if (oldValue != null)
				{
					num = (short)1397096457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BF:
				num = (short)471072774;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_218:
				if (inputGroup == null)
				{
					goto IL_BF;
				}
				num = (short)856817665;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1FF:
			IL_268:
			this.RecreateButtons();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000C584 File Offset: 0x0000A784
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000C640 File Offset: 0x0000A840
		public global::DevComponents.WpfEditors.InputButtonSettings ButtonCustom
		{
			get
			{
				short num = (short)711737351;
				short num2 = num;
				num = (short)1986019335;
				switch (num2 == num)
				{
				}
				num = (short)583204864;
				if (num != 0)
				{
				}
				num = (short)393609216;
				short num3 = num;
				num = (short)328597505;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.InputButtonSettings)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustomProperty);
			}
			set
			{
				short num = (short)1297421250;
				short num2 = num;
				num = (short)1576473538;
				switch (num2 == num)
				{
				}
				num = (short)1170472960;
				if (num != 0)
				{
				}
				num = (short)1260519424;
				short num3 = num;
				num = (short)479789057;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustomProperty, value);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1639579648;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num3;
			global::DevComponents.WpfEditors.InputBaseControl inputBaseControl;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					goto IL_7B;
				case 1:
				{
					num = (short)889387641;
					short num4 = num;
					num = (short)1242430073;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
						goto IL_10D;
					}
					break;
				}
				case 2:
					if (inputBaseControl != null)
					{
						num = (short)1294598144;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_45;
				IL_7B:
				inputBaseControl.OnButtonCustom2Changed((global::DevComponents.WpfEditors.InputButtonSettings)A_1.OldValue, (global::DevComponents.WpfEditors.InputButtonSettings)A_1.NewValue);
				num = (short)14680065;
				if (num != 0)
				{
				}
				num = (short)685965313;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10D:
			num = (short)2083913728;
			if (num != 0)
			{
			}
			return;
			IL_45:
			inputBaseControl = (A_0 as global::DevComponents.WpfEditors.InputBaseControl);
			num = (short)147587074;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000C828 File Offset: 0x0000AA28
		protected virtual void OnButtonCustom2Changed(global::DevComponents.WpfEditors.InputButtonSettings oldValue, global::DevComponents.WpfEditors.InputButtonSettings newValue)
		{
			short num = (short)153681920;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 1:
				{
					num = (short)883652315;
					short num3 = num;
					num = (short)1203140315;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_222;
					default:
						num = (short)1083899904;
						if (num != 0)
						{
						}
						num = (short)1454178306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (inputGroup.Items.Contains(oldValue.ButtonReference))
					{
						num = (short)547684356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 3:
					num = (short)800522241;
					if (num != 0)
					{
					}
					num = (short)459538440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					inputGroup.Items.Remove(oldValue.ButtonReference);
					num = (short)758972426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1E0;
				case 6:
					if (newValue != null)
					{
						num = (short)1019871243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_273;
				case 7:
					if (oldValue.ButtonReference != null)
					{
						num = (short)688979971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 8:
					goto IL_222;
				case 9:
					oldValue.Parent = null;
					inputGroup = this.GetInputGroup();
					num = (short)1098121223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_9C;
				case 11:
					newValue.Parent = this;
					newValue.ButtonReference = this.a();
					num = (short)249561093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_55:
				num = (short)922288128;
				short num4 = num;
				if (oldValue != null)
				{
					num = (short)2074214409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9C:
				num = (short)1744830470;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_222:
				if (inputGroup == null)
				{
					goto IL_9C;
				}
				num = (short)1800994817;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E0:
			IL_273:
			this.RecreateButtons();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000CB68 File Offset: 0x0000AD68
		public global::DevComponents.WpfEditors.InputButtonSettings ButtonCustom2
		{
			get
			{
				short num = (short)776208433;
				short num2 = num;
				num = (short)1449132081;
				switch (num2 == num)
				{
				}
				num = (short)1604976640;
				if (num != 0)
				{
				}
				num = (short)2020868096;
				short num3 = num;
				num = (short)628293633;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.InputButtonSettings)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustom2Property);
			}
			set
			{
				short num = (short)605459366;
				short num2 = num;
				num = (short)734696358;
				switch (num2 == num)
				{
				}
				num = (short)1818427393;
				if (num != 0)
				{
				}
				num = (short)55508992;
				short num3 = num;
				num = (short)239730688;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustom2Property, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600008A RID: 138 RVA: 0x0000CC20 File Offset: 0x0000AE20
		// (remove) Token: 0x0600008B RID: 139 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		public event global::System.Windows.RoutedEventHandler ButtonCustomClick
		{
			add
			{
				short num = (short)1104669776;
				short num2 = num;
				num = (short)1915415632;
				switch (num2 == num)
				{
				}
				num = (short)1052114945;
				if (num != 0)
				{
				}
				num = (short)1974992896;
				short num3 = num;
				num = (short)224264192;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustomClickEvent, value);
			}
			remove
			{
				short num = (short)2094644849;
				short num2 = num;
				num = (short)457096817;
				switch (num2 == num)
				{
				}
				num = (short)1909653505;
				if (num != 0)
				{
				}
				num = (short)403243008;
				short num3 = num;
				num = (short)1398079488;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustomClickEvent, value);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000CD90 File Offset: 0x0000AF90
		protected virtual void OnButtonCustomClick(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)126297883;
			short num2 = num;
			num = (short)186328859;
			switch (num2 == num)
			{
			}
			num = (short)1893859329;
			if (num != 0)
			{
			}
			num = (short)1453588480;
			short num3 = num;
			num = (short)35323904;
			if (num != 0)
			{
			}
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600008D RID: 141 RVA: 0x0000CE44 File Offset: 0x0000B044
		// (remove) Token: 0x0600008E RID: 142 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		public event global::System.Windows.RoutedEventHandler ButtonCustom2Click
		{
			add
			{
				short num = (short)183212914;
				short num2 = num;
				num = (short)319265650;
				switch (num2 == num)
				{
				}
				num = (short)1088487425;
				if (num != 0)
				{
				}
				num = (short)1473445888;
				if (num != 0)
				{
				}
				num = (short)1463156736;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustom2ClickEvent, value);
			}
			remove
			{
				short num = (short)1781586398;
				short num2 = num;
				num = (short)530307550;
				switch (num2 == num)
				{
				}
				num = (short)1958019073;
				if (num != 0)
				{
				}
				num = (short)803471360;
				if (num != 0)
				{
				}
				num = (short)30867456;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustom2ClickEvent, value);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000CFB0 File Offset: 0x0000B1B0
		protected virtual void OnButtonCustom2Click(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)1900016886;
			short num2 = num;
			num = (short)450491638;
			switch (num2 == num)
			{
			}
			num = (short)2134441985;
			if (num != 0)
			{
			}
			num = (short)1435893760;
			if (num != 0)
			{
			}
			num = (short)1844772864;
			short num3 = num;
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000D060 File Offset: 0x0000B260
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000D11C File Offset: 0x0000B31C
		[global::System.ComponentModel.Description("Indicates watermark text displayed on the input control when control is empty.")]
		[global::System.ComponentModel.Category("Watermark")]
		[global::System.ComponentModel.DefaultValue(null)]
		public string WatermarkText
		{
			get
			{
				short num = (short)2082600090;
				short num2 = num;
				num = (short)803861658;
				switch (num2 == num)
				{
				}
				num = (short)267976705;
				if (num != 0)
				{
				}
				num = (short)1963786240;
				if (num != 0)
				{
				}
				num = (short)207028224;
				short num3 = num;
				return (string)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkTextProperty);
			}
			set
			{
				short num = (short)2062497032;
				short num2 = num;
				num = (short)50148616;
				switch (num2 == num)
				{
				}
				num = (short)1650982913;
				if (num != 0)
				{
				}
				num = (short)1388380160;
				if (num != 0)
				{
				}
				num = (short)1465712640;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkTextProperty, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000D28C File Offset: 0x0000B48C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Description("Indicates watermark text brush.")]
		[global::System.ComponentModel.Category("Watermark")]
		public global::System.Windows.Media.Brush WatermarkBrush
		{
			get
			{
				short num = (short)1545944611;
				short num2 = num;
				num = (short)2109816355;
				switch (num2 == num)
				{
				}
				num = (short)2059337729;
				if (num != 0)
				{
				}
				num = (short)228261888;
				if (num != 0)
				{
				}
				num = (short)76873728;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkBrushProperty);
			}
			set
			{
				short num = (short)224579609;
				short num2 = num;
				num = (short)1002426393;
				switch (num2 == num)
				{
				}
				num = (short)553910273;
				if (num != 0)
				{
				}
				num = (short)391774208;
				if (num != 0)
				{
				}
				num = (short)826212352;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkBrushProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000D344 File Offset: 0x0000B544
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Category("Watermark")]
		[global::System.ComponentModel.Description("Indicates whether watermark text is displayed if set for the input items.")]
		public bool WatermarkEnabled
		{
			get
			{
				short num = (short)1200649969;
				short num2 = num;
				num = (short)1935570673;
				switch (num2 == num)
				{
				}
				num = (short)888733696;
				if (num != 0)
				{
				}
				num = (short)1251868673;
				if (num != 0)
				{
				}
				num = (short)477429760;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkEnabledProperty);
			}
			set
			{
				short num = (short)1870138913;
				short num2 = num;
				num = (short)601624097;
				switch (num2 == num)
				{
				}
				num = (short)2053439488;
				if (num != 0)
				{
				}
				num = (short)1530003457;
				if (num != 0)
				{
				}
				num = (short)789970944;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkEnabledProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000D4B4 File Offset: 0x0000B6B4
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000D56C File Offset: 0x0000B76C
		[global::System.ComponentModel.Description("Indicates watermark text alignment.")]
		[global::System.ComponentModel.DefaultValue(global::System.Windows.HorizontalAlignment.Left)]
		[global::System.ComponentModel.Category("Watermark")]
		public global::System.Windows.HorizontalAlignment WatermarkAlignment
		{
			get
			{
				short num = (short)962777102;
				short num2 = num;
				num = (short)2134036494;
				switch (num2 == num)
				{
				}
				num = (short)1911816193;
				if (num != 0)
				{
				}
				num = (short)1758986240;
				if (num != 0)
				{
				}
				num = (short)312016896;
				short num3 = num;
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkAlignmentProperty);
			}
			set
			{
				short num = (short)938163160;
				short num2 = num;
				num = (short)13974488;
				switch (num2 == num)
				{
				}
				num = (short)842334209;
				if (num != 0)
				{
				}
				num = (short)1180368896;
				if (num != 0)
				{
				}
				num = (short)1104871424;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkAlignmentProperty, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000D628 File Offset: 0x0000B828
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[global::System.ComponentModel.Category("Watermark")]
		[global::System.ComponentModel.Description("Indicates watermark hiding behaviour.")]
		public global::DevComponents.WpfEditors.eWatermarkBehavior WatermarkBehavior
		{
			get
			{
				short num = (short)653533222;
				short num2 = num;
				num = (short)1625235494;
				switch (num2 == num)
				{
				}
				num = (short)1704591361;
				if (num != 0)
				{
				}
				num = (short)1579024384;
				if (num != 0)
				{
				}
				num = (short)2074214400;
				short num3 = num;
				return (global::DevComponents.WpfEditors.eWatermarkBehavior)base.GetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkBehaviorProperty);
			}
			set
			{
				short num = (short)1327431681;
				if (num != 0)
				{
				}
				num = (short)232729843;
				short num2 = num;
				num = (short)765996275;
				switch (num2 == num)
				{
				}
				num = (short)1870594048;
				if (num != 0)
				{
				}
				num = (short)2117140480;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.InputBaseControl.WatermarkBehaviorProperty, value);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000D79C File Offset: 0x0000B99C
		static InputBaseControl()
		{
			int a_ = 9;
			short num = (short)601423873;
			if (num != 0)
			{
			}
			num = (short)1673463616;
			short num2 = num;
			num = (short)14616384;
			switch (num2 == num)
			{
			}
			num = (short)332529664;
			if (num != 0)
			{
			}
			num = (short)767688704;
			short num3 = num;
			global::DevComponents.WpfEditors.InputBaseControl.ShowCheckBoxProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藕냗뗙ꯛ鷝裟蟡蟣跥ꫧ藩铫", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputBaseControl.e)));
			global::DevComponents.WpfEditors.InputBaseControl.LockUpdateCheckedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髕럗맙럛话郟蛡藣鋥跧ꧩ蓫语鏯駱釳鋵", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputBaseControl.d)));
			global::DevComponents.WpfEditors.InputBaseControl.LockUpdateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髕럗맙럛话郟蛡藣鋥跧ꧩ蓫迭黯闱釳鋵", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.InputBaseControl));
			global::DevComponents.WpfEditors.InputBaseControl.IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿕ꯗ裙맛뿝蓟귡諣諥釧", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputBaseControl.c)));
			global::DevComponents.WpfEditors.InputBaseControl.AutoOverwriteProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韕귗껙돛針雟蟡難釥髧菩飫语", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.InputBaseControl.ButtonCustomProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铕귗껙꣛뇝軟ꇡ釣闥鳧藩臫", a_), typeof(global::DevComponents.WpfEditors.InputButtonSettings), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputBaseControl.b)));
			global::DevComponents.WpfEditors.InputBaseControl.ButtonCustom2Property = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铕귗껙꣛뇝軟ꇡ釣闥鳧藩臫\udced", a_), typeof(global::DevComponents.WpfEditors.InputButtonSettings), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputBaseControl.a)));
			global::DevComponents.WpfEditors.InputBaseControl.ButtonCustomClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铕귗껙꣛뇝軟ꇡ釣闥鳧藩臫귭鳯鯱音鷵", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.InputBaseControl));
			global::DevComponents.WpfEditors.InputBaseControl.ButtonCustom2ClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铕귗껙꣛뇝軟ꇡ釣闥鳧藩臫\udced돯黱鷳闵鏷", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.InputBaseControl));
			global::DevComponents.WpfEditors.InputBaseControl.WatermarkTextProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臕맗껙맛곝跟菡難跥볧迩铫髭", a_), typeof(string), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.InputBaseControl.WatermarkBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臕맗껙맛곝跟菡難跥ꫧ飩駫鷭飯", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.InputBaseControl.WatermarkEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臕맗껙맛곝跟菡難跥귧蓩跫賭鳯韱郳", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.InputBaseControl.WatermarkAlignmentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臕맗껙맛곝跟菡難跥ꧧ蛩藫觭黯鿱釳飵賷", a_), typeof(global::System.Windows.HorizontalAlignment), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(global::System.Windows.HorizontalAlignment.Left));
			global::DevComponents.WpfEditors.InputBaseControl.WatermarkBehaviorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臕맗껙맛곝跟菡難跥ꫧ迩蓫迭蛯鯱鯳蓵", a_), typeof(global::DevComponents.WpfEditors.eWatermarkBehavior), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eWatermarkBehavior.HideOnFocus));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.Input.CommandBinding(global::System.Windows.Input.ApplicationCommands.Cut, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::DevComponents.WpfEditors.InputBaseControl.c), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::DevComponents.WpfEditors.InputBaseControl.c)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.Input.CommandBinding(global::System.Windows.Input.ApplicationCommands.Copy, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::DevComponents.WpfEditors.InputBaseControl.b), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::DevComponents.WpfEditors.InputBaseControl.b)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.Input.CommandBinding(global::System.Windows.Input.ApplicationCommands.Paste, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::DevComponents.WpfEditors.InputBaseControl.a), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::DevComponents.WpfEditors.InputBaseControl.a)));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000DC38 File Offset: 0x0000BE38
		private static void c(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)673795956;
			short num2 = num;
			num = (short)1777553268;
			switch (num2 == num)
			{
			}
			num = (short)696451072;
			if (num != 0)
			{
			}
			num = (short)2110455809;
			if (num != 0)
			{
			}
			num = (short)1369178112;
			short num3 = num;
			((global::DevComponents.WpfEditors.InputBaseControl)A_0).OnCutCommand(A_1);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		protected virtual void OnCutCommand(global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			short num = (short)954828554;
			short num2 = num;
			num = (short)1022985994;
			switch (num2 == num)
			{
			}
			num = (short)744357889;
			if (num != 0)
			{
			}
			num = (short)293076992;
			if (num != 0)
			{
			}
			num = (short)957939712;
			short num3 = num;
			this.OnClipboardCut();
			args.Handled = true;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
		private static void c(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1583426657;
			short num2 = num;
			num = (short)259271777;
			switch (num2 == num)
			{
			}
			num = (short)1302069248;
			if (num != 0)
			{
			}
			num = (short)644349953;
			if (num != 0)
			{
			}
			num = (short)1695875072;
			short num3 = num;
			((global::DevComponents.WpfEditors.InputBaseControl)A_0).OnCanExecuteCutCommand(A_1);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000DE5C File Offset: 0x0000C05C
		protected virtual void OnCanExecuteCutCommand(global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			short num = (short)1772545550;
			short num2 = num;
			num = (short)807986702;
			switch (num2 == num)
			{
			}
			num = (short)1293025281;
			if (num != 0)
			{
			}
			num = (short)258736128;
			if (num != 0)
			{
			}
			num = (short)1355546624;
			short num3 = num;
			args.CanExecute = !this.IsReadOnly;
			args.Handled = true;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000DF18 File Offset: 0x0000C118
		protected virtual void OnClipboardCut()
		{
			short num = (short)1994270668;
			short num2 = num;
			num = (short)960505804;
			switch (num2 == num)
			{
			}
			num = (short)434634753;
			if (num != 0)
			{
			}
			num = (short)2098331648;
			if (num != 0)
			{
			}
			num = (short)765198336;
			short num3 = num;
			this.OnClipboardCopy();
			this.OnClear();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
		protected virtual void OnClear()
		{
			short num = (short)1384915121;
			short num2 = num;
			num = (short)17309873;
			switch (num2 == num)
			{
			}
			num = (short)2112159745;
			if (num != 0)
			{
			}
			num = (short)170328064;
			if (num != 0)
			{
			}
			num = (short)310181888;
			short num3 = num;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000E07C File Offset: 0x0000C27C
		private static void b(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)624439882;
			short num2 = num;
			num = (short)636760650;
			switch (num2 == num)
			{
			}
			num = (short)2019753985;
			if (num != 0)
			{
			}
			num = (short)1349386240;
			if (num != 0)
			{
			}
			num = (short)230359040;
			short num3 = num;
			((global::DevComponents.WpfEditors.InputBaseControl)A_0).OnCopyCommand(A_1);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000E130 File Offset: 0x0000C330
		protected virtual void OnCopyCommand(global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			short num = (short)1217798237;
			short num2 = num;
			num = (short)536748125;
			switch (num2 == num)
			{
			}
			num = (short)450428928;
			if (num != 0)
			{
			}
			num = (short)918159361;
			if (num != 0)
			{
			}
			num = (short)1613168640;
			short num3 = num;
			this.OnClipboardCopy();
			args.Handled = true;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
		private static void b(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)711475281;
			short num2 = num;
			num = (short)1787314257;
			switch (num2 == num)
			{
			}
			num = (short)1385431041;
			if (num != 0)
			{
			}
			num = (short)353239040;
			if (num != 0)
			{
			}
			num = (short)1537081344;
			short num3 = num;
			((global::DevComponents.WpfEditors.InputBaseControl)A_0).OnCanExecuteCopyCommand(A_1);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000E29C File Offset: 0x0000C49C
		protected virtual void OnCanExecuteCopyCommand(global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			short num = (short)1525073281;
			short num2 = num;
			num = (short)2023605633;
			switch (num2 == num)
			{
			}
			num = (short)1223294976;
			if (num != 0)
			{
			}
			num = (short)1995309057;
			if (num != 0)
			{
			}
			num = (short)1386479616;
			short num3 = num;
			args.CanExecute = true;
			args.Handled = true;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000E350 File Offset: 0x0000C550
		protected virtual void OnClipboardCopy()
		{
			short num = (short)1254065572;
			short num2 = num;
			num = (short)1753449892;
			switch (num2 == num)
			{
			}
			num = (short)1689321472;
			if (num != 0)
			{
			}
			num = (short)1930166273;
			if (num != 0)
			{
			}
			num = (short)2071199744;
			short num3 = num;
			global::System.Windows.Clipboard.SetText(this.GetInputStringValue());
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000E404 File Offset: 0x0000C604
		protected virtual string GetInputStringValue()
		{
			short num = (short)841938985;
			short num2 = num;
			num = (short)24311849;
			switch (num2 == num)
			{
			}
			num = (short)610533377;
			if (num != 0)
			{
			}
			num = (short)1947795456;
			if (num != 0)
			{
			}
			num = (short)481951744;
			short num3 = num;
			return "";
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
		private static void a(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)1433472012;
			short num2 = num;
			num = (short)1407847436;
			switch (num2 == num)
			{
			}
			num = (short)1316945921;
			if (num != 0)
			{
			}
			num = (short)142409728;
			if (num != 0)
			{
			}
			num = (short)800456704;
			short num3 = num;
			((global::DevComponents.WpfEditors.InputBaseControl)A_0).OnPasteCommand(A_1);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000E568 File Offset: 0x0000C768
		protected virtual void OnPasteCommand(global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			short num = (short)1187893740;
			short num2 = num;
			num = (short)822989292;
			switch (num2 == num)
			{
			}
			num = (short)2014576640;
			if (num != 0)
			{
			}
			num = (short)430243841;
			if (num != 0)
			{
			}
			num = (short)1684406272;
			short num3 = num;
			this.OnClipboardPaste();
			args.Handled = true;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000E61C File Offset: 0x0000C81C
		private static void a(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1243011615;
			short num2 = num;
			num = (short)1546377759;
			switch (num2 == num)
			{
			}
			num = (short)450560001;
			if (num != 0)
			{
			}
			num = (short)1483407360;
			if (num != 0)
			{
			}
			num = (short)1924857856;
			short num3 = num;
			((global::DevComponents.WpfEditors.InputBaseControl)A_0).OnCanExecutePasteCommand(A_1);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
		protected virtual void OnCanExecutePasteCommand(global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			short num = (short)1539309569;
			if (num != 0)
			{
			}
			num = (short)1026476520;
			short num2 = num;
			num = (short)1840302568;
			switch (num2 == num)
			{
			}
			num = (short)17235968;
			if (num != 0)
			{
			}
			num = (short)1616052224;
			short num3 = num;
			args.CanExecute = !this.IsReadOnly;
			args.Handled = true;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000E790 File Offset: 0x0000C990
		protected virtual void OnClipboardPaste()
		{
			short num = (short)203365404;
			short num2 = num;
			num = (short)1318198300;
			switch (num2 == num)
			{
			}
			num = (short)1998520321;
			if (num != 0)
			{
			}
			num = (short)1899036672;
			if (num != 0)
			{
			}
			num = (short)983105536;
			short num3 = num;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000E838 File Offset: 0x0000CA38
		protected virtual global::DevComponents.WpfEditors.Primitives.EditorGroup GetInputGroup()
		{
			short num = (short)701628417;
			if (num != 0)
			{
			}
			num = (short)1973998045;
			short num2 = num;
			num = (short)911069661;
			switch (num2 == num)
			{
			}
			num = (short)1043791872;
			if (num != 0)
			{
			}
			num = (short)1985413120;
			short num3 = num;
			return this.b;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		public override void OnApplyTemplate()
		{
			int a_ = 8;
			short num = (short)773115352;
			short num2 = num;
			num = (short)927911384;
			switch (num2 == num)
			{
			}
			num = (short)1207042049;
			if (num != 0)
			{
			}
			num = (short)1440022528;
			if (num != 0)
			{
			}
			num = (short)1771831296;
			short num3 = num;
			this.b = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藔雖诘迚苜雞迠鏢郤鏦껨駪苬髮臰", a_)) as global::DevComponents.WpfEditors.Primitives.EditorGroup);
			this.OnInputGroupAssigned();
			base.OnApplyTemplate();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
		protected virtual void OnInputGroupAssigned()
		{
			short num = (short)2018044546;
			short num2 = num;
			num = (short)633399938;
			switch (num2 == num)
			{
			}
			num = (short)235339776;
			if (num != 0)
			{
			}
			num = (short)1834221569;
			if (num != 0)
			{
			}
			num = (short)1418854400;
			short num3 = num;
			this.UpdateLockUpdateCheckBox();
			this.RecreateButtons();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000EA74 File Offset: 0x0000CC74
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool? isChecked;
			bool lockUpdateChecked;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_141;
				case 1:
					if (!(isChecked.GetValueOrDefault() == lockUpdateChecked & isChecked != null))
					{
						num2 = (short)997326848;
						short num3 = num2;
						num2 = (short)681836546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_143;
				case 2:
				{
					num2 = (short)628576698;
					short num4 = num2;
					num2 = (short)1038569914;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2125529089;
						if (num2 != 0)
						{
						}
						num2 = (short)269942784;
						if (num2 != 0)
						{
						}
						isChecked = this.a.IsChecked;
						this.LockUpdateChecked = isChecked.Value;
						break;
					}
					num2 = (short)261029888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_141:
			IL_143:
			this.OnLockUpdateChanged(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.InputBaseControl.LockUpdateChangedEvent));
			return;
			IL_1C:
			isChecked = this.a.IsChecked;
			lockUpdateChecked = this.LockUpdateChecked;
			num2 = (short)461701121;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000EBD4 File Offset: 0x0000CDD4
		protected void UpdateLockUpdateCheckBox()
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!inputGroup.Items.Contains(this.a))
					{
						num2 = (short)871694349;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					num2 = (short)319356940;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				case 3:
				{
					bool? isChecked = this.a.IsChecked;
					this.LockUpdateChecked = isChecked.Value;
					num2 = (short)1696399369;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_379;
				case 5:
					return;
				case 6:
					goto IL_257;
				case 7:
					if (this.a == null)
					{
						num2 = (short)1489960971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1105723392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)2045378560;
					short num3 = num2;
					bool? isChecked;
					bool lockUpdateChecked;
					if (!(isChecked.GetValueOrDefault() == lockUpdateChecked & isChecked != null))
					{
						num2 = (short)1244528643;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FA;
				}
				case 9:
					goto IL_C0;
				case 10:
				{
					num2 = (short)953191131;
					short num4 = num2;
					num2 = (short)608471771;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_379;
					default:
						num2 = (short)2066939904;
						if (num2 != 0)
						{
						}
						num2 = (short)1309212679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
				{
					this.a = new global::DevComponents.WpfEditors.Primitives.LockUpdateCheckBox();
					inputGroup.Items.Insert(0, this.a);
					bool? isChecked = this.a.IsChecked;
					bool lockUpdateChecked = this.LockUpdateChecked;
					num2 = (short)1898709000;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					if (this.a != null)
					{
						num2 = (short)846528516;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_257;
				case 13:
					num2 = (short)119734273;
					if (num2 != 0)
					{
					}
					inputGroup.Items.Insert(0, this.a);
					num2 = (short)15466501;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (!this.ShowCheckBox)
					{
						num2 = (short)1358102529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_257;
				case 15:
					if (inputGroup == null)
					{
						num2 = (short)2090336258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)272564238;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (this.ShowCheckBox)
					{
						num2 = (short)1215037450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_54;
				IL_257:
				num2 = (short)887947280;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_379:
				inputGroup.Items.Remove(this.a);
				this.a.Checked -= this.a;
				this.a.Unchecked -= this.a;
				this.a = null;
				num2 = (short)1089601542;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_C0:
			IL_1FA:
			this.a.Checked += this.a;
			this.a.Unchecked += this.a;
			return;
			IL_54:
			inputGroup = this.GetInputGroup();
			num2 = (short)118685711;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)75694085;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
					num = (short)563085314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (!base.IsKeyboardFocusWithin)
					{
						num = (short)124518400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF;
				case 2:
				{
					global::System.Windows.Rect rect;
					if (rect.Contains(e.GetPosition(this)))
					{
						num = (short)1743912966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF;
				}
				case 3:
					goto IL_122;
				case 4:
					num = (short)718667777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1776484352;
					short num3 = num;
					num = (short)1353758722;
					short num4 = num;
					num = (short)1155184642;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_122;
					default:
						num = (short)1618214913;
						if (num != 0)
						{
						}
						num = (short)238288896;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_DF;
						}
						continue;
					}
					break;
				}
				case 6:
					this.FocusFirstInput();
					e.Handled = true;
					num = (short)656277507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DF:
				if (e.Handled)
				{
					break;
				}
				num = (short)189267972;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_122:
			IL_1AF:
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000F180 File Offset: 0x0000D380
		protected virtual bool FocusFirstInput()
		{
			global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup = this.GetInputGroup();
			short num;
			if (inputGroup == null)
			{
				num = (short)447444322;
				short num2 = num;
				num = (short)170947938;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1997733888;
					if (num != 0)
					{
					}
					num = (short)363724800;
					short num3 = num;
					return false;
				}
				}
			}
			num = (short)712245249;
			if (num != 0)
			{
			}
			return inputGroup.FocusFirstInput();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000F23C File Offset: 0x0000D43C
		public bool FocusInput()
		{
			short num = (short)1786118145;
			if (num != 0)
			{
			}
			num = (short)953642598;
			short num2 = num;
			num = (short)1875930726;
			switch (num2 == num)
			{
			}
			num = (short)1632829440;
			if (num != 0)
			{
			}
			num = (short)1786576896;
			short num3 = num;
			return this.FocusFirstInput();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		protected virtual int GetButtonsInsertPosition()
		{
			global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup = this.GetInputGroup();
			if (inputGroup == null)
			{
				short num = (short)1724907521;
				if (num != 0)
				{
				}
				num = (short)896992423;
				short num2 = num;
				num = (short)990905511;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1996357632;
					if (num != 0)
					{
					}
					num = (short)2071592960;
					short num3 = num;
					return 0;
				}
				}
			}
			return inputGroup.Items.Count;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		internal void a(global::DevComponents.WpfEditors.InputButtonSettings A_0)
		{
			short num = (short)1482374113;
			short num2 = num;
			num = (short)1253915617;
			switch (num2 == num)
			{
			}
			num = (short)774832129;
			if (num != 0)
			{
			}
			num = (short)433324032;
			if (num != 0)
			{
			}
			num = (short)983105536;
			short num3 = num;
			this.OnInputButtonPositionChanged(A_0);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000F45C File Offset: 0x0000D65C
		protected virtual void OnInputButtonPositionChanged(global::DevComponents.WpfEditors.InputButtonSettings inputButtonSettings)
		{
			short num = (short)1435590422;
			short num2 = num;
			num = (short)792354582;
			switch (num2 == num)
			{
			}
			num = (short)1247936513;
			if (num != 0)
			{
			}
			num = (short)352976896;
			if (num != 0)
			{
			}
			num = (short)1145503744;
			short num3 = num;
			this.RecreateButtons();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000F510 File Offset: 0x0000D710
		internal void b(global::DevComponents.WpfEditors.InputButtonSettings A_0)
		{
			short num = (short)1979285357;
			short num2 = num;
			num = (short)1580236653;
			switch (num2 == num)
			{
			}
			num = (short)719519744;
			if (num != 0)
			{
			}
			num = (short)1540030465;
			if (num != 0)
			{
			}
			num = (short)415891456;
			short num3 = num;
			this.OnInputButtonVisibleChanged(A_0);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000F5C0 File Offset: 0x0000D7C0
		protected virtual void OnInputButtonVisibleChanged(global::DevComponents.WpfEditors.InputButtonSettings inputButtonSettings)
		{
			short num = (short)1139501964;
			short num2 = num;
			num = (short)37514124;
			switch (num2 == num)
			{
			}
			num = (short)1080623105;
			if (num != 0)
			{
			}
			num = (short)1922301952;
			if (num != 0)
			{
			}
			num = (short)1436483584;
			short num3 = num;
			this.RecreateButtons();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000F66C File Offset: 0x0000D86C
		protected virtual void RecreateButtons()
		{
			short num = (short)241696768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1930428416;
				short num3 = num;
				num = (short)1733885953;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
				for (;;)
				{
					IL_79:
					global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator;
					int num5;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_166;
					case 2:
					{
						if (inputGroup == null)
						{
							num = (short)1120731136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = this.GetExistingButtons().GetEnumerator();
						num = (short)1889952034;
						short num4 = num;
						num = (short)455106850;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_166;
						default:
							num = (short)203816960;
							if (num != 0)
							{
							}
							num = (short)1939472385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						try
						{
							num = (short)1027735553;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1A6;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)769392643;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement element = enumerator.Current;
									inputGroup.Items.Insert(num5, element);
									num5++;
									num = (short)144637952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1239875588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_22D;
								}
								IL_1A8:
								num = (short)1885798402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A6:
								goto IL_1A8;
							}
							IL_22D:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_3;
					}
					goto IL_90;
					Block_3:
					try
					{
						IL_240:
						num = (short)16580611;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)425132036;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement element2 = enumerator.Current;
								num = (short)1530134533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::System.Windows.UIElement element2;
								inputGroup.Items.Remove(element2);
								num = (short)2106654722;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_282;
								}
								continue;
							case 4:
								num = (short)1063976966;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::System.Windows.UIElement element2;
								if (inputGroup.Items.Contains(element2))
								{
									num = (short)216793089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_341;
							}
							IL_284:
							num = (short)48234496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_282:
							goto IL_284;
						}
						IL_341:
						goto IL_CA;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					return;
					IL_CA:
					global::System.Collections.Generic.List<global::System.Windows.UIElement> list = this.b();
					num5 = this.GetButtonsInsertPosition();
					enumerator = list.GetEnumerator();
					num = (short)1177812995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_166:
					goto IL_240;
				}
				return;
				IL_90:
				inputGroup = this.GetInputGroup();
				num = (short)368181250;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_79;
			}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000FA04 File Offset: 0x0000DC04
		protected virtual global::System.Collections.Generic.List<global::System.Windows.UIElement> GetExistingButtons()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::System.Collections.Generic.List<global::System.Windows.UIElement> list;
			global::DevComponents.WpfEditors.InputButtonSettings inputButtonSettings;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					list.Add(inputButtonSettings.ButtonReference);
					num2 = (short)801112066;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1630936359;
					short num3 = num2;
					num2 = (short)459152679;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return list;
					default:
					{
						num2 = (short)394395648;
						short num4 = num2;
						num2 = (short)204341248;
						if (num2 != 0)
						{
						}
						list.Add(inputButtonSettings.ButtonReference);
						num2 = (short)2008743945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					return list;
				case 3:
					if (inputButtonSettings.ButtonReference != null)
					{
						num2 = (short)1136066560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return list;
				case 4:
					num2 = (short)303693827;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)724107272;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (inputButtonSettings != null)
					{
						num2 = (short)428539909;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AE;
				case 7:
					if (inputButtonSettings != null)
					{
						num2 = (short)1618542596;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return list;
				case 8:
					num2 = (short)74711041;
					if (num2 != 0)
					{
					}
					if (inputButtonSettings.ButtonReference != null)
					{
						num2 = (short)1609695233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AE;
				case 9:
					goto IL_AE;
				}
				goto IL_38;
				IL_AE:
				inputButtonSettings = this.ButtonCustom2;
				num2 = (short)425721863;
				num = (int)((global::System.IntPtr)num2);
			}
			return list;
			IL_38:
			list = new global::System.Collections.Generic.List<global::System.Windows.UIElement>();
			inputButtonSettings = this.ButtonCustom;
			num2 = (short)394395654;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000FC28 File Offset: 0x0000DE28
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> b()
		{
			short num = (short)628232979;
			short num2 = num;
			num = (short)942543635;
			global::System.Collections.Generic.List<global::System.Windows.UIElement> list;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)394199040;
				if (num != 0)
				{
				}
				num = (short)1685848064;
				short num3 = num;
				global::System.Collections.Generic.List<global::DevComponents.WpfEditors.InputButtonSettings> inputButtons = this.GetInputButtons();
				inputButtons.Sort(new global::DevComponents.WpfEditors.InputBaseControl.a());
				list = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(inputButtons.Count);
				using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.InputButtonSettings>.Enumerator enumerator = inputButtons.GetEnumerator())
				{
					num = (short)311164929;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1711865860;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D5;
							}
							continue;
						case 3:
						{
							num = (short)868483073;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)1518338048;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfEditors.InputButtonSettings inputButtonSettings = enumerator.Current;
							list.Add(inputButtonSettings.ButtonReference);
							num = (short)1343291394;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_175;
						}
						IL_102:
						num = (short)1265893379;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_D5:
						goto IL_102;
					}
					IL_175:;
				}
				break;
			}
			}
			return list;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000FDCC File Offset: 0x0000DFCC
		protected virtual global::System.Collections.Generic.List<global::DevComponents.WpfEditors.InputButtonSettings> GetInputButtons()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.Collections.Generic.List<global::DevComponents.WpfEditors.InputButtonSettings> list;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)25234562;
					short num3 = num2;
					num2 = (short)516361346;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_189;
					default:
						num2 = (short)1969946624;
						if (num2 != 0)
						{
						}
						num2 = (short)1517551617;
						if (num2 != 0)
						{
						}
						list.Add(this.ButtonCustom);
						num2 = (short)2090860549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					list.Add(this.ButtonCustom2);
					num2 = (short)678428675;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.ButtonCustom != null)
					{
						num2 = (short)776994816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B5;
				case 3:
					return list;
				case 4:
					if (this.ButtonCustom2 != null)
					{
						num2 = (short)179175425;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return list;
				case 5:
					goto IL_189;
				}
				goto IL_28;
				IL_B5:
				num2 = (short)1575747588;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_189:
				goto IL_B5;
			}
			return list;
			IL_28:
			num2 = (short)1012662272;
			short num4 = num2;
			list = new global::System.Collections.Generic.List<global::DevComponents.WpfEditors.InputButtonSettings>();
			num2 = (short)1263403010;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000FF68 File Offset: 0x0000E168
		private global::DevComponents.WpfEditors.Primitives.EditorButton a()
		{
			short num = (short)1541712645;
			short num2 = num;
			num = (short)1902029573;
			switch (num2 == num)
			{
			}
			num = (short)702414849;
			if (num != 0)
			{
			}
			num = (short)1266483200;
			short num3 = num;
			num = (short)880803840;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfEditors.Primitives.EditorButton
			{
				HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right,
				Focusable = false
			};
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00010028 File Offset: 0x0000E228
		internal void c(global::DevComponents.WpfEditors.InputButtonSettings A_0)
		{
			short num = (short)1869217793;
			if (num != 0)
			{
			}
			num = (short)2041769937;
			short num2 = num;
			num = (short)71954385;
			switch (num2 == num)
			{
			}
			num = (short)1380843520;
			short num3 = num;
			num = (short)70189056;
			if (num != 0)
			{
			}
			this.OnCustomInputButtonClicked(A_0);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000100D8 File Offset: 0x0000E2D8
		protected virtual void OnCustomInputButtonClicked(global::DevComponents.WpfEditors.InputButtonSettings ibs)
		{
			short num = (short)319553537;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (ibs == this.ButtonCustom2)
					{
						goto IL_118;
					}
					return;
				case 1:
					num = (short)1053032449;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 2:
					goto IL_80;
				case 3:
					return;
				case 4:
				{
					num = (short)485413839;
					short num3 = num;
					num = (short)1834931151;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)1087045632;
						if (num != 0)
						{
						}
						this.OnButtonCustom2Click(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustom2ClickEvent));
						num = (short)63307779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_60:
				if (ibs == this.ButtonCustom)
				{
					num = (short)1569193986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1918763008;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_118:
				num = (short)161153024;
				short num4 = num;
				num = (short)931004420;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_80:
			this.OnButtonCustomClick(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.InputBaseControl.ButtonCustomClickEvent));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00010254 File Offset: 0x0000E454
		protected virtual void UpdateFreeTextEntry()
		{
			short num = (short)378011648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AA;
				}
				global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
				for (;;)
				{
					IL_27:
					global::System.Windows.Controls.TextBox freeEntryTextBox;
					int num4;
					int num5;
					global::System.Windows.UIElement uielement;
					switch (num2)
					{
					case 0:
						goto IL_5E6;
					case 1:
					{
						num = (short)786738583;
						short num3 = num;
						num = (short)28945815;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_459;
						default:
							goto IL_501;
						}
						break;
					}
					case 2:
						goto IL_62E;
					case 3:
						if (inputGroup.Items.Contains(freeEntryTextBox))
						{
							num = (short)321519646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45E;
					case 4:
						if (this.IsFreeTextBoxVisible)
						{
							num = (short)847511558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)48037899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num4 = 0;
						num = (short)1482162188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_335;
					case 7:
						if (num4 < 0)
						{
							num = (short)72089614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_482;
					case 8:
						goto IL_459;
					case 9:
						num = (short)747962371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1598423065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (freeEntryTextBox != null)
						{
							num = (short)832176137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						goto IL_69B;
					case 13:
						if (num5 >= inputGroup.Items.Count)
						{
							num = (short)1307836426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = inputGroup.Items[num5];
						num = (short)255983632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num4 = num5;
						num = (short)211681299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_47D;
					case 16:
						if (uielement is global::DevComponents.WpfEditors.Primitives.EditorInputBase)
						{
							num = (short)711262216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_633;
					case 17:
						goto IL_653;
					case 18:
						try
						{
							num = (short)631635973;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1703215112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1974206471;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Windows.UIElement uielement2;
									uielement2.Visibility = global::System.Windows.Visibility.Visible;
									num = (short)209846276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1178730496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement2 = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)2002649094;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1B5;
									}
									continue;
								case 6:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2 is global::DevComponents.WpfEditors.Primitives.EditorInputBase)
									{
										num = (short)679673857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2.Visibility == global::System.Windows.Visibility.Collapsed)
									{
										num = (short)1364787202;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_2B8;
								}
								IL_1B7:
								num = (short)1309081603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B5:
								goto IL_1B7;
							}
							IL_2B8:
							goto IL_3A7;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2DA;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2C7:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)643497985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_334;
								case 1:
									disposable.Dispose();
									num = (short)476250114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_332;
								}
								goto IL_2DA;
							}
							IL_332:
							IL_334:
							goto EndFinally_18;
							IL_2DA:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1754333184;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2C7;
							EndFinally_18:;
						}
						goto IL_335;
						IL_3A7:
						inputGroup.Items.Remove(freeEntryTextBox);
						num = (short)824901652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_482;
					case 20:
						goto IL_45E;
					case 21:
						num = (short)1274019864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_633;
					case 23:
						if (freeEntryTextBox != null)
						{
							num = (short)883032085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E6;
					case 24:
						if (!inputGroup.Items.Contains(freeEntryTextBox))
						{
							num = (short)1992032284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E6;
					case 25:
						if (num4 < 0)
						{
							num = (short)1858011141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69B;
					case 26:
						goto IL_653;
					case 27:
						if (inputGroup == null)
						{
							num = (short)1890189313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						freeEntryTextBox = this.GetFreeEntryTextBox();
						num = (short)696844292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num4 = -1;
						num5 = 0;
						num = (short)1751842842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (!this.d.IsFocused)
						{
							num = (short)864944130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 30:
					{
						global::System.Collections.IEnumerator enumerator = inputGroup.Items.GetEnumerator();
						num = (short)739115026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_AA;
					IL_335:
					num = (short)663158807;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_459:
					num = (short)2126708743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45E:
					this.DestroyFreeTextBox();
					num = (short)447348751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_482:
					uielement.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)1196818433;
					if (num != 0)
					{
					}
					num = (short)1268318230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E6:
					this.UpdateFreeTextBoxValue();
					num = (short)1477181469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_633:
					num5++;
					num = (short)2089353233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_653:
					num = (short)185008141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69B:
					inputGroup.Items.Insert(num4, freeEntryTextBox);
					num = (short)1852702720;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_47D:
				return;
				IL_501:
				num = (short)599064576;
				if (num != 0)
				{
				}
				return;
				IL_62E:
				num = (short)1124794368;
				short num6 = num;
				this.d.Focus();
				return;
				IL_AA:
				inputGroup = this.GetInputGroup();
				num = (short)1236402203;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000109D4 File Offset: 0x0000EBD4
		protected virtual void UpdateFreeTextBoxValue()
		{
			short num = (short)1939653764;
			short num2 = num;
			num = (short)596558980;
			switch (num2 == num)
			{
			}
			num = (short)136314880;
			if (num != 0)
			{
			}
			num = (short)178388992;
			short num3 = num;
			num = (short)385089537;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00010A84 File Offset: 0x0000EC84
		protected virtual void DestroyFreeTextBox()
		{
			short num = (short)2129854464;
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
					num = (short)1378418689;
					if (num != 0)
					{
					}
					this.d.ApplyValue -= this.a;
					this.d.RevertValue -= this.b;
					this.d = null;
					goto IL_123;
				case 2:
					return;
				}
				IL_30:
				num = (short)1233100223;
				short num3 = num;
				num = (short)1774951871;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_123:
					num = (short)61014018;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1946681344;
					short num4 = num;
					num = (short)1928724480;
					if (num != 0)
					{
					}
					if (this.d == null)
					{
						return;
					}
					num = (short)1693188097;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		protected virtual global::System.Windows.Controls.TextBox GetFreeEntryTextBox()
		{
			short num = (short)36569088;
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
					this.d = new global::DevComponents.WpfEditors.FreeTextEntryBox();
					this.d.ApplyValue += this.a;
					this.d.RevertValue += this.b;
					goto IL_123;
				case 2:
					goto IL_13B;
				}
				IL_30:
				num = (short)331478224;
				short num3 = num;
				num = (short)1436284112;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_123:
					num = (short)1294336002;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)585564160;
					short num4 = num;
					num = (short)1654325249;
					if (num != 0)
					{
					}
					num = (short)1071972352;
					if (num != 0)
					{
					}
					if (this.d != null)
					{
						goto IL_13D;
					}
					num = (short)2038497281;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_13B:
			IL_13D:
			return this.d;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00010D20 File Offset: 0x0000EF20
		private void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1048444929;
			if (num != 0)
			{
			}
			num = (short)437549845;
			short num2 = num;
			num = (short)1135442709;
			switch (num2 == num)
			{
			}
			num = (short)1845035008;
			short num3 = num;
			num = (short)1709703168;
			if (num != 0)
			{
			}
			this.RevertFreeTextValue();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		protected virtual void RevertFreeTextValue()
		{
			short num = (short)1164810637;
			short num2 = num;
			num = (short)159816077;
			switch (num2 == num)
			{
			}
			num = (short)1403715585;
			if (num != 0)
			{
			}
			num = (short)361299968;
			short num3 = num;
			num = (short)1815412736;
			if (num != 0)
			{
			}
			this.UpdateFreeTextBoxValue();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00010E80 File Offset: 0x0000F080
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)804335477;
			short num2 = num;
			num = (short)1708470133;
			switch (num2 == num)
			{
			default:
			{
				num = (short)438632448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1065615361;
			if (num != 0)
			{
			}
			num = (short)736034816;
			if (num != 0)
			{
			}
			this.ApplyFreeTextValue();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00010F30 File Offset: 0x0000F130
		protected virtual void ApplyFreeTextValue()
		{
			short num = (short)1549467649;
			if (num != 0)
			{
			}
			num = (short)1888944128;
			short num2 = num;
			num = (short)1582329589;
			short num3 = num;
			num = (short)1934716661;
			switch (num3 == num)
			{
			}
			num = (short)1333592064;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00010FDC File Offset: 0x0000F1DC
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0001108C File Offset: 0x0000F28C
		protected virtual bool IsFreeTextBoxVisible
		{
			get
			{
				short num = (short)897924318;
				short num2 = num;
				num = (short)515194078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884684288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)77660161;
				if (num != 0)
				{
				}
				num = (short)2049179648;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)891813889;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.e = value;
						this.UpdateFreeTextEntry();
						goto IL_D2;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_E9;
					}
					IL_30:
					num = (short)425013782;
					short num3 = num;
					num = (short)2061578774;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_D2:
						num = (short)1790312450;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1461387265;
						if (num != 0)
						{
						}
						num = (short)1331036160;
						if (num != 0)
						{
						}
						if (this.e == value)
						{
							goto IL_EB;
						}
						num = (short)442499072;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_E9:
				IL_EB:
				num = (short)1534132224;
				short num4 = num;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000111B0 File Offset: 0x0000F3B0
		protected virtual bool SupportsFreeTextEntry
		{
			get
			{
				short num = (short)1448148525;
				short num2 = num;
				num = (short)1664220717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1818820608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1491402753;
				if (num != 0)
				{
				}
				num = (short)329580544;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x04000020 RID: 32
		private global::DevComponents.WpfEditors.Primitives.LockUpdateCheckBox a;

		// Token: 0x04000021 RID: 33
		private global::DevComponents.WpfEditors.Primitives.EditorGroup b;

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty ShowCheckBoxProperty;

		// Token: 0x04000023 RID: 35
		public static readonly global::System.Windows.DependencyProperty LockUpdateCheckedProperty;

		// Token: 0x04000025 RID: 37
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty;

		// Token: 0x04000026 RID: 38
		public static readonly global::System.Windows.DependencyProperty AutoOverwriteProperty;

		// Token: 0x04000027 RID: 39
		public static readonly global::System.Windows.DependencyProperty ButtonCustomProperty;

		// Token: 0x04000028 RID: 40
		public static readonly global::System.Windows.DependencyProperty ButtonCustom2Property;

		// Token: 0x0400002B RID: 43
		public static readonly global::System.Windows.DependencyProperty WatermarkTextProperty;

		// Token: 0x0400002C RID: 44
		public static readonly global::System.Windows.DependencyProperty WatermarkBrushProperty;

		// Token: 0x0400002D RID: 45
		public static readonly global::System.Windows.DependencyProperty WatermarkEnabledProperty;

		// Token: 0x0400002E RID: 46
		public static readonly global::System.Windows.DependencyProperty WatermarkAlignmentProperty;

		// Token: 0x0400002F RID: 47
		public static readonly global::System.Windows.DependencyProperty WatermarkBehaviorProperty;

		// Token: 0x04000030 RID: 48
		internal bool c;

		// Token: 0x04000031 RID: 49
		internal global::DevComponents.WpfEditors.FreeTextEntryBox d;

		// Token: 0x04000032 RID: 50
		private bool e;

		// Token: 0x02000024 RID: 36
		private class a : global::System.Collections.Generic.IComparer<global::DevComponents.WpfEditors.InputButtonSettings>
		{
			// Token: 0x060001D6 RID: 470 RVA: 0x00025110 File Offset: 0x00023310
			public int Compare(global::DevComponents.WpfEditors.InputButtonSettings x, global::DevComponents.WpfEditors.InputButtonSettings y)
			{
				short num = (short)1115921617;
				short num2 = num;
				num = (short)1557109969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124925440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)146407424;
				if (num != 0)
				{
				}
				num = (short)830537729;
				if (num != 0)
				{
				}
				return x.DisplayPosition - y.DisplayPosition;
			}
		}
	}
}
