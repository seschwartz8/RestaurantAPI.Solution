# API for Restaurants/Shops

#### C#/.NET Core API for restaurants/shops with full CRUD functionality. Current version: 04.03.20

#### By Sarah "Sasa" Schwartz

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [API Documentaion](#api-documentation)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

## Description

Epicodus Friday project: C#/.NET Core API for restaurants/shops with full CRUD functionality.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the RestaurantAPI directory, within the RestaurantAPI.Solution directory
- \$dotnet restore
- Recreate my database structure with migration:
  - \$dotnet ef migrations add Initial
  - \$dotnet ef database update
- \$dotnet run (runs the server at localhost:5000)
- Call this API with your web application or test out the requests using Postman.

## User Stories

- As a user, I want to be able to GET all photos related to a specific tag.
- As a user, I want to be able to POST photos to a specific tag.
- As a user, I want to be able to see a list of all tags.
- As a user, I want to input date parameters and retrieve only photos posted during that timeframe.
- As a user, I want to be able to PUT and DELETE photos, but only if I posted them.

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
