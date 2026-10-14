using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200001C RID: 28
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROSystemMainRegion")]
	public class SystemsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public SystemsView()
		{
			this.InitializeComponent();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.AstroSystemColumnInfo = this.b();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.AstroSystemColumnOnUIInfo = this.a();
		}

		// Token: 0x17000021 RID: 33
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000BD18 File Offset: 0x00009F18
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemsViewModel ViewModel
		{
			set
			{
				short num = (short)2064171081;
				short num2 = num;
				num = (short)1191952457;
				switch (num2 == num)
				{
				}
				num = (short)791019520;
				if (num != 0)
				{
				}
				num = (short)59637761;
				if (num != 0)
				{
				}
				num = (short)1415643136;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)92652124;
			short num2 = num;
			num = (short)277987932;
			switch (num2 == num)
			{
			}
			num = (short)1872101377;
			if (num != 0)
			{
			}
			num = (short)687734784;
			if (num != 0)
			{
			}
			num = (short)1678835712;
			short num3 = num;
			this.dgrSystems.HideColumn((global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration) ? global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("첗ﾙ첟쎡킣쎥쮩솫쮭", a_) : global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udb97즟얡톣풥즧\udea9얫솭\udeafﲱ햳\udbb5\uddb7", a_));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> b()
		{
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> list;
			for (;;)
			{
				IL_00:
				short num = (short)1467809792;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					global::Infragistics.Windows.DataPresenter.FieldCollection fields;
					global::System.Reflection.PropertyInfo[] properties;
					for (;;)
					{
						IL_29:
						num = (short)2001076224;
						short num3 = num;
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator;
						switch (num2)
						{
						case 0:
						{
							num = (short)735078924;
							short num4 = num;
							num = (short)1774545420;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)505479168;
								if (num != 0)
								{
								}
								if (fields != null)
								{
									num = (short)1221656578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return list;
							}
							break;
						}
						case 1:
							try
							{
								num = (short)1030619138;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1B3;
									case 1:
									{
										global::System.Reflection.PropertyInfo propertyInfo;
										global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array = propertyInfo.GetCustomAttributes(typeof(global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute), false) as global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[];
										num = (short)274661389;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1AE;
										}
										continue;
									case 3:
										num = (short)1495203845;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::Infragistics.Windows.DataPresenter.Field field;
										string uiLable = field.Label as string;
										string name = field.Name;
										global::System.Reflection.PropertyInfo[] array2 = properties;
										int num5 = 0;
										num = (short)210960384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array;
										if (array.Length == 1)
										{
											num = (short)291307532;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										global::System.Reflection.PropertyInfo[] array2;
										int num5;
										if (num5 >= array2.Length)
										{
											num = (short)711786510;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Reflection.PropertyInfo propertyInfo = array2[num5];
										num = (short)1558708239;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1749549067;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Infragistics.Windows.DataPresenter.Field field = enumerator.Current;
										num = (short)788725776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										goto IL_40E;
									case 10:
										goto IL_1B3;
									case 11:
										num = (short)1314521097;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
									{
										global::System.Reflection.PropertyInfo propertyInfo;
										global::System.Type propertyType = propertyInfo.PropertyType;
										global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array;
										string uiLable;
										global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo item = new global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo(array[0].EntiytMemberName, uiLable, null, propertyType);
										list.Add(item);
										num = (short)29360135;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 13:
									{
										global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array;
										if (array != null)
										{
											num = (short)792723459;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 15:
									{
										global::System.Reflection.PropertyInfo propertyInfo;
										string name;
										if (propertyInfo.Name == name)
										{
											num = (short)1598423041;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										int num5;
										num5++;
										num = (short)173539338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
									{
										global::Infragistics.Windows.DataPresenter.Field field;
										if (field.Visibility == global::System.Windows.Visibility.Visible)
										{
											num = (short)1011941380;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_1AE;
									IL_1B3:
									num = (short)220135430;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_268:
									num = (short)226230280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1AE:
									goto IL_268;
								}
								IL_40E:
								return list;
							}
							finally
							{
								num = (short)776798208;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_445;
										}
										continue;
									case 1:
										goto IL_47C;
									case 2:
										enumerator.Dispose();
										num = (short)590872577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_445:
									if (enumerator == null)
									{
										break;
									}
									num = (short)29622274;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_47C:;
							}
							goto IL_47F;
						case 2:
							num = (short)1487536129;
							if (num != 0)
							{
							}
							goto IL_47F;
						}
						break;
						IL_47F:
						enumerator = fields.GetEnumerator();
						num = (short)1658257409;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_65:
					fields = this.dgrSystems.FieldLayouts[0].Fields;
					properties = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem).GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo>();
					num = (short)770310144;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
			}
			return list;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000C380 File Offset: 0x0000A580
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> a()
		{
			short num = (short)2115003355;
			short num2 = num;
			num = (short)924345307;
			switch (num2 == num)
			{
			}
			num = (short)1476460545;
			if (num != 0)
			{
			}
			num = (short)905904128;
			if (num != 0)
			{
			}
			num = (short)1916731392;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.GetColumOnUI(this.dgrSystems);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000C434 File Offset: 0x0000A634
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 5;
			while (this._contentLoaded)
			{
				short num = (short)40693745;
				short num2 = num;
				num = (short)906686449;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)547291137;
					if (num != 0)
					{
					}
					num = (short)1793654784;
					if (num != 0)
					{
					}
					num = (short)1319436288;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("뢖풘펠첢즤욦螨슬슮\udcb0\udcb2\udbb4鎼ꃀꟂ계꣆蓈꫊ꏌ껎뛐뛒룔닖럘꿚點닠럢럤꣦뫨鋪黬鯮铰黲컴银雸雺跼郾漀昂欄猆☈砊琌簎攐瘒研搖漘爚砜栞ภ倢尤否崨个䀬尮䜰娲倴䀶᜸䌺尼刾ⵀ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000C518 File Offset: 0x0000A718
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)44367874;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)334626816;
				short num3 = num;
				num = (short)1668713614;
				short num4 = num;
				num = (short)800558222;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1702625280;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)1140981764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1609760771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1232470017;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D2;
						}
						continue;
					case 3:
						goto IL_13A;
					case 4:
						goto IL_120;
					}
					IL_D2:
					if (connectionId != 1)
					{
						num = (short)1418592257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF;
				}
				IL_13A:
				if (connectionId == 2)
				{
					goto IL_157;
				}
				num = (short)2140078080;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			((global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemsView)target).Loaded += this.a;
			return;
			IL_120:
			this._contentLoaded = true;
			return;
			IL_157:
			this.dgrSystems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x0400004D RID: 77
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrSystems;

		// Token: 0x0400004E RID: 78
		private bool _contentLoaded;
	}
}
