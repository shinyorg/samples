using System;
using Xamarin.Forms;


namespace Sample
{
    public static class Extensions
    {
        public static IDisposable SubOnMainThread<T>(this IObservable<T> observable, Action<T> onAction) =>
            observable.Subscribe(x => Device.BeginInvokeOnMainThread(() => onAction(x)));

        public static IDisposable SubOnMainThread<T>(this IObservable<T> observable, Action<T> onAction, Action<Exception> onError) =>
            observable.Subscribe(x => Device.BeginInvokeOnMainThread(() => onAction(x)), onError);

        public static IDisposable SubOnMainThread<T>(this IObservable<T> observable, Action<T> onAction, Action<Exception> onError, Action onComplete) =>
            observable.Subscribe(
                x => Device.BeginInvokeOnMainThread(() => onAction(x)),
                onError,
                onComplete
            );

        public static void TryFireOnAppearing(this Page page)
            => (page.BindingContext as SampleViewModel)?.OnAppearing();

        public static void TryFireOnDisappearing(this Page page)
            => (page.BindingContext as SampleViewModel)?.OnDisappearing();
    }
}