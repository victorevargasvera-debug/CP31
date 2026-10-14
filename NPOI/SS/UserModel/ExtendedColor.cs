using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using NPOI.HSSF.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200003C RID: 60
	public abstract class ExtendedColor : global::NPOI.SS.UserModel.IColor
	{
		// Token: 0x06000237 RID: 567 RVA: 0x000098D8 File Offset: 0x00007AD8
		protected void SetColor(global::System.Drawing.Color clr)
		{
			this.RGB = new byte[]
			{
				clr.R,
				clr.G,
				clr.B
			};
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000238 RID: 568
		// (set) Token: 0x06000239 RID: 569
		public abstract bool IsAuto { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600023A RID: 570
		public abstract bool IsIndexed { get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600023B RID: 571
		public abstract bool IsRGB { get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600023C RID: 572
		public abstract bool IsThemed { get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600023D RID: 573
		public abstract short Index { get; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600023E RID: 574
		// (set) Token: 0x0600023F RID: 575
		public abstract int Theme { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000240 RID: 576
		// (set) Token: 0x06000241 RID: 577
		public abstract byte[] RGB { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000242 RID: 578
		public abstract byte[] ARGB { get; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000243 RID: 579
		protected abstract byte[] StoredRBG { get; }

		// Token: 0x06000244 RID: 580 RVA: 0x00009904 File Offset: 0x00007B04
		protected byte[] GetRGBOrARGB()
		{
			if (this.IsIndexed && this.Index > 0)
			{
				int index = (int)this.Index;
				global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Util.HSSFColor> indexHash = global::NPOI.HSSF.Util.HSSFColor.GetIndexHash();
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = null;
				if (indexHash.ContainsKey(index))
				{
					hssfcolor = indexHash[index];
				}
				if (hssfcolor != null)
				{
					return new byte[]
					{
						hssfcolor.GetTriplet()[0],
						hssfcolor.GetTriplet()[1],
						hssfcolor.GetTriplet()[2]
					};
				}
			}
			return this.StoredRBG;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00009974 File Offset: 0x00007B74
		public byte[] RGBWithTint
		{
			get
			{
				byte[] array = this.StoredRBG;
				if (array != null)
				{
					if (array.Length == 4)
					{
						byte[] array2 = new byte[3];
						global::System.Array.Copy(array, 1, array2, 0, 3);
						array = array2;
					}
					double tint = this.Tint;
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = global::NPOI.SS.UserModel.ExtendedColor.ApplyTint((int)(array[i] & byte.MaxValue), tint);
					}
				}
				return array;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000099CC File Offset: 0x00007BCC
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00009A40 File Offset: 0x00007C40
		public string ARGBHex
		{
			get
			{
				byte[] argb = this.ARGB;
				if (argb == null)
				{
					return null;
				}
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				byte[] array = argb;
				for (int i = 0; i < array.Length; i++)
				{
					int num = (int)(array[i] & byte.MaxValue);
					string text = string.Format("{0:x}", num);
					if (text.Length == 1)
					{
						stringBuilder.Append('0');
					}
					stringBuilder.Append(text);
				}
				return stringBuilder.ToString().ToUpper();
			}
			set
			{
				if (value.Length == 6 || value.Length == 8)
				{
					byte[] array = new byte[value.Length / 2];
					for (int i = 0; i < array.Length; i++)
					{
						string s = value.Substring(i * 2, (i + 1) * 2 - i * 2);
						array[i] = (byte)int.Parse(s, global::System.Globalization.NumberStyles.HexNumber);
					}
					this.RGB = array;
					return;
				}
				throw new global::System.ArgumentException("Must be of the form 112233 or FFEEDDCC");
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009AB0 File Offset: 0x00007CB0
		private static byte ApplyTint(int lum, double tint)
		{
			if (tint > 0.0)
			{
				return (byte)((double)lum * (1.0 - tint) + (255.0 - 255.0 * (1.0 - tint)));
			}
			if (tint < 0.0)
			{
				return (byte)((double)lum * (1.0 + tint));
			}
			return (byte)lum;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000249 RID: 585
		// (set) Token: 0x0600024A RID: 586
		public abstract double Tint { get; set; }
	}
}
