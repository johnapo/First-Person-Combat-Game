# Don't Talk About Fight Club


In a style similar to Call of Duty, Don't Talk About Fight Club combines the round-based survival gamemode of zombies with unique hand-to-hand combat to create a memorable fighting experience. The game takes place when the main character's car unusually breaks down on the side of the road after talking about fight club. People in the nearby town are angry that he would bring such bad energy from muttering the words 'Fight Club' to their originally peaceful town. Survive waves of angry townspeople to win!

Just double-click the executable file in the Game > Build folders to start the game.

#### Developer's Guide to Using GitHub, Git Large File Storage (LFS) with Unity
1. Download and install the following resources, and create an account on GitHub<br />
    - [GitHub Website](https://github.com/)
    - [GitHub Desktop Client Download](https://desktop.github.com/)
    - [Git Version Control System Download](https://git-scm.com/)
    - [Git LFS Download](https://git-lfs.github.com/)

2. Create new repository on GitHub online<br />
  Name your repository. It does not matter whether your repo is public or private, and I would recommend initializing a README file to add      documentation in the future. However, make sure that you add a .gitignore for Unity for compatibility between Unity files and GitHub, then create repository.

3. Open GitHub Desktop Client<br />
  Clone the repository you just created by finding it in your GitHub repositories, selecting a local save destination, and clicking the clone button to confirm.
  
4. Install Git LFS to your repository<br />
  Using your file explorer, open your locally saved repo which should only contain your .gitignore and README.md files. In that folder, right click and select the option _Git Bash Here_. In the Git command line, type prompt, type **git lfs install** and hit enter.

5. Create a .gitattributes file<br />
  With the Git command line still pulled up, type **git lfs track "*.psd"** which starts tracking Photoshop files using Git LFS. We will change these settings later to track more common Unity files like .fbx and .meta. At this point, we did this to autogenerate the .gitattributes file.
  
6. Configure your Unity project<br />
  Whether you created a new project or have an existing project, make sure that its file directory is copied and pasted or created in the  local save of your GitHub repository. For this example, I dragged and dropped my existing Unity project into my local save which for me was C:\Users\MyUser\Documents\GitHub\RepoName. Additionally, open your Unity project and under Edit > Project Settings, make sure that _Force Text_ is enabled under Asset Serialization. This ensures that file names have proper naming conventions for easier saving to the GitHub repo. Exit Unity. Using your file explorer, find the .gitignore file in your repo and drag and drop it it in the first folder containing your Unity project so that GitHub can properly ignore your Unity files. In your file explorer, open your .gitattributes file and insert file types used in your project. I copied and pasted [this .gitattributes file](https://gist.github.com/Srfigie/77b5c15bc5eb61733a74d34d10b3ed87) which has common file types in Unity projects. You may have to add more file types to make your project more compatible with the file types you work with.

7. Commit the changes and push to GitHub<br />
  In the GitHub Desktop client, name your changes in the _Summary Required_ field. Something like "Initial Commit" would work fine. Press the _Commit to **master**_ button and wait until it processes your changes. This may take a while if you have a large Unity project. In future commits, it will not take as long as you will only be pushing new edits, not the entire project. When that has completed, click _Push origin_ to push your local changes to the GitHub cloud.
  
You are successfully uploaded your project to GitHub! **Congratulations!**


### References

**Animations**
All animations used are from [Mixamo](https://www.mixamo.com/#/)
- Bouncing Fight Idle
- Dying
- Getting Up
- Jumping
- Punching
- Running
- Running Backward
- Walking
- Walking Backwards

**Audio**
- [Jab Sound by Mike Koening](http://soundbible.com/995-Jab.html)
- [Police Siren – vlammenos](https://freesound.org/people/vlammenos/sounds/52906/)
- [Runner by Fesliyan Studios](https://www.fesliyanstudios.com/royalty-free-music/download/runner/113)
- [The Epic Boss Fight by Fesliyan Studios](https://www.fesliyanstudios.com/royalty-free-music/download/the-epic-boss-fight/316)

**Images**
- [Controls.jpg by SC2Mapster](https://www.sc2mapster.com/projects/complex-topdown-wasd-movement)
- [Space.jpg by PNGImage](https://pngimage.net/space-button-png-1/)
- [YouDied.jpg by CoolText](https://cooltext.com/Render-Image?RenderID=356685572278273&LogoId=3566855722)

**GameObject / Assets**
- [Ferris Wheel by Brick Project Studio](https://assetstore.unity.com/packages/3d/environments/ferris-wheel-142893)
- [Furnished Cabin by Johnny Kasapi](https://assetstore.unity.com/packages/3d/environments/urban/furnished-cabin-71426)
- [Hand Painted Sand Texture by LowlyPoly](https://assetstore.unity.com/packages/2d/textures-materials/roads/hand-painted-sand-texture-153397)
- [Low Poly Park by Polygon-Park](https://assetstore.unity.com/packages/3d/environments/low-poly-park-154815)
- [Man in a Suit by Studio New Punch](https://assetstore.unity.com/packages/3d/characters/humanoids/man-in-a-suit-51662)
- [Martial Arts Low Poly Free Models Pack by Walter Palladino](https://assetstore.unity.com/packages/3d/characters/humanoids/martial-arts-low-poly-free-models-pack-131893)
- [Simple Cars Pack by MyxerMan](https://assetstore.unity.com/packages/3d/vehicles/land/simple-cars-pack-97669)
- [Simple City pack plain by 255 pixel studios](https://assetstore.unity.com/packages/3d/environments/urban/simple-city-pack-plain-100348)
- [Standard Assets (for Unity 2017.3) by Unity Technologies](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2017-3-32351)
- [Stylized Terrain Texture by LowlyPoly](https://assetstore.unity.com/packages/2d/textures-materials/floors/stylized-terrain-texture-153469)
- [UK Terraced Houses Pack FREE by rik4000](https://assetstore.unity.com/packages/3d/environments/urban/uk-terraced-houses-pack-free-63481)