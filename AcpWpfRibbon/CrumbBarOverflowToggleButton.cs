using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200002E RID: 46
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CrumbBarOverflowToggleButton : global::System.Windows.Controls.Primitives.ToggleButton
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0004AFDC File Offset: 0x000491DC
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0004B098 File Offset: 0x00049298
		public bool IsPressedState
		{
			get
			{
				short num = (short)1667825665;
				if (num != 0)
				{
				}
				num = (short)1847442335;
				short num2 = num;
				num = (short)718650271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1262813184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)302972928;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarOverflowToggleButton.IsPressedStateProperty);
			}
			set
			{
				short num = (short)1700855809;
				if (num != 0)
				{
				}
				num = (short)1488715106;
				short num2 = num;
				num = (short)779091298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)872808448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)944373760;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarOverflowToggleButton.IsPressedStateProperty, value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0004B150 File Offset: 0x00049350
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0004B20C File Offset: 0x0004940C
		public bool IsMouseOverState
		{
			get
			{
				short num = (short)1514274817;
				if (num != 0)
				{
				}
				num = (short)1162486916;
				short num2 = num;
				num = (short)1051206788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1253244928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1046806528;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarOverflowToggleButton.IsMouseOverStateProperty);
			}
			set
			{
				short num = (short)535232513;
				if (num != 0)
				{
				}
				num = (short)502305547;
				short num2 = num;
				num = (short)1582666507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)840433664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)259260416;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarOverflowToggleButton.IsMouseOverStateProperty, value);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0004B2C8 File Offset: 0x000494C8
		private void UpdatePressed()
		{
			short num = (short)1050935297;
			if (num != 0)
			{
			}
			num = (short)375928042;
			short num2 = num;
			num = (short)1651324138;
			switch (num2 == num)
			{
			default:
			{
				num = (short)549322752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2016018432;
			if (num != 0)
			{
			}
			this.IsPressedState = (base.IsChecked.Value || this._IsLeftMouseButtonDown);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0004B394 File Offset: 0x00049594
		protected override void OnChecked(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1546524267;
			short num2 = num;
			num = (short)827004523;
			switch (num2 == num)
			{
			}
			num = (short)1992425472;
			short num3 = num;
			num = (short)588513281;
			if (num != 0)
			{
			}
			num = (short)1161560064;
			if (num != 0)
			{
			}
			this.UpdateIsMouseOverState();
			this.UpdatePressed();
			base.OnChecked(e);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0004B450 File Offset: 0x00049650
		protected override void OnUnchecked(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1644811254;
			short num2 = num;
			num = (short)675009526;
			switch (num2 == num)
			{
			}
			num = (short)2049703937;
			if (num != 0)
			{
			}
			num = (short)70451200;
			short num3 = num;
			num = (short)680722432;
			if (num != 0)
			{
			}
			this.UpdateIsMouseOverState();
			this.UpdatePressed();
			base.OnUnchecked(e);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0004B50C File Offset: 0x0004970C
		// (set) Token: 0x06000368 RID: 872 RVA: 0x0004B5B8 File Offset: 0x000497B8
		private bool IsLeftMouseButtonDown
		{
			get
			{
				short num = (short)655684695;
				short num2 = num;
				num = (short)843379799;
				switch (num2 == num)
				{
				}
				num = (short)2039808001;
				if (num != 0)
				{
				}
				num = (short)1957691392;
				short num3 = num;
				num = (short)676397056;
				if (num != 0)
				{
				}
				return this._IsLeftMouseButtonDown;
			}
			set
			{
				short num = (short)934019074;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2000377494;
						short num3 = num;
						num = (short)1417696918;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32;
						case 1:
							break;
						default:
						{
							num = (short)627769344;
							short num4 = num;
							break;
						}
						}
						num = (short)1923481601;
						if (num != 0)
						{
						}
						num = (short)984219648;
						if (num != 0)
						{
						}
						this._IsLeftMouseButtonDown = value;
						this.UpdatePressed();
						num = (short)677642241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					if (this._IsLeftMouseButtonDown == value)
					{
						break;
					}
					num = (short)1926365184;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0004B6D8 File Offset: 0x000498D8
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1882914817;
			if (num != 0)
			{
			}
			this.IsLeftMouseButtonDown = true;
			if (base.IsChecked.Value)
			{
				num = (short)401102742;
				short num2 = num;
				num = (short)728848278;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1532952576;
					short num3 = num;
					num = (short)1942487040;
					if (num != 0)
					{
					}
					base.IsChecked = new bool?(false);
					base.ClickMode = global::System.Windows.Controls.ClickMode.Hover;
					base.OnMouseLeftButtonDown(e);
					base.ClickMode = global::System.Windows.Controls.ClickMode.Press;
					e.Handled = true;
					return;
				}
				}
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0004B7D0 File Offset: 0x000499D0
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)553713666;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1779630081;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1532755968;
					short num3 = num;
					num = (short)1866105179;
					short num4 = num;
					num = (short)67862875;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1409875968;
						if (num != 0)
						{
						}
						this.IsLeftMouseButtonDown = false;
						num = (short)504692737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_10F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				IL_59:
				if (e.ChangedButton != global::System.Windows.Input.MouseButton.Left)
				{
					break;
				}
				num = (short)1340866560;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			base.OnMouseUp(e);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0004B8F8 File Offset: 0x00049AF8
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1550703215;
					short num3 = num2;
					num2 = (short)1972755055;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1521418241;
						if (num2 != 0)
						{
						}
						num2 = (short)301989888;
						if (num2 != 0)
						{
						}
						num2 = (short)71565312;
						short num4 = num2;
						this.MouseOverInternal = true;
						break;
					}
					}
					num2 = (short)1983643649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_123;
				case 2:
					if (rect.Contains(e.GetPosition(this)))
					{
						num2 = (short)125829120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				}
				goto IL_1C;
			}
			IL_123:
			IL_125:
			base.OnMouseEnter(e);
			return;
			IL_1C:
			rect = new global::System.Windows.Rect(base.RenderSize);
			num2 = (short)454426626;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0004BA34 File Offset: 0x00049C34
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_125;
				case 1:
					goto IL_146;
				case 2:
					this.MouseOverInternal = true;
					num2 = (short)2104819713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					if (rect.Contains(e.GetPosition(this)))
					{
						num2 = (short)1597898754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)520880128;
					short num3 = num2;
					num2 = (short)1926486327;
					short num4 = num2;
					num2 = (short)961730871;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)672006145;
						if (num2 != 0)
						{
						}
						num2 = (short)1889533952;
						if (num2 != 0)
						{
						}
						this.MouseOverInternal = false;
						num2 = (short)1757151232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_125:
			IL_146:
			base.OnMouseMove(e);
			return;
			IL_20:
			rect = new global::System.Windows.Rect(base.RenderSize);
			num2 = (short)104923139;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0004BB90 File Offset: 0x00049D90
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0004BC44 File Offset: 0x00049E44
		private bool MouseOverInternal
		{
			get
			{
				short num = (short)1957523303;
				short num2 = num;
				num = (short)1866428263;
				switch (num2 == num)
				{
				}
				num = (short)755105793;
				if (num != 0)
				{
				}
				num = (short)1586823168;
				short num3 = num;
				num = (short)1217527808;
				if (num != 0)
				{
				}
				return this._MouseOverInternal;
			}
			set
			{
				short num = (short)620822533;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						bool? isChecked = base.IsChecked;
						num = (short)1441267713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						bool? isChecked;
						if (!isChecked.Value)
						{
							num = (short)335282183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						global::DevComponents.WpfRibbon.CrumbBar tree;
						if (tree != null)
						{
							num = (short)634978307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
						num = (short)2010578948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::DevComponents.WpfRibbon.CrumbBar tree;
						if (tree.IsMenuMode)
						{
							num = (short)1705771008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_48;
						}
						continue;
					case 6:
						return;
					case 7:
					{
						base.IsChecked = new bool?(true);
						num = (short)774044925;
						short num3 = num;
						num = (short)525466877;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)104136704;
							if (num != 0)
							{
							}
							num = (short)524484614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
					{
						num = (short)1471414272;
						short num4 = num;
						this._MouseOverInternal = value;
						this.UpdateIsMouseOverState();
						global::DevComponents.WpfRibbon.CrumbBar tree = this.GetTree();
						num = (short)1239941122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_48:
					if (this._MouseOverInternal == value)
					{
						break;
					}
					num = (short)1407123457;
					if (num != 0)
					{
					}
					num = (short)176881672;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0004BE54 File Offset: 0x0004A054
		private global::DevComponents.WpfRibbon.CrumbBar GetTree()
		{
			short num = (short)1720960284;
			short num2 = num;
			num = (short)213697820;
			switch (num2 == num)
			{
			}
			num = (short)1202978816;
			if (num != 0)
			{
			}
			num = (short)1645608960;
			short num3 = num;
			num = (short)951582721;
			if (num != 0)
			{
			}
			return base.TemplatedParent as global::DevComponents.WpfRibbon.CrumbBar;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0004BF0C File Offset: 0x0004A10C
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)456956188;
			short num2 = num;
			num = (short)967219484;
			switch (num2 == num)
			{
			}
			num = (short)1932525568;
			if (num != 0)
			{
			}
			num = (short)663355392;
			short num3 = num;
			num = (short)1306001409;
			if (num != 0)
			{
			}
			this.MouseOverInternal = false;
			base.OnMouseLeave(e);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0004BFC4 File Offset: 0x0004A1C4
		private void UpdateIsMouseOverState()
		{
			short num = (short)1529602789;
			short num2 = num;
			num = (short)1731846885;
			switch (num2 == num)
			{
			}
			num = (short)1560936449;
			if (num != 0)
			{
			}
			num = (short)353959936;
			short num3 = num;
			num = (short)381222912;
			if (num != 0)
			{
			}
			this.IsMouseOverState = (this._MouseOverInternal | base.IsChecked.Value);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0004C09C File Offset: 0x0004A29C
		// Note: this type is marked as 'beforefieldinit'.
		static CrumbBarOverflowToggleButton()
		{
			int a_ = 14;
			short num = (short)24579044;
			short num2 = num;
			num = (short)549784548;
			switch (num2 == num)
			{
			}
			num = (short)1041694721;
			if (num != 0)
			{
			}
			num = (short)238813184;
			short num3 = num;
			num = (short)1728184320;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.CrumbBarOverflowToggleButton.IsPressedStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⽥᭧㩩ṫ୭ͯűᅳት⭷๹ᵻ੽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarOverflowToggleButton), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfRibbon.CrumbBarOverflowToggleButton.IsMouseOverStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⽥᭧❩ͫ᭭ͯ᝱㭳uᵷࡹ⽻੽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarOverflowToggleButton), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000138 RID: 312
		public static readonly global::System.Windows.DependencyProperty IsPressedStateProperty;

		// Token: 0x04000139 RID: 313
		public static readonly global::System.Windows.DependencyProperty IsMouseOverStateProperty;

		// Token: 0x0400013A RID: 314
		private bool _IsLeftMouseButtonDown;

		// Token: 0x0400013B RID: 315
		private bool _MouseOverInternal;
	}
}
