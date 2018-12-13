# Unity Editor Toolbag #
The UnityEditorToolBag represents a collection of common attributes that can be helpful in discerning information to other 
game developers and designers you're working with! Its main purpose is to display information within the editor on an 
"on-need" basis, so use it whenver you need it and when things aren't obvious.

## Inspiration ##
After working with many other game developers, often there is a need for us to display certain information to other
members of the team. More often than not, we create custom tools to fit the needs of whomever we're working with, but
some common functionalities exists between multiple projects.

## Quickstart ##
You've got a few ways to get this into your projects. You can:

* Download this repository as a zip file and plug it into your project
* Clone this as a submodule into your project
* UPM (Unity Package Manager, coming soon!)


### Submodule ###
To clone this as a submodule:
```
git submodule add https://github.com/InitialPrefabs/UnityEditorToolBag.git <path-to-local-directory>
```

## Usage ##
The project uses assembly definition files. Why? Well unless the toolbag changes, then you don't really need to
recompile it and assembly definition enforces that.

Plus they help define project dependencies so you as the project/repo owner understand your dependencies. For more
information about assembly definitions in Unity you can read them 
[here](https://docs.unity3d.com/Manual/ScriptCompilationAssemblyDefinitionFiles.html).

Steps:
1. Add the `InitialPrefabs.Attribute` assembly definition file to your own assembly definition as a reference.
2. Use Attribute Tags wherever you like.
