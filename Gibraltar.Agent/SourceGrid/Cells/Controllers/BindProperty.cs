using System;
using System.Reflection;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x02000396 RID: 918
	internal class BindProperty : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x06002B1A RID: 11034 RVA: 0x00091618 File Offset: 0x0008F818
		public BindProperty(global::System.Reflection.PropertyInfo p_Property, object p_LinkObject)
		{
			this.BindValueAtProperty(p_Property, p_LinkObject);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00091628 File Offset: 0x0008F828
		public override void OnValueChanged(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnValueChanged(sender, e);
			if (this.m_LinkPropertyInfo != null)
			{
				this.m_LinkPropertyInfo.SetValue(this.m_LinkObject, sender.Cell.Model.ValueModel.GetValue(sender), null);
			}
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00091678 File Offset: 0x0008F878
		protected virtual void BindValueAtProperty(global::System.Reflection.PropertyInfo p_Property, object p_LinkObject)
		{
			this.m_LinkPropertyInfo = p_Property;
			this.m_LinkObject = p_LinkObject;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00091688 File Offset: 0x0008F888
		protected virtual void UnBindValueAtProperty()
		{
			this.m_LinkPropertyInfo = null;
			this.m_LinkObject = null;
		}

		// Token: 0x04000E81 RID: 3713
		private global::System.Reflection.PropertyInfo m_LinkPropertyInfo;

		// Token: 0x04000E82 RID: 3714
		private object m_LinkObject;
	}
}
