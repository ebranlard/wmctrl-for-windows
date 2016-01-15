# wmctrl-for-windows
Command line implementation of wmctrl for windows (pseudo-equivalent).
Only few features of the linux tool wmctrl are implemented so far, that is:
    - List the window titles, process name and ID
    - Switch the focus to a given window

The program is written in C-sharp.
This repository contains the source code, compatible Mono or Microsoft.

## Features/ usage
        
usage: wmctrl [options] [args]

options:
  -h         : show this help
  -l         : list windows
  -a <PNAME> : switch to the window of the process name <PNAME>



## Installation
Compile.
Put the exe file somewhere in your system path.
