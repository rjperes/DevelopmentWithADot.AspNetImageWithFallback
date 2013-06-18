using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevelopmentWithADot.AspNetImageWithFallback
{
	public class ImageWithFallback : Image
	{
		[DefaultValue("")]
		[UrlProperty]
		public String FallbackUrl
		{
			get;
			set;
		}

		protected override void OnLoad(EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(this.FallbackUrl) == false)
			{
				this.Attributes["onerror"] = String.Format("this.src = '{0}'", this.ResolveUrl(this.FallbackUrl));
			}

			base.OnLoad(e);
		}
	}
}