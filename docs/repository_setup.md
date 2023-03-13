# How to use this Repository

This section will show you how to correctly use this Template Repository and get it setup and working

## Setup - VS 2022 

We will be using Visual Studio 2022, as it is the most popularly used IDE

### Step 1 - CLONE

Open up VS 2022 and click on "Clone a Repository"

![image](https://media.discordapp.net/attachments/1020110665161113610/1084641804537827418/image.png?width=1102&height=663)

### Step 2 - Link

In the URL box, copy and paste the URL of this repository, it can be found by clicking on "Code", and then copying the link in the HTTPS section

![image](https://media.discordapp.net/attachments/1020110665161113610/1084641804760133652/image.png?width=966&height=534)

### Step 3 - Preparing the Project

Once you have cloned the repository, it is not ready to start just yet. We have to do 2 things

1. Restore the NuGet Packages in this solution (DSharpPlus)
2. Setting the Token/Prefix of the Bot

To restore the NuGet packages, we hava to simply Build the Solution

To do this, Click on the "Build" tab at the top, and then Build Solution

![image](https://media.discordapp.net/attachments/1020110665161113610/1084643410834640916/image.png?width=568&height=402)

You should see "1 Succeeded" in the output like this
![image](https://media.discordapp.net/attachments/1020110665161113610/1084643742306283560/image.png?width=1370&height=212)

Once that is finished, it will generate a /bin folder for us, which will contain the application we are running when we hit start

In this folder, we must place in our config.json file which contains our Token & Prefix

First start by setting the Token & Prefix of your bot in the config.json file like this and save the file
![image](https://media.discordapp.net/attachments/1020110665161113610/1084644674330959993/image.png?width=1431&height=263)

Then, open up your whole project in your File Manager by Right-Clicking on your project name and clicking "Open Folder in File Explorer"
![image](https://media.discordapp.net/attachments/1020110665161113610/1084644674591010826/image.png?width=353&height=663)

You will see a folder called "bin", open this folder and open the "Debug" folder. This is where you need to copy the config.json file to
![image](https://media.discordapp.net/attachments/1020110665161113610/1084644674825900052/image.png?width=977&height=625)

### NOTE FOR GITHUB USERS

If you push this to your own repository, bear in mind, Discord will automatically detect that your Bot token has been published online and it will 
reset your Token

So in order to keep your Bot running, all you need to do is change the config.json in your /bin/Debug folder
and NOT the one in your solution

### config.json in /bin/Debug

![image](https://media.discordapp.net/attachments/1020110665161113610/1084646160448372776/image.png?width=1284&height=141)
This should contain your actual token

### config.json in Solution
![image](https://media.discordapp.net/attachments/1020110665161113610/1084646160674861136/image.png?width=392&height=147)
When you make a commit and push it to the repository, doing this will prevent Discord from auto-resetting your token again

You should never commit your /bin/Debug folders when you push to the repository as they contain your actual application

### Step 4 - Starting up the Bot

Once you have Restored the Packages and setup the config.json file with your own Token & Prefix, you are 
ready to go

Start the application up and you should have a nice console window with your Bot

![image](https://media.discordapp.net/attachments/1020110665161113610/1084647592358584401/image.png?width=1311&height=663)