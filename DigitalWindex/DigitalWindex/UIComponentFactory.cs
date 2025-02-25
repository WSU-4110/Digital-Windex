using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public static class UIComponentFactory
    {
        public static Control GetComponent(string componentType)
        {
            switch (componentType.ToLower())
            {
                case "diagnostics":
                    return new DiagnosticsControl();  // Uses the existing class
                case "clean corruption":
                    return new CleanCorruptionForm();  // Uses the existing class
                default:
                    throw new ArgumentException($"Unknown component type: {componentType}");
            }
        }
    }
}
