[![Download count](https://img.shields.io/github/downloads/enriquesomolinos/pkgripper/total.svg)](https://github.com/enriquesomolinos/pkgripper/releases)

# PKG Ripper

`PKGRipper` allows you to remove contents from your own backups of PS4 games (Pkg files).
One important thing is PkgRipper use patches. This files contains the files that are not necesary in the pkg file and can be trimmer to zero bytes without problems  **SAVING HDD SPACE!! (F1 2020 drops more than 20GB)**  . 
The program detects the patch file that can be applied directly and gives you the oportunity to select what patch you want to apply. Think that one patch file can contain several patches due to the updates that this game can have.
For example: a game with a base version 01.00 and to updates 01.01, 01.02 can have 4 different patches.
- One for the pkg 01.00 for removing duplicated content from the version 01.01
- One for the pkg 01.00 for removing duplicated content from the version 01.02
- One for the update pkg 01.01 for removing duplicated content from the version 01.02
- One for the update pkg 01.02 for removing content from the version 01.02

For this reason the program will always asks the user to say wich is the update you have.
To see how to create these patches go https://github.com/enriquesomolinos/pkgripper-patches


## Requirements
 - Windows machine
 - .Net Framework
 - Fake PKG Tools: can be downloaded from  https://github.com/CyB1K/PS4-Fake-PKG-Tools-3.87. Gengp4 and orbis-pub-cmd files must be in the same folder of PkgRipper.
 - Your custom patches to apply: if you don't want to do this patches you can download from https://github.com/enriquesomolinos/pkgripper-patches and put them under the patches folder.

## Structure
- Output folder: repackaged backups will be stored here
- temp folder: temporal folder to extract and modify pkgs
- patches folder: contains all patches that can be applied

## Usage Example
**Depending on the size of your files PkgRipper can take a lot of time!!**
- If you want to patch a base fpkg file you can follow this video: https://youtu.be/-M4qvpxHKqc
- If you want to patch an update fpkg file you can follow this video: https://youtu.be/boaHX81oSUU

**In case you apply a patch to your base pkg you'll need to repackage the update to link with the new base.pkg**, this can be done with PkgRipper applying a fake patch (see transformers patch).

## Recomendation
- **Use only with your own backups, we don't support piracy.**
- Use at your own risk, test always the output PKG, we don't asure perfect results

## Donations
Donations are apreciated, click the sponsor button to it or donate via PayPal https://paypal.me/esomolinos?locale.x=es_ES



