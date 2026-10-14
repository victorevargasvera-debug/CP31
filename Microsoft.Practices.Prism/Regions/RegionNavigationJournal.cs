using System;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200007A RID: 122
	public class RegionNavigationJournal : global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournal
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000979E File Offset: 0x0000799E
		// (set) Token: 0x06000358 RID: 856 RVA: 0x000097A6 File Offset: 0x000079A6
		public global::Microsoft.Practices.Prism.Regions.INavigateAsync NavigationTarget { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000359 RID: 857 RVA: 0x000097AF File Offset: 0x000079AF
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000097B7 File Offset: 0x000079B7
		public global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry CurrentEntry { get; private set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600035B RID: 859 RVA: 0x000097C0 File Offset: 0x000079C0
		public bool CanGoBack
		{
			get
			{
				return this.backStack.Count > 0;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000097D0 File Offset: 0x000079D0
		public bool CanGoForward
		{
			get
			{
				return this.forwardStack.Count > 0;
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00009844 File Offset: 0x00007A44
		public void GoBack()
		{
			if (this.CanGoBack)
			{
				global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry entry = this.backStack.Peek();
				this.InternalNavigate(entry, delegate(bool result)
				{
					if (result)
					{
						if (this.CurrentEntry != null)
						{
							this.forwardStack.Push(this.CurrentEntry);
						}
						this.backStack.Pop();
						this.CurrentEntry = entry;
					}
				});
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000098F4 File Offset: 0x00007AF4
		public void GoForward()
		{
			if (this.CanGoForward)
			{
				global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry entry = this.forwardStack.Peek();
				this.InternalNavigate(entry, delegate(bool result)
				{
					if (result)
					{
						if (this.CurrentEntry != null)
						{
							this.backStack.Push(this.CurrentEntry);
						}
						this.forwardStack.Pop();
						this.CurrentEntry = entry;
					}
				});
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000993F File Offset: 0x00007B3F
		public void RecordNavigation(global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry entry)
		{
			if (!this.isNavigatingInternal)
			{
				if (this.CurrentEntry != null)
				{
					this.backStack.Push(this.CurrentEntry);
				}
				this.forwardStack.Clear();
				this.CurrentEntry = entry;
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00009974 File Offset: 0x00007B74
		public void Clear()
		{
			this.CurrentEntry = null;
			this.backStack.Clear();
			this.forwardStack.Clear();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000099E0 File Offset: 0x00007BE0
		private void InternalNavigate(global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry entry, global::System.Action<bool> callback)
		{
			this.isNavigatingInternal = true;
			this.NavigationTarget.RequestNavigate(entry.Uri, delegate(global::Microsoft.Practices.Prism.Regions.NavigationResult nr)
			{
				this.isNavigatingInternal = false;
				if (nr.Result != null)
				{
					callback(nr.Result.Value);
				}
			});
		}

		// Token: 0x040000C3 RID: 195
		private global::System.Collections.Generic.Stack<global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry> backStack = new global::System.Collections.Generic.Stack<global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry>();

		// Token: 0x040000C4 RID: 196
		private global::System.Collections.Generic.Stack<global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry> forwardStack = new global::System.Collections.Generic.Stack<global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry>();

		// Token: 0x040000C5 RID: 197
		private bool isNavigatingInternal;
	}
}
