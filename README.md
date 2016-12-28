# Description

This is a small game created for Maker Faire 2016. The goal was to place QR codes on
Players who would seek each other out. By going to a QR Code for the first time you
could claim it. Each perso to go to your code would get an unlock, but you would also
get unlocks based on how many people snapped your claimed code. There were 250 codes
that we would hand out on business cards and let people wear as badges.

# Files

## GameGenerator.nodejs

This is a simple node script which builds a list of hidden chests consisting of a uuid and a number.

Usage

```
node GameGenerator.nodejs <count> > hidden-chests.csv
```

## ChestToQRCode.nodejs

This script reads in hidden-chests.csv and builds out the QR codes. The URL is currently fixed to the
Maker Faire game so changes will have to be made to repoint the URLs.

Usage

```
node ChestToQRCode.nodejs
```

## MakeMasters.cs/exe

This is a CSharp application that uses GDI+ to merge the Toybox business card with the QR codes. By
changing out template.png we can modify the theming of the game being created. For a simple game,
we can just print the QR codes themselves without the template.

Build

```
csc /t:exe /out:MakeMasters.exe MakeMasters.cs
```

Usage

```
MakeMasters.exe
```

Automatically searches for *.qrcode.png and replaces them with *.sticker.png after applying the template.

Note the template has hard coded offsets and so MakeMasters.cs can't be used as is.