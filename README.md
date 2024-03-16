# UnityUtilities

Some utility scripts for easier work

## Build Version
Import [BuildNumber.cs](https://github.com/Maksibi/UnityUtilities/blob/main/BuildNumber.cs) in CodeBase/Editor folder.
Add [BuildVersionText](https://github.com/Maksibi/UnityUtilities/blob/main/BuildVersionText.cs) script on TMP-Text and put text link to this component. Automatically updates project version in BuildPostProcessor and puts it in text field on scene. Version format is: dd/mm/build number. 

## Clean Script
Import [CleanScript.cs](https://github.com/Maksibi/UnityUtilities/blob/main/CleanScript.cs) in CodeBase/Editor folder.
Now u have Auto/Remove Missing Scripts Recursively in unity toolbar. Select multiple prefabs (in same folder), click Auto/Remove Missing Scripts Recursively, save changes. Done!
