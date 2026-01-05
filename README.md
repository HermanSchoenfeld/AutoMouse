# AutoMouse

AutoMouse is a Windows background utility that helps reduce the strain of repetitive mouse clicking by letting you click (and perform common mouse actions) using your keyboard, or by automatically clicking when the mouse stops moving.

This repository contains the source code for the AutoMouse Windows application.

## Why AutoMouse?

For many people, repeated mouse-button clicking can contribute to discomfort or repetitive strain issues. AutoMouse aims to reduce click-heavy usage by shifting some of that workload to the keyboard and by providing dwell/auto-click style interaction.

## Features

Based on the product description on https://sphere10.com/products/automouse (paraphrased):

- **Keyboard-driven clicking**: map a keyboard key to act as a mouse click without permanently “stealing” that key for normal typing.
- **Automatic clicking (dwell click)**: optionally click when the mouse cursor stops moving.
- **Common mouse gestures without buttons**: supports actions such as click, double-click, drag-and-drop, and stroke-like interactions.
- **Keyboard cursor movement**: move the mouse cursor with arrow keys while preserving normal arrow-key behavior when you’re typing.
- **Left/right button swap**: useful for left-handed setups or to reduce strain on a particular finger.
- **Visual/audio feedback**: optional on-screen rings and click sounds to confirm when AutoMouse performs an action.
- **Startup and configuration**: can be configured extensively (keys, timings, distances) and can start automatically with Windows.

## Downloads

- **Microsoft Store**: https://apps.microsoft.com/store/detail/auto-mouse-rsi/9PD57FSWQD6P

## Screenshots

The following images are linked from the official product page (Sphere10):

![AutoMouse screenshot 1](https://sphere10.com/files/5f71a532-df9c-456d-85c0-df07795b5595/Screenshot_1A.webp)

![AutoMouse screenshot 2](https://sphere10.com/files/d4471963-d6c0-44b2-aef1-6b16d0498f18/Auto_Mouse_-_Product_Shot_4_-_1366x768.webp)

![AutoMouse screenshot 3](https://sphere10.com/files/2b8cc5c2-7c73-47ae-aabe-630deeaa218d/Auto_Mouse_-_Product_Shot_5_-_1366x768.webp)

![AutoMouse screenshot 4](https://sphere10.com/files/28108abf-983d-41de-a675-ebe356dae27b/Auto_Mouse_-_Product_Shot_6_-_1366x768.webp)

## Documentation & Resources

Sphere10 provides additional end-user docs and ergonomics resources:

- Getting Started: https://sphere10.com/products/automouse/getting-started
- Product Manual: https://sphere10.com/products/automouse/product-manual
- RSI and ergonomics resources: https://sphere10.com/articles/what-is/rsi/repetitive-strain-injury

## Build From Source

### Prerequisites

- Windows
- .NET SDK **8.0+** (the app targets `net8.0-windows`)
- Visual Studio 2022 (optional, but convenient for WinForms)

### Build (CLI)

From the repository root:

```powershell
# Debug build

dotnet build "AutoMouse WIN.sln" -c Debug

# Release build

dotnet build "AutoMouse WIN.sln" -c Release
```

### Run

You can run the WinForms app project directly:

```powershell
dotnet run --project "AutoMouse.Windows/AutoMouse.Windows.csproj" -c Debug
```

## Publish

There are publish scripts in the repo root:

- `Publish-All.ps1`
- `Publish-Portable.ps1`
- `Publish-win-x64.ps1`

(These scripts are tailored to the project’s packaging workflow.)

## Repository Layout

- `AutoMouse.Windows/` — WinForms application
- `Resources/` — shared resources (icons, sounds, help/manual assets)

## License

This project is licensed under the **GNU GPL v3.0 (or later)**.

- See `LICENSE`
- Copyright details: `COPYRIGHT`

## Disclaimer

AutoMouse is an ergonomics/utility tool. It is not medical advice and is not a substitute for professional assessment or treatment.