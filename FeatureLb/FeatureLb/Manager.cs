using System;
using System.Collections.Generic;

namespace FeatureLb
{
    public class Manager
    {
        private List<Flag> _features;

        public Manager()
        {
            _features = new List<Flag>();
        }

        public void AddFeature(Flag feature)
        {
            _features.Add(feature);
        }

        public bool IsFeatureEnabled(string featureName, User user)
        {
            var feature = _features.Find(f => f.Name == featureName);

            if (feature == null)
            {
                return false;
            }

            if (!feature.IsEnabled)
            {
                return false;
            }

            if (feature.EnableAfterDate != null)
            {
                if (DateTime.Now < feature.EnableAfterDate)
                {
                    return false;
                }
            }

            int userPercent = user.UserId % 100;

            if (userPercent >= feature.EnabledPercent)
            {
                return false;
            }

            return true;
        }
    }
}
