# CS-330-Assignment-5

Caleb VongPhit

200367739

Implementing a file I/O system in Cosmos using C#
      -Not much of a challenge but I don't know what else to do. I just need pity marks :((


The following text will be instructions in how to replicate this project step by step.

1. Materials//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
    First we need to download everything. Here are the links that I used to download the resources.
    
    Visual Studio 2019                 https://visualstudio.microsoft.com/vs/ 
    
    Cosmos user kit v20190628          https://github.com/CosmosOS/Cosmos/releases/tag/Userkit_20190628 
    
    VMWare 15.5                        https://www.vmware.com/ca/products/workstation-player/workstation-player-evaluation.html
    
    The workloads you need to have installed on Visual studio 2019 is the .NET desktop development kit. And as instructed in downloading the Cosmos user kit, make sure to have the .NET Framework 4.6.2 development tools downloaded as well. If you are not sure you have these downloaded, you can check by going into your Visual Studio Installer and click on the "Modify" option for Visual Studio 2019. If you don't remember how to access the Installer, an alternative measure to open it is to go to "Create a new project." If you scroll all the way down, a message stating "Not finding what you're looking for?" will direct you to the Installer page.
    
2. Creating the project///////////////////////////////////////////////////////////////////////////////////////////////////////////////

  If you downloaded the Cosmos user kit, 3 project templates named "Cosmos Template" should appear. We will be using the C# Cosmos kernel. For some reason my C# is seperated from the other two. Just search Cosmos using the search for templates if you can't find it. 
  
  If you don't see the projects templates at all make sure you downloaded the same versions I posted above. When I tried downloading versions for Visual studio 2013, and 2015, with the respective Cosmos files, I didn't see the templates either. The versions for 2019 worked for me and this is why we will be using them for this project.
  
 This is what it should look like when you follow these steps: https://www.gocosmos.org/docs/develop-your-own-os-in-dotnet/
  
3. Replicating The project////////////////////////////////////////////////////////////////////////////////////////////////////////////

  Since we are going to be working with File I/O operations and directories, we will need to be added the following line of code:
  
    using System.IO;
    
  This will provide us with the necessary libraries that will give us access to implementing I/O operations as well as directory management.
    

    
       
    
    
