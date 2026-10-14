using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.Collections;
using DevAge.ComponentModel;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x02000352 RID: 850
	internal class ControllerContainer : global::SourceGrid.Cells.Controllers.IController
	{
		// Token: 0x0600297F RID: 10623 RVA: 0x0008E444 File Offset: 0x0008C644
		public virtual global::SourceGrid.Cells.Controllers.IController FindController(global::System.Type modelType)
		{
			if (this.m_ControllerList == null)
			{
				this.m_ControllerList = new global::SourceGrid.Cells.Controllers.ControllerContainer.ControllerList();
			}
			return this.m_ControllerList.GetByType(modelType);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0008E468 File Offset: 0x0008C668
		public virtual void AddController(global::SourceGrid.Cells.Controllers.IController model)
		{
			if (this.m_ControllerList == null)
			{
				this.m_ControllerList = new global::SourceGrid.Cells.Controllers.ControllerContainer.ControllerList();
			}
			this.m_ControllerList.Add(model);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x0008E48C File Offset: 0x0008C68C
		public virtual void RemoveController(global::SourceGrid.Cells.Controllers.IController model)
		{
			if (this.m_ControllerList != null)
			{
				this.m_ControllerList.Remove(model);
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0008E4A8 File Offset: 0x0008C6A8
		public void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnMouseDown(sender, e);
			}
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0008E504 File Offset: 0x0008C704
		public void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnMouseUp(sender, e);
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x0008E560 File Offset: 0x0008C760
		public void OnMouseMove(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnMouseMove(sender, e);
			}
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x0008E5BC File Offset: 0x0008C7BC
		public void OnMouseEnter(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnMouseEnter(sender, e);
			}
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x0008E618 File Offset: 0x0008C818
		public void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnMouseLeave(sender, e);
			}
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x0008E674 File Offset: 0x0008C874
		public void OnKeyUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnKeyUp(sender, e);
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x0008E6D0 File Offset: 0x0008C8D0
		public void OnKeyDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnKeyDown(sender, e);
			}
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x0008E72C File Offset: 0x0008C92C
		public void OnKeyPress(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyPressEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnKeyPress(sender, e);
			}
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x0008E788 File Offset: 0x0008C988
		public void OnDoubleClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnDoubleClick(sender, e);
			}
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x0008E7E4 File Offset: 0x0008C9E4
		public void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnClick(sender, e);
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x0008E840 File Offset: 0x0008CA40
		public void OnFocusLeaving(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnFocusLeaving(sender, e);
			}
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x0008E89C File Offset: 0x0008CA9C
		public void OnFocusLeft(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnFocusLeft(sender, e);
			}
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x0008E8F8 File Offset: 0x0008CAF8
		public void OnFocusEntering(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnFocusEntering(sender, e);
			}
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0008E954 File Offset: 0x0008CB54
		public void OnFocusEntered(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnFocusEntered(sender, e);
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x0008E9B0 File Offset: 0x0008CBB0
		public void OnValueChanging(global::SourceGrid.CellContext sender, global::DevAge.ComponentModel.ValueEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnValueChanging(sender, e);
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0008EA0C File Offset: 0x0008CC0C
		public void OnValueChanged(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnValueChanged(sender, e);
			}
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x0008EA68 File Offset: 0x0008CC68
		public void OnEditStarting(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnEditStarting(sender, e);
			}
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x0008EAC4 File Offset: 0x0008CCC4
		public void OnEditStarted(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnEditStarted(sender, e);
			}
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x0008EB20 File Offset: 0x0008CD20
		public void OnEditEnded(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnEditEnded(sender, e);
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x0008EB7C File Offset: 0x0008CD7C
		public bool CanReceiveFocus(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				if (!controller.CanReceiveFocus(sender, e))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x0008EBE8 File Offset: 0x0008CDE8
		public void OnDragDrop(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnDragDrop(sender, e);
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x0008EC44 File Offset: 0x0008CE44
		public void OnDragEnter(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnDragEnter(sender, e);
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x0008ECA0 File Offset: 0x0008CEA0
		public void OnDragLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnDragLeave(sender, e);
			}
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x0008ECFC File Offset: 0x0008CEFC
		public void OnDragOver(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnDragOver(sender, e);
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x0008ED58 File Offset: 0x0008CF58
		public void OnGiveFeedback(global::SourceGrid.CellContext sender, global::System.Windows.Forms.GiveFeedbackEventArgs e)
		{
			foreach (global::SourceGrid.Cells.Controllers.IController controller in this.m_ControllerList)
			{
				controller.OnGiveFeedback(sender, e);
			}
		}

		// Token: 0x04000E31 RID: 3633
		private global::SourceGrid.Cells.Controllers.ControllerContainer.ControllerList m_ControllerList;

		// Token: 0x020004CF RID: 1231
		public class ControllerList : global::DevAge.Collections.ListByType<global::SourceGrid.Cells.Controllers.IController>
		{
		}
	}
}
