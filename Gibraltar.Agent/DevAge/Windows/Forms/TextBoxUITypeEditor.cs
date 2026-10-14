using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevAge.Windows.Forms
{
	// Token: 0x02000318 RID: 792
	internal class TextBoxUITypeEditor : global::DevAge.Windows.Forms.DevAgeTextBoxButton, global::System.Windows.Forms.Design.IWindowsFormsEditorService, global::System.ComponentModel.ITypeDescriptorContext, global::System.IServiceProvider
	{
		// Token: 0x06002569 RID: 9577 RVA: 0x000829A4 File Offset: 0x00080BA4
		public TextBoxUITypeEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x000829B4 File Offset: 0x00080BB4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x000829DC File Offset: 0x00080BDC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x000829EC File Offset: 0x00080BEC
		public override void ShowDialog()
		{
			try
			{
				this.OnDialogOpen(global::System.EventArgs.Empty);
				if (this.m_UITypeEditor != null)
				{
					global::System.Drawing.Design.UITypeEditorEditStyle editStyle = this.m_UITypeEditor.GetEditStyle();
					if (editStyle == global::System.Drawing.Design.UITypeEditorEditStyle.DropDown || editStyle == global::System.Drawing.Design.UITypeEditorEditStyle.Modal)
					{
						object value;
						if (!base.IsValidValue(out value))
						{
							if (base.Validator != null)
							{
								value = base.Validator.DefaultValue;
							}
							else
							{
								value = null;
							}
						}
						object value2 = this.m_UITypeEditor.EditValue(this, this, value);
						base.Value = value2;
					}
				}
				this.OnDialogClosed(global::System.EventArgs.Empty);
			}
			catch (global::System.Exception ex)
			{
				global::System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x00082AA4 File Offset: 0x00080CA4
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x00082AAC File Offset: 0x00080CAC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Drawing.Design.UITypeEditor UITypeEditor
		{
			get
			{
				return this.m_UITypeEditor;
			}
			set
			{
				this.m_UITypeEditor = value;
			}
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00082AB8 File Offset: 0x00080CB8
		protected override void ApplyValidatorRules()
		{
			base.ApplyValidatorRules();
			if (this.m_UITypeEditor == null && base.Validator != null)
			{
				object editor = global::System.ComponentModel.TypeDescriptor.GetEditor(base.Validator.ValueType, typeof(global::System.Drawing.Design.UITypeEditor));
				if (editor is global::System.Drawing.Design.UITypeEditor)
				{
					this.m_UITypeEditor = (global::System.Drawing.Design.UITypeEditor)editor;
				}
			}
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00082B18 File Offset: 0x00080D18
		object global::System.IServiceProvider.GetService(global::System.Type serviceType)
		{
			if (serviceType == typeof(global::System.Windows.Forms.Design.IWindowsFormsEditorService))
			{
				return this;
			}
			return null;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00082B30 File Offset: 0x00080D30
		public virtual void CloseDropDown()
		{
			if (this.m_dropDown != null)
			{
				this.m_dropDown.CloseDropDown();
			}
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00082B48 File Offset: 0x00080D48
		public virtual void DropDownControl(global::System.Windows.Forms.Control control)
		{
			using (this.m_dropDown = new global::DevAge.Windows.Forms.DropDown(control, this, base.ParentForm))
			{
				this.m_dropDown.DropDownFlags = global::DevAge.Windows.Forms.DropDownFlags.CloseOnEscape;
				this.m_dropDown.ShowDropDown();
				this.m_dropDown.Close();
			}
			this.m_dropDown = null;
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00082BB8 File Offset: 0x00080DB8
		public virtual global::System.Windows.Forms.DialogResult ShowDialog(global::System.Windows.Forms.Form dialog)
		{
			return dialog.ShowDialog(this);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00082BC4 File Offset: 0x00080DC4
		void global::System.ComponentModel.ITypeDescriptorContext.OnComponentChanged()
		{
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x00082BC8 File Offset: 0x00080DC8
		global::System.ComponentModel.IContainer global::System.ComponentModel.ITypeDescriptorContext.Container
		{
			get
			{
				return base.Container;
			}
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00082BD0 File Offset: 0x00080DD0
		bool global::System.ComponentModel.ITypeDescriptorContext.OnComponentChanging()
		{
			return true;
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x00082BD4 File Offset: 0x00080DD4
		object global::System.ComponentModel.ITypeDescriptorContext.Instance
		{
			get
			{
				return base.Value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x00082BDC File Offset: 0x00080DDC
		global::System.ComponentModel.PropertyDescriptor global::System.ComponentModel.ITypeDescriptorContext.PropertyDescriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000D3B RID: 3387
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000D3C RID: 3388
		private global::System.Drawing.Design.UITypeEditor m_UITypeEditor;

		// Token: 0x04000D3D RID: 3389
		private global::DevAge.Windows.Forms.DropDown m_dropDown;
	}
}
