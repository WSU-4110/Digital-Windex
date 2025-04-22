# Installation Guide

This document explains how to install **Digital Windex** on a Windows machine using the MSI or setup.exe installer.

---

## System Requirements

- **Operating System:** Windows 10 or 11 (64‑bit)
- **.NET Runtime:** .NET Framework 4.8 (installed) *or* Redistributable (if not already present)
- **Disk Space:** At least 50 MB free
- **Permissions:** Administrator privileges for installation and certain features (e.g., DISM, SFC)

---

## Downloading the Installer

1. Go to the [Releases](https://github.com/WSU-4110/Digital-Windex/releases) page on GitHub.
2. Find the tag **v1.0.0** (or latest) and click on it.
3. Under **Assets**, download one of the following:
   - `DigitalWindex-v1.0.0.msi` (Windows Installer package)  
   - `setup.exe` (self‑extracting bootstrapper)

---

## Running the Installer

1. **Locate** the downloaded file in your `Downloads` folder.
2. **Right‑click** the MSI or EXE and choose **Run as administrator**.
3. Follow the on‑screen prompts:
   - Accept the license agreement.
   - Choose an install folder (default: `C:\Program Files\DigitalWindex`).
4. Click **Install** and wait for the process to complete.
5. Click **Finish** when prompted.

---

## Uninstalling

1. Open **Settings** → **Apps** → **Apps & features**.
2. Find **Digital Windex** in the list.
3. Click **Uninstall** and follow the prompts.

Alternatively, run the MSI again and choose **Remove**.

---

## Troubleshooting

- **Installer won’t run or errors out:**
  - Ensure you have **administrator** privileges.
  - Confirm .NET Framework 4.8 is installed: [Download .NET 4.8 Runtime](https://dotnet.microsoft.com/download/dotnet-framework/net48).

---

_For additional help, open an issue on our GitHub repo or contact the development team._

