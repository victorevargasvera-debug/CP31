using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000080 RID: 128
	public class RMSpecialEditorFor2Fields : global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor
	{
		// Token: 0x060002EF RID: 751 RVA: 0x000303E4 File Offset: 0x0002E5E4
		public RMSpecialEditorFor2Fields()
		{
			base.Loaded += this.RMSpecialEditorFor2Fields_Loaded;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0003040C File Offset: 0x0002E60C
		private void RMSpecialEditorFor2Fields_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			global::System.Windows.Data.MultiBinding multiBinding;
			for (;;)
			{
				IL_09:
				short num = (short)566427648;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_BA;
					}
					global::System.Windows.Data.Binding binding;
					for (;;)
					{
						IL_32:
						num = (short)2129648007;
						short num3 = num;
						num = (short)1018878343;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1898643457;
							if (num != 0)
							{
							}
							num = (short)201261056;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								if (binding != null)
								{
									num = (short)905183232;
									short num4 = num;
									num = (short)1538260993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_26C;
							case 1:
								multiBinding.Bindings.Add(new global::System.Windows.Data.Binding
								{
									Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a1钣\udba5蚧\udfab\ud9af솱\uddb3풵풷\udfb9", a_), binding.Path.Path), global::System.Array.Empty<object>())
								});
								multiBinding.Bindings.Add(new global::System.Windows.Data.Binding
								{
									Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a1钣\udba5蚧\udfab톯\udeb1\uddb3튵", a_), binding.Path.Path), global::System.Array.Empty<object>())
								});
								num = (short)1879572482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_26A;
							}
							goto IL_BA;
						}
					}
					IL_BA:
					global::System.Windows.Data.Binding binding2 = global::System.Windows.Data.BindingOperations.GetBinding(this, global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1Property);
					binding = global::System.Windows.Data.BindingOperations.GetBinding(this, global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2Property);
					multiBinding = new global::System.Windows.Data.MultiBinding
					{
						Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.FieldsToIsValidConverter()
					};
					multiBinding.Bindings.Add(new global::System.Windows.Data.Binding
					{
						Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a1钣\udba5蚧\udfab\ud9af솱\uddb3풵풷\udfb9", a_), binding2.Path.Path), global::System.Array.Empty<object>())
					});
					multiBinding.Bindings.Add(new global::System.Windows.Data.Binding
					{
						Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a1钣\udba5蚧\udfab톯\udeb1\uddb3튵", a_), binding2.Path.Path), global::System.Array.Empty<object>())
					});
					num = (short)491388928;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				}
			}
			IL_26A:
			IL_26C:
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.IsValidProperty, multiBinding);
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields rmspecialEditorFor2Fields = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields;
			global::System.Windows.FrameworkElement control = (global::System.Windows.FrameworkElement)rmspecialEditorFor2Fields.FindName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("鞥", a_));
			global::System.Windows.FrameworkElement control2 = (global::System.Windows.FrameworkElement)rmspecialEditorFor2Fields.FindName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("钥", a_));
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1Property, control);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2Property, control2);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000306EC File Offset: 0x0002E8EC
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000307A4 File Offset: 0x0002E9A4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit Field1
		{
			get
			{
				short num = (short)140247040;
				short num2 = num;
				num = (short)962527233;
				if (num != 0)
				{
				}
				num = (short)853640007;
				short num3 = num;
				num = (short)1641120583;
				switch (num3 == num)
				{
				}
				num = (short)1069416448;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1Property);
			}
			set
			{
				short num = (short)251330560;
				short num2 = num;
				num = (short)171711205;
				short num3 = num;
				num = (short)198712037;
				switch (num3 == num)
				{
				}
				num = (short)791674881;
				if (num != 0)
				{
				}
				num = (short)387907584;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1Property, value);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00030858 File Offset: 0x0002EA58
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00030910 File Offset: 0x0002EB10
		public global::System.Windows.Visibility Field1Visibility
		{
			get
			{
				short num = (short)457637888;
				short num2 = num;
				num = (short)1670250497;
				if (num != 0)
				{
				}
				num = (short)1938926948;
				short num3 = num;
				num = (short)1228057956;
				switch (num3 == num)
				{
				}
				num = (short)23986176;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1VisibilityProperty);
			}
			set
			{
				short num = (short)113967104;
				short num2 = num;
				num = (short)890634241;
				if (num != 0)
				{
				}
				num = (short)1479679660;
				short num3 = num;
				num = (short)1205345964;
				switch (num3 == num)
				{
				}
				num = (short)771031040;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1VisibilityProperty, value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000309C8 File Offset: 0x0002EBC8
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00030A84 File Offset: 0x0002EC84
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit Field2
		{
			get
			{
				short num = (short)1571028992;
				short num2 = num;
				num = (short)331230061;
				short num3 = num;
				num = (short)1442196333;
				switch (num3 == num)
				{
				}
				num = (short)1507655681;
				if (num != 0)
				{
				}
				num = (short)332660736;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2Property);
			}
			set
			{
				short num = (short)531496960;
				short num2 = num;
				num = (short)1840858930;
				short num3 = num;
				num = (short)1262503730;
				switch (num3 == num)
				{
				}
				num = (short)1623588865;
				if (num != 0)
				{
				}
				num = (short)445972480;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2Property, value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00030B3C File Offset: 0x0002ED3C
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00030BF8 File Offset: 0x0002EDF8
		public global::System.Windows.Visibility Field2Visibility
		{
			get
			{
				short num = (short)613679104;
				short num2 = num;
				num = (short)1014471114;
				short num3 = num;
				num = (short)1287494090;
				switch (num3 == num)
				{
				}
				num = (short)740163585;
				if (num != 0)
				{
				}
				num = (short)1280114688;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2VisibilityProperty);
			}
			set
			{
				short num = (short)380895232;
				short num2 = num;
				num = (short)326500353;
				if (num != 0)
				{
				}
				num = (short)835583838;
				short num3 = num;
				num = (short)837222238;
				switch (num3 == num)
				{
				}
				num = (short)605356032;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2VisibilityProperty, value);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00030CB0 File Offset: 0x0002EEB0
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00030D6C File Offset: 0x0002EF6C
		public string TB1
		{
			get
			{
				short num = (short)883490816;
				short num2 = num;
				num = (short)1312180298;
				short num3 = num;
				num = (short)635193418;
				switch (num3 == num)
				{
				}
				num = (short)608174080;
				if (num != 0)
				{
				}
				num = (short)1765081089;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.TB1Porperty);
			}
			set
			{
				short num = (short)1098645504;
				short num2 = num;
				num = (short)1371471873;
				if (num != 0)
				{
				}
				num = (short)199052382;
				short num3 = num;
				num = (short)1421560926;
				switch (num3 == num)
				{
				}
				num = (short)1184694272;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.TB1Porperty, value);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00030E24 File Offset: 0x0002F024
		// Note: this type is marked as 'beforefieldinit'.
		static RMSpecialEditorFor2Fields()
		{
			int a_ = 1;
			short num = (short)73531392;
			short num2 = num;
			num = (short)348479799;
			short num3 = num;
			num = (short)1305764151;
			switch (num3 == num)
			{
			}
			num = (short)564264961;
			if (num != 0)
			{
			}
			num = (short)53149696;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf98얠銢", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1VisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf98얠銢캦\udaa8슪쾬욮\uddb0\udab2솴캶", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf98얠醢", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2VisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf98얠醢캦\udaa8슪쾬욮\uddb0\udab2솴캶", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.TB1Porperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춘\ud99a겜", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(string.Empty));
		}

		// Token: 0x040000ED RID: 237
		public static readonly global::System.Windows.DependencyProperty Field1Property;

		// Token: 0x040000EE RID: 238
		public static readonly global::System.Windows.DependencyProperty Field1VisibilityProperty;

		// Token: 0x040000EF RID: 239
		public static readonly global::System.Windows.DependencyProperty Field2Property;

		// Token: 0x040000F0 RID: 240
		public static readonly global::System.Windows.DependencyProperty Field2VisibilityProperty;

		// Token: 0x040000F1 RID: 241
		public static readonly global::System.Windows.DependencyProperty TB1Porperty;
	}
}
