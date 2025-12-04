# aspire-dotnet-configuration

Example using Aspire and .NET Configuration

## Summary

This project demonstrates how .NET configuration behaves when environment variables are set through Aspire's `WithEnvironment()` method. It includes:

| App Name | Scenario | Expected | Actual |
|----------|----------|----------|--------|
| `app-none` | No environment variable set | `"Set in appsettings.json"` | `"Set in appsettings.json"` |
| `app-empty` | Environment variable set to empty string | `""` (empty string) | `"Set in appsettings.json"` (empty string is not overriding appsettings) |
| `app-string` | Environment variable set to value | `"Set in AppHost"` | `"Set in AppHost"` |
| `app-space` | Environment variable set to whitespace | `" "` (single space) | `" "` (space overrides appsettings) |

The `app-empty` actual value is surprising/unexpected!
