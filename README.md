# Domino Challenge

A console application to analyze and display domino chains.

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-blue)

---

## Table of Contents
1. [Overview](#overview)
2. [Project Structure](#project-structure)
3. [Features](#features)
4. [Getting Started](#getting-started)
    1. [Prerequisites](#prerequisites)
    2. [Installation](#installation)
5. [Usage](#usage)
6. [Tests](#tests)
7. [License](#license)

---

## Overview

Domino Challenge is a console application designed to process and display domino chains. It provides functionalities for generating dominoes, displaying them, and identifying circular chains. The project is structured with clean separation between core logic and UI components, ensuring maintainability and scalability.

---


## Project Structure

The **Domino_Challenge** solution is organized as follows:

```plaintext
Domino_Challenge/
├── src/
│   ├── Core/
│   │   ├── Helper/
│   │   │   └── ConsoleHelper.cs
│   │   ├── Initialization/
│   │   │   └── InitializeDominoes.cs
│   │   ├── Interfaces/
│   │   │   ├── IDisplayer.cs
│   │   │   └── IDominoInputHandler.cs
│   │   ├── Logic/
│   │   │   └── CircularChains.cs
│   │   ├── Models/
│   │   │   └── Domino.cs
│   ├── UI/
│   │   ├── Displayer.cs
│   │   └── DominoInputHandler.cs
│   └── Program.cs
├── tests/
│   ├── unit/
│   │   ├── Helpers/
│   │   │   └── TestDataHelper.cs
│   │   ├── CircularChainsTests.cs
│   │   ├── DisplayerTests.cs
│   │   └── DominoInputHandlerTests.cs
```
---

## Features

* Domino Generation:
  * Predefined domino sets
  * Randomly generated dominoes
* Circular Chain Detection:
  * Finds all possible circular domino chains
* Display Options:
  * Console-based display of dominoes and results
* Clean Architecture:
  * Separation between core logic and UI

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) version 8.0 or higher
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/username/domino-challenge.git
2. Navigate to the `src` folder:

    ```bash
    cd domino-challenge/src
3. Build the project: 

    ```bash
    dotnet build
4. Run the application:

    ```bash
    dotnet run --project Domino_Challenge

---

## Usage

* **Run the Application:** Follow the on-screen instructions to:
  * Use predefined dominoes
  * Generate random dominoes
  * Exit the application
* **Examples:**
  * Use predefined dominoes: Input `1`.
  * Generate random dominoes: Input `2` and specify the number of dominoes.
* View the results for circular chains displayed in the console.

---

## Tests

Unit tests are available in the `tests/unit` folder. To run the tests:

1. Navigate to the `tests` folder:

    ```bash
    cd tests
2. Run all tests:

    ```bash
    dotnet test

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.