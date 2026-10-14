using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000CF RID: 207
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class GradientStopAppearanceData : global::Infragistics.IVisualData
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00027B37 File Offset: 0x00025D37
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00027B3F File Offset: 0x00025D3F
		public global::System.Windows.Media.Color ColorValue { get; set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00027B48 File Offset: 0x00025D48
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00027B50 File Offset: 0x00025D50
		public double Offset { get; set; }

		// Token: 0x0600089E RID: 2206 RVA: 0x00027B5C File Offset: 0x00025D5C
		public string Serialize()
		{
			object[] array = new object[5];
			array[0] = "{ colorValue: ";
			object[] array2 = array;
			int num = 1;
			global::System.Windows.Media.Color colorValue = this.ColorValue;
			array2[num] = global::Infragistics.AppearanceHelper.SerializeColor(this.ColorValue);
			array[2] = ", offset: ";
			array[3] = this.Offset;
			array[4] = " }";
			return string.Concat(array);
		}
	}
}
