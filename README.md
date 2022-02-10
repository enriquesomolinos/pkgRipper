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

## How to use
[PhR34x0r](https://github.com/PhR34x0r) has shared a great manual to know how to use pkgripper: https://github.com/enriquesomolinos/pkgRipper/raw/master/PKGRipper.Manual.pdf

This video can help you:https://youtu.be/Mu0N7axnWpg

## Current patches
| Game                                 	| Base pkg orig. size 	| Base pkg with pkgripper 	| Update pkg orig. size 	| Update pkg with pkgripper 	|
|--------------------------------------	|---------------------	|-------------------------	|-----------------------	|---------------------------	|
| EP1003-CUSA02092_00-DOOMEUROPEROWSKU 	| 45.9 GB             	| 28.5 GB                 	| 29 GB                 	| 24.8 GB                   	|
| EP3678-CUSA17580_00-TRANSFOBASEGAME0 	| 3.2 GB              	| 2.1 GB                  	| 0.7 GB                	| 0.7 GB                    	|
| EP4001-CUSA16283_00-F12020EMASTER000 	| 34.85 GB            	| 17.8 GB                 	| 18.5 GB               	| 15.5 GB                   	|
| EP9000-CUSA12982_00-MEDIEVILHD000001 	| 20 GB               	| 8.0 GB                  	| 16 GB                 	| 16 GB                     	|
| UP0777-CUSA27897_00-MSGNASCAR21XXXXX 	| 10.7 GB             	| 0.5                     	| 11.5 GB               	| 11.1                      	|
| EP2037-CUSA25234_00-DKALLIANCE01EURO 	| 19.7 GB              | 1.2 GB                   | 23.0 GB                | 23.0 GB                      	|
| EP6665-CUSA27790_00-WRC10SIEE0000000 	| 25.3 GB              | 17.0 GB                  | 12.5 GB                | 11.4 GB                      	|
| EP1003-CUSA05486_00-SKYRIMHDFULLGAME 	| 31.1 GB               | 12.4 GB                   |  2.8 GB                  	|  2.8 GB                      	|
| EP4291-CUSA18673_00-CRYSIS3REMASTERE 	| 10.0 GB               |  6.4 GB                   |  1.8 GB                  	|  6.4 GB                      	|
| EP0001-CUSA15778_00-FARCRY6GAME00000 	| 34.8 GB               | 0.2 GB                    |  59.3 GB                  	| 46.6 GB                      	|
| EP9000-CUSA01715_00-0000GODOFWAR3PS4 	| 40.0 GB               | 0.1 GB                    | 37.0 GB                  	|  0.1 GB                      	|


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





