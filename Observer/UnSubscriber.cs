namespace Observer
{
    using System;
    using System.Collections.Generic;

    internal class Unsubscriber<BaggageInfo> : IDisposable
    {
        private readonly List<IObserver<BaggageInfo>> observers;
        private readonly IObserver<BaggageInfo> observer;

        internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}