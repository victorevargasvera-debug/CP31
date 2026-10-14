using System;
using System.Collections.Generic;

namespace SpecialFeatures.FCCExceptionHandler
{
	// Token: 0x0200011C RID: 284
	internal class PointSection : global::SpecialFeatures.FCCExceptionHandler.BaseSection
	{
		// Token: 0x06000F4C RID: 3916 RVA: 0x00003440 File Offset: 0x00001640
		internal PointSection()
		{
			this.a = new global::System.Collections.Generic.List<string>();
			base.FreqType = global::SpecialFeatures.FCCExceptionHandler.SectionType.Point;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00153058 File Offset: 0x00151258
		internal void AddPoint(string point)
		{
			short num = (short)2029703344;
			short num2 = num;
			num = (short)19058864;
			switch (num2 == num)
			{
			}
			num = (short)38666241;
			if (num != 0)
			{
			}
			num = (short)1116667904;
			short num3 = num;
			num = (short)1300168704;
			if (num != 0)
			{
			}
			this.a.Add(point);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0015310C File Offset: 0x0015130C
		public global::System.Collections.Generic.List<string> PointsList
		{
			get
			{
				short num = (short)1657208833;
				if (num != 0)
				{
				}
				num = (short)1868416611;
				short num2 = num;
				num = (short)539739747;
				switch (num2 == num)
				{
				}
				num = (short)1702559744;
				short num3 = num;
				num = (short)579796992;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000800 RID: 2048
		private global::System.Collections.Generic.List<string> a;
	}
}
