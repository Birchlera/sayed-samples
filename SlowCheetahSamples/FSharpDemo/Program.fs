﻿// A simple application to create the config and show results in the console
let settingOne = System.Configuration.ConfigurationManager.AppSettings.["settingOne"];
let settingTwo = System.Configuration.ConfigurationManager.AppSettings.["settingTwo"];
let settingthree = System.Configuration.ConfigurationManager.AppSettings.["settingThree"];


printfn "settingOne: %s" settingOne
printfn "settingTwo: %s" settingTwo
printfn "settingThree: %s" settingthree

printfn " "
printfn "Press any key to close"
System.Console.ReadKey(true)