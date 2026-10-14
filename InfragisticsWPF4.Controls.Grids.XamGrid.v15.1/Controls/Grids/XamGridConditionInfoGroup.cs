using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000EC RID: 236
	[global::System.ComponentModel.Browsable(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class XamGridConditionInfoGroup : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x0001FF05 File Offset: 0x0001E105
		public XamGridConditionInfoGroup(global::Infragistics.Controls.Grids.XamGridConditionInfoGroup parentGroup)
		{
			this.ParentGroup = parentGroup;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0001FF1F File Offset: 0x0001E11F
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x0001FF28 File Offset: 0x0001E128
		public global::Infragistics.Controls.Grids.XamGridConditionInfoGroup ParentGroup
		{
			get
			{
				return this._parentGroup;
			}
			set
			{
				if (this._parentGroup != value)
				{
					if (this._parentGroup != null)
					{
						this._parentGroup.ChildGroups.Remove(this);
					}
					this._parentGroup = value;
					if (this._parentGroup != null)
					{
						this._parentGroup.ChildGroups.Add(this);
					}
					this.OnPropertyChanged("ParentGroup");
					this.OnPropertyChanged("Level");
					this.OnPropertyChanged("LevelName");
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0001FF9C File Offset: 0x0001E19C
		public int Level
		{
			get
			{
				int num = 0;
				for (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup parentGroup = this._parentGroup; parentGroup != null; parentGroup = parentGroup._parentGroup)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0001FFC3 File Offset: 0x0001E1C3
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0001FFCB File Offset: 0x0001E1CB
		public global::Infragistics.LogicalOperator Operator
		{
			get
			{
				return this._operator;
			}
			set
			{
				if (this._operator != value)
				{
					this._operator = value;
					this.OnPropertyChanged("Operator");
				}
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
		protected internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfo> InfoObjects
		{
			get
			{
				if (this._infoObjects == null)
				{
					this._infoObjects = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfo>();
				}
				return this._infoObjects;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00020003 File Offset: 0x0001E203
		protected internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> ChildGroups
		{
			get
			{
				return this._childGroups;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0002000C File Offset: 0x0001E20C
		public string LevelName
		{
			get
			{
				string text = "";
				if (this._parentGroup == null)
				{
					text = "0" + text;
				}
				else
				{
					text = this.ParentGroup.LevelName + this.ParentGroup.ChildGroups.IndexOf(this);
				}
				return text;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060007CD RID: 1997 RVA: 0x00020060 File Offset: 0x0001E260
		// (remove) Token: 0x060007CE RID: 1998 RVA: 0x00020098 File Offset: 0x0001E298
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060007CF RID: 1999 RVA: 0x000200CD File Offset: 0x0001E2CD
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x040001E8 RID: 488
		private global::Infragistics.Controls.Grids.XamGridConditionInfoGroup _parentGroup;

		// Token: 0x040001E9 RID: 489
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfo> _infoObjects;

		// Token: 0x040001EA RID: 490
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> _childGroups = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>();

		// Token: 0x040001EB RID: 491
		private global::Infragistics.LogicalOperator _operator;
	}
}
