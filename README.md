# LaborGuard
ASP.NET 10 WebAPI using Clean Architecture, designed to ingest and validate employee schedule csv data. 
Enforces labor rules (11h rest periods, 40h weekly caps), avoiding persisting non-compliant data.

# Setup
## 1.Configure user secrets
```json
{
  "JwtConfig": {
    "Secret": "a-string-secret-at-least-256-bits-long",
    "Issuer": "http://localhost:7298/",
    "Audience": "http://localhost:7298/",
    "AccessTokenExpirationMinutes": "15",
    "RefreshTokenExpirationDays": "7"
  }
}
```