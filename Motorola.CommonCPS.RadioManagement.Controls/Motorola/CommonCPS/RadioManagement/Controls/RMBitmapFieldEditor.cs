using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000CE RID: 206
	public class RMBitmapFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x0005A950 File Offset: 0x00058B50
		public RMBitmapFieldEditor()
		{
			this.InitializeComponent();
			base.AlignMainGridMaxWithEditor(this, this.grdMain);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0005A978 File Offset: 0x00058B78
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0005AA30 File Offset: 0x00058C30
		public bool IsEditorOnly
		{
			get
			{
				short num = (short)370409473;
				if (num != 0)
				{
				}
				num = (short)1579178162;
				short num2 = num;
				num = (short)2022463666;
				switch (num2 == num)
				{
				}
				num = (short)679411712;
				short num3 = num;
				num = (short)1097793536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBitmapFieldEditor.IsEditorOnlyProperty);
			}
			set
			{
				short num = (short)1706360833;
				if (num != 0)
				{
				}
				num = (short)1183291894;
				short num2 = num;
				num = (short)418814454;
				switch (num2 == num)
				{
				}
				num = (short)751960064;
				short num3 = num;
				num = (short)1992687616;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBitmapFieldEditor.IsEditorOnlyProperty, value);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0005AAEC File Offset: 0x00058CEC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			while (!(bool)A_1.NewValue)
			{
				short num = (short)1812529152;
				short num2 = num;
				num = (short)409438601;
				short num3 = num;
				num = (short)497715593;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)971964417;
					if (num != 0)
					{
					}
					num = (short)876019712;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor rmboolFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)A_0;
			rmboolFieldEditor.grdMain.ColumnDefinitions[0].Width = new global::System.Windows.GridLength(0.0);
			rmboolFieldEditor.grdMain.ColumnDefinitions[1].Width = new global::System.Windows.GridLength(0.0);
			rmboolFieldEditor.grdMain.ColumnDefinitions[3].Width = global::System.Windows.GridLength.Auto;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0005AC14 File Offset: 0x00058E14
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1951662081;
			if (num != 0)
			{
			}
			num = (short)493023527;
			short num2 = num;
			num = (short)2113073447;
			switch (num2 == num)
			{
			}
			num = (short)456327168;
			short num3 = num;
			num = (short)1418985472;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0005ACE0 File Offset: 0x00058EE0
		private void ToggleButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)436142080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				int num3;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair> observableCollection;
				char[] array;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_150;
					case 1:
						goto IL_C6;
					case 2:
						num = (short)49545217;
						if (num != 0)
						{
						}
						if (num3 >= observableCollection.Count)
						{
							num = (short)665845760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num3] = observableCollection[num3].Value;
						num3++;
						num = (short)1297874947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_C6;
					}
					goto IL_3E;
					IL_C6:
					num = (short)1184694272;
					short num4 = num;
					num = (short)1874067458;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_150:
				goto IL_188;
				IL_3E:
				observableCollection = (this.iclBitMap.ItemsSource as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Controls.NumericFieldToBitmapItemSrouceConverter.ValuePair>);
				array = new char[observableCollection.Count];
				num3 = 0;
				num = (short)1465967616;
				short num5 = num;
				num = (short)547742720;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_188:
					global::System.Array.Reverse(array);
					string value = new string(array);
					int value2 = global::System.Convert.ToInt32(value, 2);
					global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit numericEdit = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit;
					numericEdit.Value = value2;
					return;
				}
				default:
					num = (short)1307901952;
					if (num != 0)
					{
					}
					num = (short)1361903617;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0005AEA4 File Offset: 0x000590A4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num;
			while (this._contentLoaded)
			{
				num = (short)642580480;
				short num2 = num;
				num = (short)677011942;
				short num3 = num;
				num = (short)898654694;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)676593664;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1438777345;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꯧ藩苫髭苯鷱飳藵쏷駹鏻鏽烿洁樃挅昇縉⌋笍挏眑易甕眗琙栛氝伟両圣थ丧䌩䤫䈭启圱倳張䰷唹主䴽漿ぁ⥃⑅ⅇ㹉⅋⽍⁏㑑㵓㍕㑗㹙㥛㩝य़ᙡୣᑥ䙧ቩ൫ͭᱯ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0005AF84 File Offset: 0x00059184
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)890045762;
			short num2 = num;
			num = (short)1838024002;
			switch (num2 == num)
			{
			}
			num = (short)1316880385;
			if (num != 0)
			{
			}
			num = (short)2000551936;
			short num3 = num;
			num = (short)1786445824;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0005B038 File Offset: 0x00059238
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			for (;;)
			{
				IL_00:
				short num = (short)370016256;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
					{
						num = (short)664076288;
						short num3 = num;
						num = (short)1208044304;
						short num4 = num;
						num = (short)353258256;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1561657345;
							if (num != 0)
							{
							}
							num = (short)1905262592;
							if (num != 0)
							{
							}
							num = (short)1470758914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_12A;
					}
					IL_31:
					switch (connectionId)
					{
					case 1:
						goto IL_139;
					case 2:
						goto IL_105;
					case 3:
						goto IL_F8;
					case 4:
						goto IL_12C;
					default:
						num = (short)2082013185;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_F8:
			this.iclBitMap = (global::System.Windows.Controls.ItemsControl)target;
			return;
			IL_105:
			this.grdMain = (global::System.Windows.Controls.Grid)target;
			return;
			IL_12A:
			this._contentLoaded = true;
			return;
			IL_12C:
			this.btnLock = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_139:
			this.fedBitmap = (global::Motorola.CommonCPS.RadioManagement.Controls.RMBitmapFieldEditor)target;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0005B194 File Offset: 0x00059394
		// Note: this type is marked as 'beforefieldinit'.
		static RMBitmapFieldEditor()
		{
			int a_ = 15;
			short num = (short)1382574767;
			short num2 = num;
			num = (short)784165551;
			switch (num2 == num)
			{
			}
			num = (short)1779367936;
			if (num != 0)
			{
			}
			num = (short)110952448;
			short num3 = num;
			num = (short)568459265;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMBitmapFieldEditor.IsEditorOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udaa8즬욮얰\udcb2잴ힸힺ쒼", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMBitmapFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMBitmapFieldEditor.a)));
		}

		// Token: 0x0400025E RID: 606
		public static readonly global::System.Windows.DependencyProperty IsEditorOnlyProperty;

		// Token: 0x0400025F RID: 607
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMBitmapFieldEditor fedBitmap;

		// Token: 0x04000260 RID: 608
		internal global::System.Windows.Controls.Grid grdMain;

		// Token: 0x04000261 RID: 609
		internal global::System.Windows.Controls.ItemsControl iclBitMap;

		// Token: 0x04000262 RID: 610
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnLock;

		// Token: 0x04000263 RID: 611
		private bool _contentLoaded;
	}
}
