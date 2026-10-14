using System;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200052D RID: 1325
	public class EscherColorRef
	{
		// Token: 0x060031B6 RID: 12726 RVA: 0x000966DB File Offset: 0x000948DB
		public EscherColorRef(int colorRef)
		{
			this.colorRef = colorRef;
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x000966F4 File Offset: 0x000948F4
		public EscherColorRef(byte[] source, int start, int len)
		{
			int num = start;
			if (len == 6)
			{
				this.opid = global::NPOI.Util.LittleEndian.GetUShort(source, num);
				num += 2;
			}
			this.colorRef = global::NPOI.Util.LittleEndian.GetInt(source, num);
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x00096732 File Offset: 0x00094932
		public bool HasSysIndexFlag()
		{
			return global::NPOI.DDF.EscherColorRef.FLAG_SYS_INDEX.IsSet(this.colorRef);
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x00096744 File Offset: 0x00094944
		public void SetSysIndexFlag(bool flag)
		{
			this.colorRef = global::NPOI.DDF.EscherColorRef.FLAG_SYS_INDEX.SetBoolean(this.colorRef, flag);
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x0009675D File Offset: 0x0009495D
		public bool HasSchemeIndexFlag()
		{
			return global::NPOI.DDF.EscherColorRef.FLAG_SCHEME_INDEX.IsSet(this.colorRef);
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x0009676F File Offset: 0x0009496F
		public void SetSchemeIndexFlag(bool flag)
		{
			this.colorRef = global::NPOI.DDF.EscherColorRef.FLAG_SCHEME_INDEX.SetBoolean(this.colorRef, flag);
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x00096788 File Offset: 0x00094988
		public bool HasSystemRGBFlag()
		{
			return global::NPOI.DDF.EscherColorRef.FLAG_SYSTEM_RGB.IsSet(this.colorRef);
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x0009679A File Offset: 0x0009499A
		public void SetSystemRGBFlag(bool flag)
		{
			this.colorRef = global::NPOI.DDF.EscherColorRef.FLAG_SYSTEM_RGB.SetBoolean(this.colorRef, flag);
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x000967B3 File Offset: 0x000949B3
		public bool HasPaletteRGBFlag()
		{
			return global::NPOI.DDF.EscherColorRef.FLAG_PALETTE_RGB.IsSet(this.colorRef);
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000967C5 File Offset: 0x000949C5
		public void SetPaletteRGBFlag(bool flag)
		{
			this.colorRef = global::NPOI.DDF.EscherColorRef.FLAG_PALETTE_RGB.SetBoolean(this.colorRef, flag);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x000967DE File Offset: 0x000949DE
		public bool HasPaletteIndexFlag()
		{
			return global::NPOI.DDF.EscherColorRef.FLAG_PALETTE_INDEX.IsSet(this.colorRef);
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x000967F0 File Offset: 0x000949F0
		public void SetPaletteIndexFlag(bool flag)
		{
			this.colorRef = global::NPOI.DDF.EscherColorRef.FLAG_PALETTE_INDEX.SetBoolean(this.colorRef, flag);
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x0009680C File Offset: 0x00094A0C
		public int[] GetRGB()
		{
			return new int[]
			{
				global::NPOI.DDF.EscherColorRef.FLAG_RED.GetValue(this.colorRef),
				global::NPOI.DDF.EscherColorRef.FLAG_GREEN.GetValue(this.colorRef),
				global::NPOI.DDF.EscherColorRef.FLAG_BLUE.GetValue(this.colorRef)
			};
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x00096858 File Offset: 0x00094A58
		public global::NPOI.DDF.SysIndexSource GetSysIndexSource()
		{
			if (!this.HasSysIndexFlag())
			{
				return null;
			}
			int value = global::NPOI.DDF.EscherColorRef.FLAG_RED.GetValue(this.colorRef);
			foreach (global::NPOI.DDF.SysIndexSource sysIndexSource in global::NPOI.DDF.SysIndexSource.Values())
			{
				if (sysIndexSource.value == value)
				{
					return sysIndexSource;
				}
			}
			return null;
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000968A4 File Offset: 0x00094AA4
		public global::NPOI.DDF.SysIndexProcedure GetSysIndexProcedure()
		{
			if (!this.HasSysIndexFlag())
			{
				return null;
			}
			int value = global::NPOI.DDF.EscherColorRef.FLAG_RED.GetValue(this.colorRef);
			foreach (global::NPOI.DDF.SysIndexProcedure sysIndexProcedure in global::NPOI.DDF.SysIndexProcedure.Values())
			{
				if (sysIndexProcedure != global::NPOI.DDF.SysIndexProcedure.INVERT_AFTER && sysIndexProcedure != global::NPOI.DDF.SysIndexProcedure.INVERT_HIGHBIT_AFTER && sysIndexProcedure.mask.IsSet(value))
				{
					return sysIndexProcedure;
				}
			}
			return null;
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x00096908 File Offset: 0x00094B08
		public int GetSysIndexInvert()
		{
			if (!this.HasSysIndexFlag())
			{
				return 0;
			}
			int value = global::NPOI.DDF.EscherColorRef.FLAG_GREEN.GetValue(this.colorRef);
			if (global::NPOI.DDF.SysIndexProcedure.INVERT_AFTER.mask.IsSet(value))
			{
				return 1;
			}
			if (global::NPOI.DDF.SysIndexProcedure.INVERT_HIGHBIT_AFTER.mask.IsSet(value))
			{
				return 2;
			}
			return 0;
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x00096959 File Offset: 0x00094B59
		public int GetSchemeIndex()
		{
			if (!this.HasSchemeIndexFlag())
			{
				return -1;
			}
			return global::NPOI.DDF.EscherColorRef.FLAG_RED.GetValue(this.colorRef);
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x00096975 File Offset: 0x00094B75
		public int GetPaletteIndex()
		{
			if (!this.HasPaletteIndexFlag())
			{
				return -1;
			}
			return global::NPOI.DDF.EscherColorRef.FLAG_GREEN.GetValue(this.colorRef) << 8 & global::NPOI.DDF.EscherColorRef.FLAG_RED.GetValue(this.colorRef);
		}

		// Token: 0x04001631 RID: 5681
		private int opid = -1;

		// Token: 0x04001632 RID: 5682
		private int colorRef;

		// Token: 0x04001633 RID: 5683
		private static global::NPOI.Util.BitField FLAG_SYS_INDEX = new global::NPOI.Util.BitField(268435456);

		// Token: 0x04001634 RID: 5684
		private static global::NPOI.Util.BitField FLAG_SCHEME_INDEX = new global::NPOI.Util.BitField(134217728);

		// Token: 0x04001635 RID: 5685
		private static global::NPOI.Util.BitField FLAG_SYSTEM_RGB = new global::NPOI.Util.BitField(67108864);

		// Token: 0x04001636 RID: 5686
		private static global::NPOI.Util.BitField FLAG_PALETTE_RGB = new global::NPOI.Util.BitField(33554432);

		// Token: 0x04001637 RID: 5687
		private static global::NPOI.Util.BitField FLAG_PALETTE_INDEX = new global::NPOI.Util.BitField(16777216);

		// Token: 0x04001638 RID: 5688
		private static global::NPOI.Util.BitField FLAG_BLUE = new global::NPOI.Util.BitField(16711680);

		// Token: 0x04001639 RID: 5689
		private static global::NPOI.Util.BitField FLAG_GREEN = new global::NPOI.Util.BitField(65280);

		// Token: 0x0400163A RID: 5690
		private static global::NPOI.Util.BitField FLAG_RED = new global::NPOI.Util.BitField(255);
	}
}
