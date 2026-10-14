using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000067 RID: 103
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorListInput : global::DevComponents.WpfEditors.Primitives.EditorInputBase
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00090D04 File Offset: 0x0008EF04
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1409484041;
			short num2 = num;
			num = (short)494011657;
			switch (num2 == num)
			{
			}
			num = (short)323158017;
			if (num != 0)
			{
			}
			num = (short)67043328;
			short num3 = num;
			num = (short)1156710400;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.Primitives.EditorListInput)A_0).OnAllowEmptyStateChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00090DD0 File Offset: 0x0008EFD0
		protected virtual void OnAllowEmptyStateChanged(bool oldValue, bool newValue)
		{
			short num = (short)98066576;
			short num2 = num;
			num = (short)2116968592;
			switch (num2 == num)
			{
			}
			num = (short)1519124481;
			if (num != 0)
			{
			}
			num = (short)1955659776;
			short num3 = num;
			num = (short)1116864512;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00090E78 File Offset: 0x0008F078
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00090F34 File Offset: 0x0008F134
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Category("Behavior")]
		public bool AllowEmptyState
		{
			get
			{
				short num = (short)1385908362;
				short num2 = num;
				num = (short)796149898;
				switch (num2 == num)
				{
				}
				num = (short)44826625;
				if (num != 0)
				{
				}
				num = (short)1467613184;
				short num3 = num;
				num = (short)1701642240;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorListInput.AllowEmptyStateProperty);
			}
			set
			{
				short num = (short)451179563;
				short num2 = num;
				num = (short)1849324587;
				switch (num2 == num)
				{
				}
				num = (short)1302331393;
				if (num != 0)
				{
				}
				num = (short)791543808;
				short num3 = num;
				num = (short)1196032000;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorListInput.AllowEmptyStateProperty, value);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00090FEC File Offset: 0x0008F1EC
		protected override void OnInputKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)213254145;
			if (num != 0)
			{
			}
			num = (short)1052114947;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.SelectPrevious();
					e.Handled = true;
					num = (short)1304231940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_187;
				case 2:
					this.SelectNext();
					e.Handled = true;
					num = (short)1243217921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 4:
					goto IL_F8;
				case 5:
				{
					num = (short)1356333056;
					short num3 = num;
					if (e.Key == global::System.Windows.Input.Key.Up)
					{
						num = (short)1101201408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_189;
				}
				}
				IL_64:
				num = (short)201203321;
				short num4 = num;
				num = (short)1151737465;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_187;
				default:
					num = (short)1604648960;
					if (num != 0)
					{
					}
					if (e.Key == global::System.Windows.Input.Key.Down)
					{
						num = (short)329318402;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)45219845;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_F8:
			IL_187:
			IL_189:
			base.OnInputKeyDown(e);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0009118C File Offset: 0x0008F38C
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			short num = (short)1923022849;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_13F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
				{
					num = (short)1238803871;
					short num3 = num;
					num = (short)354264479;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)896139264;
						if (num != 0)
						{
						}
						this.SelectNext();
						e.Handled = true;
						num = (short)2139226112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_CD;
				}
				IL_34:
				num = (short)1007222784;
				short num4 = num;
				num = (short)758841345;
				if (num != 0)
				{
				}
				if (e.Delta > 0)
				{
					num = (short)1793064962;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.SelectPrevious();
					e.Handled = true;
					num = (short)2096627715;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_CD:
			IL_13F:
			base.OnMouseWheel(e);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000912E4 File Offset: 0x0008F4E4
		protected override bool ValidateNewInputStack(string s)
		{
			short num = (short)1243611137;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					num = (short)1058275331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)552621732;
					short num3 = num;
					num = (short)868636324;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FE;
					default:
						num = (short)196935680;
						if (num != 0)
						{
						}
						num = (short)231669761;
						if (num != 0)
						{
						}
						if (!this.AllowEmptyState)
						{
							num = (short)536018944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12B;
					}
					break;
				}
				}
				IL_34:
				if (s.Length != 0)
				{
					goto IL_12B;
				}
				num = (short)617807874;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FE:
			num = (short)55443456;
			short num4 = num;
			return false;
			IL_12B:
			return base.ValidateNewInputStack(s);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00091424 File Offset: 0x0008F624
		public virtual void SelectNext()
		{
			short num = (short)825491457;
			if (num != 0)
			{
			}
			num = (short)563340048;
			short num2 = num;
			num = (short)322429712;
			switch (num2 == num)
			{
			}
			num = (short)1125122048;
			short num3 = num;
			num = (short)1306656768;
			if (num != 0)
			{
			}
			base.ResetInputStack();
			this.TextInputComplete(true);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000914DC File Offset: 0x0008F6DC
		public virtual void SelectPrevious()
		{
			short num = (short)873820966;
			short num2 = num;
			num = (short)264401702;
			switch (num2 == num)
			{
			}
			num = (short)1278214145;
			if (num != 0)
			{
			}
			num = (short)8257536;
			short num3 = num;
			num = (short)1098711040;
			if (num != 0)
			{
			}
			base.ResetInputStack();
			this.TextInputComplete(true);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00091590 File Offset: 0x0008F790
		protected override void ResetValue()
		{
			short num = (short)2102067200;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1393593740;
				short num3 = num;
				num = (short)2127138188;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1228865536;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)434241537;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					case 1:
						goto IL_113;
					case 2:
					{
						num = (short)999555072;
						short num4 = num;
						goto IL_EB;
					}
					}
					IL_A0:
					if (this.SetInputStack(""))
					{
						num = (short)1591607298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				}
				IL_EB:
				base.SetInputPosition(base.InputStack.Length);
				num = (short)1441857537;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_113:
			IL_115:
			base.ResetValue();
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000916B8 File Offset: 0x0008F8B8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num;
			int num3;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					num = (short)1240596480;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (this.GetRenderString().Length == 0)
						{
							num = (short)660602882;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return availableSize;
					case 1:
						goto IL_155;
					case 2:
						num = (short)1691353089;
						if (num != 0)
						{
						}
						this.a = availableSize;
						num = (short)2106851329;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46;
				}
				IL_155:
				num = (short)684282653;
				short num4 = num;
				num = (short)347493149;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CD;
				default:
					num = (short)495714304;
					if (num != 0)
					{
					}
					break;
				}
				return availableSize;
			}
			}
			IL_46:
			global::System.Windows.Media.FormattedText formattedText = new global::System.Windows.Media.FormattedText(this.GetMeasureString(), global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture(), global::System.Windows.FlowDirection.LeftToRight, new global::System.Windows.Media.Typeface(base.FontFamily, base.FontStyle, base.FontWeight, base.FontStretch), base.FontSize, base.Foreground);
			formattedText.BuildGeometry(new global::System.Windows.Point(0.0, 0.0));
			availableSize.Width = global::System.Math.Ceiling(formattedText.Width) + 1.0;
			availableSize.Height = global::System.Math.Ceiling(formattedText.Height);
			IL_CD:
			num = (short)2074017792;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0009186C File Offset: 0x0008FA6C
		protected virtual string GetMeasureString()
		{
			int a_ = 19;
			short num;
			int num3;
			string text;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					num = (short)2029387776;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (text.Length == 0)
						{
							num = (short)994312194;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 1:
						goto IL_DA;
					case 2:
						text = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟", a_);
						num = (short)1208221697;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D;
				}
				IL_DA:
				num = (short)2139266706;
				short num4 = num;
				num = (short)1227398802;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7A;
				default:
					num = (short)2028077056;
					if (num != 0)
					{
					}
					break;
				}
				return text;
			}
			}
			IL_4D:
			num = (short)1142620161;
			if (num != 0)
			{
			}
			text = this.GetRenderString();
			IL_7A:
			num = (short)1257046016;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000919A4 File Offset: 0x0008FBA4
		protected virtual string GetRenderString()
		{
			short num = (short)1716064360;
			short num2 = num;
			num = (short)2063667304;
			switch (num2 == num)
			{
			}
			num = (short)1038352385;
			if (num != 0)
			{
			}
			num = (short)1267924992;
			short num3 = num;
			num = (short)1593507840;
			if (num != 0)
			{
			}
			return this.GetInputStringValue();
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00091A54 File Offset: 0x0008FC54
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)2026922269;
			short num2 = num;
			num = (short)1371562269;
			switch (num2 == num)
			{
			}
			num = (short)1276051456;
			if (num != 0)
			{
			}
			num = (short)1958150144;
			short num3 = num;
			num = (short)1833172993;
			if (num != 0)
			{
			}
			return base.DesiredSize;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00091B04 File Offset: 0x0008FD04
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00091BBC File Offset: 0x0008FDBC
		public override bool IsEmpty
		{
			get
			{
				short num = (short)1938433327;
				short num2 = num;
				num = (short)777266479;
				switch (num2 == num)
				{
				}
				num = (short)95879168;
				if (num != 0)
				{
				}
				num = (short)93978624;
				short num3 = num;
				num = (short)1887764481;
				if (num != 0)
				{
				}
				return this.GetInputStringValue().Length == 0;
			}
			set
			{
				short num = (short)821690372;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)642449409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (value)
						{
							num = (short)118685701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)666638060;
						short num3 = num;
						num = (short)281745132;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1240203264;
							if (num != 0)
							{
							}
							this.ResetValue();
							num = (short)1031667715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 5:
						num = (short)1282867201;
						if (num != 0)
						{
						}
						num = (short)433127430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)1350041600;
						short num4 = num;
						if (this.AllowEmptyState)
						{
							num = (short)1066008578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_40:
					if (value == this.IsEmpty)
					{
						break;
					}
					num = (short)39124992;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00091D64 File Offset: 0x0008FF64
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)2053832704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_12E;
				}
				string renderString;
				global::System.Windows.Media.Brush brush3;
				for (;;)
				{
					IL_27:
					global::System.Windows.Media.Brush brush;
					global::System.Windows.Rect rect;
					global::System.Windows.Media.FormattedText formattedText;
					global::System.Windows.Media.Brush brush2;
					global::System.Windows.Media.Brush brush4;
					global::System.Windows.Media.Brush brush5;
					bool flag;
					global::System.Windows.Rect rectangle;
					switch (num2)
					{
					case 0:
						drawingContext.DrawRectangle(brush, null, rect);
						num = (short)1400963104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							num = (short)1433468952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55C;
					case 2:
						goto IL_4FF;
					case 3:
						goto IL_AB5;
					case 4:
					{
						double m = -1.0;
						double m2 = 1.0;
						double width = formattedText.Width;
						double offsetY = 0.0;
						global::System.Windows.Media.MatrixTransform matrixTransform = new global::System.Windows.Media.MatrixTransform(m, 0.0, 0.0, m2, width, offsetY);
						num = (short)1897136165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (base.FocusedBackground == null)
						{
							num = (short)1550516264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2129264674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1624113202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_72A;
					case 8:
						num = (short)158793733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform2;
						if (matrixTransform2 != null)
						{
							num = (short)1753284664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_599;
					}
					case 10:
						if (this.a.Width > 0.0)
						{
							num = (short)1845952573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB5;
					case 11:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform = null;
						num = (short)102498329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (renderString.Length == 0)
						{
							num = (short)1108148282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB5;
					case 13:
						if (base.IsEnabled)
						{
							num = (short)508035126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95E;
					case 14:
						num = (short)1530527761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (base.IsKeyboardFocused)
						{
							num = (short)6291470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95E;
					case 16:
						num = (short)1462370343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (base.InputStack.Length > 0)
						{
							num = (short)606732294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95E;
					case 18:
					{
						num = (short)604008852;
						short num3 = num;
						num = (short)2100130196;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_807;
						default:
							num = (short)33423361;
							if (num != 0)
							{
							}
							num = (short)1396899840;
							if (num != 0)
							{
							}
							if (base.FocusedForeground == null)
							{
								num = (short)771883049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)38338591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
						goto IL_95E;
					case 20:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform2;
						if (matrixTransform2 != null)
						{
							num = (short)1710424123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_357;
					}
					case 21:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform;
						if (matrixTransform != null)
						{
							num = (short)255459373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FF;
					}
					case 22:
						if (base.IsKeyboardFocused)
						{
							num = (short)993132560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8FE;
					case 23:
						goto IL_357;
					case 24:
					{
						double m3 = -1.0;
						double m4 = 1.0;
						double width2 = formattedText.Width;
						double offsetY2 = 0.0;
						global::System.Windows.Media.MatrixTransform matrixTransform2 = new global::System.Windows.Media.MatrixTransform(m3, 0.0, 0.0, m4, width2, offsetY2);
						num = (short)1559232550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							num = (short)1493565444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_214;
					case 26:
						if (brush != null)
						{
							num = (short)209911808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72A;
					case 27:
						brush2 = base.Background;
						goto IL_859;
					case 28:
					{
						global::System.Windows.Media.FormattedText formattedText2 = new global::System.Windows.Media.FormattedText(renderString.Substring(0, base.InputStack.Length), global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture(), global::System.Windows.FlowDirection.LeftToRight, new global::System.Windows.Media.Typeface(base.FontFamily, base.FontStyle, base.FontWeight, base.FontStretch), base.FontSize, brush3);
						formattedText2.BuildGeometry(default(global::System.Windows.Point));
						global::System.Windows.Rect rect2 = rect;
						rect2.Width = formattedText2.Width;
						rect.X += formattedText2.Width;
						rect.Width -= formattedText2.Width;
						drawingContext.PushClip(new global::System.Windows.Media.RectangleGeometry(rect2));
						num = (short)1754988586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						brush3 = base.ForegroundDisabled;
						num = (short)88670260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						drawingContext.Pop();
						num = (short)1692008511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						brush4 = base.FocusedForeground;
						goto IL_B92;
					case 32:
						goto IL_72A;
					case 33:
						if (base.Background != null)
						{
							num = (short)139132928;
							short num4 = num;
							num = (short)141033518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1454899260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						brush5 = base.FocusedBackground;
						goto IL_ADD;
					case 35:
						drawingContext.Pop();
						num = (short)1077149749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform;
						if (matrixTransform != null)
						{
							num = (short)60620830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_319;
					}
					case 37:
						goto IL_214;
					case 38:
						goto IL_55C;
					case 39:
						if (base.IsEnabled)
						{
							num = (short)960167944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8FE;
					case 40:
						num = (short)809500716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)1306656815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (brush3 != null)
						{
							num = (short)1010368574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_599;
					case 43:
						if (flag)
						{
							num = (short)530055203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BFE;
					case 44:
						brush5 = this.DefaultHighlightBrush;
						goto IL_ADD;
					case 45:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform;
						drawingContext.PushTransform(matrixTransform);
						num = (short)145096706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						num = (short)2117206043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						brush4 = this.DefaultHighlightTextBrush;
						goto IL_B92;
					case 48:
						if (brush != null)
						{
							num = (short)2005663793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72A;
					case 49:
						rectangle = rect;
						num = (short)1150746636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (base.InputStack.Length < renderString.Length)
						{
							num = (short)969015324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95E;
					case 51:
						if (!base.IsEnabled)
						{
							num = (short)1818230813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_789;
					case 52:
						goto IL_789;
					case 53:
						goto IL_A68;
					case 54:
						goto IL_807;
					case 55:
						goto IL_599;
					case 56:
						drawingContext.Pop();
						num = (short)1097990199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (brush3 != null)
						{
							num = (short)1879638027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_319;
					case 58:
						num = (short)615841802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform2;
						drawingContext.PushTransform(matrixTransform2);
						num = (short)797638679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						brush2 = global::System.Windows.Media.Brushes.Transparent;
						goto IL_859;
					case 61:
						rectangle = new global::System.Windows.Rect(this.a);
						num = (short)1604124675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform2 = null;
						num = (short)528285697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
						goto IL_319;
					}
					goto IL_12E;
					IL_214:
					num = (short)1884815381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_319:
					num = (short)297730091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_357:
					drawingContext.DrawText(formattedText, new global::System.Windows.Point(0.0, 0.0));
					num = (short)1229848585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FF:
					drawingContext.DrawText(formattedText, new global::System.Windows.Point(0.0, 0.0));
					num = (short)357629988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55C:
					num = (short)1863385108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_599:
					drawingContext.Pop();
					drawingContext.PushClip(new global::System.Windows.Media.RectangleGeometry(rect));
					flag = true;
					num = (short)623247379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72A:
					num = (short)1351352377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_789:
					flag = false;
					rect = new global::System.Windows.Rect(base.RenderSize);
					formattedText = new global::System.Windows.Media.FormattedText(renderString, global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture(), global::System.Windows.FlowDirection.LeftToRight, new global::System.Windows.Media.Typeface(base.FontFamily, base.FontStyle, base.FontWeight, base.FontStretch), base.FontSize, brush3);
					num = (short)318636045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_807:
					num = (short)1950679055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_859:
					brush = brush2;
					num = (short)502857779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8FE:
					num = (short)7602202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_95E:
					num = (short)688390166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB5:
					drawingContext.DrawRectangle(brush, null, rectangle);
					num = (short)1498939399;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ADD:
					brush = brush5;
					num = (short)1766916114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B92:
					brush3 = brush4;
					formattedText.SetForegroundBrush(brush3);
					num = (short)428671024;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A68:
				IL_BFE:
				base.OnRender(drawingContext);
				return;
				IL_12E:
				renderString = this.GetRenderString();
				brush3 = base.Foreground;
				num = (short)701169697;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0009298C File Offset: 0x00090B8C
		// Note: this type is marked as 'beforefieldinit'.
		static EditorListInput()
		{
			int a_ = 2;
			short num = (short)954793984;
			short num2 = num;
			num = (short)1753088001;
			if (num != 0)
			{
			}
			num = (short)736609201;
			short num3 = num;
			num = (short)517260209;
			switch (num3 == num)
			{
			}
			num = (short)1980563456;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.EditorListInput.AllowEmptyStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軎뷐뿒뫔ꃖ鳘뛚규ꯞ飠냢釤蛦鷨軪", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorListInput), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorListInput.a)));
		}

		// Token: 0x040002DD RID: 733
		public static readonly global::System.Windows.DependencyProperty AllowEmptyStateProperty;

		// Token: 0x040002DE RID: 734
		private global::System.Windows.Size a;
	}
}
