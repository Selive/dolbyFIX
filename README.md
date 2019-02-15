# dolbyFIX v0.1

## Русский

### Описание
Есть такая проблена на ноутбуках с Dolby Digital Plus, что драйвер отключается сам (в играх, при работе с микрофоном и т.д.) и естественно звук становися тихим и менее качественным.
Суть данной программы в том, что она следит за драйвером и влючает его при непроизвольном отключении.

### Установка
Исполняемый файл `DolbyFIX.exe` переместить в папку с драйвером Dolby Digital Plus и запустить.
Для удобста можно сделать `.vbs` скрипт для запуска в фоне и поместить его в авто загрузку.

```vbs
Set WshShell = CreateObject("WScript.Shell")
WshShell.Run "DolbyFIX.exe", 0, false
```

## English

### Description
There is such a problem on laptops with Dolby Digital Plus, that the driver turns itself off (in games, when working with a microphone, etc.) and naturally the sound becomes quiet and less quality.
The essence of this program is that it monitors the driver and turns it on when it is accidentally turned off.

### Installation
Move the executable `DolbyFIX.exe` to the folder with the Dolby Digital Plus driver and run it.
For convenience, you can make a `.vbs` script to run in the background and place it in the auto download.

```vbs
Set WshShell = CreateObject("WScript.Shell")
WshShell.Run "DolbyFIX.exe", 0, false
```