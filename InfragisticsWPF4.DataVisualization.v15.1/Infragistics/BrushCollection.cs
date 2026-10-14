using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000008 RID: 8
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.SolidBrushCollectionConverter))]
	public class BrushCollection : global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.Media.Brush>
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00003280 File Offset: 0x00001480
		protected override void InsertItem(int index, global::System.Windows.Media.Brush item)
		{
			if (item.CanFreeze)
			{
				item.Freeze();
			}
			base.InsertItem(index, item);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003298 File Offset: 0x00001498
		protected override void SetItem(int index, global::System.Windows.Media.Brush item)
		{
			if (item.CanFreeze)
			{
				item.Freeze();
			}
			base.SetItem(index, item);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000032B0 File Offset: 0x000014B0
		public global::System.Windows.Media.Brush SelectRandom()
		{
			return this[global::Infragistics.BrushCollection.random.Next(base.Count)];
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000032C8 File Offset: 0x000014C8
		public global::System.Windows.Media.Brush InterpolateRandom()
		{
			return this.GetInterpolatedBrush(global::Infragistics.BrushCollection.random.NextDouble() * (double)(base.Count - 1));
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000032E4 File Offset: 0x000014E4
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000032EC File Offset: 0x000014EC
		public global::Infragistics.InterpolationMode InterpolationMode
		{
			get
			{
				return this.interpolationMode;
			}
			set
			{
				if (this.interpolationMode != value)
				{
					this.interpolationMode = value;
					this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				}
			}
		}

		// Token: 0x17000014 RID: 20
		public global::System.Windows.Media.Brush this[double index]
		{
			get
			{
				return this.GetInterpolatedBrush(index);
			}
		}

		// Token: 0x17000015 RID: 21
		public new global::System.Windows.Media.Brush this[int index]
		{
			get
			{
				if (index < 0 || index >= base.Count)
				{
					return null;
				}
				return base[index];
			}
			set
			{
				base[index] = value;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003338 File Offset: 0x00001538
		public global::System.Windows.Media.Brush GetInterpolatedBrush(double index)
		{
			if (double.IsNaN(index))
			{
				return null;
			}
			index = global::Infragistics.MathUtil.Clamp(index, 0.0, (double)base.Count - 1.0);
			int num = (int)global::System.Math.Floor(index);
			if ((double)num == index)
			{
				return this[num];
			}
			return this[num].GetInterpolation(index - (double)num, this[num + 1], this.InterpolationMode);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000033A8 File Offset: 0x000015A8
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			global::Infragistics.BrushCollection brushCollection = (global::Infragistics.BrushCollection)obj;
			if (brushCollection.Count != base.Count)
			{
				return false;
			}
			for (int i = 0; i < brushCollection.Count; i++)
			{
				if (!brushCollection[i].Equals(this[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000016 RID: 22
		private static global::System.Random random = new global::System.Random();

		// Token: 0x04000017 RID: 23
		private global::Infragistics.InterpolationMode interpolationMode;
	}
}
