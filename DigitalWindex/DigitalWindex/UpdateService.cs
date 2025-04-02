using System.Collections.Generic;

namespace DigitalWindexUI
{
    public class UpdateService
    {
        private List<IUpdateObserver> observers = new List<IUpdateObserver>();
        private string currentStatus = "Idle";

        public void RegisterObserver(IUpdateObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IUpdateObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.UpdateStatus(currentStatus);
            }
        }

        public void CheckForUpdates()
        {
            currentStatus = "Checking for updates...";
            NotifyObservers();

            // Simulate update check
            System.Threading.Thread.Sleep(1000); // (Use async/await in production)
            currentStatus = "Your system is up to date.";
            NotifyObservers();
        }

        public void InstallUpdates()
        {
            currentStatus = "Installing updates...";
            NotifyObservers();

            System.Threading.Thread.Sleep(1000);
            currentStatus = "Updates installed successfully.";
            NotifyObservers();
        }
    }
}
