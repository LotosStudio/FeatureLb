using System;

namespace FeatureLb
{
    public class Flag
    {
        public string Name { get; set; }

        public bool IsEnabled { get; set; }

        public int EnabledPercent { get; set; }

        public DateTime? EnableAfterDate { get; set; }

        public Flag(string name)
        {
            Name = name;
            IsEnabled = false;
            EnabledPercent = 100;
            EnableAfterDate = null;
        }
    }
}
