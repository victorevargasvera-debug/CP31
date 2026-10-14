using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000061 RID: 97
	public class RMHeaderContentControl : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000200 RID: 512 RVA: 0x00021974 File Offset: 0x0001FB74
		static RMHeaderContentControl()
		{
			int a_ = 17;
			short num = (short)1839211768;
			short num2 = num;
			num = (short)716186872;
			switch (num2 == num)
			{
			}
			num = (short)808255488;
			if (num != 0)
			{
			}
			num = (short)2094858241;
			if (num != 0)
			{
			}
			num = (short)2127495168;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캪첬쮮풰솲蒴", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header1VisibilityPorperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캪첬쮮풰솲蒴킸좺풼\uddbeꣀ꿂계돆냈", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캪첬쮮풰솲螴", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header2VisibilityPorperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캪첬쮮풰솲螴킸좺풼\uddbeꣀ꿂계돆냈", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header3Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캪첬쮮풰솲蚴", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl)));
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00021B5C File Offset: 0x0001FD5C
		public RMHeaderContentControl()
		{
			base.Loaded += this.RMHeaderContentControl_Loaded;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00021B84 File Offset: 0x0001FD84
		private void RMHeaderContentControl_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)689242112;
			short num2 = num;
			num = (short)503840768;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields> list = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.d<global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields>(this).ToList<global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields>();
				global::System.Windows.Data.MultiBinding multiBinding = new global::System.Windows.Data.MultiBinding
				{
					Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsIsVisibleConverter()
				};
				global::System.Windows.Data.MultiBinding multiBinding2 = new global::System.Windows.Data.MultiBinding
				{
					Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsIsVisibleConverter()
				};
				global::System.Windows.Data.MultiBinding multiBinding3 = new global::System.Windows.Data.MultiBinding
				{
					Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsIsVisibleConverter()
				};
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields>.Enumerator enumerator = list.GetEnumerator();
				try
				{
					num = (short)645267461;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields target;
						global::System.Windows.Data.Binding binding2;
						switch (num3)
						{
						case 0:
							goto IL_250;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)862126089;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							target = enumerator.Current;
							global::System.Windows.Data.Binding binding = global::System.Windows.Data.BindingOperations.GetBinding(target, global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1Property);
							num = (short)618659848;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Windows.Data.Binding binding;
							multiBinding.Bindings.Add(new global::System.Windows.Data.Binding
							{
								Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킪鶬튮龰者운킸좺풼\uddbe귀ꛂ", a_), binding.Path.Path), global::System.Array.Empty<object>())
							});
							multiBinding3.Bindings.Add(new global::System.Windows.Data.Binding
							{
								Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킪鶬튮龰者운킸좺풼\uddbe귀ꛂ", a_), binding.Path.Path), global::System.Array.Empty<object>())
							});
							num = (short)791019520;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							if (binding2 != null)
							{
								num = (short)466288646;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_24B;
							}
							continue;
						case 6:
							multiBinding2.Bindings.Add(new global::System.Windows.Data.Binding
							{
								Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킪鶬튮龰者운킸좺풼\uddbe귀ꛂ", a_), binding2.Path.Path), global::System.Array.Empty<object>())
							});
							multiBinding3.Bindings.Add(new global::System.Windows.Data.Binding
							{
								Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킪鶬튮龰者운킸좺풼\uddbe귀ꛂ", a_), binding2.Path.Path), global::System.Array.Empty<object>())
							});
							num = (short)1765670913;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_48A;
						case 8:
						{
							global::System.Windows.Data.Binding binding;
							if (binding != null)
							{
								num = (short)9961475;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_250;
						}
						case 9:
							num = (short)1541144583;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
						IL_250:
						binding2 = global::System.Windows.Data.BindingOperations.GetBinding(target, global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2Property);
						num = (short)768671748;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2E4:
						num = (short)1959460866;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_24B:
						goto IL_2E4;
					}
					IL_48A:
					goto IL_1C9;
				}
				finally
				{
					num = (short)125829121;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
				for (;;)
				{
					IL_1C9:
					base.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header1VisibilityPorperty, multiBinding);
					base.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header2VisibilityPorperty, multiBinding2);
					base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, multiBinding3);
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields>.Enumerator enumerator2 = list.GetEnumerator())
					{
						num = (short)859242497;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_1B6;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_D7;
								}
								continue;
							case 2:
							{
								num = (short)1242952204;
								short num4 = num;
								num = (short)157938188;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_F7;
								default:
									num = (short)725549056;
									if (num != 0)
									{
									}
									num = (short)1131347968;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									goto IL_F7;
								}
								global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields rmspecialEditorFor2Fields = enumerator2.Current;
								rmspecialEditorFor2Fields.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field1VisibilityProperty, multiBinding);
								rmspecialEditorFor2Fields.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields.Field2VisibilityProperty, multiBinding2);
								num = (short)1339424772;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_D9:
							num = (short)1556021251;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_D7:
							goto IL_D9;
							IL_F7:
							num = (short)537001986;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1B6:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0002208C File Offset: 0x0002028C
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00022148 File Offset: 0x00020348
		public string Header1
		{
			get
			{
				short num = (short)1570643141;
				short num2 = num;
				num = (short)1859460293;
				switch (num2 == num)
				{
				}
				num = (short)1986527233;
				if (num != 0)
				{
				}
				num = (short)957546496;
				if (num != 0)
				{
				}
				num = (short)1919549440;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header1Property);
			}
			set
			{
				short num = (short)466225915;
				short num2 = num;
				num = (short)50072315;
				switch (num2 == num)
				{
				}
				num = (short)159186945;
				if (num != 0)
				{
				}
				num = (short)1336737792;
				if (num != 0)
				{
				}
				num = (short)4849664;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header1Property, value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000221FC File Offset: 0x000203FC
		// (set) Token: 0x06000206 RID: 518 RVA: 0x000222B4 File Offset: 0x000204B4
		public global::System.Windows.Visibility Header1Visibility
		{
			get
			{
				short num = (short)752421159;
				short num2 = num;
				num = (short)1547634983;
				switch (num2 == num)
				{
				}
				num = (short)1627979777;
				if (num != 0)
				{
				}
				num = (short)1206583296;
				if (num != 0)
				{
				}
				num = (short)1180368896;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header1VisibilityPorperty);
			}
			set
			{
				short num = (short)1493757761;
				short num2 = num;
				num = (short)509013825;
				switch (num2 == num)
				{
				}
				num = (short)880214017;
				if (num != 0)
				{
				}
				num = (short)815595520;
				if (num != 0)
				{
				}
				num = (short)729808896;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header1VisibilityPorperty, value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00022370 File Offset: 0x00020570
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0002242C File Offset: 0x0002062C
		public string Header2
		{
			get
			{
				short num = (short)1655003872;
				short num2 = num;
				num = (short)1571248864;
				switch (num2 == num)
				{
				}
				num = (short)345440256;
				if (num != 0)
				{
				}
				num = (short)1183776769;
				if (num != 0)
				{
				}
				num = (short)2087256064;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header2Property);
			}
			set
			{
				short num = (short)457834497;
				if (num != 0)
				{
				}
				num = (short)2056211855;
				short num2 = num;
				num = (short)2142588303;
				switch (num2 == num)
				{
				}
				num = (short)169541632;
				if (num != 0)
				{
				}
				num = (short)206962688;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header2Property, value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000224E4 File Offset: 0x000206E4
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0002259C File Offset: 0x0002079C
		public global::System.Windows.Visibility Header2Visibility
		{
			get
			{
				short num = (short)2068352184;
				short num2 = num;
				num = (short)234392760;
				switch (num2 == num)
				{
				}
				num = (short)2009530369;
				if (num != 0)
				{
				}
				num = (short)493813760;
				if (num != 0)
				{
				}
				num = (short)1025638400;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header2VisibilityPorperty);
			}
			set
			{
				short num = (short)1674837573;
				short num2 = num;
				num = (short)1009843781;
				switch (num2 == num)
				{
				}
				num = (short)568786945;
				if (num != 0)
				{
				}
				num = (short)776601600;
				if (num != 0)
				{
				}
				num = (short)2085289984;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header2VisibilityPorperty, value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00022654 File Offset: 0x00020854
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00022710 File Offset: 0x00020910
		public string Header3
		{
			get
			{
				short num = (short)795398472;
				short num2 = num;
				num = (short)625267016;
				switch (num2 == num)
				{
				}
				num = (short)1631453184;
				if (num != 0)
				{
				}
				num = (short)2132148225;
				if (num != 0)
				{
				}
				num = (short)1185349632;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header3Property);
			}
			set
			{
				short num = (short)1378979912;
				short num2 = num;
				num = (short)553881672;
				switch (num2 == num)
				{
				}
				num = (short)219086849;
				if (num != 0)
				{
				}
				num = (short)1183907840;
				if (num != 0)
				{
				}
				num = (short)1569587200;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHeaderContentControl.Header3Property, value);
			}
		}

		// Token: 0x0400008F RID: 143
		public static readonly global::System.Windows.DependencyProperty Header1Property;

		// Token: 0x04000090 RID: 144
		public static readonly global::System.Windows.DependencyProperty Header1VisibilityPorperty;

		// Token: 0x04000091 RID: 145
		public static readonly global::System.Windows.DependencyProperty Header2Property;

		// Token: 0x04000092 RID: 146
		public static readonly global::System.Windows.DependencyProperty Header2VisibilityPorperty;

		// Token: 0x04000093 RID: 147
		public static readonly global::System.Windows.DependencyProperty Header3Property;
	}
}
