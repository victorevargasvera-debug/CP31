using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infragistics.Controls.Barcodes.VisualData
{
	// Token: 0x0200001E RID: 30
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class GridBarcodeVisualData : global::Infragistics.Controls.Barcodes.VisualData.BarcodeVisualData
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000DE2E File Offset: 0x0000C02E
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000DE36 File Offset: 0x0000C036
		public global::Infragistics.PrimitiveVisualData FiguresPath { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000DE3F File Offset: 0x0000C03F
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000DE47 File Offset: 0x0000C047
		public global::Infragistics.PrimitiveVisualData FiguresPathRect { get; set; }

		// Token: 0x060000BC RID: 188 RVA: 0x0000DE50 File Offset: 0x0000C050
		public virtual void ScaleByViewport()
		{
			if (this.FiguresPath != null)
			{
				this.FiguresPath.ScaleByViewport(base.Viewport);
			}
			if (this.FiguresPathRect != null)
			{
				this.FiguresPathRect.ScaleByViewport(base.Viewport);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000DE84 File Offset: 0x0000C084
		public string Serialize()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			stringBuilder.AppendLine("{");
			if (this.FiguresPath != null)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("figuresPath: ");
				stringBuilder.AppendLine(this.FiguresPath.Serialize());
			}
			if (this.FiguresPathRect != null)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("figuresPathRect: ");
				stringBuilder.AppendLine(this.FiguresPathRect.Serialize());
			}
			if (!flag)
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append("viewport: {");
			stringBuilder.Append(string.Concat(new object[]
			{
				"left: ",
				base.Viewport.Left,
				", top: ",
				base.Viewport.Top,
				", width: ",
				base.Viewport.Width,
				", height: ",
				base.Viewport.Height
			}));
			stringBuilder.AppendLine("}");
			stringBuilder.AppendLine("}");
			return stringBuilder.ToString();
		}
	}
}
