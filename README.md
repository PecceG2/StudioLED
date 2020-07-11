[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<br />
<p align="center">
  <a href="https://github.com/PecceG2/StudioLED">
    <img src="https://pecceg2.github.io/StudioLED/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">StudioLED</h3>

  <p align="center">
    StudioLED is a RGB LED strip controller via COM designed for recording and streaming
    <br />
    <a href="https://github.com/PecceG2/"><strong>View all my projects »</strong></a>
    <br />
    <br />
    <a href="https://github.com/PecceG2/StudioLED/issues">Report Bug</a>
    ·
    <a href="https://github.com/PecceG2/StudioLED/blob/master/LICENSE.md">View License</a>
    ·
    <a href="https://github.com/PecceG2/StudioLED/issues">Request Feature</a>
  </p>
</p>

## Screenshots ##
![Screenshot](https://pecceg2.github.io/StudioLED/desktop_preview.jpg)

## Building

The [StudioLED](https://github.com/PecceG2/StudioLED) repository provides a **compiled exe** for Windows to quick-start your controller. You only need build the hardware:

#### Materials
- Any Arduino (Pro Micro used in this case)
- x3 Mosfet [IRF540N](https://media.digikey.com/pdf/Data%20Sheets/Fairchild%20PDFs/IRF540N.pdf)
- x3 10kΩ Resistor
- x3 1.1kΩ Resistor
- 12v 1A Power Supply
- RGB led strip

#### Electronic diagram
![electronic_diagram](https://pecceg2.github.io/StudioLED/diagram.jpg)

#### Soldering
![board](https://pecceg2.github.io/StudioLED/board.jpg)

#### Upload code to Arduino
1. Connect your Arduino vía USB to your computer.
2. Download this repository
3. Open hardware_controller\hardware_controller.ino with Arduino IDE [(Download from here)](https://www.arduino.cc/en/main/software)
4. Select Arduino on Tools menu (model & port)
5. Click on arrow (Upload)!

#### Making led strip light
The lamp is based on 5050 led strips connected in parallel, adhered on a wooden board.<br />
I really recommend add ligth diffusor.

![led_strip](https://pecceg2.github.io/StudioLED/led_strip.jpg)

Finished led lamp with diffusor:

![led_strip_with_diffusor](https://pecceg2.github.io/StudioLED/led_strip_diffusor.jpg)

## Running
Connect 12v power supply to lamp and USB cable to your PC.<br />
Open StudioLED.exe located on "windows_software\Compiled\Portable".<br />
Refresh COM devices with "Update Devices" button and select your light COM port.<br />
Change the colors! :)


## License
>You can check out the full license [here](https://github.com/PecceG2/StudioLED/blob/master/LICENSE.md)

This project is licensed under the terms of the **MIT** license.

[contributors-shield]: https://img.shields.io/github/contributors/PecceG2/StudioLED.svg?style=flat-square
[contributors-url]: https://github.com/PecceG2/StudioLED/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/PecceG2/StudioLED.svg?style=flat-square
[forks-url]: https://github.com/PecceG2/StudioLED/network/members
[stars-shield]: https://img.shields.io/github/stars/PecceG2/StudioLED.svg?style=flat-square
[stars-url]: https://github.com/PecceG2/StudioLED/stargazers
[issues-shield]: https://img.shields.io/github/issues/PecceG2/StudioLED.svg?style=flat-square
[issues-url]: https://github.com/PecceG2/StudioLED/issues
[license-shield]: https://img.shields.io/github/license/PecceG2/StudioLED.svg?style=flat-square
[license-url]: https://github.com/PecceG2/StudioLED/blob/master/LICENSE.md