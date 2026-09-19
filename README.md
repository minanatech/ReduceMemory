# Reduce Memory

A small, free tool that frees up the RAM working set of running programs on Windows.

Reduce Memory shows your current RAM usage and, on demand, asks Windows to trim the working set of running processes. It is a single small executable, with no installer.

---

## What it actually does

Reduce Memory calls the Windows `EmptyWorkingSet` function on running processes. This asks Windows to move each process's working set out of physical RAM, which lowers the "in use" figure you see in Task Manager.

It is worth being honest about what this means. Modern Windows already manages memory well on its own, and RAM that shows as "in use" is often cache that is helping performance, not wasting it. Emptying the working set does not make your PC faster in general, and trimmed data is simply read back from disk the next time a program needs it. This tool is useful for lowering the reported RAM figure and in some narrow cases before launching something heavy, not as a general speed booster. If you were expecting magic, there isn't any, here or in any similar tool.

## Features

- Live view of current RAM usage
- Free the working set of running processes on demand
- Optional auto-run when RAM load goes above 80 percent
- Optional run at Windows startup

## Requirements

- Windows 7 SP1 or later (tested on Windows 10 and 11)
- .NET Framework 4.8, already included in Windows 10 and 11

## Download

Get the latest build from the [Releases](https://github.com/minanatech/ReduceMemory/releases) page, or from [minanatech.com](https://minanatech.com).

Each release lists a SHA-256 checksum. To verify your download, run this in Command Prompt:

```
certutil -hashfile reducememory.exe SHA256
```

The result should match the checksum published with that release.

## A note on antivirus warnings

This program reads the process list and trims memory, and it can optionally add itself to Windows startup. Those are normal things for a memory tool to do, but they are also patterns that some antivirus engines treat with suspicion, so a false positive is possible. The source is here so you can see exactly what it does, and the checksum lets you confirm the file is unaltered. You can also build it yourself.

## Building from source

Open `reducememory.csproj` in Visual Studio and build in Release configuration. The project targets .NET Framework 4.8 and has no external dependencies.

## Licence

Released under the MIT Licence. See [LICENSE](LICENSE) for the full text.

The application icon is used under its own licence. Please confirm and credit it here before wider distribution.

---

Made by [minanatech.com](https://minanatech.com)
