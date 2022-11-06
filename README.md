# PIV_miniproject
My miniproject for the course: Programming of interactive 3D worlds.  
Project Name: Wipe Out, but worse and online  
Name: Frederik Roland Christiansen  
Student Number: 20213480  
Link to Project: https://github.com/pR0land/PIV_miniproject  
## Overview of the project:
The idea of the project is to simulate the Wipe Out experience from the comfort of your chair at home. Wipe Out is an obstacle course, where the goal is to navigate the course and get to the end platform without falling or getting pushed of by any of the obstacles. The player controls a capsule in 1st person and can look and move around using the mouse and keyboard.   
The main parts of the game are:  
* Player - a capsule with a camera attached, can be rotaded with the mouse and moved with WASD or the arrow keys. You are also able to tilt the camera up and down with the mouse to lookabove and belov you.
* The Course - a series of platforms the player can jump to
* The Rotating obstacle - a rotating propeller made by 3 capsules and a cylinder 
* The Sideswipping obstacle - a big cube moving from side to side
* The Bouncing Ball - a sphere with a bouncy physics material
* The Endzone - the platform the player needs to get to, to complete the course  
## Project Parts:
* Scripts:  
  * CameraBehavior - Used to tilt the camera op and down using the mouses x-coordinates inverted. Since when you move the mouse down, the value goes down, but you want the angle of the tilt to go up. The coursor is also hidden, making the 3D experience more immersive 
  * PlayerController - Used to rotate the player with mouse coordinates and move the playerbody using wasd or arrowkeys and space to jump when the player is grounded (colliding with a hitbox tagged ground) 
  * ObstacleController - Used to control all the obstacles with coroutines. All the obstacles needs to be children of the obstacle controller object, it will then loop through them and start the appropriate coroutine based on object names. 
  * GameController - Used to display the score ones you reach the end zone  
  * EndGoalScript - Used to register when you hit the end zone  
  * Water - Used to register if the player hits the water and restart the game if so  
* Models and Prefabs:  
  * All models and prefabs are build using unity primitives, they are made so you can easily make more and larger levels
* Materials: 
  * Basic unitymaterials used to color the different objects in the scene
  * One physicsmaterial used to make the bouncingball bouncy. 
* Scenes:
  * The game consists of one scene
* Testing:
  * The game was tested on windows, with the small bug that you can sometimes glitch through the side swiping objects
## Time Management:
|Task   |Time it Took (in hours)|
|-------| ----:|
|Setting up the project in Unity and on Github| 0.5 |
|Brainstorming ideas and obstacles| 0.5 |
|Programming player movement| 1 |
|Testing player movement | 0.5 |
|Building prefabs (especially bouncing ball)| 1 |
|Testing prefabs (especially bouncing ball)| 1 |
|Programming obstacle controlls | 1.5 |
|Testing Obstacle controlls | 0.5 |
|Building level | 0.5 |
|Testing level | 0.5 |
|Trying to bugfix incorrect collision | 2 |
|Programming losing and winning | 0.75 |
|Testing losing and winning | 0.5 |
|Making Readme | 1.5 |
|Total Time used | 12,25 |
## Resourcers used
* Unity In Action Multiplatform game development in C# Second Edition (Book) By Joseph Hocking
* Unity Documentation - https://docs.unity3d.com/Manual/index.html
* Markdown Cheatsheet By Adam Pritchard - https://github.com/adam-p/markdown-here/wiki/Markdown-Here-Cheatsheet
