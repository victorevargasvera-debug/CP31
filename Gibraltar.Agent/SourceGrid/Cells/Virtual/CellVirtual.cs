using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells.Virtual
{
	// Token: 0x02000356 RID: 854
	internal class CellVirtual : global::SourceGrid.Cells.ICellVirtual
	{
		// Token: 0x060029CF RID: 10703 RVA: 0x0008F548 File Offset: 0x0008D748
		public CellVirtual()
		{
			this.View = global::SourceGrid.Cells.Views.Cell.Default;
			this.Editor = null;
			this.Model = new global::SourceGrid.Cells.Models.ModelContainer();
			this.Model.AddModel(global::SourceGrid.Cells.Models.NullValueModel.Default);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x0008F58C File Offset: 0x0008D78C
		public CellVirtual(global::System.Type type) : this()
		{
			this.Editor = global::SourceGrid.Cells.Editors.Factory.Create(type);
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x0008F5A0 File Offset: 0x0008D7A0
		// (set) Token: 0x060029D2 RID: 10706 RVA: 0x0008F5A8 File Offset: 0x0008D7A8
		public global::SourceGrid.Cells.Models.ModelContainer Model
		{
			get
			{
				return this.m_Model;
			}
			set
			{
				if (value == null)
				{
					throw new global::SourceGrid.SourceGridException("Model cannot be null");
				}
				this.m_Model = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x0008F5C4 File Offset: 0x0008D7C4
		// (set) Token: 0x060029D4 RID: 10708 RVA: 0x0008F5CC File Offset: 0x0008D7CC
		public virtual global::SourceGrid.Cells.Views.IView View
		{
			get
			{
				return this.m_View;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("View");
				}
				this.m_View = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x0008F5E8 File Offset: 0x0008D7E8
		public global::SourceGrid.Cells.Controllers.ControllerContainer Controller
		{
			get
			{
				return this.m_Controller;
			}
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0008F5F0 File Offset: 0x0008D7F0
		public void AddController(global::SourceGrid.Cells.Controllers.IController controller)
		{
			if (this.m_Controller == null)
			{
				this.m_Controller = new global::SourceGrid.Cells.Controllers.ControllerContainer();
			}
			this.m_Controller.AddController(controller);
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x0008F614 File Offset: 0x0008D814
		public void RemoveController(global::SourceGrid.Cells.Controllers.IController controller)
		{
			if (this.m_Controller != null)
			{
				this.m_Controller.RemoveController(controller);
			}
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x0008F630 File Offset: 0x0008D830
		public global::SourceGrid.Cells.Controllers.IController FindController(global::System.Type pControllerType)
		{
			if (this.m_Controller != null)
			{
				return this.m_Controller.FindController(pControllerType);
			}
			return null;
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x0008F64C File Offset: 0x0008D84C
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x0008F654 File Offset: 0x0008D854
		public global::SourceGrid.Cells.Editors.EditorBase Editor
		{
			get
			{
				return this.m_Editor;
			}
			set
			{
				this.m_Editor = value;
			}
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x0008F660 File Offset: 0x0008D860
		public global::SourceGrid.Cells.ICellVirtual Copy()
		{
			return (global::SourceGrid.Cells.ICellVirtual)base.MemberwiseClone();
		}

		// Token: 0x04000E33 RID: 3635
		private global::SourceGrid.Cells.Models.ModelContainer m_Model;

		// Token: 0x04000E34 RID: 3636
		private global::SourceGrid.Cells.Views.IView m_View;

		// Token: 0x04000E35 RID: 3637
		private global::SourceGrid.Cells.Controllers.ControllerContainer m_Controller;

		// Token: 0x04000E36 RID: 3638
		private global::SourceGrid.Cells.Editors.EditorBase m_Editor;
	}
}
