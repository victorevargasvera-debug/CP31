using System;

namespace System.Windows.Interactivity
{
	// Token: 0x02000015 RID: 21
	internal sealed class NameResolver
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000094 RID: 148 RVA: 0x00003A24 File Offset: 0x00001C24
		// (remove) Token: 0x06000095 RID: 149 RVA: 0x00003A5C File Offset: 0x00001C5C
		public event global::System.EventHandler<global::System.Windows.Interactivity.NameResolvedEventArgs> ResolvedElementChanged;

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00003A91 File Offset: 0x00001C91
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00003A9C File Offset: 0x00001C9C
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				global::System.Windows.DependencyObject @object = this.Object;
				this.name = value;
				this.UpdateObjectFromName(@object);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003ABE File Offset: 0x00001CBE
		public global::System.Windows.DependencyObject Object
		{
			get
			{
				if (string.IsNullOrEmpty(this.Name) && this.HasAttempedResolve)
				{
					return this.NameScopeReferenceElement;
				}
				return this.ResolvedObject;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003AE2 File Offset: 0x00001CE2
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00003AEC File Offset: 0x00001CEC
		public global::System.Windows.FrameworkElement NameScopeReferenceElement
		{
			get
			{
				return this.nameScopeReferenceElement;
			}
			set
			{
				global::System.Windows.FrameworkElement oldNameScopeReference = this.NameScopeReferenceElement;
				this.nameScopeReferenceElement = value;
				this.OnNameScopeReferenceElementChanged(oldNameScopeReference);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003B0E File Offset: 0x00001D0E
		private global::System.Windows.FrameworkElement ActualNameScopeReferenceElement
		{
			get
			{
				if (this.NameScopeReferenceElement == null || !global::System.Windows.Interactivity.Interaction.IsElementLoaded(this.NameScopeReferenceElement))
				{
					return null;
				}
				return this.GetActualNameScopeReference(this.NameScopeReferenceElement);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003B33 File Offset: 0x00001D33
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00003B3B File Offset: 0x00001D3B
		private global::System.Windows.DependencyObject ResolvedObject { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003B44 File Offset: 0x00001D44
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00003B4C File Offset: 0x00001D4C
		private bool PendingReferenceElementLoad { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003B55 File Offset: 0x00001D55
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00003B5D File Offset: 0x00001D5D
		private bool HasAttempedResolve { get; set; }

		// Token: 0x060000A2 RID: 162 RVA: 0x00003B66 File Offset: 0x00001D66
		private void OnNameScopeReferenceElementChanged(global::System.Windows.FrameworkElement oldNameScopeReference)
		{
			if (this.PendingReferenceElementLoad)
			{
				oldNameScopeReference.Loaded -= this.OnNameScopeReferenceLoaded;
				this.PendingReferenceElementLoad = false;
			}
			this.HasAttempedResolve = false;
			this.UpdateObjectFromName(this.Object);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003B9C File Offset: 0x00001D9C
		private void UpdateObjectFromName(global::System.Windows.DependencyObject oldObject)
		{
			global::System.Windows.DependencyObject resolvedObject = null;
			this.ResolvedObject = null;
			if (this.NameScopeReferenceElement != null)
			{
				if (!global::System.Windows.Interactivity.Interaction.IsElementLoaded(this.NameScopeReferenceElement))
				{
					this.NameScopeReferenceElement.Loaded += this.OnNameScopeReferenceLoaded;
					this.PendingReferenceElementLoad = true;
					return;
				}
				if (!string.IsNullOrEmpty(this.Name))
				{
					global::System.Windows.FrameworkElement actualNameScopeReferenceElement = this.ActualNameScopeReferenceElement;
					if (actualNameScopeReferenceElement != null)
					{
						resolvedObject = (actualNameScopeReferenceElement.FindName(this.Name) as global::System.Windows.DependencyObject);
					}
				}
			}
			this.HasAttempedResolve = true;
			this.ResolvedObject = resolvedObject;
			if (oldObject != this.Object)
			{
				this.OnObjectChanged(oldObject, this.Object);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003C35 File Offset: 0x00001E35
		private void OnObjectChanged(global::System.Windows.DependencyObject oldTarget, global::System.Windows.DependencyObject newTarget)
		{
			if (this.ResolvedElementChanged != null)
			{
				this.ResolvedElementChanged(this, new global::System.Windows.Interactivity.NameResolvedEventArgs(oldTarget, newTarget));
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003C54 File Offset: 0x00001E54
		private global::System.Windows.FrameworkElement GetActualNameScopeReference(global::System.Windows.FrameworkElement initialReferenceElement)
		{
			global::System.Windows.FrameworkElement frameworkElement = initialReferenceElement;
			if (this.IsNameScope(initialReferenceElement))
			{
				frameworkElement = ((initialReferenceElement.Parent as global::System.Windows.FrameworkElement) ?? frameworkElement);
			}
			return frameworkElement;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003C80 File Offset: 0x00001E80
		private bool IsNameScope(global::System.Windows.FrameworkElement frameworkElement)
		{
			global::System.Windows.FrameworkElement frameworkElement2 = frameworkElement.Parent as global::System.Windows.FrameworkElement;
			if (frameworkElement2 != null)
			{
				object obj = frameworkElement2.FindName(this.Name);
				return obj != null;
			}
			return false;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003CB2 File Offset: 0x00001EB2
		private void OnNameScopeReferenceLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.PendingReferenceElementLoad = false;
			this.NameScopeReferenceElement.Loaded -= this.OnNameScopeReferenceLoaded;
			this.UpdateObjectFromName(this.Object);
		}

		// Token: 0x0400002C RID: 44
		private string name;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.FrameworkElement nameScopeReferenceElement;
	}
}
