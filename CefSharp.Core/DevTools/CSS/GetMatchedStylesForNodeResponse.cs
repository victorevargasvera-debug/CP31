using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200031E RID: 798
	[global::System.Runtime.Serialization.DataContract]
	public class GetMatchedStylesForNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x0001A2DE File Offset: 0x000184DE
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x0001A2E6 File Offset: 0x000184E6
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSStyle inlineStyle { get; set; }

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x0001A2EF File Offset: 0x000184EF
		public global::CefSharp.DevTools.CSS.CSSStyle InlineStyle
		{
			get
			{
				return this.inlineStyle;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x0001A2F7 File Offset: 0x000184F7
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x0001A2FF File Offset: 0x000184FF
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSStyle attributesStyle { get; set; }

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x0001A308 File Offset: 0x00018508
		public global::CefSharp.DevTools.CSS.CSSStyle AttributesStyle
		{
			get
			{
				return this.attributesStyle;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0001A310 File Offset: 0x00018510
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0001A318 File Offset: 0x00018518
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.RuleMatch> matchedCSSRules { get; set; }

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0001A321 File Offset: 0x00018521
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.RuleMatch> MatchedCSSRules
		{
			get
			{
				return this.matchedCSSRules;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0001A329 File Offset: 0x00018529
		// (set) Token: 0x06001872 RID: 6258 RVA: 0x0001A331 File Offset: 0x00018531
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.PseudoElementMatches> pseudoElements { get; set; }

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0001A33A File Offset: 0x0001853A
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.PseudoElementMatches> PseudoElements
		{
			get
			{
				return this.pseudoElements;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x0001A342 File Offset: 0x00018542
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x0001A34A File Offset: 0x0001854A
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.InheritedStyleEntry> inherited { get; set; }

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x0001A353 File Offset: 0x00018553
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.InheritedStyleEntry> Inherited
		{
			get
			{
				return this.inherited;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0001A35B File Offset: 0x0001855B
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x0001A363 File Offset: 0x00018563
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.InheritedPseudoElementMatches> inheritedPseudoElements { get; set; }

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0001A36C File Offset: 0x0001856C
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.InheritedPseudoElementMatches> InheritedPseudoElements
		{
			get
			{
				return this.inheritedPseudoElements;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x0001A374 File Offset: 0x00018574
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x0001A37C File Offset: 0x0001857C
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSKeyframesRule> cssKeyframesRules { get; set; }

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x0001A385 File Offset: 0x00018585
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSKeyframesRule> CssKeyframesRules
		{
			get
			{
				return this.cssKeyframesRules;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x0001A38D File Offset: 0x0001858D
		// (set) Token: 0x0600187E RID: 6270 RVA: 0x0001A395 File Offset: 0x00018595
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSPositionFallbackRule> cssPositionFallbackRules { get; set; }

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0001A39E File Offset: 0x0001859E
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSPositionFallbackRule> CssPositionFallbackRules
		{
			get
			{
				return this.cssPositionFallbackRules;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0001A3A6 File Offset: 0x000185A6
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0001A3AE File Offset: 0x000185AE
		[global::System.Runtime.Serialization.DataMember]
		internal int? parentLayoutNodeId { get; set; }

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0001A3B7 File Offset: 0x000185B7
		public int? ParentLayoutNodeId
		{
			get
			{
				return this.parentLayoutNodeId;
			}
		}
	}
}
