# Restaurants API

#### C#/.NET Core API for restaurants with full CRUD functionality. Current version: 04.03.20

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

Epicodus Friday project: C#/.NET Core API for restaurants with full CRUD functionality.

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

## API Documentation

- Base url: http://localhost:5000

| Action                 | Method                                                                                                                           | Endpoint                                            |
| :--------------------- | :------------------------------------------------------------------------------------------------------------------------------- | :-------------------------------------------------- |
| List all restaurants   | GET                                                                                                                              | /restaurants                                        |
| As the business owner, | I want to add new employees                                                                                                      | so that I can view the complete list                |  |
| As the salon owner,    | I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist              | to stay organized                                   |
| As the business owner, | I want to see the clients belonging to those employees                                                                           | to simplify payment accounts                        |
| As the salon owner,    | I need to be able to add new clients to a specific stylist (I should not be able to add a client if no stylists have been added) | so that I don't have unassigned clients by mistake. |
| As the business owner, | I want name and preferred employee for clients visible                                                                           | so that my tracker is useful from both sides        |
| As the business owner, | I want a splash page                                                                                                             | so that I can access any sides of my site           |
| As the business owner, | I want to be able to delete clients or employees                                                                                 | in case of changes to the business                  |
| As the business owner, | I want to be able to edit clients or employees                                                                                   | in case of changes, or user error                   |

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
