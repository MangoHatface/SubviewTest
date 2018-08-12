// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SubviewTest.Controllers
{
	[Register ("ContainerViewController")]
	partial class ContainerViewController
	{
		[Outlet]
		AppKit.NSTextField NumberOfSubviewsBox { get; set; }

		[Outlet]
		AppKit.NSView SubviewContainerView { get; set; }

		[Action ("AddSubviewButtonClick:")]
		partial void AddSubviewButtonClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (NumberOfSubviewsBox != null) {
				NumberOfSubviewsBox.Dispose ();
				NumberOfSubviewsBox = null;
			}

			if (SubviewContainerView != null) {
				SubviewContainerView.Dispose ();
				SubviewContainerView = null;
			}
		}
	}
}
