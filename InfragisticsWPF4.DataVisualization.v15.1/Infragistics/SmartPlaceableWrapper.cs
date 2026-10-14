using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000B7 RID: 183
	public class SmartPlaceableWrapper<T> : global::Infragistics.ISmartPlaceable where T : global::System.Windows.FrameworkElement
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x00025430 File Offset: 0x00023630
		public SmartPlaceableWrapper()
		{
			this.NoWiggle = false;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0002543F File Offset: 0x0002363F
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00025447 File Offset: 0x00023647
		public bool NoWiggle { get; set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00025450 File Offset: 0x00023650
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00025458 File Offset: 0x00023658
		public T Element
		{
			get
			{
				return this._element;
			}
			set
			{
				this._element = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00025461 File Offset: 0x00023661
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00025469 File Offset: 0x00023669
		public global::System.Windows.Point ElementLocationResult { get; protected set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00025472 File Offset: 0x00023672
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x0002547A File Offset: 0x0002367A
		public global::System.Windows.Point OriginalLocation { get; set; }

		// Token: 0x060007ED RID: 2029 RVA: 0x00025483 File Offset: 0x00023683
		public virtual global::Infragistics.SmartPosition[] GetSmartPositions()
		{
			if (this.NoWiggle)
			{
				return global::Infragistics.SmartPlaceableWrapper<T>.smartPositionDefault;
			}
			return global::Infragistics.SmartPlaceableWrapper<T>.smartPositions;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00025498 File Offset: 0x00023698
		internal global::System.Windows.Size GetSmartElementSize()
		{
			T element = this.Element;
			element.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
			T element2 = this.Element;
			double height = element2.DesiredSize.Height;
			T element3 = this.Element;
			double width = element3.DesiredSize.Width;
			T element4 = this.Element;
			if (element4.ActualHeight > 0.0)
			{
				T element5 = this.Element;
				if (element5.ActualWidth > 0.0)
				{
					T element6 = this.Element;
					height = element6.ActualHeight;
					T element7 = this.Element;
					width = element7.ActualWidth;
				}
			}
			return new global::System.Windows.Size(width, height);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00025580 File Offset: 0x00023780
		public global::System.Windows.Rect GetSmartBounds(global::Infragistics.SmartPosition position)
		{
			global::System.Windows.Size smartElementSize = this.GetSmartElementSize();
			double num = smartElementSize.Width;
			double num2 = smartElementSize.Height;
			T element = this.Element;
			global::System.Windows.Point offset;
			if (element.RenderTransform != null)
			{
				T element2 = this.Element;
				if (element2.RenderTransform is global::System.Windows.Media.ScaleTransform)
				{
					T element3 = this.Element;
					global::System.Windows.Media.ScaleTransform scaleTransform = (global::System.Windows.Media.ScaleTransform)element3.RenderTransform;
					num *= scaleTransform.ScaleX;
					num2 *= scaleTransform.ScaleY;
					offset = this.GetOffset(position, num, num2);
					offset.X += (num - smartElementSize.Width) / 2.0;
					offset.Y += (num2 - smartElementSize.Height) / 2.0;
					goto IL_D5;
				}
			}
			offset = this.GetOffset(position, num, num2);
			IL_D5:
			return new global::System.Windows.Rect(this.OriginalLocation.X + offset.X, this.OriginalLocation.Y + offset.Y, num, num2);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00025698 File Offset: 0x00023898
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x000256BC File Offset: 0x000238BC
		public double Opacity
		{
			get
			{
				T element = this.Element;
				return element.Opacity;
			}
			set
			{
				T element = this.Element;
				element.Opacity = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000256DE File Offset: 0x000238DE
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x000256E8 File Offset: 0x000238E8
		public global::Infragistics.SmartPosition SmartPosition
		{
			get
			{
				return this.smartPosition;
			}
			set
			{
				this.smartPosition = value;
				global::System.Windows.Size smartElementSize = this.GetSmartElementSize();
				double height = smartElementSize.Height;
				double width = smartElementSize.Width;
				T element = this.Element;
				global::System.Windows.Point offset;
				if (element.RenderTransform != null)
				{
					T element2 = this.Element;
					if (element2.RenderTransform is global::System.Windows.Media.ScaleTransform)
					{
						T element3 = this.Element;
						global::System.Windows.Media.ScaleTransform scaleTransform = (global::System.Windows.Media.ScaleTransform)element3.RenderTransform;
						double num = width * scaleTransform.ScaleX;
						double num2 = height * scaleTransform.ScaleY;
						offset = this.GetOffset(this.smartPosition, num, num2);
						offset.X += (num - smartElementSize.Width) / 2.0;
						offset.Y += (num2 - smartElementSize.Height) / 2.0;
						goto IL_EF;
					}
				}
				offset = this.GetOffset(this.smartPosition, width, height);
				IL_EF:
				this.ElementLocationResult = new global::System.Windows.Point(this.OriginalLocation.X + offset.X, this.OriginalLocation.Y + offset.Y);
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00025820 File Offset: 0x00023A20
		private global::System.Windows.Point GetOffset(global::Infragistics.SmartPosition position, double w, double h)
		{
			switch (position)
			{
			case global::Infragistics.SmartPosition.LeftTop:
				return new global::System.Windows.Point(-w * 0.25, -h * 0.25);
			case global::Infragistics.SmartPosition.CenterTop:
				return new global::System.Windows.Point(0.0, -h * 0.25);
			case global::Infragistics.SmartPosition.RightTop:
				return new global::System.Windows.Point(w * 0.25, -h * 0.25);
			case global::Infragistics.SmartPosition.LeftCenter:
				return new global::System.Windows.Point(-w * 0.25, 0.0);
			case global::Infragistics.SmartPosition.CenterCenter:
				return new global::System.Windows.Point(0.0, 0.0);
			case global::Infragistics.SmartPosition.RightCenter:
				return new global::System.Windows.Point(w * 0.25, 0.0);
			case global::Infragistics.SmartPosition.LeftBottom:
				return new global::System.Windows.Point(-w * 0.25, h * 0.25);
			case global::Infragistics.SmartPosition.CenterBottom:
				return new global::System.Windows.Point(0.0, h * 0.25);
			default:
				return new global::System.Windows.Point(w * 0.25, h * 0.25);
			}
		}

		// Token: 0x040002D6 RID: 726
		private T _element;

		// Token: 0x040002D7 RID: 727
		private static global::Infragistics.SmartPosition[] smartPositionDefault = new global::Infragistics.SmartPosition[]
		{
			global::Infragistics.SmartPosition.CenterCenter
		};

		// Token: 0x040002D8 RID: 728
		private static global::Infragistics.SmartPosition[] smartPositions = new global::Infragistics.SmartPosition[]
		{
			global::Infragistics.SmartPosition.CenterCenter,
			global::Infragistics.SmartPosition.RightCenter,
			global::Infragistics.SmartPosition.RightTop,
			global::Infragistics.SmartPosition.CenterTop,
			global::Infragistics.SmartPosition.RightBottom,
			global::Infragistics.SmartPosition.CenterBottom,
			global::Infragistics.SmartPosition.LeftTop,
			global::Infragistics.SmartPosition.LeftCenter,
			global::Infragistics.SmartPosition.LeftBottom
		};

		// Token: 0x040002D9 RID: 729
		private global::Infragistics.SmartPosition smartPosition;
	}
}
