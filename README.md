# FeatureLb

FeatureLb is a lightweight C# feature toggle library that allows enabling and disabling application functionality without recompilation or redeployment.

The library implements a Feature Flags (Feature Toggles) mechanism, enabling dynamic control over features based on conditions such as user percentage or activation date.

## Key Features
* Enable or disable features without changing application code
* Roll out features to a percentage of users
* Activate features after a specific date
* Support for user context–based checks
* Easy integration with .NET applications

## Main methods:
AddFeature — registers a new feature
IsFeatureEnabled — checks whether a feature is enabled for a specific user

## Use
"using FeatureLb;

Manager manager = new Manager();

Flag newFeature = new Flag("NewChat")
{
    IsEnabled = true,
    EnabledPercent = 10,
    EnableAfterDate = new DateTime(2024, 1, 1)
};

manager.AddFeature(newFeature);

UserContext user = new UserContext(15);
bool isEnabled = manager.IsFeatureEnabled("NewChat", user);
"
