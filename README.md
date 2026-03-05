# Big & Clear
A lightweight, high-contrast text editor built with C# and WinForms. This project focuses on accessibility and interactability for users with visual impairments or motor challenges.

## Key Features
- High Contrast Mode: Toggle between standard view and a high-visibility Yellow-on-Black theme.
- Screen Reader Ready: Implements AccessibleName properties for seamless use with NVDA or JAWS.
- Keyboard-First Design: Full navigation support without the need for a mouse.
- Dynamic Large Fonts: Default 18pt Segoe UI for improved readability.

## Technical Details
- Language: C#
- Framework: .NET 8.0 (Windows Forms)
- Tools: VS Code, .NET SDK

## Getting Started
### Prerequisites
- You must have the .NET SDK installed.

### Installation and Running
Clone this repository:

```
git clone <your-repo-link>
```

Navigate into the project folder:

```
cd AccessiblePad
```
Run the application:

```
dotnet run
```

## Accessibility Checklist
- [x] High-contrast color ratios.
- [x] Logical Tab order for keyboard users.
- [x] Descriptive labels for assistive technology.
- [x] Save functionality
- [ ] Open file functionality
