# How to use this Repository

## This section will show you how to correctly use this Template Repository and get it setup and working

## Step 1 - Copying the Template

This Repository is a template repository, so this allows you to copy over the existing files in this repository to your own

- First start by clicking on **"Use this Template" -> "Create a new repository"**
- This is gonna allow you to copy over the contents of this template to your own repository/

<p align="center">
    <img src="https://user-images.githubusercontent.com/98812930/224717857-749edc9e-57d7-49d3-bbc1-cacc5f963fe5.png" style="border:5px solid green" />
</p>

## Step 2 - Make your repository

- Assign youself as the owner of this repository and give it a name & description

<p align="center">
    <img src="https://user-images.githubusercontent.com/98812930/224718114-05016496-6dbb-48c7-8507-129f8390af18.png" style="border:5px solid green" />
</p>

## Step 3 - Clone

- Open up VS 2022 or any other IDE and clone your newly created repository so we can start coding in it

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084641804537827418/image.png?width=1102&height=663" style="border:5px solid green" />
</p>

## Step 4 - Link

- In the URL box, copy and paste the URL of your repository, it can be found by clicking on **"Code"**, and then copying the link in the **HTTPS** section

- You can alternatively sign-in to GitHub on VS 2022 and select your repository

<p align="center">
    <img src="https://user-images.githubusercontent.com/98812930/224719890-d155eaa0-c8f8-4465-9acf-c96b798221e7.png" style="border:5px solid green" />
</p>

## Step 5 - Preparing the Project

Once you have cloned the repository, it is not ready to start just yet. We have to do 2 things

1. **Restore the NuGet Packages in this solution (DSharpPlus)**
2. **Setting the Token/Prefix of the Bot**

### Restoring the NuGet Packages

- To restore the NuGet packages, we have to simply **"Build"** the Solution

- To do this, click on the **"Build"** tab at the top, and then **"Build Solution"**

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084643410834640916/image.png?width=568&height=402" style="border:5px solid green" />
</p>

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084643742306283560/image.png?width=1370&height=212" style="border:5px solid green" />
</p>

*You should see "1 Succeeded" in the output like this*

- Once that is finished, it will generate a **/bin** folder for us in your solution folder, which will contain the application we are running when we hit **"Start" (YourSolution.exe)**.

- This **.exe** file is your actual console application

- In this folder, we must place in our **config.json** file which will contain our **Token & Prefix**

### The config.json file

- First start by setting the Token & Prefix of your bot in the **config.json** file like this and save the file

- You can get the token of your Bot using the **Discord Developer Portal** in the **Bot** section of your application

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084644674330959993/image.png?width=1431&height=263" style="border:5px solid green" />
</p>

- Then, open up your whole project in your File Manager by Right-Clicking on your project name and clicking **"Open Folder in File Explorer"**

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084644674591010826/image.png?width=353&height=663" style="border:5px solid green" />
</p>

- You will see a folder called **"bin"**, open this folder and open the **"Debug"** folder. This is where you need to copy the config.json file to

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084644674825900052/image.png?width=977&height=625" style="border:5px solid green" />
</p>

### NOTE: WHEN PUSHING CHANGES TO YOUR REPO

- If you push this to your own repository, bear in mind, Discord will automatically detect that your Bot token has been published online and it will 
reset your Token

- So in order to keep your Bot running or if you need to change the token, all you need to do is ***change the config.json file in your /bin/Debug folder
and NOT the one in your solution***

### config.json in /bin/Debug

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084646160448372776/image.png?width=1284&height=141" style="border:5px solid green" />
</p>

*This should contain your actual token*

### config.json in Solution

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084646160674861136/image.png?width=392&height=147" style="border:5px solid green" />
</p>

- When you make a commit and push it to the repository, doing this will prevent Discord from auto-resetting your token again
- You should never commit your **/bin/Debug** folders when you push to the repository as they contain your actual application
- The **gitignore** should avoid this automatically for you so you don't have to worry about this

## Final Step - Starting up the Bot

- Once you have Restored the Packages and setup the config.json file with your own Token & Prefix, you are 
ready to go

- Start the application up and you should have a nice console window with your Bot

<p align="center">
    <img src="https://media.discordapp.net/attachments/1020110665161113610/1084647592358584401/image.png?width=1311&height=663" style="border:5px solid green" />
</p>

# Help & Support

If you need extra help with this Bot then here are some recommended support links

- **Join the Discord Server** | [samjesus8 Official Server](https://discord.com/invite/GrcaGNSfCR)
- **Join the Official DSharpPlus Server** | [DSharpPlus Official Server](https://discord.com/invite/dsharpplus)
