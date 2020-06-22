Adding fonts to the emulator
============================

All CHIP-8 binary files placed here will be automatically copied during the project's build phase, to make them available to the emulator when run.

To add a new font, please add a properly formatted file here that follows this structure:

1. The new font is treated as a binary file (sequence of bytes).
2. The new font must have a `ch8` extension, *in lowercase*.
3. The new font must include exactly 16 glyphs.
4. Each glyph must occupy exactly 5 bytes, starting from the top row and going downward.
5. Each glyph is a 4-by-5 monochrome image, with data starting in the most significant bit, as follows:

       Repr.       Values
    ┏━━━━━━━━┓
    ┃▒▒▒▒    ┃    11110000
    ┃▒  ▒    ┃    10010000
    ┃▒▒▒▒    ┃    11110000
    ┃▒  ▒    ┃    10010000
    ┃▒  ▒    ┃    10010000
    ┗━━━━━━━━┛

6. As seen above, a lit up bit is represented by a `1`, `0` otherwise.
7. Symbols provided should be:
    * Numbers 0 to 9.
    * Letters A to F.

To add the font as a predefined choice, add a new item to the "Fonts" submenu, with a `Tag` equal to the following path:

    fonts\<the-name-of-your-font>.ch8
