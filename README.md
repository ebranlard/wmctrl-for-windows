# wmctrl-for-windows
Command line implementation of wmctrl for windows.
Only few features of the linux tool wmctrl are implemented so far, that is:

- List the window titles, process name and ID
- Switch the focus to a given window

The program is written in C-sharp.
This repository contains the latest binary and the source code (compatible Mono or Microsoft).

## Binaries
The latest binary is available [here](https://github.com/elmanuelito/wmctrl-for-windows/raw/master/_bin/wmctrl.exe)

## Features/ usage
Typical example:
```bash
# Jump to google chrome window
wmctrl -a chrome
```
   
   
Usage:
```bash
wmctrl [options] [args]

options:
  -h         : show this help
  -l         : list windows
  -a <PNAME> : switch to the window of the process name <PNAME>
```


## Compilation
Compile (using Mono or Miscrosoft Visual Studio tools).
You can use the Makefile provided in this repository. 
(You need csc.exe or mcs.exe in your system path)

## Installation
Put the exe file somewhere in your system path.
