# Grocery App

The Grocery App is a simple application that allows users to manage a list of groceries. It provides a graphical user interface (GUI) built using the Windows Presentation Foundation (WPF) framework and follows the Model-View-ViewModel (MVVM) design pattern. Users can add and remove grocery items from a grid table, with each item represented by its ID, Name, Price, Description, and Stock.

## Features

- Add new grocery items to the list.
- Remove grocery items from the list.
- View and manage grocery item details including Name, Price, Description, and Stock.
- Utilizes the MVVM design pattern for a structured and maintainable codebase.
- Provides a user-friendly graphical interface.

## Prerequisites

- Windows operating system.
- .NET Framework (compatible version, e.g., .NET Framework 4.7.2).

## Getting Started

1. Clone this repository to your local machine using `git clone https://github.com/your-username/grocery-app.git`.
2. Open the solution file (`GroceryApp.sln`) using Visual Studio.
3. Build and run the application using the Visual Studio IDE.
4. The application's main window will appear, displaying the grid table with grocery item information.
5. Use the "Add" button to add new grocery items to the list. Fill in the required information for each item.
6. Use the "Remove" button to remove selected grocery items from the list.

## Folder Structure

- `GroceryApp/`: Contains the WPF application project files.
    - `ViewModels/`: Contains the ViewModel classes implementing the MVVM pattern.
    - `Views/`: Contains the XAML views for the application.
    - `Models/`: Contains the data models used by the application.
    - `Commands/`: Contains the RelayCommand implementation for binding UI actions to ViewModel methods.
- `GroceryApp.Tests/`: Contains unit tests for the application logic.

## Contributing

Contributions to the Grocery App are welcome! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and ensure they are thoroughly tested.
4. Submit a pull request describing your changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

Developed by [Your Name](https://github.com/your-username)
