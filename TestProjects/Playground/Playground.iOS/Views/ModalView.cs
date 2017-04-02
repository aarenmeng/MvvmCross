using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Playground.Core.ViewModels;
using UIKit;
using MvvmCross.iOS.Views.Presenters.Attributes;

namespace Playground.iOS.Views
{
    [MvxFromStoryboard("Main")]
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.OverFullScreen, ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public partial class ModalView : MvxViewController<ModalViewModel>
    {
        public ModalView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Orange;

            var set = this.CreateBindingSet<ModalView, ModalViewModel>();

            set.Bind(btnClose).To(vm => vm.CloseCommand);

            set.Apply();
        }
    }
}