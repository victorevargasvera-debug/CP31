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

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x0200000B RID: 11
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTRODataProfileMainRegion")]
	public class DataProfilesView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00003EE8 File Offset: 0x000020E8
		public DataProfilesView()
		{
			this.InitializeComponent();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.DataProfileColumnInfo = this.b();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.DataProfileColumnOnUIInfo = this.a();
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00003F18 File Offset: 0x00002118
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.DataProfilesViewModel ViewModel
		{
			set
			{
				short num = (short)1779684515;
				short num2 = num;
				num = (short)1894569123;
				switch (num2 == num)
				{
				}
				num = (short)1141702657;
				if (num != 0)
				{
				}
				num = (short)2043019264;
				short num3 = num;
				num = (short)1755709440;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003FCC File Offset: 0x000021CC
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
			{
				short num = (short)100794369;
				if (num != 0)
				{
				}
				num = (short)1491368455;
				short num2 = num;
				num = (short)1886878215;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1102839808;
					if (num != 0)
					{
					}
					num = (short)1278410752;
					short num3 = num;
					this.dgrDataProfiles.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﺩ즫쎭삯\udeb1햳습\uddb7\uddbb펽ꖿ", a_));
					return;
				}
				}
			}
			this.dgrDataProfiles.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쎫삭횯\udbb1펳쎵쪷\udbb9좻ힽ꾿곁諃Ʂꗇ꿉", a_));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000040C0 File Offset: 0x000022C0
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> b()
		{
			short num = (short)1758724097;
			if (num != 0)
			{
			}
			num = (short)1036648448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A4;
				}
				global::Infragistics.Windows.DataPresenter.FieldCollection fieldCollection;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> list;
				global::System.Reflection.PropertyInfo[] array3;
				for (;;)
				{
					IL_51:
					global::Infragistics.Windows.DataPresenter.Field field;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_1C1;
					case 1:
					{
						int num3;
						global::System.Reflection.PropertyInfo[] array;
						if (num3 >= array.Length)
						{
							num = (short)303497226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.PropertyInfo propertyInfo = array[num3];
						num = (short)1037172749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (field.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1854734348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C1;
					case 3:
						if (num4 >= fieldCollection.Count)
						{
							num = (short)135921670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_175;
					case 4:
						goto IL_2B7;
					case 5:
						num = (short)1332019211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return list;
					case 7:
						if (fieldCollection != null)
						{
							num = (short)897318927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 8:
					{
						global::System.Reflection.PropertyInfo propertyInfo2;
						global::System.Type propertyType = propertyInfo2.PropertyType;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array2;
						string uiLable;
						global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo item = new global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo(array2[0].EntiytMemberName, uiLable, null, propertyType);
						list.Add(item);
						num = (short)156303360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array2;
						if (array2 != null)
						{
							num = (short)178585605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C1;
					}
					case 10:
						goto IL_1C1;
					case 11:
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array2;
						if (array2.Length == 1)
						{
							num = (short)912130056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C1;
					}
					case 12:
					{
						string uiLable = field.Label as string;
						string name = field.Name;
						global::System.Reflection.PropertyInfo[] array = array3;
						int num3 = 0;
						num = (short)882704398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						string name;
						if (propertyInfo.Name == name)
						{
							num = (short)247267344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)280363026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_273;
					case 15:
						num4 = 0;
						num = (short)874315793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						global::System.Reflection.PropertyInfo propertyInfo2 = propertyInfo;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array2 = propertyInfo2.GetCustomAttributes(typeof(global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute), false) as global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[];
						num = (short)1343356937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_2B7;
					case 18:
						goto IL_273;
					}
					goto IL_A4;
					IL_175:
					field = fieldCollection[num4];
					num = (short)1324941314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C1:
					num = (short)733609984;
					short num5 = num;
					num = (short)1250349071;
					short num6 = num;
					num = (short)425971727;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_175;
					default:
						num = (short)560332800;
						if (num != 0)
						{
						}
						num4++;
						num = (short)370737156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_273:
					num = (short)207683585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B7:
					num = (short)723779587;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_A4:
				fieldCollection = null;
				array3 = null;
				fieldCollection = this.dgrDataProfiles.FieldLayouts[0].Fields;
				array3 = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile).GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo>();
				num = (short)1805320199;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000044F0 File Offset: 0x000026F0
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> a()
		{
			short num = (short)65077249;
			if (num != 0)
			{
			}
			num = (short)1809055744;
			short num2 = num;
			num = (short)1819179612;
			short num3 = num;
			num = (short)486177372;
			switch (num3 == num)
			{
			}
			num = (short)572129280;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.GetColumOnUI(this.dgrDataProfiles);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000045A4 File Offset: 0x000027A4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 0;
			short num = (short)236257280;
			short num2 = num;
			if (this._contentLoaded)
			{
				num = (short)1751369351;
				short num3 = num;
				num = (short)1601422983;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)202964992;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1973813249;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("늜튞캠힢쪤햦욨잪첬膮\udcb2\ud8b4\udab6횸햺ﺼ鋀韄ꛆ귈ꋊꋌ苎냐뷒듔냖볘뛚룜뇞闠췢ꓤ듦뷨맪ꋬ꯮郰蟲铴ꟶ诸铺鯼雾洀昂㸄搆昈昊紌怎缐瘒笔挖㘘缚簜欞䀠匢圤䠦伨䈪䄬䨮䈰䔲尴制丸ᐺ夼帾㕀≂㕄㕆♈ⵊ⑌⍎㑐⁒⍔㹖㱘ⱚ獜❞`๢।", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004684 File Offset: 0x00002884
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1285423105;
			if (num != 0)
			{
			}
			num = (short)1323349503;
			short num2 = num;
			num = (short)102741503;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_137:
				num = (short)1635778561;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)375848960;
				if (num != 0)
				{
				}
				num = (short)827916291;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)1916469248;
					short num4 = num;
					num = (short)1100349442;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)2022375428;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_133;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_A7;
					}
					continue;
				case 4:
					goto IL_EE;
				}
				IL_A7:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1303707648;
				num3 = (int)((global::System.IntPtr)num);
			}
			((global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.DataProfilesView)target).Loaded += this.a;
			return;
			IL_EE:
			this._contentLoaded = true;
			return;
			IL_133:
			if (connectionId != 2)
			{
				goto IL_137;
			}
			this.dgrDataProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x0400000F RID: 15
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrDataProfiles;

		// Token: 0x04000010 RID: 16
		private bool _contentLoaded;
	}
}
