# MvvmCross and AppCompat Toolbar

This repo is supporting code for the blog post at:

https://www.majormojo.co.uk/blog/mvvmcross-and-appcompat-toolbar.html

The six branches show the progress if implementing a quick return toolbar for an Android application writtin in Xamarin with MvvmCross:

* __1-before-appcompat__ - starting out with Holo Light theme and no AppCompat
* __2-appcompat-darkactionbar__ - add AppCompat and change the theme to automatically show the toolbar
* __3-mvxappcompatactivity__ - hack MvvmCross so that it shows the AppCompat toolbar
* __4-toolbar-include__ - remove the toolbar from the theme and add it to the layouts
* __5-upgrade-mvvmcross__ - upgrade MvvmCross to v4 so as to fix styling issue
* __master__ - implement the quick return toolbar
