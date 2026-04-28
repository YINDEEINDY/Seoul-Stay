<h1 align="center">Seoul-Stay</h1>

<p align="center">
  Stay-booking platform built in C# / .NET. Clean layered architecture, real data flows.<br/>
  Where I went from "fearing layered architecture" to "actually liking it."
</p>

---

## What it is

A booking platform for short-term stays — search by city/date, view property detail, book, manage reservations. Built as a learning project to internalize layered architecture, EF Core relations, and clean controller patterns in .NET.

## What I learned building it

- **Layered separation actually pays off** — Controllers stay thin, business logic lives in services, data access in repositories. When I needed to add a new "favorite property" feature, I touched exactly 3 files.
- **EF Core navigation properties** are a trap if you don't pay attention to lazy loading. Got bitten once with N+1 queries on the property listing page.
- **DTOs are not boilerplate** — they're a contract. The day I exposed an entity directly was the day I leaked an internal field.

## Features

- Property search with filters (city, dates, price, amenities)
- Property detail with gallery and reviews
- Booking flow with conflict detection
- User account: profile, booking history, favorites
- Host account: list properties, manage availability, view bookings

## Stack

**Backend** ASP.NET Core · C# · Entity Framework Core · SQL Server  
**Architecture** Controller → Service → Repository  
**Auth** JWT bearer  
**Validation** FluentValidation  
**Testing** xUnit

## Run locally

```bash
cd Seoul-Stay
dotnet restore
dotnet ef database update
dotnet run --project Seoul-Stay.API
```

Server runs on https://localhost:5001 by default.

---

Built by **Yindee Sajarern** ([@YINDEEINDY](https://github.com/YINDEEINDY)).
