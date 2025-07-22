# Auto101Selenium

## Description
A small .NET 8.0 project demonstrating how to set up and run Selenium WebDriver tests using Microsoft Edge (msedge) driver. Includes sample automated test (`UnitTest1`) that navigates to Google, scrolls, waits for a cookie banner, clicks “Accept all” and verifies the search button.

## Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (or later) or VS Code with C# extension
- Microsoft Edge browser installed
- msedgedriver.exe matching your Edge version

## .gitignore
Excludes Visual Studio and related build artefacts for a cleaner repository

## Setup
1. **Clone the repo**  
   ```bash
   git clone <repository-url>
   cd Auto101Selenium

2. **Download EdgeDriver**
   Download the matching driver from:
   [https://developer.microsoft.com/en-gb/microsoft-edge/tools/webdriver?form=MA13LH](https://developer.microsoft.com/en-gb/microsoft-edge/tools/webdriver?form=MA13LH)

3. **Place msedgedriver.exe**
   Copy `msedgedriver.exe` into the `Resources` folder within the project root.

4. **Configure driver path**
   In `UnitTest1.cs` constructor, replace:

   ```csharp
   var driverPath = @"<path-to-driver>\Resources\msedgedriver.exe";
   ```

   with the actual relative or absolute path to `msedgedriver.exe`.

## Build

```bash
dotnet build Auto101Selenium.sln
```

## Usage

Run tests via CLI or Visual Studio Test Explorer.

### Command Line

```bash
cd Auto101Selenium
dotnet test
```

## Implementing Utility Methods

Two helper methods in `UnitTest1.cs` are stubbed out for custom interactions:

```csharp
public void WaitAndClick()
{
    // TODO: implement explicit or fluent wait then click logic
}

public void ScrollAndClick()
{
    // TODO: implement scroll-into-view then click logic
}
```

## Project Structure

```
/
├─ Auto101Selenium.sln        # Solution file
├─ Auto101Selenium/           # C# project folder
│  ├─ Auto101Selenium.csproj
│  ├─ Resources/msedgedriver.exe
│  └─ UnitTest1.cs
└─ .gitignore
```

## Running in Visual Studio

1. Open `Auto101Selenium.sln`.
2. Restore NuGet packages.
3. Build solution.
4. Run UnitTest1 via Test Explorer.

## Contributing

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m "Add YourFeature"`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a Pull Request.

## License

MIT License – see [LICENSE](LICENSE) for details.
