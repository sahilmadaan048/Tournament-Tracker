# Tournament Tracker

## Table of Contents

1. Project Overview
2. Features
3. Technology Stack
4. Architecture
5. Installation
6. Configuration
7. Usage
8. Data Storage
9. Contribution
<!-- 10. License -->

---

## 1. Project Overview

Tournament Tracker is a .NET application developed using C#. The project aims to provide a complete, flexible, and extensible solution for organizing and tracking tournaments. It demonstrates core software development concepts such as object-oriented design, event-driven architecture, data persistence, and user interface design using WinForms.

This application is part of a learning series based on the “Tournament Tracker” tutorial playlist.

Tutorial Playlist:
[https://www.youtube.com/watch?v=AB0MJkbFEYg&list=PLLWMQd6PeGY3t63w-8MMIjIyYS7MsFcCi&index=13](https://www.youtube.com/watch?v=AB0MJkbFEYg&list=PLLWMQd6PeGY3t63w-8MMIjIyYS7MsFcCi&index=13)

---

## 2. Features

* Create single and multi-round tournaments
* Add teams and players
* Track matchups and results
* Automatically generate brackets
* Update scores and progress tournament rounds
* Store and load data from multiple data sources
* Support for configuration and settings

---

## 3. Technology Stack

* Language: C#
* Framework: .NET (Framework version based on project requirements)
* UI: Windows Forms (WinForms)
* Data Storage:

  * CSV text files
  * SQL database (optional or future implementation)
* IDE: Visual Studio

---

## 4. Architecture

The application follows a layered structure:

* **User Interface Layer (WinForms):** Handles UI interactions and displays tournament data
* **Class Library (Business Logic):** Contains models such as Team, Player, Tournament, Matchup, and logic for tournament generation and progression
* **Data Access Layer:** Implements text file and database data storage strategies
* **Event System:** Uses custom events to decouple UI from business logic

---

## 5. Installation

1. Clone the repository:

   ```
   git clone https://github.com/sahilmadaan048/Tournament-Tracker.git
   ```

2. Open the solution file in Visual Studio:

   ```
   Tournament-Tracker.sln
   ```

3. Restore NuGet packages if required

4. Build the solution

---

## 6. Configuration

The application uses a configuration file to define file paths and settings.

Example configuration section:

```
"FileSettings": {
  "FilePath": "D:\\Code_Everyday\\Tournament - Tracker\\Tournament Tracker\\DataFiles"
}
```

Ensure that the paths are correct and accessible by the application.

---

## 7. Usage

1. Launch the application from Visual Studio or by running the compiled executable
2. On the main menu:

   * Create a new tournament
   * Load existing tournaments
3. Add teams, players, and enter scores to progress the tournament
4. Save tournament data for later retrieval

---

## 8. Data Storage

The application supports multiple data storage options:

### CSV File Storage

* Participant data is stored in CSV (comma separated values) format
* Text files used for models like Person, Team, Tournament, and Matchup

### SQL Database (optional)

* The project may be extended to support SQL database storage
* Use connection strings and ORM as required for database integration

---

## 9. Contribution

If you wish to contribute:

1. Fork the repository
2. Create a feature branch
3. Write clean, documented code
4. Create a pull request with clear descriptions

Ensure changes align with the current architecture and patterns.
