using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000CD RID: 205
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class SolidBrushAppearanceData : global::Infragistics.BrushAppearanceData
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x000279AF File Offset: 0x00025BAF
		public override string Type
		{
			get
			{
				return "solid";
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000279B6 File Offset: 0x00025BB6
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x000279BE File Offset: 0x00025BBE
		public global::System.Windows.Media.Color ColorValue { get; set; }

		// Token: 0x0600088B RID: 2187 RVA: 0x000279C7 File Offset: 0x00025BC7
		protected override string SerializeOverride()
		{
			string str = "colorValue: ";
			global::System.Windows.Media.Color colorValue = this.ColorValue;
			return str + global::Infragistics.AppearanceHelper.SerializeColor(this.ColorValue);
		}
	}
}
