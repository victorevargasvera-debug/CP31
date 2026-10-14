using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000106 RID: 262
	public class RMBoolFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060007D0 RID: 2000 RVA: 0x0007EE7C File Offset: 0x0007D07C
		public RMBoolFieldEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0007EE98 File Offset: 0x0007D098
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x0007EF54 File Offset: 0x0007D154
		public bool IsValueTextBlack
		{
			get
			{
				short num = (short)782407840;
				short num2 = num;
				num = (short)1683986592;
				switch (num2 == num)
				{
				}
				num = (short)2135883776;
				short num3 = num;
				num = (short)750649345;
				if (num != 0)
				{
				}
				num = (short)1037041664;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsValueTextBlackProperty);
			}
			set
			{
				short num = (short)414229939;
				short num2 = num;
				num = (short)1300342195;
				switch (num2 == num)
				{
				}
				num = (short)20840448;
				short num3 = num;
				num = (short)413597696;
				if (num != 0)
				{
				}
				num = (short)928645121;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsValueTextBlackProperty, value);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0007F010 File Offset: 0x0007D210
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x0007F0C8 File Offset: 0x0007D2C8
		public bool IsEditorOnly
		{
			get
			{
				short num = (short)693547988;
				short num2 = num;
				num = (short)940815316;
				switch (num2 == num)
				{
				}
				num = (short)1149108224;
				if (num != 0)
				{
				}
				num = (short)446693377;
				if (num != 0)
				{
				}
				num = (short)1804271616;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsEditorOnlyProperty);
			}
			set
			{
				short num = (short)850579003;
				short num2 = num;
				num = (short)521719355;
				switch (num2 == num)
				{
				}
				num = (short)1677459456;
				if (num != 0)
				{
				}
				num = (short)1324285953;
				if (num != 0)
				{
				}
				num = (short)171900928;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsEditorOnlyProperty, value);
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0007F184 File Offset: 0x0007D384
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			if (!(bool)A_1.NewValue)
			{
				short num = (short)1981022209;
				if (num != 0)
				{
				}
				num = (short)217079955;
				short num2 = num;
				num = (short)1610834067;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AF;
				case 1:
					break;
				default:
				{
					num = (short)683016192;
					short num3 = num;
					break;
				}
				}
				num = (short)1814888448;
				if (num != 0)
				{
				}
				return;
			}
			IL_AF:
			global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor rmboolFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)A_0;
			rmboolFieldEditor.grdMain.ColumnDefinitions[0].Width = new global::System.Windows.GridLength(0.0);
			rmboolFieldEditor.grdMain.ColumnDefinitions[1].Width = new global::System.Windows.GridLength(0.0);
			rmboolFieldEditor.grdMain.ColumnDefinitions[3].Width = global::System.Windows.GridLength.Auto;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0007F2AC File Offset: 0x0007D4AC
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1580271254;
			short num2 = num;
			num = (short)329385622;
			switch (num2 == num)
			{
			}
			num = (short)197722113;
			if (num != 0)
			{
			}
			num = (short)1464729600;
			if (num != 0)
			{
			}
			num = (short)1209008128;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0007F378 File Offset: 0x0007D578
		public override void SetFocus()
		{
			short num = (short)1299244923;
			short num2 = num;
			num = (short)810739579;
			switch (num2 == num)
			{
			}
			num = (short)131727360;
			if (num != 0)
			{
			}
			num = (short)1404370945;
			if (num != 0)
			{
			}
			num = (short)560332800;
			short num3 = num;
			this.cbxField.Focus();
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0007F42C File Offset: 0x0007D62C
		public override void SetCellValuePresenterMode()
		{
			short num = (short)50482289;
			short num2 = num;
			num = (short)197086321;
			switch (num2 == num)
			{
			}
			num = (short)1800536064;
			if (num != 0)
			{
			}
			num = (short)12845057;
			if (num != 0)
			{
			}
			num = (short)593100800;
			short num3 = num;
			this.cbxField.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0007F4DC File Offset: 0x0007D6DC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (this._contentLoaded)
			{
				short num = (short)105018582;
				short num2 = num;
				num = (short)2120119510;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)925564928;
					short num3 = num;
					num = (short)1379467265;
					if (num != 0)
					{
					}
					num = (short)1904869376;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("誤욨\udfaa슬\uddae\udeb0\udfb2풴馶視풺킼튾껀귂蛄韆髈鿌껎뗐뫒뫔髖룘뗚볜룞蓠転胤触鷨엪껬胮鿰蟲蟴飶闸裺웼鳾渀渂甄栆月渊挌笎㸐昒昔爖欘砚爜焞唠儢䨤䬦娨Ъ䬬䘮吰弲儴制崸刺䤼倾㍀あ橄㕆⑈⥊≌⁎㵐㕒㱔㉖㕘㽚㡜㭞ࡠᝢ੤ᕦ䝨፪౬ɮᵰ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0007F5C0 File Offset: 0x0007D7C0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)744688593;
			short num2 = num;
			num = (short)1659964369;
			switch (num2 == num)
			{
			}
			num = (short)1094844417;
			if (num != 0)
			{
			}
			num = (short)67371008;
			if (num != 0)
			{
			}
			num = (short)1073086464;
			short num3 = num;
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0007F674 File Offset: 0x0007D874
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)117571586;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_105;
				case 1:
					num = (short)1521418240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1600634471;
				short num3 = num;
				num = (short)1374797415;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_105;
				default:
					num = (short)674627584;
					if (num != 0)
					{
					}
					num = (short)721420289;
					if (num != 0)
					{
					}
					switch (connectionId)
					{
					case 1:
						goto IL_E1;
					case 2:
						goto IL_D4;
					case 3:
						goto IL_131;
					default:
						num = (short)1004339201;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_D4:
			this.cbxField = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_E1:
			this.grdMain = (global::System.Windows.Controls.Grid)target;
			return;
			IL_105:
			num = (short)675414016;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_131:
			this.btnLock = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0007F7C8 File Offset: 0x0007D9C8
		// Note: this type is marked as 'beforefieldinit'.
		static RMBoolFieldEditor()
		{
			int a_ = 0;
			short num = (short)1449181020;
			short num2 = num;
			num = (short)1089322844;
			switch (num2 == num)
			{
			}
			num = (short)939458561;
			if (num != 0)
			{
			}
			num = (short)555417600;
			if (num != 0)
			{
			}
			num = (short)1178730496;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsValueTextBlackProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톗쪛ﾝ첟힡솣춧튩\ud8ab\udcaf펱ힳ\uddb5", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsEditorOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톗\ud99b瞧즟횡쮣풥쒩삫힭", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.a)));
		}

		// Token: 0x0400038D RID: 909
		public static readonly global::System.Windows.DependencyProperty IsValueTextBlackProperty;

		// Token: 0x0400038E RID: 910
		public static readonly global::System.Windows.DependencyProperty IsEditorOnlyProperty;

		// Token: 0x0400038F RID: 911
		internal global::System.Windows.Controls.Grid grdMain;

		// Token: 0x04000390 RID: 912
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox cbxField;

		// Token: 0x04000391 RID: 913
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnLock;

		// Token: 0x04000392 RID: 914
		private bool _contentLoaded;
	}
}
