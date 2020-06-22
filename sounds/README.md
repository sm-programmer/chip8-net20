Adding sounds to the emulator
=============================

All WAV files in this folder are automatically copied during the project's build phase, so that they are available when the emulator is run.

To add a new WAV file to the project, please put it here. Recommended content is one second of a constant tone at a certain frequency.

To make the addition a predefined choice, add a new item to the "Buzzer" submenu, with a `Tag` equal to the following path:

    sounds\<the-name-of-your-file>.wav

**Important!** The extension of the new file must be `wav` *in lowercase*.
