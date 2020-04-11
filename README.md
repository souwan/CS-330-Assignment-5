# CS-330-Assignment-5

Caleb VongPhit

200367739

Implementing a directory and file I/O system in Cosmos using C#

The following text will be instructions in how to replicate this project step by step.

1. Materials//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
    First we need to download everything. Here are the links that I used to download the resources.
    
    Visual Studio 2019                 https://visualstudio.microsoft.com/vs/ 
    
    Cosmos user kit v20190628          https://github.com/CosmosOS/Cosmos/releases/tag/Userkit_20190628 
    
    VMWare 15.5                        https://www.vmware.com/ca/products/workstation-player/workstation-player-evaluation.html
    
    The workloads you need to have installed on Visual studio 2019 is the .NET desktop development kit. And as instructed in downloading the Cosmos user kit, make sure to have the .NET Framework 4.6.2 development tools downloaded as well. If you are not sure you have these downloaded, you can check by going into your Visual Studio Installer and click on the "Modify" option for Visual Studio 2019. If you don't remember how to access the Installer, an alternative measure to open it is to go to "Create a new project." If you scroll all the way down, a message stating "Not finding what you're looking for?" will direct you to the Installer page.
    
    You shouldn't need to touch the VMWare directly for this project. Running the Cosmos code, even the default, will automatically open up VMWare and execute the code. Any errors will simply give you an error prompt or automatically shut down VMware. 
    
2. Creating the project///////////////////////////////////////////////////////////////////////////////////////////////////////////////

  If you downloaded the Cosmos user kit, 3 project templates named "Cosmos Template" should appear. We will be using the C# Cosmos kernel. For some reason my C# is seperated from the other two. Just search Cosmos using the search for templates if you can't find it. 
  
  If you don't see the projects templates at all make sure you downloaded the same versions I posted above. When I tried downloading versions for Visual studio 2013, and 2015, with the respective Cosmos files, I didn't see the templates either. The versions for 2019 worked for me and this is why we will be using them for this project.
  
 This is what it should look like when you follow these steps: https://www.gocosmos.org/docs/develop-your-own-os-in-dotnet/
  
3. Replicating The project////////////////////////////////////////////////////////////////////////////////////////////////////////////

To allow Cosmos to use a FAT file system similar to how windows operates, we are going to need to initialize the virtual disk space. Follow this links instructions: https://csos-guide-to-cosmos.fandom.com/wiki/Making_our_OS_-_Filesystem

The rest of the project isn't too complicated but it definately took me a long time to figure out how to use the FAT system let alone finding it and out how to implement it into Cosmos. If you want to try and do the rest yourself from scratch, here's a link to the microsost documentation for .NET I/O functions: https://docs.microsoft.com/en-us/dotnet/api/system.io?view=netframework-4.6.2

If you want to follow along my train of thought for my code, please read the following. Keep in mind there is most likely a better way to implement this type of file system, but god knows no one is sharing that pubicly. Not that I found anyways, would have saved me ~15 hours trying to figure out how Cosmos works.

The aproach I took was to make it act similarly to standard terminal commands. To be able to type and for the system to seperate the string into seperate strings, so that I could determine what the command is and what the path(s) are, I created a string to save the ReadLine and then created a string[] that took the string and used the Split method to seperate them. This allowed me to create a switch case where string[0] was the command and would be the cases I would be looking for. Example switch(string[0])... case "ls": ... This would technically allow the user to type whatever they wanted after satisfying the commands required amount of strings, intended or not. But also allow me to check the additional string for commands that require additional information, such as "cd directory" or "copy file1 file2" by checking string[1] or string[2].

Implementing the basic shell commands is fairly self explanatory, all you need to do is look at the documentation on the microsoft website for the functions that you want to make. The only obstacle, that took me some time to figure out, was to make sure the directory paths were correct. 

The code in Kernel.cs (attached in the github) should work fine so long as you have the Cosmos project template. Copy the code in your Cosmos project template and see the basic commands work with your own eyes! Thanks for following along my project and I hope you enjoy the rest of your day!
       
    
    
