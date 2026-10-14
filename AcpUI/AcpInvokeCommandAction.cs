using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000043 RID: 67
	public class AcpInvokeCommandAction : global::System.Windows.Interactivity.TriggerAction<global::System.Windows.DependencyObject>
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000420C8 File Offset: 0x000402C8
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00042180 File Offset: 0x00040380
		public string CommandName
		{
			get
			{
				short num = (short)1946234220;
				short num2 = num;
				num = (short)502738284;
				switch (num2 == num)
				{
				}
				num = (short)844759040;
				if (num != 0)
				{
				}
				num = (short)167968769;
				if (num != 0)
				{
				}
				num = (short)434962432;
				short num3 = num;
				base.ReadPreamble();
				return this.a;
			}
			set
			{
				short num = (short)707657729;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_7E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						base.WritePreamble();
						this.a = value;
						base.WritePostscript();
						num = (short)1914044416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					if (!(this.CommandName != value))
					{
						return;
					}
					num = (short)253886466;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7E:
				num = (short)951255040;
				short num3 = num;
				num = (short)750116125;
				short num4 = num;
				num = (short)837934365;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2085748736;
					if (num != 0)
					{
					}
					num = (short)544342017;
					if (num != 0)
					{
					}
					break;
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x000422AC File Offset: 0x000404AC
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00042364 File Offset: 0x00040564
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				short num = (short)1564937527;
				short num2 = num;
				num = (short)987303223;
				switch (num2 == num)
				{
				}
				num = (short)1170604033;
				if (num != 0)
				{
				}
				num = (short)1712455680;
				if (num != 0)
				{
				}
				num = (short)1285357568;
				short num3 = num;
				return (global::System.Windows.Input.ICommand)base.GetValue(global::AcpUI.AcpInvokeCommandAction.CommandProperty);
			}
			set
			{
				short num = (short)1093959772;
				short num2 = num;
				num = (short)1443332188;
				switch (num2 == num)
				{
				}
				num = (short)855900161;
				if (num != 0)
				{
				}
				num = (short)1910439936;
				if (num != 0)
				{
				}
				num = (short)1088815104;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpInvokeCommandAction.CommandProperty, value);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00042418 File Offset: 0x00040618
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x000424CC File Offset: 0x000406CC
		public object CommandParameter
		{
			get
			{
				short num = (short)1598212174;
				short num2 = num;
				num = (short)1401079886;
				switch (num2 == num)
				{
				}
				num = (short)663093248;
				if (num != 0)
				{
				}
				num = (short)2000486401;
				if (num != 0)
				{
				}
				num = (short)986775552;
				short num3 = num;
				return base.GetValue(global::AcpUI.AcpInvokeCommandAction.CommandParameterProperty);
			}
			set
			{
				short num = (short)846322527;
				short num2 = num;
				num = (short)1662835551;
				switch (num2 == num)
				{
				}
				num = (short)39780353;
				if (num != 0)
				{
				}
				num = (short)2125987840;
				if (num != 0)
				{
				}
				num = (short)165609472;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpInvokeCommandAction.CommandParameterProperty, value);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00042584 File Offset: 0x00040784
		protected override void Invoke(object parameter)
		{
			short num = (short)828112901;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1232666626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1873998160;
					short num3 = num;
					num = (short)2106585424;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4B;
					default:
						goto IL_B5;
					}
					break;
				}
				case 2:
				{
					global::System.Windows.Input.ICommand command;
					global::AcpUI.AcpCommandParameter parameter2;
					if (command.CanExecute(parameter2))
					{
						num = (short)332660740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					global::System.Windows.Input.ICommand command;
					if (command != null)
					{
						num = (short)621150208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
				{
					num = (short)497745920;
					short num4 = num;
					num = (short)2033778689;
					if (num != 0)
					{
					}
					global::System.Windows.Input.ICommand command;
					global::AcpUI.AcpCommandParameter parameter2;
					command.Execute(parameter2);
					num = (short)1207435265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 6:
				{
					global::System.Windows.Input.ICommand command = this.a();
					global::AcpUI.AcpCommandParameter parameter2 = new global::AcpUI.AcpCommandParameter
					{
						Sender = base.AssociatedObject,
						Parameter = base.GetValue(global::AcpUI.AcpInvokeCommandAction.CommandParameterProperty),
						EventArgs = (parameter as global::System.EventArgs)
					};
					num = (short)1769406467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_40;
				IL_4B:
				num = (short)1843789830;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_40:
				if (base.AssociatedObject != null)
				{
					goto IL_4B;
				}
				return;
			}
			IL_B5:
			num = (short)314703872;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00042760 File Offset: 0x00040960
		private global::System.Windows.Input.ICommand a()
		{
			short num = (short)1857093632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				global::System.Windows.Input.ICommand result;
				for (;;)
				{
					IL_29:
					int num4;
					switch (num2)
					{
					case 0:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						result = (global::System.Windows.Input.ICommand)propertyInfo.GetValue(base.AssociatedObject, null);
						num = (short)45154317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (base.AssociatedObject != null)
						{
							num = (short)1008599046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (string.Equals(propertyInfo.Name, this.CommandName, global::System.StringComparison.Ordinal))
						{
							num = (short)1386414080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_238;
					}
					case 3:
						goto IL_15F;
					case 4:
					{
						num = (short)687986714;
						short num3 = num;
						num = (short)1917114394;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23C;
						default:
							goto IL_1F9;
						}
						break;
					}
					case 5:
					{
						global::System.Reflection.PropertyInfo[] properties;
						if (num4 >= properties.Length)
						{
							num = (short)1425670148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.PropertyInfo propertyInfo = properties[num4];
						num = (short)980746248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Reflection.PropertyInfo[] properties = base.AssociatedObject.GetType().GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
						num4 = 0;
						num = (short)1562771468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (this.Command != null)
						{
							num = (short)921698313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)687341569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (typeof(global::System.Windows.Input.ICommand).IsAssignableFrom(propertyInfo.PropertyType))
						{
							num = (short)1637613578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_238;
					}
					case 9:
						result = this.Command;
						num = (short)542638091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)578945026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						return result;
					case 12:
						num = (short)1312161793;
						if (num != 0)
						{
						}
						goto IL_15F;
					case 13:
						goto IL_238;
					}
					goto IL_68;
					IL_15F:
					num = (short)277413888;
					short num5 = num;
					num = (short)209256453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23C:
					num = (short)1064566787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_238:
					num4++;
					goto IL_23C;
				}
				IL_1F9:
				num = (short)482869248;
				if (num != 0)
				{
				}
				return result;
				IL_68:
				result = null;
				num = (short)41615367;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00042A88 File Offset: 0x00040C88
		// Note: this type is marked as 'beforefieldinit'.
		static AcpInvokeCommandAction()
		{
			int a_ = 5;
			short num = (short)918421505;
			if (num != 0)
			{
			}
			num = (short)758996914;
			short num2 = num;
			num = (short)568811442;
			switch (num2 == num)
			{
			}
			num = (short)6881280;
			if (num != 0)
			{
			}
			num = (short)1594163200;
			short num3 = num;
			global::AcpUI.AcpInvokeCommandAction.CommandProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud89a철슢쮤쎦", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::AcpUI.AcpInvokeCommandAction), null);
			global::AcpUI.AcpInvokeCommandAction.CommandParameterProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud89a철슢쮤쎦令쪪\udfac캮\udcb0횲솴튶쮸", a_), typeof(object), typeof(global::AcpUI.AcpInvokeCommandAction), null);
		}

		// Token: 0x04000239 RID: 569
		private string a;

		// Token: 0x0400023A RID: 570
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400023B RID: 571
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty;
	}
}
