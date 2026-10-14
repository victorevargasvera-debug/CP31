using System;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000236 RID: 566
	public class CheckBoxColumn : global::Infragistics.Controls.Grids.CustomDisplayEditableColumn
	{
		// Token: 0x060010CE RID: 4302 RVA: 0x0003E468 File Offset: 0x0003C668
		public CheckBoxColumn()
		{
			base.VerticalContentAlignment = (base.EditorVerticalContentAlignment = global::System.Windows.VerticalAlignment.Center);
			base.EditorHorizontalContentAlignment = (base.HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Center);
			base.AddNewRowEditorTemplateVerticalContentAlignment = (base.AddNewRowItemTemplateVerticalContentAlignment = global::System.Windows.VerticalAlignment.Center);
			base.AddNewRowItemTemplateHorizontalContentAlignment = (base.AddNewRowEditorTemplateHorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Center);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0003E4BB File Offset: 0x0003C6BB
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.Primitives.CheckBoxColumnContentProvider();
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0003E4C2 File Offset: 0x0003C6C2
		protected override string FilterMenuCustomFilterString
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("BoolFilters");
			}
		}
	}
}
