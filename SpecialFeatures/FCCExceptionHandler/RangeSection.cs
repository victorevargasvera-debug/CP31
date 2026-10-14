using System;
using System.Collections.Generic;

namespace SpecialFeatures.FCCExceptionHandler
{
	// Token: 0x0200011D RID: 285
	internal class RangeSection : global::SpecialFeatures.FCCExceptionHandler.BaseSection
	{
		// Token: 0x06000F4F RID: 3919 RVA: 0x0000345A File Offset: 0x0000165A
		internal RangeSection()
		{
			this.a = new global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.FreqRange>();
			base.FreqType = global::SpecialFeatures.FCCExceptionHandler.SectionType.Range;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x001531BC File Offset: 0x001513BC
		internal void AddRange(global::SpecialFeatures.FCCExceptionHandler.FreqRange r)
		{
			short num = (short)1414967551;
			short num2 = num;
			num = (short)1288941823;
			switch (num2 == num)
			{
			}
			num = (short)974782465;
			if (num != 0)
			{
			}
			num = (short)1096351744;
			short num3 = num;
			num = (short)1043202048;
			if (num != 0)
			{
			}
			this.a.Add(r);
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00153274 File Offset: 0x00151474
		public global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.FreqRange> RangesList
		{
			get
			{
				short num = (short)1176502857;
				short num2 = num;
				num = (short)826081865;
				switch (num2 == num)
				{
				}
				num = (short)15663105;
				if (num != 0)
				{
				}
				num = (short)96731136;
				short num3 = num;
				num = (short)1020526592;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000801 RID: 2049
		private global::System.Collections.Generic.List<global::SpecialFeatures.FCCExceptionHandler.FreqRange> a;
	}
}
