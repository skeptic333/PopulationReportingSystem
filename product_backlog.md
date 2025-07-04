# Product Backlog

## Project Title: Population Reporting System

---

### User Stories
<<<<<<< HEAD
1. **As a user**, I want to view a list of all countries sorted by population. (**High Priority**)
2. **As a user**, I want to search top N populated cities in a given continent. (**High Priority**)
3. **As a user**, I want to view total population of a region. (**High Priority**)
4. **As a user**, I want to compare populations of people living in cities vs rural areas. (**Medium Priority**)
5. **As a user**, I want to generate a report of top languages spoken globally. (**Medium Priority**)
=======
1. View a list of all countries sorted by population.
2. Search top N populated cities in a given continent.
3. View total population of a region.
4. Compare city vs rural population.
5. Generate a report of top languages spoken globally.
>>>>>>> develop

---

### Must-Have Features
- View countries/cities by population.
- Top N populated countries/cities.
- Total population by continent/country.
- Basic GUI (WinForms interface).
- SQL database integration.

---

### Should-Have Features
- Language statistics.
- Capital cities reports.
- City vs Non-city population %.

---

### Could-Have Features
- Export report as PDF.
- Search filters by region/district.

---

### Tasks for Sprint 1 (Deadline: 7 May 2025)
- Set up MySQL database with `world` schema.
- Create tables for countries and cities.
- Implement `CountryRepository` and `CityRepository`.
- Write SQL queries for fetching countries and cities by population.
- Display countries sorted by population in the GUI.

---

### Tasks for Sprint 2 (Deadline: 14 May 2025)
- Add search functionality for top N populated cities.
- Display total population of a region.
- Add basic logging using Serilog.

---

### Tasks for Sprint 3 (Deadline: 21 May 2025)
- Compare city vs rural population.
- Generate language statistics report.
- Export reports as PDF.

---

### Acceptance Criteria
#### User Story 1: View a list of all countries sorted by population
- The user can view a list of all countries sorted by population.
- The list is fetched from the database and displayed in the GUI.
- The list updates dynamically if the database changes.

#### User Story 2: Search top N populated cities in a given continent
- The user can input a continent name and a number (N).
- The system displays the top N populated cities in the given continent.
- The data is accurate and fetched from the database.

---

### Dependencies
- Database setup must be completed before implementing `CountryRepository`.
<<<<<<< HEAD
- GUI framework (WinForms) must be set up before adding user interface features.
=======
- GUI framework must be set up before adding user interface features.
>>>>>>> develop

---

### Team Roles
<<<<<<< HEAD
- **Rana Awais** – Scrum Master
- **Muavia Saeed** – Developer
- **Abdullah Javed** – Product Owner
- **Adil Tahir** – Developer
=======
- **Adil Tahir** – Scrum Master
- **Rana Awais** – Product Owner
- **Muavia Saeed** – Developer
>>>>>>> develop
- **Awais Khan** – Developer
