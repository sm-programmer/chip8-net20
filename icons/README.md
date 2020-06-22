Using icons in the program
==========================

These icons had previously been imported as resources for the frame "FrmMain" in project "UI-WinForms". Therefore, the actual files in this directory are not used directly.

In order to apply any modifications to these icons, after doing the modification, reimport them to the resource file "Icons.resx". Keep the original names in order not to break any references.

When adding a new icon, use a 32-by-32 pixel PNG file. Transparency is encouraged. After creating the icon, import it to the resource file "Icons.resx", and when using it (e.g. when adding an image to a new button in the toolbar), select from "Icons.resx" the added resource.

Please, do not import icons directly as bitmaps without using "Icons.resx"!
Using a separate resource file keeps everything organized and avoids resource duplication.

Thank you!
